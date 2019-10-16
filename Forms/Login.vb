Imports Connector

Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txbBenutzername.Text = "" Then lblFehler.Text = "kein Benutzername angegeben"
        If txbPasswort.Text = "" Then lblFehler.Text = "kein Passwort angegeben"
        If lblFehler.Text = "" Then

            connect.Login(txbBenutzername.Text, txbPasswort.Text, AddressOf Loginconfirm)
        End If

    End Sub

    Private Sub btnZumRegistrieren_Click(sender As Object, e As EventArgs) Handles btnZumRegistrieren.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub txbPasswort_TextChanged(sender As Object, e As EventArgs) Handles txbPasswort.TextChanged
        txbPasswort.PasswordChar = "*"
    End Sub
    Private connect As NetClient = New NetClient
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.connect()
    End Sub

    Sub Loginconfirm(wert As Boolean)
        If wert Then
            chatten.Show()
            Me.Hide()
        Else

            lblFehler.Text = "Passwort und Benutzername stimmen nicht überein"

        End If

    End Sub
End Class

