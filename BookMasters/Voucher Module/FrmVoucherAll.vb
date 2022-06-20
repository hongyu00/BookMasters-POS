Imports System.Data.SqlClient
Imports System.Globalization

Public Class FrmVoucherAll

    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter

    Friend Sub FrmVoucherAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strSql As String

        'Update Voucher Status
        updateStatus()

        Try

            'Load all the member with brief information into gridview as display purpose
            If OpenConnection() = True Then
                strSql = "Select voucherID, discountAmount, voucherStartDate, voucherExpiredDate,voucherStatus, minimumSpend From Voucher"
                da = New SqlDataAdapter(strSql, conn)
                ds.Clear()
                da.Fill(ds, "AllVoucher")

                If ds.Tables("AllVoucher").Rows.Count > 0 Then

                    With gvVoucher
                        .DataSource = ds.Tables("AllVoucher")
                        .Columns(0).HeaderCell.Value = "Voucher ID"
                        .Columns(1).HeaderCell.Value = "Discount Amount"
                        .Columns(1).DefaultCellStyle.Format = "C"
                        .Columns(1).DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-MY")
                        .Columns(2).HeaderCell.Value = "Start Date"
                        .Columns(2).DefaultCellStyle.Format = "yyyy-MM-dd"
                        .Columns(3).HeaderCell.Value = "End Date"
                        .Columns(3).DefaultCellStyle.Format = "yyyy-MM-dd"
                        .Columns(4).HeaderCell.Value = "Status"
                        .Columns(5).HeaderCell.Value = "Minimum Spend (RM)"
                        .Columns(5).DefaultCellStyle.Format = "C"
                        .Columns(5).DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-MY")
                    End With
                Else
                    MessageBox.Show("No record found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                CloseConnection()
            Else
                MessageBox.Show("Somethings Wrong With the Database Connection1, Please Contact Development Team", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: Cannot retrieve voucher list" & vbCrLf & ex.Message, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Only manager can add New voucher
        If UserLogin.strCurrentLoginStaffRole = "MANAGER" Then
            setBtnStyle(btnAdd, True)
            mnuAdd.Enabled = True
        Else
            setBtnStyle(btnAdd, False)
            mnuAdd.Enabled = False
        End If
    End Sub

    'Auto update the member status to expire if eceed the expired date, else enable
    Friend Sub updateStatus()

        Try

            Dim strSql As String
            Dim MySqlCommand As SqlCommand
            Dim dtrVoucher As SqlDataReader
            Dim strExpiredID As String = ""
            Dim strActiveID As String = ""

            If OpenConnection() = True Then
                'First section - get voucherID which expiredDate > Now
                strSql = "Select * From Voucher "
                MySqlCommand = New SqlCommand(strSql, conn)
                dtrVoucher = MySqlCommand.ExecuteReader()

                If dtrVoucher.HasRows Then
                    Do While dtrVoucher.Read()
                        'If expired
                        If DateTime.Compare(dtrVoucher.GetDateTime(3).Date, Now.Date) < 0 And (dtrVoucher.GetString(5) <> "Expired" And dtrVoucher.GetString(5) <> "Used") Then
                            strExpiredID = strExpiredID & " " & dtrVoucher.GetString(0)
                        End If
                        'If active
                        If DateTime.Compare(dtrVoucher.GetDateTime(2).Date, Now.Date) <= 0 And dtrVoucher.GetString(5) = "New" Then
                            strActiveID = strActiveID & " " & dtrVoucher.GetString(0)
                        End If
                    Loop
                Else
                    MessageBox.Show("Cannot Get Voucher Information, Please Re-Open", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    CloseConnection()
                    Me.Close()
                End If

                dtrVoucher.Close()
                'End of first section
                '------------------------------------------------------------------------------------------------------------

                'Second section - update status to Expired or Active
                Dim strExpiredCount As String() = strExpiredID.Trim().Split(" ")
                Dim strActiveCount As String() = strActiveID.Trim().Split(" ")
                Dim intSuccess As Integer
                Dim intCountUpdate As Integer
                Dim strSuccessMessage As String = ""

                'To update expire voucher
                If strExpiredCount.Length > 0 And strExpiredCount(0) <> "" Then

                    intCountUpdate = 0
                    intSuccess = 0
                    strSuccessMessage = ""

                    For Each strVoucherID As String In strExpiredCount

                        strSql = "Update Voucher set voucherStatus= 'Expired' where voucherID=@voucherID"
                        MySqlCommand = New SqlCommand(strSql, conn)
                        MySqlCommand.Parameters.AddWithValue("@voucherID", strVoucherID)
                        intSuccess = MySqlCommand.ExecuteNonQuery()

                        If intSuccess > 0 Then
                            intCountUpdate += 1
                            strSuccessMessage += intCountUpdate.ToString() & ". " & strVoucherID & Environment.NewLine
                        Else
                            MessageBox.Show("Voucher " & strVoucherID & "Status Update Failed.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    Next

                    strNotification += Environment.NewLine & "List of updated expired voucher ID: " & Environment.NewLine & strSuccessMessage

                End If

                'To update new voucher to active
                If strActiveCount.Length > 0 And strActiveCount(0) <> "" Then

                    intCountUpdate = 0
                    intSuccess = 0
                    strSuccessMessage = ""

                    For Each strVoucherID As String In strActiveCount

                        strSql = "Update Voucher set voucherStatus= 'Active' where voucherID=@voucherID"
                        MySqlCommand = New SqlCommand(strSql, conn)
                        MySqlCommand.Parameters.AddWithValue("@voucherID", strVoucherID)
                        intSuccess = MySqlCommand.ExecuteNonQuery()

                        If intSuccess > 0 Then
                            intCountUpdate += 1
                            strSuccessMessage += intCountUpdate.ToString() & ". " & strVoucherID & Environment.NewLine
                        Else
                            MessageBox.Show("Voucher " & strVoucherID & "Status Update Failed.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    Next

                    strNotification += Environment.NewLine & "List of updated active voucher ID: " & Environment.NewLine & strSuccessMessage

                End If

                CloseConnection()
            Else
                MessageBox.Show("Somethings Wrong With the Database Connection, Please Contact Development Team", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: Cannot update voucher status", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click, mnuSearch.Click
        FrmVoucherSearch.ShowDialog()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, mnuAdd.Click
        FrmVoucherAdd.ShowDialog()
    End Sub

    Private Sub gvVoucher_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvVoucher.CellDoubleClick

        'Only execute when the content double clicked
        '-1 is header double clicked so we should not response
        If e.RowIndex <> -1 Then
            setVoucherDetailID(gvVoucher.Rows(e.RowIndex).Cells(0).Value)
        End If
    End Sub

    'Use to set the voucherID in FrmVoucherDetailsNUpdate Form
    Private Sub setVoucherDetailID(strID As String)
        With FrmVoucherDetailsNUpdate
            .strVoucherID = strID
            .ShowDialog()
        End With
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click, mnuShow.Click
        'detect if the gvVoucher's row selected > 1 should show error message
        If gvVoucher.SelectedRows.Count = 1 Then
            setVoucherDetailID(gvVoucher.SelectedRows(0).Cells(0).Value.ToString)
        Else
            MessageBox.Show("Please select only 1 row", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class