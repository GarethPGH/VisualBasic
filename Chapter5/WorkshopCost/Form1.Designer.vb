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
        Me.lstWorkshop = New System.Windows.Forms.ListBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnWorkshop = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpWork = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstLocation = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lstCosts = New System.Windows.Forms.ListBox()
        Me.grpWork.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstWorkshop
        '
        Me.lstWorkshop.FormattingEnabled = True
        Me.lstWorkshop.Location = New System.Drawing.Point(13, 33)
        Me.lstWorkshop.Name = "lstWorkshop"
        Me.lstWorkshop.Size = New System.Drawing.Size(212, 212)
        Me.lstWorkshop.TabIndex = 0
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(383, 326)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(173, 20)
        Me.txtTotal.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(183, 331)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total Cost:"
        '
        'btnWorkshop
        '
        Me.btnWorkshop.Location = New System.Drawing.Point(22, 377)
        Me.btnWorkshop.Name = "btnWorkshop"
        Me.btnWorkshop.Size = New System.Drawing.Size(154, 48)
        Me.btnWorkshop.TabIndex = 5
        Me.btnWorkshop.Text = "&Add Workshop"
        Me.btnWorkshop.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(220, 377)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(154, 48)
        Me.btnTotal.TabIndex = 6
        Me.btnTotal.Text = "&Calculate Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(421, 377)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(154, 48)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(614, 377)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(154, 48)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpWork
        '
        Me.grpWork.Controls.Add(Me.lstWorkshop)
        Me.grpWork.Location = New System.Drawing.Point(9, 38)
        Me.grpWork.Name = "grpWork"
        Me.grpWork.Size = New System.Drawing.Size(238, 266)
        Me.grpWork.TabIndex = 1
        Me.grpWork.TabStop = False
        Me.grpWork.Text = "Pick a Workshop"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstLocation)
        Me.GroupBox2.Location = New System.Drawing.Point(281, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(238, 266)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pick a Location"
        '
        'lstLocation
        '
        Me.lstLocation.FormattingEnabled = True
        Me.lstLocation.Location = New System.Drawing.Point(13, 33)
        Me.lstLocation.Name = "lstLocation"
        Me.lstLocation.Size = New System.Drawing.Size(212, 212)
        Me.lstLocation.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lstCosts)
        Me.GroupBox3.Location = New System.Drawing.Point(550, 38)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(238, 266)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "List of Costs"
        '
        'lstCosts
        '
        Me.lstCosts.Enabled = False
        Me.lstCosts.FormattingEnabled = True
        Me.lstCosts.Location = New System.Drawing.Point(13, 33)
        Me.lstCosts.Name = "lstCosts"
        Me.lstCosts.Size = New System.Drawing.Size(212, 212)
        Me.lstCosts.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpWork)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btnWorkshop)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Workshop Selector"
        Me.grpWork.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstWorkshop As ListBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnWorkshop As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpWork As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lstLocation As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lstCosts As ListBox
End Class
