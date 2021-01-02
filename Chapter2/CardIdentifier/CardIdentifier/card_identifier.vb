Public Class card_identifier
    Private Sub imgAce_Click(sender As Object, e As EventArgs) Handles imgAce.Click
        TextBox1.Text = "Ace of Clubs"
    End Sub

    Private Sub imgJack_Click(sender As Object, e As EventArgs) Handles imgJack.Click
        TextBox1.Text = "Jack of Spades"
    End Sub

    Private Sub imgJoker_Click(sender As Object, e As EventArgs) Handles imgJoker.Click
        TextBox1.Text = "Red Joker"
    End Sub

    Private Sub imgKing_Click(sender As Object, e As EventArgs) Handles imgKing.Click
        TextBox1.Text = "King of Diamonds"
    End Sub

    Private Sub imgQueen_Click(sender As Object, e As EventArgs) Handles imgQueen.Click
        TextBox1.Text = "Queen of Hearts"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
