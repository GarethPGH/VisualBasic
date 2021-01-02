<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddNewMember
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim Date_JoinedLabel As System.Windows.Forms.Label
        Me.MembersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembersDataSet = New KarateSchoolManager.MembersDataSet()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAndClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseWithoutSaving = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.MembersTableAdapter1 = New KarateSchoolManager.MembersDataSetTableAdapters.MembersTableAdapter()
        Me.TableAdapterManager1 = New KarateSchoolManager.MembersDataSetTableAdapters.TableAdapterManager()
        Me.IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox1 = New System.Windows.Forms.TextBox()
        Me.Date_JoinedDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        IDLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        Date_JoinedLabel = New System.Windows.Forms.Label()
        CType(Me.MembersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MembersBindingSource1
        '
        Me.MembersBindingSource1.DataMember = "Members"
        Me.MembersBindingSource1.DataSource = Me.MembersDataSet
        '
        'MembersDataSet
        '
        Me.MembersDataSet.DataSetName = "MembersDataSet"
        Me.MembersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveAndClose, Me.CloseWithoutSaving})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'SaveAndClose
        '
        Me.SaveAndClose.Name = "SaveAndClose"
        Me.SaveAndClose.Size = New System.Drawing.Size(187, 22)
        Me.SaveAndClose.Text = "Save and Close"
        '
        'CloseWithoutSaving
        '
        Me.CloseWithoutSaving.Name = "CloseWithoutSaving"
        Me.CloseWithoutSaving.Size = New System.Drawing.Size(187, 22)
        Me.CloseWithoutSaving.Text = "Close Without Saving"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(308, 24)
        Me.MenuStrip2.TabIndex = 11
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'MembersTableAdapter1
        '
        Me.MembersTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.MembersTableAdapter = Me.MembersTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = KarateSchoolManager.MembersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(14, 42)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 30
        IDLabel.Text = "ID:"
        '
        'IDTextBox1
        '
        Me.IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource1, "ID", True))
        Me.IDTextBox1.Location = New System.Drawing.Point(87, 39)
        Me.IDTextBox1.Name = "IDTextBox1"
        Me.IDTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.IDTextBox1.TabIndex = 31
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(14, 68)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 32
        Last_NameLabel.Text = "Last Name:"
        '
        'Last_NameTextBox1
        '
        Me.Last_NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource1, "Last_Name", True))
        Me.Last_NameTextBox1.Location = New System.Drawing.Point(87, 65)
        Me.Last_NameTextBox1.Name = "Last_NameTextBox1"
        Me.Last_NameTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.Last_NameTextBox1.TabIndex = 33
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(14, 94)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 34
        First_NameLabel.Text = "First Name:"
        '
        'First_NameTextBox1
        '
        Me.First_NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource1, "First_Name", True))
        Me.First_NameTextBox1.Location = New System.Drawing.Point(87, 91)
        Me.First_NameTextBox1.Name = "First_NameTextBox1"
        Me.First_NameTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.First_NameTextBox1.TabIndex = 35
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(14, 120)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 36
        PhoneLabel.Text = "Phone:"
        '
        'PhoneTextBox1
        '
        Me.PhoneTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource1, "Phone", True))
        Me.PhoneTextBox1.Location = New System.Drawing.Point(87, 117)
        Me.PhoneTextBox1.Name = "PhoneTextBox1"
        Me.PhoneTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.PhoneTextBox1.TabIndex = 37
        '
        'Date_JoinedLabel
        '
        Date_JoinedLabel.AutoSize = True
        Date_JoinedLabel.Location = New System.Drawing.Point(14, 147)
        Date_JoinedLabel.Name = "Date_JoinedLabel"
        Date_JoinedLabel.Size = New System.Drawing.Size(67, 13)
        Date_JoinedLabel.TabIndex = 38
        Date_JoinedLabel.Text = "Date Joined:"
        '
        'Date_JoinedDateTimePicker1
        '
        Me.Date_JoinedDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MembersBindingSource1, "Date_Joined", True))
        Me.Date_JoinedDateTimePicker1.Location = New System.Drawing.Point(87, 143)
        Me.Date_JoinedDateTimePicker1.Name = "Date_JoinedDateTimePicker1"
        Me.Date_JoinedDateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.Date_JoinedDateTimePicker1.TabIndex = 39
        '
        'AddNewMember
        '
        Me.ClientSize = New System.Drawing.Size(308, 184)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox1)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox1)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox1)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox1)
        Me.Controls.Add(Date_JoinedLabel)
        Me.Controls.Add(Me.Date_JoinedDateTimePicker1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip2
        Me.Name = "AddNewMember"
        CType(Me.MembersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAndCloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseWithoutSavingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents MembersTableAdapter As MembersDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents TableAdapterManager As MembersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents Date_JoinedDateTimePicker As DateTimePicker
    Friend WithEvents MembersDataSet As MembersDataSet
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SaveAndClose As ToolStripMenuItem
    Friend WithEvents CloseWithoutSaving As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents MembersTableAdapter1 As MembersDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents TableAdapterManager1 As MembersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MembersBindingSource1 As BindingSource
    Friend WithEvents IDTextBox1 As TextBox
    Friend WithEvents Last_NameTextBox1 As TextBox
    Friend WithEvents First_NameTextBox1 As TextBox
    Friend WithEvents PhoneTextBox1 As TextBox
    Friend WithEvents Date_JoinedDateTimePicker1 As DateTimePicker
End Class
