Public Class frm_category

    Public adding As Boolean
    Public updating As Boolean

    Dim category_query As New category_q

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub frm_category_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        category_query.load_category()
    End Sub

    Private Sub dgv_category_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_category.CellClick
        If dgv_category.Rows.Count > 0 Then
            Me.lbl_category_no.Text = dgv_category.Item("category_no", dgv_category.CurrentRow.Index).Value.ToString()
            Me.lbl_category_name.Text = dgv_category.Item("category_name", dgv_category.CurrentRow.Index).Value.ToString()
            Me.lbl_category_desc.Text = dgv_category.Item("category_desc", dgv_category.CurrentRow.Index).Value.ToString()
        End If
    End Sub

    Private Sub cmd_addnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_addnew.Click
        adding = True
        updating = False
        frm_category_addupdate.lblTitle.Text = "Add a New Category"
        frm_category_addupdate.ShowDialog()
    End Sub

    Private Sub cmd_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_update.Click
        If lbl_category_no.Text = "" Then
            MsgBox(" Please Select a Category to Update", MsgBoxStyle.Exclamation, " Invalid")
        Else
            adding = False
            updating = True
            frm_category_addupdate.lblTitle.Text = "Update Category Info."
            frm_category_addupdate.ShowDialog()
        End If
    End Sub

    Private Sub cmd_delete_Click(sender As System.Object, e As System.EventArgs) Handles cmd_delete.Click
        If lbl_category_no.Text = "" Then
            MsgBox(" Please Select a Category to Delete", MsgBoxStyle.Exclamation, " Invalid")
        ElseIf category_query.category_used_in_itemlist = True Then
            MsgBox(" This Category Exists in the Item List. Before Deleting, Please Update the Category of the Items under the Category of: " & Me.lbl_category_name.Text, MsgBoxStyle.Critical, " Action Canceled")
            Exit Sub
        Else
            If MsgBox(" This Action Cannot Be Undone, Continue?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, " Confirm Delete") = MsgBoxResult.Yes Then
                category_query.delete_category()
                Me.lbl_category_no.Text = ""
                category_query.load_category()
            End If
        End If
    End Sub

End Class