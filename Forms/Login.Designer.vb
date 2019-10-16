<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.txbBenutzername = New System.Windows.Forms.TextBox()
        Me.txbPasswort = New System.Windows.Forms.TextBox()
        Me.lblBenutzername = New System.Windows.Forms.Label()
        Me.lblPasswort = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnZumRegistrieren = New System.Windows.Forms.Button()
        Me.lblFehler = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txbBenutzername
        '
        Me.txbBenutzername.Location = New System.Drawing.Point(113, 101)
        Me.txbBenutzername.Name = "txbBenutzername"
        Me.txbBenutzername.Size = New System.Drawing.Size(136, 22)
        Me.txbBenutzername.TabIndex = 0
        '
        'txbPasswort
        '
        Me.txbPasswort.Location = New System.Drawing.Point(112, 288)
        Me.txbPasswort.Name = "txbPasswort"
        Me.txbPasswort.Size = New System.Drawing.Size(137, 22)
        Me.txbPasswort.TabIndex = 1
        '
        'lblBenutzername
        '
        Me.lblBenutzername.AutoSize = True
        Me.lblBenutzername.Location = New System.Drawing.Point(113, 59)
        Me.lblBenutzername.Name = "lblBenutzername"
        Me.lblBenutzername.Size = New System.Drawing.Size(100, 17)
        Me.lblBenutzername.TabIndex = 2
        Me.lblBenutzername.Text = "Benutzername"
        '
        'lblPasswort
        '
        Me.lblPasswort.AutoSize = True
        Me.lblPasswort.Location = New System.Drawing.Point(110, 246)
        Me.lblPasswort.Name = "lblPasswort"
        Me.lblPasswort.Size = New System.Drawing.Size(65, 17)
        Me.lblPasswort.TabIndex = 3
        Me.lblPasswort.Text = "Passwort"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(656, 83)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(139, 40)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnZumRegistrieren
        '
        Me.btnZumRegistrieren.Location = New System.Drawing.Point(643, 288)
        Me.btnZumRegistrieren.Name = "btnZumRegistrieren"
        Me.btnZumRegistrieren.Size = New System.Drawing.Size(168, 53)
        Me.btnZumRegistrieren.TabIndex = 5
        Me.btnZumRegistrieren.Text = "Zum Registrieren"
        Me.btnZumRegistrieren.UseVisualStyleBackColor = True
        '
        'lblFehler
        '
        Me.lblFehler.AutoSize = True
        Me.lblFehler.Location = New System.Drawing.Point(110, 357)
        Me.lblFehler.Name = "lblFehler"
        Me.lblFehler.Size = New System.Drawing.Size(102, 17)
        Me.lblFehler.TabIndex = 6
        Me.lblFehler.Text = "Fehlermeldung"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 550)
        Me.Controls.Add(Me.lblFehler)
        Me.Controls.Add(Me.btnZumRegistrieren)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblPasswort)
        Me.Controls.Add(Me.lblBenutzername)
        Me.Controls.Add(Me.txbPasswort)
        Me.Controls.Add(Me.txbBenutzername)
        Me.Name = "Login"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txbBenutzername As TextBox
    Friend WithEvents txbPasswort As TextBox
    Friend WithEvents lblBenutzername As Label
    Friend WithEvents lblPasswort As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnZumRegistrieren As Button
    Friend WithEvents lblFehler As Label
End Class
