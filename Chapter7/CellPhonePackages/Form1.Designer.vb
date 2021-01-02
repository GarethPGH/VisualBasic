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
        Me.btnIndivid = New System.Windows.Forms.Button()
        Me.btnFamily = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIndivid
        '
        Me.btnIndivid.Location = New System.Drawing.Point(250, 24)
        Me.btnIndivid.Name = "btnIndivid"
        Me.btnIndivid.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnIndivid.Size = New System.Drawing.Size(161, 60)
        Me.btnIndivid.TabIndex = 0
        Me.btnIndivid.Text = "&Individual"
        Me.btnIndivid.UseVisualStyleBackColor = True
        '
        'btnFamily
        '
        Me.btnFamily.Location = New System.Drawing.Point(250, 139)
        Me.btnFamily.Name = "btnFamily"
        Me.btnFamily.Size = New System.Drawing.Size(161, 60)
        Me.btnFamily.TabIndex = 1
        Me.btnFamily.Text = "&Family"
        Me.btnFamily.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(131, 256)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(161, 60)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "E&xit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 33)
        Me.Label1.MaximumSize = New System.Drawing.Size(200, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 51)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "The Individual Plan provides one cell phone and a variety of monthly packages"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 131)
        Me.Label2.MaximumSize = New System.Drawing.Size(200, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 68)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "The Family Plan allows you to purchase multiple cell phones of the same model wit" &
    "h the same monthly package"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnFamily)
        Me.GroupBox1.Controls.Add(Me.btnIndivid)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 222)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Plan"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 332)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.Text = "Cell Phone Packages"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnIndivid As Button
    Friend WithEvents btnFamily As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
