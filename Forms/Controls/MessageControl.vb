Imports Connector
Public Class MessageControl
    Public msg As Message

    Public Sub New(msg_)

        msg = msg_


        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Private Sub MessageControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = msg.message
    End Sub
End Class
