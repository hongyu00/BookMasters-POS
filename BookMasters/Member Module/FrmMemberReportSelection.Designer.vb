<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMemberReportSelection
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
        Me.grpSelection = New System.Windows.Forms.GroupBox()
        Me.cboMemberID = New System.Windows.Forms.ComboBox()
        Me.lblMemberID = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.grpSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSelection
        '
        Me.grpSelection.Controls.Add(Me.cboMemberID)
        Me.grpSelection.Controls.Add(Me.lblMemberID)
        Me.grpSelection.Font = New System.Drawing.Font("Century Gothic", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSelection.Location = New System.Drawing.Point(624, 486)
        Me.grpSelection.Name = "grpSelection"
        Me.grpSelection.Size = New System.Drawing.Size(784, 225)
        Me.grpSelection.TabIndex = 2
        Me.grpSelection.TabStop = False
        Me.grpSelection.Text = "Select Member"
        '
        'cboMemberID
        '
        Me.cboMemberID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMemberID.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMemberID.FormattingEnabled = True
        Me.cboMemberID.Location = New System.Drawing.Point(492, 111)
        Me.cboMemberID.Name = "cboMemberID"
        Me.cboMemberID.Size = New System.Drawing.Size(173, 45)
        Me.cboMemberID.Sorted = True
        Me.cboMemberID.TabIndex = 1
        '
        'lblMemberID
        '
        Me.lblMemberID.AutoSize = True
        Me.lblMemberID.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberID.Location = New System.Drawing.Point(141, 111)
        Me.lblMemberID.Name = "lblMemberID"
        Me.lblMemberID.Size = New System.Drawing.Size(195, 37)
        Me.lblMemberID.TabIndex = 0
        Me.lblMemberID.Text = "Member I&D :"
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGenerate.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.ForeColor = System.Drawing.Color.White
        Me.btnGenerate.Location = New System.Drawing.Point(906, 788)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(304, 98)
        Me.btnGenerate.TabIndex = 3
        Me.btnGenerate.Text = "&Generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblTitle.Location = New System.Drawing.Point(830, 403)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(389, 37)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Activity Report For Who?  "
        '
        'lblHeader
        '
        Me.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeader.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(491, 200)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(1064, 123)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Activity Report"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmMemberReportSelection
        '
        Me.AcceptButton = Me.btnGenerate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1721, 1055)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.grpSelection)
        Me.Controls.Add(Me.btnGenerate)
        Me.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmMemberReportSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Report Selection"
        Me.grpSelection.ResumeLayout(False)
        Me.grpSelection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpSelection As GroupBox
    Friend WithEvents cboMemberID As ComboBox
    Friend WithEvents lblMemberID As Label
    Friend WithEvents btnGenerate As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblHeader As Label
End Class
