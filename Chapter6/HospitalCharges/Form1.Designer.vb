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
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.txtRehab = New System.Windows.Forms.TextBox()
        Me.txtLab = New System.Windows.Forms.TextBox()
        Me.txtSurge = New System.Windows.Forms.TextBox()
        Me.txtMeds = New System.Windows.Forms.TextBox()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lblMeds = New System.Windows.Forms.Label()
        Me.lblSurge = New System.Windows.Forms.Label()
        Me.lblLab = New System.Windows.Forms.Label()
        Me.lblRehab = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(45, 429)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(174, 54)
        Me.btnCalc.TabIndex = 1
        Me.btnCalc.Text = "Cal&culate Charges"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(261, 428)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(174, 54)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Cl&ear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(469, 428)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(174, 54)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(307, 23)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(166, 20)
        Me.txtDays.TabIndex = 0
        '
        'txtRehab
        '
        Me.txtRehab.Location = New System.Drawing.Point(307, 214)
        Me.txtRehab.Name = "txtRehab"
        Me.txtRehab.Size = New System.Drawing.Size(166, 20)
        Me.txtRehab.TabIndex = 4
        '
        'txtLab
        '
        Me.txtLab.Location = New System.Drawing.Point(307, 168)
        Me.txtLab.Name = "txtLab"
        Me.txtLab.Size = New System.Drawing.Size(166, 20)
        Me.txtLab.TabIndex = 3
        '
        'txtSurge
        '
        Me.txtSurge.Location = New System.Drawing.Point(307, 120)
        Me.txtSurge.Name = "txtSurge"
        Me.txtSurge.Size = New System.Drawing.Size(166, 20)
        Me.txtSurge.TabIndex = 2
        '
        'txtMeds
        '
        Me.txtMeds.Location = New System.Drawing.Point(307, 71)
        Me.txtMeds.Name = "txtMeds"
        Me.txtMeds.Size = New System.Drawing.Size(166, 20)
        Me.txtMeds.TabIndex = 1
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDays.Location = New System.Drawing.Point(100, 24)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(149, 19)
        Me.lblDays.TabIndex = 8
        Me.lblDays.Text = "Length of Stay (Days)"
        '
        'lblMeds
        '
        Me.lblMeds.AutoSize = True
        Me.lblMeds.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeds.Location = New System.Drawing.Point(100, 72)
        Me.lblMeds.Name = "lblMeds"
        Me.lblMeds.Size = New System.Drawing.Size(84, 19)
        Me.lblMeds.TabIndex = 9
        Me.lblMeds.Text = "Medication"
        '
        'lblSurge
        '
        Me.lblSurge.AutoSize = True
        Me.lblSurge.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurge.Location = New System.Drawing.Point(100, 125)
        Me.lblSurge.Name = "lblSurge"
        Me.lblSurge.Size = New System.Drawing.Size(121, 19)
        Me.lblSurge.TabIndex = 10
        Me.lblSurge.Text = "Surgical Charges"
        '
        'lblLab
        '
        Me.lblLab.AutoSize = True
        Me.lblLab.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLab.Location = New System.Drawing.Point(100, 173)
        Me.lblLab.Name = "lblLab"
        Me.lblLab.Size = New System.Drawing.Size(66, 19)
        Me.lblLab.TabIndex = 11
        Me.lblLab.Text = "Lab Fees"
        '
        'lblRehab
        '
        Me.lblRehab.AutoSize = True
        Me.lblRehab.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRehab.Location = New System.Drawing.Point(100, 219)
        Me.lblRehab.Name = "lblRehab"
        Me.lblRehab.Size = New System.Drawing.Size(108, 19)
        Me.lblRehab.TabIndex = 12
        Me.lblRehab.Text = "Physical Rehab"
        '
        'lblOutput
        '
        Me.lblOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOutput.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(3, 16)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(591, 97)
        Me.lblOutput.TabIndex = 13
        Me.lblOutput.Text = "Calculate Hospital Bill"
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.lblRehab)
        Me.GroupBox1.Controls.Add(Me.lblLab)
        Me.GroupBox1.Controls.Add(Me.lblSurge)
        Me.GroupBox1.Controls.Add(Me.lblMeds)
        Me.GroupBox1.Controls.Add(Me.lblDays)
        Me.GroupBox1.Controls.Add(Me.txtMeds)
        Me.GroupBox1.Controls.Add(Me.txtSurge)
        Me.GroupBox1.Controls.Add(Me.txtLab)
        Me.GroupBox1.Controls.Add(Me.txtRehab)
        Me.GroupBox1.Controls.Add(Me.txtDays)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(597, 253)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.lblOutput)
        Me.GroupBox2.Location = New System.Drawing.Point(45, 291)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(597, 116)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(691, 502)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Hospital Charges"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtDays As TextBox
    Friend WithEvents txtRehab As TextBox
    Friend WithEvents txtLab As TextBox
    Friend WithEvents txtSurge As TextBox
    Friend WithEvents txtMeds As TextBox
    Friend WithEvents lblDays As Label
    Friend WithEvents lblMeds As Label
    Friend WithEvents lblSurge As Label
    Friend WithEvents lblLab As Label
    Friend WithEvents lblRehab As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
