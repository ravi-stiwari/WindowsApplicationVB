<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExcelUploader
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
        Me.ImportBtn = New System.Windows.Forms.Button()
        Me.BrowseBtn = New System.Windows.Forms.Button()
        Me.ViewDataBtn = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.filepathLbl = New System.Windows.Forms.Label()
        Me.DatabaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New ProjectMorgan.DatabaseDataSet()
        Me.DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTableAdapter = New ProjectMorgan.DatabaseDataSetTableAdapters.dataTableAdapter()
        Me.SrNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISINsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImportBtn
        '
        Me.ImportBtn.Location = New System.Drawing.Point(260, 12)
        Me.ImportBtn.Name = "ImportBtn"
        Me.ImportBtn.Size = New System.Drawing.Size(75, 23)
        Me.ImportBtn.TabIndex = 0
        Me.ImportBtn.Text = "Import"
        Me.ImportBtn.UseVisualStyleBackColor = True
        '
        'BrowseBtn
        '
        Me.BrowseBtn.Location = New System.Drawing.Point(49, 12)
        Me.BrowseBtn.Name = "BrowseBtn"
        Me.BrowseBtn.Size = New System.Drawing.Size(75, 23)
        Me.BrowseBtn.TabIndex = 1
        Me.BrowseBtn.Text = "Browse"
        Me.BrowseBtn.UseVisualStyleBackColor = True
        '
        'ViewDataBtn
        '
        Me.ViewDataBtn.Location = New System.Drawing.Point(443, 12)
        Me.ViewDataBtn.Name = "ViewDataBtn"
        Me.ViewDataBtn.Size = New System.Drawing.Size(75, 23)
        Me.ViewDataBtn.TabIndex = 2
        Me.ViewDataBtn.Text = "Refresh"
        Me.ViewDataBtn.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(25, 52)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(144, 355)
        Me.ListBox1.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrNoDataGridViewTextBoxColumn, Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.ISINsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DataBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(186, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(826, 356)
        Me.DataGridView1.TabIndex = 4
        '
        'filepathLbl
        '
        Me.filepathLbl.AutoSize = True
        Me.filepathLbl.Location = New System.Drawing.Point(0, 0)
        Me.filepathLbl.Name = "filepathLbl"
        Me.filepathLbl.Size = New System.Drawing.Size(55, 13)
        Me.filepathLbl.TabIndex = 5
        Me.filepathLbl.Text = "filepathLbl"
        Me.filepathLbl.Visible = False
        '
        'DatabaseDataSetBindingSource
        '
        Me.DatabaseDataSetBindingSource.DataSource = Me.DatabaseDataSet
        Me.DatabaseDataSetBindingSource.Position = 0
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataBindingSource
        '
        Me.DataBindingSource.DataMember = "data"
        Me.DataBindingSource.DataSource = Me.DatabaseDataSetBindingSource
        '
        'DataTableAdapter
        '
        Me.DataTableAdapter.ClearBeforeFill = True
        '
        'SrNoDataGridViewTextBoxColumn
        '
        Me.SrNoDataGridViewTextBoxColumn.DataPropertyName = "SrNo"
        Me.SrNoDataGridViewTextBoxColumn.HeaderText = "SrNo"
        Me.SrNoDataGridViewTextBoxColumn.Name = "SrNoDataGridViewTextBoxColumn"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'ISINsDataGridViewTextBoxColumn
        '
        Me.ISINsDataGridViewTextBoxColumn.DataPropertyName = "ISINs"
        Me.ISINsDataGridViewTextBoxColumn.HeaderText = "ISINs"
        Me.ISINsDataGridViewTextBoxColumn.Name = "ISINsDataGridViewTextBoxColumn"
        '
        'ExcelUploader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 420)
        Me.Controls.Add(Me.filepathLbl)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ViewDataBtn)
        Me.Controls.Add(Me.BrowseBtn)
        Me.Controls.Add(Me.ImportBtn)
        Me.Name = "ExcelUploader"
        Me.Text = "ExcelUploader"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImportBtn As Button
    Friend WithEvents BrowseBtn As Button
    Friend WithEvents ViewDataBtn As Button
    Friend WithEvents excellist As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DatabaseDataSetBindingSource As BindingSource
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents filepathLbl As Label
    Friend WithEvents DataBindingSource As BindingSource
    Friend WithEvents DataTableAdapter As DatabaseDataSetTableAdapters.dataTableAdapter
    Friend WithEvents SrNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ISINsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
