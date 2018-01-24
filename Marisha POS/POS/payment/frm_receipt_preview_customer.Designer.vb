<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_receipt_preview_customer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_rem_balance = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbl_partial_payment = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_change = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbl_cash_tendered = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl_item_count = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_disc_percent = New System.Windows.Forms.Label()
        Me.lbl_total_disc = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_sub_total = New System.Windows.Forms.Label()
        Me.lbl_grand_total = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmd_close = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_custname = New System.Windows.Forms.Label()
        Me.pnl_container = New System.Windows.Forms.Panel()
        Me.pnl_receipt = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_store_address = New System.Windows.Forms.Label()
        Me.pnl_total = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lbl_receipt_totaldisc = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbl_closing_2 = New System.Windows.Forms.Label()
        Me.lbl_closing_1 = New System.Windows.Forms.Label()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.lbl_receipt_change = New System.Windows.Forms.Label()
        Me.lbl_receipt_subtotal = New System.Windows.Forms.Label()
        Me.lbl_receipt_tendered = New System.Windows.Forms.Label()
        Me.change = New System.Windows.Forms.Label()
        Me.subTotal = New System.Windows.Forms.Label()
        Me.Cash = New System.Windows.Forms.Label()
        Me.lbl_receipt_totalamt = New System.Windows.Forms.Label()
        Me.TotalAmount = New System.Windows.Forms.Label()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_cashier = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_trans_no = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbl_tin = New System.Windows.Forms.Label()
        Me.lbl_store_name = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout
        Me.pnl_container.SuspendLayout
        Me.pnl_receipt.SuspendLayout
        Me.pnl_total.SuspendLayout
        CType(Me.dgw,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.lbl_rem_balance)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.lbl_partial_payment)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.lbl_change)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.lbl_cash_tendered)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.lbl_item_count)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lbl_disc_percent)
        Me.Panel1.Controls.Add(Me.lbl_total_disc)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.lbl_sub_total)
        Me.Panel1.Controls.Add(Me.lbl_grand_total)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(6, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 352)
        Me.Panel1.TabIndex = 91
        '
        'lbl_rem_balance
        '
        Me.lbl_rem_balance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_rem_balance.ForeColor = System.Drawing.Color.Lime
        Me.lbl_rem_balance.Location = New System.Drawing.Point(264, 257)
        Me.lbl_rem_balance.Name = "lbl_rem_balance"
        Me.lbl_rem_balance.Size = New System.Drawing.Size(116, 25)
        Me.lbl_rem_balance.TabIndex = 37
        Me.lbl_rem_balance.Text = "0.00"
        Me.lbl_rem_balance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.AutoSize = true
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Lime
        Me.Label19.Location = New System.Drawing.Point(10, 257)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(226, 25)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Remaining Balance (P)"
        '
        'lbl_partial_payment
        '
        Me.lbl_partial_payment.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_partial_payment.ForeColor = System.Drawing.Color.Lime
        Me.lbl_partial_payment.Location = New System.Drawing.Point(264, 217)
        Me.lbl_partial_payment.Name = "lbl_partial_payment"
        Me.lbl_partial_payment.Size = New System.Drawing.Size(116, 25)
        Me.lbl_partial_payment.TabIndex = 34
        Me.lbl_partial_payment.Text = "0.00"
        Me.lbl_partial_payment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Lime
        Me.Label12.Location = New System.Drawing.Point(10, 217)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(194, 25)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Partial Payment (P)"
        '
        'lbl_change
        '
        Me.lbl_change.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_change.ForeColor = System.Drawing.Color.Lime
        Me.lbl_change.Location = New System.Drawing.Point(264, 305)
        Me.lbl_change.Name = "lbl_change"
        Me.lbl_change.Size = New System.Drawing.Size(116, 25)
        Me.lbl_change.TabIndex = 31
        Me.lbl_change.Text = "0.00"
        Me.lbl_change.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = true
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Lime
        Me.Label17.Location = New System.Drawing.Point(9, 305)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 25)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Change (P)"
        '
        'lbl_cash_tendered
        '
        Me.lbl_cash_tendered.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_cash_tendered.ForeColor = System.Drawing.Color.Lime
        Me.lbl_cash_tendered.Location = New System.Drawing.Point(264, 179)
        Me.lbl_cash_tendered.Name = "lbl_cash_tendered"
        Me.lbl_cash_tendered.Size = New System.Drawing.Size(116, 25)
        Me.lbl_cash_tendered.TabIndex = 28
        Me.lbl_cash_tendered.Text = "0.00"
        Me.lbl_cash_tendered.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Lime
        Me.Label14.Location = New System.Drawing.Point(10, 179)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(188, 25)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Cash Tendered (P)"
        '
        'lbl_item_count
        '
        Me.lbl_item_count.AutoSize = true
        Me.lbl_item_count.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_item_count.ForeColor = System.Drawing.Color.Lime
        Me.lbl_item_count.Location = New System.Drawing.Point(186, 141)
        Me.lbl_item_count.Name = "lbl_item_count"
        Me.lbl_item_count.Size = New System.Drawing.Size(20, 23)
        Me.lbl_item_count.TabIndex = 26
        Me.lbl_item_count.Text = "0"
        Me.lbl_item_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Lime
        Me.Label9.Location = New System.Drawing.Point(11, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(175, 23)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Total No. of Item(s)"
        '
        'lbl_disc_percent
        '
        Me.lbl_disc_percent.AutoSize = true
        Me.lbl_disc_percent.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_disc_percent.ForeColor = System.Drawing.Color.Lime
        Me.lbl_disc_percent.Location = New System.Drawing.Point(194, 61)
        Me.lbl_disc_percent.Name = "lbl_disc_percent"
        Me.lbl_disc_percent.Size = New System.Drawing.Size(23, 25)
        Me.lbl_disc_percent.TabIndex = 20
        Me.lbl_disc_percent.Text = "0"
        Me.lbl_disc_percent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_disc_percent.Visible = false
        '
        'lbl_total_disc
        '
        Me.lbl_total_disc.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_total_disc.ForeColor = System.Drawing.Color.Lime
        Me.lbl_total_disc.Location = New System.Drawing.Point(264, 61)
        Me.lbl_total_disc.Name = "lbl_total_disc"
        Me.lbl_total_disc.Size = New System.Drawing.Size(116, 25)
        Me.lbl_total_disc.TabIndex = 9
        Me.lbl_total_disc.Text = "0.00"
        Me.lbl_total_disc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Lime
        Me.Label13.Location = New System.Drawing.Point(10, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(180, 25)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Total Discount (P)"
        '
        'lbl_sub_total
        '
        Me.lbl_sub_total.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_sub_total.ForeColor = System.Drawing.Color.Lime
        Me.lbl_sub_total.Location = New System.Drawing.Point(264, 23)
        Me.lbl_sub_total.Name = "lbl_sub_total"
        Me.lbl_sub_total.Size = New System.Drawing.Size(116, 25)
        Me.lbl_sub_total.TabIndex = 7
        Me.lbl_sub_total.Text = "0.00"
        Me.lbl_sub_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_grand_total
        '
        Me.lbl_grand_total.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_grand_total.ForeColor = System.Drawing.Color.Lime
        Me.lbl_grand_total.Location = New System.Drawing.Point(227, 100)
        Me.lbl_grand_total.Name = "lbl_grand_total"
        Me.lbl_grand_total.Size = New System.Drawing.Size(153, 25)
        Me.lbl_grand_total.TabIndex = 5
        Me.lbl_grand_total.Text = "0.00"
        Me.lbl_grand_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(10, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Grand Total (P)"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(10, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sub Total (P)"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(242, 25)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Transaction Summary"
        '
        'cmd_close
        '
        Me.cmd_close.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_close.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_close.ForeColor = System.Drawing.Color.White
        Me.cmd_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_close.Location = New System.Drawing.Point(49, 506)
        Me.cmd_close.Name = "cmd_close"
        Me.cmd_close.Size = New System.Drawing.Size(307, 75)
        Me.cmd_close.TabIndex = 92
        Me.cmd_close.Text = "Next Transaction"
        Me.cmd_close.UseVisualStyleBackColor = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 424)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 19)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Transaction For Customer (On-Account) :"
        '
        'lbl_custname
        '
        Me.lbl_custname.BackColor = System.Drawing.Color.White
        Me.lbl_custname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_custname.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_custname.Location = New System.Drawing.Point(21, 449)
        Me.lbl_custname.Name = "lbl_custname"
        Me.lbl_custname.Size = New System.Drawing.Size(365, 30)
        Me.lbl_custname.TabIndex = 94
        Me.lbl_custname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl_container
        '
        Me.pnl_container.Controls.Add(Me.pnl_receipt)
        Me.pnl_container.Location = New System.Drawing.Point(528, 50)
        Me.pnl_container.Name = "pnl_container"
        Me.pnl_container.Size = New System.Drawing.Size(332, 555)
        Me.pnl_container.TabIndex = 95
        Me.pnl_container.Visible = false
        '
        'pnl_receipt
        '
        Me.pnl_receipt.BackColor = System.Drawing.Color.White
        Me.pnl_receipt.Controls.Add(Me.Label11)
        Me.pnl_receipt.Controls.Add(Me.lbl_store_address)
        Me.pnl_receipt.Controls.Add(Me.pnl_total)
        Me.pnl_receipt.Controls.Add(Me.dgw)
        Me.pnl_receipt.Controls.Add(Me.lbl_cashier)
        Me.pnl_receipt.Controls.Add(Me.lbl_date)
        Me.pnl_receipt.Controls.Add(Me.Label18)
        Me.pnl_receipt.Controls.Add(Me.lbl_trans_no)
        Me.pnl_receipt.Controls.Add(Me.Label21)
        Me.pnl_receipt.Controls.Add(Me.lbl_tin)
        Me.pnl_receipt.Controls.Add(Me.lbl_store_name)
        Me.pnl_receipt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.pnl_receipt.Location = New System.Drawing.Point(3, 3)
        Me.pnl_receipt.Name = "pnl_receipt"
        Me.pnl_receipt.Size = New System.Drawing.Size(303, 433)
        Me.pnl_receipt.TabIndex = 89
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Location = New System.Drawing.Point(6, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Customer :"
        '
        'lbl_store_address
        '
        Me.lbl_store_address.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_store_address.Location = New System.Drawing.Point(1, 34)
        Me.lbl_store_address.Name = "lbl_store_address"
        Me.lbl_store_address.Size = New System.Drawing.Size(302, 14)
        Me.lbl_store_address.TabIndex = 47
        Me.lbl_store_address.Text = "[Company Address Here]"
        Me.lbl_store_address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_total
        '
        Me.pnl_total.Controls.Add(Me.Label24)
        Me.pnl_total.Controls.Add(Me.Label25)
        Me.pnl_total.Controls.Add(Me.Label22)
        Me.pnl_total.Controls.Add(Me.Label23)
        Me.pnl_total.Controls.Add(Me.lbl_receipt_totaldisc)
        Me.pnl_total.Controls.Add(Me.Label20)
        Me.pnl_total.Controls.Add(Me.lbl_closing_2)
        Me.pnl_total.Controls.Add(Me.lbl_closing_1)
        Me.pnl_total.Controls.Add(Me.lblLine)
        Me.pnl_total.Controls.Add(Me.lbl_receipt_change)
        Me.pnl_total.Controls.Add(Me.lbl_receipt_subtotal)
        Me.pnl_total.Controls.Add(Me.lbl_receipt_tendered)
        Me.pnl_total.Controls.Add(Me.change)
        Me.pnl_total.Controls.Add(Me.subTotal)
        Me.pnl_total.Controls.Add(Me.Cash)
        Me.pnl_total.Controls.Add(Me.lbl_receipt_totalamt)
        Me.pnl_total.Controls.Add(Me.TotalAmount)
        Me.pnl_total.Location = New System.Drawing.Point(10, 206)
        Me.pnl_total.Name = "pnl_total"
        Me.pnl_total.Size = New System.Drawing.Size(281, 217)
        Me.pnl_total.TabIndex = 46
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label24.Location = New System.Drawing.Point(194, 93)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 15)
        Me.Label24.TabIndex = 61
        Me.Label24.Text = "0.00"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.AutoSize = true
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label25.Location = New System.Drawing.Point(1, 93)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(125, 13)
        Me.Label25.TabIndex = 62
        Me.Label25.Text = "Remaining Balance :"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label22.Location = New System.Drawing.Point(194, 76)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 15)
        Me.Label22.TabIndex = 59
        Me.Label22.Text = "0.00"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.AutoSize = true
        Me.Label23.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label23.Location = New System.Drawing.Point(1, 76)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(106, 13)
        Me.Label23.TabIndex = 60
        Me.Label23.Text = "Partial Payment :"
        '
        'lbl_receipt_totaldisc
        '
        Me.lbl_receipt_totaldisc.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_receipt_totaldisc.Location = New System.Drawing.Point(194, 24)
        Me.lbl_receipt_totaldisc.Name = "lbl_receipt_totaldisc"
        Me.lbl_receipt_totaldisc.Size = New System.Drawing.Size(80, 13)
        Me.lbl_receipt_totaldisc.TabIndex = 57
        Me.lbl_receipt_totaldisc.Text = "0.00"
        Me.lbl_receipt_totaldisc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = true
        Me.Label20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label20.Location = New System.Drawing.Point(1, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 13)
        Me.Label20.TabIndex = 58
        Me.Label20.Text = "Total Discount :"
        '
        'lbl_closing_2
        '
        Me.lbl_closing_2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_closing_2.Location = New System.Drawing.Point(3, 186)
        Me.lbl_closing_2.Name = "lbl_closing_2"
        Me.lbl_closing_2.Size = New System.Drawing.Size(278, 13)
        Me.lbl_closing_2.TabIndex = 55
        Me.lbl_closing_2.Text = "Thank You Come Again!"
        Me.lbl_closing_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_closing_1
        '
        Me.lbl_closing_1.Location = New System.Drawing.Point(3, 152)
        Me.lbl_closing_1.Name = "lbl_closing_1"
        Me.lbl_closing_1.Size = New System.Drawing.Size(278, 31)
        Me.lbl_closing_1.TabIndex = 56
        Me.lbl_closing_1.Text = "THIS IS YOUR OFFICIAL RECEPIT"
        Me.lbl_closing_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine
        '
        Me.lblLine.AutoSize = true
        Me.lblLine.Location = New System.Drawing.Point(2, 136)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(277, 13)
        Me.lblLine.TabIndex = 54
        Me.lblLine.Text = "=============================="
        '
        'lbl_receipt_change
        '
        Me.lbl_receipt_change.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_receipt_change.Location = New System.Drawing.Point(194, 110)
        Me.lbl_receipt_change.Name = "lbl_receipt_change"
        Me.lbl_receipt_change.Size = New System.Drawing.Size(80, 16)
        Me.lbl_receipt_change.TabIndex = 48
        Me.lbl_receipt_change.Text = "0.00"
        Me.lbl_receipt_change.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_receipt_subtotal
        '
        Me.lbl_receipt_subtotal.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_receipt_subtotal.Location = New System.Drawing.Point(194, 6)
        Me.lbl_receipt_subtotal.Name = "lbl_receipt_subtotal"
        Me.lbl_receipt_subtotal.Size = New System.Drawing.Size(80, 13)
        Me.lbl_receipt_subtotal.TabIndex = 49
        Me.lbl_receipt_subtotal.Text = "0.00"
        Me.lbl_receipt_subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_receipt_tendered
        '
        Me.lbl_receipt_tendered.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_receipt_tendered.Location = New System.Drawing.Point(194, 59)
        Me.lbl_receipt_tendered.Name = "lbl_receipt_tendered"
        Me.lbl_receipt_tendered.Size = New System.Drawing.Size(80, 15)
        Me.lbl_receipt_tendered.TabIndex = 50
        Me.lbl_receipt_tendered.Text = "0.00"
        Me.lbl_receipt_tendered.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'change
        '
        Me.change.AutoSize = true
        Me.change.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.change.Location = New System.Drawing.Point(1, 110)
        Me.change.Name = "change"
        Me.change.Size = New System.Drawing.Size(95, 18)
        Me.change.TabIndex = 52
        Me.change.Text = "Change    :"
        '
        'subTotal
        '
        Me.subTotal.AutoSize = true
        Me.subTotal.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.subTotal.Location = New System.Drawing.Point(1, 6)
        Me.subTotal.Name = "subTotal"
        Me.subTotal.Size = New System.Drawing.Size(69, 13)
        Me.subTotal.TabIndex = 51
        Me.subTotal.Text = "Sub Total :"
        '
        'Cash
        '
        Me.Cash.AutoSize = true
        Me.Cash.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Cash.Location = New System.Drawing.Point(1, 59)
        Me.Cash.Name = "Cash"
        Me.Cash.Size = New System.Drawing.Size(102, 13)
        Me.Cash.TabIndex = 53
        Me.Cash.Text = "Cash Tendered :"
        '
        'lbl_receipt_totalamt
        '
        Me.lbl_receipt_totalamt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_receipt_totalamt.Location = New System.Drawing.Point(194, 42)
        Me.lbl_receipt_totalamt.Name = "lbl_receipt_totalamt"
        Me.lbl_receipt_totalamt.Size = New System.Drawing.Size(80, 13)
        Me.lbl_receipt_totalamt.TabIndex = 45
        Me.lbl_receipt_totalamt.Text = "0.00"
        Me.lbl_receipt_totalamt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalAmount
        '
        Me.TotalAmount.AutoSize = true
        Me.TotalAmount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TotalAmount.Location = New System.Drawing.Point(1, 42)
        Me.TotalAmount.Name = "TotalAmount"
        Me.TotalAmount.Size = New System.Drawing.Size(91, 13)
        Me.TotalAmount.TabIndex = 46
        Me.TotalAmount.Text = "Total Amount :"
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = false
        Me.dgw.AllowUserToDeleteRows = false
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgw.BackgroundColor = System.Drawing.Color.White
        Me.dgw.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgw.ColumnHeadersHeight = 24
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Description, Me.Amount})
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgw.Enabled = false
        Me.dgw.GridColor = System.Drawing.Color.White
        Me.dgw.Location = New System.Drawing.Point(4, 150)
        Me.dgw.MultiSelect = false
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = true
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgw.RowHeadersVisible = false
        Me.dgw.RowHeadersWidth = 25
        Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.dgw.RowTemplate.Height = 18
        Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgw.Size = New System.Drawing.Size(296, 51)
        Me.dgw.TabIndex = 39
        '
        'Description
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Description.DefaultCellStyle = DataGridViewCellStyle10
        Me.Description.FillWeight = 7.575758!
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = true
        Me.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Description.Width = 205
        '
        'Amount
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle11.Format = "#,##0.00"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle11
        Me.Amount.FillWeight = 191.2536!
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = true
        Me.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Amount.Width = 85
        '
        'lbl_cashier
        '
        Me.lbl_cashier.Location = New System.Drawing.Point(63, 112)
        Me.lbl_cashier.Name = "lbl_cashier"
        Me.lbl_cashier.Size = New System.Drawing.Size(237, 13)
        Me.lbl_cashier.TabIndex = 1
        Me.lbl_cashier.Text = "Name"
        Me.lbl_cashier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_date
        '
        Me.lbl_date.Location = New System.Drawing.Point(2, 76)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(301, 13)
        Me.lbl_date.TabIndex = 1
        Me.lbl_date.Text = "Current DATETIME"
        Me.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = true
        Me.Label18.Location = New System.Drawing.Point(6, 112)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 13)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Cashier :"
        '
        'lbl_trans_no
        '
        Me.lbl_trans_no.AutoSize = true
        Me.lbl_trans_no.Location = New System.Drawing.Point(83, 97)
        Me.lbl_trans_no.Name = "lbl_trans_no"
        Me.lbl_trans_no.Size = New System.Drawing.Size(49, 13)
        Me.lbl_trans_no.TabIndex = 1
        Me.lbl_trans_no.Text = "Invoice"
        '
        'Label21
        '
        Me.Label21.AutoSize = true
        Me.Label21.Location = New System.Drawing.Point(6, 97)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 13)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Invoice No :"
        '
        'lbl_tin
        '
        Me.lbl_tin.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_tin.Location = New System.Drawing.Point(0, 54)
        Me.lbl_tin.Name = "lbl_tin"
        Me.lbl_tin.Size = New System.Drawing.Size(303, 13)
        Me.lbl_tin.TabIndex = 0
        Me.lbl_tin.Text = "TIN#: 119-239-518"
        Me.lbl_tin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_store_name
        '
        Me.lbl_store_name.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_store_name.Location = New System.Drawing.Point(1, 17)
        Me.lbl_store_name.Name = "lbl_store_name"
        Me.lbl_store_name.Size = New System.Drawing.Size(302, 14)
        Me.lbl_store_name.TabIndex = 0
        Me.lbl_store_name.Text = "[Company Name Here]"
        Me.lbl_store_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintDocument1
        '
        '
        'frm_receipt_preview_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(405, 607)
        Me.Controls.Add(Me.pnl_container)
        Me.Controls.Add(Me.lbl_custname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_close)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frm_receipt_preview_customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - Receipt Preview"
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.pnl_container.ResumeLayout(false)
        Me.pnl_receipt.ResumeLayout(false)
        Me.pnl_receipt.PerformLayout
        Me.pnl_total.ResumeLayout(false)
        Me.pnl_total.PerformLayout
        CType(Me.dgw,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_disc_percent As System.Windows.Forms.Label
    Friend WithEvents lbl_total_disc As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbl_sub_total As System.Windows.Forms.Label
    Friend WithEvents lbl_grand_total As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmd_close As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_custname As System.Windows.Forms.Label
    Friend WithEvents lbl_item_count As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_change As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lbl_cash_tendered As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbl_rem_balance As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lbl_partial_payment As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents pnl_container As System.Windows.Forms.Panel
    Friend WithEvents pnl_receipt As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl_store_address As System.Windows.Forms.Label
    Friend WithEvents pnl_total As System.Windows.Forms.Panel
    Friend WithEvents lbl_receipt_totaldisc As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lbl_closing_2 As System.Windows.Forms.Label
    Friend WithEvents lbl_closing_1 As System.Windows.Forms.Label
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents lbl_receipt_change As System.Windows.Forms.Label
    Friend WithEvents lbl_receipt_subtotal As System.Windows.Forms.Label
    Friend WithEvents lbl_receipt_tendered As System.Windows.Forms.Label
    Friend WithEvents change As System.Windows.Forms.Label
    Friend WithEvents subTotal As System.Windows.Forms.Label
    Friend WithEvents Cash As System.Windows.Forms.Label
    Friend WithEvents lbl_receipt_totalamt As System.Windows.Forms.Label
    Friend WithEvents TotalAmount As System.Windows.Forms.Label
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_cashier As System.Windows.Forms.Label
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbl_trans_no As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lbl_tin As System.Windows.Forms.Label
    Friend WithEvents lbl_store_name As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
