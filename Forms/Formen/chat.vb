Imports Connector

Public Class ChatForm

    Private users As New List(Of User)


    Private Sub Chat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NetworkClass.net.getChats(NetworkClass.login.id, Sub(Chats As Chat())
                                                             For Each chat As Chat In Chats
                                                                 ltbKontakte.Items.Add(chat.user.benutzername)
                                                                 users.Add(chat.user)
                                                             Next
                                                         End Sub)
    End Sub

    Private Sub btnNeuerKontakt_Click(sender As Object, e As EventArgs) Handles btnNeuerKontakt.Click
        AddFriend.Show()

    End Sub

    Private Sub LtbKontakte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltbKontakte.SelectedIndexChanged
        ' Chat wechseln
    End Sub

    Private Sub btnAbmelden_Click(sender As Object, e As EventArgs) Handles btnAbmelden.Click
        Login.Show()
        NetworkClass.login = Nothing
        Me.Close()
    End Sub

    Public Sub addFriendToList(ByVal user As User)
        users.Add(user)
        ltbKontakte.Items.Clear()

        For Each val As User In users.ToArray
            ltbKontakte.Items.Add(val.benutzername)
        Next

    End Sub


End Class