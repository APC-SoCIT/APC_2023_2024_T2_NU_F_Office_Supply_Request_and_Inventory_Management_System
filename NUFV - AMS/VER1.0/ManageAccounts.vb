Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class ManageAccounts
    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb"
    Dim con As New MySqlConnection(str)

    Private Sub firstnamedisplay()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query1 As String = "SELECT Firstname FROM accountcredentials WHERE usertype = 'SuperAdmin'"

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

    Sub load()
        Dim query As String = "select accountid AS AccountID, username AS Username, passwd AS Password, firstname AS FirstName, lastname AS LastName, usertype AS UserType from accountcredentials"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub ManageAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        firstnamedisplay()
        PanelMenu.Hide()
        load()
        con.Close()
    End Sub

    Private Sub LoadFirstName()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT firstname FROM accountcredentials WHERE usertype = 'Admin'"

            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim firstName As String = reader("firstname").ToString()
                    Label7.Text = firstName
                Else
                    Label7.Text = "User not found"
                End If

                reader.Close()
                connection.Close()
            End Using
        End Using
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            TextBox6.Text = row.Cells(0).Value.ToString()
            TextBox2.Text = row.Cells(1).Value.ToString()
            TextBox3.Text = row.Cells(2).Value.ToString()
            TextBox4.Text = row.Cells(3).Value.ToString()
            TextBox5.Text = row.Cells(4).Value.ToString()
            ComboBox1.Text = row.Cells(5).Value.ToString()
            ComboBox2.Text = row.Cells(6).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Updatebtn_Click(sender As Object, e As EventArgs) Handles Updatebtn.Click
        'Update Account
        Dim cmd As MySqlCommand
        MessageBox.Show("Updated!")
        con.Open()

        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "update accountdetails set username = @username, passwd = @password, firstname = @fname, lastname = @lname, department = @department, accounttype = @acctype WHERE accountid = @accountid ;"
            cmd.Parameters.AddWithValue("@accountid", TextBox6.Text)
            cmd.Parameters.AddWithValue("@username", TextBox2.Text)
            cmd.Parameters.AddWithValue("@password", TextBox3.Text)
            cmd.Parameters.AddWithValue("@fname", TextBox4.Text)
            cmd.Parameters.AddWithValue("@lname", TextBox5.Text)
            cmd.Parameters.AddWithValue("@department", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@acctype", ComboBox2.Text)
            cmd.ExecuteNonQuery()
            load()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Createbtn_Click(sender As Object, e As EventArgs) Handles Createbtn.Click
        CreateAccountForm.Show()
    End Sub

    Private Sub pcbmenuicon_Click(sender As Object, e As EventArgs) Handles pcbmenuicon.Click
        PanelMenu.Hide()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PanelMenu.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label11.Text = Date.Now.ToString("dd MMM yyyy  hh:mm:ss")
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        PanelMenu.Hide()
        SuperAdminDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        con.Open()
        adapter = New MySqlDataAdapter("select * from accountcredentials where accountid like '%" & TextBox1.Text & "%' OR firstname like '%" & TextBox1.Text & "%' OR lastname like '%" & TextBox1.Text & "%'", con)
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub
End Class