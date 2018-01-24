<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_choose
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_choose))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_position = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_account_no = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pic_user = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmd_pos = New System.Windows.Forms.Button()
        Me.cmd_salesrep = New System.Windows.Forms.Button()
        Me.cmd_logout = New System.Windows.Forms.Button()
        Me.cmd_accounts = New System.Windows.Forms.Button()
        Me.cmd_inv = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmd_customers = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmd_suppliers = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(166, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 73)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Welcome!"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.White
        Me.lbl_name.Location = New System.Drawing.Point(183, 83)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(251, 26)
        Me.lbl_name.TabIndex = 8
        Me.lbl_name.Text = "Jeffrey Briones Bacuña"
        '
        'lbl_position
        '
        Me.lbl_position.AutoSize = True
        Me.lbl_position.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_position.ForeColor = System.Drawing.Color.White
        Me.lbl_position.Location = New System.Drawing.Point(184, 109)
        Me.lbl_position.Name = "lbl_position"
        Me.lbl_position.Size = New System.Drawing.Size(71, 21)
        Me.lbl_position.TabIndex = 11
        Me.lbl_position.Text = "Position"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(153, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 29)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Inventory"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(280, 261)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 29)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Sales"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(404, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 29)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "User Accounts"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(807, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 29)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Log -Out"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.lbl_account_no)
        Me.Panel1.Controls.Add(Me.lbl_position)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.lbl_name)
        Me.Panel1.Controls.Add(Me.pic_user)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(935, 147)
        Me.Panel1.TabIndex = 18
        '
        'lbl_account_no
        '
        Me.lbl_account_no.BackColor = System.Drawing.Color.White
        Me.lbl_account_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_account_no.Location = New System.Drawing.Point(485, 44)
        Me.lbl_account_no.Name = "lbl_account_no"
        Me.lbl_account_no.Size = New System.Drawing.Size(47, 15)
        Me.lbl_account_no.TabIndex = 26
        Me.lbl_account_no.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PictureBox2.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.Untitled_1
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(709, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(211, 131)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'pic_user
        '
        Me.pic_user.BackColor = System.Drawing.Color.White
        Me.pic_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_user.Image = CType(resources.GetObject("pic_user.Image"), System.Drawing.Image)
        Me.pic_user.Location = New System.Drawing.Point(28, 10)
        Me.pic_user.Name = "pic_user"
        Me.pic_user.Size = New System.Drawing.Size(136, 124)
        Me.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_user.TabIndex = 7
        Me.pic_user.TabStop = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(24, 261)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 29)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "POS"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmd_pos
        '
        Me.cmd_pos.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_pos.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.compute
        Me.cmd_pos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_pos.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.cmd_pos.FlatAppearance.BorderSize = 0
        Me.cmd_pos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_pos.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_pos.Location = New System.Drawing.Point(24, 168)
        Me.cmd_pos.Name = "cmd_pos"
        Me.cmd_pos.Size = New System.Drawing.Size(100, 90)
        Me.cmd_pos.TabIndex = 0
        Me.cmd_pos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_pos.UseVisualStyleBackColor = False
        '
        'cmd_salesrep
        '
        Me.cmd_salesrep.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_salesrep.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.cashadvance
        Me.cmd_salesrep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_salesrep.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.cmd_salesrep.FlatAppearance.BorderSize = 0
        Me.cmd_salesrep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_salesrep.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_salesrep.Location = New System.Drawing.Point(286, 168)
        Me.cmd_salesrep.Name = "cmd_salesrep"
        Me.cmd_salesrep.Size = New System.Drawing.Size(100, 90)
        Me.cmd_salesrep.TabIndex = 2
        Me.cmd_salesrep.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_salesrep.UseVisualStyleBackColor = False
        '
        'cmd_logout
        '
        Me.cmd_logout.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_logout.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.logout
        Me.cmd_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_logout.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.cmd_logout.FlatAppearance.BorderSize = 0
        Me.cmd_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_logout.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_logout.Location = New System.Drawing.Point(807, 168)
        Me.cmd_logout.Name = "cmd_logout"
        Me.cmd_logout.Size = New System.Drawing.Size(100, 90)
        Me.cmd_logout.TabIndex = 6
        Me.cmd_logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_logout.UseVisualStyleBackColor = False
        '
        'cmd_accounts
        '
        Me.cmd_accounts.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_accounts.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.user
        Me.cmd_accounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_accounts.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.cmd_accounts.FlatAppearance.BorderSize = 0
        Me.cmd_accounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_accounts.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_accounts.Location = New System.Drawing.Point(418, 168)
        Me.cmd_accounts.Name = "cmd_accounts"
        Me.cmd_accounts.Size = New System.Drawing.Size(100, 90)
        Me.cmd_accounts.TabIndex = 3
        Me.cmd_accounts.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_accounts.UseVisualStyleBackColor = False
        '
        'cmd_inv
        '
        Me.cmd_inv.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_inv.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.inv
        Me.cmd_inv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_inv.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.cmd_inv.FlatAppearance.BorderSize = 0
        Me.cmd_inv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_inv.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_inv.Location = New System.Drawing.Point(153, 168)
        Me.cmd_inv.Name = "cmd_inv"
        Me.cmd_inv.Size = New System.Drawing.Size(100, 90)
        Me.cmd_inv.TabIndex = 1
        Me.cmd_inv.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_inv.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(535, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 29)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Customers"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmd_customers
        '
        Me.cmd_customers.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_customers.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.group
        Me.cmd_customers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_customers.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.cmd_customers.FlatAppearance.BorderSize = 0
        Me.cmd_customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_customers.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_customers.Location = New System.Drawing.Point(549, 168)
        Me.cmd_customers.Name = "cmd_customers"
        Me.cmd_customers.Size = New System.Drawing.Size(100, 90)
        Me.cmd_customers.TabIndex = 4
        Me.cmd_customers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_customers.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(665, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 29)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Suppliers"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmd_suppliers
        '
        Me.cmd_suppliers.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_suppliers.BackgroundImage = Global.Marisha_POS.My.Resources.Resources.package
        Me.cmd_suppliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_suppliers.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.cmd_suppliers.FlatAppearance.BorderSize = 0
        Me.cmd_suppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_suppliers.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_suppliers.Location = New System.Drawing.Point(679, 168)
        Me.cmd_suppliers.Name = "cmd_suppliers"
        Me.cmd_suppliers.Size = New System.Drawing.Size(100, 90)
        Me.cmd_suppliers.TabIndex = 5
        Me.cmd_suppliers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_suppliers.UseVisualStyleBackColor = False
        '
        'frm_choose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(932, 299)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmd_suppliers)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmd_customers)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmd_pos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmd_salesrep)
        Me.Controls.Add(Me.cmd_logout)
        Me.Controls.Add(Me.cmd_accounts)
        Me.Controls.Add(Me.cmd_inv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_choose"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - Home"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_inv As System.Windows.Forms.Button
    Friend WithEvents cmd_accounts As System.Windows.Forms.Button
    Friend WithEvents cmd_logout As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pic_user As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents cmd_salesrep As System.Windows.Forms.Button
    Friend WithEvents lbl_position As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmd_pos As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmd_customers As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmd_suppliers As System.Windows.Forms.Button
    Friend WithEvents lbl_account_no As System.Windows.Forms.Label
End Class
