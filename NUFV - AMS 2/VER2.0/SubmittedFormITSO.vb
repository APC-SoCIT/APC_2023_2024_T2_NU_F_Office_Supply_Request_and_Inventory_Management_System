Imports MySql.Data.MySqlClient

Public Class SubmittedFormITSO

    Private Sub LoadtotalRequest()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM table_osrequest WHERE department = 'ITSO'"
            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim totalrequestnum As String = reader(0).ToString()
                    userdashboardITSO.totalrequest.Text = totalrequestnum
                Else
                    userdashboardITSO.totalrequest.Text = "NaN"
                End If

                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub Loadtotalpending()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM table_osrequest WHERE status2 = 'Pending' AND department = 'ITSO' "

            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim totalrequestnum As String = reader(0).ToString()
                    userdashboardITSO.totalpending.Text = totalrequestnum
                Else
                    userdashboardITSO.totalpending.Text = "NaN"
                End If

                reader.Close()
            End Using
        End Using
    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Loadtotalpending()
        LoadtotalRequest()
        RequestFormITSO.txtbx1.Clear()
        RequestFormITSO.txtbx2.Clear()
        RequestFormITSO.txtbx3.Clear()
        RequestFormITSO.txtbx4.Clear()
        RequestFormITSO.txtbx5.Clear()
        RequestFormITSO.txtbx6.Clear()
        RequestFormITSO.txtbx7.Clear()
        RequestFormITSO.txtbx8.Clear()
        RequestFormITSO.txtbx9.Clear()
        RequestFormITSO.txtbx10.Clear()
        RequestFormITSO.reason.Clear()
        RequestFormITSO.Dropdown1.SelectedIndex = -1
        RequestFormITSO.Dropdown2.SelectedIndex = -1
        RequestFormITSO.Dropdown3.SelectedIndex = -1
        RequestFormITSO.Dropdown4.SelectedIndex = -1
        RequestFormITSO.Dropdown5.SelectedIndex = -1
        RequestFormITSO.Dropdown6.SelectedIndex = -1
        RequestFormITSO.Dropdown7.SelectedIndex = -1
        RequestFormITSO.Dropdown8.SelectedIndex = -1
        RequestFormITSO.Dropdown9.SelectedIndex = -1
        RequestFormITSO.Dropdown10.SelectedIndex = -1
        userdashboardITSO.Show()
        Me.Close()

    End Sub


    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb"
    Dim con As New MySqlConnection(str)

    Private Sub SubmittedFormITSO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class