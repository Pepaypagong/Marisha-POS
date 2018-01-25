Imports System.Data.SqlClient
Imports System.IO

Public Class customers_q

    Dim SQL As New SQLControl

    'ACCOUNTS MAIN FORM'

    Public Function GetCustomers As Datatable

        dim customers as new Datatable
        
         Try
            Dim params As New Dictionary(Of String, Object)

            Dim query_string As String = "select first_name + ' ' + " &
                                            "middle_name + ' ' + " &
                                            "last_name as full_name " &
                                            "from customers_table"

           customers = SQL.GlobalFetch(query_string,params)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return customers

    End Function

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

    Public Sub load_customers()
        Using cmd As New SqlCommand("SELECT * FROM customers_table", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_customers.dgv_customers.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_customers.dgv_customers.Columns(0).DataPropertyName = "customer_no"
                    frm_customers.dgv_customers.Columns(1).DataPropertyName = "first_name"
                    frm_customers.dgv_customers.Columns(2).DataPropertyName = "middle_name"
                    frm_customers.dgv_customers.Columns(3).DataPropertyName = "last_name"
                    frm_customers.dgv_customers.Columns(4).DataPropertyName = "contact_no"
                    frm_customers.dgv_customers.Columns(5).DataPropertyName = "address"

                    frm_customers.dgv_customers.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Public Sub load_search_customers()
        Using cmd As New SqlCommand("SELECT * FROM customers_table " & _
                                    "WHERE " & frm_customers.search_field & " like '%" & frm_customers.txt_search.Text.Trim & "%'", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_customers.dgv_customers.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_customers.dgv_customers.Columns(0).DataPropertyName = "customer_no"
                    frm_customers.dgv_customers.Columns(1).DataPropertyName = "first_name"
                    frm_customers.dgv_customers.Columns(2).DataPropertyName = "middle_name"
                    frm_customers.dgv_customers.Columns(3).DataPropertyName = "last_name"
                    frm_customers.dgv_customers.Columns(4).DataPropertyName = "contact_no"
                    frm_customers.dgv_customers.Columns(5).DataPropertyName = "address"

                    frm_customers.dgv_customers.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'Customers NEW ACCOUNT'

    'GET Cust NO.'
    Public Sub get_customer_no()
        Try
            Dim get_account_no As String = "SELECT customer_no FROM customers_table ORDER BY customer_no DESC"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_account_no, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_customer_add_update.lbl_customer_no.Text = SQL.SQLDR("customer_no") + 1
            Else
                frm_customer_add_update.lbl_customer_no.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'INSERT ACCOUNT'
    Public Sub insert_customer()
        Try
            Dim insert_customer As String = "INSERT INTO customers_table(customer_no,first_name,middle_name,last_name,contact_no,address)VALUES " & _
            "(@customer_no,@first_name,@middle_name,@last_name,@contact_no,@address)"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(insert_customer, SQL.SQLCon)

            SQL.SQLCmd.Parameters.AddWithValue("@customer_no", frm_customer_add_update.lbl_customer_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@first_name", frm_customer_add_update.txt_fname.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@middle_name", frm_customer_add_update.txt_mname.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@last_name", frm_customer_add_update.txt_lname.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@contact_no", frm_customer_add_update.txt_contact_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@address", frm_customer_add_update.txt_address.Text)

            SQL.SQLCmd.ExecuteNonQuery()
            MsgBox(" Customer Successfully Added!", MsgBoxStyle.Information, " Customer Record Created")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try

    End Sub

    'UPDATING CUSTOMERS'

    Sub update_customers()

        Try
            Dim update_account As String = "UPDATE customers_table SET first_name = @first_name, middle_name = @middle_name, " & _
                                            "last_name = @last_name, contact_no = @contact_no, address = @address WHERE customer_no = @customer_no"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(update_account, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@first_name", frm_customer_add_update.txt_fname.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@middle_name", frm_customer_add_update.txt_mname.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@last_name", frm_customer_add_update.txt_lname.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@contact_no", frm_customer_add_update.txt_contact_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@address", frm_customer_add_update.txt_address.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@customer_no", frm_customer_add_update.lbl_customer_no.Text)
            SQL.SQLCmd.ExecuteNonQuery()
            MsgBox(" Customer Record Successfully Updated!", MsgBoxStyle.Information, " Record Updated")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try

    End Sub

    'load trans'
    Public Sub load_trans()
        Using cmd As New SqlCommand("SELECT * FROM sales_trans_table WHERE customer_no = '" & frm_customers.lbl_customer_no.Text & "' " & _
                                    "AND cash_or_account = 'Account' ORDER BY trans_no DESC", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_customers.dgv_sales_trans.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_customers.dgv_sales_trans.Columns(0).DataPropertyName = "trans_no"
                    frm_customers.dgv_sales_trans.Columns(1).DataPropertyName = "trans_datetime"
                    frm_customers.dgv_sales_trans.Columns(2).DataPropertyName = "sub_total"
                    frm_customers.dgv_sales_trans.Columns(3).DataPropertyName = "dicount_percent"
                    frm_customers.dgv_sales_trans.Columns(4).DataPropertyName = "total_discount"
                    frm_customers.dgv_sales_trans.Columns(5).DataPropertyName = "grand_total"
                    frm_customers.dgv_sales_trans.Columns(6).DataPropertyName = "cash_tendered"
                    frm_customers.dgv_sales_trans.Columns(7).DataPropertyName = "change"
                    frm_customers.dgv_sales_trans.Columns(8).DataPropertyName = "customer_partial_payment"

                    frm_customers.dgv_sales_trans.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Public Sub load_trans_filter()
        Using cmd As New SqlCommand("SELECT * FROM sales_trans_table WHERE customer_no = '" & frm_customers.lbl_customer_no.Text & "' " & _
                                    "AND cash_or_account = 'Account' AND trans_date between '" & frm_customers.dtp_from.Value.ToString("yyyy/MM/dd") & "' and '" & frm_customers.dtp_to.Value.ToString("yyyy/MM/dd") & "' " & _
                                    "ORDER BY trans_no DESC", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_customers.dgv_sales_trans.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_customers.dgv_sales_trans.Columns(0).DataPropertyName = "trans_no"
                    frm_customers.dgv_sales_trans.Columns(1).DataPropertyName = "trans_datetime"
                    frm_customers.dgv_sales_trans.Columns(2).DataPropertyName = "sub_total"
                    frm_customers.dgv_sales_trans.Columns(3).DataPropertyName = "dicount_percent"
                    frm_customers.dgv_sales_trans.Columns(4).DataPropertyName = "total_discount"
                    frm_customers.dgv_sales_trans.Columns(5).DataPropertyName = "grand_total"
                    frm_customers.dgv_sales_trans.Columns(6).DataPropertyName = "cash_tendered"
                    frm_customers.dgv_sales_trans.Columns(7).DataPropertyName = "change"
                    frm_customers.dgv_sales_trans.Columns(8).DataPropertyName = "customer_partial_payment"

                    frm_customers.dgv_sales_trans.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'SHOW SELECTED TRANS INFO - frm_trans_info'
    Public Sub load_sold_items()
        Using cmd As New SqlCommand("SELECT * FROM sales_item_table WHERE trans_no = '" & frm_trans_info.lbl_trans_no.Text & "'", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_trans_info.dgv_sold_items.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_trans_info.dgv_sold_items.Columns(0).DataPropertyName = "item_no"
                    frm_trans_info.dgv_sold_items.Columns(1).DataPropertyName = "barcode"
                    frm_trans_info.dgv_sold_items.Columns(2).DataPropertyName = "item_name"
                    frm_trans_info.dgv_sold_items.Columns(3).DataPropertyName = "qty_sold"
                    frm_trans_info.dgv_sold_items.Columns(4).DataPropertyName = "unit_of_measure"
                    frm_trans_info.dgv_sold_items.Columns(5).DataPropertyName = "price"
                    frm_trans_info.dgv_sold_items.Columns(6).DataPropertyName = "total_amount"
                    frm_trans_info.dgv_sold_items.Columns(7).DataPropertyName = "dicount_percent"
                    frm_trans_info.dgv_sold_items.Columns(8).DataPropertyName = "purchase_price"
                    frm_trans_info.dgv_sold_items.Columns(9).DataPropertyName = "category"


                    frm_trans_info.dgv_sold_items.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'GET SUM OF GRAND TOTAL AND PARTIAL PAYMENTS'
    Public Sub grandtotal_and_partial_pay_sum()
        Try
            Dim grandtotal_and_partial_pay_sum As String = "SELECT SUM(grand_total) as grand_total_sum , SUM(customer_partial_payment) as customer_partial_payment_sum FROM sales_trans_table " & _
                "WHERE customer_no = '" & frm_customers.lbl_customer_no.Text & "' AND cash_or_account = 'Account'"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(grandtotal_and_partial_pay_sum, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            SQL.SQLDR.Read()
            If Not SQL.SQLDR.IsDBNull(0) Then
                frm_customers.grandtotal_sum = SQL.SQLDR("grand_total_sum")
                frm_customers.partial_pay_sum = SQL.SQLDR("customer_partial_payment_sum")
            Else
                frm_customers.grandtotal_sum = 0
                frm_customers.partial_pay_sum = 0
            End If
            SQL.SQLDR.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'CUSTOMER PAYMENTS -----'

    Public Sub payments_sum()
        Try
            Dim payments_sum As String = "SELECT SUM(amount_paid) as sum FROM customer_payments_table " & _
                "WHERE customer_no = '" & frm_customers.lbl_customer_no.Text & "' "
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(payments_sum, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            SQL.SQLDR.Read()
            If Not SQL.SQLDR.IsDBNull(0) Then
                frm_customers.lbl_total_payments.Text = SQL.SQLDR("sum")
            Else
                frm_customers.lbl_total_payments.Text = 0
            End If
            SQL.SQLDR.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'DELETETING SALES TRANS (CUSTOMER)'

    'Delete from dbo.sales_trans_table'
    Sub delete_trans_cust_sales()
        Try
            Dim delete_trans_cust_sales As String = "Delete from sales_trans_table WHERE trans_no = @trans_no"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(delete_trans_cust_sales, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_trans_info.lbl_trans_no.Text)
            SQL.SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'Delete from sales_item_table'
    Sub delete_trans_cust_items()
        Try
            Dim delete_trans_cust_items As String = "Delete from sales_item_table WHERE trans_no = @trans_no"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(delete_trans_cust_items, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_trans_info.lbl_trans_no.Text)
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
            For Each row As DataGridViewRow In frm_trans_info.dgv_sold_items.Rows

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

    'Reprint Receipt'

    Public Sub load_receipt_info()
        Try
            Dim load As String = "SELECT * FROM set_receipt_table"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(load, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            SQL.SQLDR.Read()
            frm_trans_info.store_name = SQL.SQLDR("store_name")
            frm_trans_info.store_address = SQL.SQLDR("store_address")
            frm_trans_info.tin = SQL.SQLDR("tin")
            frm_trans_info.closing_1 = SQL.SQLDR("closing_1")
            frm_trans_info.closing_2 = SQL.SQLDR("closing_2")
            frm_trans_info.closing_3 = SQL.SQLDR("closing_3")
            frm_trans_info.closing_4 = SQL.SQLDR("closing_4")
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
            Dim load As String = "SELECT * FROM sales_item_table WHERE trans_no = '" & frm_trans_info.lbl_trans_no.Text & "' "
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(load, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            frm_trans_info.dgw.Rows.Clear()

            Do While SQL.SQLDR.Read = True

                If SQL.SQLDR("item_name").ToString.Length > 25 Then
                    frm_trans_info.dgw.Rows.Add((SQL.SQLDR("item_name") & vbCrLf & CDec(SQL.SQLDR("qty_sold")) & " X Php " & SQL.SQLDR("price")),
                                                     SQL.SQLDR("total_amount"))
                    frm_trans_info.dgw.Height += 38
                    y += 38
                Else
                    frm_trans_info.dgw.Rows.Add((SQL.SQLDR("item_name") & vbCrLf & CDec(SQL.SQLDR("qty_sold")) & " X Php " & SQL.SQLDR("price")),
                                                        SQL.SQLDR("total_amount"))
                    frm_trans_info.dgw.Height += 19
                    y += 19
                End If
            Loop

            frm_trans_info.pnl_total.Location = New Point(7, 199 + y)
            frm_trans_info.pnl_receipt.Height += y
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'ADJUSTING BEGIN END INV'
    'Dim vegin As Decimal = 0
    'Dim ends As Decimal = 0

    'Public Sub adjusting()
    '    For Each row As DataGridViewRow In frm_trans_info.dgv_sold_items.Rows
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

    '            SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(0).Value)-
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(2).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(1).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_date", DateTime.Now)-
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_type", "SALES CANCEL")-
    '            SQL.SQLCmd.Parameters.AddWithValue("@beg_inv", vegin)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_in", CDec(row.Cells(3).Value))-
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_out", "0")-
    '            SQL.SQLCmd.Parameters.AddWithValue("@end_inv", ends + CDec(row.Cells(3).Value))
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", "0")
    '            SQL.SQLCmd.Parameters.AddWithValue("@price_beg", row.Cells(8).Value * vegin) 'buying price * begin inv qty-
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

    'settingsd date'

    Public Sub load_month()
        Try
            Dim loads As String = "SELECT * FROM dtp_settings WHERE part_of_system = 'cust_trans' "
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(loads, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_customers.month = SQL.SQLDR("months")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'insert sysgen customer payment'
    Public Sub insert_pay_sysgen()
        Try
            Dim inser_pay As String = "INSERT INTO customer_payments_table(date_pay,customer_no,amount_paid)VALUES " & _
               "(@date_pay,@customer_no,@amount_paid)"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(inser_pay, SQL.SQLCon)

            SQL.SQLCmd.Parameters.AddWithValue("@date_pay", DateTime.Now)
            SQL.SQLCmd.Parameters.AddWithValue("@customer_no", frm_customer_add_update.lbl_customer_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@amount_paid", "0.00")
            SQL.SQLCmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

End Class
