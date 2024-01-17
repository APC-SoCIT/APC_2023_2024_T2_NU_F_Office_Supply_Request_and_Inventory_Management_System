Imports DocumentFormat.OpenXml.Bibliography
Imports iTextSharp.text.pdf.XfaForm
Imports MySql.Data.MySqlClient

Public Class Form11
    Dim str As String = "server=localhost; uid=root; pwd=; database=database1"
    Dim con As New MySqlConnection(str)

    Sub load()
        Dim query As String = "select * from tbl_supplier"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
        txtboxcompanyname.Clear()
        txtboxcontactinfo.Clear()
        txtboxrep.Clear()


    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            txtboxsupplyid.Text = row.Cells(0).Value.ToString()
            txtboxcompanyname.Text = row.Cells(1).Value.ToString()
            txtboxcontactinfo.Text = row.Cells(2).Value.ToString()
            txtboxrep.Text = row.Cells(3).Value.ToString()




        Catch ex As Exception

        End Try



    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
        con.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtboxsearch.TextChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        con.Open()
        adapter = New MySqlDataAdapter("select * from tbl_product where supplierid like '% OR companyname like '% OR contractname like '% OR representative like '%" & txtboxsearch.Text & "%'", con)
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msg As DialogResult


        msg = MessageBox.Show("Do you wish to submit?", "Prompt,", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim cmd As MySqlCommand
        If msg = DialogResult.Yes Then
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "insert into tbl_supplier(companyname,contractname,representative)values(@companyname,@contractname,@representative);"
            cmd.Parameters.AddWithValue("@companyname", txtboxcompanyname.Text)
            cmd.Parameters.AddWithValue("@contractname", txtboxcontactinfo.Text)
            cmd.Parameters.AddWithValue("@representative", txtboxrep.Text)

            txtboxcompanyname.Clear()
            txtboxcontactinfo.Clear()
            txtboxrep.Clear()




            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Successfuly Inserted!")
        Else
            txtboxcompanyname.Clear()
            txtboxcontactinfo.Clear()
            txtboxrep.Clear()
            MessageBox.Show("Canceled!")

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try

            cmd = con.CreateCommand()
            cmd.CommandText = "update tbl_supplier SET companyname=@companyname, supplierid=@supplierid, contractname=@contractname,representative=@representative  WHERE supplierid = @supplierid;"
            cmd.Parameters.AddWithValue("@supplierid", txtboxsupplyid.Text)
            cmd.Parameters.AddWithValue("@companyname", txtboxcompanyname.Text)
            cmd.Parameters.AddWithValue("@contractname", txtboxcontactinfo.Text)
            cmd.Parameters.AddWithValue("@representative", txtboxrep.Text)
            cmd.ExecuteNonQuery()
            load()
            txtboxsupplyid.Clear()
            txtboxcompanyname.Clear()
            txtboxcontactinfo.Clear()
            txtboxrep.Clear()

            MessageBox.Show("Successfuly Updated")


        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "delete from tbl_supplier where supplierid=@supplierid;"
            cmd.Parameters.AddWithValue("@supplierid", txtboxsupplyid.Text)
            cmd.ExecuteNonQuery()
            load()
            txtboxsupplyid.Clear()
            txtboxcompanyname.Clear()
            txtboxcontactinfo.Clear()
            txtboxrep.Clear()
            MessageBox.Show("Successfully Deleted")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MessageBox.Show("Refreshed!", "Refresh",
       MessageBoxButtons.OK, MessageBoxIcon.Question)
        If DialogResult.OK Then
            load()
        Else
            Me.Hide()
            Me.Show()
        End If
    End Sub

    Private Sub txtboxsupplyid_TextChanged(sender As Object, e As EventArgs) Handles txtboxsupplyid.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
        Me.Hide()
    End Sub
End Class