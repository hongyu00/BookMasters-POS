<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddNewDiscount
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
        Me.btnAddNewDiscount = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTestUncheked = New System.Windows.Forms.Label()
        Me.txtNewDiscountPercentage = New System.Windows.Forms.TextBox()
        Me.clbNewDiscountSelectedProduct = New System.Windows.Forms.CheckedListBox()
        Me.lblDSelectProd = New System.Windows.Forms.Label()
        Me.txtNewDiscountDesc = New System.Windows.Forms.TextBox()
        Me.dtpNewDiscountEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpNewDiscountStartDate = New System.Windows.Forms.DateTimePicker()
        Me.txtNewDiscountName = New System.Windows.Forms.TextBox()
        Me.lblNewDiscountID = New System.Windows.Forms.Label()
        Me.lblDDesc = New System.Windows.Forms.Label()
        Me.lblDEndDate = New System.Windows.Forms.Label()
        Me.lblDStartDate = New System.Windows.Forms.Label()
        Me.lblDPercentage = New System.Windows.Forms.Label()
        Me.lblDName = New System.Windows.Forms.Label()
        Me.lblDID = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddNewDiscount
        '
        Me.btnAddNewDiscount.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddNewDiscount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewDiscount.ForeColor = System.Drawing.Color.White
        Me.btnAddNewDiscount.Location = New System.Drawing.Point(287, 623)
        Me.btnAddNewDiscount.Name = "btnAddNewDiscount"
        Me.btnAddNewDiscount.Size = New System.Drawing.Size(169, 56)
        Me.btnAddNewDiscount.TabIndex = 2
        Me.btnAddNewDiscount.Text = "&Add"
        Me.btnAddNewDiscount.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(784, 623)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(169, 56)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTestUncheked)
        Me.GroupBox1.Controls.Add(Me.txtNewDiscountPercentage)
        Me.GroupBox1.Controls.Add(Me.clbNewDiscountSelectedProduct)
        Me.GroupBox1.Controls.Add(Me.lblDSelectProd)
        Me.GroupBox1.Controls.Add(Me.txtNewDiscountDesc)
        Me.GroupBox1.Controls.Add(Me.dtpNewDiscountEndDate)
        Me.GroupBox1.Controls.Add(Me.dtpNewDiscountStartDate)
        Me.GroupBox1.Controls.Add(Me.txtNewDiscountName)
        Me.GroupBox1.Controls.Add(Me.lblNewDiscountID)
        Me.GroupBox1.Controls.Add(Me.lblDDesc)
        Me.GroupBox1.Controls.Add(Me.lblDEndDate)
        Me.GroupBox1.Controls.Add(Me.lblDStartDate)
        Me.GroupBox1.Controls.Add(Me.lblDPercentage)
        Me.GroupBox1.Controls.Add(Me.lblDName)
        Me.GroupBox1.Controls.Add(Me.lblDID)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(34, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1132, 505)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lblTestUncheked
        '
        Me.lblTestUncheked.AutoSize = True
        Me.lblTestUncheked.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTestUncheked.Location = New System.Drawing.Point(6, 238)
        Me.lblTestUncheked.Name = "lblTestUncheked"
        Me.lblTestUncheked.Size = New System.Drawing.Size(0, 23)
        Me.lblTestUncheked.TabIndex = 13
        '
        'txtNewDiscountPercentage
        '
        Me.txtNewDiscountPercentage.Location = New System.Drawing.Point(306, 83)
        Me.txtNewDiscountPercentage.Name = "txtNewDiscountPercentage"
        Me.txtNewDiscountPercentage.Size = New System.Drawing.Size(64, 32)
        Me.txtNewDiscountPercentage.TabIndex = 5
        '
        'clbNewDiscountSelectedProduct
        '
        Me.clbNewDiscountSelectedProduct.FormattingEnabled = True
        Me.clbNewDiscountSelectedProduct.Location = New System.Drawing.Point(365, 339)
        Me.clbNewDiscountSelectedProduct.Name = "clbNewDiscountSelectedProduct"
        Me.clbNewDiscountSelectedProduct.Size = New System.Drawing.Size(739, 139)
        Me.clbNewDiscountSelectedProduct.TabIndex = 13
        '
        'lblDSelectProd
        '
        Me.lblDSelectProd.AutoSize = True
        Me.lblDSelectProd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDSelectProd.Location = New System.Drawing.Point(24, 339)
        Me.lblDSelectProd.Name = "lblDSelectProd"
        Me.lblDSelectProd.Size = New System.Drawing.Size(254, 23)
        Me.lblDSelectProd.TabIndex = 12
        Me.lblDSelectProd.Text = "Select Discount &Product: "
        '
        'txtNewDiscountDesc
        '
        Me.txtNewDiscountDesc.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewDiscountDesc.Location = New System.Drawing.Point(365, 215)
        Me.txtNewDiscountDesc.Multiline = True
        Me.txtNewDiscountDesc.Name = "txtNewDiscountDesc"
        Me.txtNewDiscountDesc.Size = New System.Drawing.Size(739, 97)
        Me.txtNewDiscountDesc.TabIndex = 11
        '
        'dtpNewDiscountEndDate
        '
        Me.dtpNewDiscountEndDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNewDiscountEndDate.Location = New System.Drawing.Point(624, 159)
        Me.dtpNewDiscountEndDate.Name = "dtpNewDiscountEndDate"
        Me.dtpNewDiscountEndDate.Size = New System.Drawing.Size(480, 32)
        Me.dtpNewDiscountEndDate.TabIndex = 9
        '
        'dtpNewDiscountStartDate
        '
        Me.dtpNewDiscountStartDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNewDiscountStartDate.Location = New System.Drawing.Point(624, 98)
        Me.dtpNewDiscountStartDate.Name = "dtpNewDiscountStartDate"
        Me.dtpNewDiscountStartDate.Size = New System.Drawing.Size(480, 32)
        Me.dtpNewDiscountStartDate.TabIndex = 7
        '
        'txtNewDiscountName
        '
        Me.txtNewDiscountName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewDiscountName.Location = New System.Drawing.Point(624, 33)
        Me.txtNewDiscountName.Multiline = True
        Me.txtNewDiscountName.Name = "txtNewDiscountName"
        Me.txtNewDiscountName.Size = New System.Drawing.Size(480, 45)
        Me.txtNewDiscountName.TabIndex = 3
        '
        'lblNewDiscountID
        '
        Me.lblNewDiscountID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNewDiscountID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewDiscountID.Location = New System.Drawing.Point(208, 33)
        Me.lblNewDiscountID.Name = "lblNewDiscountID"
        Me.lblNewDiscountID.Size = New System.Drawing.Size(169, 29)
        Me.lblNewDiscountID.TabIndex = 1
        '
        'lblDDesc
        '
        Me.lblDDesc.AutoSize = True
        Me.lblDDesc.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDDesc.Location = New System.Drawing.Point(24, 215)
        Me.lblDDesc.Name = "lblDDesc"
        Me.lblDDesc.Size = New System.Drawing.Size(211, 23)
        Me.lblDDesc.TabIndex = 10
        Me.lblDDesc.Text = "Discount &Description:"
        '
        'lblDEndDate
        '
        Me.lblDEndDate.AutoSize = True
        Me.lblDEndDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDEndDate.Location = New System.Drawing.Point(397, 159)
        Me.lblDEndDate.Name = "lblDEndDate"
        Me.lblDEndDate.Size = New System.Drawing.Size(107, 23)
        Me.lblDEndDate.TabIndex = 8
        Me.lblDEndDate.Text = "&End Date:"
        '
        'lblDStartDate
        '
        Me.lblDStartDate.AutoSize = True
        Me.lblDStartDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDStartDate.Location = New System.Drawing.Point(397, 105)
        Me.lblDStartDate.Name = "lblDStartDate"
        Me.lblDStartDate.Size = New System.Drawing.Size(114, 23)
        Me.lblDStartDate.TabIndex = 6
        Me.lblDStartDate.Text = "&Start Date:"
        '
        'lblDPercentage
        '
        Me.lblDPercentage.AutoSize = True
        Me.lblDPercentage.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDPercentage.Location = New System.Drawing.Point(24, 86)
        Me.lblDPercentage.Name = "lblDPercentage"
        Me.lblDPercentage.Size = New System.Drawing.Size(140, 23)
        Me.lblDPercentage.TabIndex = 4
        Me.lblDPercentage.Text = "Discoun&t (%): "
        '
        'lblDName
        '
        Me.lblDName.AutoSize = True
        Me.lblDName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDName.Location = New System.Drawing.Point(397, 39)
        Me.lblDName.Name = "lblDName"
        Me.lblDName.Size = New System.Drawing.Size(171, 23)
        Me.lblDName.TabIndex = 2
        Me.lblDName.Text = "Discount &Name: "
        '
        'lblDID
        '
        Me.lblDID.AutoSize = True
        Me.lblDID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDID.Location = New System.Drawing.Point(24, 33)
        Me.lblDID.Name = "lblDID"
        Me.lblDID.Size = New System.Drawing.Size(124, 23)
        Me.lblDID.TabIndex = 0
        Me.lblDID.Text = "Discount &ID:"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(545, 623)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(169, 56)
        Me.btnClear.TabIndex = 3
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
        Me.pnlHeader.Size = New System.Drawing.Size(1202, 73)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(496, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(234, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Add New Discount"
        '
        'AddNewDiscount
        '
        Me.AcceptButton = Me.btnAddNewDiscount
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1202, 705)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddNewDiscount)
        Me.Name = "AddNewDiscount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAddNewDiscount As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDStartDate As Label
    Friend WithEvents lblDPercentage As Label
    Friend WithEvents lblDName As Label
    Friend WithEvents lblDID As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents lblDEndDate As Label
    Friend WithEvents txtNewDiscountName As TextBox
    Friend WithEvents lblNewDiscountID As Label
    Friend WithEvents lblDDesc As Label
    Friend WithEvents dtpNewDiscountStartDate As DateTimePicker
    Friend WithEvents txtNewDiscountDesc As TextBox
    Friend WithEvents dtpNewDiscountEndDate As DateTimePicker
    Friend WithEvents clbNewDiscountSelectedProduct As CheckedListBox
    Friend WithEvents lblDSelectProd As Label
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtNewDiscountPercentage As TextBox
    Friend WithEvents lblTestUncheked As Label
End Class
