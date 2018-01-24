<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_bo
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmd_close = New System.Windows.Forms.Button()
        Me.cmd_addnew = New System.Windows.Forms.Button()
        Me.dtp_to = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp_from = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgv_returns = New System.Windows.Forms.DataGridView()
        Me.ret_trans_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ret_trans_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ret_ref_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ret_grand_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ret_bo_remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_show_details = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.lbl_trans_no = New System.Windows.Forms.Label()
        Me.cmd_filter = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_returns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.cmd_close)
        Me.Panel1.Controls.Add(Me.cmd_addnew)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(671, 57)
        Me.Panel1.TabIndex = 0
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
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(6, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(171, 42)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "B.O. Records"
        '
        'cmd_close
        '
        Me.cmd_close.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_close.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_close.ForeColor = System.Drawing.Color.White
        Me.cmd_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_close.Location = New System.Drawing.Point(567, 5)
        Me.cmd_close.Name = "cmd_close"
        Me.cmd_close.Size = New System.Drawing.Size(92, 46)
        Me.cmd_close.TabIndex = 1
        Me.cmd_close.Text = "Close"
        Me.cmd_close.UseVisualStyleBackColor = False
        '
        'cmd_addnew
        '
        Me.cmd_addnew.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_addnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_addnew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_addnew.ForeColor = System.Drawing.Color.White
        Me.cmd_addnew.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_addnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_addnew.Location = New System.Drawing.Point(428, 5)
        Me.cmd_addnew.Name = "cmd_addnew"
        Me.cmd_addnew.Size = New System.Drawing.Size(133, 46)
        Me.cmd_addnew.TabIndex = 0
        Me.cmd_addnew.Text = "Add New B.O."
        Me.cmd_addnew.UseVisualStyleBackColor = False
        '
        'dtp_to
        '
        Me.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_to.Location = New System.Drawing.Point(294, 65)
        Me.dtp_to.Name = "dtp_to"
        Me.dtp_to.Size = New System.Drawing.Size(98, 20)
        Me.dtp_to.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(263, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "To :"
        '
        'dtp_from
        '
        Me.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_from.Location = New System.Drawing.Point(159, 65)
        Me.dtp_from.Name = "dtp_from"
        Me.dtp_from.Size = New System.Drawing.Size(98, 20)
        Me.dtp_from.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 13)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Show Transactions From :"
        '
        'dgv_returns
        '
        Me.dgv_returns.AllowUserToAddRows = False
        Me.dgv_returns.AllowUserToDeleteRows = False
        Me.dgv_returns.AllowUserToResizeRows = False
        Me.dgv_returns.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_returns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_returns.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_returns.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_returns.ColumnHeadersHeight = 25
        Me.dgv_returns.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ret_trans_no, Me.ret_trans_date, Me.ret_ref_no, Me.ret_grand_total, Me.ret_bo_remarks, Me.btn_show_details})
        Me.dgv_returns.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_returns.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_returns.EnableHeadersVisualStyles = False
        Me.dgv_returns.Location = New System.Drawing.Point(6, 93)
        Me.dgv_returns.MultiSelect = False
        Me.dgv_returns.Name = "dgv_returns"
        Me.dgv_returns.ReadOnly = True
        Me.dgv_returns.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_returns.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_returns.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_returns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_returns.Size = New System.Drawing.Size(651, 397)
        Me.dgv_returns.TabIndex = 77
        '
        'ret_trans_no
        '
        Me.ret_trans_no.HeaderText = "B.O. No."
        Me.ret_trans_no.Name = "ret_trans_no"
        Me.ret_trans_no.ReadOnly = True
        Me.ret_trans_no.Width = 110
        '
        'ret_trans_date
        '
        Me.ret_trans_date.HeaderText = "Date"
        Me.ret_trans_date.Name = "ret_trans_date"
        Me.ret_trans_date.ReadOnly = True
        Me.ret_trans_date.Width = 140
        '
        'ret_ref_no
        '
        Me.ret_ref_no.HeaderText = "Receipt No."
        Me.ret_ref_no.Name = "ret_ref_no"
        Me.ret_ref_no.ReadOnly = True
        Me.ret_ref_no.Width = 150
        '
        'ret_grand_total
        '
        Me.ret_grand_total.HeaderText = "Grand Total"
        Me.ret_grand_total.Name = "ret_grand_total"
        Me.ret_grand_total.ReadOnly = True
        Me.ret_grand_total.Width = 130
        '
        'ret_bo_remarks
        '
        Me.ret_bo_remarks.HeaderText = "Remarks"
        Me.ret_bo_remarks.Name = "ret_bo_remarks"
        Me.ret_bo_remarks.ReadOnly = True
        Me.ret_bo_remarks.Visible = False
        '
        'btn_show_details
        '
        Me.btn_show_details.HeaderText = "Show Details"
        Me.btn_show_details.Name = "btn_show_details"
        Me.btn_show_details.ReadOnly = True
        Me.btn_show_details.Text = "Show Details"
        Me.btn_show_details.UseColumnTextForButtonValue = True
        '
        'lbl_trans_no
        '
        Me.lbl_trans_no.BackColor = System.Drawing.Color.White
        Me.lbl_trans_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_trans_no.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_trans_no.Location = New System.Drawing.Point(636, 71)
        Me.lbl_trans_no.Name = "lbl_trans_no"
        Me.lbl_trans_no.Size = New System.Drawing.Size(21, 10)
        Me.lbl_trans_no.TabIndex = 83
        Me.lbl_trans_no.Visible = False
        '
        'cmd_filter
        '
        Me.cmd_filter.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_filter.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_filter.ForeColor = System.Drawing.Color.White
        Me.cmd_filter.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_filter.Location = New System.Drawing.Point(403, 63)
        Me.cmd_filter.Name = "cmd_filter"
        Me.cmd_filter.Size = New System.Drawing.Size(67, 23)
        Me.cmd_filter.TabIndex = 3
        Me.cmd_filter.Text = "Show"
        Me.cmd_filter.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(476, 63)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 23)
        Me.Button2.TabIndex = 84
        Me.Button2.Text = "Set"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frm_bo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 501)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lbl_trans_no)
        Me.Controls.Add(Me.dgv_returns)
        Me.Controls.Add(Me.cmd_filter)
        Me.Controls.Add(Me.dtp_to)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtp_from)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_bo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - B.O."
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_returns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents cmd_addnew As System.Windows.Forms.Button
    Friend WithEvents cmd_close As System.Windows.Forms.Button
    Friend WithEvents cmd_filter As System.Windows.Forms.Button
    Friend WithEvents dtp_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtp_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgv_returns As System.Windows.Forms.DataGridView
    Friend WithEvents ret_trans_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ret_trans_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ret_ref_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ret_grand_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ret_bo_remarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_show_details As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents lbl_trans_no As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
