<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_category
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmd_update = New System.Windows.Forms.Button()
        Me.cmd_addnew = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgv_category = New System.Windows.Forms.DataGridView()
        Me.category_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category_desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_category_no = New System.Windows.Forms.Label()
        Me.lbl_category_name = New System.Windows.Forms.Label()
        Me.lbl_category_desc = New System.Windows.Forms.Label()
        Me.cmd_delete = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_category, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 66)
        Me.Panel1.TabIndex = 21
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(11, 11)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(192, 42)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Item Category"
        '
        'cmd_update
        '
        Me.cmd_update.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_update.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_update.ForeColor = System.Drawing.Color.White
        Me.cmd_update.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_update.Location = New System.Drawing.Point(106, 397)
        Me.cmd_update.Name = "cmd_update"
        Me.cmd_update.Size = New System.Drawing.Size(92, 47)
        Me.cmd_update.TabIndex = 1
        Me.cmd_update.Text = "Update"
        Me.cmd_update.UseVisualStyleBackColor = False
        '
        'cmd_addnew
        '
        Me.cmd_addnew.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_addnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_addnew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_addnew.ForeColor = System.Drawing.Color.White
        Me.cmd_addnew.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_addnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_addnew.Location = New System.Drawing.Point(8, 397)
        Me.cmd_addnew.Name = "cmd_addnew"
        Me.cmd_addnew.Size = New System.Drawing.Size(92, 47)
        Me.cmd_addnew.TabIndex = 0
        Me.cmd_addnew.Text = "Add New"
        Me.cmd_addnew.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(630, 397)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 47)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dgv_category
        '
        Me.dgv_category.AllowUserToAddRows = False
        Me.dgv_category.AllowUserToDeleteRows = False
        Me.dgv_category.AllowUserToResizeColumns = False
        Me.dgv_category.AllowUserToResizeRows = False
        Me.dgv_category.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_category.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_category.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_category.ColumnHeadersHeight = 25
        Me.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_category.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.category_no, Me.category_name, Me.category_desc})
        Me.dgv_category.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_category.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_category.EnableHeadersVisualStyles = False
        Me.dgv_category.Location = New System.Drawing.Point(8, 72)
        Me.dgv_category.MultiSelect = False
        Me.dgv_category.Name = "dgv_category"
        Me.dgv_category.ReadOnly = True
        Me.dgv_category.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_category.RowHeadersVisible = False
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_category.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_category.Size = New System.Drawing.Size(704, 310)
        Me.dgv_category.TabIndex = 38
        '
        'category_no
        '
        Me.category_no.HeaderText = "Category No."
        Me.category_no.Name = "category_no"
        Me.category_no.ReadOnly = True
        '
        'category_name
        '
        Me.category_name.HeaderText = "Category Name"
        Me.category_name.Name = "category_name"
        Me.category_name.ReadOnly = True
        Me.category_name.Width = 175
        '
        'category_desc
        '
        Me.category_desc.HeaderText = "Category Description"
        Me.category_desc.Name = "category_desc"
        Me.category_desc.ReadOnly = True
        Me.category_desc.Width = 410
        '
        'lbl_category_no
        '
        Me.lbl_category_no.BackColor = System.Drawing.Color.White
        Me.lbl_category_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_category_no.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_category_no.Location = New System.Drawing.Point(436, 409)
        Me.lbl_category_no.Name = "lbl_category_no"
        Me.lbl_category_no.Size = New System.Drawing.Size(21, 22)
        Me.lbl_category_no.TabIndex = 39
        Me.lbl_category_no.Text = " "
        Me.lbl_category_no.Visible = False
        '
        'lbl_category_name
        '
        Me.lbl_category_name.BackColor = System.Drawing.Color.White
        Me.lbl_category_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_category_name.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_category_name.Location = New System.Drawing.Point(463, 409)
        Me.lbl_category_name.Name = "lbl_category_name"
        Me.lbl_category_name.Size = New System.Drawing.Size(21, 22)
        Me.lbl_category_name.TabIndex = 40
        Me.lbl_category_name.Text = " "
        Me.lbl_category_name.Visible = False
        '
        'lbl_category_desc
        '
        Me.lbl_category_desc.BackColor = System.Drawing.Color.White
        Me.lbl_category_desc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_category_desc.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_category_desc.Location = New System.Drawing.Point(490, 409)
        Me.lbl_category_desc.Name = "lbl_category_desc"
        Me.lbl_category_desc.Size = New System.Drawing.Size(21, 22)
        Me.lbl_category_desc.TabIndex = 41
        Me.lbl_category_desc.Text = " "
        Me.lbl_category_desc.Visible = False
        '
        'cmd_delete
        '
        Me.cmd_delete.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_delete.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_delete.ForeColor = System.Drawing.Color.White
        Me.cmd_delete.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_delete.Location = New System.Drawing.Point(205, 397)
        Me.cmd_delete.Name = "cmd_delete"
        Me.cmd_delete.Size = New System.Drawing.Size(92, 47)
        Me.cmd_delete.TabIndex = 42
        Me.cmd_delete.Text = "Delete"
        Me.cmd_delete.UseVisualStyleBackColor = False
        '
        'frm_category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 454)
        Me.Controls.Add(Me.cmd_delete)
        Me.Controls.Add(Me.lbl_category_desc)
        Me.Controls.Add(Me.lbl_category_name)
        Me.Controls.Add(Me.lbl_category_no)
        Me.Controls.Add(Me.dgv_category)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmd_update)
        Me.Controls.Add(Me.cmd_addnew)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_category"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - Category"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_category, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_addnew As System.Windows.Forms.Button
    Friend WithEvents cmd_update As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dgv_category As System.Windows.Forms.DataGridView
    Friend WithEvents category_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents category_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents category_desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_category_no As System.Windows.Forms.Label
    Friend WithEvents lbl_category_name As System.Windows.Forms.Label
    Friend WithEvents lbl_category_desc As System.Windows.Forms.Label
    Friend WithEvents cmd_delete As System.Windows.Forms.Button
End Class
