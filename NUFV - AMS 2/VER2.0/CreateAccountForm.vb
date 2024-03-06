Imports System.Web.UI.WebControls
Imports MySql.Data.MySqlClient
Public Class CreateAccountForm
    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb"
    Dim con As New MySqlConnection(str)



    Private Sub CreateAccountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Create Account
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand
            cmd.CommandText = "insert into accountcredentials(usertype,username,passwd,firstname,lastname)values(@username,@passwd,@firstname,@lastname,@usertype);"
            cmd.Parameters.AddWithValue("@username", TextBox3.Text)
            cmd.Parameters.AddWithValue("@passwd", TextBox4.Text)
            cmd.Parameters.AddWithValue("@firstname", TextBox1.Text)
            cmd.Parameters.AddWithValue("@lastname", TextBox2.Text)
            cmd.Parameters.AddWithValue("@usertype", ComboBox2.Text)
            MessageBox.Show("Account Created")
            cmd.ExecuteNonQuery()
            ManageAccounts.load()
            con.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            ComboBox2.Items.Clear()
        Catch ex As Exception

        End Try
        con.Close()
    End Sub
End Class