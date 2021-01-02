Imports System.Runtime.Remoting

Public Class MainForm
    Private decSubtotalCost As Decimal = 0.0D
    Private decShippingCost As Decimal = 0.0D
    Private decTotalTax As Decimal = 0.0D
    Private decTotalCost As Decimal = 0.0D
    Private Const decSHIPPING_RATE As Decimal = 2.0

    Public frmPrinted As New PrintedBooks
    Public frmAudio As New AudioBooks

    Private Sub PrintBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintBooksToolStripMenuItem.Click
        frmPrinted.ShowDialog()

        For Each item In frmPrinted.strSelected
            If (item IsNot String.Empty And item IsNot Nothing) Then
                Me.lstBooks.Items.Add(item)
            End If
        Next
        Me.CalculateTextFields()
    End Sub

    Private Sub AudioBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AudioBooksToolStripMenuItem.Click
        frmAudio.ShowDialog()
        For Each item In frmAudio.strSelected
            If (item IsNot String.Empty And item IsNot Nothing) Then
                Me.lstBooks.Items.Add(item)
            End If
        Next
        Me.CalculateTextFields()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        Dim strResponse As String = InputBox("Warning this will Clear the Data on the Form. Do you Wish to Proceed?", "Clear the form")
        If (strResponse IsNot Nothing And strResponse IsNot String.Empty) Then
            strResponse = strResponse.ToUpper()
            If (strResponse.Equals("Y") Or strResponse.Equals("YES")) Then
                txtShip.Text = String.Empty
                txtSub.Text = String.Empty
                txtTax.Text = String.Empty
                txtTotal.Text = String.Empty
                lstBooks.Items.Clear()
            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Products>Printed to add Printed Books to List" & vbNewLine & "Products>Audio to add a Audio Books to the List" & vbNewLine & "File>Reset Clears the Form of All Data" & vbNewLine & "File>Close Closes the Application", "Bookstore Product App")
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim strSelected As String = String.Empty
        Dim decCost As Decimal = 0.0D
        Dim decOldSubtotal As Decimal = CDec(txtSub.Text)
        decShippingCost = CDec(txtShip.Text) - decSHIPPING_RATE
        If lstBooks.SelectedIndex <> -1 Then
            strSelected = lstBooks.SelectedItem.ToString

            If strSelected.Equals(g_strCalcBook) Then
                decCost = g_decCalcBook
            ElseIf strSelected.Equals(g_strRelaxBook) Then
                decCost = g_decRelaxBook
            ElseIf strSelected.Equals(g_strScienceBook) Then
                decCost = g_decScienceBook
            ElseIf strSelected.Equals(g_strScotlandBook) Then
                decCost = g_decScotlandBook
            ElseIf strSelected.Equals(g_strStressBook) Then
                decCost = g_decStressBook
            ElseIf strSelected.Equals(g_strYourWayBook) Then
                decCost = g_decYourWayBook
            End If

            decSubtotalCost = decOldSubtotal - decCost
            decTotalTax = CalculateTax(decSubtotalCost)
            decTotalCost = CalculateTotal(decSubtotalCost, decShippingCost, decTotalTax)

            txtSub.Text = decSubtotalCost.ToString("c")
            txtShip.Text = decShippingCost.ToString("c")
            txtTax.Text = decTotalTax.ToString("c")
            txtTotal.Text = decTotalCost.ToString("c")

            lstBooks.Items.RemoveAt(lstBooks.SelectedIndex)
        End If

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSub.Text = decSubtotalCost.ToString("c")
        txtShip.Text = decShippingCost.ToString("c")
        txtTax.Text = decTotalTax.ToString("c")
        txtTotal.Text = decTotalCost.ToString("c")
    End Sub

    Private Sub CalculateTextFields()
        If lstBooks.Items.Count > 0 Then
            decSubtotalCost = CalculateSubtotal()
            decShippingCost = CalculateShipping()
            decTotalTax = CalculateTax(decSubtotalCost)
            decTotalCost = CalculateTotal(decSubtotalCost, decShippingCost, decTotalTax)

            txtSub.Text = decSubtotalCost.ToString("c")
            txtShip.Text = decShippingCost.ToString("c")
            txtTax.Text = decTotalTax.ToString("c")
            txtTotal.Text = decTotalCost.ToString("c")
        End If
    End Sub
    Private Function CalculateSubtotal() As Decimal
        Dim decSum As Decimal = 0.0D

        For intItem = 0 To lstBooks.Items.Count - 1
            lstBooks.SelectedIndex = intItem
            If lstBooks.SelectedItem.Equals(g_strCalcBook) Then
                decSum += g_decCalcBook
            ElseIf lstBooks.SelectedItem.Equals(g_strRelaxBook) Then
                decSum += g_decRelaxBook
            ElseIf lstBooks.SelectedItem.Equals(g_strScienceBook) Then
                decSum += g_decScienceBook
            ElseIf lstBooks.SelectedItem.Equals(g_strScotlandBook) Then
                decSum += g_decScotlandBook
            ElseIf lstBooks.SelectedItem.Equals(g_strStressBook) Then
                decSum += g_decStressBook
            ElseIf lstBooks.SelectedItem.Equals(g_strYourWayBook) Then
                decSum += g_decYourWayBook
            End If
        Next

        Return decSum
    End Function
    Private Function CalculateTax(ByVal decCost As Decimal) As Decimal
        Const decTAXRATE As Decimal = 0.06D
        Return decCost * decTAXRATE
    End Function
    Private Function CalculateShipping() As Decimal
        Dim intItems As Integer = 0
        For intItem = 0 To lstBooks.Items.Count - 1
            intItems += 1
        Next

        Return intItems * decSHIPPING_RATE
    End Function
    Private Function CalculateTotal(ByVal decSubtotal As Decimal, ByVal decShipping As Decimal, ByVal decTax As Decimal)
        Return decSubtotal + decTax + decShipping
    End Function

End Class
