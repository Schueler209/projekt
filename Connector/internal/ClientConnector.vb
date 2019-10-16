Imports System.Net.Sockets
Imports System.Threading
Imports System.Text.Encoding
Imports System.ComponentModel

Public Class ClientConnector
    Private clientSocket As TcpClient
    Private Ip As String = "127.0.0.1"
    Private Port As Integer = 8080

    ' recieve Event
    Public ReadOnly OnRecieve As EventNotifier(Of ConnectionData) = New EventNotifier(Of ConnectionData)

    ' connect Event
    Public ReadOnly OnConnection As EventNotifier = New EventNotifier()
    ' disconnect Event
    Public ReadOnly OnClose As EventNotifier = New EventNotifier()

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
        Me.clientSocket = New TcpClient(Ip, Port)
        OnConnection.Notify()
        ' Wartet auf Nachrichten(unendlich)
        recieveThread()
        Console.WriteLine("Neue Verbindung!")
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
        ' Ergebnis weitergeben
        OnRecieve.Notify(e.Result)
        ' Nächsten Thread starten
        recieveThread()
    End Sub

    Public Sub disconnect()
        OnClose.Notify()
        clientSocket.Close()
        clientSocket.Dispose()
    End Sub

    ' Nachrichten senden
    Public Async Sub send(msg As ConnectionData)

        ' Verbindung
        Dim serverStream As NetworkStream = clientSocket.GetStream()
        ' Nachricht in Bytes umwandeln
        Dim data As Byte() = msg.Serialize()
        serverStream.Write(data, 0, data.Length)
        Await serverStream.FlushAsync()
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
        Dim serverStream As NetworkStream = clientSocket.GetStream()
        Dim inStream(clientSocket.ReceiveBufferSize) As Byte
        serverStream.Read(inStream, 0, clientSocket.ReceiveBufferSize)
        ' Nachrichten einlesen
        Return ConnectionData.Serialized(inStream)
    End Function

End Class
