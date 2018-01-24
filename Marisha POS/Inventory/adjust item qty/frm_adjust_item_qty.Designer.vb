<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_adjust_item_qty
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_date_to = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmd_filter_by_date = New System.Windows.Forms.Button()
        Me.dtp_date_from = New System.Windows.Forms.DateTimePicker()
        Me.dgv_adjust = New System.Windows.Forms.DataGridView()
        Me.trans_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adjust_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_show = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cmd_inc = New System.Windows.Forms.Button()
        Me.cmd_dec = New System.Windows.Forms.Button()
        Me.cmd_settings = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_adjust, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(593, 66)
        Me.Panel1.TabIndex = 2
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
        Me.Button1.Location = New System.Drawing.Point(463, 6)
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
        Me.lblTitle.Size = New System.Drawing.Size(280, 42)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Adjust Item Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(251, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "To :"
        '
        'dtp_date_to
        '
        Me.dtp_date_to.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_date_to.Location = New System.Drawing.Point(251, 95)
        Me.dtp_date_to.Name = "dtp_date_to"
        Me.dtp_date_to.Size = New System.Drawing.Size(230, 23)
        Me.dtp_date_to.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 16)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Show Starting From :"
        '
        'cmd_filter_by_date
        '
        Me.cmd_filter_by_date.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_filter_by_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_filter_by_date.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_filter_by_date.ForeColor = System.Drawing.Color.White
        Me.cmd_filter_by_date.Location = New System.Drawing.Point(488, 95)
        Me.cmd_filter_by_date.Name = "cmd_filter_by_date"
        Me.cmd_filter_by_date.Size = New System.Drawing.Size(85, 23)
        Me.cmd_filter_by_date.TabIndex = 61
        Me.cmd_filter_by_date.Text = "Filter"
        Me.cmd_filter_by_date.UseVisualStyleBackColor = False
        '
        'dtp_date_from
        '
        Me.dtp_date_from.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_date_from.Location = New System.Drawing.Point(10, 95)
        Me.dtp_date_from.Name = "dtp_date_from"
        Me.dtp_date_from.Size = New System.Drawing.Size(230, 23)
        Me.dtp_date_from.TabIndex = 60
        '
        'dgv_adjust
        '
        Me.dgv_adjust.AllowUserToAddRows = False
        Me.dgv_adjust.AllowUserToDeleteRows = False
        Me.dgv_adjust.AllowUserToResizeRows = False
        Me.dgv_adjust.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_adjust.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_adjust.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_adjust.ColumnHeadersHeight = 25
        Me.dgv_adjust.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.trans_no, Me.date_time, Me.adjust_type, Me.remarks, Me.cmd_show})
        Me.dgv_adjust.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_adjust.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_adjust.EnableHeadersVisualStyles = False
        Me.dgv_adjust.Location = New System.Drawing.Point(8, 124)
        Me.dgv_adjust.MultiSelect = False
        Me.dgv_adjust.Name = "dgv_adjust"
        Me.dgv_adjust.ReadOnly = True
        Me.dgv_adjust.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_adjust.RowHeadersVisible = False
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_adjust.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_adjust.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_adjust.Size = New System.Drawing.Size(566, 448)
        Me.dgv_adjust.TabIndex = 65
        '
        'trans_no
        '
        Me.trans_no.HeaderText = "trans_no"
        Me.trans_no.Name = "trans_no"
        Me.trans_no.ReadOnly = True
        Me.trans_no.Visible = False
        '
        'date_time
        '
        Me.date_time.HeaderText = "Date Time"
        Me.date_time.Name = "date_time"
        Me.date_time.ReadOnly = True
        Me.date_time.Width = 200
        '
        'adjust_type
        '
        Me.adjust_type.HeaderText = "Adjustment Type"
        Me.adjust_type.Name = "adjust_type"
        Me.adjust_type.ReadOnly = True
        Me.adjust_type.Width = 200
        '
        'remarks
        '
        Me.remarks.HeaderText = "remarks"
        Me.remarks.Name = "remarks"
        Me.remarks.ReadOnly = True
        Me.remarks.Visible = False
        '
        'cmd_show
        '
        Me.cmd_show.HeaderText = "Show Details"
        Me.cmd_show.Name = "cmd_show"
        Me.cmd_show.ReadOnly = True
        Me.cmd_show.Text = "SHOW DETAILS"
        Me.cmd_show.UseColumnTextForButtonValue = True
        Me.cmd_show.Width = 140
        '
        'cmd_inc
        '
        Me.cmd_inc.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_inc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_inc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_inc.ForeColor = System.Drawing.Color.White
        Me.cmd_inc.Location = New System.Drawing.Point(7, 578)
        Me.cmd_inc.Name = "cmd_inc"
        Me.cmd_inc.Size = New System.Drawing.Size(129, 47)
        Me.cmd_inc.TabIndex = 66
        Me.cmd_inc.Text = "Increase Item Qty"
        Me.cmd_inc.UseVisualStyleBackColor = False
        '
        'cmd_dec
        '
        Me.cmd_dec.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_dec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_dec.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_dec.ForeColor = System.Drawing.Color.White
        Me.cmd_dec.Location = New System.Drawing.Point(142, 578)
        Me.cmd_dec.Name = "cmd_dec"
        Me.cmd_dec.Size = New System.Drawing.Size(145, 47)
        Me.cmd_dec.TabIndex = 67
        Me.cmd_dec.Text = "Decrease Item Qty"
        Me.cmd_dec.UseVisualStyleBackColor = False
        '
        'cmd_settings
        '
        Me.cmd_settings.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_settings.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_settings.ForeColor = System.Drawing.Color.White
        Me.cmd_settings.Location = New System.Drawing.Point(488, 69)
        Me.cmd_settings.Name = "cmd_settings"
        Me.cmd_settings.Size = New System.Drawing.Size(85, 23)
        Me.cmd_settings.TabIndex = 68
        Me.cmd_settings.Text = "Set"
        Me.cmd_settings.UseVisualStyleBackColor = False
        '
        'frm_adjust_item_qty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 629)
        Me.Controls.Add(Me.cmd_settings)
        Me.Controls.Add(Me.cmd_dec)
        Me.Controls.Add(Me.cmd_inc)
        Me.Controls.Add(Me.dgv_adjust)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtp_date_to)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmd_filter_by_date)
        Me.Controls.Add(Me.dtp_date_from)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_adjust_item_qty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - Adjust Item Quantity"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_adjust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_date_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmd_filter_by_date As System.Windows.Forms.Button
    Friend WithEvents dtp_date_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgv_adjust As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_inc As System.Windows.Forms.Button
    Friend WithEvents cmd_dec As System.Windows.Forms.Button
    Friend WithEvents trans_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_time As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents adjust_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents remarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmd_show As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cmd_settings As System.Windows.Forms.Button
End Class
