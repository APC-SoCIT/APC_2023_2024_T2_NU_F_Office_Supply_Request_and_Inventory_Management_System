Imports MySql.Data.MySqlClient

Public Class SubmittedFormAdmission

    Private Sub LoadtotalRequest()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM table_osrequest WHERE department = 'Admission'"
            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim totalrequestnum As String = reader(0).ToString()
                    userdashboardadmission.totalrequest.Text = totalrequestnum
                Else
                    userdashboardadmission.totalrequest.Text = "NaN"
                End If

                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub Loadtotalpending()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM table_osrequest WHERE status2 = 'Pending' AND department = 'Admission' "

            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim totalrequestnum As String = reader(0).ToString()
                    userdashboardadmission.totalpending.Text = totalrequestnum
                Else
                    userdashboardadmission.totalpending.Text = "NaN"
                End If

                reader.Close()
            End Using
        End Using
    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Loadtotalpending()
        LoadtotalRequest()
        RequestFormAdmission.txtbx1.Clear()
        RequestFormAdmission.txtbx2.Clear()
        RequestFormAdmission.txtbx3.Clear()
        RequestFormAdmission.txtbx4.Clear()
        RequestFormAdmission.txtbx5.Clear()
        RequestFormAdmission.txtbx6.Clear()
        RequestFormAdmission.txtbx7.Clear()
        RequestFormAdmission.txtbx8.Clear()
        RequestFormAdmission.txtbx9.Clear()
        RequestFormAdmission.txtbx10.Clear()
        RequestFormAdmission.reason.Clear()
        RequestFormAdmission.btnminus10.Hide()
        RequestFormAdmission.btnminus9.Hide()
        RequestFormAdmission.btnminus8.Hide()
        RequestFormAdmission.btnminus7.Hide()
        RequestFormAdmission.btnminus6.Hide()
        RequestFormAdmission.btnminus5.Hide()
        RequestFormAdmission.btnminus4.Hide()
        RequestFormAdmission.btnminus3.Hide()
        RequestFormAdmission.btnminus2.Hide()
        RequestFormAdmission.Dropdown1.SelectedIndex = -1
        RequestFormAdmission.Dropdown2.SelectedIndex = -1
        RequestFormAdmission.Dropdown3.SelectedIndex = -1
        RequestFormAdmission.Dropdown4.SelectedIndex = -1
        RequestFormAdmission.Dropdown5.SelectedIndex = -1
        RequestFormAdmission.Dropdown6.SelectedIndex = -1
        RequestFormAdmission.Dropdown7.SelectedIndex = -1
        RequestFormAdmission.Dropdown8.SelectedIndex = -1
        RequestFormAdmission.Dropdown9.SelectedIndex = -1
        RequestFormAdmission.Dropdown10.SelectedIndex = -1
        userdashboardadmission.Show()
        Me.Close()

    End Sub

    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb"
    Dim con As New MySqlConnection(str)

    Private Sub SubmittedFormAdmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class