Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.IO

Public Class suppliers_q

    Dim SQL As New SQLControl

    Public Function GetSuppliers As Datatable

        dim dtatable as new Datatable
        
         Try
            Dim params As New Dictionary(Of String, Object)

            Dim query_string As String = "select supplier_no, supplier_name " &
                                            "from supplier_table"

           dtatable = SQL.GlobalFetch(query_string,params)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dtatable

    End Function

    'ACCOUNTS MAIN FORM'

    Public Sub load_suppliers()
        Using cmd As New SqlCommand("SELECT * FROM supplier_table", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_suppliers.dgv_suppliers.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_suppliers.dgv_suppliers.Columns(0).DataPropertyName = "supplier_no"
                    frm_suppliers.dgv_suppliers.Columns(1).DataPropertyName = "supplier_name"
                    frm_suppliers.dgv_suppliers.Columns(2).DataPropertyName = "contact_no"
                    frm_suppliers.dgv_suppliers.Columns(3).DataPropertyName = "address"

                    frm_suppliers.dgv_suppliers.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Public Sub load_search_suppliers()
        Using cmd As New SqlCommand("SELECT * FROM supplier_table " &
                                    "WHERE " & frm_suppliers.search_field & " like '%" & frm_suppliers.txt_search.Text.Trim & "%'", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_suppliers.dgv_suppliers.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_suppliers.dgv_suppliers.Columns(0).DataPropertyName = "supplier_no"
                    frm_suppliers.dgv_suppliers.Columns(1).DataPropertyName = "supplier_name"
                    frm_suppliers.dgv_suppliers.Columns(2).DataPropertyName = "contact_no"
                    frm_suppliers.dgv_suppliers.Columns(3).DataPropertyName = "address"

                    frm_suppliers.dgv_suppliers.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'Customers NEW ACCOUNT'

    'GET Cust NO.'
    Public Sub get_supplier_no()
        Try
            Dim get_supplier_no As String = "SELECT supplier_no FROM supplier_table ORDER BY supplier_no DESC"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_supplier_no, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_suppliers_add_update.lbl_supplier_no.Text = SQL.SQLDR("supplier_no") + 1
            Else
                frm_suppliers_add_update.lbl_supplier_no.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'INSERT ACCOUNT'
    Public Sub insert_supplier(supplier_no As string, supplier_name As String, contact_no As String, address As String)
        dim rowsAffected as integer = 0
        Try
            Dim params As New Dictionary(Of String, Object)
            params.Add("@supplier_no", supplier_no)
            params.Add("@supplier_name", supplier_name)
            params.Add("@contact_no", contact_no)
            params.Add("@address", address)

            Dim insert_supplier As String = "INSERT INTO supplier_table(supplier_no,supplier_name,contact_no,address)VALUES " &
            "(@supplier_no,@supplier_name,@contact_no,@address)"

            SQL.GlobalInsertUpdate(insert_supplier,params)

            MsgBox(" Supplier Successfully Added!", MsgBoxStyle.Information, " Supplier Record Created")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'UPDATING CUSTOMERS'
    Sub update_supplier()

        Try
            Dim update_supplier As String = "UPDATE supplier_table SET supplier_name = @supplier_name, " &
                                            "contact_no = @contact_no, address = @address WHERE supplier_no = @supplier_no"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(update_supplier, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@supplier_name", frm_suppliers_add_update.txt_supplier_name.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@contact_no", frm_suppliers_add_update.txt_contact_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@address", frm_suppliers_add_update.txt_address.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@supplier_no", frm_suppliers_add_update.lbl_supplier_no.Text)
            SQL.SQLCmd.ExecuteNonQuery()
            MsgBox(" Supplier Record Successfully Updated!", MsgBoxStyle.Information, " Record Updated")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try

    End Sub

    'SHOW PREVIOUS TRASACTIONS'

    Public Sub load_supplier_trans()
        Using cmd As New SqlCommand("SELECT * FROM purchase_trans_table WHERE supplier_no = '" & frm_suppliers.lbl_supplier_no.Text & "' AND purchase_or_returns = 'Purchase' ORDER BY trans_no DESC", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_suppliers.dgv_purchase_trans.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_suppliers.dgv_purchase_trans.Columns(0).DataPropertyName = "trans_no"
                    frm_suppliers.dgv_purchase_trans.Columns(1).DataPropertyName = "trans_date"
                    frm_suppliers.dgv_purchase_trans.Columns(2).DataPropertyName = "ref_no"
                    frm_suppliers.dgv_purchase_trans.Columns(3).DataPropertyName = "supplier_no"
                    frm_suppliers.dgv_purchase_trans.Columns(4).DataPropertyName = "supplier_name"
                    frm_suppliers.dgv_purchase_trans.Columns(5).DataPropertyName = "sub_total"
                    frm_suppliers.dgv_purchase_trans.Columns(6).DataPropertyName = "total_discount"
                    frm_suppliers.dgv_purchase_trans.Columns(7).DataPropertyName = "grand_total"

                    frm_suppliers.dgv_purchase_trans.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'Filter Supplier Trans'
    Public Sub load_supplier_trans_filter()
        Using cmd As New SqlCommand("SELECT * FROM purchase_trans_table WHERE supplier_no = '" & frm_suppliers.lbl_supplier_no.Text & "' AND purchase_or_returns = 'Purchase' " &
                                    "AND trans_date between '" & frm_suppliers.dtp_purchase_trans_from.Value.ToString("yyyy/MM/dd") & "' and '" & frm_suppliers.dtp_purchase_trans_to.Value.ToString("yyyy/MM/dd") & "' " &
                                    "ORDER BY trans_no DESC", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_suppliers.dgv_purchase_trans.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_suppliers.dgv_purchase_trans.Columns(0).DataPropertyName = "trans_no"
                    frm_suppliers.dgv_purchase_trans.Columns(1).DataPropertyName = "trans_date"
                    frm_suppliers.dgv_purchase_trans.Columns(2).DataPropertyName = "ref_no"
                    frm_suppliers.dgv_purchase_trans.Columns(3).DataPropertyName = "supplier_no"
                    frm_suppliers.dgv_purchase_trans.Columns(4).DataPropertyName = "supplier_name"
                    frm_suppliers.dgv_purchase_trans.Columns(5).DataPropertyName = "sub_total"
                    frm_suppliers.dgv_purchase_trans.Columns(6).DataPropertyName = "total_discount"
                    frm_suppliers.dgv_purchase_trans.Columns(7).DataPropertyName = "grand_total"

                    frm_suppliers.dgv_purchase_trans.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'SHOW SELECTED TRANS - SHOW_SUPPLIER_TRANS'
    Public Sub load_purchase_items()
        Using cmd As New SqlCommand("SELECT * FROM purchase_item_table WHERE trans_no = '" & frm_show_supplier_trans.lbl_trans_no.Text & "'", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_show_supplier_trans.dgv_purchase_list.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_show_supplier_trans.dgv_purchase_list.Columns(0).DataPropertyName = "ID"
                    frm_show_supplier_trans.dgv_purchase_list.Columns(1).DataPropertyName = "trans_no"
                    frm_show_supplier_trans.dgv_purchase_list.Columns(2).DataPropertyName = "trans_date"
                    frm_show_supplier_trans.dgv_purchase_list.Columns(3).DataPropertyName = "supplier_no"
                    frm_show_supplier_trans.dgv_purchase_list.Columns(4).DataPropertyName = "item_no"
                    frm_show_supplier_trans.dgv_purchase_list.Columns(5).DataPropertyName = "barcode"
                    frm_show_supplier_trans.dgv_purchase_list.Columns(6).DataPropertyName = "item_name"
                    frm_show_supplier_trans.dgv_purchase_list.Columns(7).DataPropertyName = "category"
                    frm_show_supplier_trans.dgv_purchase_list.Columns(8).DataPropertyName = "brand"
                    frm_show_supplier_trans.dgv_purchase_list.Columns(9).DataPropertyName = "beg_inv"
                    frm_show_supplier_trans.dgv_purchase_list.Columns(10).DataPropertyName = "qty_purchased"
                    frm_show_supplier_trans.dgv_purchase_list.Columns(11).DataPropertyName = "unit_of_measure"
                    frm_show_supplier_trans.dgv_purchase_list.Columns(12).DataPropertyName = "buying_price"
                    frm_show_supplier_trans.dgv_purchase_list.Columns(13).DataPropertyName = "total_price"
                    frm_show_supplier_trans.dgv_purchase_list.Columns(14).DataPropertyName = "discount"
                    frm_show_supplier_trans.dgv_purchase_list.Columns(15).DataPropertyName = "total_after_discount"

                    frm_show_supplier_trans.dgv_purchase_list.DataSource = dt
                End Using
            End Using
        End Using
    End Sub


    'DELETING TRANSACTIONS'

    Function password_authenticate() As Boolean
        Try
            Dim password_auth As String = "SELECT * FROM accounts_table " &
                                  "WHERE password='" & frm_delete_pass_supp_trans.txt_password.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS " &
                                  " AND admin='YES' "

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(password_auth, SQL.SQLCon)

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

    'Delete from purchase_trans_table'
    Sub delete_trans()
        Try
            Dim delete_trans As String = "Delete from purchase_trans_table WHERE trans_no = @trans_no"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(delete_trans, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_show_supplier_trans.lbl_trans_no.Text)
            SQL.SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'Delete from purchase_item_table'
    Sub delete_trans_items()
        Try
            Dim delete_trans_items As String = "Delete from purchase_item_table WHERE trans_no = @trans_no"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(delete_trans_items, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_show_supplier_trans.lbl_trans_no.Text)
            SQL.SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'deduct the deleted quantity (update)'
    Sub deduct_deleted_items()
        Try
            For Each row As DataGridViewRow In frm_show_supplier_trans.dgv_purchase_list.Rows

                Dim deduct_deleted_items As String = "UPDATE item_table SET stock_qty = stock_qty - @qty_deleted WHERE item_no = @item_no "

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(deduct_deleted_items, SQL.SQLCon)

                SQL.SQLCmd.Parameters.AddWithValue("@qty_deleted", row.Cells(10).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(4).Value)
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
    'Dim vegin_pur As Decimal = 0
    'Dim ends_pur As Decimal = 0

    'Public Sub adjusting_pur()
    '    For Each row As DataGridViewRow In frm_show_supplier_trans.dgv_purchase_list.Rows
    '        Try
    '            Dim query1 As String = "SELECT TOP 1 ID, beg_inv, end_inv from begin_end_inv_table " & _
    '                "where item_no = '" & row.Cells(4).Value & "' ORDER BY ID DESC"

    '            SQL.ConnDB()
    '            SQL.SQLCmd = New SqlCommand(query1, SQL.SQLCon)
    '            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

    '            If SQL.SQLDR.Read = True Then
    '                vegin_pur = SQL.SQLDR("beg_inv")
    '                ends_pur = SQL.SQLDR("end_inv")
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

    '            SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(4).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(6).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(5).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_date", DateTime.Now)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_type", "PURCHASE CANCEL")
    '            SQL.SQLCmd.Parameters.AddWithValue("@beg_inv", vegin_pur)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_in", "0")
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_out", CDec(row.Cells(10).Value))
    '            SQL.SQLCmd.Parameters.AddWithValue("@end_inv", ends_pur - CDec(row.Cells(10).Value))
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", "0")
    '            SQL.SQLCmd.Parameters.AddWithValue("@price_beg", row.Cells(12).Value * vegin_pur) 'buying price * begin inv qty
    '            SQL.SQLCmd.Parameters.AddWithValue("@price_end", (ends_pur - CDec(row.Cells(10).Value)) * row.Cells(12).Value) 'buying price * end inv qty
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", DateTime.Now)
    '            SQL.SQLCmd.Parameters.AddWithValue("@category", row.Cells(7).Value)
    '            SQL.SQLCmd.ExecuteNonQuery()
    '        Catch ex As Exception
    '            MsgBox(ex.ToString)
    '        Finally
    '            SQL.SQLCmd.Dispose()
    '            SQL.SQLCon.Close()
    '        End Try
    '    Next

    'End Sub

    '----------------- PURCHASE RETURN TRANSACTIONS -------------------'
    'SHOW PREVIOUS TRASACTIONS'

    Public Sub load_supplier_returns()
        Using cmd As New SqlCommand("SELECT * FROM purchase_trans_table WHERE supplier_no = '" & frm_suppliers.lbl_supplier_no.Text & "' AND purchase_or_returns = 'Returns' ORDER BY trans_no DESC", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_suppliers.dgv_purchase_returns.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_suppliers.dgv_purchase_returns.Columns(0).DataPropertyName = "trans_no"
                    frm_suppliers.dgv_purchase_returns.Columns(1).DataPropertyName = "trans_date"
                    frm_suppliers.dgv_purchase_returns.Columns(2).DataPropertyName = "ref_no"
                    frm_suppliers.dgv_purchase_returns.Columns(3).DataPropertyName = "supplier_no"
                    frm_suppliers.dgv_purchase_returns.Columns(4).DataPropertyName = "supplier_name"
                    frm_suppliers.dgv_purchase_returns.Columns(5).DataPropertyName = "total_return_price"
                    frm_suppliers.dgv_purchase_returns.Columns(6).DataPropertyName = "total_return_price"

                    frm_suppliers.dgv_purchase_returns.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Public Sub load_supplier_returns_filter()
        Using cmd As New SqlCommand("SELECT * FROM purchase_trans_table WHERE supplier_no = '" & frm_suppliers.lbl_supplier_no.Text & "' AND purchase_or_returns = 'Returns' " &
                                    "AND trans_date between '" & frm_suppliers.dtp_purchase_ret_from.Value.ToString("yyyy/MM/dd") & "' and '" & frm_suppliers.dtp_purchase_ret_to.Value.ToString("yyyy/MM/dd") & "' " &
                                    "ORDER BY trans_no DESC", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_suppliers.dgv_purchase_returns.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_suppliers.dgv_purchase_returns.Columns(0).DataPropertyName = "trans_no"
                    frm_suppliers.dgv_purchase_returns.Columns(1).DataPropertyName = "trans_date"
                    frm_suppliers.dgv_purchase_returns.Columns(2).DataPropertyName = "ref_no"
                    frm_suppliers.dgv_purchase_returns.Columns(3).DataPropertyName = "supplier_no"
                    frm_suppliers.dgv_purchase_returns.Columns(4).DataPropertyName = "supplier_name"
                    frm_suppliers.dgv_purchase_returns.Columns(5).DataPropertyName = "total_return_price"
                    frm_suppliers.dgv_purchase_returns.Columns(6).DataPropertyName = "total_return_price"

                    frm_suppliers.dgv_purchase_returns.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'SHOW SELECTED TRANS - SHOW_SUPPLOER_PURCASE_RET'
    Public Sub load_returned_items()
        Using cmd As New SqlCommand("SELECT * FROM purchase_item_table WHERE trans_no = '" & frm_show_supplier_purchase_ret.lbl_trans_no.Text & "' AND purchase_or_returns = 'Returns'", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_show_supplier_purchase_ret.dgv_purchase_list.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_show_supplier_purchase_ret.dgv_purchase_list.Columns(0).DataPropertyName = "ID"
                    frm_show_supplier_purchase_ret.dgv_purchase_list.Columns(1).DataPropertyName = "trans_no"
                    frm_show_supplier_purchase_ret.dgv_purchase_list.Columns(2).DataPropertyName = "trans_date"
                    frm_show_supplier_purchase_ret.dgv_purchase_list.Columns(3).DataPropertyName = "supplier_no"
                    frm_show_supplier_purchase_ret.dgv_purchase_list.Columns(4).DataPropertyName = "item_no"
                    frm_show_supplier_purchase_ret.dgv_purchase_list.Columns(5).DataPropertyName = "barcode"
                    frm_show_supplier_purchase_ret.dgv_purchase_list.Columns(6).DataPropertyName = "item_name"
                    frm_show_supplier_purchase_ret.dgv_purchase_list.Columns(7).DataPropertyName = "category"
                    frm_show_supplier_purchase_ret.dgv_purchase_list.Columns(8).DataPropertyName = "brand"
                    frm_show_supplier_purchase_ret.dgv_purchase_list.Columns(9).DataPropertyName = "beg_inv"
                    frm_show_supplier_purchase_ret.dgv_purchase_list.Columns(10).DataPropertyName = "qty_returned"
                    frm_show_supplier_purchase_ret.dgv_purchase_list.Columns(11).DataPropertyName = "unit_of_measure"
                    frm_show_supplier_purchase_ret.dgv_purchase_list.Columns(12).DataPropertyName = "return_buying_price"
                    frm_show_supplier_purchase_ret.dgv_purchase_list.Columns(13).DataPropertyName = "total_return_price"

                    frm_show_supplier_purchase_ret.dgv_purchase_list.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'Delete from dbo.return_trans_table'
    Sub delete_trans_returns()
        Try
            Dim delete_trans_returns As String = "Delete from purchase_trans_table WHERE trans_no = @trans_no"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(delete_trans_returns, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_show_supplier_purchase_ret.lbl_trans_no.Text)
            SQL.SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'Delete from purchase_item_table'
    Sub delete_trans_items_returns()
        Try
            Dim delete_trans_items_returns As String = "Delete from purchase_item_table WHERE trans_no = @trans_no"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(delete_trans_items_returns, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_show_supplier_purchase_ret.lbl_trans_no.Text)
            SQL.SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'add the canceled returns' quantity (update)'
    Sub add_deleted_items()
        Try
            For Each row As DataGridViewRow In frm_show_supplier_purchase_ret.dgv_purchase_list.Rows

                Dim add_deleted_items As String = "UPDATE item_table SET stock_qty = stock_qty + @qty_deleted WHERE item_no = @item_no "

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(add_deleted_items, SQL.SQLCon)

                SQL.SQLCmd.Parameters.AddWithValue("@qty_deleted", row.Cells(10).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(4).Value)
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
    'Dim vegin_pur_ret As Decimal = 0
    'Dim ends_pur_ret As Decimal = 0

    'Public Sub adjusting_pur_ret()
    '    For Each row As DataGridViewRow In frm_show_supplier_purchase_ret.dgv_purchase_list.Rows
    '        Try
    '            Dim query1 As String = "SELECT TOP 1 ID, beg_inv, end_inv, trans_date from begin_end_inv_table " & _
    '                "where item_no = '" & row.Cells(4).Value & "' ORDER BY ID DESC"

    '            SQL.ConnDB()
    '            SQL.SQLCmd = New SqlCommand(query1, SQL.SQLCon)
    '            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

    '            If SQL.SQLDR.Read = True Then
    '                vegin_pur_ret = SQL.SQLDR("beg_inv")
    '                ends_pur_ret = SQL.SQLDR("end_inv")
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

    '            SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(4).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(6).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(5).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_date", DateTime.Now)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_type", "PURCHASE RETURN CANCEL")
    '            SQL.SQLCmd.Parameters.AddWithValue("@beg_inv", vegin_pur_ret)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_in", CDec(row.Cells(10).Value))
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_out", "0")
    '            SQL.SQLCmd.Parameters.AddWithValue("@end_inv", ends_pur_ret + CDec(row.Cells(10).Value))
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", "0")
    '            SQL.SQLCmd.Parameters.AddWithValue("@price_beg", row.Cells(12).Value * vegin_pur_ret) 'buying price * begin inv qty
    '            SQL.SQLCmd.Parameters.AddWithValue("@price_end", (ends_pur_ret + CDec(row.Cells(10).Value)) * row.Cells(12).Value) 'buying price * end inv qty
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", DateTime.Now)
    '            SQL.SQLCmd.Parameters.AddWithValue("@category", row.Cells(7).Value)
    '            SQL.SQLCmd.ExecuteNonQuery()
    '        Catch ex As Exception
    '            MsgBox(ex.ToString)
    '        Finally
    '            SQL.SQLCmd.Dispose()
    '            SQL.SQLCon.Close()
    '        End Try
    '    Next

    'End Sub


    Public Sub load_month_pur()
        Try
            Dim loads As String = "SELECT * FROM dtp_settings WHERE part_of_system = 'purchase_trans' "
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(loads, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_suppliers.month_pur = SQL.SQLDR("months")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    Public Sub load_month_ret()
        Try
            Dim loads As String = "SELECT * FROM dtp_settings WHERE part_of_system = 'purchase_return_trans' "
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(loads, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_suppliers.month_ret = SQL.SQLDR("months")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub
End Class
