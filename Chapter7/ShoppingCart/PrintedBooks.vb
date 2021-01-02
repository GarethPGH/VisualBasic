Public Class PrintedBooks
    Public strSelected(10) As String
    Dim intIndex As Integer = 0
    Private Sub PrintedBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        Dim intSelected As Integer
        intSelected = lstPrinted.SelectedIndex
        strSelected(intIndex) = SelectBook(intSelected)
        If intIndex < strSelected.Length Then
            intIndex += 1
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Function SelectBook(ByVal intInd As Integer) As String
        Dim strSelectedBook As String = String.Empty

        If intInd = 0 Then
            strSelectedBook = g_strYourWayBook
        ElseIf intInd = 1 Then
            strSelectedBook = g_strScotlandBook
        ElseIf intInd = 2 Then
            strSelectedBook = g_strCalcBook
        ElseIf intInd = 3 Then
            strSelectedBook = g_strStressBook
        Else
            MessageBox.Show("Please Select a Book From the List, or Close the Form")
        End If

        Return strSelectedBook
    End Function

    Private Sub PrintedBooks_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Clear Selected
        For intIn = 0 To strSelected.Length - 1
            strSelected(intIn) = String.Empty
        Next
        'Add Options to List
        lstPrinted.Items.Add(g_strYourWayBook)
        lstPrinted.Items.Add(g_strScotlandBook)
        lstPrinted.Items.Add(g_strCalcBook)
        lstPrinted.Items.Add(g_strStressBook)
    End Sub

    Private Sub PrintedBooks_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Reset the List, Reset Index
        lstPrinted.Items.Clear()
        intIndex = 0
    End Sub
End Class