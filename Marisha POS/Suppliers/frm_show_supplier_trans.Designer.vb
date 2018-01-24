<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_show_supplier_trans
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_delete_trans = New System.Windows.Forms.Button()
        Me.cmd_cancel = New System.Windows.Forms.Button()
        Me.lbl_total_discount = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lbl_sub_total_grand = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lbl_grand_total = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgv_purchase_list = New System.Windows.Forms.DataGridView()
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
        Me.lbl_supplier_name = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplier_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.beg_inv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buying_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_purchase_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.cmd_delete_trans)
        Me.GroupBox1.Controls.Add(Me.cmd_cancel)
        Me.GroupBox1.Controls.Add(Me.lbl_total_discount)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.lbl_sub_total_grand)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.lbl_grand_total)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dgv_purchase_list)
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
        Me.GroupBox1.Controls.Add(Me.lbl_supplier_name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(765, 465)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'cmd_delete_trans
        '
        Me.cmd_delete_trans.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_delete_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_delete_trans.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_delete_trans.ForeColor = System.Drawing.Color.White
        Me.cmd_delete_trans.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_delete_trans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_delete_trans.Location = New System.Drawing.Point(601, 90)
        Me.cmd_delete_trans.Name = "cmd_delete_trans"
        Me.cmd_delete_trans.Size = New System.Drawing.Size(136, 30)
        Me.cmd_delete_trans.TabIndex = 1
        Me.cmd_delete_trans.Text = "Delete Transaction"
        Me.cmd_delete_trans.UseVisualStyleBackColor = False
        '
        'cmd_cancel
        '
        Me.cmd_cancel.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_cancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_cancel.ForeColor = System.Drawing.Color.White
        Me.cmd_cancel.Location = New System.Drawing.Point(6, 412)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(301, 47)
        Me.cmd_cancel.TabIndex = 2
        Me.cmd_cancel.Text = "Close"
        Me.cmd_cancel.UseVisualStyleBackColor = False
        '
        'lbl_total_discount
        '
        Me.lbl_total_discount.BackColor = System.Drawing.Color.White
        Me.lbl_total_discount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_total_discount.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_discount.Location = New System.Drawing.Point(601, 403)
        Me.lbl_total_discount.Name = "lbl_total_discount"
        Me.lbl_total_discount.Size = New System.Drawing.Size(144, 22)
        Me.lbl_total_discount.TabIndex = 44
        Me.lbl_total_discount.Text = " "
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(484, 404)
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
        Me.lbl_sub_total_grand.Location = New System.Drawing.Point(601, 377)
        Me.lbl_sub_total_grand.Name = "lbl_sub_total_grand"
        Me.lbl_sub_total_grand.Size = New System.Drawing.Size(144, 22)
        Me.lbl_sub_total_grand.TabIndex = 42
        Me.lbl_sub_total_grand.Text = " "
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(515, 381)
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
        Me.lbl_grand_total.Location = New System.Drawing.Point(601, 428)
        Me.lbl_grand_total.Name = "lbl_grand_total"
        Me.lbl_grand_total.Size = New System.Drawing.Size(144, 22)
        Me.lbl_grand_total.TabIndex = 37
        Me.lbl_grand_total.Text = " "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(500, 429)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 18)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Grand Total :"
        '
        'dgv_purchase_list
        '
        Me.dgv_purchase_list.AllowUserToAddRows = False
        Me.dgv_purchase_list.AllowUserToDeleteRows = False
        Me.dgv_purchase_list.AllowUserToResizeRows = False
        Me.dgv_purchase_list.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_purchase_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_purchase_list.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_purchase_list.ColumnHeadersHeight = 25
        Me.dgv_purchase_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.trans_no, Me.trans_date, Me.supplier_no, Me.item_no, Me.barcode, Me.item_name, Me.category, Me.brand, Me.beg_inv, Me.quantity, Me.unit, Me.buying_price, Me.total_price, Me.discount, Me.total_amount})
        Me.dgv_purchase_list.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_purchase_list.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_purchase_list.EnableHeadersVisualStyles = False
        Me.dgv_purchase_list.Location = New System.Drawing.Point(1, 160)
        Me.dgv_purchase_list.MultiSelect = False
        Me.dgv_purchase_list.Name = "dgv_purchase_list"
        Me.dgv_purchase_list.ReadOnly = True
        Me.dgv_purchase_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_purchase_list.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_purchase_list.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_purchase_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_purchase_list.Size = New System.Drawing.Size(762, 205)
        Me.dgv_purchase_list.TabIndex = 29
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(-1, 125)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(768, 27)
        Me.Label23.TabIndex = 34
        Me.Label23.Text = "  Purchased Items"
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
        Me.Label19.Text = "  Purchase Transaction and Supplier Info."
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_ref_no
        '
        Me.txt_ref_no.Enabled = False
        Me.txt_ref_no.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ref_no.Location = New System.Drawing.Point(545, 60)
        Me.txt_ref_no.Name = "txt_ref_no"
        Me.txt_ref_no.Size = New System.Drawing.Size(192, 26)
        Me.txt_ref_no.TabIndex = 0
        '
        'lbl_supplier_no
        '
        Me.lbl_supplier_no.BackColor = System.Drawing.Color.White
        Me.lbl_supplier_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_supplier_no.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_supplier_no.Location = New System.Drawing.Point(148, 63)
        Me.lbl_supplier_no.Name = "lbl_supplier_no"
        Me.lbl_supplier_no.Size = New System.Drawing.Size(227, 22)
        Me.lbl_supplier_no.TabIndex = 31
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(24, 64)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(95, 18)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "Supplier No. :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(434, 63)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(112, 18)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Reference No. :"
        '
        'dtp_date
        '
        Me.dtp_date.Enabled = False
        Me.dtp_date.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_date.Location = New System.Drawing.Point(492, 34)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(245, 23)
        Me.dtp_date.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(434, 37)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 18)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Date :"
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
        Me.Label16.Location = New System.Drawing.Point(24, 37)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(122, 18)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Transaction No. :"
        '
        'lbl_supplier_name
        '
        Me.lbl_supplier_name.BackColor = System.Drawing.Color.White
        Me.lbl_supplier_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_supplier_name.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_supplier_name.Location = New System.Drawing.Point(149, 91)
        Me.lbl_supplier_name.Name = "lbl_supplier_name"
        Me.lbl_supplier_name.Size = New System.Drawing.Size(227, 22)
        Me.lbl_supplier_name.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Supplier Name :"
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'trans_no
        '
        Me.trans_no.HeaderText = "Trans_no"
        Me.trans_no.Name = "trans_no"
        Me.trans_no.ReadOnly = True
        Me.trans_no.Visible = False
        Me.trans_no.Width = 60
        '
        'trans_date
        '
        Me.trans_date.HeaderText = "Trans_date"
        Me.trans_date.Name = "trans_date"
        Me.trans_date.ReadOnly = True
        Me.trans_date.Visible = False
        '
        'supplier_no
        '
        Me.supplier_no.HeaderText = "supplier_no"
        Me.supplier_no.Name = "supplier_no"
        Me.supplier_no.ReadOnly = True
        Me.supplier_no.Visible = False
        '
        'item_no
        '
        Me.item_no.HeaderText = "Item No."
        Me.item_no.Name = "item_no"
        Me.item_no.ReadOnly = True
        Me.item_no.Width = 70
        '
        'barcode
        '
        Me.barcode.HeaderText = "Barcode"
        Me.barcode.Name = "barcode"
        Me.barcode.ReadOnly = True
        '
        'item_name
        '
        Me.item_name.HeaderText = "Item Name"
        Me.item_name.Name = "item_name"
        Me.item_name.ReadOnly = True
        Me.item_name.Width = 200
        '
        'category
        '
        Me.category.HeaderText = "Category"
        Me.category.Name = "category"
        Me.category.ReadOnly = True
        Me.category.Visible = False
        '
        'brand
        '
        Me.brand.HeaderText = "Brand"
        Me.brand.Name = "brand"
        Me.brand.ReadOnly = True
        Me.brand.Visible = False
        '
        'beg_inv
        '
        Me.beg_inv.HeaderText = "Beginning Inventory"
        Me.beg_inv.Name = "beg_inv"
        Me.beg_inv.ReadOnly = True
        Me.beg_inv.Visible = False
        '
        'quantity
        '
        Me.quantity.HeaderText = "Qty."
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        Me.quantity.Width = 60
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
        Me.buying_price.Width = 80
        '
        'total_price
        '
        Me.total_price.HeaderText = "Total_price"
        Me.total_price.Name = "total_price"
        Me.total_price.ReadOnly = True
        Me.total_price.Visible = False
        '
        'discount
        '
        Me.discount.HeaderText = "Discount"
        Me.discount.Name = "discount"
        Me.discount.ReadOnly = True
        Me.discount.Width = 80
        '
        'total_amount
        '
        Me.total_amount.HeaderText = "Total Amount"
        Me.total_amount.Name = "total_amount"
        Me.total_amount.ReadOnly = True
        '
        'frm_show_supplier_trans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 472)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_show_supplier_trans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - Purchase Transction Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_purchase_list, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgv_purchase_list As System.Windows.Forms.DataGridView
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_ref_no As System.Windows.Forms.TextBox
    Friend WithEvents lbl_supplier_no As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dtp_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbl_trans_no As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbl_supplier_name As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmd_delete_trans As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supplier_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents barcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents brand As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents beg_inv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents buying_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_amount As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
