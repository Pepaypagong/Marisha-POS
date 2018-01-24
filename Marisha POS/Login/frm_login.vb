Public Class frm_login

    Private SQL As New SQLControl
    Private login_query As New login_q

    Private Sub cmd_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_exit.Click
        If MsgBox(" Are You Sure You Want To Exit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub cmd_enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_enter.Click
        If login_query.admin_exists = True Then
            If SQL.HasConnection = True Then
                If login_query.IsAuthenticated() = True Then

                    'for sales_trans_table - sales->income statement'
                    If login_query.meron_na_sys_gen_entry_sales = False Then
                        login_query.insert_sys_gen_sales_trans() 'insert system generated entry sales for today'
                    End If
                    'for purchase_trans_table - sales->income statement'
                    If login_query.meron_na_sys_gen_entry_purchase = False Then
                        login_query.insert_sys_gen_purchase_trans() 'insert system generated entry purchases for today'
                    End If
                    'for sales_item_table - inventory->item sales report'
                    If login_query.meron_na_sys_gen_entry_sales_item = False Then
                        login_query.insert_sys_gen_sales_item()
                    End If
                    'for purchase_item_table - inventory->item purchases report'
                    If login_query.meron_na_sys_gen_entry_purchase_item = False Then
                        login_query.insert_sys_gen_purchase_item()
                    End If
                    'for begin_end inv table'
                    'If login_query.meron_na_sys_gen_entry_begin_end = False Then
                    '    login_query.insert_sysgen_begin_end_inv()
                    'End If
                    If login_query.meron_na_sys_gen_entry_cust_pay = False Then
                        login_query.insert_pay()
                    End If

                    Me.Hide()
                    login_query.get_user_info() 'show logged-in user info'
                    login_query.retrieve_user_pic()
                    frm_choose.ShowDialog()
                End If
            End If
            Me.txt_password.Clear()
            Me.txt_username.Clear()
            Me.txt_username.Focus()
        Else
            If MsgBox(" Hi! To Start, Please Press Yes to Create an ADMIN Account.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                frm_initial_admin.ShowDialog()
            End If
        End If
    End Sub

    'enable textboxes to keypress enter trigger event
    Private Sub login_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_username.KeyDown, txt_password.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            cmd_enter.PerformClick()
        End If
    End Sub

    Private Sub frm_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        login_query.load_item()
        login_query.load_customers()
    End Sub

End Class