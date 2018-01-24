Public Class frm_trans_info

    Dim customers_query As New customers_q

    Private Sub me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frm_trans_info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        customers_query.load_sold_items()
        customers_query.load_receipt_info()
        customers_query.LoadItemstoDatagrid()

        Dim item_count As Decimal = 0

        For index As Integer = 0 To dgv_sold_items.RowCount - 1
            If dgv_sold_items.Rows(index).Cells(4).Value.ToString = "PCS" Then
                item_count += Convert.ToDecimal(dgv_sold_items.Rows(index).Cells(3).Value)
            End If
        Next

        lbl_items.Text = item_count
    End Sub

    Private Sub cmd_delete_trans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_delete_trans.Click
        If lbl_trans_no.Text = "" Then
            MsgBox(" Please Close the Form!", MsgBoxStyle.Exclamation, " Invalid")
        Else
            If MsgBox(" WARNING! Pressing Yes Will " & vbCrLf & _
                       " PERMANENTLY DELETE this Customer Sales Record " & vbCrLf & _
                       " and INCREASE the Current Items on The Inventory Based on The Included Items on This Transaction." & vbCrLf & _
                       " Are You Sure You Want To Continue?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, " Confirmation") = MsgBoxResult.Yes Then
                frm_delete_pass_supp_trans.purchase = False
                frm_delete_pass_supp_trans.returns = False
                frm_delete_pass_supp_trans.sales_ret = False
                frm_delete_pass_supp_trans.sales_bo = False
                frm_delete_pass_supp_trans.sales_cash = False
                frm_delete_pass_supp_trans.sales_cust = True

                frm_delete_pass_supp_trans.ShowDialog()
            End If
        End If
    End Sub

    Private Sub cmd_print_receipt_Click(sender As System.Object, e As System.EventArgs) Handles cmd_print_receipt.Click
        If MsgBox(" Re-Print The Receipt?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, " Confirmation") = MsgBoxResult.Yes Then
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
        End If
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

        Dim trans_no As String = Me.lbl_trans_no.Text
        TextToPrint &= Environment.NewLine
        TextToPrint &= "Transaction #: " & trans_no & Environment.NewLine

        Dim cashier As String = frm_choose.lbl_name.Text
        TextToPrint &= "Cashier: " & cashier & Environment.NewLine

        Dim customer As String = Me.lbl_cust_name.Text
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
        Dim subtotal_items As String = "Sub Total: " + Me.lbl_items.Text + " item(s)"
        TextToPrint &= subtotal_items.PadRight(24) & Me.lbl_sub_total_grand.Text.PadLeft(8) & Environment.NewLine
        'Discount Amount
        TextToPrint &= "Total Discount:".PadRight(24) & Me.lbl_total_discount.Text.PadLeft(8) & Environment.NewLine
        'Total Amount
        TextToPrint &= "Total Amount:".PadRight(24) & Me.lbl_grand_total.Text.PadLeft(8) & Environment.NewLine
        'Cash Entered Amount
        TextToPrint &= "Cash Tendered:".PadRight(24) & Me.lbl_cash_tendered.Text.PadLeft(8) & Environment.NewLine
        'Partial Payment
        TextToPrint &= "Partial Payment:".PadRight(24) & Me.lbl_partial_pay.Text.PadLeft(8) & Environment.NewLine
        'Remaining Balance
        TextToPrint &= "Remaining Balance:".PadRight(24) & Me.lbl_balance.Text.PadLeft(8) & Environment.NewLine
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