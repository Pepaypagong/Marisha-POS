Public Class frm_apply_discount

    Dim disc_query As New discount_q

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
    Private Sub frm_apply_discount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        disc_query.load_discount_apply()
        Me.KeyPreview = True
    End Sub

    Private Sub dgv_discount_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_discount.CellClick
        If e.ColumnIndex = 3 Then
            frm_invoice.lbl_disc_percent.Text = dgv_discount.Item("discount", dgv_discount.CurrentRow.Index).Value.ToString()
            Me.Close()
        End If
        frm_invoice.looptotal()
    End Sub

    Private Sub cmd_remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_remove.Click
        frm_invoice.lbl_disc_percent.Text = "0"
        frm_invoice.looptotal()
        Me.Close()
    End Sub

    Private Sub cmd_enter_disc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_enter_disc.Click
        If Not IsNumeric(txt_discount.Text) Then
            frm_invoice.lbl_disc_percent.Text = "0"
            frm_invoice.looptotal()
        ElseIf CDec(txt_discount.Text) > 100 Then
            MsgBox(" Invalid Discount Amount!", MsgBoxStyle.Critical, " Invalid Entry")
            frm_invoice.lbl_disc_percent.Text = "0"
            frm_invoice.looptotal()
        ElseIf txt_discount.Text = "" Then
            frm_invoice.lbl_disc_percent.Text = "0"
            frm_invoice.looptotal()
        ElseIf txt_discount.Text = "." Then
            frm_invoice.lbl_disc_percent.Text = "0"
            frm_invoice.looptotal()
        Else
            txt_discount.Text = Format(CDec(txt_discount.Text), "0.00")
            frm_invoice.lbl_disc_percent.Text = Me.txt_discount.Text
            frm_invoice.looptotal()
        End If
        Me.Close()
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
            cmd_enter_disc.PerformClick()
        End If
    End Sub
End Class