Imports System.Net.Sockets
Imports System.Net
Imports System.Text.Encoding

Public Class ServerConnector
    Private serverSocket As TcpListener
    ' Liste aller verbundener Clients
    Private ReadOnly _sockets As New List(Of TcpClient)

    ' Getter für Client Array
    Public ReadOnly Property Sockets() As TcpClient()
        Get
            Return _sockets.ToArray()
        End Get
    End Property

    ' recieve Event
    Public ReadOnly OnRecieve As EventNotifier(Of ConnectionData, TcpClient) = New EventNotifier(Of ConnectionData, TcpClient)

    ' connect Event
    Public ReadOnly OnConnection As EventNotifier(Of TcpClient) = New EventNotifier(Of TcpClient)
    ' disconnect Event
    Public ReadOnly OnClose As EventNotifier(Of TcpClient) = New EventNotifier(Of TcpClient)

    Private Ip As String = "0.0.0.0"
    Private Port As Integer = 8080

    ' Konstruktoren
    Public Sub New()

    End Sub
    Public Sub New(_port As Integer)
        Port = _port
    End Sub
    Public Sub New(_Ip As String, _Port As Integer)
        Ip = _Ip
        Port = _Port
    End Sub

    ' Verbinden(mit IP und Port)
    Public Sub connect()

        ' Neuer Listener
        serverSocket = New TcpListener(IPAddress.Parse(Ip), Port)
        ' Startet Server
        serverSocket.Start()
        Console.WriteLine("Server läuft auf " & Ip & ":" & Port)
        While True
            ' sucht nach neuem client
            Dim clientSocket As TcpClient = serverSocket.AcceptTcpClient()
            ' fügt client zu der Liste hinzu
            OnConnection.Notify(clientSocket)

            _sockets.Add(clientSocket)
            awaitMessage(clientSocket)


        End While

    End Sub

    Private Sub AcceptClient(ByVal ar As IAsyncResult)
        Dim clientSocket As TcpClient = serverSocket.EndAcceptTcpClient(ar)
        _sockets.Add(clientSocket)
        awaitMessage(clientSocket)
        serverSocket.BeginAcceptTcpClient(New AsyncCallback(AddressOf AcceptClient), serverSocket)
    End Sub

    ' Wartet Asynchron auf Nachricht
    Private Async Sub awaitMessage(client As TcpClient)
        While True
            Dim result As ConnectionData
            Try
                ' Gibt Event aus

                result = recieve(client)

            Catch ex As Exception
                closeConnection(client)
            Finally
                OnRecieve.Notify(result, client)
            End Try

        End While
    End Sub

    ' sendet eine Nachricht an einen Client
    Public Async Sub send(reciever As TcpClient, msg As ConnectionData)
        Dim networkStream As NetworkStream = reciever.GetStream()
        msg.Serialize(networkStream)
        Await networkStream.FlushAsync()
    End Sub


    ' sendet eine Nachricht an mehrere Clients
    Public Sub send(recievers As TcpClient(), msg As ConnectionData)
        For Each socket In recievers
            send(socket, msg)
        Next
    End Sub

    ' sendet eine Nachricht an alle Clients
    Public Sub sendAll(msg As ConnectionData)
        send(Sockets.ToArray(), msg)
    End Sub

    ' sendet eine Nachricht an mehrere Clients
    Public Sub sendAndRecieve(recievers As TcpClient(), msg As ConnectionData, recieveHandler As Action(Of ConnectionData, TcpClient))
        OnRecieve.addHandler(
            Sub(str As ConnectionData, client As TcpClient)
                recieveHandler(str, client)
                OnRecieve.removeHandler(recieveHandler)
            End Sub
            )
        For Each socket In recievers
            send(socket, msg)
        Next
    End Sub

    ' empfängt eine Nachricht asynchron
    Private Function recieve(sender As TcpClient) As ConnectionData
        Dim serverStream As NetworkStream = sender.GetStream()
        Dim inStream(sender.ReceiveBufferSize) As Byte
        ' Nachrichten einlesen
        Return ConnectionData.Serialized(serverStream)
    End Function

    ' beendet eine Verbindung
    Public Sub closeConnection(client As TcpClient)
        OnClose.Notify(client)
        _sockets.Remove(client)
        client.Close()
        client.Dispose()
    End Sub

    ' beendet alle Verbindungen
    Public Sub closeConnections()
        For Each client In Sockets
            closeConnection(client)
        Next
    End Sub

    ' beendet alle Verbindungen und stoppt Server
    Public Sub disconnect()
        closeConnections()
        serverSocket.Stop()
    End Sub

End Class
