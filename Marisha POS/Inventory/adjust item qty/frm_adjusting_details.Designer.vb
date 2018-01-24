<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_adjusting_details
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
        Me.lbl_date_time = New System.Windows.Forms.Label()
        Me.lbl_trans_type = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmd_delete_trans = New System.Windows.Forms.Button()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmd_cancel = New System.Windows.Forms.Button()
        Me.dgv_purchase_list = New System.Windows.Forms.DataGridView()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_trans_no = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.item_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buying_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_purchase_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.lbl_date_time)
        Me.GroupBox1.Controls.Add(Me.lbl_trans_type)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmd_delete_trans)
        Me.GroupBox1.Controls.Add(Me.txt_remarks)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmd_cancel)
        Me.GroupBox1.Controls.Add(Me.dgv_purchase_list)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.lbl_trans_no)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(765, 535)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'lbl_date_time
        '
        Me.lbl_date_time.BackColor = System.Drawing.Color.White
        Me.lbl_date_time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_date_time.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date_time.Location = New System.Drawing.Point(498, 38)
        Me.lbl_date_time.Name = "lbl_date_time"
        Me.lbl_date_time.Size = New System.Drawing.Size(245, 22)
        Me.lbl_date_time.TabIndex = 53
        '
        'lbl_trans_type
        '
        Me.lbl_trans_type.BackColor = System.Drawing.Color.White
        Me.lbl_trans_type.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_trans_type.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_trans_type.Location = New System.Drawing.Point(196, 164)
        Me.lbl_trans_type.Name = "lbl_trans_type"
        Me.lbl_trans_type.Size = New System.Drawing.Size(240, 22)
        Me.lbl_trans_type.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 18)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Adjustment Type :"
        '
        'cmd_delete_trans
        '
        Me.cmd_delete_trans.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_delete_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_delete_trans.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_delete_trans.ForeColor = System.Drawing.Color.White
        Me.cmd_delete_trans.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_delete_trans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_delete_trans.Location = New System.Drawing.Point(577, 160)
        Me.cmd_delete_trans.Name = "cmd_delete_trans"
        Me.cmd_delete_trans.Size = New System.Drawing.Size(166, 30)
        Me.cmd_delete_trans.TabIndex = 50
        Me.cmd_delete_trans.Text = "Delete Record"
        Me.cmd_delete_trans.UseVisualStyleBackColor = False
        '
        'txt_remarks
        '
        Me.txt_remarks.BackColor = System.Drawing.Color.White
        Me.txt_remarks.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_remarks.Location = New System.Drawing.Point(196, 73)
        Me.txt_remarks.Multiline = True
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.ReadOnly = True
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
        Me.cmd_cancel.Location = New System.Drawing.Point(22, 477)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(231, 47)
        Me.cmd_cancel.TabIndex = 7
        Me.cmd_cancel.Text = "Close"
        Me.cmd_cancel.UseVisualStyleBackColor = False
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
        Me.dgv_purchase_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item_no, Me.barcode, Me.item_name, Me.quantity, Me.buying_price, Me.unit, Me.category})
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
        Me.dgv_purchase_list.Location = New System.Drawing.Point(6, 250)
        Me.dgv_purchase_list.MultiSelect = False
        Me.dgv_purchase_list.Name = "dgv_purchase_list"
        Me.dgv_purchase_list.ReadOnly = True
        Me.dgv_purchase_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_purchase_list.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_purchase_list.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_purchase_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_purchase_list.Size = New System.Drawing.Size(753, 219)
        Me.dgv_purchase_list.TabIndex = 29
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(-1, 212)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(768, 27)
        Me.Label23.TabIndex = 34
        Me.Label23.Text = "  Included Items"
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
        'unit
        '
        Me.unit.HeaderText = "Unit"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        Me.unit.Width = 50
        '
        'category
        '
        Me.category.HeaderText = "category"
        Me.category.Name = "category"
        Me.category.ReadOnly = True
        Me.category.Visible = False
        '
        'frm_adjusting_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 544)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_adjusting_details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - Adjustment Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_purchase_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_remarks As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmd_cancel As System.Windows.Forms.Button
    Friend WithEvents dgv_purchase_list As System.Windows.Forms.DataGridView
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbl_trans_no As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmd_delete_trans As System.Windows.Forms.Button
    Friend WithEvents lbl_trans_type As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_date_time As System.Windows.Forms.Label
    Friend WithEvents item_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents barcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents buying_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents category As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
