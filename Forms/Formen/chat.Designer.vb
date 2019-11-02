<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Chat
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
        Me.ltbKontakte.Location = New System.Drawing.Point(14, 24)
        Me.ltbKontakte.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ltbKontakte.Name = "ltbKontakte"
        Me.ltbKontakte.Size = New System.Drawing.Size(125, 303)
        Me.ltbKontakte.TabIndex = 0
        '
        'lblKontakte
        '
        Me.lblKontakte.AutoSize = True
        Me.lblKontakte.Location = New System.Drawing.Point(11, 9)
        Me.lblKontakte.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKontakte.Name = "lblKontakte"
        Me.lblKontakte.Size = New System.Drawing.Size(82, 13)
        Me.lblKontakte.TabIndex = 1
        Me.lblKontakte.Text = "Meine Kontakte"
        '
        'btnNeuerKontakt
        '
        Me.btnNeuerKontakt.Location = New System.Drawing.Point(14, 336)
        Me.btnNeuerKontakt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNeuerKontakt.Name = "btnNeuerKontakt"
        Me.btnNeuerKontakt.Size = New System.Drawing.Size(125, 19)
        Me.btnNeuerKontakt.TabIndex = 2
        Me.btnNeuerKontakt.Text = "+ Hinzufügen"
        Me.btnNeuerKontakt.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(270, 284)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(248, 20)
        Me.TextBox1.TabIndex = 3
        '
        'btnSenden
        '
        Me.btnSenden.Location = New System.Drawing.Point(535, 283)
        Me.btnSenden.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSenden.Name = "btnSenden"
        Me.btnSenden.Size = New System.Drawing.Size(56, 19)
        Me.btnSenden.TabIndex = 4
        Me.btnSenden.Text = "Senden"
        Me.btnSenden.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(270, 46)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(269, 212)
        Me.ListBox1.TabIndex = 5
        '
        'lblChatpartner
        '
        Me.lblChatpartner.AutoSize = True
        Me.lblChatpartner.Location = New System.Drawing.Point(295, 23)
        Me.lblChatpartner.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblChatpartner.Name = "lblChatpartner"
        Me.lblChatpartner.Size = New System.Drawing.Size(62, 13)
        Me.lblChatpartner.TabIndex = 6
        Me.lblChatpartner.Text = "Chatpartner"
        '
        'Chat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.lblChatpartner)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnSenden)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnNeuerKontakt)
        Me.Controls.Add(Me.lblKontakte)
        Me.Controls.Add(Me.ltbKontakte)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Chat"
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
