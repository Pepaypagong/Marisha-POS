<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_trans_history
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.dgv_history = New System.Windows.Forms.DataGridView()
        Me.dtp_date_from = New System.Windows.Forms.DateTimePicker()
        Me.cmd_filter_by_date = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_date_to = New System.Windows.Forms.DateTimePicker()
        Me.cmd_set = New System.Windows.Forms.Button()
        Me.datet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty_in = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty_out = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_history, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(967, 66)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(838, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 47)
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
        Me.lblTitle.Size = New System.Drawing.Size(257, 42)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Transaction History"
        '
        'dgv_history
        '
        Me.dgv_history.AllowUserToAddRows = False
        Me.dgv_history.AllowUserToDeleteRows = False
        Me.dgv_history.AllowUserToResizeRows = False
        Me.dgv_history.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_history.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_history.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_history.ColumnHeadersHeight = 25
        Me.dgv_history.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.datet, Me.trans_type, Me.barcode, Me.item_name, Me.qty_in, Me.qty_out})
        Me.dgv_history.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_history.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_history.EnableHeadersVisualStyles = False
        Me.dgv_history.Location = New System.Drawing.Point(6, 106)
        Me.dgv_history.MultiSelect = False
        Me.dgv_history.Name = "dgv_history"
        Me.dgv_history.ReadOnly = True
        Me.dgv_history.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_history.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_history.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_history.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_history.Size = New System.Drawing.Size(950, 551)
        Me.dgv_history.TabIndex = 51
        '
        'dtp_date_from
        '
        Me.dtp_date_from.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_date_from.Location = New System.Drawing.Point(164, 75)
        Me.dtp_date_from.Name = "dtp_date_from"
        Me.dtp_date_from.Size = New System.Drawing.Size(230, 23)
        Me.dtp_date_from.TabIndex = 55
        '
        'cmd_filter_by_date
        '
        Me.cmd_filter_by_date.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_filter_by_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_filter_by_date.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_filter_by_date.ForeColor = System.Drawing.Color.White
        Me.cmd_filter_by_date.Location = New System.Drawing.Point(680, 72)
        Me.cmd_filter_by_date.Name = "cmd_filter_by_date"
        Me.cmd_filter_by_date.Size = New System.Drawing.Size(85, 28)
        Me.cmd_filter_by_date.TabIndex = 56
        Me.cmd_filter_by_date.Text = "Filter"
        Me.cmd_filter_by_date.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 16)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Show Starting From :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(400, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "To :"
        '
        'dtp_date_to
        '
        Me.dtp_date_to.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_date_to.Location = New System.Drawing.Point(438, 75)
        Me.dtp_date_to.Name = "dtp_date_to"
        Me.dtp_date_to.Size = New System.Drawing.Size(230, 23)
        Me.dtp_date_to.TabIndex = 58
        '
        'cmd_set
        '
        Me.cmd_set.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_set.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_set.ForeColor = System.Drawing.Color.White
        Me.cmd_set.Location = New System.Drawing.Point(771, 72)
        Me.cmd_set.Name = "cmd_set"
        Me.cmd_set.Size = New System.Drawing.Size(72, 28)
        Me.cmd_set.TabIndex = 60
        Me.cmd_set.Text = "Set"
        Me.cmd_set.UseVisualStyleBackColor = False
        '
        'datet
        '
        Me.datet.HeaderText = "Date Time"
        Me.datet.Name = "datet"
        Me.datet.ReadOnly = True
        Me.datet.Width = 150
        '
        'trans_type
        '
        Me.trans_type.HeaderText = "Transaction Type"
        Me.trans_type.Name = "trans_type"
        Me.trans_type.ReadOnly = True
        Me.trans_type.Width = 200
        '
        'barcode
        '
        Me.barcode.HeaderText = "Barcode"
        Me.barcode.Name = "barcode"
        Me.barcode.ReadOnly = True
        Me.barcode.Width = 110
        '
        'item_name
        '
        Me.item_name.HeaderText = "Item Name"
        Me.item_name.Name = "item_name"
        Me.item_name.ReadOnly = True
        Me.item_name.Width = 330
        '
        'qty_in
        '
        Me.qty_in.HeaderText = "Qty. In"
        Me.qty_in.Name = "qty_in"
        Me.qty_in.ReadOnly = True
        Me.qty_in.Width = 70
        '
        'qty_out
        '
        Me.qty_out.HeaderText = "Qty Out."
        Me.qty_out.Name = "qty_out"
        Me.qty_out.ReadOnly = True
        Me.qty_out.Width = 70
        '
        'frm_trans_history
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 664)
        Me.Controls.Add(Me.cmd_set)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtp_date_to)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmd_filter_by_date)
        Me.Controls.Add(Me.dtp_date_from)
        Me.Controls.Add(Me.dgv_history)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_trans_history"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction History"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_history, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents dgv_history As System.Windows.Forms.DataGridView
    Friend WithEvents dtp_date_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmd_filter_by_date As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_date_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmd_set As System.Windows.Forms.Button
    Friend WithEvents datet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trans_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents barcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qty_in As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qty_out As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
