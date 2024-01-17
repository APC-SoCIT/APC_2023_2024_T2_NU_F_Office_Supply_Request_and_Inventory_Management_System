Imports MySql.Data.MySqlClient

Public Class InventoryViewer
    'Connection to the database'
    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb ; convert zero datetime=True"
    Dim con As New MySqlConnection(str)
    Dim i As Integer
    Dim dr As MySqlDataReader

    Private Sub firstnamedisplay()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query1 As String = "SELECT Firstname FROM accountcredentials WHERE usertype = 'LRC'"

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        firstnamedisplay()
        Timer1.Enabled = True
        PanelMenu.Hide()
        DataGridView_load()
        LoadFirstName()
    End Sub

    Private Sub LoadFirstName()

        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT firstname FROM accountcredentials WHERE usertype = 'LRC'"

            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim firstName As String = reader("firstname").ToString()
                    lrcname.Text = firstName
                Else
                    lrcname.Text = "User not found"
                End If

                reader.Close()
                connection.Close()
            End Using
        End Using
    End Sub

    'Data Viewing'
    Public Sub DataGridView_load()
        DataGridView1.Rows.Clear()

        Try
            con.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_officesupply", con)
            dr = cmd.ExecuteReader
            While dr.Read
                'Format the DatePurchase for without time format'
                Dim datePurchaseFormatted As String = If(dr.IsDBNull(dr.GetOrdinal("DatePurchase")), "", CDate(dr.Item("DatePurchase")).ToString("yyyy-MM-dd"))

                ' Get the value in the Item Stock'
                Dim itemStock As Integer
                If Not Integer.TryParse(dr.Item("ItemStock").ToString(), itemStock) Then
                    Continue While
                End If

                ' Create a new row and add it to the DataGridView'
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(DataGridView1, dr.Item("ItemName"), dr.Item("ItemStock"), dr.Item("ItemUnit"), datePurchaseFormatted, dr.Item("ItemAmount"))

                ' If the item is below the predetermined number it will change the color red'
                If itemStock < 10 Then
                    newRow.Cells(1).Style.ForeColor = Color.Red
                End If

                DataGridView1.Rows.Add(newRow)
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    'Dropdown button control'

    Public Sub New()
        InitializeComponent()

        dropdownpanel2.Visible = False
        dropdownpanel3.Visible = False
        dropdownpanel4.Visible = False

    End Sub

    Private Sub termrepbtn_Click(sender As Object, e As EventArgs) Handles termrepbtn.Click
        showdd(dropdownpanel2)
    End Sub

    Private Sub monthrepbtn_Click(sender As Object, e As EventArgs) Handles monthrepbtn.Click
        showdd(dropdownpanel3)
    End Sub

    Private Sub annualrepbtn_Click(sender As Object, e As EventArgs) Handles annualrepbtn.Click
        showdd(dropdownpanel4)
    End Sub

    Private Sub hidebutton()
        dropdownpanel2.Visible = False
        dropdownpanel3.Visible = False
        dropdownpanel4.Visible = False
        ' Hide other content as needed
    End Sub

    Private Sub showdd(subbutton As Panel)
        If subbutton.Visible = False Then
            hidebutton()
            subbutton.Visible = True
        Else
            subbutton.Visible = False
        End If
    End Sub

    Private Sub toggleVisibility()
        dropdownpanel2.Visible = Not dropdownpanel2.Visible
        dropdownpanel3.Visible = Not dropdownpanel3.Visible
        dropdownpanel4.Visible = Not dropdownpanel4.Visible
        ' Toggle visibility of other content as needed
    End Sub

    Private Sub pcbmenuicon_Click(sender As Object, e As EventArgs) Handles pcbmenuicon.Click
        PanelMenu.Hide()

    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        PanelMenu.Hide()
        userdashboardlrc.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        LoginForm.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PanelMenu.Show()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'time
        Label3.Text = Date.Now.ToString("dd MMM yyyy  hh:mm:ss")
    End Sub

    Private Sub btn_requestsup_Click(sender As Object, e As EventArgs) Handles btn_requestsup.Click
        requestformLRC.Show()
        Me.Hide()
    End Sub



    'Kulang pa ng Search Function'
    'Code Here'

End Class