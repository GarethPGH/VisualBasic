﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AudioBooks
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
        Me.lstAudio = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCart = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstAudio
        '
        Me.lstAudio.FormattingEnabled = True
        Me.lstAudio.Location = New System.Drawing.Point(38, 55)
        Me.lstAudio.Name = "lstAudio"
        Me.lstAudio.Size = New System.Drawing.Size(312, 173)
        Me.lstAudio.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select An Audio Book"
        '
        'btnCart
        '
        Me.btnCart.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCart.Location = New System.Drawing.Point(38, 257)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Size = New System.Drawing.Size(136, 52)
        Me.btnCart.TabIndex = 2
        Me.btnCart.Text = "&Add To Cart"
        Me.btnCart.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(214, 257)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(136, 52)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'AudioBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 346)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstAudio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "AudioBooks"
        Me.Text = "AudioBooks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstAudio As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCart As Button
    Friend WithEvents btnClose As Button
End Class
