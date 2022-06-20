Imports System.Net
Imports System.Net.Mail

Public Class ForgotPassword

    Friend strForgotPasswordID As String
    Friend strForgotPasswordIC As String

    Private Sub ForgetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        btnClear_Click(Nothing, Nothing)
        Me.Close()
        UserLogin.Show()
    End Sub

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        If ValidateIDAndIC() = True Then
            strForgotPasswordID = txtStaffID.Text
            strForgotPasswordIC = mskIC.Text

            btnClear_Click(Nothing, Nothing)
            Me.Close()
            ForgotPassword_ResetPassword.ShowDialog()
        End If

    End Sub

    Private Sub btnGetOldPassword_Click(sender As Object, e As EventArgs) Handles btnGetPassword.Click
        If ValidateIDAndIC() = True Then
            Dim db As New StaffDataContext()
            Dim s As Staff
            s = db.Staffs.FirstOrDefault(Function(o) o.staffID = txtStaffID.Text)

            MessageBox.Show("Your old password is : " & s.staffPassword, "Old Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnClear_Click(Nothing, Nothing)
        End If
    End Sub

    Private Function ValidateIDAndIC() As Boolean
        Dim db As New StaffDataContext()
        Dim s As Staff

        Dim strID As String = txtStaffID.Text
        Dim strIC As String = If(mskIC.MaskCompleted, mskIC.Text, "")

        If strID = "" Or strIC = "" Then
            MessageBox.Show("Please enter your staff ID and your IC number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            s = db.Staffs.FirstOrDefault(Function(o) o.staffID = strID)

            If IsNothing(s) Then
                MessageBox.Show("You have entered an invalid staff ID or IC number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If s.staffStatus <> "Active" Then
                    MessageBox.Show("You have entered an invalid staff ID or IC number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf strIC <> s.staffIC Then
                    MessageBox.Show("You have entered an invalid staff ID or IC number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Return True
                End If
            End If
        End If
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        mskIC.Text = ""
        txtStaffID.Text = ""
    End Sub
End Class