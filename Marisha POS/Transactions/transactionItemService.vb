Public Class transactionItemService

    Dim SQL As New SQLControl

    'cash sales, customer sales, sales return, purchase, purchase return, reject
    Public Sub GetViewData(transType As String, selectedId As Integer)
        Try
            Dim params As New Dictionary(Of String, Object)
            params.Add("@id", selectedId)

            Dim query_string As String = ""

            Select Case transType
                Case "cash sales", "del cash sales"
                    query_string = "SELECT * FROM sales_trans_table WHERE trans_no = @id"
                Case "customer sales", "del customer sales"
                    query_string = "SELECT b.first_name + ' ' + b.last_name as customer, " &
                    "a.* FROM sales_trans_table a LEFT JOIN customers_table b " &
                    "ON a.customer_no = b.customer_no " &
                    "WHERE a.trans_no = @id"
                Case "sales return", "del sales return"
                    query_string = "SELECT * FROM sales_trans_table WHERE trans_no = @id"
                Case "purchase", "del purchase"
                    query_string = "SELECT b.supplier_name, " &
                    "a.* FROM purchase_trans_table a LEFT JOIN supplier_table b " &
                    "ON a.supplier_no = b.supplier_no " &
                    "WHERE a.trans_no = @id"
                Case "purchase return", "del purchase return"
                    query_string = "SELECT b.supplier_name, " &
                    "a.* FROM purchase_trans_table a LEFT JOIN supplier_table b " &
                    "ON a.supplier_no = b.supplier_no " &
                    "WHERE a.trans_no = @id"
                Case "reject", "del reject"
                    query_string = "SELECT * FROM sales_trans_table WHERE trans_no = @id"
            End Select

            Dim data_table As DataTable = SQL.GlobalFetch(query_string, params)

            Select Case transType

                Case "cash sales", "del cash sales"
                    frm_transaction_items.lbl_trans_no.Text = data_table.Rows.Item(0).Item("trans_no")
                    frm_transaction_items.dtp_date.Value = data_table.Rows.Item(0).Item("trans_datetime")
                Case "customer sales", "del customer sales"
                    frm_transaction_items.lbl_trans_no.Text = data_table.Rows.Item(0).Item("trans_no")
                    frm_transaction_items.lbl_supplier_name.Text = data_table.Rows.Item(0).Item("customer") 'customer name
                    frm_transaction_items.dtp_date.Value = data_table.Rows.Item(0).Item("trans_datetime")
                Case "sales return", "del sales return"
                    frm_transaction_items.lbl_trans_no.Text = data_table.Rows.Item(0).Item("trans_no")
                    frm_transaction_items.dtp_date.Value = data_table.Rows.Item(0).Item("trans_datetime")
                    frm_transaction_items.txt_ref_no.Text = data_table.Rows.Item(0).Item("customer_name") 'receipt no is on cust name
                    frm_transaction_items.txt_remarks.Text = data_table.Rows.Item(0).Item("ret_bo_remarks")
                Case "purchase", "del purchase"
                    frm_transaction_items.lbl_trans_no.Text = data_table.Rows.Item(0).Item("trans_no")
                    frm_transaction_items.lbl_supplier_name.Text = data_table.Rows.Item(0).Item("supplier_name") 'customer name
                    frm_transaction_items.txt_ref_no.Text = data_table.Rows.Item(0).Item("ref_no") 'supp reference no
                    frm_transaction_items.dtp_date.Value = data_table.Rows.Item(0).Item("trans_date")
                Case "purchase return", "del purchase return"
                    frm_transaction_items.lbl_trans_no.Text = data_table.Rows.Item(0).Item("trans_no")
                    frm_transaction_items.lbl_supplier_name.Text = data_table.Rows.Item(0).Item("supplier_name") 'customer name
                    frm_transaction_items.txt_ref_no.Text = data_table.Rows.Item(0).Item("ref_no") 'supp reference no
                    frm_transaction_items.dtp_date.Value = data_table.Rows.Item(0).Item("trans_date")
                Case "reject", "del reject"
                    frm_transaction_items.lbl_trans_no.Text = data_table.Rows.Item(0).Item("trans_no")
                    frm_transaction_items.txt_remarks.Text = data_table.Rows.Item(0).Item("ret_bo_remarks")
                    frm_transaction_items.dtp_date.Value = data_table.Rows.Item(0).Item("trans_datetime")
                    frm_transaction_items.txt_ref_no.Text = data_table.Rows.Item(0).Item("customer_name") 'receipt no is on cust name
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GetItems(transType As String, selectedId As Integer, dgv As DataGridView)
        Try
            Dim params As New Dictionary(Of String, Object)
            params.Add("@id", selectedId)

            Dim query_string As String = ""

            Select Case transType
                Case "cash sales", "del cash sales", "customer sales", "del customer sales", "sales return", "del sales return",
                     "reject", "del reject"
                    query_string = "SELECT b.barcode, b.item_name, " &
                    "a.* FROM sales_item_table a LEFT JOIN item_table b " &
                    "ON a.item_no = b.item_no " &
                    "WHERE a.trans_no = @id"

                Case "purchase", "del purchase", "purchase return", "del purchase return", "purchase return", "del purchase return"
                    query_string = "SELECT b.barcode, b.item_name, " &
                    "a.* FROM purchase_item_table a LEFT JOIN item_table b " &
                    "ON a.item_no = b.item_no " &
                    "WHERE a.trans_no = @id"
            End Select

            Dim data_table As DataTable = SQL.GlobalFetch(query_string, params)

            SetGrid(dgv, transType)
            dgv.DataSource = Nothing
            dgv.DataSource = data_table

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SetGrid(dgv As DataGridView, trans_type As String)

        dgv.AutoGenerateColumns = False

        dgv.Columns(0).DataPropertyName = "ID"               'id
        dgv.Columns(1).DataPropertyName = "barcode"          'barcode
        dgv.Columns(2).DataPropertyName = "item_name"        'item_desc

        Select Case trans_type
            Case "cash sales", "del cash sales", "customer sales", "del customer sales"
                dgv.Columns(3).DataPropertyName = "qty_sold"         'quantity
                dgv.Columns(4).DataPropertyName = "unit_of_measure"  'unit
                dgv.Columns(5).DataPropertyName = "price"            'selling price
                dgv.Columns(6).DataPropertyName = "discount_percent" 'discount amt
                dgv.Columns(7).DataPropertyName = "total_amount"     'sub_total         
            Case "sales return", "del sales return"
                dgv.Columns(6).Visible = False
                dgv.Columns(3).DataPropertyName = "ret_qty"         'quantity
                dgv.Columns(4).DataPropertyName = "unit_of_measure"  'unit
                dgv.Columns(5).DataPropertyName = "ret_selling_price" 'selling price
                dgv.Columns(6).DataPropertyName = "discount_percent" 'discount amt
                dgv.Columns(7).DataPropertyName = "ret_grand_total"   'sub_total      
            Case "purchase", "del purchase"
                dgv.Columns(3).DataPropertyName = "qty_purchased"         'quantity
                dgv.Columns(4).DataPropertyName = "unit_of_measure"       'unit
                dgv.Columns(5).DataPropertyName = "buying_price"            'buying price
                dgv.Columns(6).DataPropertyName = "discount"             'discount amt
                dgv.Columns(7).DataPropertyName = "total_after_discount"     'sub_total    
            Case "purchase return", "del purchase return"
                dgv.Columns(6).Visible = False
                dgv.Columns(3).DataPropertyName = "qty_returned"         'quantity
                dgv.Columns(4).DataPropertyName = "unit_of_measure"       'unit
                dgv.Columns(5).DataPropertyName = "return_buying_price"   'buying price
                dgv.Columns(6).DataPropertyName = "discount"             'discount amt
                dgv.Columns(7).DataPropertyName = "total_return_price"     'sub_total    
            Case "reject", "del reject"
                dgv.Columns(6).Visible = False
                dgv.Columns(3).DataPropertyName = "bo_qty"         'quantity
                dgv.Columns(4).DataPropertyName = "unit_of_measure"       'unit
                dgv.Columns(5).DataPropertyName = "bo_selling_price"   'buying price
                dgv.Columns(6).DataPropertyName = "discount"             'discount amt
                dgv.Columns(7).DataPropertyName = "bo_grand_total"     'sub_total   
        End Select
    End Sub

    Public Sub DeleteHeader(selectedId As Integer, transType As String)
        Dim selectedTable As String = ""
        Dim queryString As String = ""

        Try
            Dim params As New Dictionary(Of String, Object)
            params.Add("@id", selectedId)

            If transType = "del cash sales" Or
            transType = "del customer sales" Or
            transType = "del sales return" Or
            transType = "del reject" Then

                selectedTable = "sales_trans_table"

            ElseIf transType = "del purchase" Or transType = "del purchase return" Then

                selectedTable = "purchase_trans_table"

            End If

            queryString = "DELETE FROM " + selectedTable + " WHERE trans_no = @id"

            SQL.GlobalInsertUpdateDelete(queryString, params)

        Catch ex As Exception
            MsgBox(SQL.GlobalErrorMessage, MsgBoxStyle.Critical)
        End Try

    End Sub

    Public Sub DeleteItems(selectedId As Integer, transType As String)
        Dim selectedTable As String = ""
        Dim queryString As String = ""

        Try
            Dim params As New Dictionary(Of String, Object)
            params.Add("@id", selectedId)

            If transType = "del cash sales" Or
            transType = "del customer sales" Or
            transType = "del sales return" Or
            transType = "del reject" Then

                selectedTable = "sales_item_table"

            ElseIf transType = "del purchase" Or transType = "del purchase return" Then

                selectedTable = "purchase_item_table"

            End If

            queryString = "DELETE FROM " + selectedTable + " WHERE trans_no = @id"

            SQL.GlobalInsertUpdateDelete(queryString, params)

        Catch ex As Exception
            MsgBox(SQL.GlobalErrorMessage, MsgBoxStyle.Critical)
        End Try
    End Sub


    Public Function BarcodeFound(barcode As String) As Boolean
        Dim return_str As Boolean = False

        Dim params As New Dictionary(Of String, Object)
        params.Add("@barcode", barcode)

        Dim query_string As String = "SELECT * FROM item_table " &
                                  "WHERE barcode = @barcode"

        return_str = SQL.GlobalIsExisting(query_string, params)

        Return return_str
    End Function

    Public Sub PutItemToVariables(barcode)
        Dim params As New Dictionary(Of String, Object)
        params.Add("@barcode", barcode)

        Dim query_string As String = "SELECT * FROM item_table " &
                                  "WHERE barcode = @barcode"

        Dim data As DataTable = SQL.GlobalFetch(query_string, params)

        frm_transaction_items.m_item_no = data.Rows.Item(0).Item("item_no")
        frm_transaction_items.m_item_name = data.Rows.Item(0).Item("item_name")
        frm_transaction_items.m_barcode = data.Rows.Item(0).Item("barcode")
        frm_transaction_items.m_selling_price = data.Rows.Item(0).Item("selling_price")
        frm_transaction_items.m_buying_price = data.Rows.Item(0).Item("buying_price")
        frm_transaction_items.m_unit = data.Rows.Item(0).Item("unit_of_measure")
        frm_transaction_items.m_category = data.Rows.Item(0).Item("category")

    End Sub

    'add to cart
    Public Sub add_to_cart(transType As String, item_no As Integer, barcode As String, item_name As String, selling_price As Decimal,
                       quantity As Decimal, unit_of_measure As String, amount As Decimal, buying_price As Decimal,
                       discount As Decimal, category As String, dgv as Datagridview)

        Dim selected_price As Decimal = 0

        Select Case transType
            Case "new sales return", "new reject"
                selected_price = selling_price
            Case "new purchase","new purchase return"
                selected_price = buying_price
        End Select

        dgv.Rows.Add(New Object() _
                             {item_no, barcode, item_name, quantity, unit_of_measure, selected_price, discount, selected_price})
    End Sub

End Class
