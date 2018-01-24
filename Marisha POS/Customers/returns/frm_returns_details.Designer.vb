<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_returns_details
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
        Me.cmd_delete_trans = New System.Windows.Forms.Button()
        Me.cmd_cancel = New System.Windows.Forms.Button()
        Me.lbl_grand_total = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgv_returned_items = New System.Windows.Forms.DataGridView()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_receipt_no = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dtp_date = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_trans_no = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.item_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buying_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.purchase_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_returned_items, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_delete_trans
        '
        Me.cmd_delete_trans.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_delete_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_delete_trans.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_delete_trans.ForeColor = System.Drawing.Color.White
        Me.cmd_delete_trans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_delete_trans.Location = New System.Drawing.Point(492, 124)
        Me.cmd_delete_trans.Name = "cmd_delete_trans"
        Me.cmd_delete_trans.Size = New System.Drawing.Size(192, 30)
        Me.cmd_delete_trans.TabIndex = 2
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
        Me.cmd_cancel.Location = New System.Drawing.Point(37, 423)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(275, 47)
        Me.cmd_cancel.TabIndex = 3
        Me.cmd_cancel.Text = "Close"
        Me.cmd_cancel.UseVisualStyleBackColor = False
        '
        'lbl_grand_total
        '
        Me.lbl_grand_total.BackColor = System.Drawing.Color.White
        Me.lbl_grand_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_grand_total.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_grand_total.Location = New System.Drawing.Point(544, 430)
        Me.lbl_grand_total.Name = "lbl_grand_total"
        Me.lbl_grand_total.Size = New System.Drawing.Size(144, 22)
        Me.lbl_grand_total.TabIndex = 84
        Me.lbl_grand_total.Text = " "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(443, 431)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 18)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Grand Total :"
        '
        'dgv_returned_items
        '
        Me.dgv_returned_items.AllowUserToAddRows = False
        Me.dgv_returned_items.AllowUserToDeleteRows = False
        Me.dgv_returned_items.AllowUserToResizeRows = False
        Me.dgv_returned_items.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_returned_items.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_returned_items.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_returned_items.ColumnHeadersHeight = 25
        Me.dgv_returned_items.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item_no, Me.barcode, Me.item_name, Me.quantity, Me.unit, Me.buying_price, Me.total_amount, Me.purchase_price, Me.category})
        Me.dgv_returned_items.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_returned_items.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_returned_items.EnableHeadersVisualStyles = False
        Me.dgv_returned_items.Location = New System.Drawing.Point(1, 206)
        Me.dgv_returned_items.MultiSelect = False
        Me.dgv_returned_items.Name = "dgv_returned_items"
        Me.dgv_returned_items.ReadOnly = True
        Me.dgv_returned_items.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_returned_items.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_returned_items.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_returned_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_returned_items.Size = New System.Drawing.Size(706, 205)
        Me.dgv_returned_items.TabIndex = 78
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(-2, 168)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(717, 27)
        Me.Label23.TabIndex = 82
        Me.Label23.Text = "  Returned Items"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(-2, 1)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(717, 27)
        Me.Label19.TabIndex = 81
        Me.Label19.Text = "  Sales Return Info."
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_receipt_no
        '
        Me.txt_receipt_no.Enabled = False
        Me.txt_receipt_no.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_receipt_no.Location = New System.Drawing.Point(140, 76)
        Me.txt_receipt_no.Name = "txt_receipt_no"
        Me.txt_receipt_no.Size = New System.Drawing.Size(192, 26)
        Me.txt_receipt_no.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(30, 79)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(104, 18)
        Me.Label20.TabIndex = 77
        Me.Label20.Text = "Receipt No. :"
        '
        'dtp_date
        '
        Me.dtp_date.Enabled = False
        Me.dtp_date.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_date.Location = New System.Drawing.Point(439, 43)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(245, 23)
        Me.dtp_date.TabIndex = 69
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(381, 46)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 18)
        Me.Label18.TabIndex = 76
        Me.Label18.Text = "Date :"
        '
        'lbl_trans_no
        '
        Me.lbl_trans_no.BackColor = System.Drawing.Color.White
        Me.lbl_trans_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_trans_no.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_trans_no.Location = New System.Drawing.Point(140, 47)
        Me.lbl_trans_no.Name = "lbl_trans_no"
        Me.lbl_trans_no.Size = New System.Drawing.Size(131, 22)
        Me.lbl_trans_no.TabIndex = 75
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(122, 18)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "Sales Return No :"
        '
        'txt_remarks
        '
        Me.txt_remarks.Enabled = False
        Me.txt_remarks.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_remarks.Location = New System.Drawing.Point(140, 108)
        Me.txt_remarks.Multiline = True
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(298, 46)
        Me.txt_remarks.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(52, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 18)
        Me.Label8.TabIndex = 89
        Me.Label8.Text = "Remarks :"
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
        Me.barcode.Width = 140
        '
        'item_name
        '
        Me.item_name.HeaderText = "Item Name"
        Me.item_name.Name = "item_name"
        Me.item_name.ReadOnly = True
        Me.item_name.Width = 200
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
        Me.buying_price.Width = 90
        '
        'total_amount
        '
        Me.total_amount.HeaderText = "Total Amount"
        Me.total_amount.Name = "total_amount"
        Me.total_amount.ReadOnly = True
        Me.total_amount.Width = 90
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
        'frm_returns_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 482)
        Me.Controls.Add(Me.txt_remarks)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmd_delete_trans)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.lbl_grand_total)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgv_returned_items)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txt_receipt_no)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.dtp_date)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lbl_trans_no)
        Me.Controls.Add(Me.Label16)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_returns_details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - Sales Return Transaction Info."
        CType(Me.dgv_returned_items, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_delete_trans As System.Windows.Forms.Button
    Friend WithEvents cmd_cancel As System.Windows.Forms.Button
    Friend WithEvents lbl_grand_total As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgv_returned_items As System.Windows.Forms.DataGridView
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_receipt_no As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dtp_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbl_trans_no As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_remarks As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents item_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents barcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents buying_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents purchase_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents category As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
