<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_discount
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmd_delete = New System.Windows.Forms.Button()
        Me.cmd_addnew = New System.Windows.Forms.Button()
        Me.dgv_discount = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_discount = New System.Windows.Forms.Label()
        Me.lbl_disc_name = New System.Windows.Forms.Label()
        Me.lbl_no = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_discount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(377, 66)
        Me.Panel1.TabIndex = 28
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(3, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(236, 42)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Pre-Set Discounts"
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
        Me.Button2.Location = New System.Drawing.Point(290, 393)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 47)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'cmd_delete
        '
        Me.cmd_delete.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_delete.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_delete.ForeColor = System.Drawing.Color.White
        Me.cmd_delete.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_delete.Location = New System.Drawing.Point(90, 393)
        Me.cmd_delete.Name = "cmd_delete"
        Me.cmd_delete.Size = New System.Drawing.Size(82, 47)
        Me.cmd_delete.TabIndex = 1
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
        Me.cmd_addnew.Location = New System.Drawing.Point(8, 393)
        Me.cmd_addnew.Name = "cmd_addnew"
        Me.cmd_addnew.Size = New System.Drawing.Size(76, 47)
        Me.cmd_addnew.TabIndex = 0
        Me.cmd_addnew.Text = "Add New"
        Me.cmd_addnew.UseVisualStyleBackColor = False
        '
        'dgv_discount
        '
        Me.dgv_discount.AllowUserToAddRows = False
        Me.dgv_discount.AllowUserToDeleteRows = False
        Me.dgv_discount.AllowUserToResizeRows = False
        Me.dgv_discount.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_discount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_discount.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_discount.ColumnHeadersHeight = 25
        Me.dgv_discount.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.discount_name, Me.discount})
        Me.dgv_discount.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_discount.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_discount.EnableHeadersVisualStyles = False
        Me.dgv_discount.Location = New System.Drawing.Point(4, 72)
        Me.dgv_discount.MultiSelect = False
        Me.dgv_discount.Name = "dgv_discount"
        Me.dgv_discount.ReadOnly = True
        Me.dgv_discount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_discount.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_discount.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_discount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_discount.Size = New System.Drawing.Size(368, 314)
        Me.dgv_discount.TabIndex = 33
        '
        'no
        '
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 80
        '
        'discount_name
        '
        Me.discount_name.HeaderText = "Discount Name"
        Me.discount_name.Name = "discount_name"
        Me.discount_name.ReadOnly = True
        Me.discount_name.Width = 160
        '
        'discount
        '
        Me.discount.HeaderText = "Discount (%)"
        Me.discount.Name = "discount"
        Me.discount.ReadOnly = True
        '
        'lbl_discount
        '
        Me.lbl_discount.BackColor = System.Drawing.Color.White
        Me.lbl_discount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_discount.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_discount.Location = New System.Drawing.Point(244, 405)
        Me.lbl_discount.Name = "lbl_discount"
        Me.lbl_discount.Size = New System.Drawing.Size(21, 22)
        Me.lbl_discount.TabIndex = 44
        Me.lbl_discount.Text = " "
        Me.lbl_discount.Visible = False
        '
        'lbl_disc_name
        '
        Me.lbl_disc_name.BackColor = System.Drawing.Color.White
        Me.lbl_disc_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_disc_name.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_disc_name.Location = New System.Drawing.Point(217, 405)
        Me.lbl_disc_name.Name = "lbl_disc_name"
        Me.lbl_disc_name.Size = New System.Drawing.Size(21, 22)
        Me.lbl_disc_name.TabIndex = 43
        Me.lbl_disc_name.Text = " "
        Me.lbl_disc_name.Visible = False
        '
        'lbl_no
        '
        Me.lbl_no.BackColor = System.Drawing.Color.White
        Me.lbl_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_no.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_no.Location = New System.Drawing.Point(190, 405)
        Me.lbl_no.Name = "lbl_no"
        Me.lbl_no.Size = New System.Drawing.Size(21, 22)
        Me.lbl_no.TabIndex = 42
        Me.lbl_no.Text = " "
        Me.lbl_no.Visible = False
        '
        'frm_discount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 448)
        Me.Controls.Add(Me.lbl_discount)
        Me.Controls.Add(Me.lbl_disc_name)
        Me.Controls.Add(Me.lbl_no)
        Me.Controls.Add(Me.dgv_discount)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmd_delete)
        Me.Controls.Add(Me.cmd_addnew)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_discount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - Discounts"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_discount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmd_delete As System.Windows.Forms.Button
    Friend WithEvents cmd_addnew As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents dgv_discount As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discount_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_discount As System.Windows.Forms.Label
    Friend WithEvents lbl_disc_name As System.Windows.Forms.Label
    Friend WithEvents lbl_no As System.Windows.Forms.Label
End Class
