Public Class frm_receipt_preview_customer

    Dim pos_query As New pos_q
    Dim receipt_query As New receipt_preview_q

    Public full_account As Boolean
    Public partial_account As Boolean
    Public partial_account_no_tendered As Boolean

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        frm_invoice.dgv_item_cart.Rows.Clear()
        frm_invoice.lbl_disc_percent.Text = "0"
        frm_invoice.txt_barcode.Clear()
        frm_invoice.looptotal()
        pos_query.get_trans_no() 'generate new trans no. frm_invoice'
        frm_showcustomers.Enabled = True
        Me.Dispose()
        frm_pay.Close()
    End Sub

    Private Sub frm_receipt_preview_customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lbl_custname.Text = frm_showcustomers.dgv_customers.Item("first_name", frm_showcustomers.dgv_customers.CurrentRow.Index).Value.ToString() _
            + " " + frm_showcustomers.dgv_customers.Item("last_name", frm_showcustomers.dgv_customers.CurrentRow.Index).Value.ToString()

        If full_account = True Then

            Me.lbl_sub_total.Text = frm_invoice.lbl_sub_total.Text
            Me.lbl_disc_percent.Text = frm_invoice.lbl_disc_percent.Text
            Me.lbl_total_disc.Text = frm_invoice.lbl_total_disc.Text
            Me.lbl_grand_total.Text = frm_invoice.lbl_grand_total.Text
            Me.lbl_item_count.Text = frm_invoice.lbl_item_count.Text
            Dim grand_total As Decimal = Me.lbl_grand_total.Text

            lbl_rem_balance.Text = grand_total

        ElseIf partial_account = True Then

            Me.lbl_sub_total.Text = frm_invoice.lbl_sub_total.Text
            Me.lbl_disc_percent.Text = frm_invoice.lbl_disc_percent.Text
            Me.lbl_total_disc.Text = frm_invoice.lbl_total_disc.Text
            Me.lbl_grand_total.Text = frm_invoice.lbl_grand_total.Text
            Me.lbl_item_count.Text = frm_invoice.lbl_item_count.Text
            Dim grand_total As Decimal = Me.lbl_grand_total.Text

            Dim part_cash_tendered As Decimal = frm_partial_pay.lbl_tendered.Text
            Me.lbl_cash_tendered.Text = Format(part_cash_tendered, "0.00")

            Dim partial_pay As Decimal = frm_partial_pay.txt_paid_amt.Text
            Me.lbl_partial_payment.Text = Format(partial_pay, "0.00")

            'get remaining bal
            Dim partial_payment As Decimal = Me.lbl_partial_payment.Text
            Dim rem_bal As Decimal = grand_total - partial_payment
            lbl_rem_balance.Text = Format(rem_bal, "0.00")

            'get change'
            Dim cash_tendered As Decimal = Me.lbl_cash_tendered.Text
            Dim change As Decimal = cash_tendered - partial_payment
            lbl_change.Text = Format(change, "0.00")

        ElseIf partial_account_no_tendered = True Then

            Me.lbl_sub_total.Text = frm_invoice.lbl_sub_total.Text
            Me.lbl_disc_percent.Text = frm_invoice.lbl_disc_percent.Text
            Me.lbl_total_disc.Text = frm_invoice.lbl_total_disc.Text
            Me.lbl_grand_total.Text = frm_invoice.lbl_grand_total.Text
            Me.lbl_item_count.Text = frm_invoice.lbl_item_count.Text
            Dim grand_total As Decimal = Me.lbl_grand_total.Text

            Dim part_no_ten As Decimal = frm_pay.txt_tendered.Text
            Me.lbl_cash_tendered.Text = Format(part_no_ten, "0.00")

            Dim part_no_pay As Decimal = frm_pay.txt_tendered.Text
            Me.lbl_partial_payment.Text = Format(part_no_pay, "0.00")

            'get remaining bal
            Dim partial_payment As Decimal = Me.lbl_partial_payment.Text
            Dim rem_bal As Decimal = grand_total - partial_payment
            lbl_rem_balance.Text = Format(rem_bal, "0.00")

            'get change'
            Me.lbl_change.Text = "0.00"

        End If

        Me.cmd_close.Focus()

        pnl_container.AutoScroll = True
        pnl_container.VerticalScroll.Visible = False Or pnl_container.HorizontalScroll.Visible = False

        receipt_query.load_receipt_info_customer() 'load storename etc'
        receipt_query.LoadItemstoDatagrid_customer() 'load items bought'

        PrintHeader()
        Print_footer()
        print_greeting()
        Dim printControl = New Printing.StandardPrintController
        PrintDocument1.PrintController = printControl
        Try
            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmd_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_close.Click
        Me.Close()
    End Sub

    'PRINT RECEIPT .TXT TYPE'
    Dim TextToPrint As String = ""
    Public store_name As String = ""
    Public store_address As String = ""
    Public tin As String = ""
    Public closing_1 As String = ""
    Public closing_2 As String = ""
    Public closing_3 As String = ""
    Public closing_4 As String = ""

    Public Sub PrintHeader()

        TextToPrint = ""

        'send store Name
        Dim LineLen As Integer = store_name.Length
        Dim spcLen1 As New String(" "c, Math.Round((33 - LineLen) / 2)) 'This line is used to center text in the middle of the receipt
        TextToPrint &= spcLen1 & store_name & Environment.NewLine

        LineLen = store_address.Length
        Dim spcLen2 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen2 & store_address & Environment.NewLine

        LineLen = tin.Length
        Dim spcLen3 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen3 & tin & Environment.NewLine

        Dim cur_date_time As String = DateTime.Now.ToString("M/d/yyyy (ddd) hh:mm tt")
        LineLen = cur_date_time.Length
        Dim spcLen4 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen4 & cur_date_time & Environment.NewLine

        Dim trans_no As String = frm_invoice.lbl_trans_no.Text
        TextToPrint &= Environment.NewLine
        TextToPrint &= "Transaction #: " & trans_no & Environment.NewLine

        Dim cashier As String = frm_choose.lbl_name.Text
        TextToPrint &= "Cashier: " & cashier & Environment.NewLine

        Dim customer As String = Me.lbl_custname.Text
        TextToPrint &= "Customer: " & customer & Environment.NewLine

        TextToPrint &= Environment.NewLine
        TextToPrint &= "DESCRIPTION               AMOUNT" & Environment.NewLine
        TextToPrint &= Environment.NewLine

        For i As Integer = 0 To dgw.RowCount - 1

            'TextToPrint &= dgw.Item(0, i).Value.ToString.PadRight(48)
            'TextToPrint &= dgw.Item(1, i).Value.ToString.PadLeft(8)

            TextToPrint &= dgw.Item(0, i).Value
            TextToPrint &= String.Format("{0,18}", dgw.Item(1, i).Value.ToString)
            TextToPrint &= Environment.NewLine
        Next

    End Sub

    Public Sub Print_footer()

        TextToPrint &= Environment.NewLine
        'SubTotal Amount
        Dim subtotal_items As String = "Sub Total: " + frm_invoice.lbl_item_count.Text + " item(s)"
        TextToPrint &= subtotal_items.PadRight(24) & frm_invoice.lbl_sub_total.Text.PadLeft(8) & Environment.NewLine
        'Discount Amount
        TextToPrint &= "Total Discount:".PadRight(24) & frm_invoice.lbl_total_disc.Text.PadLeft(8) & Environment.NewLine
        'Total Amount
        TextToPrint &= "Total Amount:".PadRight(24) & frm_invoice.lbl_grand_total.Text.PadLeft(8) & Environment.NewLine
        'Cash Entered Amount
        TextToPrint &= "Cash Tendered:".PadRight(24) & Me.lbl_cash_tendered.Text.PadLeft(8) & Environment.NewLine
        'Partial Payment
        TextToPrint &= "Partial Payment:".PadRight(24) & Me.lbl_partial_payment.Text.PadLeft(8) & Environment.NewLine
        'Remaining Balance
        TextToPrint &= "Remaining Balance:".PadRight(24) & Me.lbl_rem_balance.Text.PadLeft(8) & Environment.NewLine
        TextToPrint &= Environment.NewLine
        'Change Amount
        TextToPrint &= "CHANGE:".PadRight(24) & Me.lbl_change.Text.PadLeft(8) & Environment.NewLine
        TextToPrint &= Environment.NewLine
        TextToPrint &= "================================"
        TextToPrint &= Environment.NewLine
    End Sub

    Public Sub print_greeting()

        'Send Greeting 1
        Dim LineLen As Integer = closing_1.Length
        Dim spcLen1 As New String(" "c, Math.Round((33 - LineLen) / 2)) 'This line is used to center text in the middle of the receipt
        TextToPrint &= spcLen1 & closing_1 & Environment.NewLine

        'Send Greeting 2
        LineLen = closing_2.Length
        Dim spcLen2 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen2 & closing_2 & Environment.NewLine

        'Send Greeting 3
        LineLen = closing_3.Length
        Dim spcLen3 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen3 & closing_3 & Environment.NewLine

        'Send Greeting 4
        LineLen = closing_4.Length
        Dim spcLen4 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen4 & closing_4 & Environment.NewLine

    End Sub

    Private Sub PrintDocument2_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Static currentChar As Integer
        Dim textfont As Font = New Font("Courier New", 10, FontStyle.Bold)

        Dim h, w As Integer
        Dim left, top As Integer
        With PrintDocument1.DefaultPageSettings
            h = 0
            w = 0
            left = 0
            top = 0
        End With

        Dim lines As Integer = CInt(Math.Round(h / 1))
        Dim b As New Rectangle(left, top, w, h)
        Dim format As StringFormat
        format = New StringFormat(StringFormatFlags.LineLimit)
        Dim line, chars As Integer

        e.Graphics.MeasureString(Mid(TextToPrint, currentChar + 1), textfont, New SizeF(w, h), format, chars, line)
        e.Graphics.DrawString(TextToPrint.Substring(currentChar, chars), New Font("Courier New", 10, FontStyle.Bold), Brushes.Black, b, format)

        currentChar = currentChar + chars
        If currentChar < TextToPrint.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            currentChar = 0
        End If
    End Sub

End Class