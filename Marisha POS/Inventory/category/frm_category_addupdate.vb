Public Class frm_category_addupdate

    Dim category_query As New category_q
    Dim inventory_query As New inventory_q

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clear_category()
        Me.Dispose()
    End Sub

    Public Sub clear_category()
        frm_category.lbl_category_no.Text = ""
        frm_category.lbl_category_name.Text = ""
        frm_category.lbl_category_desc.Text = ""
    End Sub

    Private Sub frm_category_addupdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frm_category.adding = True Then
            clear_form()
            category_query.get_category_no()
        Else
            get_update_info()
        End If
    End Sub

    Public Sub clear_form()
        Me.lbl_category_no.Text = ""
        Me.txt_category_name.Clear()
        Me.txt_category_desc.Clear()
    End Sub

    'Retrieve info'
    Public Sub get_update_info()
        Me.lbl_category_no.Text = frm_category.lbl_category_no.Text
        Me.txt_category_name.Text = frm_category.lbl_category_name.Text
        Me.txt_category_desc.Text = frm_category.lbl_category_desc.Text
        Me.txt_oldcat.Text = frm_category.lbl_category_name.Text
    End Sub

    Private Sub cmd_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_save.Click
        If frm_category.adding = True Then
            If IncompleteInput() = True Then
                Exit Sub
            ElseIf category_query.category_exists = True Then
                MsgBox(" Category Already Exists! Please Enter Another One", MsgBoxStyle.Critical, " Incorrect Fields!")
                Me.txt_category_name.Clear()
                Me.txt_category_desc.Focus()
                Exit Sub
            Else
                If MsgBox(" CATEGORY INFORMATION " & vbCrLf & _
                          " Category No : " + lbl_category_no.Text & vbCrLf & "" + _
                          " Category Name : " + txt_category_name.Text & vbCrLf & "" + _
                          " Category Description : " + txt_category_desc.Text & vbCrLf & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Are You Sure You Want To Save?") = MsgBoxResult.Yes Then
                    category_query.insert_category()
                    Me.Close()
                    category_query.load_category()
                End If
            End If
        Else
            If IncompleteInput() = True Then
                Exit Sub
            ElseIf category_same_as_old() = True Then
                If MsgBox(" CATEGORY INFORMATION " & vbCrLf & _
                          " Category No : " + lbl_category_no.Text & vbCrLf & "" + _
                          " Category Name : " + txt_category_name.Text & vbCrLf & "" + _
                          " Category Description : " + txt_category_desc.Text & vbCrLf & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Are You Sure You Want To Update?") = MsgBoxResult.Yes Then
                    category_query.update_category()
                    Me.Close()
                    category_query.load_category()
                End If
            ElseIf category_query.category_exists = True Then
                MsgBox(" Category Already Exists! Please Enter Another One", MsgBoxStyle.Critical, " Incorrect Fields!")
                Me.txt_category_name.Clear()
                Me.txt_category_desc.Focus()
                Exit Sub
            Else
                If MsgBox(" CATEGORY INFORMATION " & vbCrLf & _
                          " Category No : " + lbl_category_no.Text & vbCrLf & "" + _
                          " Category Name : " + txt_category_name.Text & vbCrLf & "" + _
                          " Category Description : " + txt_category_desc.Text & vbCrLf & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Are You Sure You Want To Update?") = MsgBoxResult.Yes Then
                    category_query.update_category()
                    category_query.update_itemlist_category()
                    inventory_query.load_item()
                    Me.Close()
                    category_query.load_category()
                End If
            End If
        End If
    End Sub

    Function IncompleteInput() As Boolean
        If Me.lbl_category_no.Text = "" Then
            MsgBox(" Please Reload the form!", MsgBoxStyle.Critical, "Invalid Entry")
            Return True
        ElseIf Me.txt_category_name.Text = "" Then
            MsgBox(" Please Input the Category Name!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_category_name.Focus()
            Return True
        ElseIf Me.txt_category_desc.Text = "" Then
            MsgBox(" Please Input the Category Description!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_category_desc.Focus()
            Return True
        Else
            Return False
        End If
    End Function

    'Enables Edit of Same Cat'
    Public Function category_same_as_old() As Boolean
        If txt_category_name.Text = txt_oldcat.Text Then
            Return True
        Else
            Return False
        End If
    End Function

End Class