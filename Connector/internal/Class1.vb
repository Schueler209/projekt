Imports Microsoft.VisualBasic

Public Class Class1

    Private connector As ClientConnector = New ClientConnector()
    Public Sub sendRegister(benutzername As String, passwort As String)
        'Als function die wenn positive rückmeldung von server kriegt als rückgabewert bestätigung gibt
        'laura dann if besagte function = bestätigt then registrierung erfolgreich
        connector.send(zusammenschreiben(benutzername, passwort))


    End Sub







    Public Function zusammenschreiben(ByVal benutzername As String, ByVal passwort As String) As String
        'Benutzername und Passwort als ein String zum versenden
        'x vorweg damit man weiss wieviele zeichen benutzername hat und wo passwort beginnt
        Dim x As Integer
        x = benutzername.Length
        zusammenschreiben = x & benutzername & passwort
    End Function


    Public Sub trennen(ByVal zusammengeschrieben)
        '2 Rückgabewerte: Benutzername, Passwort, wie umsetzen?



    End Sub
End Class

