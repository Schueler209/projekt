<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txbBenutzername
        '
        Me.txbBenutzername.Location = New System.Drawing.Point(83, 110)
        Me.txbBenutzername.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txbBenutzername.Name = "txbBenutzername"
        Me.txbBenutzername.Size = New System.Drawing.Size(103, 20)
        Me.txbBenutzername.TabIndex = 0
        '
        'txbPasswort
        '
        Me.txbPasswort.Location = New System.Drawing.Point(82, 205)
        Me.txbPasswort.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txbPasswort.Name = "txbPasswort"
        Me.txbPasswort.Size = New System.Drawing.Size(104, 20)
        Me.txbPasswort.TabIndex = 1
        '
        'lblBenutzername
        '
        Me.lblBenutzername.AutoSize = True
        Me.lblBenutzername.Location = New System.Drawing.Point(80, 75)
        Me.lblBenutzername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBenutzername.Name = "lblBenutzername"
        Me.lblBenutzername.Size = New System.Drawing.Size(75, 13)
        Me.lblBenutzername.TabIndex = 2
        Me.lblBenutzername.Text = "Benutzername"
        '
        'lblPasswort
        '
        Me.lblPasswort.AutoSize = True
        Me.lblPasswort.Location = New System.Drawing.Point(80, 172)
        Me.lblPasswort.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPasswort.Name = "lblPasswort"
        Me.lblPasswort.Size = New System.Drawing.Size(50, 13)
        Me.lblPasswort.TabIndex = 3
        Me.lblPasswort.Text = "Passwort"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLogin.Location = New System.Drawing.Point(82, 269)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(130, 43)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnZumRegistrieren
        '
        Me.btnZumRegistrieren.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnZumRegistrieren.Location = New System.Drawing.Point(82, 330)
        Me.btnZumRegistrieren.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnZumRegistrieren.Name = "btnZumRegistrieren"
        Me.btnZumRegistrieren.Size = New System.Drawing.Size(129, 43)
        Me.btnZumRegistrieren.TabIndex = 5
        Me.btnZumRegistrieren.Text = "Zum Registrieren"
        Me.btnZumRegistrieren.UseVisualStyleBackColor = False
        '
        'lblFehler
        '
        Me.lblFehler.AutoSize = True
        Me.lblFehler.Location = New System.Drawing.Point(85, 330)
        Me.lblFehler.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFehler.Name = "lblFehler"
        Me.lblFehler.Size = New System.Drawing.Size(0, 13)
        Me.lblFehler.TabIndex = 6
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(158, 22)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(53, 20)
        Me.lblLogin.TabIndex = 7
        Me.lblLogin.Text = "Login"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(354, 447)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.lblFehler)
        Me.Controls.Add(Me.btnZumRegistrieren)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblPasswort)
        Me.Controls.Add(Me.lblBenutzername)
        Me.Controls.Add(Me.txbPasswort)
        Me.Controls.Add(Me.txbBenutzername)
        Me.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "LoginForm"
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
    Friend WithEvents lblLogin As Label
End Class
