Public Class frm_suppliers_add_update

    Dim suppliers_query As New suppliers_q

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clear_suppliers()
        Me.Dispose()
    End Sub

    Public Sub clear_suppliers()
        frm_suppliers.lbl_supplier_no.Text = ""
        frm_suppliers.lbl_supplier_name.Text = ""
        frm_suppliers.lbl_contact_no.Text = ""
        frm_suppliers.lbl_address.Text = ""

        frm_suppliers.dgv_purchase_trans.DataSource = Nothing
        frm_suppliers.dgv_purchase_returns.DataSource = Nothing
    End Sub

    Private Sub frm_suppliers_add_update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frm_suppliers.adding = True Then
            clear_form()
            suppliers_query.get_supplier_no()
        Else
            get_update_info()
        End If
    End Sub

    Public Sub clear_form()
        Me.lbl_supplier_no.Text = ""
        Me.txt_supplier_name.Clear()
        Me.txt_contact_no.Clear()
        Me.txt_address.Clear()
    End Sub

    'Retrieve info'
    Public Sub get_update_info()
        Me.lbl_supplier_no.Text = frm_suppliers.lbl_supplier_no.Text
        Me.txt_supplier_name.Text = frm_suppliers.lbl_supplier_name.Text
        Me.txt_contact_no.Text = frm_suppliers.lbl_contact_no.Text
        Me.txt_address.Text = frm_suppliers.lbl_address.Text
    End Sub

    Private Sub cmd_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_save.Click
        If frm_suppliers.adding = True Then
            If IncompleteInput() = True Then
                Exit Sub
            Else
                If MsgBox(" SUPPLIER INFORMATION " & vbCrLf & _
                          " Supplier No : " + lbl_supplier_no.Text & vbCrLf & "" + _
                          " Supplier Name : " + txt_supplier_name.Text & vbCrLf & "" + _
                          " Contact No. : " + txt_contact_no.Text & vbCrLf & "" + _
                          " Address : " + txt_address.Text & vbCrLf & "" & vbCrLf & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Are You Sure You Want To Save?") = MsgBoxResult.Yes Then
                    suppliers_query.insert_supplier(lbl_supplier_no.Text,txt_supplier_name.Text,txt_contact_no.Text,txt_address.text)
                    Me.Close()
                    suppliers_query.load_suppliers()
                End If
            End If
        Else
            If IncompleteInput() = True Then
                Exit Sub
            Else
                If MsgBox(" SUPPLIER INFORMATION " & vbCrLf & _
                            " Supplier No : " + lbl_supplier_no.Text & vbCrLf & "" + _
                            " Supplier Name : " + txt_supplier_name.Text & vbCrLf & "" + _
                            " Contact No. : " + txt_contact_no.Text & vbCrLf & "" + _
                            " Address : " + txt_address.Text & vbCrLf & "" & vbCrLf & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Are You Sure You Want To Update?") = MsgBoxResult.Yes Then
                    suppliers_query.update_supplier()
                    Me.Close()
                    suppliers_query.load_suppliers()
                End If
            End If
        End If
    End Sub

    Function IncompleteInput() As Boolean
        If Me.lbl_supplier_no.Text = "" Then
            MsgBox(" Please Reload the form!", MsgBoxStyle.Critical, "Invalid Entry")
            Return True
        ElseIf Me.txt_supplier_name.Text = "" Then
            MsgBox(" Please Input the Supplier Name!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_supplier_name.Focus()
            Return True
        ElseIf Me.txt_contact_no.Text = "" Then
            MsgBox(" Please Input the Contact No.!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_contact_no.Focus()
            Return True
        ElseIf Me.txt_address.Text = "" Then
            MsgBox(" Please Input the Address!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_address.Focus()
            Return True
        Else
            Return False
        End If
    End Function

End Class