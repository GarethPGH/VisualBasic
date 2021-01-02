Public Class MainForm

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub ListAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListAllToolStripMenuItem.Click
        Dim frmAllMembers = New AllMembers
        frmAllMembers.ShowDialog()
    End Sub

    Private Sub FindMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindMemberToolStripMenuItem.Click
        Dim frmFindMember As New FindMember
        frmFindMember.ShowDialog()
    End Sub

    Private Sub AddNewMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewMemberToolStripMenuItem.Click
        Dim frmAddMember = New AddNewMember
        frmAddMember.ShowDialog()
    End Sub

    Private Sub AllMembersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllMembersToolStripMenuItem.Click
        Dim frmPaymentAll = New PaymentsByAllMembers
        frmPaymentAll.ShowDialog()
    End Sub

    Private Sub ByMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByMemberToolStripMenuItem.Click
        Dim frmPaymentBy = New PaymentsBySingleMember
        frmPaymentBy.ShowDialog()
    End Sub
End Class
