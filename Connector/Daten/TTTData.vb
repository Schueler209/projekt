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
    Public state As Integer()
    Private update As TTTType
    Private values As Integer()

    Public Sub New(type As TTTType, state() As Integer)
        Me.type = type
        Me.state = state
    End Sub
End Class

