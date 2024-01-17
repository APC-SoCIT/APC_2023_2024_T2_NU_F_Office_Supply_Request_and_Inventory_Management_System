<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TblproductBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbaccessDataSet2 = New LoginandPassword.dbaccessDataSet2()
        Me.Dbprofile1DataSet = New LoginandPassword.dbprofile1DataSet()
        Me.TblcustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_customersTableAdapter = New LoginandPassword.dbprofile1DataSetTableAdapters.tbl_customersTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DbaccessDataSet = New LoginandPassword.dbaccessDataSet()
        Me.TblproductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_productTableAdapter = New LoginandPassword.dbaccessDataSetTableAdapters.tbl_productTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DbaccessDataSet1 = New LoginandPassword.dbaccessDataSet1()
        Me.TblproductBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_productTableAdapter1 = New LoginandPassword.dbaccessDataSet1TableAdapters.tbl_productTableAdapter()
        Me.Tbl_productTableAdapter2 = New LoginandPassword.dbaccessDataSet2TableAdapters.tbl_productTableAdapter()
        Me.DbprofileDataSet = New LoginandPassword.dbprofileDataSet()
        Me.TblproductBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_productTableAdapter3 = New LoginandPassword.dbprofileDataSetTableAdapters.tbl_productTableAdapter()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblproductBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbaccessDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dbprofile1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbaccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblproductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbaccessDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblproductBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbprofileDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblproductBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(249, 43)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(643, 139)
        Me.DataGridView1.TabIndex = 0
        '
        'TblproductBindingSource2
        '
        Me.TblproductBindingSource2.DataMember = "tbl_product"
        Me.TblproductBindingSource2.DataSource = Me.DbaccessDataSet2
        '
        'DbaccessDataSet2
        '
        Me.DbaccessDataSet2.DataSetName = "dbaccessDataSet2"
        Me.DbaccessDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Dbprofile1DataSet
        '
        Me.Dbprofile1DataSet.DataSetName = "dbprofile1DataSet"
        Me.Dbprofile1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblcustomersBindingSource
        '
        Me.TblcustomersBindingSource.DataMember = "tbl_customers"
        Me.TblcustomersBindingSource.DataSource = Me.Dbprofile1DataSet
        '
        'Tbl_customersTableAdapter
        '
        Me.Tbl_customersTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(435, 193)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DbaccessDataSet
        '
        Me.DbaccessDataSet.DataSetName = "dbaccessDataSet"
        Me.DbaccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblproductBindingSource
        '
        Me.TblproductBindingSource.DataMember = "tbl_product"
        Me.TblproductBindingSource.DataSource = Me.DbaccessDataSet
        '
        'Tbl_productTableAdapter
        '
        Me.Tbl_productTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(531, 193)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 35)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Import"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DbaccessDataSet1
        '
        Me.DbaccessDataSet1.DataSetName = "dbaccessDataSet1"
        Me.DbaccessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblproductBindingSource1
        '
        Me.TblproductBindingSource1.DataMember = "tbl_product"
        Me.TblproductBindingSource1.DataSource = Me.DbaccessDataSet1
        '
        'Tbl_productTableAdapter1
        '
        Me.Tbl_productTableAdapter1.ClearBeforeFill = True
        '
        'Tbl_productTableAdapter2
        '
        Me.Tbl_productTableAdapter2.ClearBeforeFill = True
        '
        'DbprofileDataSet
        '
        Me.DbprofileDataSet.DataSetName = "dbprofileDataSet"
        Me.DbprofileDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblproductBindingSource3
        '
        Me.TblproductBindingSource3.DataMember = "tbl_product"
        Me.TblproductBindingSource3.DataSource = Me.DbprofileDataSet
        '
        'Tbl_productTableAdapter3
        '
        Me.Tbl_productTableAdapter3.ClearBeforeFill = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(372, 0)
        Me.CheckedListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(24, 4)
        Me.CheckedListBox1.TabIndex = 3
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(8, 43)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(242, 238)
        Me.ListBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(267, 167)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(636, 193)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 35)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "View Data"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(813, 259)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(79, 20)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(363, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Search :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(449, 236)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(259, 20)
        Me.TextBox1.TabIndex = 9
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(468, 259)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Report"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(613, 258)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Search"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(924, 38)
        Me.Panel1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(54, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 33)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Import Data"
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 292)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form9"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Sql (Customer Database)"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblproductBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbaccessDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dbprofile1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbaccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblproductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbaccessDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblproductBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbprofileDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblproductBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Dbprofile1DataSet As dbprofile1DataSet
    Friend WithEvents TblcustomersBindingSource As BindingSource
    Friend WithEvents Tbl_customersTableAdapter As dbprofile1DataSetTableAdapters.tbl_customersTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents DbaccessDataSet As dbaccessDataSet
    Friend WithEvents TblproductBindingSource As BindingSource
    Friend WithEvents Tbl_productTableAdapter As dbaccessDataSetTableAdapters.tbl_productTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents DbaccessDataSet1 As dbaccessDataSet1
    Friend WithEvents TblproductBindingSource1 As BindingSource
    Friend WithEvents Tbl_productTableAdapter1 As dbaccessDataSet1TableAdapters.tbl_productTableAdapter
    Friend WithEvents DbaccessDataSet2 As dbaccessDataSet2
    Friend WithEvents TblproductBindingSource2 As BindingSource
    Friend WithEvents Tbl_productTableAdapter2 As dbaccessDataSet2TableAdapters.tbl_productTableAdapter
    Friend WithEvents DbprofileDataSet As dbprofileDataSet
    Friend WithEvents TblproductBindingSource3 As BindingSource
    Friend WithEvents Tbl_productTableAdapter3 As dbprofileDataSetTableAdapters.tbl_productTableAdapter
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
End Class
