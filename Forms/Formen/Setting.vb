
Public Class Einstellungen
    'Namen und Bernutzernamen anzeigen
    Private Sub Einstellungen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Text = NetworkClass.login.name
        lblUsername.Text = NetworkClass.login.benutzername
    End Sub

    Public Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim NewName As String
        NewName = txtName.Text
    End Sub


End Class