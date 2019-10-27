Imports System.Data.OleDb
Imports System.Net.Sockets
Imports Connector
Imports Server.dbTableAdapters

Module Module1

    Public Sub Main()

        Dim connect As NetServer = New NetServer
        connect.OnRegister = AddressOf register
        connect.connect()
        'register("Till", "Till1234", "123", Sub(g As Boolean)
        '                                    End Sub)
    End Sub

    Public Sub register(name As String, username As String, password As String, done As Action(Of Boolean))
        Dim connString As String = "provider= microsoft.jet.oledb.4.0; " & "data source=db.mdb;" & ""
        Dim conn As New OleDbConnection(connString)
        Dim command As New OleDbCommand("INSERT INTO Users ([Name],Username,[Password]) VALUES (@displayname,@username,@password);")
        command.Connection = conn
        command.Parameters.Add("@displayname", OleDbType.Char).Value = name
        command.Parameters.Add("@username", OleDbType.Char).Value = username
        command.Parameters.Add("@password", OleDbType.Char).Value = password

        command.CommandType = CommandType.Text
        command.CommandText = "select * from users where Username = '" & username & "'"
        conn.Open()
        Dim reader = command.ExecuteReader
        If reader.HasRows Then
            done(False)
            conn.Close()
        Else
            Try
                conn.Close()
                conn.Open()
                command.ExecuteNonQuery()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            Finally
                done(True)
            End Try
        End If
    End Sub

    Public Sub logincheck(username As String, password As String, done As Action(Of Boolean))

        Dim connString As String = "provider= microsoft.jet.oledb.4.0; " & "data source=db.mdb;" & ""
        Dim conn As New OleDbConnection(connString)
        Dim command As New OleDbCommand()
        command.Connection = conn

        command.CommandType = CommandType.Text
        command.CommandText = "select * from users where Username = '" & username & "'" And "select * from users where Password = '" & password & "'"
        conn.Open()
        Dim reader = command.ExecuteReader
        If reader.HasRows Then
            done(True)
            conn.Close()
        Else
            done(False)
            conn.Close()
        End If
    End Sub

End Module