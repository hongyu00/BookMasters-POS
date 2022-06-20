<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditDiscountInfo
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
        Me.txtUpdateDiscountName = New System.Windows.Forms.TextBox()
        Me.cboDiscountStatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUpdateDiscountPercentage = New System.Windows.Forms.TextBox()
        Me.clbSelectedDiscountProduct = New System.Windows.Forms.CheckedListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUpdateDiscountDesc = New System.Windows.Forms.TextBox()
        Me.dtpUpdateDiscountEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpUpdateDiscountStartDate = New System.Windows.Forms.DateTimePicker()
        Me.lblNewDiscountID = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnConfirm.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(445, 603)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(159, 57)
        Me.btnConfirm.TabIndex = 2
        Me.btnConfirm.Text = "&Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(687, 603)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(159, 57)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "C&ancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtUpdateDiscountName)
        Me.GroupBox1.Controls.Add(Me.cboDiscountStatus)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtUpdateDiscountPercentage)
        Me.GroupBox1.Controls.Add(Me.clbSelectedDiscountProduct)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtUpdateDiscountDesc)
        Me.GroupBox1.Controls.Add(Me.dtpUpdateDiscountEndDate)
        Me.GroupBox1.Controls.Add(Me.dtpUpdateDiscountStartDate)
        Me.GroupBox1.Controls.Add(Me.lblNewDiscountID)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1174, 507)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtUpdateDiscountName
        '
        Me.txtUpdateDiscountName.Location = New System.Drawing.Point(696, 31)
        Me.txtUpdateDiscountName.Multiline = True
        Me.txtUpdateDiscountName.Name = "txtUpdateDiscountName"
        Me.txtUpdateDiscountName.Size = New System.Drawing.Size(453, 32)
        Me.txtUpdateDiscountName.TabIndex = 2
        '
        'cboDiscountStatus
        '
        Me.cboDiscountStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiscountStatus.FormattingEnabled = True
        Me.cboDiscountStatus.Location = New System.Drawing.Point(243, 421)
        Me.cboDiscountStatus.Name = "cboDiscountStatus"
        Me.cboDiscountStatus.Size = New System.Drawing.Size(209, 31)
        Me.cboDiscountStatus.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 424)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Discount &Status:"
        '
        'txtUpdateDiscountPercentage
        '
        Me.txtUpdateDiscountPercentage.Location = New System.Drawing.Point(296, 79)
        Me.txtUpdateDiscountPercentage.Name = "txtUpdateDiscountPercentage"
        Me.txtUpdateDiscountPercentage.Size = New System.Drawing.Size(78, 32)
        Me.txtUpdateDiscountPercentage.TabIndex = 3
        '
        'clbSelectedDiscountProduct
        '
        Me.clbSelectedDiscountProduct.FormattingEnabled = True
        Me.clbSelectedDiscountProduct.Location = New System.Drawing.Point(378, 262)
        Me.clbSelectedDiscountProduct.Name = "clbSelectedDiscountProduct"
        Me.clbSelectedDiscountProduct.Size = New System.Drawing.Size(771, 139)
        Me.clbSelectedDiscountProduct.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(254, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Select Discount &Product: "
        '
        'txtUpdateDiscountDesc
        '
        Me.txtUpdateDiscountDesc.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateDiscountDesc.Location = New System.Drawing.Point(378, 176)
        Me.txtUpdateDiscountDesc.Multiline = True
        Me.txtUpdateDiscountDesc.Name = "txtUpdateDiscountDesc"
        Me.txtUpdateDiscountDesc.Size = New System.Drawing.Size(771, 65)
        Me.txtUpdateDiscountDesc.TabIndex = 6
        '
        'dtpUpdateDiscountEndDate
        '
        Me.dtpUpdateDiscountEndDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpUpdateDiscountEndDate.Location = New System.Drawing.Point(696, 130)
        Me.dtpUpdateDiscountEndDate.Name = "dtpUpdateDiscountEndDate"
        Me.dtpUpdateDiscountEndDate.Size = New System.Drawing.Size(453, 32)
        Me.dtpUpdateDiscountEndDate.TabIndex = 5
        '
        'dtpUpdateDiscountStartDate
        '
        Me.dtpUpdateDiscountStartDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpUpdateDiscountStartDate.Location = New System.Drawing.Point(696, 79)
        Me.dtpUpdateDiscountStartDate.Name = "dtpUpdateDiscountStartDate"
        Me.dtpUpdateDiscountStartDate.Size = New System.Drawing.Size(453, 32)
        Me.dtpUpdateDiscountStartDate.TabIndex = 4
        '
        'lblNewDiscountID
        '
        Me.lblNewDiscountID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNewDiscountID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewDiscountID.Location = New System.Drawing.Point(224, 32)
        Me.lblNewDiscountID.Name = "lblNewDiscountID"
        Me.lblNewDiscountID.Size = New System.Drawing.Size(150, 29)
        Me.lblNewDiscountID.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(211, 23)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Discount &Description:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(471, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 23)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "&End Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(471, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 23)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "&Start Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Discoun&t (%): "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(471, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Discount &Name: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Discount &ID:"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1226, 73)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(507, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(219, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Edit Discount Info"
        '
        'EditDiscountInfo
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1226, 686)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Name = "EditDiscountInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditDiscountInfo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents clbSelectedDiscountProduct As CheckedListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUpdateDiscountDesc As TextBox
    Friend WithEvents dtpUpdateDiscountEndDate As DateTimePicker
    Friend WithEvents dtpUpdateDiscountStartDate As DateTimePicker
    Friend WithEvents lblNewDiscountID As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtUpdateDiscountPercentage As TextBox
    Friend WithEvents cboDiscountStatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUpdateDiscountName As TextBox
End Class
