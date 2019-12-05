<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Chats
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
        Me.btnNeuerKontakt = New System.Windows.Forms.Button()
        Me.lblKontakte = New System.Windows.Forms.Label()
        Me.ltbKontakte = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AbmeldenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.AbmeldenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactPanel = New System.Windows.Forms.Panel()
        Me.ChatArea = New Forms.ChatArea()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.ContactPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNeuerKontakt
        '
        Me.btnNeuerKontakt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnNeuerKontakt.Location = New System.Drawing.Point(34, 411)
        Me.btnNeuerKontakt.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNeuerKontakt.Name = "btnNeuerKontakt"
        Me.btnNeuerKontakt.Size = New System.Drawing.Size(125, 28)
        Me.btnNeuerKontakt.TabIndex = 12
        Me.btnNeuerKontakt.Text = "+ Hinzufügen"
        Me.btnNeuerKontakt.UseVisualStyleBackColor = False
        '
        'lblKontakte
        '
        Me.lblKontakte.AutoSize = True
        Me.lblKontakte.Location = New System.Drawing.Point(11, 6)
        Me.lblKontakte.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKontakte.Name = "lblKontakte"
        Me.lblKontakte.Size = New System.Drawing.Size(66, 13)
        Me.lblKontakte.TabIndex = 11
        Me.lblKontakte.Text = "Meine Chats"
        '
        'ltbKontakte
        '
        Me.ltbKontakte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ltbKontakte.FormattingEnabled = True
        Me.ltbKontakte.Location = New System.Drawing.Point(11, 21)
        Me.ltbKontakte.Margin = New System.Windows.Forms.Padding(2)
        Me.ltbKontakte.Name = "ltbKontakte"
        Me.ltbKontakte.Size = New System.Drawing.Size(128, 303)
        Me.ltbKontakte.TabIndex = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbmeldenToolStripMenuItem, Me.EinstellungenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(690, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AbmeldenToolStripMenuItem
        '
        Me.AbmeldenToolStripMenuItem.Name = "AbmeldenToolStripMenuItem"
        Me.AbmeldenToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.AbmeldenToolStripMenuItem.Text = "Abmelden"
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.EinstellungenToolStripMenuItem.Text = "Einstellungen"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbmeldenToolStripMenuItem1, Me.EinstellungenToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(690, 24)
        Me.MenuStrip2.TabIndex = 15
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'AbmeldenToolStripMenuItem1
        '
        Me.AbmeldenToolStripMenuItem1.Name = "AbmeldenToolStripMenuItem1"
        Me.AbmeldenToolStripMenuItem1.Size = New System.Drawing.Size(74, 20)
        Me.AbmeldenToolStripMenuItem1.Text = "Abmelden"
        '
        'EinstellungenToolStripMenuItem1
        '
        Me.EinstellungenToolStripMenuItem1.Name = "EinstellungenToolStripMenuItem1"
        Me.EinstellungenToolStripMenuItem1.Size = New System.Drawing.Size(90, 20)
        Me.EinstellungenToolStripMenuItem1.Text = "Einstellungen"
        '
        'ContactPanel
        '
        Me.ContactPanel.Controls.Add(Me.ltbKontakte)
        Me.ContactPanel.Controls.Add(Me.lblKontakte)
        Me.ContactPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.ContactPanel.Location = New System.Drawing.Point(0, 24)
        Me.ContactPanel.Name = "ContactPanel"
        Me.ContactPanel.Size = New System.Drawing.Size(152, 339)
        Me.ContactPanel.TabIndex = 16
        '
        'ChatArea
        '
        Me.ChatArea.AutoSize = True
        Me.ChatArea.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ChatArea.BackColor = System.Drawing.SystemColors.Control
        Me.ChatArea.Chat = Nothing
        Me.ChatArea.Dock = System.Windows.Forms.DockStyle.Right
        Me.ChatArea.Location = New System.Drawing.Point(263, 24)
        Me.ChatArea.Name = "ChatArea"
        Me.ChatArea.Size = New System.Drawing.Size(427, 339)
        Me.ChatArea.TabIndex = 14
        '
        'Chats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 363)
        Me.Controls.Add(Me.ContactPanel)
        Me.Controls.Add(Me.ChatArea)
        Me.Controls.Add(Me.btnNeuerKontakt)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip2
        Me.MinimumSize = New System.Drawing.Size(500, 300)
        Me.Name = "Chats"
        Me.Text = "Chats"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ContactPanel.ResumeLayout(False)
        Me.ContactPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChatArea As ChatArea
    Friend WithEvents btnNeuerKontakt As Button
    Friend WithEvents lblKontakte As Label
    Friend WithEvents ltbKontakte As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EinstellungenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbmeldenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents AbmeldenToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EinstellungenToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContactPanel As Panel
End Class
