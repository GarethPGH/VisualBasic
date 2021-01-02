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
        Me.btnClr = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCalories = New System.Windows.Forms.Label()
        Me.lblFat = New System.Windows.Forms.Label()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.txtCalories = New System.Windows.Forms.TextBox()
        Me.txtFat = New System.Windows.Forms.TextBox()
        Me.txtPercent = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCalc.Location = New System.Drawing.Point(27, 249)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(188, 44)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Cal&culate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnClr
        '
        Me.btnClr.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClr.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClr.Location = New System.Drawing.Point(221, 249)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(188, 44)
        Me.btnClr.TabIndex = 4
        Me.btnClr.Text = "Cl&ear"
        Me.btnClr.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(415, 249)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(188, 44)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblCalories
        '
        Me.lblCalories.AutoSize = True
        Me.lblCalories.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalories.Location = New System.Drawing.Point(63, 35)
        Me.lblCalories.Name = "lblCalories"
        Me.lblCalories.Size = New System.Drawing.Size(231, 22)
        Me.lblCalories.TabIndex = 3
        Me.lblCalories.Text = "Total Calories in Food Item"
        Me.lblCalories.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFat
        '
        Me.lblFat.AutoSize = True
        Me.lblFat.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFat.Location = New System.Drawing.Point(63, 109)
        Me.lblFat.Name = "lblFat"
        Me.lblFat.Size = New System.Drawing.Size(223, 22)
        Me.lblFat.TabIndex = 4
        Me.lblFat.Text = "Grams of Fat in Food Item"
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.Location = New System.Drawing.Point(63, 182)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(261, 22)
        Me.lblPercent.TabIndex = 5
        Me.lblPercent.Text = "Percentage of Fat in Food Item"
        '
        'txtCalories
        '
        Me.txtCalories.Location = New System.Drawing.Point(371, 35)
        Me.txtCalories.Name = "txtCalories"
        Me.txtCalories.Size = New System.Drawing.Size(176, 20)
        Me.txtCalories.TabIndex = 0
        '
        'txtFat
        '
        Me.txtFat.Location = New System.Drawing.Point(371, 112)
        Me.txtFat.Name = "txtFat"
        Me.txtFat.Size = New System.Drawing.Size(176, 20)
        Me.txtFat.TabIndex = 1
        '
        'txtPercent
        '
        Me.txtPercent.Enabled = False
        Me.txtPercent.Location = New System.Drawing.Point(371, 182)
        Me.txtPercent.Name = "txtPercent"
        Me.txtPercent.Size = New System.Drawing.Size(176, 20)
        Me.txtPercent.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(633, 323)
        Me.Controls.Add(Me.txtPercent)
        Me.Controls.Add(Me.txtFat)
        Me.Controls.Add(Me.txtCalories)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.lblFat)
        Me.Controls.Add(Me.lblCalories)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.btnCalc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "Fat Percentage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClr As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCalories As Label
    Friend WithEvents lblFat As Label
    Friend WithEvents lblPercent As Label
    Friend WithEvents txtCalories As TextBox
    Friend WithEvents txtFat As TextBox
    Friend WithEvents txtPercent As TextBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCalories.TextChanged

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim decFat As Decimal
        Dim decCalories As Decimal
        Dim decFatPercent As Decimal

        If (Decimal.TryParse(txtFat.Text, decFat)) Then
            decFat = CDec(txtFat.Text)
        Else
            txtFat.Text = "Please Enter a Numerical Value"
        End If

        If (Decimal.TryParse(txtCalories.Text, decCalories)) Then
            decCalories = CDec(txtCalories.Text)
        Else
            txtCalories.Text = "Please Enter a Numerical Value"
        End If

        If ((Decimal.TryParse(txtFat.Text, decFat) = False) Or (Decimal.TryParse(txtCalories.Text, decCalories) = False)) Then 
            MessageBox.Show("Operation Invalid")
            txtPercent.Text = String.Empty
        Elseif( (decFat * 9d) > decCalories Or decCalories <= 0 ) Then
            MessageBox.Show("Total Calories of Fat can not be greater than Total Calories, Or Calories can't be less than zero. Please double check your info, re-enter, and try again")
        Else
            decFatPercent = (decFat * 9d)/ decCalories
            txtPercent.Text = decFatPercent.ToString("p")
            decFatPercent *= 100d

            If (decFatPercent >= 0d And decFatPercent < 30d) Then
                MessageBox.Show("This Food Item is low in fat")
            End If
        End If       
    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        txtFat.Text = String.Empty
        txtCalories.Text = String.Empty
        txtPercent.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
