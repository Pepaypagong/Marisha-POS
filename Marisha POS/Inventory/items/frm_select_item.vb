Public Class frm_select_item

    Dim inventory_query As New inventory_q
    Dim sales_ret_query As New return_trans_q
    Dim adjusting_query As New adjust_q

    Public add_stock As Boolean
    Public return_stock As Boolean
    Public return_sales As Boolean
    Public bo_sales As Boolean
    Public adjust As Boolean = False

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If add_stock = True Then

            If inventory_query.isInit = True Then
                inventory_query.get_initial_beg_inv()
            Else
                inventory_query.get_not_init_beg_inv()
            End If
            inventory_query.get_ending_inv()

        ElseIf return_stock = True Then

            If inventory_query.isInit_ret = True Then
                inventory_query.get_initial_beg_inv_ret()
            Else
                inventory_query.get_not_init_beg_inv_ret()
            End If
            inventory_query.get_ending_inv_ret()

        ElseIf return_sales = True Then

            If sales_ret_query.isInit = True Then
                sales_ret_query.get_initial_beg_inv()
            Else
                sales_ret_query.get_not_init_beg_inv()
            End If
            sales_ret_query.get_ending_inv()

        ElseIf adjust = True Then

            If adjusting_query.isInit = True Then
                adjusting_query.get_initial_beg_inv()
            Else
                adjusting_query.get_not_init_beg_inv()
            End If
            adjusting_query.get_ending_inv()

        End If
        Me.Dispose()
    End Sub

    Private Sub frm_select_item_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inventory_query.load_item_forselect()

        With cbo_search_by
            .Items.Add("Item Number")
            .Items.Add("Barcode")
            .Items.Add("Item Name")
            .Items.Add("Description")
            .Items.Add("Category")
            .Items.Add("Brand")
        End With
        cbo_search_by.SelectedIndex = 1
    End Sub

    'SEARCH
    Public search_field As String
    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged
        If Me.cbo_search_by.SelectedIndex = 0 Then
            search_field = "item_no"
        ElseIf Me.cbo_search_by.SelectedIndex = 1 Then
            search_field = "barcode"
        ElseIf Me.cbo_search_by.SelectedIndex = 2 Then
            search_field = "item_name"
        ElseIf Me.cbo_search_by.SelectedIndex = 3 Then
            search_field = "description"
        ElseIf Me.cbo_search_by.SelectedIndex = 4 Then
            search_field = "category"
        ElseIf Me.cbo_search_by.SelectedIndex = 5 Then
            search_field = "brand"
        End If
        inventory_query.load_item_forselect_search()
    End Sub
    Private Sub cmd_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_clear.Click
        txt_search.Clear()
    End Sub

    Private Sub dgv_items_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_items.CellClick
        If dgv_items.Rows.Count > 0 Then
            If add_stock = True Then
                If e.ColumnIndex = 12 Then
                    frm_addstock.lbl_item_no.Text = ""
                    frm_addstock.lbl_barcode.Text = ""
                    frm_addstock.lbl_item_name.Text = ""
                    frm_addstock.lbl_category.Text = ""
                    frm_addstock.lbl_brand.Text = ""
                    frm_addstock.lbl_unit.Text = ""

                    frm_addstock.lbl_buying_price.Text = "0.00"
                    frm_addstock.txt_qty.Text = "0"
                    frm_addstock.txt_discount.Text = "0.00"

                    frm_addstock.lbl_item_no.Text = dgv_items.Item("item_no", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_addstock.lbl_barcode.Text = dgv_items.Item("barcode", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_addstock.lbl_item_name.Text = dgv_items.Item("item_name", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_addstock.lbl_buying_price.Text = dgv_items.Item("buying_price", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_addstock.lbl_category.Text = dgv_items.Item("category", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_addstock.lbl_brand.Text = dgv_items.Item("brand", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_addstock.lbl_unit.Text = dgv_items.Item("unit", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_addstock.lbl_init_beg_inv_price.Text = dgv_items.Item("init_beg_inv_price", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_addstock.txt_qty.Enabled = True
                    frm_addstock.txt_discount.Enabled = True
                    Me.Close()
                End If
            ElseIf return_stock = True Then
                If e.ColumnIndex = 12 Then
                    frm_purchase_return.lbl_item_no.Text = ""
                    frm_purchase_return.lbl_barcode.Text = ""
                    frm_purchase_return.lbl_item_name.Text = ""
                    frm_purchase_return.lbl_category.Text = ""
                    frm_purchase_return.lbl_brand.Text = ""
                    frm_purchase_return.lbl_unit.Text = ""

                    frm_purchase_return.lbl_buying_price.Text = "0.00"
                    frm_purchase_return.txt_qty.Text = "0"

                    frm_purchase_return.lbl_item_no.Text = dgv_items.Item("item_no", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_purchase_return.lbl_barcode.Text = dgv_items.Item("barcode", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_purchase_return.lbl_item_name.Text = dgv_items.Item("item_name", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_purchase_return.lbl_buying_price.Text = dgv_items.Item("buying_price", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_purchase_return.lbl_category.Text = dgv_items.Item("category", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_purchase_return.lbl_brand.Text = dgv_items.Item("brand", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_purchase_return.lbl_unit.Text = dgv_items.Item("unit", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_purchase_return.lbl_init_beg_inv_price.Text = dgv_items.Item("init_beg_inv_price", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_purchase_return.txt_qty.Enabled = True
                    Me.Close()
                End If
            ElseIf return_sales = True Then
                If e.ColumnIndex = 12 Then
                    frm_add_sales_return.lbl_item_no.Text = ""
                    frm_add_sales_return.lbl_barcode.Text = ""
                    frm_add_sales_return.lbl_item_name.Text = ""
                    frm_add_sales_return.lbl_category.Text = ""
                    frm_add_sales_return.lbl_brand.Text = ""
                    frm_add_sales_return.lbl_unit.Text = ""

                    frm_add_sales_return.txt_selling_price.Text = "0.00"
                    frm_add_sales_return.txt_qty.Text = "0"

                    frm_add_sales_return.lbl_item_no.Text = dgv_items.Item("item_no", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_add_sales_return.lbl_barcode.Text = dgv_items.Item("barcode", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_add_sales_return.lbl_item_name.Text = dgv_items.Item("item_name", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_add_sales_return.txt_selling_price.Text = dgv_items.Item("selling_price", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_add_sales_return.lbl_category.Text = dgv_items.Item("category", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_add_sales_return.lbl_brand.Text = dgv_items.Item("brand", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_add_sales_return.lbl_unit.Text = dgv_items.Item("unit", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_add_sales_return.lbl_buying_price.Text = dgv_items.Item("buying_price", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_add_sales_return.lbl_init_beg_inv_price.Text = dgv_items.Item("init_beg_inv_price", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_add_sales_return.txt_qty.Enabled = True
                    frm_add_sales_return.txt_selling_price.Enabled = True
                    Me.Close()
                End If
            ElseIf bo_sales = True Then
                If e.ColumnIndex = 12 Then
                    frm_add_bo.lbl_item_no.Text = ""
                    frm_add_bo.lbl_barcode.Text = ""
                    frm_add_bo.lbl_item_name.Text = ""
                    frm_add_bo.lbl_category.Text = ""
                    frm_add_bo.lbl_brand.Text = ""
                    frm_add_bo.lbl_unit.Text = ""

                    frm_add_bo.txt_selling_price.Text = "0.00"
                    frm_add_bo.txt_qty.Text = "0"

                    frm_add_bo.lbl_item_no.Text = dgv_items.Item("item_no", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_add_bo.lbl_barcode.Text = dgv_items.Item("barcode", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_add_bo.lbl_item_name.Text = dgv_items.Item("item_name", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_add_bo.txt_selling_price.Text = dgv_items.Item("selling_price", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_add_bo.lbl_category.Text = dgv_items.Item("category", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_add_bo.lbl_brand.Text = dgv_items.Item("brand", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_add_bo.lbl_unit.Text = dgv_items.Item("unit", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_add_bo.txt_qty.Enabled = True
                    frm_add_bo.txt_selling_price.Enabled = True
                    Me.Close()
                End If

            ElseIf adjust = True Then
                If e.ColumnIndex = 12 Then
                    frm_adjusting.lbl_item_no.Text = ""
                    frm_adjusting.lbl_barcode.Text = ""
                    frm_adjusting.lbl_item_name.Text = ""
                    frm_adjusting.lbl_category.Text = ""
                    frm_adjusting.lbl_brand.Text = ""
                    frm_adjusting.lbl_unit.Text = ""

                    frm_adjusting.lbl_buying_price.Text = "0.00"
                    frm_adjusting.txt_qty.Text = "0"

                    frm_adjusting.lbl_item_no.Text = dgv_items.Item("item_no", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_adjusting.lbl_barcode.Text = dgv_items.Item("barcode", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_adjusting.lbl_item_name.Text = dgv_items.Item("item_name", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_adjusting.lbl_buying_price.Text = dgv_items.Item("buying_price", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_adjusting.lbl_category.Text = dgv_items.Item("category", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_adjusting.lbl_brand.Text = dgv_items.Item("brand", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_adjusting.lbl_unit.Text = dgv_items.Item("unit", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_adjusting.lbl_init_beg_inv_price.Text = dgv_items.Item("init_beg_inv_price", dgv_items.CurrentRow.Index).Value.ToString()
                    frm_adjusting.txt_qty.Enabled = True
                    Me.Close()
                End If
            End If
        End If
    End Sub

End Class