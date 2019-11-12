
<Serializable()>
Public Class Chat

    Public ID As Integer
    Public recuser As User
    Public chatDate As Date

    Public Sub New(ByVal id As Integer, ByVal user As User, ByVal chatDate As Date)
        Me.ID = id
        Me.recuser = recuser
        Me.chatDate = chatDate
    End Sub

End Class
