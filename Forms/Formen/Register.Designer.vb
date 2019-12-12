<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
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
        Me.txbAnzeigename = New System.Windows.Forms.TextBox()
        Me.txbBenutzername = New System.Windows.Forms.TextBox()
        Me.txbPasswort = New System.Windows.Forms.TextBox()
        Me.txbPasswortWdh = New System.Windows.Forms.TextBox()
        Me.lblAnzeigename = New System.Windows.Forms.Label()
        Me.lblBenutzername = New System.Windows.Forms.Label()
        Me.lblPasswort = New System.Windows.Forms.Label()
        Me.lblPasswortWdh = New System.Windows.Forms.Label()
        Me.btnRegistrieren = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.lblFehler = New System.Windows.Forms.Label()
        Me.checkKeepLoggedIn = New System.Windows.Forms.CheckBox()
        Me.Profilfarbe1 = New Forms.profilfarbe()
        Me.SuspendLayout()
        '
        'txbAnzeigename
        '
        Me.txbAnzeigename.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txbAnzeigename.Location = New System.Drawing.Point(54, 117)
        Me.txbAnzeigename.Margin = New System.Windows.Forms.Padding(2)
        Me.txbAnzeigename.Name = "txbAnzeigename"
        Me.txbAnzeigename.Size = New System.Drawing.Size(158, 20)
        Me.txbAnzeigename.TabIndex = 0
        '
        'txbBenutzername
        '
        Me.txbBenutzername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txbBenutzername.Location = New System.Drawing.Point(54, 166)
        Me.txbBenutzername.Margin = New System.Windows.Forms.Padding(2)
        Me.txbBenutzername.Name = "txbBenutzername"
        Me.txbBenutzername.Size = New System.Drawing.Size(158, 20)
        Me.txbBenutzername.TabIndex = 1
        '
        'txbPasswort
        '
        Me.txbPasswort.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txbPasswort.Location = New System.Drawing.Point(54, 215)
        Me.txbPasswort.Margin = New System.Windows.Forms.Padding(2)
        Me.txbPasswort.Name = "txbPasswort"
        Me.txbPasswort.Size = New System.Drawing.Size(158, 20)
        Me.txbPasswort.TabIndex = 2
        '
        'txbPasswortWdh
        '
        Me.txbPasswortWdh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txbPasswortWdh.Location = New System.Drawing.Point(54, 264)
        Me.txbPasswortWdh.Margin = New System.Windows.Forms.Padding(20)
        Me.txbPasswortWdh.Name = "txbPasswortWdh"
        Me.txbPasswortWdh.Size = New System.Drawing.Size(158, 20)
        Me.txbPasswortWdh.TabIndex = 3
        '
        'lblAnzeigename
        '
        Me.lblAnzeigename.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAnzeigename.AutoSize = True
        Me.lblAnzeigename.Location = New System.Drawing.Point(51, 102)
        Me.lblAnzeigename.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAnzeigename.Name = "lblAnzeigename"
        Me.lblAnzeigename.Size = New System.Drawing.Size(102, 13)
        Me.lblAnzeigename.TabIndex = 4
        Me.lblAnzeigename.Text = "Vor- und Nachname"
        '
        'lblBenutzername
        '
        Me.lblBenutzername.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBenutzername.AutoSize = True
        Me.lblBenutzername.Location = New System.Drawing.Point(51, 151)
        Me.lblBenutzername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBenutzername.Name = "lblBenutzername"
        Me.lblBenutzername.Size = New System.Drawing.Size(75, 13)
        Me.lblBenutzername.TabIndex = 5
        Me.lblBenutzername.Text = "Benutzername"
        '
        'lblPasswort
        '
        Me.lblPasswort.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPasswort.AutoSize = True
        Me.lblPasswort.Location = New System.Drawing.Point(51, 200)
        Me.lblPasswort.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPasswort.Name = "lblPasswort"
        Me.lblPasswort.Size = New System.Drawing.Size(50, 13)
        Me.lblPasswort.TabIndex = 7
        Me.lblPasswort.Text = "Passwort"
        '
        'lblPasswortWdh
        '
        Me.lblPasswortWdh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPasswortWdh.AutoSize = True
        Me.lblPasswortWdh.Location = New System.Drawing.Point(51, 249)
        Me.lblPasswortWdh.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPasswortWdh.Name = "lblPasswortWdh"
        Me.lblPasswortWdh.Size = New System.Drawing.Size(113, 13)
        Me.lblPasswortWdh.TabIndex = 8
        Me.lblPasswortWdh.Text = "Passwort Wiederholen"
        '
        'btnRegistrieren
        '
        Me.btnRegistrieren.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegistrieren.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnRegistrieren.Location = New System.Drawing.Point(24, 406)
        Me.btnRegistrieren.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegistrieren.Name = "btnRegistrieren"
        Me.btnRegistrieren.Size = New System.Drawing.Size(228, 38)
        Me.btnRegistrieren.TabIndex = 9
        Me.btnRegistrieren.Text = "Registrieren"
        Me.btnRegistrieren.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogin.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLogin.Location = New System.Drawing.Point(50, 448)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(172, 29)
        Me.btnLogin.TabIndex = 10
        Me.btnLogin.Text = "doch einloggen?"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblRegister
        '
        Me.lblRegister.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegister.Location = New System.Drawing.Point(50, 27)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(172, 30)
        Me.lblRegister.TabIndex = 11
        Me.lblRegister.Text = "Registrierung"
        Me.lblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFehler
        '
        Me.lblFehler.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFehler.Location = New System.Drawing.Point(24, 370)
        Me.lblFehler.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFehler.Name = "lblFehler"
        Me.lblFehler.Size = New System.Drawing.Size(228, 27)
        Me.lblFehler.TabIndex = 12
        Me.lblFehler.Text = "lblFehler"
        Me.lblFehler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'checkKeepLoggedIn
        '
        Me.checkKeepLoggedIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.checkKeepLoggedIn.AutoSize = True
        Me.checkKeepLoggedIn.Checked = True
        Me.checkKeepLoggedIn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkKeepLoggedIn.Location = New System.Drawing.Point(54, 350)
        Me.checkKeepLoggedIn.Name = "checkKeepLoggedIn"
        Me.checkKeepLoggedIn.Size = New System.Drawing.Size(119, 17)
        Me.checkKeepLoggedIn.TabIndex = 13
        Me.checkKeepLoggedIn.Text = "Angemeldet bleiben"
        Me.checkKeepLoggedIn.UseVisualStyleBackColor = True
        '
        'Profilfarbe1
        '
        Me.Profilfarbe1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Profilfarbe1.Location = New System.Drawing.Point(2, 307)
        Me.Profilfarbe1.Name = "Profilfarbe1"
        Me.Profilfarbe1.Size = New System.Drawing.Size(259, 30)
        Me.Profilfarbe1.TabIndex = 14
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(273, 495)
        Me.Controls.Add(Me.Profilfarbe1)
        Me.Controls.Add(Me.checkKeepLoggedIn)
        Me.Controls.Add(Me.lblFehler)
        Me.Controls.Add(Me.lblRegister)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnRegistrieren)
        Me.Controls.Add(Me.lblPasswortWdh)
        Me.Controls.Add(Me.lblPasswort)
        Me.Controls.Add(Me.lblBenutzername)
        Me.Controls.Add(Me.lblAnzeigename)
        Me.Controls.Add(Me.txbPasswortWdh)
        Me.Controls.Add(Me.txbPasswort)
        Me.Controls.Add(Me.txbBenutzername)
        Me.Controls.Add(Me.txbAnzeigename)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(230, 406)
        Me.Name = "Register"
        Me.Text = "Registrierung"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txbAnzeigename As TextBox
    Friend WithEvents txbBenutzername As TextBox
    Friend WithEvents txbPasswort As TextBox
    Friend WithEvents txbPasswortWdh As TextBox
    Friend WithEvents lblAnzeigename As Label
    Friend WithEvents lblBenutzername As Label
    Friend WithEvents lblPasswort As Label
    Friend WithEvents lblPasswortWdh As Label
    Friend WithEvents btnRegistrieren As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblRegister As Label
    Friend WithEvents lblFehler As Label
    Friend WithEvents checkKeepLoggedIn As CheckBox
    Friend WithEvents Profilfarbe1 As profilfarbe
End Class
