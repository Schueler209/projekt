
<Serializable()>
Public Class Chat

    Public ID As Integer
    Public user As User
    Public chatDate As Date

    Public Sub New(ByVal id As Integer, ByVal user As User, ByVal chatDate As Date)
        Me.ID = id
        Me.user = user
        Me.chatDate = chatDate
    End Sub

End Class
