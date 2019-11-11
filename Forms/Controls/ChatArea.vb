Imports Connector

Public Class ChatArea
    Inherits UserControl

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Private selectedChat As Chat
    Public Property Chat As Chat
        Get
            Return selectedChat
        End Get
        Set(value As Chat)
            selectedChat = value
        End Set
    End Property

    Private Sub BtnSenden_Click(sender As Object, e As EventArgs) Handles btnSenden.Click
        SendMessage()

    End Sub

    Private Sub SendMessage()
        If txtEingabe.Text.Length > 0 Then
            ltbChat.Items.Add(txtEingabe.Text)
            txtEingabe.Clear()
            ltbChat.Items.Add(NetworkClass.login.name & "-" & txtEingabe.Text)
        End If
    End Sub

    Private Sub txtEingabe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEingabe.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendMessage()
        End If
    End Sub


End Class
