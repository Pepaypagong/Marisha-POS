<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_payment_records
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
        Me.lbl_lname = New System.Windows.Forms.Label()
        Me.lbl_mname = New System.Windows.Forms.Label()
        Me.lbl_fname = New System.Windows.Forms.Label()
        Me.lbl_customer_no = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_current_bal = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmd_close = New System.Windows.Forms.Button()
        Me.dgv_payments = New System.Windows.Forms.DataGridView()
        Me.dtp_to = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp_from = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmd_pay = New System.Windows.Forms.Button()
        Me.cmd_filter = New System.Windows.Forms.Button()
        Me.lbl_pay_id = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_datetime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amt_paid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cmd_settings = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_payments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_lname
        '
        Me.lbl_lname.BackColor = System.Drawing.Color.White
        Me.lbl_lname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_lname.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lname.Location = New System.Drawing.Point(126, 150)
        Me.lbl_lname.Name = "lbl_lname"
        Me.lbl_lname.Size = New System.Drawing.Size(176, 22)
        Me.lbl_lname.TabIndex = 56
        '
        'lbl_mname
        '
        Me.lbl_mname.BackColor = System.Drawing.Color.White
        Me.lbl_mname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_mname.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mname.Location = New System.Drawing.Point(126, 124)
        Me.lbl_mname.Name = "lbl_mname"
        Me.lbl_mname.Size = New System.Drawing.Size(176, 22)
        Me.lbl_mname.TabIndex = 55
        '
        'lbl_fname
        '
        Me.lbl_fname.BackColor = System.Drawing.Color.White
        Me.lbl_fname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_fname.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fname.Location = New System.Drawing.Point(126, 98)
        Me.lbl_fname.Name = "lbl_fname"
        Me.lbl_fname.Size = New System.Drawing.Size(176, 22)
        Me.lbl_fname.TabIndex = 54
        '
        'lbl_customer_no
        '
        Me.lbl_customer_no.BackColor = System.Drawing.Color.White
        Me.lbl_customer_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_customer_no.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_no.Location = New System.Drawing.Point(126, 71)
        Me.lbl_customer_no.Name = "lbl_customer_no"
        Me.lbl_customer_no.Size = New System.Drawing.Size(73, 22)
        Me.lbl_customer_no.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 16)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Middle Name :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 16)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Last Name :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 16)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "First name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Customer No. :"
        '
        'lbl_current_bal
        '
        Me.lbl_current_bal.BackColor = System.Drawing.Color.White
        Me.lbl_current_bal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_current_bal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_current_bal.Location = New System.Drawing.Point(64, 225)
        Me.lbl_current_bal.Name = "lbl_current_bal"
        Me.lbl_current_bal.Size = New System.Drawing.Size(203, 27)
        Me.lbl_current_bal.TabIndex = 58
        Me.lbl_current_bal.Text = "0.00"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(103, 205)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 20)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Current Balance :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(787, 53)
        Me.Panel1.TabIndex = 59
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(11, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(357, 42)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Customer Payment Records"
        '
        'cmd_close
        '
        Me.cmd_close.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_close.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_close.ForeColor = System.Drawing.Color.White
        Me.cmd_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_close.Location = New System.Drawing.Point(184, 278)
        Me.cmd_close.Name = "cmd_close"
        Me.cmd_close.Size = New System.Drawing.Size(118, 47)
        Me.cmd_close.TabIndex = 4
        Me.cmd_close.Text = "Close"
        Me.cmd_close.UseVisualStyleBackColor = False
        '
        'dgv_payments
        '
        Me.dgv_payments.AllowUserToAddRows = False
        Me.dgv_payments.AllowUserToDeleteRows = False
        Me.dgv_payments.AllowUserToResizeRows = False
        Me.dgv_payments.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_payments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_payments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_payments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_payments.ColumnHeadersHeight = 25
        Me.dgv_payments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.trans_datetime, Me.cust_no, Me.amt_paid, Me.delete})
        Me.dgv_payments.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_payments.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_payments.EnableHeadersVisualStyles = False
        Me.dgv_payments.Location = New System.Drawing.Point(325, 93)
        Me.dgv_payments.MultiSelect = False
        Me.dgv_payments.Name = "dgv_payments"
        Me.dgv_payments.ReadOnly = True
        Me.dgv_payments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_payments.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_payments.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_payments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_payments.Size = New System.Drawing.Size(449, 232)
        Me.dgv_payments.TabIndex = 60
        '
        'dtp_to
        '
        Me.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_to.Location = New System.Drawing.Point(539, 67)
        Me.dtp_to.Name = "dtp_to"
        Me.dtp_to.Size = New System.Drawing.Size(98, 20)
        Me.dtp_to.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(508, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "To :"
        '
        'dtp_from
        '
        Me.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_from.Location = New System.Drawing.Point(403, 67)
        Me.dtp_from.Name = "dtp_from"
        Me.dtp_from.Size = New System.Drawing.Size(98, 20)
        Me.dtp_from.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(322, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Show From :"
        '
        'cmd_pay
        '
        Me.cmd_pay.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_pay.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_pay.ForeColor = System.Drawing.Color.White
        Me.cmd_pay.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_pay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_pay.Location = New System.Drawing.Point(20, 278)
        Me.cmd_pay.Name = "cmd_pay"
        Me.cmd_pay.Size = New System.Drawing.Size(112, 47)
        Me.cmd_pay.TabIndex = 3
        Me.cmd_pay.Text = "Pay"
        Me.cmd_pay.UseVisualStyleBackColor = False
        '
        'cmd_filter
        '
        Me.cmd_filter.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_filter.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_filter.ForeColor = System.Drawing.Color.White
        Me.cmd_filter.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_filter.Location = New System.Drawing.Point(643, 65)
        Me.cmd_filter.Name = "cmd_filter"
        Me.cmd_filter.Size = New System.Drawing.Size(67, 23)
        Me.cmd_filter.TabIndex = 2
        Me.cmd_filter.Text = "Show"
        Me.cmd_filter.UseVisualStyleBackColor = False
        '
        'lbl_pay_id
        '
        Me.lbl_pay_id.BackColor = System.Drawing.Color.White
        Me.lbl_pay_id.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_pay_id.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pay_id.Location = New System.Drawing.Point(157, 287)
        Me.lbl_pay_id.Name = "lbl_pay_id"
        Me.lbl_pay_id.Size = New System.Drawing.Size(21, 22)
        Me.lbl_pay_id.TabIndex = 68
        Me.lbl_pay_id.Visible = False
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'trans_datetime
        '
        Me.trans_datetime.HeaderText = "Date"
        Me.trans_datetime.Name = "trans_datetime"
        Me.trans_datetime.ReadOnly = True
        Me.trans_datetime.Width = 140
        '
        'cust_no
        '
        Me.cust_no.HeaderText = "Cust No."
        Me.cust_no.Name = "cust_no"
        Me.cust_no.ReadOnly = True
        Me.cust_no.Visible = False
        '
        'amt_paid
        '
        Me.amt_paid.HeaderText = "Amount Paid"
        Me.amt_paid.Name = "amt_paid"
        Me.amt_paid.ReadOnly = True
        Me.amt_paid.Width = 200
        '
        'delete
        '
        Me.delete.HeaderText = "Delete"
        Me.delete.Name = "delete"
        Me.delete.ReadOnly = True
        Me.delete.Text = "Delete"
        Me.delete.UseColumnTextForButtonValue = True
        Me.delete.Width = 90
        '
        'cmd_settings
        '
        Me.cmd_settings.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_settings.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_settings.ForeColor = System.Drawing.Color.White
        Me.cmd_settings.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_settings.Location = New System.Drawing.Point(716, 65)
        Me.cmd_settings.Name = "cmd_settings"
        Me.cmd_settings.Size = New System.Drawing.Size(58, 23)
        Me.cmd_settings.TabIndex = 69
        Me.cmd_settings.Text = "Set"
        Me.cmd_settings.UseVisualStyleBackColor = False
        '
        'frm_payment_records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 336)
        Me.Controls.Add(Me.cmd_settings)
        Me.Controls.Add(Me.lbl_pay_id)
        Me.Controls.Add(Me.cmd_pay)
        Me.Controls.Add(Me.cmd_filter)
        Me.Controls.Add(Me.dtp_to)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtp_from)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgv_payments)
        Me.Controls.Add(Me.cmd_close)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_current_bal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_lname)
        Me.Controls.Add(Me.lbl_mname)
        Me.Controls.Add(Me.lbl_fname)
        Me.Controls.Add(Me.lbl_customer_no)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_payment_records"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - Customer Payment Records"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_payments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_lname As System.Windows.Forms.Label
    Friend WithEvents lbl_mname As System.Windows.Forms.Label
    Friend WithEvents lbl_fname As System.Windows.Forms.Label
    Friend WithEvents lbl_customer_no As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_current_bal As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents cmd_close As System.Windows.Forms.Button
    Friend WithEvents dgv_payments As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_filter As System.Windows.Forms.Button
    Friend WithEvents dtp_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtp_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmd_pay As System.Windows.Forms.Button
    Friend WithEvents lbl_pay_id As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_datetime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amt_paid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents delete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cmd_settings As System.Windows.Forms.Button
End Class
