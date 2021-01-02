<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class card_identifier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(card_identifier))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.imgAce = New System.Windows.Forms.PictureBox()
        Me.imgJack = New System.Windows.Forms.PictureBox()
        Me.imgJoker = New System.Windows.Forms.PictureBox()
        Me.imgKing = New System.Windows.Forms.PictureBox()
        Me.imgQueen = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.imgAce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgJack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgJoker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgKing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgQueen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(277, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(518, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click on a Card to see its Name"
        '
        'imgAce
        '
        Me.imgAce.Image = CType(resources.GetObject("imgAce.Image"), System.Drawing.Image)
        Me.imgAce.Location = New System.Drawing.Point(20, 84)
        Me.imgAce.MaximumSize = New System.Drawing.Size(181, 266)
        Me.imgAce.Name = "imgAce"
        Me.imgAce.Size = New System.Drawing.Size(181, 266)
        Me.imgAce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgAce.TabIndex = 1
        Me.imgAce.TabStop = False
        '
        'imgJack
        '
        Me.imgJack.Image = CType(resources.GetObject("imgJack.Image"), System.Drawing.Image)
        Me.imgJack.Location = New System.Drawing.Point(234, 84)
        Me.imgJack.Name = "imgJack"
        Me.imgJack.Size = New System.Drawing.Size(181, 266)
        Me.imgJack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgJack.TabIndex = 2
        Me.imgJack.TabStop = False
        '
        'imgJoker
        '
        Me.imgJoker.Image = CType(resources.GetObject("imgJoker.Image"), System.Drawing.Image)
        Me.imgJoker.Location = New System.Drawing.Point(451, 84)
        Me.imgJoker.Name = "imgJoker"
        Me.imgJoker.Size = New System.Drawing.Size(181, 266)
        Me.imgJoker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgJoker.TabIndex = 3
        Me.imgJoker.TabStop = False
        '
        'imgKing
        '
        Me.imgKing.Image = CType(resources.GetObject("imgKing.Image"), System.Drawing.Image)
        Me.imgKing.Location = New System.Drawing.Point(663, 84)
        Me.imgKing.Name = "imgKing"
        Me.imgKing.Size = New System.Drawing.Size(181, 266)
        Me.imgKing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgKing.TabIndex = 4
        Me.imgKing.TabStop = False
        '
        'imgQueen
        '
        Me.imgQueen.Image = CType(resources.GetObject("imgQueen.Image"), System.Drawing.Image)
        Me.imgQueen.Location = New System.Drawing.Point(872, 84)
        Me.imgQueen.Name = "imgQueen"
        Me.imgQueen.Size = New System.Drawing.Size(181, 266)
        Me.imgQueen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgQueen.TabIndex = 5
        Me.imgQueen.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkRed
        Me.Button1.Location = New System.Drawing.Point(451, 438)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 61)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(317, 367)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(478, 46)
        Me.TextBox1.TabIndex = 8
        '
        'card_identifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1080, 523)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.imgQueen)
        Me.Controls.Add(Me.imgKing)
        Me.Controls.Add(Me.imgJoker)
        Me.Controls.Add(Me.imgJack)
        Me.Controls.Add(Me.imgAce)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "card_identifier"
        Me.Text = "Card Identifier"
        CType(Me.imgAce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgJack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgJoker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgKing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgQueen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents imgAce As PictureBox
    Friend WithEvents imgJack As PictureBox
    Friend WithEvents imgJoker As PictureBox
    Friend WithEvents imgKing As PictureBox
    Friend WithEvents imgQueen As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
