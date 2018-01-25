Imports System.Data.SqlClient

'Format(mydate, "yyyy-MM-dd HH:mm:ss")
Public Class SQLControl
    Public SQLCon As New SqlConnection With {.ConnectionString = "Server=JEFFREY\SQLEXPRESS;Initial Catalog=pos_marisha;Trusted_connection=true;"}
    Public sqlConnectionString = "Server=JEFFREY\SQLEXPRESS;Initial Catalog=pos_marisha;Trusted_connection=true;"
    Public SQLCmd As SqlCommand
    Public SQLDA As SqlDataAdapter
    Public SQLDS As DataSet
    Public SQLDR As SqlDataReader

    Public Function HasConnection() As Boolean
        Try
            SQLCon.Open()

            SQLCon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return False
    End Function

    Public Sub ConnDB()
        SQLCon.Close()
        Try
            SQLCon.Open()
        Catch ex As Exception
            MsgBox("The system failed to establish a connection", MsgBoxStyle.Information, "Database Settings")
        End Try
    End Sub

    Public Sub RunQuery(ByVal Query As String)
        Try
            SQLCon.Open()

            'CREATE COMMAND
            SQLCmd = New SqlCommand(Query, SQLCon)

            'FILL DATASET
            SQLDA = New SqlDataAdapter(SQLCmd)
            SQLDS = New DataSet
            SQLDA.Fill(SQLDS)

            SQLCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

            'MAKE SURE CONNECTION IS CLOSED
            If SQLCon.State = ConnectionState.Open Then
                SQLCon.Close()
            End If
        End Try
    End Sub

    Public Function GlobalInsertUpdate(sql As String, parameters As Dictionary(Of String, Object)) As Integer
        Dim rows As Integer = 0

        Using con As SqlConnection = New SqlConnection(sqlConnectionString)
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            For Each key As String In parameters.Keys
                cmd.Parameters.AddWithValue(key, parameters(key))
            Next

            rows = cmd.ExecuteNonQuery()
        End Using

        Return rows

    End Function

    Public Function GlobalFetch(sql As String, parameters As Dictionary(Of String, Object)) As DataTable
       Dim rows As DataTable

        Using con As SqlConnection = New SqlConnection(sqlConnectionString)
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            For Each key As String In parameters.Keys
                cmd.Parameters.AddWithValue(key, parameters(key))
            Next

            Using sda As New SqlDataAdapter(cmd)
                dim dt As New DataTable
                sda.Fill(dt) 'fills the datatable with data
                rows = dt
            End using

        End Using

        Return rows

    End Function

End Class