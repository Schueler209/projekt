Public Class Register
    Private Sub btnRegistrieren_Click(sender As Object, e As EventArgs) Handles btnRegistrieren.Click
        If Not txbPasswortWdh.Text = txbPasswort.Text Then lblFehlermeldung.Text = "Passwörter ungleich"
        If txbAnzeigename.Text = "" Then lblFehlermeldung.Text = "kein Anzeigename angegeben"
        If txbBenutzername.Text = "" Then lblFehlermeldung.Text = "kein Benutzername angegeben"
        If txbPasswort.Text = "" Then lblFehlermeldung.Text = "kein Passwort angegeben"
        If txbPasswortWdh.Text = "" Then lblFehlermeldung.Text = "Passwort nicht wiederholt"

    End Sub
    Private Sub CommandbtnLogin_Click()

        Login.Show vbModal

End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

    End Sub
End Class


