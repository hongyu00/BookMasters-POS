<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVoucherDetailsNUpdate
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
        Me.grpView = New System.Windows.Forms.GroupBox()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.lblLVoucherID = New System.Windows.Forms.Label()
        Me.lblVoucherID = New System.Windows.Forms.Label()
        Me.lblStaff = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.lblVoucherStatus = New System.Windows.Forms.Label()
        Me.lblVoucherType = New System.Windows.Forms.Label()
        Me.dtpCustDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpGenerated = New System.Windows.Forms.DateTimePicker()
        Me.lblLGenerated = New System.Windows.Forms.Label()
        Me.dtpAppliedDate = New System.Windows.Forms.DateTimePicker()
        Me.lblCustDate = New System.Windows.Forms.Label()
        Me.lblAplied = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblMinimum = New System.Windows.Forms.Label()
        Me.txtMinimum = New System.Windows.Forms.TextBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTipEdit = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnToolTips = New FontAwesome.Sharp.IconButton()
        Me.grpView.SuspendLayout()
        Me.grpInfo.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpView
        '
        Me.grpView.Controls.Add(Me.lblStaffID)
        Me.grpView.Controls.Add(Me.lblLVoucherID)
        Me.grpView.Controls.Add(Me.lblVoucherID)
        Me.grpView.Controls.Add(Me.lblStaff)
        Me.grpView.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpView.Location = New System.Drawing.Point(23, 112)
        Me.grpView.Margin = New System.Windows.Forms.Padding(4)
        Me.grpView.Name = "grpView"
        Me.grpView.Padding = New System.Windows.Forms.Padding(4)
        Me.grpView.Size = New System.Drawing.Size(985, 111)
        Me.grpView.TabIndex = 1
        Me.grpView.TabStop = False
        '
        'lblStaffID
        '
        Me.lblStaffID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStaffID.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffID.Location = New System.Drawing.Point(761, 46)
        Me.lblStaffID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(206, 33)
        Me.lblStaffID.TabIndex = 3
        '
        'lblLVoucherID
        '
        Me.lblLVoucherID.AutoSize = True
        Me.lblLVoucherID.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLVoucherID.Location = New System.Drawing.Point(86, 49)
        Me.lblLVoucherID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLVoucherID.Name = "lblLVoucherID"
        Me.lblLVoucherID.Size = New System.Drawing.Size(114, 21)
        Me.lblLVoucherID.TabIndex = 0
        Me.lblLVoucherID.Text = "Voucher I&D :"
        '
        'lblVoucherID
        '
        Me.lblVoucherID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVoucherID.Location = New System.Drawing.Point(238, 46)
        Me.lblVoucherID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVoucherID.Name = "lblVoucherID"
        Me.lblVoucherID.Size = New System.Drawing.Size(250, 33)
        Me.lblVoucherID.TabIndex = 1
        '
        'lblStaff
        '
        Me.lblStaff.AutoSize = True
        Me.lblStaff.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaff.Location = New System.Drawing.Point(611, 49)
        Me.lblStaff.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStaff.Name = "lblStaff"
        Me.lblStaff.Size = New System.Drawing.Size(129, 21)
        Me.lblStaff.TabIndex = 2
        Me.lblStaff.Text = "Sta&ff Created:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(350, 824)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(144, 54)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Sa&ve"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'grpInfo
        '
        Me.grpInfo.Controls.Add(Me.lblVoucherStatus)
        Me.grpInfo.Controls.Add(Me.lblVoucherType)
        Me.grpInfo.Controls.Add(Me.dtpCustDate)
        Me.grpInfo.Controls.Add(Me.dtpGenerated)
        Me.grpInfo.Controls.Add(Me.lblLGenerated)
        Me.grpInfo.Controls.Add(Me.dtpAppliedDate)
        Me.grpInfo.Controls.Add(Me.lblCustDate)
        Me.grpInfo.Controls.Add(Me.lblAplied)
        Me.grpInfo.Controls.Add(Me.lblStatus)
        Me.grpInfo.Controls.Add(Me.dtpEnd)
        Me.grpInfo.Controls.Add(Me.lblStart)
        Me.grpInfo.Controls.Add(Me.lblEnd)
        Me.grpInfo.Controls.Add(Me.dtpStart)
        Me.grpInfo.Controls.Add(Me.Label2)
        Me.grpInfo.Controls.Add(Me.txtAmount)
        Me.grpInfo.Controls.Add(Me.lblMinimum)
        Me.grpInfo.Controls.Add(Me.txtMinimum)
        Me.grpInfo.Controls.Add(Me.lblType)
        Me.grpInfo.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInfo.Location = New System.Drawing.Point(23, 254)
        Me.grpInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Padding = New System.Windows.Forms.Padding(4)
        Me.grpInfo.Size = New System.Drawing.Size(985, 540)
        Me.grpInfo.TabIndex = 3
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Voucher Information"
        '
        'lblVoucherStatus
        '
        Me.lblVoucherStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVoucherStatus.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVoucherStatus.Location = New System.Drawing.Point(855, 127)
        Me.lblVoucherStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVoucherStatus.Name = "lblVoucherStatus"
        Me.lblVoucherStatus.Size = New System.Drawing.Size(114, 33)
        Me.lblVoucherStatus.TabIndex = 19
        '
        'lblVoucherType
        '
        Me.lblVoucherType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVoucherType.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVoucherType.Location = New System.Drawing.Point(853, 54)
        Me.lblVoucherType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVoucherType.Name = "lblVoucherType"
        Me.lblVoucherType.Size = New System.Drawing.Size(114, 33)
        Me.lblVoucherType.TabIndex = 4
        '
        'dtpCustDate
        '
        Me.dtpCustDate.CustomFormat = "  "
        Me.dtpCustDate.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCustDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCustDate.Location = New System.Drawing.Point(272, 403)
        Me.dtpCustDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpCustDate.Name = "dtpCustDate"
        Me.dtpCustDate.Size = New System.Drawing.Size(410, 36)
        Me.dtpCustDate.TabIndex = 18
        Me.dtpCustDate.Value = New Date(2020, 1, 1, 0, 0, 0, 0)
        '
        'dtpGenerated
        '
        Me.dtpGenerated.Enabled = False
        Me.dtpGenerated.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpGenerated.Location = New System.Drawing.Point(272, 197)
        Me.dtpGenerated.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpGenerated.Name = "dtpGenerated"
        Me.dtpGenerated.Size = New System.Drawing.Size(410, 36)
        Me.dtpGenerated.TabIndex = 5
        '
        'lblLGenerated
        '
        Me.lblLGenerated.AutoSize = True
        Me.lblLGenerated.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLGenerated.Location = New System.Drawing.Point(38, 210)
        Me.lblLGenerated.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLGenerated.Name = "lblLGenerated"
        Me.lblLGenerated.Size = New System.Drawing.Size(162, 21)
        Me.lblLGenerated.TabIndex = 4
        Me.lblLGenerated.Text = "&Generated Date :"
        '
        'dtpAppliedDate
        '
        Me.dtpAppliedDate.CustomFormat = "  "
        Me.dtpAppliedDate.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAppliedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAppliedDate.Location = New System.Drawing.Point(272, 473)
        Me.dtpAppliedDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpAppliedDate.Name = "dtpAppliedDate"
        Me.dtpAppliedDate.Size = New System.Drawing.Size(410, 36)
        Me.dtpAppliedDate.TabIndex = 13
        Me.dtpAppliedDate.Value = New Date(2020, 1, 1, 0, 0, 0, 0)
        '
        'lblCustDate
        '
        Me.lblCustDate.AutoSize = True
        Me.lblCustDate.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustDate.Location = New System.Drawing.Point(38, 416)
        Me.lblCustDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustDate.Name = "lblCustDate"
        Me.lblCustDate.Size = New System.Drawing.Size(186, 21)
        Me.lblCustDate.TabIndex = 10
        Me.lblCustDate.Text = "Customer &Get Date :"
        '
        'lblAplied
        '
        Me.lblAplied.AutoSize = True
        Me.lblAplied.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAplied.Location = New System.Drawing.Point(38, 486)
        Me.lblAplied.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAplied.Name = "lblAplied"
        Me.lblAplied.Size = New System.Drawing.Size(134, 21)
        Me.lblAplied.TabIndex = 12
        Me.lblAplied.Text = "&Applied Date :"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(700, 133)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(147, 21)
        Me.lblStatus.TabIndex = 16
        Me.lblStatus.Text = "V&oucher Status :"
        '
        'dtpEnd
        '
        Me.dtpEnd.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnd.Location = New System.Drawing.Point(272, 334)
        Me.dtpEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(410, 36)
        Me.dtpEnd.TabIndex = 9
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.Location = New System.Drawing.Point(38, 281)
        Me.lblStart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(107, 21)
        Me.lblStart.TabIndex = 6
        Me.lblStart.Text = "&Start Date :"
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.Location = New System.Drawing.Point(38, 347)
        Me.lblEnd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(99, 21)
        Me.lblEnd.TabIndex = 8
        Me.lblEnd.Text = "&End Date :"
        '
        'dtpStart
        '
        Me.dtpStart.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStart.Location = New System.Drawing.Point(272, 268)
        Me.dtpStart.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(410, 36)
        Me.dtpStart.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Discount Amount :"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(272, 54)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(225, 36)
        Me.txtAmount.TabIndex = 1
        '
        'lblMinimum
        '
        Me.lblMinimum.AutoSize = True
        Me.lblMinimum.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimum.Location = New System.Drawing.Point(38, 135)
        Me.lblMinimum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinimum.Name = "lblMinimum"
        Me.lblMinimum.Size = New System.Drawing.Size(151, 21)
        Me.lblMinimum.TabIndex = 2
        Me.lblMinimum.Text = "&Minimum Spend :"
        '
        'txtMinimum
        '
        Me.txtMinimum.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinimum.Location = New System.Drawing.Point(272, 124)
        Me.txtMinimum.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMinimum.Name = "txtMinimum"
        Me.txtMinimum.Size = New System.Drawing.Size(225, 36)
        Me.txtMinimum.TabIndex = 3
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(700, 59)
        Me.lblType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(135, 21)
        Me.lblType.TabIndex = 14
        Me.lblType.Text = "Voucher &Type :"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(134, 824)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(144, 54)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "Ed&it"
        Me.ToolTipEdit.SetToolTip(Me.btnEdit, "Only manager are allowed to edit the following items:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Discount Amount" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Minim" &
        "um Spend" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Start Date" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- End Date")
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1033, 90)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(420, 33)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(202, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Voucher Details"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(773, 824)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(144, 54)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(566, 824)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(144, 54)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'ToolTipEdit
        '
        Me.ToolTipEdit.ShowAlways = True
        Me.ToolTipEdit.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipEdit.ToolTipTitle = "Reminder"
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
        Me.btnToolTips.Location = New System.Drawing.Point(98, 836)
        Me.btnToolTips.Name = "btnToolTips"
        Me.btnToolTips.Size = New System.Drawing.Size(18, 32)
        Me.btnToolTips.TabIndex = 12
        Me.ToolTipEdit.SetToolTip(Me.btnToolTips, "Only manager are allowed to edit the following items:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Discount Amount" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Minim" &
        "um Spend" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Start Date" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- End Date" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnToolTips.UseVisualStyleBackColor = False
        '
        'FrmVoucherDetailsNUpdate
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1033, 910)
        Me.Controls.Add(Me.btnToolTips)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpView)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmVoucherDetailsNUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Voucher Details"
        Me.grpView.ResumeLayout(False)
        Me.grpView.PerformLayout()
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpView As GroupBox
    Friend WithEvents lblLVoucherID As Label
    Friend WithEvents lblVoucherID As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents grpInfo As GroupBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblMinimum As Label
    Friend WithEvents txtMinimum As TextBox
    Friend WithEvents lblType As Label
    Friend WithEvents lblStaff As Label
    Friend WithEvents dtpAppliedDate As DateTimePicker
    Friend WithEvents lblCustDate As Label
    Friend WithEvents lblAplied As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents lblStart As Label
    Friend WithEvents lblEnd As Label
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblStaffID As Label
    Friend WithEvents err As ErrorProvider
    Friend WithEvents dtpGenerated As DateTimePicker
    Friend WithEvents lblLGenerated As Label
    Friend WithEvents dtpCustDate As DateTimePicker
    Friend WithEvents lblVoucherStatus As Label
    Friend WithEvents lblVoucherType As Label
    Friend WithEvents ToolTipEdit As ToolTip
    Friend WithEvents btnToolTips As FontAwesome.Sharp.IconButton
End Class
