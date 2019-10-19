Imports System.Net.Sockets

Public Class NetServer

    Private connector As ServerConnector

    Sub New()
    End Sub

    ' Erstellt neue Instanz und verbindet sich
    Public Sub connect()
        connector = New ServerConnector()
        ' Einkommende Nachricht handeln
        connector.OnRecieve.addHandler(AddressOf onRequest)
        connector.connect()
    End Sub

    ' Event für Registrierung Neue Methode zuweisen!
    Public OnRegister As Action(Of String, String, String, Action(Of Boolean))
    ' Event für login Neue Methode zuweisen!
    Public OnLogin As Action(Of String, String, Action(Of Boolean))
    Public OnUserlist As Action(Of Action(Of String()))

    ' Falls neue Nachricht kommt:
    Private Sub onRequest(req As ConnectionData, client As TcpClient)
        ' Welcher Typ ist die Nachricht?
        Select Case req.Type
            Case "register"
                If OnRegister IsNot Nothing Then
                    ' Argumente bekommen
                    Dim name As String = req.Data.Item("name")
                    Dim username As String = req.Data.Item("username")
                    Dim password As String = req.Data.Item("password")
                    ' Methode aufrufen + Callback 
                    OnRegister(
                        name,
                        username,
                        password,
                        Sub(val As Boolean)
                            RegisterConfirm(val, client)
                        End Sub
                    )
                End If
            Case "login"
                If OnRegister IsNot Nothing Then
                    ' Argumente bekommen
                    Dim username As String = req.Data.Item("username")
                    Dim password As String = req.Data.Item("password")
                    ' Methode aufrufen + Callback 
                    OnLogin(
                        username,
                        password,
                        Sub(val As Boolean)
                            LoginConfirm(val, client)
                        End Sub
                    )
                End If

            Case "all users"
                If OnUserlist IsNot Nothing Then
                    OnUserlist(
                    Sub(val As String())

                    End Sub)
                End If




        End Select

    End Sub

    ' Sende Antwort für Registrieren
    Sub RegisterConfirm(res As Boolean, client As TcpClient)
        Dim data As New Dictionary(Of String, Object)
        data.Add("success", res)
        Dim req As New ConnectionData("registerconfirm", data)
        connector.send(client, req)
    End Sub
    ' Sende Antwort für Login
    Sub LoginConfirm(res As Boolean, client As TcpClient)
        Dim data As New Dictionary(Of String, Object)
        data.Add("success", res)
        Dim req As New ConnectionData("loginconfirm", data)
        connector.send(client, req)
    End Sub

    Sub AllUsersSend(ans As String(), client As TcpClient)
        Dim data As New Dictionary(Of String, Object)
        data.add("All users", ans)
        connector.send(client, data)
    End Sub
End Class
