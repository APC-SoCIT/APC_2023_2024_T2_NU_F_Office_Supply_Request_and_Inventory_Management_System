Imports MySql.Data.MySqlClient
Public Class Form13
    Dim str As String = "server=localhost; uid=root; pwd=; database=database1"
    Dim con As New MySqlConnection(str)

    Sub load()
        Dim query As String = "Select * from tbl_userinfo1"
        Dim adpt As New MySqlDataAdapter(query, con)
        con.Close()
    End Sub

    Private Sub btn1_Submit_Click(sender As Object, e As EventArgs) Handles btn1_Submit.Click
        load()
        Dim cmd As MySqlCommand
        Dim READER As MySqlDataReader
        Try
            con.Open()
            Dim Query As String
            Query = "select * from tbl_userinfo1 where username='" & txtbox1_Username.Text & "' and password='" & txtbx2_Password.Text & "' "
            cmd = New MySqlCommand(Query, con)
            READER = cmd.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While


            If count = 1 Then
                MessageBox.Show("Login Successfully", "Login")
                Form2.Show()
                Me.Hide()
                txtbx2_Password.Clear()
                txtbox1_Username.Clear()
            ElseIf count > 1 Then
                MessageBox.Show("Username and Password is Duplicated", "Login")
                txtbx2_Password.Clear()
                txtbox1_Username.Clear()
            Else
                MessageBox.Show("Username and Password are Incorrect or Not Created", "Login")
                txtbx2_Password.Clear()
                txtbox1_Username.Clear()
            End If

            con.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As MySqlCommand
        cmd = con.CreateCommand
        cmd.CommandText = "insert into tbl_userinfo1(username,password)values(@username,@password);"
        con.Open()
        cmd.Parameters.AddWithValue("@username", txtbox1_Username.Text)
        cmd.Parameters.AddWithValue("@password", txtbx2_Password.Text)
        MessageBox.Show("Account Created")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoginForm.Show()
        Me.Hide()

    End Sub

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class