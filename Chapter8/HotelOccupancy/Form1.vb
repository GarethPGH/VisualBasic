Imports System.Xml

Public Class Form1
    Private intTotalOccRooms As Integer = 0
    Private decTotalPercentOccupied As Single = 0D
    Private strMsg As String = String.Empty
    Private strPrompt As String = String.Empty
    Private strRes As String = String.Empty
    Private intOccRooms(7) As Integer
    Private decPercentage(7) As Decimal
    'Class Based so Accessable to two methods
    Private strFloors() As String = {"1", "2", "3", "4", "5", "6", "7", "8"}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strF As String
        cbxFloor.Items.AddRange(strFloors)
        For intIndex = 0 To 7
            strF = "Floor: " & strFloors(intIndex) & " Rooms Occupied: 0 Percent Occupied: 0%"
            lstOccupancy.Items.Add(strF)
        Next
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intRooms As Integer = 0
        Dim strFloor As String = String.Empty
        Dim intIndex As Integer = cbxFloor.SelectedIndex
        Dim strInput As String = String.Empty
        strMsg = "Enter a Whole Number Less than 30, and Greater than 0"
        strPrompt = "Each Floor Has 30 Rooms"
        'Check ComboBox SelectedIndex, Check if txtRooms Contains Numeric Input
        If (intIndex <> -1) And IsNumeric(txtRooms.Text) Then
            'Try to Parse Integer
            If (Integer.TryParse(txtRooms.Text, intRooms)) Then
                'Check Range
                If intRooms <= 30 And intRooms >= 0 Then
                    strFloor = cbxFloor.SelectedItem
                    intOccRooms(intIndex) = intRooms
                    decPercentage(intIndex) = calculateOccupancy(intRooms)
                    decPercentage(intIndex) = Math.Round(decPercentage(intIndex), 2)
                    lstOccupancy.SelectedIndex = intIndex
                    lstOccupancy.Items(intIndex) = "Floor: " & strFloor & " Rooms Occupied: " & intRooms.ToString & " Percent Occupied: " & decPercentage(intIndex).ToString("p")
                    lstOccupancy.SetSelected(intIndex, False)
                Else
                    While intRooms > 30 Or intRooms < 0
                        strInput = InputBox(strPrompt, strMsg)
                        Integer.TryParse(strInput, intRooms)
                    End While
                    txtRooms.Text = intRooms
                End If
            End If
        End If
    End Sub

    Private Sub btnTotals_Click(sender As Object, e As EventArgs) Handles btnTotals.Click
        getTotalOccupiedRooms()
        getTotalOccupiedPercentage()

        txtTotRooms.Text = intTotalOccRooms.ToString
        txtOccupancy.Text = decTotalPercentOccupied.ToString("p")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        strMsg = "This will Reset the form. Type Y or Yes to Proceed"
        strPrompt = "Warning"
        strRes = InputBox(strPrompt, strMsg)
        Dim strF As String = String.Empty
        If (strRes IsNot Nothing And strRes IsNot String.Empty) Then
            strRes = strRes.ToUpper
            If (strRes.Equals("Y") Or strRes.Equals("YES")) Then
                txtOccupancy.Text = String.Empty
                txtRooms.Text = String.Empty
                txtTotRooms.Text = String.Empty
                decTotalPercentOccupied = 0F
                intTotalOccRooms = 0
                'Reset List
                lstOccupancy.Items.Clear()
                For intIndex = 0 To 7
                    strF = "Floor: " & strFloors(intIndex) & " Rooms Occupied: 0 Percent Occupied: 0%"
                    lstOccupancy.Items.Add(strF)
                Next
                'Deselect Box
                cbxFloor.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        strMsg = "Are you Sure you want to Close the Program? Type Y or Yes to Proceed"
        strPrompt = "Exit Program"
        strRes = InputBox(strPrompt, strMsg)
        If (strRes IsNot Nothing And strRes IsNot String.Empty) Then
            strRes = strRes.ToUpper
            If (strRes.Equals("Y") Or strRes.Equals("YES")) Then
                Me.Close()
            End If
        End If
    End Sub

    Private Function calculateOccupancy(ByVal intOccRooms As Integer) As Decimal
        Dim decPercentOccupied As Decimal = intOccRooms / 30
        Return decPercentOccupied
    End Function
    Private Sub getTotalOccupiedRooms()
        For intIndex = 0 To intOccRooms.Length - 1
            intTotalOccRooms += intOccRooms(intIndex)
        Next
    End Sub

    Private Sub getTotalOccupiedPercentage()
        Const intTotalRooms As Integer = 240
        Dim decPercent As Decimal
        decPercent = CDec(intTotalOccRooms) / CDec(intTotalRooms)
        decPercent = Math.Round(decPercent, 2)
        decTotalPercentOccupied = decPercent
    End Sub
End Class
