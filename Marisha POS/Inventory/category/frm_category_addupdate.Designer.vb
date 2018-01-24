<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_category_addupdate
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_category_no = New System.Windows.Forms.Label()
        Me.txt_category_desc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_category_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmd_cancel = New System.Windows.Forms.Button()
        Me.cmd_save = New System.Windows.Forms.Button()
        Me.txt_oldcat = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(577, 66)
        Me.Panel1.TabIndex = 22
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(11, 11)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(273, 42)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Add a New Category"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.txt_oldcat)
        Me.GroupBox1.Controls.Add(Me.lbl_category_no)
        Me.GroupBox1.Controls.Add(Me.txt_category_desc)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_category_name)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(559, 152)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'lbl_category_no
        '
        Me.lbl_category_no.BackColor = System.Drawing.Color.White
        Me.lbl_category_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_category_no.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_category_no.Location = New System.Drawing.Point(143, 17)
        Me.lbl_category_no.Name = "lbl_category_no"
        Me.lbl_category_no.Size = New System.Drawing.Size(156, 22)
        Me.lbl_category_no.TabIndex = 7
        Me.lbl_category_no.Text = " "
        '
        'txt_category_desc
        '
        Me.txt_category_desc.BackColor = System.Drawing.Color.White
        Me.txt_category_desc.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_category_desc.Location = New System.Drawing.Point(143, 76)
        Me.txt_category_desc.MaxLength = 100
        Me.txt_category_desc.Multiline = True
        Me.txt_category_desc.Name = "txt_category_desc"
        Me.txt_category_desc.Size = New System.Drawing.Size(396, 59)
        Me.txt_category_desc.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Description :"
        '
        'txt_category_name
        '
        Me.txt_category_name.BackColor = System.Drawing.Color.White
        Me.txt_category_name.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_category_name.Location = New System.Drawing.Point(143, 45)
        Me.txt_category_name.MaxLength = 50
        Me.txt_category_name.Name = "txt_category_name"
        Me.txt_category_name.Size = New System.Drawing.Size(396, 26)
        Me.txt_category_name.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Category Name :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 18)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Category No. :"
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
        Me.cmd_cancel.Location = New System.Drawing.Point(297, 235)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(91, 47)
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
        Me.cmd_save.Location = New System.Drawing.Point(181, 235)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.Size = New System.Drawing.Size(92, 47)
        Me.cmd_save.TabIndex = 1
        Me.cmd_save.Text = "Save"
        Me.cmd_save.UseVisualStyleBackColor = False
        '
        'txt_oldcat
        '
        Me.txt_oldcat.BackColor = System.Drawing.Color.White
        Me.txt_oldcat.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_oldcat.Location = New System.Drawing.Point(344, 16)
        Me.txt_oldcat.MaxLength = 50
        Me.txt_oldcat.Name = "txt_oldcat"
        Me.txt_oldcat.Size = New System.Drawing.Size(195, 26)
        Me.txt_oldcat.TabIndex = 11
        Me.txt_oldcat.Visible = False
        '
        'frm_category_addupdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 293)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.cmd_save)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_category_addupdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS -Category"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_category_no As System.Windows.Forms.Label
    Friend WithEvents txt_category_desc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_category_name As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmd_cancel As System.Windows.Forms.Button
    Friend WithEvents cmd_save As System.Windows.Forms.Button
    Friend WithEvents txt_oldcat As System.Windows.Forms.TextBox
End Class
