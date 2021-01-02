Public Class Form1
    Private Sub btnIndivid_Click(sender As Object, e As EventArgs) Handles btnIndivid.Click
        Dim frmIndivid As New IndividualPlan
        frmIndivid.ShowDialog()
    End Sub

    Private Sub btnFamily_Click(sender As Object, e As EventArgs) Handles btnFamily.Click
        Dim frmFamily As New FamilyPlan
        frmFamily.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
