Public Class ManagerMain

    Friend selectedStaff As String

    Private Sub btnAddNewStaff_Click(sender As Object, e As EventArgs) Handles btnAddNewStaff.Click
        AddNewStaff.ShowDialog()
        ManagerMain_Load(Nothing, Nothing)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If IsNothing(selectedStaff) = False Then
            UpdateStaffInformation.ShowDialog()
            ManagerMain_Load(Nothing, Nothing)
        Else
            MessageBox.Show("Please Select a Staff Record.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnShowDetails_Click(sender As Object, e As EventArgs) Handles btnShowDetails.Click

        If IsNothing(selectedStaff) = False Then
            ManagerViewStaffInformation.ShowDialog()
        Else
            MessageBox.Show("Please Select a Staff Record.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Public Sub ManagerMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
        cboType.SelectedIndex = 0
        txtSearch.Text = ""

        BindData()
    End Sub

    Private Sub BindData()
        Dim strType As String = cboType.SelectedItem ' For filtering
        Dim strSearch As String = txtSearch.Text

        Dim db As New StaffDataContext()

        If strType = "ALL" Then

            Dim rs = From s In db.Staffs
                     Where (s.staffID.Contains(strSearch) Or s.staffName.Contains(strSearch) Or s.staffIC.Contains(strSearch) Or s.staffRole.Contains(strSearch) Or s.staffType.Contains(strSearch) Or s.staffSalary.ToString.Contains(strSearch) Or s.staffStatus.Contains(strSearch) Or s.joinedDate.ToString.Contains(strSearch))
                     Select New With
                     {
                         s.staffID,
                         s.staffName,
                         s.staffIC,
                         s.staffRole,
                         s.staffType,
                         s.staffSalary,
                         s.staffStatus,
                         s.joinedDate
                     }
            dgvStaff.DataSource = rs

        Else
            If strType = "STAFF" Or strType = "MANAGER" Then

                Dim rs = From s In db.Staffs
                         Where s.staffRole = strType And (s.staffID.Contains(strSearch) Or s.staffName.Contains(strSearch) Or s.staffIC.Contains(strSearch) Or s.staffRole.Contains(strSearch) Or s.staffType.Contains(strSearch) Or s.staffSalary.ToString.Contains(strSearch) Or s.staffStatus.Contains(strSearch) Or s.joinedDate.ToString.Contains(strSearch))
                         Select New With
                         {
                         s.staffID,
                         s.staffName,
                         s.staffIC,
                         s.staffRole,
                         s.staffType,
                         s.staffSalary,
                         s.staffStatus,
                         s.joinedDate
                         }
                dgvStaff.DataSource = rs

            ElseIf strType = "FULL-TIME" Or strType = "PART-TIME" Then

                Dim rs = From s In db.Staffs
                         Where s.staffType = strType And (s.staffID.Contains(strSearch) Or s.staffName.Contains(strSearch) Or s.staffIC.Contains(strSearch) Or s.staffRole.Contains(strSearch) Or s.staffType.Contains(strSearch) Or s.staffSalary.ToString.Contains(strSearch) Or s.staffStatus.Contains(strSearch) Or s.joinedDate.ToString.Contains(strSearch))
                         Select New With
                         {
                         s.staffID,
                         s.staffName,
                         s.staffIC,
                         s.staffRole,
                         s.staffType,
                         s.staffSalary,
                         s.staffStatus,
                         s.joinedDate
                         }
                dgvStaff.DataSource = rs

            ElseIf strType = "Active" Or strType = "Resigned" Then

                Dim rs = From s In db.Staffs
                         Where s.staffStatus = strType And (s.staffID.Contains(strSearch) Or s.staffName.Contains(strSearch) Or s.staffIC.Contains(strSearch) Or s.staffRole.Contains(strSearch) Or s.staffType.Contains(strSearch) Or s.staffSalary.ToString.Contains(strSearch) Or s.staffStatus.Contains(strSearch) Or s.joinedDate.ToString.Contains(strSearch))
                         Select New With
                         {
                         s.staffID,
                         s.staffName,
                         s.staffIC,
                         s.staffRole,
                         s.staffType,
                         s.staffSalary,
                         s.staffStatus,
                         s.joinedDate
                         }
                dgvStaff.DataSource = rs

            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        BindData()
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        ManagerMain_Load(Nothing, Nothing)
    End Sub

    Private Sub cboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboType.SelectedIndexChanged
        BindData()
    End Sub

    Private Sub dgvStaff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStaff.CellClick

        Dim intIndex As Integer = e.RowIndex
        Dim strId As String

        If intIndex >= 0 Then
            strId = CStr(dgvStaff.Rows(intIndex).Cells(0).Value)
            selectedStaff = strId
        End If

    End Sub
End Class