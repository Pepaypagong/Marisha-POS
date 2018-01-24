Public Class frm_useracc_add_update

    Dim accounts_query As New accounts

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clear_accounts()
        Me.Dispose()
    End Sub

    Public Sub clear_accounts()
        frm_accounts.pic.Image = Nothing
        frm_accounts.lbl_account_no.Text = ""
        frm_accounts.lbl_username.Text = ""
        frm_accounts.lbl_password.Text = ""
        frm_accounts.lbl_position.Text = ""
        frm_accounts.lbl_fname.Text = ""
        frm_accounts.lbl_mname.Text = ""
        frm_accounts.lbl_lname.Text = ""
        frm_accounts.cb_pos_sales_trans.Checked = False
        frm_accounts.cb_pos_receipt.Checked = False
        frm_accounts.cb_inv_category.Checked = False
        frm_accounts.cb_inv_brands.Checked = False
        frm_accounts.cb_inv_add_item.Checked = False
        frm_accounts.cb_inv_updt_item.Checked = False
        frm_accounts.cb_inv_add_stocks.Checked = False
        frm_accounts.cb_inv_pur_ret.Checked = False
        frm_accounts.cb_inv_report_inv.Checked = False
        frm_accounts.cb_inv_report_pur.Checked = False
        frm_accounts.cb_inv_report_sales.Checked = False
        frm_accounts.cb_sales_report_dailyremit.Checked = False
        frm_accounts.cb_sales_report_incstate.Checked = False
        frm_accounts.cb_cust_add_cust.Checked = False
        frm_accounts.cb_cust_updt_cust.Checked = False
        frm_accounts.cb_cust_balpay.Checked = False
        frm_accounts.cb_cust_report_arpay.Checked = False
        frm_accounts.cb_cust_cash_trans.Checked = False
        frm_accounts.cb_cust_sales_ret.Checked = False
        frm_accounts.cb_cust_bo.Checked = False
        frm_accounts.cb_supp_add_supp.Checked = False
        frm_accounts.cb_supp_updt_supp.Checked = False
    End Sub

    Private Sub frm_useracc_add_update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frm_accounts.adding = True Then
            clear_form()
            accounts_query.get_account_no()
        Else
            accounts_query.retrieve_pic()
            get_update_info()
        End If
    End Sub

    Public Sub clear_form()
        Me.pic.Image = Nothing
        Me.lbl_account_no.Text = ""
        Me.txt_username.Clear()
        Me.txt_password.Clear()
        Me.txt_position.Clear()
        Me.txt_fname.Clear()
        Me.txt_mname.Clear()
        Me.txt_lname.Clear()
        Me.cb_pos_sales_trans.Checked = False
        Me.cb_pos_receipt.Checked = False
        Me.cb_inv_category.Checked = False
        Me.cb_inv_brands.Checked = False
        Me.cb_inv_add_item.Checked = False
        Me.cb_inv_updt_item.Checked = False
        Me.cb_inv_add_stocks.Checked = False
        Me.cb_inv_pur_ret.Checked = False
        Me.cb_inv_report_inv.Checked = False
        Me.cb_inv_report_pur.Checked = False
        Me.cb_inv_report_sales.Checked = False
        Me.cb_sales_report_dailyremit.Checked = False
        Me.cb_sales_report_incstate.Checked = False
        Me.cb_cust_add_cust.Checked = False
        Me.cb_cust_updt_cust.Checked = False
        Me.cb_cust_balpay.Checked = False
        Me.cb_cust_report_arpay.Checked = False
        Me.cb_cust_cash_trans.Checked = False
        Me.cb_cust_sales_ret.Checked = False
        Me.cb_cust_bo.Checked = False
        Me.cb_supp_add_supp.Checked = False
        Me.cb_supp_updt_supp.Checked = False
    End Sub

    Public imgName As String
    Sub uploadimage()
        Try
            Dim dlgImage As FileDialog = New OpenFileDialog()

            dlgImage.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"

            If dlgImage.ShowDialog() = DialogResult.OK Then
                imgName = dlgImage.FileName

                Dim newimg As New Bitmap(imgName)

                pic.SizeMode = PictureBoxSizeMode.StretchImage
                pic.Image = DirectCast(newimg, Image)
            End If

            dlgImage = Nothing
        Catch ae As System.ArgumentException
            imgName = " "

            MessageBox.Show(ae.Message.ToString())
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub cmd_loadpic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_loadpic.Click
        uploadimage()
    End Sub

    'Retrieve info'
    Public Sub get_update_info()
        Me.lbl_account_no.Text = frm_accounts.lbl_account_no.Text
        Me.txt_username.Text = frm_accounts.lbl_username.Text
        Me.txt_old_username.Text = frm_accounts.lbl_username.Text
        Me.txt_password.Text = frm_accounts.lbl_password.Text
        Me.txt_position.Text = frm_accounts.lbl_position.Text
        Me.txt_fname.Text = frm_accounts.lbl_fname.Text
        Me.txt_mname.Text = frm_accounts.lbl_mname.Text
        Me.txt_lname.Text = frm_accounts.lbl_lname.Text

        'POS'
        If frm_accounts.cb_pos_sales_trans.Checked = True Then
            cb_pos_sales_trans.Checked = True
        Else
            cb_pos_sales_trans.Checked = False
        End If
        If frm_accounts.cb_pos_receipt.Checked = True Then
            cb_pos_receipt.Checked = True
        Else
            cb_pos_receipt.Checked = False
        End If

        'INV'
        If frm_accounts.cb_inv_category.Checked = True Then
            cb_inv_category.Checked = True
        Else
            cb_inv_category.Checked = False
        End If
        If frm_accounts.cb_inv_brands.Checked = True Then
            cb_inv_brands.Checked = True
        Else
            cb_inv_brands.Checked = False
        End If
        If frm_accounts.cb_inv_add_item.Checked = True Then
            cb_inv_add_item.Checked = True
        Else
            cb_inv_add_item.Checked = False
        End If
        If frm_accounts.cb_inv_updt_item.Checked = True Then
            cb_inv_updt_item.Checked = True
        Else
            cb_inv_updt_item.Checked = False
        End If
        If frm_accounts.cb_inv_add_stocks.Checked = True Then
            cb_inv_add_stocks.Checked = True
        Else
            cb_inv_add_stocks.Checked = False
        End If
        If frm_accounts.cb_inv_pur_ret.Checked = True Then
            cb_inv_pur_ret.Checked = True
        Else
            cb_inv_pur_ret.Checked = False
        End If
        If frm_accounts.cb_inv_report_inv.Checked = True Then
            cb_inv_report_inv.Checked = True
        Else
            cb_inv_report_inv.Checked = False
        End If
        If frm_accounts.cb_inv_report_pur.Checked = True Then
            cb_inv_report_pur.Checked = True
        Else
            cb_inv_report_pur.Checked = False
        End If
        If frm_accounts.cb_inv_report_sales.Checked = True Then
            cb_inv_report_sales.Checked = True
        Else
            cb_inv_report_sales.Checked = False
        End If

        'Sales'
        If frm_accounts.cb_sales_report_dailyremit.Checked = True Then
            cb_sales_report_dailyremit.Checked = True
        Else
            cb_sales_report_dailyremit.Checked = False
        End If
        If frm_accounts.cb_sales_report_incstate.Checked = True Then
            cb_sales_report_incstate.Checked = True
        Else
            cb_sales_report_incstate.Checked = False
        End If

        'Customer'
        If frm_accounts.cb_cust_add_cust.Checked = True Then
            cb_cust_add_cust.Checked = True
        Else
            cb_cust_add_cust.Checked = False
        End If
        If frm_accounts.cb_cust_updt_cust.Checked = True Then
            cb_cust_updt_cust.Checked = True
        Else
            cb_cust_updt_cust.Checked = False
        End If
        If frm_accounts.cb_cust_balpay.Checked = True Then
            cb_cust_balpay.Checked = True
        Else
            cb_cust_balpay.Checked = False
        End If
        If frm_accounts.cb_cust_report_arpay.Checked = True Then
            cb_cust_report_arpay.Checked = True
        Else
            cb_cust_report_arpay.Checked = False
        End If
        If frm_accounts.cb_cust_cash_trans.Checked = True Then
            cb_cust_cash_trans.Checked = True
        Else
            cb_cust_cash_trans.Checked = False
        End If
        If frm_accounts.cb_cust_sales_ret.Checked = True Then
            cb_cust_sales_ret.Checked = True
        Else
            cb_cust_sales_ret.Checked = False
        End If
        If frm_accounts.cb_cust_bo.Checked = True Then
            cb_cust_bo.Checked = True
        Else
            cb_cust_bo.Checked = False
        End If

        'Supplier'
        If frm_accounts.cb_supp_add_supp.Checked = True Then
            cb_supp_add_supp.Checked = True
        Else
            cb_supp_add_supp.Checked = False
        End If
        If frm_accounts.cb_supp_updt_supp.Checked = True Then
            cb_supp_updt_supp.Checked = True
        Else
            cb_supp_updt_supp.Checked = False
        End If
    End Sub

    'account access cb values'
    Dim pos_sales_trans, pos_receipt, inv_category, inv_brands, inv_add_item, inv_updt_item, inv_add_stocks, _
        inv_purchase_return, inv_report_inv, inv_report_pur, inv_report_sales, sales_report_remit, sales_report_incstate, _
        cust_add_cust, cust_updt_cust, cust_balpay, cust_report_acc_receive, cust_cash_trans, cust_return_trans, cust_bo_trans, _
        supp_add_supp, supp_updt_supp As String

    Public Sub account_access()
        'POS
        If Me.cb_pos_sales_trans.Checked = True Then
            pos_sales_trans = "YES"
        Else
            pos_sales_trans = "NO"
        End If

        If Me.cb_pos_receipt.Checked = True Then
            pos_receipt = "YES"
        Else
            pos_receipt = "NO"
        End If

        'INVENTORY
        If Me.cb_inv_category.Checked = True Then
            inv_category = "YES"
        Else
            inv_category = "NO"
        End If

        If Me.cb_inv_brands.Checked = True Then
            inv_brands = "YES"
        Else
            inv_brands = "NO"
        End If

        If Me.cb_inv_add_item.Checked = True Then
            inv_add_item = "YES"
        Else
            inv_add_item = "NO"
        End If

        If Me.cb_inv_updt_item.Checked = True Then
            inv_updt_item = "YES"
        Else
            inv_updt_item = "NO"
        End If

        If Me.cb_inv_add_stocks.Checked = True Then
            inv_add_stocks = "YES"
        Else
            inv_add_stocks = "NO"
        End If

        If Me.cb_inv_pur_ret.Checked = True Then
            inv_purchase_return = "YES"
        Else
            inv_purchase_return = "NO"
        End If

        If Me.cb_inv_report_inv.Checked = True Then
            inv_report_inv = "YES"
        Else
            inv_report_inv = "NO"
        End If

        If Me.cb_inv_report_pur.Checked = True Then
            inv_report_pur = "YES"
        Else
            inv_report_pur = "NO"
        End If

        If Me.cb_inv_report_sales.Checked = True Then
            inv_report_sales = "YES"
        Else
            inv_report_sales = "NO"
        End If

        'SALES'
        If Me.cb_sales_report_dailyremit.Checked = True Then
            sales_report_remit = "YES"
        Else
            sales_report_remit = "NO"
        End If

        If Me.cb_sales_report_incstate.Checked = True Then
            sales_report_incstate = "YES"
        Else
            sales_report_incstate = "NO"
        End If

        'Customer'
        If Me.cb_cust_add_cust.Checked = True Then
            cust_add_cust = "YES"
        Else
            cust_add_cust = "NO"
        End If

        If Me.cb_cust_updt_cust.Checked = True Then
            cust_updt_cust = "YES"
        Else
            cust_updt_cust = "NO"
        End If

        If Me.cb_cust_balpay.Checked = True Then
            cust_balpay = "YES"
        Else
            cust_balpay = "NO"
        End If

        If Me.cb_cust_report_arpay.Checked = True Then
            cust_report_acc_receive = "YES"
        Else
            cust_report_acc_receive = "NO"
        End If

        If Me.cb_cust_cash_trans.Checked = True Then
            cust_cash_trans = "YES"
        Else
            cust_cash_trans = "NO"
        End If

        If Me.cb_cust_sales_ret.Checked = True Then
            cust_return_trans = "YES"
        Else
            cust_return_trans = "NO"
        End If

        If Me.cb_cust_bo.Checked = True Then
            cust_bo_trans = "YES"
        Else
            cust_bo_trans = "NO"
        End If

        'Suppliers'
        If Me.cb_supp_add_supp.Checked = True Then
            supp_add_supp = "YES"
        Else
            supp_add_supp = "NO"
        End If

        If Me.cb_supp_updt_supp.Checked = True Then
            supp_updt_supp = "YES"
        Else
            supp_updt_supp = "NO"
        End If
    End Sub

    Private Sub cmd_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_save.Click
        If frm_accounts.adding = True Then
            If IncompleteInput() = True Then
                Exit Sub
            ElseIf accounts_query.username_exists = True Then
                MsgBox(" Username Already Exists! Please Enter Another One", MsgBoxStyle.Critical, " Incorrect Fields!")
                Me.txt_username.Clear()
                Me.txt_username.Focus()
                Exit Sub
            Else
                account_access()
                If MsgBox(" ACCOUNT INFORMATION " & vbCrLf & _
                          " Account No : " + lbl_account_no.Text & vbCrLf & "" + _
                          " Username : " + txt_username.Text & vbCrLf & "" + _
                          " Password : " + txt_password.Text & vbCrLf & "" + _
                          " Position : " + txt_position.Text & vbCrLf & "" + _
                          " First Name : " + txt_fname.Text & vbCrLf & "" + _
                          " Middle Name : " + txt_mname.Text & vbCrLf & "" + _
                          " Last Name : " + txt_lname.Text & vbCrLf & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Are You Sure You Want To Save?") = MsgBoxResult.Yes Then
                    accounts_query.insert_account()
                    Me.Close()
                    accounts_query.load_accounts()
                End If
            End If
        Else
            If IncompleteInput() = True Then
                Exit Sub
            ElseIf username_same_as_old() = True Then
                account_access()
                If MsgBox(" ACCOUNT INFORMATION " & vbCrLf & _
                          " Account No : " + lbl_account_no.Text & vbCrLf & "" + _
                          " Username : " + txt_username.Text & vbCrLf & "" + _
                          " Password : " + txt_password.Text & vbCrLf & "" + _
                          " Position : " + txt_position.Text & vbCrLf & "" + _
                          " First Name : " + txt_fname.Text & vbCrLf & "" + _
                          " Middle Name : " + txt_mname.Text & vbCrLf & "" + _
                          " Last Name : " + txt_lname.Text & vbCrLf & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Are You Sure You Want To Update?") = MsgBoxResult.Yes Then
                    accounts_query.update_account()
                    Me.Close()
                    accounts_query.load_accounts()
                End If
            ElseIf accounts_query.username_exists = True Then
                MsgBox(" This Username Already Exists! Please Input Another One!", MsgBoxStyle.Critical, " Invalid Entry")
                txt_username.Clear()
                txt_username.Focus()
                Exit Sub
            Else
                account_access()
                If MsgBox(" ACCOUNT INFORMATION " & vbCrLf & _
                          " Account No : " + lbl_account_no.Text & vbCrLf & "" + _
                          " Username : " + txt_username.Text & vbCrLf & "" + _
                          " Password : " + txt_password.Text & vbCrLf & "" + _
                          " Position : " + txt_position.Text & vbCrLf & "" + _
                          " First Name : " + txt_fname.Text & vbCrLf & "" + _
                          " Middle Name : " + txt_mname.Text & vbCrLf & "" + _
                          " Last Name : " + txt_lname.Text & vbCrLf & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Are You Sure You Want To Update?") = MsgBoxResult.Yes Then
                    accounts_query.update_account()
                    Me.Close()
                    accounts_query.load_accounts()
                End If
            End If
        End If
    End Sub

    Function IncompleteInput() As Boolean
        If Me.lbl_account_no.Text = "" Then
            MsgBox(" Please Reload the form!", MsgBoxStyle.Critical, "Invalid Entry")
            Return True
        ElseIf Me.pic.Image Is Nothing Then
            MsgBox(" Please Put a picture!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.cmd_loadpic.Focus()
            Return True
        ElseIf Me.txt_username.Text = "" Then
            MsgBox(" Please Input the Username!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_username.Focus()
            Return True
        ElseIf Me.txt_password.Text = "" Then
            MsgBox(" Please Input the Password!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_password.Focus()
            Return True
        ElseIf Me.txt_position.Text = "" Then
            MsgBox(" Please Input the Position!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_position.Focus()
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
        Else
            Return False
        End If
    End Function


    'Enables Edit of Same Username'
    Public Function username_same_as_old() As Boolean
        If txt_username.Text = txt_old_username.Text Then
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

    Private Sub txt_username_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_username.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub

End Class