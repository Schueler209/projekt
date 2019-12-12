
<Serializable()>
Public Class User
    Public benutzername As String
    Public name As String
    Public id As Integer
    Public colour As Integer

    Public Sub New(ByVal benutzername As String, ByVal name As String, ByVal id As Integer, ByVal colour As Integer)
        Me.benutzername = benutzername
        Me.name = name
        Me.id = id
        Me.colour = colour
    End Sub

End Class
