Imports Connector
Public Class TicTacToeMessage

    Private Sub MessageControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.BackColor = ColorTranslator.FromHtml("#C5D1D8")
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        TicTacToe.Show()
        Me.Hide()
    End Sub
End Class
