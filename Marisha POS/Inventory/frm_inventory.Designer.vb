<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_inventory
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrandsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_title = New System.Windows.Forms.Label()
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
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cmd_stock_in = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmd_close = New System.Windows.Forms.Button()
        Me.cmd_stock_out = New System.Windows.Forms.Button()
        Me.cmd_itemlist = New System.Windows.Forms.Button()
        Me.cmd_dashboard = New System.Windows.Forms.Button()
        Me.PanelManager1 = New Marisha_POS.Controls.PanelManager()
        Me.pnl_dashboard = New Marisha_POS.Controls.ManagedPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbo_category = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl_items = New Marisha_POS.Controls.ManagedPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmd_adjust_item_qty = New System.Windows.Forms.Button()
        Me.cmd_clear = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmd_purchase_return = New System.Windows.Forms.Button()
        Me.dgv_items = New System.Windows.Forms.DataGridView()
        Me.item_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selling_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buying_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.avail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.beg_inv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.cbo_search_by = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmd_stock_report = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmd_additem = New System.Windows.Forms.Button()
        Me.cmd_update = New System.Windows.Forms.Button()
        Me.cmd_addstocks = New System.Windows.Forms.Button()
        Me.pnl_stock_out = New Marisha_POS.Controls.ManagedPanel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.crv_item_sales = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmd_show_sales = New System.Windows.Forms.Button()
        Me.cmd_sales_export = New System.Windows.Forms.Button()
        Me.cmd_sales_print = New System.Windows.Forms.Button()
        Me.dtp_to_itemsales = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtp_from_itemsales = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pnl_category = New Marisha_POS.Controls.ManagedPanel()
        Me.pnl_stock_in = New Marisha_POS.Controls.ManagedPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.crv_purchases = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.cmd_show_pur = New System.Windows.Forms.Button()
        Me.cmd_pur_export = New System.Windows.Forms.Button()
        Me.cmd_pur_print = New System.Windows.Forms.Button()
        Me.dtp_purchases_to = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtp_purchases_from = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout
        Me.StatusStrip1.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelManager1.SuspendLayout
        Me.pnl_dashboard.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.pnl_items.SuspendLayout
        Me.Panel3.SuspendLayout
        CType(Me.dgv_items,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnl_stock_out.SuspendLayout
        Me.Panel6.SuspendLayout
        Me.Panel4.SuspendLayout
        Me.pnl_stock_in.SuspendLayout
        Me.Panel5.SuspendLayout
        Me.Panel7.SuspendLayout
        Me.SuspendLayout
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CategoryToolStripMenuItem, Me.BrandsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1294, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.FileToolStripMenuItem.Text = "Add Stocks"
        '
        'CategoryToolStripMenuItem
        '
        Me.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem"
        Me.CategoryToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.CategoryToolStripMenuItem.Text = "Category"
        '
        'BrandsToolStripMenuItem
        '
        Me.BrandsToolStripMenuItem.Name = "BrandsToolStripMenuItem"
        Me.BrandsToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.BrandsToolStripMenuItem.Text = "Brands"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = true
        Me.lbl_title.Font = New System.Drawing.Font("Tahoma", 45!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_title.Location = New System.Drawing.Point(156, 37)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(314, 72)
        Me.lbl_title.TabIndex = 10
        Me.lbl_title.Text = "Dashboard"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_date, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel5, Me.ss_time_and_date, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel4, Me.ss_user, Me.ToolStripStatusLabel9, Me.ToolStripStatusLabel7, Me.ss_position})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 672)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1294, 22)
        Me.StatusStrip1.TabIndex = 40
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'st_date
        '
        Me.st_date.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
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
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(111, 17)
        Me.ToolStripStatusLabel5.Text = "DATE AND TIME :"
        '
        'ss_time_and_date
        '
        Me.ss_time_and_date.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
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
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(101, 17)
        Me.ToolStripStatusLabel4.Text = "LOGGED IN AS :"
        '
        'ss_user
        '
        Me.ss_user.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
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
        Me.ToolStripStatusLabel7.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ToolStripStatusLabel7.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(74, 17)
        Me.ToolStripStatusLabel7.Text = "POSITION :"
        '
        'ss_position
        '
        Me.ss_position.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ss_position.ForeColor = System.Drawing.Color.White
        Me.ss_position.Name = "ss_position"
        Me.ss_position.Size = New System.Drawing.Size(46, 17)
        Me.ss_position.Text = "Admin"
        '
        'Timer1
        '
        Me.Timer1.Enabled = true
        '
        'Label25
        '
        Me.Label25.AutoSize = true
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label25.Location = New System.Drawing.Point(753, 100)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(78, 16)
        Me.Label25.TabIndex = 41
        Me.Label25.Text = "Dashboard"
        '
        'Label26
        '
        Me.Label26.AutoSize = true
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label26.Location = New System.Drawing.Point(870, 100)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 16)
        Me.Label26.TabIndex = 42
        Me.Label26.Text = "Item List"
        '
        'Label27
        '
        Me.Label27.AutoSize = true
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label27.Location = New System.Drawing.Point(977, 100)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(75, 16)
        Me.Label27.TabIndex = 43
        Me.Label27.Text = "Purchases"
        '
        'Label28
        '
        Me.Label28.AutoSize = true
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label28.Location = New System.Drawing.Point(1090, 100)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(76, 16)
        Me.Label28.TabIndex = 44
        Me.Label28.Text = "Item Sales"
        '
        'Label29
        '
        Me.Label29.AutoSize = true
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label29.Location = New System.Drawing.Point(1222, 100)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(42, 16)
        Me.Label29.TabIndex = 45
        Me.Label29.Text = "Close"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmd_stock_in
        '
        Me.cmd_stock_in.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_stock_in.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.checque
        Me.cmd_stock_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_stock_in.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_stock_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_stock_in.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_stock_in.ForeColor = System.Drawing.Color.White
        Me.cmd_stock_in.Location = New System.Drawing.Point(971, 32)
        Me.cmd_stock_in.Name = "cmd_stock_in"
        Me.cmd_stock_in.Size = New System.Drawing.Size(87, 68)
        Me.cmd_stock_in.TabIndex = 2
        Me.cmd_stock_in.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_stock_in.UseVisualStyleBackColor = false
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.Untitled_1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(1, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = false
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
        Me.cmd_close.Location = New System.Drawing.Point(1195, 32)
        Me.cmd_close.Name = "cmd_close"
        Me.cmd_close.Size = New System.Drawing.Size(87, 68)
        Me.cmd_close.TabIndex = 4
        Me.cmd_close.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_close.UseVisualStyleBackColor = false
        '
        'cmd_stock_out
        '
        Me.cmd_stock_out.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_stock_out.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.cashadvance
        Me.cmd_stock_out.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_stock_out.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_stock_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_stock_out.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_stock_out.ForeColor = System.Drawing.Color.White
        Me.cmd_stock_out.Location = New System.Drawing.Point(1083, 32)
        Me.cmd_stock_out.Name = "cmd_stock_out"
        Me.cmd_stock_out.Size = New System.Drawing.Size(87, 68)
        Me.cmd_stock_out.TabIndex = 3
        Me.cmd_stock_out.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_stock_out.UseVisualStyleBackColor = false
        '
        'cmd_itemlist
        '
        Me.cmd_itemlist.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_itemlist.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.raw_mat
        Me.cmd_itemlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_itemlist.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_itemlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_itemlist.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_itemlist.ForeColor = System.Drawing.Color.White
        Me.cmd_itemlist.Location = New System.Drawing.Point(859, 32)
        Me.cmd_itemlist.Name = "cmd_itemlist"
        Me.cmd_itemlist.Size = New System.Drawing.Size(87, 68)
        Me.cmd_itemlist.TabIndex = 1
        Me.cmd_itemlist.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_itemlist.UseVisualStyleBackColor = false
        '
        'cmd_dashboard
        '
        Me.cmd_dashboard.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_dashboard.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.book
        Me.cmd_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_dashboard.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_dashboard.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_dashboard.ForeColor = System.Drawing.Color.White
        Me.cmd_dashboard.Location = New System.Drawing.Point(748, 32)
        Me.cmd_dashboard.Name = "cmd_dashboard"
        Me.cmd_dashboard.Size = New System.Drawing.Size(87, 68)
        Me.cmd_dashboard.TabIndex = 0
        Me.cmd_dashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_dashboard.UseVisualStyleBackColor = false
        '
        'PanelManager1
        '
        Me.PanelManager1.BackColor = System.Drawing.Color.White
        Me.PanelManager1.Controls.Add(Me.pnl_dashboard)
        Me.PanelManager1.Controls.Add(Me.pnl_items)
        Me.PanelManager1.Controls.Add(Me.pnl_stock_out)
        Me.PanelManager1.Controls.Add(Me.pnl_category)
        Me.PanelManager1.Controls.Add(Me.pnl_stock_in)
        Me.PanelManager1.Location = New System.Drawing.Point(0, 124)
        Me.PanelManager1.Name = "PanelManager1"
        Me.PanelManager1.SelectedIndex = 1
        Me.PanelManager1.SelectedPanel = Me.pnl_items
        Me.PanelManager1.Size = New System.Drawing.Size(1294, 547)
        Me.PanelManager1.TabIndex = 8
        '
        'pnl_dashboard
        '
        Me.pnl_dashboard.Controls.Add(Me.Panel1)
        Me.pnl_dashboard.ForeColor = System.Drawing.Color.White
        Me.pnl_dashboard.Location = New System.Drawing.Point(0, 0)
        Me.pnl_dashboard.Name = "pnl_dashboard"
        Me.pnl_dashboard.Size = New System.Drawing.Size(0, 0)
        Me.pnl_dashboard.Text = "ManagedPanel1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cbo_category)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1294, 46)
        Me.Panel1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(318, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Current Item Stock Levels"
        '
        'cbo_category
        '
        Me.cbo_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_category.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbo_category.FormattingEnabled = true
        Me.cbo_category.Location = New System.Drawing.Point(904, 6)
        Me.cbo_category.Name = "cbo_category"
        Me.cbo_category.Size = New System.Drawing.Size(378, 33)
        Me.cbo_category.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(762, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Item Category :"
        '
        'pnl_items
        '
        Me.pnl_items.BackColor = System.Drawing.Color.Gainsboro
        Me.pnl_items.Controls.Add(Me.Panel3)
        Me.pnl_items.Location = New System.Drawing.Point(0, 0)
        Me.pnl_items.Name = "pnl_items"
        Me.pnl_items.Size = New System.Drawing.Size(1294, 547)
        Me.pnl_items.Text = "ManagedPanel2"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.cmd_adjust_item_qty)
        Me.Panel3.Controls.Add(Me.cmd_clear)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.cmd_purchase_return)
        Me.Panel3.Controls.Add(Me.dgv_items)
        Me.Panel3.Controls.Add(Me.txt_search)
        Me.Panel3.Controls.Add(Me.cbo_search_by)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.cmd_stock_report)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.cmd_additem)
        Me.Panel3.Controls.Add(Me.cmd_update)
        Me.Panel3.Controls.Add(Me.cmd_addstocks)
        Me.Panel3.Location = New System.Drawing.Point(3, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1281, 534)
        Me.Panel3.TabIndex = 1
        '
        'cmd_adjust_item_qty
        '
        Me.cmd_adjust_item_qty.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_adjust_item_qty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_adjust_item_qty.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_adjust_item_qty.ForeColor = System.Drawing.Color.White
        Me.cmd_adjust_item_qty.Location = New System.Drawing.Point(972, 32)
        Me.cmd_adjust_item_qty.Name = "cmd_adjust_item_qty"
        Me.cmd_adjust_item_qty.Size = New System.Drawing.Size(96, 47)
        Me.cmd_adjust_item_qty.TabIndex = 32
        Me.cmd_adjust_item_qty.Text = "Adjust Item Quantity"
        Me.cmd_adjust_item_qty.UseVisualStyleBackColor = false
        '
        'cmd_clear
        '
        Me.cmd_clear.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_clear.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_clear.ForeColor = System.Drawing.Color.White
        Me.cmd_clear.Location = New System.Drawing.Point(380, 50)
        Me.cmd_clear.Name = "cmd_clear"
        Me.cmd_clear.Size = New System.Drawing.Size(59, 27)
        Me.cmd_clear.TabIndex = 31
        Me.cmd_clear.Text = "Clear"
        Me.cmd_clear.UseVisualStyleBackColor = false
        '
        'Label24
        '
        Me.Label24.AutoSize = true
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label24.Location = New System.Drawing.Point(187, 30)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(187, 16)
        Me.Label24.TabIndex = 29
        Me.Label24.Text = "Enter Keyword or Number .."
        '
        'cmd_purchase_return
        '
        Me.cmd_purchase_return.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_purchase_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_purchase_return.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_purchase_return.ForeColor = System.Drawing.Color.White
        Me.cmd_purchase_return.Location = New System.Drawing.Point(764, 32)
        Me.cmd_purchase_return.Name = "cmd_purchase_return"
        Me.cmd_purchase_return.Size = New System.Drawing.Size(100, 47)
        Me.cmd_purchase_return.TabIndex = 30
        Me.cmd_purchase_return.Text = "Purchase Return"
        Me.cmd_purchase_return.UseVisualStyleBackColor = false
        '
        'dgv_items
        '
        Me.dgv_items.AllowUserToAddRows = false
        Me.dgv_items.AllowUserToDeleteRows = false
        Me.dgv_items.AllowUserToResizeRows = false
        Me.dgv_items.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_items.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_items.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_items.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_items.ColumnHeadersHeight = 25
        Me.dgv_items.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item_no, Me.barcode, Me.item_name, Me.selling_price, Me.buying_price, Me.avail, Me.stock_qty, Me.unit, Me.description, Me.category, Me.brand, Me.beg_inv})
        Me.dgv_items.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_items.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_items.EnableHeadersVisualStyles = false
        Me.dgv_items.Location = New System.Drawing.Point(6, 83)
        Me.dgv_items.MultiSelect = false
        Me.dgv_items.Name = "dgv_items"
        Me.dgv_items.ReadOnly = true
        Me.dgv_items.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_items.RowHeadersVisible = false
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dgv_items.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgv_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_items.Size = New System.Drawing.Size(1272, 441)
        Me.dgv_items.TabIndex = 28
        '
        'item_no
        '
        Me.item_no.HeaderText = "Item No."
        Me.item_no.Name = "item_no"
        Me.item_no.ReadOnly = true
        Me.item_no.Width = 70
        '
        'barcode
        '
        Me.barcode.HeaderText = "Barcode"
        Me.barcode.Name = "barcode"
        Me.barcode.ReadOnly = true
        Me.barcode.Width = 120
        '
        'item_name
        '
        Me.item_name.HeaderText = "Item Name"
        Me.item_name.Name = "item_name"
        Me.item_name.ReadOnly = true
        Me.item_name.Width = 275
        '
        'selling_price
        '
        Me.selling_price.HeaderText = "Selling Price"
        Me.selling_price.Name = "selling_price"
        Me.selling_price.ReadOnly = true
        Me.selling_price.Width = 80
        '
        'buying_price
        '
        Me.buying_price.HeaderText = "Purchase Price"
        Me.buying_price.Name = "buying_price"
        Me.buying_price.ReadOnly = true
        Me.buying_price.Width = 95
        '
        'avail
        '
        Me.avail.HeaderText = "Availability"
        Me.avail.Name = "avail"
        Me.avail.ReadOnly = true
        Me.avail.Visible = false
        '
        'stock_qty
        '
        Me.stock_qty.HeaderText = "Stock Qty."
        Me.stock_qty.Name = "stock_qty"
        Me.stock_qty.ReadOnly = true
        Me.stock_qty.Width = 70
        '
        'unit
        '
        Me.unit.HeaderText = "Unit"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = true
        Me.unit.Width = 50
        '
        'description
        '
        Me.description.HeaderText = "Description"
        Me.description.Name = "description"
        Me.description.ReadOnly = true
        Me.description.Width = 260
        '
        'category
        '
        Me.category.HeaderText = "Category"
        Me.category.Name = "category"
        Me.category.ReadOnly = true
        Me.category.Width = 120
        '
        'brand
        '
        Me.brand.HeaderText = "Brand"
        Me.brand.Name = "brand"
        Me.brand.ReadOnly = true
        '
        'beg_inv
        '
        Me.beg_inv.HeaderText = "beg_inv"
        Me.beg_inv.Name = "beg_inv"
        Me.beg_inv.ReadOnly = true
        Me.beg_inv.Visible = false
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_search.Location = New System.Drawing.Point(185, 51)
        Me.txt_search.MaxLength = 30
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(189, 26)
        Me.txt_search.TabIndex = 25
        '
        'cbo_search_by
        '
        Me.cbo_search_by.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_search_by.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbo_search_by.FormattingEnabled = true
        Me.cbo_search_by.Location = New System.Drawing.Point(7, 52)
        Me.cbo_search_by.Name = "cbo_search_by"
        Me.cbo_search_by.Size = New System.Drawing.Size(172, 24)
        Me.cbo_search_by.TabIndex = 24
        '
        'Label23
        '
        Me.Label23.AutoSize = true
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label23.Location = New System.Drawing.Point(8, 31)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(82, 16)
        Me.Label23.TabIndex = 23
        Me.Label23.Text = "Search By :"
        '
        'cmd_stock_report
        '
        Me.cmd_stock_report.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_stock_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_stock_report.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_stock_report.ForeColor = System.Drawing.Color.White
        Me.cmd_stock_report.Location = New System.Drawing.Point(870, 32)
        Me.cmd_stock_report.Name = "cmd_stock_report"
        Me.cmd_stock_report.Size = New System.Drawing.Size(96, 47)
        Me.cmd_stock_report.TabIndex = 26
        Me.cmd_stock_report.Text = "Inventory Report"
        Me.cmd_stock_report.UseVisualStyleBackColor = false
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(0, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(1281, 27)
        Me.Label22.TabIndex = 22
        Me.Label22.Text = "Item List"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmd_additem
        '
        Me.cmd_additem.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_additem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_additem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_additem.ForeColor = System.Drawing.Color.White
        Me.cmd_additem.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_additem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_additem.Location = New System.Drawing.Point(1088, 32)
        Me.cmd_additem.Name = "cmd_additem"
        Me.cmd_additem.Size = New System.Drawing.Size(92, 47)
        Me.cmd_additem.TabIndex = 18
        Me.cmd_additem.Text = "Add New Item"
        Me.cmd_additem.UseVisualStyleBackColor = false
        '
        'cmd_update
        '
        Me.cmd_update.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_update.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_update.ForeColor = System.Drawing.Color.White
        Me.cmd_update.Location = New System.Drawing.Point(1186, 32)
        Me.cmd_update.Name = "cmd_update"
        Me.cmd_update.Size = New System.Drawing.Size(90, 47)
        Me.cmd_update.TabIndex = 19
        Me.cmd_update.Text = "Edit Item"
        Me.cmd_update.UseVisualStyleBackColor = false
        '
        'cmd_addstocks
        '
        Me.cmd_addstocks.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_addstocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_addstocks.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_addstocks.ForeColor = System.Drawing.Color.White
        Me.cmd_addstocks.Location = New System.Drawing.Point(669, 32)
        Me.cmd_addstocks.Name = "cmd_addstocks"
        Me.cmd_addstocks.Size = New System.Drawing.Size(89, 47)
        Me.cmd_addstocks.TabIndex = 22
        Me.cmd_addstocks.Text = "Add Stocks"
        Me.cmd_addstocks.UseVisualStyleBackColor = false
        '
        'pnl_stock_out
        '
        Me.pnl_stock_out.Controls.Add(Me.Panel6)
        Me.pnl_stock_out.Controls.Add(Me.Panel4)
        Me.pnl_stock_out.Location = New System.Drawing.Point(0, 0)
        Me.pnl_stock_out.Name = "pnl_stock_out"
        Me.pnl_stock_out.Size = New System.Drawing.Size(0, 0)
        Me.pnl_stock_out.Text = "ManagedPanel1"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel6.Controls.Add(Me.crv_item_sales)
        Me.Panel6.Controls.Add(Me.Label19)
        Me.Panel6.Controls.Add(Me.Label20)
        Me.Panel6.Location = New System.Drawing.Point(3, 52)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1287, 495)
        Me.Panel6.TabIndex = 15
        '
        'crv_item_sales
        '
        Me.crv_item_sales.ActiveViewIndex = -1
        Me.crv_item_sales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_item_sales.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_item_sales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv_item_sales.Location = New System.Drawing.Point(0, 0)
        Me.crv_item_sales.Name = "crv_item_sales"
        Me.crv_item_sales.ShowCloseButton = false
        Me.crv_item_sales.ShowGroupTreeButton = false
        Me.crv_item_sales.ShowParameterPanelButton = false
        Me.crv_item_sales.ShowRefreshButton = false
        Me.crv_item_sales.Size = New System.Drawing.Size(1287, 495)
        Me.crv_item_sales.TabIndex = 54
        Me.crv_item_sales.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Label19
        '
        Me.Label19.AutoSize = true
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label19.Location = New System.Drawing.Point(512, 465)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 16)
        Me.Label19.TabIndex = 53
        Me.Label19.Text = "C0001"
        '
        'Label20
        '
        Me.Label20.AutoSize = true
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label20.Location = New System.Drawing.Point(306, 465)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(203, 16)
        Me.Label20.TabIndex = 52
        Me.Label20.Text = "Total Number of Stocks Out :"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel4.Controls.Add(Me.cmd_show_sales)
        Me.Panel4.Controls.Add(Me.cmd_sales_export)
        Me.Panel4.Controls.Add(Me.cmd_sales_print)
        Me.Panel4.Controls.Add(Me.dtp_to_itemsales)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.dtp_from_itemsales)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Location = New System.Drawing.Point(1, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1294, 46)
        Me.Panel4.TabIndex = 13
        '
        'cmd_show_sales
        '
        Me.cmd_show_sales.BackColor = System.Drawing.Color.White
        Me.cmd_show_sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_show_sales.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_show_sales.ForeColor = System.Drawing.Color.Black
        Me.cmd_show_sales.Location = New System.Drawing.Point(1175, 8)
        Me.cmd_show_sales.Name = "cmd_show_sales"
        Me.cmd_show_sales.Size = New System.Drawing.Size(106, 30)
        Me.cmd_show_sales.TabIndex = 46
        Me.cmd_show_sales.Text = "Show Report"
        Me.cmd_show_sales.UseVisualStyleBackColor = false
        '
        'cmd_sales_export
        '
        Me.cmd_sales_export.BackColor = System.Drawing.Color.White
        Me.cmd_sales_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_sales_export.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_sales_export.ForeColor = System.Drawing.Color.Black
        Me.cmd_sales_export.Location = New System.Drawing.Point(104, 7)
        Me.cmd_sales_export.Name = "cmd_sales_export"
        Me.cmd_sales_export.Size = New System.Drawing.Size(80, 33)
        Me.cmd_sales_export.TabIndex = 24
        Me.cmd_sales_export.Text = "Export"
        Me.cmd_sales_export.UseVisualStyleBackColor = false
        '
        'cmd_sales_print
        '
        Me.cmd_sales_print.BackColor = System.Drawing.Color.White
        Me.cmd_sales_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_sales_print.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_sales_print.ForeColor = System.Drawing.Color.Black
        Me.cmd_sales_print.Location = New System.Drawing.Point(11, 7)
        Me.cmd_sales_print.Name = "cmd_sales_print"
        Me.cmd_sales_print.Size = New System.Drawing.Size(80, 33)
        Me.cmd_sales_print.TabIndex = 23
        Me.cmd_sales_print.Text = "Print"
        Me.cmd_sales_print.UseVisualStyleBackColor = false
        '
        'dtp_to_itemsales
        '
        Me.dtp_to_itemsales.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dtp_to_itemsales.Location = New System.Drawing.Point(905, 11)
        Me.dtp_to_itemsales.Name = "dtp_to_itemsales"
        Me.dtp_to_itemsales.Size = New System.Drawing.Size(264, 26)
        Me.dtp_to_itemsales.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(865, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 19)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "to :"
        '
        'dtp_from_itemsales
        '
        Me.dtp_from_itemsales.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dtp_from_itemsales.Location = New System.Drawing.Point(595, 11)
        Me.dtp_from_itemsales.Name = "dtp_from_itemsales"
        Me.dtp_from_itemsales.Size = New System.Drawing.Size(264, 26)
        Me.dtp_from_itemsales.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(482, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 19)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Show from :"
        '
        'pnl_category
        '
        Me.pnl_category.Location = New System.Drawing.Point(0, 0)
        Me.pnl_category.Name = "pnl_category"
        Me.pnl_category.Size = New System.Drawing.Size(0, 0)
        Me.pnl_category.Text = "ManagedPanel1"
        '
        'pnl_stock_in
        '
        Me.pnl_stock_in.Controls.Add(Me.Panel5)
        Me.pnl_stock_in.Controls.Add(Me.Panel7)
        Me.pnl_stock_in.Location = New System.Drawing.Point(0, 0)
        Me.pnl_stock_in.Name = "pnl_stock_in"
        Me.pnl_stock_in.Size = New System.Drawing.Size(0, 0)
        Me.pnl_stock_in.Text = "ManagedPanel1"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel5.Controls.Add(Me.crv_purchases)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Location = New System.Drawing.Point(3, 52)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1287, 495)
        Me.Panel5.TabIndex = 17
        '
        'crv_purchases
        '
        Me.crv_purchases.ActiveViewIndex = -1
        Me.crv_purchases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_purchases.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_purchases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv_purchases.Location = New System.Drawing.Point(0, 0)
        Me.crv_purchases.Name = "crv_purchases"
        Me.crv_purchases.ReuseParameterValuesOnRefresh = true
        Me.crv_purchases.ShowCloseButton = false
        Me.crv_purchases.ShowGroupTreeButton = false
        Me.crv_purchases.ShowParameterPanelButton = false
        Me.crv_purchases.ShowRefreshButton = false
        Me.crv_purchases.Size = New System.Drawing.Size(1287, 495)
        Me.crv_purchases.TabIndex = 54
        Me.crv_purchases.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Label15
        '
        Me.Label15.AutoSize = true
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label15.Location = New System.Drawing.Point(512, 465)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 16)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "C0001"
        '
        'Label16
        '
        Me.Label16.AutoSize = true
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label16.Location = New System.Drawing.Point(306, 465)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(203, 16)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "Total Number of Stocks Out :"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel7.Controls.Add(Me.cmd_show_pur)
        Me.Panel7.Controls.Add(Me.cmd_pur_export)
        Me.Panel7.Controls.Add(Me.cmd_pur_print)
        Me.Panel7.Controls.Add(Me.dtp_purchases_to)
        Me.Panel7.Controls.Add(Me.Label17)
        Me.Panel7.Controls.Add(Me.dtp_purchases_from)
        Me.Panel7.Controls.Add(Me.Label18)
        Me.Panel7.Location = New System.Drawing.Point(1, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1294, 46)
        Me.Panel7.TabIndex = 16
        '
        'cmd_show_pur
        '
        Me.cmd_show_pur.BackColor = System.Drawing.Color.White
        Me.cmd_show_pur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_show_pur.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_show_pur.ForeColor = System.Drawing.Color.Black
        Me.cmd_show_pur.Location = New System.Drawing.Point(1175, 8)
        Me.cmd_show_pur.Name = "cmd_show_pur"
        Me.cmd_show_pur.Size = New System.Drawing.Size(106, 30)
        Me.cmd_show_pur.TabIndex = 34
        Me.cmd_show_pur.Text = "Show Report"
        Me.cmd_show_pur.UseVisualStyleBackColor = false
        '
        'cmd_pur_export
        '
        Me.cmd_pur_export.BackColor = System.Drawing.Color.White
        Me.cmd_pur_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_pur_export.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_pur_export.ForeColor = System.Drawing.Color.Black
        Me.cmd_pur_export.Location = New System.Drawing.Point(80, 7)
        Me.cmd_pur_export.Name = "cmd_pur_export"
        Me.cmd_pur_export.Size = New System.Drawing.Size(63, 33)
        Me.cmd_pur_export.TabIndex = 22
        Me.cmd_pur_export.Text = "Export"
        Me.cmd_pur_export.UseVisualStyleBackColor = false
        '
        'cmd_pur_print
        '
        Me.cmd_pur_print.BackColor = System.Drawing.Color.White
        Me.cmd_pur_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_pur_print.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_pur_print.ForeColor = System.Drawing.Color.Black
        Me.cmd_pur_print.Location = New System.Drawing.Point(11, 7)
        Me.cmd_pur_print.Name = "cmd_pur_print"
        Me.cmd_pur_print.Size = New System.Drawing.Size(63, 33)
        Me.cmd_pur_print.TabIndex = 21
        Me.cmd_pur_print.Text = "Print"
        Me.cmd_pur_print.UseVisualStyleBackColor = false
        '
        'dtp_purchases_to
        '
        Me.dtp_purchases_to.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dtp_purchases_to.Location = New System.Drawing.Point(905, 11)
        Me.dtp_purchases_to.Name = "dtp_purchases_to"
        Me.dtp_purchases_to.Size = New System.Drawing.Size(264, 26)
        Me.dtp_purchases_to.TabIndex = 20
        '
        'Label17
        '
        Me.Label17.AutoSize = true
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(865, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 19)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "to :"
        '
        'dtp_purchases_from
        '
        Me.dtp_purchases_from.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dtp_purchases_from.Location = New System.Drawing.Point(595, 11)
        Me.dtp_purchases_from.Name = "dtp_purchases_from"
        Me.dtp_purchases_from.Size = New System.Drawing.Size(264, 26)
        Me.dtp_purchases_from.TabIndex = 18
        '
        'Label18
        '
        Me.Label18.AutoSize = true
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(482, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(107, 19)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Show from :"
        '
        'frm_inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1294, 694)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cmd_stock_in)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmd_close)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.PanelManager1)
        Me.Controls.Add(Me.cmd_stock_out)
        Me.Controls.Add(Me.cmd_itemlist)
        Me.Controls.Add(Me.cmd_dashboard)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = false
        Me.Name = "frm_inventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha - Inventory"
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelManager1.ResumeLayout(false)
        Me.pnl_dashboard.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.pnl_items.ResumeLayout(false)
        Me.Panel3.ResumeLayout(false)
        Me.Panel3.PerformLayout
        CType(Me.dgv_items,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnl_stock_out.ResumeLayout(false)
        Me.Panel6.ResumeLayout(false)
        Me.Panel6.PerformLayout
        Me.Panel4.ResumeLayout(false)
        Me.Panel4.PerformLayout
        Me.pnl_stock_in.ResumeLayout(false)
        Me.Panel5.ResumeLayout(false)
        Me.Panel5.PerformLayout
        Me.Panel7.ResumeLayout(false)
        Me.Panel7.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents cmd_dashboard As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmd_itemlist As System.Windows.Forms.Button
    Friend WithEvents cmd_stock_out As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_category As System.Windows.Forms.ComboBox
    Friend WithEvents PanelManager1 As Marisha_POS.Controls.PanelManager
    Friend WithEvents pnl_dashboard As Marisha_POS.Controls.ManagedPanel
    Friend WithEvents pnl_items As Marisha_POS.Controls.ManagedPanel
    Friend WithEvents pnl_stock_out As Marisha_POS.Controls.ManagedPanel
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents cmd_close As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnl_category As Marisha_POS.Controls.ManagedPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmd_update As System.Windows.Forms.Button
    Friend WithEvents cmd_additem As System.Windows.Forms.Button
    Friend WithEvents cmd_addstocks As System.Windows.Forms.Button
    Friend WithEvents CategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrandsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cmd_stock_in As System.Windows.Forms.Button
    Friend WithEvents pnl_stock_in As Marisha_POS.Controls.ManagedPanel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents crv_item_sales As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents dtp_to_itemsales As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtp_from_itemsales As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents dtp_purchases_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtp_purchases_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents cbo_search_by As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmd_stock_report As System.Windows.Forms.Button
    Friend WithEvents dgv_items As System.Windows.Forms.DataGridView
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
    Friend WithEvents cmd_purchase_return As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents crv_purchases As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cmd_clear As System.Windows.Forms.Button
    Friend WithEvents cmd_pur_export As System.Windows.Forms.Button
    Friend WithEvents cmd_pur_print As System.Windows.Forms.Button
    Friend WithEvents cmd_sales_export As System.Windows.Forms.Button
    Friend WithEvents cmd_sales_print As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cmd_show_pur As System.Windows.Forms.Button
    Friend WithEvents cmd_show_sales As System.Windows.Forms.Button
    Friend WithEvents cmd_adjust_item_qty As System.Windows.Forms.Button
    Friend WithEvents item_no As DataGridViewTextBoxColumn
    Friend WithEvents barcode As DataGridViewTextBoxColumn
    Friend WithEvents item_name As DataGridViewTextBoxColumn
    Friend WithEvents selling_price As DataGridViewTextBoxColumn
    Friend WithEvents buying_price As DataGridViewTextBoxColumn
    Friend WithEvents avail As DataGridViewTextBoxColumn
    Friend WithEvents stock_qty As DataGridViewTextBoxColumn
    Friend WithEvents unit As DataGridViewTextBoxColumn
    Friend WithEvents description As DataGridViewTextBoxColumn
    Friend WithEvents category As DataGridViewTextBoxColumn
    Friend WithEvents brand As DataGridViewTextBoxColumn
    Friend WithEvents beg_inv As DataGridViewTextBoxColumn
End Class
