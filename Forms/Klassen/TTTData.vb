Public Enum TTTType
    Request
    RequestSuccess
    Update
    Won
    Finished
End Enum

<Serializable()>
Public Class TTTData

    Public type As TTTType
    Public msg As String
    Public state As Integer()

    Public Sub New(type As TTTType, msg As String, state() As Integer)
        Me.type = type
        Me.msg = msg
        Me.state = state
    End Sub
End Class

