Imports System.Data.SqlClient
Imports System.IO

Public Class adjust_q

    Dim SQL As New SQLControl

    'ADJUSTMENT TRANSACTIONS'
    Public Sub load_trans()
        Using cmd As New SqlCommand("SELECT * FROM adjustment_trans_table ORDER BY ID DESC", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_adjust_item_qty.dgv_adjust.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_adjust_item_qty.dgv_adjust.Columns(0).DataPropertyName = "trans_no"
                    frm_adjust_item_qty.dgv_adjust.Columns(1).DataPropertyName = "trans_datetime"
                    frm_adjust_item_qty.dgv_adjust.Columns(2).DataPropertyName = "trans_type"
                    frm_adjust_item_qty.dgv_adjust.Columns(3).DataPropertyName = "remarks"
                    frm_adjust_item_qty.dgv_adjust.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Public Sub load_trans_filter()
        Using cmd As New SqlCommand("SELECT * FROM adjustment_trans_table " & _
                                    "WHERE trans_date between '" & frm_adjust_item_qty.dtp_date_from.Value.ToString("yyyy/MM/dd") & "' and '" & frm_adjust_item_qty.dtp_date_to.Value.ToString("yyyy/MM/dd") & "' " & _
                                    "ORDER BY ID DESC", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_adjust_item_qty.dgv_adjust.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_adjust_item_qty.dgv_adjust.Columns(0).DataPropertyName = "trans_no"
                    frm_adjust_item_qty.dgv_adjust.Columns(1).DataPropertyName = "trans_datetime"
                    frm_adjust_item_qty.dgv_adjust.Columns(2).DataPropertyName = "trans_type"
                    frm_adjust_item_qty.dgv_adjust.Columns(3).DataPropertyName = "remarks"
                    frm_adjust_item_qty.dgv_adjust.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'generate purchase trans_no'
    Public Sub get_trans_no()
        Try
            Dim get_trans_no As String = "SELECT trans_no FROM adjustment_trans_table ORDER BY trans_no DESC"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_trans_no, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_adjusting.lbl_trans_no.Text = SQL.SQLDR("trans_no") + 1
            Else
                frm_adjusting.lbl_trans_no.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'INSERT INCREASE/DECREASE ADJUST TRANSACTION'
    Dim trans_type As String

    Public Sub insert_inc_dec_adjust_trans()
        Try
            If frm_adjusting.inc = True Then
                trans_type = "INCREASE QUANTITY"
            ElseIf frm_adjusting.dec = True Then
                trans_type = "DECREASE QUANTITY"
            End If

            Dim insert_inc_adjust_trans As String = "INSERT INTO adjustment_trans_table(trans_no,trans_datetime,trans_date, " & _
                "trans_type,remarks)VALUES " & _
                "(@trans_no,@trans_datetime,@trans_date,@trans_type,@remarks)"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(insert_inc_adjust_trans, SQL.SQLCon)

            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_adjusting.lbl_trans_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", frm_adjusting.dtp_date.Value)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_date", frm_adjusting.dtp_date.Value)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_type", trans_type) 'STRING TRANSTYPE' 
            SQL.SQLCmd.Parameters.AddWithValue("@remarks", frm_adjusting.txt_remarks.Text)

            SQL.SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'INSERT increase/DEC adjst TRANSACTION ITEMS ( MULTIPLE ENTRIES) '
    Dim in_qty As Decimal = 0
    Dim out_qty As Decimal = 0

    Public Sub insert_inc_dec_adjust_items()
        Try
            If frm_adjusting.inc = True Then
                trans_type = "INCREASE QUANTITY"
            ElseIf frm_adjusting.dec = True Then
                trans_type = "DECREASE QUANTITY"
            End If

            For Each row As DataGridViewRow In frm_adjusting.dgv_purchase_list.Rows

                If frm_adjusting.inc = True Then
                    in_qty = row.Cells(6).Value
                    out_qty = 0
                ElseIf frm_adjusting.dec = True Then
                    in_qty = 0
                    out_qty = row.Cells(6).Value
                End If

                Dim insert_inc_adjust_items As String = "INSERT INTO adjustment_item_table(trans_no,trans_datetime,trans_date,trans_type, " & _
                "item_no,barcode,item_name,purchase_price,item_in,item_out,unit_of_measure,category)VALUES " & _
                "(@trans_no,@trans_datetime,@trans_date,@trans_type,@item_no,@barcode,@item_name,@purchase_price,@item_in,@item_out,@unit_of_measure,@category)"

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(insert_inc_adjust_items, SQL.SQLCon)

                SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_adjusting.lbl_trans_no.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", frm_adjusting.dtp_date.Value)
                SQL.SQLCmd.Parameters.AddWithValue("@trans_date", frm_adjusting.dtp_date.Value)
                SQL.SQLCmd.Parameters.AddWithValue("@trans_type", trans_type)
                SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(0).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(1).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(2).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@purchase_price", row.Cells(7).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@item_in", in_qty)
                SQL.SQLCmd.Parameters.AddWithValue("@item_out", out_qty)
                SQL.SQLCmd.Parameters.AddWithValue("@unit_of_measure", row.Cells(12).Value)
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

    'UPDATE STOCK QTY ADD ( MULTIPLE ENTRIES) '
    Public Sub inc_stock_qty()
        Try
            For Each row As DataGridViewRow In frm_adjusting.dgv_purchase_list.Rows

                Dim add_stock_qty As String = "UPDATE item_table SET stock_qty = stock_qty + @qty_inc_adjust WHERE item_no = @item_no "

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(add_stock_qty, SQL.SQLCon)

                SQL.SQLCmd.Parameters.AddWithValue("@qty_inc_adjust", row.Cells(6).Value)
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

    'UPDATE STOCK QTY dec ( MULTIPLE ENTRIES) '
    Public Sub dec_stock_qty()
        Try
            For Each row As DataGridViewRow In frm_adjusting.dgv_purchase_list.Rows

                Dim add_stock_qty As String = "UPDATE item_table SET stock_qty = stock_qty - @qty_inc_adjust WHERE item_no = @item_no "

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(add_stock_qty, SQL.SQLCon)

                SQL.SQLCmd.Parameters.AddWithValue("@qty_inc_adjust", row.Cells(6).Value)
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

    'Fetch Beginning and Ending Inventory '

    'check if the entry is initial'
    Function isInit()
        Try
            Dim match_found_con As String = "SELECT * from begin_end_inv_table " & _
            "WHERE item_no = '" & frm_adjusting.lbl_item_no.Text & "' and trans_date < '" & frm_adjusting.dtp_date.Value.ToString("yyyy/MM/dd") & "' "

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
            Dim get_initial_beg_inv As String = "Select beginning_inventory FROM item_table WHERE item_no ='" & frm_adjusting.lbl_item_no.Text & "'"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_initial_beg_inv, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_adjusting.lbl_beginning.Text = SQL.SQLDR("beginning_inventory")
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
                "where item_no = '" & frm_adjusting.lbl_item_no.Text & "' and trans_date < '" & frm_adjusting.dtp_date.Value.ToString("yyyy/MM/dd") & "' ORDER BY ID DESC"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_not_init_beg_inv, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_adjusting.lbl_beginning.Text = SQL.SQLDR("end_inv")
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
            Dim get_ending_inv As String = "SELECT stock_qty FROM item_table WHERE item_no = '" & frm_adjusting.lbl_item_no.Text & "' "
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_ending_inv, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_adjusting.lbl_ending.Text = SQL.SQLDR("stock_qty")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    Dim beg_end_inc As String
    Dim beg_end_dec As String

    'Public Sub insert_begin_end_adjust()
    '    If frm_adjusting.inc = True Then
    '        trans_type = "INCREASE QUANTITY ADJUST"
    '    ElseIf frm_adjusting.dec = True Then
    '        trans_type = "DECREASE QUANTITY ADJUST"
    '    End If
    '    Try
    '        For Each row As DataGridViewRow In frm_adjusting.dgv_purchase_list.Rows

    '            If frm_adjusting.inc = True Then
    '                in_qty = row.Cells(6).Value
    '                out_qty = 0
    '            ElseIf frm_adjusting.dec = True Then
    '                in_qty = 0
    '                out_qty = row.Cells(6).Value
    '            End If

    '            Dim insert_begin_end_purchase As String = "INSERT INTO begin_end_inv_table" & _
    '            "(item_no,item_name,barcode,trans_date,trans_type,beg_inv,item_in,item_out,end_inv,trans_no,price_beg,price_end,trans_datetime,category)VALUES " & _
    '            "(@item_no,@item_name,@barcode,@trans_date,@trans_type,@beg_inv,@item_in,@item_out,@end_inv,@trans_no,@price_beg,@price_end,@trans_datetime,@category)"

    '            SQL.ConnDB()
    '            SQL.SQLCmd = New SqlCommand(insert_begin_end_purchase, SQL.SQLCon)

    '            SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(0).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(2).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(1).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_date", frm_adjusting.dtp_date.Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_type", trans_type)
    '            SQL.SQLCmd.Parameters.AddWithValue("@beg_inv", row.Cells(8).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_in", in_qty)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_out", out_qty)
    '            SQL.SQLCmd.Parameters.AddWithValue("@end_inv", row.Cells(9).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_adjusting.lbl_trans_no.Text)
    '            SQL.SQLCmd.Parameters.AddWithValue("@price_beg", row.Cells(7).Value * row.Cells(8).Value) 'buying price * begin inv qty
    '            SQL.SQLCmd.Parameters.AddWithValue("@price_end", row.Cells(7).Value * row.Cells(9).Value) 'buying price * end inv qty
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", frm_adjusting.dtp_date.Value)
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


    'trans details'

    'SHOW SELECTED TRANS INFO - frm_trans_info'
    Public Sub load_sold_items()
        Using cmd As New SqlCommand("SELECT * FROM adjustment_item_table WHERE trans_no = '" & frm_adjusting_details.lbl_trans_no.Text & "'", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_adjusting_details.dgv_purchase_list.AutoGenerateColumns = False

                    'Add Columns
                    frm_adjusting_details.dgv_purchase_list.Columns(0).DataPropertyName = "item_no"
                    frm_adjusting_details.dgv_purchase_list.Columns(1).DataPropertyName = "barcode"
                    frm_adjusting_details.dgv_purchase_list.Columns(2).DataPropertyName = "item_name"

                    If frm_adjusting_details.lbl_trans_type.Text = "INCREASE QUANTITY" Then
                        frm_adjusting_details.dgv_purchase_list.Columns(3).DataPropertyName = "item_in"
                    ElseIf frm_adjusting_details.lbl_trans_type.Text = "DECREASE QUANTITY" Then
                        frm_adjusting_details.dgv_purchase_list.Columns(3).DataPropertyName = "item_out"
                    End If

                    frm_adjusting_details.dgv_purchase_list.Columns(4).DataPropertyName = "purchase_price"
                    frm_adjusting_details.dgv_purchase_list.Columns(5).DataPropertyName = "unit_of_measure"
                    frm_adjusting_details.dgv_purchase_list.Columns(6).DataPropertyName = "category"

                    frm_adjusting_details.dgv_purchase_list.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'DELETETING SALES TRANS (CASH)'

    'Delete from dbo.adjust trans'
    Sub delete_adjust_trans()
        Try
            Dim delete_trans_cash_sales As String = "Delete from adjustment_trans_table WHERE trans_no = @trans_no"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(delete_trans_cash_sales, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_adjusting_details.lbl_trans_no.Text)
            SQL.SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'Delete from sales_item_table'
    Sub delete_adjust_items()
        Try
            Dim delete_trans_items_returns As String = "Delete from adjustment_item_table WHERE trans_no = @trans_no"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(delete_trans_items_returns, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_adjusting_details.lbl_trans_no.Text)
            SQL.SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'decrease the canceled inc' quantity (update)'
    Sub increase_cancel()
        Try
            For Each row As DataGridViewRow In frm_adjusting_details.dgv_purchase_list.Rows

                Dim increase_deleted_items As String = "UPDATE item_table SET stock_qty = stock_qty - @qty_deleted WHERE item_no = @item_no "

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(increase_deleted_items, SQL.SQLCon)

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

    'increase the canceled dec' quantity (update)'
    Sub decrease_cancel()
        Try
            For Each row As DataGridViewRow In frm_adjusting_details.dgv_purchase_list.Rows

                Dim increase_deleted_items As String = "UPDATE item_table SET stock_qty = stock_qty + @qty_deleted WHERE item_no = @item_no "

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(increase_deleted_items, SQL.SQLCon)

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

    ''ADJUSTING BEGIN END INV'
    'Dim vegin As Decimal = 0
    'Dim ends As Decimal = 0

    'Public Sub adjusting_inc_cancel()
    '    For Each row As DataGridViewRow In frm_adjusting_details.dgv_purchase_list.Rows
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
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_type", frm_adjusting_details.lbl_trans_type.Text + " CANCEL")
    '            SQL.SQLCmd.Parameters.AddWithValue("@beg_inv", vegin)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_in", "0")
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_out", row.Cells(3).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@end_inv", ends - row.Cells(3).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", "0")
    '            SQL.SQLCmd.Parameters.AddWithValue("@price_beg", row.Cells(4).Value * vegin) 'buying price * begin inv qty
    '            SQL.SQLCmd.Parameters.AddWithValue("@price_end", (ends - row.Cells(3).Value) * row.Cells(4).Value) 'buying price * end inv qty
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", DateTime.Now)
    '            SQL.SQLCmd.Parameters.AddWithValue("@category", row.Cells(6).Value)

    '            SQL.SQLCmd.ExecuteNonQuery()
    '        Catch ex As Exception
    '            MsgBox(ex.ToString)
    '        Finally
    '            SQL.SQLCmd.Dispose()
    '            SQL.SQLCon.Close()
    '        End Try
    '    Next

    'End Sub


    'Public Sub adjusting_dec_cancel()
    '    For Each row As DataGridViewRow In frm_adjusting_details.dgv_purchase_list.Rows
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
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_type", frm_adjusting_details.lbl_trans_type.Text + " CANCEL")
    '            SQL.SQLCmd.Parameters.AddWithValue("@beg_inv", vegin)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_in", row.Cells(3).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_out", "0")
    '            SQL.SQLCmd.Parameters.AddWithValue("@end_inv", ends + row.Cells(3).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", "0")
    '            SQL.SQLCmd.Parameters.AddWithValue("@price_beg", row.Cells(4).Value * vegin) 'buying price * begin inv qty
    '            SQL.SQLCmd.Parameters.AddWithValue("@price_end", (ends + row.Cells(3).Value) * row.Cells(4).Value) 'buying price * end inv qty
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", DateTime.Now)
    '            SQL.SQLCmd.Parameters.AddWithValue("@category", row.Cells(6).Value)
    '            SQL.SQLCmd.ExecuteNonQuery()
    '        Catch ex As Exception
    '            MsgBox(ex.ToString)
    '        Finally
    '            SQL.SQLCmd.Dispose()
    '            SQL.SQLCon.Close()
    '        End Try
    '    Next

    'End Sub

    'settings'
    Public Sub load_month()
        Try
            Dim loads As String = "SELECT * FROM dtp_settings WHERE part_of_system = 'adjust_qty' "
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(loads, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_adjust_item_qty.month = SQL.SQLDR("months")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

End Class
