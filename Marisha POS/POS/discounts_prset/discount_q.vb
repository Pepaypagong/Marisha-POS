Imports System.Data.SqlClient
Imports System.IO

Public Class discount_q

    Dim SQL As New SQLControl

    Public Sub load_discount()
        Using cmd As New SqlCommand("SELECT * FROM pre_set_discount", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_discount.dgv_discount.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_discount.dgv_discount.Columns(0).DataPropertyName = "discount_no"
                    frm_discount.dgv_discount.Columns(1).DataPropertyName = "discount_name"
                    frm_discount.dgv_discount.Columns(2).DataPropertyName = "discount_amt"

                    frm_discount.dgv_discount.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'New discount'

    'GET disc NO.'
    Public Sub get_discount_no()
        Try
            Dim get_discount_no As String = "SELECT discount_no FROM pre_set_discount ORDER BY discount_no DESC"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_discount_no, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_add_discount.lbl_no.Text = SQL.SQLDR("discount_no") + 1
            Else
                frm_add_discount.lbl_no.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'INSERT discount'
    Public Sub insert_discount()
        Try
            Dim insert_discount As String = "INSERT INTO pre_set_discount(discount_no,discount_name,discount_amt)VALUES " & _
            "(@discount_no,@discount_name,@discount_amt)"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(insert_discount, SQL.SQLCon)

            SQL.SQLCmd.Parameters.AddWithValue("@discount_no", frm_add_discount.lbl_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@discount_name", frm_add_discount.txt_disc_name.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@discount_amt", frm_add_discount.txt_discount.Text)

            SQL.SQLCmd.ExecuteNonQuery()
            MsgBox(" Discount Successfully Added!", MsgBoxStyle.Information, " Discount Record Created")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try

    End Sub

    'Deleting discount'
    Sub delete_discount()
        Try
            Dim delete_discount As String = "Delete from pre_set_discount WHERE discount_no = @discount_no"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(delete_discount, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@discount_no", frm_discount.lbl_no.Text)
            SQL.SQLCmd.ExecuteNonQuery()
            MsgBox(" Record Successfully Deleted!", MsgBoxStyle.Information, " Record Deleted")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub


    'load to apply discount'
    Public Sub load_discount_apply()
        Using cmd As New SqlCommand("SELECT * FROM pre_set_discount", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_apply_discount.dgv_discount.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_apply_discount.dgv_discount.Columns(0).DataPropertyName = "discount_no"
                    frm_apply_discount.dgv_discount.Columns(1).DataPropertyName = "discount_name"
                    frm_apply_discount.dgv_discount.Columns(2).DataPropertyName = "discount_amt"

                    frm_apply_discount.dgv_discount.DataSource = dt
                End Using
            End Using
        End Using
    End Sub
End Class
