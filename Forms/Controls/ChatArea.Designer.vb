<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChatArea
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblChatpartner = New System.Windows.Forms.Label()
        Me.btnSenden = New System.Windows.Forms.Button()
        Me.txtEingabe = New System.Windows.Forms.TextBox()
        Me.ChatScrollPanel = New System.Windows.Forms.Panel()
        Me.ChatPanel = New System.Windows.Forms.Panel()
        Me.btnKonaktEntfernen = New System.Windows.Forms.Button()
        Me.chatTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ChatScrollPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblChatpartner
        '
        Me.lblChatpartner.AutoSize = True
        Me.lblChatpartner.Location = New System.Drawing.Point(15, 10)
        Me.lblChatpartner.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblChatpartner.Name = "lblChatpartner"
        Me.lblChatpartner.Size = New System.Drawing.Size(62, 13)
        Me.lblChatpartner.TabIndex = 10
        Me.lblChatpartner.Text = "Chatpartner"
        '
        'btnSenden
        '
        Me.btnSenden.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSenden.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnSenden.Location = New System.Drawing.Point(448, 259)
        Me.btnSenden.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSenden.Name = "btnSenden"
        Me.btnSenden.Size = New System.Drawing.Size(86, 30)
        Me.btnSenden.TabIndex = 8
        Me.btnSenden.Text = "Senden"
        Me.btnSenden.UseVisualStyleBackColor = False
        '
        'txtEingabe
        '
        Me.txtEingabe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEingabe.Location = New System.Drawing.Point(18, 259)
        Me.txtEingabe.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEingabe.Multiline = True
        Me.txtEingabe.Name = "txtEingabe"
        Me.txtEingabe.Size = New System.Drawing.Size(426, 28)
        Me.txtEingabe.TabIndex = 7
        '
        'ChatScrollPanel
        '
        Me.ChatScrollPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChatScrollPanel.AutoScroll = True
        Me.ChatScrollPanel.Controls.Add(Me.ChatPanel)
        Me.ChatScrollPanel.Location = New System.Drawing.Point(18, 26)
        Me.ChatScrollPanel.Name = "ChatScrollPanel"
        Me.ChatScrollPanel.Size = New System.Drawing.Size(516, 228)
        Me.ChatScrollPanel.TabIndex = 11
        '
        'ChatPanel
        '
        Me.ChatPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChatPanel.AutoScroll = True
        Me.ChatPanel.Location = New System.Drawing.Point(0, 0)
        Me.ChatPanel.Name = "ChatPanel"
        Me.ChatPanel.Size = New System.Drawing.Size(516, 228)
        Me.ChatPanel.TabIndex = 0
        '
        'btnKonaktEntfernen
        '
        Me.btnKonaktEntfernen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKonaktEntfernen.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnKonaktEntfernen.FlatAppearance.BorderSize = 0
        Me.btnKonaktEntfernen.Location = New System.Drawing.Point(448, 0)
        Me.btnKonaktEntfernen.Name = "btnKonaktEntfernen"
        Me.btnKonaktEntfernen.Size = New System.Drawing.Size(86, 23)
        Me.btnKonaktEntfernen.TabIndex = 12
        Me.btnKonaktEntfernen.Text = "Entfernen"
        Me.btnKonaktEntfernen.UseVisualStyleBackColor = False
        '
        'chatTimer
        '
        Me.chatTimer.Interval = 1000
        '
        'ChatArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.btnKonaktEntfernen)
        Me.Controls.Add(Me.ChatScrollPanel)
        Me.Controls.Add(Me.lblChatpartner)
        Me.Controls.Add(Me.btnSenden)
        Me.Controls.Add(Me.txtEingabe)
        Me.Name = "ChatArea"
        Me.Size = New System.Drawing.Size(554, 303)
        Me.ChatScrollPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblChatpartner As Label
    Friend WithEvents btnSenden As Button
    Friend WithEvents txtEingabe As TextBox
    Friend WithEvents ChatScrollPanel As Panel
    Friend WithEvents ChatPanel As Panel
    Friend WithEvents btnKonaktEntfernen As Button
    Friend WithEvents chatTimer As Timer
End Class
