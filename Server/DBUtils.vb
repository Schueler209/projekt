Imports System.Data.OleDb
Imports Connector

Module DBUtils

    Private ReadOnly ConnectionStr = "provider= microsoft.jet.oledb.4.0;data source=db.mdb;"

    Public Function getUser(ID As Integer) As User
        Dim conn As New OleDbConnection(ConnectionStr)
        Dim command As New OleDbCommand("SELECT username, [name] FROM Users WHERE ID = @id")
        command.Parameters.Add("@id", OleDbType.Integer).Value = ID
        command.Connection = conn
        conn.Open()
        Dim reader = command.ExecuteReader
        If reader.HasRows Then
            reader.Read()
            Return New User(reader.GetString(0), reader.GetString(1), ID)
        Else
            Return Nothing
        End If
    End Function

    Public Function getFriends(ID As Integer) As User()
        Dim conn As New OleDbConnection(ConnectionStr)
        conn.Open()
        Dim command As New OleDbCommand("SELECT UserID2 FROM Friendship WHERE UserID1 =" & ID.ToString())
        command.Connection = conn
        Dim reader = command.ExecuteReader
        Dim friendlist As New List(Of User)
        Do While reader.Read
            friendlist.Add(getUser(reader.GetInt32(0)))
        Loop
        reader.Close()
        command.CommandText = "SELECT UserID1 FROM Friendship WHERE UserID2 =" + ID.ToString()
        reader = command.ExecuteReader()
        Do While reader.Read
            friendlist.Add(getUser(reader.GetInt32(0)))
        Loop
        Return friendlist.ToArray()
    End Function



End Module
