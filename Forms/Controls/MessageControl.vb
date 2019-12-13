Imports Connector
Public Class MessageControl
    Public msg As Message
    Public isOwn As Boolean = False

    Public Sub New(msg_, isOwn_)

        msg = msg_
        isOwn = isOwn_


        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Private Sub MessageControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = msg.message

        If isOwn Then

            Label2.Text = ""
        Else

            Label2.Text = msg.user.name & ":"


        End If
        Select Case msg.user.colour
            Case 1
                Label1.BackColor = ColorTranslator.FromHtml("#73D4EC")
            Case 2
                Label1.BackColor = ColorTranslator.FromHtml("#FFD87D")
            Case 3
                Label1.BackColor = ColorTranslator.FromHtml("#FF7DA4")
            Case 4
                Label1.BackColor = ColorTranslator.FromHtml("#56B0A2")
            Case 5
                Label1.BackColor = ColorTranslator.FromHtml("#9BEB6F")
        End Select

    End Sub




End Class
