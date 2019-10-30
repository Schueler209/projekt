Imports Connector

Public Class NetworkClass
    Public Shared ReadOnly net As New NetClient()

    Public Shared Sub ensureConnection()
        net.connect()
    End Sub
End Class
