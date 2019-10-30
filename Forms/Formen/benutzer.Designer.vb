<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class benutzer
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
        Me.ltbAlleBesucher = New System.Windows.Forms.ListBox()
        Me.txbBenutzerSuchen = New System.Windows.Forms.TextBox()
        Me.btnSuchen = New System.Windows.Forms.Button()
        Me.btnZuKontakte = New System.Windows.Forms.Button()
        Me.lblBenutzerSuchen = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ltbAlleBesucher
        '
        Me.ltbAlleBesucher.FormattingEnabled = True
        Me.ltbAlleBesucher.ItemHeight = 16
        Me.ltbAlleBesucher.Location = New System.Drawing.Point(155, 102)
        Me.ltbAlleBesucher.Name = "ltbAlleBesucher"
        Me.ltbAlleBesucher.Size = New System.Drawing.Size(245, 308)
        Me.ltbAlleBesucher.TabIndex = 0
        '
        'txbBenutzerSuchen
        '
        Me.txbBenutzerSuchen.Location = New System.Drawing.Point(155, 49)
        Me.txbBenutzerSuchen.Name = "txbBenutzerSuchen"
        Me.txbBenutzerSuchen.Size = New System.Drawing.Size(245, 22)
        Me.txbBenutzerSuchen.TabIndex = 1
        '
        'btnSuchen
        '
        Me.btnSuchen.Location = New System.Drawing.Point(572, 38)
        Me.btnSuchen.Name = "btnSuchen"
        Me.btnSuchen.Size = New System.Drawing.Size(75, 23)
        Me.btnSuchen.TabIndex = 2
        Me.btnSuchen.Text = "Suchen "
        Me.btnSuchen.UseVisualStyleBackColor = True
        '
        'btnZuKontakte
        '
        Me.btnZuKontakte.Location = New System.Drawing.Point(572, 360)
        Me.btnZuKontakte.Name = "btnZuKontakte"
        Me.btnZuKontakte.Size = New System.Drawing.Size(152, 23)
        Me.btnZuKontakte.TabIndex = 3
        Me.btnZuKontakte.Text = "Zu den Kontakten"
        Me.btnZuKontakte.UseVisualStyleBackColor = True
        '
        'lblBenutzerSuchen
        '
        Me.lblBenutzerSuchen.AutoSize = True
        Me.lblBenutzerSuchen.Location = New System.Drawing.Point(285, 9)
        Me.lblBenutzerSuchen.Name = "lblBenutzerSuchen"
        Me.lblBenutzerSuchen.Size = New System.Drawing.Size(115, 17)
        Me.lblBenutzerSuchen.TabIndex = 4
        Me.lblBenutzerSuchen.Text = "Benutzer suchen"
        '
        'benutzer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblBenutzerSuchen)
        Me.Controls.Add(Me.btnZuKontakte)
        Me.Controls.Add(Me.btnSuchen)
        Me.Controls.Add(Me.txbBenutzerSuchen)
        Me.Controls.Add(Me.ltbAlleBesucher)
        Me.Name = "benutzer"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ltbAlleBesucher As ListBox
    Friend WithEvents txbBenutzerSuchen As TextBox
    Friend WithEvents btnSuchen As Button
    Friend WithEvents btnZuKontakte As Button
    Friend WithEvents lblBenutzerSuchen As Label
End Class
