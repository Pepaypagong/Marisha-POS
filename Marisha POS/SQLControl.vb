Imports System.Data.SqlClient

'Format(mydate, "yyyy-MM-dd HH:mm:ss")
Public Class SQLControl
    Public SQLCon As New SqlConnection With {.ConnectionString = "Server=JEFFREY\SQLEXPRESS;Initial Catalog=pos_marisha;Trusted_connection=true;"}
    Public sqlConnectionString = "Server=JEFFREY\SQLEXPRESS;Initial Catalog=pos_marisha;Trusted_connection=true;"
    Public SQLCmd As SqlCommand
    Public SQLDA As SqlDataAdapter
    Public SQLDS As DataSet
    Public SQLDR As SqlDataReader

    Public GlobalErrorMessage As String = "Error detected! Please contact Jeffrey Bacuña."

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

    Public Function GlobalInsertUpdateDelete(sql As String, parameters As Dictionary(Of String, Object)) As Integer

        Dim rows As Integer = 0

        Try
            Using con As SqlConnection = New SqlConnection(sqlConnectionString)
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand(sql, con)
                cmd.CommandType = CommandType.Text
                For Each key As String In parameters.Keys
                    cmd.Parameters.AddWithValue(key, parameters(key))
                Next
                rows = cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox(GlobalErrorMessage, MsgBoxStyle.Critical)
        End Try

        Return rows

    End Function

    Public Function GlobalFetch(sql As String, parameters As Dictionary(Of String, Object)) As DataTable

        Dim rows As New DataTable

        Try
            Using con As SqlConnection = New SqlConnection(sqlConnectionString)
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand(sql, con)
                cmd.CommandType = CommandType.Text
                For Each key As String In parameters.Keys
                    cmd.Parameters.AddWithValue(key, parameters(key))
                Next

                Using sda As New SqlDataAdapter(cmd)
                    sda.Fill(rows)
                End Using

            End Using
        Catch ex As Exception
            MsgBox(GlobalErrorMessage, MsgBoxStyle.Critical)
        End Try

        Return rows

    End Function

    Public Function GlobalIsExisting(sql As String, parameters As Dictionary(Of String, Object)) As Boolean
        Dim result As Boolean = False

        Try
            Using con As SqlConnection = New SqlConnection(sqlConnectionString)
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand(sql, con)
                cmd.CommandType = CommandType.Text
                For Each key As String In parameters.Keys
                    cmd.Parameters.AddWithValue(key, parameters(key))
                Next

                Using reader As SqlDataReader = cmd.ExecuteReader
                    If reader.HasRows Then
                        result = True
                    Else
                        result = False
                    End If
                End Using

            End Using
        Catch ex As Exception
            MsgBox(GlobalErrorMessage, MsgBoxStyle.Critical)
        End Try

        Return result
    End Function

    Public Function GenerateTransactionNumber(trans_type As String) As String
        Dim retVal As String = ""
        Dim tableName As String = ""
        Dim id As Integer

        Select Case trans_type
            Case "new sales return", "new reject"
                tableName = "sales_trans_table"
            Case "new purchase", "new purchase return"
                tableName = "purchase_trans_table"
        End Select

        Try
            Dim str_query As String = "SELECT TOP 1 trans_no FROM " + tableName + " ORDER BY trans_no DESC"
            ConnDB()
            SQLCmd = New SqlCommand(str_query, SQLCon)

            Using reader As SqlDataReader = SQLCmd.ExecuteReader

                If reader.Read = True Then
                    id = reader("trans_no") + 1
                Else
                    id = 1
                End If

                retVal = GeneratePrefixAndId(id, trans_type)
            End Using

        Catch ex As Exception
            MsgBox(GlobalErrorMessage, MsgBoxStyle.Critical)
        Finally
            SQLCmd.Dispose()
            SQLCon.Close()
        End Try

        Return retVal

    End Function

    Public Function GeneratePrefixAndId(Id As Integer, trans_type As String) As String
        '12 digits including prefix = SR0000000001
        Dim generatedReturn As String = ""
        Dim prefix As String = ""
        Dim idDigitCount As Integer

        Select Case trans_type
            Case "new sales return"
                prefix = "SR"
            Case "new reject"
                prefix = "RJ"
            Case "new purchase"
                prefix = "PU"
            Case "new purchase return"
                prefix = "PR"
        End Select
        generatedReturn += prefix
        idDigitCount = Id.ToString().Count()
        For index = idDigitCount To 9
            generatedReturn += "0"
        Next
        generatedReturn += Id.ToString()
        Return generatedReturn
    End Function

End Class