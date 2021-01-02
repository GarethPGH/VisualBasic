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
        Me.lstKayak = New System.Windows.Forms.ListBox()
        Me.KayaksDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayaksDataSet = New KayakBrowser.KayaksDataSet()
        Me.lblKayak = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.KayaksDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayakTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayakTypesTableAdapter = New KayakBrowser.KayaksDataSetTableAdapters.KayakTypesTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.KayaksDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayaksDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstKayak
        '
        Me.lstKayak.DataSource = Me.KayakTypesBindingSource
        Me.lstKayak.DisplayMember = "Name"
        Me.lstKayak.FormattingEnabled = True
        Me.lstKayak.Location = New System.Drawing.Point(8, 21)
        Me.lstKayak.Name = "lstKayak"
        Me.lstKayak.Size = New System.Drawing.Size(185, 121)
        Me.lstKayak.TabIndex = 0
        '
        'KayaksDataSetBindingSource1
        '
        Me.KayaksDataSetBindingSource1.DataSource = Me.KayaksDataSet
        Me.KayaksDataSetBindingSource1.Position = 0
        '
        'KayaksDataSet
        '
        Me.KayaksDataSet.DataSetName = "KayaksDataSet"
        Me.KayaksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblKayak
        '
        Me.lblKayak.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KayakTypesBindingSource, "Description", True))
        Me.lblKayak.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKayak.Location = New System.Drawing.Point(228, 21)
        Me.lblKayak.Name = "lblKayak"
        Me.lblKayak.Size = New System.Drawing.Size(333, 121)
        Me.lblKayak.TabIndex = 1
        Me.lblKayak.Text = "Placeholder Text"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(22, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select a Kayak to View it's Description"
        '
        'KayaksDataSetBindingSource
        '
        Me.KayaksDataSetBindingSource.DataSource = Me.KayaksDataSet
        Me.KayaksDataSetBindingSource.Position = 0
        '
        'KayakTypesBindingSource
        '
        Me.KayakTypesBindingSource.DataMember = "KayakTypes"
        Me.KayakTypesBindingSource.DataSource = Me.KayaksDataSetBindingSource
        '
        'KayakTypesTableAdapter
        '
        Me.KayakTypesTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.lblKayak)
        Me.GroupBox1.Controls.Add(Me.lstKayak)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(578, 151)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(604, 231)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Kayak Browser"
        CType(Me.KayaksDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayaksDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstKayak As ListBox
    Friend WithEvents lblKayak As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents KayaksDataSetBindingSource As BindingSource
    Friend WithEvents KayaksDataSet As KayaksDataSet
    Friend WithEvents KayaksDataSetBindingSource1 As BindingSource
    Friend WithEvents KayakTypesBindingSource As BindingSource
    Friend WithEvents KayakTypesTableAdapter As KayaksDataSetTableAdapters.KayakTypesTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
End Class
