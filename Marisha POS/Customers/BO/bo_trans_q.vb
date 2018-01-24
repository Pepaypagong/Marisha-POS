Imports System.Data.SqlClient
Imports System.IO

Public Class bo_trans_q

    Dim SQL As New SQLControl

    'load trans'
    Public Sub load_trans()
        Using cmd As New SqlCommand("SELECT * FROM sales_trans_table WHERE cash_or_account = 'BO' ORDER BY trans_no DESC", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_bo.dgv_returns.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_bo.dgv_returns.Columns(0).DataPropertyName = "trans_no"
                    frm_bo.dgv_returns.Columns(1).DataPropertyName = "trans_datetime"
                    frm_bo.dgv_returns.Columns(2).DataPropertyName = "ret_bo_receipt_no"
                    frm_bo.dgv_returns.Columns(3).DataPropertyName = "bo_total_amount"
                    frm_bo.dgv_returns.Columns(4).DataPropertyName = "ret_bo_remarks"

                    frm_bo.dgv_returns.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'load trans - filter'
    Public Sub load_trans_filter()
        Using cmd As New SqlCommand("SELECT * FROM sales_trans_table WHERE cash_or_account = 'BO' AND trans_date between '" & frm_bo.dtp_from.Value.ToString("yyyy/MM/dd") & "' and '" & frm_bo.dtp_to.Value.ToString("yyyy/MM/dd") & "' " & _
                                    "ORDER BY trans_no DESC", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_bo.dgv_returns.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_bo.dgv_returns.Columns(0).DataPropertyName = "trans_no"
                    frm_bo.dgv_returns.Columns(1).DataPropertyName = "trans_datetime"
                    frm_bo.dgv_returns.Columns(2).DataPropertyName = "ret_bo_receipt_no"
                    frm_bo.dgv_returns.Columns(3).DataPropertyName = "bo_total_amount"
                    frm_bo.dgv_returns.Columns(4).DataPropertyName = "ret_bo_remarks"

                    frm_bo.dgv_returns.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'SHOW SELECTED TRANS INFO - frm_return_trans_details'
    Public Sub load_returned_items()
        Using cmd As New SqlCommand("SELECT * FROM sales_item_table WHERE trans_no = '" & frm_bo_details.lbl_trans_no.Text & "'", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_bo_details.dgv_returned_items.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_bo_details.dgv_returned_items.Columns(0).DataPropertyName = "item_no"
                    frm_bo_details.dgv_returned_items.Columns(1).DataPropertyName = "barcode"
                    frm_bo_details.dgv_returned_items.Columns(2).DataPropertyName = "item_name"
                    frm_bo_details.dgv_returned_items.Columns(3).DataPropertyName = "bo_qty"
                    frm_bo_details.dgv_returned_items.Columns(4).DataPropertyName = "unit_of_measure"
                    frm_bo_details.dgv_returned_items.Columns(5).DataPropertyName = "bo_selling_price"
                    frm_bo_details.dgv_returned_items.Columns(6).DataPropertyName = "bo_grand_total"
                    frm_bo_details.dgv_returned_items.Columns(7).DataPropertyName = "category"

                    frm_bo_details.dgv_returned_items.DataSource = dt
                End Using
            End Using
        End Using
    End Sub


    'ADD NEW RETURN'

    'generate no'
    Public Sub get_return_trans_no()
        Try
            Dim get_return_trans_no As String = "SELECT trans_no FROM sales_trans_table ORDER BY trans_no DESC"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_return_trans_no, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_add_bo.lbl_trans_no.Text = SQL.SQLDR("trans_no") + 1
            Else
                frm_add_bo.lbl_trans_no.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'INSERT SALES RETURN TRANSACTION'
    Public Sub insert_sales_return_trans()
        Try
            Dim insert_sales_return_trans As String = "INSERT INTO sales_trans_table(trans_no,trans_datetime,cash_or_account, " & _
                "customer_no,customer_name,sub_total,dicount_percent,total_discount,grand_total,cash_tendered,change,trans_date,ret_bo_receipt_no,ret_total_amount,ret_bo_remarks,bo_total_amount,customer_partial_payment)VALUES " & _
                "(@trans_no,@trans_datetime,@cash_or_account,@customer_no,@customer_name,@sub_total,@dicount_percent,@total_discount, " & _
                "@grand_total,@cash_tendered,@change,@trans_date,@ret_bo_receipt_no,@ret_total_amount,@ret_bo_remarks,@bo_total_amount,@customer_partial_payment)"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(insert_sales_return_trans, SQL.SQLCon)

            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_add_bo.lbl_trans_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", DateTime.Now)
            SQL.SQLCmd.Parameters.AddWithValue("@cash_or_account", "BO")
            SQL.SQLCmd.Parameters.AddWithValue("@customer_no", "")
            SQL.SQLCmd.Parameters.AddWithValue("@customer_name", "Receipt No. " + frm_add_bo.txt_ref_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@sub_total", "0")
            SQL.SQLCmd.Parameters.AddWithValue("@dicount_percent", "0")
            SQL.SQLCmd.Parameters.AddWithValue("@total_discount", "0")
            SQL.SQLCmd.Parameters.AddWithValue("@grand_total", "0")
            SQL.SQLCmd.Parameters.AddWithValue("@cash_tendered", "0")
            SQL.SQLCmd.Parameters.AddWithValue("@change", "0")
            SQL.SQLCmd.Parameters.AddWithValue("@trans_date", frm_add_bo.dtp_date.Value)
            SQL.SQLCmd.Parameters.AddWithValue("@ret_bo_receipt_no", frm_add_bo.txt_ref_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@ret_total_amount", "0.00")
            SQL.SQLCmd.Parameters.AddWithValue("@ret_bo_remarks", frm_add_bo.txt_remarks.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@bo_total_amount", frm_add_bo.lbl_grand_total.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@customer_partial_payment", "0.00")
            SQL.SQLCmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'INSERT SALES RETURN TRANSACTION ITEMS ( MULTIPLE ENTRIES) '
    Public Sub insert_sales_return_items()
        Try
            For Each row As DataGridViewRow In frm_add_bo.dgv_purchase_list.Rows

                Dim Insert_sales_items_cash As String = "INSERT INTO sales_item_table(trans_no,trans_datetime,cash_or_account, " & _
                "customer_no,customer_name,item_no,barcode,item_name,price,qty_sold,total_amount,begin_inv,dicount_percent,trans_date, " & _
                "ret_qty, ret_selling_price, ret_grand_total, bo_qty, bo_selling_price, bo_grand_total, unit_of_measure, category)VALUES " & _
                "(@trans_no,@trans_datetime,@cash_or_account,@customer_no,@customer_name,@item_no,@barcode,@item_name,@price,@qty_sold,@total_amount,@begin_inv,@dicount_percent,@trans_date," & _
                "@ret_qty,@ret_selling_price,@ret_grand_total,@bo_qty,@bo_selling_price,@bo_grand_total,@unit_of_measure,@category)"

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(Insert_sales_items_cash, SQL.SQLCon)

                SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_add_bo.lbl_trans_no.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", DateTime.Now)
                SQL.SQLCmd.Parameters.AddWithValue("@cash_or_account", "BO")
                SQL.SQLCmd.Parameters.AddWithValue("@customer_no", "")
                SQL.SQLCmd.Parameters.AddWithValue("@customer_name", "")
                SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(0).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(1).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(2).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@price", row.Cells(8).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@qty_sold", "0.00")
                SQL.SQLCmd.Parameters.AddWithValue("@total_amount", "0.00")
                SQL.SQLCmd.Parameters.AddWithValue("@begin_inv", 0)
                SQL.SQLCmd.Parameters.AddWithValue("@dicount_percent", "0.00")
                SQL.SQLCmd.Parameters.AddWithValue("@trans_date", frm_add_bo.dtp_date.Value)
                SQL.SQLCmd.Parameters.AddWithValue("@ret_qty", "0.00")
                SQL.SQLCmd.Parameters.AddWithValue("@ret_selling_price", row.Cells(8).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@ret_grand_total", "0.00")
                SQL.SQLCmd.Parameters.AddWithValue("@bo_qty", row.Cells(6).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@bo_selling_price", row.Cells(8).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@bo_grand_total", row.Cells(9).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@unit_of_measure", row.Cells(7).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@category", row.Cells(3).Value)
                SQL.SQLCmd.ExecuteNonQuery()
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'DELETE BO RECORD'
    'UPDATE STOCK QTY Increase ( MULTIPLE ENTRIES) '
    Public Sub inc_stock_qty()
        Try
            For Each row As DataGridViewRow In frm_add_sales_return.dgv_purchase_list.Rows

                Dim inc_stock_qty As String = "UPDATE item_table SET stock_qty = stock_qty + @qty_returned WHERE item_no = @item_no "

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(inc_stock_qty, SQL.SQLCon)

                SQL.SQLCmd.Parameters.AddWithValue("@qty_returned", row.Cells(6).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(0).Value)
                SQL.SQLCmd.ExecuteNonQuery()
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub


    'DELETETING BO'

    Sub delete_trans_bo()
        Try
            Dim delete_trans_returns As String = "Delete from sales_trans_table WHERE trans_no = @trans_no"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(delete_trans_returns, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_bo_details.lbl_trans_no.Text)
            SQL.SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    Sub delete_trans_items_bo()
        Try
            Dim delete_trans_items_returns As String = "Delete from sales_item_table WHERE trans_no = @trans_no"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(delete_trans_items_returns, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_bo_details.lbl_trans_no.Text)
            SQL.SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    Public Sub load_month()
        Try
            Dim loads As String = "SELECT * FROM dtp_settings WHERE part_of_system = 'bo_trans' "
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(loads, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_bo.month = SQL.SQLDR("months")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

End Class
