<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCard))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTransactionTime = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.printReceiptPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.printReceipt = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(316, 364)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(206, 58)
        Me.btnClose.TabIndex = 53
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblTransactionTime
        '
        Me.lblTransactionTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTransactionTime.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactionTime.Location = New System.Drawing.Point(394, 208)
        Me.lblTransactionTime.Name = "lblTransactionTime"
        Me.lblTransactionTime.Size = New System.Drawing.Size(196, 42)
        Me.lblTransactionTime.TabIndex = 52
        Me.lblTransactionTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(236, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 41)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Transaction Time : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStatus
        '
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatus.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(394, 150)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(196, 42)
        Me.lblStatus.TabIndex = 50
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(236, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 41)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Payment Status : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblID
        '
        Me.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(394, 87)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(196, 42)
        Me.lblID.TabIndex = 48
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrint.Enabled = False
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(316, 283)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(206, 58)
        Me.btnPrint.TabIndex = 47
        Me.btnPrint.Text = "&Print Receipt"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(236, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 41)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Payment ID : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(844, 526)
        Me.Panel1.TabIndex = 54
        '
        'printReceiptPreview
        '
        Me.printReceiptPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.printReceiptPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.printReceiptPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.printReceiptPreview.Enabled = True
        Me.printReceiptPreview.Icon = CType(resources.GetObject("printReceiptPreview.Icon"), System.Drawing.Icon)
        Me.printReceiptPreview.Name = "printReceiptPreview"
        Me.printReceiptPreview.Visible = False
        '
        'printReceipt
        '
        '
        'FormCard
        '
        Me.AcceptButton = Me.btnPrint
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(844, 526)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblTransactionTime)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCard"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents lblTransactionTime As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents printReceiptPreview As PrintPreviewDialog
    Friend WithEvents printReceipt As Printing.PrintDocument
End Class
