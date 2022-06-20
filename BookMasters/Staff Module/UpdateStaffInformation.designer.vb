<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateStaffInformation
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
        Me.components = New System.ComponentModel.Container()
        Me.grpPersonalInfo = New System.Windows.Forms.GroupBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.mskContact = New System.Windows.Forms.MaskedTextBox()
        Me.dtpBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.grpNecessaryInfo = New System.Windows.Forms.GroupBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.mskIC = New System.Windows.Forms.MaskedTextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtLeaveReason = New System.Windows.Forms.TextBox()
        Me.lblLR = New System.Windows.Forms.Label()
        Me.lblLeaveDate = New System.Windows.Forms.Label()
        Me.dtpLeaveDate = New System.Windows.Forms.DateTimePicker()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpJoinDate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnResign = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.grpPersonalInfo.SuspendLayout()
        Me.grpNecessaryInfo.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpPersonalInfo
        '
        Me.grpPersonalInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.grpPersonalInfo.Controls.Add(Me.txtAge)
        Me.grpPersonalInfo.Controls.Add(Me.mskContact)
        Me.grpPersonalInfo.Controls.Add(Me.dtpBirthDate)
        Me.grpPersonalInfo.Controls.Add(Me.cboGender)
        Me.grpPersonalInfo.Controls.Add(Me.txtEmail)
        Me.grpPersonalInfo.Controls.Add(Me.Label4)
        Me.grpPersonalInfo.Controls.Add(Me.Label6)
        Me.grpPersonalInfo.Controls.Add(Me.Label7)
        Me.grpPersonalInfo.Controls.Add(Me.Label10)
        Me.grpPersonalInfo.Controls.Add(Me.Label11)
        Me.grpPersonalInfo.Controls.Add(Me.Label12)
        Me.grpPersonalInfo.Controls.Add(Me.txtAddress)
        Me.grpPersonalInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPersonalInfo.Location = New System.Drawing.Point(907, 134)
        Me.grpPersonalInfo.Name = "grpPersonalInfo"
        Me.grpPersonalInfo.Size = New System.Drawing.Size(609, 556)
        Me.grpPersonalInfo.TabIndex = 32
        Me.grpPersonalInfo.TabStop = False
        Me.grpPersonalInfo.Text = "Personal Information  "
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(176, 83)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(124, 30)
        Me.txtAge.TabIndex = 48
        '
        'mskContact
        '
        Me.mskContact.Location = New System.Drawing.Point(176, 177)
        Me.mskContact.Mask = "(000)000-0000"
        Me.mskContact.Name = "mskContact"
        Me.mskContact.Size = New System.Drawing.Size(244, 30)
        Me.mskContact.TabIndex = 45
        '
        'dtpBirthDate
        '
        Me.dtpBirthDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBirthDate.Location = New System.Drawing.Point(176, 129)
        Me.dtpBirthDate.MaxDate = New Date(2100, 1, 1, 0, 0, 0, 0)
        Me.dtpBirthDate.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpBirthDate.Name = "dtpBirthDate"
        Me.dtpBirthDate.Size = New System.Drawing.Size(255, 32)
        Me.dtpBirthDate.TabIndex = 44
        Me.dtpBirthDate.Value = New Date(2020, 12, 4, 0, 0, 0, 0)
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"M", "F"})
        Me.cboGender.Location = New System.Drawing.Point(176, 33)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(124, 33)
        Me.cboGender.TabIndex = 42
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(176, 222)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(352, 32)
        Me.txtEmail.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 23)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Contact : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(60, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 23)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Age : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 23)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Birth Date : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(26, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 23)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Gender : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(40, 223)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 23)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Email : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 266)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 23)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Address : "
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(176, 268)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(352, 250)
        Me.txtAddress.TabIndex = 34
        '
        'grpNecessaryInfo
        '
        Me.grpNecessaryInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.grpNecessaryInfo.Controls.Add(Me.txtSalary)
        Me.grpNecessaryInfo.Controls.Add(Me.cboType)
        Me.grpNecessaryInfo.Controls.Add(Me.cboRole)
        Me.grpNecessaryInfo.Controls.Add(Me.mskIC)
        Me.grpNecessaryInfo.Controls.Add(Me.txtID)
        Me.grpNecessaryInfo.Controls.Add(Me.Label15)
        Me.grpNecessaryInfo.Controls.Add(Me.txtLeaveReason)
        Me.grpNecessaryInfo.Controls.Add(Me.lblLR)
        Me.grpNecessaryInfo.Controls.Add(Me.lblLeaveDate)
        Me.grpNecessaryInfo.Controls.Add(Me.dtpLeaveDate)
        Me.grpNecessaryInfo.Controls.Add(Me.txtStatus)
        Me.grpNecessaryInfo.Controls.Add(Me.Label13)
        Me.grpNecessaryInfo.Controls.Add(Me.dtpJoinDate)
        Me.grpNecessaryInfo.Controls.Add(Me.Label9)
        Me.grpNecessaryInfo.Controls.Add(Me.Label1)
        Me.grpNecessaryInfo.Controls.Add(Me.Label2)
        Me.grpNecessaryInfo.Controls.Add(Me.Label3)
        Me.grpNecessaryInfo.Controls.Add(Me.Label5)
        Me.grpNecessaryInfo.Controls.Add(Me.Label8)
        Me.grpNecessaryInfo.Controls.Add(Me.txtName)
        Me.grpNecessaryInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpNecessaryInfo.Location = New System.Drawing.Point(50, 134)
        Me.grpNecessaryInfo.Name = "grpNecessaryInfo"
        Me.grpNecessaryInfo.Size = New System.Drawing.Size(769, 556)
        Me.grpNecessaryInfo.TabIndex = 31
        Me.grpNecessaryInfo.TabStop = False
        Me.grpNecessaryInfo.Text = "Necessary Information"
        '
        'txtSalary
        '
        Me.txtSalary.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(348, 249)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(255, 32)
        Me.txtSalary.TabIndex = 75
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"FULL-TIME", "PART-TIME"})
        Me.cboType.Location = New System.Drawing.Point(348, 199)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(255, 33)
        Me.cboType.TabIndex = 73
        '
        'cboRole
        '
        Me.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRole.FormattingEnabled = True
        Me.cboRole.Items.AddRange(New Object() {"STAFF", "MANAGER"})
        Me.cboRole.Location = New System.Drawing.Point(348, 153)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(255, 33)
        Me.cboRole.TabIndex = 72
        '
        'mskIC
        '
        Me.mskIC.Location = New System.Drawing.Point(348, 110)
        Me.mskIC.Mask = "000000-00-0000"
        Me.mskIC.Name = "mskIC"
        Me.mskIC.Size = New System.Drawing.Size(255, 30)
        Me.mskIC.TabIndex = 70
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(348, 33)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(229, 30)
        Me.txtID.TabIndex = 69
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(171, 38)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 23)
        Me.Label15.TabIndex = 68
        Me.Label15.Text = "&Staff ID : "
        '
        'txtLeaveReason
        '
        Me.txtLeaveReason.Location = New System.Drawing.Point(348, 441)
        Me.txtLeaveReason.Multiline = True
        Me.txtLeaveReason.Name = "txtLeaveReason"
        Me.txtLeaveReason.Size = New System.Drawing.Size(363, 90)
        Me.txtLeaveReason.TabIndex = 67
        '
        'lblLR
        '
        Me.lblLR.AutoSize = True
        Me.lblLR.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLR.Location = New System.Drawing.Point(97, 445)
        Me.lblLR.Name = "lblLR"
        Me.lblLR.Size = New System.Drawing.Size(165, 23)
        Me.lblLR.TabIndex = 66
        Me.lblLR.Text = "&Leave Reason : "
        '
        'lblLeaveDate
        '
        Me.lblLeaveDate.AutoSize = True
        Me.lblLeaveDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeaveDate.Location = New System.Drawing.Point(125, 392)
        Me.lblLeaveDate.Name = "lblLeaveDate"
        Me.lblLeaveDate.Size = New System.Drawing.Size(139, 23)
        Me.lblLeaveDate.TabIndex = 43
        Me.lblLeaveDate.Text = "Leave Date : "
        '
        'dtpLeaveDate
        '
        Me.dtpLeaveDate.Location = New System.Drawing.Point(348, 386)
        Me.dtpLeaveDate.Name = "dtpLeaveDate"
        Me.dtpLeaveDate.Size = New System.Drawing.Size(255, 30)
        Me.dtpLeaveDate.TabIndex = 42
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(348, 345)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(255, 30)
        Me.txtStatus.TabIndex = 41
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(173, 346)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 23)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Status : "
        '
        'dtpJoinDate
        '
        Me.dtpJoinDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpJoinDate.Location = New System.Drawing.Point(348, 298)
        Me.dtpJoinDate.Name = "dtpJoinDate"
        Me.dtpJoinDate.Size = New System.Drawing.Size(255, 32)
        Me.dtpJoinDate.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(146, 299)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 23)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Join Date : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 23)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "&Name : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(195, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 23)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "&Role : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(192, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 23)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "&Type : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(179, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 23)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Salary : RM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(182, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 23)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "&IC No : "
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(348, 69)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(363, 32)
        Me.txtName.TabIndex = 33
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(700, 720)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(216, 48)
        Me.btnConfirm.TabIndex = 30
        Me.btnConfirm.Text = "Confirm Update"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnResign
        '
        Me.btnResign.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnResign.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResign.ForeColor = System.Drawing.Color.White
        Me.btnResign.Location = New System.Drawing.Point(398, 720)
        Me.btnResign.Name = "btnResign"
        Me.btnResign.Size = New System.Drawing.Size(229, 48)
        Me.btnResign.TabIndex = 35
        Me.btnResign.Text = "Resign"
        Me.btnResign.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(1286, 720)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(125, 48)
        Me.btnExit.TabIndex = 41
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1601, 73)
        Me.pnlHeader.TabIndex = 43
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(695, 22)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(153, 28)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Staff Update"
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'btnChangePassword
        '
        Me.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnChangePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePassword.ForeColor = System.Drawing.Color.White
        Me.btnChangePassword.Location = New System.Drawing.Point(985, 720)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(224, 48)
        Me.btnChangePassword.TabIndex = 44
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(164, 720)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(162, 48)
        Me.btnReset.TabIndex = 45
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'UpdateStaffInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1601, 788)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnResign)
        Me.Controls.Add(Me.grpPersonalInfo)
        Me.Controls.Add(Me.grpNecessaryInfo)
        Me.Controls.Add(Me.btnConfirm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "UpdateStaffInformation"
        Me.Text = "Staff Module - Update Staff Details"
        Me.grpPersonalInfo.ResumeLayout(False)
        Me.grpPersonalInfo.PerformLayout()
        Me.grpNecessaryInfo.ResumeLayout(False)
        Me.grpNecessaryInfo.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpPersonalInfo As GroupBox
    Friend WithEvents grpNecessaryInfo As GroupBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnResign As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents dtpJoinDate As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblLeaveDate As Label
    Friend WithEvents dtpLeaveDate As DateTimePicker
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents err As ErrorProvider
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents txtLeaveReason As TextBox
    Friend WithEvents lblLR As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents mskIC As MaskedTextBox
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents mskContact As MaskedTextBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents btnReset As Button
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtAge As TextBox
End Class
