Imports Connector

Public Class Chat

    Private users As New List(Of User)


    Private Sub Chat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NetworkClass.net.getFriends(NetworkClass.login.id, Sub(Friends As User())
                                                               Console.WriteLine(Friends.Length)
                                                               For Each user As User In Friends
                                                                   ltbKontakte.Items.Add(user.benutzername)
                                                                   users.Add(user)
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