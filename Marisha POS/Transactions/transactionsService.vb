Public Class transactionsService

    Dim SQL As New SQLControl

    Public Sub FillDgvSales(trans_type As String, date_from As Date, date_to As Date, id As Integer, dgv As DataGridView)

        dgv.DataSource = Nothing

        Try
            Dim params As New Dictionary(Of String, Object)
            params.Add("@date_from", date_from)
            params.Add("@date_to", date_to)
            params.Add("@id", id)

            Dim query_string As String = ""

            Select Case trans_type
                Case "cash sales"
                    query_string = "SELECT * FROM sales_trans_table " &
                    "WHERE cash_or_account = 'Cash' AND CONVERT(date,trans_datetime) BETWEEN @date_from AND @date_to " &
                    "ORDER BY trans_datetime DESC"
                Case "customer sales"
                    query_string = "SELECT * FROM sales_trans_table " &
                    "WHERE cash_or_account = 'Account' AND CONVERT(date,trans_datetime) BETWEEN @date_from AND @date_to "
                    query_string += IIf(id = 0, "AND 1 = 1", "AND customer_no = @id")
                    query_string += " ORDER BY trans_datetime DESC"
                Case "sales return"
                    query_string = "SELECT * FROM sales_trans_table " &
                     "WHERE cash_or_account = 'Return' AND CONVERT(date,trans_datetime) BETWEEN @date_from AND @date_to " &
                     "ORDER BY trans_datetime DESC"
                Case "purchase"
                    query_string = "SELECT * FROM purchase_trans_table " &
                   "WHERE purchase_or_returns = 'Purchase' AND trans_date BETWEEN @date_from AND @date_to "
                    query_string += IIf(id = 0, "AND 1 = 1", "AND supplier_no = @id")
                    query_string += " ORDER BY trans_date DESC"
                Case "purchase return"
                    query_string = "SELECT * FROM purchase_trans_table " &
                   "WHERE purchase_or_returns = 'Returns' AND trans_date BETWEEN @date_from AND @date_to "
                    query_string += IIf(id = 0, "AND 1 = 1", "AND supplier_no = @id")
                    query_string += " ORDER BY trans_date DESC"
                Case "reject"
                    query_string = "SELECT * FROM sales_trans_table " &
                    "WHERE cash_or_account = 'BO' AND CONVERT(date,trans_datetime) BETWEEN @date_from AND @date_to " &
                    "ORDER BY trans_datetime DESC"
            End Select

            Dim data_table As DataTable = SQL.GlobalFetch(query_string, params)

            generate_grid_columns(dgv, trans_type)

            dgv.DataSource = data_table
            

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub generate_grid_columns(dgv As DataGridView, trans_type As String)

        dgv.Columns.Clear
        dgv.AutoGenerateColumns = False
        'destroyDatagridview(frm_transactions)
        'dgv = newDgv 'create new datagridview

        Select Case trans_type

            Case "cash sales"

                dgv.ColumnCount = 7

                'Column Header label
                dgv.Columns(0).Name = "Date and Time"
                dgv.Columns(1).Name = "Sales No."
                dgv.Columns(2).Name = "Sub Total"
                dgv.Columns(3).Name = "Total Discount"
                dgv.Columns(4).Name = "Grand Total"
                dgv.Columns(5).Name = "Cash Tendered"
                dgv.Columns(6).Name = "Change"

                'Width
                dgv.Columns(0).Width = 220
                dgv.Columns(1).Width = 100
                dgv.Columns(2).Width = 150
                dgv.Columns(3).Width = 150
                dgv.Columns(4).Width = 150
                dgv.Columns(5).Width = 150
                dgv.Columns(6).Width = 150

                'Formatting
                dgv.Columns(0).DefaultCellStyle.Format = " ddd - MMM d, yyyy - hh:mm tt"

                'Data
                dgv.Columns(0).DataPropertyName = "trans_datetime"
                dgv.Columns(1).DataPropertyName = "trans_no"
                dgv.Columns(2).DataPropertyName = "sub_total"
                dgv.Columns(3).DataPropertyName = "total_discount"
                dgv.Columns(4).DataPropertyName = "grand_total"
                dgv.Columns(5).DataPropertyName = "cash_tendered"
                dgv.Columns(6).DataPropertyName = "change"

                'Alignment
                dgv.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable

                dgv.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable

                dgv.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable

                dgv.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable

                dgv.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable

            Case "customer sales"

                dgv.ColumnCount = 7

                'Column Header label
                dgv.Columns(0).Name = "Date and Time"
                dgv.Columns(1).Name = "Sales No."
                dgv.Columns(2).Name = "Customer Name"
                dgv.Columns(3).Name = "Sub Total"
                dgv.Columns(4).Name = "Total Discount"
                dgv.Columns(5).Name = "Grand Total"
                dgv.Columns(6).Name = "Partial Payment"

                'Width
                dgv.Columns(0).Width = 220
                dgv.Columns(1).Width = 100
                dgv.Columns(2).Width = 250
                dgv.Columns(3).Width = 150
                dgv.Columns(4).Width = 150
                dgv.Columns(5).Width = 150
                dgv.Columns(6).Width = 150

                'Formatting
                dgv.Columns(0).DefaultCellStyle.Format = " ddd - MMM d, yyyy - hh:mm tt"

                'Data
                dgv.Columns(0).DataPropertyName = "trans_datetime"
                dgv.Columns(1).DataPropertyName = "trans_no"
                dgv.Columns(2).DataPropertyName = "customer_name"
                dgv.Columns(3).DataPropertyName = "sub_total"
                dgv.Columns(4).DataPropertyName = "total_discount"
                dgv.Columns(5).DataPropertyName = "grand_total"
                dgv.Columns(6).DataPropertyName = "customer_partial_payment"

                'Alignment
                dgv.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable

                dgv.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable

                dgv.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable

                dgv.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable

            Case "sales return"

                dgv.ColumnCount = 5

                'Column Header label
                dgv.Columns(0).Name = "Date and Time"
                dgv.Columns(1).Name = "Sales Return No."
                dgv.Columns(2).Name = "Receipt No."
                dgv.Columns(3).Name = "Total Amount"
                dgv.Columns(4).Name = "Remarks"

                'Width
                dgv.Columns(0).Width = 220
                dgv.Columns(1).Width = 150
                dgv.Columns(2).Width = 100
                dgv.Columns(3).Width = 150
                dgv.Columns(4).Width = 500

                'Formatting
                dgv.Columns(0).DefaultCellStyle.Format = " ddd - MMM d, yyyy - hh:mm tt"

                'Data
                dgv.Columns(0).DataPropertyName = "trans_datetime"
                dgv.Columns(1).DataPropertyName = "trans_no"
                dgv.Columns(2).DataPropertyName = "ret_bo_receipt_no"
                dgv.Columns(3).DataPropertyName = "ret_total_amount"
                dgv.Columns(4).DataPropertyName = "ret_bo_remarks"

                'Alignment
                dgv.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable

            Case "purchase"

                dgv.ColumnCount = 7

                'Column Header label
                dgv.Columns(0).Name = "Date"
                dgv.Columns(1).Name = "Purchase No."
                dgv.Columns(2).Name = "Reference No."
                dgv.Columns(3).Name = "Supplier Name"
                dgv.Columns(4).Name = "Sub Total"
                dgv.Columns(5).Name = "Total Discount"
                dgv.Columns(6).Name = "Grand Total"


                'Width
                dgv.Columns(0).Width = 220
                dgv.Columns(1).Width = 100
                dgv.Columns(2).Width = 100
                dgv.Columns(3).Width = 200
                dgv.Columns(4).Width = 150
                dgv.Columns(5).Width = 150
                dgv.Columns(6).Width = 150

                'Formatting
                dgv.Columns(0).DefaultCellStyle.Format = " ddd - MMM d, yyyy - hh:mm tt"

                'Data
                dgv.Columns(0).DataPropertyName = "trans_date"
                dgv.Columns(1).DataPropertyName = "trans_no"
                dgv.Columns(2).DataPropertyName = "ref_no"
                dgv.Columns(3).DataPropertyName = "supplier_name"
                dgv.Columns(4).DataPropertyName = "sub_total"
                dgv.Columns(5).DataPropertyName = "total_discount"
                dgv.Columns(6).DataPropertyName = "grand_total"

                'Alignment
                dgv.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable

                dgv.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable

                dgv.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable

            Case "purchase return"

                dgv.ColumnCount = 5

                'Column Header label
                dgv.Columns(0).Name = "Date"
                dgv.Columns(1).Name = "Purchase Return No."
                dgv.Columns(2).Name = "Reference No."
                dgv.Columns(3).Name = "Supplier Name"
                dgv.Columns(4).Name = "Total Amount"

                'Width
                dgv.Columns(0).Width = 220
                dgv.Columns(1).Width = 150
                dgv.Columns(2).Width = 100
                dgv.Columns(3).Width = 200
                dgv.Columns(4).Width = 150

                'Formatting
                dgv.Columns(0).DefaultCellStyle.Format = " ddd - MMM d, yyyy - hh:mm tt"

                'Data
                dgv.Columns(0).DataPropertyName = "trans_date"
                dgv.Columns(1).DataPropertyName = "trans_no"
                dgv.Columns(2).DataPropertyName = "ref_no"
                dgv.Columns(3).DataPropertyName = "supplier_name"
                dgv.Columns(4).DataPropertyName = "total_return_price"

                'Alignment
                dgv.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable

            Case "reject"

                dgv.ColumnCount = 5

                'Column Header label
                dgv.Columns(0).Name = "Date and Time"
                dgv.Columns(1).Name = "Reject No."
                dgv.Columns(2).Name = "Receipt No."
                dgv.Columns(3).Name = "Total Amount"
                dgv.Columns(4).Name = "Remarks"

                'Width
                dgv.Columns(0).Width = 220
                dgv.Columns(1).Width = 100
                dgv.Columns(2).Width = 100
                dgv.Columns(3).Width = 200
                dgv.Columns(4).Width = 150

                'Formatting
                dgv.Columns(0).DefaultCellStyle.Format = " ddd - MMM d, yyyy - hh:mm tt"

                'Data
                dgv.Columns(0).DataPropertyName = "trans_datetime"
                dgv.Columns(1).DataPropertyName = "trans_no"
                dgv.Columns(2).DataPropertyName = "ret_bo_receipt_no"
                dgv.Columns(3).DataPropertyName = "bo_total_amount"
                dgv.Columns(4).DataPropertyName = "ret_bo_remarks"

                'Alignment
                dgv.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable

        End Select

        'dgv.DataSource = data

    End Sub

    Private Sub destroyDatagridview(myForm As Form)
        For i As Integer = myForm.Controls.Count - 1 To 0 Step -1
            If TypeOf myForm.Controls(i) Is DataGridView Then
                myForm.Controls.RemoveAt(i)
            End If
        Next
    End Sub

    Function newDgv As DataGridView

        Dim return_dgv As New DataGridView

        With return_dgv
            .Name = "dgv_transactions"
            .Size = New Size(1270, 473)
            .Location = New Point(12, 209)

            'func
            .AutoGenerateColumns = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .MultiSelect = False
            .ReadOnly = True
            .RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            With .RowsDefaultCellStyle
                .Font = New System.Drawing.Font("Tahoma", 8.25, FontStyle.Bold)
            End With

            'design
            .BackgroundColor = Color.WhiteSmoke
            .GridColor = Color.DarkGray
            .BorderStyle = BorderStyle.Fixed3D
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            With .ColumnHeadersDefaultCellStyle
                .BackColor = Color.DarkSlateGray
                .ForeColor = Color.White
                .Font = New System.Drawing.Font("Tahoma", 8.25, FontStyle.Bold)
                .Alignment = DataGridViewContentAlignment.MiddleLeft
                .WrapMode = False
            End With
            .ColumnHeadersHeight = 25
            .Cursor = Cursors.Hand
            With .DefaultCellStyle
                .BackColor = Color.White
                .ForeColor = Color.Black
                .SelectionBackColor = Color.DarkSlateGray
                .SelectionForeColor = Color.White
                .Font = New System.Drawing.Font("Tahoma", 8.25, FontStyle.Bold)
                .Alignment = DataGridViewContentAlignment.MiddleLeft
                .WrapMode = False
            End With
            .EnableHeadersVisualStyles = False
        End With

        AddHandler return_dgv.CellContentClick, AddressOf frm_transactions.dgv_transactions_CellContentClick
        frm_transactions.Controls.Add(return_dgv)

        Return return_dgv
    End Function



End Class
