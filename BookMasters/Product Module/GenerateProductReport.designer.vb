<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GenerateProductReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerateProductReport))
        Me.grpNewBooks = New System.Windows.Forms.GroupBox()
        Me.cbonewBookArrivalsYear = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboNewBookArrivalsMonth = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGenerateNewBookArrivals = New System.Windows.Forms.Button()
        Me.printNewBookArrivalsReport = New System.Drawing.Printing.PrintDocument()
        Me.newBookArrivalsPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.grpInventory = New System.Windows.Forms.GroupBox()
        Me.btnGenerateInventorySummary = New System.Windows.Forms.Button()
        Me.printInventorySummaryReport = New System.Drawing.Printing.PrintDocument()
        Me.inventorySummaryPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.lblDiscountHeader = New System.Windows.Forms.Label()
        Me.grpNewBooks.SuspendLayout()
        Me.grpInventory.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpNewBooks
        '
        Me.grpNewBooks.Controls.Add(Me.cbonewBookArrivalsYear)
        Me.grpNewBooks.Controls.Add(Me.Label1)
        Me.grpNewBooks.Controls.Add(Me.cboNewBookArrivalsMonth)
        Me.grpNewBooks.Controls.Add(Me.Label3)
        Me.grpNewBooks.Controls.Add(Me.btnGenerateNewBookArrivals)
        Me.grpNewBooks.Font = New System.Drawing.Font("Century Gothic", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpNewBooks.Location = New System.Drawing.Point(553, 462)
        Me.grpNewBooks.Name = "grpNewBooks"
        Me.grpNewBooks.Size = New System.Drawing.Size(658, 420)
        Me.grpNewBooks.TabIndex = 0
        Me.grpNewBooks.TabStop = False
        Me.grpNewBooks.Text = "&Monthly New Book Arrivals Report "
        '
        'cbonewBookArrivalsYear
        '
        Me.cbonewBookArrivalsYear.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbonewBookArrivalsYear.FormattingEnabled = True
        Me.cbonewBookArrivalsYear.Location = New System.Drawing.Point(358, 88)
        Me.cbonewBookArrivalsYear.Name = "cbonewBookArrivalsYear"
        Me.cbonewBookArrivalsYear.Size = New System.Drawing.Size(153, 34)
        Me.cbonewBookArrivalsYear.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select &Year:"
        '
        'cboNewBookArrivalsMonth
        '
        Me.cboNewBookArrivalsMonth.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNewBookArrivalsMonth.FormattingEnabled = True
        Me.cboNewBookArrivalsMonth.Location = New System.Drawing.Point(358, 185)
        Me.cboNewBookArrivalsMonth.Name = "cboNewBookArrivalsMonth"
        Me.cboNewBookArrivalsMonth.Size = New System.Drawing.Size(153, 34)
        Me.cboNewBookArrivalsMonth.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Select &Month:"
        '
        'btnGenerateNewBookArrivals
        '
        Me.btnGenerateNewBookArrivals.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGenerateNewBookArrivals.Font = New System.Drawing.Font("Century Gothic", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateNewBookArrivals.ForeColor = System.Drawing.Color.White
        Me.btnGenerateNewBookArrivals.Location = New System.Drawing.Point(127, 281)
        Me.btnGenerateNewBookArrivals.Name = "btnGenerateNewBookArrivals"
        Me.btnGenerateNewBookArrivals.Size = New System.Drawing.Size(277, 92)
        Me.btnGenerateNewBookArrivals.TabIndex = 2
        Me.btnGenerateNewBookArrivals.Text = "G&enerate"
        Me.btnGenerateNewBookArrivals.UseVisualStyleBackColor = False
        '
        'printNewBookArrivalsReport
        '
        '
        'newBookArrivalsPreview
        '
        Me.newBookArrivalsPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.newBookArrivalsPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.newBookArrivalsPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.newBookArrivalsPreview.Enabled = True
        Me.newBookArrivalsPreview.Icon = CType(resources.GetObject("newBookArrivalsPreview.Icon"), System.Drawing.Icon)
        Me.newBookArrivalsPreview.Name = "newBookArrivalsPreview"
        Me.newBookArrivalsPreview.Visible = False
        '
        'grpInventory
        '
        Me.grpInventory.Controls.Add(Me.btnGenerateInventorySummary)
        Me.grpInventory.Font = New System.Drawing.Font("Century Gothic", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInventory.Location = New System.Drawing.Point(1282, 462)
        Me.grpInventory.Name = "grpInventory"
        Me.grpInventory.Size = New System.Drawing.Size(658, 420)
        Me.grpInventory.TabIndex = 3
        Me.grpInventory.TabStop = False
        Me.grpInventory.Text = "&Inventory Summary Report"
        '
        'btnGenerateInventorySummary
        '
        Me.btnGenerateInventorySummary.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGenerateInventorySummary.Font = New System.Drawing.Font("Century Gothic", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateInventorySummary.ForeColor = System.Drawing.Color.White
        Me.btnGenerateInventorySummary.Location = New System.Drawing.Point(193, 281)
        Me.btnGenerateInventorySummary.Name = "btnGenerateInventorySummary"
        Me.btnGenerateInventorySummary.Size = New System.Drawing.Size(277, 92)
        Me.btnGenerateInventorySummary.TabIndex = 2
        Me.btnGenerateInventorySummary.Text = "G&enerate"
        Me.btnGenerateInventorySummary.UseVisualStyleBackColor = False
        '
        'printInventorySummaryReport
        '
        '
        'inventorySummaryPreview
        '
        Me.inventorySummaryPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.inventorySummaryPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.inventorySummaryPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.inventorySummaryPreview.Enabled = True
        Me.inventorySummaryPreview.Icon = CType(resources.GetObject("inventorySummaryPreview.Icon"), System.Drawing.Icon)
        Me.inventorySummaryPreview.Name = "inventorySummaryPreview"
        Me.inventorySummaryPreview.Visible = False
        '
        'lblDiscountHeader
        '
        Me.lblDiscountHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscountHeader.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountHeader.Location = New System.Drawing.Point(448, 145)
        Me.lblDiscountHeader.Name = "lblDiscountHeader"
        Me.lblDiscountHeader.Size = New System.Drawing.Size(1603, 196)
        Me.lblDiscountHeader.TabIndex = 4
        Me.lblDiscountHeader.Text = "Monthly Product Report "
        Me.lblDiscountHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GenerateProductReport
        '
        Me.AcceptButton = Me.btnGenerateNewBookArrivals
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.lblDiscountHeader)
        Me.Controls.Add(Me.grpInventory)
        Me.Controls.Add(Me.grpNewBooks)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "GenerateProductReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GenerateProductReport"
        Me.grpNewBooks.ResumeLayout(False)
        Me.grpNewBooks.PerformLayout()
        Me.grpInventory.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpNewBooks As GroupBox
    Friend WithEvents btnGenerateNewBookArrivals As Button
    Friend WithEvents cboNewBookArrivalsMonth As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents printNewBookArrivalsReport As Printing.PrintDocument
    Friend WithEvents newBookArrivalsPreview As PrintPreviewDialog
    Friend WithEvents grpInventory As GroupBox
    Friend WithEvents btnGenerateInventorySummary As Button
    Friend WithEvents printInventorySummaryReport As Printing.PrintDocument
    Friend WithEvents inventorySummaryPreview As PrintPreviewDialog
    Friend WithEvents cbonewBookArrivalsYear As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDiscountHeader As Label
End Class
