<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ApproverDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ApproverDashboard))
        Me.TimerPanelReduce = New System.Windows.Forms.Timer(Me.components)
        Me.TimerPanelIncrease = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.displayfname = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.totalpendinglrc = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.totalrequestlrc = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel6.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Controls.Add(Me.displayfname)
        Me.Panel2.Controls.Add(Me.Label29)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel2.Location = New System.Drawing.Point(-13, -2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1805, 87)
        Me.Panel2.TabIndex = 67
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label28.Location = New System.Drawing.Point(1512, 55)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(60, 15)
        Me.Label28.TabIndex = 566
        Me.Label28.Text = "Approver"
        '
        'displayfname
        '
        Me.displayfname.AutoSize = True
        Me.displayfname.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayfname.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.displayfname.Location = New System.Drawing.Point(1541, 23)
        Me.displayfname.Name = "displayfname"
        Me.displayfname.Size = New System.Drawing.Size(64, 25)
        Me.displayfname.TabIndex = 565
        Me.displayfname.Text = "Name"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label29.Location = New System.Drawing.Point(1484, 23)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(64, 25)
        Me.Label29.TabIndex = 564
        Me.Label29.Text = "Hello,"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.LoginandPassword.My.Resources.Resources.icons8_menu_67__2_
        Me.PictureBox5.Location = New System.Drawing.Point(12, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(72, 87)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 67
        Me.PictureBox5.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.LoginandPassword.My.Resources.Resources.NULOGO2
        Me.PictureBox1.Location = New System.Drawing.Point(91, 7)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(5, 825)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "National University © 2023"
        '
        'Timer4
        '
        Me.Timer4.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Guna2Panel6.Controls.Add(Me.Label33)
        Me.Guna2Panel6.Controls.Add(Me.PictureBox8)
        Me.Guna2Panel6.Controls.Add(Me.Label25)
        Me.Guna2Panel6.Controls.Add(Me.Label26)
        Me.Guna2Panel6.Controls.Add(Me.Label35)
        Me.Guna2Panel6.Controls.Add(Me.Label36)
        Me.Guna2Panel6.Controls.Add(Me.Label37)
        Me.Guna2Panel6.Location = New System.Drawing.Point(24, 104)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(329, 100)
        Me.Guna2Panel6.TabIndex = 91
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label33.Location = New System.Drawing.Point(83, 54)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(142, 17)
        Me.Label33.TabIndex = 93
        Me.Label33.Text = "Collection of Requests "
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox8
        '
        Me.PictureBox8.ErrorImage = CType(resources.GetObject("PictureBox8.ErrorImage"), System.Drawing.Image)
        Me.PictureBox8.Image = Global.LoginandPassword.My.Resources.Resources.icons8_online_package_tracking_1001
        Me.PictureBox8.Location = New System.Drawing.Point(20, 15)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(57, 55)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 54
        Me.PictureBox8.TabStop = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label25.Location = New System.Drawing.Point(80, 34)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(130, 21)
        Me.Label25.TabIndex = 53
        Me.Label25.Text = "Request Tracker"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label26.Location = New System.Drawing.Point(257, 144)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(39, 17)
        Me.Label26.TabIndex = 52
        Me.Label26.Text = "NaN"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label35.Location = New System.Drawing.Point(257, 146)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(39, 17)
        Me.Label35.TabIndex = 49
        Me.Label35.Text = "NaN"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label36.Location = New System.Drawing.Point(407, 28)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(36, 17)
        Me.Label36.TabIndex = 40
        Me.Label36.Text = "Edit"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label37.Location = New System.Drawing.Point(14, 15)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(0, 17)
        Me.Label37.TabIndex = 37
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.totalpendinglrc)
        Me.Panel5.Location = New System.Drawing.Point(1364, 104)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(226, 134)
        Me.Panel5.TabIndex = 96
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label17.Location = New System.Drawing.Point(31, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(159, 32)
        Me.Label17.TabIndex = 84
        Me.Label17.Text = "Total Pending"
        '
        'totalpendinglrc
        '
        Me.totalpendinglrc.AutoSize = True
        Me.totalpendinglrc.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalpendinglrc.Location = New System.Drawing.Point(92, 57)
        Me.totalpendinglrc.Name = "totalpendinglrc"
        Me.totalpendinglrc.Size = New System.Drawing.Size(56, 65)
        Me.totalpendinglrc.TabIndex = 85
        Me.totalpendinglrc.Text = "0"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.totalrequestlrc)
        Me.Panel3.Location = New System.Drawing.Point(1109, 104)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(226, 134)
        Me.Panel3.TabIndex = 95
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(32, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 32)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Total Request"
        '
        'totalrequestlrc
        '
        Me.totalrequestlrc.AutoSize = True
        Me.totalrequestlrc.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalrequestlrc.Location = New System.Drawing.Point(90, 57)
        Me.totalrequestlrc.Name = "totalrequestlrc"
        Me.totalrequestlrc.Size = New System.Drawing.Size(56, 65)
        Me.totalrequestlrc.TabIndex = 83
        Me.totalrequestlrc.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(1554, 821)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Privacy Policy"
        '
        'ApproverDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1638, 844)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Guna2Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ApproverDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel6.ResumeLayout(False)
        Me.Guna2Panel6.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimerPanelReduce As Timer
    Friend WithEvents TimerPanelIncrease As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Label28 As Label
    Friend WithEvents displayfname As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label33 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents totalpendinglrc As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents totalrequestlrc As Label
    Friend WithEvents Label5 As Label
End Class
