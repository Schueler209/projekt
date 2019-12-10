Imports System.Data.OleDb
Imports System.Net.Sockets
Imports Connector
Imports Server.dbTableAdapters

Module Module1

    Private ReadOnly ConnectionStr = "provider= microsoft.jet.oledb.4.0;data source=db.mdb;"

    Public Sub Main()
        ' Verbindungsobjekt erstellen und EventHandler hinzufügen
        Dim connect As NetServer = New NetServer With {
            .OnRegister = AddressOf Register,
            .OnLogin = AddressOf CheckLogin,
            .OnNewChat = AddressOf AddFriend,
            .OnUserlist = AddressOf GetAllUsers,
            .OnChats = AddressOf GetFriends,
            .OnMessages = AddressOf getMessages,
            .OnSendMessage = AddressOf AddMessage,
            .OnSettings = AddressOf changeName,
            .OnDeleteChat = AddressOf deletechat
 }

        connect.connect()

    End Sub

    ' Benutzerverwaltung

    Public Function Register(name As String, username As String, password As String) As User

        Dim conn As New OleDbConnection(ConnectionStr)
        conn.Open()

        Dim checkCommand As New OleDbCommand("select * from users where Username = '" & username & "'")
        checkCommand.Connection = conn
        Dim reader = checkCommand.ExecuteReader
        If reader.HasRows Then
            Return Nothing
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
            Return New User(username, name, command.ExecuteScalar())

        End If
    End Function


    Public Function CheckLogin(username As String, password As String) As User
        Dim reader = ReaderQuery("SELECT ID, [name] FROM Users WHERE Username = '" & username & "'And [Password] = '" & password & "'")
        If reader.HasRows Then
            reader.Read()
            Return New User(username, reader.GetString(1), reader.GetInt32(0))
        Else
            Return Nothing
        End If
    End Function

    ' Freunde/Chatverwaltung

    Public Function GetAllUsers(id As Integer) As User()
        Dim ignore As Integer() = getFriendIDs(id).Concat({id}).ToArray()
        Return getAll(ignore)
    End Function
    Public Function AddFriend(ID As Integer, ID2 As Integer) As Chat

        If areFriends(ID, ID2) Then
            Return Nothing
        Else
            Dim conn As New OleDbConnection(ConnectionStr)
            conn.Open()

            Dim insertCommand As New OleDbCommand("INSERT INTO Chats (UserID1, UserID2, Datum) VALUES (@UserID1,@UserID2,@Date);")
            insertCommand.Connection = conn
            insertCommand.Parameters.Add("@UserID1", OleDbType.Char).Value = ID
            insertCommand.Parameters.Add("@UserID2", OleDbType.Char).Value = ID2
            insertCommand.Parameters.Add("@Date", OleDbType.Date).Value = DateTime.Now
            insertCommand.CommandType = CommandType.Text
            Try
                insertCommand.ExecuteNonQuery()


            Catch ex As Exception
                Console.WriteLine(ex.Message)
                Return Nothing
            End Try
            Dim command As New OleDbCommand("SELECT @@IDENTITY")
            command.Connection = conn

            Return New Chat(command.ExecuteScalar(), getUser(ID2), DateTime.Now)
        End If
    End Function

    Public Function GetFriends(ID As Integer) As Chat()
        Return getChats(ID)
    End Function

    Public Function AddMessage(UserID As Integer, ChatID As Integer, Message As String) As Tuple(Of Message, Integer())

        Dim conn As New OleDbConnection(ConnectionStr)
        conn.Open()

        Dim insertcommand As New OleDbCommand("INSERT INTO Messages (ChatID, UserID, Message, Datum) VALUES (@ChatID, @UserID, @Message, @Datum);")
        insertcommand.Connection = conn
        insertcommand.Parameters.Add("@ChatID", OleDbType.Integer).Value = ChatID
        insertcommand.Parameters.Add("@UserID", OleDbType.Integer).Value = UserID
        insertcommand.Parameters.Add("@Message", OleDbType.Char).Value = Message
        insertcommand.Parameters.Add("@Datum", OleDbType.Date).Value = Date.Now
        insertcommand.CommandType = CommandType.Text

        Try
            insertcommand.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return Nothing
        End Try

        Dim msg As New Message(getUser(UserID), ChatID, Date.Now, Message)

        Dim recievers As Integer() = {getFriendID(UserID, ChatID)}

        Return New Tuple(Of Message, Integer())(msg, recievers)
    End Function

    Public Function getMessages(ChatID As Integer) As Message()

        Dim conn As New OleDbConnection(ConnectionStr)
        conn.Open()
        Dim reader = ReaderQuery("SELECT Message, Datum, UserID FROM Messages WHERE ChatID = " & ChatID)
        Dim messages As New List(Of Message)
        Do While reader.Read
            Dim msg As New Message(getUser(reader.GetInt32(2)), ChatID, reader.GetDateTime(1), reader.GetString(0))
            messages.Add(msg)
        Loop
        Return messages.ToArray()
    End Function


    'Namen ändern
    Public Function changeName(ID As Integer, NewName As String) As Boolean
        Dim conn As New OleDbConnection(ConnectionStr)
        conn.Open()
        Dim updatecommand As New OleDbCommand("UPDATE Users SET Name = '" & NewName & "'" & " WHERE ID = " & ID & "")
        updatecommand.Connection = conn

        Try
            updatecommand.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return False
        End Try
        Return True

    End Function

    'Chat löschen
    Public Function deletechat(chatID As Integer, UserID As Integer) As Integer
        Dim conn As New OleDbConnection(ConnectionStr)

        conn.Open()
        Dim deletecommand As New OleDbCommand("DELETE * FROM Chats WHERE ID = " & chatID)
        deletecommand.Connection = conn
        Try
            deletecommand.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return Nothing
        End Try
        conn.Close()
        Return chatID
    End Function
End Module