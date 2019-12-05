Imports Connector
Public Class IPundPort

    Private Sub cmdSpeichern_Click(sender As Object, e As EventArgs) Handles cmdSpeichernundLaden.Click
        connect()
    End Sub

    Private Sub connect()
        If txtAddress.Text.Trim().Length > 0 Then
            Dim input As String() = txtAddress.Text.Split(":")
            NetworkClass.Ip = input(0)
            If input.Length > 1 Then
                NetworkClass.Port = input(1)
            End If

            NetworkClass.ensureConnection()
            Register.Show()
            Me.Close()
        End If
    End Sub

    Private Sub IPundPort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAddress.Text = NetworkClass.Ip
        If Not NetworkClass.Port = 8080 Then
            txtAddress.Text += ":" & NetworkClass.Port
        End If
        lblError.Text = "Es scheint ein Fehler bei der Verbindung zu " & NetworkClass.Ip & ":" & NetworkClass.Port & " aufgetreten zu sein. Bitte überprüfe deine Servereinstellungen"
    End Sub

    Private Sub txtAddress_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            connect()
            e.SuppressKeyPress = True
        End If
    End Sub
End Class