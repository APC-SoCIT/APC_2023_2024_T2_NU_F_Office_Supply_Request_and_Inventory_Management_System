Imports MySql.Data.MySqlClient

Public Class LRCrequesthistory
    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb"
    Dim con As New MySqlConnection(str)
    Private Sub LoadFirstName()
        Using connection As New MySqlConnection(Str)
            connection.Open()

            Dim query As String = "SELECT firstname FROM accountcredentials WHERE usertype = 'LRC'"

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

    Private Sub firstnamedisplay()
        Using connection As New MySqlConnection(str)
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

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PanelMenu.Show()

    End Sub

    Private Sub pcbmenuicon_Click(sender As Object, e As EventArgs) Handles pcbmenuicon.Click
        PanelMenu.Hide()
    End Sub


    Private Sub LRCrequesthistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        PanelMenu.Hide()
        LoadFirstName()
        firstnamedisplay()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'time
        Label14.Text = Date.Now.ToString("dd MMM yyyy  hh:mm:ss")
    End Sub


    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        PanelMenu.Hide()
        userdashboardlrc.Show()
        Me.Hide()

    End Sub


End Class