Public Class frm_invoice

    Dim pos_query As New pos_q
    Dim init As Boolean

    Public m_item_no As Integer
    Public m_barcode As String
    Public m_item_name As String
    Public m_qty As Decimal
    Public m_selling_price As Decimal
    Public m_buying_price As Decimal
    Public m_unit As String
    Public m_category As String

    Private Sub me_FormFormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frm_choose.Show()
    End Sub
    Private Sub cmd_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_close.Click
        If MsgBox(" Are You Sure You Want To Exit?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, " Please Confirm") = MsgBoxResult.Yes Then
            Me.Close()
            frm_choose.Show()
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ss_time_and_date.Text = DateTime.Now.ToString("h:mm tt dddd, d MMMM yyyy")
    End Sub
    Private Sub frm_invoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        ss_user.Text = frm_choose.lbl_name.Text
        ss_position.Text = frm_choose.lbl_position.Text

        'align dgv header
        dgv_item_cart.Columns("selling_price").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_item_cart.Columns("selling_price").SortMode = DataGridViewColumnSortMode.NotSortable

        dgv_item_cart.Columns("qty").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_item_cart.Columns("qty").SortMode = DataGridViewColumnSortMode.NotSortable

        dgv_item_cart.Columns("amount").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_item_cart.Columns("amount").SortMode = DataGridViewColumnSortMode.NotSortable

        dgv_item_cart.Columns("discount").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_item_cart.Columns("discount").SortMode = DataGridViewColumnSortMode.NotSortable

        pos_query.get_trans_no()
    End Sub

    Private Sub txt_barcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_barcode.KeyUp
        'If txt_barcode.Text = "" Then
        '    lbl_barcode_status.Text = "...."
        'End If
        If pos_query.match_found = True Then
            lbl_barcode_status.Text = " Match Found"
            pos_query.match_put_to_txt()

            'check if exists then find item +1
            Dim exists As Boolean = False
            For Each itm As DataGridViewRow In dgv_item_cart.Rows
                If itm.Cells(0).Value = m_item_no Then
                    exists = True
                    itm.Cells(4).Value += 1 'qty col
                    itm.Cells(6).Value = Format(CDec(itm.Cells(4).Value * itm.Cells(3).Value), "0.00") '+1 instance of price to the total amt
                End If
            Next

            If exists = False Then
                pos_query.add_to_cart(m_item_no, m_barcode, m_item_name, m_selling_price, m_qty, m_unit, m_selling_price, m_buying_price,
                                      0.00, m_category)
            End If

            looptotal()
            txt_barcode.Clear()
        Else
            If txt_barcode.Text <> "" Then
                lbl_barcode_status.Text = "No Match Found ...."
            End If
        End If


        ClearItemVariables()

    End Sub

    'clear variables'
    Public Sub ClearItemVariables()
        m_item_no = vbNull
        m_barcode = vbNull
        m_item_name = vbNull
        m_qty = vbNull
        m_selling_price = vbNull
        m_buying_price = vbNull
        m_unit = vbNull
        m_category = vbNull
    End Sub

    'initialize the current selected item'
    Public Sub FillItemVariables()
        m_item_no = dgv_item_cart.Item("item_no", dgv_item_cart.CurrentRow.Index).Value.ToString()
        m_barcode = dgv_item_cart.Item("barcode", dgv_item_cart.CurrentRow.Index).Value.ToString()
        m_item_name = dgv_item_cart.Item("item_name", dgv_item_cart.CurrentRow.Index).Value.ToString()
        m_qty = dgv_item_cart.Item("qty", dgv_item_cart.CurrentRow.Index).Value.ToString()
        m_selling_price = dgv_item_cart.Item("selling_price", dgv_item_cart.CurrentRow.Index).Value
        m_buying_price = dgv_item_cart.Item("buying_price", dgv_item_cart.CurrentRow.Index).Value
        m_unit = dgv_item_cart.Item("unit", dgv_item_cart.CurrentRow.Index).Value.ToString()
        m_category = dgv_item_cart.Item("category", dgv_item_cart.CurrentRow.Index).Value.ToString()
    End Sub

    'Remove From Cart
    Private Sub dgv_item_cart_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_item_cart.CellClick
        If dgv_item_cart.Rows.Count > 0 Then
            If e.ColumnIndex = 10 Then 'for delete row'
                delete_row()
                looptotal()
                ClearItemVariables()
            End If
            If e.ColumnIndex <> 10 Then
                FillItemVariables()
            End If
        End If
    End Sub

    Public Sub delete_row()
        If dgv_item_cart.SelectedRows.Count > 0 Then
            dgv_item_cart.Rows.Remove(dgv_item_cart.SelectedRows(0))
        End If
    End Sub

    Sub looptotal()

        Dim sub_total As Decimal = 0
        Dim item_count As Decimal = 0
        Dim discount As Decimal = 0

        'if you have the other column to get the result you  could add a new one like these above 
        For index As Integer = 0 To dgv_item_cart.RowCount - 1
            sub_total += Convert.ToDecimal(dgv_item_cart.Rows(index).Cells(3).Value * dgv_item_cart.Rows(index).Cells(4).Value)

            If dgv_item_cart.Rows(index).Cells(5).Value.ToString = "PCS" Then
                item_count += Convert.ToDecimal(dgv_item_cart.Rows(index).Cells(4).Value)
            End If

            discount += Convert.ToDecimal(dgv_item_cart.Rows(index).Cells(8).Value)
        Next

        Dim grand_total As Decimal = sub_total - discount

        lbl_total_disc.Text = discount.ToString("0.00")
        lbl_sub_total.Text = sub_total.ToString("0.00")
        lbl_grand_total.Text = grand_total.ToString("0.00")

        lbl_item_count.Text = item_count
    End Sub

    'Lower Right Buttons'
    Private Sub cmd_pay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_pay.Click
        If dgv_item_cart.Rows.Count < 1 Then
            MsgBox(" Please Select Items!", MsgBoxStyle.Critical, " Invalid Action")
            txt_barcode.Focus()
        ElseIf CDec(lbl_grand_total.Text) < CDec(1) Then
            MsgBox(" The Grand Total Amount Must Not Be Negative! Please Check Your Inputs", MsgBoxStyle.Critical, " Invalid Action")
            Exit Sub
        Else
            frm_pay.lbl_amt_to_pay.Text = Me.lbl_grand_total.Text
            frm_pay.ShowDialog()
        End If
    End Sub
    Private Sub cmd_change_qty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_change_qty.Click
        If dgv_item_cart.Rows.Count < 1 Then
            MsgBox(" There Are no Items in The List!", MsgBoxStyle.Critical, " Invalid Action")
            txt_barcode.Focus()
        ElseIf m_item_no = vbNull Then
            MsgBox(" Please Select an Item!", MsgBoxStyle.Critical, " Invalid Action")
        Else
            frm_change_qty.lbl_barcode.Text = dgv_item_cart.Item("barcode", dgv_item_cart.CurrentRow.Index).Value.ToString()
            frm_change_qty.lbl_item_name.Text = dgv_item_cart.Item("item_name", dgv_item_cart.CurrentRow.Index).Value.ToString()
            frm_change_qty.txt_qty.Text = dgv_item_cart.Item("qty", dgv_item_cart.CurrentRow.Index).Value.ToString()
            frm_change_qty.lbl_unit.Text = dgv_item_cart.Item("unit", dgv_item_cart.CurrentRow.Index).Value.ToString()
            frm_change_qty.ShowDialog()
        End If
    End Sub
    Private Sub cmd_item_lookup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_item_lookup.Click
        frm_item_lookup.ShowDialog()
    End Sub
    Private Sub cmd_discount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_discount.Click
        If dgv_item_cart.Rows.Count < 1 Then
            MsgBox(" There Are no Items in The List!", MsgBoxStyle.Critical, " Invalid Action")
            txt_barcode.Focus()
        ElseIf m_item_no = vbNull Then
            MsgBox(" Please Select an Item!", MsgBoxStyle.Critical, " Invalid Action")
        Else
            frm_change_discount.lbl_barcode.Text = dgv_item_cart.Item("barcode", dgv_item_cart.CurrentRow.Index).Value.ToString()
            frm_change_discount.lbl_item_name.Text = dgv_item_cart.Item("item_name", dgv_item_cart.CurrentRow.Index).Value.ToString()
            frm_change_discount.txt_discount.Text = dgv_item_cart.Item("discount", dgv_item_cart.CurrentRow.Index).Value.ToString()
            frm_change_discount.lbl_current_total_price.Text = dgv_item_cart.Item("amount", dgv_item_cart.CurrentRow.Index).Value
            frm_change_discount.ShowDialog()
        End If
    End Sub
    Private Sub cmd_hold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_hold.Click
        If Me.dgv_item_cart.Rows.Count < 1 Then
            MsgBox(" There are no items in the list! No need to Hold Transaction", MsgBoxStyle.Critical, " Invalid Action")
            txt_barcode.Focus()
        Else
            frm_trans_remarks.ShowDialog()
        End If
    End Sub
    Private Sub cmd_resume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_resume.Click
        frm_held_trans.ShowDialog()
    End Sub
    Private Sub cmd_cancel_invoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel_invoice.Click
        If MsgBox(" Cancel the Transaction?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, " Please Confirm") = MsgBoxResult.Yes Then
            txt_barcode.Clear()
            dgv_item_cart.Rows.Clear()
            ClearItemVariables()
            lbl_disc_percent.Text = "0"
            looptotal()
        End If
    End Sub

    'MENU STRIP'
    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_discount.ShowDialog()
    End Sub

    Private Sub ReciptSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReciptSettingsToolStripMenuItem.Click
        frm_receipt_settings.ShowDialog()
    End Sub

    'SHORCUT KEYS'
    Private Sub shortcut_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            txt_barcode.Clear()
            txt_barcode.Focus()
        End If
        If (e.Control AndAlso (e.KeyCode = Keys.P)) Then
            cmd_pay.PerformClick()
        End If
        If (e.Control AndAlso (e.KeyCode = Keys.Q)) Then
            cmd_change_qty.PerformClick()
        End If
        If (e.Control AndAlso (e.KeyCode = Keys.I)) Then
            cmd_item_lookup.PerformClick()
        End If
        If (e.Control AndAlso (e.KeyCode = Keys.D)) Then
            cmd_discount.PerformClick()
        End If
        If (e.Control AndAlso (e.KeyCode = Keys.H)) Then
            cmd_hold.PerformClick()
        End If
        If (e.Control AndAlso (e.KeyCode = Keys.R)) Then
            cmd_resume.PerformClick()
        End If
        If (e.Control AndAlso (e.KeyCode = Keys.E)) Then
            cmd_cancel_invoice.PerformClick()
        End If
        If e.KeyCode = Keys.Escape Then
            cmd_close.PerformClick()
        End If
        If (e.Control AndAlso (e.KeyCode = Keys.X)) Then
            If dgv_item_cart.Rows.Count > 0 Then
                delete_row()
                looptotal()
                ClearItemVariables()
            End If
        End If
    End Sub

End Class
