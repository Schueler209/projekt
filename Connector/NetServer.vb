Imports System.Net.Sockets

Public Class NetServer
    Public loggedIn As New Dictionary(Of Integer, TcpClient)
    Private connector As ServerConnector

    Sub New()
    End Sub

    ' Erstellt neue Instanz und verbindet sich
    Public Sub connect()
        connector = New ServerConnector()
        ' Einkommende Nachricht handeln
        connector.OnRecieve.addHandler(AddressOf onRequest)
        connector.OnClose.addHandler(AddressOf loggedOut)
        connector.connect()
    End Sub

    ' Event für Registrierung Neue Methode zuweisen!
    Public OnRegister As Func(Of String, String, String, User)
    ' Event für login Neue Methode zuweisen!
    Public OnLogin As Func(Of String, String, User)
    'Event für alle Benutzernamen senden
    Public OnUserlist As Func(Of Integer, User())
    'Event für Freunde senden
    Public OnChats As Func(Of Integer, Chat())
    'Event für Neue Freunde
    Public OnNewChat As Func(Of Integer, Integer, Chat)
    'Event für alle Nachrichten
    Public OnMessages As Func(Of Integer, Message())
    'Event für Nachricht senden
    Public OnSendMessage As Func(Of Integer, Integer, String, Tuple(Of Message, Integer()))
    'Event für Logout
    Public OnLogOut As Func(Of Integer)
    'Event für Einstellungsänderungen
    Public OnSettings As Func(Of Integer, String, String)


    ' Falls neue Nachricht kommt:
    Private Sub onRequest(req As ConnectionData, client As TcpClient)
        Console.WriteLine("Einkommende Nachricht des Typs " & req.Type)
        ' Welcher Typ ist die Nachricht?
        Select Case req.Type
            Case "register"
                If OnRegister IsNot Nothing Then
                    ' Argumente bekommen
                    Dim name As String = req.Data.Item("name")
                    Dim username As String = req.Data.Item("username")
                    Dim password As String = req.Data.Item("password")

                    ' Methode aufrufen + Callback 
                    Dim User = OnRegister(
                        name,
                        username,
                        password
                    )
                    RegisterConfirm(User, client)
                End If
            Case "login"
                If OnLogin IsNot Nothing Then
                    ' Argumente bekommen
                    Dim username As String = req.Data.Item("username")
                    Dim password As String = req.Data.Item("password")
                    ' Methode aufrufen + Callback 
                    Dim User = OnLogin(
                        username,
                        password
                    )

                    LoginConfirm(User, client)
                End If
            Case "userlist"
                If OnUserlist IsNot Nothing Then
                    Dim id As Integer = req.getData("id")
                    Dim Users = OnUserlist(id)
                    SendUserlist(Users, client)

                End If
            Case "chats"
                If OnChats IsNot Nothing Then
                    Dim id As Integer = req.getData("id")
                    Dim chats = OnChats(id)
                    SendChats(chats, client)
                End If
            Case "NewChat"
                If OnNewChat IsNot Nothing Then
                    Dim idself As Integer = req.Data.Item("IDself")
                    Dim idfriend As Integer = req.Data.Item("IDfriend")
                    Dim Chat = OnNewChat(idself, idfriend)

                    Dim data As New ConnectionData("NewChat")
                    data.addData("success", Chat)
                    connector.send(client, data)
                End If
            Case "messages"
                If OnMessages IsNot Nothing Then
                    Dim idchat As Integer = req.Data.Item("idchat")
                    Dim messages = OnMessages(idchat)
                    Dim data As New ConnectionData("messages")
                    data.addData("messages", messages)
                    connector.send(client, data)
                End If
            Case "send message"
                If OnSendMessage IsNot Nothing Then
                    Dim id As Integer = req.Data.Item("ID")
                    Dim idchat As Integer = req.Data("idchat")
                    Dim message As String = req.Data("message")

                    Dim sendmsg As Tuple(Of Message, Integer()) = OnSendMessage(id, idchat, message)


                    Dim res As New ConnectionData("message")
                    res.addData("message", sendmsg.Item1)
                    connector.send(client, res)

                    If sendmsg.Item1 IsNot Nothing Then
                        For Each reciever As Integer In sendmsg.Item2
                            If loggedIn.ContainsKey(reciever) Then
                                Dim data As New ConnectionData("message")
                                data.addData("message", sendmsg.Item1)
                                connector.send(loggedIn(reciever), data)
                            End If
                        Next


                    End If
                End If

            Case "loggedOut"
                loggedOut(client)

            Case "settings"
                If OnSettings IsNot Nothing Then
                    Dim id As Integer = req.Data.Item("id")
                    Dim name As String = req.Data.Item("name")

                End If
        End Select

    End Sub

    ' Sende Antwort für Registrieren
    Private Sub RegisterConfirm(User As User, client As TcpClient)
        If User IsNot Nothing Then
            loggedIn(User.id) = client
        End If

        Dim data As New Dictionary(Of String, Object)
        data.Add("user", User)
        Dim req As New ConnectionData("registerconfirm", data)
        connector.send(client, req)
    End Sub

    ' Sende Antwort für Login
    Private Sub LoginConfirm(User As User, client As TcpClient)
        If User IsNot Nothing Then
            loggedIn(User.id) = client
        End If

        Dim data As New Dictionary(Of String, Object)
        data.Add("user", User)
        Dim req As New ConnectionData("loginconfirm", data)
        connector.send(client, req)
    End Sub


    Private Sub SendUserlist(ans As User(), client As TcpClient)
        Dim data As New Dictionary(Of String, Object)
        data.Add("userlist", ans)
        connector.send(client, New ConnectionData("userlist", data))
    End Sub

    Private Sub SendChats(ans As Chat(), client As TcpClient)
        Dim data As New Dictionary(Of String, Object)
        data.Add("chats", ans)
        connector.send(client, New ConnectionData("chats", data))
    End Sub

    Public Sub loggedOut(client As TcpClient)
        Dim id As Integer = 0
        For Each c As KeyValuePair(Of Integer, TcpClient) In loggedIn
            If c.Value.Equals(client) Then
                id = c.Key
            End If
        Next

        loggedIn.Remove(id)
    End Sub

    Public Sub changeSettings(ans As String, client As TcpClient)
        Dim data As New Dictionary(Of String, Object)
        data.Add("name", ans)
    End Sub



End Class
