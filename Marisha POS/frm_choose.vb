Public Class frm_choose

    Public admin As Boolean = False
    Public pos_sales_trans As Boolean = False
    Public pos_receipt As Boolean = False
    Public inv_category As Boolean = False
    Public inv_brands As Boolean = False
    Public inv_add_item As Boolean = False
    Public inv_updt_item As Boolean = False
    Public inv_add_stocks As Boolean = False
    Public inv_purchase_return As Boolean = False
    Public inv_report_inv As Boolean = False
    Public inv_report_pur As Boolean = False
    Public inv_report_sales As Boolean = False
    Public sales_report_remit As Boolean = False
    Public sales_report_incstate As Boolean = False
    Public cust_add_cust As Boolean = False
    Public cust_updt_cust As Boolean = False
    Public cust_balpay As Boolean = False
    Public cust_report_acc_receive As Boolean = False
    Public cust_cash_trans As Boolean = False
    Public cust_return_trans As Boolean = False
    Public cust_bo_trans As Boolean = False
    Public supp_add_supp As Boolean = False
    Public supp_updt_supp As Boolean = False

    Private login_query As New login_q

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        login_query.load_item()
        Me.Dispose()

    End Sub

    Private Sub me_FormFormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_login.Show()
    End Sub

    Private Sub cmd_pos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_pos.Click
        If pos_sales_trans = True Then
            Me.Hide()
            frm_invoice.ShowDialog()
        Else
            MsgBox(" Restricted Access to POS! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    Private Sub cmd_inv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_inv.Click
        Me.Hide()
        frm_inventory.ShowDialog()
    End Sub

    Private Sub cmd_salesrep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_salesrep.Click
        Me.Hide()
        frm_salesrep.ShowDialog()
    End Sub

    Private Sub cmd_accounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_accounts.Click
        If admin = True Then
            Me.Hide()
            frm_accounts.ShowDialog()
        Else
            MsgBox(" Restricted Access to User Accounts! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    Private Sub cmd_customers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_customers.Click
        Me.Hide()
        frm_customers.ShowDialog()
    End Sub

    Private Sub cmd_suppliers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_suppliers.Click
        Me.Hide()
        frm_suppliers.ShowDialog()
    End Sub

    Private Sub cmd_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_logout.Click
        If MsgBox(" Are You Sure You Want To Log - Out?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Me.Close()
            frm_login.Show()
        End If
    End Sub

End Class