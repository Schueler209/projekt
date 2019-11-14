
<Serializable()>
Public Class Message

    Public user As User
    Public datum As Date
    Public message As String


    Public Sub New(ByVal user As User, ByVal datum As Date, ByVal message As String)
        Me.user = user
        Me.datum = datum
        Me.message = message
    End Sub

End Class
