Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class Form5
    Dim str As String = "server=localhost; uid=root; pwd=; database=database1"
    Dim con As New MySqlConnection(str)


    Sub load()
        Dim query As String = "select * from tbl_userinfo"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub



    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load()
        con.Close()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try

            cmd = con.CreateCommand()
            cmd.CommandText = "update tbl_userinfo set username = @username, password = @password WHERE username = @username ;"
            cmd.Parameters.AddWithValue("@username", TextBox1.Text)
            cmd.Parameters.AddWithValue("@password", TextBox2.Text)
            cmd.ExecuteNonQuery()
            Load()
            TextBox1.Clear()
            TextBox2.Clear()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try

            TextBox1.Text = row.Cells(1).Value.ToString()
            TextBox2.Text = row.Cells(2).Value.ToString()



        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtbox3search.TextChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        con.Open()
        adapter = New MySqlDataAdapter("select * from tbl_userinfo where username like '%" & txtbox3search.Text & "%'", con)
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "delete from tbl_userinfo where username=@username;"
            cmd.Parameters.AddWithValue("@username", TextBox1.Text)
            cmd.ExecuteNonQuery()
            load()
            TextBox1.Clear()
            TextBox2.Clear()
            MessageBox.Show("Successfully Deleted")
        Catch ex As Exception

        End Try



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim pdfTable As PdfPTable = New PdfPTable(DataGridView1.ColumnCount)
        pdfTable.DefaultCell.Padding = 5
        pdfTable.WidthPercentage = 100
        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
        pdfTable.DefaultCell.BorderWidth = 2
        Dim Header As New Paragraph("Account Information", New Font(Font.Name = "Tahoma", 20, Font.Bold))
        Dim text As New Phrase("User Account Information Generated Date: " + Now.Date(), New Font(Font.Name = "TAHOMA", 14, Font.Bold))

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
        Using Stream As FileStream = New FileStream(folderPath + "report.pdf", FileMode.Create)
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form6.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class