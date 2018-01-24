Public Class frm_payment_records

    Dim cust_bal_query As New cust_bal_q
    Public month As Integer = 1

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frm_payment_records_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cust_bal_query.load_month() 'for dtp settings
        dtp_from.Value = DateTime.Now.AddMonths(-month)
        dtp_to.Value = DateTime.Now
        cmd_filter.PerformClick()
    End Sub

    Private Sub cmd_filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_filter.Click
        cust_bal_query.load_filter_payments()
    End Sub

    Private Sub dgv_payments_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_payments.CellClick
        If dgv_payments.Rows.Count > 0 Then
            Me.lbl_pay_id.Text = dgv_payments.Item("ID", dgv_payments.CurrentRow.Index).Value.ToString()

            If e.ColumnIndex = 4 Then
                If MsgBox(" This Action Cannot Be Undone, Continue?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, " Confirm Delete") = MsgBoxResult.Yes Then

                    Dim cancelled_pay As Decimal = dgv_payments.Item("amt_paid", dgv_payments.CurrentRow.Index).Value.ToString()
                    Dim current_bal As Decimal = Me.lbl_current_bal.Text
                    Dim updated_bal As Decimal = current_bal + cancelled_pay

                    Me.lbl_current_bal.Text = updated_bal
                    frm_customers.lbl_current_bal.Text = updated_bal

                    cust_bal_query.delete_pay()
                    cust_bal_query.load_filter_payments()
                    MsgBox(" Record Successfully Deleted!", MsgBoxStyle.Critical, " Deleted")
                End If
            End If
        End If
    End Sub

    Private Sub cmd_pay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_pay.Click
        lbl_pay_id.Text = ""
        frm_balance_pay.ShowDialog()
    End Sub

    Private Sub cmd_settings_Click(sender As System.Object, e As System.EventArgs) Handles cmd_settings.Click
        frm_date_choose_date.cust_payment = True
        frm_date_choose_date.ShowDialog()
    End Sub
End Class