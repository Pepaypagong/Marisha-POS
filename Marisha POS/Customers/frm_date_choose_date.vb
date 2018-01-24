Imports System.Data.SqlClient
Imports System.IO

Public Class frm_date_choose_date

    Dim SQL As New SQLControl

    Public adjust_qty As Boolean = False
    Public trans_history As Boolean = False
    Public cust_trans As Boolean = False
    Public cust_payment As Boolean = False
    Public cash_trans As Boolean = False
    Public sales_return_trans As Boolean = False
    Public bo_trans As Boolean = False
    Public purchase_trans As Boolean = False
    Public purchase_return_trans As Boolean = False

    Public query As String

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frm_date_choose_date_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        With cbo_month
            .Items.Add("1")
            .Items.Add("2")
            .Items.Add("3")
            .Items.Add("4")
            .Items.Add("5")
            .Items.Add("6")
            .Items.Add("7")
            .Items.Add("8")
            .Items.Add("9")
            .Items.Add("10")
            .Items.Add("11")
            .Items.Add("12")
        End With
        cbo_month.SelectedIndex = 0

        If adjust_qty = True Then
            query = "adjust_qty"
        ElseIf trans_history = True Then
            query = "trans_history"
        ElseIf cust_trans = True Then
            query = "cust_trans"
        ElseIf cust_payment = True Then
            query = "cust_payment"
        ElseIf cash_trans = True Then
            query = "cash_trans"
        ElseIf sales_return_trans = True Then
            query = "sales_return_trans"
        ElseIf bo_trans = True Then
            query = "bo_trans"
        ElseIf purchase_trans = True Then
            query = "purchase_trans"
        ElseIf purchase_return_trans = True Then
            query = "purchase_return_trans"
        End If

        loads()

    End Sub

    Public Sub loads()
        Try
            Dim loads As String = "SELECT * FROM dtp_settings WHERE part_of_system = '" & query & "' "
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(loads, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then
                cbo_month.Text = SQL.SQLDR("months")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

    Private Sub cmd_pay_Click(sender As System.Object, e As System.EventArgs) Handles cmd_pay.Click
        update_months()

        If adjust_qty = True Then
            frm_adjust_item_qty.month = cbo_month.Text
            frm_adjust_item_qty.dtp_date_from.Value = DateTime.Now.AddMonths(-frm_adjust_item_qty.month)
            frm_adjust_item_qty.dtp_date_to.Value = DateTime.Now
            frm_adjust_item_qty.cmd_filter_by_date.PerformClick()
        ElseIf trans_history = True Then
            frm_trans_history.month = cbo_month.Text
            frm_trans_history.dtp_date_from.Value = DateTime.Now.AddMonths(-frm_trans_history.month)
            frm_trans_history.dtp_date_to.Value = DateTime.Now
            frm_trans_history.cmd_filter_by_date.PerformClick()
        ElseIf cust_trans = True Then
            frm_customers.month = cbo_month.Text
            frm_customers.dtp_from.Value = DateTime.Now.AddMonths(-frm_customers.month)
            frm_customers.dtp_to.Value = DateTime.Now
            frm_customers.cmd_filter.PerformClick()
        ElseIf cust_payment = True Then
            frm_payment_records.month = cbo_month.Text
            frm_payment_records.dtp_from.Value = DateTime.Now.AddMonths(-frm_payment_records.month)
            frm_payment_records.dtp_to.Value = DateTime.Now
            frm_payment_records.cmd_filter.PerformClick()
        ElseIf cash_trans = True Then
            frm_cash_trans.month = cbo_month.Text
            frm_cash_trans.dtp_from.Value = DateTime.Now.AddMonths(-frm_cash_trans.month)
            frm_cash_trans.dtp_to.Value = DateTime.Now
            frm_cash_trans.cmd_filter.PerformClick()
        ElseIf sales_return_trans = True Then
            frm_returns.month = cbo_month.Text
            frm_returns.dtp_from.Value = DateTime.Now.AddMonths(-frm_returns.month)
            frm_returns.dtp_to.Value = DateTime.Now
            frm_returns.cmd_filter.PerformClick()
        ElseIf bo_trans = True Then
            frm_bo.month = cbo_month.Text
            frm_bo.dtp_from.Value = DateTime.Now.AddMonths(-frm_bo.month)
            frm_bo.dtp_to.Value = DateTime.Now
            frm_bo.cmd_filter.PerformClick()
        ElseIf purchase_trans = True Then
            frm_suppliers.month_pur = cbo_month.Text
            frm_suppliers.dtp_purchase_trans_from.Value = DateTime.Now.AddMonths(-frm_suppliers.month_pur)
            frm_suppliers.dtp_purchase_trans_to.Value = DateTime.Now
            frm_suppliers.cmd_filter_trans.PerformClick()
        ElseIf purchase_return_trans = True Then
            frm_suppliers.month_ret = cbo_month.Text
            frm_suppliers.dtp_purchase_ret_from.Value = DateTime.Now.AddMonths(-frm_suppliers.month_ret)
            frm_suppliers.dtp_purchase_ret_to.Value = DateTime.Now
            frm_suppliers.cmd_filter_ret.PerformClick()
        End If

        Me.Close()
    End Sub

    Sub update_months()
        Try
            Dim update_account As String = "UPDATE dtp_settings SET months = @months WHERE part_of_system = @part_of_system"
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(update_account, SQL.SQLCon)
            SQL.SQLCmd.Parameters.AddWithValue("@months", cbo_month.Text)
            SQL.SQLCmd.Parameters.AddWithValue("@part_of_system", query)
            SQL.SQLCmd.ExecuteNonQuery()
            MsgBox(" Update Successful!", MsgBoxStyle.Information, " Settings Updated")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
    End Sub

End Class