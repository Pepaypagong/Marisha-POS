<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_select_supplier
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgv_suppliers = New System.Windows.Forms.DataGridView()
        Me.supplier_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplier_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_select = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cmd_clear = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbo_search_by = New System.Windows.Forms.ComboBox()
        CType(Me.dgv_suppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "(Click Select to Select a Supplier)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Please Select a Supplier"
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
        Me.Button2.Location = New System.Drawing.Point(379, 504)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 47)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dgv_suppliers
        '
        Me.dgv_suppliers.AllowUserToAddRows = False
        Me.dgv_suppliers.AllowUserToDeleteRows = False
        Me.dgv_suppliers.AllowUserToResizeRows = False
        Me.dgv_suppliers.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_suppliers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_suppliers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_suppliers.ColumnHeadersHeight = 25
        Me.dgv_suppliers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.supplier_no, Me.supplier_name, Me.btn_select})
        Me.dgv_suppliers.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_suppliers.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_suppliers.EnableHeadersVisualStyles = False
        Me.dgv_suppliers.Location = New System.Drawing.Point(7, 112)
        Me.dgv_suppliers.MultiSelect = False
        Me.dgv_suppliers.Name = "dgv_suppliers"
        Me.dgv_suppliers.ReadOnly = True
        Me.dgv_suppliers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_suppliers.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_suppliers.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_suppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_suppliers.Size = New System.Drawing.Size(504, 386)
        Me.dgv_suppliers.TabIndex = 38
        '
        'supplier_no
        '
        Me.supplier_no.HeaderText = "Supplier No."
        Me.supplier_no.Name = "supplier_no"
        Me.supplier_no.ReadOnly = True
        Me.supplier_no.Width = 140
        '
        'supplier_name
        '
        Me.supplier_name.HeaderText = "Supplier Name"
        Me.supplier_name.Name = "supplier_name"
        Me.supplier_name.ReadOnly = True
        Me.supplier_name.Width = 230
        '
        'btn_select
        '
        Me.btn_select.HeaderText = "Select"
        Me.btn_select.Name = "btn_select"
        Me.btn_select.ReadOnly = True
        Me.btn_select.Text = "Select"
        Me.btn_select.UseColumnTextForButtonValue = True
        '
        'cmd_clear
        '
        Me.cmd_clear.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmd_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_clear.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_clear.ForeColor = System.Drawing.Color.White
        Me.cmd_clear.Location = New System.Drawing.Point(392, 80)
        Me.cmd_clear.Name = "cmd_clear"
        Me.cmd_clear.Size = New System.Drawing.Size(85, 28)
        Me.cmd_clear.TabIndex = 1
        Me.cmd_clear.Text = "Clear"
        Me.cmd_clear.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(183, 63)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(112, 16)
        Me.Label24.TabIndex = 45
        Me.Label24.Text = "Enter Keyword.."
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(178, 81)
        Me.txt_search.MaxLength = 30
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(208, 26)
        Me.txt_search.TabIndex = 0
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(12, 63)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(82, 16)
        Me.Label23.TabIndex = 42
        Me.Label23.Text = "Search By :"
        '
        'cbo_search_by
        '
        Me.cbo_search_by.BackColor = System.Drawing.Color.Gainsboro
        Me.cbo_search_by.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_search_by.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_search_by.FormattingEnabled = True
        Me.cbo_search_by.Location = New System.Drawing.Point(10, 82)
        Me.cbo_search_by.Name = "cbo_search_by"
        Me.cbo_search_by.Size = New System.Drawing.Size(162, 24)
        Me.cbo_search_by.TabIndex = 43
        '
        'frm_select_supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 557)
        Me.Controls.Add(Me.cmd_clear)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.cbo_search_by)
        Me.Controls.Add(Me.dgv_suppliers)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_select_supplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marisha POS - Select a Supplier"
        CType(Me.dgv_suppliers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dgv_suppliers As System.Windows.Forms.DataGridView
    Friend WithEvents supplier_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supplier_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_select As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cmd_clear As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cbo_search_by As System.Windows.Forms.ComboBox
End Class
