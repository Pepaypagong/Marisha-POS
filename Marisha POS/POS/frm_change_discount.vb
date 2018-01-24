Public Class frm_change_discount

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub cmd_done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_done.Click
        If txt_discount.Text = "" Then
            txt_discount.Text = "0.00"
        End If

        If Not IsNumeric(txt_discount.Text) Then
            MsgBox(" Invalid Discount Amount!", MsgBoxStyle.Critical, " Invalid Entry")
            txt_discount.Clear()
            txt_discount.Focus()
            Exit Sub
        ElseIf CDec(txt_discount.Text) < 0 Then
            MsgBox(" Invalid Discount Amount!", MsgBoxStyle.Critical, " Invalid Entry")
            txt_discount.Clear()
            txt_discount.Focus()
        ElseIf CDec(txt_discount.Text) > CDec(lbl_current_total_price.Text) Then
            MsgBox(" Invalid Discount Amount!", MsgBoxStyle.Critical, " Invalid Entry")
            txt_discount.Clear()
            txt_discount.Focus()
        Else
            Dim i = frm_invoice.dgv_item_cart.CurrentRow.Index
            txt_discount.Text = Format(CDec(txt_discount.Text), "0.00")
            With frm_invoice.dgv_item_cart
                .Rows(i).Cells("discount").Value = txt_discount.Text
            End With
            frm_invoice.looptotal()
            Me.Close()
        End If
    End Sub

    Private Sub frm_change_qty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub NumOnly_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_discount.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        ' only allow one decimal point
        If e.KeyChar = "."c AndAlso TryCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
        End If
    End Sub

    'SHORCUT KEYS'
    Private Sub shortcut_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            cmd_cancel.PerformClick()
        End If
    End Sub

    'enable textboxes to keypress enter trigger event
    Private Sub login_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_discount.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            cmd_done.PerformClick()
        End If
    End Sub

End Class