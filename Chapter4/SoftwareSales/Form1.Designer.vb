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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radOneTime = New System.Windows.Forms.RadioButton()
        Me.radYearly = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkCloud = New System.Windows.Forms.CheckBox()
        Me.chkTraining = New System.Windows.Forms.CheckBox()
        Me.chkLevel3 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtOptional = New System.Windows.Forms.TextBox()
        Me.txtLicense = New System.Windows.Forms.TextBox()
        Me.lblCostOptional = New System.Windows.Forms.Label()
        Me.lblCostLicensing = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.radOneTime)
        Me.GroupBox1.Controls.Add(Me.radYearly)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(46, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 186)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Licensing Options"
        '
        'radOneTime
        '
        Me.radOneTime.AutoSize = True
        Me.radOneTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOneTime.Location = New System.Drawing.Point(58, 103)
        Me.radOneTime.Name = "radOneTime"
        Me.radOneTime.Size = New System.Drawing.Size(162, 25)
        Me.radOneTime.TabIndex = 1
        Me.radOneTime.TabStop = True
        Me.radOneTime.Text = "One Time Purchase"
        Me.radOneTime.UseVisualStyleBackColor = True
        '
        'radYearly
        '
        Me.radYearly.AutoSize = True
        Me.radYearly.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radYearly.Location = New System.Drawing.Point(58, 48)
        Me.radYearly.Name = "radYearly"
        Me.radYearly.Size = New System.Drawing.Size(125, 25)
        Me.radYearly.TabIndex = 0
        Me.radYearly.TabStop = True
        Me.radYearly.Text = "Yearly License"
        Me.radYearly.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.chkCloud)
        Me.GroupBox2.Controls.Add(Me.chkTraining)
        Me.GroupBox2.Controls.Add(Me.chkLevel3)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(395, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 186)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Optional Features (yearly)"
        '
        'chkCloud
        '
        Me.chkCloud.AutoSize = True
        Me.chkCloud.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCloud.Location = New System.Drawing.Point(55, 118)
        Me.chkCloud.Name = "chkCloud"
        Me.chkCloud.Size = New System.Drawing.Size(124, 25)
        Me.chkCloud.TabIndex = 2
        Me.chkCloud.Text = "Cloud Backup"
        Me.chkCloud.UseVisualStyleBackColor = True
        '
        'chkTraining
        '
        Me.chkTraining.AutoSize = True
        Me.chkTraining.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTraining.Location = New System.Drawing.Point(55, 84)
        Me.chkTraining.Name = "chkTraining"
        Me.chkTraining.Size = New System.Drawing.Size(142, 25)
        Me.chkTraining.TabIndex = 1
        Me.chkTraining.Text = "On-Site Training"
        Me.chkTraining.UseVisualStyleBackColor = True
        '
        'chkLevel3
        '
        Me.chkLevel3.AutoSize = True
        Me.chkLevel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLevel3.Location = New System.Drawing.Point(55, 48)
        Me.chkLevel3.Name = "chkLevel3"
        Me.chkLevel3.Size = New System.Drawing.Size(206, 25)
        Me.chkLevel3.TabIndex = 0
        Me.chkLevel3.Text = "Level-3 Technical Support"
        Me.chkLevel3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.txtOptional)
        Me.GroupBox3.Controls.Add(Me.txtLicense)
        Me.GroupBox3.Controls.Add(Me.lblCostOptional)
        Me.GroupBox3.Controls.Add(Me.lblCostLicensing)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(116, 248)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(476, 157)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'txtOptional
        '
        Me.txtOptional.Enabled = False
        Me.txtOptional.Location = New System.Drawing.Point(299, 96)
        Me.txtOptional.Name = "txtOptional"
        Me.txtOptional.Size = New System.Drawing.Size(100, 29)
        Me.txtOptional.TabIndex = 1
        '
        'txtLicense
        '
        Me.txtLicense.Enabled = False
        Me.txtLicense.Location = New System.Drawing.Point(299, 40)
        Me.txtLicense.Name = "txtLicense"
        Me.txtLicense.Size = New System.Drawing.Size(100, 29)
        Me.txtLicense.TabIndex = 0
        '
        'lblCostOptional
        '
        Me.lblCostOptional.AutoSize = True
        Me.lblCostOptional.Location = New System.Drawing.Point(60, 96)
        Me.lblCostOptional.Name = "lblCostOptional"
        Me.lblCostOptional.Size = New System.Drawing.Size(186, 21)
        Me.lblCostOptional.TabIndex = 1
        Me.lblCostOptional.Text = "Cost of Optional Features"
        '
        'lblCostLicensing
        '
        Me.lblCostLicensing.AutoSize = True
        Me.lblCostLicensing.Location = New System.Drawing.Point(60, 40)
        Me.lblCostLicensing.Name = "lblCostLicensing"
        Me.lblCostLicensing.Size = New System.Drawing.Size(194, 21)
        Me.lblCostLicensing.TabIndex = 0
        Me.lblCostLicensing.Text = "Cost of Software Licensing"
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCalc.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(46, 453)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(193, 40)
        Me.btnCalc.TabIndex = 1
        Me.btnCalc.Text = "Cal&culate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(268, 453)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(193, 40)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Cl&ear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(490, 453)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(193, 40)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(735, 529)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.Text = "Software Sales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radOneTime As RadioButton
    Friend WithEvents radYearly As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkCloud As CheckBox
    Friend WithEvents chkTraining As CheckBox
    Friend WithEvents chkLevel3 As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblCostOptional As Label
    Friend WithEvents lblCostLicensing As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtOptional As TextBox
    Friend WithEvents txtLicense As TextBox
End Class
