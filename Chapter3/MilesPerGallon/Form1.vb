Public Class MPG
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Try
            Dim decMiles As Decimal
            Dim decGallons As Decimal
            Dim decMPG As Decimal

            decMiles = CInt(txtMiles.Text)
            decGallons = CInt(txtGallons.Text)

            decMPG = decMiles / decGallons

            txtMPG.Text = decMPG.ToString("n2")
        Catch
            MessageBox.Show("Please enter a valid number for Miles and Gallons")
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMiles.Text = String.Empty
        txtGallons.Text = String.Empty
        txtMPG.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
