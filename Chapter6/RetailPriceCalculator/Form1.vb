Public Class Form1
    Private Function CalculateRetail(ByVal dblPrice As Double, ByVal dblMarkup As Double) As Double
        Dim dblPercentage As Double = dblMarkup * 0.01
        Dim dblRetailCost As Double

        dblRetailCost = (dblPercentage * dblPrice) + dblPrice
        Return dblRetailCost
    End Function


    Private Sub btnRetail_Click(sender As Object, e As EventArgs) Handles btnRetail.Click
        Dim dblGivenMarkup As Double
        Dim dblGivenPrice As Double
        Dim dblRetailCost As Double

        If (IsNumeric(txtMarkup.Text)) Then
            dblGivenMarkup = CDbl(txtMarkup.Text)
        Else
            txtMarkup.Text = "Invalid Input"
        End If

        If (IsNumeric(txtWholesale.Text)) Then
            dblGivenPrice = CDbl(txtWholesale.Text)
        Else
            txtWholesale.Text = "Invalid Input"
        End If

        If (dblGivenMarkup > 0 And dblGivenPrice > 0) Then
            dblRetailCost = CalculateRetail(dblGivenPrice, dblGivenMarkup)
            txtRetail.Text = dblRetailCost.ToString("c")
        Else
            MessageBox.Show("Please Enter Valid Numeric Values and Try Again")
            txtRetail.Text = ""
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
