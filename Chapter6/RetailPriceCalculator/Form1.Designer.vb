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
        Me.btnRetail = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblWholesale = New System.Windows.Forms.Label()
        Me.lblMarkup = New System.Windows.Forms.Label()
        Me.lblRetail = New System.Windows.Forms.Label()
        Me.txtWholesale = New System.Windows.Forms.TextBox()
        Me.txtMarkup = New System.Windows.Forms.TextBox()
        Me.txtRetail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnRetail
        '
        Me.btnRetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRetail.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetail.Location = New System.Drawing.Point(27, 245)
        Me.btnRetail.Name = "btnRetail"
        Me.btnRetail.Size = New System.Drawing.Size(164, 51)
        Me.btnRetail.TabIndex = 3
        Me.btnRetail.Text = "Get &Retail Cost"
        Me.btnRetail.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(230, 245)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(164, 51)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblWholesale
        '
        Me.lblWholesale.AutoSize = True
        Me.lblWholesale.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWholesale.Location = New System.Drawing.Point(12, 37)
        Me.lblWholesale.Name = "lblWholesale"
        Me.lblWholesale.Size = New System.Drawing.Size(204, 18)
        Me.lblWholesale.TabIndex = 2
        Me.lblWholesale.Text = "Wholesale Cost of Item"
        '
        'lblMarkup
        '
        Me.lblMarkup.AutoSize = True
        Me.lblMarkup.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarkup.Location = New System.Drawing.Point(28, 99)
        Me.lblMarkup.Name = "lblMarkup"
        Me.lblMarkup.Size = New System.Drawing.Size(163, 18)
        Me.lblMarkup.TabIndex = 3
        Me.lblMarkup.Text = "Markup Percentage"
        '
        'lblRetail
        '
        Me.lblRetail.AutoSize = True
        Me.lblRetail.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetail.Location = New System.Drawing.Point(58, 164)
        Me.lblRetail.Name = "lblRetail"
        Me.lblRetail.Size = New System.Drawing.Size(99, 18)
        Me.lblRetail.TabIndex = 4
        Me.lblRetail.Text = "Retail Cost"
        '
        'txtWholesale
        '
        Me.txtWholesale.Location = New System.Drawing.Point(230, 35)
        Me.txtWholesale.Name = "txtWholesale"
        Me.txtWholesale.Size = New System.Drawing.Size(149, 20)
        Me.txtWholesale.TabIndex = 0
        '
        'txtMarkup
        '
        Me.txtMarkup.Location = New System.Drawing.Point(230, 100)
        Me.txtMarkup.Name = "txtMarkup"
        Me.txtMarkup.Size = New System.Drawing.Size(149, 20)
        Me.txtMarkup.TabIndex = 1
        '
        'txtRetail
        '
        Me.txtRetail.Enabled = False
        Me.txtRetail.Location = New System.Drawing.Point(230, 162)
        Me.txtRetail.Name = "txtRetail"
        Me.txtRetail.Size = New System.Drawing.Size(149, 20)
        Me.txtRetail.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(421, 334)
        Me.Controls.Add(Me.txtRetail)
        Me.Controls.Add(Me.txtMarkup)
        Me.Controls.Add(Me.txtWholesale)
        Me.Controls.Add(Me.lblRetail)
        Me.Controls.Add(Me.lblMarkup)
        Me.Controls.Add(Me.lblWholesale)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRetail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Retail Price Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRetail As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblWholesale As Label
    Friend WithEvents lblMarkup As Label
    Friend WithEvents lblRetail As Label
    Friend WithEvents txtWholesale As TextBox
    Friend WithEvents txtMarkup As TextBox
    Friend WithEvents txtRetail As TextBox
End Class
