<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_change_qty
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_item_name = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_barcode = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.cmd_done = New System.Windows.Forms.Button()
        Me.cmd_cancel = New System.Windows.Forms.Button()
        Me.lbl_current_stock_qty = New System.Windows.Forms.Label()
        Me.lbl_unit = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 19)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Change Quantity"
        '
        'lbl_item_name
        '
        Me.lbl_item_name.BackColor = System.Drawing.Color.White
        Me.lbl_item_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_item_name.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_item_name.Location = New System.Drawing.Point(139, 83)
        Me.lbl_item_name.Name = "lbl_item_name"
        Me.lbl_item_name.Size = New System.Drawing.Size(237, 27)
        Me.lbl_item_name.TabIndex = 87
        Me.lbl_item_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 18)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Item Barcode :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 18)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Item Name :"
        '
        'lbl_barcode
        '
        Me.lbl_barcode.BackColor = System.Drawing.Color.White
        Me.lbl_barcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_barcode.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_barcode.Location = New System.Drawing.Point(139, 52)
        Me.lbl_barcode.Name = "lbl_barcode"
        Me.lbl_barcode.Size = New System.Drawing.Size(237, 26)
        Me.lbl_barcode.TabIndex = 89
        Me.lbl_barcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 18)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Quantity :"
        '
        'txt_qty
        '
        Me.txt_qty.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.Location = New System.Drawing.Point(139, 115)
        Me.txt_qty.MaxLength = 8
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(103, 26)
        Me.txt_qty.TabIndex = 0
        '
        'cmd_done
        '
        Me.cmd_done.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_done.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_done.ForeColor = System.Drawing.Color.White
        Me.cmd_done.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_done.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_done.Location = New System.Drawing.Point(139, 158)
        Me.cmd_done.Name = "cmd_done"
        Me.cmd_done.Size = New System.Drawing.Size(103, 46)
        Me.cmd_done.TabIndex = 1
        Me.cmd_done.Text = "Done" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Enter)"
        Me.cmd_done.UseVisualStyleBackColor = False
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
        Me.cmd_cancel.Location = New System.Drawing.Point(286, 158)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(90, 46)
        Me.cmd_cancel.TabIndex = 2
        Me.cmd_cancel.Text = "Cancel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Esc)"
        Me.cmd_cancel.UseVisualStyleBackColor = False
        '
        'lbl_current_stock_qty
        '
        Me.lbl_current_stock_qty.BackColor = System.Drawing.Color.White
        Me.lbl_current_stock_qty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_current_stock_qty.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_current_stock_qty.Location = New System.Drawing.Point(349, 114)
        Me.lbl_current_stock_qty.Name = "lbl_current_stock_qty"
        Me.lbl_current_stock_qty.Size = New System.Drawing.Size(27, 27)
        Me.lbl_current_stock_qty.TabIndex = 92
        Me.lbl_current_stock_qty.Text = "0"
        Me.lbl_current_stock_qty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_current_stock_qty.Visible = False
        '
        'lbl_unit
        '
        Me.lbl_unit.BackColor = System.Drawing.Color.White
        Me.lbl_unit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_unit.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_unit.Location = New System.Drawing.Point(245, 114)
        Me.lbl_unit.Name = "lbl_unit"
        Me.lbl_unit.Size = New System.Drawing.Size(62, 27)
        Me.lbl_unit.TabIndex = 93
        Me.lbl_unit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_change_qty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 216)
        Me.Controls.Add(Me.lbl_unit)
        Me.Controls.Add(Me.lbl_current_stock_qty)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.cmd_done)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_barcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_item_name)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_change_qty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - Change Quantity"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_item_name As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_barcode As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_qty As System.Windows.Forms.TextBox
    Friend WithEvents cmd_done As System.Windows.Forms.Button
    Friend WithEvents cmd_cancel As System.Windows.Forms.Button
    Friend WithEvents lbl_current_stock_qty As System.Windows.Forms.Label
    Friend WithEvents lbl_unit As System.Windows.Forms.Label
End Class
