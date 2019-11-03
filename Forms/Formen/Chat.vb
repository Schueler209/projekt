Imports Connector

Public Class Chat

    Private users As New List(Of User)


    Private Sub Chat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each user As User In users.ToArray
            ltbKontakte.Items.Add(user.benutzername)
        Next
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
        Me.Hide()
    End Sub

    Public Sub addFriendToList(ByVal user As User)
        users.Add(user)
        ltbKontakte.Items.Clear()

        For Each val As User In users.ToArray
            ltbKontakte.Items.Add(val.benutzername)
        Next

    End Sub


End Class