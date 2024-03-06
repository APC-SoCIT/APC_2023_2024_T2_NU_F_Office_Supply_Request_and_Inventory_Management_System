Imports MySql.Data.MySqlClient

Public Class LRC_Approver_dashboard
    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb"
    Dim con As New MySqlConnection(str)

    Private Sub LoadFirstName()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT firstname FROM accountcredentials WHERE usertype = 'Approver_LRC'"

            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim firstName As String = reader("firstname").ToString()
                    Label38.Text = firstName
                Else
                    Label38.Text = "User not found"
                End If

                reader.Close()
                connection.Close()
            End Using
        End Using
    End Sub

    Private Sub firstnamedisplay()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query1 As String = "SELECT Firstname FROM accountcredentials WHERE usertype = 'Approver_LRC'"

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

    Public Sub LoadtotalRequest()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM table_osrequest WHERE department = 'LRC'"
            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim totalrequestnum As String = reader(0).ToString()
                    totalrequestlrc.Text = totalrequestnum
                Else
                    totalrequestlrc.Text = "NaN"
                End If

                reader.Close()
            End Using
        End Using
    End Sub

    Public Sub Loadtotalpending()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM table_osrequest WHERE status2 = 'Pending' AND department = 'LRC' "

            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim totalrequestnum As String = reader(0).ToString()
                    totalpendinglrc.Text = totalrequestnum
                Else
                    totalpendinglrc.Text = "NaN"
                End If

                reader.Close()
            End Using
        End Using
    End Sub


    Private Sub pcbmenuicon_Click_1(sender As Object, e As EventArgs)
        If PanelMenu.Width > 150 Then
            TimerPanelReduce.Enabled = True
        Else
            TimerPanelIncrease.Enabled = True
        End If
    End Sub

    Private Sub TimerPanelReduce_Tick(sender As Object, e As EventArgs) Handles TimerPanelReduce.Tick
        If PanelMenu.Width > 45 Then
            PanelMenu.Width -= 10
        Else
            TimerPanelReduce.Enabled = False
        End If
    End Sub

    Private Sub TimerPanelIncrease_Tick(sender As Object, e As EventArgs) Handles TimerPanelIncrease.Tick
        If PanelMenu.Width < 356 Then
            PanelMenu.Width += 356
        Else
            TimerPanelIncrease.Enabled = False

        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'time
        Label39.Text = Date.Now.ToString("dd MMM yyyy  hh:mm:ss")
    End Sub




    Private Sub userdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'time enabled function
        Timer1.Enabled = True
        PanelMenu.Hide()
        firstnamedisplay()
        LoadFirstName()

        LoadtotalRequest()
        Loadtotalpending()
    End Sub


    Private Sub pcbmenuicon_Click_2(sender As Object, e As EventArgs) Handles pcbmenuicon.Click
        PanelMenu.Hide()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        LRC_ReqTracApprover.Show()
        LRC_ReqTracApprover.DataGridView_load()

        Me.Hide()
    End Sub

    Private Sub Guna2Panel6_Click(sender As Object, e As EventArgs) Handles Guna2Panel6.Click
        LRC_ReqTracApprover.Show()
        LRC_ReqTracApprover.DataGridView_load()
        Me.Hide()
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PanelMenu.Show()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        officesupplyviewer.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        requesthistorylrc.Show()
    End Sub
End Class