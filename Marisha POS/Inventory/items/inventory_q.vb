Imports System.Data.SqlClient
Imports System.IO

Public Class inventory_q

    Dim SQL As New SQLControl

    'Dashboard'
    Sub show_categories_dash()
        Try
            Dim show_categories As String = "Select * from category_table ORDER BY category_name ASC"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(show_categories, SQL.SQLCon)

            SQL.SQLDR = SQL.SQLCmd.ExecuteReader
            frm_inventory.cbo_category.Items.Clear()
            Do While SQL.SQLDR.Read
                frm_inventory.cbo_category.Items.Add(SQL.SQLDR!category_name)
            Loop
            SQL.SQLDR.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    Public Sub load_item()
        Using cmd As New SqlCommand("SELECT * FROM item_table", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_inventory.dgv_items.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_inventory.dgv_items.Columns(0).DataPropertyName = "item_no"
                    frm_inventory.dgv_items.Columns(1).DataPropertyName = "barcode"
                    frm_inventory.dgv_items.Columns(2).DataPropertyName = "item_name"
                    frm_inventory.dgv_items.Columns(3).DataPropertyName = "selling_price"
                    frm_inventory.dgv_items.Columns(4).DataPropertyName = "buying_price"
                    frm_inventory.dgv_items.Columns(5).DataPropertyName = "avail"
                    frm_inventory.dgv_items.Columns(6).DataPropertyName = "stock_qty"
                    frm_inventory.dgv_items.Columns(7).DataPropertyName = "unit_of_measure"
                    frm_inventory.dgv_items.Columns(8).DataPropertyName = "description"
                    frm_inventory.dgv_items.Columns(9).DataPropertyName = "category"
                    frm_inventory.dgv_items.Columns(10).DataPropertyName = "brand"
                    frm_inventory.dgv_items.Columns(11).DataPropertyName = "beginning_inventory"

                    frm_inventory.dgv_items.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Public Sub load_search_item()
        Using cmd As New SqlCommand("SELECT * FROM item_table " & _
                                    "WHERE " & frm_inventory.search_field & " like '%" & frm_inventory.txt_search.Text.Replace("'", "''").Trim & "%'", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_inventory.dgv_items.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_inventory.dgv_items.Columns(0).DataPropertyName = "item_no"
                    frm_inventory.dgv_items.Columns(1).DataPropertyName = "barcode"
                    frm_inventory.dgv_items.Columns(2).DataPropertyName = "item_name"
                    frm_inventory.dgv_items.Columns(3).DataPropertyName = "selling_price"
                    frm_inventory.dgv_items.Columns(4).DataPropertyName = "buying_price"
                    frm_inventory.dgv_items.Columns(5).DataPropertyName = "avail"
                    frm_inventory.dgv_items.Columns(6).DataPropertyName = "stock_qty"
                    frm_inventory.dgv_items.Columns(7).DataPropertyName = "unit_of_measure"
                    frm_inventory.dgv_items.Columns(8).DataPropertyName = "description"
                    frm_inventory.dgv_items.Columns(9).DataPropertyName = "category"
                    frm_inventory.dgv_items.Columns(10).DataPropertyName = "brand"
                    frm_inventory.dgv_items.Columns(11).DataPropertyName = "beginning_inventory"

                    frm_inventory.dgv_items.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'New item'

    'GET item NO.'
    Public Sub get_item_no()
        Try
            Dim get_item_no As String = "SELECT item_no FROM item_table ORDER BY item_no DESC"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_item_no, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_stock_add_update.lbl_item_no.Text = SQL.SQLDR("item_no") + 1
            Else
                frm_stock_add_update.lbl_item_no.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    Function barcode_exists() As Boolean
        Try
            Dim barcode_exists_con As String = "SELECT * FROM item_table " & _
                                  "WHERE barcode ='" & frm_stock_add_update.txt_barcode.Text & "'"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(barcode_exists_con, SQL.SQLCon)

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

    Function item_name_exists() As Boolean
        Try
            Dim item_name_exists_con As String = "SELECT * FROM item_table " & _
                                  "WHERE item_name ='" & frm_stock_add_update.txt_item_name.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(item_name_exists_con, SQL.SQLCon)

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

    'INSERT item'
    Public Sub insert_item()
        Try
            Dim insert_item As String = "INSERT INTO item_table(item_no,barcode,item_name,selling_price,buying_price,avail,stock_qty,description,category,brand,beginning_inventory,beginning_inventory_price,unit_of_measure)VALUES " & _
            "(@item_no,@barcode,@item_name,@selling_price,@buying_price,@avail,@stock_qty,@description,@category,@brand,@beginning_inventory,@beginning_inventory_price,@unit_of_measure)"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(insert_item, SQL.SQLCon)

            SQL.SQLCmd.Parameters.AddWithValue("@item_no", frm_stock_add_update.lbl_item_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@barcode", frm_stock_add_update.txt_barcode.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@item_name", frm_stock_add_update.txt_item_name.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@selling_price", frm_stock_add_update.txt_selling_price.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@buying_price", frm_stock_add_update.txt_buying_price.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@avail", frm_stock_add_update.cbo_avail.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@stock_qty", frm_stock_add_update.txt_initial_qty.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@description", frm_stock_add_update.txt_desc.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@category", frm_stock_add_update.cbo_category.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@brand", frm_stock_add_update.cbo_brand.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@beginning_inventory", frm_stock_add_update.txt_initial_qty.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@beginning_inventory_price", CDec(frm_stock_add_update.txt_initial_qty.Text * frm_stock_add_update.txt_buying_price.Text))
            SQL.SQLCmd.Parameters.AddWithValue("@unit_of_measure", frm_stock_add_update.cbo_unit.Text)

            SQL.SQLCmd.ExecuteNonQuery()
            MsgBox(" Item Successfully Added!", MsgBoxStyle.Information, " Item Record Created")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try

    End Sub

    'UPDATING CUSTOMERS'
    Sub update_item()
        Try
            Dim update_item As String = "UPDATE item_table SET barcode = @barcode, item_name = @item_name, " & _
            "selling_price = @selling_price, buying_price = @buying_price, avail = @avail, description = @description, " & _
            "category = @category, brand = @brand, unit_of_measure = @unit_of_measure WHERE item_no = @item_no"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(update_item, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@barcode", frm_stock_add_update.txt_barcode.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@item_name", frm_stock_add_update.txt_item_name.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@selling_price", frm_stock_add_update.txt_selling_price.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@buying_price", frm_stock_add_update.txt_buying_price.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@avail", frm_stock_add_update.cbo_avail.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@description", frm_stock_add_update.txt_desc.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@category", frm_stock_add_update.cbo_category.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@brand", frm_stock_add_update.cbo_brand.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@unit_of_measure", frm_stock_add_update.cbo_unit.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@item_no", frm_stock_add_update.lbl_item_no.Text)
            SQL.SQLCmd.ExecuteNonQuery()
            MsgBox(" Item Record Successfully Updated!", MsgBoxStyle.Information, " Record Updated")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try

    End Sub

    'Load Categories'
    Sub show_categories()
        Try
            Dim show_categories As String = "Select * from category_table ORDER BY category_name ASC"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(show_categories, SQL.SQLCon)

            SQL.SQLDR = SQL.SQLCmd.ExecuteReader
            frm_stock_add_update.cbo_category.Items.Clear()
            Do While SQL.SQLDR.Read
                frm_stock_add_update.cbo_category.Items.Add(SQL.SQLDR!category_name)
            Loop
            SQL.SQLDR.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'Load Brands'
    Sub show_brands()
        Try
            Dim show_brands As String = "Select * from brand_table ORDER BY brand_name ASC"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(show_brands, SQL.SQLCon)

            SQL.SQLDR = SQL.SQLCmd.ExecuteReader
            frm_stock_add_update.cbo_brand.Items.Clear()
            Do While SQL.SQLDR.Read
                frm_stock_add_update.cbo_brand.Items.Add(SQL.SQLDR!brand_name)
            Loop
            SQL.SQLDR.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub


    'ADDING STOCKS - PURCHASE TRANSACTION'

    'generate purchase trans_no'
    Public Sub get_purchase_trans_no()
        Try
            Dim get_purchase_trans_no As String = "SELECT trans_no FROM purchase_trans_table ORDER BY trans_no DESC"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_purchase_trans_no, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_addstock.lbl_trans_no.Text = SQL.SQLDR("trans_no") + 1
            Else
                frm_addstock.lbl_trans_no.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'load_suppliers to frm_select_suppliers'
    Public Sub load_suppliers_forselect()
        Using cmd As New SqlCommand("SELECT * FROM supplier_table", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_select_supplier.dgv_suppliers.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_select_supplier.dgv_suppliers.Columns(0).DataPropertyName = "supplier_no"
                    frm_select_supplier.dgv_suppliers.Columns(1).DataPropertyName = "supplier_name"

                    frm_select_supplier.dgv_suppliers.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Public Sub load_suppliers_forselect_search()
        Using cmd As New SqlCommand("SELECT * FROM supplier_table " & _
                                    "WHERE " & frm_select_supplier.search_field & " like '%" & frm_select_supplier.txt_search.Text.Trim & "%'", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_select_supplier.dgv_suppliers.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_select_supplier.dgv_suppliers.Columns(0).DataPropertyName = "supplier_no"
                    frm_select_supplier.dgv_suppliers.Columns(1).DataPropertyName = "supplier_name"

                    frm_select_supplier.dgv_suppliers.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'load_items to frm_select_items'
    Public Sub load_item_forselect()
        Using cmd As New SqlCommand("SELECT * FROM item_table", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_select_item.dgv_items.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_select_item.dgv_items.Columns(0).DataPropertyName = "item_no"
                    frm_select_item.dgv_items.Columns(1).DataPropertyName = "barcode"
                    frm_select_item.dgv_items.Columns(2).DataPropertyName = "item_name"
                    frm_select_item.dgv_items.Columns(3).DataPropertyName = "selling_price"
                    frm_select_item.dgv_items.Columns(4).DataPropertyName = "buying_price"
                    frm_select_item.dgv_items.Columns(5).DataPropertyName = "avail"
                    frm_select_item.dgv_items.Columns(6).DataPropertyName = "stock_qty"
                    frm_select_item.dgv_items.Columns(7).DataPropertyName = "unit_of_measure"
                    frm_select_item.dgv_items.Columns(8).DataPropertyName = "description"
                    frm_select_item.dgv_items.Columns(9).DataPropertyName = "category"
                    frm_select_item.dgv_items.Columns(10).DataPropertyName = "brand"
                    frm_select_item.dgv_items.Columns(11).DataPropertyName = "beginning_inventory_price"
                    frm_select_item.dgv_items.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Public Sub load_item_forselect_search()
        Using cmd As New SqlCommand("SELECT * FROM item_table " & _
                                    "WHERE " & frm_select_item.search_field & " like '%" & frm_select_item.txt_search.Text.Trim & "%'", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_select_item.dgv_items.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_select_item.dgv_items.Columns(0).DataPropertyName = "item_no"
                    frm_select_item.dgv_items.Columns(1).DataPropertyName = "barcode"
                    frm_select_item.dgv_items.Columns(2).DataPropertyName = "item_name"
                    frm_select_item.dgv_items.Columns(3).DataPropertyName = "selling_price"
                    frm_select_item.dgv_items.Columns(4).DataPropertyName = "buying_price"
                    frm_select_item.dgv_items.Columns(5).DataPropertyName = "avail"
                    frm_select_item.dgv_items.Columns(6).DataPropertyName = "stock_qty"
                    frm_select_item.dgv_items.Columns(7).DataPropertyName = "unit_of_measure"
                    frm_select_item.dgv_items.Columns(8).DataPropertyName = "description"
                    frm_select_item.dgv_items.Columns(9).DataPropertyName = "category"
                    frm_select_item.dgv_items.Columns(10).DataPropertyName = "brand"
                    frm_select_item.dgv_items.Columns(11).DataPropertyName = "beginning_inventory_price"

                    frm_select_item.dgv_items.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'INSERT PURCHASE TRANSACTION'
    Public Sub insert_purchase_trans()
        Try
            Dim insert_purchase_trans As String = "INSERT INTO purchase_trans_table(trans_no,trans_date,ref_no, " & _
                "supplier_no,supplier_name,sub_total,total_discount,grand_total,purchase_or_returns,total_return_price)VALUES " & _
                "(@trans_no,@trans_date,@ref_no,@supplier_no,@supplier_name,@sub_total,@total_discount,@grand_total,@purchase_or_returns,@total_return_price)"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(insert_purchase_trans, SQL.SQLCon)

            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_addstock.lbl_trans_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_date", frm_addstock.dtp_date.Value)
            SQL.SQLCmd.Parameters.AddWithValue("@ref_no", frm_addstock.txt_ref_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@supplier_no", frm_addstock.lbl_supplier_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@supplier_name", frm_addstock.lbl_supplier_name.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@sub_total", frm_addstock.lbl_sub_total_grand.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@total_discount", frm_addstock.lbl_total_discount.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@grand_total", frm_addstock.lbl_grand_total.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@purchase_or_returns", "Purchase")
            SQL.SQLCmd.Parameters.AddWithValue("@total_return_price", "0")

            SQL.SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'INSERT PURCHASE TRANSACTION ITEMS ( MULTIPLE ENTRIES) '
    Public Sub insert_purchase_items()
        Try
            For Each row As DataGridViewRow In frm_addstock.dgv_purchase_list.Rows

                Dim insert_purchase_items As String = "INSERT INTO purchase_item_table(trans_no,trans_date,supplier_no, " & _
                "item_no,barcode,item_name,category,brand,begin_inv,qty_purchased,buying_price,total_price,discount,total_after_discount,purchase_or_returns,qty_returned,return_buying_price,total_return_price,ending_inv,unit_of_measure)VALUES " & _
                "(@trans_no,@trans_date,@supplier_no,@item_no,@barcode,@item_name,@category,@brand,@begin_inv,@qty_purchased,@buying_price,@total_price,@discount,@total_after_discount,@purchase_or_returns,@qty_returned,@return_buying_price,@total_return_price,@ending_inv,@unit_of_measure)"

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(insert_purchase_items, SQL.SQLCon)

                SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_addstock.lbl_trans_no.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@trans_date", frm_addstock.dtp_date.Value)
                SQL.SQLCmd.Parameters.AddWithValue("@supplier_no", frm_addstock.lbl_supplier_no.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(0).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(1).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(2).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@category", row.Cells(3).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@brand", row.Cells(4).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@begin_inv", row.Cells(11).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@qty_purchased", row.Cells(6).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@buying_price", row.Cells(8).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@total_price", CDec(row.Cells(6).Value * row.Cells(8).Value))
                SQL.SQLCmd.Parameters.AddWithValue("@discount", row.Cells(9).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@total_after_discount", row.Cells(10).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@purchase_or_returns", "Purchase")
                SQL.SQLCmd.Parameters.AddWithValue("@qty_returned", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@return_buying_price", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@total_return_price", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@ending_inv", row.Cells(12).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@unit_of_measure", row.Cells(7).Value)
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
    Public Sub add_stock_qty()
        Try
            For Each row As DataGridViewRow In frm_addstock.dgv_purchase_list.Rows

                Dim add_stock_qty As String = "UPDATE item_table SET stock_qty = stock_qty + @qty_purchased WHERE item_no = @item_no "

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(add_stock_qty, SQL.SQLCon)

                SQL.SQLCmd.Parameters.AddWithValue("@qty_purchased", row.Cells(6).Value)
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

    '-------------------------PURCHASE RETURN----------------------------'
    'generate RETURN trans_no'
    Public Sub get_return_trans_no()
        Try
            Dim get_return_trans_no As String = "SELECT trans_no FROM purchase_trans_table ORDER BY trans_no DESC"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_return_trans_no, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_purchase_return.lbl_trans_no.Text = SQL.SQLDR("trans_no") + 1
            Else
                frm_purchase_return.lbl_trans_no.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'INSERT PURCHASE RETURN TRANSACTION'
    Public Sub insert_purchase_return_trans()
        Try
            Dim insert_purchase_trans As String = "INSERT INTO purchase_trans_table(trans_no,trans_date,ref_no, " & _
                "supplier_no,supplier_name,sub_total,total_discount,grand_total,purchase_or_returns,total_return_price)VALUES " & _
                "(@trans_no,@trans_date,@ref_no,@supplier_no,@supplier_name,@sub_total,@total_discount,@grand_total,@purchase_or_returns,@total_return_price)"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(insert_purchase_trans, SQL.SQLCon)

            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_purchase_return.lbl_trans_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_date", frm_purchase_return.dtp_date.Value)
            SQL.SQLCmd.Parameters.AddWithValue("@ref_no", frm_purchase_return.txt_ref_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@supplier_no", frm_purchase_return.lbl_supplier_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@supplier_name", frm_purchase_return.lbl_supplier_name.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@sub_total", "0")
            SQL.SQLCmd.Parameters.AddWithValue("@total_discount", "0")
            SQL.SQLCmd.Parameters.AddWithValue("@grand_total", "0")
            SQL.SQLCmd.Parameters.AddWithValue("@purchase_or_returns", "Returns")
            SQL.SQLCmd.Parameters.AddWithValue("@total_return_price", frm_purchase_return.lbl_grand_total.Text)

            SQL.SQLCmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'INSERT PURCHASE RETURN TRANSACTION ITEMS ( MULTIPLE ENTRIES) '
    Public Sub insert_purchase_return_items()
        Try
            For Each row As DataGridViewRow In frm_purchase_return.dgv_purchase_list.Rows

                Dim insert_purchase_items As String = "INSERT INTO purchase_item_table(trans_no,trans_date,supplier_no, " & _
                "item_no,barcode,item_name,category,brand,begin_inv,qty_purchased,buying_price,total_price,discount,total_after_discount,purchase_or_returns,qty_returned,return_buying_price,total_return_price,ending_inv,unit_of_measure)VALUES " & _
                "(@trans_no,@trans_date,@supplier_no,@item_no,@barcode,@item_name,@category,@brand,@begin_inv,@qty_purchased,@buying_price,@total_price,@discount,@total_after_discount,@purchase_or_returns,@qty_returned,@return_buying_price,@total_return_price,@ending_inv,@unit_of_measure)"

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(insert_purchase_items, SQL.SQLCon)

                SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_purchase_return.lbl_trans_no.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@trans_date", frm_purchase_return.dtp_date.Value)
                SQL.SQLCmd.Parameters.AddWithValue("@supplier_no", frm_purchase_return.lbl_supplier_no.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(0).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(1).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(2).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@category", row.Cells(3).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@brand", row.Cells(4).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@begin_inv", row.Cells(10).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@qty_purchased", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@buying_price", row.Cells(8).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@total_price", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@discount", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@total_after_discount", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@purchase_or_returns", "Returns")
                SQL.SQLCmd.Parameters.AddWithValue("@qty_returned", row.Cells(6).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@return_buying_price", row.Cells(8).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@total_return_price", CDec(row.Cells(6).Value * row.Cells(8).Value))
                SQL.SQLCmd.Parameters.AddWithValue("@ending_inv", row.Cells(11).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@unit_of_measure", row.Cells(7).Value)

                SQL.SQLCmd.ExecuteNonQuery()
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'UPDATE STOCK QTY Reduce ( MULTIPLE ENTRIES) '
    Public Sub reduce_stock_qty()
        Try
            For Each row As DataGridViewRow In frm_purchase_return.dgv_purchase_list.Rows

                Dim reduce_stock_qty As String = "UPDATE item_table SET stock_qty = stock_qty - @qty_returned WHERE item_no = @item_no "

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(reduce_stock_qty, SQL.SQLCon)

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

    'Fetch Beginning and Ending Inventory - add stocks'

    'check if the entry is initial'
    Function isInit()
        Try
            Dim match_found_con As String = "SELECT * from begin_end_inv_table " & _
            "WHERE item_no = '" & frm_addstock.lbl_item_no.Text & "' and trans_date < '" & frm_addstock.dtp_date.Value.ToString("yyyy/MM/dd") & "' "

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
            Dim get_initial_beg_inv As String = "Select beginning_inventory FROM item_table WHERE item_no ='" & frm_addstock.lbl_item_no.Text & "'"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_initial_beg_inv, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_addstock.lbl_beginning.Text = SQL.SQLDR("beginning_inventory")
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
                "where item_no = '" & frm_addstock.lbl_item_no.Text & "' and trans_date < '" & frm_addstock.dtp_date.Value.ToString("yyyy/MM/dd") & "' ORDER BY ID DESC"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_not_init_beg_inv, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_addstock.lbl_beginning.Text = SQL.SQLDR("end_inv")
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
            Dim get_ending_inv As String = "SELECT stock_qty FROM item_table WHERE item_no = '" & frm_addstock.lbl_item_no.Text & "' "
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_ending_inv, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_addstock.lbl_ending.Text = SQL.SQLDR("stock_qty")
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
    '        For Each row As DataGridViewRow In frm_addstock.dgv_purchase_list.Rows

    '            Dim insert_begin_end_purchase As String = "INSERT INTO begin_end_inv_table" & _
    '            "(item_no,item_name,barcode,trans_date,trans_type,beg_inv,item_in,item_out,end_inv,trans_no,price_beg,price_end,trans_datetime,category)VALUES " & _
    '            "(@item_no,@item_name,@barcode,@trans_date,@trans_type,@beg_inv,@item_in,@item_out,@end_inv,@trans_no,@price_beg,@price_end,@trans_datetime,@category)"

    '            SQL.ConnDB()
    '            SQL.SQLCmd = New SqlCommand(insert_begin_end_purchase, SQL.SQLCon)

    '            SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(0).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(2).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(1).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_date", frm_addstock.dtp_date.Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_type", "PURCHASE")
    '            SQL.SQLCmd.Parameters.AddWithValue("@beg_inv", row.Cells(11).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_in", row.Cells(6).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_out", "0")
    '            SQL.SQLCmd.Parameters.AddWithValue("@end_inv", row.Cells(12).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_addstock.lbl_trans_no.Text)
    '            SQL.SQLCmd.Parameters.AddWithValue("@price_beg", row.Cells(8).Value * row.Cells(11).Value) 'buying price * begin inv qty
    '            SQL.SQLCmd.Parameters.AddWithValue("@price_end", row.Cells(8).Value * row.Cells(12).Value) 'buying price * end inv qty
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", frm_addstock.dtp_date.Value)
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
    '        For Each row As DataGridViewRow In frm_addstock.dgv_purchase_list.Rows
    '            Dim insert_item As String = "INSERT INTO beg_inv_price_for_incom_state(generate_date,item_no,barcode,item_name,inc_dec,init_price,sys_generated,trans_no,trans_type)VALUES " & _
    '            "(@generate_date,@item_no,@barcode,@item_name,@inc_dec,@init_price,@sys_generated,@trans_no,@trans_type)"

    '            SQL.ConnDB()
    '            SQL.SQLCmd = New SqlCommand(insert_item, SQL.SQLCon)

    '            SQL.SQLCmd.Parameters.AddWithValue("@generate_date", frm_addstock.dtp_date.Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(0).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(1).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(2).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@inc_dec", row.Cells(13).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@init_price", row.Cells(14).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@sys_generated", "NO")
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_addstock.lbl_trans_no.Text)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_type", "PURCHASE")

    '            SQL.SQLCmd.ExecuteNonQuery()
    '        Next
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        SQL.SQLCmd.Dispose()
    '        SQL.SQLCon.Close()
    '    End Try
    'End Sub


    'Fetch Beginning and Ending Inventory - return stocks (PURCHASE RETURNS)'

    'check if the entry is initial'
    Function isInit_ret()
        Try
            Dim match_found_con As String = "SELECT * from begin_end_inv_table " & _
            "WHERE item_no = '" & frm_purchase_return.lbl_item_no.Text & "' and trans_date < '" & frm_purchase_return.dtp_date.Value.ToString("yyyy/MM/dd") & "' "

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
    Sub get_initial_beg_inv_ret()
        Try
            Dim get_initial_beg_inv_ret As String = "Select beginning_inventory FROM item_table WHERE item_no ='" & frm_purchase_return.lbl_item_no.Text & "'"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_initial_beg_inv_ret, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_purchase_return.lbl_beginning.Text = SQL.SQLDR("beginning_inventory")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'if item is not initial '
    Sub get_not_init_beg_inv_ret()
        Try
            Dim get_not_init_beg_inv_ret As String = "SELECT TOP 1 ID, end_inv, trans_date from begin_end_inv_table " & _
                "where item_no = '" & frm_purchase_return.lbl_item_no.Text & "' and trans_date < '" & frm_purchase_return.dtp_date.Value.ToString("yyyy/MM/dd") & "' ORDER BY ID DESC"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_not_init_beg_inv_ret, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_purchase_return.lbl_beginning.Text = SQL.SQLDR("end_inv")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    Sub get_ending_inv_ret()
        Try
            Dim get_ending_inv_ret As String = "SELECT stock_qty FROM item_table WHERE item_no = '" & frm_purchase_return.lbl_item_no.Text & "' "
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_ending_inv_ret, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_purchase_return.lbl_ending.Text = SQL.SQLDR("stock_qty")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    ''BEGIN END INVENTORY TABLE  - purchase retrn
    'Public Sub insert_begin_end_purchase_ret()
    '    Try
    '        For Each row As DataGridViewRow In frm_purchase_return.dgv_purchase_list.Rows

    '            Dim insert_begin_end_purchase_ret As String = "INSERT INTO begin_end_inv_table" & _
    '            "(item_no,item_name,barcode,trans_date,trans_type,beg_inv,item_in,item_out,end_inv,trans_no,price_beg,price_end,trans_datetime,category)VALUES " & _
    '            "(@item_no,@item_name,@barcode,@trans_date,@trans_type,@beg_inv,@item_in,@item_out,@end_inv,@trans_no,@price_beg,@price_end,@trans_datetime,@category)"

    '            SQL.ConnDB()
    '            SQL.SQLCmd = New SqlCommand(insert_begin_end_purchase_ret, SQL.SQLCon)

    '            SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(0).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(2).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(1).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_date", frm_purchase_return.dtp_date.Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_type", "PURCHASE RETURN")
    '            SQL.SQLCmd.Parameters.AddWithValue("@beg_inv", row.Cells(10).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_in", "0")
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_out", row.Cells(6).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@end_inv", row.Cells(11).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_purchase_return.lbl_trans_no.Text)
    '            SQL.SQLCmd.Parameters.AddWithValue("@price_beg", row.Cells(8).Value * row.Cells(10).Value) 'buying price * begin inv qty
    '            SQL.SQLCmd.Parameters.AddWithValue("@price_end", row.Cells(8).Value * row.Cells(11).Value) 'buying price * end inv qty
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", frm_purchase_return.dtp_date.Value)
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
    'Public Sub insert_beg_inv_price_ret()
    '    Try
    '        For Each row As DataGridViewRow In frm_purchase_return.dgv_purchase_list.Rows
    '            Dim insert_item As String = "INSERT INTO beg_inv_price_for_incom_state(generate_date,item_no,barcode,item_name,inc_dec,init_price,sys_generated,trans_no,trans_type)VALUES " & _
    '            "(@generate_date,@item_no,@barcode,@item_name,@inc_dec,@init_price,@sys_generated,@trans_no,@trans_type)"

    '            SQL.ConnDB()
    '            SQL.SQLCmd = New SqlCommand(insert_item, SQL.SQLCon)

    '            SQL.SQLCmd.Parameters.AddWithValue("@generate_date", frm_purchase_return.dtp_date.Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(0).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(1).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(2).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@inc_dec", -1 * row.Cells(12).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@init_price", row.Cells(13).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@sys_generated", "NO")
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", frm_purchase_return.lbl_trans_no.Text)
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_type", "PURCHASE")

    '            SQL.SQLCmd.ExecuteNonQuery()
    '        Next
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        SQL.SQLCmd.Dispose()
    '        SQL.SQLCon.Close()
    '    End Try
    'End Sub

    'system generated for begin inv. income statement on every item insert'
    'Public Sub insert_sys_gen_beg_inv()
    '    Try
    '        Dim insert_item As String = "INSERT INTO beg_inv_price_for_incom_state(generate_date,item_no,barcode,item_name,inc_dec,init_price,sys_generated,trans_no,trans_type)VALUES " & _
    '        "(@generate_date,@item_no,@barcode,@item_name,@inc_dec,@init_price,@sys_generated,@trans_no,@trans_type)"

    '        SQL.ConnDB()
    '        SQL.SQLCmd = New SqlCommand(insert_item, SQL.SQLCon)

    '        SQL.SQLCmd.Parameters.AddWithValue("@generate_date", DateTime.Now)
    '        SQL.SQLCmd.Parameters.AddWithValue("@item_no", frm_stock_add_update.lbl_item_no.Text)
    '        SQL.SQLCmd.Parameters.AddWithValue("@barcode", frm_stock_add_update.txt_barcode.Text)
    '        SQL.SQLCmd.Parameters.AddWithValue("@item_name", frm_stock_add_update.txt_item_name.Text)
    '        SQL.SQLCmd.Parameters.AddWithValue("@inc_dec", "0.00")
    '        SQL.SQLCmd.Parameters.AddWithValue("@init_price", CDec(frm_stock_add_update.txt_initial_qty.Text * frm_stock_add_update.txt_buying_price.Text))
    '        SQL.SQLCmd.Parameters.AddWithValue("@sys_generated", "YES")
    '        SQL.SQLCmd.Parameters.AddWithValue("@trans_no", "0")
    '        SQL.SQLCmd.Parameters.AddWithValue("@trans_type", "SYSTEM GEN")

    '        SQL.SQLCmd.ExecuteNonQuery()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        SQL.SQLCmd.Dispose()
    '        SQL.SQLCon.Close()
    '    End Try
    'End Sub

    'insert begin end system generated'
    Public Sub insert_sysgen_inv_begin_end()
        Try
            Dim insert_begin_end_purchase As String = "INSERT INTO begin_end_inv_table" & _
                "(item_no,item_name,barcode,trans_date,trans_type,beg_inv,item_in,item_out,end_inv,trans_no,price_beg,price_end,trans_datetime,category)VALUES " & _
                "(@item_no,@item_name,@barcode,@trans_date,@trans_type,@beg_inv,@item_in,@item_out,@end_inv,@trans_no,@price_beg,@price_end,@trans_datetime,@category)"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(insert_begin_end_purchase, SQL.SQLCon)

            SQL.SQLCmd.Parameters.AddWithValue("@item_no", frm_stock_add_update.lbl_item_no.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@item_name", frm_stock_add_update.txt_item_name.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@barcode", frm_stock_add_update.txt_barcode.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_date", DateTime.Now)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_type", "INITIAL SYSGEN")
            SQL.SQLCmd.Parameters.AddWithValue("@beg_inv", frm_stock_add_update.txt_initial_qty.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@item_in", "0")
            SQL.SQLCmd.Parameters.AddWithValue("@item_out", "0")
            SQL.SQLCmd.Parameters.AddWithValue("@end_inv", frm_stock_add_update.txt_initial_qty.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", "0")
            SQL.SQLCmd.Parameters.AddWithValue("@price_beg", CDec(frm_stock_add_update.txt_buying_price.Text * frm_stock_add_update.txt_initial_qty.Text)) 'buying price * begin inv qty
            SQL.SQLCmd.Parameters.AddWithValue("@price_end", CDec(frm_stock_add_update.txt_buying_price.Text * frm_stock_add_update.txt_initial_qty.Text)) 'buying price * end inv qty
            SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", DateTime.Now)
            SQL.SQLCmd.Parameters.AddWithValue("@category", frm_stock_add_update.cbo_category.Text)
            SQL.SQLCmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

End Class
