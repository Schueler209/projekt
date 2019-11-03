Public Class User
    Public benutzername As String
    Public name As String
    Public id As Integer

    Public Sub New(ByVal benutzername As String, ByVal name As String, ByVal id As Integer)
        Me.benutzername = benutzername
        Me.name = name
        Me.id = id
    End Sub

End Class
