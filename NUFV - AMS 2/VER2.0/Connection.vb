Imports MySql.Data.MySqlClient
Module Connection

    Public sqllogin As String
    Public cmdlogin As MySqlCommand
    Public drlogin As MySqlDataAdapter
    Public connlogin As New MySqlConnection

    Public Sub ConnDB()
        connlogin.Close()
        Try
            connlogin.ConnectionString = "server=localhost; user=root; password=; database=nufvdb"
            connlogin.Open()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Module
