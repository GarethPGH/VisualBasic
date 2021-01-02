<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndividualPlan
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
        Me.radMod100 = New System.Windows.Forms.RadioButton()
        Me.radMod200 = New System.Windows.Forms.RadioButton()
        Me.radMod110 = New System.Windows.Forms.RadioButton()
        Me.radUnlimited = New System.Windows.Forms.RadioButton()
        Me.rad1500 = New System.Windows.Forms.RadioButton()
        Me.rad800 = New System.Windows.Forms.RadioButton()
        Me.chkEmail = New System.Windows.Forms.CheckBox()
        Me.chkText = New System.Windows.Forms.CheckBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtTotalPhone = New System.Windows.Forms.TextBox()
        Me.txtOptions = New System.Windows.Forms.TextBox()
        Me.txtPackage = New System.Windows.Forms.TextBox()
        Me.txtTotalMonthly = New System.Windows.Forms.TextBox()
        Me.grpTotals = New System.Windows.Forms.GroupBox()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.grpPhone = New System.Windows.Forms.GroupBox()
        Me.grpPackage = New System.Windows.Forms.GroupBox()
        Me.grpTotals.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.grpPhone.SuspendLayout()
        Me.grpPackage.SuspendLayout()
        Me.SuspendLayout()
        '
        'radMod100
        '
        Me.radMod100.AutoSize = True
        Me.radMod100.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMod100.Location = New System.Drawing.Point(27, 27)
        Me.radMod100.Name = "radMod100"
        Me.radMod100.Size = New System.Drawing.Size(94, 23)
        Me.radMod100.TabIndex = 0
        Me.radMod100.TabStop = True
        Me.radMod100.Text = "Model 100"
        Me.radMod100.UseVisualStyleBackColor = True
        '
        'radMod200
        '
        Me.radMod200.AutoSize = True
        Me.radMod200.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMod200.Location = New System.Drawing.Point(27, 95)
        Me.radMod200.Name = "radMod200"
        Me.radMod200.Size = New System.Drawing.Size(94, 23)
        Me.radMod200.TabIndex = 1
        Me.radMod200.TabStop = True
        Me.radMod200.Text = "Model 200"
        Me.radMod200.UseVisualStyleBackColor = True
        '
        'radMod110
        '
        Me.radMod110.AutoSize = True
        Me.radMod110.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMod110.Location = New System.Drawing.Point(27, 61)
        Me.radMod110.Name = "radMod110"
        Me.radMod110.Size = New System.Drawing.Size(94, 23)
        Me.radMod110.TabIndex = 2
        Me.radMod110.TabStop = True
        Me.radMod110.Text = "Model 110"
        Me.radMod110.UseVisualStyleBackColor = True
        '
        'radUnlimited
        '
        Me.radUnlimited.AutoSize = True
        Me.radUnlimited.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radUnlimited.Location = New System.Drawing.Point(10, 95)
        Me.radUnlimited.Name = "radUnlimited"
        Me.radUnlimited.Size = New System.Drawing.Size(192, 23)
        Me.radUnlimited.TabIndex = 3
        Me.radUnlimited.TabStop = True
        Me.radUnlimited.Text = "Unlimited Minutes/ Month"
        Me.radUnlimited.UseVisualStyleBackColor = True
        '
        'rad1500
        '
        Me.rad1500.AutoSize = True
        Me.rad1500.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad1500.Location = New System.Drawing.Point(10, 61)
        Me.rad1500.Name = "rad1500"
        Me.rad1500.Size = New System.Drawing.Size(161, 23)
        Me.rad1500.TabIndex = 4
        Me.rad1500.TabStop = True
        Me.rad1500.Text = "1500 Minutes/Month"
        Me.rad1500.UseVisualStyleBackColor = True
        '
        'rad800
        '
        Me.rad800.AutoSize = True
        Me.rad800.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad800.Location = New System.Drawing.Point(10, 23)
        Me.rad800.Name = "rad800"
        Me.rad800.Size = New System.Drawing.Size(153, 23)
        Me.rad800.TabIndex = 5
        Me.rad800.TabStop = True
        Me.rad800.Text = "800 Minutes/Month"
        Me.rad800.UseVisualStyleBackColor = True
        '
        'chkEmail
        '
        Me.chkEmail.AutoSize = True
        Me.chkEmail.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEmail.Location = New System.Drawing.Point(27, 24)
        Me.chkEmail.Name = "chkEmail"
        Me.chkEmail.Size = New System.Drawing.Size(60, 23)
        Me.chkEmail.TabIndex = 6
        Me.chkEmail.Text = "Email"
        Me.chkEmail.UseVisualStyleBackColor = True
        '
        'chkText
        '
        Me.chkText.AutoSize = True
        Me.chkText.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkText.Location = New System.Drawing.Point(27, 70)
        Me.chkText.Name = "chkText"
        Me.chkText.Size = New System.Drawing.Size(124, 23)
        Me.chkText.TabIndex = 7
        Me.chkText.Text = "Text Messaging"
        Me.chkText.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(12, 322)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(139, 50)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(12, 392)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(139, 50)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Cl&ose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Phone Subtotal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Total Monthly Charge"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Package Charge"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Options"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Phone Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Tax"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.Location = New System.Drawing.Point(183, 21)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(107, 24)
        Me.txtSubtotal.TabIndex = 16
        '
        'txtTax
        '
        Me.txtTax.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.Location = New System.Drawing.Point(183, 64)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(107, 24)
        Me.txtTax.TabIndex = 17
        '
        'txtTotalPhone
        '
        Me.txtTotalPhone.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPhone.Location = New System.Drawing.Point(183, 105)
        Me.txtTotalPhone.Name = "txtTotalPhone"
        Me.txtTotalPhone.Size = New System.Drawing.Size(107, 24)
        Me.txtTotalPhone.TabIndex = 18
        '
        'txtOptions
        '
        Me.txtOptions.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOptions.Location = New System.Drawing.Point(183, 150)
        Me.txtOptions.Name = "txtOptions"
        Me.txtOptions.Size = New System.Drawing.Size(107, 24)
        Me.txtOptions.TabIndex = 19
        '
        'txtPackage
        '
        Me.txtPackage.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPackage.Location = New System.Drawing.Point(183, 194)
        Me.txtPackage.Name = "txtPackage"
        Me.txtPackage.Size = New System.Drawing.Size(107, 24)
        Me.txtPackage.TabIndex = 20
        '
        'txtTotalMonthly
        '
        Me.txtTotalMonthly.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalMonthly.Location = New System.Drawing.Point(183, 236)
        Me.txtTotalMonthly.Name = "txtTotalMonthly"
        Me.txtTotalMonthly.Size = New System.Drawing.Size(107, 24)
        Me.txtTotalMonthly.TabIndex = 21
        '
        'grpTotals
        '
        Me.grpTotals.Controls.Add(Me.txtTotalMonthly)
        Me.grpTotals.Controls.Add(Me.txtPackage)
        Me.grpTotals.Controls.Add(Me.txtOptions)
        Me.grpTotals.Controls.Add(Me.txtTotalPhone)
        Me.grpTotals.Controls.Add(Me.txtTax)
        Me.grpTotals.Controls.Add(Me.txtSubtotal)
        Me.grpTotals.Controls.Add(Me.Label6)
        Me.grpTotals.Controls.Add(Me.Label5)
        Me.grpTotals.Controls.Add(Me.Label4)
        Me.grpTotals.Controls.Add(Me.Label3)
        Me.grpTotals.Controls.Add(Me.Label2)
        Me.grpTotals.Controls.Add(Me.Label1)
        Me.grpTotals.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTotals.Location = New System.Drawing.Point(197, 193)
        Me.grpTotals.Name = "grpTotals"
        Me.grpTotals.Size = New System.Drawing.Size(311, 274)
        Me.grpTotals.TabIndex = 22
        Me.grpTotals.TabStop = False
        Me.grpTotals.Text = "Totals"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.chkText)
        Me.grpOptions.Controls.Add(Me.chkEmail)
        Me.grpOptions.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOptions.Location = New System.Drawing.Point(12, 193)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(166, 115)
        Me.grpOptions.TabIndex = 23
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Select Options"
        '
        'grpPhone
        '
        Me.grpPhone.Controls.Add(Me.radMod110)
        Me.grpPhone.Controls.Add(Me.radMod200)
        Me.grpPhone.Controls.Add(Me.radMod100)
        Me.grpPhone.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPhone.Location = New System.Drawing.Point(12, 33)
        Me.grpPhone.Name = "grpPhone"
        Me.grpPhone.Size = New System.Drawing.Size(166, 142)
        Me.grpPhone.TabIndex = 24
        Me.grpPhone.TabStop = False
        Me.grpPhone.Text = "Select a Phone"
        '
        'grpPackage
        '
        Me.grpPackage.Controls.Add(Me.rad800)
        Me.grpPackage.Controls.Add(Me.rad1500)
        Me.grpPackage.Controls.Add(Me.radUnlimited)
        Me.grpPackage.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPackage.Location = New System.Drawing.Point(202, 33)
        Me.grpPackage.Name = "grpPackage"
        Me.grpPackage.Size = New System.Drawing.Size(305, 143)
        Me.grpPackage.TabIndex = 25
        Me.grpPackage.TabStop = False
        Me.grpPackage.Text = "Select a Package"
        '
        'IndividualPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 485)
        Me.Controls.Add(Me.grpPackage)
        Me.Controls.Add(Me.grpPhone)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.grpTotals)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "IndividualPlan"
        Me.Text = "Individual Plan"
        Me.grpTotals.ResumeLayout(False)
        Me.grpTotals.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.grpPhone.ResumeLayout(False)
        Me.grpPhone.PerformLayout()
        Me.grpPackage.ResumeLayout(False)
        Me.grpPackage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents radMod100 As RadioButton
    Friend WithEvents radMod200 As RadioButton
    Friend WithEvents radMod110 As RadioButton
    Friend WithEvents radUnlimited As RadioButton
    Friend WithEvents rad1500 As RadioButton
    Friend WithEvents rad800 As RadioButton
    Friend WithEvents chkEmail As CheckBox
    Friend WithEvents chkText As CheckBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtTotalPhone As TextBox
    Friend WithEvents txtOptions As TextBox
    Friend WithEvents txtPackage As TextBox
    Friend WithEvents txtTotalMonthly As TextBox
    Friend WithEvents grpTotals As GroupBox
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents grpPhone As GroupBox
    Friend WithEvents grpPackage As GroupBox
End Class
