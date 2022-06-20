

Public Class AddNewStaff

    Private strNewStafFID As String

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        btnClear_Click(Nothing, Nothing)

        Me.Close()
    End Sub

    Private Sub AddNewStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()

        btnClear_Click(Nothing, Nothing)

        txtID.Enabled = False
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Dim strName As String = txtName.Text.Trim()
        Dim strIC As String = If(mskIC.MaskCompleted, mskIC.Text, "")
        Dim strRole As String
        Dim intRoleIndex As Integer = cboRole.SelectedIndex
        Dim strType As String
        Dim intTypeIndex As Integer = cboType.SelectedIndex
        Dim strSalary As String = txtSalary.Text
        Dim strJoinDate As String = dtpJoinDate.Value.ToString("dd/MM/yyyy")

        Dim strPassword As String
        Dim strConfirmPassword As String

        If chkDefaultPassword.Checked Then
            strPassword = "ABcd12++"
            strConfirmPassword = "ABcd12++"
        Else
            strPassword = txtPassword.Text
            strConfirmPassword = txtPassword.Text
        End If

        Dim strGender As String
        Dim intGenderIndex As Integer = cboGender.SelectedIndex
        Dim strAge As String = txtAge.Text
        Dim strBirthDate As String = dtpBirthDate.Value.ToString("dd/MM/yyyy")
        Dim strContact As String = If(mskContact.MaskCompleted, mskContact.Text, "")
        Dim strEmail As String = txtEmail.Text
        Dim strAddress As String = txtAddress.Text

        Dim rEMail As New System.Text.RegularExpressions.Regex("^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")

        'Validation ------------------------------------------------
        err.Tag = Nothing

        If strName = "" Then
            err.SetError(txtName, "Please enter [Name]")
            err.Tag = If(err.Tag, txtName)
        ElseIf IsDuplicatedName(strName) Then
            err.SetError(txtName, "[Name] duplicated")
            err.Tag = If(err.Tag, txtName)
        ElseIf strName.Length > 50 Then
            err.SetError(txtName, "[Name] cannot more than 50 character")
            err.Tag = If(err.Tag, txtName)
        Else
            err.SetError(txtName, Nothing)
        End If

        If strIC = "" Then
            err.SetError(mskIC, "Please enter [Staff IC]")
            err.Tag = If(err.Tag, mskIC)
        ElseIf IsDuplicatedIC(strIC) Then
            err.SetError(mskIC, "[Staff IC] duplicated")
            err.Tag = If(err.Tag, mskIC)
        Else
            err.SetError(mskIC, Nothing)
        End If

        If intRoleIndex < 0 Then
            err.SetError(cboRole, "Please select [Role]")
            err.Tag = If(err.Tag, cboRole)
        Else
            strRole = cboRole.SelectedItem.ToString()
            err.SetError(cboRole, Nothing)
        End If

        If intTypeIndex < 0 Then
            err.SetError(cboType, "Please select [Type]")
            err.Tag = If(err.Tag, cboType)
        Else
            strType = cboType.SelectedItem.ToString
            err.SetError(cboType, Nothing)
        End If

        If strSalary = "" Then
            err.SetError(txtSalary, "Please enter [Salary]")
            err.Tag = If(err.Tag, txtSalary)
        ElseIf IsNumeric(strSalary) = False Then
            err.SetError(txtSalary, "Salary must be digit.")
            err.Tag = If(err.Tag, txtSalary)
        ElseIf strSalary.Length > 5 Then
            err.SetError(txtSalary, "Salary canont more than 5 digit.")
            err.Tag = If(err.Tag, txtSalary)
        Else
            err.SetError(txtSalary, Nothing)
        End If

        If strJoinDate = "" Then
            err.SetError(dtpJoinDate, "Please select [Join Date]")
            err.Tag = If(err.Tag, dtpJoinDate)
        Else
            err.SetError(dtpJoinDate, Nothing)
        End If

        If strPassword = "" Then
            err.SetError(txtPassword, "Please enter [Password]")
            err.Tag = If(err.Tag, txtPassword)
        ElseIf ChangePassword.ValidatePassword(strPassword) = False Then
            err.SetError(txtPassword, "Please enter [Password] follow the password guidedance.")
            err.Tag = If(err.Tag, txtPassword)
        Else
            err.SetError(txtPassword, Nothing)
        End If

        If strConfirmPassword = "" Then
            err.SetError(txtConfirmPassword, "Please enter [Confirm Password]")
            err.Tag = If(err.Tag, txtConfirmPassword)
        ElseIf strPassword <> strConfirmPassword Then
            err.SetError(txtConfirmPassword, "Please enter same password.")
            err.Tag = If(err.Tag, txtConfirmPassword)
        Else
            err.SetError(txtConfirmPassword, Nothing)
        End If

        If intGenderIndex < 0 Then
            err.SetError(cboGender, "Please select [Gender]")
            err.Tag = If(err.Tag, cboGender)
        Else
            strGender = cboGender.SelectedItem.ToString
            err.SetError(cboGender, Nothing)
        End If

        If strAge = "" Then
            err.SetError(txtAge, "Please enter [Age]")
            err.Tag = If(err.Tag, txtAge)
        ElseIf IsNumeric(strAge) = False Then
            err.SetError(txtAge, "Age must be digit")
            err.Tag = If(err.Tag, txtAge)
        ElseIf Integer.Parse(strAge) <= 15 Then
            err.SetError(txtAge, "Age must more than 15")
            err.Tag = If(err.Tag, txtAge)
        Else
            err.SetError(txtAge, Nothing)
        End If

        If strBirthDate = "" Then
            err.SetError(dtpBirthDate, "Please select [Birth Date]")
            err.Tag = If(err.Tag, dtpBirthDate)
        Else
            err.SetError(dtpBirthDate, Nothing)
        End If

        If strContact = "" Then
            err.SetError(mskContact, "Please enter [Contact]")
            err.Tag = If(err.Tag, mskContact)
        ElseIf IsDuplicatedContact(strContact) Then
            err.SetError(mskContact, "Duplicated [Contact]")
            err.Tag = If(err.Tag, mskContact)
        Else
            err.SetError(mskContact, Nothing)
        End If


        If strEmail = "" Then
            err.SetError(txtEmail, "Please enter [Email]")
            err.Tag = If(err.Tag, txtEmail)
        ElseIf Not rEMail.IsMatch(strEmail) Then
            err.SetError(txtEmail, "Please enter [Email] follow regex eg: XXXX@gmail.com")
            err.Tag = If(err.Tag, txtEmail)
        ElseIf IsDuplicatedEmail(strEmail) Then
            err.SetError(txtEmail, "Duplicated [Email]")
            err.Tag = If(err.Tag, txtEmail)
        Else
            err.SetError(txtEmail, Nothing)
        End If

        If strAddress = "" Then
            err.SetError(txtAddress, "Please enter [Address]")
            err.Tag = If(err.Tag, txtAddress)
        ElseIf strAddress.Length <= 20 Then
            err.SetError(txtAddress, "Please enter more than 20 character.")
            err.Tag = If(err.Tag, txtAddress)
        Else
            err.SetError(txtAddress, Nothing)
        End If

        ' Check status ----------------------------------------------
        If err.Tag IsNot Nothing Then
            CType(err.Tag, Control).Focus() ' Focus on the first error control
            Return
        End If


        Dim s As New Staff()
        s.staffID = generateStaffID(strRole)
        s.staffName = strName
        s.staffRole = strRole
        s.staffType = strType
        s.staffPassword = strConfirmPassword
        s.staffIC = strIC
        s.staffStatus = "Active"
        s.joinedDate = strJoinDate
        s.staffSalary = strSalary
        s.staffGender = strGender
        s.staffContact = strContact
        s.staffAge = strAge
        s.staffBirthDate = strBirthDate
        s.staffAddress = strAddress
        s.staffEmail = strEmail

        Dim result As DialogResult = MessageBox.Show("Confirm to add this staff?", "Add Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim db As New StaffDataContext()
            db.Staffs.InsertOnSubmit(s)
            db.SubmitChanges()

            MessageBox.Show("New staff added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnClear_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtName.Text = ""
        mskIC.Text = ""
        cboRole.SelectedIndex = 0
        generateStaffID(cboRole.Text)
        cboType.SelectedIndex = 0
        txtSalary.Text = ""
        '
        dtpJoinDate.Value = DateTime.Now.Date
        dtpJoinDate.Format = DateTimePickerFormat.Custom
        dtpJoinDate.CustomFormat = "dd/MM/yyyy"
        dtpJoinDate.MinDate = DateTime.Now.Date

        txtPassword.Text = ""
        txtConfirmPassword.Text = ""
        chkDefaultPassword.Checked = False

        cboGender.SelectedIndex = 0
        txtAge.Text = 16
        dtpBirthDate.Value = DateTime.Now.Date.AddYears(-16)
        dtpBirthDate.CustomFormat = DateTimePickerFormat.Custom
        dtpBirthDate.CustomFormat = "dd/MM/yyyy"
        dtpBirthDate.MaxDate = DateTime.Now.Date.AddYears(-16)
        mskContact.Text = ""
        txtEmail.Text = ""
        txtAddress.Text = ""

        err.Clear()

        strNewStafFID = Nothing

    End Sub


    Private Function generateStaffID(staffRole As String) As String

        Dim intDefaultCount As Integer = 1
        Dim intDefaultCount2 As Integer = 0
        Dim intDefaultCount3 As Integer = 0
        Dim intDefaultCount4 As Integer = 0

        Dim strStaffIDPrefix As String

        If staffRole = "STAFF" Then
            strStaffIDPrefix = "SF"
        ElseIf staffRole = "MANAGER" Then
            strStaffIDPrefix = "MN"
        End If

        Dim db As New StaffDataContext()
        Dim strStaffID = strStaffIDPrefix & intDefaultCount4 & intDefaultCount3 & intDefaultCount2 & intDefaultCount
        Dim isDuplicated = db.Staffs.Any(Function(o) o.staffID = strStaffID)

        If isDuplicated = False Then
            Return strStaffID
        Else
            Do While isDuplicated = True
                intDefaultCount += 1

                If intDefaultCount > 9 Then
                    intDefaultCount = 1
                    intDefaultCount2 += 1
                End If
                If intDefaultCount2 > 9 Then
                    intDefaultCount2 = 1
                    intDefaultCount3 += 1
                End If
                If intDefaultCount3 > 9 Then
                    intDefaultCount3 = 1
                    intDefaultCount4 += 1
                End If

                strStaffID = strStaffIDPrefix & intDefaultCount4 & intDefaultCount3 & intDefaultCount2 & intDefaultCount
                isDuplicated = db.Staffs.Any(Function(o) o.staffID = strStaffID)
            Loop
            Return strStaffID
        End If
    End Function
    Private Function IsDuplicatedID(strID As String) As Boolean
        Dim db As New StaffDataContext()
        Return db.Staffs.Any(Function(o) o.staffID = strID)
    End Function

    Private Function IsDuplicatedName(strName As String) As Boolean
        Dim db As New StaffDataContext()
        Return db.Staffs.Any(Function(o) o.staffName = strName)
    End Function

    Private Function IsDuplicatedIC(strIC As String) As Boolean
        Dim db As New StaffDataContext()
        Return db.Staffs.Any(Function(o) o.staffIC = strIC)
    End Function

    Private Sub cboRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRole.SelectedIndexChanged
        If cboRole.SelectedIndex >= 0 Then
            strNewStafFID = generateStaffID(cboRole.Text)
            txtID.Text = strNewStafFID
        Else
            txtID.Text = ""
        End If
    End Sub

    Private Sub chkDefaultPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkDefaultPassword.CheckedChanged
        If chkDefaultPassword.Checked Then
            txtConfirmPassword.Text = ""
            txtPassword.Text = ""
            txtPassword.Enabled = False
            txtConfirmPassword.Enabled = False
        Else
            txtPassword.Enabled = True
            txtConfirmPassword.Enabled = True
        End If
    End Sub

    Private Function IsDuplicatedContact(strContact As String) As Boolean
        Dim db As New StaffDataContext()
        Return db.Staffs.Any(Function(o) o.staffContact = strContact)
    End Function

    Private Function IsDuplicatedEmail(strEmail As String) As Boolean
        Dim db As New StaffDataContext()
        Return db.Staffs.Any(Function(o) o.staffEmail = strEmail)
    End Function

    Private Sub dtpBirthDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthDate.ValueChanged
        Dim intAge As Integer = DateTime.Today.Year - dtpBirthDate.Value.Year
        txtAge.Text = intAge.ToString()
    End Sub

End Class