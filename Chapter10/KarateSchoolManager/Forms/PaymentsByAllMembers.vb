Public Class PaymentsByAllMembers

    Private Sub PaymentsByAllMembers_Load(sender As Object, e As EventArgs)
        'TODO: This line of code loads data into the 'KarateDataSet.Payments' table. You can move, or remove it, as needed.
        Me.PaymentsTableAdapter1.FillTable(Me.AllPaymentsDataset1.Payments)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub PaymentsByAllMembers_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AllPaymentsDataset.Payments' table. You can move, or remove it, as needed.
        Me.PaymentsTableAdapter1.FillTable(Me.AllPaymentsDataset.Payments)

    End Sub
End Class