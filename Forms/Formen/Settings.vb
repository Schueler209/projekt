
Public Class Settings
    'Namen und Benutzernamen anzeigen
    Private Sub Einstellungen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
        NetworkClass.net.OnSettings = AddressOf onsettings
        txtName.Text = NetworkClass.login.name
        lblUsername.Text = "Dein Benutzername: " & NetworkClass.login.benutzername
        lblFehler.Text = ""
    End Sub

    Public Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtPassword.Text IsNot "" Then
            Dim NewName As String = txtName.Text
            NetworkClass.net.changeSettings(NetworkClass.login.id, NewName, txtPassword.Text, txtNewPassword.Text, Profilfarbe1.selectedcolour())
        Else
            lblFehler.Text = "Bitte zur Legimitierung dein aktuelles Passwort eingeben"
        End If


        NetworkClass.net.OnSettings = AddressOf onsettings


    End Sub
    Public Sub onsettings(settings As Boolean)
        If settings Then
            NetworkClass.login.name = txtName.Text
            Me.Close()
        Else
            lblFehler.Text = "Passwort oder Eingabe ist falsch"
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class