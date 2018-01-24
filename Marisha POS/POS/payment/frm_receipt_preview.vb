Imports System.Data.SqlClient
Imports System.IO

Public Class frm_receipt_preview

    Dim pos_query As New pos_q
    Dim receipt_query As New receipt_preview_q
    Dim SQL As New SQLControl

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frm_invoice.dgv_item_cart.Rows.Clear()
        frm_invoice.lbl_disc_percent.Text = "0"
        frm_invoice.txt_barcode.Clear()
        frm_invoice.looptotal()
        pos_query.get_trans_no() 'generate new trans no. frm_invoice'
        frm_pay.Enabled = True
        Me.Dispose()
        frm_pay.Close()
    End Sub

    Private Sub frm_receipt_preview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'PrintDocument1.PrinterSettings.PrinterName = "POS-80" 'SET THERMAL PRINTER TO BE USED AS PRINTER'

        Me.lbl_sub_total.Text = frm_invoice.lbl_sub_total.Text
        Me.lbl_disc_percent.Text = frm_invoice.lbl_disc_percent.Text
        Me.lbl_total_disc.Text = frm_invoice.lbl_total_disc.Text
        Me.lbl_grand_total.Text = frm_invoice.lbl_grand_total.Text
        Me.lbl_item_count.Text = frm_invoice.lbl_item_count.Text
        Me.lbl_cash_tendered.Text = frm_pay.txt_tendered.Text

        Dim cash_tendered As Decimal = lbl_cash_tendered.Text
        Dim grand_total As Decimal = Me.lbl_grand_total.Text
        Dim cash_change As Decimal = cash_tendered - grand_total
        Me.lbl_change.Text = Format(cash_change, "0.00")

        Me.cmd_close.Focus()

        pnl_container.AutoScroll = True
        pnl_container.VerticalScroll.Visible = False Or pnl_container.HorizontalScroll.Visible = False

        receipt_query.load_receipt_info() 'load storename etc'
        receipt_query.LoadItemstoDatagrid() 'load items bought'
        load_invoice_info()

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

    Public Sub load_invoice_info()
        lbl_trans_no.Text = frm_invoice.lbl_trans_no.Text
        lbl_cashier.Text = frm_choose.lbl_name.Text
        lbl_date.Text = DateTime.Now.ToString("M/d/yyyy (ddd) hh:mm tt")

        'totals'
        lbl_subtotal_item_count.Text = frm_invoice.lbl_item_count.Text & " Item(s)"
        lbl_receipt_subtotal.Text = frm_invoice.lbl_sub_total.Text
        lbl_receipt_totaldisc.Text = frm_invoice.lbl_total_disc.Text
        lbl_receipt_totalamt.Text = frm_invoice.lbl_grand_total.Text
        lbl_receipt_tendered.Text = frm_pay.txt_tendered.Text
        lbl_receipt_change.Text = Me.lbl_change.Text
    End Sub

    Private Sub cmd_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_close.Click
        Me.Close()
    End Sub

    'Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    '    Dim bm As New Bitmap(Me.pnl_receipt.Width, Me.pnl_receipt.Height)
    '    pnl_receipt.DrawToBitmap(bm, New Rectangle(0, 0, Me.pnl_receipt.Width, Me.pnl_receipt.Height))
    '    e.Graphics.DrawImage(bm, 0, 0)
    'End Sub

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
        TextToPrint &= "Cash Tendered:".PadRight(24) & frm_pay.txt_tendered.Text.PadLeft(8) & Environment.NewLine
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