Imports System.Threading
Imports MySql.Data.MySqlClient

Public Class Faculty_ReqTrackApprover
    ' Connection to the database'
    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb; convert zero datetime=True"
    Dim con As New MySqlConnection(str)
    Dim i As Integer
    Dim dr As MySqlDataReader


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        LoadFirstName()
        firstnamedisplay()
        PanelMenu.Hide()
        DataGridView_load()
    End Sub

    Public Sub DataGridView_load()
        DataGridView1.Rows.Clear()

        Try
            con.Open()
            Dim cmd As New MySqlCommand("SELECT *
                                          FROM
                                            table_osrequest
                                         WHERE
                                            table_osrequest.department = 'Faculty';", con)

            dr = cmd.ExecuteReader

            While dr.Read()
                Dim dateValue As Date = dr.GetDateTime("date")
                DataGridView1.Rows.Add(dr("requestID"), dr("requestorName"), dr("department"), dr("branch"), dr("purpose"), dateValue.ToString("yyyy-MM-dd"), dr("item"), dr("quantity"), dr("unitPrice"), dr("amount"), dr("reason"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()
        End Try

        DataGridView1.Columns("Column5").Visible = False
        DataGridView1.Columns("Column7").Visible = False
        DataGridView1.Columns("Column8").Visible = False
        DataGridView1.Columns("Column9").Visible = False
        DataGridView1.Columns("Column10").Visible = False
        DataGridView1.Columns("Column11").Visible = False
    End Sub
    Private Sub LRC_ReqTracApprover_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' To search in tracker within the database'
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged

    End Sub

    Private Sub viewreqstat_Click(sender As Object, e As EventArgs) Handles viewreqstat.Click
        If DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0 Then
            ' Create an instance of Accounting_ReqTracClicked form
            Dim reqTracClickedForm As New Faculty_ReqTracClicked_Approver()

            ' Set TextBox values
            reqTracClickedForm.text1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
            reqTracClickedForm.text2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
            reqTracClickedForm.text3.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
            reqTracClickedForm.text4.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
            reqTracClickedForm.text5.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
            reqTracClickedForm.text6.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString

            ' Pass the selected row data to Accounting_ReqTracClicked form
            reqTracClickedForm.SelectedRowData = DataGridView1.CurrentRow

            ' Show Accounting_ReqTracClicked form
            reqTracClickedForm.ShowDialog()
        End If
    End Sub

    Private Sub pcbmenuicon_Click(sender As Object, e As EventArgs) Handles pcbmenuicon.Click
        PanelMenu.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        'time
        Label11.Text = Date.Now.ToString("dd MMM yyyy  hh:mm:ss")
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        userdashboardadmission.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PanelMenu.Show()
    End Sub

    Private Sub LoadFirstName()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT firstname FROM accountcredentials WHERE usertype = 'Approver_Faculty'"

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

    Private Sub firstnamedisplay()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query1 As String = "SELECT Firstname FROM accountcredentials WHERE usertype = 'Approver_Faculty'"

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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class