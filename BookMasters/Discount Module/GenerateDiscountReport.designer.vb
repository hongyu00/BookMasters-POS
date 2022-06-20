<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerateDiscountReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerateDiscountReport))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboDiscountYear = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboDiscountMonth = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGenerateMonthlyDiscountReport = New System.Windows.Forms.Button()
        Me.printMonthlyDiscountReport = New System.Drawing.Printing.PrintDocument()
        Me.monthlyDiscountReportPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.lblDiscountHeader = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboDiscountYear)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboDiscountMonth)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnGenerateMonthlyDiscountReport)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(886, 411)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(855, 521)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Monthly Discount Report "
        '
        'cboDiscountYear
        '
        Me.cboDiscountYear.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiscountYear.FormattingEnabled = True
        Me.cboDiscountYear.Location = New System.Drawing.Point(499, 103)
        Me.cboDiscountYear.Name = "cboDiscountYear"
        Me.cboDiscountYear.Size = New System.Drawing.Size(225, 48)
        Me.cboDiscountYear.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select &Year:"
        '
        'cboDiscountMonth
        '
        Me.cboDiscountMonth.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiscountMonth.FormattingEnabled = True
        Me.cboDiscountMonth.Location = New System.Drawing.Point(499, 215)
        Me.cboDiscountMonth.Name = "cboDiscountMonth"
        Me.cboDiscountMonth.Size = New System.Drawing.Size(225, 48)
        Me.cboDiscountMonth.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 40)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select &Month: "
        '
        'btnGenerateMonthlyDiscountReport
        '
        Me.btnGenerateMonthlyDiscountReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGenerateMonthlyDiscountReport.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateMonthlyDiscountReport.ForeColor = System.Drawing.Color.White
        Me.btnGenerateMonthlyDiscountReport.Location = New System.Drawing.Point(289, 366)
        Me.btnGenerateMonthlyDiscountReport.Name = "btnGenerateMonthlyDiscountReport"
        Me.btnGenerateMonthlyDiscountReport.Size = New System.Drawing.Size(289, 107)
        Me.btnGenerateMonthlyDiscountReport.TabIndex = 0
        Me.btnGenerateMonthlyDiscountReport.Text = "&Generate"
        Me.btnGenerateMonthlyDiscountReport.UseVisualStyleBackColor = False
        '
        'printMonthlyDiscountReport
        '
        '
        'monthlyDiscountReportPreview
        '
        Me.monthlyDiscountReportPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.monthlyDiscountReportPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.monthlyDiscountReportPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.monthlyDiscountReportPreview.Enabled = True
        Me.monthlyDiscountReportPreview.Icon = CType(resources.GetObject("monthlyDiscountReportPreview.Icon"), System.Drawing.Icon)
        Me.monthlyDiscountReportPreview.Name = "monthlyDiscountReportPreview"
        Me.monthlyDiscountReportPreview.Visible = False
        '
        'lblDiscountHeader
        '
        Me.lblDiscountHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscountHeader.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountHeader.Location = New System.Drawing.Point(689, 222)
        Me.lblDiscountHeader.Name = "lblDiscountHeader"
        Me.lblDiscountHeader.Size = New System.Drawing.Size(1157, 88)
        Me.lblDiscountHeader.TabIndex = 0
        Me.lblDiscountHeader.Text = "Monthly Discount Report "
        Me.lblDiscountHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GenerateDiscountReport
        '
        Me.AcceptButton = Me.btnGenerateMonthlyDiscountReport
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1924, 1040)
        Me.Controls.Add(Me.lblDiscountHeader)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "GenerateDiscountReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GenerateDiscountReport"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGenerateMonthlyDiscountReport As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cboDiscountMonth As ComboBox
    Friend WithEvents printMonthlyDiscountReport As Printing.PrintDocument
    Friend WithEvents monthlyDiscountReportPreview As PrintPreviewDialog
    Friend WithEvents cboDiscountYear As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDiscountHeader As Label
End Class
