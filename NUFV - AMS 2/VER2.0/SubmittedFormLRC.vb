Imports MySql.Data.MySqlClient

Public Class SubmittedFormLRC

    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb"
    Dim con As New MySqlConnection(str)


    Private Sub LoadtotalRequest()

        Using connection As New MySqlConnection(Str)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM table_osrequest WHERE department = 'LRC'"
            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim totalrequestnum As String = reader(0).ToString()
                    userdashboardlrc.totalrequestlrc.Text = totalrequestnum
                Else
                    userdashboardlrc.totalrequestlrc.Text = "NaN"
                End If

                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub Loadtotalpending()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM table_osrequest WHERE status2 = 'Pending' AND department = 'LRC' "

            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim totalrequestnum As String = reader(0).ToString()
                    userdashboardlrc.totalpendinglrc.Text = totalrequestnum
                Else
                    userdashboardlrc.totalpendinglrc.Text = "NaN"
                End If

                reader.Close()
            End Using
        End Using
    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        LoadtotalRequest()
        Loadtotalpending()

        requestformLRC.txtbx1.Clear()
        requestformLRC.txtbx1.Clear()
        requestformLRC.txtbx3.Clear()
        requestformLRC.txtbx4.Clear()
        requestformLRC.txtbx5.Clear()
        requestformLRC.txtbx6.Clear()
        requestformLRC.txtbx7.Clear()
        requestformLRC.txtbx8.Clear()
        requestformLRC.txtbx9.Clear()
        requestformLRC.txtbx10.Clear()
        requestformLRC.reason.Clear()
        requestformLRC.btnminus10.Hide()
        requestformLRC.btnminus9.Hide()
        requestformLRC.btnminus8.Hide()
        requestformLRC.btnminus7.Hide()
        requestformLRC.btnminus6.Hide()
        requestformLRC.btnminus5.Hide()
        requestformLRC.btnminus4.Hide()
        requestformLRC.btnminus3.Hide()
        requestformLRC.btnminus2.Hide()
        requestformLRC.Dropdown1.SelectedIndex = -1
        requestformLRC.Dropdown2.SelectedIndex = -1
        requestformLRC.Dropdown3.SelectedIndex = -1
        requestformLRC.Dropdown4.SelectedIndex = -1
        requestformLRC.Dropdown5.SelectedIndex = -1
        requestformLRC.Dropdown6.SelectedIndex = -1
        requestformLRC.Dropdown7.SelectedIndex = -1
        requestformLRC.Dropdown8.SelectedIndex = -1
        requestformLRC.Dropdown9.SelectedIndex = -1
        requestformLRC.Dropdown10.SelectedIndex = -1
        userdashboardlrc.Show()
        Me.Close()
    End Sub

    Private Sub SubmittedFormLRC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class