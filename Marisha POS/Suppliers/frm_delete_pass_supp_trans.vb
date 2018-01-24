Public Class frm_delete_pass_supp_trans

    Dim supplier_query As New suppliers_q
    Dim bo_query As New bo_trans_q
    Dim sales_ret_query As New return_trans_q
    Dim cash_query As New cash_trans_q
    Dim customer_query As New customers_q
    Dim item_flow_service As New ItemFlowService

    Public purchase As Boolean 'purchase delete
    Public returns As Boolean 'purchase return delete

    Public sales_ret As Boolean 'sales return delete
    Public sales_bo As Boolean 'sales bo delete

    Public sales_cash As Boolean 'sales cash delete
    Public sales_cust As Boolean 'sales customer delete

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub cmd_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_delete.Click
        If supplier_query.password_authenticate = True Then
            If purchase = True Then
                If MsgBox(" Warning! This Action Cannot Be Undone, Continue?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, " Confirm Delete") = MsgBoxResult.Yes Then
                    supplier_query.delete_trans()
                    supplier_query.delete_trans_items()
                    supplier_query.deduct_deleted_items()
                    'supplier_query.adjusting_pur() 'ADJUST BEG END INV'
                    For Each row As DataGridViewRow In frm_show_supplier_trans.dgv_purchase_list.Rows
                        item_flow_service.InsertItemFlow(row.Cells(4).Value, DateTime.Now,
                                                      "PURCHASE CANCEL", 0, row.Cells(10).Value, 0, row.Cells(12).Value)
                    Next

                    MsgBox(" Purchase Transaction Successfully Deleted!", MsgBoxStyle.Information, " Purchase Transaction Deleted")
                    Me.Close()
                    frm_show_supplier_trans.Dispose()
                    supplier_query.load_supplier_trans_filter()
                    frm_suppliers.lbl_trans_no.Text = ""
                End If
            ElseIf returns = True Then
                If MsgBox(" Warning! This Action Cannot Be Undone, Continue?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, " Confirm Delete") = MsgBoxResult.Yes Then
                    supplier_query.delete_trans_returns()
                    supplier_query.delete_trans_items_returns()
                    supplier_query.add_deleted_items()
                    'supplier_query.adjusting_pur_ret() 'ADJUST BEG END INV'
                    For Each row As DataGridViewRow In frm_show_supplier_purchase_ret.dgv_purchase_list.Rows
                        item_flow_service.InsertItemFlow(row.Cells(4).Value, DateTime.Now,
                                                      "PURCHASE RETURN CANCEL", row.Cells(10).Value, 0, 0, row.Cells(12).Value)
                    Next
                    MsgBox(" Purchase Return Transaction Successfully Deleted!", MsgBoxStyle.Information, " Purchase Return Transaction Deleted")
                    Me.Close()
                    frm_show_supplier_purchase_ret.Dispose()
                    supplier_query.load_supplier_returns_filter()
                End If
            ElseIf sales_ret = True Then
                If MsgBox(" Warning! This Action Cannot Be Undone, Continue?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, " Confirm Delete") = MsgBoxResult.Yes Then
                    sales_ret_query.delete_trans_returns()
                    sales_ret_query.delete_trans_items_returns()
                    sales_ret_query.deduct_deleted_items()
                    'sales_ret_query.adjusting() 'ADJUST BEG END INV'
                    For Each row As DataGridViewRow In frm_returns_details.dgv_returned_items.Rows
                        item_flow_service.InsertItemFlow(row.Cells(0).Value, DateTime.Now,
                                                      "SALES RETURN CANCEL", 0, row.Cells(3).Value, 0, row.Cells(7).Value)
                    Next

                    MsgBox(" Sales Return Transaction Successfully Deleted!", MsgBoxStyle.Information, " Sales Return Transaction Deleted")
                    Me.Close()
                    frm_returns_details.Dispose()
                    sales_ret_query.load_trans_filter()
                End If
            ElseIf sales_bo = True Then
                If MsgBox(" Warning! This Action Cannot Be Undone, Continue?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, " Confirm Delete") = MsgBoxResult.Yes Then
                    bo_query.delete_trans_bo()
                    bo_query.delete_trans_items_bo()
                    MsgBox(" B.O. Transaction Successfully Deleted!", MsgBoxStyle.Information, " B.O. Transaction Deleted")
                    Me.Close()
                    frm_bo_details.Dispose()
                    bo_query.load_trans_filter()
                End If
            ElseIf sales_cash = True Then
                If MsgBox(" Warning! This Action Cannot Be Undone, Continue?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, " Confirm Delete") = MsgBoxResult.Yes Then
                    cash_query.delete_trans_cash_sales()
                    cash_query.delete_trans_cash_items()
                    cash_query.increase_deleted_items()

                    For Each row As DataGridViewRow In frm_cash_trans_details.dgv_sold_items.Rows
                        item_flow_service.InsertItemFlow(row.Cells(0).Value, DateTime.Now,
                                                      "SALES CANCEL", row.Cells(3).Value, 0, 0, row.Cells(8).Value)
                    Next

                    ''cash_query.adjusting() 'ADJUST BEG END INV'
                    MsgBox(" Cash Sales Transaction Successfully Deleted!", MsgBoxStyle.Information, " Cash Sales Transaction Deleted")
                    Me.Close()
                    frm_cash_trans_details.Dispose()
                    cash_query.load_trans_filter()
                End If
            ElseIf sales_cust = True Then
                If MsgBox(" Warning! This Action Cannot Be Undone, Continue?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, " Confirm Delete") = MsgBoxResult.Yes Then
                    customer_query.delete_trans_cust_sales()
                    customer_query.delete_trans_cust_items()
                    customer_query.increase_deleted_items()
                    'customer_query.adjusting() 'ADJUST BEG END INV'
                    For Each row As DataGridViewRow In frm_trans_info.dgv_sold_items.Rows
                        item_flow_service.InsertItemFlow(row.Cells(0).Value, DateTime.Now,
                                                      "SALES CANCEL", row.Cells(3).Value, 0, 0, row.Cells(8).Value)
                    Next
                    MsgBox(" Customer On-Account Sales Transaction Successfully Deleted!", MsgBoxStyle.Information, " Customer On-Account Sales Transaction Deleted")
                    Me.Close()
                    frm_trans_info.Dispose()
                    customer_query.load_trans_filter()
                End If
            End If
        Else
            MsgBox(" Invalid Password!", MsgBoxStyle.Critical, " Action Cancelled")
            txt_password.Clear()
            txt_password.Focus()
        End If
    End Sub

End Class