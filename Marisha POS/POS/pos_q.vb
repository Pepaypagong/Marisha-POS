Imports System.Data.SqlClient
Imports System.IO

Public Class pos_q

    Dim SQL As New SQLControl

    'add to cart
    Public Sub add_to_cart(item_no As Integer, barcode As String, item_name As String, selling_price As Decimal,
                       quantity As Decimal, unit_of_measure As String, amount As Decimal, buying_price As Decimal,
                       discount As Decimal, category As String)

        frm_invoice.dgv_item_cart.Rows.Add(New Object() _
                             {item_no, barcode, item_name, selling_price, quantity, unit_of_measure, amount, buying_price, discount, category})
    End Sub

    'GENERATE TRANS NO.'
    Public Sub get_trans_no()
        Try
            Dim get_trans_no As String = "SELECT trans_no FROM sales_trans_table ORDER BY trans_no DESC"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_trans_no, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_invoice.lbl_trans_no.Text = SQL.SQLDR("trans_no") + 1
            Else
                frm_invoice.lbl_trans_no.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    Function match_found() As Boolean
        Try
            Dim match_found_con As String = "SELECT * FROM item_table " &
                                  "WHERE barcode ='" & frm_invoice.txt_barcode.Text.Replace("'", "''") & "' "

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(match_found_con, SQL.SQLCon)

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

    Public Sub match_put_to_txt()
        Try
            Dim match_put_to_txt As String = "SELECT * FROM item_table WHERE barcode = '" & frm_invoice.txt_barcode.Text.Replace("'", "''") & "' "
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(match_put_to_txt, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_invoice.m_item_no = SQL.SQLDR("item_no")
                frm_invoice.m_item_name = SQL.SQLDR("item_name")
                frm_invoice.m_barcode = SQL.SQLDR("barcode")
                frm_invoice.m_selling_price = SQL.SQLDR("selling_price")
                frm_invoice.m_buying_price = SQL.SQLDR("buying_price")
                frm_invoice.m_unit = SQL.SQLDR("unit_of_measure")
                frm_invoice.m_category = SQL.SQLDR("category")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'CHANGE QUANTITY GET CURRENT QTY OF THE ITEM'
    Public Sub get_stock_qty()
        Try
            Dim get_stock_qty As String = "SELECT stock_qty FROM item_table WHERE barcode = '" & frm_change_qty.lbl_barcode.Text & "' "
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_stock_qty, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_change_qty.lbl_current_stock_qty.Text = SQL.SQLDR("stock_qty")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'SHOW CUSTOMERS'

    'load CUSTOMERS to frm_showcustomers'
    Public Sub load_customers()
        Using cmd As New SqlCommand("SELECT * FROM customers_table", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_showcustomers.dgv_customers.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_showcustomers.dgv_customers.Columns(0).DataPropertyName = "customer_no"
                    frm_showcustomers.dgv_customers.Columns(1).DataPropertyName = "first_name"
                    frm_showcustomers.dgv_customers.Columns(2).DataPropertyName = "last_name"

                    frm_showcustomers.dgv_customers.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'load CUSTOMERS to frm_showcustomers'
    Public Sub load_search_customers()
        Using cmd As New SqlCommand("SELECT * FROM customers_table " &
                                    "WHERE " & frm_showcustomers.search_field & " like '%" & frm_showcustomers.txt_search.Text.Trim & "%'", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_showcustomers.dgv_customers.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_showcustomers.dgv_customers.Columns(0).DataPropertyName = "customer_no"
                    frm_showcustomers.dgv_customers.Columns(1).DataPropertyName = "first_name"
                    frm_showcustomers.dgv_customers.Columns(2).DataPropertyName = "last_name"

                    frm_showcustomers.dgv_customers.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'Save Transaction To Database'
    '----------------------------CASH---------------------------------'
    'Insert Trans'
    Public Sub insert_sales_trans_cash()
        Try
            Dim insert_sales_trans As String = "INSERT INTO sales_trans_table(trans_no,trans_datetime,cash_or_account, " &
                "customer_no,customer_name,sub_total,dicount_percent,total_discount,grand_total,cash_tendered,change,trans_date,ret_bo_receipt_no,ret_total_amount,ret_bo_remarks,bo_total_amount,customer_partial_payment)VALUES " &
                "(@trans_no,@trans_datetime,@cash_or_account,@customer_no,@customer_name,@sub_total,@dicount_percent,@total_discount, " &
                "@grand_total,@cash_tendered,@change,@trans_date,@ret_bo_receipt_no,@ret_total_amount,@ret_bo_remarks,@bo_total_amount,@customer_partial_payment)"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(insert_sales_trans, SQL.SQLCon)

            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_invoice.lbl_trans_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", DateTime.Now)
            SQL.SQLCmd.Parameters.AddWithValue("@cash_or_account", "Cash")
            SQL.SQLCmd.Parameters.AddWithValue("@customer_no", "")
            SQL.SQLCmd.Parameters.AddWithValue("@customer_name", "CASH")
            SQL.SQLCmd.Parameters.AddWithValue("@sub_total", frm_invoice.lbl_sub_total.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@dicount_percent", frm_invoice.lbl_disc_percent.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@total_discount", frm_invoice.lbl_total_disc.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@grand_total", frm_invoice.lbl_grand_total.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@cash_tendered", frm_pay.txt_tendered.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@change", CDec(frm_pay.txt_tendered.Text) - CDec(frm_invoice.lbl_grand_total.Text))
            SQL.SQLCmd.Parameters.AddWithValue("@trans_date", DateTime.Now)
            SQL.SQLCmd.Parameters.AddWithValue("@ret_bo_receipt_no", "")
            SQL.SQLCmd.Parameters.AddWithValue("@ret_total_amount", "0.00")
            SQL.SQLCmd.Parameters.AddWithValue("@ret_bo_remarks", "")
            SQL.SQLCmd.Parameters.AddWithValue("@bo_total_amount", "0.00")
            SQL.SQLCmd.Parameters.AddWithValue("@customer_partial_payment", frm_invoice.lbl_grand_total.Text)

            SQL.SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'Insert Items'
    Public Sub Insert_sales_items_cash()
        Try
            For Each row As DataGridViewRow In frm_invoice.dgv_item_cart.Rows

                Dim Insert_sales_items_cash As String = "INSERT INTO sales_item_table(trans_no,trans_datetime,cash_or_account, " &
                "customer_no,customer_name,item_no,barcode,item_name,price,qty_sold,total_amount,begin_inv,dicount_percent,trans_date, " &
                "ret_qty, ret_selling_price, ret_grand_total, bo_qty, bo_selling_price, bo_grand_total, ending_inv,purchase_price,unit_of_measure,category)VALUES " &
                "(@trans_no,@trans_datetime,@cash_or_account,@customer_no,@customer_name,@item_no,@barcode,@item_name,@price,@qty_sold,@total_amount,@begin_inv,@dicount_percent,@trans_date," &
                "@ret_qty,@ret_selling_price,@ret_grand_total,@bo_qty,@bo_selling_price,@bo_grand_total,@ending_inv,@purchase_price,@unit_of_measure,@category)"

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(Insert_sales_items_cash, SQL.SQLCon)

                SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_invoice.lbl_trans_no.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", DateTime.Now)
                SQL.SQLCmd.Parameters.AddWithValue("@cash_or_account", "Cash")
                SQL.SQLCmd.Parameters.AddWithValue("@customer_no", "")
                SQL.SQLCmd.Parameters.AddWithValue("@customer_name", "")
                SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(0).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(1).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(2).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@price", row.Cells(3).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@qty_sold", row.Cells(4).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@total_amount", row.Cells(6).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@begin_inv", row.Cells(7).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@dicount_percent", row.Cells(12).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@trans_date", DateTime.Now)
                SQL.SQLCmd.Parameters.AddWithValue("@ret_qty", 0)
                SQL.SQLCmd.Parameters.AddWithValue("@ret_selling_price", row.Cells(3).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@ret_grand_total", 0)
                SQL.SQLCmd.Parameters.AddWithValue("@bo_qty", 0)
                SQL.SQLCmd.Parameters.AddWithValue("@bo_selling_price", row.Cells(3).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@bo_grand_total", 0)
                SQL.SQLCmd.Parameters.AddWithValue("@ending_inv", row.Cells(8).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@purchase_price", row.Cells(9).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@unit_of_measure", row.Cells(5).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@category", row.Cells(13).Value)
                SQL.SQLCmd.ExecuteNonQuery()
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub


    '----------------------------------------- ON ACCOUNT (CUSTOMERS) ---------------------------------------------'
    'Insert Trans cust'
    Public Sub insert_sales_trans_cust()
        Try
            Dim insert_sales_trans_cust As String = "INSERT INTO sales_trans_table(trans_no,trans_datetime,cash_or_account, " &
                "customer_no,customer_name,sub_total,dicount_percent,total_discount,grand_total,cash_tendered,change,trans_date,ret_bo_receipt_no,ret_total_amount,ret_bo_remarks,bo_total_amount,customer_partial_payment)VALUES " &
                "(@trans_no,@trans_datetime,@cash_or_account,@customer_no,@customer_name,@sub_total,@dicount_percent,@total_discount, " &
                "@grand_total,@cash_tendered,@change,@trans_date,@ret_bo_receipt_no,@ret_total_amount,@ret_bo_remarks,@bo_total_amount,@customer_partial_payment)"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(insert_sales_trans_cust, SQL.SQLCon)

            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_invoice.lbl_trans_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", DateTime.Now)
            SQL.SQLCmd.Parameters.AddWithValue("@cash_or_account", "Account")
            SQL.SQLCmd.Parameters.AddWithValue("@customer_no", frm_showcustomers.dgv_customers.Item("customer_no", frm_showcustomers.dgv_customers.CurrentRow.Index).Value.ToString())

            SQL.SQLCmd.Parameters.AddWithValue("@customer_name", frm_showcustomers.dgv_customers.Item("first_name", frm_showcustomers.dgv_customers.CurrentRow.Index).Value.ToString() _
            + " " + frm_showcustomers.dgv_customers.Item("last_name", frm_showcustomers.dgv_customers.CurrentRow.Index).Value.ToString())

            SQL.SQLCmd.Parameters.AddWithValue("@sub_total", frm_invoice.lbl_sub_total.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@dicount_percent", frm_invoice.lbl_disc_percent.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@total_discount", frm_invoice.lbl_total_disc.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@grand_total", frm_invoice.lbl_grand_total.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@cash_tendered", "0.00")
            SQL.SQLCmd.Parameters.AddWithValue("@change", "0.00")
            SQL.SQLCmd.Parameters.AddWithValue("@trans_date", DateTime.Now)
            SQL.SQLCmd.Parameters.AddWithValue("@ret_bo_receipt_no", "")
            SQL.SQLCmd.Parameters.AddWithValue("@ret_total_amount", "0.00")
            SQL.SQLCmd.Parameters.AddWithValue("@ret_bo_remarks", "")
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

    'Insert Transaction Partial (with cash tendered)'
    Public Sub insert_sales_trans_cust_partial()
        Try
            Dim insert_sales_trans_cust_partial As String = "INSERT INTO sales_trans_table(trans_no,trans_datetime,cash_or_account, " &
                "customer_no,customer_name,sub_total,dicount_percent,total_discount,grand_total,cash_tendered,change,trans_date,ret_bo_receipt_no,ret_total_amount,ret_bo_remarks,bo_total_amount,customer_partial_payment)VALUES " &
                "(@trans_no,@trans_datetime,@cash_or_account,@customer_no,@customer_name,@sub_total,@dicount_percent,@total_discount, " &
                "@grand_total,@cash_tendered,@change,@trans_date,@ret_bo_receipt_no,@ret_total_amount,@ret_bo_remarks,@bo_total_amount,@customer_partial_payment)"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(insert_sales_trans_cust_partial, SQL.SQLCon)

            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_invoice.lbl_trans_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", DateTime.Now)
            SQL.SQLCmd.Parameters.AddWithValue("@cash_or_account", "Account")
            SQL.SQLCmd.Parameters.AddWithValue("@customer_no", frm_showcustomers.dgv_customers.Item("customer_no", frm_showcustomers.dgv_customers.CurrentRow.Index).Value.ToString())

            SQL.SQLCmd.Parameters.AddWithValue("@customer_name", frm_showcustomers.dgv_customers.Item("first_name", frm_showcustomers.dgv_customers.CurrentRow.Index).Value.ToString() _
            + " " + frm_showcustomers.dgv_customers.Item("last_name", frm_showcustomers.dgv_customers.CurrentRow.Index).Value.ToString())

            SQL.SQLCmd.Parameters.AddWithValue("@sub_total", frm_invoice.lbl_sub_total.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@dicount_percent", frm_invoice.lbl_disc_percent.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@total_discount", frm_invoice.lbl_total_disc.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@grand_total", frm_invoice.lbl_grand_total.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@cash_tendered", frm_pay.txt_tendered.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@change", CDec(frm_pay.txt_tendered.Text) - CDec(frm_partial_pay.txt_paid_amt.Text))
            SQL.SQLCmd.Parameters.AddWithValue("@trans_date", DateTime.Now)
            SQL.SQLCmd.Parameters.AddWithValue("@ret_bo_receipt_no", "")
            SQL.SQLCmd.Parameters.AddWithValue("@ret_total_amount", "0.00")
            SQL.SQLCmd.Parameters.AddWithValue("@ret_bo_remarks", "")
            SQL.SQLCmd.Parameters.AddWithValue("@bo_total_amount", "0.00")
            SQL.SQLCmd.Parameters.AddWithValue("@customer_partial_payment", frm_partial_pay.txt_paid_amt.Text)

            SQL.SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'Insert Transaction Partial (no cash tendered)'
    Public Sub insert_sales_trans_cust_partial_no_casht()
        Try
            Dim insert_sales_trans_cust_partial_no_casht As String = "INSERT INTO sales_trans_table(trans_no,trans_datetime,cash_or_account, " &
                "customer_no,customer_name,sub_total,dicount_percent,total_discount,grand_total,cash_tendered,change,trans_date,ret_bo_receipt_no,ret_total_amount,ret_bo_remarks,bo_total_amount,customer_partial_payment)VALUES " &
                "(@trans_no,@trans_datetime,@cash_or_account,@customer_no,@customer_name,@sub_total,@dicount_percent,@total_discount, " &
                "@grand_total,@cash_tendered,@change,@trans_date,@ret_bo_receipt_no,@ret_total_amount,@ret_bo_remarks,@bo_total_amount,@customer_partial_payment)"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(insert_sales_trans_cust_partial_no_casht, SQL.SQLCon)

            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_invoice.lbl_trans_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", DateTime.Now)
            SQL.SQLCmd.Parameters.AddWithValue("@cash_or_account", "Account")
            SQL.SQLCmd.Parameters.AddWithValue("@customer_no", frm_showcustomers.dgv_customers.Item("customer_no", frm_showcustomers.dgv_customers.CurrentRow.Index).Value.ToString())

            SQL.SQLCmd.Parameters.AddWithValue("@customer_name", frm_showcustomers.dgv_customers.Item("first_name", frm_showcustomers.dgv_customers.CurrentRow.Index).Value.ToString() _
            + " " + frm_showcustomers.dgv_customers.Item("last_name", frm_showcustomers.dgv_customers.CurrentRow.Index).Value.ToString())

            SQL.SQLCmd.Parameters.AddWithValue("@sub_total", frm_invoice.lbl_sub_total.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@dicount_percent", frm_invoice.lbl_disc_percent.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@total_discount", frm_invoice.lbl_total_disc.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@grand_total", frm_invoice.lbl_grand_total.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@cash_tendered", frm_pay.txt_tendered.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@change", "0.00")
            SQL.SQLCmd.Parameters.AddWithValue("@trans_date", DateTime.Now)
            SQL.SQLCmd.Parameters.AddWithValue("@ret_bo_receipt_no", "")
            SQL.SQLCmd.Parameters.AddWithValue("@ret_total_amount", "0.00")
            SQL.SQLCmd.Parameters.AddWithValue("@ret_bo_remarks", "")
            SQL.SQLCmd.Parameters.AddWithValue("@bo_total_amount", "0.00")
            SQL.SQLCmd.Parameters.AddWithValue("@customer_partial_payment", frm_pay.txt_tendered.Text)

            SQL.SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'Insert Items cust'
    Public Sub Insert_sales_items_cust()
        Try
            For Each row As DataGridViewRow In frm_invoice.dgv_item_cart.Rows

                Dim Insert_sales_items_cash As String = "INSERT INTO sales_item_table(trans_no,trans_datetime,cash_or_account, " &
                "customer_no,customer_name,item_no,barcode,item_name,price,qty_sold,total_amount,begin_inv,dicount_percent,trans_date, " &
                "ret_qty, ret_selling_price, ret_grand_total, bo_qty, bo_selling_price, bo_grand_total,ending_inv,purchase_price,unit_of_measure,category)VALUES " &
                "(@trans_no,@trans_datetime,@cash_or_account,@customer_no,@customer_name,@item_no,@barcode,@item_name,@price,@qty_sold,@total_amount,@begin_inv,@dicount_percent,@trans_date," &
                "@ret_qty,@ret_selling_price,@ret_grand_total,@bo_qty,@bo_selling_price,@bo_grand_total,@ending_inv,@purchase_price,@unit_of_measure,@category)"

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(Insert_sales_items_cash, SQL.SQLCon)

                SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_invoice.lbl_trans_no.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", DateTime.Now)
                SQL.SQLCmd.Parameters.AddWithValue("@cash_or_account", "Account")
                SQL.SQLCmd.Parameters.AddWithValue("@customer_no", frm_showcustomers.dgv_customers.Item("customer_no", frm_showcustomers.dgv_customers.CurrentRow.Index).Value.ToString())

                SQL.SQLCmd.Parameters.AddWithValue("@customer_name", frm_showcustomers.dgv_customers.Item("first_name", frm_showcustomers.dgv_customers.CurrentRow.Index).Value.ToString() _
                + " " + frm_showcustomers.dgv_customers.Item("last_name", frm_showcustomers.dgv_customers.CurrentRow.Index).Value.ToString())

                SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(0).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(1).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(2).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@price", row.Cells(3).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@qty_sold", row.Cells(4).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@total_amount", row.Cells(6).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@begin_inv", row.Cells(7).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@dicount_percent", row.Cells(12).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@trans_date", DateTime.Now)
                SQL.SQLCmd.Parameters.AddWithValue("@ret_qty", 0)
                SQL.SQLCmd.Parameters.AddWithValue("@ret_selling_price", row.Cells(3).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@ret_grand_total", 0)
                SQL.SQLCmd.Parameters.AddWithValue("@bo_qty", 0)
                SQL.SQLCmd.Parameters.AddWithValue("@bo_selling_price", row.Cells(3).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@bo_grand_total", 0)
                SQL.SQLCmd.Parameters.AddWithValue("@ending_inv", row.Cells(8).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@purchase_price", row.Cells(9).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@unit_of_measure", row.Cells(5).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@category", row.Cells(13).Value)
                SQL.SQLCmd.ExecuteNonQuery()
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'Deduct the Quantity of the Sold Items from the items_table (UPDATING)'
    Public Sub deduct_items_qty()
        Try
            For Each row As DataGridViewRow In frm_invoice.dgv_item_cart.Rows

                Dim deduct_items_qty As String = "UPDATE item_table SET stock_qty = stock_qty - @qty_sold WHERE item_no = @item_no "

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(deduct_items_qty, SQL.SQLCon)

                SQL.SQLCmd.Parameters.AddWithValue("@qty_sold", row.Cells(4).Value)
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

    'Fetch Beginning and Ending Inventory'

    ''check if the entry is initial'
    'Function isInit()
    '    Try
    '        Dim match_found_con As String = "SELECT * from begin_end_inv_table " &
    '        "WHERE item_no = '" & frm_invoice.lbl_item_no.Text & "' and trans_date < '" & DateTime.Now.ToString("yyyy/MM/dd") & "' "

    '        SQL.ConnDB()
    '        SQL.SQLCmd = New SqlCommand(match_found_con, SQL.SQLCon)

    '        Using reader As SqlDataReader = SQL.SQLCmd.ExecuteReader
    '            If reader.HasRows = True Thena
    '                Return False
    '            Else
    '                Return True
    '            End If
    '        End Using

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        SQL.SQLCmd.Dispose()
    '        SQL.SQLCon.Close()
    '    End Try
    'End Function

    'if the item is initially added, run this
    'Sub get_initial_beg_inv()
    '    Try
    '        Dim get_initial_beg_inv As String = "Select beginning_inventory FROM item_table WHERE item_no ='" & frm_invoice.lbl_item_no.Text & "'"
    '        SQL.ConnDB()
    '        SQL.SQLCmd = New SqlCommand(get_initial_beg_inv, SQL.SQLCon)
    '        SQL.SQLDR = SQL.SQLCmd.ExecuteReader

    '        If SQL.SQLDR.Read = True Then
    '            frm_invoice.lbl_beginning.Text = SQL.SQLDR("beginning_inventory")
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    Finally
    '        SQL.SQLCmd.Dispose()
    '        SQL.SQLCon.Close()
    '    End Try
    'End Sub

    'Sub get_not_init_beg_inv()
    '    Try
    '        Dim get_not_init_beg_inv As String = "SELECT TOP 1 ID, end_inv, trans_date from begin_end_inv_table " &
    '            "where item_no = '" & frm_invoice.lbl_item_no.Text & "' and trans_date < '" & DateTime.Now.ToString("yyyy/MM/dd") & "' ORDER BY ID DESC"
    '        SQL.ConnDB()
    '        SQL.SQLCmd = New SqlCommand(get_not_init_beg_inv, SQL.SQLCon)
    '        SQL.SQLDR = SQL.SQLCmd.ExecuteReader

    '        If SQL.SQLDR.Read = True Then
    '            frm_invoice.lbl_beginning.Text = SQL.SQLDR("end_inv")
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    Finally
    '        SQL.SQLCmd.Dispose()
    '        SQL.SQLCon.Close()
    '    End Try
    'End Sub

    'Sub get_ending_inv()
    '    Try
    '        Dim get_ending_inv As String = "SELECT stock_qty FROM item_table WHERE item_no = '" & frm_invoice.lbl_item_no.Text & "' "
    '        SQL.ConnDB()
    '        SQL.SQLCmd = New SqlCommand(get_ending_inv, SQL.SQLCon)
    '        SQL.SQLDR = SQL.SQLCmd.ExecuteReader

    '        If SQL.SQLDR.Read = True Then
    '            frm_invoice.lbl_ending.Text = SQL.SQLDR("stock_qty") - 1 'bcause default qty is 1 when add to cart
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    Finally
    '        SQL.SQLCmd.Dispose()
    '        SQL.SQLCon.Close()
    '    End Try
    'End Sub

    ''BEGIN END INVENTORY TABLE  
    'Public Sub insert_begin_end_sales()
    '    Try
    '        For Each row As DataGridViewRow In frm_invoice.dgv_item_cart.Rows

    '            Dim insert_begin_end_purchase As String = "INSERT INTO begin_end_inv_table" & _
    '            "(item_no,item_name,barcode,trans_date,trans_type,beg_inv,item_in,item_out,end_inv,trans_no,price_beg,price_end,trans_datetime,category)VALUES " & _
    '            "(@item_no,@item_name,@barcode,@trans_date,@trans_type,@beg_inv,@item_in,@item_out,@end_inv,@trans_no,@price_beg,@price_end,@trans_datetime,@category)"

    '            SQL.ConnDB()
    '            SQL.SQLCmd = New SqlCommand(insert_begin_end_purchase, SQL.SQLCon)

    '            SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(0).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(2).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(1).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_date", DateTime.Now)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_type", "SALES")
    '            SQL.SQLCmd.Parameters.AddWithValue("@beg_inv", CDec(row.Cells(7).Value))
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_in", "0")
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_out", CDec(row.Cells(4).Value))
    '            SQL.SQLCmd.Parameters.AddWithValue("@end_inv", CDec(row.Cells(8).Value))
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_invoice.lbl_trans_no.Text)
    '            SQL.SQLCmd.Parameters.AddWithValue("@price_beg", row.Cells(9).Value * row.Cells(7).Value) 'buying price * begin inv qty
    '            SQL.SQLCmd.Parameters.AddWithValue("@price_end", row.Cells(9).Value * row.Cells(8).Value) 'buying price * end inv qty
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", DateTime.Now)
    '            SQL.SQLCmd.Parameters.AddWithValue("@category", row.Cells(13).Value)
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
    '        For Each row As DataGridViewRow In frm_invoice.dgv_item_cart.Rows
    '            Dim insert_item As String = "INSERT INTO beg_inv_price_for_incom_state(generate_date,item_no,barcode,item_name,inc_dec,init_price,sys_generated,trans_no,trans_type)VALUES " & _
    '            "(@generate_date,@item_no,@barcode,@item_name,@inc_dec,@init_price,@sys_generated,@trans_no,@trans_type)"

    '            SQL.ConnDB()
    '            SQL.SQLCmd = New SqlCommand(insert_item, SQL.SQLCon)

    '            SQL.SQLCmd.Parameters.AddWithValue("@generate_date", DateTime.Now)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(0).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(1).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(2).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@inc_dec", -1 * row.Cells(10).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@init_price", row.Cells(11).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@sys_generated", "NO")
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_invoice.lbl_trans_no.Text)
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
End Class
