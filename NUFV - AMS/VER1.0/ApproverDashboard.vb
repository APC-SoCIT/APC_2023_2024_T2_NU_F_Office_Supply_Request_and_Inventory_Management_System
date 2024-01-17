Imports MySql.Data.MySqlClient

Public Class ApproverDashboard
    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb"
    Dim con As New MySqlConnection(str)

    Private Sub LoadFirstName()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT firstname FROM accountcredentials WHERE usertype = 'Accounting'"

            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim firstName As String = reader("firstname").ToString()
                    Label7.Text = firstName
                Else
                    Label7.Text = "User not found"
                End If

                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        Label11.Text = Date.Now.ToString("dd MMM yyyy  hh:mm:ss")
    End Sub

    Private Sub userdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        PanelMenu.Hide()
    End Sub



    Private Sub pcbmenuicon_Click_2(sender As Object, e As EventArgs)
        PanelMenu.Hide()

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub pcbmenuicon_Click(sender As Object, e As EventArgs) Handles pcbmenuicon.Click
        PanelMenu.Hide()
    End Sub
End Class