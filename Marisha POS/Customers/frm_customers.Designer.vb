<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customers
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmd_balances = New System.Windows.Forms.Button()
        Me.cmd_acct_receive = New System.Windows.Forms.Button()
        Me.cmd_bo = New System.Windows.Forms.Button()
        Me.cmd_returns = New System.Windows.Forms.Button()
        Me.cmd_cash_trans = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.st_date = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ss_time_and_date = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ss_user = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel9 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ss_position = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelManager1 = New Marisha_POS.Controls.PanelManager()
        Me.ManagedPanel1 = New Marisha_POS.Controls.ManagedPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmd_clear = New System.Windows.Forms.Button()
        Me.dgv_customers = New System.Windows.Forms.DataGridView()
        Me.customer_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.first_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.middle_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.last_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contact_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_update = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.cmd_addnew = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbo_search_by = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmd_settings = New System.Windows.Forms.Button()
        Me.lbl_trans_no = New System.Windows.Forms.Label()
        Me.lbl_total_payments = New System.Windows.Forms.Label()
        Me.lbl_current_bal = New System.Windows.Forms.Label()
        Me.dgv_sales_trans = New System.Windows.Forms.DataGridView()
        Me.trans_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_datetime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.disc_percent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grand_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cash_tendered = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Change = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.partial_pay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_show_details = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.lbl_contact_no = New System.Windows.Forms.Label()
        Me.lbl_lname = New System.Windows.Forms.Label()
        Me.lbl_mname = New System.Windows.Forms.Label()
        Me.lbl_fname = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmd_filter = New System.Windows.Forms.Button()
        Me.dtp_to = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp_from = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmd_pay = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_customer_no = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ManagedPanel2 = New Marisha_POS.Controls.ManagedPanel()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.PanelManager1.SuspendLayout()
        Me.ManagedPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgv_customers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_sales_trans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(11, 11)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(144, 42)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Customers"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmd_balances)
        Me.Panel1.Controls.Add(Me.cmd_acct_receive)
        Me.Panel1.Controls.Add(Me.cmd_bo)
        Me.Panel1.Controls.Add(Me.cmd_returns)
        Me.Panel1.Controls.Add(Me.cmd_cash_trans)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1214, 66)
        Me.Panel1.TabIndex = 0
        '
        'cmd_balances
        '
        Me.cmd_balances.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_balances.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_balances.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_balances.ForeColor = System.Drawing.Color.White
        Me.cmd_balances.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_balances.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_balances.Location = New System.Drawing.Point(477, 9)
        Me.cmd_balances.Name = "cmd_balances"
        Me.cmd_balances.Size = New System.Drawing.Size(109, 47)
        Me.cmd_balances.TabIndex = 5
        Me.cmd_balances.Text = "Customer Balance"
        Me.cmd_balances.UseVisualStyleBackColor = False
        '
        'cmd_acct_receive
        '
        Me.cmd_acct_receive.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_acct_receive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_acct_receive.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_acct_receive.ForeColor = System.Drawing.Color.White
        Me.cmd_acct_receive.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_acct_receive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_acct_receive.Location = New System.Drawing.Point(607, 9)
        Me.cmd_acct_receive.Name = "cmd_acct_receive"
        Me.cmd_acct_receive.Size = New System.Drawing.Size(109, 47)
        Me.cmd_acct_receive.TabIndex = 4
        Me.cmd_acct_receive.Text = "AR Payments"
        Me.cmd_acct_receive.UseVisualStyleBackColor = False
        '
        'cmd_bo
        '
        Me.cmd_bo.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_bo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_bo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_bo.ForeColor = System.Drawing.Color.White
        Me.cmd_bo.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_bo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_bo.Location = New System.Drawing.Point(985, 9)
        Me.cmd_bo.Name = "cmd_bo"
        Me.cmd_bo.Size = New System.Drawing.Size(101, 47)
        Me.cmd_bo.TabIndex = 2
        Me.cmd_bo.Text = "B.O."
        Me.cmd_bo.UseVisualStyleBackColor = False
        '
        'cmd_returns
        '
        Me.cmd_returns.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_returns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_returns.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_returns.ForeColor = System.Drawing.Color.White
        Me.cmd_returns.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_returns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_returns.Location = New System.Drawing.Point(864, 9)
        Me.cmd_returns.Name = "cmd_returns"
        Me.cmd_returns.Size = New System.Drawing.Size(101, 47)
        Me.cmd_returns.TabIndex = 1
        Me.cmd_returns.Text = "Returns"
        Me.cmd_returns.UseVisualStyleBackColor = False
        '
        'cmd_cash_trans
        '
        Me.cmd_cash_trans.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_cash_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_cash_trans.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_cash_trans.ForeColor = System.Drawing.Color.White
        Me.cmd_cash_trans.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_cash_trans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_cash_trans.Location = New System.Drawing.Point(736, 9)
        Me.cmd_cash_trans.Name = "cmd_cash_trans"
        Me.cmd_cash_trans.Size = New System.Drawing.Size(109, 47)
        Me.cmd_cash_trans.TabIndex = 0
        Me.cmd_cash_trans.Text = "Cash Transactions"
        Me.cmd_cash_trans.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1106, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 47)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_date, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel5, Me.ss_time_and_date, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel4, Me.ss_user, Me.ToolStripStatusLabel9, Me.ToolStripStatusLabel7, Me.ss_position})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 671)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1205, 22)
        Me.StatusStrip1.TabIndex = 40
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'st_date
        '
        Me.st_date.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.st_date.ForeColor = System.Drawing.Color.White
        Me.st_date.Name = "st_date"
        Me.st_date.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(111, 17)
        Me.ToolStripStatusLabel5.Text = "DATE AND TIME :"
        '
        'ss_time_and_date
        '
        Me.ss_time_and_date.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ss_time_and_date.ForeColor = System.Drawing.Color.White
        Me.ss_time_and_date.Name = "ss_time_and_date"
        Me.ss_time_and_date.Size = New System.Drawing.Size(219, 17)
        Me.ss_time_and_date.Text = "12:00 AM Saturday, 12 April 2016"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(19, 17)
        Me.ToolStripStatusLabel2.Text = "    "
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(101, 17)
        Me.ToolStripStatusLabel4.Text = "LOGGED IN AS :"
        '
        'ss_user
        '
        Me.ss_user.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ss_user.ForeColor = System.Drawing.Color.White
        Me.ss_user.Name = "ss_user"
        Me.ss_user.Size = New System.Drawing.Size(43, 17)
        Me.ss_user.Text = "Jepoy"
        '
        'ToolStripStatusLabel9
        '
        Me.ToolStripStatusLabel9.Name = "ToolStripStatusLabel9"
        Me.ToolStripStatusLabel9.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel9.Text = " "
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel7.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(74, 17)
        Me.ToolStripStatusLabel7.Text = "POSITION :"
        '
        'ss_position
        '
        Me.ss_position.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ss_position.ForeColor = System.Drawing.Color.White
        Me.ss_position.Name = "ss_position"
        Me.ss_position.Size = New System.Drawing.Size(46, 17)
        Me.ss_position.Text = "Admin"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PanelManager1
        '
        Me.PanelManager1.Controls.Add(Me.ManagedPanel1)
        Me.PanelManager1.Controls.Add(Me.ManagedPanel2)
        Me.PanelManager1.Location = New System.Drawing.Point(0, 68)
        Me.PanelManager1.Name = "PanelManager1"
        Me.PanelManager1.SelectedIndex = 0
        Me.PanelManager1.SelectedPanel = Me.ManagedPanel1
        Me.PanelManager1.Size = New System.Drawing.Size(1201, 600)
        Me.PanelManager1.TabIndex = 41
        '
        'ManagedPanel1
        '
        Me.ManagedPanel1.BackColor = System.Drawing.Color.Gainsboro
        Me.ManagedPanel1.Controls.Add(Me.Panel3)
        Me.ManagedPanel1.Controls.Add(Me.Panel2)
        Me.ManagedPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ManagedPanel1.Name = "ManagedPanel1"
        Me.ManagedPanel1.Size = New System.Drawing.Size(1201, 600)
        Me.ManagedPanel1.Text = "ManagedPanel1"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.cmd_clear)
        Me.Panel3.Controls.Add(Me.dgv_customers)
        Me.Panel3.Controls.Add(Me.cmd_update)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.txt_search)
        Me.Panel3.Controls.Add(Me.cmd_addnew)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.cbo_search_by)
        Me.Panel3.Location = New System.Drawing.Point(4, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(345, 595)
        Me.Panel3.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(1, 1)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(344, 27)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Customer List"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmd_clear
        '
        Me.cmd_clear.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_clear.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_clear.ForeColor = System.Drawing.Color.White
        Me.cmd_clear.Location = New System.Drawing.Point(273, 52)
        Me.cmd_clear.Name = "cmd_clear"
        Me.cmd_clear.Size = New System.Drawing.Size(69, 28)
        Me.cmd_clear.TabIndex = 1
        Me.cmd_clear.Text = "Clear"
        Me.cmd_clear.UseVisualStyleBackColor = False
        '
        'dgv_customers
        '
        Me.dgv_customers.AllowUserToAddRows = False
        Me.dgv_customers.AllowUserToDeleteRows = False
        Me.dgv_customers.AllowUserToResizeRows = False
        Me.dgv_customers.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_customers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_customers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_customers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_customers.ColumnHeadersHeight = 25
        Me.dgv_customers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.customer_no, Me.first_name, Me.middle_name, Me.last_name, Me.contact_no, Me.address})
        Me.dgv_customers.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_customers.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_customers.EnableHeadersVisualStyles = False
        Me.dgv_customers.Location = New System.Drawing.Point(4, 85)
        Me.dgv_customers.MultiSelect = False
        Me.dgv_customers.Name = "dgv_customers"
        Me.dgv_customers.ReadOnly = True
        Me.dgv_customers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_customers.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_customers.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_customers.Size = New System.Drawing.Size(337, 447)
        Me.dgv_customers.TabIndex = 32
        '
        'customer_no
        '
        Me.customer_no.HeaderText = "Cust No."
        Me.customer_no.Name = "customer_no"
        Me.customer_no.ReadOnly = True
        Me.customer_no.Width = 60
        '
        'first_name
        '
        Me.first_name.HeaderText = "First Name"
        Me.first_name.Name = "first_name"
        Me.first_name.ReadOnly = True
        Me.first_name.Width = 120
        '
        'middle_name
        '
        Me.middle_name.HeaderText = "Middle Name"
        Me.middle_name.Name = "middle_name"
        Me.middle_name.ReadOnly = True
        Me.middle_name.Visible = False
        '
        'last_name
        '
        Me.last_name.HeaderText = "Last Name"
        Me.last_name.Name = "last_name"
        Me.last_name.ReadOnly = True
        Me.last_name.Width = 120
        '
        'contact_no
        '
        Me.contact_no.HeaderText = "Contact No."
        Me.contact_no.Name = "contact_no"
        Me.contact_no.ReadOnly = True
        Me.contact_no.Visible = False
        '
        'address
        '
        Me.address.HeaderText = "Address"
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        Me.address.Visible = False
        '
        'cmd_update
        '
        Me.cmd_update.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_update.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_update.ForeColor = System.Drawing.Color.White
        Me.cmd_update.Location = New System.Drawing.Point(181, 540)
        Me.cmd_update.Name = "cmd_update"
        Me.cmd_update.Size = New System.Drawing.Size(90, 47)
        Me.cmd_update.TabIndex = 3
        Me.cmd_update.Text = "Update"
        Me.cmd_update.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(117, 34)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(112, 16)
        Me.Label24.TabIndex = 39
        Me.Label24.Text = "Enter Keyword.."
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(114, 53)
        Me.txt_search.MaxLength = 30
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(156, 26)
        Me.txt_search.TabIndex = 0
        '
        'cmd_addnew
        '
        Me.cmd_addnew.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_addnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_addnew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_addnew.ForeColor = System.Drawing.Color.White
        Me.cmd_addnew.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_addnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_addnew.Location = New System.Drawing.Point(63, 540)
        Me.cmd_addnew.Name = "cmd_addnew"
        Me.cmd_addnew.Size = New System.Drawing.Size(92, 47)
        Me.cmd_addnew.TabIndex = 2
        Me.cmd_addnew.Text = "Add New"
        Me.cmd_addnew.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(7, 36)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(82, 16)
        Me.Label23.TabIndex = 33
        Me.Label23.Text = "Search By :"
        '
        'cbo_search_by
        '
        Me.cbo_search_by.BackColor = System.Drawing.Color.Gainsboro
        Me.cbo_search_by.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_search_by.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_search_by.FormattingEnabled = True
        Me.cbo_search_by.Location = New System.Drawing.Point(5, 55)
        Me.cbo_search_by.Name = "cbo_search_by"
        Me.cbo_search_by.Size = New System.Drawing.Size(103, 24)
        Me.cbo_search_by.TabIndex = 34
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.cmd_settings)
        Me.Panel2.Controls.Add(Me.lbl_trans_no)
        Me.Panel2.Controls.Add(Me.lbl_total_payments)
        Me.Panel2.Controls.Add(Me.lbl_current_bal)
        Me.Panel2.Controls.Add(Me.dgv_sales_trans)
        Me.Panel2.Controls.Add(Me.lbl_address)
        Me.Panel2.Controls.Add(Me.lbl_contact_no)
        Me.Panel2.Controls.Add(Me.lbl_lname)
        Me.Panel2.Controls.Add(Me.lbl_mname)
        Me.Panel2.Controls.Add(Me.lbl_fname)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.cmd_filter)
        Me.Panel2.Controls.Add(Me.dtp_to)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.dtp_from)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.cmd_pay)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lbl_customer_no)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(353, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(848, 594)
        Me.Panel2.TabIndex = 1
        '
        'cmd_settings
        '
        Me.cmd_settings.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_settings.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_settings.ForeColor = System.Drawing.Color.White
        Me.cmd_settings.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_settings.Location = New System.Drawing.Point(473, 267)
        Me.cmd_settings.Name = "cmd_settings"
        Me.cmd_settings.Size = New System.Drawing.Size(65, 24)
        Me.cmd_settings.TabIndex = 55
        Me.cmd_settings.Text = "Set"
        Me.cmd_settings.UseVisualStyleBackColor = False
        '
        'lbl_trans_no
        '
        Me.lbl_trans_no.BackColor = System.Drawing.Color.White
        Me.lbl_trans_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_trans_no.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_trans_no.Location = New System.Drawing.Point(665, 269)
        Me.lbl_trans_no.Name = "lbl_trans_no"
        Me.lbl_trans_no.Size = New System.Drawing.Size(21, 22)
        Me.lbl_trans_no.TabIndex = 54
        Me.lbl_trans_no.Visible = False
        '
        'lbl_total_payments
        '
        Me.lbl_total_payments.BackColor = System.Drawing.Color.White
        Me.lbl_total_payments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_total_payments.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_payments.Location = New System.Drawing.Point(630, 193)
        Me.lbl_total_payments.Name = "lbl_total_payments"
        Me.lbl_total_payments.Size = New System.Drawing.Size(42, 27)
        Me.lbl_total_payments.TabIndex = 53
        Me.lbl_total_payments.Text = "0.00"
        Me.lbl_total_payments.Visible = False
        '
        'lbl_current_bal
        '
        Me.lbl_current_bal.BackColor = System.Drawing.Color.White
        Me.lbl_current_bal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_current_bal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_current_bal.Location = New System.Drawing.Point(330, 193)
        Me.lbl_current_bal.Name = "lbl_current_bal"
        Me.lbl_current_bal.Size = New System.Drawing.Size(157, 27)
        Me.lbl_current_bal.TabIndex = 52
        Me.lbl_current_bal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgv_sales_trans
        '
        Me.dgv_sales_trans.AllowUserToAddRows = False
        Me.dgv_sales_trans.AllowUserToDeleteRows = False
        Me.dgv_sales_trans.AllowUserToResizeRows = False
        Me.dgv_sales_trans.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_sales_trans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_sales_trans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_sales_trans.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_sales_trans.ColumnHeadersHeight = 35
        Me.dgv_sales_trans.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.trans_no, Me.trans_datetime, Me.sub_total, Me.disc_percent, Me.total_discount, Me.grand_total, Me.cash_tendered, Me.Change, Me.partial_pay, Me.btn_show_details})
        Me.dgv_sales_trans.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_sales_trans.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_sales_trans.EnableHeadersVisualStyles = False
        Me.dgv_sales_trans.Location = New System.Drawing.Point(5, 299)
        Me.dgv_sales_trans.MultiSelect = False
        Me.dgv_sales_trans.Name = "dgv_sales_trans"
        Me.dgv_sales_trans.ReadOnly = True
        Me.dgv_sales_trans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_sales_trans.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_sales_trans.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_sales_trans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_sales_trans.Size = New System.Drawing.Size(836, 292)
        Me.dgv_sales_trans.TabIndex = 51
        '
        'trans_no
        '
        Me.trans_no.HeaderText = "Trans. No."
        Me.trans_no.Name = "trans_no"
        Me.trans_no.ReadOnly = True
        Me.trans_no.Width = 90
        '
        'trans_datetime
        '
        Me.trans_datetime.HeaderText = "Date and Time"
        Me.trans_datetime.Name = "trans_datetime"
        Me.trans_datetime.ReadOnly = True
        Me.trans_datetime.Width = 160
        '
        'sub_total
        '
        Me.sub_total.HeaderText = "Sub Total"
        Me.sub_total.Name = "sub_total"
        Me.sub_total.ReadOnly = True
        Me.sub_total.Width = 120
        '
        'disc_percent
        '
        Me.disc_percent.HeaderText = "Disc. (%)"
        Me.disc_percent.Name = "disc_percent"
        Me.disc_percent.ReadOnly = True
        Me.disc_percent.Visible = False
        Me.disc_percent.Width = 70
        '
        'total_discount
        '
        Me.total_discount.HeaderText = "Total Discount"
        Me.total_discount.Name = "total_discount"
        Me.total_discount.ReadOnly = True
        '
        'grand_total
        '
        Me.grand_total.HeaderText = "Grand Total"
        Me.grand_total.Name = "grand_total"
        Me.grand_total.ReadOnly = True
        Me.grand_total.Width = 130
        '
        'cash_tendered
        '
        Me.cash_tendered.HeaderText = "Cash Tendered"
        Me.cash_tendered.Name = "cash_tendered"
        Me.cash_tendered.ReadOnly = True
        Me.cash_tendered.Visible = False
        '
        'Change
        '
        Me.Change.HeaderText = "Change"
        Me.Change.Name = "Change"
        Me.Change.ReadOnly = True
        Me.Change.Visible = False
        '
        'partial_pay
        '
        Me.partial_pay.HeaderText = "Partial Payment"
        Me.partial_pay.Name = "partial_pay"
        Me.partial_pay.ReadOnly = True
        Me.partial_pay.Width = 110
        '
        'btn_show_details
        '
        Me.btn_show_details.HeaderText = "Show Details"
        Me.btn_show_details.Name = "btn_show_details"
        Me.btn_show_details.ReadOnly = True
        Me.btn_show_details.Text = "Show Details"
        Me.btn_show_details.UseColumnTextForButtonValue = True
        '
        'lbl_address
        '
        Me.lbl_address.BackColor = System.Drawing.Color.White
        Me.lbl_address.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_address.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.Location = New System.Drawing.Point(561, 75)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(268, 87)
        Me.lbl_address.TabIndex = 50
        '
        'lbl_contact_no
        '
        Me.lbl_contact_no.BackColor = System.Drawing.Color.White
        Me.lbl_contact_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_contact_no.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contact_no.Location = New System.Drawing.Point(561, 39)
        Me.lbl_contact_no.Name = "lbl_contact_no"
        Me.lbl_contact_no.Size = New System.Drawing.Size(268, 22)
        Me.lbl_contact_no.TabIndex = 49
        Me.lbl_contact_no.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_lname
        '
        Me.lbl_lname.BackColor = System.Drawing.Color.White
        Me.lbl_lname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_lname.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lname.Location = New System.Drawing.Point(133, 139)
        Me.lbl_lname.Name = "lbl_lname"
        Me.lbl_lname.Size = New System.Drawing.Size(283, 22)
        Me.lbl_lname.TabIndex = 48
        Me.lbl_lname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_mname
        '
        Me.lbl_mname.BackColor = System.Drawing.Color.White
        Me.lbl_mname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_mname.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mname.Location = New System.Drawing.Point(133, 107)
        Me.lbl_mname.Name = "lbl_mname"
        Me.lbl_mname.Size = New System.Drawing.Size(283, 22)
        Me.lbl_mname.TabIndex = 47
        Me.lbl_mname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_fname
        '
        Me.lbl_fname.BackColor = System.Drawing.Color.White
        Me.lbl_fname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_fname.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fname.Location = New System.Drawing.Point(133, 74)
        Me.lbl_fname.Name = "lbl_fname"
        Me.lbl_fname.Size = New System.Drawing.Size(283, 22)
        Me.lbl_fname.TabIndex = 46
        Me.lbl_fname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(192, 199)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 20)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Current Balance :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmd_filter
        '
        Me.cmd_filter.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_filter.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_filter.ForeColor = System.Drawing.Color.White
        Me.cmd_filter.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_filter.Location = New System.Drawing.Point(400, 267)
        Me.cmd_filter.Name = "cmd_filter"
        Me.cmd_filter.Size = New System.Drawing.Size(67, 24)
        Me.cmd_filter.TabIndex = 2
        Me.cmd_filter.Text = "Filter"
        Me.cmd_filter.UseVisualStyleBackColor = False
        '
        'dtp_to
        '
        Me.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_to.Location = New System.Drawing.Point(291, 271)
        Me.dtp_to.Name = "dtp_to"
        Me.dtp_to.Size = New System.Drawing.Size(98, 20)
        Me.dtp_to.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(260, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "To :"
        '
        'dtp_from
        '
        Me.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_from.Location = New System.Drawing.Point(156, 271)
        Me.dtp_from.Name = "dtp_from"
        Me.dtp_from.Size = New System.Drawing.Size(98, 20)
        Me.dtp_from.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Show Transactions From :"
        '
        'cmd_pay
        '
        Me.cmd_pay.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_pay.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_pay.ForeColor = System.Drawing.Color.White
        Me.cmd_pay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_pay.Location = New System.Drawing.Point(493, 192)
        Me.cmd_pay.Name = "cmd_pay"
        Me.cmd_pay.Size = New System.Drawing.Size(131, 31)
        Me.cmd_pay.TabIndex = 0
        Me.cmd_pay.Text = "Balance Payment"
        Me.cmd_pay.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(467, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Address :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(449, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Contact No. :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(852, 27)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Customer On - Account Transactions"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_customer_no
        '
        Me.lbl_customer_no.BackColor = System.Drawing.Color.White
        Me.lbl_customer_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_customer_no.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_no.Location = New System.Drawing.Point(133, 39)
        Me.lbl_customer_no.Name = "lbl_customer_no"
        Me.lbl_customer_no.Size = New System.Drawing.Size(283, 22)
        Me.lbl_customer_no.TabIndex = 30
        Me.lbl_customer_no.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(848, 27)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Customer Information"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Middle Name :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Last Name :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "First name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Customer No. :"
        '
        'ManagedPanel2
        '
        Me.ManagedPanel2.Location = New System.Drawing.Point(0, 0)
        Me.ManagedPanel2.Name = "ManagedPanel2"
        Me.ManagedPanel2.Size = New System.Drawing.Size(0, 0)
        Me.ManagedPanel2.Text = "ManagedPanel2"
        '
        'frm_customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1205, 693)
        Me.Controls.Add(Me.PanelManager1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_customers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - Customers"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.PanelManager1.ResumeLayout(False)
        Me.ManagedPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgv_customers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgv_sales_trans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_customer_no As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmd_update As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmd_addnew As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_pay As System.Windows.Forms.Button
    Friend WithEvents cmd_filter As System.Windows.Forms.Button
    Friend WithEvents dtp_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtp_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgv_customers As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_address As System.Windows.Forms.Label
    Friend WithEvents lbl_contact_no As System.Windows.Forms.Label
    Friend WithEvents lbl_lname As System.Windows.Forms.Label
    Friend WithEvents lbl_mname As System.Windows.Forms.Label
    Friend WithEvents lbl_fname As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents st_date As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ss_time_and_date As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ss_user As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel9 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ss_position As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmd_returns As System.Windows.Forms.Button
    Friend WithEvents cmd_cash_trans As System.Windows.Forms.Button
    Friend WithEvents PanelManager1 As Marisha_POS.Controls.PanelManager
    Friend WithEvents ManagedPanel1 As Marisha_POS.Controls.ManagedPanel
    Friend WithEvents ManagedPanel2 As Marisha_POS.Controls.ManagedPanel
    Friend WithEvents cbo_search_by As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmd_clear As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dgv_sales_trans As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_current_bal As System.Windows.Forms.Label
    Friend WithEvents lbl_total_payments As System.Windows.Forms.Label
    Friend WithEvents cmd_bo As System.Windows.Forms.Button
    Friend WithEvents lbl_trans_no As System.Windows.Forms.Label
    Friend WithEvents cmd_acct_receive As System.Windows.Forms.Button
    Friend WithEvents trans_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_datetime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sub_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents disc_percent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_discount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grand_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cash_tendered As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Change As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents partial_pay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_show_details As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cmd_settings As System.Windows.Forms.Button
    Friend WithEvents cmd_balances As System.Windows.Forms.Button
    Friend WithEvents customer_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents first_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents middle_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents last_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contact_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents address As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
