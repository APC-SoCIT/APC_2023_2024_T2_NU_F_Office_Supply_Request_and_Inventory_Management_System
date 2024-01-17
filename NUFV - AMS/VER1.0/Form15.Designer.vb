<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form15
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
        Me.txtboxpaaymentid = New System.Windows.Forms.TextBox()
        Me.txtboxamountvalue = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxcard = New System.Windows.Forms.TextBox()
        Me.lblcrdnumber = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn1submit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'txtboxpaaymentid
        '
        Me.txtboxpaaymentid.Location = New System.Drawing.Point(22, 97)
        Me.txtboxpaaymentid.Name = "txtboxpaaymentid"
        Me.txtboxpaaymentid.Size = New System.Drawing.Size(121, 20)
        Me.txtboxpaaymentid.TabIndex = 0
        '
        'txtboxamountvalue
        '
        Me.txtboxamountvalue.Location = New System.Drawing.Point(22, 211)
        Me.txtboxamountvalue.Name = "txtboxamountvalue"
        Me.txtboxamountvalue.Size = New System.Drawing.Size(121, 20)
        Me.txtboxamountvalue.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Cash", "Card"})
        Me.ComboBox1.Location = New System.Drawing.Point(22, 152)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(230, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(311, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Product Order / Customer Information / Payment"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 37)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Basic Details"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(18, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Payment ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(18, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Payment Option"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtboxcard
        '
        Me.txtboxcard.Location = New System.Drawing.Point(273, 153)
        Me.txtboxcard.Name = "txtboxcard"
        Me.txtboxcard.Size = New System.Drawing.Size(208, 20)
        Me.txtboxcard.TabIndex = 20
        '
        'lblcrdnumber
        '
        Me.lblcrdnumber.AutoSize = True
        Me.lblcrdnumber.BackColor = System.Drawing.Color.Transparent
        Me.lblcrdnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcrdnumber.ForeColor = System.Drawing.Color.Black
        Me.lblcrdnumber.Location = New System.Drawing.Point(323, 129)
        Me.lblcrdnumber.Name = "lblcrdnumber"
        Me.lblcrdnumber.Size = New System.Drawing.Size(114, 20)
        Me.lblcrdnumber.TabIndex = 21
        Me.lblcrdnumber.Text = "Card Number"
        Me.lblcrdnumber.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(18, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Value"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn1submit
        '
        Me.btn1submit.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn1submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1submit.ForeColor = System.Drawing.Color.White
        Me.btn1submit.Location = New System.Drawing.Point(404, 229)
        Me.btn1submit.Name = "btn1submit"
        Me.btn1submit.Size = New System.Drawing.Size(154, 44)
        Me.btn1submit.TabIndex = 23
        Me.btn1submit.Text = "Submit"
        Me.btn1submit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Location = New System.Drawing.Point(-4, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(593, 31)
        Me.Panel1.TabIndex = 24
        '
        'Form15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(570, 285)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn1submit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblcrdnumber)
        Me.Controls.Add(Me.txtboxcard)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtboxamountvalue)
        Me.Controls.Add(Me.txtboxpaaymentid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form15"
        Me.Text = "Form15"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtboxpaaymentid As TextBox
    Friend WithEvents txtboxamountvalue As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtboxcard As TextBox
    Friend WithEvents lblcrdnumber As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn1submit As Button
    Friend WithEvents Panel1 As Panel
End Class
