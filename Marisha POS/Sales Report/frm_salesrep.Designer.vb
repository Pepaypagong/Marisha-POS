<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_salesrep
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncomeStatementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmd_close = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.cmd_gross_profict = New System.Windows.Forms.Button()
        Me.cmd_sales_trans = New System.Windows.Forms.Button()
        Me.cmd_dashboard = New System.Windows.Forms.Button()
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
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panelmanager = New Marisha_POS.Controls.PanelManager()
        Me.pnl_dashboard = New Marisha_POS.Controls.ManagedPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtp_to = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtp_from = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbo_category = New System.Windows.Forms.ComboBox()
        Me.cmd_showgraph = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl_sales_trans = New Marisha_POS.Controls.ManagedPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.crv_remit = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.cmd_export_remit = New System.Windows.Forms.Button()
        Me.cmd_print_remit = New System.Windows.Forms.Button()
        Me.dtp_remit = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.pnl_gross_profit = New Marisha_POS.Controls.ManagedPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.crv_inc_statement = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmd_show = New System.Windows.Forms.Button()
        Me.cmd_income_export = New System.Windows.Forms.Button()
        Me.cmd_income_print = New System.Windows.Forms.Button()
        Me.dtp_to_income = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_from_income = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.IncomeStatementToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Panelmanager.SuspendLayout()
        Me.pnl_dashboard.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnl_sales_trans.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.pnl_gross_profit.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.IncomeStatementToolStripMenuItem, Me.IncomeStatementToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1294, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'IncomeStatementToolStripMenuItem
        '
        Me.IncomeStatementToolStripMenuItem.Name = "IncomeStatementToolStripMenuItem"
        Me.IncomeStatementToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.IncomeStatementToolStripMenuItem.Text = "Remittances"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.Untitled_1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'cmd_close
        '
        Me.cmd_close.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_close.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.login
        Me.cmd_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_close.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_close.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_close.Location = New System.Drawing.Point(1188, 31)
        Me.cmd_close.Name = "cmd_close"
        Me.cmd_close.Size = New System.Drawing.Size(94, 79)
        Me.cmd_close.TabIndex = 2
        Me.cmd_close.UseVisualStyleBackColor = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Tahoma", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(132, 45)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(470, 72)
        Me.lbl_title.TabIndex = 17
        Me.lbl_title.Text = "Sales Dashboard"
        '
        'cmd_gross_profict
        '
        Me.cmd_gross_profict.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_gross_profict.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.checque
        Me.cmd_gross_profict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_gross_profict.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_gross_profict.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_gross_profict.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_gross_profict.Location = New System.Drawing.Point(1056, 31)
        Me.cmd_gross_profict.Name = "cmd_gross_profict"
        Me.cmd_gross_profict.Size = New System.Drawing.Size(94, 79)
        Me.cmd_gross_profict.TabIndex = 1
        Me.cmd_gross_profict.UseVisualStyleBackColor = False
        '
        'cmd_sales_trans
        '
        Me.cmd_sales_trans.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_sales_trans.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.cashadvance
        Me.cmd_sales_trans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_sales_trans.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_sales_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_sales_trans.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_sales_trans.Location = New System.Drawing.Point(921, 31)
        Me.cmd_sales_trans.Name = "cmd_sales_trans"
        Me.cmd_sales_trans.Size = New System.Drawing.Size(94, 79)
        Me.cmd_sales_trans.TabIndex = 15
        Me.cmd_sales_trans.UseVisualStyleBackColor = False
        '
        'cmd_dashboard
        '
        Me.cmd_dashboard.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_dashboard.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.book
        Me.cmd_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_dashboard.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_dashboard.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_dashboard.Location = New System.Drawing.Point(786, 31)
        Me.cmd_dashboard.Name = "cmd_dashboard"
        Me.cmd_dashboard.Size = New System.Drawing.Size(94, 79)
        Me.cmd_dashboard.TabIndex = 0
        Me.cmd_dashboard.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_date, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel5, Me.ss_time_and_date, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel4, Me.ss_user, Me.ToolStripStatusLabel9, Me.ToolStripStatusLabel7, Me.ss_position})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 669)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1294, 22)
        Me.StatusStrip1.TabIndex = 39
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
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(795, 111)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(78, 16)
        Me.Label25.TabIndex = 42
        Me.Label25.Text = "Dashboard"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(923, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 16)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Remittances"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1040, 111)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 16)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Income Statement"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1217, 111)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 16)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Close"
        '
        'Panelmanager
        '
        Me.Panelmanager.Controls.Add(Me.pnl_dashboard)
        Me.Panelmanager.Controls.Add(Me.pnl_sales_trans)
        Me.Panelmanager.Controls.Add(Me.pnl_gross_profit)
        Me.Panelmanager.Location = New System.Drawing.Point(0, 133)
        Me.Panelmanager.Name = "Panelmanager"
        Me.Panelmanager.SelectedIndex = 0
        Me.Panelmanager.SelectedPanel = Me.pnl_dashboard
        Me.Panelmanager.Size = New System.Drawing.Size(1294, 533)
        Me.Panelmanager.TabIndex = 21
        '
        'pnl_dashboard
        '
        Me.pnl_dashboard.Controls.Add(Me.Panel1)
        Me.pnl_dashboard.Location = New System.Drawing.Point(0, 0)
        Me.pnl_dashboard.Name = "pnl_dashboard"
        Me.pnl_dashboard.Size = New System.Drawing.Size(1294, 533)
        Me.pnl_dashboard.Text = "ManagedPanel1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.dtp_to)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.dtp_from)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.cbo_category)
        Me.Panel1.Controls.Add(Me.cmd_showgraph)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1294, 46)
        Me.Panel1.TabIndex = 13
        '
        'dtp_to
        '
        Me.dtp_to.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_to.Location = New System.Drawing.Point(898, 9)
        Me.dtp_to.Name = "dtp_to"
        Me.dtp_to.Size = New System.Drawing.Size(264, 26)
        Me.dtp_to.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(851, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 19)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "To :"
        '
        'dtp_from
        '
        Me.dtp_from.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_from.Location = New System.Drawing.Point(579, 9)
        Me.dtp_from.Name = "dtp_from"
        Me.dtp_from.Size = New System.Drawing.Size(266, 26)
        Me.dtp_from.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(463, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 19)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Show From :"
        '
        'cbo_category
        '
        Me.cbo_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_category.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_category.FormattingEnabled = True
        Me.cbo_category.Location = New System.Drawing.Point(223, 6)
        Me.cbo_category.Name = "cbo_category"
        Me.cbo_category.Size = New System.Drawing.Size(60, 33)
        Me.cbo_category.TabIndex = 6
        Me.cbo_category.Visible = False
        '
        'cmd_showgraph
        '
        Me.cmd_showgraph.BackColor = System.Drawing.Color.White
        Me.cmd_showgraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_showgraph.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_showgraph.ForeColor = System.Drawing.Color.Black
        Me.cmd_showgraph.Location = New System.Drawing.Point(1174, 5)
        Me.cmd_showgraph.Name = "cmd_showgraph"
        Me.cmd_showgraph.Size = New System.Drawing.Size(108, 33)
        Me.cmd_showgraph.TabIndex = 7
        Me.cmd_showgraph.Text = "Show Graph"
        Me.cmd_showgraph.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Top Selling Items"
        '
        'pnl_sales_trans
        '
        Me.pnl_sales_trans.Controls.Add(Me.Panel5)
        Me.pnl_sales_trans.Controls.Add(Me.Panel7)
        Me.pnl_sales_trans.Location = New System.Drawing.Point(0, 0)
        Me.pnl_sales_trans.Name = "pnl_sales_trans"
        Me.pnl_sales_trans.Size = New System.Drawing.Size(0, 0)
        Me.pnl_sales_trans.Text = "ManagedPanel2"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel5.Controls.Add(Me.crv_remit)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Location = New System.Drawing.Point(3, 52)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1287, 478)
        Me.Panel5.TabIndex = 18
        '
        'crv_remit
        '
        Me.crv_remit.ActiveViewIndex = -1
        Me.crv_remit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_remit.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_remit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv_remit.Location = New System.Drawing.Point(0, 0)
        Me.crv_remit.Name = "crv_remit"
        Me.crv_remit.ShowGroupTreeButton = False
        Me.crv_remit.ShowParameterPanelButton = False
        Me.crv_remit.ShowRefreshButton = False
        Me.crv_remit.Size = New System.Drawing.Size(1287, 478)
        Me.crv_remit.TabIndex = 54
        Me.crv_remit.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(512, 465)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 16)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "C0001"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(306, 465)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(203, 16)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "Total Number of Stocks Out :"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel7.Controls.Add(Me.cmd_export_remit)
        Me.Panel7.Controls.Add(Me.cmd_print_remit)
        Me.Panel7.Controls.Add(Me.dtp_remit)
        Me.Panel7.Controls.Add(Me.Button2)
        Me.Panel7.Controls.Add(Me.Label18)
        Me.Panel7.Location = New System.Drawing.Point(1, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1294, 46)
        Me.Panel7.TabIndex = 17
        '
        'cmd_export_remit
        '
        Me.cmd_export_remit.BackColor = System.Drawing.Color.White
        Me.cmd_export_remit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_export_remit.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_export_remit.ForeColor = System.Drawing.Color.Black
        Me.cmd_export_remit.Location = New System.Drawing.Point(104, 7)
        Me.cmd_export_remit.Name = "cmd_export_remit"
        Me.cmd_export_remit.Size = New System.Drawing.Size(80, 33)
        Me.cmd_export_remit.TabIndex = 28
        Me.cmd_export_remit.Text = "Export"
        Me.cmd_export_remit.UseVisualStyleBackColor = False
        '
        'cmd_print_remit
        '
        Me.cmd_print_remit.BackColor = System.Drawing.Color.White
        Me.cmd_print_remit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_print_remit.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_print_remit.ForeColor = System.Drawing.Color.Black
        Me.cmd_print_remit.Location = New System.Drawing.Point(11, 7)
        Me.cmd_print_remit.Name = "cmd_print_remit"
        Me.cmd_print_remit.Size = New System.Drawing.Size(80, 33)
        Me.cmd_print_remit.TabIndex = 27
        Me.cmd_print_remit.Text = "Print"
        Me.cmd_print_remit.UseVisualStyleBackColor = False
        '
        'dtp_remit
        '
        Me.dtp_remit.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_remit.Location = New System.Drawing.Point(906, 10)
        Me.dtp_remit.Name = "dtp_remit"
        Me.dtp_remit.Size = New System.Drawing.Size(264, 26)
        Me.dtp_remit.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(1184, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 33)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Show Data"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(841, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 19)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Date :"
        '
        'pnl_gross_profit
        '
        Me.pnl_gross_profit.Controls.Add(Me.Panel4)
        Me.pnl_gross_profit.Controls.Add(Me.Panel3)
        Me.pnl_gross_profit.Location = New System.Drawing.Point(0, 0)
        Me.pnl_gross_profit.Name = "pnl_gross_profit"
        Me.pnl_gross_profit.Size = New System.Drawing.Size(0, 0)
        Me.pnl_gross_profit.Text = "ManagedPanel1"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel4.Controls.Add(Me.crv_inc_statement)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Location = New System.Drawing.Point(3, 52)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1287, 478)
        Me.Panel4.TabIndex = 18
        '
        'crv_inc_statement
        '
        Me.crv_inc_statement.ActiveViewIndex = -1
        Me.crv_inc_statement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_inc_statement.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_inc_statement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv_inc_statement.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crv_inc_statement.Location = New System.Drawing.Point(0, 0)
        Me.crv_inc_statement.Name = "crv_inc_statement"
        Me.crv_inc_statement.ShowGroupTreeButton = False
        Me.crv_inc_statement.ShowParameterPanelButton = False
        Me.crv_inc_statement.ShowRefreshButton = False
        Me.crv_inc_statement.Size = New System.Drawing.Size(1287, 478)
        Me.crv_inc_statement.TabIndex = 54
        Me.crv_inc_statement.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(512, 465)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "C0001"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(306, 465)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(203, 16)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Total Number of Stocks Out :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel3.Controls.Add(Me.cmd_show)
        Me.Panel3.Controls.Add(Me.cmd_income_export)
        Me.Panel3.Controls.Add(Me.cmd_income_print)
        Me.Panel3.Controls.Add(Me.dtp_to_income)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.dtp_from_income)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(1, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1294, 46)
        Me.Panel3.TabIndex = 17
        '
        'cmd_show
        '
        Me.cmd_show.BackColor = System.Drawing.Color.White
        Me.cmd_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_show.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_show.ForeColor = System.Drawing.Color.Black
        Me.cmd_show.Location = New System.Drawing.Point(1165, 8)
        Me.cmd_show.Name = "cmd_show"
        Me.cmd_show.Size = New System.Drawing.Size(116, 30)
        Me.cmd_show.TabIndex = 34
        Me.cmd_show.Text = "Show Report"
        Me.cmd_show.UseVisualStyleBackColor = False
        '
        'cmd_income_export
        '
        Me.cmd_income_export.BackColor = System.Drawing.Color.White
        Me.cmd_income_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_income_export.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_income_export.ForeColor = System.Drawing.Color.Black
        Me.cmd_income_export.Location = New System.Drawing.Point(104, 7)
        Me.cmd_income_export.Name = "cmd_income_export"
        Me.cmd_income_export.Size = New System.Drawing.Size(80, 33)
        Me.cmd_income_export.TabIndex = 26
        Me.cmd_income_export.Text = "Export"
        Me.cmd_income_export.UseVisualStyleBackColor = False
        '
        'cmd_income_print
        '
        Me.cmd_income_print.BackColor = System.Drawing.Color.White
        Me.cmd_income_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_income_print.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_income_print.ForeColor = System.Drawing.Color.Black
        Me.cmd_income_print.Location = New System.Drawing.Point(11, 7)
        Me.cmd_income_print.Name = "cmd_income_print"
        Me.cmd_income_print.Size = New System.Drawing.Size(80, 33)
        Me.cmd_income_print.TabIndex = 25
        Me.cmd_income_print.Text = "Print"
        Me.cmd_income_print.UseVisualStyleBackColor = False
        '
        'dtp_to_income
        '
        Me.dtp_to_income.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_to_income.Location = New System.Drawing.Point(894, 10)
        Me.dtp_to_income.Name = "dtp_to_income"
        Me.dtp_to_income.Size = New System.Drawing.Size(264, 26)
        Me.dtp_to_income.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(854, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 19)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "to :"
        '
        'dtp_from_income
        '
        Me.dtp_from_income.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_from_income.Location = New System.Drawing.Point(584, 10)
        Me.dtp_from_income.Name = "dtp_from_income"
        Me.dtp_from_income.Size = New System.Drawing.Size(264, 26)
        Me.dtp_from_income.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(471, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Show from :"
        '
        'IncomeStatementToolStripMenuItem1
        '
        Me.IncomeStatementToolStripMenuItem1.Name = "IncomeStatementToolStripMenuItem1"
        Me.IncomeStatementToolStripMenuItem1.Size = New System.Drawing.Size(116, 20)
        Me.IncomeStatementToolStripMenuItem1.Text = "Income Statement"
        '
        'frm_salesrep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1294, 691)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panelmanager)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmd_close)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.cmd_gross_profict)
        Me.Controls.Add(Me.cmd_sales_trans)
        Me.Controls.Add(Me.cmd_dashboard)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_salesrep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - Sales"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panelmanager.ResumeLayout(False)
        Me.pnl_dashboard.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnl_sales_trans.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.pnl_gross_profit.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmd_close As System.Windows.Forms.Button
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents cmd_gross_profict As System.Windows.Forms.Button
    Friend WithEvents cmd_sales_trans As System.Windows.Forms.Button
    Friend WithEvents cmd_dashboard As System.Windows.Forms.Button
    Friend WithEvents Panelmanager As Marisha_POS.Controls.PanelManager
    Friend WithEvents pnl_dashboard As Marisha_POS.Controls.ManagedPanel
    Friend WithEvents pnl_sales_trans As Marisha_POS.Controls.ManagedPanel
    Friend WithEvents pnl_gross_profit As Marisha_POS.Controls.ManagedPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmd_showgraph As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents dtp_remit As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents crv_remit As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dtp_to_income As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtp_from_income As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
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
    Friend WithEvents crv_inc_statement As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents dtp_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtp_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbo_category As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DashboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncomeStatementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmd_income_export As System.Windows.Forms.Button
    Friend WithEvents cmd_income_print As System.Windows.Forms.Button
    Friend WithEvents cmd_export_remit As System.Windows.Forms.Button
    Friend WithEvents cmd_print_remit As System.Windows.Forms.Button
    Friend WithEvents cmd_show As System.Windows.Forms.Button
    Friend WithEvents IncomeStatementToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
