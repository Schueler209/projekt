Imports Connector

Public Class TicTacToe

    Private values As Integer() = {0, 0, 1, 2, 2, 1, 0, 1, 0}
    Private buttons As Button()

    Public isInitiator As Boolean = False
    Public opponentId As Integer

    Private isTurn As Boolean = False

    Public ReadOnly Property FieldValue As Object
        Get
            Return If(isInitiator, 1, 2)
        End Get
    End Property

    Private Sub TicTacToe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NetworkClass.net.OnTTTUpdate = AddressOf onUpdate

        buttons = {Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9}
        displayValues()
        btnWiederholen.Hide()

        If isInitiator Then
            buttonGroup.Hide()
            lblOutput.Text = "Warte auf Mitspieler..."
            isTurn = True
            NetworkClass.net.sendTTTRequest(NetworkClass.login.id, opponentId)
        Else
            lblOutput.Text = "Warte auf Aktion..."

            Dim data As New TTTData(TTTType.RequestSuccess, values)
            NetworkClass.net.updateTTT(NetworkClass.login.id, opponentId, data)
        End If
    End Sub

    Private Sub onUpdate(user As Integer, data As TTTData)
        Select Case data.type
            Case TTTType.RequestSuccess
                lblOutput.Text = "Du darfst starten!"
                buttonGroup.Show()
            Case TTTType.Update
                isTurn = True
                values = data.state
                lblOutput.Text = "Du bist dran."
                displayValues()
            Case TTTType.Won
                lblOutput.Text = "Du hast leider verloren"

                buttonGroup.Hide()
                btnWiederholen.Show()
        End Select
    End Sub

    Private Sub displayValues()
        For i = 0 To 8
            Select Case values(i)
                Case 0
                    buttons(i).Text = ""
                Case 1
                    buttons(i).Text = "X"
                Case 2
                    buttons(i).Text = "O"
            End Select
        Next
    End Sub

    Private Sub ButtonClick(i As Integer)
        If isTurn Then
            If values(i) = 0 Then

                isTurn = False
                lblOutput.Text = "Warte auf Aktion..."

                values(i) = If(isInitiator, 1, 2)
                Dim data As New TTTData(TTTType.Update, values)
                NetworkClass.net.updateTTT(NetworkClass.login.id, opponentId, data)

                displayValues()
            End If
        End If

        Dim hasWon = False
        For i = 0 To 8 Step 3
            If values(i) = FieldValue And values(i + 1) = FieldValue And values(i + 2) = FieldValue Then
                hasWon = True
            End If
        Next

        For i = 0 To 2
            If values(i) = FieldValue And values(i + 3) = FieldValue And values(i + 6) = FieldValue Then
                hasWon = True
            End If
        Next

        If values(0) = FieldValue And values(4) = FieldValue And values(8) = FieldValue Then
            hasWon = True
        End If
        If values(2) = FieldValue And values(4) = FieldValue And values(6) = FieldValue Then
            hasWon = True
        End If

        If hasWon Then
            lblOutput.Text = "Du hast gewonnen!"

            Dim data As New TTTData(TTTType.Won, values)
            NetworkClass.net.updateTTT(NetworkClass.login.id, opponentId, data)

            buttonGroup.Hide()
            btnWiederholen.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ButtonClick(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ButtonClick(1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ButtonClick(2)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ButtonClick(3)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ButtonClick(4)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ButtonClick(5)
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ButtonClick(6)
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ButtonClick(7)
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ButtonClick(8)
    End Sub
End Class