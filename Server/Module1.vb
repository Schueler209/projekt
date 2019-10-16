Module Module1

    Public Sub Main()
    End Sub
    Public Sub register(name As String, password As String,username As String)

      Dim con As New OleDb.OleDbConnection 
      Dim cmd As New OleDb.OleDbCommand 
      Dim reader As OleDb.OleDbDataReader 
      con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" & "C:\Users\Marten\Source\Repos\projekt\Server\databaseuser.mdb"
      cmd.Connection = con
      cmd.CommandType = CommandType.Text
      reader = cmd.ExecuteReader

                con.Open()
                cmd = New SqlCommand("INSERT INTO databaseuser values('" & username & "','" & name & "','" & password & "')", con)
                  con.Close()
    End Sub 


    Public Sub logincheck()
        'Daten von Leo
        'Verbindung mit databaseuser
        'Daten überprüfen und bestätigen/Fehlermeldung




    End Sub
End Module