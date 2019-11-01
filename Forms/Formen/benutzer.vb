Public Class benutzer
    Private users As New List(Of String)
    Private Sub txbBenutzerSuchen_TextChanged(sender As Object, e As EventArgs) Handles txbBenutzerSuchen.TextChanged
        ltbAlleBenutzer.Items.Clear()
        For Each user In users
            If user.Contains(txbBenutzerSuchen.Text) Then
                ltbAlleBenutzer.Items.Add(user)
            End If


        Next
    End Sub

    Private Sub btnZuKontakte_Click(sender As Object, e As EventArgs) Handles btnZuKontakte.Click
        chat.Show()
        Me.Hide()
    End Sub

    Private Sub benutzer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        users.Add("marten1")
        users.Add("laura1")
        users.Add("till1")
        For Each user In users
            ltbAlleBenutzer.Items.Add(user)
        Next
    End Sub

    Private Sub ltbAlleBenutzer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltbAlleBenutzer.SelectedIndexChanged
        Console.WriteLine(ltbAlleBenutzer.SelectedItem)
    End Sub





End Class