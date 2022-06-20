Imports System.Net
Imports System.Net.Mail

Public Class ForgotPassword_ResetPassword
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        btnClear_Click(Nothing, Nothing)
        Me.Close()
        UserLogin.Show()
    End Sub

    Private Sub ForgetPassword_ResetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()

        txtUserID.Text = ForgotPassword.strForgotPasswordID
        txtICNo.Text = ForgotPassword.strForgotPasswordIC
        txtUserID.Enabled = False
        txtICNo.Enabled = False
    End Sub

    Private Sub ckbHide_CheckedChanged(sender As Object, e As EventArgs) Handles ckbHide.CheckedChanged
        If ckbHide.Checked = True Then
            txtNewPassword.PasswordChar = "*"
            txtVerifyPassword.PasswordChar = "*"
        Else
            txtNewPassword.PasswordChar = ""
            txtVerifyPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNewPassword.Text = ""
        txtVerifyPassword.Text = ""
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim db As New StaffDataContext()
        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = ForgotPassword.strForgotPasswordID)

        Dim strNewPassword As String = txtNewPassword.Text
        Dim strVerifyPassword As String = txtVerifyPassword.Text

        If s Is Nothing Then
            MessageBox.Show("User Id not found. Cannot reset password", "Error")
        Else
            If strNewPassword = "" Or strVerifyPassword = "" Then
                MessageBox.Show("Please enter the password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf ChangePassword.ValidatePassword(strNewPassword) = False Then
                MessageBox.Show("New password must between 8 - 16 characters and include atleast 2 upppercase, 2 lowercase character, 2 digit and 2 special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf s.staffPassword = strNewPassword Then
                MessageBox.Show("Old password is same with new password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf strNewPassword <> strVerifyPassword Then
                MessageBox.Show("New password is not same with verify password.", "Input Error")
            Else
                Dim result As DialogResult = MessageBox.Show("Confirm reset password?", "Reset Password Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    s.staffPassword = strVerifyPassword
                    db.SubmitChanges()


                    'HERE FOR EMAIL
                    Dim smtpServer As New SmtpClient()
                    Dim strAddFrom As String = "bookMasterVP@outlook.com"
                    Dim strAddFromPass As String = "b00kM@sterVP"

                    With smtpServer
                        .Host = "smtp-mail.outlook.com"
                        .Port = 587
                        .EnableSsl = True
                        .DeliveryMethod = SmtpDeliveryMethod.Network
                        .Credentials = New NetworkCredential(strAddFrom, strAddFromPass)
                        .Timeout = 20000
                    End With

                    'Option 1
                    Dim mail As New MailMessage()
                    mail = New MailMessage()
                    mail.From = New MailAddress(strAddFrom)
                    mail.To.Add(s.staffEmail)
                    mail.Subject = "Password Recovery Changes in Book Master POS System"
                    mail.Body = "Hi " & s.staffName & ", This is the notification for password changes in Book Masters. You have changed your password to " & strVerifyPassword & ". "
                    smtpServer.Send(mail)

                    'Option 2
                    'smtpServer.Send(strAddFrom, s.staffEmail , "EMAIL SUBJECT", "EMAIL CONTENT")



                    MessageBox.Show("Password reset Successfully. A notification will sent to your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnClear_Click(Nothing, Nothing)
                End If
            End If
        End If
    End Sub
End Class