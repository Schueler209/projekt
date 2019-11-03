Imports System.Data.OleDb
Imports System.Net.Sockets
Imports Connector
Imports Server.dbTableAdapters

Module Module1

    Private ReadOnly ConnectionStr = "provider= microsoft.jet.oledb.4.0;data source=db.mdb;"

    Public Sub Main()

        Dim connect As NetServer = New NetServer
        connect.OnRegister = AddressOf register
        connect.OnLogin = AddressOf logincheck
        connect.OnUserlist = AddressOf Userlist
        connect.connect()
        'register("Till", "Till1234", "123", Sub(g As Boolean)
        '                                    End Sub)
    End Sub

    Public Sub register(name As String, username As String, password As String, done As Action(Of Integer))
        Dim conn As New OleDbConnection(ConnectionStr)
        conn.Open()

        Dim checkCommand As New OleDbCommand("select * from users where Username = '" & username & "'")
        checkCommand.Connection = conn
        Dim reader = checkCommand.ExecuteReader
        If reader.HasRows Then
            done(Nothing)
        Else
            Dim insertCommand As New OleDbCommand("INSERT INTO Users ([Name],Username,[Password]) VALUES (@displayname,@username,@password); ")
            Dim command As New OleDbCommand("SELECT @@IDENTITY")
            insertCommand.Connection = conn
            insertCommand.Parameters.Add("@displayname", OleDbType.Char).Value = name
            insertCommand.Parameters.Add("@username", OleDbType.Char).Value = username
            insertCommand.Parameters.Add("@password", OleDbType.Char).Value = password
            insertCommand.CommandType = CommandType.Text
            insertCommand.ExecuteNonQuery()
            command.Connection = conn
            done(command.ExecuteScalar())

        End If
    End Sub

    Public Sub logincheck(username As String, password As String, done As Action(Of Integer))

        Dim conn As New OleDbConnection(ConnectionStr)
        Dim command As New OleDbCommand("SELECT ID FROM Users WHERE Username = '" & username & "'And [Password] = '" & password & "'")
        command.Connection = conn

        conn.Open()
        Dim reader = command.ExecuteReader
        If reader.HasRows Then
            reader.Read()
            done(reader.GetInt32(0))
        Else
            done(Nothing)
        End If
    End Sub

    'Public Function GetID(ByVal username As String, ByRef ID As Integer) As Boolean
    '    Dim success As Boolean = False
    '    Dim connString As String = "provider= microsoft.jet.oledb.4.0; " & "data source=db.mdb;" & ""
    '    Dim conn As New OleDbConnection(connString)
    '    Dim command As New OleDbCommand()
    '    command.Connection = conn
    '    command.CommandText = "SELECT ID FROM users WHERE Username = ? "

    '    command.Parameters.AddWithValue("?", username)
    '    conn.Open()
    '    Dim reader = command.ExecuteReader
    '    If reader.HasRows Then
    '        ID = reader.GetInt32(0)
    '        success = True
    '        conn.Close()
    '    Else
    '        success = False
    '        conn.Close()
    '    End If
    '    Return success
    'End Function

    'Public Sub addFriend(ID As Integer, ID2 As Integer)
    '    Dim conn As New OleDbConnection(ConnectionStr)
    '    conn.Open()

    '    Dim insertCommand As New OleDbCommand("INSERT INTO Friendship (UserID1, UserID2) VALUES (@displayname,@username,@password);")
    '    insertCommand.Connection = conn
    '        insertCommand.Parameters.Add("@displayname", OleDbType.Char).Value = name
    '    insertCommand.Parameters.Add("@username", OleDbType.Char).Value = username

    '    insertCommand.CommandType = CommandType.Text
    '        Try
    '            insertCommand.ExecuteNonQuery()
    '        Catch ex As Exception
    '            Console.WriteLine(ex.Message)
    '        Finally
    '            done(True)
    '        End Try
    '    End If

    'End Sub



    Public Sub Userlist(done As Action(Of String()))
        Dim conn As New OleDbConnection(ConnectionStr)
        conn.Open()
        Dim checkCommand As New OleDbCommand("SELECT username FROM users")
        checkCommand.Connection = conn
        Dim reader = checkCommand.ExecuteReader
        Dim userlist As New List(Of String)
        Do While reader.Read
            userlist.Add(reader.GetString(0))
        Loop
        done(userlist.ToArray)
    End Sub
End Module