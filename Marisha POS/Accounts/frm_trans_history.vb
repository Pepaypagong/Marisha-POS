Public Class frm_trans_history

    Dim history_query As New trans_history_q

    Public month As Integer = 1

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frm_trans_history_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        history_query.load_month() 'for dtp settings
        dtp_date_from.Value = DateTime.Now.AddMonths(-month)
        dtp_date_to.Value = DateTime.Now
        cmd_filter_by_date.PerformClick()
    End Sub

    Private Sub cmd_filter_by_date_Click(sender As System.Object, e As System.EventArgs) Handles cmd_filter_by_date.Click
        history_query.load_transaction_history_filter()
    End Sub

    Private Sub cmd_set_Click(sender As System.Object, e As System.EventArgs) Handles cmd_set.Click
        frm_date_choose_date.trans_history = True
        frm_date_choose_date.ShowDialog()
    End Sub
End Class