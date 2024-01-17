<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DbaccessDataSet1 = New LoginandPassword.dbaccessDataSet()
        Me.TableAdapterManager1 = New LoginandPassword.dbaccessDataSet1TableAdapters.TableAdapterManager()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.textboxpassword = New System.Windows.Forms.TextBox()
        Me.textboxusername = New System.Windows.Forms.TextBox()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.btn1_Submit = New System.Windows.Forms.Button()
        CType(Me.DbaccessDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(158, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 22)
        Me.Label2.TabIndex = 5
        '
        'DbaccessDataSet1
        '
        Me.DbaccessDataSet1.DataSetName = "dbaccessDataSet"
        Me.DbaccessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.tbl_productTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = LoginandPassword.dbaccessDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(327, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(298, 355)
        Me.Panel3.TabIndex = 41
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Goldenrod
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Button2.Location = New System.Drawing.Point(0, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 36)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Direct dashboard"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.LoginandPassword.My.Resources.Resources.NULOGO2
        Me.PictureBox3.Location = New System.Drawing.Point(89, 25)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(123, 130)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(60, 191)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(190, 18)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Inventory made smart"""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(46, 171)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(210, 18)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = """Requesting made simple"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label20.Location = New System.Drawing.Point(90, 297)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(124, 24)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = "Login Page"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Goldenrod
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Button1.Location = New System.Drawing.Point(201, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 36)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Direct dashboard"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(34, 158)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 24)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Password"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(34, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 24)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Username"
        '
        'textboxpassword
        '
        Me.textboxpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textboxpassword.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxpassword.Location = New System.Drawing.Point(31, 187)
        Me.textboxpassword.Name = "textboxpassword"
        Me.textboxpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textboxpassword.Size = New System.Drawing.Size(254, 29)
        Me.textboxpassword.TabIndex = 3
        '
        'textboxusername
        '
        Me.textboxusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textboxusername.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxusername.Location = New System.Drawing.Point(31, 88)
        Me.textboxusername.Name = "textboxusername"
        Me.textboxusername.Size = New System.Drawing.Size(254, 29)
        Me.textboxusername.TabIndex = 2
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = Global.LoginandPassword.My.Resources.Resources.icons8_password_50
        Me.GunaPictureBox2.Location = New System.Drawing.Point(251, 189)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(28, 24)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox2.TabIndex = 28
        Me.GunaPictureBox2.TabStop = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.LoginandPassword.My.Resources.Resources.icons8_id_50
        Me.GunaPictureBox1.Location = New System.Drawing.Point(252, 91)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(28, 24)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 27
        Me.GunaPictureBox1.TabStop = False
        '
        'btn1_Submit
        '
        Me.btn1_Submit.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn1_Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn1_Submit.FlatAppearance.BorderSize = 0
        Me.btn1_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1_Submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1_Submit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn1_Submit.Image = Global.LoginandPassword.My.Resources.Resources.icons8_sign_in_40658568568
        Me.btn1_Submit.Location = New System.Drawing.Point(84, 256)
        Me.btn1_Submit.Name = "btn1_Submit"
        Me.btn1_Submit.Size = New System.Drawing.Size(136, 48)
        Me.btn1_Submit.TabIndex = 0
        Me.btn1_Submit.Text = " Login"
        Me.btn1_Submit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn1_Submit.UseVisualStyleBackColor = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(625, 353)
        Me.ControlBox = False
        Me.Controls.Add(Me.GunaPictureBox2)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn1_Submit)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.textboxpassword)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.textboxusername)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Page"
        CType(Me.DbaccessDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents DbaccessDataSet1 As dbaccessDataSet
    Friend WithEvents TableAdapterManager1 As dbaccessDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btn1_Submit As Button
    Friend WithEvents textboxpassword As TextBox
    Friend WithEvents textboxusername As TextBox
    Friend WithEvents Button2 As Button
End Class
