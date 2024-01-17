Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO


Public Class Form8
    Dim str As String = "server=localhost; uid=root; pwd=; database=database1"
    Dim con As New MySqlConnection(str)

    Sub load()
        Dim query As String = "SELECT tbl_product.pname, tbl_product.pdesc, tbl_product.pprice, tbl_supplier.supplierid, tbl_supplier.companyname,tbl_supplier.representative
                               FROM tbl_product LEFT JOIN tbl_supplier ON tbl_product.productid = tbl_supplier.supplierid;"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub



    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
        con.Close()




    End Sub

    Private Sub rprtbtn_Click(sender As Object, e As EventArgs) Handles rprtbtn.Click
        Dim pdfTable As PdfPTable = New PdfPTable(DataGridView1.ColumnCount)
        pdfTable.DefaultCell.Padding = 5
        pdfTable.WidthPercentage = 100
        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
        pdfTable.DefaultCell.BorderWidth = 2
        Dim Header As New Paragraph("Product Information (Left Join)", New Font(Font.Name = "Tahoma", 20, Font.Bold))
        Dim text As New Phrase("Product Information Generated Date: " + Now.Date(), New Font(Font.Name = "TAHOMA", 14, Font.Bold))

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
        Using Stream As FileStream = New FileStream(folderPath + "LeftJoinReport.pdf", FileMode.Create)
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

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class