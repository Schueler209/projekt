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
        ' Alle bisherigen Controls entfernen
        ChatPanel.Controls.Clear()
        For Each item In msg
            addMessage(item)
        Next

        ' Scrollen
        ChatPanel.VerticalScroll.Value = ChatPanel.VerticalScroll.Maximum

    End Sub

    Private Sub BtnSenden_Click(sender As Object, e As EventArgs) Handles btnSenden.Click
        SendMessage()
    End Sub

    Public Sub addMessage(msg As Message)
        Dim isOwn = msg.user.id = NetworkClass.login.id

        ChatPanel.VerticalScroll.Value = ChatPanel.VerticalScroll.Minimum



        Dim messagecontrol As New MessageControl(msg, isOwn)
        messagecontrol.Top = messagecontrol.Height * ChatPanel.Controls.Count
        'If (ChatPanel.VerticalScroll.Value / 100) * messagecontrol.Height * ChatPanel.Controls.Count > messagecontrol.Height Then
        '    messagecontrol.Top = messagecontrol.Top - (ChatPanel.VerticalScroll.Value / 100) * messagecontrol.Height * ChatPanel.Controls.Count
        'End If
        messagecontrol.Width = 0.8 * ChatPanel.Width
        If isOwn Then
            messagecontrol.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            messagecontrol.Left = ChatPanel.Width - messagecontrol.Width

        End If

        ChatPanel.Controls.Add(messagecontrol)

        ChatPanel.ScrollControlIntoView(messagecontrol)

        'ChatPanel.VerticalScroll.Value = ChatPanel.VerticalScroll.Maximum

    End Sub

    Private Sub SendMessage()
        If txtEingabe.Text.Trim().Length > 0 And txtEingabe.Text.Length > 2000 Then

            NetworkClass.net.SendMessage(NetworkClass.login.id, selectedChat.ID, txtEingabe.Text.Trim())
            txtEingabe.Clear()

        End If

    End Sub



    Private Sub ChatArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChatPanel.VerticalScroll.Enabled = True
    End Sub

    Private Sub txtEingabe_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEingabe.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendMessage()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub ChatArea_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        For Each control As Control In ChatPanel.Controls
            control.Width = 0.8 * ChatPanel.Width
            If control.Left > 20 Then
                control.Left = ChatPanel.Width - control.Width
            End If
        Next
    End Sub

    Private Sub btnKonaktEntfernen_Click(sender As Object, e As EventArgs) Handles btnKonaktEntfernen.Click
        NetworkClass.net.deleteChat(selectedChat.ID, NetworkClass.login.id)


    End Sub
End Class
