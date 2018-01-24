Public Class frm_suppliers

    Public adding As Boolean
    Public updating As Boolean

    Dim suppliers_query As New suppliers_q
    Public month_pur As Integer = 0
    Public month_ret As Integer = 0

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub me_FormFormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frm_choose.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        frm_choose.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ss_time_and_date.Text = DateTime.Now.ToString("h:mm tt dddd, d MMMM yyyy")
    End Sub

    Private Sub frm_suppliers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ss_user.Text = frm_choose.lbl_name.Text
        ss_position.Text = frm_choose.lbl_position.Text
        suppliers_query.load_suppliers()
        cmd_pur_trans.PerformClick()
        With cbo_search_by
            .Items.Add("Supplier No.")
            .Items.Add("Supplier Name")
        End With
        cbo_search_by.SelectedIndex = 1

        suppliers_query.load_month_pur() 'for dtp settings
        suppliers_query.load_month_ret() 'for dtp settings

        dtp_purchase_trans_from.Value = DateTime.Now.AddMonths(-month_pur)
        dtp_purchase_trans_to.Value = DateTime.Now
        dtp_purchase_ret_from.Value = DateTime.Now.AddMonths(-month_ret)
        dtp_purchase_ret_to.Value = DateTime.Now
    End Sub

    'SEARCH
    Public search_field As String
    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged
        If Me.cbo_search_by.SelectedIndex = 0 Then
            search_field = "supplier_no"
        ElseIf Me.cbo_search_by.SelectedIndex = 1 Then
            search_field = "supplier_name"
        End If
        suppliers_query.load_search_suppliers()
    End Sub
    Private Sub cmd_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_clear.Click
        txt_search.Clear()
    End Sub

    Private Sub dgv_suppliers_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_suppliers.CellClick
        If dgv_suppliers.Rows.Count > 0 Then
            Me.lbl_supplier_no.Text = dgv_suppliers.Item("supplier_no", dgv_suppliers.CurrentRow.Index).Value.ToString()
            Me.lbl_supplier_name.Text = dgv_suppliers.Item("supplier_name", dgv_suppliers.CurrentRow.Index).Value.ToString()
            Me.lbl_contact_no.Text = dgv_suppliers.Item("contact_no", dgv_suppliers.CurrentRow.Index).Value.ToString()
            Me.lbl_address.Text = dgv_suppliers.Item("address", dgv_suppliers.CurrentRow.Index).Value.ToString()

            suppliers_query.load_supplier_trans_filter()
            lbl_trans_no.Text = ""

            suppliers_query.load_supplier_returns_filter()
            lbl_pur_ret_no.Text = ""
        End If
    End Sub

    Private Sub cmd_addnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_addnew.Click
        If frm_choose.supp_add_supp = True Then
            adding = True
            updating = False
            frm_suppliers_add_update.lblTitle.Text = "Add a New Supplier"
            frm_suppliers_add_update.ShowDialog()
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    Private Sub cmd_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_update.Click
        If frm_choose.supp_updt_supp = True Then
            If lbl_supplier_no.Text = "" Then
                MsgBox(" Please Select a Record to Update", MsgBoxStyle.Exclamation, " Invalid")
            Else
                adding = False
                updating = True
                frm_suppliers_add_update.lblTitle.Text = "Update Supplier Info."
                frm_suppliers_add_update.ShowDialog()
            End If
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    Private Sub dgv_purchase_trans_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_purchase_trans.CellClick
        If dgv_purchase_trans.Rows.Count > 0 Then
            Me.lbl_trans_no.Text = dgv_purchase_trans.Item("trans_no", dgv_purchase_trans.CurrentRow.Index).Value.ToString()

            'SHOW DETAILS ----------'
            If e.ColumnIndex = 8 Then
                If lbl_trans_no.Text = "" Then
                    MsgBox(" Please Select a Purchase Transction Record to View", MsgBoxStyle.Exclamation, " Invalid")
                    Exit Sub
                Else
                    pass_dgv_purchase_info()
                    frm_show_supplier_trans.ShowDialog()
                End If
            End If
        End If
    End Sub

    'Filter Trans'
    Private Sub cmd_filter_trans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_filter_trans.Click
        If CDate(dtp_purchase_trans_from.Value) > CDate(dtp_purchase_trans_to.Value) Then
            MsgBox(" Invalid Date Range! Please Check The Date You Selected.", MsgBoxStyle.Critical, " Invalid")
            dtp_purchase_trans_to.Focus()
        Else
            suppliers_query.load_supplier_trans_filter()
        End If
    End Sub

    Sub pass_dgv_purchase_info()
        frm_show_supplier_trans.lbl_trans_no.Text = dgv_purchase_trans.Item("trans_no", dgv_purchase_trans.CurrentRow.Index).Value.ToString()
        frm_show_supplier_trans.dtp_date.Value = dgv_purchase_trans.Item("trans_date", dgv_purchase_trans.CurrentRow.Index).Value()
        frm_show_supplier_trans.txt_ref_no.Text = dgv_purchase_trans.Item("ref_no", dgv_purchase_trans.CurrentRow.Index).Value.ToString()

        frm_show_supplier_trans.lbl_supplier_no.Text = dgv_purchase_trans.Item("supp_no", dgv_purchase_trans.CurrentRow.Index).Value.ToString()
        frm_show_supplier_trans.lbl_supplier_name.Text = dgv_purchase_trans.Item("supp_name", dgv_purchase_trans.CurrentRow.Index).Value.ToString()

        frm_show_supplier_trans.lbl_sub_total_grand.Text = dgv_purchase_trans.Item("sub_total", dgv_purchase_trans.CurrentRow.Index).Value.ToString()
        frm_show_supplier_trans.lbl_total_discount.Text = dgv_purchase_trans.Item("total_discount", dgv_purchase_trans.CurrentRow.Index).Value.ToString()
        frm_show_supplier_trans.lbl_grand_total.Text = dgv_purchase_trans.Item("grand_total", dgv_purchase_trans.CurrentRow.Index).Value.ToString()
    End Sub

    Private Sub cmd_pur_set_Click(sender As System.Object, e As System.EventArgs) Handles cmd_pur_set.Click
        frm_date_choose_date.purchase_trans = True
        frm_date_choose_date.ShowDialog()
    End Sub

    'RETURNS DGV--------------'
    Private Sub dgv_purchase_returns_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_purchase_returns.CellClick
        If dgv_purchase_returns.Rows.Count > 0 Then
            Me.lbl_pur_ret_no.Text = dgv_purchase_returns.Item("ret_trans_no", dgv_purchase_returns.CurrentRow.Index).Value.ToString()

            'SHOW DETAILS ----------'
            If e.ColumnIndex = 7 Then
                If lbl_pur_ret_no.Text = "" Then
                    MsgBox(" Please Select a Purchase Return Record to View", MsgBoxStyle.Exclamation, " Invalid")
                    Exit Sub
                Else
                    pass_dgv_return_info()
                    frm_show_supplier_purchase_ret.ShowDialog()
                End If
            End If
        End If
    End Sub

    'Filter Return trans'
    Private Sub cmd_filter_ret_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_filter_ret.Click
        If CDate(dtp_purchase_ret_from.Value) > CDate(dtp_purchase_ret_to.Value) Then
            MsgBox(" Invalid Date Range! Please Check The Date You Selected.", MsgBoxStyle.Critical, " Invalid")
            dtp_purchase_ret_to.Focus()
        Else
            suppliers_query.load_supplier_returns_filter()
        End If
    End Sub

    Sub pass_dgv_return_info()
        frm_show_supplier_purchase_ret.lbl_trans_no.Text = dgv_purchase_returns.Item("ret_trans_no", dgv_purchase_returns.CurrentRow.Index).Value.ToString()
        frm_show_supplier_purchase_ret.dtp_date.Value = dgv_purchase_returns.Item("ret_trans_date", dgv_purchase_returns.CurrentRow.Index).Value()
        frm_show_supplier_purchase_ret.txt_ref_no.Text = dgv_purchase_returns.Item("ret_ref_no", dgv_purchase_returns.CurrentRow.Index).Value.ToString()

        frm_show_supplier_purchase_ret.lbl_supplier_no.Text = dgv_purchase_returns.Item("ret_supp_no", dgv_purchase_returns.CurrentRow.Index).Value.ToString()
        frm_show_supplier_purchase_ret.lbl_supplier_name.Text = dgv_purchase_returns.Item("ret_supp_name", dgv_purchase_returns.CurrentRow.Index).Value.ToString()

        frm_show_supplier_purchase_ret.lbl_sub_total_grand.Text = dgv_purchase_returns.Item("ret_sub_total", dgv_purchase_returns.CurrentRow.Index).Value.ToString()
        frm_show_supplier_purchase_ret.lbl_grand_total.Text = dgv_purchase_returns.Item("ret_grand_total", dgv_purchase_returns.CurrentRow.Index).Value.ToString()
    End Sub

    Private Sub cmd_pur_trans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_pur_trans.Click
        lbl_trans_title.Text = "    Purchase Transactions"
        pnl_pur_trans.Show()
        pnl_pur_returns.Hide()
        cmd_pur_trans.BackColor = Color.LightSlateGray
        cmd_pur_trans.ForeColor = Color.White
        cmd_pur_returns.BackColor = Color.White
        cmd_pur_returns.ForeColor = Color.Black
    End Sub

    Private Sub cmd_pur_returns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_pur_returns.Click
        lbl_trans_title.Text = "    Purchase Returns"
        pnl_pur_trans.Hide()
        pnl_pur_returns.Show()
        cmd_pur_trans.BackColor = Color.White
        cmd_pur_trans.ForeColor = Color.Black
        cmd_pur_returns.BackColor = Color.LightSlateGray
        cmd_pur_returns.ForeColor = Color.White
    End Sub

    Private Sub cmd_ret_set_Click(sender As System.Object, e As System.EventArgs) Handles cmd_ret_set.Click
        frm_date_choose_date.purchase_return_trans = True
        frm_date_choose_date.ShowDialog()
    End Sub

End Class