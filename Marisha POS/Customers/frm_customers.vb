Public Class frm_customers

    Public adding As Boolean
    Public updating As Boolean

    'for sum of grandtotal and partial_payments'
    Public grandtotal_sum As Decimal = 0
    Public partial_pay_sum As Decimal = 0

    Dim customers_query As New customers_q

    Public month As Integer = 1

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub me_FormFormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frm_choose.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        frm_choose.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ss_time_and_date.Text = DateTime.Now.ToString("h:mm tt dddd, d MMMM yyyy")
    End Sub
    Private Sub frm_customers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ss_user.Text = frm_choose.lbl_name.Text
        ss_position.Text = frm_choose.lbl_position.Text
        customers_query.load_customers()

        With cbo_search_by
            .Items.Add("Customer No.")
            .Items.Add("First Name")
            .Items.Add("Last Name")
        End With
        cbo_search_by.SelectedIndex = 2

        customers_query.load_month() 'for dtp settings
        dtp_from.Value = DateTime.Now.AddMonths(-month)
        dtp_to.Value = DateTime.Now
    End Sub

    'SEARCH
    Public search_field As String
    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged
        If Me.cbo_search_by.SelectedIndex = 0 Then
            search_field = "customer_no"
        ElseIf Me.cbo_search_by.SelectedIndex = 1 Then
            search_field = "first_name"
        ElseIf Me.cbo_search_by.SelectedIndex = 2 Then
            search_field = "last_name"
        End If
        customers_query.load_search_customers()
    End Sub
    Private Sub cmd_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_clear.Click
        txt_search.Clear()
    End Sub

    Private Sub dgv_customers_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_customers.CellClick
        If dgv_customers.Rows.Count > 0 Then
            Me.lbl_customer_no.Text = dgv_customers.Item("customer_no", dgv_customers.CurrentRow.Index).Value.ToString()
            Me.lbl_fname.Text = dgv_customers.Item("first_name", dgv_customers.CurrentRow.Index).Value.ToString()
            Me.lbl_mname.Text = dgv_customers.Item("middle_name", dgv_customers.CurrentRow.Index).Value.ToString()
            Me.lbl_lname.Text = dgv_customers.Item("last_name", dgv_customers.CurrentRow.Index).Value.ToString()
            Me.lbl_contact_no.Text = dgv_customers.Item("contact_no", dgv_customers.CurrentRow.Index).Value.ToString()
            Me.lbl_address.Text = dgv_customers.Item("address", dgv_customers.CurrentRow.Index).Value.ToString()

            cmd_filter.PerformClick()
            lbl_trans_no.Text = ""
            customers_query.payments_sum()
            looptotal()
        End If
    End Sub

    Sub looptotal()
        'Dim grand_total As Decimal = 0
        'Dim partial_pay_total As Decimal = 0

        ''if you have the other column to get the result you  could add a new one like these above 
        'For index As Integer = 0 To dgv_sales_trans.RowCount - 1
        '    grand_total += Convert.ToDecimal(dgv_sales_trans.Rows(index).Cells(5).Value)
        '    partial_pay_total += Convert.ToDecimal(dgv_sales_trans.Rows(index).Cells(8).Value)
        '    'if you have the other column to get the result you  could add a new one like these above (just change Cells(2) to the one you added)
        'Next

        'query for grand total and partial pay'
        customers_query.grandtotal_and_partial_pay_sum()

        Dim total_paid As Decimal = lbl_total_payments.Text
        Dim current_balance As Decimal = grandtotal_sum - partial_pay_sum - total_paid
        lbl_current_bal.Text = current_balance
        'if you have the other column to get the result you  could add a new one like these above 
    End Sub

    Private Sub cmd_addnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_addnew.Click
        If frm_choose.cust_add_cust = True Then
            adding = True
            updating = False
            frm_customer_add_update.lblTitle.Text = "Add a New Customer"
            frm_customer_add_update.ShowDialog()
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    Private Sub cmd_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_update.Click
        If frm_choose.cust_updt_cust = True Then
            If lbl_customer_no.Text = "" Then
                MsgBox(" Please Select a  Record to Update", MsgBoxStyle.Exclamation, " Invalid")
            Else
                adding = False
                updating = True
                frm_customer_add_update.lblTitle.Text = "Update Customer Info"
                frm_customer_add_update.ShowDialog()
            End If
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    Private Sub dgv_sales_trans_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_sales_trans.CellClick
        If dgv_sales_trans.Rows.Count > 0 Then
            Me.lbl_trans_no.Text = dgv_sales_trans.Item("trans_no", dgv_sales_trans.CurrentRow.Index).Value.ToString()

            'SHOW DETAILS ----------'
            If e.ColumnIndex = 9 Then
                If lbl_trans_no.Text = "" Then
                    MsgBox(" Please Select a Sales Transaction Record to View", MsgBoxStyle.Exclamation, " Invalid")
                    Exit Sub
                Else
                    pass_dgv_sales_trans_info()
                    frm_trans_info.ShowDialog()
                End If
            End If
        End If
    End Sub

    'Filter Trans'
    Private Sub cmd_filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_filter.Click
        If dtp_from.Value > dtp_to.Value Then
            MsgBox(" Invalid Date Range! Please Check The Date You Selected.", MsgBoxStyle.Critical, " Invalid")
            dtp_to.Focus()
        Else
            customers_query.load_trans_filter()
        End If
    End Sub

    Sub pass_dgv_sales_trans_info()
        frm_trans_info.lbl_trans_no.Text = dgv_sales_trans.Item("trans_no", dgv_sales_trans.CurrentRow.Index).Value.ToString()
        frm_trans_info.lbl_date_time.Text = dgv_sales_trans.Item("trans_datetime", dgv_sales_trans.CurrentRow.Index).Value.ToString()
        frm_trans_info.lbl_cust_no.Text = Me.lbl_customer_no.Text
        frm_trans_info.lbl_cust_name.Text = Me.lbl_fname.Text + " " + Me.lbl_lname.Text

        frm_trans_info.lbl_disc_percent.Text = dgv_sales_trans.Item("disc_percent", dgv_sales_trans.CurrentRow.Index).Value.ToString()
        frm_trans_info.lbl_sub_total_grand.Text = dgv_sales_trans.Item("sub_total", dgv_sales_trans.CurrentRow.Index).Value.ToString()
        frm_trans_info.lbl_total_discount.Text = dgv_sales_trans.Item("total_discount", dgv_sales_trans.CurrentRow.Index).Value.ToString()
        frm_trans_info.lbl_grand_total.Text = dgv_sales_trans.Item("grand_total", dgv_sales_trans.CurrentRow.Index).Value.ToString()

        frm_trans_info.lbl_cash_tendered.Text = dgv_sales_trans.Item("cash_tendered", dgv_sales_trans.CurrentRow.Index).Value.ToString()
        frm_trans_info.lbl_change.Text = dgv_sales_trans.Item("Change", dgv_sales_trans.CurrentRow.Index).Value.ToString()
        frm_trans_info.lbl_partial_pay.Text = dgv_sales_trans.Item("partial_pay", dgv_sales_trans.CurrentRow.Index).Value.ToString()
        frm_trans_info.lbl_balance.Text = CDec(dgv_sales_trans.Item("grand_total", dgv_sales_trans.CurrentRow.Index).Value.ToString()) - CDec(dgv_sales_trans.Item("partial_pay", dgv_sales_trans.CurrentRow.Index).Value.ToString())
    End Sub

    'Payment Records'
    Private Sub cmd_pay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_pay.Click
        If frm_choose.cust_balpay = True Then
            If lbl_customer_no.Text = "" Then
                MsgBox(" Please Select a Customer!", MsgBoxStyle.Critical, " Invalid Action")
            Else
                copy_to_pay_records()
                frm_payment_records.ShowDialog()
            End If
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    Sub copy_to_pay_records()
        frm_payment_records.lbl_customer_no.Text = Me.lbl_customer_no.text
        frm_payment_records.lbl_fname.Text = Me.lbl_fname.Text
        frm_payment_records.lbl_mname.Text = Me.lbl_mname.Text
        frm_payment_records.lbl_lname.Text = Me.lbl_lname.Text
        frm_payment_records.lbl_current_bal.Text = Me.lbl_current_bal.Text
    End Sub

    'BALANCES'
    Private Sub cmd_balances_Click(sender As System.Object, e As System.EventArgs) Handles cmd_balances.Click
        If frm_choose.cust_report_acc_receive = True Then
            frm_customer_balances.ShowDialog()
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    'ACCOUNT RECEIVABLES'
    Private Sub cmd_acct_receive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_acct_receive.Click
        If frm_choose.cust_report_acc_receive = True Then
            frm_account_receivables.ShowDialog()
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    'CASH TRANS'
    Private Sub cmd_cash_trans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cash_trans.Click
        If frm_choose.cust_cash_trans = True Then
            frm_cash_trans.ShowDialog()
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub


    'RETURNS'
    Private Sub cmd_returns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_returns.Click
        If frm_choose.cust_return_trans = True Then
            frm_returns.ShowDialog()
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    'BO'
    Private Sub cmd_bo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_bo.Click
        If frm_choose.cust_bo_trans = True Then
            frm_bo.ShowDialog()
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    'set datetime pickers default records date range'
    Private Sub cmd_settings_Click(sender As System.Object, e As System.EventArgs) Handles cmd_settings.Click
        frm_date_choose_date.cust_trans = True
        frm_date_choose_date.ShowDialog()
    End Sub

End Class