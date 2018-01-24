Public Class frm_showcustomers

    Dim pos_query As New pos_q
    Dim item_flow_service As New ItemFlowService

    Public full_account As Boolean
    Public partial_account As Boolean
    Public partial_account_no_tendered As Boolean

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frm_showcustomers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pos_query.load_customers()
        Me.KeyPreview = True

        With cbo_search_by
            .Items.Add("Customer No.")
            .Items.Add("First Name")
            .Items.Add("Last Name")
        End With
        cbo_search_by.SelectedIndex = 2
    End Sub

    'SEARCH
    Public search_field As String
    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged
        If Me.cbo_search_by.SelectedIndex = 0 Then
            search_field = "customer_no"
        ElseIf Me.cbo_search_by.SelectedIndex = 1 Then
            search_field = "first_name"
        ElseIf Me.cbo_search_by.SelectedIndex = 2 Then
            search_field = "last_name"
        End If
        pos_query.load_search_customers()
    End Sub
    Private Sub cmd_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_clear.Click
        txt_search.Clear()
    End Sub

    Private Sub dgv_customers_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_customers.CellClick
        If dgv_customers.Rows.Count > 0 Then

            Dim firstname As String = dgv_customers.Item("first_name", dgv_customers.CurrentRow.Index).Value.ToString()
            Dim lastname As String = dgv_customers.Item("last_name", dgv_customers.CurrentRow.Index).Value.ToString()

            If full_account = True Then
                If e.ColumnIndex = 3 Then
                    If MsgBox(" Commit Transaction for " + firstname + " " + lastname + " ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, " Please Confirm") = MsgBoxResult.Yes Then
                        'Database Manipulation Here'
                        pos_query.insert_sales_trans_cust()
                        pos_query.Insert_sales_items_cust()

                        'pos_query.insert_begin_end_sales()
                        For Each row As DataGridViewRow In frm_invoice.dgv_item_cart.Rows
                            item_flow_service.InsertItemFlow(row.Cells(0).Value, DateTime.Now,
                                                          "SALES", 0, row.Cells(4).Value, 0, row.Cells(9).Value)
                        Next

                        'pos_query.insert_beg_inv_price()
                        pos_query.deduct_items_qty()
                        MsgBox(" Sales Transaction Saved!", MsgBoxStyle.Information, " Action Successful")
                        Me.Enabled = False
                        'transfer cash tendered and change to invoice tab
                        frm_receipt_preview_customer.full_account = True
                        frm_receipt_preview_customer.partial_account = False
                        frm_receipt_preview_customer.partial_account_no_tendered = False
                        frm_receipt_preview_customer.ShowDialog()
                    End If
                End If
            ElseIf partial_account = True Then
                If e.ColumnIndex = 3 Then
                    If MsgBox(" TRANSACTION INFORMATION " & vbCrLf & "" & vbCrLf &
                          " CUSTOMER NAME : " + firstname + " " + lastname & vbCrLf & "" +
                          " AMOUNT TO PAY : " & frm_pay.lbl_amt_to_pay.Text & vbCrLf & "" +
                          " TENDERED AMOUNT : " & frm_pay.txt_tendered.Text & vbCrLf & "" +
                          " PARTIAL AMOUNT PAID : " & frm_partial_pay.txt_paid_amt.Text & vbCrLf & "" +
                          " REMAINING BALANCE : " & CDec(frm_pay.lbl_amt_to_pay.Text) - CDec(frm_partial_pay.txt_paid_amt.Text) & vbCrLf & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Please Confirm") = MsgBoxResult.Yes Then
                        'Database Manipulation Here'
                        pos_query.insert_sales_trans_cust_partial()
                        pos_query.Insert_sales_items_cust()

                        'pos_query.insert_begin_end_sales()
                        For Each row As DataGridViewRow In frm_invoice.dgv_item_cart.Rows
                            item_flow_service.InsertItemFlow(row.Cells(0).Value, DateTime.Now,
                                                          "SALES", 0, row.Cells(4).Value, 0, row.Cells(9).Value)
                        Next

                        'pos_query.insert_beg_inv_price()
                        pos_query.deduct_items_qty()
                        MsgBox(" Sales Transaction Saved!", MsgBoxStyle.Information, " Action Successful")
                        Me.Enabled = False
                        'transfer cash tendered and change to invoice tab
                        frm_receipt_preview_customer.full_account = False
                        frm_receipt_preview_customer.partial_account = True
                        frm_receipt_preview_customer.partial_account_no_tendered = False
                        frm_receipt_preview_customer.ShowDialog()
                    End If
                End If
            ElseIf partial_account_no_tendered = True Then
                If e.ColumnIndex = 3 Then
                    If MsgBox(" TRANSACTION INFORMATION " & vbCrLf & "" & vbCrLf &
                          " CUSTOMER NAME : " + firstname + " " + lastname & vbCrLf & "" +
                          " AMOUNT TO PAY : " & frm_pay.lbl_amt_to_pay.Text & vbCrLf & "" +
                          " TENDERED AMOUNT : " & frm_pay.txt_tendered.Text & vbCrLf & "" +
                          " PARTIAL AMOUNT PAID : " & frm_pay.txt_tendered.Text & vbCrLf & "" +
                          " REMAINING BALANCE : " & CDec(frm_pay.lbl_amt_to_pay.Text) - CDec(frm_pay.txt_tendered.Text) & vbCrLf & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Please Confirm") = MsgBoxResult.Yes Then
                        'Database Manipulation Here'
                        pos_query.insert_sales_trans_cust_partial_no_casht()
                        pos_query.Insert_sales_items_cust()

                        'pos_query.insert_begin_end_sales()
                        For Each row As DataGridViewRow In frm_invoice.dgv_item_cart.Rows
                            item_flow_service.InsertItemFlow(row.Cells(0).Value, DateTime.Now,
                                                          "SALES", 0, row.Cells(4).Value, 0, row.Cells(9).Value)
                        Next

                        'pos_query.insert_beg_inv_price()
                        pos_query.deduct_items_qty()
                        MsgBox(" Sales Transaction Saved!", MsgBoxStyle.Information, " Action Successful")
                        Me.Enabled = False
                        'transfer cash tendered and change to invoice tab
                        frm_receipt_preview_customer.full_account = False
                        frm_receipt_preview_customer.partial_account = False
                        frm_receipt_preview_customer.partial_account_no_tendered = True
                        frm_receipt_preview_customer.ShowDialog()
                    End If
                End If
            End If
        End If
    End Sub

    'SHORCUT KEYS'
    Private Sub shortcut_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            cmd_cancel.PerformClick()
        End If
    End Sub
    'Private Sub dgv_customers_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_customers.CellDoubleClick
    '    'frm_pay.lbl_supplier_no.Text = ""
    '    'frm_addstock.lbl_supplier_name.Text = ""
    '    'frm_addstock.lbl_supplier_no.Text = dgv_suppliers.Item("supplier_no", dgv_suppliers.CurrentRow.Index).Value.ToString()
    '    'frm_addstock.lbl_supplier_name.Text = dgv_suppliers.Item("supplier_name", dgv_suppliers.CurrentRow.Index).Value.ToString()
    '    Me.Close()
    'End Sub

End Class