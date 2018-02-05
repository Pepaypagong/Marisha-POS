Public Class frm_transactions

    Dim customers_query As New customers_q
    Dim suppliers_query As New suppliers_q
    Dim transService As New transactionsService

    Public trans_type As String = "cash sales"

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frm_transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
        'format dgv'
        dtp_purchases_from.Format = DateTimePickerFormat.Custom
        dtp_purchases_from.CustomFormat = " MMMM dd,  yyyy"
        dtp_purchases_to.Format = DateTimePickerFormat.Custom
        dtp_purchases_to.CustomFormat = " MMMM dd,  yyyy"

        reset_cbo_and_dtp()

        With cbo_sales_type.Items
            .Add("Cash Sales")
            .Add("On-Account Sales")
        End With
        cbo_sales_type.SelectedIndex = 0

        fillIdDropDown()

    End Sub

    Public Sub reset_cbo_and_dtp()
        dtp_purchases_to.Value = DateTime.Now()
        dtp_purchases_from.Value = DateTime.Now.AddMonths(-1)

        cbo_id.DataSource = Nothing
    End Sub

    Public Sub fillIdDropDown()

        cbo_id.DataSource = Nothing

        Dim valueAndKey As New Dictionary(Of Integer, String)
        Dim dtRow As New Datatable

        With valueAndKey

            If trans_type = "customer sales" Then
                .Add(0,"-- All Customers --")
                dtRow = customers_query.GetCustomers
            Else 'if trans_type = "purchase" Or trans_type = "purchase return"
                .Add(0,"-- All Suppliers --")
                dtRow = suppliers_query.GetSuppliers
            End If

            For Each row As DataRow In dtRow.Rows
                .Add(row.Field(Of Integer)(0),row.Field(Of String)(1))
            Next

        End With

        cbo_id.DataSource = New BindingSource(valueAndKey, vbNullString)
        cbo_id.DisplayMember = "Value"
        cbo_id.ValueMember = "Key"

    End Sub

    Private Sub cmd_sales_Click(sender As Object, e As EventArgs) Handles cmd_sales.Click
        lbl_title.Text = "Sales Transactions"
        trans_type = "cash sales"
        cbo_sales_type.SelectedIndex = 0
        reset_cbo_and_dtp()
        reposition_filter_controls()
        fillIdDropDown()
    End Sub
    Private Sub cmd_sales_return_Click(sender As Object, e As EventArgs) Handles cmd_sales_return.Click
        lbl_title.Text = "Sales Returns"
        trans_type = "sales return"
        reset_cbo_and_dtp()
        reposition_filter_controls()
        fillIdDropDown()
    End Sub
    Private Sub cmd_purchases_Click(sender As Object, e As EventArgs) Handles cmd_purchases.Click
        lbl_title.Text = "Purchase Transactions"
        trans_type = "purchase"
        reset_cbo_and_dtp()
        reposition_filter_controls()
        fillIdDropDown()
    End Sub
    Private Sub cmd_purchase_returns_Click(sender As Object, e As EventArgs) Handles cmd_purchase_returns.Click
        lbl_title.Text = "Purchase Returns"
        trans_type = "purchase return"
        reset_cbo_and_dtp()
        reposition_filter_controls()
        fillIdDropDown()
    End Sub
    Private Sub cmd_rejects_Click(sender As Object, e As EventArgs) Handles cmd_rejects.Click
        lbl_title.Text = "Rejects"
        trans_type = "reject"
        reset_cbo_and_dtp()
        reposition_filter_controls()
        fillIdDropDown()
    End Sub
    Private Sub cmd_close_Click(sender As Object, e As EventArgs) Handles cmd_close.Click
        Me.Close()
    End Sub

    Private Sub cbo_sales_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_sales_type.SelectedIndexChanged
        trans_type = IIf(cbo_sales_type.SelectedIndex = 0, "cash sales", "customer sales")
        reposition_filter_controls()
        If cbo_sales_type.SelectedIndex = 1 Then
            fillIdDropDown()
        End If

        transService.FillDgvSales(trans_type, dtp_purchases_from.Value.ToString("yyyy/MM/dd"),
                          dtp_purchases_to.Value.ToString("yyyy/MM/dd"),
                          (CType(cbo_id.SelectedItem, KeyValuePair(Of Integer, String))).Key, dgv_transactions)
    End Sub

    Private Sub cbo_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_id.SelectedIndexChanged
        transService.FillDgvSales(trans_type, dtp_purchases_from.Value.ToString("yyyy/MM/dd"),
                          dtp_purchases_to.Value.ToString("yyyy/MM/dd"),
                          (CType(cbo_id.SelectedItem, KeyValuePair(Of Integer, String))).Key, dgv_transactions)
    End Sub

    Private Sub dtp_purchases_from_ValueChanged(sender As Object, e As EventArgs) Handles dtp_purchases_from.ValueChanged
        transService.FillDgvSales(trans_type, dtp_purchases_from.Value.ToString("yyyy/MM/dd"),
                          dtp_purchases_to.Value.ToString("yyyy/MM/dd"),
                          (CType(cbo_id.SelectedItem, KeyValuePair(Of Integer, String))).Key, dgv_transactions)
    End Sub

    Private Sub dtp_purchases_to_ValueChanged(sender As Object, e As EventArgs) Handles dtp_purchases_to.ValueChanged
        transService.FillDgvSales(trans_type, dtp_purchases_from.Value.ToString("yyyy/MM/dd"),
                          dtp_purchases_to.Value.ToString("yyyy/MM/dd"),
                          (CType(cbo_id.SelectedItem, KeyValuePair(Of Integer, String))).Key, dgv_transactions)

    End Sub

    'SHORCUT KEYS'
    Private Sub shortcut_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            cmd_close.PerformClick()
        End If
    End Sub

    Public Sub reposition_filter_controls()
        Select Case trans_type
            Case "cash sales"
                With lbl_sales_type
                    .Visible = True
                    .Location = New Point(17, 149)
                End With
                With cbo_sales_type
                    .Visible = True
                    .Location = New Point(109, 146)
                End With

                With lbl_customer
                    .Text = "Customer:"
                    .Visible = False
                    .Location = New Point(24, 179)
                End With
                With cbo_id
                    .Visible = False
                    .Location = New Point(109, 176)
                End With

                With lbl_date_from
                    .Visible = True
                    .Location = New Point(420, 149)
                End With
                With dtp_purchases_from
                    .Visible = True
                    .Location = New Point(570, 146)
                End With

                With lbl_date_to
                    .Visible = True
                    .Location = New Point(532, 179)
                End With
                With dtp_purchases_to
                    .Visible = True
                    .Location = New Point(571, 174)
                End With

                cmd_new.Visible = False

            Case "customer sales"
                With lbl_sales_type
                    .Visible = True
                    .Location = New Point(17, 149)
                End With
                With cbo_sales_type
                    .Visible = True
                    .Location = New Point(109, 146)
                End With

                With lbl_customer
                    .Text = "Customer:"
                    .Visible = True
                    .Location = New Point(24, 179)
                End With
                With cbo_id
                    .Visible = True
                    .Location = New Point(109, 176)
                End With

                With lbl_date_from
                    .Visible = True
                    .Location = New Point(420, 149)
                End With
                With dtp_purchases_from
                    .Visible = True
                    .Location = New Point(570, 146)
                End With

                With lbl_date_to
                    .Visible = True
                    .Location = New Point(532, 179)
                End With
                With dtp_purchases_to
                    .Visible = True
                    .Location = New Point(571, 174)
                End With

                cmd_new.Visible = False

            Case "sales return"
                With lbl_sales_type
                    .Visible = False
                    .Location = New Point(17, 149)
                End With
                With cbo_sales_type
                    .Visible = False
                    .Location = New Point(109, 146)
                End With

                With lbl_customer
                    .Text = "Customer:"
                    .Visible = False
                    .Location = New Point(24, 179)
                End With
                With cbo_id
                    .Visible = False
                    .Location = New Point(109, 176)
                End With

                With lbl_date_from
                    .Visible = True
                    .Location = New Point(16, 149S)
                End With
                With dtp_purchases_from
                    .Visible = True
                    .Location = New Point(166, 146)
                End With

                With lbl_date_to
                    .Visible = True
                    .Location = New Point(128, 179)
                End With
                With dtp_purchases_to
                    .Visible = True
                    .Location = New Point(167, 174)
                End With

                cmd_new.Visible = True

            Case "purchase"
                With lbl_sales_type
                    .Visible = False
                    .Location = New Point(17, 149)
                End With
                With cbo_sales_type
                    .Visible = False
                    .Location = New Point(109, 146)
                End With

                With lbl_customer
                    .Text = " Supplier:"
                    .Visible = True
                    .Location = New Point(17, 149)
                End With
                With cbo_id
                    .Visible = True
                    .Location = New Point(109, 146)
                End With

                With lbl_date_from
                    .Visible = True
                    .Location = New Point(420, 149)
                End With
                With dtp_purchases_from
                    .Visible = True
                    .Location = New Point(570, 146)
                End With

                With lbl_date_to
                    .Visible = True
                    .Location = New Point(532, 179)
                End With
                With dtp_purchases_to
                    .Visible = True
                    .Location = New Point(571, 174)
                End With

                cmd_new.Visible = True

            Case "purchase return"
                With lbl_sales_type
                    .Visible = False
                    .Location = New Point(17, 149)
                End With
                With cbo_sales_type
                    .Visible = False
                    .Location = New Point(109, 146)
                End With

                With lbl_customer
                    .Text = " Supplier:"
                    .Visible = True
                    .Location = New Point(17, 149)
                End With
                With cbo_id
                    .Visible = True
                    .Location = New Point(109, 146)
                End With

                With lbl_date_from
                    .Visible = True
                    .Location = New Point(420, 149)
                End With
                With dtp_purchases_from
                    .Visible = True
                    .Location = New Point(570, 146)
                End With

                With lbl_date_to
                    .Visible = True
                    .Location = New Point(532, 179)
                End With
                With dtp_purchases_to
                    .Visible = True
                    .Location = New Point(571, 174)
                End With

                cmd_new.Visible = True

            Case "reject"
                With lbl_sales_type
                    .Visible = False
                    .Location = New Point(17, 149)
                End With
                With cbo_sales_type
                    .Visible = False
                    .Location = New Point(109, 146)
                End With

                With lbl_customer
                    .Text = "Customer:"
                    .Visible = False
                    .Location = New Point(24, 179)
                End With
                With cbo_id
                    .Visible = False
                    .Location = New Point(109, 176)
                End With

                With lbl_date_from
                    .Visible = True
                    .Location = New Point(16, 149S)
                End With
                With dtp_purchases_from
                    .Visible = True
                    .Location = New Point(166, 146)
                End With

                With lbl_date_to
                    .Visible = True
                    .Location = New Point(128, 179)
                End With
                With dtp_purchases_to
                    .Visible = True
                    .Location = New Point(167, 174)
                End With

                cmd_new.Visible = True
        End Select
    End Sub

    Public Sub dgv_transactions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        MessageBox.Show("Working " + dgv_transactions.Name)

    End Sub

    Private Sub cmd_new_Click(sender As Object, e As EventArgs) Handles cmd_new.Click

    End Sub

    Private Sub cmd_view_Click(sender As Object, e As EventArgs) Handles cmd_view.Click
        dgv_transactions.Columns.Clear()
    End Sub

    Private Sub cmd_delete_Click(sender As Object, e As EventArgs) Handles cmd_delete.Click

    End Sub
End Class