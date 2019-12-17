Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Friend Class ConnectionData
    Sub New(_type As String)
        Type = _type
        Data = New Dictionary(Of String, Object)
    End Sub
    Sub New(_type As String, _data As Dictionary(Of String, Object))
        Type = _type
        Data = _data
    End Sub


    Public Type As String
    Public Data As Dictionary(Of String, Object)

    Public Sub addData(key As String, obj As Object)
        Data.Add(key, obj)
    End Sub


    Public Function getData(key As String) As Object
        Return Data.Item(key)
    End Function
    Public Function getData(Of T)(key As String) As Object
        Return CType(Data.Item(key), T)
    End Function


    Function Serialize() As Byte()
        Dim M As New MemoryStream
        Dim formatter As New BinaryFormatter

        Try
            formatter.Serialize(M, Me)
        Catch e As SerializationException
            Console.WriteLine("Failed to serialize. Reason: " & e.Message)
            Throw
        End Try
        Return M.ToArray()

    End Function
    Shared Function Serialized(bytes As Byte()) As ConnectionData
        Dim M As New MemoryStream(bytes, False)
        Dim formatter As New BinaryFormatter
        Dim val As ConnectionData = Nothing
        Try
            val = DirectCast(formatter.Deserialize(M), ConnectionData)
        Catch e As SerializationException
            Console.WriteLine("Failed to serialize. Reason: " & e.Message)

        End Try

        Return val

    End Function

End Class
