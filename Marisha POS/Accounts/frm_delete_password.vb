Public Class frm_delete_password

    Dim accounts_query As New accounts

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        frm_admin_update.clear_accounts()
    End Sub

    Private Sub cmd_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_delete.Click
        If accounts_query.password_authenticate = True Then
            If MsgBox(" This Action Cannot Be Undone, Continue?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, " Confirm Delete") = MsgBoxResult.Yes Then
                accounts_query.delete_account()
                Me.Close()
                accounts_query.load_accounts()
            End If
        Else
            MsgBox(" Invalid Password!", MsgBoxStyle.Critical, " Action Cancelled")
            txt_password.Clear()
            txt_password.Focus()
        End If
    End Sub

End Class