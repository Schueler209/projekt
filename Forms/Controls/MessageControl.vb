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
    End Sub
End Class
