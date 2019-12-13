Public Class profilfarbe


    Public Property SelectedColour As Integer
        Get
            If btn1.Checked Then
                Return 1
            End If
            If btn2.Checked Then
                Return 2
            End If
            If btn3.Checked Then
                Return 3
            End If
            If btn4.Checked Then
                Return 4
            End If
            Return 5
        End Get
        Set(value As Integer)
            Select Case value
                Case 1
                    btn1.Checked = True
                Case 2
                    btn2.Checked = True
                Case 3
                    btn3.Checked = True
                Case 4
                    btn4.Checked = True
                Case 5
                    btn5.Checked = True
            End Select
        End Set
    End Property

    Private Sub profilfarbe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn1.ForeColor = ColorTranslator.FromHtml("#73D4EC")
        btn2.ForeColor = ColorTranslator.FromHtml("#FFD87D")
        btn3.ForeColor = ColorTranslator.FromHtml("#FF7DA4")
        btn4.ForeColor = ColorTranslator.FromHtml("#56B0A2")
        btn5.ForeColor = ColorTranslator.FromHtml("#9BEB6F")

    End Sub
End Class
