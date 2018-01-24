Imports System.Data.SqlClient
Imports System.IO

Public Class cash_trans_q

    Dim SQL As New SQLControl

    'load trans'
    Public Sub load_trans()
        Using cmd As New SqlCommand("SELECT * FROM sales_trans_table WHERE cash_or_account = 'Cash' ORDER BY trans_no DESC", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_cash_trans.dgv_cash_trans.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_cash_trans.dgv_cash_trans.Columns(0).DataPropertyName = "trans_no"
                    frm_cash_trans.dgv_cash_trans.Columns(1).DataPropertyName = "trans_datetime"
                    frm_cash_trans.dgv_cash_trans.Columns(2).DataPropertyName = "sub_total"
                    frm_cash_trans.dgv_cash_trans.Columns(3).DataPropertyName = "dicount_percent"
                    frm_cash_trans.dgv_cash_trans.Columns(4).DataPropertyName = "total_discount"
                    frm_cash_trans.dgv_cash_trans.Columns(5).DataPropertyName = "grand_total"
                    frm_cash_trans.dgv_cash_trans.Columns(6).DataPropertyName = "cash_tendered"
                    frm_cash_trans.dgv_cash_trans.Columns(7).DataPropertyName = "change"

                    frm_cash_trans.dgv_cash_trans.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'load trans'
    Public Sub load_trans_filter()
        Using cmd As New SqlCommand("SELECT * FROM sales_trans_table WHERE cash_or_account = 'Cash' AND trans_date between '" & frm_cash_trans.dtp_from.Value.ToString("yyyy/MM/dd") & "' and '" & frm_cash_trans.dtp_to.Value.ToString("yyyy/MM/dd") & "' " & _
                                    "ORDER BY trans_no DESC", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_cash_trans.dgv_cash_trans.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_cash_trans.dgv_cash_trans.Columns(0).DataPropertyName = "trans_no"
                    frm_cash_trans.dgv_cash_trans.Columns(1).DataPropertyName = "trans_datetime"
                    frm_cash_trans.dgv_cash_trans.Columns(2).DataPropertyName = "sub_total"
                    frm_cash_trans.dgv_cash_trans.Columns(3).DataPropertyName = "dicount_percent"
                    frm_cash_trans.dgv_cash_trans.Columns(4).DataPropertyName = "total_discount"
                    frm_cash_trans.dgv_cash_trans.Columns(5).DataPropertyName = "grand_total"
                    frm_cash_trans.dgv_cash_trans.Columns(6).DataPropertyName = "cash_tendered"
                    frm_cash_trans.dgv_cash_trans.Columns(7).DataPropertyName = "change"

                    frm_cash_trans.dgv_cash_trans.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'SHOW SELECTED TRANS INFO - frm_trans_info'
    Public Sub load_sold_items()
        Using cmd As New SqlCommand("SELECT * FROM sales_item_table WHERE trans_no = '" & frm_cash_trans_details.lbl_trans_no.Text & "'", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_cash_trans_details.dgv_sold_items.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_cash_trans_details.dgv_sold_items.Columns(0).DataPropertyName = "item_no"
                    frm_cash_trans_details.dgv_sold_items.Columns(1).DataPropertyName = "barcode"
                    frm_cash_trans_details.dgv_sold_items.Columns(2).DataPropertyName = "item_name"
                    frm_cash_trans_details.dgv_sold_items.Columns(3).DataPropertyName = "qty_sold"
                    frm_cash_trans_details.dgv_sold_items.Columns(4).DataPropertyName = "unit_of_measure"
                    frm_cash_trans_details.dgv_sold_items.Columns(5).DataPropertyName = "price"
                    frm_cash_trans_details.dgv_sold_items.Columns(6).DataPropertyName = "total_amount"
                    frm_cash_trans_details.dgv_sold_items.Columns(7).DataPropertyName = "dicount_percent"
                    frm_cash_trans_details.dgv_sold_items.Columns(8).DataPropertyName = "purchase_price"
                    frm_cash_trans_details.dgv_sold_items.Columns(9).DataPropertyName = "category"

                    frm_cash_trans_details.dgv_sold_items.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'DELETETING SALES TRANS (CASH)'

    'Delete from dbo.sales_trans_table'
    Sub delete_trans_cash_sales()
        Try
            Dim delete_trans_cash_sales As String = "Delete from sales_trans_table WHERE trans_no = @trans_no"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(delete_trans_cash_sales, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_cash_trans_details.lbl_trans_no.Text)
            SQL.SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'Delete from sales_item_table'
    Sub delete_trans_cash_items()
        Try
            Dim delete_trans_items_returns As String = "Delete from sales_item_table WHERE trans_no = @trans_no"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(delete_trans_items_returns, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_cash_trans_details.lbl_trans_no.Text)
            SQL.SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'INC the canceled SALES' quantity (update)'
    Sub increase_deleted_items()
        Try
            For Each row As DataGridViewRow In frm_cash_trans_details.dgv_sold_items.Rows

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


    'Reprint Receipt Cash Trans'
    Public Sub load_receipt_info()
        Try
            Dim load As String = "SELECT * FROM set_receipt_table"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(load, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            SQL.SQLDR.Read()
            frm_cash_trans_details.store_name = SQL.SQLDR("store_name")
            frm_cash_trans_details.store_address = SQL.SQLDR("store_address")
            frm_cash_trans_details.tin = SQL.SQLDR("tin")
            frm_cash_trans_details.closing_1 = SQL.SQLDR("closing_1")
            frm_cash_trans_details.closing_2 = SQL.SQLDR("closing_2")
            frm_cash_trans_details.closing_3 = SQL.SQLDR("closing_3")
            frm_cash_trans_details.closing_4 = SQL.SQLDR("closing_4")
            SQL.SQLDR.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    Public Sub LoadItemstoDatagrid()
        Dim y As Integer
        Try
            Dim load As String = "SELECT * FROM sales_item_table WHERE trans_no = '" & frm_cash_trans_details.lbl_trans_no.Text & "' "
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(load, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            frm_cash_trans_details.dgw.Rows.Clear()

            Do While SQL.SQLDR.Read = True

                If SQL.SQLDR("item_name").ToString.Length > 25 Then
                    frm_cash_trans_details.dgw.Rows.Add((SQL.SQLDR("item_name") & vbCrLf & CDec(SQL.SQLDR("qty_sold")) & " X Php " & SQL.SQLDR("price")),
                                                     SQL.SQLDR("total_amount"))
                    frm_cash_trans_details.dgw.Height += 38
                    y += 38
                Else
                    frm_cash_trans_details.dgw.Rows.Add((SQL.SQLDR("item_name") & vbCrLf & CDec(SQL.SQLDR("qty_sold")) & " X Php " & SQL.SQLDR("price")),
                                                        SQL.SQLDR("total_amount"))
                    frm_cash_trans_details.dgw.Height += 19
                    y += 19
                End If
            Loop

            frm_cash_trans_details.pnl_total.Location = New Point(7, 199 + y)
            frm_cash_trans_details.pnl_receipt.Height += y
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    ''ADJUSTING BEGIN END INV'
    'Dim vegin As Decimal = 0
    'Dim ends As Decimal = 0

    'Public Sub adjusting()
    '    For Each row As DataGridViewRow In frm_cash_trans_details.dgv_sold_items.Rows
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
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_type", "SALES CANCEL")
    '            SQL.SQLCmd.Parameters.AddWithValue("@beg_inv", vegin)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_in", CDec(row.Cells(3).Value))
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_out", "0")
    '            SQL.SQLCmd.Parameters.AddWithValue("@end_inv", ends + CDec(row.Cells(3).Value))
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", "0")
    '            SQL.SQLCmd.Parameters.AddWithValue("@price_beg", row.Cells(8).Value * vegin) 'buying price * begin inv qty
    '            SQL.SQLCmd.Parameters.AddWithValue("@price_end", (ends + CDec(row.Cells(3).Value)) * row.Cells(8).Value) 'buying price * end inv qty
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", DateTime.Now)
    '            SQL.SQLCmd.Parameters.AddWithValue("@category", row.Cells(9).Value)
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
            Dim loads As String = "SELECT * FROM dtp_settings WHERE part_of_system = 'cash_trans' "
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(loads, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_cash_trans.month = SQL.SQLDR("months")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

End Class
