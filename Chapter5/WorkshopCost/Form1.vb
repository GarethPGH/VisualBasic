Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstWorkshop.Items.Add("Handling Stress")
        lstWorkshop.Items.Add("Time Management")
        lstWorkshop.Items.Add("Supervision Skills")
        lstWorkshop.Items.Add("Negotiation")
        lstWorkshop.Items.Add("How To Interview")

        lstLocation.Items.Add("Austin")
        lstLocation.Items.Add("Chicago")
        lstLocation.Items.Add("Dallas")
        lstLocation.Items.Add("Orlando")
        lstLocation.Items.Add("Phoenix")
        lstLocation.Items.Add("Raleigh")
    End Sub

    Private Sub btnWorkshop_Click(sender As Object, e As EventArgs) Handles btnWorkshop.Click
        Dim intWorkshop As Integer
        Dim intLodgingCost As Integer
        Dim intWorkshopCost As Integer

        'Set Lodging Cost Per Day
        If lstLocation.SelectedIndex = -1 Then
            intLodgingCost = 0
        ElseIf lstLocation.SelectedItem.Equals("Austin") Then
            intLodgingCost = 95
        ElseIf lstLocation.SelectedItem.Equals("Chicago") Then
            intLodgingCost = 125
        ElseIf lstLocation.SelectedItem.Equals("Dallas") Then
            intLodgingCost = 110
        ElseIf lstLocation.SelectedItem.Equals("Orlando") Then
            intLodgingCost = 100
        ElseIf lstLocation.SelectedItem.Equals("Phoenix") Then
            intLodgingCost = 92
        ElseIf lstLocation.SelectedItem.Equals("Raleigh") Then
            intLodgingCost = 90
        End If

        'Set Workshop Cost and Calculate Total Cost of Attending
        If lstWorkshop.SelectedIndex = -1 Or lstLocation.SelectedIndex = -1 Then
            intWorkshopCost = 0
        ElseIf lstWorkshop.SelectedItem.Equals("Handling Stress") Then
            intWorkshop = 595
            intWorkshopCost = intWorkshop + (intLodgingCost * 3)
        ElseIf lstWorkshop.SelectedItem.Equals("Time Management") Then
            intWorkshop = 695
            intWorkshopCost = intWorkshop + (intLodgingCost * 3)
        ElseIf lstWorkshop.SelectedItem.Equals("Supervision Skills") Then
            intWorkshop = 995
            intWorkshopCost = intWorkshop + (intLodgingCost * 3)
        ElseIf lstWorkshop.SelectedItem.Equals("Negotiation") Then
            intWorkshop = 1295
            intWorkshopCost = intWorkshop + (intLodgingCost * 5)
        ElseIf lstWorkshop.SelectedItem.Equals("How To Interview") Then
            intWorkshop = 395
            intWorkshopCost = intWorkshop + intLodgingCost
        End If

        lstCosts.Items.Add(intWorkshopCost)
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim intLen As Integer = lstCosts.Items.Count
        Dim intNum As Integer = 0
        Dim intSum As Integer = 0
        Dim strNum As String = ""
        Dim blnCheck As Boolean = False

        For intCount = 0 To intLen - 1
            'Set Selection
            lstCosts.SetSelected(intCount, True)
            strNum = lstCosts.SelectedItem.ToString()

            blnCheck = IsNumeric(strNum)
            If (blnCheck) Then
                intNum = CInt(strNum)
            End If

            intSum += intNum

            'Clear Selection
            lstCosts.SetSelected(intCount, False)
        Next

        If intSum > 0 Then
            txtTotal.Text = intSum.ToString("c")
        Else
            txtTotal.Text = "No Workshops Selected"
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lstCosts.Items.Clear()
        txtTotal.Text = String.Empty
        lstLocation.SelectedIndex = -1
        lstWorkshop.SelectedIndex = -1
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
