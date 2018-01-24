Public Class frm_customer_add_update

    Dim customers_query As New customers_q

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clear_customers()
        Me.Dispose()
    End Sub

    Public Sub clear_customers()
        frm_customers.lbl_customer_no.Text = ""
        frm_customers.lbl_fname.Text = ""
        frm_customers.lbl_mname.Text = ""
        frm_customers.lbl_lname.Text = ""
        frm_customers.lbl_contact_no.Text = ""
        frm_customers.lbl_address.Text = ""

        frm_customers.dgv_sales_trans.DataSource = Nothing
    End Sub

    Private Sub frm_customer_add_update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frm_customers.adding = True Then
            clear_form()
            customers_query.get_customer_no()
        Else
            get_update_info()
        End If
    End Sub

    Public Sub clear_form()
        Me.lbl_customer_no.Text = ""
        Me.txt_fname.Clear()
        Me.txt_mname.Clear()
        Me.txt_lname.Clear()
        Me.txt_contact_no.Clear()
        Me.txt_address.Clear()
    End Sub

    'Retrieve info'
    Public Sub get_update_info()
        Me.lbl_customer_no.Text = frm_customers.lbl_customer_no.Text
        Me.txt_fname.Text = frm_customers.lbl_fname.Text
        Me.txt_mname.Text = frm_customers.lbl_mname.Text
        Me.txt_lname.Text = frm_customers.lbl_lname.Text
        Me.txt_contact_no.Text = frm_customers.lbl_contact_no.Text
        Me.txt_address.Text = frm_customers.lbl_address.Text
    End Sub

    Private Sub cmd_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_save.Click
        If frm_customers.adding = True Then
            If IncompleteInput() = True Then
                Exit Sub
            Else
                If MsgBox(" CUSTOMER INFORMATION " & vbCrLf & _
                          " Customer No : " + lbl_customer_no.Text & vbCrLf & "" + _
                          " First Name : " + txt_fname.Text & vbCrLf & "" + _
                          " Middle Name : " + txt_mname.Text & vbCrLf & "" + _
                          " Last Name : " + txt_lname.Text & vbCrLf & "" + _
                          " Contact No. : " + txt_contact_no.Text & vbCrLf & "" + _
                          " Address : " + txt_address.Text & vbCrLf & "" & vbCrLf & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Are You Sure You Want To Save?") = MsgBoxResult.Yes Then
                    customers_query.insert_customer()
                    customers_query.insert_pay_sysgen()
                    Me.Close()
                    customers_query.load_customers()
                End If
            End If
        Else
            If IncompleteInput() = True Then
                Exit Sub
            Else
                If MsgBox(" CUSTOMER INFORMATION " & vbCrLf & _
                          " Customer No : " + lbl_customer_no.Text & vbCrLf & "" + _
                          " First Name : " + txt_fname.Text & vbCrLf & "" + _
                          " Middle Name : " + txt_mname.Text & vbCrLf & "" + _
                          " Last Name : " + txt_lname.Text & vbCrLf & "" + _
                          " Contact No. : " + txt_contact_no.Text & vbCrLf & "" + _
                          " Address : " + txt_address.Text & vbCrLf & "" & vbCrLf & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Are You Sure You Want To Update?") = MsgBoxResult.Yes Then
                    customers_query.update_customers()
                    Me.Close()
                    customers_query.load_customers()
                End If
            End If
        End If
    End Sub

    Function IncompleteInput() As Boolean
        If Me.lbl_customer_no.Text = "" Then
            MsgBox(" Please Reload the form!", MsgBoxStyle.Critical, "Invalid Entry")
            Return True
        ElseIf Me.txt_fname.Text = "" Then
            MsgBox(" Please Input the First Name!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_fname.Focus()
            Return True
        ElseIf Me.txt_mname.Text = "" Then
            MsgBox(" Please Input the Middle Name!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_mname.Focus()
            Return True
        ElseIf Me.txt_lname.Text = "" Then
            MsgBox(" Please Input the Last Name!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_lname.Focus()
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

    Private Sub noenter_numbers_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txt_fname.KeyPress, txt_mname.KeyPress, txt_lname.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
            And Not e.KeyChar = Chr(Keys.Delete) _
            And Not e.KeyChar = Chr(Keys.Back) _
            And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

End Class