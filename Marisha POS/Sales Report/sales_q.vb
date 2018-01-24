Imports System.Data.SqlClient
Imports System.IO

Public Class sales_q

    Dim SQL As New SQLControl

    'Dashboard'
    Sub show_categories_dash()
        Try
            Dim show_categories As String = "Select * from category_table ORDER BY category_name ASC"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(show_categories, SQL.SQLCon)

            SQL.SQLDR = SQL.SQLCmd.ExecuteReader
            frm_salesrep.cbo_category.Items.Clear()
            Do While SQL.SQLDR.Read
                frm_salesrep.cbo_category.Items.Add(SQL.SQLDR!category_name)
            Loop
            SQL.SQLDR.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    Function get_beginning_inventory_amount(start_date As String) As Decimal

        Dim amount As Decimal = 0

        Try
            Dim show_categories As String = "DECLARE @START_DATE date = '" & start_date & "' " &
            "select ISNULL(SUM(price_in) - SUM(price_out),0) as beginInvAmount " &
            "from item_flow_table where date < @START_DATE "

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(show_categories, SQL.SQLCon)

            SQL.SQLDR = SQL.SQLCmd.ExecuteReader
            Do While SQL.SQLDR.Read
                amount = SQL.SQLDR!beginInvAmount
            Loop
            SQL.SQLDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try

        Return amount

    End Function

    Function get_oldest_item_flow() As Date

        Dim x As Date = "1900-01-01"

        Try
            Dim match_found_con As String = "SELECT convert(date,MIN([date])) as oldest_date from item_flow_table where is_initial_entry = 1"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(match_found_con, SQL.SQLCon)

            SQL.SQLDR = SQL.SQLCmd.ExecuteReader
            Do While SQL.SQLDR.Read
                x = SQL.SQLDR!beginInvAmount
            Loop
            SQL.SQLDR.Close()

        Catch ex As Exception
            MsgBox("Error Found Please Contact Jepoy")
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Function

    Function validate_income_statement(start_date As Date, end_date As Date) As String
        Dim message = ""
        Dim oldest_item_flow As Date = get_oldest_item_flow()
        Dim err_date As Date = "1900-01-01"

        'check if the start date < oldest_initial_itemflow
        Try
            Dim match_found_con As String = "select date as x " &
            "from item_flow_table where is_initial_entry = 1 and convert(date,[date]) = '" & start_date & "' "

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(match_found_con, SQL.SQLCon)

            Using reader As SqlDataReader = SQL.SQLCmd.ExecuteReader

                If oldest_item_flow = err_date Then
                    message = "No record found!"
                Else
                    If reader.HasRows Then
                        message = "Invalid Date Range! start date must be after or on " &
                                      oldest_item_flow.ToString("MMM dd, yyyy")
                    End If
                End If

            End Using

        Catch ex As Exception
            MsgBox("Error Found Please Contact Jepoy")
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try

        Return message

    End Function

    

End Class
