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
    Public ReadOnly OnRecieve As EventNotifier(Of String, TcpClient) = New EventNotifier(Of String, TcpClient)

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
            Dim result As String = ""
            Try
                ' Gibt Event aus

                result = Await recieve(client)

            Catch ex As Exception
                closeConnection(client)
            Finally
                If result IsNot "" Then
                    result = result.Trim()
                    OnRecieve.Notify(result, client)
                End If
            End Try

        End While
    End Sub

    ' sendet eine Nachricht an einen Client
    Public Async Sub send(reciever As TcpClient, msg As String)
        Dim networkStream As NetworkStream = reciever.GetStream()
        Dim outStream As Byte() = ASCII.GetBytes(msg)

        Await networkStream.WriteAsync(outStream, 0, outStream.Length)
        Await networkStream.FlushAsync()
    End Sub

    ' sendet eine Nachricht an mehrere Clients
    Public Sub send(recievers As TcpClient(), msg As String)
        For Each socket In recievers
            send(socket, msg)
        Next
    End Sub

    ' sendet eine Nachricht an alle Clients
    Public Sub sendAll(msg As String)
        send(Sockets.ToArray(), msg)
    End Sub

    ' sendet eine Nachricht an mehrere Clients
    Public Sub sendAndRecieve(recievers As TcpClient(), msg As String, recieveHandler As Action(Of String, TcpClient))
        OnRecieve.addHandler(
            Sub(str As String, client As TcpClient)
                recieveHandler(str, client)
                OnRecieve.removeHandler(recieveHandler)
            End Sub
            )
        For Each socket In recievers
            send(socket, msg)
        Next
    End Sub

    ' empfängt eine Nachricht asynchron
    Private Async Function recieve(sender As TcpClient) As Task(Of String)
        Dim serverStream As NetworkStream = sender.GetStream()
        Dim inStream(sender.ReceiveBufferSize) As Byte
        ' Nachrichten einlesen
        Await serverStream.ReadAsync(inStream, 0, sender.ReceiveBufferSize)
        Console.WriteLine(sender.ReceiveBufferSize)
        ' In String umwandeln
        Return ASCII.GetString(inStream)
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
