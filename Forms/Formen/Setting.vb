
Public Class Einstellungen

    Public Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim NewName As String
        NewName = txtName.Text

    End Sub

    Private Sub Einstellungen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NetworkClass.login
    End Sub
End Class