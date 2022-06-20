<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewAllDiscount
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
        Me.gvViewDiscount = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearchDiscount = New System.Windows.Forms.TextBox()
        Me.btnAddNewDiscount = New System.Windows.Forms.Button()
        Me.lblDiscountHeader = New System.Windows.Forms.Label()
        CType(Me.gvViewDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvViewDiscount
        '
        Me.gvViewDiscount.AllowUserToAddRows = False
        Me.gvViewDiscount.AllowUserToResizeColumns = False
        Me.gvViewDiscount.AllowUserToResizeRows = False
        Me.gvViewDiscount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gvViewDiscount.BackgroundColor = System.Drawing.Color.Azure
        Me.gvViewDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvViewDiscount.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gvViewDiscount.ColumnHeadersHeight = 80
        Me.gvViewDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvViewDiscount.EnableHeadersVisualStyles = False
        Me.gvViewDiscount.Location = New System.Drawing.Point(362, 389)
        Me.gvViewDiscount.Name = "gvViewDiscount"
        Me.gvViewDiscount.RowHeadersVisible = False
        Me.gvViewDiscount.RowHeadersWidth = 51
        Me.gvViewDiscount.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.gvViewDiscount.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.gvViewDiscount.RowTemplate.Height = 75
        Me.gvViewDiscount.RowTemplate.ReadOnly = True
        Me.gvViewDiscount.Size = New System.Drawing.Size(2100, 600)
        Me.gvViewDiscount.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1737, 293)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Search"
        '
        'txtSearchDiscount
        '
        Me.txtSearchDiscount.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchDiscount.Location = New System.Drawing.Point(1899, 295)
        Me.txtSearchDiscount.Name = "txtSearchDiscount"
        Me.txtSearchDiscount.Size = New System.Drawing.Size(233, 36)
        Me.txtSearchDiscount.TabIndex = 2
        '
        'btnAddNewDiscount
        '
        Me.btnAddNewDiscount.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddNewDiscount.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewDiscount.ForeColor = System.Drawing.Color.White
        Me.btnAddNewDiscount.Location = New System.Drawing.Point(1245, 1011)
        Me.btnAddNewDiscount.Name = "btnAddNewDiscount"
        Me.btnAddNewDiscount.Size = New System.Drawing.Size(302, 69)
        Me.btnAddNewDiscount.TabIndex = 4
        Me.btnAddNewDiscount.Text = "&Add New Discount"
        Me.btnAddNewDiscount.UseVisualStyleBackColor = False
        '
        'lblDiscountHeader
        '
        Me.lblDiscountHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscountHeader.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountHeader.Location = New System.Drawing.Point(363, 157)
        Me.lblDiscountHeader.Name = "lblDiscountHeader"
        Me.lblDiscountHeader.Size = New System.Drawing.Size(644, 88)
        Me.lblDiscountHeader.TabIndex = 0
        Me.lblDiscountHeader.Text = "View All Discount"
        Me.lblDiscountHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ViewAllDiscount
        '
        Me.AcceptButton = Me.btnAddNewDiscount
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.lblDiscountHeader)
        Me.Controls.Add(Me.btnAddNewDiscount)
        Me.Controls.Add(Me.txtSearchDiscount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gvViewDiscount)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "ViewAllDiscount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewAllDiscount"
        CType(Me.gvViewDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gvViewDiscount As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearchDiscount As TextBox
    Friend WithEvents btnAddNewDiscount As Button
    Friend WithEvents lblDiscountHeader As Label
End Class
