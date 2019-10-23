<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chat
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ltbKontakte = New System.Windows.Forms.ListBox()
        Me.lblKontakte = New System.Windows.Forms.Label()
        Me.btnNeuerKontakt = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnSenden = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblChatpartner = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ltbKontakte
        '
        Me.ltbKontakte.FormattingEnabled = True
        Me.ltbKontakte.ItemHeight = 16
        Me.ltbKontakte.Location = New System.Drawing.Point(88, 48)
        Me.ltbKontakte.Name = "ltbKontakte"
        Me.ltbKontakte.Size = New System.Drawing.Size(120, 324)
        Me.ltbKontakte.TabIndex = 0
        '
        'lblKontakte
        '
        Me.lblKontakte.AutoSize = True
        Me.lblKontakte.Location = New System.Drawing.Point(85, 19)
        Me.lblKontakte.Name = "lblKontakte"
        Me.lblKontakte.Size = New System.Drawing.Size(146, 17)
        Me.lblKontakte.TabIndex = 1
        Me.lblKontakte.Text = "Meine Kontakte/Chats"
        '
        'btnNeuerKontakt
        '
        Me.btnNeuerKontakt.Location = New System.Drawing.Point(88, 403)
        Me.btnNeuerKontakt.Name = "btnNeuerKontakt"
        Me.btnNeuerKontakt.Size = New System.Drawing.Size(118, 23)
        Me.btnNeuerKontakt.TabIndex = 2
        Me.btnNeuerKontakt.Text = "Neuer Kontakt"
        Me.btnNeuerKontakt.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(360, 349)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(329, 22)
        Me.TextBox1.TabIndex = 3
        '
        'btnSenden
        '
        Me.btnSenden.Location = New System.Drawing.Point(713, 348)
        Me.btnSenden.Name = "btnSenden"
        Me.btnSenden.Size = New System.Drawing.Size(75, 23)
        Me.btnSenden.TabIndex = 4
        Me.btnSenden.Text = "Senden"
        Me.btnSenden.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(360, 57)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(357, 260)
        Me.ListBox1.TabIndex = 5
        '
        'lblChatpartner
        '
        Me.lblChatpartner.AutoSize = True
        Me.lblChatpartner.Location = New System.Drawing.Point(393, 28)
        Me.lblChatpartner.Name = "lblChatpartner"
        Me.lblChatpartner.Size = New System.Drawing.Size(83, 17)
        Me.lblChatpartner.TabIndex = 6
        Me.lblChatpartner.Text = "Chatpartner"
        '
        'chat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblChatpartner)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnSenden)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnNeuerKontakt)
        Me.Controls.Add(Me.lblKontakte)
        Me.Controls.Add(Me.ltbKontakte)
        Me.Name = "chat"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ltbKontakte As ListBox
    Friend WithEvents lblKontakte As Label
    Friend WithEvents btnNeuerKontakt As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnSenden As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lblChatpartner As Label
End Class
