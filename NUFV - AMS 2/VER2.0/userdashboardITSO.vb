Imports MySql.Data.MySqlClient


Public Class userdashboardITSO
    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb"
    Dim con As New MySqlConnection(str)

    Private Sub LoadFirstName()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT firstname FROM accountcredentials WHERE usertype = 'ITSO'"

            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim firstName As String = reader("firstname").ToString()
                    lrcname.Text = firstName
                Else
                    lrcname.Text = "User not found"
                End If

                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub firstnamedisplay()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query1 As String = "SELECT Firstname FROM accountcredentials WHERE usertype = 'ITSO'"

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

            Dim query As String = "SELECT COUNT(*) FROM table_osrequest WHERE department = 'ITSO'"
            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim totalrequestnum As String = reader(0).ToString()
                    totalrequest.Text = totalrequestnum
                Else
                    totalrequest.Text = "NaN"
                End If

                reader.Close()
            End Using
        End Using
    End Sub

    Public Sub Loadtotalpending()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM table_osrequest WHERE status2 = 'Pending' AND department = 'ITSO' "

            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim totalrequestnum As String = reader(0).ToString()
                    totalpending.Text = totalrequestnum
                Else
                    totalpending.Text = "NaN"
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



    Private Sub PanelMenu_SizeChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'time
        Label13.Text = Date.Now.ToString("dd MMM yyyy  hh:mm:ss")
    End Sub




    Private Sub userdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'time enabled function
        Loadtotalpending()
        LoadtotalRequest()
        Timer1.Enabled = True
        PanelMenu.Hide()
        firstnamedisplay()
        LoadFirstName()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PanelMenu.Show()

    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs)
        LoginForm.Show()
        Me.Hide()

    End Sub

    Private Sub pcbmenuicon_Click(sender As Object, e As EventArgs)
        PanelMenu.Hide()

    End Sub

    Private Sub lrcname_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Panel4_Paint(sender As Object, e As PaintEventArgs)
        RequestFormITSO.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
        RequestFormITSO.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox7_Click_1(sender As Object, e As EventArgs)
        RequestFormITSO.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)

        Me.Hide()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)

        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

        Me.Hide()
    End Sub

    Private Sub pcbmenuicon_Click_2(sender As Object, e As EventArgs) Handles pcbmenuicon.Click
        PanelMenu.Hide()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox8_Click_1(sender As Object, e As EventArgs) Handles PictureBox8.Click
        ITSO_RequestTracker.DataGridView_load()
        ITSO_RequestTracker.Show()

        Me.Hide()
    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click
        officesupplyviewer.DataGridView_load()
        officesupplyviewer.Show()

    End Sub

    Private Sub Guna2Panel4_Click(sender As Object, e As EventArgs) Handles Guna2Panel4.Click
        officesupplyviewer.DataGridView_load()
        officesupplyviewer.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        RequestFormITSO.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox7_Click_2(sender As Object, e As EventArgs) Handles PictureBox7.Click
        requesthistoryitso.DataGridView_load()
        requesthistoryitso.Show()


    End Sub
End Class