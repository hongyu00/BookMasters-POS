<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSelectedProductDetails
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
        Me.btnEditProduct = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnAddStock = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblProductDetails = New System.Windows.Forms.Label()
        Me.lblSelectedProductName = New System.Windows.Forms.Label()
        Me.lblSelectedProductAddedDate = New System.Windows.Forms.Label()
        Me.lblTotalAddedStock = New System.Windows.Forms.Label()
        Me.lblStockIn = New System.Windows.Forms.Label()
        Me.lblSelectedProductDesc = New System.Windows.Forms.Label()
        Me.lblProductAuthor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblInStock = New System.Windows.Forms.Label()
        Me.lblStockOut = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEditProduct
        '
        Me.btnEditProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEditProduct.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditProduct.ForeColor = System.Drawing.Color.White
        Me.btnEditProduct.Location = New System.Drawing.Point(490, 521)
        Me.btnEditProduct.Name = "btnEditProduct"
        Me.btnEditProduct.Size = New System.Drawing.Size(192, 67)
        Me.btnEditProduct.TabIndex = 9
        Me.btnEditProduct.Text = "&Edit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Product" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnEditProduct.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOk.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(740, 521)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(192, 67)
        Me.btnOk.TabIndex = 10
        Me.btnOk.Text = "&OK"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnAddStock
        '
        Me.btnAddStock.AutoSize = True
        Me.btnAddStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddStock.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStock.ForeColor = System.Drawing.Color.White
        Me.btnAddStock.Location = New System.Drawing.Point(240, 521)
        Me.btnAddStock.Name = "btnAddStock"
        Me.btnAddStock.Size = New System.Drawing.Size(192, 67)
        Me.btnAddStock.TabIndex = 8
        Me.btnAddStock.Text = "&Add " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Stock"
        Me.btnAddStock.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1199, 73)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(451, 22)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(192, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Product Details"
        '
        'lblProductDetails
        '
        Me.lblProductDetails.BackColor = System.Drawing.Color.Azure
        Me.lblProductDetails.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductDetails.Location = New System.Drawing.Point(34, 102)
        Me.lblProductDetails.Name = "lblProductDetails"
        Me.lblProductDetails.Size = New System.Drawing.Size(1124, 396)
        Me.lblProductDetails.TabIndex = 0
        '
        'lblSelectedProductName
        '
        Me.lblSelectedProductName.BackColor = System.Drawing.Color.Azure
        Me.lblSelectedProductName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSelectedProductName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedProductName.Location = New System.Drawing.Point(64, 123)
        Me.lblSelectedProductName.Name = "lblSelectedProductName"
        Me.lblSelectedProductName.Size = New System.Drawing.Size(1032, 46)
        Me.lblSelectedProductName.TabIndex = 1
        Me.lblSelectedProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSelectedProductAddedDate
        '
        Me.lblSelectedProductAddedDate.BackColor = System.Drawing.Color.Azure
        Me.lblSelectedProductAddedDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSelectedProductAddedDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedProductAddedDate.Location = New System.Drawing.Point(54, 419)
        Me.lblSelectedProductAddedDate.Name = "lblSelectedProductAddedDate"
        Me.lblSelectedProductAddedDate.Size = New System.Drawing.Size(637, 37)
        Me.lblSelectedProductAddedDate.TabIndex = 6
        Me.lblSelectedProductAddedDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalAddedStock
        '
        Me.lblTotalAddedStock.BackColor = System.Drawing.Color.Azure
        Me.lblTotalAddedStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalAddedStock.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAddedStock.Location = New System.Drawing.Point(54, 351)
        Me.lblTotalAddedStock.Name = "lblTotalAddedStock"
        Me.lblTotalAddedStock.Size = New System.Drawing.Size(331, 37)
        Me.lblTotalAddedStock.TabIndex = 3
        Me.lblTotalAddedStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStockIn
        '
        Me.lblStockIn.BackColor = System.Drawing.Color.Azure
        Me.lblStockIn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockIn.Location = New System.Drawing.Point(424, 351)
        Me.lblStockIn.Name = "lblStockIn"
        Me.lblStockIn.Size = New System.Drawing.Size(258, 37)
        Me.lblStockIn.TabIndex = 0
        Me.lblStockIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSelectedProductDesc
        '
        Me.lblSelectedProductDesc.BackColor = System.Drawing.Color.Azure
        Me.lblSelectedProductDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSelectedProductDesc.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedProductDesc.Location = New System.Drawing.Point(0, 0)
        Me.lblSelectedProductDesc.Name = "lblSelectedProductDesc"
        Me.lblSelectedProductDesc.Size = New System.Drawing.Size(756, 124)
        Me.lblSelectedProductDesc.TabIndex = 0
        '
        'lblProductAuthor
        '
        Me.lblProductAuthor.BackColor = System.Drawing.Color.Azure
        Me.lblProductAuthor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProductAuthor.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductAuthor.Location = New System.Drawing.Point(712, 417)
        Me.lblProductAuthor.Name = "lblProductAuthor"
        Me.lblProductAuthor.Size = New System.Drawing.Size(425, 42)
        Me.lblProductAuthor.TabIndex = 7
        Me.lblProductAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Azure
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Product Description: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.lblSelectedProductDesc)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Location = New System.Drawing.Point(380, 197)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 124)
        Me.Panel1.TabIndex = 26
        '
        'lblInStock
        '
        Me.lblInStock.BackColor = System.Drawing.Color.Azure
        Me.lblInStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInStock.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInStock.Location = New System.Drawing.Point(403, 351)
        Me.lblInStock.Name = "lblInStock"
        Me.lblInStock.Size = New System.Drawing.Size(331, 37)
        Me.lblInStock.TabIndex = 4
        Me.lblInStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStockOut
        '
        Me.lblStockOut.BackColor = System.Drawing.Color.Azure
        Me.lblStockOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStockOut.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockOut.Location = New System.Drawing.Point(753, 351)
        Me.lblStockOut.Name = "lblStockOut"
        Me.lblStockOut.Size = New System.Drawing.Size(331, 37)
        Me.lblStockOut.TabIndex = 5
        Me.lblStockOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ViewSelectedProductDetails
        '
        Me.AcceptButton = Me.btnAddStock
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.CancelButton = Me.btnOk
        Me.ClientSize = New System.Drawing.Size(1199, 626)
        Me.Controls.Add(Me.lblStockOut)
        Me.Controls.Add(Me.lblInStock)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblProductAuthor)
        Me.Controls.Add(Me.lblStockIn)
        Me.Controls.Add(Me.lblTotalAddedStock)
        Me.Controls.Add(Me.lblSelectedProductAddedDate)
        Me.Controls.Add(Me.lblSelectedProductName)
        Me.Controls.Add(Me.lblProductDetails)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.btnAddStock)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnEditProduct)
        Me.Name = "ViewSelectedProductDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewSelectedProductDetails"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEditProduct As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents btnAddStock As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblProductDetails As Label
    Friend WithEvents lblSelectedProductName As Label
    Friend WithEvents lblSelectedProductAddedDate As Label
    Friend WithEvents lblTotalAddedStock As Label
    Friend WithEvents lblStockIn As Label
    Friend WithEvents lblSelectedProductDesc As Label
    Friend WithEvents lblProductAuthor As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblInStock As Label
    Friend WithEvents lblStockOut As Label
End Class
