Public Class Carpet
    Private strColor As String
    Private strStyle As String
    Private decPrice As Decimal
    Public Sub New()
        strColor = String.Empty
        strStyle = String.Empty
        decPrice = 0.0D
    End Sub
    Public Property Color() As String
        Get
            Return strColor
        End Get
        Set(value As String)
            strColor = value
        End Set
    End Property

    Public Property Style() As String
        Get
            Return strStyle
        End Get
        Set(value As String)
            strStyle = value
        End Set
    End Property

    Public Property Price() As Decimal
        Get
            Return decPrice
        End Get
        Set(value As Decimal)
            decPrice = value
        End Set
    End Property
End Class
