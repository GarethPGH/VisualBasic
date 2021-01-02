Public Class AudioBooks
    Public strSelected(10) As String
    Dim intIndex As Integer = 0
    Private Sub AudioBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        Dim intSelected As Integer
        intSelected = lstAudio.SelectedIndex
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
            strSelectedBook = g_strCalcBook
        ElseIf intInd = 1 Then
            strSelectedBook = g_strScotlandBook
        ElseIf intInd = 2 Then
            strSelectedBook = g_strScienceBook
        ElseIf intInd = 3 Then
            strSelectedBook = g_strRelaxBook
        Else
            MessageBox.Show("Please Select a Book From the List, or Close the Form")
        End If

        Return strSelectedBook
    End Function

    Private Sub AudioBooks_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Clear Selected
        For intInd = 0 To strSelected.Length - 1
            strSelected(intInd) = String.Empty
        Next
        'Add Options to List
        lstAudio.Items.Add(g_strCalcBook)
        lstAudio.Items.Add(g_strScotlandBook)
        lstAudio.Items.Add(g_strScienceBook)
        lstAudio.Items.Add(g_strRelaxBook)
    End Sub

    Private Sub AudioBooks_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Reset the List, Reset Index
        lstAudio.Items.Clear()
        intIndex = 0
    End Sub
End Class