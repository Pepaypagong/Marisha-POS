Public Class frm_select_supplier

    Dim inventory_query As New inventory_q

    Public add_stock As Boolean
    Public return_stock As Boolean

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frm_select_supplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inventory_query.load_suppliers_forselect()
        With cbo_search_by
            .Items.Add("Supplier No.")
            .Items.Add("Supplier Name")
        End With
        cbo_search_by.SelectedIndex = 1
    End Sub

    'SEARCH
    Public search_field As String
    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged
        If Me.cbo_search_by.SelectedIndex = 0 Then
            search_field = "supplier_no"
        ElseIf Me.cbo_search_by.SelectedIndex = 1 Then
            search_field = "supplier_name"
        End If
        inventory_query.load_suppliers_forselect_search()
    End Sub
    Private Sub cmd_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_clear.Click
        txt_search.Clear()
    End Sub

    Private Sub dgv_suppliers_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_suppliers.CellClick
        If dgv_suppliers.Rows.Count > 0 Then
            If add_stock = True Then
                If e.ColumnIndex = 2 Then
                    frm_addstock.lbl_supplier_no.Text = ""
                    frm_addstock.lbl_supplier_name.Text = ""
                    frm_addstock.lbl_supplier_no.Text = dgv_suppliers.Item("supplier_no", dgv_suppliers.CurrentRow.Index).Value.ToString()
                    frm_addstock.lbl_supplier_name.Text = dgv_suppliers.Item("supplier_name", dgv_suppliers.CurrentRow.Index).Value.ToString()
                    Me.Close()
                End If
            Else
                If e.ColumnIndex = 2 Then
                    frm_purchase_return.lbl_supplier_no.Text = ""
                    frm_purchase_return.lbl_supplier_name.Text = ""
                    frm_purchase_return.lbl_supplier_no.Text = dgv_suppliers.Item("supplier_no", dgv_suppliers.CurrentRow.Index).Value.ToString()
                    frm_purchase_return.lbl_supplier_name.Text = dgv_suppliers.Item("supplier_name", dgv_suppliers.CurrentRow.Index).Value.ToString()
                    Me.Close()
                End If
            End If
        End If
    End Sub

End Class