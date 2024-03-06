Public Class test
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        colorchange.BackColor = Color.Red

    End Sub

    Private Sub colorchange_Paint(sender As Object, e As PaintEventArgs) Handles colorchange.Paint

    End Sub
End Class