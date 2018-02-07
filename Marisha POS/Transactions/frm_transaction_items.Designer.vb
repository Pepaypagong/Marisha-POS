<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_transaction_items
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
        Me.txt_ref_no = New System.Windows.Forms.TextBox()
        Me.dtp_date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_trans_no = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmd_select_supplier = New System.Windows.Forms.Button()
        Me.lbl_supplier_name = New System.Windows.Forms.Label()
        Me.lbl_supplier = New System.Windows.Forms.Label()
        Me.cmd_cancel = New System.Windows.Forms.Button()
        Me.cmd_save = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_ref_no = New System.Windows.Forms.Label()
        Me.lbl_dtp = New System.Windows.Forms.Label()
        Me.cmd_remove_item = New System.Windows.Forms.Button()
        Me.cmd_add_item = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_barcode = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dgv_items = New System.Windows.Forms.DataGridView()
        Me.item_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_total_discount = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lbl_sub_total_grand = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lbl_grand_total = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        CType(Me.dgv_items,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'txt_ref_no
        '
        Me.txt_ref_no.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_ref_no.Location = New System.Drawing.Point(144, 117)
        Me.txt_ref_no.MaxLength = 50
        Me.txt_ref_no.Name = "txt_ref_no"
        Me.txt_ref_no.Size = New System.Drawing.Size(258, 22)
        Me.txt_ref_no.TabIndex = 34
        '
        'dtp_date
        '
        Me.dtp_date.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_date.Location = New System.Drawing.Point(144, 148)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(180, 22)
        Me.dtp_date.TabIndex = 32
        '
        'lbl_trans_no
        '
        Me.lbl_trans_no.BackColor = System.Drawing.Color.White
        Me.lbl_trans_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_trans_no.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_trans_no.Location = New System.Drawing.Point(144, 54)
        Me.lbl_trans_no.Name = "lbl_trans_no"
        Me.lbl_trans_no.Size = New System.Drawing.Size(167, 22)
        Me.lbl_trans_no.TabIndex = 38
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DimGray
        Me.Label16.Location = New System.Drawing.Point(15, 57)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(123, 16)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Transaction No. :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmd_select_supplier
        '
        Me.cmd_select_supplier.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_select_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_select_supplier.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_select_supplier.ForeColor = System.Drawing.Color.White
        Me.cmd_select_supplier.Location = New System.Drawing.Point(544, 84)
        Me.cmd_select_supplier.Name = "cmd_select_supplier"
        Me.cmd_select_supplier.Size = New System.Drawing.Size(69, 24)
        Me.cmd_select_supplier.TabIndex = 33
        Me.cmd_select_supplier.Text = "Select"
        Me.cmd_select_supplier.UseVisualStyleBackColor = false
        '
        'lbl_supplier_name
        '
        Me.lbl_supplier_name.BackColor = System.Drawing.Color.White
        Me.lbl_supplier_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_supplier_name.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_supplier_name.Location = New System.Drawing.Point(144, 85)
        Me.lbl_supplier_name.Name = "lbl_supplier_name"
        Me.lbl_supplier_name.Size = New System.Drawing.Size(394, 22)
        Me.lbl_supplier_name.TabIndex = 36
        '
        'lbl_supplier
        '
        Me.lbl_supplier.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_supplier.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_supplier.Location = New System.Drawing.Point(15, 88)
        Me.lbl_supplier.Name = "lbl_supplier"
        Me.lbl_supplier.Size = New System.Drawing.Size(123, 16)
        Me.lbl_supplier.TabIndex = 35
        Me.lbl_supplier.Text = "Supplier :"
        Me.lbl_supplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmd_cancel
        '
        Me.cmd_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cmd_cancel.BackColor = System.Drawing.Color.White
        Me.cmd_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_cancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_cancel.ForeColor = System.Drawing.Color.Black
        Me.cmd_cancel.Location = New System.Drawing.Point(1170, 7)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(114, 27)
        Me.cmd_cancel.TabIndex = 73
        Me.cmd_cancel.Text = "CANCEL"
        Me.cmd_cancel.UseVisualStyleBackColor = false
        '
        'cmd_save
        '
        Me.cmd_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cmd_save.BackColor = System.Drawing.Color.White
        Me.cmd_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_save.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_save.ForeColor = System.Drawing.Color.Black
        Me.cmd_save.Location = New System.Drawing.Point(1050, 7)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.Size = New System.Drawing.Size(114, 27)
        Me.cmd_save.TabIndex = 72
        Me.cmd_save.Text = "CONFIRM DELETE"
        Me.cmd_save.UseVisualStyleBackColor = false
        '
        'lbl_title
        '
        Me.lbl_title.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_title.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(0, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(1295, 40)
        Me.lbl_title.TabIndex = 74
        Me.lbl_title.Text = "   New Purchase Transaction"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_ref_no
        '
        Me.lbl_ref_no.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_ref_no.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_ref_no.Location = New System.Drawing.Point(15, 119)
        Me.lbl_ref_no.Name = "lbl_ref_no"
        Me.lbl_ref_no.Size = New System.Drawing.Size(123, 16)
        Me.lbl_ref_no.TabIndex = 75
        Me.lbl_ref_no.Text = "Reference No. :"
        Me.lbl_ref_no.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_dtp
        '
        Me.lbl_dtp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_dtp.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_dtp.Location = New System.Drawing.Point(15, 153)
        Me.lbl_dtp.Name = "lbl_dtp"
        Me.lbl_dtp.Size = New System.Drawing.Size(123, 16)
        Me.lbl_dtp.TabIndex = 76
        Me.lbl_dtp.Text = "Date :"
        Me.lbl_dtp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmd_remove_item
        '
        Me.cmd_remove_item.BackColor = System.Drawing.Color.White
        Me.cmd_remove_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_remove_item.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_remove_item.ForeColor = System.Drawing.Color.Black
        Me.cmd_remove_item.Location = New System.Drawing.Point(1168, 211)
        Me.cmd_remove_item.Name = "cmd_remove_item"
        Me.cmd_remove_item.Size = New System.Drawing.Size(114, 27)
        Me.cmd_remove_item.TabIndex = 78
        Me.cmd_remove_item.Text = "REMOVE ITEM"
        Me.cmd_remove_item.UseVisualStyleBackColor = false
        '
        'cmd_add_item
        '
        Me.cmd_add_item.BackColor = System.Drawing.Color.White
        Me.cmd_add_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_add_item.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_add_item.ForeColor = System.Drawing.Color.Black
        Me.cmd_add_item.Location = New System.Drawing.Point(1048, 211)
        Me.cmd_add_item.Name = "cmd_add_item"
        Me.cmd_add_item.Size = New System.Drawing.Size(114, 27)
        Me.cmd_add_item.TabIndex = 77
        Me.cmd_add_item.Text = "ADD ITEM"
        Me.cmd_add_item.UseVisualStyleBackColor = false
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(12, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 16)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "ADD ITEMS (BARCODE) :"
        '
        'txt_barcode
        '
        Me.txt_barcode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_barcode.Location = New System.Drawing.Point(181, 213)
        Me.txt_barcode.MaxLength = 50
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Size = New System.Drawing.Size(247, 23)
        Me.txt_barcode.TabIndex = 81
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(1, 187)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(1294, 10)
        Me.Label22.TabIndex = 82
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgv_items
        '
        Me.dgv_items.AllowUserToAddRows = false
        Me.dgv_items.AllowUserToDeleteRows = false
        Me.dgv_items.AllowUserToResizeRows = false
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_items.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_items.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_items.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_items.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_items.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_items.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_items.ColumnHeadersHeight = 25
        Me.dgv_items.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item_no, Me.barcode, Me.item_name, Me.qty, Me.unit, Me.price, Me.discount, Me.total_amount})
        Me.dgv_items.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_items.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_items.EnableHeadersVisualStyles = false
        Me.dgv_items.GridColor = System.Drawing.Color.White
        Me.dgv_items.Location = New System.Drawing.Point(10, 244)
        Me.dgv_items.MultiSelect = false
        Me.dgv_items.Name = "dgv_items"
        Me.dgv_items.ReadOnly = true
        Me.dgv_items.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_items.RowHeadersVisible = false
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dgv_items.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_items.Size = New System.Drawing.Size(1274, 339)
        Me.dgv_items.TabIndex = 83
        '
        'item_no
        '
        Me.item_no.HeaderText = "Item No."
        Me.item_no.Name = "item_no"
        Me.item_no.ReadOnly = true
        '
        'barcode
        '
        Me.barcode.HeaderText = "Barcode"
        Me.barcode.Name = "barcode"
        Me.barcode.ReadOnly = true
        Me.barcode.Width = 150
        '
        'item_name
        '
        Me.item_name.HeaderText = "Item Description"
        Me.item_name.Name = "item_name"
        Me.item_name.ReadOnly = true
        Me.item_name.Width = 300
        '
        'qty
        '
        Me.qty.HeaderText = "Quantity"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = true
        '
        'unit
        '
        Me.unit.HeaderText = "Unit"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = true
        '
        'price
        '
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        Me.price.ReadOnly = true
        '
        'discount
        '
        Me.discount.HeaderText = "Discount"
        Me.discount.Name = "discount"
        Me.discount.ReadOnly = true
        Me.discount.Width = 150
        '
        'total_amount
        '
        Me.total_amount.HeaderText = "Total Amount"
        Me.total_amount.Name = "total_amount"
        Me.total_amount.ReadOnly = true
        Me.total_amount.Width = 150
        '
        'lbl_total_discount
        '
        Me.lbl_total_discount.BackColor = System.Drawing.Color.White
        Me.lbl_total_discount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_total_discount.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_total_discount.Location = New System.Drawing.Point(1026, 622)
        Me.lbl_total_discount.Name = "lbl_total_discount"
        Me.lbl_total_discount.Size = New System.Drawing.Size(256, 22)
        Me.lbl_total_discount.TabIndex = 89
        Me.lbl_total_discount.Text = " "
        '
        'Label27
        '
        Me.Label27.AutoSize = true
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label27.ForeColor = System.Drawing.Color.DimGray
        Me.Label27.Location = New System.Drawing.Point(912, 623)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(109, 16)
        Me.Label27.TabIndex = 88
        Me.Label27.Text = "Total Discount :"
        '
        'lbl_sub_total_grand
        '
        Me.lbl_sub_total_grand.BackColor = System.Drawing.Color.White
        Me.lbl_sub_total_grand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_sub_total_grand.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_sub_total_grand.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_sub_total_grand.Location = New System.Drawing.Point(1026, 596)
        Me.lbl_sub_total_grand.Name = "lbl_sub_total_grand"
        Me.lbl_sub_total_grand.Size = New System.Drawing.Size(256, 22)
        Me.lbl_sub_total_grand.TabIndex = 87
        Me.lbl_sub_total_grand.Text = " "
        '
        'Label25
        '
        Me.Label25.AutoSize = true
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label25.Location = New System.Drawing.Point(943, 600)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(77, 16)
        Me.Label25.TabIndex = 86
        Me.Label25.Text = "Sub Total :"
        '
        'lbl_grand_total
        '
        Me.lbl_grand_total.BackColor = System.Drawing.Color.White
        Me.lbl_grand_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_grand_total.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_grand_total.Location = New System.Drawing.Point(1026, 647)
        Me.lbl_grand_total.Name = "lbl_grand_total"
        Me.lbl_grand_total.Size = New System.Drawing.Size(256, 22)
        Me.lbl_grand_total.TabIndex = 85
        Me.lbl_grand_total.Text = " "
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(928, 648)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 16)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Grand Total :"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(650, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Remarks :"
        '
        'txt_remarks
        '
        Me.txt_remarks.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_remarks.Location = New System.Drawing.Point(729, 54)
        Me.txt_remarks.MaxLength = 50
        Me.txt_remarks.Multiline = true
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(553, 115)
        Me.txt_remarks.TabIndex = 91
        '
        'frm_transaction_items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1294, 694)
        Me.Controls.Add(Me.txt_remarks)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_total_discount)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.lbl_sub_total_grand)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.lbl_grand_total)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgv_items)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txt_barcode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmd_remove_item)
        Me.Controls.Add(Me.cmd_add_item)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.cmd_save)
        Me.Controls.Add(Me.lbl_dtp)
        Me.Controls.Add(Me.lbl_ref_no)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.txt_ref_no)
        Me.Controls.Add(Me.dtp_date)
        Me.Controls.Add(Me.lbl_trans_no)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmd_select_supplier)
        Me.Controls.Add(Me.lbl_supplier_name)
        Me.Controls.Add(Me.lbl_supplier)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = true
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frm_transaction_items"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha's Meat Products"
        CType(Me.dgv_items,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents txt_ref_no As TextBox
    Friend WithEvents dtp_date As DateTimePicker
    Friend WithEvents lbl_trans_no As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cmd_select_supplier As Button
    Friend WithEvents lbl_supplier_name As Label
    Friend WithEvents lbl_supplier As Label
    Friend WithEvents cmd_cancel As Button
    Friend WithEvents cmd_save As Button
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_ref_no As Label
    Friend WithEvents lbl_dtp As Label
    Friend WithEvents cmd_remove_item As Button
    Friend WithEvents cmd_add_item As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_barcode As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents dgv_items As DataGridView
    Friend WithEvents item_no As DataGridViewTextBoxColumn
    Friend WithEvents barcode As DataGridViewTextBoxColumn
    Friend WithEvents item_name As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents unit As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents discount As DataGridViewTextBoxColumn
    Friend WithEvents total_amount As DataGridViewTextBoxColumn
    Friend WithEvents lbl_total_discount As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents lbl_sub_total_grand As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lbl_grand_total As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_remarks As TextBox
End Class
