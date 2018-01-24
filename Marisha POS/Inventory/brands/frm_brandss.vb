Public Class frm_brandss

    Public adding As Boolean
    Public updating As Boolean

    Dim brand_query As New brands_q

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub frm_brand_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        brand_query.load_brand()
    End Sub

    Private Sub dgv_brand_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_brand.CellClick
        If dgv_brand.Rows.Count > 0 Then
            Me.lbl_brand_no.Text = dgv_brand.Item("brand_no", dgv_brand.CurrentRow.Index).Value.ToString()
            Me.lbl_brand_name.Text = dgv_brand.Item("brand_name", dgv_brand.CurrentRow.Index).Value.ToString()
        End If
    End Sub

    Private Sub cmd_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_addnew.Click
        adding = True
        updating = False
        frm_brands_addupdate.lblTitle.Text = "Add a New Brand"
        frm_brands_addupdate.ShowDialog()
    End Sub

    Private Sub cmd_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_update.Click
        If lbl_brand_no.Text = "" Then
            MsgBox(" Please Select a Brand to Update", MsgBoxStyle.Exclamation, " Invalid")
        Else
            adding = False
            updating = True
            frm_brands_addupdate.lblTitle.Text = "Update Brand Info."
            frm_brands_addupdate.ShowDialog()
        End If
    End Sub

End Class