<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_trans_info
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_items = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmd_print_receipt = New System.Windows.Forms.Button()
        Me.lbl_balance = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_change = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_partial_pay = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_cash_tendered = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmd_delete_trans = New System.Windows.Forms.Button()
        Me.lbl_cust_no = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lbl_cust_name = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_date_time = New System.Windows.Forms.Label()
        Me.lbl_disc_percent = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmd_cancel = New System.Windows.Forms.Button()
        Me.lbl_total_discount = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lbl_sub_total_grand = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lbl_grand_total = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgv_sold_items = New System.Windows.Forms.DataGridView()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_trans_no = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.pnl_container = New System.Windows.Forms.Panel()
        Me.pnl_receipt = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_store_address = New System.Windows.Forms.Label()
        Me.pnl_total = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbl_tin = New System.Windows.Forms.Label()
        Me.lbl_store_name = New System.Windows.Forms.Label()
        Me.item_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buying_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.purchase_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_sold_items, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_container.SuspendLayout()
        Me.pnl_receipt.SuspendLayout()
        Me.pnl_total.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.lbl_items)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmd_print_receipt)
        Me.GroupBox1.Controls.Add(Me.lbl_balance)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lbl_change)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lbl_partial_pay)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lbl_cash_tendered)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmd_delete_trans)
        Me.GroupBox1.Controls.Add(Me.lbl_cust_no)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.lbl_cust_name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbl_date_time)
        Me.GroupBox1.Controls.Add(Me.lbl_disc_percent)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmd_cancel)
        Me.GroupBox1.Controls.Add(Me.lbl_total_discount)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.lbl_sub_total_grand)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.lbl_grand_total)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dgv_sold_items)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.lbl_trans_no)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(765, 541)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'lbl_items
        '
        Me.lbl_items.BackColor = System.Drawing.Color.White
        Me.lbl_items.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_items.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_items.Location = New System.Drawing.Point(407, 383)
        Me.lbl_items.Name = "lbl_items"
        Me.lbl_items.Size = New System.Drawing.Size(53, 22)
        Me.lbl_items.TabIndex = 67
        Me.lbl_items.Text = " "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(308, 386)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 18)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Item Count :"
        '
        'cmd_print_receipt
        '
        Me.cmd_print_receipt.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_print_receipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_print_receipt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_print_receipt.ForeColor = System.Drawing.Color.White
        Me.cmd_print_receipt.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_print_receipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_print_receipt.Location = New System.Drawing.Point(454, 89)
        Me.cmd_print_receipt.Name = "cmd_print_receipt"
        Me.cmd_print_receipt.Size = New System.Drawing.Size(133, 30)
        Me.cmd_print_receipt.TabIndex = 65
        Me.cmd_print_receipt.Text = "Re-print Receipt"
        Me.cmd_print_receipt.UseVisualStyleBackColor = False
        '
        'lbl_balance
        '
        Me.lbl_balance.BackColor = System.Drawing.Color.White
        Me.lbl_balance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_balance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_balance.Location = New System.Drawing.Point(593, 512)
        Me.lbl_balance.Name = "lbl_balance"
        Me.lbl_balance.Size = New System.Drawing.Size(144, 22)
        Me.lbl_balance.TabIndex = 64
        Me.lbl_balance.Text = " "
        Me.lbl_balance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(519, 513)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 18)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Balance :"
        '
        'lbl_change
        '
        Me.lbl_change.BackColor = System.Drawing.Color.White
        Me.lbl_change.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_change.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_change.Location = New System.Drawing.Point(350, 462)
        Me.lbl_change.Name = "lbl_change"
        Me.lbl_change.Size = New System.Drawing.Size(110, 22)
        Me.lbl_change.TabIndex = 62
        Me.lbl_change.Text = " "
        Me.lbl_change.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(277, 463)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 18)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Change :"
        '
        'lbl_partial_pay
        '
        Me.lbl_partial_pay.BackColor = System.Drawing.Color.White
        Me.lbl_partial_pay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_partial_pay.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_partial_pay.Location = New System.Drawing.Point(593, 487)
        Me.lbl_partial_pay.Name = "lbl_partial_pay"
        Me.lbl_partial_pay.Size = New System.Drawing.Size(144, 22)
        Me.lbl_partial_pay.TabIndex = 60
        Me.lbl_partial_pay.Text = " "
        Me.lbl_partial_pay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(468, 488)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 18)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Partial Payment :"
        '
        'lbl_cash_tendered
        '
        Me.lbl_cash_tendered.BackColor = System.Drawing.Color.White
        Me.lbl_cash_tendered.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_cash_tendered.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cash_tendered.Location = New System.Drawing.Point(593, 462)
        Me.lbl_cash_tendered.Name = "lbl_cash_tendered"
        Me.lbl_cash_tendered.Size = New System.Drawing.Size(144, 22)
        Me.lbl_cash_tendered.TabIndex = 58
        Me.lbl_cash_tendered.Text = " "
        Me.lbl_cash_tendered.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(469, 463)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 18)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Cash Tendered :"
        '
        'cmd_delete_trans
        '
        Me.cmd_delete_trans.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_delete_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_delete_trans.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_delete_trans.ForeColor = System.Drawing.Color.White
        Me.cmd_delete_trans.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_delete_trans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_delete_trans.Location = New System.Drawing.Point(602, 89)
        Me.cmd_delete_trans.Name = "cmd_delete_trans"
        Me.cmd_delete_trans.Size = New System.Drawing.Size(135, 30)
        Me.cmd_delete_trans.TabIndex = 0
        Me.cmd_delete_trans.Text = "Delete Transaction"
        Me.cmd_delete_trans.UseVisualStyleBackColor = False
        '
        'lbl_cust_no
        '
        Me.lbl_cust_no.BackColor = System.Drawing.Color.White
        Me.lbl_cust_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_cust_no.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cust_no.Location = New System.Drawing.Point(148, 65)
        Me.lbl_cust_no.Name = "lbl_cust_no"
        Me.lbl_cust_no.Size = New System.Drawing.Size(227, 22)
        Me.lbl_cust_no.TabIndex = 55
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(18, 66)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(109, 18)
        Me.Label22.TabIndex = 54
        Me.Label22.Text = "Customer No. :"
        '
        'lbl_cust_name
        '
        Me.lbl_cust_name.BackColor = System.Drawing.Color.White
        Me.lbl_cust_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_cust_name.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cust_name.Location = New System.Drawing.Point(149, 93)
        Me.lbl_cust_name.Name = "lbl_cust_name"
        Me.lbl_cust_name.Size = New System.Drawing.Size(227, 22)
        Me.lbl_cust_name.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 18)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Customer Name :"
        '
        'lbl_date_time
        '
        Me.lbl_date_time.BackColor = System.Drawing.Color.White
        Me.lbl_date_time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_date_time.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date_time.Location = New System.Drawing.Point(518, 36)
        Me.lbl_date_time.Name = "lbl_date_time"
        Me.lbl_date_time.Size = New System.Drawing.Size(219, 22)
        Me.lbl_date_time.TabIndex = 51
        '
        'lbl_disc_percent
        '
        Me.lbl_disc_percent.BackColor = System.Drawing.Color.White
        Me.lbl_disc_percent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_disc_percent.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_disc_percent.Location = New System.Drawing.Point(407, 408)
        Me.lbl_disc_percent.Name = "lbl_disc_percent"
        Me.lbl_disc_percent.Size = New System.Drawing.Size(53, 22)
        Me.lbl_disc_percent.TabIndex = 50
        Me.lbl_disc_percent.Text = " "
        Me.lbl_disc_percent.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(308, 409)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 18)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Discount % :"
        Me.Label3.Visible = False
        '
        'cmd_cancel
        '
        Me.cmd_cancel.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_cancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_cancel.ForeColor = System.Drawing.Color.White
        Me.cmd_cancel.Location = New System.Drawing.Point(10, 472)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(196, 59)
        Me.cmd_cancel.TabIndex = 1
        Me.cmd_cancel.Text = "Close"
        Me.cmd_cancel.UseVisualStyleBackColor = False
        '
        'lbl_total_discount
        '
        Me.lbl_total_discount.BackColor = System.Drawing.Color.White
        Me.lbl_total_discount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_total_discount.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_discount.Location = New System.Drawing.Point(593, 408)
        Me.lbl_total_discount.Name = "lbl_total_discount"
        Me.lbl_total_discount.Size = New System.Drawing.Size(144, 22)
        Me.lbl_total_discount.TabIndex = 44
        Me.lbl_total_discount.Text = " "
        Me.lbl_total_discount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(476, 409)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(111, 18)
        Me.Label27.TabIndex = 43
        Me.Label27.Text = "Total Discount :"
        '
        'lbl_sub_total_grand
        '
        Me.lbl_sub_total_grand.BackColor = System.Drawing.Color.White
        Me.lbl_sub_total_grand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_sub_total_grand.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sub_total_grand.Location = New System.Drawing.Point(593, 383)
        Me.lbl_sub_total_grand.Name = "lbl_sub_total_grand"
        Me.lbl_sub_total_grand.Size = New System.Drawing.Size(144, 22)
        Me.lbl_sub_total_grand.TabIndex = 42
        Me.lbl_sub_total_grand.Text = " "
        Me.lbl_sub_total_grand.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(507, 387)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 18)
        Me.Label25.TabIndex = 41
        Me.Label25.Text = "Sub Total :"
        '
        'lbl_grand_total
        '
        Me.lbl_grand_total.BackColor = System.Drawing.Color.White
        Me.lbl_grand_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_grand_total.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_grand_total.Location = New System.Drawing.Point(593, 433)
        Me.lbl_grand_total.Name = "lbl_grand_total"
        Me.lbl_grand_total.Size = New System.Drawing.Size(144, 22)
        Me.lbl_grand_total.TabIndex = 37
        Me.lbl_grand_total.Text = " "
        Me.lbl_grand_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(492, 434)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 18)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Grand Total :"
        '
        'dgv_sold_items
        '
        Me.dgv_sold_items.AllowUserToAddRows = False
        Me.dgv_sold_items.AllowUserToDeleteRows = False
        Me.dgv_sold_items.AllowUserToResizeRows = False
        Me.dgv_sold_items.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_sold_items.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_sold_items.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_sold_items.ColumnHeadersHeight = 25
        Me.dgv_sold_items.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item_no, Me.barcode, Me.item_name, Me.quantity, Me.unit, Me.buying_price, Me.total_amount, Me.discount, Me.purchase_price, Me.category})
        Me.dgv_sold_items.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_sold_items.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_sold_items.EnableHeadersVisualStyles = False
        Me.dgv_sold_items.Location = New System.Drawing.Point(3, 166)
        Me.dgv_sold_items.MultiSelect = False
        Me.dgv_sold_items.Name = "dgv_sold_items"
        Me.dgv_sold_items.ReadOnly = True
        Me.dgv_sold_items.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_sold_items.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_sold_items.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_sold_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_sold_items.Size = New System.Drawing.Size(757, 205)
        Me.dgv_sold_items.TabIndex = 29
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(-1, 129)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(768, 27)
        Me.Label23.TabIndex = 34
        Me.Label23.Text = "  Sold Items"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(-1, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(768, 27)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "  On - Account Sales Transaction Info."
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(398, 37)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(116, 18)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Date and Time :"
        '
        'lbl_trans_no
        '
        Me.lbl_trans_no.BackColor = System.Drawing.Color.White
        Me.lbl_trans_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_trans_no.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_trans_no.Location = New System.Drawing.Point(148, 36)
        Me.lbl_trans_no.Name = "lbl_trans_no"
        Me.lbl_trans_no.Size = New System.Drawing.Size(131, 22)
        Me.lbl_trans_no.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(18, 37)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(122, 18)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Transaction No. :"
        '
        'PrintDocument1
        '
        '
        'pnl_container
        '
        Me.pnl_container.Controls.Add(Me.pnl_receipt)
        Me.pnl_container.Location = New System.Drawing.Point(773, 3)
        Me.pnl_container.Name = "pnl_container"
        Me.pnl_container.Size = New System.Drawing.Size(332, 555)
        Me.pnl_container.TabIndex = 96
        Me.pnl_container.Visible = False
        '
        'pnl_receipt
        '
        Me.pnl_receipt.BackColor = System.Drawing.Color.White
        Me.pnl_receipt.Controls.Add(Me.Label1)
        Me.pnl_receipt.Controls.Add(Me.lbl_store_address)
        Me.pnl_receipt.Controls.Add(Me.pnl_total)
        Me.pnl_receipt.Controls.Add(Me.dgw)
        Me.pnl_receipt.Controls.Add(Me.lbl_cashier)
        Me.pnl_receipt.Controls.Add(Me.lbl_date)
        Me.pnl_receipt.Controls.Add(Me.Label13)
        Me.pnl_receipt.Controls.Add(Me.Label14)
        Me.pnl_receipt.Controls.Add(Me.Label21)
        Me.pnl_receipt.Controls.Add(Me.lbl_tin)
        Me.pnl_receipt.Controls.Add(Me.lbl_store_name)
        Me.pnl_receipt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_receipt.Location = New System.Drawing.Point(3, 3)
        Me.pnl_receipt.Name = "pnl_receipt"
        Me.pnl_receipt.Size = New System.Drawing.Size(303, 433)
        Me.pnl_receipt.TabIndex = 89
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Customer :"
        '
        'lbl_store_address
        '
        Me.lbl_store_address.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.pnl_total.Controls.Add(Me.Label5)
        Me.pnl_total.Controls.Add(Me.Label10)
        Me.pnl_total.Controls.Add(Me.Label12)
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
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(194, 93)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 15)
        Me.Label24.TabIndex = 61
        Me.Label24.Text = "0.00"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Remaining Balance :"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(194, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 15)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "0.00"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 13)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "Partial Payment :"
        '
        'lbl_receipt_totaldisc
        '
        Me.lbl_receipt_totaldisc.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_receipt_totaldisc.Location = New System.Drawing.Point(194, 24)
        Me.lbl_receipt_totaldisc.Name = "lbl_receipt_totaldisc"
        Me.lbl_receipt_totaldisc.Size = New System.Drawing.Size(80, 13)
        Me.lbl_receipt_totaldisc.TabIndex = 57
        Me.lbl_receipt_totaldisc.Text = "0.00"
        Me.lbl_receipt_totaldisc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(1, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 13)
        Me.Label20.TabIndex = 58
        Me.Label20.Text = "Total Discount :"
        '
        'lbl_closing_2
        '
        Me.lbl_closing_2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lblLine.AutoSize = True
        Me.lblLine.Location = New System.Drawing.Point(2, 136)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(277, 13)
        Me.lblLine.TabIndex = 54
        Me.lblLine.Text = "=============================="
        '
        'lbl_receipt_change
        '
        Me.lbl_receipt_change.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_receipt_change.Location = New System.Drawing.Point(194, 110)
        Me.lbl_receipt_change.Name = "lbl_receipt_change"
        Me.lbl_receipt_change.Size = New System.Drawing.Size(80, 16)
        Me.lbl_receipt_change.TabIndex = 48
        Me.lbl_receipt_change.Text = "0.00"
        Me.lbl_receipt_change.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_receipt_subtotal
        '
        Me.lbl_receipt_subtotal.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_receipt_subtotal.Location = New System.Drawing.Point(194, 6)
        Me.lbl_receipt_subtotal.Name = "lbl_receipt_subtotal"
        Me.lbl_receipt_subtotal.Size = New System.Drawing.Size(80, 13)
        Me.lbl_receipt_subtotal.TabIndex = 49
        Me.lbl_receipt_subtotal.Text = "0.00"
        Me.lbl_receipt_subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_receipt_tendered
        '
        Me.lbl_receipt_tendered.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_receipt_tendered.Location = New System.Drawing.Point(194, 59)
        Me.lbl_receipt_tendered.Name = "lbl_receipt_tendered"
        Me.lbl_receipt_tendered.Size = New System.Drawing.Size(80, 15)
        Me.lbl_receipt_tendered.TabIndex = 50
        Me.lbl_receipt_tendered.Text = "0.00"
        Me.lbl_receipt_tendered.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'change
        '
        Me.change.AutoSize = True
        Me.change.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change.Location = New System.Drawing.Point(1, 110)
        Me.change.Name = "change"
        Me.change.Size = New System.Drawing.Size(95, 18)
        Me.change.TabIndex = 52
        Me.change.Text = "Change    :"
        '
        'subTotal
        '
        Me.subTotal.AutoSize = True
        Me.subTotal.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subTotal.Location = New System.Drawing.Point(1, 6)
        Me.subTotal.Name = "subTotal"
        Me.subTotal.Size = New System.Drawing.Size(69, 13)
        Me.subTotal.TabIndex = 51
        Me.subTotal.Text = "Sub Total :"
        '
        'Cash
        '
        Me.Cash.AutoSize = True
        Me.Cash.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cash.Location = New System.Drawing.Point(1, 59)
        Me.Cash.Name = "Cash"
        Me.Cash.Size = New System.Drawing.Size(102, 13)
        Me.Cash.TabIndex = 53
        Me.Cash.Text = "Cash Tendered :"
        '
        'lbl_receipt_totalamt
        '
        Me.lbl_receipt_totalamt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_receipt_totalamt.Location = New System.Drawing.Point(194, 42)
        Me.lbl_receipt_totalamt.Name = "lbl_receipt_totalamt"
        Me.lbl_receipt_totalamt.Size = New System.Drawing.Size(80, 13)
        Me.lbl_receipt_totalamt.TabIndex = 45
        Me.lbl_receipt_totalamt.Text = "0.00"
        Me.lbl_receipt_totalamt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalAmount
        '
        Me.TotalAmount.AutoSize = True
        Me.TotalAmount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmount.Location = New System.Drawing.Point(1, 42)
        Me.TotalAmount.Name = "TotalAmount"
        Me.TotalAmount.Size = New System.Drawing.Size(91, 13)
        Me.TotalAmount.TabIndex = 46
        Me.TotalAmount.Text = "Total Amount :"
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgw.BackgroundColor = System.Drawing.Color.White
        Me.dgw.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgw.ColumnHeadersHeight = 24
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Description, Me.Amount})
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgw.Enabled = False
        Me.dgw.GridColor = System.Drawing.Color.White
        Me.dgw.Location = New System.Drawing.Point(4, 150)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgw.RowHeadersVisible = False
        Me.dgw.RowHeadersWidth = 25
        Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgw.RowTemplate.Height = 18
        Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgw.Size = New System.Drawing.Size(296, 51)
        Me.dgw.TabIndex = 39
        '
        'Description
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Description.DefaultCellStyle = DataGridViewCellStyle6
        Me.Description.FillWeight = 7.575758!
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Description.Width = 205
        '
        'Amount
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle7.Format = "#,##0.00"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle7
        Me.Amount.FillWeight = 191.2536!
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
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
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Cashier :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(83, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Invoice"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 97)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 13)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Invoice No :"
        '
        'lbl_tin
        '
        Me.lbl_tin.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tin.Location = New System.Drawing.Point(0, 54)
        Me.lbl_tin.Name = "lbl_tin"
        Me.lbl_tin.Size = New System.Drawing.Size(303, 13)
        Me.lbl_tin.TabIndex = 0
        Me.lbl_tin.Text = "TIN#: 119-239-518"
        Me.lbl_tin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_store_name
        '
        Me.lbl_store_name.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_store_name.Location = New System.Drawing.Point(1, 17)
        Me.lbl_store_name.Name = "lbl_store_name"
        Me.lbl_store_name.Size = New System.Drawing.Size(302, 14)
        Me.lbl_store_name.TabIndex = 0
        Me.lbl_store_name.Text = "[Company Name Here]"
        Me.lbl_store_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'item_no
        '
        Me.item_no.HeaderText = "Item No."
        Me.item_no.Name = "item_no"
        Me.item_no.ReadOnly = True
        Me.item_no.Width = 60
        '
        'barcode
        '
        Me.barcode.HeaderText = "Barcode"
        Me.barcode.Name = "barcode"
        Me.barcode.ReadOnly = True
        Me.barcode.Width = 110
        '
        'item_name
        '
        Me.item_name.HeaderText = "Item Name"
        Me.item_name.Name = "item_name"
        Me.item_name.ReadOnly = True
        Me.item_name.Width = 215
        '
        'quantity
        '
        Me.quantity.HeaderText = "Qty."
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        Me.quantity.Width = 55
        '
        'unit
        '
        Me.unit.HeaderText = "Unit"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        Me.unit.Width = 50
        '
        'buying_price
        '
        Me.buying_price.HeaderText = "Price"
        Me.buying_price.Name = "buying_price"
        Me.buying_price.ReadOnly = True
        Me.buying_price.Width = 70
        '
        'total_amount
        '
        Me.total_amount.HeaderText = "Amount"
        Me.total_amount.Name = "total_amount"
        Me.total_amount.ReadOnly = True
        Me.total_amount.Width = 90
        '
        'discount
        '
        Me.discount.HeaderText = "Discount"
        Me.discount.Name = "discount"
        Me.discount.ReadOnly = True
        Me.discount.Width = 90
        '
        'purchase_price
        '
        Me.purchase_price.HeaderText = "purchase_price"
        Me.purchase_price.Name = "purchase_price"
        Me.purchase_price.ReadOnly = True
        Me.purchase_price.Visible = False
        '
        'category
        '
        Me.category.HeaderText = "category"
        Me.category.Name = "category"
        Me.category.ReadOnly = True
        Me.category.Visible = False
        '
        'frm_trans_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 548)
        Me.Controls.Add(Me.pnl_container)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_trans_info"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - Transaction Info"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_sold_items, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_container.ResumeLayout(False)
        Me.pnl_receipt.ResumeLayout(False)
        Me.pnl_receipt.PerformLayout()
        Me.pnl_total.ResumeLayout(False)
        Me.pnl_total.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_cancel As System.Windows.Forms.Button
    Friend WithEvents lbl_total_discount As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lbl_sub_total_grand As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lbl_grand_total As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgv_sold_items As System.Windows.Forms.DataGridView
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbl_trans_no As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbl_disc_percent As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_date_time As System.Windows.Forms.Label
    Friend WithEvents cmd_delete_trans As System.Windows.Forms.Button
    Friend WithEvents lbl_cust_no As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lbl_cust_name As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_cash_tendered As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_partial_pay As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_change As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_balance As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmd_print_receipt As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents lbl_items As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pnl_container As System.Windows.Forms.Panel
    Friend WithEvents pnl_receipt As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_store_address As System.Windows.Forms.Label
    Friend WithEvents pnl_total As System.Windows.Forms.Panel
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
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
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_cashier As System.Windows.Forms.Label
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lbl_tin As System.Windows.Forms.Label
    Friend WithEvents lbl_store_name As System.Windows.Forms.Label
    Friend WithEvents item_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents barcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents buying_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents purchase_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents category As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
