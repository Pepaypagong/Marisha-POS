Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frm_salesrep

    Dim SQL As New SQLControl
    Dim sales_query As New sales_q

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub me_FormFormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frm_choose.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_close.Click
        Me.Close()
        frm_choose.Show()
    End Sub

    'NAVIGATION
    Private Sub cmd_dashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_dashboard.Click
        lbl_title.Text = "Sales Dashboard"
        pnl_dashboard.Show()
        pnl_sales_trans.Hide()
        pnl_gross_profit.Hide()
    End Sub

    Private Sub cmd_sales_trans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_sales_trans.Click
        If frm_choose.sales_report_remit = True Then
            lbl_title.Text = "Remittances Report"
            pnl_dashboard.Hide()
            pnl_sales_trans.Show()
            pnl_gross_profit.Hide()
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    Private Sub cmd_gross_profit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_gross_profict.Click
        If frm_choose.sales_report_incstate = True Then
            lbl_title.Text = "Income Statement"
            pnl_dashboard.Hide()
            pnl_sales_trans.Hide()
            pnl_gross_profit.Show()
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ss_time_and_date.Text = DateTime.Now.ToString("h:mm tt dddd, d MMMM yyyy")
    End Sub

    'loading'
    Private Sub frm_salesrep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'username position bottom'
        ss_user.Text = frm_choose.lbl_name.Text
        ss_position.Text = frm_choose.lbl_position.Text

        sales_query.show_categories_dash()
        Me.cbo_category.SelectedIndex = 0

        cmd_showgraph.PerformClick()
    End Sub

    'Dashboard'
    'Dim sqlProducts As String = "select item_no, item_name, Sum(qty_sold) as Total_sales " & _
    '    "from sales_item_table " & _
    '    "WHERE trans_date between '" & dtp_from.Value & "' and '" & dtp_to.Value & "' " & _
    '    "group by item_no, item_name "
    'DASHBOARD'
    Public ds As New DataSet()
    Public Sub fill_dashboard_dataset()
        Dim sqlProducts As String = "SELECT top 20 SUM(qty_sold) as qty, item_name from sales_item_table  WHERE trans_date between '" & dtp_from.Value.ToString("yyyy/MM/dd") & "' and '" & dtp_to.Value.ToString("yyyy/MM/dd") & "' AND cash_or_account <> 'System Gen' GROUP BY item_name ORDER BY qty DESC"
        Dim da As New SqlDataAdapter(sqlProducts, SQL.SQLCon)
        da.Fill(ds, "item_table")
    End Sub

    Public Chart1 = New Chart()

    Public Sub create_graph()
        Dim ChartArea1 As ChartArea = New ChartArea()
        Dim Legend1 As Legend = New Legend()
        Dim Series1 As Series = New Series()
        pnl_dashboard.Controls.Add(Chart1)

        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)

        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)

        Chart1.Location = New System.Drawing.Point(5, 50)
        Chart1.Name = "Chart1"

        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Chart1.Series.Add(Series1)

        Chart1.Size = New System.Drawing.Size(1282, 490)
        Chart1.TabIndex = 0
        Chart1.Text = "Chart1"

        Chart1.Series("Series1").XValueMember = "item_name"
        Chart1.Series("Series1").YValueMembers = "qty"

        Chart1.DataSource = ds.Tables("item_table")

        ' Specifying Chart Title
        Chart1.ChartAreas("ChartArea1").AxisX.Title = "Items"
        Chart1.ChartAreas("ChartArea1").AxisX.TitleFont = New Font("Tahoma", 14, FontStyle.Bold)

        Chart1.ChartAreas("ChartArea1").AxisY.Title = "Quantity"
        Chart1.ChartAreas("ChartArea1").AxisY.TitleFont = New Font("Tahoma", 14, FontStyle.Bold)

        'ilabas ang value'
        Chart1.Series("Series1").IsValueShownAsLabel = True

        'loob ng bar ang text'
        Chart1.Series("Series1").CustomProperties = "LabelStyle=Bottom"
        Chart1.Series("Series1").Font = New System.Drawing.Font("Tahoma", 9, System.Drawing.FontStyle.Bold)

        'font of yaxis labes'
        Chart1.ChartAreas(0).AxisY.LabelStyle.Font = New System.Drawing.Font("Tahoma", 9, System.Drawing.FontStyle.Bold)

        'font of xaxis labes'
        Chart1.ChartAreas(0).AxisX.LabelStyle.Font = New System.Drawing.Font("Tahoma", 9, System.Drawing.FontStyle.Bold)

        'rotate x axis labels'
        Chart1.ChartAreas(0).AxisX.LabelStyle.Angle = -90
        'Show tick marks every 1 datapoint
        Chart1.ChartAreas(0).AxisX.MajorTickMark.Interval = 1
        'Show labels every 1 datapoint.
        Chart1.ChartAreas(0).AxisX.Interval = 1
        Chart1.Legends(0).Enabled = False
    End Sub

    Private Sub cmd_showgraph_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_showgraph.Click
        Chart1.series.clear()
        Chart1.ChartAreas.clear()
        Chart1.Legends.clear()
        ds.Clear()
        fill_dashboard_dataset()
        create_graph()
    End Sub

    'DAILY REMITTANCES'

    Public Sub load_daily_remit()
        'FOR CRYSTAL REPORT'S

        Try
            Dim rpt As New cr_daily_remit 'The report you created.
            Dim myAdapter As SqlDataAdapter
            Dim myDataset As New ds_purchases() 'The DataSet you created.

            Dim query As String = "select trans_no, customer_name, " &
            "grand_total, ret_total_amount, " &
            "bo_total_amount, customer_partial_payment, (grand_total - ret_total_amount - bo_total_amount - customer_partial_payment) as outstanding_bal, trans_date " &
            "from sales_trans_table where trans_date = '" & dtp_remit.Value.ToString("yyyy/MM/dd") & "' " &
            "and trans_no > 0 "

            myAdapter = New SqlDataAdapter(query, SQL.SQLCon)
            myAdapter.Fill(myDataset, "sales_trans_table")
            rpt.SetDataSource(myDataset)
            crv_remit.ReportSource = rpt

        Catch ex As Exception
            MsgBox(ex.ToString & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub

    Private Sub cmd_print_remit_Click(sender As System.Object, e As System.EventArgs) Handles cmd_print_remit.Click
        crv_remit.PrintReport()
    End Sub

    Private Sub cmd_export_remit_Click(sender As System.Object, e As System.EventArgs) Handles cmd_export_remit.Click
        crv_remit.ExportReport()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        load_daily_remit()
    End Sub


    'INCOME STATEMENT'
    Public Sub load_income_statement()
        Try
            'FOR CRYSTAL REPORT'
            Dim rpt As New cr_income_statement 'The report you created.
            Dim myAdapter As SqlDataAdapter
            Dim myDataset As New ds_income_statement() 'The DataSet you created.

            myAdapter = New SqlDataAdapter("SELECT SUM(sub_total) AS Sales, " &
            "SUM(total_discount) AS SalesDiscount, " &
            "SUM(ret_total_amount) AS SalesRetrn, " &
            "SUM(bo_total_amount) AS BO FROM sales_trans_table " &
            "WHERE trans_date between '" & dtp_from_income.Value.ToString("yyyy/MM/dd") & "' AND '" & dtp_to_income.Value.ToString("yyyy/MM/dd") & "' ", SQL.SQLCon)
            myAdapter.Fill(myDataset, "sales_trans_table")

            myAdapter = New SqlDataAdapter("SELECT SUM(sub_total) AS Purchases, " &
            "SUM(total_return_price) AS PurchaseReturn, " &
            "SUM(total_discount) AS PurchaseDiscount FROM purchase_trans_table " &
            "WHERE trans_date between '" & dtp_from_income.Value.ToString("yyyy/MM/dd") & "' AND '" & dtp_to_income.Value.ToString("yyyy/MM/dd") & "' ", SQL.SQLCon)
            myAdapter.Fill(myDataset, "purchase_trans_table")

            myAdapter = New SqlDataAdapter("SELECT a.item_no, a.item_name, a.id, a.price_beg, a.trans_date " &
            "FROM begin_end_inv_table a " &
            "INNER JOIN ( " &
            "SELECT item_no, MAX(id) id " &
            "FROM begin_end_inv_table " &
            "WHERE trans_type <> 'SYSGEN' and trans_date = '" & dtp_from_income.Value.ToString("yyyy/MM/dd") & "' " &
            "GROUP BY item_no " &
            ") b ON a.item_no = b.item_no AND a.id = b.id", SQL.SQLCon)
            myAdapter.Fill(myDataset, "begin_end_inv_table")

            rpt.SetDataSource(myDataset)

            Dim beg_inv_amt As Decimal = sales_query.get_beginning_inventory_amount(dtp_from_income.Value.ToString("yyyy/MM/dd"))
            rpt.SetParameterValue("BeginningInventoryAmount", beg_inv_amt)

            Dim date_from As Date = dtp_from_income.Value
            rpt.SetParameterValue("from_pur", date_from)

            Dim date_to As Date = dtp_to.Value
            rpt.SetParameterValue("to_pur", date_to)

            crv_inc_statement.ReportSource = rpt

        Catch ex As Exception
            MsgBox(ex.ToString & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub

    Private Sub cmd_show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_show.Click
        Dim errMessage As String = sales_query.validate_income_statement(dtp_from.Value, dtp_to.Value)

        If errMessage = "" Then 
            load_income_statement()
        Else
            MsgBox(errMessage, MsgBoxStyle.Critical, " Invalid Action")
        End If

    End Sub

    Private Sub cmd_income_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_income_print.Click
        crv_inc_statement.PrintReport()
    End Sub

    Private Sub cmd_income_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_income_export.Click
        crv_inc_statement.ExportReport()
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DashboardToolStripMenuItem.Click
        cmd_dashboard.PerformClick()
    End Sub

    Private Sub IncomeStatementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncomeStatementToolStripMenuItem.Click
        If frm_choose.sales_report_remit = True Then
            cmd_sales_trans.PerformClick()
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    Private Sub IncomeStatementToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles IncomeStatementToolStripMenuItem1.Click
        If frm_choose.sales_report_incstate = True Then
            cmd_gross_profict.PerformClick()
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

End Class