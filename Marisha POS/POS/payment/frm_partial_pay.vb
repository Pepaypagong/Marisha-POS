Public Class frm_partial_pay

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub cmd_select_customer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_select_customer.Click
        If txt_paid_amt.Text = "" Then
            txt_paid_amt.Text = "0.00"
        End If
        If Not IsNumeric(txt_paid_amt.Text) Then
            MsgBox(" Invalid Entry! Please Input A Correct One!", MsgBoxStyle.Critical, "Invalid")
            txt_paid_amt.Clear()
            txt_paid_amt.Focus()
        ElseIf CDec(txt_paid_amt.Text) <= 0 Then
            MsgBox(" Please Input the Partial Amount Paid by The Customer!", MsgBoxStyle.Critical, "Invalid")
            txt_paid_amt.Focus()
        ElseIf CDec(txt_paid_amt.Text) >= CDec(frm_pay.lbl_amt_to_pay.Text) Then
            MsgBox(" The Partial Paid Amount Should NOT BE GREATER than the amount to Pay! Pay With CASH Instead.", MsgBoxStyle.Critical, "Invalid Amount")
            txt_paid_amt.Focus()
        Else
            frm_showcustomers.full_account = False
            frm_showcustomers.partial_account = True
            frm_showcustomers.ShowDialog()
        End If
    End Sub

    Private Sub NumOnly_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_paid_amt.KeyPress

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        ' only allow one decimal point
        If e.KeyChar = "."c AndAlso TryCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmd_20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt_paid_amt.Text = "20.00"
    End Sub
    Private Sub cmd_50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt_paid_amt.Text = "50.00"
    End Sub
    Private Sub cmd_100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt_paid_amt.Text = "100.00"
    End Sub
    Private Sub cmd_200_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt_paid_amt.Text = "200.00"
    End Sub
    Private Sub cmd_500_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt_paid_amt.Text = "500.00"
    End Sub
    Private Sub cmd_1000_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt_paid_amt.Text = "1000.00"
    End Sub

    Private Sub cmd_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_0.Click
        If txt_paid_amt.TextLength < 10 Then
            txt_paid_amt.Text += "0"
        End If
    End Sub
    Private Sub cmd_00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_00.Click
        If txt_paid_amt.TextLength < 10 Then
            txt_paid_amt.Text += "00"
        End If
    End Sub
    Private Sub cmd_period_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_period.Click
        If txt_paid_amt.TextLength < 10 Then
            If InStr(txt_paid_amt.Text, ".") Then
                'no action'
            Else
                txt_paid_amt.Text += "."
            End If
        End If
    End Sub
    Private Sub cmd_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_1.Click
        If txt_paid_amt.TextLength < 10 Then
            txt_paid_amt.Text += "1"
        End If
    End Sub
    Private Sub cmd_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_2.Click
        If txt_paid_amt.TextLength < 10 Then
            txt_paid_amt.Text += "2"
        End If
    End Sub
    Private Sub cmd_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_3.Click
        If txt_paid_amt.TextLength < 10 Then
            txt_paid_amt.Text += "3"
        End If
    End Sub
    Private Sub cmd_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_4.Click
        If txt_paid_amt.TextLength < 10 Then
            txt_paid_amt.Text += "4"
        End If
    End Sub
    Private Sub cmd_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_5.Click
        If txt_paid_amt.TextLength < 10 Then
            txt_paid_amt.Text += "5"
        End If
    End Sub
    Private Sub cmd_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_6.Click
        If txt_paid_amt.TextLength < 10 Then
            txt_paid_amt.Text += "6"
        End If
    End Sub
    Private Sub cmd_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_7.Click
        If txt_paid_amt.TextLength < 10 Then
            txt_paid_amt.Text += "7"
        End If
    End Sub
    Private Sub cmd_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_8.Click
        If txt_paid_amt.TextLength < 10 Then
            txt_paid_amt.Text += "8"
        End If
    End Sub
    Private Sub cmd_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_9.Click
        If txt_paid_amt.TextLength < 10 Then
            txt_paid_amt.Text += "9"
        End If
    End Sub
    Private Sub cmd_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_clear.Click
        txt_paid_amt.Clear()
    End Sub

    Private Sub frm_partial_pay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    'SHORCUT KEYS'
    Private Sub shortcut_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            cmd_back.PerformClick()
        End If
    End Sub

End Class