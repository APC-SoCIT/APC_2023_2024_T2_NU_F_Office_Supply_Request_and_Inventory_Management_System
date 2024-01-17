Imports MySql.Data.MySqlClient
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
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Core
Imports System.Data.SqlClient
Imports System.Linq

Public Class Form4
    Dim str As String = "server=localhost; uid=root; pwd=; database=database1"
    Dim con As New MySqlConnection(str)

    Sub load()
        Dim query As String = "select * from tbl_product"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
        Form2.productnametxt.Clear()
        Form2.productdesctxt.Clear()
        Form2.productpricetxt.Clear()
        Form2.wsaletxt.Clear()
        Form2.stockstxt.Clear()


    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
        con.Close()
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            productid.Text = row.Cells(0).Value.ToString()
            productname.Text = row.Cells(1).Value.ToString()
            productdesc.Text = row.Cells(2).Value.ToString()
            productprice.Text = row.Cells(3).Value.ToString()
            wsale.Text = row.Cells(4).Value.ToString()
            stocks.Text = row.Cells(5).Value.ToString()




        Catch ex As Exception

        End Try



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form10.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles frm4_search.TextChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        con.Open()
        adapter = New MySqlDataAdapter("select * from tbl_product where productid like '%" & frm4_search.Text & "%'", con)
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub frm4_update_Click(sender As Object, e As EventArgs) Handles frm4_update.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try

            cmd = con.CreateCommand()
            cmd.CommandText = "update tbl_product SET productid=@productid, pname=@pname, pdesc=@pdesc, pprice=@pprice,stocks=@stocks,wprice=@wprice WHERE productid = @productid;"

            cmd.Parameters.AddWithValue("@productid", productid.Text)
            cmd.Parameters.AddWithValue("@pname", productname.Text)
            cmd.Parameters.AddWithValue("@pdesc", productdesc.Text)
            cmd.Parameters.AddWithValue("@pprice", productprice.Text)
            cmd.Parameters.AddWithValue("@wprice", wsale.Text)
            cmd.Parameters.AddWithValue("@stocks", stocks.Text)
            cmd.ExecuteNonQuery()
            load()
            productprice.Clear()
            productdesc.Clear()
            productid.Clear()
            productname.Clear()
            stocks.Clear()
            wsale.Clear()
            MessageBox.Show("Successfuly Updated")


        Catch ex As Exception

        End Try
        con.Close()
    End Sub





    Private Sub frm4_delete_Click(sender As Object, e As EventArgs) Handles frm4_delete.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "delete from tbl_product where productid=@productid;"
            cmd.Parameters.AddWithValue("@productid", productid.Text)
            cmd.ExecuteNonQuery()
            load()
            productprice.Clear()
            productdesc.Clear()
            productid.Clear()
            productname.Clear()
            stocks.Clear()
            wsale.Clear()
            MessageBox.Show("Successfully Deleted")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Refreshed!", "Refresh",
        MessageBoxButtons.OK, MessageBoxIcon.Question)
        If DialogResult.OK Then
            load()
        Else
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs)






    End Sub

    Private Sub frm4_fname_TextChanged(sender As Object, e As EventArgs) Handles productid.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) 
        Form12.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles exportbtn.Click
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer
        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")
        For i = 0 To DataGridView1.RowCount - 2
            For j = 0 To DataGridView1.ColumnCount - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next
        Next
        xlWorkSheet.SaveAs("C:\foldexcel\Todays_record_excel.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()
        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
        MsgBox("You can find the file at C:\foldexcel\Todays_record_excel.xlsx")
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

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Form11.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Form2.Show()
        Me.Close()

    End Sub
End Class