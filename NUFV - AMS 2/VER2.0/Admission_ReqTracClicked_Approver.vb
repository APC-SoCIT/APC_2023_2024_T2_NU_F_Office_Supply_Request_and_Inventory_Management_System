Imports MySql.Data.MySqlClient
Imports System.Net.Mail

Public Class Admission_ReqTracClicked_Approver
    ' Connection to the database'
    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb; convert zero datetime=True"
    Dim con As New MySqlConnection(str)

    Public Event StatusUpdated(ByVal statusText As String, ByVal statusColor As Color)

    Private button1Clicked As Boolean = False
    Private button2Clicked As Boolean = False

    Public Property SelectedRowData As DataGridViewRow

    Private Sub Admission_ReqTracClicked_Approver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        status1.Text = "Pending Request"
        status2.Text = "Pending Request"

        dt1.Visible = False
        dt2.Visible = False

        HideAllButtons()
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
        DateandTime.Text = Date.Now.ToString("dd-MM-yyyy   hh:mm:ss")
    End Sub

    Private Sub HideAllButtons()


    End Sub

    Public Sub EmailSentReject()
        Dim email_add As String = "kylehora2023@myyahoo.com"
        Dim email_pass As String = "afdsznkeesgndcsa"
        Dim email_receiver As String = "horakm@students.nu-fairview.edu.ph"
        Dim email_subject As String = "Request Form Notification"
        Dim email_body As String = "We regret to inform you that your request has been Rejected"
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


    Private Sub EnableNextButtons()
        If button1Clicked AndAlso Not button2Clicked Then

            approvebtn1.Enabled = False
            rejectbtn1.Enabled = False
        ElseIf button2Clicked Then


        End If
    End Sub

    Private Sub MakeCircular(panel As Panel)
        Dim diameter As Integer = Math.Min(panel.Width, panel.Height) ' Use the smaller dimension as diameter
        Dim path As New Drawing2D.GraphicsPath()
        path.AddEllipse(0, 0, diameter, diameter) ' Use diameter for both width and height
        panel.Size = New Size(diameter, diameter)
        panel.Region = New Region(path)
    End Sub

    Private Sub approvebtn1_Click(sender As Object, e As EventArgs) Handles approvebtn1.Click
        If MessageBox.Show("Are you sure you want to APPROVE this request?", "NUFV-AMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            UpdateStatusInDatabase("Approved", 1)
        End If
    End Sub


    Private Sub MoveRowsToHistory()
        Try
            If con.State <> ConnectionState.Closed Then
                con.Close()
            End If

            con.Open()

            Dim cmd As New MySqlCommand("INSERT INTO table_requesthistory SELECT * FROM table_osrequest WHERE status1 IN ('Rejected')", con)
            cmd.ExecuteNonQuery()

            ' Delete the rows from table_osrequest after moving them to history
            cmd = New MySqlCommand("DELETE FROM table_osrequest WHERE status1 IN ('Rejected')", con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub



    Private Sub rejectbtn1_Click(sender As Object, e As EventArgs) Handles rejectbtn1.Click
        If MessageBox.Show("Are you sure you want to REJECT this request?", "NUFV-AMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            UpdateStatusInDatabase("Rejected", 1)
            UpdateAllStatusInDatabase("Rejected")
            EmailSentReject()
            MoveRowsToHistory()
            Admission_Approver_dashboard.Loadtotalpending()
            Admission_Approver_dashboard.LoadtotalRequest()
            Admission_ReqTrackApprover.DataGridView_load()
        End If
    End Sub

    Private Sub approvebtn2_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Are you sure you want to APPROVE this request?", "NUFV-AMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            UpdateStatusInDatabase("Approved", 2)
        End If
    End Sub

    Private Sub rejectbtn2_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Are you sure you want to REJECT this request?", "NUFV-AMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            UpdateStatusInDatabase("Rejected", 2)
            UpdateAllStatusInDatabase("Rejected")
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

    Private Sub DisableAllButtons()
        approvebtn1.Enabled = False
        rejectbtn1.Enabled = False


    End Sub

    Private Sub UpdateStatusInDatabase(ByVal finalStatus As String, ByVal stage As Integer)
        Try
            con.Open()
            Dim statusColumn As String = $"status{stage}" ' Determine the status column based on the stage

            Dim approveDateColumn As String = $"approved_date_{stage}"
            Dim rejectDateColumn As String = $"rejected_date_{stage}"

            Dim query As String = $"UPDATE table_osrequest SET {statusColumn} = @status, " &
                                  $"{approveDateColumn} = IF(@status = 'Approved', CURDATE(), {approveDateColumn}), " &
                                  $"{rejectDateColumn} = IF(@status = 'Rejected', CURDATE(), {rejectDateColumn}) " &
                                  "WHERE requestID = @requestID"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@status", finalStatus)
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
                    button1Clicked = True
                    status1.Text = "Approved!"
                    dt1.Text = formattedApprovedDateTime
                    statuspanel1.BackColor = Color.Green
                    Panel3.BackColor = Color.Green
                    status1.Visible = True
                    dt1.Visible = True
                    EnableNextButtons()
                ElseIf stage = 2 Then
                    button2Clicked = True
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
                    DisableAllButtons()
                ElseIf stage = 2 Then
                    button2Clicked = True
                    status2.Text = "Rejected!"
                    dt2.Text = formattedRejectedDateTime
                    statuspanel2.BackColor = Color.Red

                    status2.Visible = True
                    dt2.Visible = True
                    DisableAllButtons()
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

    Private Sub UpdateAllStatusInDatabase(ByVal finalStatus As String)
        Try
            con.Open()

            For stage As Integer = 1 To 3
                Dim statusColumn As String = $"status{stage}" ' Determine the status column based on the stage
                Dim query As String = $"UPDATE table_osrequest SET {statusColumn} = @status WHERE requestID = @requestID"
                Dim cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@status", finalStatus)
                cmd.Parameters.AddWithValue("@requestID", SelectedRowData.Cells(0).Value)
                cmd.ExecuteNonQuery()
            Next

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
End Class