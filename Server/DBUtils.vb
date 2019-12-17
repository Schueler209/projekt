Imports System.Data.OleDb
Imports Connector

Module DBUtils
    Private ReadOnly ConnectionStr = "provider= microsoft.jet.oledb.4.0;data source=db.mdb;"

    Public Function ReaderQuery(Query As String) As OleDbDataReader
        Dim conn As New OleDbConnection(ConnectionStr)
        Dim command As New OleDbCommand(Query)
        Try
            command.Connection = conn
            conn.Open()
            Dim reader = command.ExecuteReader
            Return reader
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return Nothing
        End Try
        Return Nothing
    End Function


    Public Function getUser(ID As Integer) As User
        Dim reader = ReaderQuery("SELECT username, [name], Colour FROM Users WHERE ID = " + ID.ToString())
        If reader IsNot Nothing AndAlso reader.HasRows Then
            reader.Read()
            Return New User(reader.GetString(0), reader.GetString(1), ID, reader.GetInt32(2))
        Else
            Return Nothing
        End If
    End Function

    'Public Function getName(ID As Integer) As String
    '    Dim reader = ReaderQuery("SELECT [name] FROM Users WHERE ID =" & ID & "")
    '    If reader.HasRows Then
    '        reader.Read()
    '        Return reader.GetString(0)
    '    Else
    '        Return Nothing
    '    End If
    'End Function

    Public Function areFriends(ID1 As Integer, ID2 As Integer) As Boolean
        Dim reader = ReaderQuery("SELECT ID FROM Chats WHERE UserID1 =" & ID1.ToString() & "And UserID2 =" & ID2.ToString())
        If reader IsNot Nothing Then
            Return reader.HasRows
        Else
            Return Nothing
        End If
    End Function

    Public Function getFriendIDs(ID As Integer) As Integer()
        Dim reader = ReaderQuery("SELECT UserID1, UserID2 FROM Chats WHERE UserID1 = " & ID & " OR UserID2 = " & ID) ' & " ORDER BY Datum")
        If reader IsNot Nothing Then
            Dim friendlist As New List(Of Integer)
            Do While reader.Read
                Dim friendID As Integer = reader.GetInt32(0)
                If friendID = ID Then
                    friendID = reader.GetInt32(1)
                End If
                friendlist.Add(friendID)
            Loop
            reader.Close()
            Return friendlist.ToArray()
        Else
            reader.Close()
            Return {}
        End If

    End Function
    Public Function getFriendID(UserID As Integer, ChatID As Integer) As Integer
        Dim reader = ReaderQuery("SELECT UserID1, UserID2 FROM Chats WHERE ID = " & ChatID & " And (UserID1 = " & UserID & " OR UserID2 = " & UserID & ")")
        If reader IsNot Nothing AndAlso reader.HasRows Then
            reader.Read()
            Dim friendID As Integer = reader.GetInt32(0)
            If friendID = UserID Then
                friendID = reader.GetInt32(1)
            End If
            reader.Close()
            Return friendID
        End If
        reader.Close()
        Return Nothing
    End Function
    'Alle Chats auflisten
    Public Function getChats(ID As Integer) As Chat()
        Dim reader = ReaderQuery("SELECT ID, UserID1, UserID2, Datum FROM Chats WHERE UserID1 =" & ID & "OR UserID2 =" & ID & " ORDER BY Datum DESC;")
        Dim friendlist As New List(Of Chat)
        If reader IsNot Nothing Then
            Do While reader.Read
                Dim friendID As Integer = reader.GetInt32(1)
                If friendID = ID Then
                    friendID = reader.GetInt32(2)
                End If
                friendlist.Add(New Chat(reader.GetInt32(0), getUser(friendID), reader.GetDateTime(3)))
            Loop
            reader.Close()
            Return friendlist.ToArray()
        Else
            reader.Close()
            Return Nothing
        End If

    End Function

    Public Function getAll(exept As Integer()) As User()
        Dim reader = ReaderQuery("SELECT ID,username, [name], Colour FROM Users")
        If reader IsNot Nothing Then
            Dim userlist As New List(Of User)
            Do While reader.Read
                Dim id As Integer = reader.GetInt32(0)
                ' Nehme nur die, die nicht in der Ausnahmeliste stehen
                If Not exept.Contains(id) Then
                    userlist.Add(New User(reader.GetString(1), reader.GetString(2), id, reader.GetInt32(3)))
                End If
            Loop
            reader.Close()
            Return userlist.ToArray()
        Else
            reader.Close()
            Return Nothing
        End If
    End Function
End Module
