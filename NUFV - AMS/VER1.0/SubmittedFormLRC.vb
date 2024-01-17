Imports MySql.Data.MySqlClient

Public Class SubmittedFormLRC


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        userdashboardlrc.Show()
        Me.Hide()
    End Sub

    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb"
    Dim con As New MySqlConnection(str)

    Private Sub firstnamedisplay()
        Using connection As New MySqlConnection(Str)
            connection.Open()

            Dim query1 As String = "SELECT Firstname FROM accountcredentials WHERE usertype = 'LRC'"

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

    Private Sub SubmittedFormLRC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        firstnamedisplay()
    End Sub
End Class