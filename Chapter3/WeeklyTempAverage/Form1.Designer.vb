<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AverageTemp
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
        Me.txtWk1 = New System.Windows.Forms.TextBox()
        Me.txtWk3 = New System.Windows.Forms.TextBox()
        Me.txtWk2 = New System.Windows.Forms.TextBox()
        Me.txtWk4 = New System.Windows.Forms.TextBox()
        Me.txtWk5 = New System.Windows.Forms.TextBox()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtWk1
        '
        Me.txtWk1.Location = New System.Drawing.Point(195, 45)
        Me.txtWk1.Name = "txtWk1"
        Me.txtWk1.Size = New System.Drawing.Size(202, 20)
        Me.txtWk1.TabIndex = 0
        '
        'txtWk3
        '
        Me.txtWk3.Location = New System.Drawing.Point(195, 148)
        Me.txtWk3.Name = "txtWk3"
        Me.txtWk3.Size = New System.Drawing.Size(202, 20)
        Me.txtWk3.TabIndex = 2
        '
        'txtWk2
        '
        Me.txtWk2.Location = New System.Drawing.Point(195, 95)
        Me.txtWk2.Name = "txtWk2"
        Me.txtWk2.Size = New System.Drawing.Size(202, 20)
        Me.txtWk2.TabIndex = 1
        '
        'txtWk4
        '
        Me.txtWk4.Location = New System.Drawing.Point(195, 196)
        Me.txtWk4.Name = "txtWk4"
        Me.txtWk4.Size = New System.Drawing.Size(202, 20)
        Me.txtWk4.TabIndex = 3
        '
        'txtWk5
        '
        Me.txtWk5.Location = New System.Drawing.Point(195, 248)
        Me.txtWk5.Name = "txtWk5"
        Me.txtWk5.Size = New System.Drawing.Size(202, 20)
        Me.txtWk5.TabIndex = 4
        '
        'txtAverage
        '
        Me.txtAverage.Enabled = False
        Me.txtAverage.Location = New System.Drawing.Point(195, 319)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(202, 20)
        Me.txtAverage.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sylfaen", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 27)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Week #1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sylfaen", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 27)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Week #2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sylfaen", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 27)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Week #3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sylfaen", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 27)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Week #4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sylfaen", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 27)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Week #5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(33, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Average:"
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(22, 379)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(127, 56)
        Me.btnCalc.TabIndex = 9
        Me.btnCalc.Text = "Cal&culate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(155, 379)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(130, 56)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Cl&ear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(291, 379)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(133, 56)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'AverageTemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 457)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAverage)
        Me.Controls.Add(Me.txtWk5)
        Me.Controls.Add(Me.txtWk4)
        Me.Controls.Add(Me.txtWk2)
        Me.Controls.Add(Me.txtWk3)
        Me.Controls.Add(Me.txtWk1)
        Me.Name = "AverageTemp"
        Me.Text = "Average Weekly Temperature"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtWk1 As TextBox
    Friend WithEvents txtWk3 As TextBox
    Friend WithEvents txtWk2 As TextBox
    Friend WithEvents txtWk4 As TextBox
    Friend WithEvents txtWk5 As TextBox
    Friend WithEvents txtAverage As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Try
            Dim intWk1 As Integer
            Dim intWk2 As Integer
            Dim intWk3 As Integer
            Dim intWk4 As Integer
            Dim intWk5 As Integer
            Dim intAverage As Integer

            intWk1 = CInt(txtWk1.Text)
            intWk2 = CInt(txtWk2.Text)
            intWk3 = CInt(txtWk3.Text)
            intWk4 = CInt(txtWk4.Text)
            intWk5 = CInt(txtWk5.Text)

            intAverage = (intWk1 + intWk2 + intWk3 + intWk4 + intWk5) / 5
            txtAverage.Text = intAverage.ToString()

        Catch ex As Exception
            MessageBox.Show("Please enter valid temperature numbers")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtWk1.Text = String.Empty
        txtWk2.Text = String.Empty
        txtWk3.Text = String.Empty
        txtWk4.Text = String.Empty
        txtWk5.Text = String.Empty
        txtAverage.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
