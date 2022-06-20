<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffViewInformation
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
        Me.grpPersonalInfo = New System.Windows.Forms.GroupBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.dtpBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.mskContact = New System.Windows.Forms.MaskedTextBox()
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
        Me.mskIC = New System.Windows.Forms.MaskedTextBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.grpPersonalInfo.SuspendLayout()
        Me.grpNecessaryInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPersonalInfo
        '
        Me.grpPersonalInfo.BackColor = System.Drawing.Color.Aquamarine
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
        Me.grpPersonalInfo.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPersonalInfo.Location = New System.Drawing.Point(1234, 359)
        Me.grpPersonalInfo.Name = "grpPersonalInfo"
        Me.grpPersonalInfo.Size = New System.Drawing.Size(678, 586)
        Me.grpPersonalInfo.TabIndex = 43
        Me.grpPersonalInfo.TabStop = False
        Me.grpPersonalInfo.Text = "Personal Information  "
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(191, 97)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(124, 36)
        Me.txtAge.TabIndex = 35
        '
        'dtpBirthDate
        '
        Me.dtpBirthDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBirthDate.Location = New System.Drawing.Point(191, 145)
        Me.dtpBirthDate.MaxDate = New Date(2100, 1, 1, 0, 0, 0, 0)
        Me.dtpBirthDate.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpBirthDate.Name = "dtpBirthDate"
        Me.dtpBirthDate.Size = New System.Drawing.Size(255, 32)
        Me.dtpBirthDate.TabIndex = 32
        Me.dtpBirthDate.Value = New Date(2020, 12, 4, 0, 0, 0, 0)
        '
        'mskContact
        '
        Me.mskContact.Location = New System.Drawing.Point(191, 190)
        Me.mskContact.Mask = "(000)000-0000"
        Me.mskContact.Name = "mskContact"
        Me.mskContact.Size = New System.Drawing.Size(244, 36)
        Me.mskContact.TabIndex = 31
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"M", "F"})
        Me.cboGender.Location = New System.Drawing.Point(191, 51)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(124, 35)
        Me.cboGender.TabIndex = 29
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(191, 261)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(448, 32)
        Me.txtEmail.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contact : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(76, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Age : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Birth Date : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(43, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 23)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Gender : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(65, 264)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 23)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Email : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(38, 314)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 23)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Address : "
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(191, 313)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(448, 243)
        Me.txtAddress.TabIndex = 18
        '
        'grpNecessaryInfo
        '
        Me.grpNecessaryInfo.BackColor = System.Drawing.Color.Aquamarine
        Me.grpNecessaryInfo.Controls.Add(Me.txtSalary)
        Me.grpNecessaryInfo.Controls.Add(Me.mskIC)
        Me.grpNecessaryInfo.Controls.Add(Me.cboType)
        Me.grpNecessaryInfo.Controls.Add(Me.cboRole)
        Me.grpNecessaryInfo.Controls.Add(Me.txtID)
        Me.grpNecessaryInfo.Controls.Add(Me.Label15)
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
        Me.grpNecessaryInfo.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpNecessaryInfo.Location = New System.Drawing.Point(461, 359)
        Me.grpNecessaryInfo.Name = "grpNecessaryInfo"
        Me.grpNecessaryInfo.Size = New System.Drawing.Size(728, 586)
        Me.grpNecessaryInfo.TabIndex = 42
        Me.grpNecessaryInfo.TabStop = False
        Me.grpNecessaryInfo.Text = "Necessary Information"
        '
        'txtSalary
        '
        Me.txtSalary.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(313, 376)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(255, 32)
        Me.txtSalary.TabIndex = 66
        '
        'mskIC
        '
        Me.mskIC.Location = New System.Drawing.Point(313, 172)
        Me.mskIC.Mask = "000000-00-0000"
        Me.mskIC.Name = "mskIC"
        Me.mskIC.Size = New System.Drawing.Size(255, 36)
        Me.mskIC.TabIndex = 64
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"FULL-TIME", "PART-TIME"})
        Me.cboType.Location = New System.Drawing.Point(313, 307)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(255, 35)
        Me.cboType.TabIndex = 63
        '
        'cboRole
        '
        Me.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRole.FormattingEnabled = True
        Me.cboRole.Items.AddRange(New Object() {"STAFF", "MANAGER"})
        Me.cboRole.Location = New System.Drawing.Point(313, 239)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(255, 35)
        Me.cboRole.TabIndex = 62
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(313, 48)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(255, 36)
        Me.txtID.TabIndex = 61
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(118, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 23)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "&Staff ID : "
        '
        'txtStatus
        '
        Me.txtStatus.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(313, 500)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(255, 32)
        Me.txtStatus.TabIndex = 57
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(129, 503)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 23)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Status : "
        '
        'dtpJoinDate
        '
        Me.dtpJoinDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpJoinDate.Location = New System.Drawing.Point(313, 447)
        Me.dtpJoinDate.Name = "dtpJoinDate"
        Me.dtpJoinDate.Size = New System.Drawing.Size(296, 32)
        Me.dtpJoinDate.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(93, 447)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 23)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Join Date : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(125, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 23)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "&Name : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(142, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 23)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "&Role : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(139, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 23)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "&Type : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(126, 379)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 23)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Salary : RM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(129, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 23)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "&IC No : "
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(313, 110)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(400, 32)
        Me.txtName.TabIndex = 49
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(1234, 988)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(210, 57)
        Me.btnUpdate.TabIndex = 41
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnChangePassword
        '
        Me.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnChangePassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePassword.ForeColor = System.Drawing.Color.White
        Me.btnChangePassword.Location = New System.Drawing.Point(922, 988)
        Me.btnChangePassword.Margin = New System.Windows.Forms.Padding(5)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(267, 61)
        Me.btnChangePassword.TabIndex = 45
        Me.btnChangePassword.Text = "&Change Password"
        Me.btnChangePassword.UseVisualStyleBackColor = False
        '
        'StaffViewInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1920, 1051)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.grpPersonalInfo)
        Me.Controls.Add(Me.grpNecessaryInfo)
        Me.Controls.Add(Me.btnUpdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "StaffViewInformation"
        Me.Text = "Staff Module - Staff Detail"
        Me.grpPersonalInfo.ResumeLayout(False)
        Me.grpPersonalInfo.PerformLayout()
        Me.grpNecessaryInfo.ResumeLayout(False)
        Me.grpNecessaryInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpPersonalInfo As GroupBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents grpNecessaryInfo As GroupBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpJoinDate As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents mskIC As MaskedTextBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents mskContact As MaskedTextBox
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtAge As TextBox
End Class
