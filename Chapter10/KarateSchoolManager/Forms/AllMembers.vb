Public Class AllMembers
    Private Sub AllMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MembersDataSet1.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.MembersDataSet1.Members)
        'TODO: This line of code loads data into the 'MembersDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.MembersDataSet.Members)

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Me.MembersTableAdapter.Update(Me.MembersDataSet.Members)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class