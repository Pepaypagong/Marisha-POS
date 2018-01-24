Public Class frm_purchase_return

    Dim inventory_query As New inventory_q
    Dim item_flow_service As New ItemFlowService
    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frm_purchase_return_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inventory_query.get_return_trans_no()
        dtp_date.Value = DateTime.Now
    End Sub

    Private Sub cmd_select_supplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_select_supplier.Click
        frm_select_supplier.add_stock = False
        frm_select_supplier.return_stock = True
        frm_select_supplier.ShowDialog()
    End Sub

    Private Sub cmd_select_item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_select_item.Click
        frm_select_item.add_stock = False
        frm_select_item.return_stock = True
        frm_select_item.return_sales = False
        frm_select_item.bo_sales = False
        frm_select_item.ShowDialog()
    End Sub

    Private Sub txt_qty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_qty.TextChanged
        If Not IsNumeric(txt_qty.Text) Then
            txt_qty.Text = "0"
        Else
            If txt_qty.Text = "" Then
                txt_qty.Text = "0"
            End If
            Dim qty As Decimal = Me.txt_qty.Text
            Dim buying_price As Decimal = Me.lbl_buying_price.Text

            Dim sub_total As Decimal = qty * buying_price
            Me.lbl_sub_total.Text = Math.Round(CDec(sub_total), 2)

            Dim total_amt As Decimal = sub_total
            Me.lbl_total_after_disc.Text = Math.Round(CDec(total_amt), 2)
        End If
    End Sub

    Private Sub NumOnly_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_qty.KeyPress
        If lbl_unit.Text = "KGS" Then
            If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
                e.Handled = True
            End If

            ' only allow one decimal point
            If e.KeyChar = "."c AndAlso TryCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
                e.Handled = True
            End If
        Else
            If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmd_add_to_list_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_add_to_list.Click
        If lbl_item_no.Text = "" Then
            MsgBox(" Please Select an Item First!", MsgBoxStyle.Critical, " Action Cancelled")
            cmd_select_item.Focus()
        ElseIf CDec(txt_qty.Text) <= 0 Then
            MsgBox(" Please Input the Item Quantity!", MsgBoxStyle.Critical, " Invalid Entry")
            txt_qty.Focus()
        Else
            Dim exists As Boolean = False
            For Each itm As DataGridViewRow In dgv_purchase_list.Rows
                If itm.Cells(0).Value = lbl_item_no.Text Then
                    exists = True
                End If
            Next
            If Me.dgv_purchase_list.Rows.Count > 0 AndAlso exists = True Then
                MsgBox(" This Item is Already in The Item List! ", MsgBoxStyle.Critical, " Invalid Action")
                clear_items_field()
                Exit Sub
            Else
                add_to_list()
                looptotal()
            End If
        End If
    End Sub

    Public Sub add_to_list()
        dgv_purchase_list.Rows.Add(New Object() _
                             {lbl_item_no.Text, lbl_barcode.Text, _
                              lbl_item_name.Text, lbl_category.Text, lbl_brand.Text, _
                              txt_qty.Text, txt_qty.Text, lbl_unit.Text, lbl_buying_price.Text, _
                              lbl_total_after_disc.Text, lbl_beginning.Text, CDec(lbl_ending.Text) - CDec(txt_qty.Text), _
                              txt_qty.Text * CDec(lbl_buying_price.Text), lbl_init_beg_inv_price.Text})
        clear_items_field()
    End Sub

    Sub clear_items_field()
        Me.lbl_item_no.Text = ""
        Me.lbl_barcode.Text = ""
        Me.lbl_item_name.Text = ""
        Me.lbl_category.Text = ""
        Me.lbl_brand.Text = ""
        Me.lbl_unit.Text = ""

        Me.lbl_buying_price.Text = "0.00"
        Me.txt_qty.Text = "0"

        Me.txt_qty.Enabled = False
    End Sub

    Public Sub delete_row()
        If dgv_purchase_list.SelectedRows.Count > 0 Then
            dgv_purchase_list.Rows.Remove(dgv_purchase_list.SelectedRows(0))
        End If
    End Sub

    Private Sub dgv_purchase_list_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_purchase_list.CellDoubleClick
        delete_row()
        clear_items_field()
        looptotal()
    End Sub

    Sub looptotal()
        Dim sub_total As Decimal = 0
        Dim grand_total As Decimal = 0

        'if you have the other column to get the result you  could add a new one like these above 
        For index As Integer = 0 To dgv_purchase_list.RowCount - 1
            sub_total += Convert.ToDecimal(dgv_purchase_list.Rows(index).Cells(6).Value * dgv_purchase_list.Rows(index).Cells(8).Value)
            grand_total += Convert.ToDecimal(dgv_purchase_list.Rows(index).Cells(9).Value)
            'if you have the other column to get the result you  could add a new one like these above (just change Cells(2) to the one you added)
        Next
        lbl_sub_total_grand.Text = sub_total
        lbl_grand_total.Text = grand_total
        'if you have the other column to get the result you  could add a new one like these above 
    End Sub

    Private Sub cmd_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_save.Click
        If lbl_supplier_no.Text = "" Then
            MsgBox(" Please Select a Supplier!", MsgBoxStyle.Critical, " Invalid Entry")
            cmd_select_supplier.Focus()
        ElseIf dtp_date.Value > DateTime.Now Then
            MsgBox(" Invalid Date!, Date Must Not Exceed Today!", MsgBoxStyle.Critical, " Invalid Entry")
            dtp_date.Focus()
        ElseIf dgv_purchase_list.Rows.Count < 1 Then
            MsgBox(" Please Enter Items on The List!", MsgBoxStyle.Critical, " Invalid Entry")
            cmd_select_item.Focus()
        Else
            If MsgBox(" PURCHASE RETURN INFORMATION " & vbCrLf & "" & vbCrLf & _
                          " Date : " + dtp_date.Text & vbCrLf & "" + _
                          " Return Transaction No : " + lbl_trans_no.Text & vbCrLf & "" + _
                          " Supplier No. : " + lbl_supplier_no.Text & vbCrLf & "" + _
                          " Supplier Name : " + lbl_supplier_name.Text & vbCrLf & "" + _
                          " Refrerence No. : " + txt_ref_no.Text & vbCrLf & "" & vbCrLf & "" + _
                          " Sub Total : P " + lbl_sub_total_grand.Text & vbCrLf & "" + _
                          " Grand Total : P " + lbl_grand_total.Text & vbCrLf & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Are You Sure You Want To Commit The Purchase Return Transaction?") = MsgBoxResult.Yes Then
                inventory_query.insert_purchase_return_trans()
                inventory_query.insert_purchase_return_items()
                'inventory_query.insert_begin_end_purchase_ret() 'begin end inventory (items)'
                For Each row As DataGridViewRow In me.dgv_purchase_list.Rows
                    item_flow_service.InsertItemFlow(row.Cells(0).Value, me.dtp_date.Value,
                                                  "PURCHASE RETURN", 0, row.Cells(6).Value, 0, row.Cells(8).Value)
                Next
                'inventory_query.insert_beg_inv_price_ret()
                inventory_query.reduce_stock_qty()
                inventory_query.load_item()
                MsgBox(" Purchase Return Successfully Recorded!", MsgBoxStyle.Information, " Transaction Saved")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub dtp_date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_date.ValueChanged
        Me.dgv_purchase_list.Rows.Clear()
    End Sub

End Class