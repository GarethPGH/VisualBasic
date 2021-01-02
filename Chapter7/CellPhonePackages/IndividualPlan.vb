Imports System.Runtime.Remoting.Messaging

Public Class IndividualPlan
    Function SelectPhone() As Decimal
        Dim decPhone As Decimal = 0.0
        If radMod100.Checked Then
            decPhone = 29.95
        ElseIf radMod110.Checked Then
            decPhone = 49.95
        ElseIf radMod200.Checked Then
            decPhone = 99.95
        End If

        Return decPhone
    End Function

    Function SelectOptions() As Decimal
        Dim decOptions As Decimal = 0.0
        If chkEmail.Checked Then
            decOptions += 25.0
        End If
        If chkText.Checked Then
            decOptions += 10.0
        End If

        Return decOptions
    End Function

    Function SelectMinutes() As Decimal
        Dim decMinutes As Decimal = 0.0
        If rad800.Checked Then
            decMinutes = 45.0
        ElseIf rad1500.Checked Then
            decMinutes = 65.0
        ElseIf radUnlimited.Checked Then
            decMinutes = 99.0
        End If

        Return decMinutes
    End Function

    Function CalculateTax(ByVal decPhone As Decimal) As Decimal
        Dim decSALES_TAX As Decimal = 0.06
        Dim decTax As Decimal = decPhone * decSALES_TAX

        Return decTax
    End Function
    Function CalculateTotalMonthly(ByVal decMinutes As Decimal, ByVal decOptions As Decimal)
        Dim decTotal As Decimal
        decTotal = decMinutes + decOptions
        Return decTotal
    End Function
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim decPhoneCost = SelectPhone()
        Dim decTax As Decimal = CalculateTax(decPhoneCost)
        Dim decMinutes As Decimal = SelectMinutes()
        Dim decOptions As Decimal = SelectOptions()
        Dim decTotal As Decimal = CalculateTotalMonthly(decMinutes, decOptions)
        Dim decPhoneTotal As Decimal = decPhoneCost + decTax

        txtPackage.Text = decMinutes.ToString("c")
        txtTax.Text = decTax.ToString("c")
        txtOptions.Text = decOptions.ToString("c")
        txtSubtotal.Text = decPhoneCost.ToString("c")
        txtTotalMonthly.Text = decTotal.ToString("c")
        txtTotalPhone.Text = decPhoneTotal.ToString("c")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class