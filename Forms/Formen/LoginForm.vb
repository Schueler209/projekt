Imports Connector

Public Class LoginForm

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
        NetworkClass.ensureConnection()

        ' Fehler label verstecken
        lblFehler.Text = ""


        ' gespeicherte Benutzername und Passwort abrufen

        If My.Settings.username IsNot "" And My.Settings.username IsNot "" Then
            txbBenutzername.Text = My.Settings.username
            txbPasswort.Text = My.Settings.password
            checkKeepLoggedIn.Checked = True
            login()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        login()

    End Sub

    Private Sub btnZumRegistrieren_Click(sender As Object, e As EventArgs) Handles btnZumRegistrieren.Click
        Register.Show()
        Me.Hide()
    End Sub

    Sub Loginconfirm(wert As User)
        If IsNothing(wert) Then
            lblFehler.Text = "Passwort oder Benutzername ist falsch!"
        Else
            NetworkClass.login = wert

            If checkKeepLoggedIn.Checked Then

                ' Benutzername und Passwort speichern
                My.Settings.username = txbBenutzername.Text
                My.Settings.password = txbPasswort.Text
                My.Settings.Save()
            End If
            Chats.Show()
            Me.Close()

        End If

    End Sub
    Private Sub login()
        lblFehler.Text = ""

        If txbPasswort.Text = "" Then lblFehler.Text = "kein Passwort angegeben"
        If txbBenutzername.Text = "" Then lblFehler.Text = "kein Benutzername angegeben"
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

