<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_invoice
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_barcode = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_item_count = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_disc_percent = New System.Windows.Forms.Label()
        Me.lbl_total_disc = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_sub_total = New System.Windows.Forms.Label()
        Me.lbl_grand_total = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmd_pay = New System.Windows.Forms.Button()
        Me.cmd_cancel_invoice = New System.Windows.Forms.Button()
        Me.cmd_item_lookup = New System.Windows.Forms.Button()
        Me.cmd_resume = New System.Windows.Forms.Button()
        Me.cmd_close = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReciptSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_barcode_status = New System.Windows.Forms.Label()
        Me.dgv_item_cart = New System.Windows.Forms.DataGridView()
        Me.item_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selling_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buying_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.remove_btn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_trans_no = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.st_date = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ss_time_and_date = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ss_user = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel9 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ss_position = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmd_hold = New System.Windows.Forms.Button()
        Me.cmd_change_qty = New System.Windows.Forms.Button()
        Me.cmd_discount = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout
        Me.MenuStrip1.SuspendLayout
        CType(Me.dgv_item_cart,System.ComponentModel.ISupportInitialize).BeginInit
        Me.StatusStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Input Barcode Here."
        '
        'txt_barcode
        '
        Me.txt_barcode.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_barcode.Location = New System.Drawing.Point(11, 59)
        Me.txt_barcode.MaxLength = 20
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Size = New System.Drawing.Size(299, 30)
        Me.txt_barcode.TabIndex = 0
        Me.txt_barcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.lbl_item_count)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lbl_disc_percent)
        Me.Panel1.Controls.Add(Me.lbl_total_disc)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.lbl_sub_total)
        Me.Panel1.Controls.Add(Me.lbl_grand_total)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(842, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(486, 211)
        Me.Panel1.TabIndex = 65
        '
        'lbl_item_count
        '
        Me.lbl_item_count.AutoSize = true
        Me.lbl_item_count.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_item_count.ForeColor = System.Drawing.Color.Lime
        Me.lbl_item_count.Location = New System.Drawing.Point(240, 162)
        Me.lbl_item_count.Name = "lbl_item_count"
        Me.lbl_item_count.Size = New System.Drawing.Size(26, 29)
        Me.lbl_item_count.TabIndex = 22
        Me.lbl_item_count.Text = "0"
        Me.lbl_item_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Lime
        Me.Label9.Location = New System.Drawing.Point(19, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(226, 29)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Total No. of Item(s)"
        '
        'lbl_disc_percent
        '
        Me.lbl_disc_percent.AutoSize = true
        Me.lbl_disc_percent.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_disc_percent.ForeColor = System.Drawing.Color.Lime
        Me.lbl_disc_percent.Location = New System.Drawing.Point(240, 59)
        Me.lbl_disc_percent.Name = "lbl_disc_percent"
        Me.lbl_disc_percent.Size = New System.Drawing.Size(26, 29)
        Me.lbl_disc_percent.TabIndex = 20
        Me.lbl_disc_percent.Text = "0"
        Me.lbl_disc_percent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_disc_percent.Visible = false
        '
        'lbl_total_disc
        '
        Me.lbl_total_disc.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_total_disc.ForeColor = System.Drawing.Color.Lime
        Me.lbl_total_disc.Location = New System.Drawing.Point(236, 63)
        Me.lbl_total_disc.Name = "lbl_total_disc"
        Me.lbl_total_disc.Size = New System.Drawing.Size(228, 25)
        Me.lbl_total_disc.TabIndex = 9
        Me.lbl_total_disc.Text = "0.00"
        Me.lbl_total_disc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Lime
        Me.Label13.Location = New System.Drawing.Point(19, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(203, 29)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Total Discount (P)"
        '
        'lbl_sub_total
        '
        Me.lbl_sub_total.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_sub_total.ForeColor = System.Drawing.Color.Lime
        Me.lbl_sub_total.Location = New System.Drawing.Point(235, 22)
        Me.lbl_sub_total.Name = "lbl_sub_total"
        Me.lbl_sub_total.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_sub_total.Size = New System.Drawing.Size(229, 25)
        Me.lbl_sub_total.TabIndex = 7
        Me.lbl_sub_total.Text = "0.00"
        Me.lbl_sub_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_grand_total
        '
        Me.lbl_grand_total.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_grand_total.ForeColor = System.Drawing.Color.Lime
        Me.lbl_grand_total.Location = New System.Drawing.Point(236, 109)
        Me.lbl_grand_total.Name = "lbl_grand_total"
        Me.lbl_grand_total.Size = New System.Drawing.Size(233, 33)
        Me.lbl_grand_total.TabIndex = 5
        Me.lbl_grand_total.Text = "0.00"
        Me.lbl_grand_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(18, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(212, 35)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Grand Total (P)"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(19, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sub Total (P)"
        '
        'cmd_pay
        '
        Me.cmd_pay.BackColor = System.Drawing.Color.DarkGreen
        Me.cmd_pay.Font = New System.Drawing.Font("Tahoma", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_pay.ForeColor = System.Drawing.Color.White
        Me.cmd_pay.Location = New System.Drawing.Point(842, 256)
        Me.cmd_pay.Name = "cmd_pay"
        Me.cmd_pay.Size = New System.Drawing.Size(486, 111)
        Me.cmd_pay.TabIndex = 1
        Me.cmd_pay.Text = "PAY"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&" (Ctrl + P)"
        Me.cmd_pay.UseVisualStyleBackColor = false
        '
        'cmd_cancel_invoice
        '
        Me.cmd_cancel_invoice.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_cancel_invoice.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.cmd_cancel_invoice.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_cancel_invoice.ForeColor = System.Drawing.Color.White
        Me.cmd_cancel_invoice.Location = New System.Drawing.Point(1173, 372)
        Me.cmd_cancel_invoice.Name = "cmd_cancel_invoice"
        Me.cmd_cancel_invoice.Size = New System.Drawing.Size(155, 123)
        Me.cmd_cancel_invoice.TabIndex = 7
        Me.cmd_cancel_invoice.Text = "Clear Invoice"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"(Ctrl + E)"
        Me.cmd_cancel_invoice.UseVisualStyleBackColor = false
        '
        'cmd_item_lookup
        '
        Me.cmd_item_lookup.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_item_lookup.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.cmd_item_lookup.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_item_lookup.ForeColor = System.Drawing.Color.White
        Me.cmd_item_lookup.Location = New System.Drawing.Point(842, 501)
        Me.cmd_item_lookup.Name = "cmd_item_lookup"
        Me.cmd_item_lookup.Size = New System.Drawing.Size(164, 124)
        Me.cmd_item_lookup.TabIndex = 3
        Me.cmd_item_lookup.Text = "Item Look Up"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"(Ctrl + I)"
        Me.cmd_item_lookup.UseVisualStyleBackColor = false
        '
        'cmd_resume
        '
        Me.cmd_resume.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_resume.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.cmd_resume.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_resume.ForeColor = System.Drawing.Color.White
        Me.cmd_resume.Location = New System.Drawing.Point(1012, 546)
        Me.cmd_resume.Name = "cmd_resume"
        Me.cmd_resume.Size = New System.Drawing.Size(155, 79)
        Me.cmd_resume.TabIndex = 6
        Me.cmd_resume.Text = "Resume"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"(Ctrl + R"
        Me.cmd_resume.UseVisualStyleBackColor = false
        '
        'cmd_close
        '
        Me.cmd_close.BackColor = System.Drawing.Color.Red
        Me.cmd_close.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.cmd_close.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_close.ForeColor = System.Drawing.Color.White
        Me.cmd_close.Location = New System.Drawing.Point(1173, 501)
        Me.cmd_close.Name = "cmd_close"
        Me.cmd_close.Size = New System.Drawing.Size(155, 124)
        Me.cmd_close.TabIndex = 8
        Me.cmd_close.Text = "Close"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"(Esc)"
        Me.cmd_close.UseVisualStyleBackColor = false
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReciptSettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1340, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReciptSettingsToolStripMenuItem
        '
        Me.ReciptSettingsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReciptSettingsToolStripMenuItem.Name = "ReciptSettingsToolStripMenuItem"
        Me.ReciptSettingsToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.ReciptSettingsToolStripMenuItem.Text = "Recipt Settings"
        '
        'lbl_barcode_status
        '
        Me.lbl_barcode_status.AutoSize = true
        Me.lbl_barcode_status.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_barcode_status.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_barcode_status.Location = New System.Drawing.Point(163, 36)
        Me.lbl_barcode_status.Name = "lbl_barcode_status"
        Me.lbl_barcode_status.Size = New System.Drawing.Size(14, 19)
        Me.lbl_barcode_status.TabIndex = 78
        Me.lbl_barcode_status.Text = "."
        '
        'dgv_item_cart
        '
        Me.dgv_item_cart.AllowUserToAddRows = false
        Me.dgv_item_cart.AllowUserToDeleteRows = false
        Me.dgv_item_cart.AllowUserToResizeColumns = false
        Me.dgv_item_cart.AllowUserToResizeRows = false
        Me.dgv_item_cart.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_item_cart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_item_cart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_item_cart.ColumnHeadersHeight = 30
        Me.dgv_item_cart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item_no, Me.barcode, Me.item_name, Me.selling_price, Me.qty, Me.unit, Me.amount, Me.buying_price, Me.discount, Me.category, Me.remove_btn})
        Me.dgv_item_cart.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_item_cart.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_item_cart.EnableHeadersVisualStyles = false
        Me.dgv_item_cart.Location = New System.Drawing.Point(11, 95)
        Me.dgv_item_cart.MultiSelect = false
        Me.dgv_item_cart.Name = "dgv_item_cart"
        Me.dgv_item_cart.ReadOnly = true
        Me.dgv_item_cart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_item_cart.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_item_cart.RowHeadersVisible = false
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dgv_item_cart.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_item_cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_item_cart.Size = New System.Drawing.Size(820, 529)
        Me.dgv_item_cart.TabIndex = 84
        '
        'item_no
        '
        Me.item_no.HeaderText = "Item No."
        Me.item_no.Name = "item_no"
        Me.item_no.ReadOnly = true
        Me.item_no.Visible = false
        Me.item_no.Width = 90
        '
        'barcode
        '
        Me.barcode.HeaderText = "Barcode"
        Me.barcode.Name = "barcode"
        Me.barcode.ReadOnly = true
        Me.barcode.Visible = false
        Me.barcode.Width = 120
        '
        'item_name
        '
        Me.item_name.HeaderText = "Item Name"
        Me.item_name.Name = "item_name"
        Me.item_name.ReadOnly = true
        Me.item_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.item_name.Width = 310
        '
        'selling_price
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.selling_price.DefaultCellStyle = DataGridViewCellStyle2
        Me.selling_price.HeaderText = "Price"
        Me.selling_price.Name = "selling_price"
        Me.selling_price.ReadOnly = true
        Me.selling_price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'qty
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.qty.DefaultCellStyle = DataGridViewCellStyle3
        Me.qty.HeaderText = "Qty."
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = true
        Me.qty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.qty.Width = 60
        '
        'unit
        '
        Me.unit.HeaderText = "Unit"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = true
        Me.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.unit.Width = 50
        '
        'amount
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.amount.DefaultCellStyle = DataGridViewCellStyle4
        Me.amount.HeaderText = "Amount"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = true
        Me.amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.amount.Width = 110
        '
        'buying_price
        '
        Me.buying_price.HeaderText = "buying_price"
        Me.buying_price.Name = "buying_price"
        Me.buying_price.ReadOnly = true
        Me.buying_price.Visible = false
        '
        'discount
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.discount.DefaultCellStyle = DataGridViewCellStyle5
        Me.discount.HeaderText = "Discount"
        Me.discount.Name = "discount"
        Me.discount.ReadOnly = true
        Me.discount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'category
        '
        Me.category.HeaderText = "category"
        Me.category.Name = "category"
        Me.category.ReadOnly = true
        Me.category.Visible = false
        '
        'remove_btn
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.remove_btn.DefaultCellStyle = DataGridViewCellStyle6
        Me.remove_btn.HeaderText = "Remove"
        Me.remove_btn.Name = "remove_btn"
        Me.remove_btn.ReadOnly = true
        Me.remove_btn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.remove_btn.Text = "X"
        Me.remove_btn.UseColumnTextForButtonValue = true
        Me.remove_btn.Width = 70
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.Location = New System.Drawing.Point(602, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 19)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Transaction No."
        '
        'lbl_trans_no
        '
        Me.lbl_trans_no.BackColor = System.Drawing.Color.White
        Me.lbl_trans_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_trans_no.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_trans_no.Location = New System.Drawing.Point(597, 59)
        Me.lbl_trans_no.Name = "lbl_trans_no"
        Me.lbl_trans_no.Size = New System.Drawing.Size(234, 30)
        Me.lbl_trans_no.TabIndex = 86
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_date, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel5, Me.ss_time_and_date, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel4, Me.ss_user, Me.ToolStripStatusLabel9, Me.ToolStripStatusLabel7, Me.ss_position})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 632)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1340, 22)
        Me.StatusStrip1.TabIndex = 87
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'st_date
        '
        Me.st_date.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.st_date.ForeColor = System.Drawing.Color.White
        Me.st_date.Name = "st_date"
        Me.st_date.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(111, 17)
        Me.ToolStripStatusLabel5.Text = "DATE AND TIME :"
        '
        'ss_time_and_date
        '
        Me.ss_time_and_date.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ss_time_and_date.ForeColor = System.Drawing.Color.White
        Me.ss_time_and_date.Name = "ss_time_and_date"
        Me.ss_time_and_date.Size = New System.Drawing.Size(219, 17)
        Me.ss_time_and_date.Text = "12:00 AM Saturday, 12 April 2016"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(19, 17)
        Me.ToolStripStatusLabel2.Text = "    "
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(101, 17)
        Me.ToolStripStatusLabel4.Text = "LOGGED IN AS :"
        '
        'ss_user
        '
        Me.ss_user.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ss_user.ForeColor = System.Drawing.Color.White
        Me.ss_user.Name = "ss_user"
        Me.ss_user.Size = New System.Drawing.Size(43, 17)
        Me.ss_user.Text = "Jepoy"
        '
        'ToolStripStatusLabel9
        '
        Me.ToolStripStatusLabel9.Name = "ToolStripStatusLabel9"
        Me.ToolStripStatusLabel9.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel9.Text = " "
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ToolStripStatusLabel7.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(74, 17)
        Me.ToolStripStatusLabel7.Text = "POSITION :"
        '
        'ss_position
        '
        Me.ss_position.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ss_position.ForeColor = System.Drawing.Color.White
        Me.ss_position.Name = "ss_position"
        Me.ss_position.Size = New System.Drawing.Size(46, 17)
        Me.ss_position.Text = "Admin"
        '
        'cmd_hold
        '
        Me.cmd_hold.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_hold.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.cmd_hold.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_hold.ForeColor = System.Drawing.Color.White
        Me.cmd_hold.Location = New System.Drawing.Point(1012, 467)
        Me.cmd_hold.Name = "cmd_hold"
        Me.cmd_hold.Size = New System.Drawing.Size(155, 73)
        Me.cmd_hold.TabIndex = 5
        Me.cmd_hold.Text = "Hold"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"(Ctrl + H)"
        Me.cmd_hold.UseVisualStyleBackColor = false
        '
        'cmd_change_qty
        '
        Me.cmd_change_qty.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_change_qty.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.cmd_change_qty.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_change_qty.ForeColor = System.Drawing.Color.White
        Me.cmd_change_qty.Location = New System.Drawing.Point(842, 372)
        Me.cmd_change_qty.Name = "cmd_change_qty"
        Me.cmd_change_qty.Size = New System.Drawing.Size(164, 123)
        Me.cmd_change_qty.TabIndex = 2
        Me.cmd_change_qty.Text = "Change Qty."&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"(Ctrl + Q)"
        Me.cmd_change_qty.UseVisualStyleBackColor = false
        '
        'cmd_discount
        '
        Me.cmd_discount.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_discount.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.cmd_discount.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_discount.ForeColor = System.Drawing.Color.White
        Me.cmd_discount.Location = New System.Drawing.Point(1012, 372)
        Me.cmd_discount.Name = "cmd_discount"
        Me.cmd_discount.Size = New System.Drawing.Size(155, 89)
        Me.cmd_discount.TabIndex = 4
        Me.cmd_discount.Text = "Discount"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"(Ctrl + D)"
        Me.cmd_discount.UseVisualStyleBackColor = false
        '
        'Timer1
        '
        Me.Timer1.Enabled = true
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(316, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 32)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "(*Press F1 to Set Focus"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"on the Barcode Textbox)"
        '
        'frm_invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1340, 654)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmd_discount)
        Me.Controls.Add(Me.cmd_change_qty)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lbl_trans_no)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgv_item_cart)
        Me.Controls.Add(Me.lbl_barcode_status)
        Me.Controls.Add(Me.cmd_close)
        Me.Controls.Add(Me.cmd_resume)
        Me.Controls.Add(Me.cmd_item_lookup)
        Me.Controls.Add(Me.cmd_hold)
        Me.Controls.Add(Me.cmd_cancel_invoice)
        Me.Controls.Add(Me.cmd_pay)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_barcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = false
        Me.Name = "frm_invoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha Point of Sales - Invoice"
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        CType(Me.dgv_item_cart,System.ComponentModel.ISupportInitialize).EndInit
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_barcode As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_grand_total As System.Windows.Forms.Label
    Friend WithEvents lbl_sub_total As System.Windows.Forms.Label
    Friend WithEvents cmd_pay As System.Windows.Forms.Button
    Friend WithEvents cmd_cancel_invoice As System.Windows.Forms.Button
    Friend WithEvents cmd_item_lookup As System.Windows.Forms.Button
    Friend WithEvents cmd_resume As System.Windows.Forms.Button
    Friend WithEvents cmd_close As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents lbl_barcode_status As System.Windows.Forms.Label
    Friend WithEvents ReciptSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgv_item_cart As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_total_disc As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_trans_no As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents st_date As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ss_time_and_date As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ss_user As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel9 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ss_position As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmd_hold As System.Windows.Forms.Button
    Friend WithEvents cmd_change_qty As System.Windows.Forms.Button
    Friend WithEvents cmd_discount As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_item_count As System.Windows.Forms.Label
    Friend WithEvents lbl_disc_percent As System.Windows.Forms.Label
    Friend WithEvents item_no As DataGridViewTextBoxColumn
    Friend WithEvents barcode As DataGridViewTextBoxColumn
    Friend WithEvents item_name As DataGridViewTextBoxColumn
    Friend WithEvents selling_price As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents unit As DataGridViewTextBoxColumn
    Friend WithEvents amount As DataGridViewTextBoxColumn
    Friend WithEvents buying_price As DataGridViewTextBoxColumn
    Friend WithEvents discount As DataGridViewTextBoxColumn
    Friend WithEvents category As DataGridViewTextBoxColumn
    Friend WithEvents remove_btn As DataGridViewButtonColumn
End Class
