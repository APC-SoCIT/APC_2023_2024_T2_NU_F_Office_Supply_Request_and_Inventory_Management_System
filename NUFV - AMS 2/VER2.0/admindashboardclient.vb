Imports MySql.Data.MySqlClient

Public Class admindashboardclient
    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb"
    Dim con As New MySqlConnection(str)

    Private Sub LoadFirstName()
        Using connection As New MySqlConnection(Str)
            connection.Open()

            Dim query As String = "SELECT firstname FROM accountcredentials WHERE usertype = 'Admin'"

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

            Dim query1 As String = "SELECT Firstname FROM accountcredentials WHERE usertype = 'Admin'"

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




    'budget
    Public Sub budgetforlrc()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT budgetamount FROM budget WHERE department = 'lrc'"

            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim budgetAmount As Double = Convert.ToDouble(reader("budgetamount"))
                    Dim budgetAmountString As String = budgetAmount.ToString()
                    budgetlrc.Text = budgetAmountString
                Else
                    budgetlrc.Text = "@Budget"
                End If

                reader.Close()
                connection.Close()
            End Using
        End Using
    End Sub


    Public Sub budgetforadmission()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT * FROM budget WHERE department = 'admission'"

            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim budget As String = reader("budgetamount").ToString()
                    budgetadmission.Text = budget
                Else
                    budgetadmission.Text = "@Budget"
                End If

                reader.Close()
                connection.Close()
            End Using
        End Using
    End Sub

    Public Sub budgetforaccounting()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT * FROM budget WHERE department = 'accounting'"

            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim budget As String = reader("budgetamount").ToString()
                    budgetaccounting.Text = budget
                Else
                    budgetaccounting.Text = "@Budget"
                End If

                reader.Close()
                connection.Close()
            End Using
        End Using
    End Sub

    Public Sub budgetforfaculty()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT * FROM budget WHERE department = 'faculty'"

            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim budget As String = reader("budgetamount").ToString()
                    budgetfaculty.Text = budget
                Else
                    budgetfaculty.Text = "@Budget"
                End If

                reader.Close()
                connection.Close()
            End Using
        End Using
    End Sub

    Public Sub budgetforitso()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT * FROM budget WHERE department = 'itso'"

            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim budget As String = reader("budgetamount").ToString()
                    budgetitso.Text = budget
                Else
                    budgetitso.Text = "@Budget"
                End If

                reader.Close()
                connection.Close()
            End Using
        End Using
    End Sub


    Private Sub pcbmenuicon_Click_1(sender As Object, e As EventArgs)
        'menu button appears when clicked
        If PanelMenu.Width > 150 Then
            TimerPanelReduce.Enabled = True
        Else
            TimerPanelIncrease.Enabled = True
        End If
    End Sub

    Private Sub TimerPanelReduce_Tick(sender As Object, e As EventArgs)
        'menu button disaappears when clicked
        If PanelMenu.Width > 45 Then
            PanelMenu.Width -= 10
        Else
            TimerPanelReduce.Enabled = False
        End If
    End Sub

    Private Sub TimerPanelIncrease_Tick(sender As Object, e As EventArgs)
        'menu button size 
        If PanelMenu.Width < 356 Then
            PanelMenu.Width += 356
        Else
            TimerPanelIncrease.Enabled = False

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PanelMenu_SizeChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'time
        Label39.Text = Date.Now.ToString("dd MMM yyyy  hh:mm:ss")
    End Sub

    Public Sub LoadtotalRequest()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM table_osrequest"
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

            Dim query As String = "SELECT COUNT(*) FROM table_osrequest WHERE status2 = 'Pending' "

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


    Private Sub userdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadtotalpending()
        LoadtotalRequest()
        budgetforadmission()
        budgetforfaculty()
        budgetforlrc()
        budgetforitso()
        budgetforaccounting()
        PanelMenu.Hide()
        firstnamedisplay()
        LoadFirstName()
        lblaccounting.Hide()
        lbladmission.Hide()
        lblfaculty.Hide()
        lblitso.Hide()
        lbllrc.Hide()
        budgetaccounting.Hide()
        budgetlrc.Hide()
        budgetadmission.Hide()
        budgetfaculty.Hide()
        budgetitso.Hide()
        Button4.Hide()
        Button3.Show()
        Button2.Hide()
        Timer1.Enabled = True
    End Sub

    Private Sub Guna2Panel4_Click(sender As Object, e As EventArgs) Handles Guna2Panel4.Click
        'Office Supplies Viewer
    End Sub

    Private Sub Guna2Panel5_Click(sender As Object, e As EventArgs) Handles Guna2Panel5.Click
        'Request History
    End Sub

    Private Sub Guna2Panel7_Click(sender As Object, e As EventArgs) Handles Guna2Panel7.Click
        'Category Management
    End Sub

    Private Sub Guna2Panel6_Click(sender As Object, e As EventArgs) Handles Guna2Panel6.Click
        'Request Tracker
    End Sub

    Private Sub Guna2Panel3_Click(sender As Object, e As EventArgs)
        'Make a Request Form
    End Sub

    Private Sub Guna2Panel1_Click(sender As Object, e As EventArgs) Handles Guna2Panel1.Click
        'Inventory Management
        Form1.DataGridView_load()
        Form1.Show()
    End Sub

    Private Sub pcbmenuicon_Click(sender As Object, e As EventArgs) Handles pcbmenuicon.Click
        PanelMenu.Hide()
    End Sub

    Private Sub Label39_Click(sender As Object, e As EventArgs) Handles Label39.Click

    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        PanelMenu.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form1.DataGridView_load()
        Form1.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        officesupplyviewer.Show()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PanelMenu.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lblaccounting.Show()
        lbladmission.Show()
        lblfaculty.Show()
        lblitso.Show()
        lbllrc.Show()
        budgetaccounting.Show()
        budgetlrc.Show()
        budgetadmission.Show()
        budgetfaculty.Show()
        budgetitso.Show()
        Button4.Show()
        Button3.Hide()
        Button2.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lblaccounting.Hide()
        lbladmission.Hide()
        lblfaculty.Hide()
        lblitso.Hide()
        lbllrc.Hide()
        budgetaccounting.Hide()
        budgetlrc.Hide()
        budgetadmission.Hide()
        budgetfaculty.Hide()
        budgetitso.Hide()
        Button3.Show()
        Button4.Hide()
        Button2.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        budgetedit.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        categorymanagement.DataGridView_load()
        categorymanagement.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        AdminClient_RequestTracker.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        requeshisotryclient.DataGridView_load()
        requeshisotryclient.Show()

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        categorymanagementarchive.Show()
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        officesuppliesarchive.DataGridView_load()
        officesuppliesarchive.Show()
    End Sub
End Class