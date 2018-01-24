Public Class frm_show_supplier_purchase_ret

    Dim suppliers_query As New suppliers_q

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frm_show_supplier_purchase_ret_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        suppliers_query.load_returned_items()
    End Sub

    Private Sub cmd_delete_trans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_delete_trans.Click
        If lbl_trans_no.Text = "" Then
            MsgBox(" Please Close the Form!", MsgBoxStyle.Exclamation, " Invalid")
        Else
            If MsgBox(" WARNING! Pressing Yes Will PERMANENTLY DELETE this Purchase Return Record " & vbCrLf & _
                      " and INCREASE the Current Items on The Inventory Based on The Included Items on This Transaction. " & vbCrLf & _
                      " Are You Sure You Want To Continue?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, " Confirmation") = MsgBoxResult.Yes Then
                frm_delete_pass_supp_trans.purchase = False
                frm_delete_pass_supp_trans.returns = True
                frm_delete_pass_supp_trans.sales_ret = False
                frm_delete_pass_supp_trans.sales_bo = False
                frm_delete_pass_supp_trans.sales_cash = False
                frm_delete_pass_supp_trans.sales_cust = False
                frm_delete_pass_supp_trans.ShowDialog()
            End If
        End If
    End Sub

End Class