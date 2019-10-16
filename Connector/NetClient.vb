Public Class NetClient
    Public ReadOnly OnRecieve As EventNotifier(Of ConnectionData) = New EventNotifier(Of ConnectionData)
End Class
