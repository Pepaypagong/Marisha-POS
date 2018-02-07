Imports System.Data
Imports System.Data.SqlClient
Imports System.Threading

Public Class frm_current_stock

    Dim SQL As New SQLControl
    Dim dateHelper As New dateHelper

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Public Sub load_report()
        Try
            'FOR CRYSTAL REPORT'S
            Dim rpt As New cr_current_stock  'The report you created.
            Dim myAdapter As SqlDataAdapter
            Dim myDataset As New ds_beg_end_inv() 'The DataSet you created.

            dim date_from As string = dtp_purchases_from.Value().ToString("yyyy/MM/dd")
            dim date_to As string = dtp_purchases_to.Value().ToString("yyyy/MM/dd")

            Dim category As String = frm_choose_category.cbo_choose_cat.Text()

            Dim query As String = "DECLARE @START_DATE date = '"& date_from &"' " &
                             "DECLARE @OLDEST_TRANSACTION_DATE date = (SELECT MIN(date) from item_flow_table) " &
                             "DECLARE @CATEGORY VARCHAR(50) = '"& category &"' " &
                             "DECLARE @query NVARCHAR(MAX) =  " &
                             "'DECLARE @START_DATE date = ''"& date_from &"'' " &
                             "DECLARE @END_DATE date = ''"& date_to &"''" &
                             "DECLARE @OLDEST_TRANSACTION_DATE date = (SELECT MIN(date) from item_flow_table) " &
                             "DECLARE @CATEGORY VARCHAR(50) = ''"& category &"'' " &
                             ";WITH CTE_BEGIN_INV AS( " &
                             "SELECT item_no,SUM(item_in) - SUM(item_out) as beginInv, " &
                             "SUM(price_in) - SUM(price_out) as beginInvAmount " &
                             "FROM item_flow_table ' " &
                             "IF @START_DATE = @OLDEST_TRANSACTION_DATE " &
	                         "SET @query = @query + 'WHERE date = @START_DATE AND is_initial_entry = 1 ' " &
                             "ELSE " &
	                         "SET @query = @query + 'WHERE date < @START_DATE ' " &
                             "SET @query = @query + 'GROUP BY item_no), " &
                             "CTE_IN_OUT AS ( " &
                             "SELECT a.item_no, " & 
                             "ISNULL(SUM(b.item_in),0) as totalIn, " &
                             "ISNULL(SUM(b.price_in),0) as totalInAmount, " &
                             "ISNULL(SUM(b.item_out),0) as totalOut, " &
                             "ISNULL(SUM(b.price_out),0) as totalOutAmount " &
                             "FROM CTE_BEGIN_INV a " &
                             "LEFT JOIN item_flow_table b  " &
                             "ON a.item_no = b.item_no AND b.date BETWEEN @START_DATE AND @END_DATE " &
                             "AND b.is_initial_entry != 1 " &
                             "GROUP BY a.item_no)," &
                             "CTE_ENDING_INV AS ( " &
                             "SELECT a.item_no, a.beginInv + b.totalIn - b.totalOut as endingInv, " &
                             "a.beginInvAmount + b.totalInAmount - b.totalOutAmount as endingInvAmount " &
                             "FROM CTE_BEGIN_INV a " &
                             "LEFT JOIN CTE_IN_OUT b  " &
                             "ON a.item_no = b.item_no " &
                             ") " &
                             "SELECT a.item_no, d.barcode, d.item_name, a.beginInv, a.beginInvAmount, b.totalIn, " &
                             "b.totalInAmount, b.totalOut, b.totalOutAmount, c.endingInv, c.endingInvAmount " &
                             "FROM CTE_BEGIN_INV a " &
                             "LEFT JOIN  CTE_IN_OUT b " &
                             "ON a.item_no = b.item_no " &
                             "LEFT JOIN  CTE_ENDING_INV c " &
                             "ON a.item_no = c.item_no " &
                             "LEFT JOIN item_table d " &
                             "ON a.item_no = d.item_no ' " &
                             "IF @CATEGORY != 'All Categories' " &
	                         "    SET @query = @query + 'WHERE d.category = @CATEGORY ' " &
                             " EXECUTE sp_executesql @query "

            myAdapter = New SqlDataAdapter(query, SQL.SQLCon)
            myAdapter.Fill(myDataset, "item_flow")
            rpt.SetDataSource(myDataset)

            rpt.SetParameterValue("from_pur", dtp_purchases_from.Value())
            rpt.SetParameterValue("to_pur", dtp_purchases_from.Value())

            crv_inventory_report.ReportSource = rpt

        Catch ex As Exception
            MsgBox(ex.ToString & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub

    Private Sub cmd_showdata_itemsales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_show.Click
        frm_choose_category.inventory = True
        frm_choose_category.ShowDialog()
    End Sub

    Private Sub cmd_sales_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_print.Click
        crv_inventory_report.PrintReport()
    End Sub

    Private Sub cmd_sales_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_export.Click
        crv_inventory_report.ExportReport()
    End Sub

    Private Sub frm_current_stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class