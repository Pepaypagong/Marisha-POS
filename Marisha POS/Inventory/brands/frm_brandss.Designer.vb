<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_brandss
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmd_update = New System.Windows.Forms.Button()
        Me.cmd_addnew = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgv_brand = New System.Windows.Forms.DataGridView()
        Me.brand_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brand_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_brand_name = New System.Windows.Forms.Label()
        Me.lbl_brand_no = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_brand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(3, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(170, 42)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Item Brands"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(382, 66)
        Me.Panel1.TabIndex = 23
        '
        'cmd_update
        '
        Me.cmd_update.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_update.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_update.ForeColor = System.Drawing.Color.White
        Me.cmd_update.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_update.Location = New System.Drawing.Point(85, 391)
        Me.cmd_update.Name = "cmd_update"
        Me.cmd_update.Size = New System.Drawing.Size(82, 47)
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
        Me.cmd_addnew.Location = New System.Drawing.Point(3, 391)
        Me.cmd_addnew.Name = "cmd_addnew"
        Me.cmd_addnew.Size = New System.Drawing.Size(76, 47)
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
        Me.Button2.Location = New System.Drawing.Point(294, 391)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 47)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dgv_brand
        '
        Me.dgv_brand.AllowUserToAddRows = False
        Me.dgv_brand.AllowUserToDeleteRows = False
        Me.dgv_brand.AllowUserToResizeColumns = False
        Me.dgv_brand.AllowUserToResizeRows = False
        Me.dgv_brand.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_brand.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_brand.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_brand.ColumnHeadersHeight = 25
        Me.dgv_brand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_brand.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.brand_no, Me.brand_name})
        Me.dgv_brand.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_brand.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_brand.EnableHeadersVisualStyles = False
        Me.dgv_brand.Location = New System.Drawing.Point(3, 74)
        Me.dgv_brand.MultiSelect = False
        Me.dgv_brand.Name = "dgv_brand"
        Me.dgv_brand.ReadOnly = True
        Me.dgv_brand.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_brand.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_brand.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_brand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_brand.Size = New System.Drawing.Size(373, 310)
        Me.dgv_brand.TabIndex = 39
        '
        'brand_no
        '
        Me.brand_no.HeaderText = "Brand No."
        Me.brand_no.Name = "brand_no"
        Me.brand_no.ReadOnly = True
        Me.brand_no.Width = 120
        '
        'brand_name
        '
        Me.brand_name.HeaderText = "Brand Name"
        Me.brand_name.Name = "brand_name"
        Me.brand_name.ReadOnly = True
        Me.brand_name.Width = 230
        '
        'lbl_brand_name
        '
        Me.lbl_brand_name.BackColor = System.Drawing.Color.White
        Me.lbl_brand_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_brand_name.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand_name.Location = New System.Drawing.Point(221, 403)
        Me.lbl_brand_name.Name = "lbl_brand_name"
        Me.lbl_brand_name.Size = New System.Drawing.Size(21, 22)
        Me.lbl_brand_name.TabIndex = 43
        Me.lbl_brand_name.Text = " "
        Me.lbl_brand_name.Visible = False
        '
        'lbl_brand_no
        '
        Me.lbl_brand_no.BackColor = System.Drawing.Color.White
        Me.lbl_brand_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_brand_no.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand_no.Location = New System.Drawing.Point(194, 403)
        Me.lbl_brand_no.Name = "lbl_brand_no"
        Me.lbl_brand_no.Size = New System.Drawing.Size(21, 22)
        Me.lbl_brand_no.TabIndex = 42
        Me.lbl_brand_no.Text = " "
        Me.lbl_brand_no.Visible = False
        '
        'frm_brandss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 446)
        Me.Controls.Add(Me.lbl_brand_name)
        Me.Controls.Add(Me.lbl_brand_no)
        Me.Controls.Add(Me.dgv_brand)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmd_update)
        Me.Controls.Add(Me.cmd_addnew)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_brandss"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - Brands"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_brand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmd_update As System.Windows.Forms.Button
    Friend WithEvents cmd_addnew As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dgv_brand As System.Windows.Forms.DataGridView
    Friend WithEvents brand_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents brand_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_brand_name As System.Windows.Forms.Label
    Friend WithEvents lbl_brand_no As System.Windows.Forms.Label
End Class
