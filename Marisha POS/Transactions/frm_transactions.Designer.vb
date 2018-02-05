<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_transactions
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.dgv_transactions = New System.Windows.Forms.DataGridView()
        Me.cbo_sales_type = New System.Windows.Forms.ComboBox()
        Me.lbl_sales_type = New System.Windows.Forms.Label()
        Me.cbo_id = New System.Windows.Forms.ComboBox()
        Me.lbl_customer = New System.Windows.Forms.Label()
        Me.lbl_date_from = New System.Windows.Forms.Label()
        Me.dtp_purchases_to = New System.Windows.Forms.DateTimePicker()
        Me.dtp_purchases_from = New System.Windows.Forms.DateTimePicker()
        Me.lbl_date_to = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_rejects = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmd_purchases = New System.Windows.Forms.Button()
        Me.cmd_close = New System.Windows.Forms.Button()
        Me.cmd_purchase_returns = New System.Windows.Forms.Button()
        Me.cmd_sales_return = New System.Windows.Forms.Button()
        Me.cmd_sales = New System.Windows.Forms.Button()
        Me.cmd_view = New System.Windows.Forms.Button()
        Me.cmd_delete = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmd_new = New System.Windows.Forms.Button()
        CType(Me.dgv_transactions,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1294, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = true
        Me.lbl_title.BackColor = System.Drawing.Color.White
        Me.lbl_title.Font = New System.Drawing.Font("Tahoma", 40!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_title.Location = New System.Drawing.Point(11, 20)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(466, 65)
        Me.lbl_title.TabIndex = 51
        Me.lbl_title.Text = "Sales Transactions"
        '
        'dgv_transactions
        '
        Me.dgv_transactions.AllowUserToAddRows = false
        Me.dgv_transactions.AllowUserToDeleteRows = false
        Me.dgv_transactions.AllowUserToResizeRows = false
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_transactions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_transactions.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_transactions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_transactions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_transactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_transactions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_transactions.ColumnHeadersHeight = 25
        Me.dgv_transactions.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_transactions.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_transactions.EnableHeadersVisualStyles = false
        Me.dgv_transactions.GridColor = System.Drawing.Color.White
        Me.dgv_transactions.Location = New System.Drawing.Point(12, 209)
        Me.dgv_transactions.MultiSelect = false
        Me.dgv_transactions.Name = "dgv_transactions"
        Me.dgv_transactions.ReadOnly = true
        Me.dgv_transactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_transactions.RowHeadersVisible = false
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dgv_transactions.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_transactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_transactions.Size = New System.Drawing.Size(1270, 473)
        Me.dgv_transactions.TabIndex = 60
        '
        'cbo_sales_type
        '
        Me.cbo_sales_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_sales_type.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbo_sales_type.FormattingEnabled = true
        Me.cbo_sales_type.Location = New System.Drawing.Point(109, 146)
        Me.cbo_sales_type.Name = "cbo_sales_type"
        Me.cbo_sales_type.Size = New System.Drawing.Size(268, 24)
        Me.cbo_sales_type.TabIndex = 62
        '
        'lbl_sales_type
        '
        Me.lbl_sales_type.AutoSize = true
        Me.lbl_sales_type.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_sales_type.ForeColor = System.Drawing.Color.Black
        Me.lbl_sales_type.Location = New System.Drawing.Point(17, 149)
        Me.lbl_sales_type.Name = "lbl_sales_type"
        Me.lbl_sales_type.Size = New System.Drawing.Size(86, 16)
        Me.lbl_sales_type.TabIndex = 61
        Me.lbl_sales_type.Text = "Sales Type :"
        '
        'cbo_id
        '
        Me.cbo_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_id.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbo_id.FormattingEnabled = true
        Me.cbo_id.Location = New System.Drawing.Point(109, 176)
        Me.cbo_id.Name = "cbo_id"
        Me.cbo_id.Size = New System.Drawing.Size(268, 24)
        Me.cbo_id.TabIndex = 64
        '
        'lbl_customer
        '
        Me.lbl_customer.AutoSize = true
        Me.lbl_customer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_customer.ForeColor = System.Drawing.Color.Black
        Me.lbl_customer.Location = New System.Drawing.Point(24, 179)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(79, 16)
        Me.lbl_customer.TabIndex = 63
        Me.lbl_customer.Text = "Customer :"
        Me.lbl_customer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_date_from
        '
        Me.lbl_date_from.AutoSize = true
        Me.lbl_date_from.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_date_from.ForeColor = System.Drawing.Color.Black
        Me.lbl_date_from.Location = New System.Drawing.Point(420, 149)
        Me.lbl_date_from.Name = "lbl_date_from"
        Me.lbl_date_from.Size = New System.Drawing.Size(144, 16)
        Me.lbl_date_from.TabIndex = 65
        Me.lbl_date_from.Text = "Show Records From :"
        '
        'dtp_purchases_to
        '
        Me.dtp_purchases_to.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dtp_purchases_to.Location = New System.Drawing.Point(571, 174)
        Me.dtp_purchases_to.Name = "dtp_purchases_to"
        Me.dtp_purchases_to.Size = New System.Drawing.Size(198, 23)
        Me.dtp_purchases_to.TabIndex = 67
        '
        'dtp_purchases_from
        '
        Me.dtp_purchases_from.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dtp_purchases_from.Location = New System.Drawing.Point(570, 146)
        Me.dtp_purchases_from.Name = "dtp_purchases_from"
        Me.dtp_purchases_from.Size = New System.Drawing.Size(199, 23)
        Me.dtp_purchases_from.TabIndex = 66
        '
        'lbl_date_to
        '
        Me.lbl_date_to.AutoSize = true
        Me.lbl_date_to.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_date_to.ForeColor = System.Drawing.Color.Black
        Me.lbl_date_to.Location = New System.Drawing.Point(532, 179)
        Me.lbl_date_to.Name = "lbl_date_to"
        Me.lbl_date_to.Size = New System.Drawing.Size(32, 16)
        Me.lbl_date_to.TabIndex = 68
        Me.lbl_date_to.Text = "To :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmd_rejects)
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Controls.Add(Me.lbl_title)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.cmd_purchases)
        Me.Panel1.Controls.Add(Me.cmd_close)
        Me.Panel1.Controls.Add(Me.cmd_purchase_returns)
        Me.Panel1.Controls.Add(Me.cmd_sales_return)
        Me.Panel1.Controls.Add(Me.cmd_sales)
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1294, 109)
        Me.Panel1.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(1095, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Rejects"
        '
        'cmd_rejects
        '
        Me.cmd_rejects.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_rejects.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.cancel
        Me.cmd_rejects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_rejects.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_rejects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_rejects.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_rejects.ForeColor = System.Drawing.Color.White
        Me.cmd_rejects.Location = New System.Drawing.Point(1080, 13)
        Me.cmd_rejects.Name = "cmd_rejects"
        Me.cmd_rejects.Size = New System.Drawing.Size(87, 68)
        Me.cmd_rejects.TabIndex = 70
        Me.cmd_rejects.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_rejects.UseVisualStyleBackColor = false
        '
        'Label29
        '
        Me.Label29.AutoSize = true
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label29.Location = New System.Drawing.Point(1219, 81)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(42, 16)
        Me.Label29.TabIndex = 69
        Me.Label29.Text = "Close"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.AutoSize = true
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label28.Location = New System.Drawing.Point(948, 81)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(124, 16)
        Me.Label28.TabIndex = 68
        Me.Label28.Text = "Purchase Returns"
        '
        'Label27
        '
        Me.Label27.AutoSize = true
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label27.Location = New System.Drawing.Point(852, 81)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(75, 16)
        Me.Label27.TabIndex = 67
        Me.Label27.Text = "Purchases"
        '
        'Label26
        '
        Me.Label26.AutoSize = true
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label26.Location = New System.Drawing.Point(724, 81)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(98, 16)
        Me.Label26.TabIndex = 66
        Me.Label26.Text = "Sales Returns"
        '
        'Label25
        '
        Me.Label25.AutoSize = true
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label25.Location = New System.Drawing.Point(636, 81)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(42, 16)
        Me.Label25.TabIndex = 65
        Me.Label25.Text = "Sales"
        '
        'cmd_purchases
        '
        Me.cmd_purchases.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_purchases.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.checque
        Me.cmd_purchases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_purchases.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_purchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_purchases.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_purchases.ForeColor = System.Drawing.Color.White
        Me.cmd_purchases.Location = New System.Drawing.Point(846, 13)
        Me.cmd_purchases.Name = "cmd_purchases"
        Me.cmd_purchases.Size = New System.Drawing.Size(87, 68)
        Me.cmd_purchases.TabIndex = 62
        Me.cmd_purchases.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_purchases.UseVisualStyleBackColor = false
        '
        'cmd_close
        '
        Me.cmd_close.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_close.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.login
        Me.cmd_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_close.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_close.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_close.ForeColor = System.Drawing.Color.White
        Me.cmd_close.Location = New System.Drawing.Point(1195, 13)
        Me.cmd_close.Name = "cmd_close"
        Me.cmd_close.Size = New System.Drawing.Size(87, 68)
        Me.cmd_close.TabIndex = 64
        Me.cmd_close.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_close.UseVisualStyleBackColor = false
        '
        'cmd_purchase_returns
        '
        Me.cmd_purchase_returns.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_purchase_returns.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.refresh
        Me.cmd_purchase_returns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_purchase_returns.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_purchase_returns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_purchase_returns.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_purchase_returns.ForeColor = System.Drawing.Color.White
        Me.cmd_purchase_returns.Location = New System.Drawing.Point(964, 13)
        Me.cmd_purchase_returns.Name = "cmd_purchase_returns"
        Me.cmd_purchase_returns.Size = New System.Drawing.Size(87, 68)
        Me.cmd_purchase_returns.TabIndex = 63
        Me.cmd_purchase_returns.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_purchase_returns.UseVisualStyleBackColor = false
        '
        'cmd_sales_return
        '
        Me.cmd_sales_return.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_sales_return.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.refresh
        Me.cmd_sales_return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_sales_return.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_sales_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_sales_return.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_sales_return.ForeColor = System.Drawing.Color.White
        Me.cmd_sales_return.Location = New System.Drawing.Point(730, 13)
        Me.cmd_sales_return.Name = "cmd_sales_return"
        Me.cmd_sales_return.Size = New System.Drawing.Size(87, 68)
        Me.cmd_sales_return.TabIndex = 61
        Me.cmd_sales_return.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_sales_return.UseVisualStyleBackColor = false
        '
        'cmd_sales
        '
        Me.cmd_sales.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_sales.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.cashadvance
        Me.cmd_sales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_sales.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_sales.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_sales.ForeColor = System.Drawing.Color.White
        Me.cmd_sales.Location = New System.Drawing.Point(613, 13)
        Me.cmd_sales.Name = "cmd_sales"
        Me.cmd_sales.Size = New System.Drawing.Size(87, 68)
        Me.cmd_sales.TabIndex = 60
        Me.cmd_sales.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_sales.UseVisualStyleBackColor = false
        '
        'cmd_view
        '
        Me.cmd_view.BackColor = System.Drawing.Color.White
        Me.cmd_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_view.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_view.ForeColor = System.Drawing.Color.Black
        Me.cmd_view.Location = New System.Drawing.Point(1041, 170)
        Me.cmd_view.Name = "cmd_view"
        Me.cmd_view.Size = New System.Drawing.Size(114, 27)
        Me.cmd_view.TabIndex = 70
        Me.cmd_view.Text = "VIEW"
        Me.cmd_view.UseVisualStyleBackColor = false
        '
        'cmd_delete
        '
        Me.cmd_delete.BackColor = System.Drawing.Color.White
        Me.cmd_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_delete.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_delete.ForeColor = System.Drawing.Color.Black
        Me.cmd_delete.Location = New System.Drawing.Point(1166, 170)
        Me.cmd_delete.Name = "cmd_delete"
        Me.cmd_delete.Size = New System.Drawing.Size(114, 27)
        Me.cmd_delete.TabIndex = 71
        Me.cmd_delete.Text = "DELETE"
        Me.cmd_delete.UseVisualStyleBackColor = false
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(0, 127)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(1294, 12)
        Me.Label22.TabIndex = 72
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmd_new
        '
        Me.cmd_new.BackColor = System.Drawing.Color.White
        Me.cmd_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_new.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_new.ForeColor = System.Drawing.Color.Black
        Me.cmd_new.Location = New System.Drawing.Point(916, 170)
        Me.cmd_new.Name = "cmd_new"
        Me.cmd_new.Size = New System.Drawing.Size(114, 27)
        Me.cmd_new.TabIndex = 73
        Me.cmd_new.Text = "NEW"
        Me.cmd_new.UseVisualStyleBackColor = false
        '
        'frm_transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1294, 694)
        Me.Controls.Add(Me.cmd_new)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cmd_delete)
        Me.Controls.Add(Me.cmd_view)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_date_to)
        Me.Controls.Add(Me.dtp_purchases_to)
        Me.Controls.Add(Me.dtp_purchases_from)
        Me.Controls.Add(Me.lbl_date_from)
        Me.Controls.Add(Me.cbo_id)
        Me.Controls.Add(Me.lbl_customer)
        Me.Controls.Add(Me.cbo_sales_type)
        Me.Controls.Add(Me.lbl_sales_type)
        Me.Controls.Add(Me.dgv_transactions)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frm_transactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - Transactions"
        CType(Me.dgv_transactions,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents lbl_title As Label
    Friend WithEvents dgv_transactions As DataGridView
    Friend WithEvents cbo_sales_type As ComboBox
    Friend WithEvents lbl_sales_type As Label
    Friend WithEvents cbo_id As ComboBox
    Friend WithEvents lbl_customer As Label
    Friend WithEvents lbl_date_from As Label
    Friend WithEvents dtp_purchases_to As DateTimePicker
    Friend WithEvents dtp_purchases_from As DateTimePicker
    Friend WithEvents lbl_date_to As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cmd_rejects As Button
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents cmd_purchases As Button
    Friend WithEvents cmd_close As Button
    Friend WithEvents cmd_purchase_returns As Button
    Friend WithEvents cmd_sales_return As Button
    Friend WithEvents cmd_sales As Button
    Friend WithEvents cmd_view As Button
    Friend WithEvents cmd_delete As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents cmd_new As Button
End Class
