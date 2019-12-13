Imports System.Net.Sockets

Public Class NetClient

    Private connector As ClientConnector

    Sub New()
    End Sub

    ' Erstellt neue Instanz und verbindet sich
    Public Sub connect(Ip As String, Port As Integer)
        connector = New ClientConnector(Ip, Port)
        ' Einkommende Nachricht handeln
        connector.OnRecieve.addHandler(AddressOf onRequest)
        connector.OnConnectionLost.addHandler(OnConnectionLost)
        connector.connect()

    End Sub

    ' Event für Registrierung Neue Methode zuweisen!
    Public OnConnectionLost As Action

    ' Event für Registrierung Neue Methode zuweisen!
    Public OnRegisterConfirm As Action(Of User)
    ' Event für login Neue Methode zuweisen!
    Public OnLoginConfirm As Action(Of User)
    'Event für alle Benutzernamenn empfangen
    Public OnUserList As Action(Of User())
    'Event für Freunde empfangen
    Public OnChats As Action(Of Chat())
    'Event für neuen Freund hinzufügen
    Public OnNewChat As Action(Of Chat)
    'Event für alle Nschrichten
    Public OnMessages As Action(Of Message())
    'Event für Nachricht bekommen(eigene oder andere)
    Public OnMessage As Action(Of Message)
    'Event für Einstellungsänderungen
    Public OnSettings As Action(Of Boolean)
    'Event für Chat löschen
    Public OnDeleteChat As Action(Of Integer)

    'Event für TicTacToe Request
    Public OnTTTRequest As Action(Of Integer)

    'Event für TicTacToe Update
    Public OnTTTUpdate As Action(Of Integer, TTTData)


    ' Falls neue Nachricht kommt:
    Private Sub onRequest(req As ConnectionData)
        Console.WriteLine("Einkommende Nachricht des Typs " & req.Type)
        ' Welcher Typ ist die Nachricht?
        Select Case req.Type
            Case "registerconfirm"
                If OnRegisterConfirm IsNot Nothing Then
                    ' Argumente bekommen
                    Dim user As User = req.Data.Item("user")

                    ' Methode aufrufen + Callback 
                    OnRegisterConfirm(user)
                End If
            Case "loginconfirm"
                If OnLoginConfirm IsNot Nothing Then
                    ' Argumente bekommen
                    Dim user As User = req.Data.Item("user")
                    ' Methode aufrufen + Callback 
                    OnLoginConfirm(user)

                End If
            Case "userlist"
                If OnUserList IsNot Nothing Then
                    Dim list As User() = req.Data.Item("userlist")
                    OnUserList(list)
                End If

            Case "chats"
                If OnChats IsNot Nothing Then
                    Dim list As Chat() = req.Data.Item("chats")
                    OnChats(list)
                End If

            Case "NewChat"
                If OnNewChat IsNot Nothing Then
                    Dim ans As Chat = req.Data.Item("success")
                    OnNewChat(ans)
                End If

            Case "messages"
                If OnMessages IsNot Nothing Then
                    Dim ans As Message() = req.Data.Item("messages")
                    OnMessages(ans)
                End If

            Case "message"
                If OnMessage IsNot Nothing Then
                    Dim ans As Message = req.Data.Item("message")
                    OnMessage(ans)
                End If

            Case "settingsSuccess"
                If OnSettings IsNot Nothing Then
                    Dim ans As Boolean = req.Data.Item("success")
                    OnSettings(ans)
                End If

            Case "delete chat"
                If OnDeleteChat IsNot Nothing Then
                    Dim ans As Integer = req.Data.Item("success")
                    OnDeleteChat(ans)
                End If
            Case "TicTacToe/Request"
                Dim sender As Integer = req.Data.Item("user")
                If OnTTTRequest IsNot Nothing Then
                    OnTTTRequest(sender)
                End If
            Case "TicTacToe/Update"
                Dim sender As Integer = req.Data.Item("user")
                Dim data As TTTData = req.Data.Item("data")
                If OnTTTUpdate IsNot Nothing Then
                    OnTTTUpdate(sender, data)
                End If
        End Select

    End Sub

    ' Registrieren
    Sub Register(name As String, username As String, password As String, colour As Integer, callback As Action(Of User))
        Dim data As New Dictionary(Of String, Object)
        data.Add("name", name)
        data.Add("username", username)
        data.Add("password", password)
        data.Add("colour", colour)
        Dim req As New ConnectionData("register", data)
        connector.send(req)
        ' Callback setzen
        OnRegisterConfirm = callback
    End Sub
    ' Einloggen
    Sub Login(username As String, password As String, callback As Action(Of User))
        Dim data As New Dictionary(Of String, Object)
        data.Add("username", username)
        data.Add("password", password)
        Dim req As New ConnectionData("login", data)
        connector.send(req)
        ' Callback setzen
        OnLoginConfirm = callback
    End Sub

    'Userlist
    Sub getAllUsers(id As Integer, callback As Action(Of User()))
        Dim res As New ConnectionData("userlist")
        res.addData("id", id)
        connector.send(res)
        OnUserList = callback
    End Sub

    'Chats
    Sub getChats(id As Integer, callback As Action(Of Chat()))
        Dim res As New ConnectionData("chats")
        res.addData("id", id)
        connector.send(res)
        OnChats = callback
    End Sub

    'NewChat
    Sub NewChat(idself As Integer, idfriend As Integer, callback As Action(Of Chat))
        Dim data As New Dictionary(Of String, Object)
        Dim res As New ConnectionData("NewChat")
        res.addData("IDself", idself)
        res.addData("IDfriend", idfriend)
        connector.send(res)
        OnNewChat = callback
    End Sub

    'Messages bekommen
    Sub getMessages(idchat As Integer, callback As Action(Of Message()))
        Dim res As New ConnectionData("messages")
        res.addData("idchat", idchat)
        connector.send(res)
        OnMessages = callback
    End Sub


    Sub SendMessage(id As Integer, idchat As Integer, message As String)
        Dim res As New ConnectionData("send message")
        res.addData("ID", id)
        res.addData("message", message)
        res.addData("idchat", idchat)
        connector.send(res)
    End Sub


    Sub logOut()
        Dim res As New ConnectionData("loggedOut")
        connector.send(res)
    End Sub

    Sub changeSettings(id As Integer, name As String, password As String, newPassword As String, colour As Integer)
        Dim res As New ConnectionData("settings")
        res.addData("id", id)
        res.addData("name", name)
        res.addData("password", password)
        res.addData("newPassword", newPassword)
        res.addData("colour", colour)
        connector.send(res)

    End Sub

    Sub deleteChat(Chatid As Integer, Userid As Integer)
        Dim res As New ConnectionData("delete Chat")
        res.addData("chat", Chatid)
        res.addData("UserID", Userid)
        connector.send(res)
    End Sub

    Sub sendTTTRequest(ownId As Integer, Userid As Integer)
        Dim res As New ConnectionData("TicTacToe/Request")
        res.addData("user", ownId)
        res.addData("reciever", Userid)
        connector.send(res)
    End Sub
    Sub updateTTT(ownId As Integer, Userid As Integer, data As TTTData)
        Dim res As New ConnectionData("TicTacToe/Update")
        res.addData("user", ownId)
        res.addData("reciever", Userid)
        res.addData("data", data)
        connector.send(res)
    End Sub

End Class
