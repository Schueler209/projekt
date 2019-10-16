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


    Sub Serialize(stream As Stream)

        Dim formatter As New BinaryFormatter

        Try
            formatter.Serialize(stream, Me)
        Catch e As SerializationException
            Console.WriteLine("Failed to serialize. Reason: " & e.Message)
        Finally
            stream.Close()
        End Try

    End Sub
    Shared Function Serialized(stream As Stream) As ConnectionData

        Dim formatter As New BinaryFormatter
        Dim val
        Try
            val = DirectCast(formatter.Deserialize(stream), ConnectionData)
        Catch e As SerializationException
            Console.WriteLine("Failed to serialize. Reason: " & e.Message)
            Throw
        Finally
            stream.Close()

        End Try

        Return val

    End Function

End Class
