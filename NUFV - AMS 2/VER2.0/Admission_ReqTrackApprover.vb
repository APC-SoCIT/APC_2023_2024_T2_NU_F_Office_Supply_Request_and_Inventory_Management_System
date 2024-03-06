Imports MySql.Data.MySqlClient

Public Class Admission_ReqTrackApprover
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
                                            table_osrequest.department = 'Admission';", con)

            dr = cmd.ExecuteReader

            While dr.Read()
                Dim dateValue As Date = dr.GetDateTime("date")
                DataGridView1.Rows.Add(dr("requestID"), dr("requestorName"), dr("department"), dr("branch"), dr("purpose"), dateValue.ToString("yyyy-MM-dd"), dr("item1"), dr("quantity1"), dr("unitPrice1"), dr("amount1"),
                                                                                                                                                              dr("item2"), dr("quantity2"), dr("unitPrice2"), dr("amount2"),
                                                                                                                                                               dr("item3"), dr("quantity3"), dr("unitPrice3"), dr("amount3"),
                                                                                                                                                               dr("item4"), dr("quantity4"), dr("unitPrice4"), dr("amount4"),
                                                                                                                                                               dr("item5"), dr("quantity5"), dr("unitPrice5"), dr("amount5"),
                                                                                                                                                               dr("item6"), dr("quantity6"), dr("unitPrice6"), dr("amount6"),
                                                                                                                                                               dr("item7"), dr("quantity7"), dr("unitPrice7"), dr("amount7"),
                                                                                                                                                               dr("item8"), dr("quantity8"), dr("unitPrice8"), dr("amount8"),
                                                                                                                                                               dr("item9"), dr("quantity9"), dr("unitPrice9"), dr("amount9"),
                                                                                                                                                               dr("item10"), dr("quantity10"), dr("unitPrice10"), dr("amount10"))
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
        DataGridView1.Columns("Column12").Visible = False
        DataGridView1.Columns("Column13").Visible = False
        DataGridView1.Columns("Column14").Visible = False
        DataGridView1.Columns("Column15").Visible = False
        DataGridView1.Columns("Column16").Visible = False
        DataGridView1.Columns("Column17").Visible = False
        DataGridView1.Columns("Column18").Visible = False
        DataGridView1.Columns("Column19").Visible = False
        DataGridView1.Columns("Column20").Visible = False
        DataGridView1.Columns("Column21").Visible = False
        DataGridView1.Columns("Column22").Visible = False
        DataGridView1.Columns("Column23").Visible = False
        DataGridView1.Columns("Column24").Visible = False
        DataGridView1.Columns("Column25").Visible = False
        DataGridView1.Columns("Column26").Visible = False
        DataGridView1.Columns("Column27").Visible = False
        DataGridView1.Columns("Column28").Visible = False
        DataGridView1.Columns("Column29").Visible = False
        DataGridView1.Columns("Column30").Visible = False
        DataGridView1.Columns("Column31").Visible = False
        DataGridView1.Columns("Column32").Visible = False
        DataGridView1.Columns("Column33").Visible = False
        DataGridView1.Columns("Column34").Visible = False
        DataGridView1.Columns("Column35").Visible = False
        DataGridView1.Columns("Column36").Visible = False
        DataGridView1.Columns("Column37").Visible = False
        DataGridView1.Columns("Column38").Visible = False
        DataGridView1.Columns("Column39").Visible = False
        DataGridView1.Columns("Column40").Visible = False
        DataGridView1.Columns("Column41").Visible = False
        DataGridView1.Columns("Column42").Visible = False
        DataGridView1.Columns("Column43").Visible = False
        DataGridView1.Columns("Column44").Visible = False
        DataGridView1.Columns("Column45").Visible = False
        DataGridView1.Columns("Column46").Visible = False
    End Sub


    ' To search in tracker within the database'
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()

        Try
            con.Open()
            Dim cmd As New MySqlCommand("SELECT requestorname, department, branch, purpose, date
                                         FROM table_osrequest
                                         WHERE (requestorname Like @SearchText Or date Like @SearchText) " &
                                         "And department = 'Admission'", con)
            cmd.Parameters.AddWithValue("@SearchText", "%" & txt_search.Text & "%")

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim dateValue As Date = reader.GetDateTime("date")
                DataGridView1.Rows.Add(reader("requestorname"), reader("department"), reader("branch"), reader("purpose"), dateValue.ToString("yyyy-MM-dd"))
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub viewreqstat_Click(sender As Object, e As EventArgs) Handles viewreqstat.Click
        If DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0 Then
            ' Create an instance of Accounting_ReqTracClicked form
            Dim reqTracClickedForm As New Admission_ReqTracClicked_Approver()

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

    Private Sub pcbmenuicon_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        'time
        Label11.Text = Date.Now.ToString("dd MMM yyyy  hh:mm:ss")
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs)
        userdashboardadmission.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PanelMenu.Show()
    End Sub

    Private Sub LoadFirstName()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT firstname FROM accountcredentials WHERE usertype = 'Approver_Admission'"

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

            Dim query1 As String = "SELECT Firstname FROM accountcredentials WHERE usertype = 'Approver_Admission'"

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

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub pcbmenuicon_Click_1(sender As Object, e As EventArgs) Handles pcbmenuicon.Click
        PanelMenu.Hide()
    End Sub

    Private Sub BtnHome_Click_1(sender As Object, e As EventArgs) Handles BtnHome.Click
        Admission_Approver_dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class