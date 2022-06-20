Imports System.IO

Public Class StaffViewInformation
    Public Sub StaffViewInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New StaffDataContext()

        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = UserLogin.strCurrentLoginStaffID)

        If IsNothing(s) Then
            MessageBox.Show("Invalid user ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            txtID.Text = s.staffID
            txtName.Text = s.staffName
            mskIC.Text = s.staffIC
            cboRole.Text = s.staffRole
            cboType.Text = s.staffType

            txtSalary.Text = s.staffSalary
            dtpJoinDate.Value = s.joinedDate.ToString("dd/MM/yyyy")

            txtStatus.Text = s.staffStatus

            cboGender.Text = s.staffGender
            txtAge.Text = s.staffAge
            dtpBirthDate.Value = s.staffBirthDate.Value.ToString("dd/MM/yyyy")
            mskContact.Text = s.staffContact
            txtEmail.Text = s.staffEmail
            txtAddress.Text = s.staffAddress

            grpPersonalInfo.Enabled = False
            grpNecessaryInfo.Enabled = False
        End If

    End Sub

    Private Sub btnChangePassword_Click_1(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        ChangePassword.ShowDialog()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateStaffInformation.ShowDialog()
        StaffViewInformation_Load(Nothing, Nothing)
    End Sub

End Class