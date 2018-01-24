Public Class frm_stock_add_update

    Dim inventory_query As New inventory_q

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frm_stock_add_update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load items to combo boxes'
        With Me.cbo_unit
            .Items.Add("PCS")
            .Items.Add("KGS")
        End With
        With Me.cbo_avail
            .Items.Add("Available")
            .Items.Add("Out of Stock")
        End With
        inventory_query.show_categories()
        inventory_query.show_brands()

        If frm_inventory.adding = True Then
            clear_form()
            inventory_query.get_item_no()
            lalbelqty.Text = "Initial Qty. :"
        Else
            get_update_info()
            txt_initial_qty.Enabled = False
            lalbelqty.Text = "Stock Qty. :"
        End If
        
    End Sub

    Public Sub clear_form()
        Me.lbl_item_no.Text = ""
        Me.txt_barcode.Clear()
        Me.txt_item_name.Clear()
        Me.txt_selling_price.Clear()
        Me.txt_buying_price.Clear()
        Me.txt_initial_qty.Clear()
        Me.cbo_avail.SelectedIndex = 0
        Me.cbo_unit.SelectedIndex = 0
        Me.txt_desc.Clear()
        Me.cbo_category.SelectedIndex = 0
        Me.cbo_brand.SelectedIndex = 0
    End Sub

    'Retrieve info'
    Public Sub get_update_info()
        Me.lbl_item_no.Text = frm_inventory.m_item_no
        Me.txt_barcode.Text = frm_inventory.m_barcode
        Me.txt_old_barcode.Text = frm_inventory.m_barcode
        Me.txt_item_name.Text = frm_inventory.m_item_name
        Me.txt_selling_price.Text = frm_inventory.m_selling_price
        Me.txt_buying_price.Text = frm_inventory.m_buying_price
        Me.txt_initial_qty.Text = frm_inventory.m_stock_qty
        Me.txt_desc.Text = frm_inventory.m_desc
        Me.cbo_category.Text = frm_inventory.m_category
        Me.cbo_brand.Text = frm_inventory.m_brand
        Me.cbo_unit.Text = frm_inventory.m_unit
    End Sub

    Private Sub cmd_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_save.Click
        If frm_inventory.adding = True Then
            If IncompleteInput() = True Then
                Exit Sub
            ElseIf inventory_query.barcode_exists = True Then
                MsgBox(" This Barcode Already Exists! Please Input Another One!", MsgBoxStyle.Critical, " Invalid Entry")
                txt_barcode.Clear()
                txt_barcode.Focus()
                Exit Sub
            ElseIf inventory_query.item_name_exists = True Then
                MsgBox(" This Item Already Exists! Please Input Another One!", MsgBoxStyle.Critical, " Invalid Entry")
                txt_item_name.Clear()
                txt_item_name.Focus()
                Exit Sub
            Else
                If MsgBox(" ITEM INFORMATION " & vbCrLf & _
                          " Item No : " + lbl_item_no.Text & vbCrLf & "" + _
                          " Item Barcode : " + txt_barcode.Text & vbCrLf & "" + _
                          " Item Name : " + txt_item_name.Text & vbCrLf & "" + _
                          " Selling Price : " + txt_selling_price.Text & vbCrLf & "" + _
                          " Purchase Price : " + txt_buying_price.Text & vbCrLf & "" + _
                          " Initial Quantity : " + txt_initial_qty.Text & vbCrLf & "" + _
                          " Availbility : " + cbo_avail.Text & vbCrLf & "" + _
                          " Description : " + txt_desc.Text & vbCrLf & "" + _
                          " Category : " + cbo_category.Text & vbCrLf & "" + _
                          " Brand : " + cbo_brand.Text & vbCrLf & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Are You Sure You Want To Save?") = MsgBoxResult.Yes Then
                    inventory_query.insert_item()
                    'inventory_query.insert_sys_gen_beg_inv() 'for initial insert'
                    inventory_query.insert_sysgen_inv_begin_end() 'system generated beg_end inv'
                    Me.Close()
                    inventory_query.load_item()
                End If
            End If
        Else
            If IncompleteInput() = True Then
                Exit Sub
            ElseIf barcode_same_as_old() = True Then
                If MsgBox(" ITEM INFORMATION " & vbCrLf & _
                          " Item No : " + lbl_item_no.Text & vbCrLf & "" + _
                          " Item Barcode : " + txt_barcode.Text & vbCrLf & "" + _
                          " Item Name : " + txt_item_name.Text & vbCrLf & "" + _
                          " Selling Price : " + txt_selling_price.Text & vbCrLf & "" + _
                          " Purchase Price : " + txt_buying_price.Text & vbCrLf & "" + _
                          " Availbility : " + cbo_avail.Text & vbCrLf & "" + _
                          " Description : " + txt_desc.Text & vbCrLf & "" + _
                          " Category : " + cbo_category.Text & vbCrLf & "" + _
                          " Brand : " + cbo_brand.Text & vbCrLf & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Are You Sure You Want To Update?") = MsgBoxResult.Yes Then
                    inventory_query.update_item()
                    Me.Close()
                    inventory_query.load_item()
                End If
            ElseIf inventory_query.barcode_exists = True Then
                MsgBox(" This Barcode Already Exists! Please Input Another One!", MsgBoxStyle.Critical, " Invalid Entry")
                txt_barcode.Clear()
                txt_barcode.Focus()
                Exit Sub
            Else
                If MsgBox(" ITEM INFORMATION " & vbCrLf & _
                          " Item No : " + lbl_item_no.Text & vbCrLf & "" + _
                          " Item Barcode : " + txt_barcode.Text & vbCrLf & "" + _
                          " Item Name : " + txt_item_name.Text & vbCrLf & "" + _
                          " Selling Price : " + txt_selling_price.Text & vbCrLf & "" + _
                          " Purchase Price : " + txt_buying_price.Text & vbCrLf & "" + _
                          " Availbility : " + cbo_avail.Text & vbCrLf & "" + _
                          " Description : " + txt_desc.Text & vbCrLf & "" + _
                          " Category : " + cbo_category.Text & vbCrLf & "" + _
                          " Brand : " + cbo_brand.Text & vbCrLf & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " Are You Sure You Want To Update?") = MsgBoxResult.Yes Then
                    inventory_query.update_item()
                    Me.Close()
                    inventory_query.load_item()
                End If
            End If
        End If
    End Sub

    Function IncompleteInput() As Boolean
        If Me.lbl_item_no.Text = "" Then
            MsgBox(" Please Reload the form!", MsgBoxStyle.Critical, "Invalid Entry")
            Return True
            'ElseIf Me.txt_barcode.Text = "" Then
            '    MsgBox(" Please Input the Item Barcode!", MsgBoxStyle.Critical, " Incomplete Fields!")
            '    Me.txt_barcode.Focus()
            '    Return True
        ElseIf Me.txt_item_name.Text = "" Then
            MsgBox(" Please Input the Item Name!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_item_name.Focus()
            Return True
        ElseIf Me.txt_selling_price.Text = "" Then
            MsgBox(" Please Input the Item Selling Price!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_selling_price.Focus()
            Return True
        ElseIf Me.txt_buying_price.Text = "" Then
            MsgBox(" Please Input the Item Purchase Price!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_buying_price.Focus()
            Return True
        ElseIf Me.txt_initial_qty.Text = "" Then
            MsgBox(" Please Input the Initial Quantity of the Item!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_initial_qty.Focus()
            Return True
        ElseIf Me.txt_desc.Text = "" Then
            MsgBox(" Please Input the Item Description!", MsgBoxStyle.Critical, " Incomplete Fields!")
            Me.txt_desc.Focus()
            Return True
        ElseIf Not IsNumeric(txt_selling_price.Text) Then
            MsgBox(" Invalid Selling Price! Please Input a Valid One!", MsgBoxStyle.Critical, " Invalid Fields!")
            Me.txt_selling_price.Clear()
            Me.txt_selling_price.Focus()
            Return True
        ElseIf Not IsNumeric(txt_buying_price.Text) Then
            MsgBox(" Invalid Buying Price! Please Input a Valid One!", MsgBoxStyle.Critical, " Invalid Fields!")
            Me.txt_buying_price.Clear()
            Me.txt_buying_price.Focus()
            Return True
        ElseIf Not IsNumeric(txt_initial_qty.Text) Then
            MsgBox(" Invalid Initial Quatity! Please Input a Valid One!", MsgBoxStyle.Critical, " Invalid Fields!")
            Me.txt_initial_qty.Clear()
            Me.txt_initial_qty.Focus()
            Return True
        Else
            Return False
        End If
    End Function

    'Enables Edit of Same barcode'
    Public Function barcode_same_as_old() As Boolean
        If txt_barcode.Text = txt_old_barcode.Text Then
            Return True
        Else
            Return False
        End If
    End Function

    'handles'

    Private Sub NumOnly_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_buying_price.KeyPress, txt_selling_price.KeyPress

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        ' only allow one decimal point
        If e.KeyChar = "."c AndAlso TryCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub NumOnly_nopoint_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_initial_qty.KeyPress
        If cbo_unit.SelectedIndex = 1 Then
            If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
                e.Handled = True
            End If

            ' only allow one decimal point
            If e.KeyChar = "."c AndAlso TryCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
                e.Handled = True
            End If
        Else
            If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_initial_qty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_initial_qty.TextChanged
        If Not IsNumeric(txt_initial_qty.Text) Then
            cbo_avail.SelectedIndex = 1
        Else
            If CDec(txt_initial_qty.Text) > 0 Then
                cbo_avail.SelectedIndex = 0
            Else
                cbo_avail.SelectedIndex = 1
            End If
        End If
    End Sub

    Private Sub cbo_unit_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_unit.SelectedIndexChanged
        If frm_inventory.adding = True Then
            txt_initial_qty.Clear()
            txt_initial_qty.Focus()
        End If
    End Sub

End Class