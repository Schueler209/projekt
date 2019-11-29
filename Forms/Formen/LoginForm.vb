Imports Connector

Public Class LoginForm

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NetworkClass.ensureConnection()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        login()

    End Sub

    Private Sub btnZumRegistrieren_Click(sender As Object, e As EventArgs) Handles btnZumRegistrieren.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub txbPasswort_TextChanged(sender As Object, e As EventArgs) Handles txbPasswort.TextChanged
        txbPasswort.PasswordChar = "*"




    End Sub

    Sub Loginconfirm(wert As User)
        If IsNothing(wert) Then
            lblFehler.Text = "Passwort oder Benutzername ist falsch!"
        Else
            NetworkClass.login = wert
            Chats.Show()

            Me.Close()

        End If

    End Sub
    Private Sub login()
        lblFehler.Text = ""
        If txbBenutzername.Text = "" Then lblFehler.Text = "kein Benutzername angegeben"
        If txbPasswort.Text = "" Then lblFehler.Text = "kein Passwort angegeben"
        If lblFehler.Text = "" Then
            NetworkClass.net.Login(txbBenutzername.Text, txbPasswort.Text, AddressOf Loginconfirm)
        End If
    End Sub


    Private Sub txbPasswort_KeyDown(sender As Object, e As KeyEventArgs) Handles txbPasswort.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
            e.SuppressKeyPress = True
        End If
    End Sub
End Class

