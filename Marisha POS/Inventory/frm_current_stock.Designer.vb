<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_current_stock
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.crv_inventory_report = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtp_purchases_to = New System.Windows.Forms.DateTimePicker()
        Me.cmd_show = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmd_export = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmd_print = New System.Windows.Forms.Button()
        Me.dtp_purchases_from = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1337, 66)
        Me.Panel1.TabIndex = 29
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(1231, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 47)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = false
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = true
        Me.lblTitle.Font = New System.Drawing.Font("Segoe Print", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(11, 11)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(243, 42)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Item Stock Report"
        '
        'crv_inventory_report
        '
        Me.crv_inventory_report.ActiveViewIndex = -1
        Me.crv_inventory_report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_inventory_report.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_inventory_report.Location = New System.Drawing.Point(1, 107)
        Me.crv_inventory_report.Name = "crv_inventory_report"
        Me.crv_inventory_report.ReuseParameterValuesOnRefresh = true
        Me.crv_inventory_report.ShowGroupTreeButton = false
        Me.crv_inventory_report.ShowParameterPanelButton = false
        Me.crv_inventory_report.ShowRefreshButton = false
        Me.crv_inventory_report.Size = New System.Drawing.Size(1335, 569)
        Me.crv_inventory_report.TabIndex = 30
        Me.crv_inventory_report.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel2.Controls.Add(Me.dtp_purchases_to)
        Me.Panel2.Controls.Add(Me.cmd_show)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.cmd_export)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.cmd_print)
        Me.Panel2.Controls.Add(Me.dtp_purchases_from)
        Me.Panel2.Location = New System.Drawing.Point(0, 66)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1336, 40)
        Me.Panel2.TabIndex = 31
        '
        'dtp_purchases_to
        '
        Me.dtp_purchases_to.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dtp_purchases_to.Location = New System.Drawing.Point(397, 8)
        Me.dtp_purchases_to.Name = "dtp_purchases_to"
        Me.dtp_purchases_to.Size = New System.Drawing.Size(231, 23)
        Me.dtp_purchases_to.TabIndex = 35
        '
        'cmd_show
        '
        Me.cmd_show.BackColor = System.Drawing.Color.White
        Me.cmd_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_show.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_show.ForeColor = System.Drawing.Color.Black
        Me.cmd_show.Location = New System.Drawing.Point(647, 5)
        Me.cmd_show.Name = "cmd_show"
        Me.cmd_show.Size = New System.Drawing.Size(136, 30)
        Me.cmd_show.TabIndex = 33
        Me.cmd_show.Text = "Show Report"
        Me.cmd_show.UseVisualStyleBackColor = false
        '
        'Label18
        '
        Me.Label18.AutoSize = true
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(16, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 18)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Show from :"
        '
        'cmd_export
        '
        Me.cmd_export.BackColor = System.Drawing.Color.White
        Me.cmd_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_export.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_export.ForeColor = System.Drawing.Color.Black
        Me.cmd_export.Location = New System.Drawing.Point(1238, 6)
        Me.cmd_export.Name = "cmd_export"
        Me.cmd_export.Size = New System.Drawing.Size(88, 30)
        Me.cmd_export.TabIndex = 32
        Me.cmd_export.Text = "Export"
        Me.cmd_export.UseVisualStyleBackColor = false
        '
        'Label17
        '
        Me.Label17.AutoSize = true
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(356, 11)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 18)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "To :"
        '
        'cmd_print
        '
        Me.cmd_print.BackColor = System.Drawing.Color.White
        Me.cmd_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_print.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_print.ForeColor = System.Drawing.Color.Black
        Me.cmd_print.Location = New System.Drawing.Point(1144, 6)
        Me.cmd_print.Name = "cmd_print"
        Me.cmd_print.Size = New System.Drawing.Size(88, 30)
        Me.cmd_print.TabIndex = 31
        Me.cmd_print.Text = "Print"
        Me.cmd_print.UseVisualStyleBackColor = false
        '
        'dtp_purchases_from
        '
        Me.dtp_purchases_from.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dtp_purchases_from.Location = New System.Drawing.Point(119, 8)
        Me.dtp_purchases_from.Name = "dtp_purchases_from"
        Me.dtp_purchases_from.Size = New System.Drawing.Size(231, 23)
        Me.dtp_purchases_from.TabIndex = 33
        '
        'frm_current_stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1336, 677)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.crv_inventory_report)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frm_current_stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - Current Stock Report"
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents crv_inventory_report As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmd_print As System.Windows.Forms.Button
    Friend WithEvents cmd_export As System.Windows.Forms.Button
    Friend WithEvents cmd_show As System.Windows.Forms.Button
    Friend WithEvents dtp_purchases_to As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents dtp_purchases_from As DateTimePicker
End Class
