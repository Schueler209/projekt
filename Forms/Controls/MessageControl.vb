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
        Label2.Text = msg.user.name & ":"
        If isOwn Then
            Label1.BackColor = Color.DarkSeaGreen
        Else Label1.BackColor = Color.LightBlue


        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
