Imports System.Net.Sockets
Imports System.Threading
Imports System.Text.Encoding
Imports System.ComponentModel
Imports System.IO

Friend Class ClientConnector
    Private clientSocket As TcpClient
    Private Ip As String = "127.0.0.1"
    Private Port As Integer = 8080

    ' recieve Event
    Public ReadOnly OnRecieve As EventNotifier(Of ConnectionData) = New EventNotifier(Of ConnectionData)

    ' connect Event
    Public ReadOnly OnConnection As EventNotifier = New EventNotifier()
    ' disconnect Event
    Public ReadOnly OnClose As EventNotifier = New EventNotifier()
    ' connection lost Event
    Public ReadOnly OnConnectionLost As EventNotifier = New EventNotifier()

    Public Sub New()

    End Sub
    Public Sub New(_Port As Integer)
        Ip = "127.0.0.1"
        Port = _Port
    End Sub

    Public Sub New(_Ip As String, _Port As Integer)
        Ip = _Ip
        Port = _Port
    End Sub



    ' Verbinden
    Public Sub connect()
        ' Erstellt Socket mit IP und Port
        Try
            Me.clientSocket = New TcpClient(Ip, Port)
        Catch ex As Exception
            OnConnectionLost.Notify()
        Finally
            OnConnection.Notify()
            ' Wartet auf Nachrichten(unendlich)
            recieveThread()
        End Try

    End Sub

    ' Neuen Threat erstellen
    Private Sub recieveThread()
        Dim worker As New BackgroundWorker
        AddHandler worker.DoWork, AddressOf recieveThreadSub
        AddHandler worker.RunWorkerCompleted, AddressOf recieveThreadCompleted
        worker.RunWorkerAsync()
    End Sub

    Private Sub recieveThreadSub(sender As BackgroundWorker, e As DoWorkEventArgs)
        ' Gibt Nachricht als Event weiter
        e.Result = recieve()
    End Sub
    Private Sub recieveThreadCompleted(sender As BackgroundWorker, e As RunWorkerCompletedEventArgs)

        ' Wenn verbindung abbricht
        If CType(e.Result, ConnectionData).Type = "ConnectionLost" Then
            ' Schließe die Verbindung
            disconnect()
            ' sende Disconnect Event
            OnConnectionLost.Notify()
        Else
            ' Ergebnis weitergeben
            OnRecieve.Notify(e.Result)
            ' Nächsten Thread starten
            recieveThread()
        End If
    End Sub

    Public Sub disconnect()
        OnClose.Notify()
        If (clientSocket IsNot Nothing) Then
            clientSocket.Close()
            clientSocket.Dispose()
        End If

    End Sub

    ' Nachrichten senden
    Public Async Sub send(msg As ConnectionData)
        Try
            ' Verbindung
            Dim serverStream As NetworkStream = clientSocket.GetStream()
            ' Nachricht in Bytes umwandeln
            Dim data As Byte() = msg.Serialize()
            serverStream.Write(data, 0, data.Length)
            Await serverStream.FlushAsync()
        Catch ex As Exception
            Console.WriteLine(ex)
            disconnect()
        End Try

    End Sub

    ' sendet eine Nachricht an mehrere Clients
    Public Sub sendAndRecieve(msg As ConnectionData, recieveHandler As Action(Of ConnectionData))
        OnRecieve.addHandler(
            Sub(str As ConnectionData)
                recieveHandler(str)
                OnRecieve.removeHandler(recieveHandler)
            End Sub)
        send(msg)

    End Sub

    ' Nachrichten bekommen
    Private Function recieve() As ConnectionData
        If clientSocket Is Nothing Then
            Return New ConnectionData("ConnectionLost")
        End If
        Try
            Dim serverStream As NetworkStream = clientSocket.GetStream()
            Dim inStream(clientSocket.ReceiveBufferSize) As Byte
            serverStream.Read(inStream, 0, clientSocket.ReceiveBufferSize)
            ' Nachrichten einlesen
            Return ConnectionData.Serialized(inStream)
        Catch ex As IOException
            Return New ConnectionData("ConnectionLost")
        End Try

    End Function

End Class
