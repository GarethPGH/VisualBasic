Public Class FindMember
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim strName As String = txtLastName.Text
        Me.MembersTableAdapter.Fill(Me.FindMemberDataset1.Members, strName)
        dgvFindMember.ColumnHeadersVisible = True
    End Sub

    Private Sub FindMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvFindMember.RowHeadersVisible = False
        dgvFindMember.ColumnHeadersVisible = False
    End Sub
End Class