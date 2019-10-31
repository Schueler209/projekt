Imports Connector

Public Class NetworkClass
    Public Shared ReadOnly net As New NetClient
    Private Shared connected As Boolean = False

    Public Shared Sub ensureConnection()
        If Not connected Then
            net.OnConnectionLost = AddressOf OnConnectionLost
            net.connect()
            connected = True
        End If

    End Sub

    Private Shared Sub OnConnectionLost()
        Dim msg = MsgBox("Verbindung wurde unterbrochen!", vbRetryCancel, "Verbindung getrennt")
        If msg = vbRetry Then
            net.connect()
        Else
            ' Einstellungen öffnen
            Application.Exit()

            End
        End If
    End Sub
End Class
