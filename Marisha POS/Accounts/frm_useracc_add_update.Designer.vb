<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_useracc_add_update
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_old_username = New System.Windows.Forms.TextBox()
        Me.lbl_account_no = New System.Windows.Forms.Label()
        Me.txt_position = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmd_loadpic = New System.Windows.Forms.Button()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_mname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmd_cancel = New System.Windows.Forms.Button()
        Me.cmd_save = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1141, 66)
        Me.Panel1.TabIndex = 29
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(3, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(265, 42)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Add a User Account"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.txt_old_username)
        Me.Panel2.Controls.Add(Me.lbl_account_no)
        Me.Panel2.Controls.Add(Me.txt_position)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cmd_loadpic)
        Me.Panel2.Controls.Add(Me.pic)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txt_fname)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txt_lname)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txt_mname)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txt_password)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txt_username)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(5, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(546, 323)
        Me.Panel2.TabIndex = 0
        '
        'txt_old_username
        '
        Me.txt_old_username.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_old_username.Location = New System.Drawing.Point(178, 83)
        Me.txt_old_username.MaxLength = 20
        Me.txt_old_username.Name = "txt_old_username"
        Me.txt_old_username.Size = New System.Drawing.Size(25, 26)
        Me.txt_old_username.TabIndex = 39
        Me.txt_old_username.Visible = False
        '
        'lbl_account_no
        '
        Me.lbl_account_no.BackColor = System.Drawing.Color.White
        Me.lbl_account_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_account_no.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_account_no.Location = New System.Drawing.Point(317, 53)
        Me.lbl_account_no.Name = "lbl_account_no"
        Me.lbl_account_no.Size = New System.Drawing.Size(209, 22)
        Me.lbl_account_no.TabIndex = 38
        Me.lbl_account_no.Text = " "
        Me.lbl_account_no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_position
        '
        Me.txt_position.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_position.Location = New System.Drawing.Point(317, 146)
        Me.txt_position.MaxLength = 20
        Me.txt_position.Name = "txt_position"
        Me.txt_position.Size = New System.Drawing.Size(209, 26)
        Me.txt_position.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(203, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 18)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Position :"
        '
        'cmd_loadpic
        '
        Me.cmd_loadpic.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_loadpic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_loadpic.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_loadpic.ForeColor = System.Drawing.Color.White
        Me.cmd_loadpic.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_loadpic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_loadpic.Location = New System.Drawing.Point(16, 192)
        Me.cmd_loadpic.Name = "cmd_loadpic"
        Me.cmd_loadpic.Size = New System.Drawing.Size(155, 31)
        Me.cmd_loadpic.TabIndex = 6
        Me.cmd_loadpic.Text = "Load Picture"
        Me.cmd_loadpic.UseVisualStyleBackColor = False
        '
        'pic
        '
        Me.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic.Location = New System.Drawing.Point(16, 52)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(155, 134)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic.TabIndex = 23
        Me.pic.TabStop = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(546, 27)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Account Information"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_fname
        '
        Me.txt_fname.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname.Location = New System.Drawing.Point(317, 198)
        Me.txt_fname.MaxLength = 20
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(209, 26)
        Me.txt_fname.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(202, 233)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 18)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Middle Name :"
        '
        'txt_lname
        '
        Me.txt_lname.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lname.Location = New System.Drawing.Point(317, 262)
        Me.txt_lname.MaxLength = 20
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(209, 26)
        Me.txt_lname.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(202, 265)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 18)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Last Name :"
        '
        'txt_mname
        '
        Me.txt_mname.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mname.Location = New System.Drawing.Point(317, 230)
        Me.txt_mname.MaxLength = 20
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.Size = New System.Drawing.Size(209, 26)
        Me.txt_mname.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(203, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "First Name :"
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(317, 114)
        Me.txt_password.MaxLength = 20
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(209, 26)
        Me.txt_password.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(203, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Password :"
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(317, 83)
        Me.txt_username.MaxLength = 20
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(209, 26)
        Me.txt_username.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(203, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Username :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(203, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Account No. :"
        '
        'cmd_cancel
        '
        Me.cmd_cancel.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_cancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_cancel.ForeColor = System.Drawing.Color.White
        Me.cmd_cancel.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_cancel.Location = New System.Drawing.Point(936, 405)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(193, 47)
        Me.cmd_cancel.TabIndex = 2
        Me.cmd_cancel.Text = "Cancel"
        Me.cmd_cancel.UseVisualStyleBackColor = False
        '
        'cmd_save
        '
        Me.cmd_save.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_save.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_save.ForeColor = System.Drawing.Color.White
        Me.cmd_save.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_save.Location = New System.Drawing.Point(714, 405)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.Size = New System.Drawing.Size(210, 47)
        Me.cmd_save.TabIndex = 1
        Me.cmd_save.Text = "Save"
        Me.cmd_save.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.cb_supp_updt_supp)
        Me.Panel3.Controls.Add(Me.cb_supp_add_supp)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.cb_cust_bo)
        Me.Panel3.Controls.Add(Me.cb_cust_sales_ret)
        Me.Panel3.Controls.Add(Me.cb_cust_report_arpay)
        Me.Panel3.Controls.Add(Me.cb_cust_cash_trans)
        Me.Panel3.Controls.Add(Me.cb_cust_balpay)
        Me.Panel3.Controls.Add(Me.cb_cust_updt_cust)
        Me.Panel3.Controls.Add(Me.cb_cust_add_cust)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.cb_sales_report_incstate)
        Me.Panel3.Controls.Add(Me.cb_sales_report_dailyremit)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.cb_inv_report_pur)
        Me.Panel3.Controls.Add(Me.cb_inv_report_sales)
        Me.Panel3.Controls.Add(Me.cb_inv_report_inv)
        Me.Panel3.Controls.Add(Me.cb_inv_pur_ret)
        Me.Panel3.Controls.Add(Me.cb_inv_updt_item)
        Me.Panel3.Controls.Add(Me.cb_inv_add_item)
        Me.Panel3.Controls.Add(Me.cb_inv_add_stocks)
        Me.Panel3.Controls.Add(Me.cb_inv_brands)
        Me.Panel3.Controls.Add(Me.cb_inv_category)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.cb_pos_receipt)
        Me.Panel3.Controls.Add(Me.cb_pos_sales_trans)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Location = New System.Drawing.Point(557, 72)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(572, 323)
        Me.Panel3.TabIndex = 30
        '
        'cb_supp_updt_supp
        '
        Me.cb_supp_updt_supp.AutoSize = True
        Me.cb_supp_updt_supp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_supp_updt_supp.Location = New System.Drawing.Point(20, 262)
        Me.cb_supp_updt_supp.Name = "cb_supp_updt_supp"
        Me.cb_supp_updt_supp.Size = New System.Drawing.Size(143, 18)
        Me.cb_supp_updt_supp.TabIndex = 47
        Me.cb_supp_updt_supp.Text = "Update Supplier Info."
        Me.cb_supp_updt_supp.UseVisualStyleBackColor = True
        '
        'cb_supp_add_supp
        '
        Me.cb_supp_add_supp.AutoSize = True
        Me.cb_supp_add_supp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_supp_add_supp.Location = New System.Drawing.Point(20, 238)
        Me.cb_supp_add_supp.Name = "cb_supp_add_supp"
        Me.cb_supp_add_supp.Size = New System.Drawing.Size(124, 18)
        Me.cb_supp_add_supp.TabIndex = 48
        Me.cb_supp_add_supp.Text = "Add New Supplier"
        Me.cb_supp_add_supp.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(17, 216)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 14)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "SUPPLIERS"
        '
        'cb_cust_bo
        '
        Me.cb_cust_bo.AutoSize = True
        Me.cb_cust_bo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cust_bo.Location = New System.Drawing.Point(379, 220)
        Me.cb_cust_bo.Name = "cb_cust_bo"
        Me.cb_cust_bo.Size = New System.Drawing.Size(50, 18)
        Me.cb_cust_bo.TabIndex = 45
        Me.cb_cust_bo.Text = "B.O."
        Me.cb_cust_bo.UseVisualStyleBackColor = True
        '
        'cb_cust_sales_ret
        '
        Me.cb_cust_sales_ret.AutoSize = True
        Me.cb_cust_sales_ret.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cust_sales_ret.Location = New System.Drawing.Point(379, 148)
        Me.cb_cust_sales_ret.Name = "cb_cust_sales_ret"
        Me.cb_cust_sales_ret.Size = New System.Drawing.Size(94, 18)
        Me.cb_cust_sales_ret.TabIndex = 44
        Me.cb_cust_sales_ret.Text = "Sales Return"
        Me.cb_cust_sales_ret.UseVisualStyleBackColor = True
        '
        'cb_cust_report_arpay
        '
        Me.cb_cust_report_arpay.AutoSize = True
        Me.cb_cust_report_arpay.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cust_report_arpay.Location = New System.Drawing.Point(379, 196)
        Me.cb_cust_report_arpay.Name = "cb_cust_report_arpay"
        Me.cb_cust_report_arpay.Size = New System.Drawing.Size(139, 18)
        Me.cb_cust_report_arpay.TabIndex = 43
        Me.cb_cust_report_arpay.Text = "AR Payments Report"
        Me.cb_cust_report_arpay.UseVisualStyleBackColor = True
        '
        'cb_cust_cash_trans
        '
        Me.cb_cust_cash_trans.AutoSize = True
        Me.cb_cust_cash_trans.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cust_cash_trans.Location = New System.Drawing.Point(379, 124)
        Me.cb_cust_cash_trans.Name = "cb_cust_cash_trans"
        Me.cb_cust_cash_trans.Size = New System.Drawing.Size(117, 18)
        Me.cb_cust_cash_trans.TabIndex = 42
        Me.cb_cust_cash_trans.Text = "Cash Transctions"
        Me.cb_cust_cash_trans.UseVisualStyleBackColor = True
        '
        'cb_cust_balpay
        '
        Me.cb_cust_balpay.AutoSize = True
        Me.cb_cust_balpay.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cust_balpay.Location = New System.Drawing.Point(379, 172)
        Me.cb_cust_balpay.Name = "cb_cust_balpay"
        Me.cb_cust_balpay.Size = New System.Drawing.Size(175, 18)
        Me.cb_cust_balpay.TabIndex = 41
        Me.cb_cust_balpay.Text = "Customer Balance Payment"
        Me.cb_cust_balpay.UseVisualStyleBackColor = True
        '
        'cb_cust_updt_cust
        '
        Me.cb_cust_updt_cust.AutoSize = True
        Me.cb_cust_updt_cust.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cust_updt_cust.Location = New System.Drawing.Point(379, 100)
        Me.cb_cust_updt_cust.Name = "cb_cust_updt_cust"
        Me.cb_cust_updt_cust.Size = New System.Drawing.Size(152, 18)
        Me.cb_cust_updt_cust.TabIndex = 40
        Me.cb_cust_updt_cust.Text = "Update Customer Info."
        Me.cb_cust_updt_cust.UseVisualStyleBackColor = True
        '
        'cb_cust_add_cust
        '
        Me.cb_cust_add_cust.AutoSize = True
        Me.cb_cust_add_cust.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cust_add_cust.Location = New System.Drawing.Point(379, 76)
        Me.cb_cust_add_cust.Name = "cb_cust_add_cust"
        Me.cb_cust_add_cust.Size = New System.Drawing.Size(133, 18)
        Me.cb_cust_add_cust.TabIndex = 39
        Me.cb_cust_add_cust.Text = "Add New Customer"
        Me.cb_cust_add_cust.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(376, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 14)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "CUSTOMERS"
        '
        'cb_sales_report_incstate
        '
        Me.cb_sales_report_incstate.AutoSize = True
        Me.cb_sales_report_incstate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_sales_report_incstate.Location = New System.Drawing.Point(20, 180)
        Me.cb_sales_report_incstate.Name = "cb_sales_report_incstate"
        Me.cb_sales_report_incstate.Size = New System.Drawing.Size(130, 18)
        Me.cb_sales_report_incstate.TabIndex = 36
        Me.cb_sales_report_incstate.Text = "Income Statement"
        Me.cb_sales_report_incstate.UseVisualStyleBackColor = True
        '
        'cb_sales_report_dailyremit
        '
        Me.cb_sales_report_dailyremit.AutoSize = True
        Me.cb_sales_report_dailyremit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_sales_report_dailyremit.Location = New System.Drawing.Point(20, 156)
        Me.cb_sales_report_dailyremit.Name = "cb_sales_report_dailyremit"
        Me.cb_sales_report_dailyremit.Size = New System.Drawing.Size(162, 18)
        Me.cb_sales_report_dailyremit.TabIndex = 37
        Me.cb_sales_report_dailyremit.Text = "Daily Remittances Report"
        Me.cb_sales_report_dailyremit.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 14)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "SALES"
        '
        'cb_inv_report_pur
        '
        Me.cb_inv_report_pur.AutoSize = True
        Me.cb_inv_report_pur.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_inv_report_pur.Location = New System.Drawing.Point(206, 268)
        Me.cb_inv_report_pur.Name = "cb_inv_report_pur"
        Me.cb_inv_report_pur.Size = New System.Drawing.Size(151, 18)
        Me.cb_inv_report_pur.TabIndex = 34
        Me.cb_inv_report_pur.Text = "Item Purchases Report"
        Me.cb_inv_report_pur.UseVisualStyleBackColor = True
        '
        'cb_inv_report_sales
        '
        Me.cb_inv_report_sales.AutoSize = True
        Me.cb_inv_report_sales.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_inv_report_sales.Location = New System.Drawing.Point(206, 220)
        Me.cb_inv_report_sales.Name = "cb_inv_report_sales"
        Me.cb_inv_report_sales.Size = New System.Drawing.Size(124, 18)
        Me.cb_inv_report_sales.TabIndex = 33
        Me.cb_inv_report_sales.Text = "Item Sales Report"
        Me.cb_inv_report_sales.UseVisualStyleBackColor = True
        '
        'cb_inv_report_inv
        '
        Me.cb_inv_report_inv.AutoSize = True
        Me.cb_inv_report_inv.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_inv_report_inv.Location = New System.Drawing.Point(206, 244)
        Me.cb_inv_report_inv.Name = "cb_inv_report_inv"
        Me.cb_inv_report_inv.Size = New System.Drawing.Size(120, 18)
        Me.cb_inv_report_inv.TabIndex = 32
        Me.cb_inv_report_inv.Text = "Inventory Report"
        Me.cb_inv_report_inv.UseVisualStyleBackColor = True
        '
        'cb_inv_pur_ret
        '
        Me.cb_inv_pur_ret.AutoSize = True
        Me.cb_inv_pur_ret.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_inv_pur_ret.Location = New System.Drawing.Point(206, 196)
        Me.cb_inv_pur_ret.Name = "cb_inv_pur_ret"
        Me.cb_inv_pur_ret.Size = New System.Drawing.Size(121, 18)
        Me.cb_inv_pur_ret.TabIndex = 31
        Me.cb_inv_pur_ret.Text = "Purchase Returns"
        Me.cb_inv_pur_ret.UseVisualStyleBackColor = True
        '
        'cb_inv_updt_item
        '
        Me.cb_inv_updt_item.AutoSize = True
        Me.cb_inv_updt_item.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_inv_updt_item.Location = New System.Drawing.Point(206, 148)
        Me.cb_inv_updt_item.Name = "cb_inv_updt_item"
        Me.cb_inv_updt_item.Size = New System.Drawing.Size(126, 18)
        Me.cb_inv_updt_item.TabIndex = 30
        Me.cb_inv_updt_item.Text = "Update Item Info."
        Me.cb_inv_updt_item.UseVisualStyleBackColor = True
        '
        'cb_inv_add_item
        '
        Me.cb_inv_add_item.AutoSize = True
        Me.cb_inv_add_item.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_inv_add_item.Location = New System.Drawing.Point(206, 124)
        Me.cb_inv_add_item.Name = "cb_inv_add_item"
        Me.cb_inv_add_item.Size = New System.Drawing.Size(107, 18)
        Me.cb_inv_add_item.TabIndex = 28
        Me.cb_inv_add_item.Text = "Add New Item"
        Me.cb_inv_add_item.UseVisualStyleBackColor = True
        '
        'cb_inv_add_stocks
        '
        Me.cb_inv_add_stocks.AutoSize = True
        Me.cb_inv_add_stocks.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_inv_add_stocks.Location = New System.Drawing.Point(206, 172)
        Me.cb_inv_add_stocks.Name = "cb_inv_add_stocks"
        Me.cb_inv_add_stocks.Size = New System.Drawing.Size(88, 18)
        Me.cb_inv_add_stocks.TabIndex = 29
        Me.cb_inv_add_stocks.Text = "Add Stocks"
        Me.cb_inv_add_stocks.UseVisualStyleBackColor = True
        '
        'cb_inv_brands
        '
        Me.cb_inv_brands.AutoSize = True
        Me.cb_inv_brands.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_inv_brands.Location = New System.Drawing.Point(206, 100)
        Me.cb_inv_brands.Name = "cb_inv_brands"
        Me.cb_inv_brands.Size = New System.Drawing.Size(92, 18)
        Me.cb_inv_brands.TabIndex = 26
        Me.cb_inv_brands.Text = "Item Brands"
        Me.cb_inv_brands.UseVisualStyleBackColor = True
        '
        'cb_inv_category
        '
        Me.cb_inv_category.AutoSize = True
        Me.cb_inv_category.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_inv_category.Location = New System.Drawing.Point(206, 76)
        Me.cb_inv_category.Name = "cb_inv_category"
        Me.cb_inv_category.Size = New System.Drawing.Size(113, 18)
        Me.cb_inv_category.TabIndex = 27
        Me.cb_inv_category.Text = "Item Categories"
        Me.cb_inv_category.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(203, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 14)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "INVENTORY"
        '
        'cb_pos_receipt
        '
        Me.cb_pos_receipt.AutoSize = True
        Me.cb_pos_receipt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_pos_receipt.Location = New System.Drawing.Point(20, 99)
        Me.cb_pos_receipt.Name = "cb_pos_receipt"
        Me.cb_pos_receipt.Size = New System.Drawing.Size(116, 18)
        Me.cb_pos_receipt.TabIndex = 23
        Me.cb_pos_receipt.Text = "Receipt Settings"
        Me.cb_pos_receipt.UseVisualStyleBackColor = True
        '
        'cb_pos_sales_trans
        '
        Me.cb_pos_sales_trans.AutoSize = True
        Me.cb_pos_sales_trans.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_pos_sales_trans.Location = New System.Drawing.Point(20, 75)
        Me.cb_pos_sales_trans.Name = "cb_pos_sales_trans"
        Me.cb_pos_sales_trans.Size = New System.Drawing.Size(120, 18)
        Me.cb_pos_sales_trans.TabIndex = 24
        Me.cb_pos_sales_trans.Text = "Sales Transaction"
        Me.cb_pos_sales_trans.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 14)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "POS"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(583, 27)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Account Access"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_useracc_add_update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1137, 460)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.cmd_save)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_useracc_add_update"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - User Accounts"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pic As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_fname As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_lname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_mname As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmd_loadpic As System.Windows.Forms.Button
    Friend WithEvents cmd_cancel As System.Windows.Forms.Button
    Friend WithEvents cmd_save As System.Windows.Forms.Button
    Friend WithEvents txt_position As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_account_no As System.Windows.Forms.Label
    Friend WithEvents txt_old_username As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cb_pos_receipt As System.Windows.Forms.CheckBox
    Friend WithEvents cb_pos_sales_trans As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cb_inv_brands As System.Windows.Forms.CheckBox
    Friend WithEvents cb_inv_category As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cb_inv_add_item As System.Windows.Forms.CheckBox
    Friend WithEvents cb_inv_add_stocks As System.Windows.Forms.CheckBox
    Friend WithEvents cb_inv_updt_item As System.Windows.Forms.CheckBox
    Friend WithEvents cb_inv_pur_ret As System.Windows.Forms.CheckBox
    Friend WithEvents cb_inv_report_sales As System.Windows.Forms.CheckBox
    Friend WithEvents cb_inv_report_inv As System.Windows.Forms.CheckBox
    Friend WithEvents cb_inv_report_pur As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cb_sales_report_incstate As System.Windows.Forms.CheckBox
    Friend WithEvents cb_sales_report_dailyremit As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cb_cust_updt_cust As System.Windows.Forms.CheckBox
    Friend WithEvents cb_cust_add_cust As System.Windows.Forms.CheckBox
    Friend WithEvents cb_cust_cash_trans As System.Windows.Forms.CheckBox
    Friend WithEvents cb_cust_balpay As System.Windows.Forms.CheckBox
    Friend WithEvents cb_cust_report_arpay As System.Windows.Forms.CheckBox
    Friend WithEvents cb_cust_bo As System.Windows.Forms.CheckBox
    Friend WithEvents cb_cust_sales_ret As System.Windows.Forms.CheckBox
    Friend WithEvents cb_supp_updt_supp As System.Windows.Forms.CheckBox
    Friend WithEvents cb_supp_add_supp As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
