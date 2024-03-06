Imports MySql.Data.MySqlClient

Public Class Accounting_ReqTracClicked
    ' Connection to the database'
    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb; convert zero datetime=True"
    Dim con As New MySqlConnection(str)

    Public Property SelectedRowData As DataGridViewRow

    Private Sub Accounting_ReqTracClicked_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            ' Load status updates
            LoadStatusFromDatabase()

            ' Apply circular style
            MakeCircular(statuspanel1)
            MakeCircular(statuspanel2)
        End If
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

                ' Update UI with status updates
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
        ' Display status updates without buttons
        Dim formattedApprovedDateTime As String = If(approvedDateTime <> DateTime.MinValue, approvedDateTime.ToString("dd-MM-yyyy "), "")
        Dim formattedRejectedDateTime As String = If(rejectedDateTime <> DateTime.MinValue, rejectedDateTime.ToString("dd-MM-yyyy "), "")

        Select Case stage
            Case 1
                status1.Text = finalStatus
                dt1.Text = If(finalStatus = "Approved", formattedApprovedDateTime, formattedRejectedDateTime)
                If finalStatus = "Approved" Then
                    statuspanel1.BackColor = Color.Green
                    Panel3.BackColor = Color.Green
                ElseIf finalStatus = "Rejected" Then
                    statuspanel1.BackColor = Color.Red
                    Panel3.BackColor = Color.Red
                End If
            Case 2
                status2.Text = finalStatus
                dt2.Text = If(finalStatus = "Approved", formattedApprovedDateTime, formattedRejectedDateTime)
                If finalStatus = "Approved" Then
                    statuspanel2.BackColor = Color.Green
                ElseIf finalStatus = "Rejected" Then
                    statuspanel2.BackColor = Color.Red
                End If
        End Select
    End Sub


    Private Sub MakeCircular(panel As Panel)
        Dim diameter As Integer = Math.Min(panel.Width, panel.Height) ' Use the smaller dimension as diameter
        Dim path As New Drawing2D.GraphicsPath()
        path.AddEllipse(0, 0, diameter, diameter) ' Use diameter for both width and height
        panel.Size = New Size(diameter, diameter)
        panel.Region = New Region(path)
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class