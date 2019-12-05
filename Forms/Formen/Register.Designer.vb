<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.txbAnzeigename = New System.Windows.Forms.TextBox()
        Me.txbBenutzername = New System.Windows.Forms.TextBox()
        Me.txbPasswort = New System.Windows.Forms.TextBox()
        Me.txbPasswortWdh = New System.Windows.Forms.TextBox()
        Me.lblAnzeigename = New System.Windows.Forms.Label()
        Me.lblBenutzername = New System.Windows.Forms.Label()
        Me.lblFehlermeldung = New System.Windows.Forms.Label()
        Me.lblPasswort = New System.Windows.Forms.Label()
        Me.lblPasswortWdh = New System.Windows.Forms.Label()
        Me.btnRegistrieren = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txbAnzeigename
        '
        Me.txbAnzeigename.Location = New System.Drawing.Point(50, 93)
        Me.txbAnzeigename.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txbAnzeigename.Name = "txbAnzeigename"
        Me.txbAnzeigename.Size = New System.Drawing.Size(76, 20)
        Me.txbAnzeigename.TabIndex = 0
        '
        'txbBenutzername
        '
        Me.txbBenutzername.Location = New System.Drawing.Point(50, 195)
        Me.txbBenutzername.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txbBenutzername.Name = "txbBenutzername"
        Me.txbBenutzername.Size = New System.Drawing.Size(76, 20)
        Me.txbBenutzername.TabIndex = 1
        '
        'txbPasswort
        '
        Me.txbPasswort.Location = New System.Drawing.Point(50, 289)
        Me.txbPasswort.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txbPasswort.Name = "txbPasswort"
        Me.txbPasswort.Size = New System.Drawing.Size(76, 20)
        Me.txbPasswort.TabIndex = 2
        '
        'txbPasswortWdh
        '
        Me.txbPasswortWdh.Location = New System.Drawing.Point(50, 387)
        Me.txbPasswortWdh.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txbPasswortWdh.Name = "txbPasswortWdh"
        Me.txbPasswortWdh.Size = New System.Drawing.Size(76, 20)
        Me.txbPasswortWdh.TabIndex = 3
        '
        'lblAnzeigename
        '
        Me.lblAnzeigename.AutoSize = True
        Me.lblAnzeigename.Location = New System.Drawing.Point(47, 54)
        Me.lblAnzeigename.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAnzeigename.Name = "lblAnzeigename"
        Me.lblAnzeigename.Size = New System.Drawing.Size(71, 13)
        Me.lblAnzeigename.TabIndex = 4
        Me.lblAnzeigename.Text = "Anzeigename"
        '
        'lblBenutzername
        '
        Me.lblBenutzername.AutoSize = True
        Me.lblBenutzername.Location = New System.Drawing.Point(47, 150)
        Me.lblBenutzername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBenutzername.Name = "lblBenutzername"
        Me.lblBenutzername.Size = New System.Drawing.Size(75, 13)
        Me.lblBenutzername.TabIndex = 5
        Me.lblBenutzername.Text = "Benutzername"
        '
        'lblFehlermeldung
        '
        Me.lblFehlermeldung.AutoSize = True
        Me.lblFehlermeldung.Location = New System.Drawing.Point(118, 341)
        Me.lblFehlermeldung.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFehlermeldung.Name = "lblFehlermeldung"
        Me.lblFehlermeldung.Size = New System.Drawing.Size(0, 13)
        Me.lblFehlermeldung.TabIndex = 6
        '
        'lblPasswort
        '
        Me.lblPasswort.AutoSize = True
        Me.lblPasswort.Location = New System.Drawing.Point(51, 248)
        Me.lblPasswort.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPasswort.Name = "lblPasswort"
        Me.lblPasswort.Size = New System.Drawing.Size(50, 13)
        Me.lblPasswort.TabIndex = 7
        Me.lblPasswort.Text = "Passwort"
        '
        'lblPasswortWdh
        '
        Me.lblPasswortWdh.AutoSize = True
        Me.lblPasswortWdh.Location = New System.Drawing.Point(47, 341)
        Me.lblPasswortWdh.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPasswortWdh.Name = "lblPasswortWdh"
        Me.lblPasswortWdh.Size = New System.Drawing.Size(113, 13)
        Me.lblPasswortWdh.TabIndex = 8
        Me.lblPasswortWdh.Text = "Passwort Wiederholen"
        '
        'btnRegistrieren
        '
        Me.btnRegistrieren.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnRegistrieren.Location = New System.Drawing.Point(211, 305)
        Me.btnRegistrieren.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRegistrieren.Name = "btnRegistrieren"
        Me.btnRegistrieren.Size = New System.Drawing.Size(91, 49)
        Me.btnRegistrieren.TabIndex = 9
        Me.btnRegistrieren.Text = "Registrieren"
        Me.btnRegistrieren.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnLogin.Location = New System.Drawing.Point(211, 180)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(91, 49)
        Me.btnLogin.TabIndex = 10
        Me.btnLogin.Text = "zum Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblRegister
        '
        Me.lblRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegister.Location = New System.Drawing.Point(174, 9)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(80, 30)
        Me.lblRegister.TabIndex = 11
        Me.lblRegister.Text = "Register"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(445, 450)
        Me.Controls.Add(Me.lblRegister)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnRegistrieren)
        Me.Controls.Add(Me.lblPasswortWdh)
        Me.Controls.Add(Me.lblPasswort)
        Me.Controls.Add(Me.lblFehlermeldung)
        Me.Controls.Add(Me.lblBenutzername)
        Me.Controls.Add(Me.lblAnzeigename)
        Me.Controls.Add(Me.txbPasswortWdh)
        Me.Controls.Add(Me.txbPasswort)
        Me.Controls.Add(Me.txbBenutzername)
        Me.Controls.Add(Me.txbAnzeigename)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txbAnzeigename As TextBox
    Friend WithEvents txbBenutzername As TextBox
    Friend WithEvents txbPasswort As TextBox
    Friend WithEvents txbPasswortWdh As TextBox
    Friend WithEvents lblAnzeigename As Label
    Friend WithEvents lblBenutzername As Label
    Friend WithEvents lblFehlermeldung As Label
    Friend WithEvents lblPasswort As Label
    Friend WithEvents lblPasswortWdh As Label
    Friend WithEvents btnRegistrieren As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblRegister As Label
End Class
