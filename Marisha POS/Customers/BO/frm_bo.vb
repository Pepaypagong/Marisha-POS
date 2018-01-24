Public Class frm_bo

    Dim bo_query As New bo_trans_q
    Public month As Integer = 1

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frm_bo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bo_query.load_month() 'for dtp settings
        dtp_from.Value = DateTime.Now.AddMonths(-month)
        dtp_to.Value = DateTime.Now
        cmd_filter.PerformClick()
    End Sub

    Private Sub cmd_filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_filter.Click
        bo_query.load_trans_filter()
    End Sub

    Private Sub dgv_returns_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_returns.CellClick
        If dgv_returns.Rows.Count > 0 Then
            Me.lbl_trans_no.Text = dgv_returns.Item("ret_trans_no", dgv_returns.CurrentRow.Index).Value.ToString()

            'SHOW DETAILS ----------'
            If e.ColumnIndex = 5 Then
                If lbl_trans_no.Text = "" Then
                    MsgBox(" Please Select a B.O. Transaction Record to View", MsgBoxStyle.Exclamation, " Invalid")
                    Exit Sub
                Else
                    pass_dgv_bo_trans_info()
                    frm_bo_details.ShowDialog()
                End If
            End If
        End If
    End Sub

    Sub pass_dgv_bo_trans_info()
        frm_bo_details.lbl_trans_no.Text = dgv_returns.Item("ret_trans_no", dgv_returns.CurrentRow.Index).Value.ToString()
        frm_bo_details.dtp_date.Text = dgv_returns.Item("ret_trans_date", dgv_returns.CurrentRow.Index).Value.ToString()
        frm_bo_details.txt_receipt_no.Text = dgv_returns.Item("ret_ref_no", dgv_returns.CurrentRow.Index).Value.ToString()
        frm_bo_details.lbl_grand_total.Text = dgv_returns.Item("ret_grand_total", dgv_returns.CurrentRow.Index).Value.ToString()
        frm_bo_details.txt_remarks.Text = dgv_returns.Item("ret_bo_remarks", dgv_returns.CurrentRow.Index).Value.ToString()
    End Sub

    Private Sub cmd_addnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_addnew.Click
        frm_add_bo.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        frm_date_choose_date.bo_trans = True
        frm_date_choose_date.ShowDialog()
    End Sub
End Class