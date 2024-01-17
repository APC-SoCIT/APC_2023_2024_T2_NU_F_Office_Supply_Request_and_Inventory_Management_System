<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtboxfname = New System.Windows.Forms.TextBox()
        Me.txtboxlname = New System.Windows.Forms.TextBox()
        Me.txtboxmname = New System.Windows.Forms.TextBox()
        Me.txtboxaddress = New System.Windows.Forms.TextBox()
        Me.txtboxemailaddress = New System.Windows.Forms.TextBox()
        Me.txtboxcustoid = New System.Windows.Forms.TextBox()
        Me.txtboxcontactinfo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn1submit = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'txtboxfname
        '
        Me.txtboxfname.Location = New System.Drawing.Point(19, 178)
        Me.txtboxfname.Name = "txtboxfname"
        Me.txtboxfname.Size = New System.Drawing.Size(175, 20)
        Me.txtboxfname.TabIndex = 0
        '
        'txtboxlname
        '
        Me.txtboxlname.Location = New System.Drawing.Point(208, 178)
        Me.txtboxlname.Name = "txtboxlname"
        Me.txtboxlname.Size = New System.Drawing.Size(173, 20)
        Me.txtboxlname.TabIndex = 1
        '
        'txtboxmname
        '
        Me.txtboxmname.Location = New System.Drawing.Point(392, 178)
        Me.txtboxmname.Name = "txtboxmname"
        Me.txtboxmname.Size = New System.Drawing.Size(175, 20)
        Me.txtboxmname.TabIndex = 2
        '
        'txtboxaddress
        '
        Me.txtboxaddress.Location = New System.Drawing.Point(18, 239)
        Me.txtboxaddress.Name = "txtboxaddress"
        Me.txtboxaddress.Size = New System.Drawing.Size(549, 20)
        Me.txtboxaddress.TabIndex = 3
        '
        'txtboxemailaddress
        '
        Me.txtboxemailaddress.Location = New System.Drawing.Point(19, 354)
        Me.txtboxemailaddress.Name = "txtboxemailaddress"
        Me.txtboxemailaddress.Size = New System.Drawing.Size(324, 20)
        Me.txtboxemailaddress.TabIndex = 3
        '
        'txtboxcustoid
        '
        Me.txtboxcustoid.Location = New System.Drawing.Point(19, 111)
        Me.txtboxcustoid.Name = "txtboxcustoid"
        Me.txtboxcustoid.Size = New System.Drawing.Size(116, 20)
        Me.txtboxcustoid.TabIndex = 4
        '
        'txtboxcontactinfo
        '
        Me.txtboxcontactinfo.Location = New System.Drawing.Point(19, 295)
        Me.txtboxcontactinfo.Name = "txtboxcontactinfo"
        Me.txtboxcontactinfo.Size = New System.Drawing.Size(175, 20)
        Me.txtboxcontactinfo.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 37)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Basic Details"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Customer ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(389, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Middle Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "First Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(15, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Contact Information"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(15, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(252, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Address City / State / Province"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(204, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Last Name"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(15, 331)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Email Address"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn1submit
        '
        Me.btn1submit.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn1submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1submit.ForeColor = System.Drawing.Color.White
        Me.btn1submit.Location = New System.Drawing.Point(413, 333)
        Me.btn1submit.Name = "btn1submit"
        Me.btn1submit.Size = New System.Drawing.Size(154, 44)
        Me.btn1submit.TabIndex = 13
        Me.btn1submit.Text = "Proceed"
        Me.btn1submit.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(256, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(311, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Product Order / Customer Information / Payment"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Location = New System.Drawing.Point(-2, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(598, 38)
        Me.Panel1.TabIndex = 16
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(594, 400)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn1submit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtboxcontactinfo)
        Me.Controls.Add(Me.txtboxcustoid)
        Me.Controls.Add(Me.txtboxemailaddress)
        Me.Controls.Add(Me.txtboxaddress)
        Me.Controls.Add(Me.txtboxmname)
        Me.Controls.Add(Me.txtboxlname)
        Me.Controls.Add(Me.txtboxfname)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form14"
        Me.Text = "Customer Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtboxfname As TextBox
    Friend WithEvents txtboxlname As TextBox
    Friend WithEvents txtboxmname As TextBox
    Friend WithEvents txtboxaddress As TextBox
    Friend WithEvents txtboxemailaddress As TextBox
    Friend WithEvents txtboxcustoid As TextBox
    Friend WithEvents txtboxcontactinfo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btn1submit As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
End Class
