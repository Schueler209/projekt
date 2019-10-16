Imports System.Net.Sockets



Module Module1
    Private connect As NetServer = New NetServer
    Public Sub Main()
    End Sub

    Public Sub register(name As String, username As String, password As String)

        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim reader As OleDb.OleDbDataReader
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" & "C:\Users\Marten\Source\Repos\projekt\Server\databaseuser.mdb" 'Mit Datenbank verbindung aufbauen
        reader = cmd.ExecuteReader
        con.Open() 'Verbindung aufbauen
        cmd = New OleDb.OleDbCommand("INSERT INTO databaseuser values('" & name & "','" & username & "','" & password & "')", con) 'Eingabe von den Daten in Datenbank
        con.Close() 'Verbindung schließen
    End Sub

    Public Sub logincheck()
        'Daten von Leo
        'Verbindung mit databaseuser
        'Daten überprüfen und bestätigen/Fehlermeldung




    End Sub
End Module