Public Class transactionItemService

    Dim SQL As New SQLControl

    'cash sales, customer sales, sales return, purchase, purchase return, reject
    Public Sub GetViewData(transType As String, selectedId As Integer)
        Try
            Dim params As New Dictionary(Of String, Object)
            params.Add("@id", selectedId)

            Dim query_string As String = ""

            Select Case transType

                Case "cash sales"
                    query_string = "SELECT * FROM sales_trans_table WHERE trans_no = @id"
                Case "customer sales"
                    query_string = "SELECT b.first_name + ' ' + b.last_name as customer, " &
                    "a.* FROM sales_trans_table a LEFT JOIN customers_table b " &
                    "ON a.customer_no = b.customer_no " &
                    "WHERE a.trans_no = @id"
                Case "sales return"
                    query_string = "SELECT * FROM sales_trans_table WHERE trans_no = @id"
                Case "purchase"
                    query_string = "SELECT b.supplier_name, " &
                    "a.* FROM purchase_trans_table a LEFT JOIN supplier_table b " &
                    "ON a.supplier_no = b.supplier_no " &
                    "WHERE a.trans_no = @id"
                Case "purchase return"
                    query_string = "SELECT b.supplier_name, " &
                    "a.* FROM purchase_trans_table a LEFT JOIN supplier_table b " &
                    "ON a.supplier_no = b.supplier_no " &
                    "WHERE a.trans_no = @id"
                Case "reject"
                    query_string = "SELECT * FROM sales_trans_table WHERE trans_no = @id"
            End Select

            Dim data_table As DataTable = SQL.GlobalFetch(query_string, params)

            Select Case transType

                Case "cash sales"
                    frm_transaction_items.lbl_trans_no.Text = data_table.Rows.Item(0).Item("trans_no")
                    frm_transaction_items.dtp_date.Value = data_table.Rows.Item(0).Item("trans_datetime")
                Case "customer sales"
                    frm_transaction_items.lbl_trans_no.Text = data_table.Rows.Item(0).Item("trans_no")
                    frm_transaction_items.lbl_supplier_name.Text = data_table.Rows.Item(0).Item("customer") 'customer name
                    frm_transaction_items.dtp_date.Value = data_table.Rows.Item(0).Item("trans_datetime")
                Case "sales return"
                    frm_transaction_items.lbl_trans_no.Text = data_table.Rows.Item(0).Item("trans_no")
                    frm_transaction_items.dtp_date.Value = data_table.Rows.Item(0).Item("trans_datetime")
                    frm_transaction_items.txt_ref_no.Text = data_table.Rows.Item(0).Item("customer_name") 'receipt no is on cust name
                    frm_transaction_items.txt_remarks.Text = data_table.Rows.Item(0).Item("ret_bo_remarks")
                Case "purchase"
                    frm_transaction_items.lbl_trans_no.Text = data_table.Rows.Item(0).Item("trans_no")
                    frm_transaction_items.lbl_supplier_name.Text = data_table.Rows.Item(0).Item("supplier_name") 'customer name
                    frm_transaction_items.txt_ref_no.Text = data_table.Rows.Item(0).Item("ref_no") 'supp reference no
                    frm_transaction_items.dtp_date.Value = data_table.Rows.Item(0).Item("trans_date")
                Case "purchase return"
                    frm_transaction_items.lbl_trans_no.Text = data_table.Rows.Item(0).Item("trans_no")
                    frm_transaction_items.lbl_supplier_name.Text = data_table.Rows.Item(0).Item("supplier_name") 'customer name
                    frm_transaction_items.txt_ref_no.Text = data_table.Rows.Item(0).Item("ref_no") 'supp reference no
                    frm_transaction_items.dtp_date.Value = data_table.Rows.Item(0).Item("trans_date")
                Case "reject"
                    frm_transaction_items.lbl_trans_no.Text = data_table.Rows.Item(0).Item("trans_no")
                    frm_transaction_items.txt_remarks.Text = data_table.Rows.Item(0).Item("ret_bo_remarks")
                    frm_transaction_items.dtp_date.Value = data_table.Rows.Item(0).Item("trans_datetime")
                    frm_transaction_items.txt_ref_no.Text = data_table.Rows.Item(0).Item("customer_name") 'receipt no is on cust name
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GetItems(transType As String, selectedId As Integer)
        'fetch here
    End Sub


End Class
