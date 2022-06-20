<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPayment))
        Me.lblMember = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.lblBarcode = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDiscountText = New System.Windows.Forms.Label()
        Me.lblTax2 = New System.Windows.Forms.Label()
        Me.lblSubName = New System.Windows.Forms.Label()
        Me.lblTotalQuantity = New System.Windows.Forms.Label()
        Me.lblQuantityName = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.listProduct = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPaymentID = New System.Windows.Forms.Label()
        Me.lblRounding = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPotentialDiscount = New System.Windows.Forms.Label()
        Me.btnRenewMember = New System.Windows.Forms.Button()
        Me.btnPrice = New System.Windows.Forms.Button()
        Me.btnPoint = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnVoucher = New System.Windows.Forms.Button()
        Me.btnHold = New System.Windows.Forms.Button()
        Me.btnMember = New System.Windows.Forms.Button()
        Me.btnCard = New System.Windows.Forms.Button()
        Me.btnCash = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMember
        '
        Me.lblMember.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMember.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMember.Location = New System.Drawing.Point(716, 107)
        Me.lblMember.Name = "lblMember"
        Me.lblMember.Size = New System.Drawing.Size(236, 23)
        Me.lblMember.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(587, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 23)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Member ID : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(958, 148)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(79, 37)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtBarcode
        '
        Me.txtBarcode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBarcode.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(716, 148)
        Me.txtBarcode.Multiline = True
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(236, 37)
        Me.txtBarcode.TabIndex = 0
        '
        'lblBarcode
        '
        Me.lblBarcode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblBarcode.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarcode.Location = New System.Drawing.Point(586, 155)
        Me.lblBarcode.Name = "lblBarcode"
        Me.lblBarcode.Size = New System.Drawing.Size(124, 30)
        Me.lblBarcode.TabIndex = 18
        Me.lblBarcode.Text = "&Barcode : "
        Me.lblBarcode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(1107, 629)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 35
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiscount
        '
        Me.lblDiscount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDiscount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(1106, 516)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(100, 23)
        Me.lblDiscount.TabIndex = 30
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax
        '
        Me.lblTax.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTax.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(1107, 548)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 23)
        Me.lblTax.TabIndex = 28
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubtotal
        '
        Me.lblSubtotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSubtotal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(1106, 482)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(100, 23)
        Me.lblSubtotal.TabIndex = 26
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1001, 629)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Total : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiscountText
        '
        Me.lblDiscountText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDiscountText.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountText.Location = New System.Drawing.Point(939, 516)
        Me.lblDiscountText.Name = "lblDiscountText"
        Me.lblDiscountText.Size = New System.Drawing.Size(162, 23)
        Me.lblDiscountText.TabIndex = 29
        Me.lblDiscountText.Text = "Discount : "
        Me.lblDiscountText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax2
        '
        Me.lblTax2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTax2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax2.Location = New System.Drawing.Point(968, 548)
        Me.lblTax2.Name = "lblTax2"
        Me.lblTax2.Size = New System.Drawing.Size(133, 23)
        Me.lblTax2.TabIndex = 27
        Me.lblTax2.Text = "Tax (6%) : "
        Me.lblTax2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubName
        '
        Me.lblSubName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSubName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubName.Location = New System.Drawing.Point(934, 482)
        Me.lblSubName.Name = "lblSubName"
        Me.lblSubName.Size = New System.Drawing.Size(166, 23)
        Me.lblSubName.TabIndex = 25
        Me.lblSubName.Text = "Subtotal : "
        Me.lblSubName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalQuantity
        '
        Me.lblTotalQuantity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalQuantity.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalQuantity.Location = New System.Drawing.Point(561, 482)
        Me.lblTotalQuantity.Name = "lblTotalQuantity"
        Me.lblTotalQuantity.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalQuantity.TabIndex = 24
        Me.lblTotalQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQuantityName
        '
        Me.lblQuantityName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblQuantityName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantityName.Location = New System.Drawing.Point(373, 482)
        Me.lblQuantityName.Name = "lblQuantityName"
        Me.lblQuantityName.Size = New System.Drawing.Size(182, 23)
        Me.lblQuantityName.TabIndex = 23
        Me.lblQuantityName.Text = "Total Quantity : "
        Me.lblQuantityName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrice
        '
        Me.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPrice.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(912, 223)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(119, 24)
        Me.lblPrice.TabIndex = 21
        Me.lblPrice.Text = "Price (RM)"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQuantity
        '
        Me.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblQuantity.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(736, 224)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(116, 23)
        Me.lblQuantity.TabIndex = 20
        Me.lblQuantity.Text = "Quantity"
        Me.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProduct
        '
        Me.lblProduct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblProduct.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduct.Location = New System.Drawing.Point(406, 221)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(93, 22)
        Me.lblProduct.TabIndex = 19
        Me.lblProduct.Text = "Product"
        '
        'listProduct
        '
        Me.listProduct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.listProduct.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listProduct.FormattingEnabled = True
        Me.listProduct.ItemHeight = 21
        Me.listProduct.Location = New System.Drawing.Point(382, 254)
        Me.listProduct.Name = "listProduct"
        Me.listProduct.Size = New System.Drawing.Size(872, 193)
        Me.listProduct.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(585, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 23)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Payment ID : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPaymentID
        '
        Me.lblPaymentID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPaymentID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentID.Location = New System.Drawing.Point(715, 66)
        Me.lblPaymentID.Name = "lblPaymentID"
        Me.lblPaymentID.Size = New System.Drawing.Size(236, 23)
        Me.lblPaymentID.TabIndex = 15
        '
        'lblRounding
        '
        Me.lblRounding.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRounding.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRounding.Location = New System.Drawing.Point(1106, 578)
        Me.lblRounding.Name = "lblRounding"
        Me.lblRounding.Size = New System.Drawing.Size(100, 23)
        Me.lblRounding.TabIndex = 32
        Me.lblRounding.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(889, 578)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(212, 23)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Rounding Adjustment : "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(913, 608)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(327, 23)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "----------------------------------------------------------------"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(913, 660)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(327, 23)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "----------------------------------------------------------------"
        '
        'lblPotentialDiscount
        '
        Me.lblPotentialDiscount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPotentialDiscount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPotentialDiscount.Location = New System.Drawing.Point(1024, 223)
        Me.lblPotentialDiscount.Name = "lblPotentialDiscount"
        Me.lblPotentialDiscount.Size = New System.Drawing.Size(250, 24)
        Me.lblPotentialDiscount.TabIndex = 22
        Me.lblPotentialDiscount.Text = "Potential Discount (RM)"
        Me.lblPotentialDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRenewMember
        '
        Me.btnRenewMember.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRenewMember.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRenewMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRenewMember.FlatAppearance.BorderSize = 0
        Me.btnRenewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRenewMember.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRenewMember.Image = CType(resources.GetObject("btnRenewMember.Image"), System.Drawing.Image)
        Me.btnRenewMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRenewMember.Location = New System.Drawing.Point(1280, 518)
        Me.btnRenewMember.Name = "btnRenewMember"
        Me.btnRenewMember.Size = New System.Drawing.Size(224, 67)
        Me.btnRenewMember.TabIndex = 6
        Me.btnRenewMember.Text = "&Renew Member"
        Me.btnRenewMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRenewMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRenewMember.UseVisualStyleBackColor = False
        '
        'btnPrice
        '
        Me.btnPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrice.FlatAppearance.BorderSize = 0
        Me.btnPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrice.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrice.Image = CType(resources.GetObject("btnPrice.Image"), System.Drawing.Image)
        Me.btnPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrice.Location = New System.Drawing.Point(1397, 608)
        Me.btnPrice.Name = "btnPrice"
        Me.btnPrice.Size = New System.Drawing.Size(224, 67)
        Me.btnPrice.TabIndex = 11
        Me.btnPrice.Text = "Price &Check"
        Me.btnPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrice.UseVisualStyleBackColor = False
        '
        'btnPoint
        '
        Me.btnPoint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPoint.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPoint.FlatAppearance.BorderSize = 0
        Me.btnPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPoint.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPoint.Image = CType(resources.GetObject("btnPoint.Image"), System.Drawing.Image)
        Me.btnPoint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPoint.Location = New System.Drawing.Point(1280, 317)
        Me.btnPoint.Name = "btnPoint"
        Me.btnPoint.Size = New System.Drawing.Size(224, 67)
        Me.btnPoint.TabIndex = 4
        Me.btnPoint.Text = "&Point Redeem"
        Me.btnPoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPoint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPoint.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(1510, 317)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(224, 63)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "&Edit Product Quantity"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(1510, 516)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(224, 69)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "C&lear"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(1510, 420)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(224, 62)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnVoucher
        '
        Me.btnVoucher.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnVoucher.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVoucher.FlatAppearance.BorderSize = 0
        Me.btnVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoucher.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoucher.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnVoucher.Image = CType(resources.GetObject("btnVoucher.Image"), System.Drawing.Image)
        Me.btnVoucher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVoucher.Location = New System.Drawing.Point(1280, 420)
        Me.btnVoucher.Name = "btnVoucher"
        Me.btnVoucher.Size = New System.Drawing.Size(224, 67)
        Me.btnVoucher.TabIndex = 5
        Me.btnVoucher.Text = "&Voucher"
        Me.btnVoucher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVoucher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVoucher.UseVisualStyleBackColor = False
        '
        'btnHold
        '
        Me.btnHold.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHold.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnHold.FlatAppearance.BorderSize = 0
        Me.btnHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHold.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHold.Image = CType(resources.GetObject("btnHold.Image"), System.Drawing.Image)
        Me.btnHold.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHold.Location = New System.Drawing.Point(1510, 215)
        Me.btnHold.Name = "btnHold"
        Me.btnHold.Size = New System.Drawing.Size(224, 67)
        Me.btnHold.TabIndex = 7
        Me.btnHold.Text = "&Hold Transaction"
        Me.btnHold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHold.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHold.UseVisualStyleBackColor = False
        '
        'btnMember
        '
        Me.btnMember.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMember.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMember.FlatAppearance.BorderSize = 0
        Me.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMember.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMember.Image = CType(resources.GetObject("btnMember.Image"), System.Drawing.Image)
        Me.btnMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMember.Location = New System.Drawing.Point(1280, 215)
        Me.btnMember.Name = "btnMember"
        Me.btnMember.Size = New System.Drawing.Size(224, 67)
        Me.btnMember.TabIndex = 3
        Me.btnMember.Text = "&Member Validation"
        Me.btnMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMember.UseVisualStyleBackColor = False
        '
        'btnCard
        '
        Me.btnCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCard.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCard.FlatAppearance.BorderSize = 0
        Me.btnCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCard.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCard.Image = CType(resources.GetObject("btnCard.Image"), System.Drawing.Image)
        Me.btnCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCard.Location = New System.Drawing.Point(821, 700)
        Me.btnCard.Name = "btnCard"
        Me.btnCard.Size = New System.Drawing.Size(184, 63)
        Me.btnCard.TabIndex = 13
        Me.btnCard.Text = "Pay by Ca&rd"
        Me.btnCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCard.UseVisualStyleBackColor = False
        '
        'btnCash
        '
        Me.btnCash.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCash.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCash.FlatAppearance.BorderSize = 0
        Me.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCash.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCash.Image = CType(resources.GetObject("btnCash.Image"), System.Drawing.Image)
        Me.btnCash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCash.Location = New System.Drawing.Point(565, 700)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(178, 63)
        Me.btnCash.TabIndex = 12
        Me.btnCash.Text = "Pay by Ca&sh"
        Me.btnCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCash.UseVisualStyleBackColor = False
        '
        'FormPayment
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1784, 857)
        Me.Controls.Add(Me.btnRenewMember)
        Me.Controls.Add(Me.lblPotentialDiscount)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblRounding)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblPaymentID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnPrice)
        Me.Controls.Add(Me.btnPoint)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lblMember)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnVoucher)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnHold)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.btnMember)
        Me.Controls.Add(Me.lblBarcode)
        Me.Controls.Add(Me.btnCard)
        Me.Controls.Add(Me.btnCash)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDiscountText)
        Me.Controls.Add(Me.lblTax2)
        Me.Controls.Add(Me.lblSubName)
        Me.Controls.Add(Me.lblTotalQuantity)
        Me.Controls.Add(Me.lblQuantityName)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblProduct)
        Me.Controls.Add(Me.listProduct)
        Me.MinimumSize = New System.Drawing.Size(1800, 896)
        Me.Name = "FormPayment"
        Me.Text = "FormOrders"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEdit As Button
    Friend WithEvents lblMember As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnVoucher As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnHold As Button
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents btnMember As Button
    Friend WithEvents lblBarcode As Label
    Friend WithEvents btnCard As Button
    Friend WithEvents btnCash As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDiscountText As Label
    Friend WithEvents lblTax2 As Label
    Friend WithEvents lblSubName As Label
    Friend WithEvents lblTotalQuantity As Label
    Friend WithEvents lblQuantityName As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblProduct As Label
    Friend WithEvents listProduct As ListBox
    Friend WithEvents btnPoint As Button
    Friend WithEvents btnPrice As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPaymentID As Label
    Friend WithEvents lblRounding As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblPotentialDiscount As Label
    Friend WithEvents btnRenewMember As Button
End Class
