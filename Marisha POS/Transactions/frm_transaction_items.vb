﻿Public Class frm_transaction_items

    'trans type = [cash sales, customer sales, sales return, purchase, purchase return, reject]
    'trans type del = [del cash sales,del customer sales, del sales return, del purchase, del purchase return,del reject]

    Private SQL As New SQLControl
    Private transItemService As New transactionItemService
    Private transService As New transactionsService
    Public mTransactionTypeItem As String = "cash trans"
    Public mode As String = "view"

    Public m_item_no As Integer
    Public m_item_name As String = ""
    Public m_qty As Decimal
    Public m_barcode As String = ""
    Public m_selling_price As Decimal
    Public m_buying_price As Decimal
    Public m_unit As String = ""
    Public m_category As String = ""

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub frm_transaction_items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
        dtp_date.CustomFormat = " MMMM dd,  yyyy"
        lbl_title.Text = GetTitle()
        SetControls()
        SetTotalsControls()
        SetDiscountGridAndButtons(mTransactionTypeItem)

        If mode = "view" Or mode = "delete" Then
            transItemService.GetViewData(mTransactionTypeItem, frm_transactions.selectedTransId)
            transItemService.GetItems(mTransactionTypeItem, frm_transactions.selectedTransId, dgv_items)
        Else 'new
            lbl_trans_no.Text = SQL.GenerateTransactionNumber(mTransactionTypeItem)
        End If

        GetItemTotalAmounts()

    End Sub

    Private Sub cmd_save_Click(sender As Object, e As EventArgs) Handles cmd_save.Click
        If mode = "new" Then

        ElseIf mode = "delete" Then
            transItemService.DeleteHeader(frm_transactions.selectedTransId, mTransactionTypeItem)
            transItemService.DeleteItems(frm_transactions.selectedTransId, mTransactionTypeItem)
            Me.Close()
            MsgBox(refresh_grid(mTransactionTypeItem), MsgBoxStyle.Information)
        End If
    End Sub

    Private Function refresh_grid(refresh_trans_type As String) As String
        Dim message = " transaction successfully deleted!"

        Select Case refresh_trans_type

            Case "del cash sales"
                message = "Cash sales" + message
                frm_transactions.cmd_sales.PerformClick()
            Case "del customer sales"
                message = "Customer sales" + message
                frm_transactions.cmd_sales.PerformClick()
                frm_transactions.cbo_sales_type.SelectedIndex = 1
            Case "del sales return"
                message = "Sales return" + message
                frm_transactions.cmd_sales_return.PerformClick()
            Case "del purchase"
                message = "Purchase" + message
                frm_transactions.cmd_purchases.PerformClick()
            Case "del purchase return"
                message = "Purchase return" + message
                frm_transactions.cmd_purchase_returns.PerformClick()
            Case "del reject"
                message = "Reject" + message
                frm_transactions.cmd_rejects.PerformClick()
        End Select

        Return message
    End Function

    Private Sub cmd_cancel_Click(sender As Object, e As EventArgs) Handles cmd_cancel.Click
        Me.Close()
    End Sub

    Private Sub shortcut_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            cmd_cancel.PerformClick()
        End If
    End Sub

    Sub GetItemTotalAmounts()

        Dim sub_total As Decimal = 0
        Dim item_count As Decimal = 0
        Dim discount As Decimal = 0

        For index As Integer = 0 To dgv_items.RowCount - 1
            sub_total += Convert.ToDecimal(dgv_items.Rows(index).Cells(3).Value * dgv_items.Rows(index).Cells(5).Value)

            'If dgv_items.Rows(index).Cells(4).Value.ToString = "PCS" Then
            '    item_count += Convert.ToDecimal(dgv_items.Rows(index).Cells(3).Value)
            'End If

            discount += Convert.ToDecimal(dgv_items.Rows(index).Cells(6).Value)
        Next

        Dim grand_total As Decimal = sub_total - discount

        lbl_total_discount.Text = discount.ToString("0.00")
        lbl_sub_total.Text = sub_total.ToString("0.00")
        lbl_grand_total.Text = grand_total.ToString("0.00")
    End Sub
    Public Sub SetTotalsControls()
        Select Case mTransactionTypeItem

            Case "new sales return", "sales return", "del sales return",
                 "new purchase return", "purchase return", "del purchase return",
                 "new reject", "reject", "del reject"

                lbl_total_discount_label.Visible = False
                lbl_total_discount.Visible = False
                lbl_grand_total_label.Visible = False
                lbl_grand_total.Visible = False
                lbl_sub_total_label.Text = "Grand Total:"
        End Select
    End Sub

    Public Sub DisableControls()
        'For Each ctl As Control In Controls
        '    ctl.Enabled = False
        'Next
        txt_ref_no.Enabled = False
        dtp_date.Enabled = False
        txt_remarks.Enabled = False

        txt_barcode.Enabled = False

        cmd_apply_disc.Visible = False
        cmd_add_item.Visible = False
        cmd_remove_item.Visible = False
        cmd_change_qty.Visible = False
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
            cmd_change_qty.Visible = True

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
    Public Sub SetDiscountGridAndButtons(trans_type As String)

        Select Case trans_type
            Case "cash sales","new cash sales","del cash sales",
                 "customer sales","new customer sales","del customer sales",
                 "purchase","new purchase","del purchase"
                dgv_items.Columns(6).Visible = True
                cmd_apply_disc.Visible = True
                Select Case trans_type
                    Case "cash sales","customer sales","purchase","del cash sales",
                         "del customer sales","del purchase"
                        cmd_apply_disc.Visible = False
                End Select
            Case "sales return","new sales return","del sales return",
                 "purchase return","new purchase return","del purchase return",
                 "reject","new reject","del reject"
                dgv_items.Columns(6).Visible = False
                cmd_apply_disc.Visible = False
        End Select

    End Sub

    Private Sub txt_barcode_TextChanged(sender As Object, e As EventArgs) Handles txt_barcode.TextChanged
        Dim barcodeText = txt_barcode.Text.Replace("'", "''")
        'If txt_barcode.Text = "" Then
        '    lbl_barcode_status.Text = "...."
        'End If

        If transItemService.BarcodeFound(barcodeText) Then
            lbl_barcode_status.Text = " Item Found!"
            transItemService.PutItemToVariables(barcodeText)
            'check if exists then find item +1
            Dim exists As Boolean = False
            For Each itm As DataGridViewRow In dgv_items.Rows
                If itm.Cells(0).Value = m_item_no Then
                    exists = True
                    itm.Cells(3).Value += 1 'qty col
                    itm.Cells(7).Value = Format(CDec(itm.Cells(3).Value * itm.Cells(5).Value), "0.00") '+1 instance of price to the total amt
                End If
            Next

            If exists = False Then
                transItemService.add_to_cart(mTransactionTypeItem, m_item_no, m_barcode, m_item_name, m_selling_price, m_qty, m_unit, m_selling_price, m_buying_price,
                                      0.00, m_category, dgv_items)
            End If

            GetItemTotalAmounts()
            txt_barcode.Clear()
        Else
            If txt_barcode.Text <> "" Then
                lbl_barcode_status.Text = "No Match Found ...."
            End If    
        End If
        
        ClearItemVariables()
    End Sub

    Public Sub ClearItemVariables()
        m_item_no = vbNull
        m_barcode = vbNull
        m_item_name = vbNull
        m_qty = vbNull
        m_selling_price = vbNull
        m_buying_price = vbNull
        m_unit = vbNull
        m_category = vbNull
    End Sub

End Class