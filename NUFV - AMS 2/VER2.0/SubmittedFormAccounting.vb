Imports MySql.Data.MySqlClient

Public Class SubmittedFormAccounting
    Private Sub LoadtotalRequest()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM table_osrequest WHERE department = 'Accounting'"
            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim totalrequestnum As String = reader(0).ToString()
                    userdashboardaccounting.totalrequest.Text = totalrequestnum
                Else
                    userdashboardaccounting.totalrequest.Text = "NaN"
                End If

                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub Loadtotalpending()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM table_osrequest WHERE status2 = 'Pending' AND department = 'Accounting' "

            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim totalrequestnum As String = reader(0).ToString()
                    userdashboardaccounting.totalpending.Text = totalrequestnum
                Else
                    userdashboardaccounting.totalpending.Text = "NaN"
                End If

                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        LoadtotalRequest()
        Loadtotalpending()
        RequestFormAccounting.txtbx1.Clear()
        RequestFormAccounting.txtbx2.Clear()
        RequestFormAccounting.txtbx3.Clear()
        RequestFormAccounting.txtbx4.Clear()
        RequestFormAccounting.txtbx5.Clear()
        RequestFormAccounting.txtbx6.Clear()
        RequestFormAccounting.txtbx7.Clear()
        RequestFormAccounting.txtbx8.Clear()
        RequestFormAccounting.txtbx9.Clear()
        RequestFormAccounting.txtbx10.Clear()



        RequestFormAccounting.btnminus10.Hide()
        RequestFormAccounting.btnminus9.Hide()
        RequestFormAccounting.btnminus8.Hide()
        RequestFormAccounting.btnminus7.Hide()
        RequestFormAccounting.btnminus6.Hide()
        RequestFormAccounting.btnminus5.Hide()
        RequestFormAccounting.btnminus4.Hide()
        RequestFormAccounting.btnminus3.Hide()
        RequestFormAccounting.btnminus2.Hide()



        RequestFormAccounting.reason.Clear()
        RequestFormAccounting.Dropdown1.SelectedIndex = -1
        RequestFormAccounting.Dropdown2.SelectedIndex = -1
        RequestFormAccounting.Dropdown3.SelectedIndex = -1
        RequestFormAccounting.Dropdown4.SelectedIndex = -1
        RequestFormAccounting.Dropdown5.SelectedIndex = -1
        RequestFormAccounting.Dropdown6.SelectedIndex = -1
        RequestFormAccounting.Dropdown7.SelectedIndex = -1
        RequestFormAccounting.Dropdown8.SelectedIndex = -1
        RequestFormAccounting.Dropdown9.SelectedIndex = -1
        RequestFormAccounting.Dropdown10.SelectedIndex = -1
        userdashboardaccounting.Show()
        Me.Close() ' Close the current form
    End Sub

    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb"
    Dim con As New MySqlConnection(str)

    Private Sub SubmittedFormAccounting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class