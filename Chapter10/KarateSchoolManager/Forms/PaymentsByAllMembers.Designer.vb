<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaymentsByAllMembers
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
        Me.dgvAllPayments = New System.Windows.Forms.DataGridView()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllPaymentsDataset1 = New KarateSchoolManager.AllPaymentsDataset()
        Me.PaymentsTableAdapter1 = New KarateSchoolManager.AllPaymentsDatasetTableAdapters.PaymentsTableAdapter()
        Me.AllPaymentsDataset = New KarateSchoolManager.AllPaymentsDataset()
        CType(Me.dgvAllPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.PaymentsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllPaymentsDataset1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllPaymentsDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAllPayments
        '
        Me.dgvAllPayments.AllowUserToAddRows = False
        Me.dgvAllPayments.AllowUserToDeleteRows = False
        Me.dgvAllPayments.AutoGenerateColumns = False
        Me.dgvAllPayments.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvAllPayments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAllPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAllPayments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PaymentDateDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn})
        Me.dgvAllPayments.DataSource = Me.PaymentsBindingSource1
        Me.dgvAllPayments.Location = New System.Drawing.Point(23, 59)
        Me.dgvAllPayments.Name = "dgvAllPayments"
        Me.dgvAllPayments.ReadOnly = True
        Me.dgvAllPayments.Size = New System.Drawing.Size(485, 271)
        Me.dgvAllPayments.TabIndex = 0
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(551, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(48, 20)
        Me.ToolStripMenuItem1.Text = "Close"
        '
        'PaymentDateDataGridViewTextBoxColumn
        '
        Me.PaymentDateDataGridViewTextBoxColumn.DataPropertyName = "Payment_Date"
        Me.PaymentDateDataGridViewTextBoxColumn.HeaderText = "Payment_Date"
        Me.PaymentDateDataGridViewTextBoxColumn.Name = "PaymentDateDataGridViewTextBoxColumn"
        Me.PaymentDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaymentsBindingSource1
        '
        Me.PaymentsBindingSource1.DataMember = "Payments"
        Me.PaymentsBindingSource1.DataSource = Me.AllPaymentsDataset
        '
        'AllPaymentsDataset1
        '
        Me.AllPaymentsDataset1.DataSetName = "AllPaymentsDataset"
        Me.AllPaymentsDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentsTableAdapter1
        '
        Me.PaymentsTableAdapter1.ClearBeforeFill = True
        '
        'AllPaymentsDataset
        '
        Me.AllPaymentsDataset.DataSetName = "AllPaymentsDataset"
        Me.AllPaymentsDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentsByAllMembers
        '
        Me.ClientSize = New System.Drawing.Size(551, 362)
        Me.Controls.Add(Me.dgvAllPayments)
        Me.Controls.Add(Me.MenuStrip2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip2
        Me.Name = "PaymentsByAllMembers"
        CType(Me.dgvAllPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.PaymentsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllPaymentsDataset1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllPaymentsDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents dgvAllPayments As DataGridView
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AllPaymentsDataset1 As AllPaymentsDataset
    Friend WithEvents PaymentsTableAdapter1 As AllPaymentsDatasetTableAdapters.PaymentsTableAdapter
    Friend WithEvents PaymentDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentsBindingSource1 As BindingSource
    Friend WithEvents AllPaymentsDataset As AllPaymentsDataset
End Class
