Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Web.UI.WebControls
Imports MySql.Data.MySqlClient

Public Class RequestFormITSO
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
                    displayfname.Text = firstName
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

            Dim query1 As String = "SELECT firstname FROM accountcredentials WHERE usertype = 'ITSO'"

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

    Private Sub fnamerequest()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT firstname FROM accountcredentials WHERE usertype = 'ITSO'"

            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim firstName As String = reader("firstname").ToString()
                    Label12.Text = firstName
                Else
                    Label12.Text = "User not found"
                End If

                reader.Close()
                connection.Close()
            End Using
        End Using
    End Sub

    Private Sub lnamerequest()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT lastname FROM accountcredentials WHERE usertype = 'ITSO'"

            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim firstName As String = reader("lastname").ToString()
                    Label17.Text = firstName
                Else
                    Label17.Text = "User not found"
                End If

                reader.Close()
                connection.Close()
            End Using
        End Using
    End Sub


    Private Sub pcbmenuicon_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RequestingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelMenu.Hide()
        LoadFirstName()
        fnamerequest()
        lnamerequest()
        Dropdown2.Hide()
        Dropdown3.Hide()
        Dropdown4.Hide()
        Dropdown5.Hide()
        Dropdown6.Hide()
        Dropdown7.Hide()
        Dropdown8.Hide()
        Dropdown9.Hide()
        Dropdown10.Hide()
        txtbx2.Hide()
        txtbx3.Hide()
        txtbx4.Hide()
        txtbx5.Hide()
        txtbx6.Hide()
        txtbx7.Hide()
        txtbx8.Hide()
        txtbx9.Hide()
        txtbx10.Hide()
        Btnadd2.Hide()
        Btnadd3.Hide()
        Btnadd4.Hide()
        Btnadd5.Hide()
        Btnadd6.Hide()
        Btnadd7.Hide()
        Btnadd8.Hide()
        Btnadd9.Hide()
        Btnadd10.Hide()
        amount2.Hide()
        amount3.Hide()
        amount4.Hide()
        amount5.Hide()
        amount6.Hide()
        amount7.Hide()
        amount8.Hide()
        amount9.Hide()
        amount10.Hide()
        unitprice2.Hide()
        unitprice3.Hide()
        unitprice4.Hide()
        unitprice5.Hide()
        unitprice6.Hide()
        unitprice7.Hide()
        unitprice8.Hide()
        unitprice9.Hide()
        unitprice10.Hide()

        btnminus2.Hide()
        btnminus3.Hide()
        btnminus4.Hide()
        btnminus5.Hide()
        btnminus6.Hide()
        btnminus7.Hide()
        btnminus8.Hide()
        btnminus9.Hide()
        btnminus10.Hide()


        Dim NsqlConn1 As New MySqlConnection
        NsqlConn1.ConnectionString = "server=localhost; uid=root; pwd=; database=nufvdb"
        Dim READER1 As MySqlDataReader
        Try
            NsqlConn1.Open()
            Dim Querydropdownitemname As String
            Querydropdownitemname = "Select * From tbl_officesupply"
            Dim Command As New MySqlCommand(Querydropdownitemname, NsqlConn1)
            READER1 = Command.ExecuteReader
            While READER1.Read
                Dim Itemname = READER1.GetString("ItemName")
                Dropdown1.Items.Add(Itemname)
                Dropdown2.Items.Add(Itemname)
                Dropdown3.Items.Add(Itemname)
                Dropdown4.Items.Add(Itemname)
                Dropdown5.Items.Add(Itemname)
                Dropdown6.Items.Add(Itemname)
                Dropdown7.Items.Add(Itemname)
                Dropdown8.Items.Add(Itemname)
                Dropdown9.Items.Add(Itemname)
                Dropdown10.Items.Add(Itemname)
            End While
            NsqlConn1.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Dropdown1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Dropdown1.SelectedIndexChanged
        Dim NsqlConn As New MySqlConnection
        NsqlConn.ConnectionString = "server=localhost; uid=root; pwd=; database=nufvdb"
        Dim READER As MySqlDataReader
        Try
            NsqlConn.Open()
            Dim Querydropdown As String
            Querydropdown = "Select * From tbl_officesupply where ItemName = '" & Dropdown1.Text & "'"
            Dim Command As New MySqlCommand(Querydropdown, NsqlConn)
            READER = Command.ExecuteReader
            While READER.Read
                unitprice1.Text = READER.GetDouble("ItemAmount")
            End While
            NsqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Dropdown2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Dropdown2.SelectedIndexChanged
        Dim NsqlConn As New MySqlConnection
        NsqlConn.ConnectionString = "server=localhost; uid=root; pwd=; database=nufvdb"
        Dim READER As MySqlDataReader
        Try
            NsqlConn.Open()
            Dim Querydropdown As String
            Querydropdown = "Select * From tbl_officesupply where ItemName = '" & Dropdown2.Text & "'"
            Dim Command As New MySqlCommand(Querydropdown, NsqlConn)
            READER = Command.ExecuteReader
            While READER.Read
                unitprice2.Text = READER.GetDouble("ItemAmount")
            End While
            NsqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Dropdown3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Dropdown3.SelectedIndexChanged
        Dim NsqlConn As New MySqlConnection
        NsqlConn.ConnectionString = "server=localhost; uid=root; pwd=; database=nufvdb"
        Dim READER As MySqlDataReader
        Try
            NsqlConn.Open()
            Dim Querydropdown As String
            Querydropdown = "Select * From tbl_officesupply where ItemName = '" & Dropdown3.Text & "'"
            Dim Command As New MySqlCommand(Querydropdown, NsqlConn)
            READER = Command.ExecuteReader
            While READER.Read
                unitprice3.Text = READER.GetDouble("ItemAmount")
            End While
            NsqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Dropdown4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Dropdown4.SelectedIndexChanged
        Dim NsqlConn As New MySqlConnection
        NsqlConn.ConnectionString = "server=localhost; uid=root; pwd=; database=nufvdb"
        Dim READER As MySqlDataReader
        Try
            NsqlConn.Open()
            Dim Querydropdown As String
            Querydropdown = "Select * From tbl_officesupply where ItemName = '" & Dropdown4.Text & "'"
            Dim Command As New MySqlCommand(Querydropdown, NsqlConn)
            READER = Command.ExecuteReader
            While READER.Read
                unitprice4.Text = READER.GetDouble("ItemAmount")
            End While
            NsqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Dropdown5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Dropdown5.SelectedIndexChanged
        Dim NsqlConn As New MySqlConnection
        NsqlConn.ConnectionString = "server=localhost; uid=root; pwd=; database=nufvdb"
        Dim READER As MySqlDataReader
        Try
            NsqlConn.Open()
            Dim Querydropdown As String
            Querydropdown = "Select * From tbl_officesupply where ItemName = '" & Dropdown5.Text & "'"
            Dim Command As New MySqlCommand(Querydropdown, NsqlConn)
            READER = Command.ExecuteReader
            While READER.Read
                unitprice5.Text = READER.GetDouble("ItemAmount")
            End While
            NsqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Dropdown6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Dropdown6.SelectedIndexChanged
        Dim NsqlConn As New MySqlConnection
        NsqlConn.ConnectionString = "server=localhost; uid=root; pwd=; database=nufvdb"
        Dim READER As MySqlDataReader
        Try
            NsqlConn.Open()
            Dim Querydropdown As String
            Querydropdown = "Select * From tbl_officesupply where ItemName = '" & Dropdown6.Text & "'"
            Dim Command As New MySqlCommand(Querydropdown, NsqlConn)
            READER = Command.ExecuteReader
            While READER.Read
                unitprice6.Text = READER.GetDouble("ItemAmount")
            End While
            NsqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Dropdown7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Dropdown7.SelectedIndexChanged
        Dim NsqlConn As New MySqlConnection
        NsqlConn.ConnectionString = "server=localhost; uid=root; pwd=; database=nufvdb"
        Dim READER As MySqlDataReader
        Try
            NsqlConn.Open()
            Dim Querydropdown As String
            Querydropdown = "Select * From tbl_officesupply where ItemName = '" & Dropdown7.Text & "'"
            Dim Command As New MySqlCommand(Querydropdown, NsqlConn)
            READER = Command.ExecuteReader
            While READER.Read
                unitprice7.Text = READER.GetDouble("ItemAmount")
            End While
            NsqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Dropdown8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Dropdown8.SelectedIndexChanged
        Dim NsqlConn As New MySqlConnection
        NsqlConn.ConnectionString = "server=localhost; uid=root; pwd=; database=nufvdb"
        Dim READER As MySqlDataReader
        Try
            NsqlConn.Open()
            Dim Querydropdown As String
            Querydropdown = "Select * From tbl_officesupply where ItemName = '" & Dropdown8.Text & "'"
            Dim Command As New MySqlCommand(Querydropdown, NsqlConn)
            READER = Command.ExecuteReader
            While READER.Read
                unitprice8.Text = READER.GetDouble("ItemAmount")
            End While
            NsqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Dropdown9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Dropdown9.SelectedIndexChanged
        Dim NsqlConn As New MySqlConnection
        NsqlConn.ConnectionString = "server=localhost; uid=root; pwd=; database=nufvdb"
        Dim READER As MySqlDataReader
        Try
            NsqlConn.Open()
            Dim Querydropdown As String
            Querydropdown = "Select * From tbl_officesupply where ItemName = '" & Dropdown9.Text & "'"
            Dim Command As New MySqlCommand(Querydropdown, NsqlConn)
            READER = Command.ExecuteReader
            While READER.Read
                unitprice9.Text = READER.GetDouble("ItemAmount")
            End While
            NsqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Dropdown10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Dropdown10.SelectedIndexChanged
        Dim NsqlConn As New MySqlConnection
        NsqlConn.ConnectionString = "server=localhost; uid=root; pwd=; database=nufvdb"
        Dim READER As MySqlDataReader
        Try
            NsqlConn.Open()
            Dim Querydropdown As String
            Querydropdown = "Select * From tbl_officesupply where ItemName = '" & Dropdown10.Text & "'"
            Dim Command As New MySqlCommand(Querydropdown, NsqlConn)
            READER = Command.ExecuteReader
            While READER.Read
                unitprice10.Text = READER.GetDouble("ItemAmount")
            End While
            NsqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Btnadd10_Click(sender As Object, e As EventArgs)
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

    Private Sub Btnadd1_Click(sender As Object, e As EventArgs) Handles Btnadd1.Click
        Btnadd2.Visible = True
        txtbx2.Visible = True
        Dropdown2.Visible = True
        unitprice2.Visible = True
        amount2.Visible = True
        btnminus2.Visible = True
        Btnadd1.Visible = False
    End Sub

    Private Sub Btnadd2_Click2(sender As Object, e As EventArgs) Handles Btnadd2.Click
        Btnadd3.Visible = True
        txtbx3.Visible = True
        Dropdown3.Visible = True
        unitprice3.Visible = True
        amount3.Visible = True
        btnminus3.Visible = True
        btnminus2.Visible = False
        Btnadd2.Visible = False
    End Sub

    Private Sub Btnadd3_Click(sender As Object, e As EventArgs) Handles Btnadd3.Click
        Btnadd4.Visible = True
        txtbx4.Visible = True
        Dropdown4.Visible = True
        unitprice4.Visible = True
        amount4.Visible = True
        btnminus4.Visible = True
        btnminus3.Visible = False
        Btnadd3.Visible = False
    End Sub

    Private Sub Btnadd4_Click(sender As Object, e As EventArgs) Handles Btnadd4.Click
        Btnadd5.Visible = True
        txtbx5.Visible = True
        Dropdown5.Visible = True
        unitprice5.Visible = True
        amount5.Visible = True
        btnminus5.Visible = True
        btnminus4.Visible = False
        Btnadd4.Visible = False
    End Sub

    Private Sub Btnadd5_Click(sender As Object, e As EventArgs) Handles Btnadd5.Click
        Btnadd6.Visible = True
        txtbx6.Visible = True
        Dropdown6.Visible = True
        unitprice6.Visible = True
        amount6.Visible = True
        btnminus6.Visible = True
        btnminus5.Visible = False
        Btnadd5.Visible = False
    End Sub

    Private Sub Btnadd6_Click(sender As Object, e As EventArgs) Handles Btnadd6.Click
        Btnadd7.Visible = True
        txtbx7.Visible = True
        Dropdown7.Visible = True
        unitprice7.Visible = True
        amount7.Visible = True
        btnminus7.Visible = True
        btnminus6.Visible = False
        Btnadd6.Visible = False
    End Sub

    Private Sub Btnadd7_Click(sender As Object, e As EventArgs) Handles Btnadd7.Click
        Btnadd8.Visible = True
        txtbx8.Visible = True
        Dropdown8.Visible = True
        unitprice8.Visible = True
        amount8.Visible = True
        btnminus8.Visible = True
        btnminus7.Visible = False
        Btnadd7.Visible = False
    End Sub

    Private Sub Btnadd8_Click(sender As Object, e As EventArgs) Handles Btnadd8.Click
        Btnadd9.Visible = True
        txtbx9.Visible = True
        Dropdown9.Visible = True
        unitprice9.Visible = True
        amount9.Visible = True
        btnminus9.Visible = True
        btnminus8.Visible = False
        Btnadd8.Visible = False
    End Sub

    Private Sub Btnadd9_Click(sender As Object, e As EventArgs) Handles Btnadd9.Click
        Btnadd10.Visible = False
        txtbx10.Visible = True
        Dropdown10.Visible = True
        unitprice10.Visible = True
        amount10.Visible = True
        btnminus10.Visible = True
        btnminus9.Visible = False
        Btnadd9.Visible = False
    End Sub

    Private Sub Btnadd2_Click(sender As Object, e As EventArgs) Handles Btnadd2.Click
        Btnadd3.Visible = True
        txtbx3.Visible = True
        Dropdown3.Visible = True
        unitprice3.Visible = True
        amount3.Visible = True
        btnminus3.Visible = True
        Btnadd2.Visible = False
    End Sub


    Private Sub Btnadd10_Click_1(sender As Object, e As EventArgs)
        MsgBox("You have reach the maximum number of Order!", MsgBoxStyle.Information, "Notification")
    End Sub

    Private Sub txtbx1_TextChanged(sender As Object, e As EventArgs) Handles txtbx1.TextChanged
        Dim quantityValue As Integer
        Dim priceValue As Double

        If Integer.TryParse(txtbx1.Text, quantityValue) AndAlso Double.TryParse(unitprice1.Text, priceValue) Then
            amount1.Text = (quantityValue * priceValue).ToString()
        Else
            amount1.Text = "0"
        End If
    End Sub

    Private Sub txtbx2_TextChanged(sender As Object, e As EventArgs) Handles txtbx2.TextChanged
        Dim quantityValue As Integer
        Dim priceValue As Double

        If Integer.TryParse(txtbx2.Text, quantityValue) AndAlso Double.TryParse(unitprice2.Text, priceValue) Then
            amount2.Text = (quantityValue * priceValue).ToString()
        Else
            amount2.Text = "0"
        End If
    End Sub

    Private Sub txtbx3_TextChanged(sender As Object, e As EventArgs) Handles txtbx3.TextChanged
        Dim quantityValue As Integer
        Dim priceValue As Double

        If Integer.TryParse(txtbx3.Text, quantityValue) AndAlso Double.TryParse(unitprice3.Text, priceValue) Then
            amount3.Text = (quantityValue * priceValue).ToString()
        Else
            amount3.Text = "0"
        End If
    End Sub

    Private Sub txtbx4_TextChanged(sender As Object, e As EventArgs) Handles txtbx4.TextChanged
        Dim quantityValue As Integer
        Dim priceValue As Double

        If Integer.TryParse(txtbx4.Text, quantityValue) AndAlso Double.TryParse(unitprice4.Text, priceValue) Then
            amount4.Text = (quantityValue * priceValue).ToString()
        Else
            amount4.Text = "0"
        End If
    End Sub

    Private Sub txtbx5_TextChanged(sender As Object, e As EventArgs) Handles txtbx5.TextChanged
        Dim quantityValue As Integer
        Dim priceValue As Double

        If Integer.TryParse(txtbx5.Text, quantityValue) AndAlso Double.TryParse(unitprice5.Text, priceValue) Then
            amount5.Text = (quantityValue * priceValue).ToString()
        Else
            amount5.Text = "0"
        End If
    End Sub

    Private Sub txtbx6_TextChanged(sender As Object, e As EventArgs) Handles txtbx6.TextChanged
        Dim quantityValue As Integer
        Dim priceValue As Double

        If Integer.TryParse(txtbx6.Text, quantityValue) AndAlso Double.TryParse(unitprice6.Text, priceValue) Then
            amount6.Text = (quantityValue * priceValue).ToString()
        Else
            amount6.Text = "0"
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles txtbx7.TextChanged
        Dim quantityValue As Integer
        Dim priceValue As Double

        If Integer.TryParse(txtbx7.Text, quantityValue) AndAlso Double.TryParse(unitprice7.Text, priceValue) Then
            amount7.Text = (quantityValue * priceValue).ToString()
        Else
            amount7.Text = "0"
        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles txtbx8.TextChanged
        Dim quantityValue As Integer
        Dim priceValue As Double

        If Integer.TryParse(txtbx8.Text, quantityValue) AndAlso Double.TryParse(unitprice8.Text, priceValue) Then
            amount8.Text = (quantityValue * priceValue).ToString()
        Else
            amount8.Text = "0"
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles txtbx9.TextChanged
        Dim quantityValue As Integer
        Dim priceValue As Double

        If Integer.TryParse(txtbx9.Text, quantityValue) AndAlso Double.TryParse(unitprice9.Text, priceValue) Then
            amount9.Text = (quantityValue * priceValue).ToString()
        Else
            amount9.Text = "0"
        End If
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles txtbx10.TextChanged
        Dim quantityValue As Integer
        Dim priceValue As Double

        If Integer.TryParse(txtbx10.Text, quantityValue) AndAlso Double.TryParse(unitprice10.Text, priceValue) Then
            amount10.Text = (quantityValue * priceValue).ToString()
        Else
            amount10.Text = "0"
        End If
    End Sub

    Private Sub totalamount_TextChanged(sender As Object, e As EventArgs) Handles amount1.TextChanged, amount2.TextChanged, amount3.TextChanged, amount4.TextChanged, amount5.TextChanged,
       amount6.TextChanged, amount7.TextChanged, amount8.TextChanged, amount9.TextChanged, amount10.TextChanged
        Dim value1 As Double
        Dim value2 As Double
        Dim value3 As Double
        Dim value4 As Double
        Dim value5 As Double
        Dim value6 As Double
        Dim value7 As Double
        Dim value8 As Double
        Dim value9 As Double
        Dim value10 As Double


        If Double.TryParse(amount1.Text, value1) AndAlso
             Double.TryParse(amount2.Text, value2) AndAlso
            Double.TryParse(amount3.Text, value3) AndAlso
            Double.TryParse(amount4.Text, value4) AndAlso
            Double.TryParse(amount5.Text, value5) AndAlso
            Double.TryParse(amount6.Text, value6) AndAlso
            Double.TryParse(amount7.Text, value7) AndAlso
            Double.TryParse(amount8.Text, value8) AndAlso
            Double.TryParse(amount9.Text, value9) AndAlso
            Double.TryParse(amount10.Text, value10) Then



            Dim totalValue As Double = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10
            Label40.Text = totalValue.ToString()
        End If
    End Sub


    Public Sub EmailSent()
        Dim email_add As String = "kylehora2023@myyahoo.com"
        Dim email_pass As String = "afdsznkeesgndcsa"
        Dim email_receiver As String = "horakm@students.nu-fairview.edu.ph"
        Dim email_subject As String = "Request Form Notification"
        Dim email_body As String = "You got a request form from Department IT Systems Office (ITSO), Please Check your Dashboard to see latest request"
        Dim smtp_server As New SmtpClient()
        Dim e_mail As New MailMessage

        smtp_server.UseDefaultCredentials = False
        smtp_server.Credentials = New Net.NetworkCredential(email_add, email_pass)
        smtp_server.Port = 587
        smtp_server.EnableSsl = True
        smtp_server.Host = "smtp.mail.yahoo.com"

        e_mail = New MailMessage()
        e_mail.From = New MailAddress(email_add)
        e_mail.To.Add(email_receiver)
        e_mail.Subject = email_subject
        e_mail.IsBodyHtml = False
        e_mail.Body = email_body
        smtp_server.Send(e_mail)

    End Sub

    Public Sub EmailSentRequestorITSO()
        Dim email_add As String = "kylehora2023@myyahoo.com"
        Dim email_pass As String = "afdsznkeesgndcsa"
        Dim email_receiver As String = "horakm@students.nu-fairview.edu.ph"
        Dim email_subject As String = "Request Form Submitted"
        Dim email_body As String = "Your request form has been submitted and will be proccessed, Please check your request tracker for any updates regarding your request."
        Dim smtp_server As New SmtpClient()
        Dim e_mail As New MailMessage

        smtp_server.UseDefaultCredentials = False
        smtp_server.Credentials = New Net.NetworkCredential(email_add, email_pass)
        smtp_server.Port = 587
        smtp_server.EnableSsl = True
        smtp_server.Host = "smtp.mail.yahoo.com"

        e_mail = New MailMessage()
        e_mail.From = New MailAddress(email_add)
        e_mail.To.Add(email_receiver)
        e_mail.Subject = email_subject
        e_mail.IsBodyHtml = False
        e_mail.Body = email_body
        smtp_server.Send(e_mail)
    End Sub


    Private Sub InsertData()
        ' Define your SQL insert statement
        Dim insertQuery As String = "INSERT INTO table_osrequest (requestorname, department, branch, total, date, purpose"
        Dim valuesQuery As String = "VALUES (@requestorname, @department, @branch, @total, @date, @purpose"

        ' Create a connection object
        Using connection As New MySqlConnection(str)
            ' Open the connection
            connection.Open()

            ' Create a command object with the insert query and connection
            Using command As New MySqlCommand("", connection)
                ' Replace parameters with actual values from your form controls
                Dim requestorname As String = Label12.Text & " " & Label17.Text
                command.Parameters.AddWithValue("@requestorname", requestorname)
                command.Parameters.AddWithValue("@department", Label3.Text)
                command.Parameters.AddWithValue("@branch", Label8.Text)
                command.Parameters.AddWithValue("@purpose", reason.Text)
                ' Pass the current date and time from VB.NET code with hours, minutes, and seconds
                command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"))

                Dim totalamount As Double = Double.Parse(Label40.Text)
                command.Parameters.AddWithValue("@total", totalamount)

                ' Flag to track if any dropdown is missing
                Dim anyDropdownMissing As Boolean = False

                ' Loop through each visible dropdown and add to parameters if it's not blank
                For i As Integer = 0 To 10
                    Dim dropdown As ComboBox = DirectCast(Me.Controls.Find("Dropdown" & i, True).FirstOrDefault(), ComboBox)
                    If dropdown IsNot Nothing AndAlso dropdown.Visible AndAlso dropdown.Text = "" Then
                        ' Set the flag to true if any dropdown is missing
                        anyDropdownMissing = True
                        Exit For
                    End If
                Next

                If anyDropdownMissing Then
                    ' Display a message indicating missing dropdown selection
                    MessageBox.Show("Please select an item for each dropdown to proceed with the order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                ' Loop through each visible dropdown again to add parameters
                For i As Integer = 0 To 10
                    Dim dropdown As ComboBox = DirectCast(Me.Controls.Find("Dropdown" & i, True).FirstOrDefault(), ComboBox)
                    If dropdown IsNot Nothing AndAlso dropdown.Visible AndAlso dropdown.Text <> "" Then
                        ' Parse quantity using Integer.TryParse
                        Dim quantity As Integer
                        If Integer.TryParse(Me.Controls.Find("txtbx" & i, True).FirstOrDefault()?.Text, quantity) Then
                            ' Quantity was successfully parsed
                            Dim unitPriceValue As Double = Double.Parse(Me.Controls.Find("unitprice" & i, True).FirstOrDefault().Text)
                            Dim amountValue As Double = Double.Parse(Me.Controls.Find("amount" & i, True).FirstOrDefault().Text)

                            ' Add parameters to the command
                            command.Parameters.AddWithValue("@item" & i, dropdown.Text)
                            command.Parameters.AddWithValue("@quantity" & i, quantity)
                            command.Parameters.AddWithValue("@unitprice" & i, unitPriceValue)
                            command.Parameters.AddWithValue("@amount" & i, amountValue)

                            ' Add corresponding fields to the SQL insert statement
                            insertQuery &= $", item{i}, quantity{i}, unitprice{i}, amount{i}"
                            valuesQuery &= $", @item{i}, @quantity{i}, @unitprice{i}, @amount{i}"
                        Else
                            ' Quantity could not be parsed
                            ' Handle the case where the input is not a valid integer
                            MessageBox.Show($"Missing input for quantity in Quantity Row {i}. Please enter a valid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If
                Next

                ' Concatenate the SQL query parts
                command.CommandText = insertQuery & ") " & valuesQuery & ");"

                ' Execute the insert command
                command.ExecuteNonQuery()

                ' Display a message indicating success
                MessageBox.Show("Request Form submitted!.")
                EmailSent()
                EmailSentRequestorITSO()
                SubmittedFormITSO.Show()
                Dropdown2.Hide()
                Dropdown3.Hide()
                Dropdown4.Hide()
                Dropdown5.Hide()
                Dropdown6.Hide()
                Dropdown7.Hide()
                Dropdown8.Hide()
                Dropdown9.Hide()
                Dropdown10.Hide()
                txtbx2.Hide()
                txtbx3.Hide()
                txtbx4.Hide()
                txtbx5.Hide()
                txtbx6.Hide()
                txtbx7.Hide()
                txtbx8.Hide()
                txtbx9.Hide()
                txtbx10.Hide()
                Btnadd1.Show()
                Btnadd2.Hide()
                Btnadd3.Hide()
                Btnadd4.Hide()
                Btnadd5.Hide()
                Btnadd6.Hide()
                Btnadd7.Hide()
                Btnadd8.Hide()
                Btnadd9.Hide()
                Btnadd10.Hide()
                amount2.Hide()
                amount3.Hide()
                amount4.Hide()
                amount5.Hide()
                amount6.Hide()
                amount7.Hide()
                amount8.Hide()
                amount9.Hide()
                amount10.Hide()
                unitprice2.Hide()
                unitprice3.Hide()
                unitprice4.Hide()
                unitprice5.Hide()
                unitprice6.Hide()
                unitprice7.Hide()
                unitprice8.Hide()
                unitprice9.Hide()
                unitprice10.Hide()
                unitprice1.Text = "0.0"
                unitprice2.Text = "0.0"
                unitprice3.Text = "0.0"
                unitprice4.Text = "0.0"
                unitprice5.Text = "0.0"
                unitprice6.Text = "0.0"
                unitprice7.Text = "0.0"
                unitprice8.Text = "0.0"
                unitprice9.Text = "0.0"
                unitprice10.Text = "0.0"
                amount1.Text = "0.0"
                amount2.Text = "0.0"
                amount3.Text = "0.0"
                amount4.Text = "0.0"
                amount5.Text = "0.0"
                amount6.Text = "0.0"
                amount7.Text = "0.0"
                amount8.Text = "0.0"
                amount9.Text = "0.0"
                amount10.Text = "0.0"
                Label40.Text = "0.0"
                Me.Hide()
                connection.Close()
            End Using
        End Using
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs)
        userdashboardITSO.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub txtbx1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbx1.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtbx2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbx2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtbx3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbx3.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtbx4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbx4.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtbx5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbx5.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtbx6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbx6.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtbx7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbx7.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtbx8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbx2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtbx9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbx9.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtbx10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbx10.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub



    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        InsertData()
    End Sub

    Private Sub pcbmenuicon_Click_2(sender As Object, e As EventArgs)
        PanelMenu.Hide()
    End Sub

    Private Sub BtnHome_Click_1(sender As Object, e As EventArgs)
        userdashboardITSO.Show()
        Me.Hide()
    End Sub

    Private Sub pcbmenuicon_Click_3(sender As Object, e As EventArgs) Handles pcbmenuicon.Click
        PanelMenu.Hide()
    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub BtnHome_Click_2(sender As Object, e As EventArgs) Handles BtnHome.Click
        Dropdown2.Hide()
        Dropdown3.Hide()
        Dropdown4.Hide()
        Dropdown5.Hide()
        Dropdown6.Hide()
        Dropdown7.Hide()
        Dropdown8.Hide()
        Dropdown9.Hide()
        Dropdown10.Hide()
        txtbx2.Hide()
        txtbx3.Hide()
        txtbx4.Hide()
        txtbx5.Hide()
        txtbx6.Hide()
        txtbx7.Hide()
        txtbx8.Hide()
        txtbx9.Hide()
        txtbx10.Hide()
        Btnadd1.Show()
        Btnadd2.Hide()
        Btnadd3.Hide()
        Btnadd4.Hide()
        Btnadd5.Hide()
        Btnadd6.Hide()
        Btnadd7.Hide()
        Btnadd8.Hide()
        Btnadd9.Hide()
        Btnadd10.Hide()
        btnminus10.Hide()
        btnminus9.Hide()
        btnminus8.Hide()
        btnminus7.Hide()
        btnminus6.Hide()
        btnminus5.Hide()
        btnminus4.Hide()
        btnminus3.Hide()
        btnminus2.Hide()
        amount2.Hide()
        amount3.Hide()
        amount4.Hide()
        amount5.Hide()
        amount6.Hide()
        amount7.Hide()
        amount8.Hide()
        amount9.Hide()
        amount10.Hide()
        unitprice2.Hide()
        unitprice3.Hide()
        unitprice4.Hide()
        unitprice5.Hide()
        unitprice6.Hide()
        unitprice7.Hide()
        unitprice8.Hide()
        unitprice9.Hide()
        unitprice10.Hide()
        unitprice1.Text = "0.0"
        unitprice2.Text = "0.0"
        unitprice3.Text = "0.0"
        unitprice4.Text = "0.0"
        unitprice5.Text = "0.0"
        unitprice6.Text = "0.0"
        unitprice7.Text = "0.0"
        unitprice8.Text = "0.0"
        unitprice9.Text = "0.0"
        unitprice10.Text = "0.0"
        amount1.Text = "0.0"
        amount2.Text = "0.0"
        amount3.Text = "0.0"
        amount4.Text = "0.0"
        amount5.Text = "0.0"
        amount6.Text = "0.0"
        amount7.Text = "0.0"
        amount8.Text = "0.0"
        amount9.Text = "0.0"
        amount10.Text = "0.0"
        Label40.Text = "0.0"
        userdashboardITSO.Show()
        Me.Hide()
    End Sub

    Private Sub btnminus10_Click(sender As Object, e As EventArgs) Handles btnminus10.Click
        Btnadd10.Visible = False
        txtbx10.Visible = False
        unitprice10.Visible = False
        amount10.Visible = False
        Dropdown10.Visible = False
        btnminus10.Visible = False
        Btnadd9.Visible = True
        btnminus9.Visible = True
    End Sub

    Private Sub btnminus9_Click(sender As Object, e As EventArgs) Handles btnminus9.Click
        Btnadd9.Visible = False
        txtbx9.Visible = False
        unitprice9.Visible = False
        amount9.Visible = False
        Dropdown9.Visible = False
        btnminus9.Visible = False
        Btnadd8.Visible = True
        btnminus9.Visible = False
        btnminus8.Visible = True
    End Sub

    Private Sub btnminus8_Click(sender As Object, e As EventArgs) Handles btnminus8.Click
        Btnadd8.Visible = False
        txtbx8.Visible = False
        unitprice8.Visible = False
        amount8.Visible = False
        Dropdown8.Visible = False
        btnminus8.Visible = False
        Btnadd7.Visible = True
        btnminus8.Visible = False
        btnminus7.Visible = True
    End Sub

    Private Sub btnminus7_Click(sender As Object, e As EventArgs) Handles btnminus7.Click
        Btnadd7.Visible = False
        txtbx7.Visible = False
        unitprice7.Visible = False
        amount7.Visible = False
        Dropdown7.Visible = False
        btnminus7.Visible = False
        Btnadd6.Visible = True
        btnminus7.Visible = False
        btnminus6.Visible = True
    End Sub

    Private Sub btnminus6_Click(sender As Object, e As EventArgs) Handles btnminus6.Click
        Btnadd6.Visible = False
        txtbx6.Visible = False
        unitprice6.Visible = False
        amount6.Visible = False
        Dropdown6.Visible = False
        btnminus6.Visible = False
        Btnadd5.Visible = True
        btnminus6.Visible = False
        btnminus5.Visible = True
    End Sub

    Private Sub btnminus5_Click(sender As Object, e As EventArgs) Handles btnminus5.Click
        Btnadd5.Visible = False
        txtbx5.Visible = False
        unitprice5.Visible = False
        amount5.Visible = False
        Dropdown5.Visible = False
        btnminus5.Visible = False
        Btnadd4.Visible = True
        btnminus5.Visible = False
        btnminus4.Visible = True
    End Sub

    Private Sub btnminus4_Click(sender As Object, e As EventArgs) Handles btnminus4.Click
        Btnadd4.Visible = False
        txtbx4.Visible = False
        unitprice4.Visible = False
        amount4.Visible = False
        Dropdown4.Visible = False
        btnminus4.Visible = False
        Btnadd3.Visible = True
        btnminus4.Visible = False
        btnminus3.Visible = True
    End Sub

    Private Sub btnminus3_Click(sender As Object, e As EventArgs) Handles btnminus3.Click
        Btnadd3.Visible = False
        txtbx3.Visible = False
        unitprice3.Visible = False
        amount3.Visible = False
        Dropdown3.Visible = False
        btnminus3.Visible = False
        Btnadd2.Visible = True
        btnminus3.Visible = False
        btnminus2.Visible = True
    End Sub

    Private Sub btnminus2_Click(sender As Object, e As EventArgs) Handles btnminus2.Click
        Btnadd2.Visible = False
        txtbx2.Visible = False
        unitprice2.Visible = False
        amount2.Visible = False
        Dropdown2.Visible = False
        btnminus2.Visible = False
        Btnadd1.Visible = True
        btnminus2.Visible = False
    End Sub
End Class