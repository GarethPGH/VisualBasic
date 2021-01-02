Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim rectangle As New Rectangle()
        Dim carpet As New Carpet()
        Dim decCost As Decimal = 0.0D

        If IsNumeric(txtLen.Text) And IsNumeric(txtWid.Text) Then
            rectangle.Length = CSng(txtLen.Text)
            rectangle.Width = CSng(txtWid.Text)
            If rectangle.Length > 0.0F And rectangle.Width > 0.0F Then
                txtArea.Text = rectangle.CalcArea().ToString
            Else
                MessageBox.Show("Length and Width values must be greater than zero")
                clearNumericFields()
            End If
        Else
            MessageBox.Show("Length and Width values must be a number")
            clearNumericFields()
        End If

        If txtColor.Text IsNot String.Empty And txtStyle.Text IsNot String.Empty Then
            carpet.Color = txtColor.Text
            carpet.Style = txtStyle.Text
        End If
        If IsNumeric(txtPrice.Text) Then
            If txtPrice.Text >= 0.0D Then
                carpet.Price = CDec(txtPrice.Text)
            Else
                MessageBox.Show("Price can't be negative")
                clearNumericFields()
            End If
        Else
            MessageBox.Show("Price must be a number")
            clearNumericFields()
        End If

        If carpet.Price >= 0.0D And rectangle.CalcArea > 0.0F Then
            decCost = carpet.Price * rectangle.CalcArea
            txtTotal.Text = decCost.ToString("c")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtColor.Text = String.Empty
        txtStyle.Text = String.Empty
        clearNumericFields()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub clearNumericFields()
        txtTotal.Text = String.Empty
        txtWid.Text = String.Empty
        txtArea.Text = String.Empty
        txtLen.Text = String.Empty
        txtPrice.Text = String.Empty
    End Sub
End Class
