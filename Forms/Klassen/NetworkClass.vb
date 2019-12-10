Imports Connector

Public Class NetworkClass
    Public Shared ReadOnly net As New NetClient
    Private Shared connected As Boolean = False
    Public Shared login As User
    Public Shared Ip As String = "127.0.0.1"
    Public Shared Port As Integer = 8080

    Public Shared Sub ensureConnection()

        If My.Settings.Ip IsNot Nothing Then
            Ip = My.Settings.Ip
        End If
        If My.Settings.Port > 0 Then
            Port = My.Settings.Port
        End If

        If Not connected Then
            net.OnConnectionLost = AddressOf OnConnectionLost
            net.connect(Ip, Port)
            connected = True
        End If

    End Sub

    Private Shared Sub OnConnectionLost()
        connected = False
        IPundPort.Show()
        Register.Close()
        LoginForm.Close()
        Chats.Close()
        Settings.Close()
        AddFriend.Close()


        'Dim msg = MsgBox("Verbindung wurde unterbrochen!", vbRetryCancel, "Verbindung getrennt")
        'If msg = vbRetry Then
        '    net.connect()
        'Else
        '    ' Einstellungen öffnen
        '    Application.Exit()

        '    End
        'End If
    End Sub
End Class
