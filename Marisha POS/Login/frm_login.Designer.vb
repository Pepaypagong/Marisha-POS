<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgv_items = New System.Windows.Forms.DataGridView()
        Me.item_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selling_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buying_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.avail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.beg_inv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.beg_inv_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmd_enter = New System.Windows.Forms.Button()
        Me.cmd_exit = New System.Windows.Forms.Button()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_customers = New System.Windows.Forms.DataGridView()
        Me.customer_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.first_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.middle_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.last_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contact_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_items, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_customers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.dgv_items)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(434, 115)
        Me.Panel1.TabIndex = 0
        '
        'dgv_items
        '
        Me.dgv_items.AllowUserToAddRows = False
        Me.dgv_items.AllowUserToDeleteRows = False
        Me.dgv_items.AllowUserToResizeRows = False
        Me.dgv_items.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_items.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_items.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_items.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_items.ColumnHeadersHeight = 25
        Me.dgv_items.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item_no, Me.barcode, Me.item_name, Me.selling_price, Me.buying_price, Me.avail, Me.stock_qty, Me.description, Me.category, Me.brand, Me.beg_inv, Me.beg_inv_price, Me.unit})
        Me.dgv_items.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_items.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_items.EnableHeadersVisualStyles = False
        Me.dgv_items.Location = New System.Drawing.Point(407, 5)
        Me.dgv_items.MultiSelect = False
        Me.dgv_items.Name = "dgv_items"
        Me.dgv_items.ReadOnly = True
        Me.dgv_items.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_items.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_items.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_items.Size = New System.Drawing.Size(13, 104)
        Me.dgv_items.TabIndex = 57
        Me.dgv_items.Visible = False
        '
        'item_no
        '
        Me.item_no.HeaderText = "Item No."
        Me.item_no.Name = "item_no"
        Me.item_no.ReadOnly = True
        Me.item_no.Width = 90
        '
        'barcode
        '
        Me.barcode.HeaderText = "Barcode"
        Me.barcode.Name = "barcode"
        Me.barcode.ReadOnly = True
        Me.barcode.Width = 120
        '
        'item_name
        '
        Me.item_name.HeaderText = "Item Name"
        Me.item_name.Name = "item_name"
        Me.item_name.ReadOnly = True
        Me.item_name.Width = 150
        '
        'selling_price
        '
        Me.selling_price.HeaderText = "Selling Price"
        Me.selling_price.Name = "selling_price"
        Me.selling_price.ReadOnly = True
        '
        'buying_price
        '
        Me.buying_price.HeaderText = "Purchase Price"
        Me.buying_price.Name = "buying_price"
        Me.buying_price.ReadOnly = True
        '
        'avail
        '
        Me.avail.HeaderText = "Availability"
        Me.avail.Name = "avail"
        Me.avail.ReadOnly = True
        Me.avail.Visible = False
        '
        'stock_qty
        '
        Me.stock_qty.HeaderText = "Stock Qty."
        Me.stock_qty.Name = "stock_qty"
        Me.stock_qty.ReadOnly = True
        '
        'description
        '
        Me.description.HeaderText = "Description"
        Me.description.Name = "description"
        Me.description.ReadOnly = True
        Me.description.Visible = False
        '
        'category
        '
        Me.category.HeaderText = "Category"
        Me.category.Name = "category"
        Me.category.ReadOnly = True
        '
        'brand
        '
        Me.brand.HeaderText = "Brand"
        Me.brand.Name = "brand"
        Me.brand.ReadOnly = True
        '
        'beg_inv
        '
        Me.beg_inv.HeaderText = "beg_inv"
        Me.beg_inv.Name = "beg_inv"
        Me.beg_inv.ReadOnly = True
        '
        'beg_inv_price
        '
        Me.beg_inv_price.HeaderText = "beg_inv_price"
        Me.beg_inv_price.Name = "beg_inv_price"
        Me.beg_inv_price.ReadOnly = True
        '
        'unit
        '
        Me.unit.HeaderText = "unit"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(203, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 75)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Point of Sales " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inventory System"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.Untitled_1
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(9, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(184, 104)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 58
        Me.PictureBox2.TabStop = False
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(150, 175)
        Me.txt_password.MaxLength = 20
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(236, 27)
        Me.txt_password.TabIndex = 1
        Me.txt_password.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(42, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 18)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Password :"
        '
        'cmd_enter
        '
        Me.cmd_enter.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_enter.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_enter.ForeColor = System.Drawing.Color.White
        Me.cmd_enter.Location = New System.Drawing.Point(150, 220)
        Me.cmd_enter.Name = "cmd_enter"
        Me.cmd_enter.Size = New System.Drawing.Size(114, 37)
        Me.cmd_enter.TabIndex = 2
        Me.cmd_enter.Text = "&ENTER"
        Me.cmd_enter.UseVisualStyleBackColor = False
        '
        'cmd_exit
        '
        Me.cmd_exit.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_exit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_exit.ForeColor = System.Drawing.Color.White
        Me.cmd_exit.Location = New System.Drawing.Point(286, 220)
        Me.cmd_exit.Name = "cmd_exit"
        Me.cmd_exit.Size = New System.Drawing.Size(99, 37)
        Me.cmd_exit.TabIndex = 3
        Me.cmd_exit.Text = "E&XIT"
        Me.cmd_exit.UseVisualStyleBackColor = False
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(149, 136)
        Me.txt_username.MaxLength = 20
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(236, 27)
        Me.txt_username.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(37, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 18)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Username :"
        '
        'dgv_customers
        '
        Me.dgv_customers.AllowUserToAddRows = False
        Me.dgv_customers.AllowUserToDeleteRows = False
        Me.dgv_customers.AllowUserToResizeRows = False
        Me.dgv_customers.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_customers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_customers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_customers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_customers.ColumnHeadersHeight = 25
        Me.dgv_customers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.customer_no, Me.first_name, Me.middle_name, Me.last_name, Me.contact_no, Me.address})
        Me.dgv_customers.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_customers.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_customers.EnableHeadersVisualStyles = False
        Me.dgv_customers.Location = New System.Drawing.Point(407, 121)
        Me.dgv_customers.MultiSelect = False
        Me.dgv_customers.Name = "dgv_customers"
        Me.dgv_customers.ReadOnly = True
        Me.dgv_customers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_customers.RowHeadersVisible = False
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_customers.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_customers.Size = New System.Drawing.Size(13, 116)
        Me.dgv_customers.TabIndex = 57
        Me.dgv_customers.Visible = False
        '
        'customer_no
        '
        Me.customer_no.HeaderText = "Cust No."
        Me.customer_no.Name = "customer_no"
        Me.customer_no.ReadOnly = True
        Me.customer_no.Width = 80
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
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(432, 279)
        Me.Controls.Add(Me.dgv_customers)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmd_enter)
        Me.Controls.Add(Me.cmd_exit)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_items, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_customers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmd_enter As System.Windows.Forms.Button
    Friend WithEvents cmd_exit As System.Windows.Forms.Button
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgv_items As System.Windows.Forms.DataGridView
    Friend WithEvents item_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents barcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents selling_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents buying_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents avail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock_qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents brand As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents beg_inv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents beg_inv_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_customers As System.Windows.Forms.DataGridView
    Friend WithEvents customer_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents first_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents middle_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents last_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contact_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents address As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
