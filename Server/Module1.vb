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
            .OnSettings = AddressOf changeSettings,
            .OnDeleteChat = AddressOf deletechat
 }

        connect.connect()

    End Sub

    ' Benutzerverwaltung

    Public Function Register(name As String, username As String, password As String, colour As Integer) As User

        Dim conn As New OleDbConnection(ConnectionStr)
        conn.Open()

        Dim checkCommand As New OleDbCommand("select * from users where Username = '" & username & "'")
        checkCommand.Connection = conn

        Dim reader = checkCommand.ExecuteReader
        If reader IsNot Nothing Then
            If reader.HasRows Then
                Return Nothing
            Else
                Dim insertCommand As New OleDbCommand("INSERT INTO Users ([Name],Username,[Password],Colour) VALUES (@displayname,@username,@password,@colour); ")
                Dim command As New OleDbCommand("SELECT @@IDENTITY")
                insertCommand.Connection = conn
                insertCommand.Parameters.Add("@displayname", OleDbType.Char).Value = name
                insertCommand.Parameters.Add("@username", OleDbType.Char).Value = username
                insertCommand.Parameters.Add("@password", OleDbType.Char).Value = password
                insertCommand.Parameters.Add("@colour", OleDbType.Char).Value = colour
                insertCommand.CommandType = CommandType.Text
                insertCommand.ExecuteNonQuery()
                command.Connection = conn
                Return New User(username, name, command.ExecuteScalar(), colour)
            End If
        End If
    End Function


    Public Function CheckLogin(username As String, password As String) As User
        Dim reader = ReaderQuery("SELECT ID, [name], Colour FROM Users WHERE Username = '" & username & "'And [Password] = '" & password & "'")
        If reader IsNot Nothing Then
            If reader.HasRows Then
                reader.Read()
                Return New User(username, reader.GetString(1), reader.GetInt32(0), reader.GetInt32(2))
            Else
                Return Nothing
            End If
        End If
    End Function

    ' Freunde/Chatverwaltung

    Public Function GetAllUsers(id As Integer) As User()
        Dim ignore As Integer() = getFriendIDs(id).Concat({id}).ToArray()
        Return getAll(ignore)
    End Function
    'Chats erstellen
    Public Function AddFriend(ID As Integer, ID2 As Integer) As Chat

        If areFriends(ID, ID2) Then
            Return Nothing
        Else
            Dim conn As New OleDbConnection(ConnectionStr)
            conn.Open()

            Dim insertCommand As New OleDbCommand("INSERT INTO Chats (UserID1, UserID2, Datum) VALUES (@UserID1,@UserID2,@Date)")
            insertCommand.Connection = conn
            insertCommand.Parameters.Add("@UserID1", OleDbType.Integer).Value = ID
            insertCommand.Parameters.Add("@UserID2", OleDbType.Integer).Value = ID2
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
            Console.WriteLine(ID2)

            Dim user As User = getUser(ID2)

            If user Is Nothing Then
                Return Nothing
            End If

            Return New Chat(command.ExecuteScalar(), user, DateTime.Now)

        End If
    End Function

    Public Function GetFriends(ID As Integer) As Chat()
        Return getChats(ID)
    End Function
    'Nachricht schicken
    Public Function AddMessage(UserID As Integer, ChatID As Integer, Message As String) As Tuple(Of Message, Integer())
        Try
            Dim conn As New OleDbConnection(ConnectionStr)
        conn.Open()

        Dim insertcommand As New OleDbCommand("INSERT INTO Messages (ChatID, UserID, Message, Datum) VALUES (@ChatID, @UserID, @Message, @Datum);")
        insertcommand.Connection = conn
        insertcommand.Parameters.Add("@ChatID", OleDbType.Integer).Value = ChatID
        insertcommand.Parameters.Add("@UserID", OleDbType.Integer).Value = UserID
        insertcommand.Parameters.Add("@Message", OleDbType.Char).Value = Message
        insertcommand.Parameters.Add("@Datum", OleDbType.Date).Value = Date.Now
        insertcommand.CommandType = CommandType.Text

            insertcommand.ExecuteNonQuery()

            Dim updatecommand As New OleDbCommand("UPDATE Chats SET Datum = '" & Date.Now & "'" & " WHERE ID = " & ChatID & "")
            updatecommand.Connection = conn
        updatecommand.ExecuteNonQuery()
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
        If reader IsNot Nothing Then
            Dim messages As New List(Of Message)
            Do While reader.Read
                Dim msg As New Message(getUser(reader.GetInt32(2)), ChatID, reader.GetDateTime(1), reader.GetString(0))
                messages.Add(msg)
            Loop
            Return messages.ToArray()
        End If
    End Function


    'Namen ändern
    Public Function changeSettings(ID As Integer, NewName As String, Password As String, NewPassword As String, Colour As Integer) As Boolean

        Dim reader = ReaderQuery("SELECT ID FROM Users WHERE ID = " & ID & " And [Password] = '" & Password & "'")
        If reader IsNot Nothing Then
            If reader.HasRows Then

                If NewPassword = "" Then
                    NewPassword = Password
                End If

                Dim conn As New OleDbConnection(ConnectionStr)
                conn.Open()
                Dim updatecommand As New OleDbCommand("UPDATE Users SET Name = '" & NewName & "', [Password] = '" & NewPassword & "', Colour = '" & Colour & "' WHERE ID = " & ID & "")
                updatecommand.Connection = conn
                Try
                    updatecommand.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                    Return False
                End Try
                Return True
            Else
                Return False
            End If
        End If




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
        Return chatID
    End Function
End Module