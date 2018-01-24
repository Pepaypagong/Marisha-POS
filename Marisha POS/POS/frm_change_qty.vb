Public Class frm_change_qty

    Dim pos_query As New pos_q

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub cmd_done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_done.Click
        If txt_qty.Text = "" Then
            MsgBox(" Invalid Quantity!", MsgBoxStyle.Critical, " Invalid Entry")
            txt_qty.Clear()
            txt_qty.Focus()
            Exit Sub
        ElseIf Not IsNumeric(txt_qty.Text) Then
            MsgBox(" Invalid Quantity!", MsgBoxStyle.Critical, " Invalid Entry")
            txt_qty.Clear()
            txt_qty.Focus()
            Exit Sub
        ElseIf CDec(txt_qty.Text) <= 0 Then
            MsgBox(" Invalid Quantity!", MsgBoxStyle.Critical, " Invalid Entry")
            txt_qty.Clear()
            txt_qty.Focus()
        ElseIf CDec(txt_qty.Text) > CDec(lbl_current_stock_qty.Text) Then
            MsgBox(" The Current Stock On This Item is : " + lbl_current_stock_qty.Text + ". The Qty. You Entered is Invalid!", MsgBoxStyle.Critical, " Invalid Entry")
            txt_qty.Clear()
            txt_qty.Focus()
        Else
            Dim i = frm_invoice.dgv_item_cart.CurrentRow.Index
            txt_qty.Text = Format(CDec(txt_qty.Text), "0.00")
            With frm_invoice.dgv_item_cart
                .Rows(i).Cells("qty").Value = txt_qty.Text
                .Rows(i).Cells("amount").Value = Format(CDec(.Rows(i).Cells("selling_price").Value * .Rows(i).Cells("qty").Value), "0.00")
                .Rows(i).Cells("ending").Value = lbl_current_stock_qty.Text - txt_qty.Text
                .Rows(i).Cells("beg_inv_price").Value = Format(CDec(.Rows(i).Cells("buying_price").Value * .Rows(i).Cells("qty").Value), "0.00")
            End With
            frm_invoice.looptotal()
            Me.Close()
        End If
    End Sub

    Private Sub frm_change_qty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        pos_query.get_stock_qty()
    End Sub

    Private Sub NumOnly_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_qty.KeyPress
        If lbl_unit.Text = "KGS" Then
            If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
                e.Handled = True
            End If

            ' only allow one decimal point
            If e.KeyChar = "."c AndAlso TryCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
                e.Handled = True
            End If
        Else
            If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    'SHORCUT KEYS'
    Private Sub shortcut_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            cmd_cancel.PerformClick()
        End If
    End Sub

    'enable textboxes to keypress enter trigger event
    Private Sub login_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_qty.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            cmd_done.PerformClick()
        End If
    End Sub

End Class