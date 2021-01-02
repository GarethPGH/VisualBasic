Public Class Form1
    Private Sub btnEnterNum_Click(sender As Object, e As EventArgs) Handles btnEnterNum.Click
        Dim intNumber As Integer = 0
        Dim intNumDisplay As Integer = 0
        Dim intSum As Integer = 0
        Dim strInput As String = ""

        Do
            Try
                strInput = InputBox("Enter a Positive Whole Number", "Input Needed", 10)
                intNumber = CInt(strInput)
            Catch
                intNumber = 10
            End Try
            If intNumber < 0 Then
                MessageBox.Show("Number can not be Negative")
            End If

        Loop While intNumber <= 0

        'To display user number
        intNumDisplay = intNumber

        While intNumber > 0
            intSum += intNumber
            intNumber -= 1
        End While
        MessageBox.Show("The Sum of 1 through " & intNumDisplay & " is " & intSum, "Results")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
