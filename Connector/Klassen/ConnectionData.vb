Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class ConnectionData
    Sub New(_type As String, _data As Dictionary(Of String, Object))
        Type = _type
        Data = _data
    End Sub


    Public Type As String
    Public Data As Dictionary(Of String, Object)


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
        Dim val
        Try
            val = DirectCast(formatter.Deserialize(M), ConnectionData)
        Catch e As SerializationException
            Console.WriteLine("Failed to serialize. Reason: " & e.Message)
            Throw
        End Try

        Return val

    End Function

End Class
