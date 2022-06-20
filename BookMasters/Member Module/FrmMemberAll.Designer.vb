<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMemberAll
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnRenew = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.gvMember = New System.Windows.Forms.DataGridView()
        Me.lblViewAllMem = New System.Windows.Forms.Label()
        Me.ctmMember = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRenew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTipAdd = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnToolTips = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        CType(Me.gvMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctmMember.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnShow.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Location = New System.Drawing.Point(1655, 921)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(5)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(159, 54)
        Me.btnShow.TabIndex = 5
        Me.btnShow.Text = "Sho&w Details"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(1655, 156)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(159, 54)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Searc&h"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnRenew
        '
        Me.btnRenew.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRenew.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRenew.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRenew.ForeColor = System.Drawing.Color.White
        Me.btnRenew.Location = New System.Drawing.Point(1413, 921)
        Me.btnRenew.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRenew.Name = "btnRenew"
        Me.btnRenew.Size = New System.Drawing.Size(159, 54)
        Me.btnRenew.TabIndex = 4
        Me.btnRenew.Text = "Re&new"
        Me.btnRenew.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(1161, 921)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(159, 54)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'gvMember
        '
        Me.gvMember.AllowUserToAddRows = False
        Me.gvMember.AllowUserToDeleteRows = False
        Me.gvMember.AllowUserToResizeColumns = False
        Me.gvMember.AllowUserToResizeRows = False
        Me.gvMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvMember.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gvMember.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.gvMember.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvMember.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.gvMember.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gvMember.ColumnHeadersHeight = 50
        Me.gvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvMember.DefaultCellStyle = DataGridViewCellStyle2
        Me.gvMember.EnableHeadersVisualStyles = False
        Me.gvMember.Location = New System.Drawing.Point(341, 236)
        Me.gvMember.Margin = New System.Windows.Forms.Padding(5)
        Me.gvMember.Name = "gvMember"
        Me.gvMember.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvMember.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.gvMember.RowHeadersVisible = False
        Me.gvMember.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gvMember.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.gvMember.RowTemplate.Height = 40
        Me.gvMember.RowTemplate.ReadOnly = True
        Me.gvMember.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvMember.Size = New System.Drawing.Size(1473, 642)
        Me.gvMember.TabIndex = 1
        '
        'lblViewAllMem
        '
        Me.lblViewAllMem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblViewAllMem.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewAllMem.Location = New System.Drawing.Point(341, 107)
        Me.lblViewAllMem.Name = "lblViewAllMem"
        Me.lblViewAllMem.Size = New System.Drawing.Size(639, 92)
        Me.lblViewAllMem.TabIndex = 0
        Me.lblViewAllMem.Text = "View All Member"
        Me.lblViewAllMem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ctmMember
        '
        Me.ctmMember.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ctmMember.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAdd, Me.mnuRenew, Me.mnuSearch, Me.mnuShow})
        Me.ctmMember.Name = "ctmMember"
        Me.ctmMember.Size = New System.Drawing.Size(165, 100)
        '
        'mnuAdd
        '
        Me.mnuAdd.Name = "mnuAdd"
        Me.mnuAdd.Size = New System.Drawing.Size(164, 24)
        Me.mnuAdd.Text = "&Add "
        '
        'mnuRenew
        '
        Me.mnuRenew.Name = "mnuRenew"
        Me.mnuRenew.Size = New System.Drawing.Size(164, 24)
        Me.mnuRenew.Text = "Re&new"
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
        Me.btnToolTips.Location = New System.Drawing.Point(1135, 932)
        Me.btnToolTips.Name = "btnToolTips"
        Me.btnToolTips.Size = New System.Drawing.Size(18, 32)
        Me.btnToolTips.TabIndex = 6
        Me.ToolTipAdd.SetToolTip(Me.btnToolTips, "Only manager is allowed to add new member without payment")
        Me.btnToolTips.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Info
        Me.IconButton1.IconColor = System.Drawing.Color.Orange
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 30
        Me.IconButton1.Location = New System.Drawing.Point(1387, 932)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(18, 32)
        Me.IconButton1.TabIndex = 7
        Me.ToolTipAdd.SetToolTip(Me.IconButton1, "Only manager is allowed to renew membership without payment")
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'FrmMemberAll
        '
        Me.AcceptButton = Me.btnShow
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1924, 1016)
        Me.ContextMenuStrip = Me.ctmMember
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.btnToolTips)
        Me.Controls.Add(Me.lblViewAllMem)
        Me.Controls.Add(Me.gvMember)
        Me.Controls.Add(Me.btnRenew)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnShow)
        Me.Font = New System.Drawing.Font("Century Gothic", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FrmMemberAll"
        Me.Text = "Member List"
        CType(Me.gvMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctmMember.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MemberIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberPointDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnShow As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnRenew As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents gvMember As DataGridView
    Friend WithEvents lblViewAllMem As Label
    Friend WithEvents ctmMember As ContextMenuStrip
    Friend WithEvents mnuAdd As ToolStripMenuItem
    Friend WithEvents mnuRenew As ToolStripMenuItem
    Friend WithEvents mnuSearch As ToolStripMenuItem
    Friend WithEvents mnuShow As ToolStripMenuItem
    Friend WithEvents ToolTipAdd As ToolTip
    Friend WithEvents btnToolTips As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
