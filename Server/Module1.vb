Imports System.Net.Sockets
Imports Connector
Module Module1

    Public Sub Main()
        Dim connect As NetServer = New NetServer
        connect.OnRegister = AddressOf register
        connect.connect()
    End Sub

    Public Sub register(name As String, username As String, password As String, done As Action(Of Boolean))

        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim reader As OleDb.OleDbDataReader
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" & "C:\Users\Marten\Source\Repos\projekt\Server\databaseuser.mdb" 'Mit Datenbank verbindung aufbauen
        reader = cmd.ExecuteReader
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * databaseuser ='" & username & "' "
        reader = cmd.ExecuteReader
        If reader.HasRows Then
            done(False)
            Console.WriteLine("Hallo")
            con.Close()
        Else
            con.Close()
            con.Open() 'Verbindung aufbauen
            cmd = New OleDb.OleDbCommand("INSERT INTO databaseuser values('" & name & "','" & username & "','" & password & "')", con) 'Eingabe von den Daten in Datenbank
            con.Close() 'Verbindung schließen
            done(True)
        End If
    End Sub

    Public Sub logincheck()

        'Verbindung aufbauen

        'Verbindung mit databaseuser
        'Daten überprüfen und bestätigen/Fehlermeldung




    End Sub
End Module