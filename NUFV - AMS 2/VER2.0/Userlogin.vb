Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Userlogin
    Dim str As String = "server=localhost; uid=root; pwd=; database=nufarosimdb"
    Dim con As New MySqlConnection(str)

    Private Const CS_DROPSHADOW As Integer = 131072
    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Sub load()
        Dim query As String = "Select * from useracc"
        Dim adpt As New MySqlDataAdapter(query, con)
        con.Close()
    End Sub

    Private Sub Userlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn1_Submit_Click(sender As Object, e As EventArgs) Handles btn1_Submit.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoginForm.Show()
        Me.Close()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Panel1.BackColor = Color.FromArgb(255, 53, 64, 142)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Panel1.BackColor = Color.FromArgb(255, 53, 64, 142)
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint
        Panel3.BackColor = Color.FromArgb(255, 242, 190, 34)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class