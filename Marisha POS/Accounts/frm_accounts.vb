Public Class frm_accounts

    Public adding As Boolean
    Public updating As Boolean

    Dim accounts_query As New accounts

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
    Private Sub me_FormFormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_choose.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        frm_choose.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ss_time_and_date.Text = DateTime.Now.ToString("h:mm tt dddd, d MMMM yyyy")
    End Sub
    Private Sub frm_accounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ss_user.Text = frm_choose.lbl_name.Text
        ss_position.Text = frm_choose.lbl_position.Text
        accounts_query.load_accounts()
    End Sub

    Private Sub dgv_accounts_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_accounts.CellClick
        If dgv_accounts.Rows.Count > 0 Then
            Me.lbl_account_no.Text = dgv_accounts.Item("account_no", dgv_accounts.CurrentRow.Index).Value.ToString()
            Me.lbl_username.Text = dgv_accounts.Item("username", dgv_accounts.CurrentRow.Index).Value.ToString()
            Me.lbl_password.Text = dgv_accounts.Item("password", dgv_accounts.CurrentRow.Index).Value.ToString()
            Me.lbl_position.Text = dgv_accounts.Item("position", dgv_accounts.CurrentRow.Index).Value.ToString()
            Me.lbl_fname.Text = dgv_accounts.Item("first_name", dgv_accounts.CurrentRow.Index).Value.ToString()
            Me.lbl_mname.Text = dgv_accounts.Item("middle_name", dgv_accounts.CurrentRow.Index).Value.ToString()
            Me.lbl_lname.Text = dgv_accounts.Item("last_name", dgv_accounts.CurrentRow.Index).Value.ToString()
            Me.lbl_admin.Text = dgv_accounts.Item("admin", dgv_accounts.CurrentRow.Index).Value.ToString()

            'POS'
            If dgv_accounts.Item("pos_sales_trans", dgv_accounts.CurrentRow.Index).Value = "YES" Then
                cb_pos_sales_trans.Checked = True
            Else
                cb_pos_sales_trans.Checked = False
            End If
            If dgv_accounts.Item("pos_receipt", dgv_accounts.CurrentRow.Index).Value = "YES" Then
                cb_pos_receipt.Checked = True
            Else
                cb_pos_receipt.Checked = False
            End If

            'INV'
            If dgv_accounts.Item("inv_category", dgv_accounts.CurrentRow.Index).Value = "YES" Then
                cb_inv_category.Checked = True
            Else
                cb_inv_category.Checked = False
            End If
            If dgv_accounts.Item("inv_brands", dgv_accounts.CurrentRow.Index).Value = "YES" Then
                cb_inv_brands.Checked = True
            Else
                cb_inv_brands.Checked = False
            End If
            If dgv_accounts.Item("inv_add_item", dgv_accounts.CurrentRow.Index).Value = "YES" Then
                cb_inv_add_item.Checked = True
            Else
                cb_inv_add_item.Checked = False
            End If
            If dgv_accounts.Item("inv_updt_item", dgv_accounts.CurrentRow.Index).Value = "YES" Then
                cb_inv_updt_item.Checked = True
            Else
                cb_inv_updt_item.Checked = False
            End If
            If dgv_accounts.Item("inv_add_stocks", dgv_accounts.CurrentRow.Index).Value = "YES" Then
                cb_inv_add_stocks.Checked = True
            Else
                cb_inv_add_stocks.Checked = False
            End If
            If dgv_accounts.Item("inv_purchase_return", dgv_accounts.CurrentRow.Index).Value = "YES" Then
                cb_inv_pur_ret.Checked = True
            Else
                cb_inv_pur_ret.Checked = False
            End If
            If dgv_accounts.Item("inv_report_inv", dgv_accounts.CurrentRow.Index).Value = "YES" Then
                cb_inv_report_inv.Checked = True
            Else
                cb_inv_report_inv.Checked = False
            End If
            If dgv_accounts.Item("inv_report_pur", dgv_accounts.CurrentRow.Index).Value = "YES" Then
                cb_inv_report_pur.Checked = True
            Else
                cb_inv_report_pur.Checked = False
            End If
            If dgv_accounts.Item("inv_report_sales", dgv_accounts.CurrentRow.Index).Value = "YES" Then
                cb_inv_report_sales.Checked = True
            Else
                cb_inv_report_sales.Checked = False
            End If

            'Sales'
            If dgv_accounts.Item("sales_report_remit", dgv_accounts.CurrentRow.Index).Value = "YES" Then
                cb_sales_report_dailyremit.Checked = True
            Else
                cb_sales_report_dailyremit.Checked = False
            End If
            If dgv_accounts.Item("sales_report_incstate", dgv_accounts.CurrentRow.Index).Value = "YES" Then
                cb_sales_report_incstate.Checked = True
            Else
                cb_sales_report_incstate.Checked = False
            End If

            'Customer'
            If dgv_accounts.Item("cust_add_cust", dgv_accounts.CurrentRow.Index).Value = "YES" Then
                cb_cust_add_cust.Checked = True
            Else
                cb_cust_add_cust.Checked = False
            End If
            If dgv_accounts.Item("cust_updt_cust", dgv_accounts.CurrentRow.Index).Value = "YES" Then
                cb_cust_updt_cust.Checked = True
            Else
                cb_cust_updt_cust.Checked = False
            End If
            If dgv_accounts.Item("cust_balpay", dgv_accounts.CurrentRow.Index).Value = "YES" Then
                cb_cust_balpay.Checked = True
            Else
                cb_cust_balpay.Checked = False
            End If
            If dgv_accounts.Item("cust_report_acc_receive", dgv_accounts.CurrentRow.Index).Value = "YES" Then
                cb_cust_report_arpay.Checked = True
            Else
                cb_cust_report_arpay.Checked = False
            End If
            If dgv_accounts.Item("cust_cash_trans", dgv_accounts.CurrentRow.Index).Value = "YES" Then
                cb_cust_cash_trans.Checked = True
            Else
                cb_cust_cash_trans.Checked = False
            End If
            If dgv_accounts.Item("cust_return_trans", dgv_accounts.CurrentRow.Index).Value = "YES" Then
                cb_cust_sales_ret.Checked = True
            Else
                cb_cust_sales_ret.Checked = False
            End If
            If dgv_accounts.Item("cust_bo_trans", dgv_accounts.CurrentRow.Index).Value = "YES" Then
                cb_cust_bo.Checked = True
            Else
                cb_cust_bo.Checked = False
            End If

            'Supplier'
            If dgv_accounts.Item("supp_add_supp", dgv_accounts.CurrentRow.Index).Value = "YES" Then
                cb_supp_add_supp.Checked = True
            Else
                cb_supp_add_supp.Checked = False
            End If
            If dgv_accounts.Item("supp_updt_supp", dgv_accounts.CurrentRow.Index).Value = "YES" Then
                cb_supp_updt_supp.Checked = True
            Else
                cb_supp_updt_supp.Checked = False
            End If

            accounts_query.retrieve_pic()
        End If
    End Sub

    Private Sub cmd_addnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_addnew.Click
        adding = True
        updating = False
        frm_useracc_add_update.lblTitle.Text = "Add a User Account"
        frm_useracc_add_update.ShowDialog()
    End Sub

    Private Sub cmd_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_update.Click
        If lbl_account_no.Text = "" Then
            MsgBox(" Please Select a Record to Update", MsgBoxStyle.Exclamation, " Invalid")
        Else
            If lbl_admin.Text = "YES" Then
                frm_useracc_add_update.txt_username.Focus()
                frm_admin_update.ShowDialog()
            Else
                adding = False
                updating = True
                frm_useracc_add_update.lblTitle.Text = "Update a User Account"
                frm_useracc_add_update.txt_username.Focus()
                frm_useracc_add_update.ShowDialog()
            End If
        End If
    End Sub

    Private Sub cmd_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_delete.Click
        If lbl_account_no.Text = "" Then
            MsgBox(" Please Select a Record to Delete", MsgBoxStyle.Exclamation, " Invalid")
        Else
            If lbl_admin.Text = "YES" Then
                MsgBox(" The Admin Account Cannot Be Deleted!", MsgBoxStyle.Critical, " Invalid Command")
            Else
                If MsgBox(" ACCOUNT INFORMATION " & vbCrLf & _
                              " Account No : " + lbl_account_no.Text & vbCrLf & "" + _
                              " Username : " + lbl_username.Text & vbCrLf & "" + _
                              " Password : " + lbl_password.Text & vbCrLf & "" + _
                              " Position : " + lbl_position.Text & vbCrLf & "" + _
                              " First Name : " + lbl_fname.Text & vbCrLf & "" + _
                              " Middle Name : " + lbl_mname.Text & vbCrLf & "" + _
                              " Last Name : " + lbl_lname.Text & vbCrLf & "" & vbCrLf & "", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, " This Will Permanently Delete this Account, Continue?") = MsgBoxResult.Yes Then
                    frm_delete_password.ShowDialog()
                End If
            End If
        End If
    End Sub

    Private Sub cmd_trans_history_Click(sender As System.Object, e As System.EventArgs) Handles cmd_trans_history.Click
        frm_trans_history.ShowDialog()
    End Sub
End Class