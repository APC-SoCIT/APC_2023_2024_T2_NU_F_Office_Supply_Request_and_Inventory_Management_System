Imports System.Drawing.Drawing2D
Imports System.Threading
Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports System.Data.SqlClient

Public Class ApproverRelease_ReqTracClicked
    ' Connection to the database'
    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb;"
    Dim con As New MySqlConnection(str)

    Public Event StatusUpdated(ByVal statusText As String, ByVal statusColor As Color)

    Public Property SelectedRowData As DataGridViewRow


    Private button1Clicked As Boolean = False

    Private Sub EnableNextButtons()
        If button1Clicked Then
            approvebtn2.Enabled = False
        End If
    End Sub

    Public Sub EmailSentrelease()
        Dim email_add As String = "kylehora2023@myyahoo.com"
        Dim email_pass As String = "afdsznkeesgndcsa"
        Dim email_receiver As String = "horakm@students.nu-fairview.edu.ph"
        Dim email_subject As String = "Request Form Notification"
        Dim email_body As String = "Your request has been noted as release, Please Check your request history to check the details"
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

    Private Sub text3_TextChanged(sender As Object, e As EventArgs) Handles text3.TextChanged
        Dim searchText As String = text3.Text()
        Select Case searchText
            Case "LRC"
                Label9.Text = "Ms. Sandra Rosales"
            Case "ITSO"
                Label9.Text = "Mr. Peter L. Magcaling"
            Case "Accounting"
                Label9.Text = "Ms. Maribeth F. Ramos"
            Case "Admission"
                Label9.Text = "Ms. Patricia Kerstin C. Zamora"
            Case Else
                Label9.Text = ""
        End Select
    End Sub

    Private Sub HeadApprover1_ReqTracClicked_Approver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        status1.Text = "Pending Request"
        status2.Text = "Pending Request"

        dt1.Visible = True
        dt2.Visible = True

        MakeCircular(statuspanel1)
        MakeCircular(statuspanel2)


        If SelectedRowData IsNot Nothing Then
            ' Display the results without buttons
            DataGridView2.Rows.Clear() ' Clear previous data

            ' Loop through data and add rows for each item
            For i As Integer = 6 To 45 Step 4
                Dim itemName As String = SelectedRowData.Cells(i).Value.ToString()
                Dim quantity As String = SelectedRowData.Cells(i + 1).Value.ToString()
                Dim unitPrice As String = SelectedRowData.Cells(i + 2).Value.ToString()
                Dim amount As String = SelectedRowData.Cells(i + 3).Value.ToString()

                ' Add row if the item name is not blank
                If Not String.IsNullOrWhiteSpace(itemName) Then
                    DataGridView2.Rows.Add(itemName, quantity, unitPrice, amount)
                End If
            Next

            ' Calculate total amount
            Dim total As Double = 0
            For Each row As DataGridViewRow In DataGridView2.Rows
                If Not row.IsNewRow AndAlso Not IsDBNull(row.Cells(3).Value) Then
                    total += CDbl(row.Cells(3).Value)
                End If
            Next
            totalamount.Text = "₱" & total.ToString("0.00")

            LoadStatusFromDatabase()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateAndTime.Text = Date.Now.ToString("dd-MM-yyyy   hh:mm:ss")
    End Sub

    Private Sub DisableAllButtons()
        approvebtn2.Enabled = False


    End Sub



    Public Sub deductionbudget()
        Dim department As String = text3.Text.Trim().ToUpper()
        Dim amountWithSign As String = totalamount.Text
        Dim amountWithoutSign As String = amountWithSign.Replace("₱", "").Trim()
        Dim amountToDeduct As Double

        If Not String.IsNullOrEmpty(amountWithoutSign) AndAlso Double.TryParse(amountWithoutSign, amountToDeduct) Then
            Dim query As String = ""

            Select Case department
                Case "LRC"
                    query = $"UPDATE budget SET budgetamount = budgetamount - {amountToDeduct.ToString()} WHERE budgetid = 1"
                Case "ADMISSION"
                    query = $"UPDATE budget SET  budgetamount = budgetamount - {amountToDeduct.ToString()} WHERE budgetid = 2"
                Case "ITSO"
                    query = $"UPDATE budget SET  budgetamount = budgetamount - {amountToDeduct.ToString()} WHERE budgetid = 3"
                Case "FACULTY"
                    query = $"UPDATE budget SET  budgetamount = budgetamount - {amountToDeduct.ToString()} WHERE budgetid = 4"
                Case "ACCOUNTING"
                    query = $"UPDATE budget SET  budgetamount = budgetamount - {amountToDeduct.ToString()} WHERE budgetid = 5"
                Case Else
                    MessageBox.Show("Invalid department")
                    Return
            End Select

            ' Execute the query
            Try
                Using connection As New MySqlConnection(str)
                    Dim command As New MySqlCommand(query, connection)
                    connection.Open()
                    command.ExecuteNonQuery()
                    admindashboardclient.budgetforadmission()
                    admindashboardclient.budgetforfaculty()
                    admindashboardclient.budgetforitso()
                    admindashboardclient.budgetforlrc()
                    admindashboardclient.budgetforaccounting()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error updating budget: " & ex.Message)
            End Try
        Else
        End If
    End Sub


    Public Sub deductstocks()
        Dim connectionString As String = "server=localhost;uid=root;pwd=;database=nufvdb;"

        For Each row As DataGridViewRow In DataGridView2.Rows
            If Not row.IsNewRow Then
                Dim itemName As String = row.Cells(0).Value.ToString()
                Dim quantity As Integer = Integer.Parse(row.Cells(1).Value.ToString())

                Dim query As String = "UPDATE tbl_officesupply SET ItemStock = ItemStock - @Quantity WHERE ItemName = @ItemName"

                Using connection As New MySqlConnection(connectionString)
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Quantity", quantity)
                        command.Parameters.AddWithValue("@ItemName", itemName)
                        connection.Open()
                        command.ExecuteNonQuery()
                    End Using
                End Using
            End If
        Next

        MessageBox.Show("Stocks reduced successfully.")
    End Sub


    Private Sub MakeCircular(panel As Panel)
        Dim diameter As Integer = Math.Min(panel.Width, panel.Height)
        Dim path As New Drawing2D.GraphicsPath()
        path.AddEllipse(0, 0, diameter, diameter)
        panel.Size = New Size(diameter, diameter)
        panel.Region = New Region(path)
    End Sub

    Private Sub approvebtn2_Click(sender As Object, e As EventArgs) Handles approvebtn2.Click
        If MessageBox.Show("Are you sure you want to APPROVE this request?", "NUFV-AMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            UpdateStatusInDatabase("Approved", 1)
            deductionbudget()
            deductstocks()
            EmailSentrelease()
            Form1.DataGridView_load()
            Approver_Dashboard_Sirjed.Loadtotalpending()
            Approver_Dashboard_Sirjed.LoadtotalRequest()

            userdashboardlrc.Loadtotalpending()
            userdashboardlrc.LoadtotalRequest()
            LRC_Approver_dashboard.Loadtotalpending()
            LRC_Approver_dashboard.LoadtotalRequest()

            userdashboardaccounting.Loadtotalpending()
            userdashboardaccounting.LoadtotalRequest()
            Accounting_Approver_dashboard.Loadtotalpending()
            Accounting_Approver_dashboard.LoadtotalRequest()

            userdashboardITSO.Loadtotalpending()
            userdashboardITSO.LoadtotalRequest()
            ITSO_Approver_dashboard.Loadtotalpending()
            ITSO_Approver_dashboard.LoadtotalRequest()

            Dashboard_AccountingRelease.LoadtotalRequest()

            userdashboardadmission.Loadtotalpending()
            userdashboardadmission.LoadtotalRequest()
            Admission_Approver_dashboard.Loadtotalpending()
            Admission_Approver_dashboard.LoadtotalRequest()
            MoveRowsToHistory()
            ApproverRelease_RequestTracker.DataGridView_load()
            Approvalrelease_RequestHistory.DataGridView_load()
        End If
    End Sub



    Private Sub approvebtn3_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Are you sure you want to APPROVE this request?", "NUFV-AMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            UpdateStatusInDatabase("Approved", 3)
        End If
    End Sub

    Private Sub rejectbtn3_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Are you sure you want to REJECT this request?", "NUFV-AMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            UpdateStatusInDatabase("Rejected", 3)
            UpdateAllStatusInDatabase("Rejected")
        End If
    End Sub



    Private Sub UpdateStatusInDatabase(ByVal finalStatus As String, ByVal stage As Integer)
        Try
            con.Open()
            Dim query As String = "UPDATE table_osrequest SET release1 = @release, " &
                              "approved_date_1 = IF(@release = 'Approved', CURDATE(), approved_date_1) " &
                              "WHERE requestID = @requestID"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@release", finalStatus)
            cmd.Parameters.AddWithValue("@requestID", SelectedRowData.Cells(0).Value)
            cmd.ExecuteNonQuery()
            con.Close()

            LoadStatusFromDatabase()

            RaiseEvent StatusUpdated(finalStatus, GetStatusColor(finalStatus))
        Catch ex As Exception
            MessageBox.Show("Error updating status in the database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub





    Private Sub UpdateAllStatusInDatabase(ByVal finalStatus As String)
        Try
            con.Open()

            ' Update only release1
            Dim statusColumn As String = "release1" ' Hardcoding to update release1
            Dim query As String = $"UPDATE table_osrequest SET {statusColumn} = @release WHERE requestID = @requestID"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@release", finalStatus)
            cmd.Parameters.AddWithValue("@requestID", SelectedRowData.Cells(0).Value)
            cmd.ExecuteNonQuery()

            con.Close()

            ' Update UI based on status change
            LoadStatusFromDatabase()

            ' Raise event
            RaiseEvent StatusUpdated(finalStatus, GetStatusColor(finalStatus))
        Catch ex As Exception
            MessageBox.Show("Error updating status in the database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub



    Private Sub LoadStatusFromDatabase()
        Dim requestID As Integer = SelectedRowData.Cells(0).Value

        ' Execute a SQL query to retrieve status information for the given requestID
        Dim query As String = "SELECT status1, status2, status3, approved_date_1, rejected_date_1, approved_date_2, rejected_date_2, approved_date_3, rejected_date_3 FROM table_osrequest WHERE requestID = @requestID"
        Dim cmd As New MySqlCommand(query, con)
        cmd.Parameters.AddWithValue("@requestID", requestID)

        Try
            con.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim status1 As String = reader("status1").ToString()
                Dim status2 As String = reader("status2").ToString()
                Dim status3 As String = reader("status3").ToString()

                Dim approvedDateTime1 As DateTime = If(reader("approved_date_1") IsNot DBNull.Value, CType(reader("approved_date_1"), DateTime), DateTime.MinValue)
                Dim rejectedDateTime1 As DateTime = If(reader("rejected_date_1") IsNot DBNull.Value, CType(reader("rejected_date_1"), DateTime), DateTime.MinValue)
                Dim approvedDateTime2 As DateTime = If(reader("approved_date_2") IsNot DBNull.Value, CType(reader("approved_date_2"), DateTime), DateTime.MinValue)
                Dim rejectedDateTime2 As DateTime = If(reader("rejected_date_2") IsNot DBNull.Value, CType(reader("rejected_date_2"), DateTime), DateTime.MinValue)
                Dim approvedDateTime3 As DateTime = If(reader("approved_date_3") IsNot DBNull.Value, CType(reader("approved_date_3"), DateTime), DateTime.MinValue)
                Dim rejectedDateTime3 As DateTime = If(reader("rejected_date_3") IsNot DBNull.Value, CType(reader("rejected_date_3"), DateTime), DateTime.MinValue)

                UpdateUIStatus(status1, 1, approvedDateTime1, rejectedDateTime1)
                UpdateUIStatus(status2, 2, approvedDateTime2, rejectedDateTime2)
                UpdateUIStatus(status3, 3, approvedDateTime3, rejectedDateTime3)

            End If
        Catch ex As Exception
            MessageBox.Show("Error loading status from the database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub UpdateUIStatus(ByVal finalStatus As String, ByVal stage As Integer, ByVal approvedDateTime As DateTime, ByVal rejectedDateTime As DateTime)
        Dim formattedApprovedDateTime As String = If(approvedDateTime <> DateTime.MinValue, approvedDateTime.ToString("dd-MM-yyyy "), "")
        Dim formattedRejectedDateTime As String = If(rejectedDateTime <> DateTime.MinValue, rejectedDateTime.ToString("dd-MM-yyyy "), "")

        Select Case finalStatus
            Case "Approved"
                If stage = 1 Then
                    button1Clicked = False
                    status1.Text = "Approved!"
                    dt1.Text = formattedApprovedDateTime
                    statuspanel1.BackColor = Color.Green
                    Panel3.BackColor = Color.Green
                    status1.Visible = True
                    dt1.Visible = True
                    EnableNextButtons()
                ElseIf stage = 2 Then
                    status2.Text = "Approved!"
                    dt2.Text = formattedApprovedDateTime
                    statuspanel2.BackColor = Color.Green

                    status2.Visible = True
                    dt2.Visible = True
                    EnableNextButtons()
                ElseIf stage = 3 Then
                    DisableAllButtons()
                End If
            Case "Rejected"
                If stage = 1 Then
                    button1Clicked = True
                    status1.Text = "Rejected!"
                    dt1.Text = formattedRejectedDateTime
                    statuspanel1.BackColor = Color.Red
                    Panel3.BackColor = Color.Red
                    status1.Visible = True
                    dt1.Visible = True

                ElseIf stage = 2 Then
                    status2.Text = "Rejected!"
                    dt2.Text = formattedRejectedDateTime
                    statuspanel2.BackColor = Color.Red

                    status2.Visible = True
                    dt2.Visible = True

                ElseIf stage = 3 Then
                    DisableAllButtons()

                End If
        End Select
    End Sub


    Private Function GetStatusColor(ByVal status As String) As Color
        Select Case status
            Case "Approved"
                Return Color.Green
            Case "Rejected"
                Return Color.Red
            Case Else
                Return Color.Black
        End Select
    End Function




    Private Sub MoveRowsToHistory()
        Try
            If con.State <> ConnectionState.Closed Then
                con.Close()
            End If

            con.Open()

            Dim cmd As New MySqlCommand("INSERT INTO table_requesthistory SELECT * FROM table_osrequest WHERE release1 IN ('Approved', 'Rejected')", con)
            cmd.ExecuteNonQuery()

            ' Delete the rows from table_osrequest after moving them to history
            cmd = New MySqlCommand("DELETE FROM table_osrequest WHERE release1 IN ('Approved', 'Rejected')", con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

        ' Reload the DataGridView after moving rows to history
        HeadApproval1_RequestTrackerApprover.DataGridView_load()
    End Sub



    Private Sub text4_TextChanged(sender As Object, e As EventArgs) Handles text4.TextChanged

    End Sub
End Class