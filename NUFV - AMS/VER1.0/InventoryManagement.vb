Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class InventoryManagement
    'Connection to the database'
    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb ; convert zero datetime=True"
    Dim con As New MySqlConnection(str)
    Dim i As Integer
    Dim dr As MySqlDataReader

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
        PanelMenu.Hide()
        DataGridView_load()
        firstnamedisplay()
        hidebutton()
        LoadFirstName()
    End Sub

    Private Sub LoadFirstName()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT firstname FROM accountcredentials WHERE usertype = 'Admin'"

            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim firstName As String = reader("firstname").ToString()
                    nameuser.Text = firstName
                Else
                    nameuser.Text = "User not found"
                End If

                reader.Close()
                connection.Close()
            End Using
        End Using
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
                newRow.CreateCells(DataGridView1, dr.Item("ItemNumber"), dr.Item("ItemName"), dr.Item("ItemStock"), dr.Item("ItemUnit"), dr.Item("ItemStatus"), datePurchaseFormatted, dr.Item("ItemAmount"))

                ' If the item is below the predetermined number, it will change the color red'
                If itemStock < 10 Then
                    newRow.Cells(2).Style.ForeColor = Color.Red
                End If

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
           String.IsNullOrWhiteSpace(txt_amount.Text) Then
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
                Dim insertCmd As New MySqlCommand("INSERT INTO `tbl_officesupply`(`ItemNumber`, `ItemName`, `ItemStock`, `ItemUnit`, `ItemStatus`, `DatePurchase`, `ItemAmount`) VALUES (@ItemNumber, @ItemName, @ItemStock, @ItemUnit, @ItemStatus, @DatePurchase, @ItemAmount)", con)
                insertCmd.Parameters.AddWithValue("@ItemNumber", txt_itemno.Text)
                insertCmd.Parameters.AddWithValue("@ItemName", txt_itemname.Text)
                insertCmd.Parameters.AddWithValue("@ItemStock", txt_itemstock.Text)
                insertCmd.Parameters.AddWithValue("@ItemUnit", combo_itemunit.Text)
                insertCmd.Parameters.AddWithValue("@ItemStatus", combo_itemstat.Text)
                insertCmd.Parameters.AddWithValue("@DatePurchase", CDate(purchase_date.Value))
                insertCmd.Parameters.AddWithValue("@ItemAmount", txt_amount.Text)
                i = insertCmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Item successfully added", "NUFAROSIM", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
    End Sub


    'Update Button with validation before updating'
    Sub UpdateItem()

        If DataChanges() Then
            If Validation() Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this item?", "NUFAROSIM", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Try
                        con.Open()
                        Dim cmd As New MySqlCommand("UPDATE `tbl_officesupply` SET `ItemName`=@ItemName,`ItemStock`=@ItemStock,`ItemUnit`=@ItemUnit,`ItemStatus`=@ItemStatus,`DatePurchase`=@DatePurchase,`ItemAmount`=@ItemAmount WHERE  `ItemNumber`=@ItemNumber", con)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@ItemNumber", txt_itemno.Text)
                        cmd.Parameters.AddWithValue("@ItemName", txt_itemname.Text)
                        cmd.Parameters.AddWithValue("@ItemStock", txt_itemstock.Text)
                        cmd.Parameters.AddWithValue("@ItemUnit", combo_itemunit.Text)
                        cmd.Parameters.AddWithValue("@ItemStatus", combo_itemstat.Text)
                        cmd.Parameters.AddWithValue("@DatePurchase", CDate(purchase_date.Value))
                        cmd.Parameters.AddWithValue("@ItemAmount", txt_amount.Text)

                        i = cmd.ExecuteNonQuery
                        If i > 0 Then
                            MessageBox.Show("Item successfully updated", "NUFAROSIM", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            MessageBox.Show("No changes attempt", "NUFAROSIM", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Function DataChanges() As Boolean
        'check if any text boxes has been changed'
        If txt_itemname.Text <> DataGridView1.CurrentRow.Cells(1).Value.ToString() OrElse
           txt_itemstock.Text <> DataGridView1.CurrentRow.Cells(2).Value.ToString() OrElse
           combo_itemunit.Text <> DataGridView1.CurrentRow.Cells(3).Value.ToString() OrElse
           combo_itemstat.Text <> DataGridView1.CurrentRow.Cells(4).Value.ToString() OrElse
           purchase_date.Value <> DateTime.Parse(DataGridView1.CurrentRow.Cells(5).Value.ToString()) OrElse
           txt_amount.Text <> DataGridView1.CurrentRow.Cells(6).Value.ToString() Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btn_upd_Click(sender As Object, e As EventArgs) Handles btn_upd.Click

        UpdateItem()

    End Sub

    'DELETE'
    Public Sub delete()
        'Validation if an item is selected'
        If String.IsNullOrWhiteSpace(txt_itemno.Text) AndAlso
       String.IsNullOrWhiteSpace(txt_itemname.Text) AndAlso
       String.IsNullOrWhiteSpace(txt_itemstock.Text) AndAlso
       String.IsNullOrWhiteSpace(combo_itemunit.Text) AndAlso
       String.IsNullOrWhiteSpace(combo_itemstat.Text) Then
            ' No item is selected'
            MessageBox.Show("Please select an item to delete.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            If MsgBox("Are you sure you want to delete this item?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
                Try
                    con.Open()
                    Dim cmd As New MySqlCommand("DELETE FROM `tbl_officesupply` WHERE `ItemNumber`=@ItemNumber", con)
                    cmd.Parameters.Clear()

                    ' Get an item number to delete '
                    Dim itemNumber As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
                    cmd.Parameters.AddWithValue("@ItemNumber", itemNumber)

                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        MessageBox.Show("Item successfully deleted", "NUFAROSIM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Item delete attempt failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
                clearform()
                DataGridView_load()
            End If
        End If

    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        delete()
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

                DataGridView1.Rows.Add(dr.Item("ItemNumber"), dr.Item("ItemName"), dr.Item("ItemStock"), dr.Item("ItemUnit"), dr.Item("ItemStatus"), datePurchaseFormatted, dr.Item("ItemAmount"))
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
        Dim LRC As New LRCrequesttracker()
        LRC.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Admission
        Admission.Show()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim Accounting
        Accounting.Show()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim ITSO As New ITSOrequesttracker()
        ITSO.Show()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim Faculty As New Facultyrequesttracker()
        Faculty.Show()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim Admin
        Admin.Show()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim SuperAdmin
        SuperAdmin.Show()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PanelMenu.Show()
    End Sub

    Private Sub pcbmenuicon_Click(sender As Object, e As EventArgs) Handles pcbmenuicon.Click
        PanelMenu.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'time
        Label14.Text = Date.Now.ToString("dd MMM yyyy  hh:mm:ss")
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        admindashboardclient.Show()
        Me.Hide()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub pdfrepbtn_Click(sender As Object, e As EventArgs) Handles pdfrepbtn.Click
        'report

        Dim pdfTable As PdfPTable = New PdfPTable(DataGridView1.ColumnCount)
        pdfTable.DefaultCell.Padding = 5
        pdfTable.WidthPercentage = 100
        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
        pdfTable.DefaultCell.BorderWidth = 0
        Dim Header As New Paragraph("Monthly Report Data", New Font(Font.Name = "Arial", 20, Font.Italic))
        Header.Alignment = Element.ALIGN_CENTER
        Dim Header2 As New Paragraph("AY 2023-2024", New Font(Font.Name = "Tahoma", 11, Font.Bold))
        Header2.Alignment = Element.ALIGN_CENTER
        Dim Header3 As New Paragraph("1st Semester ", New Font(Font.Name = "Tahoma", 11, Font.Bold))
        Header3.Alignment = Element.ALIGN_CENTER
        Dim Header4 As New Paragraph("Office Supplies Stocks Data Sheet ", New Font(Font.Name = "Tahoma", 14, Font.Bold))
        Header4.Alignment = Element.ALIGN_CENTER
        Dim Datepage As New Paragraph("Date: " + Now.Date(), New Font(Font.Name = "Tahoma", 12, Font.Bold))
        Datepage.Alignment = Element.ALIGN_CENTER
        Dim spaceParagraph As New Paragraph(" ")
        Dim logoTextParagraph As New Paragraph()
        Dim imagePath As String = "c://foldpdf//nulogo.jpg"
        Dim logoImage As Image = Image.GetInstance(imagePath)
        logoImage.ScaleAbsolute(60, 60)
        logoTextParagraph.Add(logoImage)



        For Each column As DataGridViewColumn In DataGridView1.Columns
            Dim cell As PdfPCell = New PdfPCell(New Phrase(column.HeaderText))
            pdfTable.AddCell(cell)
        Next


        For Each row As DataGridViewRow In DataGridView1.Rows
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value Is Nothing Then
                Else
                    pdfTable.AddCell(cell.Value.ToString())
                End If
            Next
        Next

        Dim folderPath As String = "C:\\foldpdf\\"
        If IsNothing(Directory.Exists(folderPath)) Then
            Directory.CreateDirectory(folderPath)
        End If
        Using Stream As FileStream = New FileStream(folderPath + "SumReport.pdf", FileMode.Create)
            Dim document As Document = New Document(PageSize.A4, 10.0F, 10.0F, 10.0F, 0)
            PdfWriter.GetInstance(document, Stream)

            document.Open()

            document.Add(logoTextParagraph)
            document.Add(spaceParagraph)
            document.Add(Header)
            document.Add(Header2)
            document.Add(Header3)
            document.Add(Header4)
            document.Add(Datepage)
            document.Add(spaceParagraph)
            document.Add(pdfTable)



            document.Close()
            Stream.Close()
            MessageBox.Show("PDF File Exported!")
        End Using
    End Sub


End Class