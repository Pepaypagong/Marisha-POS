<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cash_trans
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_cash_trans = New System.Windows.Forms.DataGridView()
        Me.trans_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_datetime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.disc_percent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grand_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cash_tendered = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.change = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_show_details = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dtp_to = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp_from = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmd_filter = New System.Windows.Forms.Button()
        Me.lbl_trans_no = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgv_cash_trans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_cash_trans
        '
        Me.dgv_cash_trans.AllowUserToAddRows = False
        Me.dgv_cash_trans.AllowUserToDeleteRows = False
        Me.dgv_cash_trans.AllowUserToResizeRows = False
        Me.dgv_cash_trans.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_cash_trans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_cash_trans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_cash_trans.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_cash_trans.ColumnHeadersHeight = 25
        Me.dgv_cash_trans.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.trans_no, Me.trans_datetime, Me.sub_total, Me.disc_percent, Me.total_discount, Me.grand_total, Me.cash_tendered, Me.change, Me.btn_show_details})
        Me.dgv_cash_trans.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_cash_trans.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_cash_trans.EnableHeadersVisualStyles = False
        Me.dgv_cash_trans.Location = New System.Drawing.Point(6, 93)
        Me.dgv_cash_trans.MultiSelect = False
        Me.dgv_cash_trans.Name = "dgv_cash_trans"
        Me.dgv_cash_trans.ReadOnly = True
        Me.dgv_cash_trans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_cash_trans.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_cash_trans.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_cash_trans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_cash_trans.Size = New System.Drawing.Size(901, 374)
        Me.dgv_cash_trans.TabIndex = 59
        '
        'trans_no
        '
        Me.trans_no.HeaderText = "Trans. No."
        Me.trans_no.Name = "trans_no"
        Me.trans_no.ReadOnly = True
        Me.trans_no.Width = 80
        '
        'trans_datetime
        '
        Me.trans_datetime.HeaderText = "Date and Time"
        Me.trans_datetime.Name = "trans_datetime"
        Me.trans_datetime.ReadOnly = True
        Me.trans_datetime.Width = 150
        '
        'sub_total
        '
        Me.sub_total.HeaderText = "Sub Total"
        Me.sub_total.Name = "sub_total"
        Me.sub_total.ReadOnly = True
        Me.sub_total.Width = 110
        '
        'disc_percent
        '
        Me.disc_percent.HeaderText = "Disc. (%)"
        Me.disc_percent.Name = "disc_percent"
        Me.disc_percent.ReadOnly = True
        Me.disc_percent.Visible = False
        Me.disc_percent.Width = 90
        '
        'total_discount
        '
        Me.total_discount.HeaderText = "Total Discount"
        Me.total_discount.Name = "total_discount"
        Me.total_discount.ReadOnly = True
        Me.total_discount.Width = 110
        '
        'grand_total
        '
        Me.grand_total.HeaderText = "Grand Total"
        Me.grand_total.Name = "grand_total"
        Me.grand_total.ReadOnly = True
        Me.grand_total.Width = 110
        '
        'cash_tendered
        '
        Me.cash_tendered.HeaderText = "Cash Tendered"
        Me.cash_tendered.Name = "cash_tendered"
        Me.cash_tendered.ReadOnly = True
        '
        'change
        '
        Me.change.HeaderText = "Change"
        Me.change.Name = "change"
        Me.change.ReadOnly = True
        '
        'btn_show_details
        '
        Me.btn_show_details.HeaderText = "Show Details"
        Me.btn_show_details.Name = "btn_show_details"
        Me.btn_show_details.ReadOnly = True
        Me.btn_show_details.Text = "Show Details"
        Me.btn_show_details.UseColumnTextForButtonValue = True
        '
        'dtp_to
        '
        Me.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_to.Location = New System.Drawing.Point(294, 66)
        Me.dtp_to.Name = "dtp_to"
        Me.dtp_to.Size = New System.Drawing.Size(98, 20)
        Me.dtp_to.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(263, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "To :"
        '
        'dtp_from
        '
        Me.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_from.Location = New System.Drawing.Point(159, 66)
        Me.dtp_from.Name = "dtp_from"
        Me.dtp_from.Size = New System.Drawing.Size(98, 20)
        Me.dtp_from.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Show Transactions From :"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(815, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 47)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmd_filter
        '
        Me.cmd_filter.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_filter.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_filter.ForeColor = System.Drawing.Color.White
        Me.cmd_filter.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_filter.Location = New System.Drawing.Point(403, 64)
        Me.cmd_filter.Name = "cmd_filter"
        Me.cmd_filter.Size = New System.Drawing.Size(67, 23)
        Me.cmd_filter.TabIndex = 3
        Me.cmd_filter.Text = "Filter"
        Me.cmd_filter.UseVisualStyleBackColor = False
        '
        'lbl_trans_no
        '
        Me.lbl_trans_no.BackColor = System.Drawing.Color.White
        Me.lbl_trans_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_trans_no.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_trans_no.Location = New System.Drawing.Point(885, 66)
        Me.lbl_trans_no.Name = "lbl_trans_no"
        Me.lbl_trans_no.Size = New System.Drawing.Size(21, 22)
        Me.lbl_trans_no.TabIndex = 61
        Me.lbl_trans_no.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(916, 57)
        Me.Panel1.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(6, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(398, 42)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Cash Sales Transaction Records"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(476, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 23)
        Me.Button2.TabIndex = 62
        Me.Button2.Text = "Set"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frm_cash_trans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 474)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_trans_no)
        Me.Controls.Add(Me.dgv_cash_trans)
        Me.Controls.Add(Me.cmd_filter)
        Me.Controls.Add(Me.dtp_to)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtp_from)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_cash_trans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - Cash Transactions"
        CType(Me.dgv_cash_trans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_cash_trans As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_filter As System.Windows.Forms.Button
    Friend WithEvents dtp_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtp_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbl_trans_no As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents trans_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_datetime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sub_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents disc_percent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_discount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grand_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cash_tendered As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents change As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_show_details As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
