Public Class MessageControl
    Public msg As Message

    Public Sub New(msg_)
        msg = msg_
        Label1.Text = msg.Msg

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

End Class
