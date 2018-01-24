<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_suppliers
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmd_update = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_trans_title = New System.Windows.Forms.Label()
        Me.lbl_supplier_no = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmd_pur_returns = New System.Windows.Forms.Button()
        Me.cmd_pur_trans = New System.Windows.Forms.Button()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.lbl_contact_no = New System.Windows.Forms.Label()
        Me.lbl_supplier_name = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_suppliers = New System.Windows.Forms.DataGridView()
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
        Me.cmd_addnew = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmd_clear = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbo_search_by = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelManager1 = New Marisha_POS.Controls.PanelManager()
        Me.pnl_pur_trans = New Marisha_POS.Controls.ManagedPanel()
        Me.cmd_pur_set = New System.Windows.Forms.Button()
        Me.lbl_trans_no = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgv_purchase_trans = New System.Windows.Forms.DataGridView()
        Me.trans_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ref_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supp_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supp_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grand_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_show_details = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dtp_purchase_trans_from = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp_purchase_trans_to = New System.Windows.Forms.DateTimePicker()
        Me.cmd_filter_trans = New System.Windows.Forms.Button()
        Me.pnl_pur_returns = New Marisha_POS.Controls.ManagedPanel()
        Me.cmd_ret_set = New System.Windows.Forms.Button()
        Me.lbl_pur_ret_no = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgv_purchase_returns = New System.Windows.Forms.DataGridView()
        Me.ret_trans_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ret_trans_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ret_ref_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ret_supp_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ret_supp_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ret_sub_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ret_grand_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_show_details_ret = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dtp_purchase_ret_from = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtp_purchase_ret_to = New System.Windows.Forms.DateTimePicker()
        Me.cmd_filter_ret = New System.Windows.Forms.Button()
        Me.supplier_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplier_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contact_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_suppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelManager1.SuspendLayout()
        Me.pnl_pur_trans.SuspendLayout()
        CType(Me.dgv_purchase_trans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_pur_returns.SuspendLayout()
        CType(Me.dgv_purchase_returns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_update
        '
        Me.cmd_update.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_update.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_update.ForeColor = System.Drawing.Color.White
        Me.cmd_update.Location = New System.Drawing.Point(180, 499)
        Me.cmd_update.Name = "cmd_update"
        Me.cmd_update.Size = New System.Drawing.Size(90, 47)
        Me.cmd_update.TabIndex = 4
        Me.cmd_update.Text = "Update"
        Me.cmd_update.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1104, 66)
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
        Me.Button1.Location = New System.Drawing.Point(1006, 10)
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
        Me.lblTitle.Size = New System.Drawing.Size(128, 42)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Suppliers"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Address :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Contact No. :"
        '
        'lbl_trans_title
        '
        Me.lbl_trans_title.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_trans_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_trans_title.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_trans_title.ForeColor = System.Drawing.Color.White
        Me.lbl_trans_title.Location = New System.Drawing.Point(5, 172)
        Me.lbl_trans_title.Name = "lbl_trans_title"
        Me.lbl_trans_title.Size = New System.Drawing.Size(741, 35)
        Me.lbl_trans_title.TabIndex = 31
        Me.lbl_trans_title.Text = "    Purchase Transactions"
        Me.lbl_trans_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_supplier_no
        '
        Me.lbl_supplier_no.BackColor = System.Drawing.Color.White
        Me.lbl_supplier_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_supplier_no.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_supplier_no.Location = New System.Drawing.Point(127, 40)
        Me.lbl_supplier_no.Name = "lbl_supplier_no"
        Me.lbl_supplier_no.Size = New System.Drawing.Size(592, 22)
        Me.lbl_supplier_no.TabIndex = 30
        Me.lbl_supplier_no.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(741, 27)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Supplier Information"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.PanelManager1)
        Me.Panel2.Controls.Add(Me.cmd_pur_returns)
        Me.Panel2.Controls.Add(Me.cmd_pur_trans)
        Me.Panel2.Controls.Add(Me.lbl_address)
        Me.Panel2.Controls.Add(Me.lbl_contact_no)
        Me.Panel2.Controls.Add(Me.lbl_supplier_name)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lbl_trans_title)
        Me.Panel2.Controls.Add(Me.lbl_supplier_no)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(357, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(741, 553)
        Me.Panel2.TabIndex = 1
        '
        'cmd_pur_returns
        '
        Me.cmd_pur_returns.BackColor = System.Drawing.Color.White
        Me.cmd_pur_returns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_pur_returns.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_pur_returns.ForeColor = System.Drawing.Color.Black
        Me.cmd_pur_returns.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_pur_returns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_pur_returns.Location = New System.Drawing.Point(562, 174)
        Me.cmd_pur_returns.Name = "cmd_pur_returns"
        Me.cmd_pur_returns.Size = New System.Drawing.Size(169, 30)
        Me.cmd_pur_returns.TabIndex = 1
        Me.cmd_pur_returns.Text = "Purchase Returns"
        Me.cmd_pur_returns.UseVisualStyleBackColor = False
        '
        'cmd_pur_trans
        '
        Me.cmd_pur_trans.BackColor = System.Drawing.Color.White
        Me.cmd_pur_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_pur_trans.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_pur_trans.ForeColor = System.Drawing.Color.Black
        Me.cmd_pur_trans.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_pur_trans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_pur_trans.Location = New System.Drawing.Point(387, 174)
        Me.cmd_pur_trans.Name = "cmd_pur_trans"
        Me.cmd_pur_trans.Size = New System.Drawing.Size(169, 30)
        Me.cmd_pur_trans.TabIndex = 0
        Me.cmd_pur_trans.Text = "Purchase Transactions"
        Me.cmd_pur_trans.UseVisualStyleBackColor = False
        '
        'lbl_address
        '
        Me.lbl_address.BackColor = System.Drawing.Color.White
        Me.lbl_address.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_address.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.Location = New System.Drawing.Point(127, 133)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(592, 22)
        Me.lbl_address.TabIndex = 44
        Me.lbl_address.Text = " "
        Me.lbl_address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_contact_no
        '
        Me.lbl_contact_no.BackColor = System.Drawing.Color.White
        Me.lbl_contact_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_contact_no.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contact_no.Location = New System.Drawing.Point(127, 102)
        Me.lbl_contact_no.Name = "lbl_contact_no"
        Me.lbl_contact_no.Size = New System.Drawing.Size(592, 22)
        Me.lbl_contact_no.TabIndex = 43
        Me.lbl_contact_no.Text = " "
        Me.lbl_contact_no.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_supplier_name
        '
        Me.lbl_supplier_name.BackColor = System.Drawing.Color.White
        Me.lbl_supplier_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_supplier_name.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_supplier_name.Location = New System.Drawing.Point(127, 72)
        Me.lbl_supplier_name.Name = "lbl_supplier_name"
        Me.lbl_supplier_name.Size = New System.Drawing.Size(592, 22)
        Me.lbl_supplier_name.TabIndex = 42
        Me.lbl_supplier_name.Text = " "
        Me.lbl_supplier_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Supplier Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Supplier No. :"
        '
        'dgv_suppliers
        '
        Me.dgv_suppliers.AllowUserToAddRows = False
        Me.dgv_suppliers.AllowUserToDeleteRows = False
        Me.dgv_suppliers.AllowUserToResizeRows = False
        Me.dgv_suppliers.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_suppliers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_suppliers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_suppliers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_suppliers.ColumnHeadersHeight = 25
        Me.dgv_suppliers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.supplier_no, Me.supplier_name, Me.contact_no, Me.address})
        Me.dgv_suppliers.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_suppliers.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_suppliers.EnableHeadersVisualStyles = False
        Me.dgv_suppliers.Location = New System.Drawing.Point(4, 79)
        Me.dgv_suppliers.MultiSelect = False
        Me.dgv_suppliers.Name = "dgv_suppliers"
        Me.dgv_suppliers.ReadOnly = True
        Me.dgv_suppliers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_suppliers.RowHeadersVisible = False
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_suppliers.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_suppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_suppliers.Size = New System.Drawing.Size(337, 415)
        Me.dgv_suppliers.TabIndex = 37
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_date, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel5, Me.ss_time_and_date, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel4, Me.ss_user, Me.ToolStripStatusLabel9, Me.ToolStripStatusLabel7, Me.ss_position})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 636)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1103, 22)
        Me.StatusStrip1.TabIndex = 38
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
        'cmd_addnew
        '
        Me.cmd_addnew.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_addnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_addnew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_addnew.ForeColor = System.Drawing.Color.White
        Me.cmd_addnew.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_addnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_addnew.Location = New System.Drawing.Point(74, 499)
        Me.cmd_addnew.Name = "cmd_addnew"
        Me.cmd_addnew.Size = New System.Drawing.Size(92, 47)
        Me.cmd_addnew.TabIndex = 3
        Me.cmd_addnew.Text = "Add New"
        Me.cmd_addnew.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(346, 27)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Supplier List"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmd_clear
        '
        Me.cmd_clear.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_clear.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_clear.ForeColor = System.Drawing.Color.White
        Me.cmd_clear.Location = New System.Drawing.Point(272, 48)
        Me.cmd_clear.Name = "cmd_clear"
        Me.cmd_clear.Size = New System.Drawing.Size(69, 28)
        Me.cmd_clear.TabIndex = 2
        Me.cmd_clear.Text = "Clear"
        Me.cmd_clear.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(133, 30)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(112, 16)
        Me.Label24.TabIndex = 45
        Me.Label24.Text = "Enter Keyword.."
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(133, 49)
        Me.txt_search.MaxLength = 30
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(136, 26)
        Me.txt_search.TabIndex = 1
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(6, 32)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(82, 16)
        Me.Label23.TabIndex = 42
        Me.Label23.Text = "Search By :"
        '
        'cbo_search_by
        '
        Me.cbo_search_by.BackColor = System.Drawing.Color.Gainsboro
        Me.cbo_search_by.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_search_by.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_search_by.FormattingEnabled = True
        Me.cbo_search_by.Location = New System.Drawing.Point(7, 50)
        Me.cbo_search_by.Name = "cbo_search_by"
        Me.cbo_search_by.Size = New System.Drawing.Size(121, 24)
        Me.cbo_search_by.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.cmd_clear)
        Me.Panel3.Controls.Add(Me.cmd_update)
        Me.Panel3.Controls.Add(Me.dgv_suppliers)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.cmd_addnew)
        Me.Panel3.Controls.Add(Me.cbo_search_by)
        Me.Panel3.Controls.Add(Me.txt_search)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Location = New System.Drawing.Point(5, 73)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(346, 553)
        Me.Panel3.TabIndex = 0
        '
        'PanelManager1
        '
        Me.PanelManager1.Controls.Add(Me.pnl_pur_trans)
        Me.PanelManager1.Controls.Add(Me.pnl_pur_returns)
        Me.PanelManager1.Location = New System.Drawing.Point(4, 210)
        Me.PanelManager1.Name = "PanelManager1"
        Me.PanelManager1.SelectedIndex = 0
        Me.PanelManager1.SelectedPanel = Me.pnl_pur_trans
        Me.PanelManager1.Size = New System.Drawing.Size(734, 339)
        Me.PanelManager1.TabIndex = 50
        '
        'pnl_pur_trans
        '
        Me.pnl_pur_trans.Controls.Add(Me.cmd_pur_set)
        Me.pnl_pur_trans.Controls.Add(Me.lbl_trans_no)
        Me.pnl_pur_trans.Controls.Add(Me.Label5)
        Me.pnl_pur_trans.Controls.Add(Me.dgv_purchase_trans)
        Me.pnl_pur_trans.Controls.Add(Me.dtp_purchase_trans_from)
        Me.pnl_pur_trans.Controls.Add(Me.Label6)
        Me.pnl_pur_trans.Controls.Add(Me.dtp_purchase_trans_to)
        Me.pnl_pur_trans.Controls.Add(Me.cmd_filter_trans)
        Me.pnl_pur_trans.Location = New System.Drawing.Point(0, 0)
        Me.pnl_pur_trans.Name = "pnl_pur_trans"
        Me.pnl_pur_trans.Size = New System.Drawing.Size(734, 339)
        Me.pnl_pur_trans.Text = "ManagedPanel1"
        '
        'cmd_pur_set
        '
        Me.cmd_pur_set.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_pur_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_pur_set.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_pur_set.ForeColor = System.Drawing.Color.White
        Me.cmd_pur_set.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_pur_set.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_pur_set.Location = New System.Drawing.Point(458, 5)
        Me.cmd_pur_set.Name = "cmd_pur_set"
        Me.cmd_pur_set.Size = New System.Drawing.Size(67, 23)
        Me.cmd_pur_set.TabIndex = 48
        Me.cmd_pur_set.Text = "Set"
        Me.cmd_pur_set.UseVisualStyleBackColor = False
        '
        'lbl_trans_no
        '
        Me.lbl_trans_no.BackColor = System.Drawing.Color.White
        Me.lbl_trans_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_trans_no.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_trans_no.Location = New System.Drawing.Point(645, 6)
        Me.lbl_trans_no.Name = "lbl_trans_no"
        Me.lbl_trans_no.Size = New System.Drawing.Size(12, 22)
        Me.lbl_trans_no.TabIndex = 47
        Me.lbl_trans_no.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Show Records From :"
        '
        'dgv_purchase_trans
        '
        Me.dgv_purchase_trans.AllowUserToAddRows = False
        Me.dgv_purchase_trans.AllowUserToDeleteRows = False
        Me.dgv_purchase_trans.AllowUserToResizeRows = False
        Me.dgv_purchase_trans.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_purchase_trans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_purchase_trans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_purchase_trans.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_purchase_trans.ColumnHeadersHeight = 25
        Me.dgv_purchase_trans.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.trans_no, Me.trans_date, Me.ref_no, Me.supp_no, Me.supp_name, Me.sub_total, Me.total_discount, Me.grand_total, Me.btn_show_details})
        Me.dgv_purchase_trans.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_purchase_trans.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_purchase_trans.EnableHeadersVisualStyles = False
        Me.dgv_purchase_trans.Location = New System.Drawing.Point(2, 34)
        Me.dgv_purchase_trans.MultiSelect = False
        Me.dgv_purchase_trans.Name = "dgv_purchase_trans"
        Me.dgv_purchase_trans.ReadOnly = True
        Me.dgv_purchase_trans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_purchase_trans.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_purchase_trans.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_purchase_trans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_purchase_trans.Size = New System.Drawing.Size(730, 302)
        Me.dgv_purchase_trans.TabIndex = 45
        '
        'trans_no
        '
        Me.trans_no.HeaderText = "Trans. No."
        Me.trans_no.Name = "trans_no"
        Me.trans_no.ReadOnly = True
        Me.trans_no.Width = 90
        '
        'trans_date
        '
        Me.trans_date.HeaderText = "Date"
        Me.trans_date.Name = "trans_date"
        Me.trans_date.ReadOnly = True
        Me.trans_date.Width = 120
        '
        'ref_no
        '
        Me.ref_no.HeaderText = "Reference No."
        Me.ref_no.Name = "ref_no"
        Me.ref_no.ReadOnly = True
        Me.ref_no.Width = 110
        '
        'supp_no
        '
        Me.supp_no.HeaderText = "Supplier No."
        Me.supp_no.Name = "supp_no"
        Me.supp_no.ReadOnly = True
        Me.supp_no.Visible = False
        '
        'supp_name
        '
        Me.supp_name.HeaderText = "Supplier Name"
        Me.supp_name.Name = "supp_name"
        Me.supp_name.ReadOnly = True
        Me.supp_name.Visible = False
        '
        'sub_total
        '
        Me.sub_total.HeaderText = "Sub Total"
        Me.sub_total.Name = "sub_total"
        Me.sub_total.ReadOnly = True
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
        '
        'btn_show_details
        '
        Me.btn_show_details.HeaderText = "Show Details"
        Me.btn_show_details.Name = "btn_show_details"
        Me.btn_show_details.ReadOnly = True
        Me.btn_show_details.Text = "Show Details"
        Me.btn_show_details.UseColumnTextForButtonValue = True
        Me.btn_show_details.Width = 90
        '
        'dtp_purchase_trans_from
        '
        Me.dtp_purchase_trans_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_purchase_trans_from.Location = New System.Drawing.Point(137, 7)
        Me.dtp_purchase_trans_from.Name = "dtp_purchase_trans_from"
        Me.dtp_purchase_trans_from.Size = New System.Drawing.Size(98, 20)
        Me.dtp_purchase_trans_from.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(243, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "To :"
        '
        'dtp_purchase_trans_to
        '
        Me.dtp_purchase_trans_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_purchase_trans_to.Location = New System.Drawing.Point(274, 7)
        Me.dtp_purchase_trans_to.Name = "dtp_purchase_trans_to"
        Me.dtp_purchase_trans_to.Size = New System.Drawing.Size(98, 20)
        Me.dtp_purchase_trans_to.TabIndex = 1
        '
        'cmd_filter_trans
        '
        Me.cmd_filter_trans.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_filter_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_filter_trans.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_filter_trans.ForeColor = System.Drawing.Color.White
        Me.cmd_filter_trans.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_filter_trans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_filter_trans.Location = New System.Drawing.Point(385, 5)
        Me.cmd_filter_trans.Name = "cmd_filter_trans"
        Me.cmd_filter_trans.Size = New System.Drawing.Size(67, 23)
        Me.cmd_filter_trans.TabIndex = 0
        Me.cmd_filter_trans.Text = "Filter"
        Me.cmd_filter_trans.UseVisualStyleBackColor = False
        '
        'pnl_pur_returns
        '
        Me.pnl_pur_returns.Controls.Add(Me.cmd_ret_set)
        Me.pnl_pur_returns.Controls.Add(Me.lbl_pur_ret_no)
        Me.pnl_pur_returns.Controls.Add(Me.Label8)
        Me.pnl_pur_returns.Controls.Add(Me.dgv_purchase_returns)
        Me.pnl_pur_returns.Controls.Add(Me.dtp_purchase_ret_from)
        Me.pnl_pur_returns.Controls.Add(Me.Label9)
        Me.pnl_pur_returns.Controls.Add(Me.dtp_purchase_ret_to)
        Me.pnl_pur_returns.Controls.Add(Me.cmd_filter_ret)
        Me.pnl_pur_returns.Location = New System.Drawing.Point(0, 0)
        Me.pnl_pur_returns.Name = "pnl_pur_returns"
        Me.pnl_pur_returns.Size = New System.Drawing.Size(0, 0)
        Me.pnl_pur_returns.Text = "ManagedPanel2"
        '
        'cmd_ret_set
        '
        Me.cmd_ret_set.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_ret_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_ret_set.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ret_set.ForeColor = System.Drawing.Color.White
        Me.cmd_ret_set.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_ret_set.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_ret_set.Location = New System.Drawing.Point(458, 5)
        Me.cmd_ret_set.Name = "cmd_ret_set"
        Me.cmd_ret_set.Size = New System.Drawing.Size(67, 23)
        Me.cmd_ret_set.TabIndex = 56
        Me.cmd_ret_set.Text = "Set"
        Me.cmd_ret_set.UseVisualStyleBackColor = False
        '
        'lbl_pur_ret_no
        '
        Me.lbl_pur_ret_no.BackColor = System.Drawing.Color.White
        Me.lbl_pur_ret_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_pur_ret_no.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pur_ret_no.Location = New System.Drawing.Point(718, 7)
        Me.lbl_pur_ret_no.Name = "lbl_pur_ret_no"
        Me.lbl_pur_ret_no.Size = New System.Drawing.Size(12, 22)
        Me.lbl_pur_ret_no.TabIndex = 55
        Me.lbl_pur_ret_no.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Show Records From :"
        '
        'dgv_purchase_returns
        '
        Me.dgv_purchase_returns.AllowUserToAddRows = False
        Me.dgv_purchase_returns.AllowUserToDeleteRows = False
        Me.dgv_purchase_returns.AllowUserToResizeRows = False
        Me.dgv_purchase_returns.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_purchase_returns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_purchase_returns.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_purchase_returns.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_purchase_returns.ColumnHeadersHeight = 25
        Me.dgv_purchase_returns.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ret_trans_no, Me.ret_trans_date, Me.ret_ref_no, Me.ret_supp_no, Me.ret_supp_name, Me.ret_sub_total, Me.ret_grand_total, Me.btn_show_details_ret})
        Me.dgv_purchase_returns.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_purchase_returns.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_purchase_returns.EnableHeadersVisualStyles = False
        Me.dgv_purchase_returns.Location = New System.Drawing.Point(2, 34)
        Me.dgv_purchase_returns.MultiSelect = False
        Me.dgv_purchase_returns.Name = "dgv_purchase_returns"
        Me.dgv_purchase_returns.ReadOnly = True
        Me.dgv_purchase_returns.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_purchase_returns.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_purchase_returns.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_purchase_returns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_purchase_returns.Size = New System.Drawing.Size(729, 302)
        Me.dgv_purchase_returns.TabIndex = 53
        '
        'ret_trans_no
        '
        Me.ret_trans_no.HeaderText = "Trans. No."
        Me.ret_trans_no.Name = "ret_trans_no"
        Me.ret_trans_no.ReadOnly = True
        Me.ret_trans_no.Width = 90
        '
        'ret_trans_date
        '
        Me.ret_trans_date.HeaderText = "Date"
        Me.ret_trans_date.Name = "ret_trans_date"
        Me.ret_trans_date.ReadOnly = True
        Me.ret_trans_date.Width = 130
        '
        'ret_ref_no
        '
        Me.ret_ref_no.HeaderText = "Reference No."
        Me.ret_ref_no.Name = "ret_ref_no"
        Me.ret_ref_no.ReadOnly = True
        Me.ret_ref_no.Width = 150
        '
        'ret_supp_no
        '
        Me.ret_supp_no.HeaderText = "Supplier No."
        Me.ret_supp_no.Name = "ret_supp_no"
        Me.ret_supp_no.ReadOnly = True
        Me.ret_supp_no.Visible = False
        '
        'ret_supp_name
        '
        Me.ret_supp_name.HeaderText = "Supplier Name"
        Me.ret_supp_name.Name = "ret_supp_name"
        Me.ret_supp_name.ReadOnly = True
        Me.ret_supp_name.Visible = False
        '
        'ret_sub_total
        '
        Me.ret_sub_total.HeaderText = "Sub Total"
        Me.ret_sub_total.Name = "ret_sub_total"
        Me.ret_sub_total.ReadOnly = True
        '
        'ret_grand_total
        '
        Me.ret_grand_total.HeaderText = "Grand Total"
        Me.ret_grand_total.Name = "ret_grand_total"
        Me.ret_grand_total.ReadOnly = True
        '
        'btn_show_details_ret
        '
        Me.btn_show_details_ret.HeaderText = "Show Details"
        Me.btn_show_details_ret.Name = "btn_show_details_ret"
        Me.btn_show_details_ret.ReadOnly = True
        Me.btn_show_details_ret.Text = "Show Details"
        Me.btn_show_details_ret.UseColumnTextForButtonValue = True
        '
        'dtp_purchase_ret_from
        '
        Me.dtp_purchase_ret_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_purchase_ret_from.Location = New System.Drawing.Point(137, 7)
        Me.dtp_purchase_ret_from.Name = "dtp_purchase_ret_from"
        Me.dtp_purchase_ret_from.Size = New System.Drawing.Size(98, 20)
        Me.dtp_purchase_ret_from.TabIndex = 48
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(243, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "To :"
        '
        'dtp_purchase_ret_to
        '
        Me.dtp_purchase_ret_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_purchase_ret_to.Location = New System.Drawing.Point(274, 7)
        Me.dtp_purchase_ret_to.Name = "dtp_purchase_ret_to"
        Me.dtp_purchase_ret_to.Size = New System.Drawing.Size(98, 20)
        Me.dtp_purchase_ret_to.TabIndex = 49
        '
        'cmd_filter_ret
        '
        Me.cmd_filter_ret.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_filter_ret.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_filter_ret.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_filter_ret.ForeColor = System.Drawing.Color.White
        Me.cmd_filter_ret.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_filter_ret.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_filter_ret.Location = New System.Drawing.Point(385, 5)
        Me.cmd_filter_ret.Name = "cmd_filter_ret"
        Me.cmd_filter_ret.Size = New System.Drawing.Size(67, 23)
        Me.cmd_filter_ret.TabIndex = 50
        Me.cmd_filter_ret.Text = "Filter"
        Me.cmd_filter_ret.UseVisualStyleBackColor = False
        '
        'supplier_no
        '
        Me.supplier_no.HeaderText = "Supplier No."
        Me.supplier_no.Name = "supplier_no"
        Me.supplier_no.ReadOnly = True
        Me.supplier_no.Width = 80
        '
        'supplier_name
        '
        Me.supplier_name.HeaderText = "Supplier Name"
        Me.supplier_name.Name = "supplier_name"
        Me.supplier_name.ReadOnly = True
        Me.supplier_name.Width = 240
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
        'frm_suppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1103, 658)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_suppliers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - Suppliers"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgv_suppliers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PanelManager1.ResumeLayout(False)
        Me.pnl_pur_trans.ResumeLayout(False)
        Me.pnl_pur_trans.PerformLayout()
        CType(Me.dgv_purchase_trans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_pur_returns.ResumeLayout(False)
        Me.pnl_pur_returns.PerformLayout()
        CType(Me.dgv_purchase_returns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtp_purchase_trans_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtp_purchase_trans_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmd_update As System.Windows.Forms.Button
    Friend WithEvents cmd_filter_trans As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_trans_title As System.Windows.Forms.Label
    Friend WithEvents lbl_supplier_no As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmd_addnew As System.Windows.Forms.Button
    Friend WithEvents dgv_suppliers As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_address As System.Windows.Forms.Label
    Friend WithEvents lbl_contact_no As System.Windows.Forms.Label
    Friend WithEvents lbl_supplier_name As System.Windows.Forms.Label
    Friend WithEvents dgv_purchase_trans As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_trans_no As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents st_date As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ss_time_and_date As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ss_user As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ss_position As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel9 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmd_pur_returns As System.Windows.Forms.Button
    Friend WithEvents cmd_pur_trans As System.Windows.Forms.Button
    Friend WithEvents PanelManager1 As Marisha_POS.Controls.PanelManager
    Friend WithEvents pnl_pur_trans As Marisha_POS.Controls.ManagedPanel
    Friend WithEvents pnl_pur_returns As Marisha_POS.Controls.ManagedPanel
    Friend WithEvents lbl_pur_ret_no As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgv_purchase_returns As System.Windows.Forms.DataGridView
    Friend WithEvents dtp_purchase_ret_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtp_purchase_ret_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmd_filter_ret As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmd_clear As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cbo_search_by As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents trans_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ref_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supp_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supp_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sub_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_discount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grand_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_show_details As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ret_trans_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ret_trans_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ret_ref_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ret_supp_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ret_supp_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ret_sub_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ret_grand_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_show_details_ret As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cmd_pur_set As System.Windows.Forms.Button
    Friend WithEvents cmd_ret_set As System.Windows.Forms.Button
    Friend WithEvents supplier_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supplier_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contact_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents address As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
