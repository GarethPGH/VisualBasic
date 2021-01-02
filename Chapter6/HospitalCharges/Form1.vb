Public Class Form1
    Function CalcStayCharges(ByVal strDays As String) As Decimal
        If strDays = String.Empty Then
            strDays = "0"
        End If
        Const decCOST_PER_DAY As Decimal = 350.0
        Dim intDays As Integer = CInt(strDays)
        Dim decCost As Decimal
        decCost = CDec(intDays) * decCOST_PER_DAY

        Return decCost
    End Function
    Function CalcMiscCharges(ByVal strMeds As String, ByVal strSurge As String, ByVal strLab As String, ByVal strRehab As String) As Decimal
        Dim decMeds As Decimal
        Dim decSurge As Decimal
        Dim decLab As Decimal
        Dim decRehab As Decimal
        If strSurge = String.Empty Then
            decSurge = 0.0
        Else
            decSurge = CDec(strSurge)
        End If
        If strMeds = String.Empty Then
            decMeds = 0.0
        Else
            decMeds = CDec(strMeds)
        End If
        If strLab = String.Empty Then
            decLab = 0.0
        Else
            decLab = CDec(strLab)
        End If
        If strRehab = String.Empty Then
            decRehab = 0.0
        Else
            decRehab = CDec(strRehab)
        End If

        Dim decMisc As Decimal

        decMisc = decMeds + decLab + decRehab + decSurge
        Return decMisc
    End Function
    Function CalcTotalCharges(ByVal decMisc As Decimal, ByVal decStay As Decimal) As Decimal
        Return decMisc + decStay
    End Function

    Function ValidateInputFields() As Boolean
        Dim blnPasses As Boolean = True
        Dim intCounter As Integer = 0
        Dim blnValid As Boolean
        Dim strStay As String = txtDays.Text
        Dim strSurge As String = txtSurge.Text
        Dim strLab As String = txtLab.Text
        Dim strRehab As String = txtRehab.Text
        Dim strMeds As String = txtMeds.Text
        Dim intPlaceholder As Integer
        Dim decPlaceholder As Decimal

        Dim strInvalid As String = "Invalid Field(s):"

        'Check Stay
        blnValid = Integer.TryParse(strStay, intPlaceholder)
        If (blnValid = False) Then
            If txtDays.Text = String.Empty Then
                blnPasses = True
                intPlaceholder = 0
            Else
                blnPasses = False
                txtDays.Text = ""
                strInvalid &= vbNewLine & "Length of Stay(Days): Must be a Whole Number(Integer)"
            End If
        ElseIf blnValid = True Then
                If (intPlaceholder < 0) Then
                txtDays.Text = ""
                blnPasses = False
                strInvalid &= vbNewLine & "Length of Stay(Days): Whole Number Must be Greater or Equal to Zero"
            End If
        End If
        If blnPasses = True Then
            intCounter += 1
        End If

        'Check Surgery
        blnValid = Decimal.TryParse(strSurge, decPlaceholder)
        If (blnValid = False) Then
            If txtSurge.Text = String.Empty Then
                blnPasses = True
                decPlaceholder = 0.0
            Else
                txtSurge.Text = ""
                blnPasses = False
                strInvalid &= vbNewLine & "Surgical Charges: Must be a Numerical Value"
            End If
        ElseIf blnValid = True Then
            If decPlaceholder < 0 Then
                txtSurge.Text = ""
                blnPasses = False
                strInvalid &= vbNewLine & "Surgical Charges: Number Must be Greater or Equal to Zero"
            End If
        End If
        If blnPasses = True Then
            intCounter += 1
        End If

        'Check Lab
        blnValid = Decimal.TryParse(strLab, decPlaceholder)
        If (blnValid = False) Then
            If txtLab.Text = String.Empty Then
                blnPasses = True
                decPlaceholder = 0.0
            Else
                txtLab.Text = ""
                blnPasses = False
                strInvalid &= vbNewLine & "Lab Fees: Must be a Numerical Value"
            End If
        ElseIf blnValid = True Then
            If decPlaceholder < 0 Then
                txtLab.Text = ""
                blnPasses = False
                strInvalid &= vbNewLine & "Lab Fees: Number Must be Greater or Equal to Zero"
            End If
        End If
        If blnPasses = True Then
            intCounter += 1
        End If

        'Check Rehab
        blnValid = Decimal.TryParse(strRehab, decPlaceholder)
        If (blnValid = False) Then
            If txtRehab.Text = String.Empty Then
                blnPasses = True
                decPlaceholder = 0.0
            Else
                blnPasses = False
                txtRehab.Text = ""
                strInvalid &= vbNewLine & "Physical Rehab: Must be a Numerical Value"
            End If
        ElseIf blnValid = True Then
            If decPlaceholder < 0 Then
                blnPasses = False
                txtRehab.Text = ""
                strInvalid &= vbNewLine & "Physical Rehab: Number Must be Greater or Equal to Zero"
            End If
        End If
        If blnPasses = True Then
            intCounter += 1
        End If

        'Check Meds
        blnValid = Decimal.TryParse(strMeds, decPlaceholder)
        If (blnValid = False) Then
            If txtMeds.Text = String.Empty Then
                blnPasses = True
                decPlaceholder = 0.0
            Else
                blnPasses = False
                txtMeds.Text = ""
                strInvalid &= vbNewLine & "Medication: Must be a Numerical Value"
            End If
        ElseIf blnValid = True Then
            If decPlaceholder < 0 Then
                txtMeds.Text = ""
                blnPasses = False
                strInvalid &= vbNewLine & "Medication: Number Must be Greater or Equal to Zero"
            End If
        End If
        If blnPasses = True Then
            intCounter += 1
        End If

        'intCounter Must Equal 5
        If (intCounter = 5) Then
            blnPasses = True
        Else
            blnPasses = False
            lblOutput.Text = strInvalid
            Dim font As Font = New Font("Verdana", 12, FontStyle.Regular, GraphicsUnit.Pixel)
            lblOutput.Font = font
        End If
        Return blnPasses
    End Function
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim blnValid As Boolean = ValidateInputFields()
        Dim decStay As Decimal
        Dim decMisc As Decimal
        Dim decTotal As Decimal

        If blnValid = True Then
            decStay = CalcStayCharges(txtDays.Text)
            decMisc = CalcMiscCharges(txtMeds.Text, txtSurge.Text, txtLab.Text, txtRehab.Text)
            decTotal = decStay + decMisc
            lblOutput.Text = "Total Cost: " & decTotal.ToString("c")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDays.Text = String.Empty
        txtLab.Text = String.Empty
        txtMeds.Text = String.Empty
        txtRehab.Text = String.Empty
        txtSurge.Text = String.Empty
        Dim font As Font = New Font("Verdana", 12, FontStyle.Bold, GraphicsUnit.Point)
        lblOutput.Font = font
        lblOutput.Text = "Calculate Hospital Charges"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
