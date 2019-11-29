Imports Connector
Public Class IPundPort

    Private Sub cmdSpeichern_Click(sender As Object, e As EventArgs) Handles cmdSpeichernundLaden.Click
        NetworkClass.Ip = txtIp.Text
        NetworkClass.Port = txtPort.Text
        NetworkClass.ensureConnection()
        Register.Show()
        Me.Close()

    End Sub

    Private Sub IPundPort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIp.Text = NetworkClass.Ip
        txtPort.Text = NetworkClass.Port
    End Sub
End Class