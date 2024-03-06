Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Form1
    'Connection to the database'
    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb ; convert zero datetime=True"
    Dim con As New MySqlConnection(str)
    Dim i As Integer
    Dim dr As MySqlDataReader


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView_load()
        hidebutton()

        NotifPanel.Visible = False ' Ensure the notification panel is hidden initially

        ' Call the method to check and update the stock status
        UpdateStockStatus()

        ' Set up the timer to refresh stock status every 5 seconds (adjust as needed)
        StockStatusTimer.Interval = 1000 ' 5 seconds
        StockStatusTimer.Start()
    End Sub

    'Data Viewing'
    Public Sub DataGridView_load()
        DataGridView1.Rows.Clear()

        Try
            con.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_officesupply", con)
            dr = cmd.ExecuteReader
            While dr.Read
                'Format the DatePurchase for without time format'
                Dim datePurchaseFormatted As String = If(dr.IsDBNull(dr.GetOrdinal("DatePurchase")), "", CDate(dr.Item("DatePurchase")).ToString("yyyy-MM-dd"))

                ' Get the value in the Item Stock'
                Dim itemStock As Integer
                If Not Integer.TryParse(dr.Item("ItemStock").ToString(), itemStock) Then
                    Continue While
                End If

                ' Create a new row and add it to the DataGridView'
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(DataGridView1, dr.Item("ItemNumber"), dr.Item("ItemName"), dr.Item("ItemStock"), dr.Item("ItemUnit"), dr.Item("ItemStatus"), datePurchaseFormatted, dr.Item("ItemAmount"), dr.Item("ReorderPoint"))

                DataGridView1.Rows.Add(newRow)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    'Add Item and Data Viewing'
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If Validation() Then
            add()
            DataGridView_load()
        Else
            MessageBox.Show("Please Complete all the fields!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'For Field Validation in completing all the attributes'
    Private Function Validation() As Boolean
        If String.IsNullOrWhiteSpace(txt_itemno.Text) OrElse
           String.IsNullOrWhiteSpace(txt_itemname.Text) OrElse
           String.IsNullOrWhiteSpace(txt_itemstock.Text) OrElse
           String.IsNullOrWhiteSpace(combo_itemunit.Text) OrElse
           String.IsNullOrWhiteSpace(combo_itemstat.Text) OrElse
           String.IsNullOrWhiteSpace(purchase_date.Value) OrElse
           String.IsNullOrWhiteSpace(txt_amount.Text) OrElse
           String.IsNullOrWhiteSpace(txt_reorder.Text) Then
            Return False
        End If

        Return True
    End Function

    'Adding / Inserting Item'
    Public Sub add()
        Try
            con.Open()

            ' Check if there are any duplication of item number in the database '
            Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM tbl_officesupply WHERE ItemNumber = @ItemNumber", con)
            checkCmd.Parameters.AddWithValue("@ItemNumber", txt_itemno.Text)
            Dim count As Integer = CInt(checkCmd.ExecuteScalar())

            If count > 0 Then
                ' if the item number already exist it will display this message'
                MessageBox.Show("Item number is already existed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ' It will continue to add the item'
                Dim insertCmd As New MySqlCommand("INSERT INTO `tbl_officesupply`(`ItemNumber`, `ItemName`, `ItemStock`, `ItemUnit`, `ItemStatus`, `DatePurchase`, `ItemAmount`, `ReorderPoint`) VALUES (@ItemNumber, @ItemName, @ItemStock, @ItemUnit, @ItemStatus, @DatePurchase, @ItemAmount, @ReorderPoint)", con)
                insertCmd.Parameters.AddWithValue("@ItemNumber", txt_itemno.Text)
                insertCmd.Parameters.AddWithValue("@ItemName", txt_itemname.Text)
                insertCmd.Parameters.AddWithValue("@ItemStock", txt_itemstock.Text)
                insertCmd.Parameters.AddWithValue("@ItemUnit", combo_itemunit.Text)
                insertCmd.Parameters.AddWithValue("@ItemStatus", combo_itemstat.Text)
                insertCmd.Parameters.AddWithValue("@DatePurchase", CDate(purchase_date.Value))
                insertCmd.Parameters.AddWithValue("@ItemAmount", txt_amount.Text)
                insertCmd.Parameters.AddWithValue("@ReorderPoint", txt_reorder.Text)
                i = insertCmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Item successfully added", "NUFV-AMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Item has not been recorded!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        clearform()

    End Sub

    'Clearing the content of the text boxes'
    Public Sub clearform()
        txt_itemno.Clear()
        txt_itemname.Clear()
        txt_itemstock.Clear()
        combo_itemunit.Text = ""
        combo_itemstat.Text = ""
        purchase_date.Value = Now
        txt_amount.Clear()
        txt_reorder.Clear()

    End Sub

    'Getting the data to the textboxes'
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txt_itemno.Text = DataGridView1.CurrentRow.Cells(0).Value
        txt_itemname.Text = DataGridView1.CurrentRow.Cells(1).Value
        txt_itemstock.Text = DataGridView1.CurrentRow.Cells(2).Value
        combo_itemunit.Text = DataGridView1.CurrentRow.Cells(3).Value
        combo_itemstat.Text = DataGridView1.CurrentRow.Cells(4).Value
        purchase_date.Value = DateTime.Parse(DataGridView1.CurrentRow.Cells(5).Value.ToString())
        txt_amount.Text = DataGridView1.CurrentRow.Cells(6).Value
        txt_reorder.Text = DataGridView1.CurrentRow.Cells(7).Value
    End Sub


    'Update Button with validation before updating'
    Sub UpdateItem()

        If DataChanges() Then
            If Validation() Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this item?", "NUFV-AMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Try
                        con.Open()
                        Dim cmd As New MySqlCommand("UPDATE `tbl_officesupply` SET `ItemName`=@ItemName,`ItemStock`=@ItemStock,`ItemUnit`=@ItemUnit,`ItemStatus`=@ItemStatus,`DatePurchase`=@DatePurchase,`ItemAmount`=@ItemAmount, `ReorderPoint`=@ReorderPoint WHERE  `ItemNumber`=@ItemNumber", con)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@ItemNumber", txt_itemno.Text)
                        cmd.Parameters.AddWithValue("@ItemName", txt_itemname.Text)
                        cmd.Parameters.AddWithValue("@ItemStock", txt_itemstock.Text)
                        cmd.Parameters.AddWithValue("@ItemUnit", combo_itemunit.Text)
                        cmd.Parameters.AddWithValue("@ItemStatus", combo_itemstat.Text)
                        cmd.Parameters.AddWithValue("@DatePurchase", CDate(purchase_date.Value))
                        cmd.Parameters.AddWithValue("@ItemAmount", txt_amount.Text)
                        cmd.Parameters.AddWithValue("@ReorderPoint", txt_reorder.Text)

                        i = cmd.ExecuteNonQuery
                        If i > 0 Then
                            MessageBox.Show("Item successfully updated", "NUFV-AMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Item update record failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        con.Close()
                    End Try
                    clearform()
                    DataGridView_load()
                End If
            Else
                MessageBox.Show("Please select an item to update", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("No changes attempt", "NUFV-AMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Function DataChanges() As Boolean
        'check if any text boxes has been changed'
        If txt_itemname.Text <> DataGridView1.CurrentRow.Cells(1).Value.ToString() OrElse
           txt_itemstock.Text <> DataGridView1.CurrentRow.Cells(2).Value.ToString() OrElse
           combo_itemunit.Text <> DataGridView1.CurrentRow.Cells(3).Value.ToString() OrElse
           combo_itemstat.Text <> DataGridView1.CurrentRow.Cells(4).Value.ToString() OrElse
           purchase_date.Value <> DateTime.Parse(DataGridView1.CurrentRow.Cells(5).Value.ToString()) OrElse
           txt_amount.Text <> DataGridView1.CurrentRow.Cells(6).Value.ToString() OrElse
           txt_reorder.Text <> DataGridView1.CurrentRow.Cells(7).Value.ToString() Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btn_upd_Click(sender As Object, e As EventArgs) Handles btn_upd.Click
        UpdateItem()
        UpdateStockStatussample()
        UpdateStockStatus()
    End Sub

    'ARCHIVE'
    Public Sub archive()
        Try
            'Validation: Check if an item is selected
            If DataGridView1.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select an item to archive.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            'Confirmation: Ask for confirmation before archiving
            If MessageBox.Show("Are you sure you want to archive this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim selectedItemNumber As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()

                'Open connection
                con.Open()

                'Insert the selected item into the archive table
                Dim archiveCmdText As String = "INSERT INTO tbl_officesupply_archive SELECT * FROM tbl_officesupply WHERE ItemNumber = @ItemNumber"
                Using archiveCmd As New MySqlCommand(archiveCmdText, con)
                    archiveCmd.Parameters.AddWithValue("@ItemNumber", selectedItemNumber)
                    Dim rowsAffected As Integer = archiveCmd.ExecuteNonQuery()

                    'Check if the item was successfully archived
                    If rowsAffected > 0 Then
                        'Delete the item from the main table
                        Dim deleteCmdText As String = "DELETE FROM tbl_officesupply WHERE ItemNumber = @ItemNumber"
                        Using deleteCmd As New MySqlCommand(deleteCmdText, con)
                            deleteCmd.Parameters.AddWithValue("@ItemNumber", selectedItemNumber)
                            deleteCmd.ExecuteNonQuery()
                        End Using

                        MessageBox.Show("Item successfully archived.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to archive the item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'Close connection
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            clearform()
            DataGridView_load()
        End Try
    End Sub


    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clearform()
    End Sub

    'To serach an item within the database'
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()

        Try
            con.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_officesupply WHERE ItemNumber LIKE @SearchText OR ItemName LIKE @SearchText", con)
            cmd.Parameters.AddWithValue("@SearchText", "%" & txt_search.Text & "%")

            dr = cmd.ExecuteReader
            While dr.Read
                ' Format the DatePurchase value to display only the date part without the time'
                Dim datePurchaseFormatted As String = If(dr.IsDBNull(dr.GetOrdinal("DatePurchase")), "", CDate(dr.Item("DatePurchase")).ToString("yyyy-MM-dd"))

                DataGridView1.Rows.Add(dr.Item("ItemNumber"), dr.Item("ItemName"), dr.Item("ItemStock"), dr.Item("ItemUnit"), dr.Item("ItemStatus"), datePurchaseFormatted, dr.Item("ItemAmount"), dr.Item("ReorderPoint"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    'Dropdown button control'

    Public Sub New()
        InitializeComponent()

        dropdownpanel2.Visible = False
        dropdownpanel3.Visible = False
        dropdownpanel4.Visible = False
        ' Set other content visibility as needed
    End Sub

    Private Sub termrepbtn_Click(sender As Object, e As EventArgs) Handles termrepbtn.Click
        showdd(dropdownpanel2)
    End Sub

    Private Sub monthrepbtn_Click(sender As Object, e As EventArgs) Handles monthrepbtn.Click
        showdd(dropdownpanel3)
    End Sub

    Private Sub annualrepbtn_Click(sender As Object, e As EventArgs) Handles annualrepbtn.Click
        showdd(dropdownpanel4)
    End Sub

    Private Sub hidebutton()
        dropdownpanel2.Visible = False
        dropdownpanel3.Visible = False
        dropdownpanel4.Visible = False
        ' Hide other content as needed
    End Sub

    Private Sub showdd(subbutton As Panel)
        If subbutton.Visible = False Then
            hidebutton()
            subbutton.Visible = True
        Else
            subbutton.Visible = False
        End If
    End Sub

    Private Sub toggleVisibility()
        ' Toggle visibility of all dropdown panels and other contents
        dropdownpanel2.Visible = Not dropdownpanel2.Visible
        dropdownpanel3.Visible = Not dropdownpanel3.Visible
        dropdownpanel4.Visible = Not dropdownpanel4.Visible
        ' Toggle visibility of other content as needed
    End Sub


    Private WithEvents StockStatusTimer As New Timer()


    Private Sub StockStatusTimer_Tick(sender As Object, e As EventArgs) Handles StockStatusTimer.Tick
        ' Update the stock status
        UpdateStockStatus()
    End Sub
    Private Sub NotifIcon_Click(sender As Object, e As EventArgs) Handles NotifIcon.Click
        ' Toggle the visibility of the notification panel
        NotifPanel.Visible = Not NotifPanel.Visible
    End Sub



    Public Sub UpdateStockStatussample()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM tbl_officesupply WHERE ItemStock < ReorderPoint"
            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim totalrequestnum As String = reader(0).ToString()
                    notiflabel.Text = totalrequestnum
                Else
                    notiflabel.Text = "NaN"
                End If

                reader.Close()
            End Using
        End Using

    End Sub

    Public Sub UpdateStockStatus()
        Dim connection1 As New MySqlConnection(str)
        Dim command As New MySqlCommand("SELECT COUNT(*) FROM tbl_officesupply WHERE ItemStock < ReorderPoint", connection1)

        ' Execute the command to get the count of items below reorder point
        Dim count As Integer

        ' Open the connection if it's not already open
        If connection1.State <> ConnectionState.Open Then
            connection1.Open()
        End If

        count = CInt(command.ExecuteScalar())

        ' Close the connection if it was opened in this method
        If connection1.State = ConnectionState.Open Then
            connection1.Close()
        End If

        ' Clear existing items in the panel
        NotifPanel.Controls.Clear()

        ' If there are no items below reorder point, display a header in the notification panel
        If count = 0 Then
            Dim headerLabel As New Label()
            headerLabel.Text = "No notifications"
            ' For the System.Drawing.Font
            headerLabel.Font = New System.Drawing.Font(headerLabel.Font, FontStyle.Bold)

            headerLabel.AutoSize = True
            headerLabel.TextAlign = ContentAlignment.MiddleCenter ' Center-align the header label
            headerLabel.Margin = New Padding(0, 10, 0, 0) ' Add margin at the top
            headerLabel.Dock = DockStyle.Fill ' Fill the panel with the header label
            NotifPanel.Controls.Add(headerLabel)
        Else
            ' Update the label text with the count
            notiflabel.Text = count.ToString()

            ' If there are items below reorder point, set the label color to red
            notiflabel.ForeColor = Color.Red

            ' Display the names of the items below reorder point inside the notification panel
            DisplayItemsBelowReorderPoint(connection1)
        End If
    End Sub



    Private Sub DisplayItemsBelowReorderPoint(connection As MySqlConnection)

        Dim command As New MySqlCommand("SELECT ItemNumber, ItemName FROM tbl_officesupply WHERE ItemStock < ReorderPoint", connection)

        connection.Open()

        Dim reader As MySqlDataReader = command.ExecuteReader()

        ' Clear existing items in the panel
        NotifPanel.Controls.Clear()

        ' Add header title
        Dim headerLabel As New Label()
        headerLabel.Text = "Item/s Below Reorder Point"
        headerLabel.AutoSize = True
        ' For the System.Drawing.Font
        headerLabel.Font = New System.Drawing.Font(headerLabel.Font, FontStyle.Bold)
        ' Decrease font size
        headerLabel.Location = New Point(10, 10) ' Adjust the position as needed
        NotifPanel.Controls.Add(headerLabel)

        ' Display items below reorder point in the panel
        Dim yPosition As Integer = headerLabel.Bottom + 10 ' Set Y position below the header with some margin
        While reader.Read()
            ' Retrieve data from the reader
            Dim itemNumber As Integer = reader.GetInt32(0) ' Assuming the first column is of integer type
            Dim itemName As String = reader.GetString(1) ' Assuming the second column is of string type

            ' Convert itemNumber to string for concatenation
            Dim itemNumberString As String = itemNumber.ToString()

            ' Create and configure the label
            Dim label As New Label()
            label.Text = $"{itemNumberString} - {itemName}"
            label.AutoSize = True ' Adjust the label size automatically based on its content
            label.Location = New Point(10, yPosition) ' Set the label's position
            NotifPanel.Controls.Add(label)

            ' Increment the Y position for the next label
            yPosition += label.Height + 5 ' Adjust as needed for spacing
        End While

        reader.Close()
        connection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GenerateReport("Term")
    End Sub

    Private Sub GenerateReport(reportType As String)
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
        saveFileDialog.FilterIndex = 1
        saveFileDialog.RestoreDirectory = True

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim pdfFilePath As String = saveFileDialog.FileName

            ' Get date range based on report type
            Dim startDate As Date
            Dim endDate As Date = Date.Now ' Default to current date

            Select Case reportType
                Case "Monthly"
                    startDate = Date.Now.AddMonths(-1).Date ' Start of last month
                Case "Yearly"
                    startDate = New Date(Date.Now.Year, 1, 1) ' Start of current year
                Case "Term"
                    ' Define your custom term start and end dates here
                    startDate = New Date(2024, 1, 1) ' Example start date for term
                    endDate = New Date(2024, 3, 31) ' Example end date for term
            End Select

            ' Get the current date as the "Date Created"
            Dim dateCreated As Date = Date.Now

            ' Create a new PDF document
            Dim doc As New Document()
            Dim fs As New FileStream(pdfFilePath, FileMode.Create)
            Dim writer As PdfWriter = PdfWriter.GetInstance(doc, fs)
            doc.Open()

            ' Add "Date Created" to the document
            Dim dateCreatedParagraph As New Paragraph($"Date Created: {dateCreated.ToString("MMMM dd, yyyy")}")
            dateCreatedParagraph.Alignment = Element.ALIGN_RIGHT
            doc.Add(dateCreatedParagraph)

            ' Add title to the document
            Dim titleFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 24, iTextSharp.text.Font.BOLD)
            Dim title As New Paragraph($"{reportType} Office Supplies Report", titleFont)
            title.Alignment = Element.ALIGN_CENTER
            doc.Add(title)

            ' Add date range to the document
            Dim dateRange As New Paragraph($"Date Range: {startDate.ToString("MMMM dd, yyyy")} - {endDate.ToString("MMMM dd, yyyy")}")
            dateRange.Alignment = Element.ALIGN_CENTER
            doc.Add(dateRange)

            ' Add some space between title and date range
            doc.Add(New Paragraph(" "))

            ' Add a table to the document
            Dim table As New PdfPTable(DataGridView1.ColumnCount)
            table.WidthPercentage = 100

            ' Add column headers
            For Each column As DataGridViewColumn In DataGridView1.Columns
                Dim cell As New PdfPCell(New Phrase(column.HeaderText))
                cell.BackgroundColor = New BaseColor(240, 240, 240)
                table.AddCell(cell)
            Next

            ' Add data rows
            For Each row As DataGridViewRow In DataGridView1.Rows
                For Each cell As DataGridViewCell In row.Cells
                    table.AddCell(cell.Value.ToString())
                Next
            Next

            ' Add the table to the document
            doc.Add(table)

            ' Close the document
            doc.Close()
            fs.Close()

            MessageBox.Show("PDF report generated successfully!")
        End If
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        ' Create and configure the SaveFileDialog
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveFileDialog.Title = "Save Excel File"
        saveFileDialog.FileName = "AssetReport.xlsx" ' Default file name

        ' Show the SaveFileDialog and check if the user clicked OK
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")

            ' Export DataGridView headers to Excel
            For j = 0 To DataGridView1.ColumnCount - 1
                xlWorkSheet.Cells(1, j + 1) = DataGridView1.Columns(j).HeaderText
            Next

            ' Export DataGridView data to Excel
            For i = 0 To DataGridView1.RowCount - 1
                For j = 0 To DataGridView1.ColumnCount - 1
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next

            ' Save the workbook to the selected file location
            xlWorkBook.SaveAs(saveFileDialog.FileName)
            xlWorkBook.Close()
            xlApp.Quit()
            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)

            MessageBox.Show("File saved successfully!")
        End If
    End Sub

    Private Sub excelrepbtn_Click(sender As Object, e As EventArgs) Handles excelrepbtn.Click
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        ' Create and configure the SaveFileDialog
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveFileDialog.Title = "Save Excel File"
        saveFileDialog.FileName = "AssetReport.xlsx" ' Default file name

        ' Show the SaveFileDialog and check if the user clicked OK
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")

            ' Export DataGridView headers to Excel
            For j = 0 To DataGridView1.ColumnCount - 1
                xlWorkSheet.Cells(1, j + 1) = DataGridView1.Columns(j).HeaderText
            Next

            ' Export DataGridView data to Excel
            For i = 0 To DataGridView1.RowCount - 1
                For j = 0 To DataGridView1.ColumnCount - 1
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next

            ' Save the workbook to the selected file location
            xlWorkBook.SaveAs(saveFileDialog.FileName)
            xlWorkBook.Close()
            xlApp.Quit()
            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)

            MessageBox.Show("File saved successfully!")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        ' Create and configure the SaveFileDialog
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveFileDialog.Title = "Save Excel File"
        saveFileDialog.FileName = "AssetReport.xlsx" ' Default file name

        ' Show the SaveFileDialog and check if the user clicked OK
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")

            ' Export DataGridView headers to Excel
            For j = 0 To DataGridView1.ColumnCount - 1
                xlWorkSheet.Cells(1, j + 1) = DataGridView1.Columns(j).HeaderText
            Next

            ' Export DataGridView data to Excel
            For i = 0 To DataGridView1.RowCount - 1
                For j = 0 To DataGridView1.ColumnCount - 1
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next

            ' Save the workbook to the selected file location
            xlWorkBook.SaveAs(saveFileDialog.FileName)
            xlWorkBook.Close()
            xlApp.Quit()
            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)

            MessageBox.Show("File saved successfully!")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GenerateReport("Yearly")
    End Sub

    Private Sub pdfrepbtn_Click(sender As Object, e As EventArgs) Handles pdfrepbtn.Click
        GenerateReport("Monthly")
    End Sub

    Private Sub btn_archive_Click(sender As Object, e As EventArgs) Handles btn_archive.Click
        archive()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class