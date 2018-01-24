Public Class frm_adjust_item_qty

    Dim adjust_query As New adjust_q
    Public month As Integer = 1

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frm_adjust_item_qty_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        adjust_query.load_month() 'for dtp settings
        dtp_date_from.Value = DateTime.Now.AddMonths(-month)
        dtp_date_to.Value = DateTime.Now
        cmd_filter_by_date.PerformClick()
    End Sub

    Private Sub cmd_filter_by_date_Click(sender As System.Object, e As System.EventArgs) Handles cmd_filter_by_date.Click
        adjust_query.load_trans_filter()
    End Sub

    Private Sub dgv_adjust_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_adjust.CellClick
        If dgv_adjust.Rows.Count > 0 Then
            If e.ColumnIndex = 4 Then
                pass_dgv_trans_info()
                frm_adjusting_details.ShowDialog()
            End If
        End If
    End Sub

    Sub pass_dgv_trans_info()
        frm_adjusting_details.lbl_trans_no.Text = dgv_adjust.Item("trans_no", dgv_adjust.CurrentRow.Index).Value.ToString()
        frm_adjusting_details.lbl_date_time.Text = dgv_adjust.Item("date_time", dgv_adjust.CurrentRow.Index).Value.ToString()
        frm_adjusting_details.txt_remarks.Text = dgv_adjust.Item("remarks", dgv_adjust.CurrentRow.Index).Value.ToString()
        frm_adjusting_details.lbl_trans_type.Text = dgv_adjust.Item("adjust_type", dgv_adjust.CurrentRow.Index).Value.ToString()
    End Sub

    Private Sub cmd_inc_Click(sender As System.Object, e As System.EventArgs) Handles cmd_inc.Click
        frm_adjusting.lbl_title.Text = "Increase Item Quantity"
        frm_adjusting.inc = True
        frm_adjusting.dec = False
        frm_adjusting.ShowDialog()
    End Sub

    Private Sub cmd_dec_Click(sender As System.Object, e As System.EventArgs) Handles cmd_dec.Click
        frm_adjusting.lbl_title.Text = "Decrease Item Quantity"
        frm_adjusting.inc = False
        frm_adjusting.dec = True
        frm_adjusting.ShowDialog()
    End Sub


    Private Sub cmd_settings_Click(sender As System.Object, e As System.EventArgs) Handles cmd_settings.Click
        frm_date_choose_date.adjust_qty = True
        frm_date_choose_date.ShowDialog()
    End Sub

End Class