Public Class frm_brands_addupdate

    Dim brand_query As New brands_q

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clear_brand()
        Me.Dispose()
    End Sub

    Public Sub clear_brand()
        frm_brandss.lbl_brand_no.Text = ""
        frm_brandss.lbl_brand_name.Text = ""
    End Sub

    Private Sub frm_brand_addupdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frm_brandss.adding = True Then
            clear_form()
            brand_query.get_brand_no()
        Else
            get_update_info()
        End If
    End Sub

    Public Sub clear_form()
        Me.lbl_brand_no.Text = ""
        Me.txt_brand_name.Clear()
    End Sub

    'Retrieve info'
    Public Sub get_update_info()
        Me.lbl_brand_no.Text = frm_brandss.lbl_brand_no.Text
        Me.txt_brand_name.Text = frm_brandss.lbl_brand_name.Text
    End Sub

    Private Sub cmd_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_save.Click
        If frm_brandss.adding = True Then
            If IncompleteInput() = True Then
                Exit Sub
            Else
                If MsgBox(" BRAND INFORMATION " & vbCrLf & _
                          " Brand No : " + lbl_brand_no.Text & vbCrLf & "" + _
                          " Brand Name : " + txt_brand_name.Text & vbCrLf & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Are You Sure You Want To Save?") = MsgBoxResult.Yes Then
                    brand_query.insert_brand()
                    Me.Close()
                    brand_query.load_brand()
                End If
            End If
        Else
            If IncompleteInput() = True Then
                Exit Sub
            Else
                If MsgBox(" BRAND INFORMATION " & vbCrLf & _
                        " Brand No : " + lbl_brand_no.Text & vbCrLf & "" + _
                        " Brand Name : " + txt_brand_name.Text & vbCrLf & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Are You Sure You Want To Update?") = MsgBoxResult.Yes Then
                    brand_query.update_brand()
                    Me.Close()
                    brand_query.load_brand()
                End If
            End If
        End If
    End Sub

    Function IncompleteInput() As Boolean
        If Me.lbl_brand_no.Text = "" Then
            MsgBox(" Please Reload the form!", MsgBoxStyle.Critical, "Invalid Entry")
            Return True
        ElseIf Me.txt_brand_name.Text = "" Then
            MsgBox(" Please Input the Brand Name!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_brand_name.Focus()
            Return True
        Else
            Return False
        End If
    End Function
End Class