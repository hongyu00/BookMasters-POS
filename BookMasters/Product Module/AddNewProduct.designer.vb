<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewProduct
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboProductCategory = New System.Windows.Forms.ComboBox()
        Me.txtNewProductPrice = New System.Windows.Forms.TextBox()
        Me.txtNewProductQuantity = New System.Windows.Forms.TextBox()
        Me.txtNewProductDistributor = New System.Windows.Forms.TextBox()
        Me.txtNewProductAuthor = New System.Windows.Forms.TextBox()
        Me.dtpProductAddedDate = New System.Windows.Forms.DateTimePicker()
        Me.txtNewProductDesc = New System.Windows.Forms.TextBox()
        Me.txtNewProductName = New System.Windows.Forms.TextBox()
        Me.lblNewProductID = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(473, 489)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(158, 56)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(949, 489)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(158, 56)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboProductCategory)
        Me.GroupBox1.Controls.Add(Me.txtNewProductPrice)
        Me.GroupBox1.Controls.Add(Me.txtNewProductQuantity)
        Me.GroupBox1.Controls.Add(Me.txtNewProductDistributor)
        Me.GroupBox1.Controls.Add(Me.txtNewProductAuthor)
        Me.GroupBox1.Controls.Add(Me.dtpProductAddedDate)
        Me.GroupBox1.Controls.Add(Me.txtNewProductDesc)
        Me.GroupBox1.Controls.Add(Me.txtNewProductName)
        Me.GroupBox1.Controls.Add(Me.lblNewProductID)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1494, 377)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cboProductCategory
        '
        Me.cboProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProductCategory.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProductCategory.FormattingEnabled = True
        Me.cboProductCategory.Location = New System.Drawing.Point(1096, 248)
        Me.cboProductCategory.Name = "cboProductCategory"
        Me.cboProductCategory.Size = New System.Drawing.Size(200, 31)
        Me.cboProductCategory.TabIndex = 1
        '
        'txtNewProductPrice
        '
        Me.txtNewProductPrice.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewProductPrice.Location = New System.Drawing.Point(309, 136)
        Me.txtNewProductPrice.Name = "txtNewProductPrice"
        Me.txtNewProductPrice.Size = New System.Drawing.Size(180, 32)
        Me.txtNewProductPrice.TabIndex = 11
        '
        'txtNewProductQuantity
        '
        Me.txtNewProductQuantity.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewProductQuantity.Location = New System.Drawing.Point(428, 80)
        Me.txtNewProductQuantity.Name = "txtNewProductQuantity"
        Me.txtNewProductQuantity.Size = New System.Drawing.Size(61, 32)
        Me.txtNewProductQuantity.TabIndex = 7
        '
        'txtNewProductDistributor
        '
        Me.txtNewProductDistributor.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewProductDistributor.Location = New System.Drawing.Point(310, 251)
        Me.txtNewProductDistributor.Multiline = True
        Me.txtNewProductDistributor.Name = "txtNewProductDistributor"
        Me.txtNewProductDistributor.Size = New System.Drawing.Size(393, 41)
        Me.txtNewProductDistributor.TabIndex = 15
        '
        'txtNewProductAuthor
        '
        Me.txtNewProductAuthor.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewProductAuthor.Location = New System.Drawing.Point(309, 308)
        Me.txtNewProductAuthor.Multiline = True
        Me.txtNewProductAuthor.Name = "txtNewProductAuthor"
        Me.txtNewProductAuthor.Size = New System.Drawing.Size(394, 41)
        Me.txtNewProductAuthor.TabIndex = 17
        '
        'dtpProductAddedDate
        '
        Me.dtpProductAddedDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpProductAddedDate.Location = New System.Drawing.Point(309, 192)
        Me.dtpProductAddedDate.Name = "dtpProductAddedDate"
        Me.dtpProductAddedDate.Size = New System.Drawing.Size(377, 32)
        Me.dtpProductAddedDate.TabIndex = 13
        '
        'txtNewProductDesc
        '
        Me.txtNewProductDesc.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewProductDesc.Location = New System.Drawing.Point(815, 95)
        Me.txtNewProductDesc.Multiline = True
        Me.txtNewProductDesc.Name = "txtNewProductDesc"
        Me.txtNewProductDesc.Size = New System.Drawing.Size(637, 110)
        Me.txtNewProductDesc.TabIndex = 9
        '
        'txtNewProductName
        '
        Me.txtNewProductName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewProductName.Location = New System.Drawing.Point(815, 34)
        Me.txtNewProductName.Multiline = True
        Me.txtNewProductName.Name = "txtNewProductName"
        Me.txtNewProductName.Size = New System.Drawing.Size(637, 41)
        Me.txtNewProductName.TabIndex = 5
        '
        'lblNewProductID
        '
        Me.lblNewProductID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNewProductID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewProductID.Location = New System.Drawing.Point(309, 31)
        Me.lblNewProductID.Name = "lblNewProductID"
        Me.lblNewProductID.Size = New System.Drawing.Size(180, 32)
        Me.lblNewProductID.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(29, 308)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(163, 23)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Product A&uthor:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 23)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Product P&rice:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(196, 23)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Product Add Da&te:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 23)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Product &Distributor:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Product  &Quantity:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(525, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(205, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Product De&scription:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(811, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Product Cate&gory:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(571, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Product &Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product &ID:"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(707, 489)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(158, 56)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Cl&ear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1559, 73)
        Me.pnlHeader.TabIndex = 5
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(610, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(222, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Add New Product"
        '
        'AddNewProduct
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1559, 577)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "AddNewProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddNewProduct"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNewProductDistributor As TextBox
    Friend WithEvents txtNewProductAuthor As TextBox
    Friend WithEvents dtpProductAddedDate As DateTimePicker
    Friend WithEvents txtNewProductDesc As TextBox
    Friend WithEvents txtNewProductName As TextBox
    Friend WithEvents lblNewProductID As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtNewProductQuantity As TextBox
    Friend WithEvents txtNewProductPrice As TextBox
    Friend WithEvents cboProductCategory As ComboBox
End Class
