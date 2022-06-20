<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVoucherAdd
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
        Me.lblRM2 = New System.Windows.Forms.Label()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpPeriod = New System.Windows.Forms.GroupBox()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblRM1 = New System.Windows.Forms.Label()
        Me.lblMinimum = New System.Windows.Forms.Label()
        Me.txtMinimum = New System.Windows.Forms.TextBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPeriod.SuspendLayout()
        Me.grpInfo.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRM2
        '
        Me.lblRM2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRM2.Location = New System.Drawing.Point(231, 115)
        Me.lblRM2.Name = "lblRM2"
        Me.lblRM2.Size = New System.Drawing.Size(39, 23)
        Me.lblRM2.TabIndex = 4
        Me.lblRM2.Text = "RM"
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'grpPeriod
        '
        Me.grpPeriod.Controls.Add(Me.dtpEnd)
        Me.grpPeriod.Controls.Add(Me.lblStart)
        Me.grpPeriod.Controls.Add(Me.lblEnd)
        Me.grpPeriod.Controls.Add(Me.dtpStart)
        Me.grpPeriod.Font = New System.Drawing.Font("Century Gothic", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPeriod.Location = New System.Drawing.Point(136, 312)
        Me.grpPeriod.Name = "grpPeriod"
        Me.grpPeriod.Size = New System.Drawing.Size(737, 131)
        Me.grpPeriod.TabIndex = 2
        Me.grpPeriod.TabStop = False
        Me.grpPeriod.Text = "Period"
        '
        'dtpEnd
        '
        Me.dtpEnd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnd.Location = New System.Drawing.Point(294, 83)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(372, 32)
        Me.dtpEnd.TabIndex = 3
        Me.dtpEnd.Value = New Date(2020, 12, 2, 0, 0, 0, 0)
        '
        'lblStart
        '
        Me.lblStart.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.Location = New System.Drawing.Point(100, 42)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(120, 23)
        Me.lblStart.TabIndex = 0
        Me.lblStart.Text = "&Start Date :"
        '
        'lblEnd
        '
        Me.lblEnd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.Location = New System.Drawing.Point(99, 90)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(113, 23)
        Me.lblEnd.TabIndex = 2
        Me.lblEnd.Text = "&End Date :"
        '
        'dtpStart
        '
        Me.dtpStart.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStart.Location = New System.Drawing.Point(294, 35)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(372, 32)
        Me.dtpStart.TabIndex = 1
        Me.dtpStart.Value = New Date(2020, 12, 2, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Discount Amount :"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(295, 52)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(181, 32)
        Me.txtAmount.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(649, 473)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(135, 50)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(227, 473)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(135, 50)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblRM1
        '
        Me.lblRM1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRM1.Location = New System.Drawing.Point(231, 57)
        Me.lblRM1.Name = "lblRM1"
        Me.lblRM1.Size = New System.Drawing.Size(39, 23)
        Me.lblRM1.TabIndex = 1
        Me.lblRM1.Text = "RM"
        '
        'lblMinimum
        '
        Me.lblMinimum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimum.Location = New System.Drawing.Point(10, 115)
        Me.lblMinimum.Name = "lblMinimum"
        Me.lblMinimum.Size = New System.Drawing.Size(184, 23)
        Me.lblMinimum.TabIndex = 3
        Me.lblMinimum.Text = "&Minumum Spend :"
        '
        'txtMinimum
        '
        Me.txtMinimum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinimum.Location = New System.Drawing.Point(295, 111)
        Me.txtMinimum.Name = "txtMinimum"
        Me.txtMinimum.Size = New System.Drawing.Size(181, 32)
        Me.txtMinimum.TabIndex = 5
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(720, 52)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(150, 31)
        Me.cboType.TabIndex = 7
        '
        'lblType
        '
        Me.lblType.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(522, 57)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(172, 23)
        Me.lblType.TabIndex = 6
        Me.lblType.Text = "Voucher &Type :"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(349, 21)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(232, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Add New Voucher"
        '
        'grpInfo
        '
        Me.grpInfo.Controls.Add(Me.lblRM2)
        Me.grpInfo.Controls.Add(Me.lblRM1)
        Me.grpInfo.Controls.Add(Me.Label2)
        Me.grpInfo.Controls.Add(Me.txtAmount)
        Me.grpInfo.Controls.Add(Me.lblMinimum)
        Me.grpInfo.Controls.Add(Me.txtMinimum)
        Me.grpInfo.Controls.Add(Me.cboType)
        Me.grpInfo.Controls.Add(Me.lblType)
        Me.grpInfo.Font = New System.Drawing.Font("Century Gothic", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInfo.Location = New System.Drawing.Point(50, 109)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(892, 171)
        Me.grpInfo.TabIndex = 1
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Voucher Info"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(984, 73)
        Me.pnlHeader.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(446, 473)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(135, 50)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'FrmVoucherAdd
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(984, 549)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.grpPeriod)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmVoucherAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Voucher"
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPeriod.ResumeLayout(False)
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblRM2 As Label
    Friend WithEvents err As ErrorProvider
    Friend WithEvents grpPeriod As GroupBox
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents lblStart As Label
    Friend WithEvents lblEnd As Label
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents btnExit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents grpInfo As GroupBox
    Friend WithEvents lblRM1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblMinimum As Label
    Friend WithEvents txtMinimum As TextBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents lblType As Label
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnCancel As Button
End Class
