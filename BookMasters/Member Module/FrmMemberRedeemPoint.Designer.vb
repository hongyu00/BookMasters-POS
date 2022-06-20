<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMemberRedeemPoint
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
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblLStatus = New System.Windows.Forms.Label()
        Me.lblLPoints = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.lblLMemberID = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnRedeem = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblConvertToRM = New System.Windows.Forms.Label()
        Me.lblRedeemAmount = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblMemberID = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.White
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatus.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(178, 164)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(188, 29)
        Me.lblStatus.TabIndex = 5
        '
        'lblLStatus
        '
        Me.lblLStatus.AutoSize = True
        Me.lblLStatus.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLStatus.Location = New System.Drawing.Point(38, 169)
        Me.lblLStatus.Name = "lblLStatus"
        Me.lblLStatus.Size = New System.Drawing.Size(75, 22)
        Me.lblLStatus.TabIndex = 4
        Me.lblLStatus.Text = "S&tatus :"
        '
        'lblLPoints
        '
        Me.lblLPoints.AutoSize = True
        Me.lblLPoints.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLPoints.Location = New System.Drawing.Point(41, 219)
        Me.lblLPoints.Name = "lblLPoints"
        Me.lblLPoints.Size = New System.Drawing.Size(72, 22)
        Me.lblLPoints.TabIndex = 6
        Me.lblLPoints.Text = "&Points :"
        '
        'lblPoints
        '
        Me.lblPoints.BackColor = System.Drawing.Color.White
        Me.lblPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPoints.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.Location = New System.Drawing.Point(178, 214)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(188, 29)
        Me.lblPoints.TabIndex = 7
        '
        'lblLMemberID
        '
        Me.lblLMemberID.AutoSize = True
        Me.lblLMemberID.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLMemberID.Location = New System.Drawing.Point(38, 117)
        Me.lblLMemberID.Name = "lblLMemberID"
        Me.lblLMemberID.Size = New System.Drawing.Size(121, 22)
        Me.lblLMemberID.TabIndex = 2
        Me.lblLMemberID.Text = "Member I&D :"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(228, 347)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(143, 47)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnRedeem
        '
        Me.btnRedeem.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRedeem.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRedeem.ForeColor = System.Drawing.Color.White
        Me.btnRedeem.Location = New System.Drawing.Point(42, 347)
        Me.btnRedeem.Name = "btnRedeem"
        Me.btnRedeem.Size = New System.Drawing.Size(135, 47)
        Me.btnRedeem.TabIndex = 12
        Me.btnRedeem.Text = "&Redeem"
        Me.btnRedeem.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(406, 73)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(88, 22)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(243, 30)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Point Redeemption"
        '
        'lblConvertToRM
        '
        Me.lblConvertToRM.AutoSize = True
        Me.lblConvertToRM.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvertToRM.Location = New System.Drawing.Point(41, 272)
        Me.lblConvertToRM.Name = "lblConvertToRM"
        Me.lblConvertToRM.Size = New System.Drawing.Size(122, 22)
        Me.lblConvertToRM.TabIndex = 8
        Me.lblConvertToRM.Text = "&Convert To :"
        '
        'lblRedeemAmount
        '
        Me.lblRedeemAmount.BackColor = System.Drawing.Color.White
        Me.lblRedeemAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRedeemAmount.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRedeemAmount.Location = New System.Drawing.Point(178, 267)
        Me.lblRedeemAmount.Name = "lblRedeemAmount"
        Me.lblRedeemAmount.Size = New System.Drawing.Size(188, 29)
        Me.lblRedeemAmount.TabIndex = 9
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(174, 307)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(197, 19)
        Me.lblDesc.TabIndex = 10
        Me.lblDesc.Text = "(100 points convert to RM1)"
        '
        'lblMemberID
        '
        Me.lblMemberID.BackColor = System.Drawing.Color.White
        Me.lblMemberID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMemberID.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberID.Location = New System.Drawing.Point(178, 116)
        Me.lblMemberID.Name = "lblMemberID"
        Me.lblMemberID.Size = New System.Drawing.Size(188, 29)
        Me.lblMemberID.TabIndex = 3
        '
        'FrmMemberRedeemPoint
        '
        Me.AcceptButton = Me.btnRedeem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(406, 440)
        Me.Controls.Add(Me.lblMemberID)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.lblConvertToRM)
        Me.Controls.Add(Me.lblRedeemAmount)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblLStatus)
        Me.Controls.Add(Me.btnRedeem)
        Me.Controls.Add(Me.lblLPoints)
        Me.Controls.Add(Me.lblLMemberID)
        Me.Controls.Add(Me.lblPoints)
        Me.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmMemberRedeemPoint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Redeemption"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblLStatus As Label
    Friend WithEvents lblLPoints As Label
    Friend WithEvents lblPoints As Label
    Friend WithEvents lblLMemberID As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnRedeem As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblConvertToRM As Label
    Friend WithEvents lblRedeemAmount As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblMemberID As Label
End Class
