Imports System.Data
Imports System.Data.SqlClient
Imports System.Threading

Public Class frm_customer_balances

    Dim SQL As New SQLControl

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Public Sub load_report()
        Try
            'FOR CRYSTAL REPORT'S
            Dim rpt As New cr_customer_balances  'The report you created.
            Dim myAdapter As SqlDataAdapter
            Dim myDataset As New ds_customer_balance 'The DataSet you created.

            Dim query As String = "SELECT a.[customer_no], a.[customer_name]," & _
            "(SELECT SUM(a1.grand_total) - SUM(a1.customer_partial_payment) FROM sales_trans_table AS a1 WHERE a1.customer_no = a.customer_no and a1.trans_date between '" & dtp_from.Value.ToString("yyyy/MM/dd") & "' and '" & dtp_to.Value.ToString("yyyy/MM/dd") & "') " & _
            "- (SELECT SUM(b2.amount_paid) FROM customer_payments_table AS b2 WHERE b2.customer_no = a.customer_no and b2.date_pay between '" & dtp_from.Value.ToString("yyyy/MM/dd") & "' and '" & dtp_to.Value.ToString("yyyy/MM/dd") & "') as Remaining_Bal " & _
            "FROM sales_trans_table AS a INNER JOIN customer_payments_table AS b " & _
            "ON (a.[customer_no] = b.[customer_no]) " & _
            "WHERE a.cash_or_account = 'Account' and a.trans_date between '" & dtp_from.Value.ToString("yyyy/MM/dd") & "' and '" & dtp_to.Value.ToString("yyyy/MM/dd") & "' and b.date_pay between '" & dtp_from.Value.ToString("yyyy/MM/dd") & "' and '" & dtp_to.Value.ToString("yyyy/MM/dd") & "' " & _
            "GROUP BY a.[customer_no],a.[customer_name]"

            myAdapter = New SqlDataAdapter(query, SQL.SQLCon)
            myAdapter.Fill(myDataset, "sales_trans_table")
            rpt.SetDataSource(myDataset)

            Dim date_from As Date = dtp_from.Value
            rpt.SetParameterValue("from_pur", date_from)

            Dim date_to As Date = dtp_to.Value
            rpt.SetParameterValue("to_pur", date_to)

            crv_customer_balance.ReportSource = rpt

        Catch ex As Exception
            MsgBox(ex.ToString & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub

    Private Sub cmd_showdata_itemsales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_show.Click
        load_report()
    End Sub

    Private Sub cmd_sales_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_print.Click
        crv_customer_balance.PrintReport()
    End Sub

    Private Sub cmd_sales_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_export.Click
        crv_customer_balance.ExportReport()
    End Sub

    Private Sub frm_customer_balances_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class