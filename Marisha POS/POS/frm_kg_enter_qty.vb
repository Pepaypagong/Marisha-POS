Public Class frm_kg_enter_qty

    Dim pos_query As New pos_q
    Dim item_lookup_query As New item_lookup_q

    Public item_no As String
    Public barcode As String
    Public item_name As String
    Public selling_price As String
    'qty'
    'unit'
    'amount'
    'begin'
    'end'
    Public buying_price As String
    'beg inv price

    'initial beg inv price' 
    Public beginning_inventory_price As String
    'discount'
    Public category As String


    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub cmd_done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_done.Click
        If txt_qty.Text = "" Then
            MsgBox(" Invalid Quantity!", MsgBoxStyle.Critical, " Invalid Entry")
            txt_qty.Clear()
            txt_qty.Focus()
            Exit Sub
        ElseIf Not IsNumeric(txt_qty.Text) Then
            MsgBox(" Invalid Quantity!", MsgBoxStyle.Critical, " Invalid Entry")
            txt_qty.Clear()
            txt_qty.Focus()
            Exit Sub
        ElseIf CDec(txt_qty.Text) <= 0 Then
            MsgBox(" Invalid Quantity!", MsgBoxStyle.Critical, " Invalid Entry")
            txt_qty.Clear()
            txt_qty.Focus()
        ElseIf CDec(txt_qty.Text) > CDec(lbl_current_stock_qty.Text) Then
            MsgBox(" The Current Stock On This Item is : " + lbl_current_stock_qty.Text + ". The Qty. You Entered is Invalid!", MsgBoxStyle.Critical, " Invalid Entry")
            txt_qty.Clear()
            txt_qty.Focus()
        Else
            pos_query.add_to_cart(item_no,barcode,item_name,selling_price,Me.txt_qty.Text,Me.lbl_unit.Text, Format(CDec(Me.txt_qty.Text) * CDec(selling_price), "0.00"),
                                  buying_price,0,category)

            frm_invoice.looptotal()
            Me.Close()
        End If
    End Sub

    Private Sub frm_change_qty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        pos_query.get_stock_qty()
    End Sub

    Private Sub NumOnly_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_qty.KeyPress
        If lbl_unit.Text = "KGS" Then
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

    'SHORCUT KEYS'
    Private Sub shortcut_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            cmd_cancel.PerformClick()
        End If
    End Sub

    'enable textboxes to keypress enter trigger event
    Private Sub login_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_qty.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            cmd_done.PerformClick()
        End If
    End Sub

End Class