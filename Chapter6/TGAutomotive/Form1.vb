Public Class Form1
    'Methods for Calculate Button
    Function ValidateInputs(ByVal strMinutesInput As String, ByVal strPartsInput As String) As Boolean
        Dim blnInputField As Boolean = False
        Dim decPlaceholder As Decimal

        If IsNumeric(strPartsInput) And Decimal.TryParse(strPartsInput, decPlaceholder) = True Then
            If IsNumeric(strMinutesInput) And Decimal.TryParse(strMinutesInput, decPlaceholder) = True Then
                blnInputField = True
            End If
        End If
        Return blnInputField
    End Function

    Function CalcOilLubeCharges() As Decimal
        Dim decCost As Decimal = 0.0
        If chkOil.Checked() Then
            decCost += 36.0
        End If
        If chkLube.Checked() Then
            decCost += 28.0
        End If
        Return decCost
    End Function

    Function CalcFlushCharges() As Decimal
        Dim decCost As Decimal = 0
        If chkRad.Checked() Then
            decCost += 50.0
        End If
        If chkTran.Checked() Then
            decCost += 120.0
        End If
        Return decCost
    End Function

    Function CalcMiscCharges() As Decimal
        Dim decCost As Decimal = 0
        If chkInsp.Checked() Then
            decCost += 15.0
        End If
        If chkMuff.Checked() Then
            decCost += 200.0
        End If
        If chkTire.Checked() Then
            decCost += 20.0
        End If
        Return decCost
    End Function

    Sub CalculateTotalCharges()
        Const DEC_TAX As Decimal = 0.06
        Dim decTotal As Decimal
        Dim decServices As Decimal
        Dim decLabor As Decimal
        Dim strMinutes As String = txtMinutes.Text
        Dim strParts As String = txtParts.Text
        Dim blnValidate As Boolean = ValidateInputs(strMinutes, strParts)
        Dim decOil As Decimal = CalcOilLubeCharges()
        Dim decFlush As Decimal = CalcFlushCharges()
        Dim decMisc As Decimal = CalcMiscCharges()

        Dim decMinutes As Decimal
        Dim decParts As Decimal
        Decimal.TryParse(strMinutes, decMinutes)
        Decimal.TryParse(strParts, decParts)

        If blnValidate = True Then
            decLabor = (decMinutes / 60) * 60
            decServices = decOil + decFlush + decMisc
            decTotal = decServices + decParts + decLabor

            txtTotal.Text = decTotal.ToString("c")
            txtServices.Text = decServices.ToString("c")
            txtPartsCost.Text = decParts.ToString("c")
            txtTax.Text = (decParts * DEC_TAX).ToString("c")
        Else
            MessageBox.Show("Please Provide Numerical Values for Parts and Minutes")
        End If

    End Sub

    'Methods for Clear Button
    Sub ClearOilLube()
        chkLube.Checked = False
        chkOil.Checked = False
    End Sub

    Sub ClearFlushes()
        chkRad.Checked = False
        chkTran.Checked = False
    End Sub

    Sub ClearMisc()
        chkTire.Checked = False
        chkMuff.Checked = False
        chkInsp.Checked = False
    End Sub

    Sub ClearOther()
        txtMinutes.Text = String.Empty
        txtParts.Text = String.Empty
        txtPartsCost.Text = String.Empty
        txtServices.Text = String.Empty
        txtTax.Text = String.Empty
        txtTotal.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        CalculateTotalCharges()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFlushes()
        ClearMisc()
        ClearOilLube()
        ClearOther()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
