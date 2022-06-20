Public Class ChangePassword
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        btnClear_Click(Nothing, Nothing)
        Me.Close()
    End Sub

    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()

        If UserLogin.strCurrentLoginStaffRole = "STAFF" Then
            txtUserID.Text = UserLogin.strCurrentLoginStaffID
            txtUserID.Enabled = False
        ElseIf UserLogin.strCurrentLoginStaffRole = "MANAGER" Then
            txtUserID.Text = ManagerMain.selectedStaff

            btnClear_Click(Nothing, Nothing)
            txtUserID.Enabled = False
        Else
            MessageBox.Show("Staff Id not found. Cannot change password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub ckbHidePassword_CheckedChanged(sender As Object, e As EventArgs) Handles ckbHidePassword.CheckedChanged
        If ckbHidePassword.Checked = True Then
            txtOldPassword.PasswordChar = "*"
            txtNewPassword.PasswordChar = "*"
            txtVerifyPassword.PasswordChar = "*"
        Else
            txtOldPassword.PasswordChar = ""
            txtNewPassword.PasswordChar = ""
            txtVerifyPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        If UserLogin.strCurrentLoginStaffRole = "STAFF" Then
            txtOldPassword.Text = ""
            txtNewPassword.Text = ""
            txtVerifyPassword.Text = ""
        ElseIf UserLogin.strCurrentLoginStaffRole = "MANAGER" Then
            Dim db As New StaffDataContext()
            Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = ManagerMain.selectedStaff)

            txtOldPassword.Text = s.staffPassword
            txtNewPassword.Text = ""
            txtVerifyPassword.Text = ""
        End If

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim db As New StaffDataContext()
        Dim s As Staff
        Dim strOldPassword As String
        Dim strNewPassword As String
        Dim strVerifyPassword As String

        If UserLogin.strCurrentLoginStaffRole = "STAFF" Then
            s = db.Staffs.FirstOrDefault(Function(o) o.staffID = UserLogin.strCurrentLoginStaffID)
        ElseIf UserLogin.strCurrentLoginStaffRole = "MANAGER" Then
            s = db.Staffs.FirstOrDefault(Function(o) o.staffID = ManagerMain.selectedStaff)
        End If

        If s Is Nothing Then
            MessageBox.Show("Staff Id not found. Cannot change password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            strOldPassword = txtOldPassword.Text
            strNewPassword = txtNewPassword.Text
            strVerifyPassword = txtVerifyPassword.Text

            If strOldPassword = "" Or strNewPassword = "" Or strVerifyPassword = "" Then
                MessageBox.Show("Please enter all the password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf strOldPassword <> s.staffPassword Then
                MessageBox.Show("Old password wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf strOldPassword = strNewPassword Then
                MessageBox.Show("Old password is same with new password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf ValidatePassword(strNewPassword) = False Then
                MessageBox.Show("New password must between 8 - 16 characters and include at least 2 uppercase, 2 lowercase characters, 2 digit and 2 special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf strNewPassword <> strVerifyPassword Then
                MessageBox.Show("New password is not same with verify password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim result As DialogResult = MessageBox.Show("Confirm to change password?", "Change Password Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    s.staffPassword = strVerifyPassword
                    db.SubmitChanges()
                    btnClear_Click(Nothing, Nothing)
                    MessageBox.Show("Password Change Successfully.", "Success")
                End If

            End If
        End If

    End Sub


    Function ValidatePassword(ByVal pwd As String,
    Optional ByVal minLength As Integer = 8,
    Optional ByVal maxLength As Integer = 16,
    Optional ByVal numUpper As Integer = 2,
    Optional ByVal numLower As Integer = 2,
    Optional ByVal numNumbers As Integer = 2,
    Optional ByVal numSpecial As Integer = 2) As Boolean

        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        If Len(pwd) < minLength Then Return False
        If Len(pwd) > maxLength Then Return False
        If upper.Matches(pwd).Count < numUpper Then Return False
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False
        If special.Matches(pwd).Count < numSpecial Then Return False

        Return True
    End Function
End Class