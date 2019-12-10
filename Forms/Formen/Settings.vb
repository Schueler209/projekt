
Public Class Settings
    'Namen und Benutzernamen anzeigen
    Private Sub Einstellungen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NetworkClass.net.OnSettings = AddressOf onsettings
        txtName.Text = NetworkClass.login.name
        lblUsername.Text = NetworkClass.login.benutzername
    End Sub

    Public Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim NewName As String
        NewName = txtName.Text
        NetworkClass.net.changeSettings(NetworkClass.login.id, NewName)

        NetworkClass.net.OnSettings = AddressOf onsettings
    End Sub
    Public Sub onsettings(settings As Boolean)
        NetworkClass.login.name = txtName.Text
        Me.Close()
    End Sub
End Class