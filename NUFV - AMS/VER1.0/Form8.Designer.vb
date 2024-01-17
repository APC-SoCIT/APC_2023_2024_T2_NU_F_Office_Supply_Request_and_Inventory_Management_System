<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.rprtbtn = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 109)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(750, 247)
        Me.DataGridView1.TabIndex = 0
        '
        'rprtbtn
        '
        Me.rprtbtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.rprtbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rprtbtn.ForeColor = System.Drawing.Color.White
        Me.rprtbtn.Location = New System.Drawing.Point(380, 362)
        Me.rprtbtn.Name = "rprtbtn"
        Me.rprtbtn.Size = New System.Drawing.Size(101, 39)
        Me.rprtbtn.TabIndex = 1
        Me.rprtbtn.Text = "Report"
        Me.rprtbtn.UseVisualStyleBackColor = False
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.MidnightBlue
        Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back.ForeColor = System.Drawing.Color.White
        Me.back.Location = New System.Drawing.Point(380, 407)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(93, 30)
        Me.back.TabIndex = 2
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(-5, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(814, 84)
        Me.Panel1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(379, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 33)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Left Join"
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.rprtbtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form8"
        Me.Text = "Left Join "
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents rprtbtn As Button
    Friend WithEvents back As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
End Class
