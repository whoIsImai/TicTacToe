Public Class Player
    Private ReadOnly _X As String = "X"
    Private ReadOnly _O As String = "O"


    Public ReadOnly Property X() As String
        Get
            Return _X
        End Get
    End Property

    Public ReadOnly Property O() As String
        Get
            Return _O
        End Get
    End Property
End Class
