Imports System.Data.SqlClient
Imports System.IO

Public Class category_q

    Dim SQL As New SQLControl

    Public Sub load_category()
        Using cmd As New SqlCommand("SELECT * FROM category_table", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_category.dgv_category.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_category.dgv_category.Columns(0).DataPropertyName = "category_no"
                    frm_category.dgv_category.Columns(1).DataPropertyName = "category_name"
                    frm_category.dgv_category.Columns(2).DataPropertyName = "category_desc"

                    frm_category.dgv_category.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'New category'

    'GET cat NO.'
    Public Sub get_category_no()
        Try
            Dim get_category_no As String = "SELECT category_no FROM category_table ORDER BY category_no DESC"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_category_no, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_category_addupdate.lbl_category_no.Text = SQL.SQLDR("category_no") + 1
            Else
                frm_category_addupdate.lbl_category_no.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'category exists'
    Function category_exists() As Boolean
        Try
            Dim category_exists_con As String = "SELECT * FROM category_table " & _
                                  "WHERE category_name='" & frm_category_addupdate.txt_category_name.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS "

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(category_exists_con, SQL.SQLCon)

            Using reader As SqlDataReader = SQL.SQLCmd.ExecuteReader
                If reader.HasRows = True Then
                    Return True
                Else
                    Return False
                End If
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Function

    'INSERT CATEGGORy'
    Public Sub insert_category()
        Try
            Dim insert_category As String = "INSERT INTO category_table(category_no,category_name,category_desc)VALUES " & _
            "(@category_no,@category_name,@category_desc)"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(insert_category, SQL.SQLCon)

            SQL.SQLCmd.Parameters.AddWithValue("@category_no", frm_category_addupdate.lbl_category_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@category_name", frm_category_addupdate.txt_category_name.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@category_desc", frm_category_addupdate.txt_category_desc.Text)

            SQL.SQLCmd.ExecuteNonQuery()
            MsgBox(" Category Successfully Added!", MsgBoxStyle.Information, " Category Record Created")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try

    End Sub

    'UPDATING CUSTOMERS'
    Sub update_category()
        Try
            Dim update_category As String = "UPDATE category_table SET category_name = @category_name, " & _
                                            "category_desc = @category_desc WHERE category_no = @category_no"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(update_category, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@category_name", frm_category_addupdate.txt_category_name.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@category_desc", frm_category_addupdate.txt_category_desc.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@category_no", frm_category_addupdate.lbl_category_no.Text)
            SQL.SQLCmd.ExecuteNonQuery()
            MsgBox(" Category Record Successfully Updated!", MsgBoxStyle.Information, " Record Updated")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'update the category of the itemlist'
    Sub update_itemlist_category()
        Try
            Dim update_itemlist_category As String = "UPDATE item_table SET category = @new_category " & _
                                            "WHERE category = @old_category"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(update_itemlist_category, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@new_category", frm_category_addupdate.txt_category_name.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@old_category", frm_category_addupdate.txt_oldcat.Text)
            SQL.SQLCmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'check if category is used in item list'
    Function category_used_in_itemlist() As Boolean
        Try
            Dim category_used_in_itemlist_con As String = "SELECT * FROM item_table " & _
                                  "WHERE category='" & frm_category.lbl_category_name.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS "

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(category_used_in_itemlist_con, SQL.SQLCon)

            Using reader As SqlDataReader = SQL.SQLCmd.ExecuteReader
                If reader.HasRows = True Then
                    Return True
                Else
                    Return False
                End If
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Function

    'deleting category'
    Sub delete_category()
        Try
            Dim delete_category As String = "Delete from category_table WHERE category_no = @category_no"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(delete_category, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@category_no", frm_category.lbl_category_no.Text)
            SQL.SQLCmd.ExecuteNonQuery()
            MsgBox(" Category Successfully Deleted!", MsgBoxStyle.Information, " Category Deleted")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

End Class
