Public Class Rectangle
    Private sngWidth As Single
    Private sngLength As Single
    Private sngArea As Single
    Public Sub New()
        sngLength = 0.0F
        sngWidth = 0.0F
        CalcArea()
    End Sub

    Public Property Width() As Single
        Get
            Return sngWidth
        End Get
        Set(value As Single)
            sngWidth = value
        End Set
    End Property

    Public Property Length() As Single
        Get
            Return sngLength
        End Get
        Set(value As Single)
            sngLength = value
        End Set
    End Property

    Public ReadOnly Property Area() As Single
        Get
            Return Area
        End Get
    End Property

    Public Function CalcArea() As Single
        sngArea = sngLength * sngWidth
        Return sngArea
    End Function

End Class
