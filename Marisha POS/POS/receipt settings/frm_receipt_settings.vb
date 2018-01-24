Public Class frm_receipt_settings

    Dim receipt_query As New receipt_settings_q

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frm_receipt_settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        receipt_query.load()
    End Sub

    Private Sub cmd_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_update.Click
        If frm_choose.pos_receipt = True Then
            If IncompleteInput() = True Then
                Exit Sub
            Else
                If MsgBox(" Save Changes?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Are You Sure You Want To Save?") = MsgBoxResult.Yes Then
                    receipt_query.update()
                    Me.Close()
                    receipt_query.load()
                End If
            End If
        Else
            MsgBox(" Restricted Access! Please Contact Your Administrator", MsgBoxStyle.Critical, " Access Denied")
        End If
    End Sub

    Function IncompleteInput() As Boolean
        If Me.txt_store_name.Text = "" Then
            MsgBox(" Please Input the Store Name!", MsgBoxStyle.Critical, "Incomplete Fields!")
            Me.txt_store_name.Focus()
            Return True
        ElseIf Me.txt_store_address.Text = "" Then
            MsgBox(" Please Input the Store Address!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_store_address.Focus()
            Return True
        ElseIf Me.txt_tin.Text = "" Then
            MsgBox(" Please Input the Tin #", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_tin.Focus()
            Return True
        ElseIf Me.txt_closing_1.Text = "" Then
            MsgBox(" Please Input a text!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_closing_1.Focus()
            Return True
        ElseIf Me.txt_closing_2.Text = "" Then
            MsgBox(" Please Input a text!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_closing_2.Focus()
            Return True
        Else
            Return False
        End If
    End Function
End Class