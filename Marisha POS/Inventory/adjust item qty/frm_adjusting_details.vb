Public Class frm_adjusting_details

    Dim adjust_query As New adjust_q
    Dim inventory_query As New inventory_q
    Dim item_flow_service As New ItemFlowService

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frm_adjusting_details_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        adjust_query.load_sold_items()
    End Sub

    Private Sub cmd_delete_trans_Click(sender As System.Object, e As System.EventArgs) Handles cmd_delete_trans.Click
        If lbl_trans_no.Text = "" Then
            MsgBox(" Please Close the Form!", MsgBoxStyle.Exclamation, " Invalid")
            Me.Close()
        Else
            If lbl_trans_type.Text = "INCREASE QUANTITY" Then
                If MsgBox(" WARNING! Pressing Yes Will " & vbCrLf &
                            " PERMANENTLY DELETE this Adjustment Record " & vbCrLf &
                            " and DECREASE the Current Items on The Inventory Based on The Included Items on This Record." & vbCrLf &
                            " Are You Sure You Want To Continue?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, " Confirmation") = MsgBoxResult.Yes Then
                    adjust_query.delete_adjust_items()
                    adjust_query.delete_adjust_trans()
                    adjust_query.increase_cancel()

                    'adjust_query.adjusting_inc_cancel()
                    For Each row As DataGridViewRow In Me.dgv_purchase_list.Rows
                        item_flow_service.InsertItemFlow(row.Cells(0).Value, DateTime.Now,
                                                      "INCREASE QUANTITY CANCEL", 0, row.Cells(3).Value, 0, row.Cells(4).Value)
                    Next

                    adjust_query.load_trans_filter()
                    inventory_query.load_item()
                    MsgBox(" Increase Quantity Record Deleted!", MsgBoxStyle.Information, " Action Success")
                    Me.Close()
                End If
            ElseIf lbl_trans_type.Text = "DECREASE QUANTITY" Then
                If MsgBox(" WARNING! Pressing Yes Will " & vbCrLf &
                            " PERMANENTLY DELETE this Adjustment Record " & vbCrLf &
                            " and INCREASE the Current Items on The Inventory Based on The Included Items on This Record." & vbCrLf &
                            " Are You Sure You Want To Continue?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, " Confirmation") = MsgBoxResult.Yes Then
                    adjust_query.delete_adjust_items()
                    adjust_query.delete_adjust_trans()
                    adjust_query.decrease_cancel()

                    'adjust_query.adjusting_dec_cancel()
                    For Each row As DataGridViewRow In Me.dgv_purchase_list.Rows
                        item_flow_service.InsertItemFlow(row.Cells(0).Value, DateTime.Now,
                                                      "INCREASE QUANTITY CANCEL", row.Cells(3).Value, 0, 0, row.Cells(4).Value)
                    Next

                    adjust_query.load_trans_filter()
                    inventory_query.load_item()
                    MsgBox(" Decrease Quantity Record Deleted!", MsgBoxStyle.Information, " Action Success")
                    Me.Close()
                End If
            End If
        End If
    End Sub

End Class