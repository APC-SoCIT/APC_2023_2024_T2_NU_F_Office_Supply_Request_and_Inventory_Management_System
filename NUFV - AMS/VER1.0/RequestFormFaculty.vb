Imports MySql.Data.MySqlClient

Public Class RequestFormFaculty
    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb"
    Dim con As New MySqlConnection(str)


    Private Sub LoadFirstName()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT firstname FROM accountcredentials WHERE usertype = 'Faculty'"

            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim firstName As String = reader("firstname").ToString()
                    nameuser.Text = firstName
                Else
                    nameuser.Text = "User not found"
                End If

                reader.Close()
            End Using
        End Using
    End Sub


    Private Sub firstnamedisplay()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query1 As String = "SELECT Firstname FROM accountcredentials WHERE usertype = 'Faculty'"

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

    Private Sub pcbmenuicon_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RequestingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelMenu.Hide()
        firstnamedisplay()
        LoadFirstName()

        Dropdown2.Hide()
        Dropdown3.Hide()
        Dropdown4.Hide()
        Dropdown5.Hide()
        Dropdown6.Hide()
        Dropdown7.Hide()
        Dropdown8.Hide()
        Dropdown9.Hide()
        Dropdown10.Hide()
        Dropdown11.Hide()
        txtbx2.Hide()
        txtbx3.Hide()
        txtbx4.Hide()
        txtbx5.Hide()
        txtbx6.Hide()
        TextBox7.Hide()
        TextBox8.Hide()
        TextBox9.Hide()
        TextBox10.Hide()
        TextBox11.Hide()
        Btnadd2.Hide()
        Btnadd3.Hide()
        Btnadd4.Hide()
        Btnadd5.Hide()
        Btnadd6.Hide()
        Btnadd7.Hide()
        Btnadd8.Hide()
        Btnadd9.Hide()
        Btnadd10.Hide()
        Btnadd11.Hide()

        amount2.Hide()
        amount3.Hide()
        amount4.Hide()
        amount5.Hide()
        amount6.Hide()
        amount7.Hide()
        amount8.Hide()
        amount9.Hide()
        amount10.Hide()
        amount11.Hide()

        unitprice2.Hide()
        unitprice3.Hide()
        unitprice4.Hide()
        unitprice5.Hide()
        unitprice6.Hide()
        unitprice7.Hide()
        unitprice8.Hide()
        unitprice9.Hide()
        unitprice10.Hide()
        unitprice11.Hide()
    End Sub



    Private Sub Btnadd11_Click(sender As Object, e As EventArgs)
        MsgBox("You have reach the maximum number of Order!", MsgBoxStyle.Information, "Notification")
    End Sub




    Private Sub Button9_Click(sender As Object, e As EventArgs)
        SubmittedFormITSO.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PanelMenu.Show()
    End Sub

    Private Sub pcbmenuicon_Click_1(sender As Object, e As EventArgs)
        PanelMenu.Hide()
    End Sub

    Private Sub Btnadd1_Click_1(sender As Object, e As EventArgs) Handles Btnadd1.Click
        Btnadd2.Visible = True
        txtbx2.Visible = True
        Dropdown2.Visible = True
        unitprice2.Visible = True
        amount2.Visible = True
        Btnadd1.Visible = False
    End Sub

    Private Sub Btnadd2_Click_1(sender As Object, e As EventArgs) Handles Btnadd2.Click
        Btnadd3.Visible = True
        txtbx3.Visible = True
        Dropdown3.Visible = True
        unitprice3.Visible = True
        amount3.Visible = True
        Btnadd2.Visible = False
    End Sub

    Private Sub Btnadd3_Click_1(sender As Object, e As EventArgs) Handles Btnadd3.Click
        Btnadd4.Visible = True
        txtbx4.Visible = True
        Dropdown4.Visible = True
        unitprice4.Visible = True
        amount4.Visible = True
        Btnadd3.Visible = False
    End Sub

    Private Sub Btnadd4_Click_1(sender As Object, e As EventArgs) Handles Btnadd4.Click
        Btnadd5.Visible = True
        txtbx5.Visible = True
        Dropdown5.Visible = True
        unitprice5.Visible = True
        amount5.Visible = True
        Btnadd4.Visible = False
    End Sub

    Private Sub Btnadd5_Click_1(sender As Object, e As EventArgs) Handles Btnadd5.Click
        Btnadd6.Visible = True
        txtbx6.Visible = True
        Dropdown6.Visible = True
        unitprice6.Visible = True
        amount6.Visible = True
        Btnadd5.Visible = False
    End Sub

    Private Sub Btnadd6_Click_1(sender As Object, e As EventArgs) Handles Btnadd6.Click
        Btnadd7.Visible = True
        TextBox7.Visible = True
        Dropdown7.Visible = True
        unitprice7.Visible = True
        amount7.Visible = True
        Btnadd6.Visible = False
    End Sub

    Private Sub Btnadd7_Click_1(sender As Object, e As EventArgs) Handles Btnadd7.Click
        Btnadd8.Visible = True
        TextBox8.Visible = True
        Dropdown8.Visible = True
        unitprice8.Visible = True
        amount8.Visible = True
        Btnadd7.Visible = False
    End Sub

    Private Sub Btnadd8_Click_1(sender As Object, e As EventArgs) Handles Btnadd8.Click
        Btnadd9.Visible = True
        TextBox9.Visible = True
        Dropdown9.Visible = True
        unitprice9.Visible = True
        amount9.Visible = True
        Btnadd8.Visible = False
    End Sub

    Private Sub Btnadd9_Click_1(sender As Object, e As EventArgs) Handles Btnadd9.Click
        Btnadd10.Visible = True
        TextBox10.Visible = True
        Dropdown10.Visible = True
        unitprice10.Visible = True
        amount10.Visible = True
        Btnadd9.Visible = False
    End Sub

    Private Sub Btnadd10_Click_1(sender As Object, e As EventArgs) Handles Btnadd10.Click
        Btnadd11.Visible = True
        TextBox11.Visible = True
        Dropdown11.Visible = True
        unitprice11.Visible = True
        amount11.Visible = True
        Btnadd10.Visible = False
    End Sub

    Private Sub Btnadd11_Click_1(sender As Object, e As EventArgs) Handles Btnadd11.Click
        MsgBox("You have reach the maximum number of Order!", MsgBoxStyle.Information, "Notification")
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        dashboardfaculty.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        SubmittedFormFaculty.Show()
        Me.Hide()
    End Sub
End Class