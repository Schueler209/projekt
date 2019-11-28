
<Serializable()>
Public Class Message

    Public chat As Integer
    Public user As User
    Public datum As Date
    Public message As String


    Public Sub New(ByVal user As User, chatID As Integer, ByVal datum As Date, ByVal message As String)
        Me.user = user
        Me.datum = datum
        Me.message = message
        Me.chat = chatID
    End Sub

End Class
