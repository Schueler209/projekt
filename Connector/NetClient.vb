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
    Public OnRegisterConfirm As Action(Of Integer)
    ' Event für login Neue Methode zuweisen!
    Public OnLoginConfirm As Action(Of Integer)
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
                    Dim id As Integer = req.Data.Item("id")

                    ' Methode aufrufen + Callback 
                    OnRegisterConfirm(id)
                End If
            Case "loginconfirm"
                If OnLoginConfirm IsNot Nothing Then
                    ' Argumente bekommen
                    Dim id As Integer = req.Data.Item("id")
                    ' Methode aufrufen + Callback 
                    OnLoginConfirm(id)
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
                If OnNewFriendConfirm IsNot Nothing Then
                    Dim ans As Boolean = req.Data.Item("succes")
                    OnNewFriendConfirm(ans)
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
    Sub Login(username As String, password As String, id As Integer, callback As Action(Of Boolean))
        Dim data As New Dictionary(Of String, Object)
        data.Add("username", username)
        data.Add("password", password)
        Dim req As New ConnectionData("login", data)
        connector.send(req)
        ' Callback setzen
        OnLoginConfirm = callback
    End Sub

    'Userlist
    Sub getAllUsers(callback As Action(Of String()))
        Dim data As New Dictionary(Of String, Object)
        Dim res As New ConnectionData("all users", data)
        connector.send(res)
        OnUserList = callback
    End Sub

    'Friends
    Sub getFriends(callback As Action(Of String()))
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
