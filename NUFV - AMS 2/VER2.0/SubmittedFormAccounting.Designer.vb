<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SubmittedFormAccounting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TimerPanelReduce = New System.Windows.Forms.Timer(Me.components)
        Me.TimerPanelIncrease = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerPanelReduce
        '
        Me.TimerPanelReduce.Interval = 1
        '
        'TimerPanelIncrease
        '
        Me.TimerPanelIncrease.Interval = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel2.Location = New System.Drawing.Point(-27, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1665, 77)
        Me.Panel2.TabIndex = 83
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.LoginandPassword.My.Resources.Resources.NULOGO2
        Me.PictureBox1.Location = New System.Drawing.Point(29, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1249, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 18)
        Me.Label10.TabIndex = 19
        '
        'Timer4
        '
        Me.Timer4.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 29)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Back to Home Page"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(464, 406)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(765, 77)
        Me.Guna2HtmlLabel1.TabIndex = 85
        Me.Guna2HtmlLabel1.Text = "Request Form Submitted"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.LoginandPassword.My.Resources.Resources.icons8_left_arrow_100
        Me.PictureBox3.Location = New System.Drawing.Point(6, 85)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 54)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 88
        Me.PictureBox3.TabStop = False
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Image = Global.LoginandPassword.My.Resources.Resources.icons8_check_48
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(358, 406)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox1.TabIndex = 86
        Me.Guna2CirclePictureBox1.TabStop = False
        Me.Guna2CirclePictureBox1.UseTransparentBackground = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.LoginandPassword.My.Resources.Resources.icons8_submit_document_100
        Me.PictureBox2.Location = New System.Drawing.Point(319, 377)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(139, 123)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 84
        Me.PictureBox2.TabStop = False
        '
        'SubmittedFormAccounting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1638, 844)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "SubmittedFormAccounting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TimerPanelReduce As Timer
    Friend WithEvents TimerPanelIncrease As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PictureBox2 As PictureBox
End Class
