<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSelectedDiscountDetails
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
        Me.lblDiscountInfo = New System.Windows.Forms.Label()
        Me.btnEditDiscount = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDiscountPercentage = New System.Windows.Forms.Label()
        Me.lblDiscountStartDate = New System.Windows.Forms.Label()
        Me.lblDiscountDesc = New System.Windows.Forms.Label()
        Me.lblDiscountStatus = New System.Windows.Forms.Label()
        Me.lblDiscountName = New System.Windows.Forms.Label()
        Me.lblDiscountEndDate = New System.Windows.Forms.Label()
        Me.lblProdDesc = New System.Windows.Forms.Label()
        Me.lblDiscountProducts = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDiscountInfo
        '
        Me.lblDiscountInfo.BackColor = System.Drawing.Color.Azure
        Me.lblDiscountInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscountInfo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountInfo.Location = New System.Drawing.Point(25, 99)
        Me.lblDiscountInfo.Name = "lblDiscountInfo"
        Me.lblDiscountInfo.Size = New System.Drawing.Size(1044, 467)
        Me.lblDiscountInfo.TabIndex = 1
        '
        'btnEditDiscount
        '
        Me.btnEditDiscount.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEditDiscount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditDiscount.ForeColor = System.Drawing.Color.White
        Me.btnEditDiscount.Location = New System.Drawing.Point(323, 583)
        Me.btnEditDiscount.Name = "btnEditDiscount"
        Me.btnEditDiscount.Size = New System.Drawing.Size(195, 67)
        Me.btnEditDiscount.TabIndex = 12
        Me.btnEditDiscount.Text = "&Edit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Discount" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnEditDiscount.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOk.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(605, 583)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(195, 67)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "&OK"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1093, 73)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(445, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(204, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Discount Details"
        '
        'lblDiscountPercentage
        '
        Me.lblDiscountPercentage.BackColor = System.Drawing.Color.Azure
        Me.lblDiscountPercentage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscountPercentage.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountPercentage.Location = New System.Drawing.Point(58, 188)
        Me.lblDiscountPercentage.Name = "lblDiscountPercentage"
        Me.lblDiscountPercentage.Size = New System.Drawing.Size(348, 35)
        Me.lblDiscountPercentage.TabIndex = 3
        '
        'lblDiscountStartDate
        '
        Me.lblDiscountStartDate.BackColor = System.Drawing.Color.Azure
        Me.lblDiscountStartDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscountStartDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountStartDate.Location = New System.Drawing.Point(58, 313)
        Me.lblDiscountStartDate.Name = "lblDiscountStartDate"
        Me.lblDiscountStartDate.Size = New System.Drawing.Size(482, 35)
        Me.lblDiscountStartDate.TabIndex = 6
        '
        'lblDiscountDesc
        '
        Me.lblDiscountDesc.BackColor = System.Drawing.Color.Azure
        Me.lblDiscountDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscountDesc.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountDesc.Location = New System.Drawing.Point(0, 0)
        Me.lblDiscountDesc.Name = "lblDiscountDesc"
        Me.lblDiscountDesc.Size = New System.Drawing.Size(427, 108)
        Me.lblDiscountDesc.TabIndex = 0
        '
        'lblDiscountStatus
        '
        Me.lblDiscountStatus.BackColor = System.Drawing.Color.Azure
        Me.lblDiscountStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscountStatus.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountStatus.Location = New System.Drawing.Point(58, 249)
        Me.lblDiscountStatus.Name = "lblDiscountStatus"
        Me.lblDiscountStatus.Size = New System.Drawing.Size(505, 35)
        Me.lblDiscountStatus.TabIndex = 4
        '
        'lblDiscountName
        '
        Me.lblDiscountName.BackColor = System.Drawing.Color.Azure
        Me.lblDiscountName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscountName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountName.Location = New System.Drawing.Point(58, 123)
        Me.lblDiscountName.Name = "lblDiscountName"
        Me.lblDiscountName.Size = New System.Drawing.Size(983, 35)
        Me.lblDiscountName.TabIndex = 2
        Me.lblDiscountName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDiscountEndDate
        '
        Me.lblDiscountEndDate.BackColor = System.Drawing.Color.Azure
        Me.lblDiscountEndDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscountEndDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountEndDate.Location = New System.Drawing.Point(558, 312)
        Me.lblDiscountEndDate.Name = "lblDiscountEndDate"
        Me.lblDiscountEndDate.Size = New System.Drawing.Size(482, 35)
        Me.lblDiscountEndDate.TabIndex = 7
        '
        'lblProdDesc
        '
        Me.lblProdDesc.BackColor = System.Drawing.Color.Azure
        Me.lblProdDesc.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdDesc.Location = New System.Drawing.Point(446, 188)
        Me.lblProdDesc.Name = "lblProdDesc"
        Me.lblProdDesc.Size = New System.Drawing.Size(169, 65)
        Me.lblProdDesc.TabIndex = 5
        Me.lblProdDesc.Text = "Discount" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Description: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblDiscountProducts
        '
        Me.lblDiscountProducts.AutoSize = True
        Me.lblDiscountProducts.BackColor = System.Drawing.Color.Azure
        Me.lblDiscountProducts.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountProducts.Location = New System.Drawing.Point(0, 0)
        Me.lblDiscountProducts.Name = "lblDiscountProducts"
        Me.lblDiscountProducts.Size = New System.Drawing.Size(0, 23)
        Me.lblDiscountProducts.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.lblDiscountProducts)
        Me.Panel1.Location = New System.Drawing.Point(58, 422)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(982, 111)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.lblDiscountDesc)
        Me.Panel2.Location = New System.Drawing.Point(625, 188)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(416, 108)
        Me.Panel2.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Azure
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 379)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(482, 35)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Product that will have discount: "
        '
        'ViewSelectedDiscountDetails
        '
        Me.AcceptButton = Me.btnEditDiscount
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.CancelButton = Me.btnOk
        Me.ClientSize = New System.Drawing.Size(1093, 680)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblProdDesc)
        Me.Controls.Add(Me.lblDiscountEndDate)
        Me.Controls.Add(Me.lblDiscountName)
        Me.Controls.Add(Me.lblDiscountStatus)
        Me.Controls.Add(Me.lblDiscountStartDate)
        Me.Controls.Add(Me.lblDiscountPercentage)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnEditDiscount)
        Me.Controls.Add(Me.lblDiscountInfo)
        Me.Name = "ViewSelectedDiscountDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewSelectedDiscountDetails"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDiscountInfo As Label
    Friend WithEvents btnEditDiscount As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDiscountPercentage As Label
    Friend WithEvents lblDiscountStartDate As Label
    Friend WithEvents lblDiscountDesc As Label
    Friend WithEvents lblDiscountStatus As Label
    Friend WithEvents lblDiscountName As Label
    Friend WithEvents lblDiscountEndDate As Label
    Friend WithEvents lblProdDesc As Label
    Friend WithEvents lblDiscountProducts As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
End Class
