<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHome
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblOpenCounter = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOpenCounter = New FontAwesome.Sharp.IconButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCashCounter = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblExpectedCash = New System.Windows.Forms.Label()
        Me.lblVariousAmount = New System.Windows.Forms.Label()
        Me.lblVarious = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblOpenCounter2 = New System.Windows.Forms.Label()
        Me.btnCloseCounter = New FontAwesome.Sharp.IconButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblOpenCounter)
        Me.GroupBox1.Controls.Add(Me.IconButton1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnOpenCounter)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(328, 195)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 659)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Open Counter"
        '
        'lblOpenCounter
        '
        Me.lblOpenCounter.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpenCounter.Location = New System.Drawing.Point(293, 131)
        Me.lblOpenCounter.Name = "lblOpenCounter"
        Me.lblOpenCounter.Size = New System.Drawing.Size(174, 39)
        Me.lblOpenCounter.TabIndex = 88
        Me.lblOpenCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IconButton1
        '
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(724, 570)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(203, 65)
        Me.IconButton1.TabIndex = 3
        Me.IconButton1.Text = "Close Counter"
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 48)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Open Counter Amount : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnOpenCounter
        '
        Me.btnOpenCounter.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnOpenCounter.IconChar = FontAwesome.Sharp.IconChar.HandPointLeft
        Me.btnOpenCounter.IconColor = System.Drawing.Color.Black
        Me.btnOpenCounter.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnOpenCounter.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOpenCounter.Location = New System.Drawing.Point(185, 570)
        Me.btnOpenCounter.Name = "btnOpenCounter"
        Me.btnOpenCounter.Size = New System.Drawing.Size(203, 65)
        Me.btnOpenCounter.TabIndex = 2
        Me.btnOpenCounter.Text = "Open Counter"
        Me.btnOpenCounter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOpenCounter.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblCashCounter)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblStatus)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblExpectedCash)
        Me.GroupBox2.Controls.Add(Me.lblVariousAmount)
        Me.GroupBox2.Controls.Add(Me.lblVarious)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblOpenCounter2)
        Me.GroupBox2.Controls.Add(Me.btnCloseCounter)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(973, 195)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(751, 659)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Close Counter"
        '
        'lblCashCounter
        '
        Me.lblCashCounter.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashCounter.Location = New System.Drawing.Point(425, 212)
        Me.lblCashCounter.Name = "lblCashCounter"
        Me.lblCashCounter.Size = New System.Drawing.Size(174, 39)
        Me.lblCashCounter.TabIndex = 87
        Me.lblCashCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(379, 34)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Total Amount from Cash Drawers : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(421, 404)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(284, 39)
        Me.lblStatus.TabIndex = 85
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(240, 404)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 39)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Status : "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(361, 34)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Open Counter Amount : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblExpectedCash
        '
        Me.lblExpectedCash.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpectedCash.Location = New System.Drawing.Point(425, 168)
        Me.lblExpectedCash.Name = "lblExpectedCash"
        Me.lblExpectedCash.Size = New System.Drawing.Size(174, 39)
        Me.lblExpectedCash.TabIndex = 81
        Me.lblExpectedCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVariousAmount
        '
        Me.lblVariousAmount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVariousAmount.Location = New System.Drawing.Point(428, 336)
        Me.lblVariousAmount.Name = "lblVariousAmount"
        Me.lblVariousAmount.Size = New System.Drawing.Size(166, 39)
        Me.lblVariousAmount.TabIndex = 83
        Me.lblVariousAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVarious
        '
        Me.lblVarious.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVarious.Location = New System.Drawing.Point(231, 336)
        Me.lblVarious.Name = "lblVarious"
        Me.lblVarious.Size = New System.Drawing.Size(184, 39)
        Me.lblVarious.TabIndex = 80
        Me.lblVarious.Text = "Various Amount : "
        Me.lblVarious.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(383, 34)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Total Expected Cash to be Received : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOpenCounter2
        '
        Me.lblOpenCounter2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpenCounter2.Location = New System.Drawing.Point(425, 126)
        Me.lblOpenCounter2.Name = "lblOpenCounter2"
        Me.lblOpenCounter2.Size = New System.Drawing.Size(174, 39)
        Me.lblOpenCounter2.TabIndex = 82
        Me.lblOpenCounter2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCloseCounter
        '
        Me.btnCloseCounter.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCloseCounter.IconChar = FontAwesome.Sharp.IconChar.HandPointRight
        Me.btnCloseCounter.IconColor = System.Drawing.Color.Black
        Me.btnCloseCounter.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCloseCounter.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCloseCounter.Location = New System.Drawing.Point(290, 570)
        Me.btnCloseCounter.Name = "btnCloseCounter"
        Me.btnCloseCounter.Size = New System.Drawing.Size(203, 65)
        Me.btnCloseCounter.TabIndex = 3
        Me.btnCloseCounter.Text = "Close Counter"
        Me.btnCloseCounter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCloseCounter.UseVisualStyleBackColor = True
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(2044, 857)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmHome"
        Me.Text = "FrmHome"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCloseCounter As FontAwesome.Sharp.IconButton
    Friend WithEvents btnOpenCounter As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCashCounter As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblExpectedCash As Label
    Friend WithEvents lblVariousAmount As Label
    Friend WithEvents lblVarious As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblOpenCounter2 As Label
    Friend WithEvents lblOpenCounter As Label
End Class
