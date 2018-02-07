Public Class frm_transaction_items

    'trans type = [cash sales, customer sales, sales return, purchase, purchase return, reject]
    'trans type del = [del cash sales,del customer sales, del sales return, del purchase, del purchase return,del reject]

    Private SQL As New SQLControl
    Private transItemService As New transactionItemService
    Public mTransactionTypeItem As String = "cash trans"
    Public mode As String = "view"

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub frm_transaction_items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
        dtp_date.CustomFormat = " MMMM dd,  yyyy"
        lbl_title.Text = GetTitle()
        SetControls()

        If mode = "view"
            transItemService.GetViewData(mTransactionTypeItem,frm_transactions.selectedTransId)
            transItemService.GetItems(mTransactionTypeItem,frm_transactions.selectedTransId)
        End If
        
    End Sub

    Private Sub dgv_items_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_items.CellContentClick

    End Sub

    Private Sub cmd_view_Click(sender As Object, e As EventArgs) Handles cmd_save.Click

    End Sub

    Private Sub cmd_cancel_Click(sender As Object, e As EventArgs) Handles cmd_cancel.Click
        Me.Close()
    End Sub

    Private Sub shortcut_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            cmd_cancel.PerformClick()
        End If
    End Sub

    Public Sub DisableControls()
        For Each ctl As Control In Controls
            ctl.Enabled = False
        Next
        cmd_cancel.Enabled = True
        cmd_save.Enabled = True
        lbl_title.Enabled = True
    End Sub
    Public Sub SetControls()
        If mode = "view" Then
            cmd_save.Visible = False

            If mTransactionTypeItem = "cash sales" _
                Or mTransactionTypeItem = "reject" Or mTransactionTypeItem = "sales return" Then

                cmd_select_supplier.Visible = False
                lbl_supplier.Visible = False
                lbl_supplier_name.Visible = False

                lbl_ref_no.Location = New Point(15, 88)
                lbl_ref_no.Text = "Receipt No. :"

                txt_ref_no.Location = New Point(144, 85)

                dtp_date.Location = New Point(144, 117)
                lbl_dtp.Location = New Point(15, 119)

            ElseIf mTransactionTypeItem = "customer sales" Then

                cmd_select_supplier.Visible = False
                lbl_supplier.Visible = True
                lbl_supplier_name.Visible = True

                lbl_supplier.Location = New Point(15, 88)
                lbl_supplier.Text = "Customer :"

                lbl_supplier_name.Location = New Point(144, 85)

                lbl_ref_no.Location = New Point(15, 119)
                lbl_ref_no.Text = "Receipt No. :"

                txt_ref_no.Location = New Point(144, 117)

                dtp_date.Location = New Point(144, 148)
                lbl_dtp.Location = New Point(15, 153)

            ElseIf mTransactionTypeItem = "purchase" _
                Or mTransactionTypeItem = "purchase return" Then

                cmd_select_supplier.Visible = False
                lbl_supplier.Visible = True
                lbl_supplier_name.Visible = True

                lbl_supplier.Location = New Point(15, 88)
                lbl_supplier.Text = "Supplier :"

                lbl_supplier_name.Location = New Point(144, 85)

                lbl_ref_no.Location = New Point(15, 119)
                lbl_ref_no.Text = "Reference No. :"

                txt_ref_no.Location = New Point(144, 117)

                dtp_date.Location = New Point(144, 148)
                lbl_dtp.Location = New Point(15, 153)

            End If

            DisableControls()

        ElseIf mode = "new" Then

            cmd_save.Visible = True
            cmd_save.Text = "SAVE"
            cmd_save.Location = New Point(1050, 7)
            cmd_save.Size = New Point(114, 27)
            cmd_add_item.Visible = True
            cmd_remove_item.Visible = True

            If mTransactionTypeItem = "new sales return" Or
               mTransactionTypeItem = "new reject" Then

                lbl_supplier.Visible = False
                lbl_supplier_name.Visible = False
                cmd_select_supplier.Visible = False

                lbl_ref_no.Location = New Point(15, 88)
                lbl_ref_no.Text = "Receipt No. :"

                txt_ref_no.Location = New Point(144, 85)

                dtp_date.Location = New Point(144, 117)
                lbl_dtp.Location = New Point(15, 119)

            ElseIf mTransactionTypeItem = "purchase" _
                Or mTransactionTypeItem = "purchase return" Then

                cmd_select_supplier.Visible = True
                lbl_supplier.Visible = True
                lbl_supplier_name.Visible = True

                lbl_supplier.Location = New Point(15, 88)
                lbl_supplier.Text = "Supplier :"

                lbl_supplier_name.Location = New Point(144, 85)

                lbl_ref_no.Location = New Point(15, 119)
                lbl_ref_no.Text = "Reference No. :"

                txt_ref_no.Location = New Point(144, 117)

                dtp_date.Location = New Point(144, 148)
                lbl_dtp.Location = New Point(15, 153)

            End If

        ElseIf mode = "delete" Then
            cmd_save.Visible = True
            cmd_save.Text = "CONFIRM DELETE"

            cmd_save.Location = New Point(995, 7)
            cmd_save.Size = New Point(169, 27)

            If mTransactionTypeItem = "del cash sales" _
                Or mTransactionTypeItem = "del reject" Or mTransactionTypeItem = "del sales return" Then

                cmd_select_supplier.Visible = False
                lbl_supplier.Visible = False
                lbl_supplier_name.Visible = False

                lbl_ref_no.Location = New Point(15, 88)
                lbl_ref_no.Text = "Receipt No. :"

                txt_ref_no.Location = New Point(144, 85)

                dtp_date.Location = New Point(144, 117)
                lbl_dtp.Location = New Point(15, 119)

            ElseIf mTransactionTypeItem = "del customer sales" Then

                cmd_select_supplier.Visible = False
                lbl_supplier.Visible = True
                lbl_supplier_name.Visible = True

                lbl_supplier.Location = New Point(15, 88)
                lbl_supplier.Text = "Customer :"

                lbl_supplier_name.Location = New Point(144, 85)

                lbl_ref_no.Location = New Point(15, 119)
                lbl_ref_no.Text = "Receipt No. :"

                txt_ref_no.Location = New Point(144, 117)

                dtp_date.Location = New Point(144, 148)
                lbl_dtp.Location = New Point(15, 153)

            ElseIf mTransactionTypeItem = "del purchase" _
                Or mTransactionTypeItem = "del purchase return" Then

                cmd_select_supplier.Visible = False
                lbl_supplier.Visible = True
                lbl_supplier_name.Visible = True

                lbl_supplier.Location = New Point(15, 88)
                lbl_supplier.Text = "Supplier :"

                lbl_supplier_name.Location = New Point(144, 85)

                lbl_ref_no.Location = New Point(15, 119)
                lbl_ref_no.Text = "Reference No. :"

                txt_ref_no.Location = New Point(144, 117)

                dtp_date.Location = New Point(144, 148)
                lbl_dtp.Location = New Point(15, 153)

            End If

            DisableControls()
        End If
    End Sub
    Function GetTitle() As String

        Dim ret_string = ""

        'view'
        If mTransactionTypeItem = "cash sales" Then
            ret_string = "  Cash Transaction Details"
        ElseIf mTransactionTypeItem = "customer sales" Then
            ret_string = "  On-Account Transaction Details"
        ElseIf mTransactionTypeItem = "sales return" Then
            ret_string = "  Sales Return Transaction Details"
        ElseIf mTransactionTypeItem = "purchase" Then
            ret_string = "  Purchase Transaction Details"
        ElseIf mTransactionTypeItem = "purchase return" Then
            ret_string = "  Purchase Return Transaction Details"
        ElseIf mTransactionTypeItem = "reject" Then
            ret_string = "  Rejects Transaction Details"
            'new'
        ElseIf mTransactionTypeItem = "new cash sales" Then
            ret_string = "  New Cash Transaction"
        ElseIf mTransactionTypeItem = "new customer sales" Then
            ret_string = "  New On-Account Transaction "
        ElseIf mTransactionTypeItem = "new sales return" Then
            ret_string = "  New Sales Return Transaction "
        ElseIf mTransactionTypeItem = "new purchase" Then
            ret_string = "  New Purchase Transaction "
        ElseIf mTransactionTypeItem = "new purchase return" Then
            ret_string = "  New Purchase Return Transaction "
        ElseIf mTransactionTypeItem = "new reject" Then
            ret_string = "  New Rejects Transaction "
            'delete'
        ElseIf mTransactionTypeItem = "del cash sales" Then
            ret_string = "  Delete Cash Transaction"
        ElseIf mTransactionTypeItem = "del customer sales" Then
            ret_string = "  Delete On-Account Transaction"
        ElseIf mTransactionTypeItem = "del sales return" Then
            ret_string = "  Delete Sales Return Transaction"
        ElseIf mTransactionTypeItem = "del purchase" Then
            ret_string = "  Delete Purchase Transaction"
        ElseIf mTransactionTypeItem = "del purchase return" Then
            ret_string = "  Delete Purchase Return Transaction"
        ElseIf mTransactionTypeItem = "del reject" Then
            ret_string = "  Delete Rejects Transaction"
        End If

        Return ret_string

    End Function

End Class