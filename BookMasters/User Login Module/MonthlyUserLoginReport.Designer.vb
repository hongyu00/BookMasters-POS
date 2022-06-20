<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonthlyUserLoginReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MonthlyUserLoginReport))
        Me.lblDiscountHeader = New System.Windows.Forms.Label()
        Me.grpReport = New System.Windows.Forms.GroupBox()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.printUserLoginReport = New System.Drawing.Printing.PrintDocument()
        Me.userLoginReportPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.grpReport.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDiscountHeader
        '
        Me.lblDiscountHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDiscountHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscountHeader.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountHeader.Location = New System.Drawing.Point(656, 430)
        Me.lblDiscountHeader.Name = "lblDiscountHeader"
        Me.lblDiscountHeader.Size = New System.Drawing.Size(1254, 142)
        Me.lblDiscountHeader.TabIndex = 9
        Me.lblDiscountHeader.Text = "Monthly User Login Report "
        Me.lblDiscountHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpReport
        '
        Me.grpReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grpReport.Controls.Add(Me.cboYear)
        Me.grpReport.Controls.Add(Me.cboMonth)
        Me.grpReport.Controls.Add(Me.lblYear)
        Me.grpReport.Controls.Add(Me.lblMonth)
        Me.grpReport.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpReport.Location = New System.Drawing.Point(734, 625)
        Me.grpReport.Name = "grpReport"
        Me.grpReport.Size = New System.Drawing.Size(1090, 228)
        Me.grpReport.TabIndex = 10
        Me.grpReport.TabStop = False
        Me.grpReport.Text = "Monthly User Login Report "
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {"2019", "2020", "2021"})
        Me.cboYear.Location = New System.Drawing.Point(893, 122)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(159, 41)
        Me.cboYear.TabIndex = 3
        '
        'cboMonth
        '
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboMonth.Location = New System.Drawing.Point(315, 122)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(200, 41)
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
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGenerate.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.ForeColor = System.Drawing.Color.White
        Me.btnGenerate.Location = New System.Drawing.Point(1192, 945)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(214, 85)
        Me.btnGenerate.TabIndex = 11
        Me.btnGenerate.Text = "&Generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'userLoginReportPreview
        '
        Me.userLoginReportPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.userLoginReportPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.userLoginReportPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.userLoginReportPreview.Enabled = True
        Me.userLoginReportPreview.Icon = CType(resources.GetObject("userLoginReportPreview.Icon"), System.Drawing.Icon)
        Me.userLoginReportPreview.Name = "userLoginReportPreview"
        Me.userLoginReportPreview.Visible = False
        '
        'MonthlyUserLoginReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.lblDiscountHeader)
        Me.Controls.Add(Me.grpReport)
        Me.Controls.Add(Me.btnGenerate)
        Me.Name = "MonthlyUserLoginReport"
        Me.Text = "Monthly User Login Report"
        Me.grpReport.ResumeLayout(False)
        Me.grpReport.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblDiscountHeader As Label
    Friend WithEvents grpReport As GroupBox
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents cboMonth As ComboBox
    Friend WithEvents lblYear As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents btnGenerate As Button
    Friend WithEvents printUserLoginReport As Printing.PrintDocument
    Friend WithEvents userLoginReportPreview As PrintPreviewDialog
End Class
