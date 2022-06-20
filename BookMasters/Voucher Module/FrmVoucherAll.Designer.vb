<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVoucherAll
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gvVoucher = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.lblViewAllVoucher = New System.Windows.Forms.Label()
        Me.ctmVoucher = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTipAdd = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnToolTips = New FontAwesome.Sharp.IconButton()
        CType(Me.gvVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctmVoucher.SuspendLayout()
        Me.SuspendLayout()
        '
        'gvVoucher
        '
        Me.gvVoucher.AllowUserToAddRows = False
        Me.gvVoucher.AllowUserToDeleteRows = False
        Me.gvVoucher.AllowUserToResizeColumns = False
        Me.gvVoucher.AllowUserToResizeRows = False
        Me.gvVoucher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvVoucher.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gvVoucher.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.gvVoucher.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvVoucher.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.gvVoucher.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gvVoucher.ColumnHeadersHeight = 50
        Me.gvVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvVoucher.DefaultCellStyle = DataGridViewCellStyle2
        Me.gvVoucher.EnableHeadersVisualStyles = False
        Me.gvVoucher.Location = New System.Drawing.Point(270, 259)
        Me.gvVoucher.Margin = New System.Windows.Forms.Padding(6)
        Me.gvVoucher.Name = "gvVoucher"
        Me.gvVoucher.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvVoucher.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.gvVoucher.RowHeadersVisible = False
        Me.gvVoucher.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gvVoucher.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.gvVoucher.RowTemplate.Height = 40
        Me.gvVoucher.RowTemplate.ReadOnly = True
        Me.gvVoucher.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvVoucher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvVoucher.Size = New System.Drawing.Size(1562, 605)
        Me.gvVoucher.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(1455, 904)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(136, 56)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(1696, 164)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(136, 56)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnShow.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Location = New System.Drawing.Point(1663, 904)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(6)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(169, 56)
        Me.btnShow.TabIndex = 3
        Me.btnShow.Text = "Sho&w Details"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'lblViewAllVoucher
        '
        Me.lblViewAllVoucher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblViewAllVoucher.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewAllVoucher.Location = New System.Drawing.Point(270, 114)
        Me.lblViewAllVoucher.Name = "lblViewAllVoucher"
        Me.lblViewAllVoucher.Size = New System.Drawing.Size(639, 92)
        Me.lblViewAllVoucher.TabIndex = 10
        Me.lblViewAllVoucher.Text = "View All Voucher"
        Me.lblViewAllVoucher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ctmVoucher
        '
        Me.ctmVoucher.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ctmVoucher.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAdd, Me.mnuSearch, Me.mnuShow})
        Me.ctmVoucher.Name = "ctmMember"
        Me.ctmVoucher.Size = New System.Drawing.Size(165, 76)
        '
        'mnuAdd
        '
        Me.mnuAdd.Name = "mnuAdd"
        Me.mnuAdd.Size = New System.Drawing.Size(164, 24)
        Me.mnuAdd.Text = "&Add "
        '
        'mnuSearch
        '
        Me.mnuSearch.Name = "mnuSearch"
        Me.mnuSearch.Size = New System.Drawing.Size(164, 24)
        Me.mnuSearch.Text = "&Search"
        '
        'mnuShow
        '
        Me.mnuShow.Name = "mnuShow"
        Me.mnuShow.Size = New System.Drawing.Size(164, 24)
        Me.mnuShow.Text = "Sho&w Details"
        '
        'ToolTipAdd
        '
        Me.ToolTipAdd.ShowAlways = True
        Me.ToolTipAdd.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipAdd.ToolTipTitle = "Reminder"
        '
        'btnToolTips
        '
        Me.btnToolTips.BackColor = System.Drawing.Color.Transparent
        Me.btnToolTips.FlatAppearance.BorderSize = 0
        Me.btnToolTips.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToolTips.IconChar = FontAwesome.Sharp.IconChar.Info
        Me.btnToolTips.IconColor = System.Drawing.Color.Orange
        Me.btnToolTips.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnToolTips.IconSize = 30
        Me.btnToolTips.Location = New System.Drawing.Point(1428, 916)
        Me.btnToolTips.Name = "btnToolTips"
        Me.btnToolTips.Size = New System.Drawing.Size(18, 32)
        Me.btnToolTips.TabIndex = 11
        Me.ToolTipAdd.SetToolTip(Me.btnToolTips, "Only manager is allowed to add new voucher")
        Me.btnToolTips.UseVisualStyleBackColor = False
        '
        'FrmVoucherAll
        '
        Me.AcceptButton = Me.btnShow
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.ContextMenuStrip = Me.ctmVoucher
        Me.Controls.Add(Me.btnToolTips)
        Me.Controls.Add(Me.lblViewAllVoucher)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.gvVoucher)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSearch)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FrmVoucherAll"
        Me.Text = "Voucher List"
        CType(Me.gvVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctmVoucher.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gvVoucher As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents lblViewAllVoucher As Label
    Friend WithEvents ctmVoucher As ContextMenuStrip
    Friend WithEvents mnuAdd As ToolStripMenuItem
    Friend WithEvents mnuSearch As ToolStripMenuItem
    Friend WithEvents mnuShow As ToolStripMenuItem
    Friend WithEvents ToolTipAdd As ToolTip
    Friend WithEvents btnToolTips As FontAwesome.Sharp.IconButton
End Class
