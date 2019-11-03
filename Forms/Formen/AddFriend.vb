Imports Connector

Public Class AddFriend
    Private users As User()
    Private Sub txbBenutzerSuchen_TextChanged(sender As Object, e As EventArgs) Handles txbBenutzerSuchen.TextChanged
        ' Vorherige Anzeige löschen
        ltbAlleBenutzer.Items.Clear()
        For Each user In users
            ' Ist der Name in der Suche enthalten?
            If user.benutzername.ToLower.Contains(txbBenutzerSuchen.Text.ToLower) Or user.name.ToLower.Contains(txbBenutzerSuchen.Text.ToLower) Then
                ltbAlleBenutzer.Items.Add(user.benutzername)
            End If

        Next
    End Sub

    Private Sub btnZuKontakte_Click(sender As Object, e As EventArgs) Handles btnZuKontakte.Click
        Me.Hide()
    End Sub

    Private Sub benutzer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NetworkClass.net.getAllUsers(Sub(AllUsers As User())
                                         Console.WriteLine(AllUsers)
                                         users = AllUsers
                                         For Each user In users
                                             ltbAlleBenutzer.Items.Add(user.benutzername)
                                         Next
                                     End Sub)

    End Sub

    Private Sub ltbAlleBenutzer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltbAlleBenutzer.SelectedIndexChanged
        Dim selecteduser As User
        For Each user In users
            If user.benutzername = ltbAlleBenutzer.SelectedItem Then
                selecteduser = user
            End If
        Next
        If selecteduser IsNot Nothing Then
            NetworkClass.net.AddNewFriend(NetworkClass.login.id, selecteduser.id, Sub(res As User)
                                                                                      Console.WriteLine(res.benutzername)
                                                                                      Me.Hide()
                                                                                  End Sub)
        End If


    End Sub

End Class