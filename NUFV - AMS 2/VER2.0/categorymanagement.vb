Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Globalization

Public Class categorymanagement

    'Connection to the database'
    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb ; convert zero datetime=True"
    Dim con As New MySqlConnection(str)
    Dim i As Integer
    Dim dr As MySqlDataReader


    Public Sub DataGridView_load()
        DataGridView1.Rows.Clear()

        Try
            con.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM tbl_category", con)
            dr = cmd.ExecuteReader
            While dr.Read
                ' Create a new row and add it to the DataGridView'
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(DataGridView1, dr.Item("glaccount"), dr.Item("Particulars"), dr.Item("qty"), dr.Item("reference"), dr.Item("EULIY"), dr.Item("datepurchased"), dr.Item("startdate"), dr.Item("enddate"), dr.Item("costcenter"), dr.Item("costcenterdescription"), dr.Item("acquisitiontotal"), dr.Item("totaldepreciation"), dr.Item("destination"), dr.Item("identitynotag"), dr.Item("accountableperson"), dr.Item("june"), dr.Item("july"), dr.Item("august"), dr.Item("september"), dr.Item("october"), dr.Item("november"), dr.Item("december"), dr.Item("january"), dr.Item("february"), dr.Item("march"), dr.Item("april"), dr.Item("may"))
                DataGridView1.Rows.Add(newRow)

                ' Set DateTimePicker values
                dateofpurchase.Value = dr.GetDateTime("datepurchased")
                startdate.Value = dr.GetDateTime("startdate")
                enddate.Value = dr.GetDateTime("enddate")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        ' Check if the column is the one containing dates (replace 5, 6, and 7 with the actual indices of your date columns)
        If e.ColumnIndex = 5 Or e.ColumnIndex = 6 Or e.ColumnIndex = 7 Then
            If e.Value IsNot Nothing AndAlso Not e.Value Is DBNull.Value Then
                ' Convert the value to a DateTime object
                Dim dateValue As Date = Convert.ToDateTime(e.Value)
                ' Format the date as "yyyy-MM-dd" and set it back to the cell
                e.Value = dateValue.ToString("yyyy-MM-dd")
                ' Set the format of the cell
                e.FormattingApplied = True
            End If
        End If
    End Sub



    Private Sub LoadFirstName()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT firstname FROM accountcredentials WHERE usertype = 'Admin'"

            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim firstName As String = reader("firstname").ToString()
                    lrcname.Text = firstName
                Else
                    lrcname.Text = "User not found"
                End If

                reader.Close()
                connection.Close()
            End Using
        End Using
    End Sub

    Private Sub firstnamedisplay()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query1 As String = "SELECT Firstname FROM accountcredentials WHERE usertype = 'Admin'"

            Using cmd As New MySqlCommand(query1, connection)

                Dim reader1 As MySqlDataReader = cmd.ExecuteReader()

                If reader1.Read Then
                    Dim fname As String = reader1("firstname").ToString()
                    displayfname.Text = fname
                Else
                    displayfname.Text = "User not found"
                End If

                reader1.Close()
                connection.Close()
            End Using
        End Using
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        DataGridView_load()
        firstnamedisplay()
        LoadFirstName()
        PanelMenu.Hide()
    End Sub



    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        ' Retrieve values from input controls
        Dim glAccount As String = txtbx_glacc.Text
        Dim particulars As String = txt_particulars.Text
        Dim quantity As Integer = Integer.Parse(txt_quantity.Text)
        Dim reference As String = txt_reference.Text
        Dim estimatedUsefulLife As Integer = Integer.Parse(txt_estusefullifeinyears.Text)
        Dim datePurchased As Date = dateofpurchase.Value
        Dim startDate1 As Date = startdate.Value
        Dim endDate1 As Date = enddate.Value
        Dim costCenter As String = txt_costcenter.Text
        Dim costCenterDescription As String = txt_costcenterdescription.Text
        Dim acquisitionTotal As Decimal = Decimal.Parse(txt_aquisitioncost.Text)
        Dim totalDepreciation As Decimal = Decimal.Parse(txt_totaldepreciation.Text)
        Dim destination As String = txt_destination.Text
        Dim identityTag As String = txt_identitytag.Text
        Dim accountablePerson As String = txt_accpersonauthorized.Text

        ' Calculate monthly depreciation
        Dim monthlyDepreciation As Decimal = totalDepreciation / 12

        ' Insert data into MySQL database table
        Dim query As String = "INSERT INTO tbl_category (glaccount, Particulars, qty, reference, EULIY, datepurchased, startdate, enddate, costcenter, costcenterdescription, acquisitiontotal, totaldepreciation, destination, identitynotag, accountableperson, june, july, august, september, october, november, december, january, february, march, april, may) " &
                       "VALUES (@glAccount, @particulars, @quantity, @reference, @estimatedUsefulLife, @datePurchased, @startDate, @endDate, @costCenter, @costCenterDescription, @acquisitionTotal, @totalDepreciation, @destination, @identityTag, @accountablePerson, @june, @july, @august, @september, @october, @november, @december, @january, @february, @march, @april, @may)"

        Using con As New MySqlConnection(str)
            Using cmd As New MySqlCommand(query, con)
                ' Add parameters
                cmd.Parameters.AddWithValue("@glAccount", glAccount)
                cmd.Parameters.AddWithValue("@particulars", particulars)
                cmd.Parameters.AddWithValue("@quantity", quantity)
                cmd.Parameters.AddWithValue("@reference", reference)
                cmd.Parameters.AddWithValue("@estimatedUsefulLife", estimatedUsefulLife)
                cmd.Parameters.AddWithValue("@datePurchased", datePurchased)
                cmd.Parameters.AddWithValue("@startDate", startDate1)
                cmd.Parameters.AddWithValue("@endDate", endDate1)
                cmd.Parameters.AddWithValue("@costCenter", costCenter)
                cmd.Parameters.AddWithValue("@costCenterDescription", costCenterDescription)
                cmd.Parameters.AddWithValue("@acquisitionTotal", acquisitionTotal)
                cmd.Parameters.AddWithValue("@totalDepreciation", totalDepreciation)
                cmd.Parameters.AddWithValue("@destination", destination)
                cmd.Parameters.AddWithValue("@identityTag", identityTag)
                cmd.Parameters.AddWithValue("@accountablePerson", accountablePerson)
                ' Add parameters for monthly depreciation
                cmd.Parameters.AddWithValue("@june", monthlyDepreciation)
                cmd.Parameters.AddWithValue("@july", monthlyDepreciation)
                cmd.Parameters.AddWithValue("@august", monthlyDepreciation)
                cmd.Parameters.AddWithValue("@september", monthlyDepreciation)
                cmd.Parameters.AddWithValue("@october", monthlyDepreciation)
                cmd.Parameters.AddWithValue("@november", monthlyDepreciation)
                cmd.Parameters.AddWithValue("@december", monthlyDepreciation)
                cmd.Parameters.AddWithValue("@january", monthlyDepreciation)
                cmd.Parameters.AddWithValue("@february", monthlyDepreciation)
                cmd.Parameters.AddWithValue("@march", monthlyDepreciation)
                cmd.Parameters.AddWithValue("@april", monthlyDepreciation)
                cmd.Parameters.AddWithValue("@may", monthlyDepreciation)

                ' Open the connection and execute the query
                con.Open()
                cmd.ExecuteNonQuery()
                DataGridView_load()
                con.Close()
            End Using
        End Using





        ' Display success message or perform any other necessary actions
        MessageBox.Show("Data added successfully.")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        If row IsNot Nothing Then
            Try
                txtbx_glacc.Text = row.Cells(0).Value?.ToString()
                txt_particulars.Text = row.Cells(1).Value?.ToString()
                txt_quantity.Text = row.Cells(2).Value?.ToString()
                txt_reference.Text = row.Cells(3).Value?.ToString()
                txt_estusefullifeinyears.Text = row.Cells(4).Value?.ToString()
                dateofpurchase.Value = DateTime.Parse(row.Cells(5).Value?.ToString())
                startdate.Value = DateTime.Parse(row.Cells(6).Value?.ToString())
                enddate.Value = DateTime.Parse(row.Cells(7).Value?.ToString())
                txt_costcenter.Text = row.Cells(8).Value?.ToString()
                txt_costcenterdescription.Text = row.Cells(9).Value?.ToString()
                txt_aquisitioncost.Text = row.Cells(10).Value?.ToString()
                txt_totaldepreciation.Text = row.Cells(11).Value?.ToString()
                txt_destination.Text = row.Cells(12).Value?.ToString()
                txt_identitytag.Text = row.Cells(13).Value?.ToString()
                txt_accpersonauthorized.Text = row.Cells(14).Value?.ToString()
            Catch ex As Exception
                ' Handle the exception here, if needed
                MsgBox(ex.Message)
            End Try

        End If
    End Sub


    Private Sub btn_upd_Click(sender As Object, e As EventArgs) Handles btn_upd.Click
        ' Retrieve values from input controls
        Dim glAccount As String = txtbx_glacc.Text
        Dim particulars As String = txt_particulars.Text
        Dim quantity As Integer = Integer.Parse(txt_quantity.Text)
        Dim reference As String = txt_reference.Text
        Dim estimatedUsefulLife As Integer = Integer.Parse(txt_estusefullifeinyears.Text)
        Dim datePurchased As Date = dateofpurchase.Value
        Dim startDate1 As Date = startdate.Value
        Dim endDate1 As Date = enddate.Value
        Dim costCenter As String = txt_costcenter.Text
        Dim costCenterDescription As String = txt_costcenterdescription.Text
        Dim acquisitionTotal As Decimal = Decimal.Parse(txt_aquisitioncost.Text)
        Dim destination As String = txt_destination.Text
        Dim identityTag As String = txt_identitytag.Text
        Dim accountablePerson As String = txt_accpersonauthorized.Text

        ' Construct the UPDATE query
        Dim query As String = "UPDATE tbl_category SET Particulars = @particulars, qty = @quantity, reference = @reference, EULIY = @estimatedUsefulLife, datepurchased = @datePurchased, startdate = @startDate, enddate = @endDate, costcenter = @costCenter, costcenterdescription = @costCenterDescription, acquisitiontotal = @acquisitionTotal, destination = @destination, identitynotag = @identityTag, accountableperson = @accountablePerson WHERE glaccount = @glAccount"

        Using con As New MySqlConnection(str)
            Using cmd As New MySqlCommand(query, con)
                ' Add parameters
                cmd.Parameters.AddWithValue("@glAccount", glAccount)
                cmd.Parameters.AddWithValue("@particulars", particulars)
                cmd.Parameters.AddWithValue("@quantity", quantity)
                cmd.Parameters.AddWithValue("@reference", reference)
                cmd.Parameters.AddWithValue("@estimatedUsefulLife", estimatedUsefulLife)
                cmd.Parameters.AddWithValue("@datePurchased", datePurchased)
                cmd.Parameters.AddWithValue("@startDate", startDate1)
                cmd.Parameters.AddWithValue("@endDate", endDate1)
                cmd.Parameters.AddWithValue("@costCenter", costCenter)
                cmd.Parameters.AddWithValue("@costCenterDescription", costCenterDescription)
                cmd.Parameters.AddWithValue("@acquisitionTotal", acquisitionTotal)
                cmd.Parameters.AddWithValue("@destination", destination)
                cmd.Parameters.AddWithValue("@identityTag", identityTag)
                cmd.Parameters.AddWithValue("@accountablePerson", accountablePerson)

                ' Open the connection and execute the query
                con.Open()
                cmd.ExecuteNonQuery()
                DataGridView_load()
                con.Close()


                ' Display notification
                MessageBox.Show("Record updated successfully.")
            End Using
        End Using

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txtbx_glacc.Clear()
        txt_particulars.Clear()
        txt_quantity.Clear()
        txt_reference.Clear()
        txt_estusefullifeinyears.Clear()
        txt_costcenter.Clear()
        txt_costcenterdescription.Clear()
        txt_aquisitioncost.Clear()
        txt_totaldepreciation.Clear()
        txt_destination.Clear()
        txt_identitytag.Clear()
        txt_accpersonauthorized.Clear()
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

    Private Sub csvexport_Click(sender As Object, e As EventArgs) Handles csvexport.Click
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



    Private Sub pcbmenuicon_Click(sender As Object, e As EventArgs)
        PanelMenu.Hide()

    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs)
        admindashboardclient.Show()
        Me.Hide()
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs)
        LoginForm.Show()
        Me.Hide()
    End Sub

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
                Dim archiveCmdText As String = "INSERT INTO tbl_category_archive SELECT * FROM tbl_category WHERE glaccount = @glaccount"
                Using archiveCmd As New MySqlCommand(archiveCmdText, con)
                    archiveCmd.Parameters.AddWithValue("@glaccount", selectedItemNumber)
                    Dim rowsAffected As Integer = archiveCmd.ExecuteNonQuery()

                    'Check if the item was successfully archived
                    If rowsAffected > 0 Then
                        'Delete the item from the main table
                        Dim deleteCmdText As String = "DELETE FROM tbl_category WHERE glaccount = @glaccount"
                        Using deleteCmd As New MySqlCommand(deleteCmdText, con)
                            deleteCmd.Parameters.AddWithValue("glaccount", selectedItemNumber)
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
            DataGridView_load()
        End Try
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        archive()
        DataGridView_load()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label24.Text = Date.Now.ToString("dd MMM yyyy  hh:mm:ss")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PanelMenu.Show()
    End Sub

    Private Sub BtnHome_Click_1(sender As Object, e As EventArgs) Handles BtnHome.Click
        admindashboardclient.Show()
        Me.Hide()
    End Sub

    Private Sub Label22_Click_1(sender As Object, e As EventArgs) Handles Label22.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub pcbmenuicon_Click_1(sender As Object, e As EventArgs) Handles pcbmenuicon.Click
        PanelMenu.Hide()
    End Sub
End Class