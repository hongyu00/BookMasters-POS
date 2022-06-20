<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPaymentReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPaymentReport))
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblRecord = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotalProfit = New System.Windows.Forms.Label()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.lblCard = New System.Windows.Forms.Label()
        Me.lblTransaction = New System.Windows.Forms.Label()
        Me.lblCashTransaction = New System.Windows.Forms.Label()
        Me.lblCardTransaction = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblProfitEarned = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.printReceipt = New System.Drawing.Printing.PrintDocument()
        Me.printReceiptPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.gboBestSelling = New System.Windows.Forms.GroupBox()
        Me.lbl5Sold = New System.Windows.Forms.Label()
        Me.lbl4Sold = New System.Windows.Forms.Label()
        Me.lbl3Sold = New System.Windows.Forms.Label()
        Me.lbl2Sold = New System.Windows.Forms.Label()
        Me.lbl1Sold = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gboBestSelling.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(1575, 122)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(119, 48)
        Me.btnRefresh.TabIndex = 19
        Me.btnRefresh.Text = "Refres&h"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(652, 127)
        Me.DateTimePicker1.MaxDate = New Date(2020, 12, 3, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(2020, 8, 3, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(332, 31)
        Me.DateTimePicker1.TabIndex = 15
        Me.DateTimePicker1.Value = New Date(2020, 8, 3, 0, 0, 0, 0)
        '
        'lblFrom
        '
        Me.lblFrom.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.Location = New System.Drawing.Point(312, 132)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(334, 24)
        Me.lblFrom.TabIndex = 14
        Me.lblFrom.Text = "Get Summary Report &From :"
        Me.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRecord
        '
        Me.lblRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecord.Location = New System.Drawing.Point(113, 189)
        Me.lblRecord.Name = "lblRecord"
        Me.lblRecord.Size = New System.Drawing.Size(229, 39)
        Me.lblRecord.TabIndex = 20
        Me.lblRecord.Text = "Total Transactions : "
        Me.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(1092, 127)
        Me.DateTimePicker2.MaxDate = New Date(2020, 12, 3, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(338, 31)
        Me.DateTimePicker2.TabIndex = 17
        Me.DateTimePicker2.Value = New Date(2020, 12, 3, 0, 0, 0, 0)
        '
        'lblTo
        '
        Me.lblTo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.Location = New System.Drawing.Point(1003, 132)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(73, 24)
        Me.lblTo.TabIndex = 16
        Me.lblTo.Text = "T&o :"
        Me.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(993, 678)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(189, 72)
        Me.btnPrint.TabIndex = 18
        Me.btnPrint.Text = "&Print Report"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(747, 179)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(619, 60)
        Me.lblTitle.TabIndex = 22
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(331, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(257, 39)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Tax to be paid : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(675, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(272, 43)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Total Amount : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(610, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(337, 44)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Amount Received By Cash : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(610, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(343, 47)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Amount Received By Card : "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(614, 262)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(327, 39)
        Me.lblTax.TabIndex = 30
        Me.lblTax.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalProfit
        '
        Me.lblTotalProfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalProfit.Location = New System.Drawing.Point(975, 193)
        Me.lblTotalProfit.Name = "lblTotalProfit"
        Me.lblTotalProfit.Size = New System.Drawing.Size(218, 39)
        Me.lblTotalProfit.TabIndex = 32
        Me.lblTotalProfit.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblTotalProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCash
        '
        Me.lblCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCash.Location = New System.Drawing.Point(975, 58)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(218, 39)
        Me.lblCash.TabIndex = 33
        Me.lblCash.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCard
        '
        Me.lblCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCard.Location = New System.Drawing.Point(975, 125)
        Me.lblCard.Name = "lblCard"
        Me.lblCard.Size = New System.Drawing.Size(218, 39)
        Me.lblCard.TabIndex = 34
        Me.lblCard.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTransaction
        '
        Me.lblTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransaction.Location = New System.Drawing.Point(374, 189)
        Me.lblTransaction.Name = "lblTransaction"
        Me.lblTransaction.Size = New System.Drawing.Size(218, 39)
        Me.lblTransaction.TabIndex = 35
        Me.lblTransaction.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCashTransaction
        '
        Me.lblCashTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCashTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashTransaction.Location = New System.Drawing.Point(373, 58)
        Me.lblCashTransaction.Name = "lblCashTransaction"
        Me.lblCashTransaction.Size = New System.Drawing.Size(218, 39)
        Me.lblCashTransaction.TabIndex = 36
        Me.lblCashTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCardTransaction
        '
        Me.lblCardTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCardTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardTransaction.Location = New System.Drawing.Point(373, 125)
        Me.lblCardTransaction.Name = "lblCardTransaction"
        Me.lblCardTransaction.Size = New System.Drawing.Size(219, 39)
        Me.lblCardTransaction.TabIndex = 37
        Me.lblCardTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblProfitEarned)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblTotalProfit)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblCard)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblTax)
        Me.GroupBox1.Controls.Add(Me.lblCash)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblRecord)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblCardTransaction)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblTransaction)
        Me.GroupBox1.Controls.Add(Me.lblCashTransaction)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(419, 242)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1238, 412)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Revenue Summary"
        '
        'lblProfitEarned
        '
        Me.lblProfitEarned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProfitEarned.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfitEarned.Location = New System.Drawing.Point(614, 329)
        Me.lblProfitEarned.Name = "lblProfitEarned"
        Me.lblProfitEarned.Size = New System.Drawing.Size(327, 54)
        Me.lblProfitEarned.TabIndex = 41
        Me.lblProfitEarned.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblProfitEarned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(322, 329)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(269, 54)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Profit Earned : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(302, 39)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Total Transactions By Card: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 39)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Total Transactions By Cash: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Location = New System.Drawing.Point(1450, 122)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(119, 48)
        Me.btnSearch.TabIndex = 39
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'printReceipt
        '
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
        'gboBestSelling
        '
        Me.gboBestSelling.Controls.Add(Me.lbl5Sold)
        Me.gboBestSelling.Controls.Add(Me.lbl4Sold)
        Me.gboBestSelling.Controls.Add(Me.lbl3Sold)
        Me.gboBestSelling.Controls.Add(Me.lbl2Sold)
        Me.gboBestSelling.Controls.Add(Me.lbl1Sold)
        Me.gboBestSelling.Controls.Add(Me.lbl4)
        Me.gboBestSelling.Controls.Add(Me.lbl5)
        Me.gboBestSelling.Controls.Add(Me.lbl3)
        Me.gboBestSelling.Controls.Add(Me.lbl2)
        Me.gboBestSelling.Controls.Add(Me.lbl1)
        Me.gboBestSelling.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.gboBestSelling.Location = New System.Drawing.Point(419, 760)
        Me.gboBestSelling.Name = "gboBestSelling"
        Me.gboBestSelling.Size = New System.Drawing.Size(1238, 263)
        Me.gboBestSelling.TabIndex = 40
        Me.gboBestSelling.TabStop = False
        '
        'lbl5Sold
        '
        Me.lbl5Sold.Location = New System.Drawing.Point(739, 213)
        Me.lbl5Sold.Name = "lbl5Sold"
        Me.lbl5Sold.Size = New System.Drawing.Size(355, 29)
        Me.lbl5Sold.TabIndex = 9
        '
        'lbl4Sold
        '
        Me.lbl4Sold.Location = New System.Drawing.Point(738, 162)
        Me.lbl4Sold.Name = "lbl4Sold"
        Me.lbl4Sold.Size = New System.Drawing.Size(355, 29)
        Me.lbl4Sold.TabIndex = 8
        '
        'lbl3Sold
        '
        Me.lbl3Sold.Location = New System.Drawing.Point(738, 117)
        Me.lbl3Sold.Name = "lbl3Sold"
        Me.lbl3Sold.Size = New System.Drawing.Size(355, 29)
        Me.lbl3Sold.TabIndex = 7
        '
        'lbl2Sold
        '
        Me.lbl2Sold.Location = New System.Drawing.Point(738, 74)
        Me.lbl2Sold.Name = "lbl2Sold"
        Me.lbl2Sold.Size = New System.Drawing.Size(355, 29)
        Me.lbl2Sold.TabIndex = 6
        '
        'lbl1Sold
        '
        Me.lbl1Sold.Location = New System.Drawing.Point(738, 32)
        Me.lbl1Sold.Name = "lbl1Sold"
        Me.lbl1Sold.Size = New System.Drawing.Size(355, 29)
        Me.lbl1Sold.TabIndex = 5
        '
        'lbl4
        '
        Me.lbl4.Location = New System.Drawing.Point(39, 156)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(660, 35)
        Me.lbl4.TabIndex = 4
        Me.lbl4.Text = "4. "
        Me.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl5
        '
        Me.lbl5.Location = New System.Drawing.Point(40, 207)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(660, 35)
        Me.lbl5.TabIndex = 3
        Me.lbl5.Text = "5. "
        Me.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl3
        '
        Me.lbl3.Location = New System.Drawing.Point(39, 111)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(660, 35)
        Me.lbl3.TabIndex = 2
        Me.lbl3.Text = "3. "
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl2
        '
        Me.lbl2.Location = New System.Drawing.Point(39, 68)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(660, 35)
        Me.lbl2.TabIndex = 1
        Me.lbl2.Text = "2. "
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl1
        '
        Me.lbl1.Location = New System.Drawing.Point(39, 26)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(660, 35)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "1. "
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormPaymentReport
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.CancelButton = Me.btnRefresh
        Me.ClientSize = New System.Drawing.Size(2373, 1061)
        Me.Controls.Add(Me.gboBestSelling)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.btnPrint)
        Me.Name = "FormPaymentReport"
        Me.Text = "FormPaymentReport"
        Me.GroupBox1.ResumeLayout(False)
        Me.gboBestSelling.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRefresh As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblRecord As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents lblTo As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTotalProfit As Label
    Friend WithEvents lblCash As Label
    Friend WithEvents lblCard As Label
    Friend WithEvents lblTransaction As Label
    Friend WithEvents lblCashTransaction As Label
    Friend WithEvents lblCardTransaction As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblProfitEarned As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents printReceipt As Printing.PrintDocument
    Friend WithEvents printReceiptPreview As PrintPreviewDialog
    Friend WithEvents gboBestSelling As GroupBox
    Friend WithEvents lbl5Sold As Label
    Friend WithEvents lbl4Sold As Label
    Friend WithEvents lbl3Sold As Label
    Friend WithEvents lbl2Sold As Label
    Friend WithEvents lbl1Sold As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    'Friend WithEvents PaymentTableAdapter As BookMastersDBDataSetTableAdapters.PaymentTableAdapter
End Class
