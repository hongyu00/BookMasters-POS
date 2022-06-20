<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonthlyStaffJoinedReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MonthlyStaffJoinedReport))
        Me.printStaffReport = New System.Drawing.Printing.PrintDocument()
        Me.staffReportPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.lblDiscountHeader = New System.Windows.Forms.Label()
        Me.grpReport = New System.Windows.Forms.GroupBox()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.grpReport.SuspendLayout()
        Me.SuspendLayout()
        '
        'printStaffReport
        '
        '
        'staffReportPreview
        '
        resources.ApplyResources(Me.staffReportPreview, "staffReportPreview")
        Me.staffReportPreview.Name = "staffReportPreview"
        '
        'lblDiscountHeader
        '
        Me.lblDiscountHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDiscountHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.lblDiscountHeader, "lblDiscountHeader")
        Me.lblDiscountHeader.Name = "lblDiscountHeader"
        '
        'grpReport
        '
        Me.grpReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grpReport.Controls.Add(Me.cboYear)
        Me.grpReport.Controls.Add(Me.cboMonth)
        Me.grpReport.Controls.Add(Me.lblYear)
        Me.grpReport.Controls.Add(Me.lblMonth)
        resources.ApplyResources(Me.grpReport, "grpReport")
        Me.grpReport.Name = "grpReport"
        Me.grpReport.TabStop = False
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cboYear, "cboYear")
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {resources.GetString("cboYear.Items"), resources.GetString("cboYear.Items1"), resources.GetString("cboYear.Items2")})
        Me.cboYear.Name = "cboYear"
        '
        'cboMonth
        '
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cboMonth, "cboMonth")
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {resources.GetString("cboMonth.Items"), resources.GetString("cboMonth.Items1"), resources.GetString("cboMonth.Items2"), resources.GetString("cboMonth.Items3"), resources.GetString("cboMonth.Items4"), resources.GetString("cboMonth.Items5"), resources.GetString("cboMonth.Items6"), resources.GetString("cboMonth.Items7"), resources.GetString("cboMonth.Items8"), resources.GetString("cboMonth.Items9"), resources.GetString("cboMonth.Items10"), resources.GetString("cboMonth.Items11")})
        Me.cboMonth.Name = "cboMonth"
        '
        'lblYear
        '
        resources.ApplyResources(Me.lblYear, "lblYear")
        Me.lblYear.Name = "lblYear"
        '
        'lblMonth
        '
        resources.ApplyResources(Me.lblMonth, "lblMonth")
        Me.lblMonth.Name = "lblMonth"
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        resources.ApplyResources(Me.btnGenerate, "btnGenerate")
        Me.btnGenerate.ForeColor = System.Drawing.Color.White
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'MonthlyStaffJoinedReport
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Controls.Add(Me.lblDiscountHeader)
        Me.Controls.Add(Me.grpReport)
        Me.Controls.Add(Me.btnGenerate)
        Me.Name = "MonthlyStaffJoinedReport"
        Me.grpReport.ResumeLayout(False)
        Me.grpReport.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents printStaffReport As Printing.PrintDocument
    Friend WithEvents staffReportPreview As PrintPreviewDialog
    Friend WithEvents lblDiscountHeader As Label
    Friend WithEvents grpReport As GroupBox
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents cboMonth As ComboBox
    Friend WithEvents lblYear As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents btnGenerate As Button
End Class
