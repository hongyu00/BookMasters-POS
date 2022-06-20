<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVoucherReport
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
        Me.grpReport = New System.Windows.Forms.GroupBox()
        Me.mskYear = New System.Windows.Forms.MaskedTextBox()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.btnAvailable = New System.Windows.Forms.Button()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblDiscountHeader = New System.Windows.Forms.Label()
        Me.btnUsed = New System.Windows.Forms.Button()
        Me.grpReport.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpReport
        '
        Me.grpReport.Controls.Add(Me.mskYear)
        Me.grpReport.Controls.Add(Me.cboMonth)
        Me.grpReport.Controls.Add(Me.lblYear)
        Me.grpReport.Controls.Add(Me.lblMonth)
        Me.grpReport.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpReport.Location = New System.Drawing.Point(427, 475)
        Me.grpReport.Name = "grpReport"
        Me.grpReport.Size = New System.Drawing.Size(1090, 248)
        Me.grpReport.TabIndex = 1
        Me.grpReport.TabStop = False
        Me.grpReport.Text = "Month And Year Selection"
        '
        'mskYear
        '
        Me.mskYear.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskYear.Location = New System.Drawing.Point(878, 116)
        Me.mskYear.Mask = "0000"
        Me.mskYear.Name = "mskYear"
        Me.mskYear.Size = New System.Drawing.Size(123, 40)
        Me.mskYear.TabIndex = 3
        Me.mskYear.ValidatingType = GetType(Date)
        '
        'cboMonth
        '
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {"Voucher Device Management", "Customer Gift Voucher"})
        Me.cboMonth.Location = New System.Drawing.Point(308, 119)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(159, 41)
        Me.cboMonth.TabIndex = 1
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(643, 119)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(178, 33)
        Me.lblYear.TabIndex = 2
        Me.lblYear.Text = "Select &Year: "
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(54, 122)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(203, 33)
        Me.lblMonth.TabIndex = 0
        Me.lblMonth.Text = "Select &Month: "
        '
        'btnAvailable
        '
        Me.btnAvailable.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAvailable.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvailable.ForeColor = System.Drawing.Color.White
        Me.btnAvailable.Location = New System.Drawing.Point(487, 806)
        Me.btnAvailable.Name = "btnAvailable"
        Me.btnAvailable.Size = New System.Drawing.Size(394, 85)
        Me.btnAvailable.TabIndex = 2
        Me.btnAvailable.Text = "Voucher &Available Report "
        Me.btnAvailable.UseVisualStyleBackColor = False
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'lblDiscountHeader
        '
        Me.lblDiscountHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscountHeader.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountHeader.Location = New System.Drawing.Point(335, 175)
        Me.lblDiscountHeader.Name = "lblDiscountHeader"
        Me.lblDiscountHeader.Size = New System.Drawing.Size(1254, 142)
        Me.lblDiscountHeader.TabIndex = 0
        Me.lblDiscountHeader.Text = "Monthly Voucher Report "
        Me.lblDiscountHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUsed
        '
        Me.btnUsed.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUsed.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsed.ForeColor = System.Drawing.Color.White
        Me.btnUsed.Location = New System.Drawing.Point(1076, 806)
        Me.btnUsed.Name = "btnUsed"
        Me.btnUsed.Size = New System.Drawing.Size(394, 85)
        Me.btnUsed.TabIndex = 3
        Me.btnUsed.Text = "Voucher Used Report"
        Me.btnUsed.UseVisualStyleBackColor = False
        '
        'FrmVoucherReport
        '
        Me.AcceptButton = Me.btnAvailable
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.btnUsed)
        Me.Controls.Add(Me.grpReport)
        Me.Controls.Add(Me.btnAvailable)
        Me.Controls.Add(Me.lblDiscountHeader)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmVoucherReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Voucher Report"
        Me.grpReport.ResumeLayout(False)
        Me.grpReport.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpReport As GroupBox
    Friend WithEvents mskYear As MaskedTextBox
    Friend WithEvents cboMonth As ComboBox
    Friend WithEvents lblYear As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents btnAvailable As Button
    Friend WithEvents err As ErrorProvider
    Friend WithEvents lblDiscountHeader As Label
    Friend WithEvents btnUsed As Button
End Class
