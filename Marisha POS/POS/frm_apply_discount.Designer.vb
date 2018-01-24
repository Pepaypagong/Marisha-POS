<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_apply_discount
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
        Me.dgv_discount = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cmd_cancel = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_discount = New System.Windows.Forms.TextBox()
        Me.cmd_remove = New System.Windows.Forms.Button()
        Me.cmd_enter_disc = New System.Windows.Forms.Button()
        CType(Me.dgv_discount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.dgv_discount.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.discount_name, Me.discount, Me.btn})
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
        Me.dgv_discount.Location = New System.Drawing.Point(8, 59)
        Me.dgv_discount.MultiSelect = False
        Me.dgv_discount.Name = "dgv_discount"
        Me.dgv_discount.ReadOnly = True
        Me.dgv_discount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_discount.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_discount.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_discount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_discount.Size = New System.Drawing.Size(459, 193)
        Me.dgv_discount.TabIndex = 34
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
        'btn
        '
        Me.btn.HeaderText = "Select"
        Me.btn.Name = "btn"
        Me.btn.ReadOnly = True
        Me.btn.Text = "Select"
        Me.btn.UseColumnTextForButtonValue = True
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
        Me.cmd_cancel.Location = New System.Drawing.Point(375, 258)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(92, 47)
        Me.cmd_cancel.TabIndex = 3
        Me.cmd_cancel.Text = "Close"
        Me.cmd_cancel.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 38)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Enter or " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Select Discount (%)"
        '
        'txt_discount
        '
        Me.txt_discount.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_discount.Location = New System.Drawing.Point(167, 17)
        Me.txt_discount.MaxLength = 3
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.Size = New System.Drawing.Size(128, 30)
        Me.txt_discount.TabIndex = 0
        Me.txt_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmd_remove
        '
        Me.cmd_remove.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_remove.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_remove.ForeColor = System.Drawing.Color.White
        Me.cmd_remove.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_remove.Location = New System.Drawing.Point(8, 263)
        Me.cmd_remove.Name = "cmd_remove"
        Me.cmd_remove.Size = New System.Drawing.Size(151, 36)
        Me.cmd_remove.TabIndex = 2
        Me.cmd_remove.Text = "Remove Discount"
        Me.cmd_remove.UseVisualStyleBackColor = False
        '
        'cmd_enter_disc
        '
        Me.cmd_enter_disc.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_enter_disc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_enter_disc.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_enter_disc.ForeColor = System.Drawing.Color.White
        Me.cmd_enter_disc.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_enter_disc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_enter_disc.Location = New System.Drawing.Point(301, 17)
        Me.cmd_enter_disc.Name = "cmd_enter_disc"
        Me.cmd_enter_disc.Size = New System.Drawing.Size(151, 30)
        Me.cmd_enter_disc.TabIndex = 1
        Me.cmd_enter_disc.Text = "Confirm"
        Me.cmd_enter_disc.UseVisualStyleBackColor = False
        '
        'frm_apply_discount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 313)
        Me.Controls.Add(Me.cmd_enter_disc)
        Me.Controls.Add(Me.cmd_remove)
        Me.Controls.Add(Me.txt_discount)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.dgv_discount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_apply_discount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - Discount"
        CType(Me.dgv_discount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_discount As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discount_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cmd_cancel As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_discount As System.Windows.Forms.TextBox
    Friend WithEvents cmd_remove As System.Windows.Forms.Button
    Friend WithEvents cmd_enter_disc As System.Windows.Forms.Button
End Class
