﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KayakTypesTableAdapter.Fill(Me.KayaksDataSet.KayakTypes)
    End Sub
End Class
