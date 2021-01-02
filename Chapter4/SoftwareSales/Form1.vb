Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCostLicensing.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLicense.Text = String.Empty
        txtOptional.Text = String.Empty
        radOneTime.Checked = False
        radYearly.Checked = False
        chkCloud.Checked = False
        chkLevel3.Checked = False
        chkTraining.Checked = False
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim intLicense As Integer = 0.0
        Dim intOptions As Integer = 0.0

        If radOneTime.Checked Then
            intLicense = 20000
        ElseIf radYearly.Checked Then
            intLicense = 5000
        End If

        If chkCloud.Checked Then
            intOptions += 300
        End If
        If chkLevel3.Checked Then
            intOptions += 3500
        End If
        If chkTraining.Checked Then
            intOptions += 2000
        End If

        txtLicense.Text = intLicense.ToString("c")
        txtOptional.Text = intOptions.ToString("c")
    End Sub
End Class
