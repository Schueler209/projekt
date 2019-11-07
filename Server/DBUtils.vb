Imports System.Data.OleDb
Imports Connector

Module DBUtils
    Private ReadOnly ConnectionStr = "provider= microsoft.jet.oledb.4.0;data source=db.mdb;"

    Public Function ReaderQuery(Query As String) As OleDbDataReader
        Dim conn As New OleDbConnection(ConnectionStr)
        Dim command As New OleDbCommand(Query)
        command.Connection = conn
        conn.Open()
        Return command.ExecuteReader
    End Function


    Public Function getUser(ID As Integer) As User
        Dim reader = ReaderQuery("SELECT username, [name] FROM Users WHERE ID = " + ID.ToString())
        If reader.HasRows Then
            reader.Read()
            Return New User(reader.GetString(0), reader.GetString(1), ID)
        Else
            Return Nothing
        End If
    End Function

    Public Function getFriendIDs(ID As Integer) As Integer()
        Dim reader = ReaderQuery("SELECT UserID1, UserID2 FROM Chats WHERE UserID1 =" & ID & "OR UserID2 =" & ID) ' & " ORDER BY Datum")
        Dim friendlist As New List(Of Integer)
        Do While reader.Read
            Dim friendID As Integer = reader.GetInt32(0)
            If friendID = ID Then
                friendID = reader.GetInt32(1)
            End If
            Console.WriteLine(friendID)
            friendlist.Add(friendID)
        Loop
        Return friendlist.ToArray()
    End Function

    Public Function getChats(ID As Integer) As User()
        Return getFriendIDs(ID).Select(Function(x) getUser(x)).ToArray()
    End Function

    Public Function getAll(exept As Integer()) As User()
        Dim reader = ReaderQuery("SELECT ID ,username, [name] FROM Users")
        Dim userlist As New List(Of User)
        Do While reader.Read
            Dim id As Integer = reader.GetInt32(0)
            ' Nehme nur die, die nicht in der Ausnahmeliste stehen
            If Not exept.Contains(id) Then
                userlist.Add(New User(reader.GetString(1), reader.GetString(2), id))
            End If
        Loop
        Return userlist.ToArray()
    End Function


End Module
