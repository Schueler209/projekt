Imports System.Data.OleDb
Imports System.Net.Sockets
'Imports connector
Imports Server.dbTableAdapters

Module Module1

    Public Sub Main()
        'Dim users As New usersTableAdapter
        'users.GetData().

        'Dim connect As NetServer = New NetServer
        'connect.OnRegister = AddressOf register
        'connect.connect()
        register("Till", "Till1234", "123", Sub(g As Boolean)
                                            End Sub)

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
        Dim reader = command.ExecuteReader
        If reader.HasRows Then
            done(False)
            conn.Close()
        Else
            Try
                conn.Open()
                command.ExecuteNonQuery()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            Finally
                done(True)
            End Try
        End If

        'Try



        '    con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Marten\Source\Repos\projekt\Server\databaseuser.mdb;Integrated Security=True"
        '    con.Open()
        '    cmd.Connection = con
        '    cmd.CommandType = CommandType.Text
        '    cmd.CommandText = "select * from databaseuser where username='" & username & "' "
        '    dr = cmd.ExecuteReader
        '    If dr.HasRows Then
        '        done(False)
        '        con.Close()
        '    Else
        '        con.Close()
        '        con.Open()
        '        cmd = New SqlCommand("INSERT INTO databaseuser values('" & name & "','" & username & "','" & password & "')", con)
        '        cmd.ExecuteNonQuery()
        '        done(True)
        '    End If
        '    con.Close()
        'Catch ex As Exception
        '    Console.WriteLine(ex.Message)
        '    MsgBox("Error")
        'End Try

        'Dim con As New OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim reader As OleDb.OleDbDataReader
        'con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" & "C:\Users\Marten\Source\Repos\projekt\Server\databaseuser.mdb" 'Mit Datenbank verbindung aufbauen
        'reader = cmd.ExecuteReader
        'cmd.Connection = con
        'cmd.CommandType = CommandType.Text
        ' cmd.CommandText = "select * databaseuser ='" & username & "' "
        'reader = cmd.ExecuteReader
        'If reader.HasRows Then
        '   done(False)
        '  Console.WriteLine("Hallo")
        ' con.Close()
        'Else
        '   con.Close()
        '  con.Open() 'Verbindung aufbauen
        ' cmd = New OleDb.OleDbCommand("INSERT INTO databaseuser values('" & name & "','" & username & "','" & password & "')", con) 'Eingabe von den Daten in Datenbank
        'con.Close() 'Verbindung schließen
        'done(True)
        'End If


    End Sub

    Public Sub logincheck(username As String, password As String, done As Action(Of Boolean))





    End Sub
End Module