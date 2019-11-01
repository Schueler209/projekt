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
        Me.ltbAlleBenutzer = New System.Windows.Forms.ListBox()
        Me.txbBenutzerSuchen = New System.Windows.Forms.TextBox()
        Me.btnZuKontakte = New System.Windows.Forms.Button()
        Me.lblBenutzerSuchen = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ltbAlleBenutzer
        '
        Me.ltbAlleBenutzer.FormattingEnabled = True
        Me.ltbAlleBenutzer.Location = New System.Drawing.Point(116, 83)
        Me.ltbAlleBenutzer.Margin = New System.Windows.Forms.Padding(2)
        Me.ltbAlleBenutzer.Name = "ltbAlleBenutzer"
        Me.ltbAlleBenutzer.Size = New System.Drawing.Size(185, 251)
        Me.ltbAlleBenutzer.TabIndex = 0
        '
        'txbBenutzerSuchen
        '
        Me.txbBenutzerSuchen.Location = New System.Drawing.Point(116, 40)
        Me.txbBenutzerSuchen.Margin = New System.Windows.Forms.Padding(2)
        Me.txbBenutzerSuchen.Name = "txbBenutzerSuchen"
        Me.txbBenutzerSuchen.Size = New System.Drawing.Size(185, 20)
        Me.txbBenutzerSuchen.TabIndex = 1
        '
        'btnZuKontakte
        '
        Me.btnZuKontakte.Location = New System.Drawing.Point(429, 292)
        Me.btnZuKontakte.Margin = New System.Windows.Forms.Padding(2)
        Me.btnZuKontakte.Name = "btnZuKontakte"
        Me.btnZuKontakte.Size = New System.Drawing.Size(114, 19)
        Me.btnZuKontakte.TabIndex = 3
        Me.btnZuKontakte.Text = "Zu den Kontakten"
        Me.btnZuKontakte.UseVisualStyleBackColor = True
        '
        'lblBenutzerSuchen
        '
        Me.lblBenutzerSuchen.AutoSize = True
        Me.lblBenutzerSuchen.Location = New System.Drawing.Point(214, 7)
        Me.lblBenutzerSuchen.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBenutzerSuchen.Name = "lblBenutzerSuchen"
        Me.lblBenutzerSuchen.Size = New System.Drawing.Size(87, 13)
        Me.lblBenutzerSuchen.TabIndex = 4
        Me.lblBenutzerSuchen.Text = "Benutzer suchen"
        '
        'benutzer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.lblBenutzerSuchen)
        Me.Controls.Add(Me.btnZuKontakte)
        Me.Controls.Add(Me.txbBenutzerSuchen)
        Me.Controls.Add(Me.ltbAlleBenutzer)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "benutzer"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ltbAlleBenutzer As ListBox
    Friend WithEvents txbBenutzerSuchen As TextBox
    Friend WithEvents btnZuKontakte As Button
    Friend WithEvents lblBenutzerSuchen As Label
End Class
