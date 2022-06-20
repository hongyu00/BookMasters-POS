<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewAllProduct
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gvViewProduct = New System.Windows.Forms.DataGridView()
        Me.lblSearchProd = New System.Windows.Forms.Label()
        Me.txtSearchProduct = New System.Windows.Forms.TextBox()
        Me.btnAddNewProduct = New System.Windows.Forms.Button()
        Me.lblViewAllProd = New System.Windows.Forms.Label()
        CType(Me.gvViewProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvViewProduct
        '
        Me.gvViewProduct.AllowUserToAddRows = False
        Me.gvViewProduct.AllowUserToResizeColumns = False
        Me.gvViewProduct.AllowUserToResizeRows = False
        Me.gvViewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gvViewProduct.BackgroundColor = System.Drawing.Color.Azure
        Me.gvViewProduct.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvViewProduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gvViewProduct.ColumnHeadersHeight = 80
        Me.gvViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvViewProduct.DefaultCellStyle = DataGridViewCellStyle2
        Me.gvViewProduct.EnableHeadersVisualStyles = False
        Me.gvViewProduct.Location = New System.Drawing.Point(362, 389)
        Me.gvViewProduct.Name = "gvViewProduct"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvViewProduct.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.gvViewProduct.RowHeadersVisible = False
        Me.gvViewProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.gvViewProduct.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.gvViewProduct.RowTemplate.Height = 75
        Me.gvViewProduct.RowTemplate.ReadOnly = True
        Me.gvViewProduct.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvViewProduct.Size = New System.Drawing.Size(2100, 600)
        Me.gvViewProduct.TabIndex = 0
        '
        'lblSearchProd
        '
        Me.lblSearchProd.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchProd.Location = New System.Drawing.Point(1737, 293)
        Me.lblSearchProd.Name = "lblSearchProd"
        Me.lblSearchProd.Size = New System.Drawing.Size(144, 46)
        Me.lblSearchProd.TabIndex = 0
        Me.lblSearchProd.Text = "Search"
        '
        'txtSearchProduct
        '
        Me.txtSearchProduct.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchProduct.Location = New System.Drawing.Point(1899, 295)
        Me.txtSearchProduct.Name = "txtSearchProduct"
        Me.txtSearchProduct.Size = New System.Drawing.Size(235, 36)
        Me.txtSearchProduct.TabIndex = 1
        '
        'btnAddNewProduct
        '
        Me.btnAddNewProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddNewProduct.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewProduct.ForeColor = System.Drawing.Color.White
        Me.btnAddNewProduct.Location = New System.Drawing.Point(1233, 1011)
        Me.btnAddNewProduct.Name = "btnAddNewProduct"
        Me.btnAddNewProduct.Size = New System.Drawing.Size(302, 69)
        Me.btnAddNewProduct.TabIndex = 2
        Me.btnAddNewProduct.Text = "&Add New Product"
        Me.btnAddNewProduct.UseVisualStyleBackColor = False
        '
        'lblViewAllProd
        '
        Me.lblViewAllProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblViewAllProd.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewAllProd.Location = New System.Drawing.Point(363, 157)
        Me.lblViewAllProd.Name = "lblViewAllProd"
        Me.lblViewAllProd.Size = New System.Drawing.Size(639, 92)
        Me.lblViewAllProd.TabIndex = 8
        Me.lblViewAllProd.Text = "View All Product"
        Me.lblViewAllProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ViewAllProduct
        '
        Me.AcceptButton = Me.btnAddNewProduct
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.lblViewAllProd)
        Me.Controls.Add(Me.btnAddNewProduct)
        Me.Controls.Add(Me.txtSearchProduct)
        Me.Controls.Add(Me.lblSearchProd)
        Me.Controls.Add(Me.gvViewProduct)
        Me.Name = "ViewAllProduct"
        Me.Text = "ViewProduct"
        CType(Me.gvViewProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gvViewProduct As DataGridView
    Friend WithEvents lblSearchProd As Label
    Friend WithEvents txtSearchProduct As TextBox
    Friend WithEvents btnAddNewProduct As Button
    Friend WithEvents lblViewAllProd As Label
End Class
