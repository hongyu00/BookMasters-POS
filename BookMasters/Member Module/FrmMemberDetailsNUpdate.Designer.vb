<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMemberDetailsNUpdate
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
        Me.components = New System.ComponentModel.Container()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mskIC = New System.Windows.Forms.MaskedTextBox()
        Me.lblIC = New System.Windows.Forms.Label()
        Me.cboCountry = New System.Windows.Forms.ComboBox()
        Me.mskHome = New System.Windows.Forms.MaskedTextBox()
        Me.mskMobile = New System.Windows.Forms.MaskedTextBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblHomeNo = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblNationality = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.grpView = New System.Windows.Forms.GroupBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.dtpExpired = New System.Windows.Forms.DateTimePicker()
        Me.lblExpired = New System.Windows.Forms.Label()
        Me.lblLStatus = New System.Windows.Forms.Label()
        Me.lblLPoints = New System.Windows.Forms.Label()
        Me.dtpDOJ = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.lblLMemberID = New System.Windows.Forms.Label()
        Me.lblMemberID = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlHeader.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpView.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1235, 73)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(541, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(202, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Member Details"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(613, 460)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(130, 44)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Ed&it"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mskIC)
        Me.GroupBox1.Controls.Add(Me.lblIC)
        Me.GroupBox1.Controls.Add(Me.cboCountry)
        Me.GroupBox1.Controls.Add(Me.mskHome)
        Me.GroupBox1.Controls.Add(Me.mskMobile)
        Me.GroupBox1.Controls.Add(Me.dtpDOB)
        Me.GroupBox1.Controls.Add(Me.cboGender)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.lblHomeNo)
        Me.GroupBox1.Controls.Add(Me.lblGender)
        Me.GroupBox1.Controls.Add(Me.lblEmail)
        Me.GroupBox1.Controls.Add(Me.lblNationality)
        Me.GroupBox1.Controls.Add(Me.lblDOB)
        Me.GroupBox1.Controls.Add(Me.lblMobile)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 508)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Member Information"
        '
        'mskIC
        '
        Me.mskIC.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskIC.Location = New System.Drawing.Point(166, 100)
        Me.mskIC.Mask = "000000-00-0000"
        Me.mskIC.Name = "mskIC"
        Me.mskIC.Size = New System.Drawing.Size(131, 28)
        Me.mskIC.TabIndex = 3
        '
        'lblIC
        '
        Me.lblIC.AutoSize = True
        Me.lblIC.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIC.Location = New System.Drawing.Point(69, 103)
        Me.lblIC.Name = "lblIC"
        Me.lblIC.Size = New System.Drawing.Size(68, 21)
        Me.lblIC.TabIndex = 2
        Me.lblIC.Text = "&IC No :"
        '
        'cboCountry
        '
        Me.cboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCountry.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCountry.FormattingEnabled = True
        Me.cboCountry.Location = New System.Drawing.Point(166, 450)
        Me.cboCountry.Name = "cboCountry"
        Me.cboCountry.Size = New System.Drawing.Size(117, 29)
        Me.cboCountry.TabIndex = 15
        '
        'mskHome
        '
        Me.mskHome.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskHome.Location = New System.Drawing.Point(166, 274)
        Me.mskHome.Mask = "00-0000000"
        Me.mskHome.Name = "mskHome"
        Me.mskHome.Size = New System.Drawing.Size(129, 28)
        Me.mskHome.TabIndex = 9
        '
        'mskMobile
        '
        Me.mskMobile.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskMobile.Location = New System.Drawing.Point(166, 209)
        Me.mskMobile.Mask = "000-00000009"
        Me.mskMobile.Name = "mskMobile"
        Me.mskMobile.Size = New System.Drawing.Size(129, 28)
        Me.mskMobile.TabIndex = 7
        '
        'dtpDOB
        '
        Me.dtpDOB.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Location = New System.Drawing.Point(166, 153)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(331, 28)
        Me.dtpDOB.TabIndex = 5
        Me.dtpDOB.Value = New Date(2020, 11, 23, 15, 44, 50, 0)
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Female", "Male"})
        Me.cboGender.Location = New System.Drawing.Point(166, 393)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(117, 29)
        Me.cboGender.TabIndex = 13
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(166, 340)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(331, 28)
        Me.txtEmail.TabIndex = 11
        '
        'lblHomeNo
        '
        Me.lblHomeNo.AutoSize = True
        Me.lblHomeNo.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeNo.Location = New System.Drawing.Point(39, 277)
        Me.lblHomeNo.Name = "lblHomeNo"
        Me.lblHomeNo.Size = New System.Drawing.Size(98, 21)
        Me.lblHomeNo.TabIndex = 8
        Me.lblHomeNo.Text = "&Home No :"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(53, 396)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(84, 21)
        Me.lblGender.TabIndex = 12
        Me.lblGender.Text = "&Gender :"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(75, 340)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(62, 21)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "&Email :"
        '
        'lblNationality
        '
        Me.lblNationality.AutoSize = True
        Me.lblNationality.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNationality.Location = New System.Drawing.Point(28, 454)
        Me.lblNationality.Name = "lblNationality"
        Me.lblNationality.Size = New System.Drawing.Size(109, 21)
        Me.lblNationality.TabIndex = 14
        Me.lblNationality.Text = "N&ationality :"
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.Location = New System.Drawing.Point(13, 159)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(124, 21)
        Me.lblDOB.TabIndex = 4
        Me.lblDOB.Text = "Date of &Birth :"
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobile.Location = New System.Drawing.Point(31, 212)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(106, 21)
        Me.lblMobile.TabIndex = 6
        Me.lblMobile.Text = "&Mobile No :"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(166, 46)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(331, 28)
        Me.txtName.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(66, 53)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(71, 21)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "&Name :"
        '
        'grpView
        '
        Me.grpView.Controls.Add(Me.lblStatus)
        Me.grpView.Controls.Add(Me.dtpExpired)
        Me.grpView.Controls.Add(Me.lblExpired)
        Me.grpView.Controls.Add(Me.lblLStatus)
        Me.grpView.Controls.Add(Me.lblLPoints)
        Me.grpView.Controls.Add(Me.dtpDOJ)
        Me.grpView.Controls.Add(Me.Label2)
        Me.grpView.Controls.Add(Me.lblPoints)
        Me.grpView.Controls.Add(Me.lblLMemberID)
        Me.grpView.Controls.Add(Me.lblMemberID)
        Me.grpView.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpView.Location = New System.Drawing.Point(613, 93)
        Me.grpView.Name = "grpView"
        Me.grpView.Size = New System.Drawing.Size(571, 297)
        Me.grpView.TabIndex = 2
        Me.grpView.TabStop = False
        Me.grpView.Text = "View Only"
        '
        'lblStatus
        '
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatus.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(191, 88)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(124, 27)
        Me.lblStatus.TabIndex = 3
        '
        'dtpExpired
        '
        Me.dtpExpired.Enabled = False
        Me.dtpExpired.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExpired.Location = New System.Drawing.Point(191, 177)
        Me.dtpExpired.Name = "dtpExpired"
        Me.dtpExpired.Size = New System.Drawing.Size(341, 28)
        Me.dtpExpired.TabIndex = 7
        Me.dtpExpired.Value = New Date(2020, 11, 23, 15, 44, 50, 0)
        '
        'lblExpired
        '
        Me.lblExpired.AutoSize = True
        Me.lblExpired.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpired.Location = New System.Drawing.Point(43, 177)
        Me.lblExpired.Name = "lblExpired"
        Me.lblExpired.Size = New System.Drawing.Size(131, 21)
        Me.lblExpired.TabIndex = 6
        Me.lblExpired.Text = "Exipi&red Date :"
        '
        'lblLStatus
        '
        Me.lblLStatus.AutoSize = True
        Me.lblLStatus.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLStatus.Location = New System.Drawing.Point(106, 90)
        Me.lblLStatus.Name = "lblLStatus"
        Me.lblLStatus.Size = New System.Drawing.Size(71, 21)
        Me.lblLStatus.TabIndex = 2
        Me.lblLStatus.Text = "S&tatus :"
        '
        'lblLPoints
        '
        Me.lblLPoints.AutoSize = True
        Me.lblLPoints.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLPoints.Location = New System.Drawing.Point(106, 134)
        Me.lblLPoints.Name = "lblLPoints"
        Me.lblLPoints.Size = New System.Drawing.Size(68, 21)
        Me.lblLPoints.TabIndex = 4
        Me.lblLPoints.Text = "&Points :"
        '
        'dtpDOJ
        '
        Me.dtpDOJ.Enabled = False
        Me.dtpDOJ.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOJ.Location = New System.Drawing.Point(191, 225)
        Me.dtpDOJ.Name = "dtpDOJ"
        Me.dtpDOJ.Size = New System.Drawing.Size(341, 28)
        Me.dtpDOJ.TabIndex = 9
        Me.dtpDOJ.Value = New Date(2020, 11, 23, 15, 44, 50, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Date of &Joined :"
        '
        'lblPoints
        '
        Me.lblPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPoints.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.Location = New System.Drawing.Point(191, 132)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(124, 27)
        Me.lblPoints.TabIndex = 5
        '
        'lblLMemberID
        '
        Me.lblLMemberID.AutoSize = True
        Me.lblLMemberID.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLMemberID.Location = New System.Drawing.Point(63, 39)
        Me.lblLMemberID.Name = "lblLMemberID"
        Me.lblLMemberID.Size = New System.Drawing.Size(114, 21)
        Me.lblLMemberID.TabIndex = 0
        Me.lblLMemberID.Text = "Member I&D :"
        '
        'lblMemberID
        '
        Me.lblMemberID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMemberID.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberID.Location = New System.Drawing.Point(190, 37)
        Me.lblMemberID.Name = "lblMemberID"
        Me.lblMemberID.Size = New System.Drawing.Size(200, 27)
        Me.lblMemberID.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(761, 460)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(130, 44)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(1054, 460)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(130, 44)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(908, 460)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(130, 44)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'FrmMemberDetailsNUpdate
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1235, 613)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpView)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMemberDetailsNUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Details"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpView.ResumeLayout(False)
        Me.grpView.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboCountry As ComboBox
    Friend WithEvents mskHome As MaskedTextBox
    Friend WithEvents mskMobile As MaskedTextBox
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblHomeNo As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblNationality As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents lblMobile As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblLStatus As Label
    Friend WithEvents lblMemberID As Label
    Friend WithEvents lblLMemberID As Label
    Friend WithEvents dtpExpired As DateTimePicker
    Friend WithEvents lblExpired As Label
    Friend WithEvents lblPoints As Label
    Friend WithEvents lblLPoints As Label
    Friend WithEvents dtpDOJ As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents grpView As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents err As ErrorProvider
    Friend WithEvents mskIC As MaskedTextBox
    Friend WithEvents lblIC As Label
End Class
