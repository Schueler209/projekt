Imports Connector

Public Class Register

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NetworkClass.ensureConnection()

        ' Fehler label verstecken
        lblFehler.Text = ""
    End Sub

    Private Sub btnRegistrieren_Click(sender As Object, e As EventArgs) Handles btnRegistrieren.Click
        register()

    End Sub

    Sub Registerconfirm(wert As User)

        If IsNothing(wert) Then
            lblFehler.Text = "Benutzer existiert schon, bitte anderen Benutzernamen wählen."
        Else

            NetworkClass.login = wert
            If checkKeepLoggedIn.Checked Then
                My.Settings.username = txbBenutzername.Text
                My.Settings.password = txbPasswort.Text
            End If
            Chats.Show()

            Me.Close()

        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        LoginForm.Show()
        Me.Close()

    End Sub

    Private Sub txbPasswort_TextChanged(sender As Object, e As EventArgs) Handles txbPasswort.TextChanged
        txbPasswort.PasswordChar = "*"
    End Sub

    Private Sub txbPasswortWdh_TextChanged(sender As Object, e As EventArgs) Handles txbPasswortWdh.TextChanged
        txbPasswortWdh.PasswordChar = "*"
    End Sub

    Private Sub register()
        lblFehler.Text = ""
        If Not txbPasswortWdh.Text = txbPasswort.Text Then lblFehler.Text = "Passwörter ungleich"
        If txbAnzeigename.Text.Trim() = "" Then lblFehler.Text = "kein Anzeigename angegeben"
        If txbBenutzername.Text.Trim() = "" Then lblFehler.Text = "kein Benutzername angegeben"
        If txbPasswortWdh.Text = "" Then lblFehler.Text = "Passwort nicht wiederholt"
        If txbPasswort.Text = "" Then lblFehler.Text = "kein Passwort angegeben"
        If txbBenutzername.Text.Trim().Length > 15 Then lblFehler.Text = "Benutzername zu lang"
        If txbAnzeigename.Text.Trim().Length > 15 Then lblFehler.Text = "Name zu lang"
        If lblFehler.Text = "" Then
            NetworkClass.net.Register(txbAnzeigename.Text, txbBenutzername.Text, txbPasswort.Text, AddressOf Registerconfirm)
        End If

    End Sub

    Private Sub txbPasswortWdh_KeyDown(sender As Object, e As KeyEventArgs) Handles txbPasswortWdh.KeyDown
        If e.KeyCode = Keys.Enter Then
            Register()
            e.SuppressKeyPress = True
        End If

    End Sub


End Class




