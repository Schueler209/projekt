Imports Connector

Public Class AddFriend
    Private users As User()
    Private filteredUsers As New List(Of User)

    Private Sub txbBenutzerSuchen_TextChanged(sender As Object, e As EventArgs) Handles txbBenutzerSuchen.TextChanged
        ' Vorherige Anzeige löschen
        showUsers()
    End Sub

    Private Sub showUsers()
        ltbAlleBenutzer.Items.Clear()
        filteredUsers = New List(Of User)
        For Each user In users
            ' Ist der Name in der Suche enthalten?
            If user.benutzername.ToLower.Contains(txbBenutzerSuchen.Text.ToLower) Or user.name.ToLower.Contains(txbBenutzerSuchen.Text.ToLower) Then
                ltbAlleBenutzer.Items.Add("@" & user.benutzername & " (" & user.name & ")")
                filteredUsers.Add(user)
            End If

        Next
    End Sub

    Private Sub btnZuKontakte_Click(sender As Object, e As EventArgs) Handles btnZuKontakte.Click
        Me.Hide()
    End Sub

    Private Sub benutzer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
        NetworkClass.net.getAllUsers(NetworkClass.login.id, Sub(AllUsers As User())
                                                                users = AllUsers
                                                                showUsers()
                                                            End Sub)

    End Sub

    Private Sub ltbAlleBenutzer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltbAlleBenutzer.SelectedIndexChanged
        If ltbAlleBenutzer.SelectedIndex >= 0 Then
            Dim selecteduser As User = filteredUsers(ltbAlleBenutzer.SelectedIndex)
            If selecteduser IsNot Nothing Then
                Console.WriteLine(selecteduser.benutzername)
                NetworkClass.net.NewChat(NetworkClass.login.id, selecteduser.id, Sub(res As Chat)
                                                                                     If res IsNot Nothing Then
                                                                                         Chats.addChatToList(res)
                                                                                         Me.Close()
                                                                                     End If

                                                                                 End Sub)
            End If
        End If


    End Sub

End Class