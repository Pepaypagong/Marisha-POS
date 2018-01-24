Public Class frm_cash_trans

    Dim cash_query As New cash_trans_q
    Public month As Integer = 1

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frm_cash_trans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cash_query.load_month() 'for dtp settings
        dtp_from.Value = DateTime.Now.AddMonths(-month)
        dtp_to.Value = DateTime.Now
        cmd_filter.PerformClick()
    End Sub

    Private Sub cmd_filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_filter.Click
        cash_query.load_trans_filter()
    End Sub

    Private Sub dgv_cash_trans_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_cash_trans.CellClick
        If dgv_cash_trans.Rows.Count > 0 Then
            Me.lbl_trans_no.Text = dgv_cash_trans.Item("trans_no", dgv_cash_trans.CurrentRow.Index).Value.ToString()

            'SHOW DETAILS ----------'
            If e.ColumnIndex = 8 Then
                If lbl_trans_no.Text = "" Then
                    MsgBox(" Please Select a Cash Sales Transaction Record to View", MsgBoxStyle.Exclamation, " Invalid")
                    Exit Sub
                Else
                    pass_dgv_sales_trans_info()
                    frm_cash_trans_details.ShowDialog()
                End If
            End If
        End If
    End Sub

    Sub pass_dgv_sales_trans_info()
        frm_cash_trans_details.lbl_trans_no.Text = dgv_cash_trans.Item("trans_no", dgv_cash_trans.CurrentRow.Index).Value.ToString()
        frm_cash_trans_details.lbl_date_time.Text = dgv_cash_trans.Item("trans_datetime", dgv_cash_trans.CurrentRow.Index).Value.ToString()

        frm_cash_trans_details.lbl_disc_percent.Text = dgv_cash_trans.Item("disc_percent", dgv_cash_trans.CurrentRow.Index).Value.ToString()
        frm_cash_trans_details.lbl_sub_total_grand.Text = dgv_cash_trans.Item("sub_total", dgv_cash_trans.CurrentRow.Index).Value.ToString()
        frm_cash_trans_details.lbl_total_discount.Text = dgv_cash_trans.Item("total_discount", dgv_cash_trans.CurrentRow.Index).Value.ToString()
        frm_cash_trans_details.lbl_grand_total.Text = dgv_cash_trans.Item("grand_total", dgv_cash_trans.CurrentRow.Index).Value.ToString()

        frm_cash_trans_details.lbl_cash_tendered.Text = dgv_cash_trans.Item("cash_tendered", dgv_cash_trans.CurrentRow.Index).Value.ToString()
        frm_cash_trans_details.lbl_change.Text = dgv_cash_trans.Item("change", dgv_cash_trans.CurrentRow.Index).Value.ToString()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        frm_date_choose_date.cash_trans = True
        frm_date_choose_date.ShowDialog()
    End Sub
End Class