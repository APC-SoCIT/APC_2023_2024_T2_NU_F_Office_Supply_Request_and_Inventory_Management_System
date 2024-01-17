Imports MySql.Data.SqlClient
Imports ExcelDataReader
Imports Microsoft.Office.Interop
Imports ClosedXML
Imports DocumentFormat.OpenXml.Office
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Xml
Imports System.Data
Imports System.Xml.XPath
Imports System.IO
Imports System
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Core
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Excel
Imports Org.BouncyCastle.Asn1.X500
Imports MySql.Data.MySqlClient
Imports Font = iTextSharp.text.Font

Public Class Form9
    Dim ConnectionString As String = "Data Source=LAPTOP-PJK8KVEG\SQLEXPRESS;Initial Catalog=dbprofile;Integrated Security=True"
    Dim connection As New SqlConnection(ConnectionString)


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New FolderBrowserDialog
        f.Description = "Select the Raw Data Folder"
        Dim folderDlg As New FolderBrowserDialog
        folderDlg.ShowNewFolderButton = True
        If (folderDlg.ShowDialog() = DialogResult.OK) Then
            ListBox1.Text = folderDlg.SelectedPath
            Label1.Text = folderDlg.SelectedPath
            Dim di As New IO.DirectoryInfo(folderDlg.SelectedPath)
            Dim myFileInfoArray As IO.FileInfo() = di.GetFiles()
            ListBox1.DataSource = myFileInfoArray
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Fldr() As String = IO.Directory.GetFiles(Label1.Text & "\")
        Dim file As String
        Dim Rd As OleDbDataReader
        Dim Olp As New SqlConnection
        Try
            For Each file In Fldr
                Dim Olcon As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source ='" & file & "'; " & "Extended Properties=Excel 8.0;")
                Olcon.Open()
                Dim QueryExcel As String = "Select * from [Sheet1$]"
                Dim Cmd As OleDbCommand = New OleDbCommand(QueryExcel, Olcon)
                Dim TestingDatabase As String = "Data Source=LAPTOP-PJK8KVEG\SQLEXPRESS;Initial Catalog=dbprofile;Integrated Security=True"
                Olp.ConnectionString = TestingDatabase
                Olp.Open()

                'import bulk data (bulk data is for absorbing multiple excel files at once into the sql server)

                Using bulkcopy As SqlBulkCopy = New SqlBulkCopy(Olp)

                    bulkcopy.DestinationTableName = "dbo.tbl_product"
                    Rd = Cmd.ExecuteReader
                    bulkcopy.WriteToServer(Rd)
                    Rd.Close()
                    Olp.Close()


                End Using

            Next
            Olp.Dispose()

            MsgBox("Data has been Successfully Imported", MsgBoxStyle.Information, "Success Imported.")
        Catch ex As Exception
            MsgBox(ex.ToString)
            Olp.Dispose()
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ConnectionString As String = "Data Source=LAPTOP-PJK8KVEG\SQLEXPRESS;Initial Catalog=dbprofile;Integrated Security=True"
        Dim sql As String = "Select * From dbo.tbl_product"
        Dim connection As New SqlConnection(ConnectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "tbl_product")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "tbl_product"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form12.Show()
        Me.Hide()
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData("")
    End Sub

    Public Sub FilterData(ValueToSearch As String)
        Dim searchQuery As String = "SELECT * FROM tbl_product WHERE CONCAT(productid, pname, pdesc, pprice, wprice, stocks) like '%" & TextBox1.Text & "%'"
        Dim Command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(Command)
        Dim table As New Data.DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim pdfTable As PdfPTable = New PdfPTable(DataGridView1.ColumnCount)
        pdfTable.DefaultCell.Padding = 5
        pdfTable.WidthPercentage = 100
        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
        pdfTable.DefaultCell.BorderWidth = 2
        Dim Header As New Paragraph("Search Result Report (Like Query Report)", New Font(Font.Name = "Tahoma", 20, Font.Bold))
        Dim text As New Phrase("Information Generated Date: " + Now.Date(), New Font(Font.Name = "TAHOMA", 14, Font.Bold))

        For Each column As DataGridViewColumn In DataGridView1.Columns
            Dim cell As PdfPCell = New PdfPCell(New Phrase(column.HeaderText))
            cell.BackgroundColor = New iTextSharp.text.BaseColor(30, 144, 255)
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
        Using Stream As FileStream = New FileStream(folderPath + "SearcReport.pdf", FileMode.Create)
            Dim document As Document = New Document(PageSize.A4, 10.0F, 10.0F, 10.0F, 0)
            PdfWriter.GetInstance(document, Stream)

            document.Open()
            document.Add(Header)
            document.Add(text)
            document.Add(pdfTable)

            document.Close()
            Stream.Close()
            MessageBox.Show("PDF File Exported!")
        End Using
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FilterData(TextBox1.Text)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class