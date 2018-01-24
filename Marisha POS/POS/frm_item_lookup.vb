Imports System.Data.SqlClient
Imports System.IO

Public Class frm_item_lookup

    Dim SQL As New SQLControl
    Dim item_lookup_query As New item_lookup_q
    Dim pos_query As New pos_q

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
    Private Sub frm_item_lookup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        flp_items.Controls.Clear()
        item_lookup_query.show_categories()
        Me.cbo_category.SelectedIndex = 0 'prompts the cbo_category to do the event which is load items'
    End Sub

    Public Sub click_me(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As Button
        btn = CType(sender, Button)

        Dim unit As String
        'Dim item_name As String = btn.Text
        'Dim item_no_tag As String = btn.Tag
        'MessageBox.Show(item_no_tag + " " + item_name)

        Try
            Dim add_to_item_cart As String = "SELECT * FROM item_table WHERE item_no = '" & btn.Tag & "' "
            SQL.ConnDB()
            SQL.SQLCmd = New SqlCommand(add_to_item_cart, SQL.SQLCon)
            SQL.SQLDR = SQL.SQLCmd.ExecuteReader

            If SQL.SQLDR.Read = True Then

                frm_invoice.m_item_no = SQL.SQLDR("item_no") 'get selected item_no'
                unit = SQL.SQLDR("unit_of_measure")

                If unit = "KGS" Then
                    Dim exists As Boolean = False
                    For Each itm As DataGridViewRow In frm_invoice.dgv_item_cart.Rows
                        If itm.Cells(0).Value = frm_invoice.m_item_no Then
                            exists = True
                        End If
                    Next

                    If frm_invoice.dgv_item_cart.Rows.Count > 0 AndAlso exists = True Then
                        MsgBox(" This Item is Already in The Item List! ", MsgBoxStyle.Critical, " Invalid Action")
                        frm_invoice.ClearItemVariables()
                        Exit Sub
                    Else

                        ''check if init or not then get begin and end inv'
                        'If pos_query.isInit = True Then
                        '    pos_query.get_initial_beg_inv()
                        'Else
                        '    pos_query.get_not_init_beg_inv()
                        'End If
                        'pos_query.get_ending_inv()

                        frm_kg_enter_qty.item_no = SQL.SQLDR("item_no")
                        frm_kg_enter_qty.barcode = SQL.SQLDR("barcode")
                        frm_kg_enter_qty.item_name = SQL.SQLDR("item_name")
                        frm_kg_enter_qty.selling_price = SQL.SQLDR("selling_price")
                        'qty'
                        'unit'
                        'amount'
                        'begin'
                        'end'

                        'buying price'
                        frm_kg_enter_qty.buying_price = SQL.SQLDR("buying_price")

                        'beg inv price

                        'initial beg inv price' 
                        frm_kg_enter_qty.beginning_inventory_price = SQL.SQLDR("beginning_inventory_price")

                        'discount'

                        frm_kg_enter_qty.lbl_item_name.Text = SQL.SQLDR("item_name")
                        frm_kg_enter_qty.lbl_current_stock_qty.Text = SQL.SQLDR("stock_qty")
                        frm_kg_enter_qty.lbl_unit.Text = SQL.SQLDR("unit_of_measure")
                        frm_kg_enter_qty.category = SQL.SQLDR("category")

                        frm_kg_enter_qty.txt_qty.Focus()
                        frm_kg_enter_qty.ShowDialog()

                        ''insert to item cart including the ending and beg inv.'
                        'frm_invoice.dgv_item_cart.Rows.Add(New Object() _
                        '                     {SQL.SQLDR("item_no"), SQL.SQLDR("barcode"), _
                        '                      SQL.SQLDR("item_name"), SQL.SQLDR("selling_price"), _
                        '                      1, SQL.SQLDR("unit_of_measure"), SQL.SQLDR("selling_price"), frm_invoice.lbl_beginning.Text, _
                        '                      frm_invoice.lbl_ending.Text, SQL.SQLDR("buying_price"), SQL.SQLDR("buying_price"), _
                        '                      SQL.SQLDR("beginning_inventory_price"), 0})

                        ''clear populated labels'
                        'frm_invoice.lbl_item_no.Text = ""
                        'frm_invoice.lbl_beginning.Text = ""
                        'frm_invoice.lbl_ending.Text = ""
                        'frm_invoice.lbl_buying_price.Text = ""
                        'frm_invoice.lbl_beg_inv_init_price.Text = ""
                        'frm_invoice.lbl_unit.Text = ""
                    End If

                Else
                    Dim exists As Boolean = False
                    For Each itm As DataGridViewRow In frm_invoice.dgv_item_cart.Rows
                        If itm.Cells(0).Value = frm_invoice.m_item_no Then
                            exists = True
                        End If
                    Next

                    If frm_invoice.dgv_item_cart.Rows.Count > 0 AndAlso exists = True Then
                        MsgBox(" This Item is Already in The Item List! ", MsgBoxStyle.Critical, " Invalid Action")
                        frm_invoice.m_item_no = vbNull
                        Exit Sub
                    Else

                        ''check if init or not then get begin and end inv'
                        'If pos_query.isInit = True Then
                        '    pos_query.get_initial_beg_inv()
                        'Else
                        '    pos_query.get_not_init_beg_inv()
                        'End If
                        'pos_query.get_ending_inv()

                        'insert to item cart including the ending and beg inv.'
                        pos_query.add_to_cart(SQL.SQLDR("item_no"), SQL.SQLDR("barcode"),
                                              SQL.SQLDR("item_name"), SQL.SQLDR("selling_price"),
                                              1, SQL.SQLDR("unit_of_measure"), SQL.SQLDR("selling_price"),
                                              SQL.SQLDR("buying_price"), 0, SQL.SQLDR("category"))

                        'clear populated labels'W
                        frm_invoice.ClearItemVariables()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SQL.SQLCmd.Dispose()
            SQL.SQLCon.Close()
        End Try
        frm_invoice.ClearItemVariables()
        frm_invoice.looptotal()
    End Sub

    Private Sub cbo_category_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_category.SelectedIndexChanged
        Me.flp_items.Controls.Clear()
        item_lookup_query.load_items()
    End Sub

    'SHORCUT KEYS'
    Private Sub shortcut_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            cmd_cancel.PerformClick()
        End If
    End Sub

End Class