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
            If value IsNot Nothing Then
                selectedChat = value
                lblChatpartner.Text = value.user.name


                NetworkClass.net.getMessages(value.ID, AddressOf recievemessages)
            End If
        End Set
    End Property

    Private Sub recievemessages(msg As Message())
        For Each item In msg
            addMessage(item)

        Next

        ' Hier müsste noch hin, dass alle Nachrichten mit der addMessage Methode hinzugefügt werden

        ' Nach unten scrollen

    End Sub

    Private Sub BtnSenden_Click(sender As Object, e As EventArgs) Handles btnSenden.Click
        SendMessage()
    End Sub

    Public Sub addMessage(msg As Message)
        Dim messagecontrol As New MessageControl(msg)
        messagecontrol.Top = messagecontrol.Height * Panel1.Controls.Count
        If msg.user.id = NetworkClass.login.id Then
            messagecontrol.Anchor = AnchorStyles.Right
            messagecontrol.Left = Panel1.Width - messagecontrol.Width
            messagecontrol.BackColor = Color.Coral
        End If

        Panel1.Controls.Add(messagecontrol)

    End Sub

    Private Sub SendMessage()
        If txtEingabe.Text.Length > 0 Then

            NetworkClass.net.SendMessage(NetworkClass.login.id, selectedChat.ID, txtEingabe.Text)
            txtEingabe.Clear()
        End If
    End Sub


    Private Sub txtEingabe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEingabe.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendMessage()
        End If
    End Sub

    Private Sub ChatArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
