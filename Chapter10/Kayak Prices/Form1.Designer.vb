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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KayakTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayaksDataSet = New Kayak_Prices.KayaksDataSet()
        Me.KayakTypesTableAdapter = New Kayak_Prices.KayaksDataSetTableAdapters.KayakTypesTableAdapter()
        Me.KayakTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DailyRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourlyRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeeklyRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KayakTypeDataGridViewTextBoxColumn, Me.DailyRateDataGridViewTextBoxColumn, Me.HourlyRateDataGridViewTextBoxColumn, Me.WeeklyRateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.KayakTypesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(444, 177)
        Me.DataGridView1.TabIndex = 0
        '
        'KayakTypesBindingSource
        '
        Me.KayakTypesBindingSource.DataMember = "KayakTypes"
        Me.KayakTypesBindingSource.DataSource = Me.KayaksDataSet
        '
        'KayaksDataSet
        '
        Me.KayaksDataSet.DataSetName = "KayaksDataSet"
        Me.KayaksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KayakTypesTableAdapter
        '
        Me.KayakTypesTableAdapter.ClearBeforeFill = True
        '
        'KayakTypeDataGridViewTextBoxColumn
        '
        Me.KayakTypeDataGridViewTextBoxColumn.DataPropertyName = "Kayak Type"
        Me.KayakTypeDataGridViewTextBoxColumn.HeaderText = "Kayak Type"
        Me.KayakTypeDataGridViewTextBoxColumn.Name = "KayakTypeDataGridViewTextBoxColumn"
        '
        'DailyRateDataGridViewTextBoxColumn
        '
        Me.DailyRateDataGridViewTextBoxColumn.DataPropertyName = "Daily Rate"
        Me.DailyRateDataGridViewTextBoxColumn.HeaderText = "Daily Rate"
        Me.DailyRateDataGridViewTextBoxColumn.Name = "DailyRateDataGridViewTextBoxColumn"
        '
        'HourlyRateDataGridViewTextBoxColumn
        '
        Me.HourlyRateDataGridViewTextBoxColumn.DataPropertyName = "Hourly Rate"
        Me.HourlyRateDataGridViewTextBoxColumn.HeaderText = "Hourly Rate"
        Me.HourlyRateDataGridViewTextBoxColumn.Name = "HourlyRateDataGridViewTextBoxColumn"
        '
        'WeeklyRateDataGridViewTextBoxColumn
        '
        Me.WeeklyRateDataGridViewTextBoxColumn.DataPropertyName = "Weekly Rate"
        Me.WeeklyRateDataGridViewTextBoxColumn.HeaderText = "Weekly Rate"
        Me.WeeklyRateDataGridViewTextBoxColumn.Name = "WeeklyRateDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 226)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Kayak Rental Prices"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KayaksDataSet As KayaksDataSet
    Friend WithEvents KayakTypesBindingSource As BindingSource
    Friend WithEvents KayakTypesTableAdapter As KayaksDataSetTableAdapters.KayakTypesTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KayakTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DailyRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HourlyRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeeklyRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
