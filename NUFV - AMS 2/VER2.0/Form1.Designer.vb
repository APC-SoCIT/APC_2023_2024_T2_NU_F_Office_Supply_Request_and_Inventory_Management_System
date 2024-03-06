<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dropdownpanel = New System.Windows.Forms.Panel()
        Me.dropdownpanel4 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.annualrepbtn = New System.Windows.Forms.Button()
        Me.dropdownpanel3 = New System.Windows.Forms.Panel()
        Me.pdfrepbtn = New System.Windows.Forms.Button()
        Me.excelrepbtn = New System.Windows.Forms.Button()
        Me.monthrepbtn = New System.Windows.Forms.Button()
        Me.dropdownpanel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.termrepbtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.notiflabel = New System.Windows.Forms.Label()
        Me.txt_reorder = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.NotifPanel = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.combo_itemstat = New System.Windows.Forms.ComboBox()
        Me.txt_amount = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Header = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_archive = New System.Windows.Forms.Button()
        Me.btn_upd = New System.Windows.Forms.Button()
        Me.purchase_date = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.combo_itemunit = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_itemstock = New System.Windows.Forms.TextBox()
        Me.txt_itemname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_itemno = New System.Windows.Forms.TextBox()
        Me.NotifIcon = New System.Windows.Forms.PictureBox()
        Me.dropdownpanel.SuspendLayout()
        Me.dropdownpanel4.SuspendLayout()
        Me.dropdownpanel3.SuspendLayout()
        Me.dropdownpanel2.SuspendLayout()
        Me.Header.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotifIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Item Stock"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 85
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Item Status"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "Date Purchased"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "Amount Per Item"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "Reorder Point"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 103
        '
        'dropdownpanel
        '
        Me.dropdownpanel.Controls.Add(Me.dropdownpanel4)
        Me.dropdownpanel.Controls.Add(Me.annualrepbtn)
        Me.dropdownpanel.Controls.Add(Me.dropdownpanel3)
        Me.dropdownpanel.Controls.Add(Me.monthrepbtn)
        Me.dropdownpanel.Controls.Add(Me.dropdownpanel2)
        Me.dropdownpanel.Controls.Add(Me.termrepbtn)
        Me.dropdownpanel.Location = New System.Drawing.Point(778, 210)
        Me.dropdownpanel.Name = "dropdownpanel"
        Me.dropdownpanel.Size = New System.Drawing.Size(366, 152)
        Me.dropdownpanel.TabIndex = 57
        '
        'dropdownpanel4
        '
        Me.dropdownpanel4.Controls.Add(Me.Button3)
        Me.dropdownpanel4.Controls.Add(Me.Button4)
        Me.dropdownpanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.dropdownpanel4.Location = New System.Drawing.Point(0, 202)
        Me.dropdownpanel4.Name = "dropdownpanel4"
        Me.dropdownpanel4.Size = New System.Drawing.Size(366, 53)
        Me.dropdownpanel4.TabIndex = 30
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(0, 26)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(366, 26)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "EXPORT PDF"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(0, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(366, 26)
        Me.Button4.TabIndex = 27
        Me.Button4.Text = "EXPORT EXCEL"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'annualrepbtn
        '
        Me.annualrepbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.annualrepbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.annualrepbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.annualrepbtn.FlatAppearance.BorderSize = 0
        Me.annualrepbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.annualrepbtn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.annualrepbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.annualrepbtn.Location = New System.Drawing.Point(0, 170)
        Me.annualrepbtn.Name = "annualrepbtn"
        Me.annualrepbtn.Size = New System.Drawing.Size(366, 32)
        Me.annualrepbtn.TabIndex = 26
        Me.annualrepbtn.Text = "ANNUAL REPORT"
        Me.annualrepbtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.annualrepbtn.UseVisualStyleBackColor = False
        '
        'dropdownpanel3
        '
        Me.dropdownpanel3.Controls.Add(Me.pdfrepbtn)
        Me.dropdownpanel3.Controls.Add(Me.excelrepbtn)
        Me.dropdownpanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.dropdownpanel3.Location = New System.Drawing.Point(0, 117)
        Me.dropdownpanel3.Name = "dropdownpanel3"
        Me.dropdownpanel3.Size = New System.Drawing.Size(366, 53)
        Me.dropdownpanel3.TabIndex = 28
        '
        'pdfrepbtn
        '
        Me.pdfrepbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pdfrepbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pdfrepbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.pdfrepbtn.FlatAppearance.BorderSize = 0
        Me.pdfrepbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pdfrepbtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pdfrepbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.pdfrepbtn.Location = New System.Drawing.Point(0, 26)
        Me.pdfrepbtn.Name = "pdfrepbtn"
        Me.pdfrepbtn.Size = New System.Drawing.Size(366, 26)
        Me.pdfrepbtn.TabIndex = 28
        Me.pdfrepbtn.Text = "EXPORT PDF"
        Me.pdfrepbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.pdfrepbtn.UseVisualStyleBackColor = False
        '
        'excelrepbtn
        '
        Me.excelrepbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.excelrepbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.excelrepbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.excelrepbtn.FlatAppearance.BorderSize = 0
        Me.excelrepbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.excelrepbtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.excelrepbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.excelrepbtn.Location = New System.Drawing.Point(0, 0)
        Me.excelrepbtn.Name = "excelrepbtn"
        Me.excelrepbtn.Size = New System.Drawing.Size(366, 26)
        Me.excelrepbtn.TabIndex = 27
        Me.excelrepbtn.Text = "EXPORT EXCEL"
        Me.excelrepbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.excelrepbtn.UseVisualStyleBackColor = False
        '
        'monthrepbtn
        '
        Me.monthrepbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.monthrepbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.monthrepbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.monthrepbtn.FlatAppearance.BorderSize = 0
        Me.monthrepbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.monthrepbtn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monthrepbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.monthrepbtn.Location = New System.Drawing.Point(0, 85)
        Me.monthrepbtn.Name = "monthrepbtn"
        Me.monthrepbtn.Size = New System.Drawing.Size(366, 32)
        Me.monthrepbtn.TabIndex = 25
        Me.monthrepbtn.Text = "MONTHLY REPORT"
        Me.monthrepbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.monthrepbtn.UseVisualStyleBackColor = False
        '
        'dropdownpanel2
        '
        Me.dropdownpanel2.Controls.Add(Me.Button1)
        Me.dropdownpanel2.Controls.Add(Me.Button2)
        Me.dropdownpanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.dropdownpanel2.Location = New System.Drawing.Point(0, 32)
        Me.dropdownpanel2.Name = "dropdownpanel2"
        Me.dropdownpanel2.Size = New System.Drawing.Size(366, 53)
        Me.dropdownpanel2.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(0, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(366, 26)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "EXPORT PDF"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(366, 26)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "EXPORT EXCEL"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'termrepbtn
        '
        Me.termrepbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.termrepbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.termrepbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.termrepbtn.FlatAppearance.BorderSize = 0
        Me.termrepbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.termrepbtn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.termrepbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.termrepbtn.Location = New System.Drawing.Point(0, 0)
        Me.termrepbtn.Name = "termrepbtn"
        Me.termrepbtn.Size = New System.Drawing.Size(366, 32)
        Me.termrepbtn.TabIndex = 24
        Me.termrepbtn.Text = "TERM REPORT"
        Me.termrepbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.termrepbtn.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(1170, 322)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 20)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "SEARCH"
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(1249, 321)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(341, 25)
        Me.txt_search.TabIndex = 55
        '
        'notiflabel
        '
        Me.notiflabel.AutoSize = True
        Me.notiflabel.BackColor = System.Drawing.Color.Transparent
        Me.notiflabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.notiflabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.notiflabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notiflabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.notiflabel.Location = New System.Drawing.Point(1522, 94)
        Me.notiflabel.Name = "notiflabel"
        Me.notiflabel.Size = New System.Drawing.Size(15, 17)
        Me.notiflabel.TabIndex = 67
        Me.notiflabel.Text = "0"
        '
        'txt_reorder
        '
        Me.txt_reorder.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_reorder.Location = New System.Drawing.Point(608, 275)
        Me.txt_reorder.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_reorder.Name = "txt_reorder"
        Me.txt_reorder.Size = New System.Drawing.Size(146, 27)
        Me.txt_reorder.TabIndex = 66
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(474, 282)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 20)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "REORDER POINT"
        '
        'NotifPanel
        '
        Me.NotifPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.NotifPanel.Location = New System.Drawing.Point(1383, 147)
        Me.NotifPanel.Name = "NotifPanel"
        Me.NotifPanel.Size = New System.Drawing.Size(200, 155)
        Me.NotifPanel.TabIndex = 64
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(890, 180)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(146, 20)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "GENERATE REPORT"
        '
        'combo_itemstat
        '
        Me.combo_itemstat.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_itemstat.FormattingEnabled = True
        Me.combo_itemstat.Items.AddRange(New Object() {"AVAILABLE", "NOT AVAILABLE"})
        Me.combo_itemstat.Location = New System.Drawing.Point(608, 236)
        Me.combo_itemstat.Name = "combo_itemstat"
        Me.combo_itemstat.Size = New System.Drawing.Size(146, 28)
        Me.combo_itemstat.TabIndex = 61
        '
        'txt_amount
        '
        Me.txt_amount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amount.Location = New System.Drawing.Point(187, 237)
        Me.txt_amount.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(271, 27)
        Me.txt_amount.TabIndex = 60
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(32, 242)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 20)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "AMOUNT PER ITEM"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(474, 241)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 20)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "ITEM STATUS"
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btn_add.Location = New System.Drawing.Point(778, 117)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(180, 45)
        Me.btn_add.TabIndex = 50
        Me.btn_add.Text = "ADD ITEM"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'Column4
        '
        Me.Column4.HeaderText = "Item Unit"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Item Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Header.Controls.Add(Me.Label7)
        Me.Header.Location = New System.Drawing.Point(-5, 0)
        Me.Header.Margin = New System.Windows.Forms.Padding(2)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1805, 87)
        Me.Header.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(584, 21)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(488, 47)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "INVENTORY MANAGEMENT"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(25, 368)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1567, 343)
        Me.DataGridView1.TabIndex = 54
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Item Number"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 98
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btn_clear.Location = New System.Drawing.Point(1154, 168)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(180, 45)
        Me.btn_clear.TabIndex = 53
        Me.btn_clear.Text = "CLEAR FORM"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_archive
        '
        Me.btn_archive.BackColor = System.Drawing.Color.ForestGreen
        Me.btn_archive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_archive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_archive.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_archive.ForeColor = System.Drawing.Color.White
        Me.btn_archive.Location = New System.Drawing.Point(1154, 117)
        Me.btn_archive.Name = "btn_archive"
        Me.btn_archive.Size = New System.Drawing.Size(180, 45)
        Me.btn_archive.TabIndex = 52
        Me.btn_archive.Text = "ARCHIVE ITEM"
        Me.btn_archive.UseVisualStyleBackColor = False
        '
        'btn_upd
        '
        Me.btn_upd.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btn_upd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_upd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_upd.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_upd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btn_upd.Location = New System.Drawing.Point(967, 117)
        Me.btn_upd.Name = "btn_upd"
        Me.btn_upd.Size = New System.Drawing.Size(180, 45)
        Me.btn_upd.TabIndex = 51
        Me.btn_upd.Text = "UPDATE ITEM"
        Me.btn_upd.UseVisualStyleBackColor = False
        '
        'purchase_date
        '
        Me.purchase_date.CalendarFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchase_date.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchase_date.Location = New System.Drawing.Point(187, 275)
        Me.purchase_date.Name = "purchase_date"
        Me.purchase_date.Size = New System.Drawing.Size(271, 27)
        Me.purchase_date.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(32, 280)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 20)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "DATE PURCHASED"
        '
        'combo_itemunit
        '
        Me.combo_itemunit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_itemunit.FormattingEnabled = True
        Me.combo_itemunit.Items.AddRange(New Object() {"Piece/s", "Box/es", "Ream/s"})
        Me.combo_itemunit.Location = New System.Drawing.Point(608, 197)
        Me.combo_itemunit.Name = "combo_itemunit"
        Me.combo_itemunit.Size = New System.Drawing.Size(146, 28)
        Me.combo_itemunit.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(474, 205)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 21)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "UNIT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(32, 205)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 20)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "ITEM STOCK"
        '
        'txt_itemstock
        '
        Me.txt_itemstock.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_itemstock.Location = New System.Drawing.Point(187, 198)
        Me.txt_itemstock.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_itemstock.Name = "txt_itemstock"
        Me.txt_itemstock.Size = New System.Drawing.Size(271, 27)
        Me.txt_itemstock.TabIndex = 44
        '
        'txt_itemname
        '
        Me.txt_itemname.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_itemname.Location = New System.Drawing.Point(187, 159)
        Me.txt_itemname.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_itemname.Name = "txt_itemname"
        Me.txt_itemname.Size = New System.Drawing.Size(567, 27)
        Me.txt_itemname.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(31, 166)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "ITEM NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(31, 127)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "ITEM NO / CODE"
        '
        'txt_itemno
        '
        Me.txt_itemno.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_itemno.Location = New System.Drawing.Point(187, 122)
        Me.txt_itemno.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_itemno.Name = "txt_itemno"
        Me.txt_itemno.Size = New System.Drawing.Size(567, 25)
        Me.txt_itemno.TabIndex = 40
        '
        'NotifIcon
        '
        Me.NotifIcon.BackColor = System.Drawing.Color.Transparent
        Me.NotifIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.NotifIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NotifIcon.Image = Global.LoginandPassword.My.Resources.Resources.Notif_Icon
        Me.NotifIcon.Location = New System.Drawing.Point(1535, 94)
        Me.NotifIcon.Margin = New System.Windows.Forms.Padding(0)
        Me.NotifIcon.Name = "NotifIcon"
        Me.NotifIcon.Size = New System.Drawing.Size(48, 53)
        Me.NotifIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NotifIcon.TabIndex = 63
        Me.NotifIcon.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1624, 756)
        Me.Controls.Add(Me.dropdownpanel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.notiflabel)
        Me.Controls.Add(Me.txt_reorder)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.NotifPanel)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.combo_itemstat)
        Me.Controls.Add(Me.txt_amount)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.NotifIcon)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_archive)
        Me.Controls.Add(Me.btn_upd)
        Me.Controls.Add(Me.purchase_date)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.combo_itemunit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_itemstock)
        Me.Controls.Add(Me.txt_itemname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_itemno)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NUFV-AMS"
        Me.dropdownpanel.ResumeLayout(False)
        Me.dropdownpanel4.ResumeLayout(False)
        Me.dropdownpanel3.ResumeLayout(False)
        Me.dropdownpanel2.ResumeLayout(False)
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotifIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents dropdownpanel As Panel
    Friend WithEvents dropdownpanel4 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents annualrepbtn As Button
    Friend WithEvents dropdownpanel3 As Panel
    Friend WithEvents pdfrepbtn As Button
    Friend WithEvents excelrepbtn As Button
    Friend WithEvents monthrepbtn As Button
    Friend WithEvents dropdownpanel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents termrepbtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents notiflabel As Label
    Friend WithEvents txt_reorder As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents NotifPanel As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents combo_itemstat As ComboBox
    Friend WithEvents txt_amount As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_add As Button
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents NotifIcon As PictureBox
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Header As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_archive As Button
    Friend WithEvents btn_upd As Button
    Friend WithEvents purchase_date As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents combo_itemunit As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_itemstock As TextBox
    Friend WithEvents txt_itemname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_itemno As TextBox
End Class
