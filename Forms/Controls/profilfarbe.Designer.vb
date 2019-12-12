<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class profilfarbe
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
        Me.btn1 = New System.Windows.Forms.RadioButton()
        Me.btn4 = New System.Windows.Forms.RadioButton()
        Me.btn3 = New System.Windows.Forms.RadioButton()
        Me.btn2 = New System.Windows.Forms.RadioButton()
        Me.btn5 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn1.AutoSize = True
        Me.btn1.Checked = True
        Me.btn1.ForeColor = System.Drawing.Color.Blue
        Me.btn1.Location = New System.Drawing.Point(7, 17)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(45, 17)
        Me.btn1.TabIndex = 23
        Me.btn1.TabStop = True
        Me.btn1.Text = "██"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn4.AutoSize = True
        Me.btn4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn4.Location = New System.Drawing.Point(160, 17)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(45, 17)
        Me.btn4.TabIndex = 22
        Me.btn4.Text = "██"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn3.AutoSize = True
        Me.btn3.ForeColor = System.Drawing.Color.Red
        Me.btn3.Location = New System.Drawing.Point(109, 17)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(45, 17)
        Me.btn3.TabIndex = 21
        Me.btn3.Text = "██"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn2.AutoSize = True
        Me.btn2.ForeColor = System.Drawing.Color.Yellow
        Me.btn2.Location = New System.Drawing.Point(58, 17)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(45, 17)
        Me.btn2.TabIndex = 20
        Me.btn2.Text = "██"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn5.AutoSize = True
        Me.btn5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn5.Location = New System.Drawing.Point(211, 17)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(45, 17)
        Me.btn5.TabIndex = 19
        Me.btn5.Text = "██"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Wähle deine persönliche Farbe:"
        '
        'profilfarbe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn5)
        Me.Name = "profilfarbe"
        Me.Size = New System.Drawing.Size(259, 40)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn1 As RadioButton
    Friend WithEvents btn4 As RadioButton
    Friend WithEvents btn3 As RadioButton
    Friend WithEvents btn2 As RadioButton
    Friend WithEvents btn5 As RadioButton
    Friend WithEvents Label1 As Label
End Class
