Imports System.Data.SqlClient
Imports System.IO

Public Class choose_category_q

    Dim SQL As New SQLControl

    'Load Categories'
    Sub show_categories()
        Try
            Dim show_categories As String = "Select * from category_table ORDER BY category_name ASC"

            Sql.ConnDB()
            Sql.SQLCmd = New SqlCommand(show_categories, Sql.SQLCon)

            Sql.SQLDR = Sql.SQLCmd.ExecuteReader
            frm_choose_category.cbo_choose_cat.Items.Clear()
            frm_choose_category.cbo_choose_cat.Items.Add("All Categories")
            Do While Sql.SQLDR.Read
                frm_choose_category.cbo_choose_cat.Items.Add(SQL.SQLDR!category_name)
            Loop
            Sql.SQLDR.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Sql.SQLCmd.Dispose()
            Sql.SQLCon.Close()
        End Try
    End Sub

End Class
