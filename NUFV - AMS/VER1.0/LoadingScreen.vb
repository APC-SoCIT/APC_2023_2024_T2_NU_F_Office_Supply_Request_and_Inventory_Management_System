Public Class LoadingScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label2.Text = ProgressBar1.Value & "%"

        ProgressBar1.Value += 3.52

        If ProgressBar1.Value > 10 Then
            lblstatus.Text = "Loading..."
        End If

        If ProgressBar1.Value > 35 Then
            lblstatus.Text = "Loading."
        End If

        If ProgressBar1.Value > 65 Then
            lblstatus.Text = "Loading.."
        End If

        If ProgressBar1.Value > 70 Then
            lblstatus.Text = "Loading..."
        End If

        If ProgressBar1.Value > 75 Then
            lblstatus.Text = "Loading."
        End If

        If ProgressBar1.Value > 80 Then
            lblstatus.Text = "Loading.."
        End If

        If ProgressBar1.Value > 94 Then
            lblstatus.Text = "Done!"
        End If

        If ProgressBar1.Value = 100 Then
            lblstatus.Text = "Done!"
            LoginForm.Show()
            Me.Hide()
            Timer1.Dispose()
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Panel1.BackColor = Color.FromArgb(255, 53, 64, 142)
    End Sub

    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class