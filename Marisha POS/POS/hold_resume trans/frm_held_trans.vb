Public Class frm_held_trans

    Dim hold_trans_query As New hold_resume_q

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frm_held_trans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        hold_trans_query.load_trans()
        Me.KeyPreview = True
    End Sub

    Private Sub dgv_trans_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_trans.CellClick
        If dgv_trans.Rows.Count > 0 Then
            Me.lbl_id.Text = dgv_trans.Item("ID", dgv_trans.CurrentRow.Index).Value.ToString()
            If e.ColumnIndex = 3 Then 'for select row'
                If MsgBox(" Resume This Transaction?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, " Confirm Action") = MsgBoxResult.Yes Then
                    frm_invoice.dgv_item_cart.Rows.Clear()
                    hold_trans_query.load_resume_trans()
                    hold_trans_query.load_discount_resume()
                    frm_invoice.looptotal()
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub cmd_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_delete.Click
        If lbl_id.Text = "" Then
            MsgBox(" Please Select a Record to Delete", MsgBoxStyle.Exclamation, " Invalid")
        Else
            If MsgBox(" This Action Cannot Be Undone. Anyway, Delete This Record?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, " Confirm Action") = MsgBoxResult.Yes Then
                hold_trans_query.delete_trans()
                hold_trans_query.delete_trans_item()
                hold_trans_query.load_trans()
                lbl_id.Text = ""
                MsgBox(" Record Deleted!", MsgBoxStyle.Information, " Action Successfull")
            End If
        End If
    End Sub

    'SHORCUT KEYS'
    Private Sub shortcut_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            cmd_cancel.PerformClick()
        End If
    End Sub

End Class