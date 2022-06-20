Imports System.Data.SqlClient

Public Class FrmMemberAll

    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter

    Friend Sub FrmMemberAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strSql As String

        'Update Member Status
        checkExpired()

        Try
            'Load all the member with brief information into gridview as display purpose
            If OpenConnection() = True Then
                strSql = "Select memberID, memberName, memberIC, memberStatus,memberPoint,memberContact, memberExpiredDate From Member"
                da = New SqlDataAdapter(strSql, conn)
                ds.Clear()
                da.Fill(ds, "Member")

                If ds.Tables("Member").Rows.Count > 0 Then

                    With gvMember
                        .DataSource = ds.Tables(0)
                        .Columns(0).HeaderCell.Value = "Member ID"
                        .Columns(1).HeaderCell.Value = "Name"
                        .Columns(2).HeaderCell.Value = "IC"
                        .Columns(3).HeaderCell.Value = "Status"
                        .Columns(4).HeaderCell.Value = "Points"
                        .Columns(5).HeaderCell.Value = "Contact"
                        .Columns(6).HeaderCell.Value = "Expired Date"
                        .Columns(6).DefaultCellStyle.Format = "yyyy-MM-dd"
                    End With
                Else
                    MessageBox.Show("No record found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                CloseConnection()
            Else
                MessageBox.Show("Somethings Wrong With the Database Connection, Please Contact Development Team", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            'Only manager can add new member and renew without payment
            If UserLogin.strCurrentLoginStaffRole = "MANAGER" Then
                setBtnStyle(btnAdd, True)
                setBtnStyle(btnRenew, True)
                mnuAdd.Enabled = True
                mnuRenew.Enabled = True
            Else
                setBtnStyle(btnAdd, False)
                setBtnStyle(btnRenew, False)
                mnuAdd.Enabled = False
                mnuRenew.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show("Error: Cannot retrieve member list", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click, mnuShow.Click

        'detect if the gvMember's row selected > 1 should show error message
        If gvMember.SelectedRows.Count = 1 Then
            setMemberDetailID(gvMember.SelectedRows(0).Cells(0).Value.ToString)
        Else
            MessageBox.Show("Please select only 1 row", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub gvMember_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvMember.CellDoubleClick

        'Only execute when the content double clicked
        '-1 is header double clicked so we should not response
        If e.RowIndex <> -1 Then
            setMemberDetailID(gvMember.Rows(e.RowIndex).Cells(0).Value)
        End If

    End Sub

    'Use to set the memberID in FrmMemberDetailsNUpdate Form
    Private Sub setMemberDetailID(strID As String)
        With FrmMemberDetailsNUpdate
            .strMemberID = strID
            .ShowDialog()
        End With
    End Sub

    'Auto update the member status to expire if eceed the expired date 
    Friend Sub checkExpired()

        Try

            Dim strSql As String
            Dim MySqlCommand As SqlCommand
            Dim dtrMember As SqlDataReader
            Dim strExpiredID As String = ""

            If OpenConnection() = True Then
                'First section - get memberID which expiredDate > Now
                strSql = "Select * From Member "
                MySqlCommand = New SqlCommand(strSql, conn)
                dtrMember = MySqlCommand.ExecuteReader()

                If dtrMember.HasRows Then
                    Do While dtrMember.Read()
                        If DateTime.Compare(dtrMember.GetDateTime(4).Date, Now.Date) < 0 And dtrMember.GetString(7) <> "Expired" Then
                            strExpiredID = strExpiredID & " " & dtrMember.GetString(0)
                        End If
                    Loop
                Else
                    MessageBox.Show("Cannot Get Member Information, Please Re-Open", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    CloseConnection()
                    Me.Close()
                End If

                dtrMember.Close()
                'End of first section
                '------------------------------------------------------------------------------------------------------------

                'Second section - update status to Expired
                Dim strExpiredCount As String() = strExpiredID.Trim().Split(" ")
                Dim intSuccess As Integer
                Dim intCountUpdate As Integer = 0
                Dim strSuccessMessage As String = ""

                If strExpiredCount.Length > 0 And strExpiredCount(0).StartsWith("MB") Then
                    For Each strMemberID As String In strExpiredCount

                        strSql = "Update Member set memberStatus= 'Expired' where memberID=@memberID"
                        MySqlCommand = New SqlCommand(strSql, conn)
                        MySqlCommand.Parameters.AddWithValue("@memberID", strMemberID)
                        intSuccess = MySqlCommand.ExecuteNonQuery()

                        If intSuccess > 0 Then
                            intCountUpdate = intCountUpdate + 1
                            strSuccessMessage += intCountUpdate.ToString() & ". " & strMemberID & Environment.NewLine
                        Else
                            MessageBox.Show("Member " & strMemberID & "Status Update Failed.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    Next
                    strNotification += Environment.NewLine & "List of updated expired member ID: " & Environment.NewLine & strSuccessMessage

                End If

                CloseConnection()
            Else
                MessageBox.Show("Somethings Wrong With the Database Connection, Please Contact Development Team", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: Cannot update member status", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click, mnuSearch.Click
        FrmMemberSearch.ShowDialog()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, mnuAdd.Click
        FrmMemberAdd.ShowDialog()
    End Sub

    Private Sub btnRenew_Click(sender As Object, e As EventArgs) Handles btnRenew.Click, mnuRenew.Click

        Try

            If gvMember.SelectedRows.Count = 1 Then
                With FrmMemberRenew
                    .strMemberID = gvMember.SelectedRows(0).Cells(0).Value.ToString()
                    .ShowDialog()
                End With
                FrmMemberAll_Load(Nothing, Nothing)
            Else
                MessageBox.Show("Please select only 1 row", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: Cannot renew member validaty", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class