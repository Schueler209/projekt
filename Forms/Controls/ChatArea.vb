Imports Connector

Public Class ChatArea
    Inherits UserControl

    Private Sub ChatArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChatPanel.VerticalScroll.Enabled = True
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
        If msg IsNot Nothing Then
            For Each item In msg
                addMessage(item)

            Next

            ' Scrollen
            ChatPanel.VerticalScroll.Value = ChatPanel.VerticalScroll.Maximum

        End If


    End Sub

    Public Sub onTicTacToeRequest(user As Integer)
        If Chat.user.id = user Then
            ChatPanel.VerticalScroll.Value = ChatPanel.VerticalScroll.Minimum
            Dim messagecontrol As New TicTacToeMessage(user)
            messagecontrol.Top = messagecontrol.Height * ChatPanel.Controls.Count
            messagecontrol.Width = 0.8 * ChatPanel.Width

            ChatPanel.Controls.Add(messagecontrol)

            ChatPanel.ScrollControlIntoView(messagecontrol)
        End If
    End Sub

    Private Sub BtnSenden_Click(sender As Object, e As EventArgs) Handles btnSenden.Click
        SendMessage()
    End Sub

    Public Sub addMessage(msg As Message)
        Dim isOwn = False
        If msg.user IsNot Nothing Then
            isOwn = msg.user.id = NetworkClass.login.id
        End If

        ChatPanel.VerticalScroll.Value = ChatPanel.VerticalScroll.Minimum



        Dim messagecontrol As New MessageControl(msg, isOwn)
        messagecontrol.Top = messagecontrol.Height * ChatPanel.Controls.Count
        messagecontrol.Width = 0.8 * ChatPanel.Width
        If isOwn Then
            messagecontrol.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            messagecontrol.Left = ChatPanel.Width - messagecontrol.Width

        End If

        ChatPanel.Controls.Add(messagecontrol)

        ChatPanel.ScrollControlIntoView(messagecontrol)
    End Sub
    Private blockNewMessage = False
    Private Sub SendMessage()
        If Not blockNewMessage Then
            If txtEingabe.Text.ToLower = "ttt" Then
                TicTacToe.isInitiator = True
                TicTacToe.opponentId = Chat.user.id
                TicTacToe.Show()

                txtEingabe.Clear()
            ElseIf txtEingabe.Text.Length > 500 Then
                MsgBox("Deine Eingabe darf maximal 500 Zeichen lang sein!")
            ElseIf txtEingabe.Text.Trim().Length Then

                NetworkClass.net.SendMessage(NetworkClass.login.id, selectedChat.ID, txtEingabe.Text.Trim())
                txtEingabe.Clear()

                blockNewMessage = True
                btnSenden.Enabled = False
                chatTimer.Start()

            End If
        End If
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
        Dim msg = MsgBox("Diesen Chat wirklich für immer entfernen?", vbYesNo, "Chat wirklich entfernen?")
        If msg = vbYes Then
            NetworkClass.net.deleteChat(selectedChat.ID, NetworkClass.login.id, Chat.user.id)
        End If

    End Sub

    Private Sub chatTimer_Tick(sender As Object, e As EventArgs) Handles chatTimer.Tick

        btnSenden.Enabled = True
        btnSenden.Text = "Senden"
        blockNewMessage = False
        chatTimer.Stop()
    End Sub

    Private Sub txtEingabe_TextChanged(sender As Object, e As EventArgs) Handles txtEingabe.TextChanged
        If txtEingabe.Text.Length > 500 Then
            btnSenden.Enabled = False
        ElseIf txtEingabe.Text.Trim().Length < 1 Then
            btnSenden.Enabled = False
        Else
            btnSenden.Enabled = True
        End If

    End Sub
End Class
