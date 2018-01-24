Imports System.Data.SqlClient
Imports System.IO

Public Class login_q

    Private SQL As New SQLControl

    'AUTHENTICATE LOGIN'

    Function IsAuthenticated() As Boolean
        If SQL.SQLCon.State = ConnectionState.Open Then
            SQL.SQLCon.Close()
        End If
        'CLEAR EXISTING RECORDS
        If SQL.SQLDS IsNot Nothing Then
            SQL.SQLDS.Clear()
        End If

        SQL.RunQuery("SELECT Count(username) As UserCount " & _
                     "FROM accounts_table " & _
                     "WHERE username='" & frm_login.txt_username.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS" & _
                     " AND password='" & frm_login.txt_password.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS")

        If SQL.SQLDS.Tables(0).Rows(0).Item("UserCount") = 1 Then
            Return True
        End If

        MsgBox("Invalid User Credentials.", MsgBoxStyle.Critical, "LOGIN FAILED")
        frm_login.txt_password.Text = ""
        frm_login.txt_username.Text = ""
        frm_login.txt_username.Focus()
        Return False
    End Function


    'CHOOSE USER'

    'FETCH LOGIN'
    Sub get_user_info()
        Try
            Dim get_user_info As String = "SELECT * FROM accounts_table WHERE " & _
                "username = '" & frm_login.txt_username.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS " & _
                "and password = '" & frm_login.txt_password.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_user_info, SQL.SQLCon)

            SQL.SQLDR = SQL.SQLCmd.ExecuteReader
            SQL.SQLDR.Read()

            frm_choose.lbl_account_no.Text = SQL.SQLDR(0)
            frm_choose.lbl_name.Text = SQL.SQLDR(3) + " " + SQL.SQLDR(4) + " " + SQL.SQLDR(5)
            'POS
            If SQL.SQLDR(6).ToString = "YES" Then
                frm_choose.pos_sales_trans = True
            End If
            If SQL.SQLDR(7).ToString = "YES" Then
                frm_choose.pos_receipt = True
            End If

            'INVENTORY
            If SQL.SQLDR(8).ToString = "YES" Then
                frm_choose.inv_category = True
            End If
            If SQL.SQLDR(9).ToString = "YES" Then
                frm_choose.inv_brands = True
            End If
            If SQL.SQLDR(10).ToString = "YES" Then
                frm_choose.inv_add_item = True
            End If
            If SQL.SQLDR(11).ToString = "YES" Then
                frm_choose.inv_updt_item = True
            End If
            If SQL.SQLDR(12).ToString = "YES" Then
                frm_choose.inv_add_stocks = True
            End If
            If SQL.SQLDR(13).ToString = "YES" Then
                frm_choose.inv_purchase_return = True
            End If
            If SQL.SQLDR(14).ToString = "YES" Then
                frm_choose.inv_report_inv = True
            End If
            If SQL.SQLDR(15).ToString = "YES" Then
                frm_choose.inv_report_pur = True
            End If
            If SQL.SQLDR(16).ToString = "YES" Then
                frm_choose.inv_report_sales = True
            End If

            'SALES
            If SQL.SQLDR(17).ToString = "YES" Then
                frm_choose.sales_report_remit = True
            End If
            If SQL.SQLDR(18).ToString = "YES" Then
                frm_choose.sales_report_incstate = True
            End If

            'CUSTOMER
            If SQL.SQLDR(19).ToString = "YES" Then
                frm_choose.cust_add_cust = True
            End If
            If SQL.SQLDR(20).ToString = "YES" Then
                frm_choose.cust_updt_cust = True
            End If
            If SQL.SQLDR(21).ToString = "YES" Then
                frm_choose.cust_balpay = True
            End If
            If SQL.SQLDR(22).ToString = "YES" Then
                frm_choose.cust_report_acc_receive = True
            End If
            If SQL.SQLDR(23).ToString = "YES" Then
                frm_choose.cust_cash_trans = True
            End If
            If SQL.SQLDR(24).ToString = "YES" Then
                frm_choose.cust_return_trans = True
            End If
            If SQL.SQLDR(25).ToString = "YES" Then
                frm_choose.cust_bo_trans = True
            End If

            'SUPPLIERS'
            If SQL.SQLDR(26).ToString = "YES" Then
                frm_choose.supp_add_supp = True
            End If
            If SQL.SQLDR(27).ToString = "YES" Then
                frm_choose.supp_updt_supp = True
            End If

            'admin'
            If SQL.SQLDR(28).ToString = "YES" Then
                frm_choose.admin = True
            End If

            frm_choose.lbl_position.Text = SQL.SQLDR(30)

            SQL.SQLDR.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'fetch login user image'
    Sub retrieve_user_pic()
        'retrieve picture'
        Try
            Dim retrieve_pic As String = "SELECT picture FROM accounts_table where account_no = '" & frm_choose.lbl_account_no.Text & "' "
            Dim stream As New MemoryStream()
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(retrieve_pic, SQL.SQLCon)
            Dim image As Byte() = DirectCast(SQL.SQLCmd.ExecuteScalar(), Byte())

            stream.Write(image, 0, image.Length)
            Dim bitmap As New Bitmap(stream)
            frm_choose.pic_user.Image = bitmap 'to frm_accounts'
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'CREATE INITIAL ADMIN'

    'check if admin account already exists
    Function admin_exists() As Boolean
        Try
            Dim admin_exists_con As String = "SELECT * FROM accounts_table " & _
                                  "WHERE admin = 'YES'"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(admin_exists_con, SQL.SQLCon)

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

    'INSERT INITIAL ADMIN ACCOUNT'
    Public Sub insert_account()

        If frm_initial_admin.imgName <> "" Then
            Dim fs As FileStream
            fs = New FileStream(frm_initial_admin.imgName, FileMode.Open, FileAccess.Read)
            Dim picByte As Byte() = New Byte(fs.Length - 1) {}
            fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))
            fs.Close()

            Try
                Dim insert_account As String = "INSERT INTO accounts_table(account_no,username,password,first_name,middle_name,last_name," & _
                "pos_sales_trans,pos_receipt,inv_category,inv_brands,inv_add_item,inv_updt_item,inv_add_stocks,inv_purchase_return,inv_report_inv," & _
                "inv_report_pur,inv_report_sales,sales_report_remit,sales_report_incstate,cust_add_cust,cust_updt_cust,cust_balpay,cust_report_acc_receive," & _
                "cust_cash_trans,cust_return_trans,cust_bo_trans,supp_add_supp,supp_updt_supp,admin,position,picture)VALUES " & _
                "(@account_no,@username,@password,@first_name,@middle_name,@last_name," & _
                "@pos_sales_trans,@pos_receipt,@inv_category,@inv_brands,@inv_add_item,@inv_updt_item,@inv_add_stocks,@inv_purchase_return,@inv_report_inv," & _
                "@inv_report_pur,@inv_report_sales,@sales_report_remit,@sales_report_incstate,@cust_add_cust,@cust_updt_cust,@cust_balpay,@cust_report_acc_receive," & _
                "@cust_cash_trans,@cust_return_trans,@cust_bo_trans,@supp_add_supp,@supp_updt_supp,@admin,@position,@picture)"

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(insert_account, SQL.SQLCon)

                SQL.SQLCmd.Parameters.AddWithValue("@account_no", frm_initial_admin.lbl_account_no.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@username", frm_initial_admin.txt_username.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@password", frm_initial_admin.txt_password.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@first_name", frm_initial_admin.txt_fname.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@middle_name", frm_initial_admin.txt_mname.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@last_name", frm_initial_admin.txt_lname.Text)
                SQL.SQLCmd.Parameters.AddWithValue("pos_sales_trans", "YES")
                SQL.SQLCmd.Parameters.AddWithValue("pos_receipt", "YES")
                SQL.SQLCmd.Parameters.AddWithValue("inv_category", "YES")
                SQL.SQLCmd.Parameters.AddWithValue("inv_brands", "YES")
                SQL.SQLCmd.Parameters.AddWithValue("inv_add_item", "YES")
                SQL.SQLCmd.Parameters.AddWithValue("inv_updt_item", "YES")
                SQL.SQLCmd.Parameters.AddWithValue("inv_add_stocks", "YES")
                SQL.SQLCmd.Parameters.AddWithValue("inv_purchase_return", "YES")
                SQL.SQLCmd.Parameters.AddWithValue("inv_report_inv", "YES")
                SQL.SQLCmd.Parameters.AddWithValue("inv_report_pur", "YES")
                SQL.SQLCmd.Parameters.AddWithValue("inv_report_sales", "YES")
                SQL.SQLCmd.Parameters.AddWithValue("sales_report_remit", "YES")
                SQL.SQLCmd.Parameters.AddWithValue("sales_report_incstate", "YES")
                SQL.SQLCmd.Parameters.AddWithValue("cust_add_cust", "YES")
                SQL.SQLCmd.Parameters.AddWithValue("cust_updt_cust", "YES")
                SQL.SQLCmd.Parameters.AddWithValue("cust_balpay", "YES")
                SQL.SQLCmd.Parameters.AddWithValue("cust_report_acc_receive", "YES")
                SQL.SQLCmd.Parameters.AddWithValue("cust_cash_trans", "YES")
                SQL.SQLCmd.Parameters.AddWithValue("cust_return_trans", "YES")
                SQL.SQLCmd.Parameters.AddWithValue("cust_bo_trans", "YES")
                SQL.SQLCmd.Parameters.AddWithValue("supp_add_supp", "YES")
                SQL.SQLCmd.Parameters.AddWithValue("supp_updt_supp", "YES")
                SQL.SQLCmd.Parameters.AddWithValue("admin", "YES")
                SQL.SQLCmd.Parameters.AddWithValue("@position", frm_initial_admin.txt_position.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@Picture", picByte)

                SQL.SQLCmd.ExecuteNonQuery()
                MsgBox(" Admin Account Successfully Saved!", MsgBoxStyle.Information, " Account Created")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                SQL.SQLCmd.Dispose()
                SQL.SQLCon.Close()
            End Try

        End If
    End Sub

    'load items for system entry'
    Public Sub load_item()
        Using cmd As New SqlCommand("SELECT * FROM item_table", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_login.dgv_items.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_login.dgv_items.Columns(0).DataPropertyName = "item_no"
                    frm_login.dgv_items.Columns(1).DataPropertyName = "barcode"
                    frm_login.dgv_items.Columns(2).DataPropertyName = "item_name"
                    frm_login.dgv_items.Columns(3).DataPropertyName = "selling_price"
                    frm_login.dgv_items.Columns(4).DataPropertyName = "buying_price"
                    frm_login.dgv_items.Columns(5).DataPropertyName = "avail"
                    frm_login.dgv_items.Columns(6).DataPropertyName = "stock_qty"
                    frm_login.dgv_items.Columns(7).DataPropertyName = "description"
                    frm_login.dgv_items.Columns(8).DataPropertyName = "category"
                    frm_login.dgv_items.Columns(9).DataPropertyName = "brand"
                    frm_login.dgv_items.Columns(10).DataPropertyName = "beginning_inventory"
                    frm_login.dgv_items.Columns(11).DataPropertyName = "beginning_inventory_price"
                    frm_login.dgv_items.Columns(12).DataPropertyName = "unit_of_measure"

                    frm_login.dgv_items.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    ''PRA LAHAT MAY INITIAL INVENTORY'
    'Public Function meron_na_sys_gen_entry()
    '    Try
    '        Dim barcode_exists_con As String = "SELECT * FROM beg_inv_price_for_incom_state " & _
    '                              "WHERE generate_date ='" & DateTime.Now.ToString("yyyy/MM/dd") & "' and sys_generated = 'YES'"

    '        SQL.ConnDB()
    '        SQL.SQLCmd = New SqlCommand(barcode_exists_con, SQL.SQLCon)

    '        Using reader As SqlDataReader = SQL.SQLCmd.ExecuteReader
    '            If reader.HasRows = True Then
    '                Return True
    '            Else
    '                Return False
    '            End If
    '        End Using

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        SQL.SQLCmd.Dispose()
    '        SQL.SQLCon.Close()
    '    End Try
    'End Function

    'Public Sub insert_sys_gen_beg_inv()
    '    Try
    '        For Each row As DataGridViewRow In frm_login.dgv_items.Rows
    '            Dim insert_item As String = "INSERT INTO beg_inv_price_for_incom_state(generate_date,item_no,barcode,item_name,inc_dec,init_price,sys_generated,trans_no,trans_type)VALUES " & _
    '            "(@generate_date,@item_no,@barcode,@item_name,@inc_dec,@init_price,@sys_generated,@trans_no,@trans_type)"

    '            SQL.ConnDB()
    '            SQL.SQLCmd = New SqlCommand(insert_item, SQL.SQLCon)

    '            SQL.SQLCmd.Parameters.AddWithValue("@generate_date", DateTime.Now)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(0).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(1).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(2).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@inc_dec", "0.00")
    '            SQL.SQLCmd.Parameters.AddWithValue("@init_price", row.Cells(11).Value)
    '            SQL.SQLCmd.Parameters.AddWithValue("@sys_generated", "YES")
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", "0")
    '            SQL.SQLCmd.Parameters.AddWithValue("@trans_type", "SYSTEM GEN")

    '            SQL.SQLCmd.ExecuteNonQuery()
    '        Next
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        SQL.SQLCmd.Dispose()
    '        SQL.SQLCon.Close()
    '    End Try
    'End Sub

    'check if sysgen entry exists - sales trans'
    Public Function meron_na_sys_gen_entry_sales()
        Try
            Dim barcode_exists_con As String = "SELECT * FROM sales_trans_table " & _
                                  "WHERE trans_date ='" & DateTime.Now.ToString("yyyy/MM/dd") & "' and trans_no = '0'"

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

    Public Sub insert_sys_gen_sales_trans()
        Try
            Dim insert_sales_trans As String = "INSERT INTO sales_trans_table(trans_no,trans_datetime,cash_or_account, " & _
                "customer_no,customer_name,sub_total,dicount_percent,total_discount,grand_total,cash_tendered,change,trans_date,ret_bo_receipt_no,ret_total_amount,ret_bo_remarks,bo_total_amount,customer_partial_payment)VALUES " & _
                "(@trans_no,@trans_datetime,@cash_or_account,@customer_no,@customer_name,@sub_total,@dicount_percent,@total_discount, " & _
                "@grand_total,@cash_tendered,@change,@trans_date,@ret_bo_receipt_no,@ret_total_amount,@ret_bo_remarks,@bo_total_amount,@customer_partial_payment)"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(insert_sales_trans, SQL.SQLCon)

            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", 0)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", DateTime.Now)
            SQL.SQLCmd.Parameters.AddWithValue("@cash_or_account", "System Gen")
            SQL.SQLCmd.Parameters.AddWithValue("@customer_no", "")
            SQL.SQLCmd.Parameters.AddWithValue("@customer_name", "")
            SQL.SQLCmd.Parameters.AddWithValue("@sub_total", "0.00")
            SQL.SQLCmd.Parameters.AddWithValue("@dicount_percent", "0")
            SQL.SQLCmd.Parameters.AddWithValue("@total_discount", "0.00")
            SQL.SQLCmd.Parameters.AddWithValue("@grand_total", "0.00")
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

    'check if sysgen entry exists - purchase trans'
    Public Function meron_na_sys_gen_entry_purchase()
        Try
            Dim barcode_exists_con As String = "SELECT * FROM purchase_trans_table " & _
                                  "WHERE trans_date ='" & DateTime.Now.ToString("yyyy/MM/dd") & "' and trans_no = '0'"

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

    Public Sub insert_sys_gen_purchase_trans()
        Try
            Dim insert_purchase_trans As String = "INSERT INTO purchase_trans_table(trans_no,trans_date,ref_no, " & _
                "supplier_no,supplier_name,sub_total,total_discount,grand_total,purchase_or_returns,total_return_price)VALUES " & _
                "(@trans_no,@trans_date,@ref_no,@supplier_no,@supplier_name,@sub_total,@total_discount,@grand_total,@purchase_or_returns,@total_return_price)"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(insert_purchase_trans, SQL.SQLCon)

            SQL.SQLCmd.Parameters.AddWithValue("@trans_no", 0)
            SQL.SQLCmd.Parameters.AddWithValue("@trans_date", DateTime.Now)
            SQL.SQLCmd.Parameters.AddWithValue("@ref_no", "")
            SQL.SQLCmd.Parameters.AddWithValue("@supplier_no", "0")
            SQL.SQLCmd.Parameters.AddWithValue("@supplier_name", "")
            SQL.SQLCmd.Parameters.AddWithValue("@sub_total", "0.00")
            SQL.SQLCmd.Parameters.AddWithValue("@total_discount", "0.00")
            SQL.SQLCmd.Parameters.AddWithValue("@grand_total", "0.00")
            SQL.SQLCmd.Parameters.AddWithValue("@purchase_or_returns", "System Gen")
            SQL.SQLCmd.Parameters.AddWithValue("@total_return_price", "0.00")

            SQL.SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub


    'check if system gen entry exists - sales_item'
    Public Function meron_na_sys_gen_entry_sales_item()
        Try
            Dim barcode_exists_con As String = "SELECT * FROM sales_item_table " & _
                                  "WHERE trans_date ='" & DateTime.Now.ToString("yyyy/MM/dd") & "' and trans_no = '0'"

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

    Public Sub insert_sys_gen_sales_item()
        Try
            For Each row As DataGridViewRow In frm_login.dgv_items.Rows
                Dim insert_sys_gen_sales_item As String = "INSERT INTO sales_item_table(trans_no,trans_datetime,cash_or_account, " & _
                 "customer_no,customer_name,item_no,barcode,item_name,price,qty_sold,total_amount,begin_inv,dicount_percent,trans_date, " & _
                 "ret_qty, ret_selling_price, ret_grand_total, bo_qty, bo_selling_price, bo_grand_total, ending_inv, purchase_price, unit_of_measure, category)VALUES " & _
                 "(@trans_no,@trans_datetime,@cash_or_account,@customer_no,@customer_name,@item_no,@barcode,@item_name,@price,@qty_sold,@total_amount,@begin_inv,@dicount_percent,@trans_date," & _
                 "@ret_qty,@ret_selling_price,@ret_grand_total,@bo_qty,@bo_selling_price,@bo_grand_total,@ending_inv,@purchase_price,@unit_of_measure,@category)"

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(insert_sys_gen_sales_item, SQL.SQLCon)

                SQL.SQLCmd.Parameters.AddWithValue("@trans_no", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", DateTime.Now)
                SQL.SQLCmd.Parameters.AddWithValue("@cash_or_account", "System Gen")
                SQL.SQLCmd.Parameters.AddWithValue("@customer_no", "")
                SQL.SQLCmd.Parameters.AddWithValue("@customer_name", "")
                SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(0).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(1).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(2).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@price", row.Cells(3).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@qty_sold", "0.00")
                SQL.SQLCmd.Parameters.AddWithValue("@total_amount", "0.00")
                SQL.SQLCmd.Parameters.AddWithValue("@begin_inv", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@dicount_percent", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@trans_date", DateTime.Now)
                SQL.SQLCmd.Parameters.AddWithValue("@ret_qty", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@ret_selling_price", row.Cells(3).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@ret_grand_total", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@bo_qty", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@bo_selling_price", row.Cells(3).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@bo_grand_total", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@ending_inv", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@purchase_price", row.Cells(4).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@unit_of_measure", row.Cells(12).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@category", row.Cells(8).Value)
                SQL.SQLCmd.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'check if system gen entry exists - purchase_item'
    Public Function meron_na_sys_gen_entry_purchase_item()
        Try
            Dim barcode_exists_con As String = "SELECT * FROM purchase_item_table " & _
                                  "WHERE trans_date ='" & DateTime.Now.ToString("yyyy/MM/dd") & "' and trans_no = '0'"

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

    Public Sub insert_sys_gen_purchase_item()
        Try
            For Each row As DataGridViewRow In frm_login.dgv_items.Rows

                Dim insert_sys_gen_purchase_item As String = "INSERT INTO purchase_item_table(trans_no,trans_date,supplier_no, " & _
                 "item_no,barcode,item_name,category,brand,begin_inv,qty_purchased,buying_price,total_price,discount,total_after_discount,purchase_or_returns,qty_returned,return_buying_price,total_return_price,ending_inv,unit_of_measure)VALUES " & _
                 "(@trans_no,@trans_date,@supplier_no,@item_no,@barcode,@item_name,@category,@brand,@begin_inv,@qty_purchased,@buying_price,@total_price,@discount,@total_after_discount,@purchase_or_returns,@qty_returned,@return_buying_price,@total_return_price,@ending_inv,@unit_of_measure)"

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(insert_sys_gen_purchase_item, SQL.SQLCon)

                SQL.SQLCmd.Parameters.AddWithValue("@trans_no", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@trans_date", DateTime.Now)
                SQL.SQLCmd.Parameters.AddWithValue("@supplier_no", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(0).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(1).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(2).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@category", row.Cells(8).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@brand", row.Cells(9).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@begin_inv", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@qty_purchased", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@buying_price", row.Cells(4).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@total_price", "0.00")
                SQL.SQLCmd.Parameters.AddWithValue("@discount", "0.00")
                SQL.SQLCmd.Parameters.AddWithValue("@total_after_discount", "0.00")
                SQL.SQLCmd.Parameters.AddWithValue("@purchase_or_returns", "System Gen")
                SQL.SQLCmd.Parameters.AddWithValue("@qty_returned", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@return_buying_price", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@total_return_price", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@ending_inv", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@unit_of_measure", row.Cells(12).Value)
                SQL.SQLCmd.ExecuteNonQuery()

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    'check if system gen entry exists - begin end inv table'
    Public Function meron_na_sys_gen_entry_begin_end()
        Try
            Dim barcode_exists_con As String = "SELECT * FROM begin_end_inv_table " & _
                                  "WHERE trans_date ='" & DateTime.Now.ToString("yyyy/MM/dd") & "' and trans_type = 'SYSGEN'"

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

    'ADJUSTING BEGIN END INV'
    Dim vegin As Decimal = 0
    Dim ends As Decimal = 0
    Dim purdate As DateTime

    Public Sub insert_sysgen_begin_end_inv()
        For Each row As DataGridViewRow In frm_login.dgv_items.Rows
            Try
                Dim query1 As String = "SELECT TOP 1 ID, beg_inv, end_inv, trans_date from begin_end_inv_table " & _
                    "where item_no = '" & row.Cells(0).Value & "' ORDER BY ID DESC"

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(query1, SQL.SQLCon)
                SQL.SQLDR = SQL.SQLCmd.ExecuteReader

                If SQL.SQLDR.Read = True Then
                    purdate = SQL.SQLDR("trans_date")

                    If DateTime.Now > purdate Then
                        vegin = SQL.SQLDR("end_inv")
                        ends = SQL.SQLDR("end_inv")
                    Else
                        vegin = SQL.SQLDR("beg_inv")
                        ends = SQL.SQLDR("end_inv")
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                SQL.SQLCmd.Dispose()
                SQL.SQLCon.Close()
            End Try

            Try
                Dim query2 As String = "INSERT INTO begin_end_inv_table" & _
                "(item_no,item_name,barcode,trans_date,trans_type,beg_inv,item_in,item_out,end_inv,trans_no,price_beg,price_end,trans_datetime,category)VALUES " & _
                "(@item_no,@item_name,@barcode,@trans_date,@trans_type,@beg_inv,@item_in,@item_out,@end_inv,@trans_no,@price_beg,@price_end,@trans_datetime,@category)"

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(query2, SQL.SQLCon)

                SQL.SQLCmd.Parameters.AddWithValue("@item_no", row.Cells(0).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@item_name", row.Cells(2).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@barcode", row.Cells(1).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@trans_date", DateTime.Now)
                SQL.SQLCmd.Parameters.AddWithValue("@trans_type", "SYSGEN")
                SQL.SQLCmd.Parameters.AddWithValue("@beg_inv", vegin)
                SQL.SQLCmd.Parameters.AddWithValue("@item_in", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@item_out", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@end_inv", ends)
                SQL.SQLCmd.Parameters.AddWithValue("@trans_no", "0")
                SQL.SQLCmd.Parameters.AddWithValue("@price_beg", vegin * row.Cells(4).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@price_end", ends * row.Cells(4).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@trans_datetime", DateTime.Now)
                SQL.SQLCmd.Parameters.AddWithValue("@category", row.Cells(8).Value)

                SQL.SQLCmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                SQL.SQLCmd.Dispose()
                SQL.SQLCon.Close()
            End Try
        Next

    End Sub

    'customers'
    Public Sub load_customers()
        Using cmd As New SqlCommand("SELECT * FROM customers_table", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_login.dgv_customers.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_login.dgv_customers.Columns(0).DataPropertyName = "customer_no"
                    frm_login.dgv_customers.Columns(1).DataPropertyName = "first_name"
                    frm_login.dgv_customers.Columns(2).DataPropertyName = "middle_name"
                    frm_login.dgv_customers.Columns(3).DataPropertyName = "last_name"
                    frm_login.dgv_customers.Columns(4).DataPropertyName = "contact_no"
                    frm_login.dgv_customers.Columns(5).DataPropertyName = "address"

                    frm_login.dgv_customers.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    'check if system gen entry exists - customer_pay'
    Public Function meron_na_sys_gen_entry_cust_pay()
        Try
            Dim barcode_exists_con As String = "SELECT * FROM customer_payments_table " & _
                                  "WHERE date_pay ='" & DateTime.Now.ToString("yyyy/MM/dd") & "' and amount_paid = '0'"

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

    Public Sub insert_pay()
        Try
            For Each row As DataGridViewRow In frm_login.dgv_customers.Rows
                Dim inser_pay As String = "INSERT INTO customer_payments_table(date_pay,customer_no,amount_paid)VALUES " & _
                "(@date_pay,@customer_no,@amount_paid)"

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(inser_pay, SQL.SQLCon)

                SQL.SQLCmd.Parameters.AddWithValue("@date_pay", DateTime.Now)
                SQL.SQLCmd.Parameters.AddWithValue("@customer_no", row.Cells(0).Value)
                SQL.SQLCmd.Parameters.AddWithValue("@amount_paid", "0.00")
                SQL.SQLCmd.ExecuteNonQuery()
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

End Class
