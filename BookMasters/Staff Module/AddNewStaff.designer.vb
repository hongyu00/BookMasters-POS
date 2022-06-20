<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewStaff
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.grpNecessaryInfo = New System.Windows.Forms.GroupBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.chkDefaultPassword = New System.Windows.Forms.CheckBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.mskIC = New System.Windows.Forms.MaskedTextBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.dtpJoinDate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grpPersonalInfo = New System.Windows.Forms.GroupBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.dtpBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.mskContact = New System.Windows.Forms.MaskedTextBox()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpNecessaryInfo.SuspendLayout()
        Me.grpPersonalInfo.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(218, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Name : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(235, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Role : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(232, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Type : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contact : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(211, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "&Salary : RM"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(89, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Age : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Birth Date : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(222, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "&IC No : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(55, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 23)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Gender : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(69, 245)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 23)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Email : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(47, 288)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 23)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Address : "
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(369, 93)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(417, 32)
        Me.txtName.TabIndex = 12
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(205, 292)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(464, 250)
        Me.txtAddress.TabIndex = 18
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(205, 246)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(464, 32)
        Me.txtEmail.TabIndex = 19
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnConfirm.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfirm.Location = New System.Drawing.Point(732, 687)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(214, 53)
        Me.btnConfirm.TabIndex = 23
        Me.btnConfirm.Text = "Confirm Add"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'grpNecessaryInfo
        '
        Me.grpNecessaryInfo.AccessibleDescription = ""
        Me.grpNecessaryInfo.BackColor = System.Drawing.Color.Azure
        Me.grpNecessaryInfo.Controls.Add(Me.txtSalary)
        Me.grpNecessaryInfo.Controls.Add(Me.chkDefaultPassword)
        Me.grpNecessaryInfo.Controls.Add(Me.txtID)
        Me.grpNecessaryInfo.Controls.Add(Me.Label16)
        Me.grpNecessaryInfo.Controls.Add(Me.Label15)
        Me.grpNecessaryInfo.Controls.Add(Me.Label14)
        Me.grpNecessaryInfo.Controls.Add(Me.txtConfirmPassword)
        Me.grpNecessaryInfo.Controls.Add(Me.txtPassword)
        Me.grpNecessaryInfo.Controls.Add(Me.Label13)
        Me.grpNecessaryInfo.Controls.Add(Me.mskIC)
        Me.grpNecessaryInfo.Controls.Add(Me.cboType)
        Me.grpNecessaryInfo.Controls.Add(Me.cboRole)
        Me.grpNecessaryInfo.Controls.Add(Me.dtpJoinDate)
        Me.grpNecessaryInfo.Controls.Add(Me.Label9)
        Me.grpNecessaryInfo.Controls.Add(Me.Label1)
        Me.grpNecessaryInfo.Controls.Add(Me.Label2)
        Me.grpNecessaryInfo.Controls.Add(Me.Label3)
        Me.grpNecessaryInfo.Controls.Add(Me.Label5)
        Me.grpNecessaryInfo.Controls.Add(Me.Label8)
        Me.grpNecessaryInfo.Controls.Add(Me.txtName)
        Me.grpNecessaryInfo.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpNecessaryInfo.Location = New System.Drawing.Point(12, 103)
        Me.grpNecessaryInfo.Name = "grpNecessaryInfo"
        Me.grpNecessaryInfo.Size = New System.Drawing.Size(942, 561)
        Me.grpNecessaryInfo.TabIndex = 26
        Me.grpNecessaryInfo.TabStop = False
        Me.grpNecessaryInfo.Text = "Necessary Information"
        '
        'txtSalary
        '
        Me.txtSalary.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(369, 275)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(255, 32)
        Me.txtSalary.TabIndex = 78
        '
        'chkDefaultPassword
        '
        Me.chkDefaultPassword.AutoSize = True
        Me.chkDefaultPassword.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDefaultPassword.Location = New System.Drawing.Point(651, 373)
        Me.chkDefaultPassword.Name = "chkDefaultPassword"
        Me.chkDefaultPassword.Size = New System.Drawing.Size(205, 23)
        Me.chkDefaultPassword.TabIndex = 36
        Me.chkDefaultPassword.Text = "Use Default Password"
        Me.chkDefaultPassword.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(369, 54)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(255, 36)
        Me.txtID.TabIndex = 34
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(211, 54)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 23)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "&Staff ID : "
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(30, 482)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(887, 60)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Password must between 8 - 16 characters and include at least 2 upppercase, 2 lowe" &
    "rcase character, 2 digit and 2 special character."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(62, 425)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(201, 23)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "&Confirm Password : "
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(369, 419)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(255, 36)
        Me.txtConfirmPassword.TabIndex = 30
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(369, 367)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(255, 36)
        Me.txtPassword.TabIndex = 29
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(175, 373)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 23)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "&Password : "
        '
        'mskIC
        '
        Me.mskIC.Location = New System.Drawing.Point(369, 131)
        Me.mskIC.Mask = "000000-00-0000"
        Me.mskIC.Name = "mskIC"
        Me.mskIC.Size = New System.Drawing.Size(255, 36)
        Me.mskIC.TabIndex = 27
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"FULL-TIME", "PART_TIME"})
        Me.cboType.Location = New System.Drawing.Point(369, 223)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(255, 35)
        Me.cboType.TabIndex = 26
        '
        'cboRole
        '
        Me.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRole.FormattingEnabled = True
        Me.cboRole.Items.AddRange(New Object() {"STAFF", "MANAGER"})
        Me.cboRole.Location = New System.Drawing.Point(369, 177)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(255, 35)
        Me.cboRole.TabIndex = 25
        '
        'dtpJoinDate
        '
        Me.dtpJoinDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpJoinDate.Location = New System.Drawing.Point(369, 322)
        Me.dtpJoinDate.MaxDate = New Date(2100, 1, 1, 0, 0, 0, 0)
        Me.dtpJoinDate.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.dtpJoinDate.Name = "dtpJoinDate"
        Me.dtpJoinDate.Size = New System.Drawing.Size(255, 32)
        Me.dtpJoinDate.TabIndex = 24
        Me.dtpJoinDate.Value = New Date(2020, 12, 4, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(175, 329)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 23)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "&Join Date : "
        '
        'grpPersonalInfo
        '
        Me.grpPersonalInfo.BackColor = System.Drawing.Color.Azure
        Me.grpPersonalInfo.Controls.Add(Me.txtAge)
        Me.grpPersonalInfo.Controls.Add(Me.dtpBirthDate)
        Me.grpPersonalInfo.Controls.Add(Me.mskContact)
        Me.grpPersonalInfo.Controls.Add(Me.cboGender)
        Me.grpPersonalInfo.Controls.Add(Me.txtEmail)
        Me.grpPersonalInfo.Controls.Add(Me.Label4)
        Me.grpPersonalInfo.Controls.Add(Me.Label6)
        Me.grpPersonalInfo.Controls.Add(Me.Label7)
        Me.grpPersonalInfo.Controls.Add(Me.Label10)
        Me.grpPersonalInfo.Controls.Add(Me.Label11)
        Me.grpPersonalInfo.Controls.Add(Me.Label12)
        Me.grpPersonalInfo.Controls.Add(Me.txtAddress)
        Me.grpPersonalInfo.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPersonalInfo.Location = New System.Drawing.Point(1007, 103)
        Me.grpPersonalInfo.Name = "grpPersonalInfo"
        Me.grpPersonalInfo.Size = New System.Drawing.Size(732, 561)
        Me.grpPersonalInfo.TabIndex = 27
        Me.grpPersonalInfo.TabStop = False
        Me.grpPersonalInfo.Text = "Personal Information  "
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(205, 105)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(124, 36)
        Me.txtAge.TabIndex = 31
        '
        'dtpBirthDate
        '
        Me.dtpBirthDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBirthDate.Location = New System.Drawing.Point(205, 151)
        Me.dtpBirthDate.MaxDate = New Date(2100, 1, 1, 0, 0, 0, 0)
        Me.dtpBirthDate.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpBirthDate.Name = "dtpBirthDate"
        Me.dtpBirthDate.Size = New System.Drawing.Size(255, 32)
        Me.dtpBirthDate.TabIndex = 28
        Me.dtpBirthDate.Value = New Date(2020, 12, 4, 0, 0, 0, 0)
        '
        'mskContact
        '
        Me.mskContact.Location = New System.Drawing.Point(205, 196)
        Me.mskContact.Mask = "(000)000-0000"
        Me.mskContact.Name = "mskContact"
        Me.mskContact.Size = New System.Drawing.Size(244, 36)
        Me.mskContact.TabIndex = 27
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"M", "F"})
        Me.cboGender.Location = New System.Drawing.Point(205, 57)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(124, 35)
        Me.cboGender.TabIndex = 25
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(1365, 687)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(153, 53)
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
        Me.pnlHeader.Size = New System.Drawing.Size(1768, 73)
        Me.pnlHeader.TabIndex = 42
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(774, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(262, 28)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "New Staff Registration"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClear.Location = New System.Drawing.Point(1072, 687)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(151, 53)
        Me.btnClear.TabIndex = 43
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'AddNewStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1768, 765)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpPersonalInfo)
        Me.Controls.Add(Me.grpNecessaryInfo)
        Me.Controls.Add(Me.btnConfirm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "AddNewStaff"
        Me.Text = "Staff Module - Add New Staff"
        Me.grpNecessaryInfo.ResumeLayout(False)
        Me.grpNecessaryInfo.PerformLayout()
        Me.grpPersonalInfo.ResumeLayout(False)
        Me.grpPersonalInfo.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents grpNecessaryInfo As GroupBox
    Friend WithEvents grpPersonalInfo As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents dtpJoinDate As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents mskIC As MaskedTextBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents mskContact As MaskedTextBox
    Friend WithEvents err As ErrorProvider
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents chkDefaultPassword As CheckBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtAge As TextBox
End Class
