Imports System.Data
Imports System.Data.SqlClient
Imports System.Threading

Public Class frm_account_receivables

    Dim SQL As New SQLControl

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    'Item Sales'
    'sales - STOCK out'
    Public Sub load_report()
        'FOR CRYSTAL REPORT'S
        Try
            Dim rpt As New cr_ar_payments  'The report you created.
            Dim myAdapter As SqlDataAdapter
            Dim myDataset As New ds_ar_payments() 'The DataSet you created.

            Dim query As String = "SELECT customer_payments_table.ID, customer_payments_table.customer_no, " & _
            "customers_table.first_name + ' ' + customers_table.last_name as Fullname, customer_payments_table.amount_paid, customer_payments_table.date_pay " & _
            "FROM customer_payments_table INNER JOIN customers_table ON customer_payments_table.customer_no = customers_table.customer_no " & _
            "WHERE customer_payments_table.date_pay = '" & dtp_from.Value.ToString("yyyy/MM/dd") & "' AND customer_payments_table.amount_paid > '0' "

            myAdapter = New SqlDataAdapter(query, SQL.SQLCon)
            myAdapter.Fill(myDataset, "customer_payments_table")
            rpt.SetDataSource(myDataset)
            crv_acct_receive.ReportSource = rpt

        Catch ex As Exception
            MsgBox(ex.ToString & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub

    Private Sub cmd_show_sales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_show.Click
        load_report()
    End Sub

    Private Sub cmd_sales_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_print.Click
        crv_acct_receive.PrintReport()
    End Sub

    Private Sub cmd_sales_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_export.Click
        crv_acct_receive.ExportReport()
    End Sub

    Private Sub frm_account_receivables_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class