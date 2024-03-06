Public Class admindashboardapprover
    Private Const CS_DROPSHADOW As Integer = 131072
    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property
    ' ^^^ dropshadow for windows form



    Private Sub admindashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        Label11.Text = Date.Now.ToString("dd MMM yyyy     hh:mm:ss")
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)
        Panel2.BackColor = Color.FromArgb(255, 53, 64, 142)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)
        Panel1.BackColor = Color.FromArgb(255, 53, 64, 142)
    End Sub


    Private Sub Panel4_Paint_1(sender As Object, e As PaintEventArgs)
        Panel4.BackColor = Color.FromArgb(255, 242, 190, 34)
    End Sub

    Private Sub pcbmenuicon_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click

    End Sub
End Class