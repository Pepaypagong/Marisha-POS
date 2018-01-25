Public Class frm_transactions

    Dim customers_query As New customers_q

    Private Sub frm_transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'format dgv'
        dtp_purchases_from.Format = DateTimePickerFormat.Custom
        dtp_purchases_from.CustomFormat = " MMMM dd,  yyyy"

        With cbo_sales_type.Items
            .Add("Cash Sales")
            .Add("On-Account Sales")
        End With
        cbo_sales_type.SelectedIndex = 0

    End Sub

    Public Sub fillCboCustomers()

        cbo_customer.Items.Clear()
        With cbo_customer.Items
            .Add("--None--")

            For Each row As DataRow In customers_query.GetCustomers.Rows
                .Add(row.Field(Of String)(0))
            Next

        End With
        cbo_customer.SelectedIndex = 0

    End Sub

    Private Sub cmd_sales_Click(sender As Object, e As EventArgs) Handles cmd_sales.Click
        lbl_title.Text = "Sales Transactions"
    End Sub
    Private Sub cmd_sales_return_Click(sender As Object, e As EventArgs) Handles cmd_sales_return.Click
        lbl_title.Text = "Sales Returns"
    End Sub
    Private Sub cmd_purchases_Click(sender As Object, e As EventArgs) Handles cmd_purchases.Click
        lbl_title.Text = "Purchases Transactions"
    End Sub
    Private Sub cmd_purchase_returns_Click(sender As Object, e As EventArgs) Handles cmd_purchase_returns.Click
        lbl_title.Text = "Purchase Returns"
    End Sub
    Private Sub cmd_rejects_Click(sender As Object, e As EventArgs) Handles cmd_rejects.Click
        lbl_title.Text = "Rejects"
    End Sub
    Private Sub cmd_close_Click(sender As Object, e As EventArgs) Handles cmd_close.Click
        Me.Close()
    End Sub

    'Sales
    Private Sub cbo_sales_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_sales_type.SelectedIndexChanged

        lbl_customer.Visible = IIf(cbo_sales_type.SelectedIndex = 0, false, true)
        cbo_customer.Visible = IIf(cbo_sales_type.SelectedIndex = 0, false, true)

        If cbo_sales_type.SelectedIndex = 1 Then
            fillCboCustomers()
        End If

    End Sub

End Class