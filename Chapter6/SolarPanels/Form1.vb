Public Class Form1
    Private Const decBASE_CHARGE As Decimal = 2000D 'Charege includes 2 solar panels
    Private Const decADD_CHARGE As Decimal = 300D 'Charge per extra solar panel
    Private Const decEXPRESS As Decimal = 0.05D 'Charge Percentage May be moved to calculate method

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Validation 
        Dim blnCustomer As Boolean = False
        Dim blnPanels As Boolean = False
        Dim blnDepo As Boolean = False

        'To Process Data 
        Dim intNumberPanels As Integer = 0
        Dim decDepo As Decimal = 0D
        Dim decExtraCharge As Decimal = 0D
        Dim decTotalCharge As Decimal = 0D
        Dim decExpressCharge As Decimal = 0D
        Dim decBalance As Decimal = 0D

        blnCustomer = checkNameAndPhoneFields()
        blnPanels = checkPanelNumber()
        blnDepo = checkDeposit()
        If blnCustomer And blnPanels And blnDepo Then
            intNumberPanels = CInt(txtNumPan.Text)
            decDepo = CDec(txtDeposit.Text)

            decExtraCharge = calculateExtraPanelsCharge(intNumberPanels)
            decTotalCharge = calculateTotalCharge(decExtraCharge)
            If chkExpress.Checked Then
                decExpressCharge = calculateExpressCharge(decTotalCharge)
                decTotalCharge += decExpressCharge
            End If

            txtBase.Text = decBASE_CHARGE.ToString("c")
            txtDepoAmt.Text = decDepo.ToString("c")
            txtTotal.Text = decTotalCharge.ToString("c")
            txtAdd.Text = decExtraCharge.ToString("c")

            If decDepo > decTotalCharge Then
                lblBal.Text = "Refund:"
                decBalance = decDepo - decTotalCharge
            Else
                decBalance = decTotalCharge - decDepo
            End If

            txtDue.Text = decBalance.ToString("c")

            grpCharges.Visible = True
        Else
            MessageBox.Show("Double Check your Information and Try Again", "Error")
        End If
    End Sub
    'Fields cant be blank
    Private Function checkNameAndPhoneFields() As Boolean
        Dim isValid As Boolean = True
        If txtFirstN.Text = String.Empty Or txtLastN.Text = String.Empty Or txtPhone.Text = String.Empty Then
            isValid = False
        End If
        Return isValid
    End Function
    'Panels between 1 and 1000
    Private Function checkPanelNumber() As Boolean
        Dim isValid As Boolean = False
        Dim intPanels As Integer
        If IsNumeric(txtNumPan.Text) Then
            Try
                Integer.TryParse(txtNumPan.Text, intPanels)
                If (intPanels >= 1 And intPanels <= 1000) Then
                    isValid = True
                End If
            Catch ex As Exception
                isValid = False
            End Try
        End If
        Return isValid
    End Function
    'Deposit must be greater than zero
    Private Function checkDeposit() As Boolean
        Dim isValid As Boolean = False
        Dim decDeposit As Decimal
        If IsNumeric(txtDeposit.Text) Then
            Try
                Decimal.TryParse(txtDeposit.Text, decDeposit)
                If (decDeposit > 0) Then
                    isValid = True
                End If
            Catch ex As Exception
                isValid = False
            End Try
        End If
        Return isValid
    End Function

    'Extra Charges
    Private Function calculateExtraPanelsCharge(ByVal intTotalPanels As Integer) As Decimal
        Dim intExtraPanels As Integer
        Dim decExtraCharge As Decimal
        If intTotalPanels > 2 Then
                    intExtraPanels = intTotalPanels - 2
                ElseIf intTotalPanels <= 2 And intTotalPanels >= 1 Then
                    intExtraPanels = 0
                End If
        decExtraCharge = intExtraPanels * decADD_CHARGE
        Return decExtraCharge
    End Function
    'Calculate Total 
    Private Function calculateTotalCharge(ByVal decExtraCharge As Decimal) As Decimal
        Dim decTotal As Decimal
        decTotal = decBASE_CHARGE + decExtraCharge
        Return decTotal
    End Function
    'Calculate Express
    Private Function calculateExpressCharge(ByVal decTotalCharge As Decimal) As Decimal
        Dim decExpressCharge As Decimal
        decExpressCharge = decTotalCharge * decEXPRESS
        Return decExpressCharge
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim strInput As String
        strInput = InputBox("This will clear the entire form. Do you want to proceed? Type Y or Yes", "Clear The Form")
        strInput = strInput.ToUpper()
        If (strInput = "Y" Or strInput = "YES") Then
            txtDue.Text = String.Empty
            txtDepoAmt.Text = String.Empty
            txtDeposit.Text = String.Empty
            txtBase.Text = String.Empty
            txtAdd.Text = String.Empty
            txtFirstN.Text = String.Empty
            txtLastN.Text = String.Empty
            txtDeposit.Text = String.Empty
            txtNumPan.Text = String.Empty
            txtPhone.Text = String.Empty
            txtTotal.Text = String.Empty
            chkExpress.Checked = False
            grpCharges.Visible = False
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
