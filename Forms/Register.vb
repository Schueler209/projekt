Public Class Register
    Private Sub btnRegistrieren_Click(sender As Object, e As EventArgs) Handles btnRegistrieren.Click
        If Not txbPasswortWdh.Text = txbPasswort.Text Then lblFehlermeldung.Text = "Passwörter ungleich"
        If txbAnzeigename.Text = "" Then lblFehlermeldung.Text = "kein Anzeigename angegeben"
        If txbBenutzername.Text = "" Then lblFehlermeldung.Text = "kein Benutzername angegeben"
        If txbPasswort.Text = "" Then lblFehlermeldung.Text = "kein Passwort angegeben"
        If txbPasswortWdh.Text = "" Then lblFehlermeldung.Text = "Passwort nicht wiederholt"
        If lblFehlermeldung.Text = "" Then
            chatten.Show()
            Me.Hide()

        End If

    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login.Show()
        Me.Hide()

    End Sub

    Private Sub txbPasswort_TextChanged(sender As Object, e As EventArgs) Handles txbPasswort.TextChanged
        txbPasswort.PasswordChar = "*"
    End Sub

    Private Sub txbPasswortWdh_TextChanged(sender As Object, e As EventArgs) Handles txbPasswortWdh.TextChanged
        txbPasswortWdh.PasswordChar = "*"
    End Sub
End Class


