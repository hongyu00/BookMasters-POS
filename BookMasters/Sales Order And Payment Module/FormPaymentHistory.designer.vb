<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPaymentHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPaymentHistory))
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblPaymentMethod = New System.Windows.Forms.Label()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.cboPaymentID = New System.Windows.Forms.ComboBox()
        Me.grpView = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New FontAwesome.Sharp.IconButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblVoucherID = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblPointsRedeem = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblMemberID = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblPaymentDate = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblPaymentID = New System.Windows.Forms.Label()
        Me.btnType = New FontAwesome.Sharp.IconButton()
        Me.btnSelect = New FontAwesome.Sharp.IconButton()
        Me.btnPrint = New FontAwesome.Sharp.IconButton()
        Me.btnClear = New FontAwesome.Sharp.IconButton()
        Me.listBoxProduct = New System.Windows.Forms.ListBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.printReceiptPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.printReceipt = New System.Drawing.Printing.PrintDocument()
        Me.grpView.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(400, 105)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(154, 19)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Payment Method : "
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPaymentMethod
        '
        Me.lblPaymentMethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPaymentMethod.Location = New System.Drawing.Point(576, 103)
        Me.lblPaymentMethod.Name = "lblPaymentMethod"
        Me.lblPaymentMethod.Size = New System.Drawing.Size(200, 27)
        Me.lblPaymentMethod.TabIndex = 8
        '
        'txtPayment
        '
        Me.txtPayment.Location = New System.Drawing.Point(193, 44)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(200, 25)
        Me.txtPayment.TabIndex = 0
        '
        'cboPaymentID
        '
        Me.cboPaymentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaymentID.FormattingEnabled = True
        Me.cboPaymentID.Location = New System.Drawing.Point(194, 44)
        Me.cboPaymentID.Name = "cboPaymentID"
        Me.cboPaymentID.Size = New System.Drawing.Size(200, 26)
        Me.cboPaymentID.TabIndex = 1
        Me.cboPaymentID.Visible = False
        '
        'grpView
        '
        Me.grpView.Controls.Add(Me.txtPayment)
        Me.grpView.Controls.Add(Me.btnSearch)
        Me.grpView.Controls.Add(Me.cboPaymentID)
        Me.grpView.Controls.Add(Me.Label19)
        Me.grpView.Controls.Add(Me.lblPaymentMethod)
        Me.grpView.Controls.Add(Me.Label17)
        Me.grpView.Controls.Add(Me.lblSubtotal)
        Me.grpView.Controls.Add(Me.Label9)
        Me.grpView.Controls.Add(Me.lblVoucherID)
        Me.grpView.Controls.Add(Me.Label11)
        Me.grpView.Controls.Add(Me.lblPointsRedeem)
        Me.grpView.Controls.Add(Me.Label13)
        Me.grpView.Controls.Add(Me.lblMemberID)
        Me.grpView.Controls.Add(Me.Label15)
        Me.grpView.Controls.Add(Me.lblPaymentDate)
        Me.grpView.Controls.Add(Me.Label7)
        Me.grpView.Controls.Add(Me.lblStaffID)
        Me.grpView.Controls.Add(Me.Label5)
        Me.grpView.Controls.Add(Me.lblTotal)
        Me.grpView.Controls.Add(Me.Label3)
        Me.grpView.Controls.Add(Me.lblTax)
        Me.grpView.Controls.Add(Me.Label1)
        Me.grpView.Controls.Add(Me.lblDiscount)
        Me.grpView.Controls.Add(Me.lblPaymentID)
        Me.grpView.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpView.Location = New System.Drawing.Point(536, 176)
        Me.grpView.Name = "grpView"
        Me.grpView.Size = New System.Drawing.Size(836, 367)
        Me.grpView.TabIndex = 2
        Me.grpView.TabStop = False
        Me.grpView.Text = "Payment History"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.LightBlue
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btnSearch.IconColor = System.Drawing.Color.Black
        Me.btnSearch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSearch.Location = New System.Drawing.Point(431, 33)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(144, 46)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(67, 105)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 19)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Subtotal : "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubtotal.Location = New System.Drawing.Point(194, 103)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(200, 27)
        Me.lblSubtotal.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(458, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 19)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Voucher ID : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVoucherID
        '
        Me.lblVoucherID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVoucherID.Location = New System.Drawing.Point(576, 310)
        Me.lblVoucherID.Name = "lblVoucherID"
        Me.lblVoucherID.Size = New System.Drawing.Size(200, 27)
        Me.lblVoucherID.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(427, 260)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 19)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Points Redeem : "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPointsRedeem
        '
        Me.lblPointsRedeem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPointsRedeem.Location = New System.Drawing.Point(576, 258)
        Me.lblPointsRedeem.Name = "lblPointsRedeem"
        Me.lblPointsRedeem.Size = New System.Drawing.Size(200, 27)
        Me.lblPointsRedeem.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(458, 207)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 19)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Member ID : "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMemberID
        '
        Me.lblMemberID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMemberID.Location = New System.Drawing.Point(576, 205)
        Me.lblMemberID.Name = "lblMemberID"
        Me.lblMemberID.Size = New System.Drawing.Size(200, 27)
        Me.lblMemberID.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(404, 155)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(150, 19)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Payment Date : "
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPaymentDate
        '
        Me.lblPaymentDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPaymentDate.Location = New System.Drawing.Point(576, 153)
        Me.lblPaymentDate.Name = "lblPaymentDate"
        Me.lblPaymentDate.Size = New System.Drawing.Size(200, 27)
        Me.lblPaymentDate.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 19)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "StaffID : "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStaffID
        '
        Me.lblStaffID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStaffID.Location = New System.Drawing.Point(194, 308)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(200, 27)
        Me.lblStaffID.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(67, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 19)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Total : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(194, 256)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(200, 27)
        Me.lblTotal.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Tax : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Location = New System.Drawing.Point(194, 203)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(200, 27)
        Me.lblTax.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 19)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Total Discount : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiscount
        '
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscount.Location = New System.Drawing.Point(194, 151)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(200, 27)
        Me.lblDiscount.TabIndex = 4
        '
        'lblPaymentID
        '
        Me.lblPaymentID.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentID.Location = New System.Drawing.Point(67, 46)
        Me.lblPaymentID.Name = "lblPaymentID"
        Me.lblPaymentID.Size = New System.Drawing.Size(96, 19)
        Me.lblPaymentID.TabIndex = 13
        Me.lblPaymentID.Text = "Payment I&D :"
        Me.lblPaymentID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnType
        '
        Me.btnType.BackColor = System.Drawing.Color.LightBlue
        Me.btnType.FlatAppearance.BorderSize = 0
        Me.btnType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnType.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnType.IconChar = FontAwesome.Sharp.IconChar.Keyboard
        Me.btnType.IconColor = System.Drawing.Color.Black
        Me.btnType.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnType.Location = New System.Drawing.Point(729, 109)
        Me.btnType.Name = "btnType"
        Me.btnType.Size = New System.Drawing.Size(201, 50)
        Me.btnType.TabIndex = 0
        Me.btnType.Text = "&Type Payment ID "
        Me.btnType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnType.UseVisualStyleBackColor = False
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.LightBlue
        Me.btnSelect.FlatAppearance.BorderSize = 0
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSelect.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnSelect.IconChar = FontAwesome.Sharp.IconChar.ListUl
        Me.btnSelect.IconColor = System.Drawing.Color.Black
        Me.btnSelect.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSelect.Location = New System.Drawing.Point(967, 109)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(194, 50)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "&Select Payment ID"
        Me.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.LightBlue
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btnPrint.IconColor = System.Drawing.Color.Black
        Me.btnPrint.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPrint.Location = New System.Drawing.Point(1058, 550)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(130, 50)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightBlue
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.btnClear.IconColor = System.Drawing.Color.Black
        Me.btnClear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClear.Location = New System.Drawing.Point(1212, 549)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(124, 51)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "&Clear"
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'listBoxProduct
        '
        Me.listBoxProduct.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.listBoxProduct.FormattingEnabled = True
        Me.listBoxProduct.ItemHeight = 21
        Me.listBoxProduct.Location = New System.Drawing.Point(536, 662)
        Me.listBoxProduct.Name = "listBoxProduct"
        Me.listBoxProduct.Size = New System.Drawing.Size(836, 340)
        Me.listBoxProduct.TabIndex = 5
        '
        'lblPrice
        '
        Me.lblPrice.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(1225, 628)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(147, 24)
        Me.lblPrice.TabIndex = 8
        Me.lblPrice.Text = "Price (RM)"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQuantity
        '
        Me.lblQuantity.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(1046, 628)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(115, 23)
        Me.lblQuantity.TabIndex = 7
        Me.lblQuantity.Text = "Quantity"
        Me.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProduct
        '
        Me.lblProduct.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduct.Location = New System.Drawing.Point(564, 628)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(125, 22)
        Me.lblProduct.TabIndex = 6
        Me.lblProduct.Text = "Product"
        Me.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'FormPaymentHistory
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(1511, 1031)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.listBoxProduct)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblProduct)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnType)
        Me.Controls.Add(Me.grpView)
        Me.Name = "FormPaymentHistory"
        Me.Text = "FormPaymentHistory"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpView.ResumeLayout(False)
        Me.grpView.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    'Friend WithEvents PaymentTableAdapter As BookMastersDBDataSetTableAdapters.PaymentTableAdapter
    Friend WithEvents Label19 As Label
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents cboPaymentID As ComboBox
    Friend WithEvents grpView As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblVoucherID As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblPointsRedeem As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblMemberID As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblPaymentDate As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblStaffID As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblPaymentID As Label
    Friend WithEvents btnSearch As FontAwesome.Sharp.IconButton
    Friend WithEvents btnType As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSelect As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPrint As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClear As FontAwesome.Sharp.IconButton
    Friend WithEvents listBoxProduct As ListBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblProduct As Label
    Friend WithEvents printReceiptPreview As PrintPreviewDialog
    Friend WithEvents printReceipt As Printing.PrintDocument
End Class
