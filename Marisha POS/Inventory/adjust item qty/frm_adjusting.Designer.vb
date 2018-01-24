<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_adjusting
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
        Me.lbl_unit = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_buying_price = New System.Windows.Forms.Label()
        Me.lbl_init_beg_inv_price = New System.Windows.Forms.Label()
        Me.lbl_beginning = New System.Windows.Forms.Label()
        Me.lbl_ending = New System.Windows.Forms.Label()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmd_cancel = New System.Windows.Forms.Button()
        Me.cmd_save = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmd_add_to_list = New System.Windows.Forms.Button()
        Me.dgv_purchase_list = New System.Windows.Forms.DataGridView()
        Me.cmd_select_item = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtp_date = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_trans_no = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_category = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_item_no = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl_item_name = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbl_barcode = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.item_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.beg_inv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buying_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.negin_inv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ending_inv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.beg_inv_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.beg_inv_init_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_purchase_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.lbl_unit)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_buying_price)
        Me.GroupBox1.Controls.Add(Me.lbl_init_beg_inv_price)
        Me.GroupBox1.Controls.Add(Me.lbl_beginning)
        Me.GroupBox1.Controls.Add(Me.lbl_ending)
        Me.GroupBox1.Controls.Add(Me.txt_remarks)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmd_cancel)
        Me.GroupBox1.Controls.Add(Me.cmd_save)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmd_add_to_list)
        Me.GroupBox1.Controls.Add(Me.dgv_purchase_list)
        Me.GroupBox1.Controls.Add(Me.cmd_select_item)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.dtp_date)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.lbl_trans_no)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.lbl_brand)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.lbl_category)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lbl_item_no)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.lbl_item_name)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txt_qty)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.lbl_barcode)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(765, 587)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'lbl_unit
        '
        Me.lbl_unit.BackColor = System.Drawing.Color.White
        Me.lbl_unit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_unit.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_unit.Location = New System.Drawing.Point(436, 255)
        Me.lbl_unit.Name = "lbl_unit"
        Me.lbl_unit.Size = New System.Drawing.Size(106, 22)
        Me.lbl_unit.TabIndex = 102
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(396, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 18)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Unit :"
        '
        'lbl_buying_price
        '
        Me.lbl_buying_price.BackColor = System.Drawing.Color.White
        Me.lbl_buying_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_buying_price.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_buying_price.Location = New System.Drawing.Point(261, 291)
        Me.lbl_buying_price.Name = "lbl_buying_price"
        Me.lbl_buying_price.Size = New System.Drawing.Size(32, 26)
        Me.lbl_buying_price.TabIndex = 100
        Me.lbl_buying_price.Visible = False
        '
        'lbl_init_beg_inv_price
        '
        Me.lbl_init_beg_inv_price.BackColor = System.Drawing.Color.White
        Me.lbl_init_beg_inv_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_init_beg_inv_price.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_init_beg_inv_price.Location = New System.Drawing.Point(299, 289)
        Me.lbl_init_beg_inv_price.Name = "lbl_init_beg_inv_price"
        Me.lbl_init_beg_inv_price.Size = New System.Drawing.Size(31, 30)
        Me.lbl_init_beg_inv_price.TabIndex = 99
        Me.lbl_init_beg_inv_price.Visible = False
        '
        'lbl_beginning
        '
        Me.lbl_beginning.BackColor = System.Drawing.Color.White
        Me.lbl_beginning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_beginning.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_beginning.Location = New System.Drawing.Point(336, 289)
        Me.lbl_beginning.Name = "lbl_beginning"
        Me.lbl_beginning.Size = New System.Drawing.Size(29, 30)
        Me.lbl_beginning.TabIndex = 97
        Me.lbl_beginning.Visible = False
        '
        'lbl_ending
        '
        Me.lbl_ending.BackColor = System.Drawing.Color.White
        Me.lbl_ending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ending.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ending.Location = New System.Drawing.Point(371, 288)
        Me.lbl_ending.Name = "lbl_ending"
        Me.lbl_ending.Size = New System.Drawing.Size(34, 30)
        Me.lbl_ending.TabIndex = 96
        Me.lbl_ending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_ending.Visible = False
        '
        'txt_remarks
        '
        Me.txt_remarks.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_remarks.Location = New System.Drawing.Point(196, 73)
        Me.txt_remarks.Multiline = True
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(547, 76)
        Me.txt_remarks.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(171, 18)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Adjustment Remarks :"
        '
        'cmd_cancel
        '
        Me.cmd_cancel.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_cancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_cancel.ForeColor = System.Drawing.Color.White
        Me.cmd_cancel.Location = New System.Drawing.Point(399, 529)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(90, 47)
        Me.cmd_cancel.TabIndex = 7
        Me.cmd_cancel.Text = "Ca&ncel"
        Me.cmd_cancel.UseVisualStyleBackColor = False
        '
        'cmd_save
        '
        Me.cmd_save.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_save.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_save.ForeColor = System.Drawing.Color.White
        Me.cmd_save.Location = New System.Drawing.Point(287, 529)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.Size = New System.Drawing.Size(90, 47)
        Me.cmd_save.TabIndex = 6
        Me.cmd_save.Text = "&Save"
        Me.cmd_save.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(611, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 28)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "* double click an item " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from the list to remove"
        '
        'cmd_add_to_list
        '
        Me.cmd_add_to_list.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_add_to_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_add_to_list.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_add_to_list.ForeColor = System.Drawing.Color.White
        Me.cmd_add_to_list.Location = New System.Drawing.Point(435, 293)
        Me.cmd_add_to_list.Name = "cmd_add_to_list"
        Me.cmd_add_to_list.Size = New System.Drawing.Size(170, 26)
        Me.cmd_add_to_list.TabIndex = 5
        Me.cmd_add_to_list.Text = "Add To List"
        Me.cmd_add_to_list.UseVisualStyleBackColor = False
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
        Me.dgv_purchase_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item_no, Me.barcode, Me.item_name, Me.category, Me.brand, Me.beg_inv, Me.quantity, Me.buying_price, Me.negin_inv, Me.ending_inv, Me.beg_inv_price, Me.beg_inv_init_price, Me.unit})
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
        Me.dgv_purchase_list.Location = New System.Drawing.Point(6, 337)
        Me.dgv_purchase_list.MultiSelect = False
        Me.dgv_purchase_list.Name = "dgv_purchase_list"
        Me.dgv_purchase_list.ReadOnly = True
        Me.dgv_purchase_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_purchase_list.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_purchase_list.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_purchase_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_purchase_list.Size = New System.Drawing.Size(754, 186)
        Me.dgv_purchase_list.TabIndex = 29
        '
        'cmd_select_item
        '
        Me.cmd_select_item.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_select_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_select_item.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_select_item.ForeColor = System.Drawing.Color.White
        Me.cmd_select_item.Location = New System.Drawing.Point(281, 198)
        Me.cmd_select_item.Name = "cmd_select_item"
        Me.cmd_select_item.Size = New System.Drawing.Size(69, 24)
        Me.cmd_select_item.TabIndex = 2
        Me.cmd_select_item.Text = "Select"
        Me.cmd_select_item.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(-1, 163)
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
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(-1, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(768, 27)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "  Adjustment Info"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtp_date
        '
        Me.dtp_date.Enabled = False
        Me.dtp_date.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_date.Location = New System.Drawing.Point(498, 36)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(245, 23)
        Me.dtp_date.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(440, 39)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 18)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Date :"
        '
        'lbl_trans_no
        '
        Me.lbl_trans_no.BackColor = System.Drawing.Color.White
        Me.lbl_trans_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_trans_no.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_trans_no.Location = New System.Drawing.Point(145, 38)
        Me.lbl_trans_no.Name = "lbl_trans_no"
        Me.lbl_trans_no.Size = New System.Drawing.Size(168, 22)
        Me.lbl_trans_no.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(19, 39)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(121, 18)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Adjustment No. :"
        '
        'lbl_brand
        '
        Me.lbl_brand.BackColor = System.Drawing.Color.White
        Me.lbl_brand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_brand.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.Location = New System.Drawing.Point(615, 226)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(130, 22)
        Me.lbl_brand.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(562, 227)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 18)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Brand :"
        '
        'lbl_category
        '
        Me.lbl_category.BackColor = System.Drawing.Color.White
        Me.lbl_category.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_category.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_category.Location = New System.Drawing.Point(436, 226)
        Me.lbl_category.Name = "lbl_category"
        Me.lbl_category.Size = New System.Drawing.Size(106, 22)
        Me.lbl_category.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(362, 227)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 18)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Category :"
        '
        'lbl_item_no
        '
        Me.lbl_item_no.BackColor = System.Drawing.Color.White
        Me.lbl_item_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_item_no.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_item_no.Location = New System.Drawing.Point(122, 199)
        Me.lbl_item_no.Name = "lbl_item_no"
        Me.lbl_item_no.Size = New System.Drawing.Size(153, 22)
        Me.lbl_item_no.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(45, 200)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 18)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Item No. :"
        '
        'lbl_item_name
        '
        Me.lbl_item_name.BackColor = System.Drawing.Color.White
        Me.lbl_item_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_item_name.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_item_name.Location = New System.Drawing.Point(122, 225)
        Me.lbl_item_name.Name = "lbl_item_name"
        Me.lbl_item_name.Size = New System.Drawing.Size(228, 22)
        Me.lbl_item_name.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(27, 226)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 18)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Item Name :"
        '
        'txt_qty
        '
        Me.txt_qty.Enabled = False
        Me.txt_qty.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.Location = New System.Drawing.Point(122, 255)
        Me.txt_qty.MaxLength = 8
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(153, 26)
        Me.txt_qty.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(25, 258)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(93, 18)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Enter Qty. :"
        '
        'lbl_barcode
        '
        Me.lbl_barcode.BackColor = System.Drawing.Color.White
        Me.lbl_barcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_barcode.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_barcode.Location = New System.Drawing.Point(436, 199)
        Me.lbl_barcode.Name = "lbl_barcode"
        Me.lbl_barcode.Size = New System.Drawing.Size(309, 22)
        Me.lbl_barcode.TabIndex = 3
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(368, 200)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(71, 18)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Barcode :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lbl_title)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(783, 57)
        Me.Panel1.TabIndex = 70
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(921, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 47)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(6, 4)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(297, 42)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Increase Item Quantity"
        '
        'item_no
        '
        Me.item_no.HeaderText = "Item No."
        Me.item_no.Name = "item_no"
        Me.item_no.ReadOnly = True
        Me.item_no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.item_no.Width = 90
        '
        'barcode
        '
        Me.barcode.HeaderText = "Barcode"
        Me.barcode.Name = "barcode"
        Me.barcode.ReadOnly = True
        Me.barcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.barcode.Width = 160
        '
        'item_name
        '
        Me.item_name.HeaderText = "Item Name"
        Me.item_name.Name = "item_name"
        Me.item_name.ReadOnly = True
        Me.item_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.item_name.Width = 350
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
        Me.beg_inv.HeaderText = "Beginning Inv"
        Me.beg_inv.Name = "beg_inv"
        Me.beg_inv.ReadOnly = True
        Me.beg_inv.Visible = False
        '
        'quantity
        '
        Me.quantity.HeaderText = "Qty."
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        Me.quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.quantity.Width = 80
        '
        'buying_price
        '
        Me.buying_price.HeaderText = "Price"
        Me.buying_price.Name = "buying_price"
        Me.buying_price.ReadOnly = True
        Me.buying_price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.buying_price.Visible = False
        Me.buying_price.Width = 120
        '
        'negin_inv
        '
        Me.negin_inv.HeaderText = "begin_inv"
        Me.negin_inv.Name = "negin_inv"
        Me.negin_inv.ReadOnly = True
        Me.negin_inv.Visible = False
        '
        'ending_inv
        '
        Me.ending_inv.HeaderText = "ending_inv"
        Me.ending_inv.Name = "ending_inv"
        Me.ending_inv.ReadOnly = True
        Me.ending_inv.Visible = False
        '
        'beg_inv_price
        '
        Me.beg_inv_price.HeaderText = "beg_inv_price"
        Me.beg_inv_price.Name = "beg_inv_price"
        Me.beg_inv_price.ReadOnly = True
        Me.beg_inv_price.Visible = False
        '
        'beg_inv_init_price
        '
        Me.beg_inv_init_price.HeaderText = "beg_inv_init_price"
        Me.beg_inv_init_price.Name = "beg_inv_init_price"
        Me.beg_inv_init_price.ReadOnly = True
        Me.beg_inv_init_price.Visible = False
        '
        'unit
        '
        Me.unit.HeaderText = "Unit"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        Me.unit.Width = 50
        '
        'frm_adjusting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 657)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_adjusting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - Adjusting Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_purchase_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_buying_price As System.Windows.Forms.Label
    Friend WithEvents lbl_init_beg_inv_price As System.Windows.Forms.Label
    Friend WithEvents lbl_beginning As System.Windows.Forms.Label
    Friend WithEvents lbl_ending As System.Windows.Forms.Label
    Friend WithEvents txt_remarks As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmd_cancel As System.Windows.Forms.Button
    Friend WithEvents cmd_save As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmd_add_to_list As System.Windows.Forms.Button
    Friend WithEvents dgv_purchase_list As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_select_item As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents dtp_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbl_trans_no As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbl_brand As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbl_category As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl_item_no As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbl_item_name As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_qty As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lbl_barcode As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents lbl_unit As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents item_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents barcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents brand As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents beg_inv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents buying_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents negin_inv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ending_inv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents beg_inv_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents beg_inv_init_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
