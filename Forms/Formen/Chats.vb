Imports Connector

Public Class Chats

    Private chats As New List(Of Chat)


    Private Sub Chat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChatArea.Hide()
        NetworkClass.net.getChats(NetworkClass.login.id, AddressOf onGetChats)

        NetworkClass.net.OnMessage = AddressOf OnRecieveMessage

    End Sub

    Sub OnRecieveMessage(msg As Message)

        If ChatArea.Chat IsNot Nothing AndAlso msg.chat = ChatArea.Chat.ID Then
            ChatArea.addMessage(msg)
        End If
    End Sub

    Private Sub onGetChats(FriendChats As Chat())
        For Each chat As Chat In FriendChats
            ltbKontakte.Items.Add(chat.user.benutzername)
            chats.Add(chat)
        Next
        If FriendChats.Length > 0 Then
            ltbKontakte.SelectedIndex = 0
        End If

    End Sub

    Private Sub btnNeuerKontakt_Click(sender As Object, e As EventArgs) Handles btnNeuerKontakt.Click
        AddFriend.Show()

    End Sub

    Private Sub LtbKontakte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltbKontakte.SelectedIndexChanged

        Dim chat = chats(ltbKontakte.SelectedIndex)
        If chat IsNot Nothing And chat IsNot ChatArea.Chat Then
            ChatArea.Chat = chat
            ChatArea.Show()

        End If

    End Sub

    Private Sub btnAbmelden_Click(sender As Object, e As EventArgs)
        LoginForm.Show()
        NetworkClass.login = Nothing
        NetworkClass.net.logOut()
        Me.Close()

    End Sub

    Public Sub addChatToList(ByVal user As Chat)
        chats.Insert(0, user)
        ltbKontakte.Items.Clear()

        For Each chat As Chat In chats
            ltbKontakte.Items.Add(chat.user.benutzername)
        Next
        ltbKontakte.SelectedIndex = 0
    End Sub

    Private Sub Chats_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ChatArea.Width = Me.Width - 150
    End Sub

    Private Sub EinstellungenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EinstellungenToolStripMenuItem1.Click
        Settings.Show()
    End Sub

    Private Sub AbmeldenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AbmeldenToolStripMenuItem1.Click
        LoginForm.Show()
        NetworkClass.login = Nothing
        NetworkClass.net.logOut()
        Me.Close()
    End Sub
End Class