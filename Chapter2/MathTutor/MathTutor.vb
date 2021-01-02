Public Class MathTutor
    Private Sub btnShowAnswer_Click(sender As Object, e As EventArgs) Handles btnShowAnswer.Click

        Dim product As Integer
        Dim input As String
        input = InputBox("Enter a number")
        product = CInt(input)

        Do While product < 100
            product *= 10
        Loop
        lblMathQuestion.Text = product
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub


End Class
