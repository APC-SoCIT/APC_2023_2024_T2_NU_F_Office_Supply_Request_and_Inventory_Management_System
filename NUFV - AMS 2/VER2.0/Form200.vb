Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient
Public Class Form1
    'Connection to the database'
    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvprojectdb ; convert zero datetime=True"
    Dim con As New MySqlConnection(str)
    Dim i As Integer
    Dim dr As MySqlDataReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView_load()
        hidebutton()

        NotifPanel.Visible = False ' Ensure the notification panel is hidden initially

        ' Call the method to check and update the stock status
        UpdateStockStatus(con)

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



    'For VIewer only (Sample Only)'
    Private Sub inventoryviewer_Click(sender As Object, e As EventArgs) Handles inventoryviewer.Click
        Dim inventoryViewerForm As New InventoryViewer()

        ' Show the InventoryViewerForm
        inventoryViewerForm.Show()

        ' Optionally, you can hide the current form if needed
        Me.Hide()
    End Sub

    'Sample Page Viewer'

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim LRC As New LRC_RequestTracker()
        LRC.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Admiussion As New Admission_RequestTracker()
        Admiussion.Show()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim Accounting As New Accounting_RequestTracker()
        Accounting.Show()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim ITSO As New ITSO_RequestTracker()
        ITSO.Show()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim Faculty As New Faculty_RequestTracker()
        Faculty.Show()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim Admin As New Admin_RequestTracker()
        Admin.Show()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim SuperAdmin As New SuperAdmin_RequestTracker()
        SuperAdmin.Show()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim OSRequest As New OSRequest()
        OSRequest.Show()
    End Sub

    Private purchaseOrderForm As Purchase_Order ' Instance of the Purchase_Order form
    Private termsAndCondForm As Term_and_Cond ' Instance of the Terms_and_Cond form
    Private currentPage As Integer = 1 ' Track the current page number

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            ' Open or create an instance of the Purchase_Order form
            If purchaseOrderForm Is Nothing OrElse purchaseOrderForm.IsDisposed Then
                purchaseOrderForm = New Purchase_Order()
            End If

            ' Open or create an instance of the Terms_and_Cond form
            If termsAndCondForm Is Nothing OrElse termsAndCondForm.IsDisposed Then
                termsAndCondForm = New Term_and_Cond()
            End If

            ' Make sure both forms are loaded before printing
            If Not purchaseOrderForm.IsHandleCreated Then
                purchaseOrderForm.CreateControl()
            End If
            If Not termsAndCondForm.IsHandleCreated Then
                termsAndCondForm.CreateControl()
            End If

            ' Check if both form instances are available
            If purchaseOrderForm IsNot Nothing AndAlso termsAndCondForm IsNot Nothing Then
                ' Make sure both forms are visible before printing
                purchaseOrderForm.Show()
                termsAndCondForm.Show()

                ' Create a PrintDocument for both forms
                Dim printDocument As New Printing.PrintDocument()

                ' Set the paper size and orientation
                printDocument.DefaultPageSettings.Landscape = False ' Set to False for portrait orientation
                ' Set the paper size to match the form's height
                printDocument.DefaultPageSettings.PaperSize = New Printing.PaperSize("Custom", purchaseOrderForm.Width, purchaseOrderForm.Height)

                ' Set the margins to ensure the entire form fits within the printable area
                printDocument.DefaultPageSettings.Margins = New Printing.Margins(50, 50, 50, 50) ' Adjust margins as needed

                ' Set the PrintPage event handler to draw both forms
                AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage

                ' Print the document without displaying the print dialog
                printDocument.Print()
            Else
                MessageBox.Show("One or both form instances are not available.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while printing: " & ex.Message)
        Finally
            ' Dispose the forms after printing if they're no longer needed
            If purchaseOrderForm IsNot Nothing AndAlso Not purchaseOrderForm.IsDisposed Then
                purchaseOrderForm.Dispose()
            End If
            If termsAndCondForm IsNot Nothing AndAlso Not termsAndCondForm.IsDisposed Then
                termsAndCondForm.Dispose()
            End If
        End Try
    End Sub

    ' Handle the PrintPage event to draw both forms onto the PrintDocument
    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        Try
            ' Create bitmaps of both forms' display areas
            Dim bitmapPurchaseOrder As New Bitmap(purchaseOrderForm.Width, purchaseOrderForm.Height)
            Dim bitmapTermsAndCond As New Bitmap(termsAndCondForm.Width, termsAndCondForm.Height)

            ' Draw the forms based on the current page
            If currentPage = 1 Then
                purchaseOrderForm.DrawToBitmap(bitmapPurchaseOrder, New Rectangle(0, 0, purchaseOrderForm.Width, purchaseOrderForm.Height))
                e.Graphics.DrawImage(bitmapPurchaseOrder, 0, 0)
                currentPage += 1
                e.HasMorePages = True ' Indicates there are more pages to print
            ElseIf currentPage = 2 Then
                termsAndCondForm.DrawToBitmap(bitmapTermsAndCond, New Rectangle(0, 0, termsAndCondForm.Width, termsAndCondForm.Height))
                e.Graphics.DrawImage(bitmapTermsAndCond, 0, 0)
                currentPage = 1 ' Reset page number for next print
                e.HasMorePages = False ' Indicates no more pages to print
            End If

            ' Dispose the bitmaps
            bitmapPurchaseOrder.Dispose()
            bitmapTermsAndCond.Dispose()
        Catch ex As Exception
            MessageBox.Show("An error occurred while printing: " & ex.Message)
        End Try
    End Sub

    Private WithEvents StockStatusTimer As New Timer()

    Private Sub StockStatusTimer_Tick(sender As Object, e As EventArgs) Handles StockStatusTimer.Tick
        ' Update the stock status
        UpdateStockStatus(con)
    End Sub
    Private Sub NotifIcon_Click(sender As Object, e As EventArgs) Handles NotifIcon.Click
        ' Toggle the visibility of the notification panel
        NotifPanel.Visible = Not NotifPanel.Visible
    End Sub
    Private Sub UpdateStockStatus(connection As MySqlConnection)
        Dim command As New MySqlCommand("SELECT COUNT(*) FROM tbl_officesupply WHERE ItemStock < ReorderPoint", connection)

        ' Execute the command to get the count of items below reorder point
        Dim count As Integer

        ' Open the connection if it's not already open
        If connection.State <> ConnectionState.Open Then
            connection.Open()
        End If

        count = CInt(command.ExecuteScalar())

        ' Close the connection if it was opened in this method
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If

        ' Clear existing items in the panel
        NotifPanel.Controls.Clear()

        ' If there are no items below reorder point, display a header in the notification panel
        If count = 0 Then
            Dim headerLabel As New Label()
            headerLabel.Text = "No notifications"
            headerLabel.Font = New Font(headerLabel.Font, FontStyle.Bold)
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
            DisplayItemsBelowReorderPoint(connection)
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
        headerLabel.Font = New Font(headerLabel.Font.FontFamily, 9, FontStyle.Bold) ' Decrease font size
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
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim lrcapprover As New LRC_ReqTracApprover()
        lrcapprover.Show()
    End Sub

    Private Sub btn_archive_Click(sender As Object, e As EventArgs) Handles btn_archive.Click
        archive() ' Call the archive method to handle archiving of the selected item
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim archive As New InventoryArchieve()
        archive.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim lrcreqhistory As New LRC_ReqHistory()
        lrcreqhistory.Show()
    End Sub
End Class