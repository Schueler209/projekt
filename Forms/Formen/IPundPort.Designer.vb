<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IPundPort
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
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtIp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdSpeichernundLaden = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(328, 68)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(100, 20)
        Me.txtPort.TabIndex = 14
        '
        'txtIp
        '
        Me.txtIp.Location = New System.Drawing.Point(99, 68)
        Me.txtIp.Name = "txtIp"
        Me.txtIp.Size = New System.Drawing.Size(100, 20)
        Me.txtIp.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(249, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Port:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "IP:"
        '
        'cmdSpeichernundLaden
        '
        Me.cmdSpeichernundLaden.Location = New System.Drawing.Point(196, 121)
        Me.cmdSpeichernundLaden.Name = "cmdSpeichernundLaden"
        Me.cmdSpeichernundLaden.Size = New System.Drawing.Size(94, 40)
        Me.cmdSpeichernundLaden.TabIndex = 15
        Me.cmdSpeichernundLaden.Text = "Verbinden"
        Me.cmdSpeichernundLaden.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(10, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(454, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Es scheint ein Verbindungsfehler aufgetreten zu sein. Bitte überprüfe deine Serve" &
    "reinstellungen"
        '
        'IPundPort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 173)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdSpeichernundLaden)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.txtIp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "IPundPort"
        Me.Text = "IPundPort"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPort As TextBox
    Friend WithEvents txtIp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdSpeichernundLaden As Button
    Friend WithEvents Label2 As Label
End Class
