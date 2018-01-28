Public Class frm_pay

    Dim pos_query As New pos_q
    Dim itemFlowServce As New ItemFlowService


    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub cmd_cash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cash.Click
        If txt_tendered.Text = "" Then
            MsgBox(" Please Input the Amount Tendered!", MsgBoxStyle.Critical, "Invalid")
            txt_tendered.Focus()
        ElseIf Not IsNumeric(txt_tendered.Text) Then
            MsgBox(" Invalid Entry! Please Input A Correct One!", MsgBoxStyle.Critical, "Invalid")
            txt_tendered.Clear()
            txt_tendered.Focus()
        ElseIf CDec(lbl_amt_to_pay.Text) > CDec(txt_tendered.Text) Then
            MsgBox(" Insufficient Tendered Amount!", MsgBoxStyle.Critical, "Invalid")
            txt_tendered.Focus()
        Else
            If MsgBox(" COMMIT TRANSACTION?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, " Please Confirm") = MsgBoxResult.Yes Then
                'Database Manipulation Here'
                pos_query.insert_sales_trans_cash()
                pos_query.Insert_sales_items_cash()

                'new global insert for item flow
                For Each row As DataGridViewRow In frm_invoice.dgv_item_cart.Rows
                    itemFlowServce.InsertItemFlow(row.Cells(0).Value, DateTime.Now, 
                                                  "SALES", 0, row.Cells(4).Value, 0, row.Cells(7).Value)
                Next

                ''pos_query.insert_begin_end_sales()
                'pos_query.insert_beg_inv_price() 'begin inv price'
                pos_query.deduct_items_qty()

                MsgBox(" Sales Transaction Saved!", MsgBoxStyle.Information, " Action Successful")

                Me.Enabled = False
                'transfer cash tendered and change to invoice tab
                frm_receipt_preview.ShowDialog()
            End If
        End If
    End Sub

    Private Sub cmd_on_account_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_on_account.Click
        If CDec(lbl_amt_to_pay.Text) > 0 Then
            frm_showcustomers.full_account = True
            frm_showcustomers.partial_account = False
            frm_showcustomers.partial_account_no_tendered = False
            frm_showcustomers.ShowDialog()
        Else
            MsgBox(" Please Input Items!", MsgBoxStyle.Critical, "Invalid")
        End If
    End Sub

    Private Sub cmd_partial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_partial.Click
        If txt_tendered.Text = "" Then
            txt_tendered.Text = "0.00"
        End If
        If CDec(txt_tendered.Text) <= 0 Then
            MsgBox(" Please Input the Amount Tendered!", MsgBoxStyle.Critical, "Invalid")
            txt_tendered.Focus()
        ElseIf CDec(lbl_amt_to_pay.Text) > CDec(txt_tendered.Text) Then
            frm_showcustomers.full_account = False
            frm_showcustomers.partial_account = False
            frm_showcustomers.partial_account_no_tendered = True
            frm_showcustomers.ShowDialog()
        Else
            frm_partial_pay.lbl_tendered.Text = Me.txt_tendered.Text
            frm_partial_pay.ShowDialog()
        End If
    End Sub

    Private Sub cmd_20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_20.Click
        txt_tendered.Text = "20.00"
    End Sub
    Private Sub cmd_50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_50.Click
        txt_tendered.Text = "50.00"
    End Sub
    Private Sub cmd_100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_100.Click
        txt_tendered.Text = "100.00"
    End Sub
    Private Sub cmd_200_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_200.Click
        txt_tendered.Text = "200.00"
    End Sub
    Private Sub cmd_500_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_500.Click
        txt_tendered.Text = "500.00"
    End Sub
    Private Sub cmd_1000_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_1000.Click
        txt_tendered.Text = "1000.00"
    End Sub

    Private Sub cmd_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_0.Click
        If txt_tendered.TextLength < 10 Then
            txt_tendered.Text += "0"
        End If
    End Sub
    Private Sub cmd_00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_00.Click
        If txt_tendered.TextLength < 10 Then
            txt_tendered.Text += "00"
        End If
    End Sub
    Private Sub cmd_period_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_period.Click
        If txt_tendered.TextLength < 10 Then
            If InStr(txt_tendered.Text, ".") Then
                'no action'
            Else
                txt_tendered.Text += "."
            End If
        End If
    End Sub
    Private Sub cmd_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_1.Click
        If txt_tendered.TextLength < 10 Then
            txt_tendered.Text += "1"
        End If
    End Sub
    Private Sub cmd_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_2.Click
        If txt_tendered.TextLength < 10 Then
            txt_tendered.Text += "2"
        End If
    End Sub
    Private Sub cmd_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_3.Click
        If txt_tendered.TextLength < 10 Then
            txt_tendered.Text += "3"
        End If
    End Sub
    Private Sub cmd_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_4.Click
        If txt_tendered.TextLength < 10 Then
            txt_tendered.Text += "4"
        End If
    End Sub
    Private Sub cmd_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_5.Click
        If txt_tendered.TextLength < 10 Then
            txt_tendered.Text += "5"
        End If
    End Sub
    Private Sub cmd_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_6.Click
        If txt_tendered.TextLength < 10 Then
            txt_tendered.Text += "6"
        End If
    End Sub
    Private Sub cmd_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_7.Click
        If txt_tendered.TextLength < 10 Then
            txt_tendered.Text += "7"
        End If
    End Sub
    Private Sub cmd_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_8.Click
        If txt_tendered.TextLength < 10 Then
            txt_tendered.Text += "8"
        End If
    End Sub
    Private Sub cmd_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_9.Click
        If txt_tendered.TextLength < 10 Then
            txt_tendered.Text += "9"
        End If
    End Sub
    Private Sub cmd_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_clear.Click
        txt_tendered.Clear()
    End Sub

    Private Sub NumOnly_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_tendered.KeyPress

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        ' only allow one decimal point
        If e.KeyChar = "."c AndAlso TryCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub frm_pay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    'SHORCUT KEYS'
    Private Sub shortcut_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            cmd_cancel.PerformClick()
        End If

        If e.KeyCode = Keys.F1 Then
            cmd_20.PerformClick()
        End If
        If e.KeyCode = Keys.F2 Then
            cmd_50.PerformClick()
        End If
        If e.KeyCode = Keys.F3 Then
            cmd_100.PerformClick()
        End If
        If e.KeyCode = Keys.F4 Then
            cmd_200.PerformClick()
        End If
        If e.KeyCode = Keys.F5 Then
            cmd_500.PerformClick()
        End If
        If e.KeyCode = Keys.F6 Then
            cmd_1000.PerformClick()
        End If

        If (e.Control AndAlso (e.KeyCode = Keys.S)) Then
            cmd_cash.PerformClick()
        End If
        If (e.Control AndAlso (e.KeyCode = Keys.A)) Then
            cmd_on_account.PerformClick()
        End If
    End Sub

    Private Sub cmd_equal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_equal.Click
        txt_tendered.Text = lbl_amt_to_pay.Text
    End Sub

End Class