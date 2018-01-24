Public Class frm_add_discount

    Dim disc_query As New discount_q

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clear_disc()
        Me.Dispose()
    End Sub

    Public Sub clear_disc()
        frm_discount.lbl_no.Text = ""
        frm_discount.lbl_disc_name.Text = ""
        frm_discount.lbl_discount.Text = ""
    End Sub

    Private Sub frm_discount_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frm_discount.adding = True Then
            clear_form()
            disc_query.get_discount_no()
        End If
    End Sub

    Public Sub clear_form()
        Me.lbl_no.Text = ""
        Me.txt_disc_name.Clear()
        Me.txt_discount.Clear()
    End Sub

    Private Sub cmd_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_save.Click
        If frm_discount.adding = True Then
            If IncompleteInput() = True Then
                Exit Sub
            Else
                If MsgBox(" DISCOUNT INFORMATION " & vbCrLf & _
                          " Discount No : " + lbl_no.Text & vbCrLf & "" + _
                          " Discount Name : " + txt_disc_name.Text & vbCrLf & "" + _
                          " Discount (%) : " + txt_discount.Text & vbCrLf & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Are You Sure You Want To Save?") = MsgBoxResult.Yes Then
                    disc_query.insert_discount()
                    Me.Close()
                    disc_query.load_discount()
                End If
            End If
        End If
    End Sub

    Function IncompleteInput() As Boolean
        If Me.lbl_no.Text = "" Then
            MsgBox(" Please Reload the form!", MsgBoxStyle.Critical, "Invalid Entry")
            Return True
        ElseIf Me.txt_disc_name.Text = "" Then
            MsgBox(" Please Input the Discount Name!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_disc_name.Focus()
            Return True
        ElseIf Me.txt_discount.Text = "" Then
            MsgBox(" Please Input the Discount (%) !", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_discount.Focus()
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub NumOnly_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_discount.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        ' only allow one decimal point
        If e.KeyChar = "."c AndAlso TryCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
        End If
    End Sub

End Class