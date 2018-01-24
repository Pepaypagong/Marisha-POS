Public Class frm_discount

    Public adding As Boolean
    Public updating As Boolean

    Dim disc_query As New discount_q

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub frm_discount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        disc_query.load_discount()
    End Sub

    Private Sub dgv_discount_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_discount.CellClick
        If dgv_discount.Rows.Count > 0 Then
            Me.lbl_no.Text = dgv_discount.Item("no", dgv_discount.CurrentRow.Index).Value.ToString()
            Me.lbl_disc_name.Text = dgv_discount.Item("discount_name", dgv_discount.CurrentRow.Index).Value.ToString()
            Me.lbl_discount.Text = dgv_discount.Item("discount", dgv_discount.CurrentRow.Index).Value.ToString()
        End If
    End Sub

    Private Sub cmd_addnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_addnew.Click
        adding = True
        updating = False
        frm_add_discount.lblTitle.Text = "Add a New Discount"
        frm_add_discount.ShowDialog()
    End Sub

    Private Sub cmd_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_delete.Click
        If lbl_no.Text = "" Then
            MsgBox(" Please Select a Record to Delete", MsgBoxStyle.Exclamation, " Invalid")
        Else
            If MsgBox(" This Action Cannot Be Undone. Anyway, Delete This Record?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, " Confirm Action") = MsgBoxResult.Yes Then
                disc_query.delete_discount()
                disc_query.load_discount()
            End If
        End If
    End Sub
End Class