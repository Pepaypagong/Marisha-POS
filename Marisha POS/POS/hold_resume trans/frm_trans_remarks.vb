Public Class frm_trans_remarks

    Dim hold_trans_query As New hold_resume_q

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub frm_trans_remarks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        hold_trans_query.get_hold_no()
        Me.KeyPreview = True
    End Sub

    Private Sub cmd_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_save.Click
        If MsgBox(" Hold and Save this Transaction? This Action Will Clear Item List, Continue?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Are You Sure You Want To Save?") = MsgBoxResult.Yes Then
            hold_trans_query.insert_trans()
            hold_trans_query.insert_trans_items()
            MsgBox(" Record Saved!", MsgBoxStyle.Information, " Record Successfully Saved")
            frm_invoice.dgv_item_cart.DataSource = Nothing 'remove data source if dgv bound to database'
            frm_invoice.dgv_item_cart.Rows.Clear() 'clear item cart'
            frm_invoice.lbl_disc_percent.Text = "0" 'clear discount'
            frm_invoice.looptotal() 'loop total on invoice'
            Me.Close()
        End If
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        Me.Dispose()
    End Sub

    'SHORCUT KEYS'
    Private Sub shortcut_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            cmd_cancel.PerformClick()
        End If
    End Sub

    'enable textboxes to keypress enter trigger event
    Private Sub login_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_remarks.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            cmd_save.PerformClick()
        End If
    End Sub
End Class