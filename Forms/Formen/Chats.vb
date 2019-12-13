Imports Connector

Public Class Chats

    Private chats As New List(Of Chat)

    Private Sub ondeletechat(delete As Integer)
        If delete >= 0 Then
            If ChatArea.Chat.ID = delete Then
                ChatArea.Hide()
            End If

            ltbKontakte.Items.Clear()
            Dim deletedchat As Chat

            For Each chat In chats
                If chat.ID = delete Then
                    deletedchat = chat
                Else
                    ltbKontakte.Items.Add(chat.user.name)

                End If

            Next

            If deletedchat IsNot Nothing Then
                chats.Remove(deletedchat)
            End If

        End If



    End Sub

    Private Sub Chat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)

        ChatArea.Hide()
        NetworkClass.net.getChats(NetworkClass.login.id, AddressOf onGetChats)

        NetworkClass.net.OnMessage = AddressOf OnRecieveMessage
        NetworkClass.net.OnDeleteChat = AddressOf ondeletechat
        NetworkClass.net.OnTTTRequest = AddressOf ChatArea.onTicTacToeRequest

    End Sub

    Private Sub showChats()
        ltbKontakte.Items.Clear()
        For Each chatten As Chat In chats
            ltbKontakte.Items.Add(chatten.user.name)
        Next
    End Sub


    Sub OnRecieveMessage(msg As Message)

        If ChatArea.Chat IsNot Nothing AndAlso msg.chat = ChatArea.Chat.ID Then
            ChatArea.addMessage(msg)
        End If
        If ltbKontakte.SelectedIndex >= 0 Then
            Dim chat As Chat = chats(ltbKontakte.SelectedIndex)
            chats.Remove(chat)
            chats.Insert(0, chat)
            showChats()
        End If



    End Sub

    Private Sub onGetChats(FriendChats As Chat())
        chats = FriendChats.ToList()
        showChats()
        If FriendChats.Length > 0 Then
            ltbKontakte.SelectedIndex = 0
        End If

    End Sub



    Private Sub btnNeuerKontakt_Click(sender As Object, e As EventArgs) Handles btnNeuerKontakt.Click
        AddFriend.Show()

    End Sub

    Private Sub LtbKontakte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltbKontakte.SelectedIndexChanged

        If ltbKontakte.SelectedIndex >= 0 Then
            Dim chat = chats(ltbKontakte.SelectedIndex)
            If chat IsNot Nothing And chat IsNot ChatArea.Chat Then
                ChatArea.Chat = chat
                ChatArea.Show()

            End If
        End If

    End Sub


    Public Sub addChatToList(ByVal user As Chat)
        chats.Insert(0, user)
        ltbKontakte.Items.Clear()

        showChats()

        ltbKontakte.SelectedIndex = 0
    End Sub

    Private Sub Chats_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ChatArea.Width = Me.Width - 150
    End Sub

    Private Sub EinstellungenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EinstellungenToolStripMenuItem1.Click
        Settings.Show()
    End Sub

    Private Sub AbmeldenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AbmeldenToolStripMenuItem1.Click
        My.Settings.Reload()
        ' Passwort und Benutzername löschen
        My.Settings.username = ""
        My.Settings.password = ""
        My.Settings.Save()

        LoginForm.txbBenutzername.Text = NetworkClass.login.benutzername

        NetworkClass.login = Nothing
        NetworkClass.net.logOut()


        ' Zu Login zurück
        LoginForm.Show()

        Me.Close()
        AddFriend.Close()
        Settings.Close()
    End Sub


End Class