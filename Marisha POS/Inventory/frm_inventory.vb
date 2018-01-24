Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frm_inventory

    Dim SQL As New SQLControl

    Dim inventory_query As New inventory_q

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

    'NAVIGATION'
    Private Sub cmd_dashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_dashboard.Click
        lbl_title.Text = "Dashboard"
        pnl_dashboard.Show()
        pnl_items.Hide()
        pnl_category.Hide()
        pnl_stock_in.Hide()
        pnl_stock_out.Hide()
    End Sub

    Private Sub cmd_itemlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_itemlist.Click
        lbl_title.Text = "Item List"
        pnl_dashboard.Hide()
        pnl_items.Show()
        pnl_category.Hide()
        pnl_stock_in.Hide()
        pnl_stock_out.Hide()
    End Sub

    Private Sub cmd_stock_in_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_stock_in.Click
        If frm_choose.inv_report_pur = True Then
            lbl_title.Text = "Purchases Report"
            pnl_dashboard.Hide()
            pnl_items.Hide()
            pnl_category.Hide()
            pnl_stock_in.Show()
            pnl_stock_out.Hide()
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    Private Sub cmd_stock_out_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_stock_out.Click
        If frm_choose.inv_report_sales = True Then
            lbl_title.Text = "Item Sales Report"
            pnl_dashboard.Hide()
            pnl_items.Hide()
            pnl_category.Hide()
            pnl_stock_in.Hide()
            pnl_stock_out.Show()
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    'menu strip'
    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click
        If frm_choose.inv_add_stocks = True Then
            cmd_itemlist.PerformClick()
            Me.cmd_addstocks.PerformClick()
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    Private Sub CategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryToolStripMenuItem.Click
        If frm_choose.inv_category = True Then
            frm_category.ShowDialog()
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    Private Sub BrandsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrandsToolStripMenuItem.Click
        If frm_choose.inv_brands = True Then
            frm_brandss.ShowDialog()
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ss_time_and_date.Text = DateTime.Now.ToString("h:mm tt dddd, d MMMM yyyy")
    End Sub
    Private Sub frm_inventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'username position bottom'
        ss_user.Text = frm_choose.lbl_name.Text
        ss_position.Text = frm_choose.lbl_position.Text
        'DASHBOARD'
        inventory_query.show_categories_dash()
        Me.cbo_category.SelectedIndex = 0

        'ITEMS'
        inventory_query.load_item()
        With cbo_search_by
            .Items.Add("Item Number")
            .Items.Add("Barcode")
            .Items.Add("Item Name")
            .Items.Add("Description")
            .Items.Add("Category")
            .Items.Add("Brand")
        End With
        cbo_search_by.SelectedIndex = 1
    End Sub

    'DASHBOARD'
    Public ds As New DataSet()
    Public Sub fill_dashboard_dataset()
        Dim sqlProducts As String = "SELECT item_name, stock_qty from item_table WHERE category = '" & Me.cbo_category.Text & "' ORDER BY item_name ASC"
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
        Chart1.Series("Series1").YValueMembers = "stock_qty"

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

    Private Sub cbo_category_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_category.SelectedIndexChanged
        Chart1.series.clear()
        Chart1.ChartAreas.clear()
        Chart1.Legends.clear()
        ds.Clear()
        fill_dashboard_dataset()
        create_graph()
    End Sub

    'ITEM LIST'
    Public adding As Boolean
    Public updating As Boolean

    Public m_item_no As String
    Public m_barcode As String
    Public m_item_name As String
    Public m_selling_price As String
    Public m_buying_price As String
    Public m_avail As String
    Public m_stock_qty As String
    Public m_unit As String
    Public m_desc As String
    Public m_category As String
    Public m_brand As String

    'SEARCH
    Public search_field As String
    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged
        If Me.cbo_search_by.SelectedIndex = 0 Then
            search_field = "item_no"
        ElseIf Me.cbo_search_by.SelectedIndex = 1 Then
            search_field = "barcode"
        ElseIf Me.cbo_search_by.SelectedIndex = 2 Then
            search_field = "item_name"
        ElseIf Me.cbo_search_by.SelectedIndex = 3 Then
            search_field = "description"
        ElseIf Me.cbo_search_by.SelectedIndex = 4 Then
            search_field = "category"
        ElseIf Me.cbo_search_by.SelectedIndex = 5 Then
            search_field = "brand"
        End If
        inventory_query.load_search_item()
    End Sub
    Private Sub cmd_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_clear.Click
        txt_search.Clear()
    End Sub

    Private Sub dgv_items_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_items.CellClick
        If dgv_items.Rows.Count > 0 Then
            m_item_no = dgv_items.Item("item_no", dgv_items.CurrentRow.Index).Value.ToString()
            m_barcode = dgv_items.Item("barcode", dgv_items.CurrentRow.Index).Value.ToString()
            m_item_name = dgv_items.Item("item_name", dgv_items.CurrentRow.Index).Value.ToString()
            m_selling_price = dgv_items.Item("selling_price", dgv_items.CurrentRow.Index).Value.ToString()
            m_buying_price = dgv_items.Item("buying_price", dgv_items.CurrentRow.Index).Value.ToString()
            m_avail = dgv_items.Item("avail", dgv_items.CurrentRow.Index).Value.ToString()
            m_stock_qty = dgv_items.Item("stock_qty", dgv_items.CurrentRow.Index).Value.ToString()
            m_unit = dgv_items.Item("unit", dgv_items.CurrentRow.Index).Value.ToString()
            m_desc = dgv_items.Item("description", dgv_items.CurrentRow.Index).Value.ToString()
            m_category = dgv_items.Item("category", dgv_items.CurrentRow.Index).Value.ToString()
            m_brand = dgv_items.Item("brand", dgv_items.CurrentRow.Index).Value.ToString()
        End If
    End Sub

    Private Sub cmd_additem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_additem.Click
        If frm_choose.inv_add_item = True Then
            adding = True
            updating = False
            frm_stock_add_update.lblTitle.Text = "Add a New Item"
            frm_stock_add_update.ShowDialog()
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    Private Sub cmd_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_update.Click
        If frm_choose.inv_updt_item = True Then
            If m_item_no = "" Then
                MsgBox(" Please Select a Record to Update", MsgBoxStyle.Exclamation, " Invalid")
            Else
                adding = False
                updating = True
                frm_stock_add_update.lblTitle.Text = "Update an Item"
                frm_stock_add_update.txt_barcode.Focus()
                frm_stock_add_update.ShowDialog()
            End If
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    Private Sub cmd_delete_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub cmd_stock_report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_stock_report.Click
        If frm_choose.inv_report_inv = True Then
            frm_current_stock.ShowDialog()
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    Private Sub cmd_addstocks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_addstocks.Click
        If frm_choose.inv_add_stocks = True Then
            frm_addstock.ShowDialog()
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    Private Sub cmd_purchase_return_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_purchase_return.Click
        If frm_choose.inv_purchase_return = True Then
            frm_purchase_return.ShowDialog()
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    Private Sub cmd_adjust_item_qty_Click(sender As System.Object, e As System.EventArgs) Handles cmd_adjust_item_qty.Click
        If frm_choose.admin = True Then
            frm_adjust_item_qty.ShowDialog()
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    'LOAD REPORT'

    'PURCHASES - STOCK IN'
    Public Sub load_report_purchases()
        'FOR CRYSTAL REPORT'S
        Try
            Dim rpt As New cr_purchases 'The report you created.
            Dim myAdapter As SqlDataAdapter
            Dim myDataset As New ds_purchases() 'The DataSet you created.

            Dim query As String = "SELECT item_no,barcode,item_name, " &
            "SUM(qty_purchased)as Qty_Purchased, buying_price, SUM(discount) as Purchase_disc, " &
            "SUM(total_price) as Total_Price, SUM(total_return_price) as Total_Returns, " &
            "(SUM(total_price)- SUM(discount)- SUM(total_return_price)) AS NET_TOTAL " &
            "FROM purchase_item_table " &
            "WHERE trans_date between'" & dtp_purchases_from.Value.ToString("yyyy/MM/dd") & "' and '" & dtp_purchases_to.Value.ToString("yyyy/MM/dd") & "' " &
            "GROUP BY item_no,barcode,item_name,buying_price"

            myAdapter = New SqlDataAdapter(query, SQL.SQLCon)
            myAdapter.Fill(myDataset, "purchase_item_table")
            rpt.SetDataSource(myDataset)
            crv_purchases.ReportSource = rpt

            Dim date_from As Date = dtp_purchases_from.Value
            rpt.SetParameterValue("from_pur", date_from)

            Dim date_to As Date = dtp_purchases_to.Value
            rpt.SetParameterValue("to_pur", date_to)

        Catch ex As Exception
            MsgBox(ex.ToString & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub

    Public purchase_category As String

    Public Sub load_report_purchases_cat()
        'FOR CRYSTAL REPORT'S
        Try
            Dim rpt As New cr_purchases 'The report you created.
            Dim myAdapter As SqlDataAdapter
            Dim myDataset As New ds_purchases() 'The DataSet you created.

            Dim query As String = "SELECT item_no,barcode,item_name, " &
            "SUM(qty_purchased)as Qty_Purchased, buying_price, SUM(discount) as Purchase_disc, " &
            "SUM(total_price) as Total_Price, SUM(total_return_price) as Total_Returns, " &
            "(SUM(total_price)- SUM(discount)- SUM(total_return_price)) AS NET_TOTAL " &
            "FROM purchase_item_table " &
            "WHERE category = '" & purchase_category & "' AND trans_date between'" & dtp_purchases_from.Value.ToString("yyyy/MM/dd") & "' and '" & dtp_purchases_to.Value.ToString("yyyy/MM/dd") & "' " &
            "GROUP BY item_no,barcode,item_name,buying_price"

            myAdapter = New SqlDataAdapter(query, SQL.SQLCon)
            myAdapter.Fill(myDataset, "purchase_item_table")
            rpt.SetDataSource(myDataset)
            crv_purchases.ReportSource = rpt

            Dim date_from As Date = dtp_purchases_from.Value
            rpt.SetParameterValue("from_pur", date_from)

            Dim date_to As Date = dtp_purchases_to.Value
            rpt.SetParameterValue("to_pur", date_to)

        Catch ex As Exception
            MsgBox(ex.ToString & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub

    Private Sub cmd_show_pur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_show_pur.Click
        frm_choose_category.purchases = True
        frm_choose_category.ShowDialog()
    End Sub

    Private Sub cmd_pur_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_pur_print.Click
        crv_purchases.PrintReport()
    End Sub

    Private Sub cmd_pur_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_pur_export.Click
        crv_purchases.ExportReport()
    End Sub

    'Item Sales'
    'sales - STOCK out'
    Public Sub load_report_sales()
        'FOR CRYSTAL REPORT'S
        Try
            Dim rpt As New cr_sales 'The report you created.
            Dim myAdapter As SqlDataAdapter
            Dim myDataset As New ds_sales() 'The DataSet you created.

            Dim query As String = "SELECT item_no,barcode,item_name, SUM(qty_sold)as Qty, Price, CAST((SUM(qty_sold)* price)as Float) as [Total], " &
            "SUM(dicount_percent) AS Sales_Discount, " &
            "CAST((SUM(ret_qty) * Price)as Float) As [Returns], CAST((SUM(bo_qty) * Price)as Float) As [BO], " &
            "((SUM(qty_sold)* price))- SUM(dicount_percent) - CAST((SUM(ret_qty) * Price)as Float) - CAST((SUM(bo_qty) * Price)as Float) as Net_Total " &
            "FROM sales_item_table WHERE trans_date between '" & dtp_from_itemsales.Value.ToString("yyyy/MM/dd") & "' and '" & dtp_to_itemsales.Value.ToString("yyyy/MM/dd") & "' " &
            "GROUP BY item_no,barcode,item_name, price"

            myAdapter = New SqlDataAdapter(query, SQL.SQLCon)
            myAdapter.Fill(myDataset, "sales_item_table")
            rpt.SetDataSource(myDataset)
            crv_item_sales.ReportSource = rpt

            Dim date_from As Date = dtp_from_itemsales.Value
            rpt.SetParameterValue("from_pur", date_from)

            Dim date_to As Date = dtp_to_itemsales.Value
            rpt.SetParameterValue("to_pur", date_to)
        Catch ex As Exception
            MsgBox(ex.ToString & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub

    Public sales_category As String

    Public Sub load_report_sales_cat()
        'FOR CRYSTAL REPORT'S
        Try
            Dim rpt As New cr_sales 'The report you created.
            Dim myAdapter As SqlDataAdapter
            Dim myDataset As New ds_sales() 'The DataSet you created.

            Dim query As String = "SELECT item_no,barcode,item_name, SUM(qty_sold)as Qty, Price, CAST((SUM(qty_sold)* price)as Float) as [Total], " &
            "SUM(dicount_percent) AS Sales_Discount, " &
            "CAST((SUM(ret_qty) * Price)as Float) As [Returns], CAST((SUM(bo_qty) * Price)as Float) As [BO], " &
            "((SUM(qty_sold)* price))- SUM(dicount_percent) - CAST((SUM(ret_qty) * Price)as Float) - CAST((SUM(bo_qty) * Price)as Float) as Net_Total " &
            "FROM sales_item_table WHERE category = '" & sales_category & "' AND trans_date between '" & dtp_from_itemsales.Value.ToString("yyyy/MM/dd") & "' and '" & dtp_to_itemsales.Value.ToString("yyyy/MM/dd") & "' " &
            "GROUP BY item_no,barcode,item_name, price"

            myAdapter = New SqlDataAdapter(query, SQL.SQLCon)
            myAdapter.Fill(myDataset, "sales_item_table")
            rpt.SetDataSource(myDataset)
            crv_item_sales.ReportSource = rpt

            Dim date_from As Date = dtp_from_itemsales.Value
            rpt.SetParameterValue("from_pur", date_from)

            Dim date_to As Date = dtp_to_itemsales.Value
            rpt.SetParameterValue("to_pur", date_to)
        Catch ex As Exception
            MsgBox(ex.ToString & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub

    Private Sub cmd_show_sales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_show_sales.Click
        frm_choose_category.sales = True
        frm_choose_category.ShowDialog()
    End Sub

    Private Sub cmd_sales_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_sales_print.Click
        crv_item_sales.PrintReport()
    End Sub

    Private Sub cmd_sales_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_sales_export.Click
        crv_item_sales.ExportReport()
    End Sub


End Class