<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditProductInfo
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
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtUpdateDesc = New System.Windows.Forms.TextBox()
        Me.cboProductStatus = New System.Windows.Forms.ComboBox()
        Me.txtUpdatePrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblProductCategory = New System.Windows.Forms.Label()
        Me.txtUpdateAuthor = New System.Windows.Forms.TextBox()
        Me.txtUpdateDistributor = New System.Windows.Forms.TextBox()
        Me.txtUpdateProductName = New System.Windows.Forms.TextBox()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnConfirm.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(579, 451)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(162, 56)
        Me.btnConfirm.TabIndex = 2
        Me.btnConfirm.Text = "&Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(839, 451)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(162, 56)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.cboProductStatus)
        Me.GroupBox1.Controls.Add(Me.txtUpdatePrice)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblProductCategory)
        Me.GroupBox1.Controls.Add(Me.txtUpdateAuthor)
        Me.GroupBox1.Controls.Add(Me.txtUpdateDistributor)
        Me.GroupBox1.Controls.Add(Me.txtUpdateProductName)
        Me.GroupBox1.Controls.Add(Me.lblProductID)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1485, 333)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.txtUpdateDesc)
        Me.Panel1.Location = New System.Drawing.Point(775, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(688, 101)
        Me.Panel1.TabIndex = 21
        '
        'txtUpdateDesc
        '
        Me.txtUpdateDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUpdateDesc.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateDesc.Location = New System.Drawing.Point(0, 0)
        Me.txtUpdateDesc.Multiline = True
        Me.txtUpdateDesc.Name = "txtUpdateDesc"
        Me.txtUpdateDesc.Size = New System.Drawing.Size(704, 101)
        Me.txtUpdateDesc.TabIndex = 0
        '
        'cboProductStatus
        '
        Me.cboProductStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProductStatus.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProductStatus.FormattingEnabled = True
        Me.cboProductStatus.Location = New System.Drawing.Point(775, 272)
        Me.cboProductStatus.Name = "cboProductStatus"
        Me.cboProductStatus.Size = New System.Drawing.Size(180, 31)
        Me.cboProductStatus.TabIndex = 14
        '
        'txtUpdatePrice
        '
        Me.txtUpdatePrice.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdatePrice.Location = New System.Drawing.Point(283, 88)
        Me.txtUpdatePrice.Name = "txtUpdatePrice"
        Me.txtUpdatePrice.Size = New System.Drawing.Size(198, 32)
        Me.txtUpdatePrice.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(506, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Product &Status:"
        '
        'lblProductCategory
        '
        Me.lblProductCategory.BackColor = System.Drawing.Color.White
        Me.lblProductCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProductCategory.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductCategory.Location = New System.Drawing.Point(283, 265)
        Me.lblProductCategory.Name = "lblProductCategory"
        Me.lblProductCategory.Size = New System.Drawing.Size(185, 32)
        Me.lblProductCategory.TabIndex = 12
        '
        'txtUpdateAuthor
        '
        Me.txtUpdateAuthor.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateAuthor.Location = New System.Drawing.Point(283, 148)
        Me.txtUpdateAuthor.Multiline = True
        Me.txtUpdateAuthor.Name = "txtUpdateAuthor"
        Me.txtUpdateAuthor.Size = New System.Drawing.Size(472, 35)
        Me.txtUpdateAuthor.TabIndex = 8
        '
        'txtUpdateDistributor
        '
        Me.txtUpdateDistributor.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateDistributor.Location = New System.Drawing.Point(283, 211)
        Me.txtUpdateDistributor.Multiline = True
        Me.txtUpdateDistributor.Name = "txtUpdateDistributor"
        Me.txtUpdateDistributor.Size = New System.Drawing.Size(472, 35)
        Me.txtUpdateDistributor.TabIndex = 10
        '
        'txtUpdateProductName
        '
        Me.txtUpdateProductName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateProductName.Location = New System.Drawing.Point(775, 29)
        Me.txtUpdateProductName.Multiline = True
        Me.txtUpdateProductName.Name = "txtUpdateProductName"
        Me.txtUpdateProductName.Size = New System.Drawing.Size(688, 35)
        Me.txtUpdateProductName.TabIndex = 3
        '
        'lblProductID
        '
        Me.lblProductID.BackColor = System.Drawing.Color.White
        Me.lblProductID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProductID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductID.Location = New System.Drawing.Point(283, 31)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(198, 32)
        Me.lblProductID.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(29, 214)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(192, 23)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Product &Distributor:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 23)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Product &Price:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 23)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Product &Author:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(503, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(205, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Product D&escription:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Product Cate&gory:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(503, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Product &Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Product &ID:"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1541, 73)
        Me.pnlHeader.TabIndex = 5
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(684, 22)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(207, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Edit Product Info"
        '
        'EditProductInfo
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1541, 536)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Name = "EditProductInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " EditProductInfo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtUpdateAuthor As TextBox
    Friend WithEvents txtUpdateDistributor As TextBox
    Friend WithEvents txtUpdateProductName As TextBox
    Friend WithEvents lblProductID As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblProductCategory As Label
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUpdatePrice As TextBox
    Friend WithEvents cboProductStatus As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtUpdateDesc As TextBox
End Class
