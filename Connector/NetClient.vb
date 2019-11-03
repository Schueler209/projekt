Imports System.Net.Sockets

Public Class NetClient

    Private connector As ClientConnector

    Sub New()
    End Sub

    ' Erstellt neue Instanz und verbindet sich
    Public Sub connect()
        connector = New ClientConnector()
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
    Public OnFriends As Action(Of User())
    'Event für neuen Freund hinzufügen
    Public OnNewFriendConfirm As Action(Of User)

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
                    Dim list As User() = req.Data.Item("All users")
                    OnUserList(list)
                End If

            Case "friends"
                If OnFriends IsNot Nothing Then
                    Dim list As User() = req.Data.Item("Friends")
                    OnFriends(list)
                End If

            Case "new Friend confirm"
                If OnNewFriendConfirm IsNot Nothing Then
                    Dim ans As User = req.Data.Item("succes")
                    OnNewFriendConfirm(ans)
                End If



        End Select

    End Sub

    ' Registrieren
    Sub Register(name As String, username As String, password As String, callback As Action(Of User))
        Dim data As New Dictionary(Of String, Object)
        data.Add("name", name)
        data.Add("username", username)
        data.Add("password", password)
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
    Sub getAllUsers(callback As Action(Of User()))
        Dim data As New Dictionary(Of String, Object)
        Dim res As New ConnectionData("userlist", data)
        connector.send(res)
        OnUserList = callback
    End Sub

    'Friends
    Sub getFriends(callback As Action(Of User()))
        Dim data As New Dictionary(Of String, Object)
        Dim res As New ConnectionData("Friends", data)
        connector.send(res)
        OnUserList = callback
    End Sub

    'NewFriends
    Sub NewFriendConfirm(callback As Action(Of Boolean))
        Dim data As New Dictionary(Of String, Object)
        Dim res As New ConnectionData("new Friend confirm")
        connector.send(res)
        OnNewFriendConfirm = callback
    End Sub

End Class
