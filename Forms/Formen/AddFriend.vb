Public Class AddFriend
    Private users As String()
    Private Sub txbBenutzerSuchen_TextChanged(sender As Object, e As EventArgs) Handles txbBenutzerSuchen.TextChanged
        ' Vorherige Anzeige löschen
        ltbAlleBenutzer.Items.Clear()
        For Each user In users
            ' Ist der Name in der Suche enthalten?
            If user.Contains(txbBenutzerSuchen.Text) Then
                ltbAlleBenutzer.Items.Add(user)
            End If
        Next
    End Sub

    Private Sub btnZuKontakte_Click(sender As Object, e As EventArgs) Handles btnZuKontakte.Click
        Me.Hide()
    End Sub

    Private Sub benutzer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NetworkClass.net.getAllUsers(Sub(AllUsers As String())
                                         users = AllUsers
                                     End Sub)
        For Each user In users
            ltbAlleBenutzer.Items.Add(user)
        Next
    End Sub

    Private Sub ltbAlleBenutzer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltbAlleBenutzer.SelectedIndexChanged
        'NetworkClass.net.
        Console.WriteLine(ltbAlleBenutzer.SelectedItem)
    End Sub

End Class