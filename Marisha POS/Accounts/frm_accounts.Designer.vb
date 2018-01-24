<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_accounts
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmd_trans_history = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmd_update = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cb_supp_updt_supp = New System.Windows.Forms.CheckBox()
        Me.cb_supp_add_supp = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cb_cust_bo = New System.Windows.Forms.CheckBox()
        Me.cb_cust_sales_ret = New System.Windows.Forms.CheckBox()
        Me.cb_cust_report_arpay = New System.Windows.Forms.CheckBox()
        Me.cb_cust_cash_trans = New System.Windows.Forms.CheckBox()
        Me.cb_cust_balpay = New System.Windows.Forms.CheckBox()
        Me.cb_cust_updt_cust = New System.Windows.Forms.CheckBox()
        Me.cb_cust_add_cust = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cb_sales_report_incstate = New System.Windows.Forms.CheckBox()
        Me.cb_sales_report_dailyremit = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cb_inv_report_pur = New System.Windows.Forms.CheckBox()
        Me.cb_inv_report_sales = New System.Windows.Forms.CheckBox()
        Me.cb_inv_report_inv = New System.Windows.Forms.CheckBox()
        Me.cb_inv_pur_ret = New System.Windows.Forms.CheckBox()
        Me.cb_inv_updt_item = New System.Windows.Forms.CheckBox()
        Me.cb_inv_add_item = New System.Windows.Forms.CheckBox()
        Me.cb_inv_add_stocks = New System.Windows.Forms.CheckBox()
        Me.cb_inv_brands = New System.Windows.Forms.CheckBox()
        Me.cb_inv_category = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cb_pos_receipt = New System.Windows.Forms.CheckBox()
        Me.cb_pos_sales_trans = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_admin = New System.Windows.Forms.Label()
        Me.lbl_position = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_lname = New System.Windows.Forms.Label()
        Me.lbl_mname = New System.Windows.Forms.Label()
        Me.lbl_fname = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_account_no = New System.Windows.Forms.Label()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_accounts = New System.Windows.Forms.DataGridView()
        Me.account_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.position = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.first_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.middle_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.last_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pos_sales_trans = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pos_receipt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inv_category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inv_brands = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inv_add_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inv_updt_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inv_add_stocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inv_purchase_return = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inv_report_inv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inv_report_pur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inv_report_sales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sales_report_remit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sales_report_incstate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_add_cust = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_updt_cust = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_balpay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_report_acc_receive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_cash_trans = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_return_trans = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust_bo_trans = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supp_add_supp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supp_updt_supp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.admin = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.cmd_delete = New System.Windows.Forms.Button()
        Me.cmd_addnew = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_accounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmd_trans_history)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(968, 66)
        Me.Panel1.TabIndex = 0
        '
        'cmd_trans_history
        '
        Me.cmd_trans_history.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_trans_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_trans_history.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_trans_history.ForeColor = System.Drawing.Color.White
        Me.cmd_trans_history.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_trans_history.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_trans_history.Location = New System.Drawing.Point(691, 9)
        Me.cmd_trans_history.Name = "cmd_trans_history"
        Me.cmd_trans_history.Size = New System.Drawing.Size(156, 47)
        Me.cmd_trans_history.TabIndex = 2
        Me.cmd_trans_history.Text = "Transaction History"
        Me.cmd_trans_history.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(864, 9)
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
        Me.lblTitle.Location = New System.Drawing.Point(11, 11)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(190, 42)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "User Accounts"
        '
        'cmd_update
        '
        Me.cmd_update.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_update.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_update.ForeColor = System.Drawing.Color.White
        Me.cmd_update.Location = New System.Drawing.Point(148, 580)
        Me.cmd_update.Name = "cmd_update"
        Me.cmd_update.Size = New System.Drawing.Size(90, 47)
        Me.cmd_update.TabIndex = 2
        Me.cmd_update.Text = "Update"
        Me.cmd_update.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.cb_supp_updt_supp)
        Me.Panel2.Controls.Add(Me.cb_supp_add_supp)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.cb_cust_bo)
        Me.Panel2.Controls.Add(Me.cb_cust_sales_ret)
        Me.Panel2.Controls.Add(Me.cb_cust_report_arpay)
        Me.Panel2.Controls.Add(Me.cb_cust_cash_trans)
        Me.Panel2.Controls.Add(Me.cb_cust_balpay)
        Me.Panel2.Controls.Add(Me.cb_cust_updt_cust)
        Me.Panel2.Controls.Add(Me.cb_cust_add_cust)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.cb_sales_report_incstate)
        Me.Panel2.Controls.Add(Me.cb_sales_report_dailyremit)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.cb_inv_report_pur)
        Me.Panel2.Controls.Add(Me.cb_inv_report_sales)
        Me.Panel2.Controls.Add(Me.cb_inv_report_inv)
        Me.Panel2.Controls.Add(Me.cb_inv_pur_ret)
        Me.Panel2.Controls.Add(Me.cb_inv_updt_item)
        Me.Panel2.Controls.Add(Me.cb_inv_add_item)
        Me.Panel2.Controls.Add(Me.cb_inv_add_stocks)
        Me.Panel2.Controls.Add(Me.cb_inv_brands)
        Me.Panel2.Controls.Add(Me.cb_inv_category)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.cb_pos_receipt)
        Me.Panel2.Controls.Add(Me.cb_pos_sales_trans)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.lbl_admin)
        Me.Panel2.Controls.Add(Me.lbl_position)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lbl_lname)
        Me.Panel2.Controls.Add(Me.lbl_mname)
        Me.Panel2.Controls.Add(Me.lbl_fname)
        Me.Panel2.Controls.Add(Me.lbl_password)
        Me.Panel2.Controls.Add(Me.lbl_username)
        Me.Panel2.Controls.Add(Me.lbl_account_no)
        Me.Panel2.Controls.Add(Me.pic)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(380, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(580, 559)
        Me.Panel2.TabIndex = 26
        '
        'cb_supp_updt_supp
        '
        Me.cb_supp_updt_supp.AutoSize = True
        Me.cb_supp_updt_supp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_supp_updt_supp.Location = New System.Drawing.Point(30, 524)
        Me.cb_supp_updt_supp.Name = "cb_supp_updt_supp"
        Me.cb_supp_updt_supp.Size = New System.Drawing.Size(143, 18)
        Me.cb_supp_updt_supp.TabIndex = 74
        Me.cb_supp_updt_supp.Text = "Update Supplier Info."
        Me.cb_supp_updt_supp.UseVisualStyleBackColor = True
        '
        'cb_supp_add_supp
        '
        Me.cb_supp_add_supp.AutoSize = True
        Me.cb_supp_add_supp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_supp_add_supp.Location = New System.Drawing.Point(30, 500)
        Me.cb_supp_add_supp.Name = "cb_supp_add_supp"
        Me.cb_supp_add_supp.Size = New System.Drawing.Size(124, 18)
        Me.cb_supp_add_supp.TabIndex = 75
        Me.cb_supp_add_supp.Text = "Add New Supplier"
        Me.cb_supp_add_supp.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(27, 478)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 14)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "SUPPLIERS"
        '
        'cb_cust_bo
        '
        Me.cb_cust_bo.AutoSize = True
        Me.cb_cust_bo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cust_bo.Location = New System.Drawing.Point(389, 482)
        Me.cb_cust_bo.Name = "cb_cust_bo"
        Me.cb_cust_bo.Size = New System.Drawing.Size(50, 18)
        Me.cb_cust_bo.TabIndex = 72
        Me.cb_cust_bo.Text = "B.O."
        Me.cb_cust_bo.UseVisualStyleBackColor = True
        '
        'cb_cust_sales_ret
        '
        Me.cb_cust_sales_ret.AutoSize = True
        Me.cb_cust_sales_ret.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cust_sales_ret.Location = New System.Drawing.Point(389, 410)
        Me.cb_cust_sales_ret.Name = "cb_cust_sales_ret"
        Me.cb_cust_sales_ret.Size = New System.Drawing.Size(94, 18)
        Me.cb_cust_sales_ret.TabIndex = 71
        Me.cb_cust_sales_ret.Text = "Sales Return"
        Me.cb_cust_sales_ret.UseVisualStyleBackColor = True
        '
        'cb_cust_report_arpay
        '
        Me.cb_cust_report_arpay.AutoSize = True
        Me.cb_cust_report_arpay.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cust_report_arpay.Location = New System.Drawing.Point(389, 458)
        Me.cb_cust_report_arpay.Name = "cb_cust_report_arpay"
        Me.cb_cust_report_arpay.Size = New System.Drawing.Size(139, 18)
        Me.cb_cust_report_arpay.TabIndex = 70
        Me.cb_cust_report_arpay.Text = "AR Payments Report"
        Me.cb_cust_report_arpay.UseVisualStyleBackColor = True
        '
        'cb_cust_cash_trans
        '
        Me.cb_cust_cash_trans.AutoSize = True
        Me.cb_cust_cash_trans.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cust_cash_trans.Location = New System.Drawing.Point(389, 386)
        Me.cb_cust_cash_trans.Name = "cb_cust_cash_trans"
        Me.cb_cust_cash_trans.Size = New System.Drawing.Size(117, 18)
        Me.cb_cust_cash_trans.TabIndex = 69
        Me.cb_cust_cash_trans.Text = "Cash Transctions"
        Me.cb_cust_cash_trans.UseVisualStyleBackColor = True
        '
        'cb_cust_balpay
        '
        Me.cb_cust_balpay.AutoSize = True
        Me.cb_cust_balpay.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cust_balpay.Location = New System.Drawing.Point(389, 434)
        Me.cb_cust_balpay.Name = "cb_cust_balpay"
        Me.cb_cust_balpay.Size = New System.Drawing.Size(175, 18)
        Me.cb_cust_balpay.TabIndex = 68
        Me.cb_cust_balpay.Text = "Customer Balance Payment"
        Me.cb_cust_balpay.UseVisualStyleBackColor = True
        '
        'cb_cust_updt_cust
        '
        Me.cb_cust_updt_cust.AutoSize = True
        Me.cb_cust_updt_cust.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cust_updt_cust.Location = New System.Drawing.Point(389, 362)
        Me.cb_cust_updt_cust.Name = "cb_cust_updt_cust"
        Me.cb_cust_updt_cust.Size = New System.Drawing.Size(152, 18)
        Me.cb_cust_updt_cust.TabIndex = 67
        Me.cb_cust_updt_cust.Text = "Update Customer Info."
        Me.cb_cust_updt_cust.UseVisualStyleBackColor = True
        '
        'cb_cust_add_cust
        '
        Me.cb_cust_add_cust.AutoSize = True
        Me.cb_cust_add_cust.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cust_add_cust.Location = New System.Drawing.Point(389, 338)
        Me.cb_cust_add_cust.Name = "cb_cust_add_cust"
        Me.cb_cust_add_cust.Size = New System.Drawing.Size(133, 18)
        Me.cb_cust_add_cust.TabIndex = 66
        Me.cb_cust_add_cust.Text = "Add New Customer"
        Me.cb_cust_add_cust.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(386, 315)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 14)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "CUSTOMERS"
        '
        'cb_sales_report_incstate
        '
        Me.cb_sales_report_incstate.AutoSize = True
        Me.cb_sales_report_incstate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_sales_report_incstate.Location = New System.Drawing.Point(30, 442)
        Me.cb_sales_report_incstate.Name = "cb_sales_report_incstate"
        Me.cb_sales_report_incstate.Size = New System.Drawing.Size(130, 18)
        Me.cb_sales_report_incstate.TabIndex = 63
        Me.cb_sales_report_incstate.Text = "Income Statement"
        Me.cb_sales_report_incstate.UseVisualStyleBackColor = True
        '
        'cb_sales_report_dailyremit
        '
        Me.cb_sales_report_dailyremit.AutoSize = True
        Me.cb_sales_report_dailyremit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_sales_report_dailyremit.Location = New System.Drawing.Point(30, 418)
        Me.cb_sales_report_dailyremit.Name = "cb_sales_report_dailyremit"
        Me.cb_sales_report_dailyremit.Size = New System.Drawing.Size(162, 18)
        Me.cb_sales_report_dailyremit.TabIndex = 64
        Me.cb_sales_report_dailyremit.Text = "Daily Remittances Report"
        Me.cb_sales_report_dailyremit.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 396)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 14)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "SALES"
        '
        'cb_inv_report_pur
        '
        Me.cb_inv_report_pur.AutoSize = True
        Me.cb_inv_report_pur.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_inv_report_pur.Location = New System.Drawing.Point(216, 530)
        Me.cb_inv_report_pur.Name = "cb_inv_report_pur"
        Me.cb_inv_report_pur.Size = New System.Drawing.Size(151, 18)
        Me.cb_inv_report_pur.TabIndex = 61
        Me.cb_inv_report_pur.Text = "Item Purchases Report"
        Me.cb_inv_report_pur.UseVisualStyleBackColor = True
        '
        'cb_inv_report_sales
        '
        Me.cb_inv_report_sales.AutoSize = True
        Me.cb_inv_report_sales.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_inv_report_sales.Location = New System.Drawing.Point(216, 482)
        Me.cb_inv_report_sales.Name = "cb_inv_report_sales"
        Me.cb_inv_report_sales.Size = New System.Drawing.Size(124, 18)
        Me.cb_inv_report_sales.TabIndex = 60
        Me.cb_inv_report_sales.Text = "Item Sales Report"
        Me.cb_inv_report_sales.UseVisualStyleBackColor = True
        '
        'cb_inv_report_inv
        '
        Me.cb_inv_report_inv.AutoSize = True
        Me.cb_inv_report_inv.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_inv_report_inv.Location = New System.Drawing.Point(216, 506)
        Me.cb_inv_report_inv.Name = "cb_inv_report_inv"
        Me.cb_inv_report_inv.Size = New System.Drawing.Size(120, 18)
        Me.cb_inv_report_inv.TabIndex = 59
        Me.cb_inv_report_inv.Text = "Inventory Report"
        Me.cb_inv_report_inv.UseVisualStyleBackColor = True
        '
        'cb_inv_pur_ret
        '
        Me.cb_inv_pur_ret.AutoSize = True
        Me.cb_inv_pur_ret.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_inv_pur_ret.Location = New System.Drawing.Point(216, 458)
        Me.cb_inv_pur_ret.Name = "cb_inv_pur_ret"
        Me.cb_inv_pur_ret.Size = New System.Drawing.Size(121, 18)
        Me.cb_inv_pur_ret.TabIndex = 58
        Me.cb_inv_pur_ret.Text = "Purchase Returns"
        Me.cb_inv_pur_ret.UseVisualStyleBackColor = True
        '
        'cb_inv_updt_item
        '
        Me.cb_inv_updt_item.AutoSize = True
        Me.cb_inv_updt_item.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_inv_updt_item.Location = New System.Drawing.Point(216, 410)
        Me.cb_inv_updt_item.Name = "cb_inv_updt_item"
        Me.cb_inv_updt_item.Size = New System.Drawing.Size(126, 18)
        Me.cb_inv_updt_item.TabIndex = 57
        Me.cb_inv_updt_item.Text = "Update Item Info."
        Me.cb_inv_updt_item.UseVisualStyleBackColor = True
        '
        'cb_inv_add_item
        '
        Me.cb_inv_add_item.AutoSize = True
        Me.cb_inv_add_item.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_inv_add_item.Location = New System.Drawing.Point(216, 386)
        Me.cb_inv_add_item.Name = "cb_inv_add_item"
        Me.cb_inv_add_item.Size = New System.Drawing.Size(107, 18)
        Me.cb_inv_add_item.TabIndex = 55
        Me.cb_inv_add_item.Text = "Add New Item"
        Me.cb_inv_add_item.UseVisualStyleBackColor = True
        '
        'cb_inv_add_stocks
        '
        Me.cb_inv_add_stocks.AutoSize = True
        Me.cb_inv_add_stocks.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_inv_add_stocks.Location = New System.Drawing.Point(216, 434)
        Me.cb_inv_add_stocks.Name = "cb_inv_add_stocks"
        Me.cb_inv_add_stocks.Size = New System.Drawing.Size(88, 18)
        Me.cb_inv_add_stocks.TabIndex = 56
        Me.cb_inv_add_stocks.Text = "Add Stocks"
        Me.cb_inv_add_stocks.UseVisualStyleBackColor = True
        '
        'cb_inv_brands
        '
        Me.cb_inv_brands.AutoSize = True
        Me.cb_inv_brands.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_inv_brands.Location = New System.Drawing.Point(216, 362)
        Me.cb_inv_brands.Name = "cb_inv_brands"
        Me.cb_inv_brands.Size = New System.Drawing.Size(92, 18)
        Me.cb_inv_brands.TabIndex = 53
        Me.cb_inv_brands.Text = "Item Brands"
        Me.cb_inv_brands.UseVisualStyleBackColor = True
        '
        'cb_inv_category
        '
        Me.cb_inv_category.AutoSize = True
        Me.cb_inv_category.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_inv_category.Location = New System.Drawing.Point(216, 338)
        Me.cb_inv_category.Name = "cb_inv_category"
        Me.cb_inv_category.Size = New System.Drawing.Size(113, 18)
        Me.cb_inv_category.TabIndex = 54
        Me.cb_inv_category.Text = "Item Categories"
        Me.cb_inv_category.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(213, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 14)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "INVENTORY"
        '
        'cb_pos_receipt
        '
        Me.cb_pos_receipt.AutoSize = True
        Me.cb_pos_receipt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_pos_receipt.Location = New System.Drawing.Point(30, 361)
        Me.cb_pos_receipt.Name = "cb_pos_receipt"
        Me.cb_pos_receipt.Size = New System.Drawing.Size(116, 18)
        Me.cb_pos_receipt.TabIndex = 50
        Me.cb_pos_receipt.Text = "Receipt Settings"
        Me.cb_pos_receipt.UseVisualStyleBackColor = True
        '
        'cb_pos_sales_trans
        '
        Me.cb_pos_sales_trans.AutoSize = True
        Me.cb_pos_sales_trans.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_pos_sales_trans.Location = New System.Drawing.Point(30, 337)
        Me.cb_pos_sales_trans.Name = "cb_pos_sales_trans"
        Me.cb_pos_sales_trans.Size = New System.Drawing.Size(120, 18)
        Me.cb_pos_sales_trans.TabIndex = 51
        Me.cb_pos_sales_trans.Text = "Sales Transaction"
        Me.cb_pos_sales_trans.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(27, 315)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 14)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "POS"
        '
        'lbl_admin
        '
        Me.lbl_admin.BackColor = System.Drawing.Color.White
        Me.lbl_admin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_admin.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_admin.Location = New System.Drawing.Point(32, 201)
        Me.lbl_admin.Name = "lbl_admin"
        Me.lbl_admin.Size = New System.Drawing.Size(155, 22)
        Me.lbl_admin.TabIndex = 39
        Me.lbl_admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_admin.Visible = False
        '
        'lbl_position
        '
        Me.lbl_position.BackColor = System.Drawing.Color.White
        Me.lbl_position.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_position.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_position.Location = New System.Drawing.Point(337, 129)
        Me.lbl_position.Name = "lbl_position"
        Me.lbl_position.Size = New System.Drawing.Size(209, 22)
        Me.lbl_position.TabIndex = 38
        Me.lbl_position.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(222, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 18)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Position :"
        '
        'lbl_lname
        '
        Me.lbl_lname.BackColor = System.Drawing.Color.White
        Me.lbl_lname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_lname.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lname.Location = New System.Drawing.Point(337, 236)
        Me.lbl_lname.Name = "lbl_lname"
        Me.lbl_lname.Size = New System.Drawing.Size(209, 22)
        Me.lbl_lname.TabIndex = 35
        Me.lbl_lname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_mname
        '
        Me.lbl_mname.BackColor = System.Drawing.Color.White
        Me.lbl_mname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_mname.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mname.Location = New System.Drawing.Point(337, 205)
        Me.lbl_mname.Name = "lbl_mname"
        Me.lbl_mname.Size = New System.Drawing.Size(209, 22)
        Me.lbl_mname.TabIndex = 34
        Me.lbl_mname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_fname
        '
        Me.lbl_fname.BackColor = System.Drawing.Color.White
        Me.lbl_fname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_fname.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fname.Location = New System.Drawing.Point(337, 175)
        Me.lbl_fname.Name = "lbl_fname"
        Me.lbl_fname.Size = New System.Drawing.Size(209, 22)
        Me.lbl_fname.TabIndex = 33
        Me.lbl_fname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_password
        '
        Me.lbl_password.BackColor = System.Drawing.Color.White
        Me.lbl_password.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_password.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.Location = New System.Drawing.Point(337, 100)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(209, 22)
        Me.lbl_password.TabIndex = 32
        Me.lbl_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_username
        '
        Me.lbl_username.BackColor = System.Drawing.Color.White
        Me.lbl_username.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_username.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(337, 70)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(209, 22)
        Me.lbl_username.TabIndex = 31
        Me.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_account_no
        '
        Me.lbl_account_no.BackColor = System.Drawing.Color.White
        Me.lbl_account_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_account_no.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_account_no.Location = New System.Drawing.Point(337, 41)
        Me.lbl_account_no.Name = "lbl_account_no"
        Me.lbl_account_no.Size = New System.Drawing.Size(209, 22)
        Me.lbl_account_no.TabIndex = 30
        Me.lbl_account_no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pic
        '
        Me.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic.Location = New System.Drawing.Point(32, 45)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(155, 134)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic.TabIndex = 23
        Me.pic.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(580, 27)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Account Access"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(580, 27)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Account Information"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(222, 206)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 18)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Middle Name :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(222, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 18)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Last Name :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(223, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "First name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(223, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Password :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(223, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Username :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(223, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Account No. :"
        '
        'dgv_accounts
        '
        Me.dgv_accounts.AllowUserToAddRows = False
        Me.dgv_accounts.AllowUserToDeleteRows = False
        Me.dgv_accounts.AllowUserToResizeRows = False
        Me.dgv_accounts.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_accounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_accounts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_accounts.ColumnHeadersHeight = 25
        Me.dgv_accounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.account_no, Me.username, Me.password, Me.position, Me.first_name, Me.middle_name, Me.last_name, Me.pos_sales_trans, Me.pos_receipt, Me.inv_category, Me.inv_brands, Me.inv_add_item, Me.inv_updt_item, Me.inv_add_stocks, Me.inv_purchase_return, Me.inv_report_inv, Me.inv_report_pur, Me.inv_report_sales, Me.sales_report_remit, Me.sales_report_incstate, Me.cust_add_cust, Me.cust_updt_cust, Me.cust_balpay, Me.cust_report_acc_receive, Me.cust_cash_trans, Me.cust_return_trans, Me.cust_bo_trans, Me.supp_add_supp, Me.supp_updt_supp, Me.admin})
        Me.dgv_accounts.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_accounts.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_accounts.EnableHeadersVisualStyles = False
        Me.dgv_accounts.Location = New System.Drawing.Point(9, 72)
        Me.dgv_accounts.MultiSelect = False
        Me.dgv_accounts.Name = "dgv_accounts"
        Me.dgv_accounts.ReadOnly = True
        Me.dgv_accounts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_accounts.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_accounts.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_accounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_accounts.Size = New System.Drawing.Size(362, 502)
        Me.dgv_accounts.TabIndex = 27
        '
        'account_no
        '
        Me.account_no.HeaderText = "Account No."
        Me.account_no.Name = "account_no"
        Me.account_no.ReadOnly = True
        '
        'username
        '
        Me.username.HeaderText = "Username"
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        Me.username.Width = 120
        '
        'password
        '
        Me.password.HeaderText = "Password"
        Me.password.Name = "password"
        Me.password.ReadOnly = True
        Me.password.Width = 120
        '
        'position
        '
        Me.position.HeaderText = "position"
        Me.position.Name = "position"
        Me.position.ReadOnly = True
        Me.position.Visible = False
        '
        'first_name
        '
        Me.first_name.HeaderText = "firstname"
        Me.first_name.Name = "first_name"
        Me.first_name.ReadOnly = True
        Me.first_name.Visible = False
        '
        'middle_name
        '
        Me.middle_name.HeaderText = "middlename"
        Me.middle_name.Name = "middle_name"
        Me.middle_name.ReadOnly = True
        Me.middle_name.Visible = False
        '
        'last_name
        '
        Me.last_name.HeaderText = "lastname"
        Me.last_name.Name = "last_name"
        Me.last_name.ReadOnly = True
        Me.last_name.Visible = False
        '
        'pos_sales_trans
        '
        Me.pos_sales_trans.HeaderText = "pos_sales_trans"
        Me.pos_sales_trans.Name = "pos_sales_trans"
        Me.pos_sales_trans.ReadOnly = True
        Me.pos_sales_trans.Visible = False
        '
        'pos_receipt
        '
        Me.pos_receipt.HeaderText = "pos_receipt"
        Me.pos_receipt.Name = "pos_receipt"
        Me.pos_receipt.ReadOnly = True
        Me.pos_receipt.Visible = False
        '
        'inv_category
        '
        Me.inv_category.HeaderText = "inv_category"
        Me.inv_category.Name = "inv_category"
        Me.inv_category.ReadOnly = True
        Me.inv_category.Visible = False
        '
        'inv_brands
        '
        Me.inv_brands.HeaderText = "inv_brands"
        Me.inv_brands.Name = "inv_brands"
        Me.inv_brands.ReadOnly = True
        Me.inv_brands.Visible = False
        '
        'inv_add_item
        '
        Me.inv_add_item.HeaderText = "inv_add_item"
        Me.inv_add_item.Name = "inv_add_item"
        Me.inv_add_item.ReadOnly = True
        Me.inv_add_item.Visible = False
        '
        'inv_updt_item
        '
        Me.inv_updt_item.HeaderText = "inv_updt_item"
        Me.inv_updt_item.Name = "inv_updt_item"
        Me.inv_updt_item.ReadOnly = True
        Me.inv_updt_item.Visible = False
        '
        'inv_add_stocks
        '
        Me.inv_add_stocks.HeaderText = "inv_add_stocks"
        Me.inv_add_stocks.Name = "inv_add_stocks"
        Me.inv_add_stocks.ReadOnly = True
        Me.inv_add_stocks.Visible = False
        '
        'inv_purchase_return
        '
        Me.inv_purchase_return.HeaderText = "inv_purchase_return"
        Me.inv_purchase_return.Name = "inv_purchase_return"
        Me.inv_purchase_return.ReadOnly = True
        Me.inv_purchase_return.Visible = False
        '
        'inv_report_inv
        '
        Me.inv_report_inv.HeaderText = "inv_report_inv"
        Me.inv_report_inv.Name = "inv_report_inv"
        Me.inv_report_inv.ReadOnly = True
        Me.inv_report_inv.Visible = False
        '
        'inv_report_pur
        '
        Me.inv_report_pur.HeaderText = "inv_report_pur"
        Me.inv_report_pur.Name = "inv_report_pur"
        Me.inv_report_pur.ReadOnly = True
        Me.inv_report_pur.Visible = False
        '
        'inv_report_sales
        '
        Me.inv_report_sales.HeaderText = "inv_report_sales"
        Me.inv_report_sales.Name = "inv_report_sales"
        Me.inv_report_sales.ReadOnly = True
        Me.inv_report_sales.Visible = False
        '
        'sales_report_remit
        '
        Me.sales_report_remit.HeaderText = "sales_report_remit"
        Me.sales_report_remit.Name = "sales_report_remit"
        Me.sales_report_remit.ReadOnly = True
        Me.sales_report_remit.Visible = False
        '
        'sales_report_incstate
        '
        Me.sales_report_incstate.HeaderText = "sales_report_incstate"
        Me.sales_report_incstate.Name = "sales_report_incstate"
        Me.sales_report_incstate.ReadOnly = True
        Me.sales_report_incstate.Visible = False
        '
        'cust_add_cust
        '
        Me.cust_add_cust.HeaderText = "cust_add_cust"
        Me.cust_add_cust.Name = "cust_add_cust"
        Me.cust_add_cust.ReadOnly = True
        Me.cust_add_cust.Visible = False
        '
        'cust_updt_cust
        '
        Me.cust_updt_cust.HeaderText = "cust_updt_cust"
        Me.cust_updt_cust.Name = "cust_updt_cust"
        Me.cust_updt_cust.ReadOnly = True
        Me.cust_updt_cust.Visible = False
        '
        'cust_balpay
        '
        Me.cust_balpay.HeaderText = "cust_balpay"
        Me.cust_balpay.Name = "cust_balpay"
        Me.cust_balpay.ReadOnly = True
        Me.cust_balpay.Visible = False
        '
        'cust_report_acc_receive
        '
        Me.cust_report_acc_receive.HeaderText = "cust_report_acc_receive"
        Me.cust_report_acc_receive.Name = "cust_report_acc_receive"
        Me.cust_report_acc_receive.ReadOnly = True
        Me.cust_report_acc_receive.Visible = False
        '
        'cust_cash_trans
        '
        Me.cust_cash_trans.HeaderText = "cust_cash_trans"
        Me.cust_cash_trans.Name = "cust_cash_trans"
        Me.cust_cash_trans.ReadOnly = True
        Me.cust_cash_trans.Visible = False
        '
        'cust_return_trans
        '
        Me.cust_return_trans.HeaderText = "cust_return_trans"
        Me.cust_return_trans.Name = "cust_return_trans"
        Me.cust_return_trans.ReadOnly = True
        Me.cust_return_trans.Visible = False
        '
        'cust_bo_trans
        '
        Me.cust_bo_trans.HeaderText = "cust_bo_trans"
        Me.cust_bo_trans.Name = "cust_bo_trans"
        Me.cust_bo_trans.ReadOnly = True
        Me.cust_bo_trans.Visible = False
        '
        'supp_add_supp
        '
        Me.supp_add_supp.HeaderText = "supp_add_supp"
        Me.supp_add_supp.Name = "supp_add_supp"
        Me.supp_add_supp.ReadOnly = True
        Me.supp_add_supp.Visible = False
        '
        'supp_updt_supp
        '
        Me.supp_updt_supp.HeaderText = "supp_updt_supp"
        Me.supp_updt_supp.Name = "supp_updt_supp"
        Me.supp_updt_supp.ReadOnly = True
        Me.supp_updt_supp.Visible = False
        '
        'admin
        '
        Me.admin.HeaderText = "admin"
        Me.admin.Name = "admin"
        Me.admin.ReadOnly = True
        Me.admin.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_date, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel5, Me.ss_time_and_date, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel4, Me.ss_user, Me.ToolStripStatusLabel9, Me.ToolStripStatusLabel7, Me.ss_position})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 637)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(968, 22)
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
        'cmd_delete
        '
        Me.cmd_delete.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_delete.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_delete.ForeColor = System.Drawing.Color.White
        Me.cmd_delete.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_delete.Location = New System.Drawing.Point(252, 580)
        Me.cmd_delete.Name = "cmd_delete"
        Me.cmd_delete.Size = New System.Drawing.Size(92, 47)
        Me.cmd_delete.TabIndex = 3
        Me.cmd_delete.Text = "Delete"
        Me.cmd_delete.UseVisualStyleBackColor = False
        '
        'cmd_addnew
        '
        Me.cmd_addnew.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_addnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_addnew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_addnew.ForeColor = System.Drawing.Color.White
        Me.cmd_addnew.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_addnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_addnew.Location = New System.Drawing.Point(41, 580)
        Me.cmd_addnew.Name = "cmd_addnew"
        Me.cmd_addnew.Size = New System.Drawing.Size(92, 47)
        Me.cmd_addnew.TabIndex = 1
        Me.cmd_addnew.Text = "Add New"
        Me.cmd_addnew.UseVisualStyleBackColor = False
        '
        'frm_accounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(968, 659)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cmd_delete)
        Me.Controls.Add(Me.dgv_accounts)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmd_update)
        Me.Controls.Add(Me.cmd_addnew)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_accounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - User Accounts"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_accounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents cmd_update As System.Windows.Forms.Button
    Friend WithEvents cmd_addnew As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pic As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbl_account_no As System.Windows.Forms.Label
    Friend WithEvents lbl_lname As System.Windows.Forms.Label
    Friend WithEvents lbl_mname As System.Windows.Forms.Label
    Friend WithEvents lbl_fname As System.Windows.Forms.Label
    Friend WithEvents lbl_password As System.Windows.Forms.Label
    Friend WithEvents lbl_username As System.Windows.Forms.Label
    Friend WithEvents dgv_accounts As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_position As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmd_delete As System.Windows.Forms.Button
    Friend WithEvents lbl_admin As System.Windows.Forms.Label
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
    Friend WithEvents cb_supp_updt_supp As System.Windows.Forms.CheckBox
    Friend WithEvents cb_supp_add_supp As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cb_cust_bo As System.Windows.Forms.CheckBox
    Friend WithEvents cb_cust_sales_ret As System.Windows.Forms.CheckBox
    Friend WithEvents cb_cust_report_arpay As System.Windows.Forms.CheckBox
    Friend WithEvents cb_cust_cash_trans As System.Windows.Forms.CheckBox
    Friend WithEvents cb_cust_balpay As System.Windows.Forms.CheckBox
    Friend WithEvents cb_cust_updt_cust As System.Windows.Forms.CheckBox
    Friend WithEvents cb_cust_add_cust As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cb_sales_report_incstate As System.Windows.Forms.CheckBox
    Friend WithEvents cb_sales_report_dailyremit As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cb_inv_report_pur As System.Windows.Forms.CheckBox
    Friend WithEvents cb_inv_report_sales As System.Windows.Forms.CheckBox
    Friend WithEvents cb_inv_report_inv As System.Windows.Forms.CheckBox
    Friend WithEvents cb_inv_pur_ret As System.Windows.Forms.CheckBox
    Friend WithEvents cb_inv_updt_item As System.Windows.Forms.CheckBox
    Friend WithEvents cb_inv_add_item As System.Windows.Forms.CheckBox
    Friend WithEvents cb_inv_add_stocks As System.Windows.Forms.CheckBox
    Friend WithEvents cb_inv_brands As System.Windows.Forms.CheckBox
    Friend WithEvents cb_inv_category As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cb_pos_receipt As System.Windows.Forms.CheckBox
    Friend WithEvents cb_pos_sales_trans As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents account_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents username As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents password As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents position As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents first_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents middle_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents last_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pos_sales_trans As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pos_receipt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inv_category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inv_brands As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inv_add_item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inv_updt_item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inv_add_stocks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inv_purchase_return As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inv_report_inv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inv_report_pur As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inv_report_sales As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sales_report_remit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sales_report_incstate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_add_cust As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_updt_cust As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_balpay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_report_acc_receive As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_cash_trans As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_return_trans As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cust_bo_trans As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supp_add_supp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supp_updt_supp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents admin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmd_trans_history As System.Windows.Forms.Button
End Class
