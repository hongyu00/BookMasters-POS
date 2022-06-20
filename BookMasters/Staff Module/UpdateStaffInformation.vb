
Public Class UpdateStaffInformation
    Public Sub UpdateStaffInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Shown, MyBase.Load
        CenterToScreen()

        Dim db As New StaffDataContext()

        If UserLogin.strCurrentLoginStaffRole = "STAFF" Then

            Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = UserLogin.strCurrentLoginStaffID)

            If s Is Nothing Then
                MessageBox.Show("User ID not found. Cannot update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                txtID.Text = s.staffID
                txtName.Text = s.staffName
                mskIC.Text = s.staffIC
                cboRole.Text = s.staffRole
                cboType.Text = s.staffType

                'Dim decSalary As Decimal = s.staffSalary
                txtSalary.Text = s.staffSalary
                dtpJoinDate.Value = s.joinedDate.ToString("dd/MM/yyyy")

                txtStatus.Text = s.staffStatus
                lblLeaveDate.Visible = False
                dtpLeaveDate.Visible = False
                lblLR.Visible = False
                txtLeaveReason.Visible = False

                cboGender.Text = s.staffGender
                txtAge.Text = s.staffAge
                dtpBirthDate.Value = s.staffBirthDate
                mskContact.Text = s.staffContact
                txtEmail.Text = s.staffEmail
                txtAddress.Text = s.staffAddress

                txtID.Enabled = False
                cboRole.Enabled = False
                cboType.Enabled = False
                txtSalary.Enabled = False
                dtpJoinDate.Enabled = False
                txtStatus.Enabled = False
                dtpLeaveDate.Enabled = False

                btnResign.Visible = False
                btnChangePassword.Visible = False

            End If

        ElseIf UserLogin.strCurrentLoginStaffRole = "MANAGER" Then

            Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = ManagerMain.selectedStaff)

            If s Is Nothing Then
                MessageBox.Show("Staff ID not found. Cannot update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                txtID.Text = s.staffID
                txtName.Text = s.staffName
                mskIC.Text = s.staffIC
                cboRole.Text = s.staffRole
                cboType.Text = s.staffType
                'Dim decSalary As Decimal = s.staffSalary
                txtSalary.Text = s.staffSalary
                dtpJoinDate.Value = s.joinedDate.ToString("dd/MM/yyyy")
                txtStatus.Text = s.staffStatus

                If s.staffStatus = "Resigned" Then
                    dtpLeaveDate.Value = s.leaveDate.Value.ToString("dd/MM/yyyy")
                    txtLeaveReason.Text = s.staffLeaveReason
                    btnResign.Enabled = False
                ElseIf s.staffStatus = "Active" Then

                    btnResign.Enabled = True

                    dtpLeaveDate.CustomFormat = " "
                    dtpLeaveDate.Format = DateTimePickerFormat.Custom
                    txtLeaveReason.Text = ""
                End If

                cboGender.Text = s.staffGender
                txtAge.Text = s.staffAge
                dtpBirthDate.Value = s.staffBirthDate.Value.ToString("dd/MM/yyyy")
                mskContact.Text = s.staffContact
                txtEmail.Text = s.staffEmail
                txtAddress.Text = s.staffAddress

                txtID.Enabled = False
                txtName.Enabled = True
                mskIC.Enabled = True
                cboRole.Enabled = True
                cboType.Enabled = True
                txtSalary.Enabled = True

                dtpJoinDate.Enabled = False
                txtStatus.Enabled = False
                dtpLeaveDate.Enabled = False
                txtLeaveReason.Enabled = False

                cboGender.Enabled = True
                txtAge.Enabled = True
                dtpBirthDate.Enabled = True
                mskContact.Enabled = True
                txtEmail.Enabled = True
                txtAddress.Enabled = True

                btnResign.Text = "Resign"
                btnResign.BackColor = Color.FromArgb(22, 99, 255)

                btnChangePassword.Visible = True
                btnResign.Visible = True

            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        If UserLogin.strCurrentLoginStaffRole = "STAFF" Then
            UpdateStaffInformation_Load(Nothing, Nothing)
            StaffViewInformation.Show()
        ElseIf UserLogin.strCurrentLoginStaffRole = "MANAGER" Then
            ManagerMain.Show()
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Dim db As New StaffDataContext()
        Dim s As Staff

        If UserLogin.strCurrentLoginStaffRole = "STAFF" Then
            s = db.Staffs.FirstOrDefault(Function(o) o.staffID = UserLogin.strCurrentLoginStaffID)

            If s Is Nothing Then
                MessageBox.Show("Staff ID not found. Cannot update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                Dim tempEmail As String = s.staffEmail
                Dim tempName As String = s.staffName
                Dim tempIC As String = s.staffIC
                Dim tempContact As String = s.staffContact

                Dim strName As String = txtName.Text.Trim()
                Dim strIC As String = If(mskIC.MaskCompleted, mskIC.Text, "")

                Dim strGender As String
                Dim intGenderIndex As Integer = cboGender.SelectedIndex
                Dim strAge As String = txtAge.Text
                Dim strBirthDate As String = dtpBirthDate.Value.ToString("dd/MM/yyyy")
                Dim strContact As String = If(mskContact.MaskCompleted, mskContact.Text, "")
                Dim strEmail As String = txtEmail.Text
                Dim strAddress As String = txtAddress.Text

                Dim rEMail As New System.Text.RegularExpressions.Regex("^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")

                err.Tag = Nothing

                If strName = "" Then
                    err.SetError(txtName, "Please enter [Name]")
                    err.Tag = If(err.Tag, txtName)
                ElseIf strName <> tempName Then
                    If IsDuplicatedName(strName) = True Then
                        err.SetError(txtName, "[Name] duplicated")
                        err.Tag = If(err.Tag, txtName)
                    Else
                        err.SetError(txtName, Nothing)
                    End If
                ElseIf strName.Length > 50 Then
                    err.SetError(txtName, "[Name] cannot more than 50 character")
                    err.Tag = If(err.Tag, txtName)
                Else
                    err.SetError(txtName, Nothing)
                End If

                If strIC = "" Then
                    err.SetError(mskIC, "Please enter [IC]")
                    err.Tag = If(err.Tag, mskIC)
                ElseIf strIC <> tempIC Then
                    If IsDuplicatedIC(strIC) = True Then
                        err.SetError(mskIC, "[IC] duplicated")
                        err.Tag = If(err.Tag, mskIC)
                    Else
                        err.SetError(mskIC, Nothing)
                    End If

                Else
                    err.SetError(mskIC, Nothing)
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
                ElseIf strContact <> tempContact Then
                    If IsDuplicatedContact(strContact) = True Then
                        err.SetError(mskContact, "Duplicated [Contact]")
                        err.Tag = If(err.Tag, mskContact)
                    Else
                        err.SetError(mskContact, Nothing)
                    End If

                Else
                    err.SetError(mskContact, Nothing)
                End If

                If strEmail = "" Then
                    err.SetError(txtEmail, "Please enter [Email]")
                    err.Tag = If(err.Tag, txtEmail)
                ElseIf Not rEMail.IsMatch(strEmail) Then
                    err.SetError(txtEmail, "Please enter [Email] follow regex eg: XXXX@gmail.com")
                    err.Tag = If(err.Tag, txtEmail)
                ElseIf strEmail <> tempEmail Then
                    If IsDuplicatedEmail(strEmail) = True Then
                        err.SetError(txtEmail, "Duplicated [Email]")
                        err.Tag = If(err.Tag, txtEmail)
                    Else
                        err.SetError(txtEmail, Nothing)
                    End If
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

                If err.Tag IsNot Nothing Then
                    CType(err.Tag, Control).Focus() ' Focus on the first error control
                    Return
                Else

                    s.staffName = strName
                    s.staffIC = strIC
                    s.staffContact = strContact
                    s.staffAge = strAge
                    s.staffBirthDate = strBirthDate
                    s.staffGender = strGender
                    s.staffAddress = strAddress
                    s.staffEmail = strEmail

                    Dim result As DialogResult = MessageBox.Show("Confirm to update this staff?", "Update Confirmation", MessageBoxButtons.YesNoCancel)

                    If result = DialogResult.Yes Then

                        db.SubmitChanges()
                        UpdateStaffInformation_Load(Nothing, Nothing)
                        StaffViewInformation.StaffViewInformation_Load(Nothing, Nothing)
                        MessageBox.Show("Staff details updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                End If
            End If

        ElseIf UserLogin.strCurrentLoginStaffRole = "MANAGER" Then

            s = db.Staffs.FirstOrDefault(Function(o) o.staffID = ManagerMain.selectedStaff)

            If s Is Nothing Then
                MessageBox.Show("Staff ID not found. Cannot update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim tempEmail As String = s.staffEmail
                Dim tempName As String = s.staffName
                Dim tempIC As String = s.staffIC
                Dim tempContact As String = s.staffContact

                Dim strName As String = txtName.Text.Trim()
                Dim strIC As String = If(mskIC.MaskCompleted, mskIC.Text, "")
                Dim strRole As String
                Dim intRoleIndex As Integer = cboRole.SelectedIndex
                Dim strType As String
                Dim intTypeIndex As Integer = cboType.SelectedIndex
                Dim strSalary As String = txtSalary.Text

                Dim strGender As String
                Dim intGenderIndex As Integer = cboGender.SelectedIndex
                Dim strAge As String = txtAge.Text
                Dim strBirthDate As String = dtpBirthDate.Value.ToString("dd/MM/yyyy")
                Dim strContact As String = If(mskContact.MaskCompleted, mskContact.Text, "")
                Dim strEmail As String = txtEmail.Text
                Dim strAddress As String = txtAddress.Text

                Dim rEMail As New System.Text.RegularExpressions.Regex("^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")


                err.Tag = Nothing

                If strName = "" Then
                    err.SetError(txtName, "Please enter [Name]")
                    err.Tag = If(err.Tag, txtName)
                ElseIf strName <> tempName Then
                    If IsDuplicatedName(strName) = True Then
                        err.SetError(txtName, "[Name] duplicated")
                        err.Tag = If(err.Tag, txtName)
                    Else
                        err.SetError(txtName, Nothing)
                    End If

                ElseIf strName.Length > 50 Then
                    err.SetError(txtName, "[Name] cannot more than 50 character")
                    err.Tag = If(err.Tag, txtName)
                Else
                    err.SetError(txtName, Nothing)
                End If

                If strIC = "" Then
                    err.SetError(mskIC, "Please enter [IC]")
                    err.Tag = If(err.Tag, mskIC)
                ElseIf strIC <> tempIC Then
                    If IsDuplicatedIC(strIC) = True Then
                        err.SetError(mskIC, "[IC] duplicated")
                        err.Tag = If(err.Tag, mskIC)
                    Else
                        err.SetError(mskIC, Nothing)
                    End If

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
                ElseIf strContact <> tempContact Then

                    If IsDuplicatedContact(strContact) = True Then
                        err.SetError(mskContact, "Duplicated [Contact]")
                        err.Tag = If(err.Tag, mskContact)
                    Else
                        err.SetError(mskContact, Nothing)
                    End If

                Else
                    err.SetError(mskContact, Nothing)
                End If


                If strEmail = "" Then
                    err.SetError(txtEmail, "Please enter [Email]")
                    err.Tag = If(err.Tag, txtEmail)
                ElseIf Not rEMail.IsMatch(strEmail) Then
                    err.SetError(txtEmail, "Please enter [Email] follow regex eg: XXXX@gmail.com")
                    err.Tag = If(err.Tag, txtEmail)
                ElseIf strEmail <> tempEmail Then
                    If IsDuplicatedEmail(strEmail) = True Then
                        err.SetError(txtEmail, "Duplicated [Email]")
                        err.Tag = If(err.Tag, txtEmail)
                    Else
                        err.SetError(txtEmail, Nothing)
                    End If
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

                If err.Tag IsNot Nothing Then
                    CType(err.Tag, Control).Focus() ' Focus on the first error control
                    Return

                Else
                    s.staffName = strName
                    s.staffIC = strIC
                    s.staffRole = strRole
                    s.staffType = strType
                    s.staffContact = strContact
                    s.staffSalary = strSalary
                    s.staffAge = strAge
                    s.staffBirthDate = strBirthDate
                    s.staffGender = strGender
                    s.staffAddress = strAddress
                    s.staffEmail = strEmail

                    Dim result As DialogResult = MessageBox.Show("Confirm to update this staff?", "Update Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

                    If result = DialogResult.Yes Then

                        db.SubmitChanges()
                        UpdateStaffInformation_Load(Nothing, Nothing)
                        MessageBox.Show("Staff details updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Reset()
        err.Clear()
    End Sub

    Private Sub btnResign_Click(sender As Object, e As EventArgs) Handles btnResign.Click

        If txtStatus.Text = "Active" Then

            txtID.Enabled = False
            txtName.Enabled = False
            mskIC.Enabled = False
            cboRole.Enabled = False
            cboType.Enabled = False
            txtSalary.Enabled = False
            dtpJoinDate.Enabled = False

            txtStatus.Enabled = False

            cboGender.Enabled = False
            txtAge.Enabled = False
            dtpBirthDate.Enabled = False
            mskContact.Enabled = False
            txtEmail.Enabled = False
            txtAddress.Enabled = False

            txtLeaveReason.Enabled = True
            dtpLeaveDate.Enabled = True
            dtpLeaveDate.MinDate = DateTime.Now.Date
            dtpLeaveDate.Value = DateTime.Now.Date
            dtpLeaveDate.Format = DateTimePickerFormat.Custom
            dtpLeaveDate.CustomFormat = "dd/MM/yyyy"

            btnResign.Text = "Confirm Resign"
            btnResign.BackColor = Color.OrangeRed


            Dim strLeaveReason As String = txtLeaveReason.Text
            Dim strLeaveDate As String = dtpLeaveDate.Value.ToString("dd/MM/yyyy")
            Dim db As New StaffDataContext()
            Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = ManagerMain.selectedStaff)

            If s Is Nothing Then
                MessageBox.Show("Staff not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                err.Tag = Nothing
                Reset()

                If strLeaveDate = "" Then
                    err.SetError(dtpLeaveDate, "Please select [Birth Date]")
                    err.Tag = If(err.Tag, dtpLeaveDate)
                Else
                    err.SetError(dtpLeaveDate, Nothing)
                End If

                If strLeaveReason = "" Then
                    err.SetError(txtLeaveReason, "Please enter [Leave Reason]")
                    err.Tag = If(err.Tag, txtLeaveReason)
                ElseIf strLeaveReason.Length <= 15 Then
                    err.SetError(txtLeaveReason, "Please enter more than 15 character.")
                    err.Tag = If(err.Tag, txtLeaveReason)
                Else
                    err.SetError(txtLeaveReason, Nothing)
                End If

                If err.Tag IsNot Nothing Then
                    CType(err.Tag, Control).Focus() ' Focus on the first error control
                    Return

                Else

                    Dim resultResign As DialogResult = MessageBox.Show("Confirm to resign this staff?", "Resign Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

                    If resultResign = DialogResult.Yes Then

                        s.staffStatus = "Resigned"
                        s.leaveDate = strLeaveDate
                        s.staffLeaveReason = strLeaveReason

                        MessageBox.Show("Resigned staff successful.", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        db.SubmitChanges()

                        Reset()
                        UpdateStaffInformation_Load(Nothing, Nothing)

                    End If

                End If
            End If
        End If

    End Sub

    Private Function IsDuplicatedName(strName As String) As Boolean
        Dim db As New StaffDataContext()
        Return db.Staffs.Any(Function(o) o.staffName = strName)
    End Function

    Private Function IsDuplicatedIC(strIC As String) As Boolean
        Dim db As New StaffDataContext()
        Return db.Staffs.Any(Function(o) o.staffIC = strIC)
    End Function

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

    Private Sub mskAge_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)
        dtpBirthDate.Value = DateTime.Now.Date
        dtpBirthDate.MaxDate = DateTime.Now.Date.AddYears(-(Integer.Parse(txtAge.Text)))
        dtpBirthDate.CustomFormat = DateTimePickerFormat.Custom
        dtpBirthDate.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        ChangePassword.ShowDialog()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        UpdateStaffInformation_Load(Nothing, Nothing)
        Reset()
    End Sub
End Class