<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase_Order
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dept = New System.Windows.Forms.Label()
        Me.txtbxdept = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtbxname = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.amount = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.Panel30 = New System.Windows.Forms.Panel()
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel16.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.Panel26.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "SUBTOTAL"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 83
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "QUANTITY"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.Width = 83
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "ITEMNAME"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'dept
        '
        Me.dept.AutoSize = True
        Me.dept.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dept.ForeColor = System.Drawing.Color.Black
        Me.dept.Location = New System.Drawing.Point(279, 596)
        Me.dept.Name = "dept"
        Me.dept.Size = New System.Drawing.Size(28, 13)
        Me.dept.TabIndex = 236
        Me.dept.Text = "dept"
        '
        'txtbxdept
        '
        Me.txtbxdept.BackColor = System.Drawing.Color.White
        Me.txtbxdept.Enabled = False
        Me.txtbxdept.ForeColor = System.Drawing.Color.Black
        Me.txtbxdept.Location = New System.Drawing.Point(313, 593)
        Me.txtbxdept.Name = "txtbxdept"
        Me.txtbxdept.Size = New System.Drawing.Size(114, 20)
        Me.txtbxdept.TabIndex = 237
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(27, 595)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 234
        Me.Label7.Text = "Name"
        '
        'txtbxname
        '
        Me.txtbxname.BackColor = System.Drawing.Color.White
        Me.txtbxname.Enabled = False
        Me.txtbxname.ForeColor = System.Drawing.Color.Black
        Me.txtbxname.Location = New System.Drawing.Point(68, 592)
        Me.txtbxname.Name = "txtbxname"
        Me.txtbxname.Size = New System.Drawing.Size(205, 20)
        Me.txtbxname.TabIndex = 235
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeight = 30
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.Location = New System.Drawing.Point(23, 216)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(769, 367)
        Me.DataGridView2.TabIndex = 233
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "UNITPRICE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.Black
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1000, 3)
        Me.Panel14.TabIndex = 58
        '
        'Panel27
        '
        Me.Panel27.BackColor = System.Drawing.Color.Black
        Me.Panel27.Location = New System.Drawing.Point(0, 0)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(1000, 3)
        Me.Panel27.TabIndex = 58
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.Black
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1000, 3)
        Me.Panel13.TabIndex = 58
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(656, 723)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 13)
        Me.Label23.TabIndex = 231
        Me.Label23.Text = "INVOICE NO."
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.Black
        Me.Panel16.Controls.Add(Me.Panel17)
        Me.Panel16.Location = New System.Drawing.Point(23, 653)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(769, 1)
        Me.Panel16.TabIndex = 203
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.Black
        Me.Panel17.Location = New System.Drawing.Point(0, 0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(1000, 3)
        Me.Panel17.TabIndex = 58
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(448, 592)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 13)
        Me.Label16.TabIndex = 224
        Me.Label16.Text = "Total  Cost"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(33, 630)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 13)
        Me.Label14.TabIndex = 222
        Me.Label14.Text = "PO COMMENTS"
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.Color.Black
        Me.Panel21.Location = New System.Drawing.Point(0, 0)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(1000, 3)
        Me.Panel21.TabIndex = 58
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.Black
        Me.Panel20.Controls.Add(Me.Panel21)
        Me.Panel20.Location = New System.Drawing.Point(23, 670)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(769, 1)
        Me.Panel20.TabIndex = 204
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.Black
        Me.Panel19.Location = New System.Drawing.Point(791, 571)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(1, 83)
        Me.Panel19.TabIndex = 202
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.Black
        Me.Panel18.Location = New System.Drawing.Point(23, 571)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(1, 83)
        Me.Panel18.TabIndex = 199
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(141, 630)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 13)
        Me.Label15.TabIndex = 223
        Me.Label15.Text = "N/A"
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.Black
        Me.Panel22.Controls.Add(Me.Panel23)
        Me.Panel22.Location = New System.Drawing.Point(23, 713)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(769, 1)
        Me.Panel22.TabIndex = 208
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.Black
        Me.Panel23.Location = New System.Drawing.Point(0, 0)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(1000, 3)
        Me.Panel23.TabIndex = 58
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.Color.Black
        Me.Panel24.Controls.Add(Me.Panel25)
        Me.Panel24.Location = New System.Drawing.Point(23, 774)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(769, 1)
        Me.Panel24.TabIndex = 207
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.Black
        Me.Panel25.Location = New System.Drawing.Point(0, 0)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(1000, 3)
        Me.Panel25.TabIndex = 58
        '
        'amount
        '
        Me.amount.BackColor = System.Drawing.Color.White
        Me.amount.Enabled = False
        Me.amount.ForeColor = System.Drawing.Color.Black
        Me.amount.Location = New System.Drawing.Point(528, 589)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(235, 20)
        Me.amount.TabIndex = 232
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(461, 723)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(93, 13)
        Me.Label22.TabIndex = 230
        Me.Label22.Text = "DATE RECEIVED"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(253, 723)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(78, 13)
        Me.Label21.TabIndex = 229
        Me.Label21.Text = "RECIEVED BY"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(69, 723)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(73, 13)
        Me.Label20.TabIndex = 228
        Me.Label20.Text = "VERIFIED BY"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(575, 677)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 13)
        Me.Label19.TabIndex = 227
        Me.Label19.Text = "APPROVED BY :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(167, 679)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 26)
        Me.Label18.TabIndex = 226
        Me.Label18.Text = "CREATED BY :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Auto PO Buyer"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(293, 783)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(217, 13)
        Me.Label17.TabIndex = 225
        Me.Label17.Text = "This PO is e-approved, no signature required" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel32
        '
        Me.Panel32.BackColor = System.Drawing.Color.Black
        Me.Panel32.Location = New System.Drawing.Point(614, 713)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(1, 62)
        Me.Panel32.TabIndex = 211
        '
        'Panel31
        '
        Me.Panel31.BackColor = System.Drawing.Color.Black
        Me.Panel31.Location = New System.Drawing.Point(197, 713)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(1, 62)
        Me.Panel31.TabIndex = 209
        '
        'Panel30
        '
        Me.Panel30.BackColor = System.Drawing.Color.Black
        Me.Panel30.Location = New System.Drawing.Point(401, 670)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(1, 105)
        Me.Panel30.TabIndex = 205
        '
        'Panel29
        '
        Me.Panel29.BackColor = System.Drawing.Color.Black
        Me.Panel29.Location = New System.Drawing.Point(791, 671)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(1, 135)
        Me.Panel29.TabIndex = 206
        '
        'Panel28
        '
        Me.Panel28.BackColor = System.Drawing.Color.Black
        Me.Panel28.Location = New System.Drawing.Point(23, 670)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(1, 135)
        Me.Panel28.TabIndex = 201
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.Color.Black
        Me.Panel26.Controls.Add(Me.Panel27)
        Me.Panel26.Location = New System.Drawing.Point(23, 804)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(769, 1)
        Me.Panel26.TabIndex = 210
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Black
        Me.Panel15.Location = New System.Drawing.Point(27, 363)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(0, 0)
        Me.Panel15.TabIndex = 197
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Black
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.Panel12.Location = New System.Drawing.Point(23, 619)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(769, 1)
        Me.Panel12.TabIndex = 200
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Panel14)
        Me.Panel2.Location = New System.Drawing.Point(23, 207)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(769, 1)
        Me.Panel2.TabIndex = 195
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(23, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(769, 1)
        Me.Panel1.TabIndex = 193
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(354, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 192
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Black
        Me.Panel11.Location = New System.Drawing.Point(791, 7)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1, 200)
        Me.Panel11.TabIndex = 196
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Black
        Me.Panel10.Location = New System.Drawing.Point(23, 8)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1, 200)
        Me.Panel10.TabIndex = 194
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(27, 315)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(0, 0)
        Me.Panel5.TabIndex = 198
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(263, 151)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(352, 39)
        Me.Label13.TabIndex = 221
        Me.Label13.Text = "NU - Fairview" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NU Fairview Complex Quirino Highway Cor. Regalado Lagro Quezon Cit" &
    "y." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Quezon City, Philippines"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(263, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(139, 13)
        Me.Label12.TabIndex = 220
        Me.Label12.Text = "Private Education Institution"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(263, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 13)
        Me.Label11.TabIndex = 219
        Me.Label11.Text = "010-356-564-000"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(263, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 13)
        Me.Label10.TabIndex = 218
        Me.Label10.Text = "National University - Fairview Inc."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(141, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 217
        Me.Label6.Text = "BILL TO ADDRESS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(141, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 216
        Me.Label5.Text = "BUSINESS STYLE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(141, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 215
        Me.Label4.Text = "TIN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(141, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 214
        Me.Label3.Text = "COMPANY NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(307, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 15)
        Me.Label2.TabIndex = 213
        Me.Label2.Text = "PURCHASE ORDER : NON TRADE"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.ErrorImage = Global.LoginandPassword.My.Resources.Resources.NULOGO1
        Me.PictureBox1.Image = Global.LoginandPassword.My.Resources.Resources.NULOGO1
        Me.PictureBox1.InitialImage = Global.LoginandPassword.My.Resources.Resources.NULOGO1
        Me.PictureBox1.Location = New System.Drawing.Point(36, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 212
        Me.PictureBox1.TabStop = False
        '
        'Purchase_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 840)
        Me.Controls.Add(Me.dept)
        Me.Controls.Add(Me.txtbxdept)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtbxname)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Panel16)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Panel20)
        Me.Controls.Add(Me.Panel19)
        Me.Controls.Add(Me.Panel18)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Panel22)
        Me.Controls.Add(Me.Panel24)
        Me.Controls.Add(Me.amount)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Panel32)
        Me.Controls.Add(Me.Panel31)
        Me.Controls.Add(Me.Panel30)
        Me.Controls.Add(Me.Panel29)
        Me.Controls.Add(Me.Panel28)
        Me.Controls.Add(Me.Panel26)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Purchase_Order"
        Me.Text = "Purchase_Order"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel16.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.Panel24.ResumeLayout(False)
        Me.Panel26.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents dept As Label
    Friend WithEvents txtbxdept As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtbxname As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Panel14 As Panel
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Panel27 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Panel24 As Panel
    Friend WithEvents Panel25 As Panel
    Friend WithEvents amount As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel32 As Panel
    Friend WithEvents Panel31 As Panel
    Friend WithEvents Panel30 As Panel
    Friend WithEvents Panel29 As Panel
    Friend WithEvents Panel28 As Panel
    Friend WithEvents Panel26 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
