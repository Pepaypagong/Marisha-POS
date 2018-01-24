<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addstock
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_unit = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl_init_beg_inv_price = New System.Windows.Forms.Label()
        Me.lbl_beginning = New System.Windows.Forms.Label()
        Me.lbl_ending = New System.Windows.Forms.Label()
        Me.lbl_total_after_disc = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmd_cancel = New System.Windows.Forms.Button()
        Me.cmd_save = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_total_discount = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lbl_sub_total_grand = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmd_add_to_list = New System.Windows.Forms.Button()
        Me.txt_discount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_grand_total = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgv_purchase_list = New System.Windows.Forms.DataGridView()
        Me.item_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.beg_inv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit_measure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buying_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.begin_inv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ending_inv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.beg_inv_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.beg_inv_init_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_select_item = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_ref_no = New System.Windows.Forms.TextBox()
        Me.lbl_supplier_no = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dtp_date = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_trans_no = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbl_sub_total = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmd_select_supplier = New System.Windows.Forms.Button()
        Me.lbl_supplier_name = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_buying_price = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_category = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_item_no = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_item_name = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_barcode = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout
        Me.GroupBox1.SuspendLayout
        CType(Me.dgv_purchase_list,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 52)
        Me.Panel1.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = true
        Me.lblTitle.Font = New System.Drawing.Font("Segoe Print", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(3, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(449, 42)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Add Stocks - Purchase Transaction"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.lbl_unit)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.lbl_init_beg_inv_price)
        Me.GroupBox1.Controls.Add(Me.lbl_beginning)
        Me.GroupBox1.Controls.Add(Me.lbl_ending)
        Me.GroupBox1.Controls.Add(Me.lbl_total_after_disc)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cmd_cancel)
        Me.GroupBox1.Controls.Add(Me.cmd_save)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbl_total_discount)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.lbl_sub_total_grand)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.cmd_add_to_list)
        Me.GroupBox1.Controls.Add(Me.txt_discount)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lbl_grand_total)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dgv_purchase_list)
        Me.GroupBox1.Controls.Add(Me.cmd_select_item)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txt_ref_no)
        Me.GroupBox1.Controls.Add(Me.lbl_supplier_no)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.dtp_date)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.lbl_trans_no)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.lbl_sub_total)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cmd_select_supplier)
        Me.GroupBox1.Controls.Add(Me.lbl_supplier_name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbl_buying_price)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lbl_brand)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.lbl_category)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lbl_item_no)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lbl_item_name)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_qty)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lbl_barcode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(765, 562)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.UseCompatibleTextRendering = true
        '
        'lbl_unit
        '
        Me.lbl_unit.BackColor = System.Drawing.Color.White
        Me.lbl_unit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_unit.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_unit.Location = New System.Drawing.Point(436, 214)
        Me.lbl_unit.Name = "lbl_unit"
        Me.lbl_unit.Size = New System.Drawing.Size(106, 22)
        Me.lbl_unit.TabIndex = 98
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label14.Location = New System.Drawing.Point(396, 215)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 18)
        Me.Label14.TabIndex = 97
        Me.Label14.Text = "Unit :"
        '
        'lbl_init_beg_inv_price
        '
        Me.lbl_init_beg_inv_price.BackColor = System.Drawing.Color.White
        Me.lbl_init_beg_inv_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_init_beg_inv_price.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_init_beg_inv_price.Location = New System.Drawing.Point(581, 260)
        Me.lbl_init_beg_inv_price.Name = "lbl_init_beg_inv_price"
        Me.lbl_init_beg_inv_price.Size = New System.Drawing.Size(111, 30)
        Me.lbl_init_beg_inv_price.TabIndex = 96
        Me.lbl_init_beg_inv_price.Visible = false
        '
        'lbl_beginning
        '
        Me.lbl_beginning.BackColor = System.Drawing.Color.White
        Me.lbl_beginning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_beginning.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_beginning.Location = New System.Drawing.Point(514, 260)
        Me.lbl_beginning.Name = "lbl_beginning"
        Me.lbl_beginning.Size = New System.Drawing.Size(111, 30)
        Me.lbl_beginning.TabIndex = 95
        Me.lbl_beginning.Visible = false
        '
        'lbl_ending
        '
        Me.lbl_ending.BackColor = System.Drawing.Color.White
        Me.lbl_ending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ending.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_ending.Location = New System.Drawing.Point(635, 260)
        Me.lbl_ending.Name = "lbl_ending"
        Me.lbl_ending.Size = New System.Drawing.Size(114, 30)
        Me.lbl_ending.TabIndex = 94
        Me.lbl_ending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_ending.Visible = false
        '
        'lbl_total_after_disc
        '
        Me.lbl_total_after_disc.BackColor = System.Drawing.Color.White
        Me.lbl_total_after_disc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_total_after_disc.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_total_after_disc.Location = New System.Drawing.Point(122, 298)
        Me.lbl_total_after_disc.Name = "lbl_total_after_disc"
        Me.lbl_total_after_disc.Size = New System.Drawing.Size(153, 22)
        Me.lbl_total_after_disc.TabIndex = 47
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 299)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 18)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Total Amount  :"
        '
        'cmd_cancel
        '
        Me.cmd_cancel.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_cancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_cancel.ForeColor = System.Drawing.Color.White
        Me.cmd_cancel.Location = New System.Drawing.Point(260, 505)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(90, 47)
        Me.cmd_cancel.TabIndex = 7
        Me.cmd_cancel.Text = "Ca&ncel"
        Me.cmd_cancel.UseVisualStyleBackColor = false
        '
        'cmd_save
        '
        Me.cmd_save.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_save.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_save.ForeColor = System.Drawing.Color.White
        Me.cmd_save.Location = New System.Drawing.Point(148, 505)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.Size = New System.Drawing.Size(90, 47)
        Me.cmd_save.TabIndex = 6
        Me.cmd_save.Text = "&Save"
        Me.cmd_save.UseVisualStyleBackColor = false
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(630, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 28)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "* double click an item "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"from the list to remove"
        '
        'lbl_total_discount
        '
        Me.lbl_total_discount.BackColor = System.Drawing.Color.White
        Me.lbl_total_discount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_total_discount.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_total_discount.Location = New System.Drawing.Point(601, 505)
        Me.lbl_total_discount.Name = "lbl_total_discount"
        Me.lbl_total_discount.Size = New System.Drawing.Size(144, 22)
        Me.lbl_total_discount.TabIndex = 44
        Me.lbl_total_discount.Text = " "
        '
        'Label27
        '
        Me.Label27.AutoSize = true
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label27.Location = New System.Drawing.Point(484, 506)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(111, 18)
        Me.Label27.TabIndex = 43
        Me.Label27.Text = "Total Discount :"
        '
        'lbl_sub_total_grand
        '
        Me.lbl_sub_total_grand.BackColor = System.Drawing.Color.White
        Me.lbl_sub_total_grand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_sub_total_grand.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_sub_total_grand.Location = New System.Drawing.Point(601, 479)
        Me.lbl_sub_total_grand.Name = "lbl_sub_total_grand"
        Me.lbl_sub_total_grand.Size = New System.Drawing.Size(144, 22)
        Me.lbl_sub_total_grand.TabIndex = 42
        Me.lbl_sub_total_grand.Text = " "
        '
        'Label25
        '
        Me.Label25.AutoSize = true
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label25.Location = New System.Drawing.Point(515, 483)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 18)
        Me.Label25.TabIndex = 41
        Me.Label25.Text = "Sub Total :"
        '
        'cmd_add_to_list
        '
        Me.cmd_add_to_list.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_add_to_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_add_to_list.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_add_to_list.ForeColor = System.Drawing.Color.White
        Me.cmd_add_to_list.Location = New System.Drawing.Point(508, 297)
        Me.cmd_add_to_list.Name = "cmd_add_to_list"
        Me.cmd_add_to_list.Size = New System.Drawing.Size(116, 24)
        Me.cmd_add_to_list.TabIndex = 5
        Me.cmd_add_to_list.Text = "Add To List"
        Me.cmd_add_to_list.UseVisualStyleBackColor = false
        '
        'txt_discount
        '
        Me.txt_discount.Enabled = false
        Me.txt_discount.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_discount.Location = New System.Drawing.Point(375, 269)
        Me.txt_discount.MaxLength = 8
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.Size = New System.Drawing.Size(110, 26)
        Me.txt_discount.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label9.Location = New System.Drawing.Point(292, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 18)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Discount :"
        '
        'lbl_grand_total
        '
        Me.lbl_grand_total.BackColor = System.Drawing.Color.White
        Me.lbl_grand_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_grand_total.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_grand_total.Location = New System.Drawing.Point(601, 530)
        Me.lbl_grand_total.Name = "lbl_grand_total"
        Me.lbl_grand_total.Size = New System.Drawing.Size(144, 22)
        Me.lbl_grand_total.TabIndex = 37
        Me.lbl_grand_total.Text = " "
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(500, 531)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 18)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Grand Total :"
        '
        'dgv_purchase_list
        '
        Me.dgv_purchase_list.AllowUserToAddRows = false
        Me.dgv_purchase_list.AllowUserToDeleteRows = false
        Me.dgv_purchase_list.AllowUserToResizeRows = false
        Me.dgv_purchase_list.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_purchase_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_purchase_list.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_purchase_list.ColumnHeadersHeight = 25
        Me.dgv_purchase_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item_no, Me.barcode, Me.item_name, Me.category, Me.brand, Me.beg_inv, Me.quantity, Me.unit_measure, Me.buying_price, Me.discount, Me.total_amount, Me.begin_inv, Me.ending_inv, Me.beg_inv_price, Me.beg_inv_init_price})
        Me.dgv_purchase_list.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_purchase_list.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_purchase_list.EnableHeadersVisualStyles = false
        Me.dgv_purchase_list.Location = New System.Drawing.Point(1, 332)
        Me.dgv_purchase_list.MultiSelect = false
        Me.dgv_purchase_list.Name = "dgv_purchase_list"
        Me.dgv_purchase_list.ReadOnly = true
        Me.dgv_purchase_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_purchase_list.RowHeadersVisible = false
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dgv_purchase_list.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_purchase_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_purchase_list.Size = New System.Drawing.Size(762, 142)
        Me.dgv_purchase_list.TabIndex = 29
        '
        'item_no
        '
        Me.item_no.HeaderText = "Item No."
        Me.item_no.Name = "item_no"
        Me.item_no.ReadOnly = true
        Me.item_no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.item_no.Width = 70
        '
        'barcode
        '
        Me.barcode.HeaderText = "Barcode"
        Me.barcode.Name = "barcode"
        Me.barcode.ReadOnly = true
        Me.barcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.barcode.Width = 120
        '
        'item_name
        '
        Me.item_name.HeaderText = "Item Name"
        Me.item_name.Name = "item_name"
        Me.item_name.ReadOnly = true
        Me.item_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.item_name.Width = 210
        '
        'category
        '
        Me.category.HeaderText = "Category"
        Me.category.Name = "category"
        Me.category.ReadOnly = true
        Me.category.Visible = false
        '
        'brand
        '
        Me.brand.HeaderText = "Brand"
        Me.brand.Name = "brand"
        Me.brand.ReadOnly = true
        Me.brand.Visible = false
        '
        'beg_inv
        '
        Me.beg_inv.HeaderText = "Beginning Inventory"
        Me.beg_inv.Name = "beg_inv"
        Me.beg_inv.ReadOnly = true
        Me.beg_inv.Visible = false
        '
        'quantity
        '
        Me.quantity.HeaderText = "Qty."
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = true
        Me.quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.quantity.Width = 60
        '
        'unit_measure
        '
        Me.unit_measure.HeaderText = "Unit"
        Me.unit_measure.Name = "unit_measure"
        Me.unit_measure.ReadOnly = true
        Me.unit_measure.Width = 50
        '
        'buying_price
        '
        Me.buying_price.HeaderText = "Price"
        Me.buying_price.Name = "buying_price"
        Me.buying_price.ReadOnly = true
        Me.buying_price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.buying_price.Width = 70
        '
        'discount
        '
        Me.discount.HeaderText = "Discount"
        Me.discount.Name = "discount"
        Me.discount.ReadOnly = true
        Me.discount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.discount.Width = 70
        '
        'total_amount
        '
        Me.total_amount.HeaderText = "Total Amount"
        Me.total_amount.Name = "total_amount"
        Me.total_amount.ReadOnly = true
        Me.total_amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_amount.Width = 90
        '
        'begin_inv
        '
        Me.begin_inv.HeaderText = "begin_inv"
        Me.begin_inv.Name = "begin_inv"
        Me.begin_inv.ReadOnly = true
        Me.begin_inv.Visible = false
        '
        'ending_inv
        '
        Me.ending_inv.HeaderText = "ending_inv"
        Me.ending_inv.Name = "ending_inv"
        Me.ending_inv.ReadOnly = true
        Me.ending_inv.Visible = false
        '
        'beg_inv_price
        '
        Me.beg_inv_price.HeaderText = "beg_inv_price"
        Me.beg_inv_price.Name = "beg_inv_price"
        Me.beg_inv_price.ReadOnly = true
        Me.beg_inv_price.Visible = false
        '
        'beg_inv_init_price
        '
        Me.beg_inv_init_price.HeaderText = "beg_inv_init_price"
        Me.beg_inv_init_price.Name = "beg_inv_init_price"
        Me.beg_inv_init_price.ReadOnly = true
        Me.beg_inv_init_price.Visible = false
        '
        'cmd_select_item
        '
        Me.cmd_select_item.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_select_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_select_item.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_select_item.ForeColor = System.Drawing.Color.White
        Me.cmd_select_item.Location = New System.Drawing.Point(281, 159)
        Me.cmd_select_item.Name = "cmd_select_item"
        Me.cmd_select_item.Size = New System.Drawing.Size(69, 24)
        Me.cmd_select_item.TabIndex = 2
        Me.cmd_select_item.Text = "Select"
        Me.cmd_select_item.UseVisualStyleBackColor = false
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(-1, 125)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(768, 27)
        Me.Label23.TabIndex = 34
        Me.Label23.Text = "  Item Info."
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(-1, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(768, 27)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "  Purchase Transaction and Supplier Info."
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_ref_no
        '
        Me.txt_ref_no.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_ref_no.Location = New System.Drawing.Point(581, 86)
        Me.txt_ref_no.Name = "txt_ref_no"
        Me.txt_ref_no.Size = New System.Drawing.Size(168, 26)
        Me.txt_ref_no.TabIndex = 1
        '
        'lbl_supplier_no
        '
        Me.lbl_supplier_no.BackColor = System.Drawing.Color.White
        Me.lbl_supplier_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_supplier_no.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_supplier_no.Location = New System.Drawing.Point(149, 61)
        Me.lbl_supplier_no.Name = "lbl_supplier_no"
        Me.lbl_supplier_no.Size = New System.Drawing.Size(152, 22)
        Me.lbl_supplier_no.TabIndex = 31
        '
        'Label22
        '
        Me.Label22.AutoSize = true
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label22.Location = New System.Drawing.Point(24, 62)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(95, 18)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "Supplier No. :"
        '
        'Label20
        '
        Me.Label20.AutoSize = true
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label20.Location = New System.Drawing.Point(451, 89)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(124, 18)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Reference No. :"
        '
        'dtp_date
        '
        Me.dtp_date.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dtp_date.Location = New System.Drawing.Point(504, 31)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(245, 23)
        Me.dtp_date.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = true
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label18.Location = New System.Drawing.Point(446, 34)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 18)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Date :"
        '
        'lbl_trans_no
        '
        Me.lbl_trans_no.BackColor = System.Drawing.Color.White
        Me.lbl_trans_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_trans_no.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_trans_no.Location = New System.Drawing.Point(148, 33)
        Me.lbl_trans_no.Name = "lbl_trans_no"
        Me.lbl_trans_no.Size = New System.Drawing.Size(228, 22)
        Me.lbl_trans_no.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.AutoSize = true
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label16.Location = New System.Drawing.Point(24, 34)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(122, 18)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Transaction No. :"
        '
        'lbl_sub_total
        '
        Me.lbl_sub_total.BackColor = System.Drawing.Color.White
        Me.lbl_sub_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_sub_total.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_sub_total.Location = New System.Drawing.Point(122, 271)
        Me.lbl_sub_total.Name = "lbl_sub_total"
        Me.lbl_sub_total.Size = New System.Drawing.Size(153, 22)
        Me.lbl_sub_total.TabIndex = 23
        '
        'Label15
        '
        Me.Label15.AutoSize = true
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label15.Location = New System.Drawing.Point(39, 272)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 18)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Sub Total :"
        '
        'cmd_select_supplier
        '
        Me.cmd_select_supplier.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_select_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_select_supplier.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_select_supplier.ForeColor = System.Drawing.Color.White
        Me.cmd_select_supplier.Location = New System.Drawing.Point(307, 60)
        Me.cmd_select_supplier.Name = "cmd_select_supplier"
        Me.cmd_select_supplier.Size = New System.Drawing.Size(69, 24)
        Me.cmd_select_supplier.TabIndex = 0
        Me.cmd_select_supplier.Text = "Select"
        Me.cmd_select_supplier.UseVisualStyleBackColor = false
        '
        'lbl_supplier_name
        '
        Me.lbl_supplier_name.BackColor = System.Drawing.Color.White
        Me.lbl_supplier_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_supplier_name.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_supplier_name.Location = New System.Drawing.Point(149, 88)
        Me.lbl_supplier_name.Name = "lbl_supplier_name"
        Me.lbl_supplier_name.Size = New System.Drawing.Size(227, 22)
        Me.lbl_supplier_name.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Supplier Name :"
        '
        'lbl_buying_price
        '
        Me.lbl_buying_price.BackColor = System.Drawing.Color.White
        Me.lbl_buying_price.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_buying_price.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_buying_price.Location = New System.Drawing.Point(122, 244)
        Me.lbl_buying_price.Name = "lbl_buying_price"
        Me.lbl_buying_price.Size = New System.Drawing.Size(153, 22)
        Me.lbl_buying_price.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 245)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 18)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Buying Price :"
        '
        'lbl_brand
        '
        Me.lbl_brand.BackColor = System.Drawing.Color.White
        Me.lbl_brand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_brand.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_brand.Location = New System.Drawing.Point(615, 187)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(130, 22)
        Me.lbl_brand.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label13.Location = New System.Drawing.Point(562, 188)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 18)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Brand :"
        '
        'lbl_category
        '
        Me.lbl_category.BackColor = System.Drawing.Color.White
        Me.lbl_category.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_category.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_category.Location = New System.Drawing.Point(436, 187)
        Me.lbl_category.Name = "lbl_category"
        Me.lbl_category.Size = New System.Drawing.Size(106, 22)
        Me.lbl_category.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label11.Location = New System.Drawing.Point(362, 188)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 18)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Category :"
        '
        'lbl_item_no
        '
        Me.lbl_item_no.BackColor = System.Drawing.Color.White
        Me.lbl_item_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_item_no.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_item_no.Location = New System.Drawing.Point(122, 160)
        Me.lbl_item_no.Name = "lbl_item_no"
        Me.lbl_item_no.Size = New System.Drawing.Size(153, 22)
        Me.lbl_item_no.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Item No. :"
        '
        'lbl_item_name
        '
        Me.lbl_item_name.BackColor = System.Drawing.Color.White
        Me.lbl_item_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_item_name.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_item_name.Location = New System.Drawing.Point(122, 186)
        Me.lbl_item_name.Name = "lbl_item_name"
        Me.lbl_item_name.Size = New System.Drawing.Size(228, 22)
        Me.lbl_item_name.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Item Name :"
        '
        'txt_qty
        '
        Me.txt_qty.Enabled = false
        Me.txt_qty.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_qty.Location = New System.Drawing.Point(122, 215)
        Me.txt_qty.MaxLength = 8
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(153, 26)
        Me.txt_qty.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 218)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Enter Qty. :"
        '
        'lbl_barcode
        '
        Me.lbl_barcode.BackColor = System.Drawing.Color.White
        Me.lbl_barcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_barcode.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_barcode.Location = New System.Drawing.Point(436, 160)
        Me.lbl_barcode.Name = "lbl_barcode"
        Me.lbl_barcode.Size = New System.Drawing.Size(309, 22)
        Me.lbl_barcode.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(368, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Barcode :"
        '
        'frm_addstock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 624)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frm_addstock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS -Add Stocks"
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.dgv_purchase_list,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_qty As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_barcode As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_item_name As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_item_no As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_brand As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbl_category As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmd_cancel As System.Windows.Forms.Button
    Friend WithEvents lbl_buying_price As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_sub_total As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmd_select_supplier As System.Windows.Forms.Button
    Friend WithEvents lbl_supplier_name As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmd_save As System.Windows.Forms.Button
    Friend WithEvents dtp_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbl_trans_no As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lbl_supplier_no As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_ref_no As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents dgv_purchase_list As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_select_item As System.Windows.Forms.Button
    Friend WithEvents lbl_grand_total As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_discount As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmd_add_to_list As System.Windows.Forms.Button
    Friend WithEvents lbl_total_discount As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lbl_sub_total_grand As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_total_after_disc As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbl_beginning As System.Windows.Forms.Label
    Friend WithEvents lbl_ending As System.Windows.Forms.Label
    Friend WithEvents lbl_init_beg_inv_price As System.Windows.Forms.Label
    Friend WithEvents lbl_unit As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents item_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents barcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents brand As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents beg_inv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit_measure As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents buying_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents begin_inv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ending_inv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents beg_inv_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents beg_inv_init_price As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
