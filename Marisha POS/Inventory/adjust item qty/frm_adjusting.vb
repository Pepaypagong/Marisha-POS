Public Class frm_adjusting

    Public inc As Boolean
    Public dec As Boolean

    Dim adjust_query As New adjust_q
    Dim inventory_query As New inventory_q
    Dim item_flow_service As New ItemFlowService

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frm_adjusting_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtp_date.Value = DateTime.Now
        adjust_query.get_trans_no()
    End Sub

    Private Sub cmd_select_item_Click(sender As System.Object, e As System.EventArgs) Handles cmd_select_item.Click
        frm_select_item.add_stock = False
        frm_select_item.return_stock = False
        frm_select_item.return_sales = False
        frm_select_item.bo_sales = False
        frm_select_item.adjust = True
        frm_select_item.ShowDialog()
    End Sub

    Private Sub NumOnly_nopoint_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_qty.KeyPress
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
                If Me.inc = True Then
                    add_to_list_inc()
                ElseIf Me.dec = True Then
                    add_to_list_dec()
                End If
            End If
        End If
    End Sub

    Public Sub add_to_list_inc()
        dgv_purchase_list.Rows.Add(New Object() _
                             {lbl_item_no.Text, lbl_barcode.Text,
                              lbl_item_name.Text, lbl_category.Text, lbl_brand.Text,
                              txt_qty.Text, txt_qty.Text, lbl_buying_price.Text,
                              lbl_beginning.Text, CDec(lbl_ending.Text) + CDec(txt_qty.Text),
                              txt_qty.Text * CDec(lbl_buying_price.Text), lbl_init_beg_inv_price.Text, lbl_unit.Text})
        clear_items_field()
    End Sub

    Public Sub add_to_list_dec()
        dgv_purchase_list.Rows.Add(New Object() _
                             {lbl_item_no.Text, lbl_barcode.Text,
                              lbl_item_name.Text, lbl_category.Text, lbl_brand.Text,
                              txt_qty.Text, txt_qty.Text, lbl_buying_price.Text,
                              lbl_beginning.Text, CDec(lbl_ending.Text) - CDec(txt_qty.Text),
                              txt_qty.Text * CDec(lbl_buying_price.Text), lbl_init_beg_inv_price.Text, lbl_unit.Text})
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
    End Sub

    Private Sub cmd_save_Click(sender As System.Object, e As System.EventArgs) Handles cmd_save.Click
        If dtp_date.Value > DateTime.Now Then
            MsgBox(" Invalid Date!, Date Must Not Exceed Today!", MsgBoxStyle.Critical, " Invalid Entry")
            dtp_date.Focus()
        ElseIf dgv_purchase_list.Rows.Count < 1 Then
            MsgBox(" Please Enter Items on The List!", MsgBoxStyle.Critical, " Invalid Entry")
            cmd_select_item.Focus()
        Else

            If inc = True Then
                If MsgBox(" ITEM QUANTITY ADJUSTMENT INFORMATION " & vbCrLf & "" & vbCrLf &
                              " Adjustment Date : " + dtp_date.Text & vbCrLf & "" +
                              " Adjustment Type : Increase Item Quantity", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Are You Sure You Want To Commit Adjustment?") = MsgBoxResult.Yes Then
                    adjust_query.insert_inc_dec_adjust_trans() 'you put conditionals kaya pareho lang'
                    adjust_query.insert_inc_dec_adjust_items()
                    'adjust_query.insert_begin_end_adjust() 'begin end inventory (items)'
                    For Each row As DataGridViewRow In Me.dgv_purchase_list.Rows
                        item_flow_service.InsertItemFlow(row.Cells(0).Value, dtp_date.Value(),
                                                      "INCREASE QUANTITY ADJUST", row.Cells(6).Value, 0, 0, row.Cells(7).Value)
                    Next
                    adjust_query.inc_stock_qty()
                    inventory_query.load_item()
                    MsgBox(" Adjustment Record Successfully Saved!", MsgBoxStyle.Information, " Transaction Saved")
                    adjust_query.load_trans_filter()
                    Me.Close()
                End If
            ElseIf dec = True Then
                If MsgBox(" ITEM QUANTITY ADJUSTMENT INFORMATION " & vbCrLf & "" & vbCrLf &
                              " Adjustment Date : " + dtp_date.Text & vbCrLf & "" +
                              " Adjustment Type : Decrease Item Quantity", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Are You Sure You Want To Commit Adjustment?") = MsgBoxResult.Yes Then
                    adjust_query.insert_inc_dec_adjust_trans()
                    adjust_query.insert_inc_dec_adjust_items()
                    'adjust_query.insert_begin_end_adjust() 'begin end inventory (items)'
                    For Each row As DataGridViewRow In Me.dgv_purchase_list.Rows
                        item_flow_service.InsertItemFlow(row.Cells(0).Value, dtp_date.Value(),
                                                      "DECREASE QUANTITY ADJUST", 0, row.Cells(6).Value, 0, row.Cells(7).Value)
                    Next
                    adjust_query.dec_stock_qty()
                    inventory_query.load_item()
                    MsgBox(" Adjustment Record Successfully Saved!", MsgBoxStyle.Information, " Transaction Saved")
                    adjust_query.load_trans_filter()
                    Me.Close()
                End If
            End If

        End If
    End Sub

    Private Sub dtp_date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_date.ValueChanged
        Me.dgv_purchase_list.Rows.Clear()
    End Sub

    Private Sub txt_qty_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_qty.TextChanged
        If txt_qty.Text = "" Then
            txt_qty.Text = "0"
        End If
    End Sub
End Class