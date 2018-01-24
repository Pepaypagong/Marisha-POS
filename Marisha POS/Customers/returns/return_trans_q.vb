Imports System.Data.SqlClient
Imports System.IO

Public Class return_trans_q

    Dim SQL As New SQLControl

    'load trans'
    Public Sub load_trans()
        Using cmd As New SqlCommand("SELECT * FROM sales_trans_table WHERE cash_or_account = 'Return' ORDER BY trans_no DESC", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_returns.dgv_returns.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_returns.dgv_returns.Columns(0).DataPropertyName = "trans_no"
                    frm_returns.dgv_returns.Columns(1).DataPropertyName = "trans_datetime"
                    frm_returns.dgv_returns.Columns(2).DataPropertyName = "ret_bo_receipt_no"
                    frm_returns.dgv_returns.Columns(3).DataPropertyName = "ret_total_amount"
                    frm_returns.dgv_returns.Columns(4).DataPropertyName = "ret_bo_remarks"

                    frm_returns.dgv_returns.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'load trans - filter'
    Public Sub load_trans_filter()
        Using cmd As New SqlCommand("SELECT * FROM sales_trans_table WHERE cash_or_account = 'Return' AND trans_date between '" & frm_returns.dtp_from.Value.ToString("yyyy/MM/dd") & "' and '" & frm_returns.dtp_to.Value.ToString("yyyy/MM/dd") & "' " & _
                                    "ORDER BY trans_no DESC", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_returns.dgv_returns.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_returns.dgv_returns.Columns(0).DataPropertyName = "trans_no"
                    frm_returns.dgv_returns.Columns(1).DataPropertyName = "trans_datetime"
                    frm_returns.dgv_returns.Columns(2).DataPropertyName = "ret_bo_receipt_no"
                    frm_returns.dgv_returns.Columns(3).DataPropertyName = "ret_total_amount"
                    frm_returns.dgv_returns.Columns(4).DataPropertyName = "ret_bo_remarks"

                    frm_returns.dgv_returns.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'SHOW SELECTED TRANS INFO - frm_return_trans_details'
    Public Sub load_returned_items()
        Using cmd As New SqlCommand("SELECT * FROM sales_item_table WHERE trans_no = '" & frm_returns_details.lbl_trans_no.Text & "'", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_returns_details.dgv_returned_items.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_returns_details.dgv_returned_items.Columns(0).DataPropertyName = "item_no"
                    frm_returns_details.dgv_returned_items.Columns(1).DataPropertyName = "barcode"
                    frm_returns_details.dgv_returned_items.Columns(2).DataPropertyName = "item_name"
                    frm_returns_details.dgv_returned_items.Columns(3).DataPropertyName = "ret_qty"
                    frm_returns_details.dgv_returned_items.Columns(4).DataPropertyName = "unit_of_measure"
                    frm_returns_details.dgv_returned_items.Columns(5).DataPropertyName = "ret_selling_price"
                    frm_returns_details.dgv_returned_items.Columns(6).DataPropertyName = "ret_grand_total"
                    frm_returns_details.dgv_returned_items.Columns(7).DataPropertyName = "purchase_price"
                    frm_returns_details.dgv_returned_items.Columns(8).DataPropertyName = "category"

                    frm_returns_details.dgv_returned_items.DataSource = dt
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
                frm_add_sales_return.lbl_trans_no.Text = SQL.SQLDR("trans_no") + 1
            Else
                frm_add_sales_return.lbl_trans_no.Text = 1
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

            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_add_sales_return.lbl_trans_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", DateTime.Now)
            SQL.SQLCmd.Parameters.AddWithValue("@cash_or_account", "Return")
            SQL.SQLCmd.Parameters.AddWithValue("@customer_no", "")
            SQL.SQLCmd.Parameters.AddWithValue("@customer_name", "Receipt No. " + frm_add_sales_return.txt_ref_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@sub_total", "0")
            SQL.SQLCmd.Parameters.AddWithValue("@dicount_percent", "0")
            SQL.SQLCmd.Parameters.AddWithValue("@total_discount", "0")
            SQL.SQLCmd.Parameters.AddWithValue("@grand_total", "0")
            SQL.SQLCmd.Parameters.AddWithValue("@cash_tendered", "0")
            SQL.SQLCmd.Parameters.AddWithValue("@change", "0")
            SQL.SQLCmd.Parameters.AddWithValue("@trans_date", frm_add_sales_return.dtp_date.Value)
            SQL.SQLCmd.Parameters.AddWithValue("@ret_bo_receipt_no", frm_add_sales_return.txt_ref_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@ret_total_amount", frm_add_sales_return.lbl_grand_total.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@ret_bo_remarks", frm_add_sales_return.txt_remarks.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@bo_total_amount", "0.00")
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
            For Each row As DataGridViewRow In frm_add_sales_return.dgv_purchase_list.Rows

                Dim Insert_sales_items_cash As String = "INSERT INTO sales_item_table(trans_no,trans_datetime,cash_or_account, " & _
                "customer_no,customer_name,item_no,barcode,item_name,price,qty_sold,total_amount,begin_inv,dicount_percent,trans_date, " & _
                "ret_qty, ret_selling_price, ret_grand_total, bo_qty, bo_selling_price, bo_grand_total,ending_inv,purchase_price,unit_of_measure,category)VALUES " & _
                "(@trans_no,@trans_datetime,@cash_or_account,@customer_no,@customer_name,@item_no,@barcode,@item_name,@price,@qty_sold,@total_amount,@begin_inv,@dicount_percent,@trans_date," & _
                "@ret_qty,@ret_selling_price,@ret_grand_total,@bo_qty,@bo_selling_price,@bo_grand_total,@ending_inv,@purchase_price,@unit_of_measure,@category)"

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(Insert_sales_items_cash, SQL.SQLCon)

                SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_add_sales_return.lbl_trans_no.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", DateTime.Now)
                SQL.SQLCmd.Parameters.AddWithValue("@cash_or_account", "Return")
                SQL.SQLCmd.Parameters.AddWithValue("@customer_no", "")
                SQL.SQLCmd.Parameters.AddWithValue("@customer_name", "")
                SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(0).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(1).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(2).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@price", row.Cells(8).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@qty_sold", "0.00")
                SQL.SQLCmd.Parameters.AddWithValue("@total_amount", "0.00")
                SQL.SQLCmd.Parameters.AddWithValue("@begin_inv", row.Cells(10).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@dicount_percent", "0.00")
                SQL.SQLCmd.Parameters.AddWithValue("@trans_date", frm_add_sales_return.dtp_date.Value)
                SQL.SQLCmd.Parameters.AddWithValue("@ret_qty", row.Cells(6).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@ret_selling_price", row.Cells(8).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@ret_grand_total", row.Cells(9).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@bo_qty", "0.00")
                SQL.SQLCmd.Parameters.AddWithValue("@bo_selling_price", row.Cells(8).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@bo_grand_total", "0.00")
                SQL.SQLCmd.Parameters.AddWithValue("@ending_inv", row.Cells(10).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@purchase_price", row.Cells(14).Value)
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


    'DELETETING SALES RETURNS'

    'Delete from dbo.sales_trans_table'
    Sub delete_trans_returns()
        Try
            Dim delete_trans_returns As String = "Delete from sales_trans_table WHERE trans_no = @trans_no"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(delete_trans_returns, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_returns_details.lbl_trans_no.Text)
            SQL.SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'Delete from sales_item_table'
    Sub delete_trans_items_returns()
        Try
            Dim delete_trans_items_returns As String = "Delete from sales_item_table WHERE trans_no = @trans_no"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(delete_trans_items_returns, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_returns_details.lbl_trans_no.Text)
            SQL.SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'REDUCE the canceled returns' quantity (update)'
    Sub deduct_deleted_items()
        Try
            For Each row As DataGridViewRow In frm_returns_details.dgv_returned_items.Rows

                Dim deduct_deleted_items As String = "UPDATE item_table SET stock_qty = stock_qty - @qty_deleted WHERE item_no = @item_no "

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(deduct_deleted_items, SQL.SQLCon)

                SQL.SQLCmd.Parameters.AddWithValue("@qty_deleted", row.Cells(3).Value)
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


    'Fetch Beginning and Ending Inventory - SALES RETURNS'

    'check if the entry is initial'
    Function isInit()
        Try
            Dim match_found_con As String = "SELECT * from begin_end_inv_table " & _
            "WHERE item_no = '" & frm_add_sales_return.lbl_item_no.Text & "' and trans_date < '" & frm_add_sales_return.dtp_date.Value.ToString("yyyy/MM/dd") & "' "

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(match_found_con, SQL.SQLCon)

            Using reader As SqlDataReader = SQL.SQLCmd.ExecuteReader
                If reader.HasRows = True Then
                    Return False
                Else
                    Return True
                End If
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Function

    'if the item is initially added, run this
    Sub get_initial_beg_inv()
        Try
            Dim get_initial_beg_inv As String = "Select beginning_inventory FROM item_table WHERE item_no ='" & frm_add_sales_return.lbl_item_no.Text & "'"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_initial_beg_inv, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_add_sales_return.lbl_beginning.Text = SQL.SQLDR("beginning_inventory")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'if item is not initial '
    Sub get_not_init_beg_inv()
        Try
            Dim get_not_init_beg_inv As String = "SELECT TOP 1 ID, end_inv, trans_date from begin_end_inv_table " & _
                "where item_no = '" & frm_add_sales_return.lbl_item_no.Text & "' and trans_date < '" & frm_add_sales_return.dtp_date.Value.ToString("yyyy/MM/dd") & "' ORDER BY ID DESC"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_not_init_beg_inv, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_add_sales_return.lbl_beginning.Text = SQL.SQLDR("end_inv")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    Sub get_ending_inv()
        Try
            Dim get_ending_inv As String = "SELECT stock_qty FROM item_table WHERE item_no = '" & frm_add_sales_return.lbl_item_no.Text & "' "
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_ending_inv, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_add_sales_return.lbl_ending.Text = SQL.SQLDR("stock_qty")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    ''BEGIN END INVENTORY TABLE  
    'Public Sub insert_begin_end_purchase()
    '    Try
    '        For Each row As DataGridViewRow In frm_add_sales_return.dgv_purchase_list.Rows

    '            Dim insert_begin_end_purchase As String = "INSERT INTO begin_end_inv_table" & _
    '            "(item_no,item_name,barcode,trans_date,trans_type,beg_inv,item_in,item_out,end_inv,trans_no,price_beg,price_end,trans_datetime,category)VALUES " & _
    '            "(@item_no,@item_name,@barcode,@trans_date,@trans_type,@beg_inv,@item_in,@item_out,@end_inv,@trans_no,@price_beg,@price_end,@trans_datetime,@category)"

    '            SQL.ConnDB()
    '            SQL.SQLCmd = New SqlCommand(insert_begin_end_purchase, SQL.SQLCon)

    '            SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(0).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(2).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(1).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_date", frm_add_sales_return.dtp_date.Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_type", "SALES RETURN")
    '            SQL.SQLCmd.Parameters.AddWithValue("@beg_inv", CDec(row.Cells(10).Value))
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_in", CDec(row.Cells(6).Value))
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_out", "0")
    '            SQL.SQLCmd.Parameters.AddWithValue("@end_inv", CDec(row.Cells(11).Value))
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_add_sales_return.lbl_trans_no.Text)
    '            SQL.SQLCmd.Parameters.AddWithValue("@price_beg", row.Cells(14).Value * row.Cells(10).Value) 'buying price * begin inv qty
    '            SQL.SQLCmd.Parameters.AddWithValue("@price_end", row.Cells(14).Value * row.Cells(11).Value) 'buying price * end inv qty
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", frm_add_sales_return.dtp_date.Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@category", row.Cells(3).Value)
    '            SQL.SQLCmd.ExecuteNonQuery()
    '        Next

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        SQL.SQLCmd.Dispose()
    '        SQL.SQLCon.Close()
    '    End Try
    'End Sub

    'BEGIN INVENTORY INSERT'
    'Public Sub insert_beg_inv_price()
    '    Try
    '        For Each row As DataGridViewRow In frm_add_sales_return.dgv_purchase_list.Rows
    '            Dim insert_item As String = "INSERT INTO beg_inv_price_for_incom_state(generate_date,item_no,barcode,item_name,inc_dec,init_price,sys_generated,trans_no,trans_type)VALUES " & _
    '            "(@generate_date,@item_no,@barcode,@item_name,@inc_dec,@init_price,@sys_generated,@trans_no,@trans_type)"

    '            SQL.ConnDB()
    '            SQL.SQLCmd = New SqlCommand(insert_item, SQL.SQLCon)

    '            SQL.SQLCmd.Parameters.AddWithValue("@generate_date", frm_add_sales_return.dtp_date.Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(0).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(1).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(2).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@inc_dec", row.Cells(12).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@init_price", row.Cells(13).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@sys_generated", "NO")
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_add_sales_return.lbl_trans_no.Text)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_type", "SALES")

    '            SQL.SQLCmd.ExecuteNonQuery()
    '        Next
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        SQL.SQLCmd.Dispose()
    '        SQL.SQLCon.Close()
    '    End Try
    'End Sub

    ''ADJUSTING BEGIN END INV'
    'Dim vegin As Decimal = 0
    'Dim ends As Decimal = 0

    'Public Sub adjusting()
    '    For Each row As DataGridViewRow In frm_returns_details.dgv_returned_items.Rows
    '        Try
    '            Dim query1 As String = "SELECT TOP 1 ID, beg_inv, end_inv from begin_end_inv_table " & _
    '                "where item_no = '" & row.Cells(0).Value & "' ORDER BY ID DESC"

    '            SQL.ConnDB()
    '            SQL.SQLCmd = New SqlCommand(query1, SQL.SQLCon)
    '            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

    '            If SQL.SQLDR.Read = True Then
    '                vegin = SQL.SQLDR("beg_inv")
    '                ends = SQL.SQLDR("end_inv")
    '            End If
    '        Catch ex As Exception
    '            MsgBox(ex.ToString)
    '        Finally
    '            SQL.SQLCmd.Dispose()
    '            SQL.SQLCon.Close()
    '        End Try

    '        Try
    '            Dim query2 As String = "INSERT INTO begin_end_inv_table" & _
    '            "(item_no,item_name,barcode,trans_date,trans_type,beg_inv,item_in,item_out,end_inv,trans_no,price_beg,price_end,trans_datetime,category)VALUES " & _
    '            "(@item_no,@item_name,@barcode,@trans_date,@trans_type,@beg_inv,@item_in,@item_out,@end_inv,@trans_no,@price_beg,@price_end,@trans_datetime,@category)"

    '            SQL.ConnDB()
    '            SQL.SQLCmd = New SqlCommand(query2, SQL.SQLCon)

    '            SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(0).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(2).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(1).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_date", DateTime.Now)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_type", "SALES RETURN CANCEL")
    '            SQL.SQLCmd.Parameters.AddWithValue("@beg_inv", vegin)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_in", "0")
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_out", CDec(row.Cells(3).Value))
    '            SQL.SQLCmd.Parameters.AddWithValue("@end_inv", ends - CDec(row.Cells(3).Value))
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", "0")
    '            SQL.SQLCmd.Parameters.AddWithValue("@price_beg", row.Cells(7).Value * vegin) 'buying price * begin inv qty
    '            SQL.SQLCmd.Parameters.AddWithValue("@price_end", (ends - CDec(row.Cells(3).Value)) * row.Cells(7).Value) 'buying price * end inv qty
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", DateTime.Now)
    '            SQL.SQLCmd.Parameters.AddWithValue("@category", row.Cells(8).Value)
    '            SQL.SQLCmd.ExecuteNonQuery()
    '        Catch ex As Exception
    '            MsgBox(ex.ToString)
    '        Finally
    '            SQL.SQLCmd.Dispose()
    '            SQL.SQLCon.Close()
    '        End Try
    '    Next

    'End Sub

    Public Sub load_month()
        Try
            Dim loads As String = "SELECT * FROM dtp_settings WHERE part_of_system = 'sales_return_trans' "
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(loads, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_returns.month = SQL.SQLDR("months")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

End Class
