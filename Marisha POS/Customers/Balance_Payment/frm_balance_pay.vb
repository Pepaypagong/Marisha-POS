Public Class frm_balance_pay

    Dim cust_bal_query As New cust_bal_q

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub cmd_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_save.Click
        If IncompleteInput() = True Then
            Exit Sub
        ElseIf CDec(Me.txt_amount.Text) <= 0 Then
            MsgBox(" Please Input a Correct Amount!", MsgBoxStyle.Critical, "Invalid Entry")
            txt_amount.Focus()
        ElseIf CDec(Me.txt_amount.Text) > CDec(frm_payment_records.lbl_current_bal.Text) Then
            MsgBox(" This Amount is Greater Than the Current Balance! Please Input Another Amount", MsgBoxStyle.Critical, "Invalid Entry")
            txt_amount.Focus()
        Else
            If MsgBox(" PAYMENT INFORMATION " & vbCrLf & _
                      " Date : " + Me.dtp_date.Text & vbCrLf & "" + _
                      " Amount : " + Me.txt_amount.Text & vbCrLf & "" & vbCrLf & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Are You Sure You Want To Save?") = MsgBoxResult.Yes Then

                Dim paying_amt As Decimal = txt_amount.Text
                Dim current_bal As Decimal = frm_payment_records.lbl_current_bal.Text
                Dim new_bal As Decimal = current_bal - paying_amt
                frm_payment_records.lbl_current_bal.Text = new_bal
                frm_customers.lbl_current_bal.Text = new_bal

                cust_bal_query.inser_pay()
                Me.Close()
                cust_bal_query.load_filter_payments()
            End If
        End If
    End Sub

    Function IncompleteInput() As Boolean
        If Me.txt_amount.Text = "" Then
            MsgBox(" Please Input an Amount!", MsgBoxStyle.Critical, "Incomplete Entry")
            txt_amount.Focus()
            Return True
        ElseIf Not IsNumeric(txt_amount.Text) Then
            MsgBox(" Invalid Amount! Please Input a Correct One!", MsgBoxStyle.Critical, "Invalid Entry")
            txt_amount.Clear()
            txt_amount.Focus()
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub NumOnly_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_amount.KeyPress

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        ' only allow one decimal point
        If e.KeyChar = "."c AndAlso TryCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
        End If
    End Sub

End Class