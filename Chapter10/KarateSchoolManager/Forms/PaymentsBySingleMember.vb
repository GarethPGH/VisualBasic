Public Class PaymentsBySingleMember
    Private Sub PaymentsBySingleMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PaymentByOneMemberDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.PaymentByOneMemberDataSet.Members)
    End Sub

    Private Sub lstMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMembers.SelectedIndexChanged
        Dim strName As String = lstMembers.SelectedValue.ToString
        Me.PaymentsTableAdapter.Fill(Me.PaymentByOneMemberDataSet.Payments, strName)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class