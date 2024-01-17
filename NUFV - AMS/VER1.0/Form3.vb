Imports MySql.Data.MySqlClient
Imports MySql.Data.SqlClient
Imports ExcelDataReader
Imports Microsoft.Office.Interop
Imports ClosedXML
Imports DocumentFormat.OpenXml.Office
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class Form3
    Dim str As String = "server=localhost; uid=root; pwd=; database=database1"
    Dim con As New MySqlConnection(str)


    Sub load()
        Dim query As String = "select * from tbl_customers"
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

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
        con.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            customerid.Text = row.Cells(0).Value.ToString(0)
            customername.Text = row.Cells(1).Value.ToString()
            contactname.Text = row.Cells(2).Value.ToString()
            address.Text = row.Cells(3).Value.ToString()
            city.Text = row.Cells(4).Value.ToString()
            postalcode.Text = row.Cells(5).Value.ToString()




        Catch ex As Exception

        End Try



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles insertbtn.Click
        Dim msg As DialogResult


        msg = MessageBox.Show("Do you wish to submit?", "Prompt,", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim cmd As MySqlCommand
        If msg = DialogResult.Yes Then
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "insert into tbl_customers(customername,contactname,address,city,postalcode)values(@customername,@contactname,@address,@city,@postalcode);"
            cmd.Parameters.AddWithValue("@customername", customername.Text)
            cmd.Parameters.AddWithValue("@contactname", contactname.Text)
            cmd.Parameters.AddWithValue("@address", address.Text)
            cmd.Parameters.AddWithValue("@city", city.Text)
            cmd.Parameters.AddWithValue("@postalcode", postalcode.Text)

            customername.Clear()
            contactname.Clear()
            address.Clear()
            city.Clear()
            postalcode.Clear()




            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Successfuly Updated")
        Else
            customername.Clear()
            contactname.Clear()
            address.Clear()
            city.Clear()
            postalcode.Clear()
            MessageBox.Show("Canceled!")

        End If

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click, Button4.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "delete from tbl_customers WHERE customerid=@customerid;"
            cmd.Parameters.AddWithValue("@customerid", customerid.Text)
            cmd.ExecuteNonQuery()
            load()
            customername.Clear()
            contactname.Clear()
            address.Clear()
            city.Clear()
            postalcode.Clear()
            MessageBox.Show("Successfully Deleted")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub customeridsearch_TextChanged(sender As Object, e As EventArgs) Handles customeridsearch.TextChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        con.Open()
        adapter = New MySqlDataAdapter("select * from tbl_customers where customerid like '%" & customeridsearch.Text & "%'", con)
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click, Button3.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try

            cmd = con.CreateCommand()
            cmd.CommandText = "update tbl_customers set customername = @customername, contactname = @contactname, address = @address, city = @city , postalcode = @postalcode WHERE customerid = @customerid;"
            cmd.Parameters.AddWithValue("@customerid", customerid.Text)
            cmd.Parameters.AddWithValue("@customername", customername.Text)
            cmd.Parameters.AddWithValue("@contactname", contactname.Text)
            cmd.Parameters.AddWithValue("@address", address.Text)
            cmd.Parameters.AddWithValue("@city", city.Text)
            cmd.Parameters.AddWithValue("@postalcode", postalcode.Text)
            cmd.ExecuteNonQuery()
            load()
            customername.Clear()
            contactname.Clear()
            address.Clear()
            city.Clear()
            postalcode.Clear()
            MessageBox.Show("Successfuly Updated")


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button5.Click
        Form4.Show()
        Me.Hide()
    End Sub
End Class