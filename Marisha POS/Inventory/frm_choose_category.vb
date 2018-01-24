Public Class frm_choose_category

    Dim choose_cat_query As New choose_category_q

    Public purchases As Boolean = False
    Public sales As Boolean = False
    Public inventory As Boolean = False

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frm_choose_category_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        choose_cat_query.show_categories()
        cbo_choose_cat.SelectedIndex = 0
    End Sub

    Private Sub cmd_ok_Click(sender As System.Object, e As System.EventArgs) Handles cmd_ok.Click
        If purchases = True Then
            If cbo_choose_cat.SelectedIndex = 0 Then
                frm_inventory.load_report_purchases()
                Me.Close()
            Else
                frm_inventory.purchase_category = cbo_choose_cat.Text
                frm_inventory.load_report_purchases_cat()
                Me.Close()
            End If
        ElseIf sales = True Then
            If cbo_choose_cat.SelectedIndex = 0 Then
                frm_inventory.load_report_sales()
                Me.Close()
            Else
                frm_inventory.sales_category = cbo_choose_cat.Text
                frm_inventory.load_report_sales_cat()
                Me.Close()
            End If
        ElseIf inventory = True Then
                frm_current_stock.load_report()
                Me.Close()
        End If
    End Sub

End Class