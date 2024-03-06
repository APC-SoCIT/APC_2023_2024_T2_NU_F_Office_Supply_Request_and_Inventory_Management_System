Imports MySql.Data.MySqlClient

Public Class SubmittedFormFaculty


    Private Sub LoadtotalRequest()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM table_osrequest WHERE department = 'Faculty'"
            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim totalrequestnum As String = reader(0).ToString()
                    dashboardfaculty.totalrequestlrc.Text = totalrequestnum
                Else
                    dashboardfaculty.totalrequestlrc.Text = "NaN"
                End If

                reader.Close()
            End Using
        End Using
    End Sub


    Private Sub Loadtotalpending()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM table_osrequest WHERE status2 = 'Pending' AND department = 'Faculty' "

            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim totalrequestnum As String = reader(0).ToString()
                    dashboardfaculty.totalpendinglrc.Text = totalrequestnum
                Else
                    dashboardfaculty.totalpendinglrc.Text = "NaN"
                End If

                reader.Close()
            End Using
        End Using
    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Loadtotalpending()
        LoadtotalRequest()
        RequestFormFaculty.txtbx1.Clear()
        RequestFormFaculty.txtbx2.Clear()
        RequestFormFaculty.txtbx3.Clear()
        RequestFormFaculty.txtbx4.Clear()
        RequestFormFaculty.txtbx5.Clear()
        RequestFormFaculty.txtbx6.Clear()
        RequestFormFaculty.txtbx7.Clear()
        RequestFormFaculty.txtbx8.Clear()
        RequestFormFaculty.txtbx9.Clear()
        RequestFormFaculty.txtbx10.Clear()
        RequestFormFaculty.reason.Clear()
        RequestFormFaculty.Dropdown1.SelectedIndex = -1
        RequestFormFaculty.Dropdown2.SelectedIndex = -1
        RequestFormFaculty.Dropdown3.SelectedIndex = -1
        RequestFormFaculty.Dropdown4.SelectedIndex = -1
        RequestFormFaculty.Dropdown5.SelectedIndex = -1
        RequestFormFaculty.Dropdown6.SelectedIndex = -1
        RequestFormFaculty.Dropdown7.SelectedIndex = -1
        RequestFormFaculty.Dropdown8.SelectedIndex = -1
        RequestFormFaculty.Dropdown9.SelectedIndex = -1
        RequestFormFaculty.Dropdown10.SelectedIndex = -1
        dashboardfaculty.Show()
        Me.Close()
    End Sub

    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb"
    Dim con As New MySqlConnection(str)

    Private Sub SubmittedFormFaculty_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class