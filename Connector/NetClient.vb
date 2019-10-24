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
        connector.connect()
    End Sub

    ' Event für Registrierung Neue Methode zuweisen!
    Public OnRegisterConfirm As Action(Of Boolean)
    ' Event für login Neue Methode zuweisen!
    Public OnLoginConfirm As Action(Of Boolean)
    'Event für alle Benutzernamenn empfangen
    Public OnUserList As Action(Of String())
    'Event für Freunde empfangen
    Public OnFriends As Action(Of String())
    'Event für neuen Freund hinzufügen
    Public OnNewFriendConfirm As Action(Of Boolean)

    ' Falls neue Nachricht kommt:
    Private Sub onRequest(req As ConnectionData)
        ' Welcher Typ ist die Nachricht?
        Select Case req.Type
            Case "registerconfirm"
                If OnRegisterConfirm IsNot Nothing Then
                    ' Argumente bekommen
                    Dim res As Boolean = req.Data.Item("success")

                    ' Methode aufrufen + Callback 
                    OnRegisterConfirm(res)
                End If
            Case "loginconfirm"
                If OnLoginConfirm IsNot Nothing Then
                    ' Argumente bekommen
                    Dim res As Boolean = req.Data.Item("success")
                    ' Methode aufrufen + Callback 
                    OnLoginConfirm(res)
                End If
            Case "userlist"
                If OnUserList IsNot Nothing Then
                    Dim list As String() = req.Data.Item("All users")
                    OnUserList(list)
                End If

            Case "friends"
                If OnFriends IsNot Nothing Then
                    Dim list As String() = req.Data.Item("Friends")
                    OnFriends(list)
                End If

            Case "new Friend confirm"
                If OnNewFriend IsNot Nothing Then
                    Dim ans As Boolean = req.Data.Item("succes")
                    OnNewFriend(ans)
                End If



        End Select

    End Sub

    ' Registrieren
    Sub Register(name As String, username As String, password As String, callback As Action(Of Boolean))
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
    Sub Login(username As String, password As String, callback As Action(Of Boolean))
        Dim data As New Dictionary(Of String, Object)
        data.Add("username", username)
        data.Add("password", password)
        Dim req As New ConnectionData("login", data)
        connector.send(req)
        ' Callback setzen
        OnLoginConfirm = callback
    End Sub

    'Userlist
    Sub getAllUsers(callback As String())
        Dim data As New Dictionary(Of String, Object)
        Dim req As New ConnectionData("all users")
        connector.send(req)
        OnUserList = callback
    End Sub

    'Friends
    Sub getFriends(callback As String())
        Dim data As New Dictionary(Of String, Object)
        Dim req As New ConnectionData("Friends")
        connector.send(req)
        OnUserList = callback
    End Sub

    'NewFriends
    Sub NewFriendConfirm(callback As Action(Of Boolean))
        Dim data As New Dictionary

    End Sub

End Class
