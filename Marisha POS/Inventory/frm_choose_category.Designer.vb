<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_choose_category
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
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbo_choose_cat = New System.Windows.Forms.ComboBox()
        Me.cmd_ok = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(12, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(282, 19)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Select an Item Category To Show"
        '
        'cbo_choose_cat
        '
        Me.cbo_choose_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_choose_cat.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_choose_cat.FormattingEnabled = True
        Me.cbo_choose_cat.Location = New System.Drawing.Point(16, 48)
        Me.cbo_choose_cat.Name = "cbo_choose_cat"
        Me.cbo_choose_cat.Size = New System.Drawing.Size(379, 26)
        Me.cbo_choose_cat.TabIndex = 12
        '
        'cmd_ok
        '
        Me.cmd_ok.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_ok.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ok.ForeColor = System.Drawing.Color.White
        Me.cmd_ok.Image = Global.Marisha_POS.My.Resources.Resources.add
        Me.cmd_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_ok.Location = New System.Drawing.Point(102, 91)
        Me.cmd_ok.Name = "cmd_ok"
        Me.cmd_ok.Size = New System.Drawing.Size(91, 47)
        Me.cmd_ok.TabIndex = 44
        Me.cmd_ok.Text = "Select"
        Me.cmd_ok.UseVisualStyleBackColor = False
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
        Me.Button2.Location = New System.Drawing.Point(211, 91)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 47)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frm_choose_category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 157)
        Me.Controls.Add(Me.cmd_ok)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cbo_choose_cat)
        Me.Controls.Add(Me.Label18)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_choose_category"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - Choose Category"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cbo_choose_cat As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_ok As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
