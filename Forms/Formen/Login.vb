﻿Imports Connector

Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NetworkClass.ensureConnection()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txbBenutzername.Text = "" Then lblFehler.Text = "kein Benutzername angegeben"
        If txbPasswort.Text = "" Then lblFehler.Text = "kein Passwort angegeben"
        If lblFehler.Text = "" Then
            NetworkClass.net.Login(txbBenutzername.Text, txbPasswort.Text, AddressOf Loginconfirm)
        End If

    End Sub

    Private Sub btnZumRegistrieren_Click(sender As Object, e As EventArgs) Handles btnZumRegistrieren.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub txbPasswort_TextChanged(sender As Object, e As EventArgs) Handles txbPasswort.TextChanged
        txbPasswort.PasswordChar = "*"
    End Sub

    Sub Loginconfirm(wert As Boolean)
        If wert Then
            NetworkClass.loginID = 1 'TODO: richtige ID hinzufügen
            chat.Show()

            Me.Hide()
        Else
            lblFehler.Text = "Passwort und Benutzername stimmen nicht überein"

        End If

    End Sub
End Class

