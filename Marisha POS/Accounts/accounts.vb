Imports System.Data.SqlClient
Imports System.IO

Public Class accounts

    Dim SQL As New SQLControl

    'ACCOUNTS MAIN FORM'

    Public Sub load_accounts()
        Using cmd As New SqlCommand("SELECT * FROM accounts_table", SQL.SQLCon)
            cmd.CommandType = CommandType.Text
            Using sda As New SqlDataAdapter(cmd)
                Using dt As New DataTable()
                    sda.Fill(dt)

                    'Set AutoGenerateColumns False
                    frm_accounts.dgv_accounts.AutoGenerateColumns = False

                    'Set Columns Count
                    'frm_accounts.dgv_accounts.ColumnCount = 6

                    'Add Columns
                    frm_accounts.dgv_accounts.Columns(0).DataPropertyName = "account_no"
                    frm_accounts.dgv_accounts.Columns(1).DataPropertyName = "username"
                    frm_accounts.dgv_accounts.Columns(2).DataPropertyName = "password"
                    frm_accounts.dgv_accounts.Columns(3).DataPropertyName = "position"
                    frm_accounts.dgv_accounts.Columns(4).DataPropertyName = "first_name"
                    frm_accounts.dgv_accounts.Columns(5).DataPropertyName = "middle_name"
                    frm_accounts.dgv_accounts.Columns(6).DataPropertyName = "last_name"
                    frm_accounts.dgv_accounts.Columns(7).DataPropertyName = "pos_sales_trans"
                    frm_accounts.dgv_accounts.Columns(8).DataPropertyName = "pos_receipt"
                    frm_accounts.dgv_accounts.Columns(9).DataPropertyName = "inv_category"
                    frm_accounts.dgv_accounts.Columns(10).DataPropertyName = "inv_brands"
                    frm_accounts.dgv_accounts.Columns(11).DataPropertyName = "inv_add_item"
                    frm_accounts.dgv_accounts.Columns(12).DataPropertyName = "inv_updt_item"
                    frm_accounts.dgv_accounts.Columns(13).DataPropertyName = "inv_add_stocks"
                    frm_accounts.dgv_accounts.Columns(14).DataPropertyName = "inv_purchase_return"
                    frm_accounts.dgv_accounts.Columns(15).DataPropertyName = "inv_report_inv"
                    frm_accounts.dgv_accounts.Columns(16).DataPropertyName = "inv_report_pur"
                    frm_accounts.dgv_accounts.Columns(17).DataPropertyName = "inv_report_sales"
                    frm_accounts.dgv_accounts.Columns(18).DataPropertyName = "sales_report_remit"
                    frm_accounts.dgv_accounts.Columns(19).DataPropertyName = "sales_report_incstate"
                    frm_accounts.dgv_accounts.Columns(20).DataPropertyName = "cust_add_cust"
                    frm_accounts.dgv_accounts.Columns(21).DataPropertyName = "cust_updt_cust"
                    frm_accounts.dgv_accounts.Columns(22).DataPropertyName = "cust_balpay"
                    frm_accounts.dgv_accounts.Columns(23).DataPropertyName = "cust_report_acc_receive"
                    frm_accounts.dgv_accounts.Columns(24).DataPropertyName = "cust_cash_trans"
                    frm_accounts.dgv_accounts.Columns(25).DataPropertyName = "cust_return_trans"
                    frm_accounts.dgv_accounts.Columns(26).DataPropertyName = "cust_bo_trans"
                    frm_accounts.dgv_accounts.Columns(27).DataPropertyName = "supp_add_supp"
                    frm_accounts.dgv_accounts.Columns(28).DataPropertyName = "supp_updt_supp"
                    frm_accounts.dgv_accounts.Columns(29).DataPropertyName = "admin"
                    frm_accounts.dgv_accounts.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Sub retrieve_pic()
        'retrieve picture'
        Try
            Dim retrieve_pic As String = "SELECT picture FROM accounts_table where account_no = '" & frm_accounts.lbl_account_no.Text & "' "
            Dim stream As New MemoryStream()
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(retrieve_pic, SQL.SQLCon)
            Dim image As Byte() = DirectCast(SQL.SQLCmd.ExecuteScalar(), Byte())

            stream.Write(image, 0, image.Length)
            Dim bitmap As New Bitmap(stream)
            frm_accounts.pic.Image = bitmap 'to frm_accounts'
            frm_useracc_add_update.pic.Image = bitmap 'to frm_useracc_add_update when update'
            frm_admin_update.pic.Image = bitmap 'to frm_update_admin when update'
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub


    'ACCOUNTS NEW ACCOUNT'

    'GET ACCOUNT NO.'
    Public Sub get_account_no()
        Try
            Dim get_account_no As String = "SELECT account_no FROM accounts_table ORDER BY account_no DESC"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(get_account_no, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                frm_useracc_add_update.lbl_account_no.Text = SQL.SQLDR("account_no") + 1
            Else
                frm_useracc_add_update.lbl_account_no.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    Function username_exists() As Boolean
        Try
            Dim username_exists_con As String = "SELECT * FROM accounts_table " & _
                                  "WHERE username='" & frm_useracc_add_update.txt_username.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS "

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(username_exists_con, SQL.SQLCon)

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

    Dim pos_sales_trans, pos_receipt, inv_category, inv_brands, inv_add_item, inv_updt_item, inv_add_stocks, _
        inv_purchase_return, inv_report_inv, inv_report_pur, inv_report_sales, sales_report_remit, sales_report_incstate, _
        cust_add_cust, cust_updt_cust, cust_balpay, cust_report_acc_receive, cust_cash_trans, cust_return_trans, cust_bo_trans, _
        supp_add_supp, supp_updt_supp As String

    'account access cb values'
    Public Sub account_access()
        'POS
        If frm_useracc_add_update.cb_pos_sales_trans.Checked = True Then
            pos_sales_trans = "YES"
        Else
            pos_sales_trans = "NO"
        End If

        If frm_useracc_add_update.cb_pos_receipt.Checked = True Then
            pos_receipt = "YES"
        Else
            pos_receipt = "NO"
        End If

        'INVENTORY
        If frm_useracc_add_update.cb_inv_category.Checked = True Then
            inv_category = "YES"
        Else
            inv_category = "NO"
        End If

        If frm_useracc_add_update.cb_inv_brands.Checked = True Then
            inv_brands = "YES"
        Else
            inv_brands = "NO"
        End If

        If frm_useracc_add_update.cb_inv_add_item.Checked = True Then
            inv_add_item = "YES"
        Else
            inv_add_item = "NO"
        End If

        If frm_useracc_add_update.cb_inv_updt_item.Checked = True Then
            inv_updt_item = "YES"
        Else
            inv_updt_item = "NO"
        End If

        If frm_useracc_add_update.cb_inv_add_stocks.Checked = True Then
            inv_add_stocks = "YES"
        Else
            inv_add_stocks = "NO"
        End If

        If frm_useracc_add_update.cb_inv_pur_ret.Checked = True Then
            inv_purchase_return = "YES"
        Else
            inv_purchase_return = "NO"
        End If

        If frm_useracc_add_update.cb_inv_report_inv.Checked = True Then
            inv_report_inv = "YES"
        Else
            inv_report_inv = "NO"
        End If

        If frm_useracc_add_update.cb_inv_report_pur.Checked = True Then
            inv_report_pur = "YES"
        Else
            inv_report_pur = "NO"
        End If

        If frm_useracc_add_update.cb_inv_report_sales.Checked = True Then
            inv_report_sales = "YES"
        Else
            inv_report_sales = "NO"
        End If

        'SALES'
        If frm_useracc_add_update.cb_sales_report_dailyremit.Checked = True Then
            sales_report_remit = "YES"
        Else
            sales_report_remit = "NO"
        End If

        If frm_useracc_add_update.cb_sales_report_incstate.Checked = True Then
            sales_report_incstate = "YES"
        Else
            sales_report_incstate = "NO"
        End If

        'Customer'
        If frm_useracc_add_update.cb_cust_add_cust.Checked = True Then
            cust_add_cust = "YES"
        Else
            cust_add_cust = "NO"
        End If

        If frm_useracc_add_update.cb_cust_updt_cust.Checked = True Then
            cust_updt_cust = "YES"
        Else
            cust_updt_cust = "NO"
        End If

        If frm_useracc_add_update.cb_cust_balpay.Checked = True Then
            cust_balpay = "YES"
        Else
            cust_balpay = "NO"
        End If

        If frm_useracc_add_update.cb_cust_report_arpay.Checked = True Then
            cust_report_acc_receive = "YES"
        Else
            cust_report_acc_receive = "NO"
        End If

        If frm_useracc_add_update.cb_cust_cash_trans.Checked = True Then
            cust_cash_trans = "YES"
        Else
            cust_cash_trans = "NO"
        End If

        If frm_useracc_add_update.cb_cust_sales_ret.Checked = True Then
            cust_return_trans = "YES"
        Else
            cust_return_trans = "NO"
        End If

        If frm_useracc_add_update.cb_cust_bo.Checked = True Then
            cust_bo_trans = "YES"
        Else
            cust_bo_trans = "NO"
        End If

        'Suppliers'
        If frm_useracc_add_update.cb_supp_add_supp.Checked = True Then
            supp_add_supp = "YES"
        Else
            supp_add_supp = "NO"
        End If

        If frm_useracc_add_update.cb_supp_updt_supp.Checked = True Then
            supp_updt_supp = "YES"
        Else
            supp_updt_supp = "NO"
        End If
    End Sub

    'INSERT ACCOUNT'


    Public Sub insert_account()

        If frm_useracc_add_update.imgName <> "" Then
            Dim fs As FileStream
            fs = New FileStream(frm_useracc_add_update.imgName, FileMode.Open, FileAccess.Read)
            Dim picByte As Byte() = New Byte(fs.Length - 1) {}
            fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))
            fs.Close()

            Try
                account_access()
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

                SQL.SQLCmd.Parameters.AddWithValue("@account_no", frm_useracc_add_update.lbl_account_no.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@username", frm_useracc_add_update.txt_username.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@password", frm_useracc_add_update.txt_password.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@first_name", frm_useracc_add_update.txt_fname.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@middle_name", frm_useracc_add_update.txt_mname.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@last_name", frm_useracc_add_update.txt_lname.Text)
                SQL.SQLCmd.Parameters.AddWithValue("pos_sales_trans", pos_sales_trans)
                SQL.SQLCmd.Parameters.AddWithValue("pos_receipt", pos_receipt)
                SQL.SQLCmd.Parameters.AddWithValue("inv_category", inv_category)
                SQL.SQLCmd.Parameters.AddWithValue("inv_brands", inv_brands)
                SQL.SQLCmd.Parameters.AddWithValue("inv_add_item", inv_add_item)
                SQL.SQLCmd.Parameters.AddWithValue("inv_updt_item", inv_updt_item)
                SQL.SQLCmd.Parameters.AddWithValue("inv_add_stocks", inv_add_stocks)
                SQL.SQLCmd.Parameters.AddWithValue("inv_purchase_return", inv_purchase_return)
                SQL.SQLCmd.Parameters.AddWithValue("inv_report_inv", inv_report_inv)
                SQL.SQLCmd.Parameters.AddWithValue("inv_report_pur", inv_report_pur)
                SQL.SQLCmd.Parameters.AddWithValue("inv_report_sales", inv_report_sales)
                SQL.SQLCmd.Parameters.AddWithValue("sales_report_remit", sales_report_remit)
                SQL.SQLCmd.Parameters.AddWithValue("sales_report_incstate", sales_report_incstate)
                SQL.SQLCmd.Parameters.AddWithValue("cust_add_cust", cust_add_cust)
                SQL.SQLCmd.Parameters.AddWithValue("cust_updt_cust", cust_updt_cust)
                SQL.SQLCmd.Parameters.AddWithValue("cust_balpay", cust_balpay)
                SQL.SQLCmd.Parameters.AddWithValue("cust_report_acc_receive", cust_report_acc_receive)
                SQL.SQLCmd.Parameters.AddWithValue("cust_cash_trans", cust_cash_trans)
                SQL.SQLCmd.Parameters.AddWithValue("cust_return_trans", cust_return_trans)
                SQL.SQLCmd.Parameters.AddWithValue("cust_bo_trans", cust_bo_trans)
                SQL.SQLCmd.Parameters.AddWithValue("supp_add_supp", supp_add_supp)
                SQL.SQLCmd.Parameters.AddWithValue("supp_updt_supp", supp_updt_supp)
                SQL.SQLCmd.Parameters.AddWithValue("@admin", "NO")
                SQL.SQLCmd.Parameters.AddWithValue("@position", frm_useracc_add_update.txt_position.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@Picture", picByte)

                SQL.SQLCmd.ExecuteNonQuery()
                MsgBox(" Account Successfully Added!", MsgBoxStyle.Information, " Account Created")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                SQL.SQLCmd.Dispose()
                SQL.SQLCon.Close()
            End Try

        End If
    End Sub

    'UPDATING ACCOUNTS'

    Sub update_account()

        Using ms As MemoryStream = New MemoryStream()

            Dim bm As Bitmap = New Bitmap(frm_useracc_add_update.pic.Image)
            bm.Save(ms, frm_useracc_add_update.pic.Image.RawFormat)

            Dim arrPic() As Byte = ms.GetBuffer()
            Try
                account_access()
                Dim update_account As String = "UPDATE accounts_table SET username = @username," & _
                                                "password = @password, first_name = @first_name, middle_name = @middle_name, " & _
                                                "last_name = @last_name, pos_sales_trans = @pos_sales_trans, pos_receipt = @pos_receipt, inv_category = @inv_category, " & _
                                                "inv_brands = @inv_brands, inv_add_item = @inv_add_item, inv_updt_item = @inv_updt_item, " & _
                                                "inv_add_stocks = @inv_add_stocks, inv_purchase_return = @inv_purchase_return, inv_report_inv = @inv_report_inv, " & _
                                                "inv_report_pur = @inv_report_pur, inv_report_sales = @inv_report_sales, sales_report_remit = @sales_report_remit, " & _
                                                "sales_report_incstate = @sales_report_incstate, cust_add_cust = @cust_add_cust, cust_updt_cust = @cust_updt_cust, " & _
                                                "cust_balpay = @cust_balpay, cust_report_acc_receive = @cust_report_acc_receive, cust_cash_trans = @cust_cash_trans, " & _
                                                "cust_return_trans = @cust_return_trans, cust_bo_trans = @cust_bo_trans, supp_add_supp = @supp_add_supp, supp_updt_supp = @supp_updt_supp, " & _
                                                "admin = @admin, position = @position," & _
                                                "Picture = @Picture WHERE account_no = @account_no"

                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(update_account, SQL.SQLCon)
                SQL.SQLCmd.Parameters.AddWithValue("@username", frm_useracc_add_update.txt_username.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@password", frm_useracc_add_update.txt_password.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@first_name", frm_useracc_add_update.txt_fname.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@middle_name", frm_useracc_add_update.txt_mname.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@last_name", frm_useracc_add_update.txt_lname.Text)
                SQL.SQLCmd.Parameters.AddWithValue("pos_sales_trans", pos_sales_trans)
                SQL.SQLCmd.Parameters.AddWithValue("pos_receipt", pos_receipt)
                SQL.SQLCmd.Parameters.AddWithValue("inv_category", inv_category)
                SQL.SQLCmd.Parameters.AddWithValue("inv_brands", inv_brands)
                SQL.SQLCmd.Parameters.AddWithValue("inv_add_item", inv_add_item)
                SQL.SQLCmd.Parameters.AddWithValue("inv_updt_item", inv_updt_item)
                SQL.SQLCmd.Parameters.AddWithValue("inv_add_stocks", inv_add_stocks)
                SQL.SQLCmd.Parameters.AddWithValue("inv_purchase_return", inv_purchase_return)
                SQL.SQLCmd.Parameters.AddWithValue("inv_report_inv", inv_report_inv)
                SQL.SQLCmd.Parameters.AddWithValue("inv_report_pur", inv_report_pur)
                SQL.SQLCmd.Parameters.AddWithValue("inv_report_sales", inv_report_sales)
                SQL.SQLCmd.Parameters.AddWithValue("sales_report_remit", sales_report_remit)
                SQL.SQLCmd.Parameters.AddWithValue("sales_report_incstate", sales_report_incstate)
                SQL.SQLCmd.Parameters.AddWithValue("cust_add_cust", cust_add_cust)
                SQL.SQLCmd.Parameters.AddWithValue("cust_updt_cust", cust_updt_cust)
                SQL.SQLCmd.Parameters.AddWithValue("cust_balpay", cust_balpay)
                SQL.SQLCmd.Parameters.AddWithValue("cust_report_acc_receive", cust_report_acc_receive)
                SQL.SQLCmd.Parameters.AddWithValue("cust_cash_trans", cust_cash_trans)
                SQL.SQLCmd.Parameters.AddWithValue("cust_return_trans", cust_return_trans)
                SQL.SQLCmd.Parameters.AddWithValue("cust_bo_trans", cust_bo_trans)
                SQL.SQLCmd.Parameters.AddWithValue("supp_add_supp", supp_add_supp)
                SQL.SQLCmd.Parameters.AddWithValue("supp_updt_supp", supp_updt_supp)
                SQL.SQLCmd.Parameters.AddWithValue("@admin", "NO")
                SQL.SQLCmd.Parameters.AddWithValue("@position", frm_useracc_add_update.txt_position.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@Picture", arrPic)
                SQL.SQLCmd.Parameters.AddWithValue("@account_no", frm_useracc_add_update.lbl_account_no.Text)
                SQL.SQLCmd.ExecuteNonQuery()
                MsgBox(" Account Successfully Updated!", MsgBoxStyle.Information, " Account Updated")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                SQL.SQLCmd.Dispose()
                SQL.SQLCon.Close()
            End Try
        End Using

    End Sub

    'Deleting Accounts'
    Sub delete_account()
        Try
            Dim delete_account As String = "Delete from accounts_table WHERE account_no = @account_no"

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(delete_account, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@account_no", frm_accounts.lbl_account_no.Text)
            SQL.SQLCmd.ExecuteNonQuery()
            MsgBox(" Account Successfully Deleted!", MsgBoxStyle.Information, " Account Deleted")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    Function password_authenticate() As Boolean
        Try
            Dim password_auth As String = "SELECT * FROM accounts_table " & _
                                  "WHERE password='" & frm_delete_password.txt_password.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS " & _
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


    'ADMIN UPDATE ACCOUNT'

    Function username_exists_admin() As Boolean
        Try
            Dim username_exists_con As String = "SELECT * FROM accounts_table " & _
                                  "WHERE username='" & frm_admin_update.txt_username.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS "

            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(username_exists_con, SQL.SQLCon)

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

    Sub update_account_admin()

        Using ms As MemoryStream = New MemoryStream()

            Dim bm As Bitmap = New Bitmap(frm_admin_update.pic.Image)
            bm.Save(ms, frm_admin_update.pic.Image.RawFormat)

            Dim arrPic() As Byte = ms.GetBuffer()
            Try
                Dim update_account As String = "UPDATE accounts_table SET username = @username," & _
                                                "password = @password, first_name = @first_name, middle_name = @middle_name, " & _
                                                "last_name = @last_name, " & _
                                                "Picture = @Picture WHERE account_no = @account_no"
                SQL.ConnDB()
                SQL.SQLCmd = New SqlCommand(update_account, SQL.SQLCon)
                SQL.SQLCmd.Parameters.AddWithValue("@username", frm_admin_update.txt_username.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@password", frm_admin_update.txt_password.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@first_name", frm_admin_update.txt_fname.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@middle_name", frm_admin_update.txt_mname.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@last_name", frm_admin_update.txt_lname.Text)
                SQL.SQLCmd.Parameters.AddWithValue("@Picture", arrPic)
                SQL.SQLCmd.Parameters.AddWithValue("@account_no", frm_admin_update.lbl_account_no.Text)
                SQL.SQLCmd.ExecuteNonQuery()
                MsgBox(" Account Successfully Updated!", MsgBoxStyle.Information, " Account Updated")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                SQL.SQLCmd.Dispose()
                SQL.SQLCon.Close()
            End Try
        End Using

    End Sub

End Class
