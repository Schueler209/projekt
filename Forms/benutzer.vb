Public Class benutzer
    Private Sub txbBenutzerSuchen_TextChanged(sender As Object, e As EventArgs) Handles txbBenutzerSuchen.TextChanged

    End Sub

    Private Sub btnZuKontakte_Click(sender As Object, e As EventArgs) Handles btnZuKontakte.Click
        chat.Show()
        Me.Hide()
    End Sub
End Class