<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.frm4_search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.frm4_update = New System.Windows.Forms.Button()
        Me.frm4_delete = New System.Windows.Forms.Button()
        Me.productid = New System.Windows.Forms.TextBox()
        Me.productname = New System.Windows.Forms.TextBox()
        Me.productdesc = New System.Windows.Forms.TextBox()
        Me.productprice = New System.Windows.Forms.TextBox()
        Me.wsale = New System.Windows.Forms.TextBox()
        Me.stocks = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.exportbtn = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 95)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(664, 333)
        Me.DataGridView1.TabIndex = 44
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(3, 677)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "LOGIN PAGE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(588, 677)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 23)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frm4_search
        '
        Me.frm4_search.Location = New System.Drawing.Point(375, 678)
        Me.frm4_search.Name = "frm4_search"
        Me.frm4_search.Size = New System.Drawing.Size(209, 20)
        Me.frm4_search.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(312, 681)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Search"
        '
        'frm4_update
        '
        Me.frm4_update.BackColor = System.Drawing.Color.MidnightBlue
        Me.frm4_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frm4_update.ForeColor = System.Drawing.Color.White
        Me.frm4_update.Location = New System.Drawing.Point(14, 441)
        Me.frm4_update.Name = "frm4_update"
        Me.frm4_update.Size = New System.Drawing.Size(75, 33)
        Me.frm4_update.TabIndex = 50
        Me.frm4_update.Text = "Update"
        Me.frm4_update.UseVisualStyleBackColor = False
        '
        'frm4_delete
        '
        Me.frm4_delete.BackColor = System.Drawing.Color.MidnightBlue
        Me.frm4_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frm4_delete.ForeColor = System.Drawing.Color.White
        Me.frm4_delete.Location = New System.Drawing.Point(96, 441)
        Me.frm4_delete.Name = "frm4_delete"
        Me.frm4_delete.Size = New System.Drawing.Size(75, 33)
        Me.frm4_delete.TabIndex = 51
        Me.frm4_delete.Text = "Delete"
        Me.frm4_delete.UseVisualStyleBackColor = False
        '
        'productid
        '
        Me.productid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.productid.Location = New System.Drawing.Point(153, 511)
        Me.productid.Name = "productid"
        Me.productid.Size = New System.Drawing.Size(98, 13)
        Me.productid.TabIndex = 52
        '
        'productname
        '
        Me.productname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.productname.Location = New System.Drawing.Point(154, 535)
        Me.productname.Name = "productname"
        Me.productname.Size = New System.Drawing.Size(265, 13)
        Me.productname.TabIndex = 53
        '
        'productdesc
        '
        Me.productdesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.productdesc.Location = New System.Drawing.Point(154, 561)
        Me.productdesc.Name = "productdesc"
        Me.productdesc.Size = New System.Drawing.Size(434, 13)
        Me.productdesc.TabIndex = 54
        '
        'productprice
        '
        Me.productprice.Location = New System.Drawing.Point(154, 587)
        Me.productprice.Name = "productprice"
        Me.productprice.Size = New System.Drawing.Size(206, 20)
        Me.productprice.TabIndex = 61
        '
        'wsale
        '
        Me.wsale.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.wsale.Location = New System.Drawing.Point(154, 611)
        Me.wsale.Name = "wsale"
        Me.wsale.Size = New System.Drawing.Size(206, 13)
        Me.wsale.TabIndex = 62
        '
        'stocks
        '
        Me.stocks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.stocks.Location = New System.Drawing.Point(154, 639)
        Me.stocks.Name = "stocks"
        Me.stocks.Size = New System.Drawing.Size(129, 13)
        Me.stocks.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MS Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(71, 516)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Product ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MS Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(58, 542)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Product Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("MS Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 569)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 13)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Product Description"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("MS Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(50, 595)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Product Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("MS Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(37, 619)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Wholesale Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("MS Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(99, 643)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Stocks"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(227, 676)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 83
        Me.Button3.Text = "REFRESH"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("MS PGothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(205, 59)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(281, 33)
        Me.Label14.TabIndex = 84
        Me.Label14.Text = "Product Information"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.LoginandPassword.My.Resources.Resources.icon_1_1s_257px_1
        Me.PictureBox1.Location = New System.Drawing.Point(566, 441)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 85
        Me.PictureBox1.TabStop = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(258, 441)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(89, 33)
        Me.Button6.TabIndex = 88
        Me.Button6.Text = "SUM"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(177, 441)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 33)
        Me.Button4.TabIndex = 89
        Me.Button4.Text = "Left Join"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'exportbtn
        '
        Me.exportbtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.exportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exportbtn.ForeColor = System.Drawing.Color.White
        Me.exportbtn.Location = New System.Drawing.Point(353, 441)
        Me.exportbtn.Name = "exportbtn"
        Me.exportbtn.Size = New System.Drawing.Size(99, 33)
        Me.exportbtn.TabIndex = 90
        Me.exportbtn.Text = "Export"
        Me.exportbtn.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(104, 676)
        Me.Button7.Margin = New System.Windows.Forms.Padding(2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(112, 24)
        Me.Button7.TabIndex = 91
        Me.Button7.Text = "SUPPLIER TABLE"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(609, 28)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Product Table"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(693, 52)
        Me.Panel1.TabIndex = 93
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(151, 529)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 1)
        Me.Label9.TabIndex = 94
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(152, 555)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(265, 1)
        Me.Label10.TabIndex = 95
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label11.Location = New System.Drawing.Point(153, 654)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(130, 1)
        Me.Label11.TabIndex = 96
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label12.Location = New System.Drawing.Point(155, 631)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(205, 1)
        Me.Label12.TabIndex = 97
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label13.Location = New System.Drawing.Point(154, 581)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(434, 1)
        Me.Label13.TabIndex = 98
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label15.Location = New System.Drawing.Point(155, 606)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(205, 1)
        Me.Label15.TabIndex = 99
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(692, 706)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.exportbtn)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.stocks)
        Me.Controls.Add(Me.wsale)
        Me.Controls.Add(Me.productprice)
        Me.Controls.Add(Me.productdesc)
        Me.Controls.Add(Me.productname)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.frm4_delete)
        Me.Controls.Add(Me.frm4_update)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.frm4_search)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.Text = "Information"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents frm4_search As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents frm4_update As Button
    Friend WithEvents frm4_delete As Button
    Friend WithEvents productid As TextBox
    Friend WithEvents productname As TextBox
    Friend WithEvents productdesc As TextBox
    Friend WithEvents productprice As TextBox
    Friend WithEvents wsale As TextBox
    Friend WithEvents stocks As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents exportbtn As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
End Class
