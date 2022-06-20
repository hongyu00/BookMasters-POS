Imports System.IO

Public Class ManagerViewStaffInformation
    Private Sub ViewStaffInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()

        Dim db As New StaffDataContext()
        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = ManagerMain.selectedStaff)

        If IsNothing(s) Then
            MessageBox.Show("Invalid user ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            txtID.Text = s.staffID
            txtName.Text = s.staffName
            mskIC.Text = s.staffIC
            cboRole.Text = s.staffRole
            cboType.Text = s.staffType
            txtSalary.Text = s.staffSalary
            dtpJoinDate.Value = s.joinedDate.ToString("dd/MM/yyyy")

            txtStatus.Text = s.staffStatus

            If s.staffStatus = "Resigned" Then
                dtpLeaveDate.Value = s.leaveDate.Value.ToString("dd/MM/yyyy")
                txtLeaveReason.Text = s.staffLeaveReason
            ElseIf s.staffStatus = "Active" Then
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

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Me.Close()
        UpdateStaffInformation.UpdateStaffInformation_Load(Nothing, Nothing)
        UpdateStaffInformation.ShowDialog()
    End Sub
End Class