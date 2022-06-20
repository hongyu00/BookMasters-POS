Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Globalization

Public Class FrmVoucherDetailsNUpdate

    Friend strVoucherID As String

    Private Sub FrmVoucherDetails_Load(sender As Object, e As EventArgs) Handles Me.Load

        'If there are no voucherID means something wrong so we need to close the form
        If strVoucherID = "" Then
            MessageBox.Show("Please select a voucher", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        Else
            'set voucherID
            lblVoucherID.Text = strVoucherID

            'retrieve voucher information
            retrieveInfo()

            'View only for member information
            setEditability(False)

        End If
    End Sub

    'Set editability for the voucher information
    'flag; true = editable, false = view only
    Private Sub setEditability(flag As Boolean)

        dtpCustDate.Enabled = flag
        dtpAppliedDate.Enabled = flag

        'Only manager can edit voucher start and end date
        If UserLogin.strCurrentLoginStaffRole = "MANAGER" And flag Then
            dtpStart.Enabled = flag
            dtpEnd.Enabled = flag
            txtAmount.Enabled = flag
            txtMinimum.Enabled = flag
        Else
            dtpStart.Enabled = False
            dtpEnd.Enabled = False
            txtAmount.Enabled = False
            txtMinimum.Enabled = False
        End If

        If flag = False Then
            setBtnStyle(btnSave, False)
            setBtnStyle(btnCancel, False)
            setBtnStyle(btnEdit, True)
        Else
            setBtnStyle(btnSave, True)
            setBtnStyle(btnCancel, True)
            setBtnStyle(btnEdit, False)
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Dim strSql As String
            Dim MySqlCommand As SqlCommand
            Dim strStatus As String

            If OpenConnection() = True Then
                strSql = "Select voucherStatus From Voucher Where voucherID = @voucherID"
                MySqlCommand = New SqlCommand(strSql, conn)
                MySqlCommand.Parameters.AddWithValue("@voucherID", strVoucherID)
                strStatus = MySqlCommand.ExecuteScalar()

                If strStatus <> "Used" And strStatus <> "Expired" Then
                    setEditability(True)
                    If lblVoucherStatus.Text = "New" Then
                        dtpAppliedDate.Enabled = False
                    End If
                Else
                    MessageBox.Show("Cannot Edit The Used/Expired Voucher", "Restrict Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                CloseConnection()
            Else
                MessageBox.Show("Somethings Wrong With the Database Connection, Please Contact Development Team", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: Cannot retrieve voucher information" & vbCrLf & "Exception : " & ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        setEditability(False)

        'Change back to default value
        retrieveInfo()

    End Sub

    Private Sub FrmVoucherDetailsNUpdate_Validating(sender As Object, e As CancelEventArgs) Handles Me.Validating
        FrmVoucherAll.FrmVoucherAll_Load(Nothing, Nothing)
    End Sub

    Private Sub retrieveInfo()

        Try
            Dim strSql As String
            Dim MySqlCommand As SqlCommand
            Dim dtrVoucher As SqlDataReader

            'Load all the information for selected voucher
            If OpenConnection() = True Then
                strSql = "Select * From Voucher Where voucherID = @voucherID"
                MySqlCommand = New SqlCommand(strSql, conn)
                MySqlCommand.Parameters.AddWithValue("@voucherID", strVoucherID)
                dtrVoucher = MySqlCommand.ExecuteReader()

                If dtrVoucher.HasRows Then
                    Do While dtrVoucher.Read()
                        txtAmount.Text = dtrVoucher.GetDecimal(1).ToString("C", CultureInfo.GetCultureInfo("en-MY"))
                        dtpStart.Value = dtrVoucher.GetDateTime(2)
                        dtpEnd.Value = dtrVoucher.GetDateTime(3)
                        txtMinimum.Text = dtrVoucher.GetDecimal(4).ToString("C", CultureInfo.GetCultureInfo("en-MY"))
                        lblVoucherStatus.Text = dtrVoucher.GetString(5)
                        lblVoucherType.Text = dtrVoucher.GetString(6)

                        If Not IsDBNull(dtrVoucher(7)) Then
                            With dtpCustDate
                                .Value = dtrVoucher.GetDateTime(7)
                                .Format = DateTimePickerFormat.Long
                            End With
                        Else
                            With dtpCustDate
                                .Value = "1/1/2020"
                                .Format = DateTimePickerFormat.Custom
                                .CustomFormat = " "
                            End With
                        End If

                        If Not IsDBNull(dtrVoucher(8)) Then
                            With dtpAppliedDate
                                .Value = dtrVoucher.GetDateTime(8)
                                .Format = DateTimePickerFormat.Long
                            End With
                        Else
                            With dtpAppliedDate
                                .Value = "1/1/2020"
                                .Format = DateTimePickerFormat.Custom
                                .CustomFormat = " "
                            End With
                        End If

                        dtpGenerated.Value = dtrVoucher.GetDateTime(9)
                        lblStaffID.Text = dtrVoucher.GetString(10)

                    Loop
                Else
                    MessageBox.Show("Cannot Get Voucher Information, Please Re-try", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    CloseConnection()
                    Me.Close()
                End If
                CloseConnection()
            Else
                MessageBox.Show("Somethings Wrong With the Database Connection, Please Contact Development Team", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: Cannot retrieve voucher information" & vbCrLf & "Exception : " & ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Sub dtpAppliedDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpAppliedDate.ValueChanged, dtpCustDate.ValueChanged

        If sender Is dtpAppliedDate Then
            dtpAppliedDate.Format = DateTimePickerFormat.Long
        ElseIf sender Is dtpCustDate Then
            dtpCustDate.Format = DateTimePickerFormat.Long
        End If

    End Sub

    Private Sub dtpAppliedDate_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpAppliedDate.KeyDown, dtpCustDate.KeyDown

        'Press delete or backspace to delete the selected date
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then

            If sender Is dtpAppliedDate Then
                With dtpAppliedDate
                    .Format = DateTimePickerFormat.Custom
                    .CustomFormat = " "
                    .Value = "1/1/2020"
                End With
            ElseIf sender Is dtpCustDate Then
                With dtpCustDate
                    .Format = DateTimePickerFormat.Custom
                    .CustomFormat = " "
                    .Value = "1/1/2020"
                End With
            End If

        End If

    End Sub

    Private Sub txtAmount_Validating(sender As Object, e As CancelEventArgs) Handles txtAmount.Validating
        Try
            Dim strDiscount As String = txtAmount.Text.ToUpper().Replace("RM", "")
            Dim decDiscount As Decimal = Decimal.Parse(strDiscount)

            If decDiscount <= 0D Then
                err.SetError(txtAmount, "Cannot be equal or less than 0")
                e.Cancel = True
            Else
                err.SetError(txtAmount, Nothing)
                txtAmount.Text = decDiscount.ToString("RM0.00")
            End If

        Catch ex As Exception

            'If contain special character, empty, and aplhabet will fall into exception

            If containsSpecialChars(txtAmount.Text) Then
                err.SetError(txtAmount, "Cannot contains special characters")
                e.Cancel = True
            Else
                err.SetError(txtAmount, "Must not be empty and only accept digits")
                e.Cancel = True
            End If

            txtAmount.SelectAll()

        End Try
    End Sub

    Private Sub txtMinimum_Validating(sender As Object, e As CancelEventArgs) Handles txtMinimum.Validating
        Try
            Dim strMinimum As String = txtMinimum.Text.ToUpper().Replace("RM", "")
            Dim decMinimum As Decimal = Decimal.Parse(strMinimum)

            If decMinimum < 0D Then
                err.SetError(txtMinimum, "Cannot be equal or less than 0")
                e.Cancel = True
            Else
                err.SetError(txtMinimum, Nothing)
                txtMinimum.Text = decMinimum.ToString("RM0.00")
            End If

        Catch ex As Exception

            'If contain special character, empty, and aplhabet will fall into exception

            If containsSpecialChars(txtMinimum.Text) Then
                err.SetError(txtMinimum, "Cannot contains special characters")
                e.Cancel = True
            Else
                err.SetError(txtMinimum, "Must not be empty and only accept digits")
                e.Cancel = True
            End If

            txtMinimum.SelectAll()

        End Try

    End Sub

    Private Sub dtpStart_Validating(sender As Object, e As CancelEventArgs) Handles dtpStart.Validating

        Dim dateStart As Date = dtpStart.Value

        If dateStart > dtpEnd.Value Then
            err.SetError(dtpStart, "Start Date Must Earlier Than End Date")
            e.Cancel = True
        ElseIf dateStart < dtpGenerated.Value Then
            err.SetError(dtpStart, "Start Date Cannot Earlier Than Date Generated")
            e.Cancel = True
        Else
            err.SetError(dtpStart, Nothing)
        End If

    End Sub

    Private Sub dtpEnd_Validating(sender As Object, e As CancelEventArgs) Handles dtpEnd.Validating

        Dim dateEnd As Date = dtpEnd.Value

        If dateEnd < dtpStart.Value Then
            err.SetError(dtpEnd, "End Date Must After Start Date")
            e.Cancel = True
        Else
            err.SetError(dtpEnd, Nothing)
        End If

    End Sub

    Private Sub dtpCustDate_Validating(sender As Object, e As CancelEventArgs) Handles dtpCustDate.Validating

        Dim dateCustDate As Date = dtpCustDate.Value

        If dateCustDate <> "1/1/2020" Then
            If dateCustDate >= dtpEnd.Value Then
                err.SetError(dtpCustDate, "Customer Get Date Impossible After The Voucher Expired")
                e.Cancel = True
            ElseIf dateCustDate < dtpGenerated.Value Then
                err.SetError(dtpCustDate, "Customer Get Date Cannot Before The Voucher Generated Date")
                e.Cancel = True
            Else
                err.SetError(dtpCustDate, Nothing)
            End If
        Else
            err.SetError(dtpCustDate, Nothing)
        End If

    End Sub

    Private Sub dtpAppliedDate_Validating(sender As Object, e As CancelEventArgs) Handles dtpAppliedDate.Validating

        Dim dateApplied As Date = dtpAppliedDate.Value

        If dateApplied <> "1/1/2020" Then
            If dateApplied < dtpStart.Value Then
                err.SetError(dtpAppliedDate, "Customer cannot use the voucher before activate")
                e.Cancel = True
            ElseIf dateApplied > dtpEnd.Value Then
                err.SetError(dtpAppliedDate, "Customer cannot use the voucher after expired")
                e.Cancel = True
            Else
                err.SetError(dtpAppliedDate, Nothing)
            End If
        Else
            err.SetError(dtpAppliedDate, Nothing)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            Dim MySqlCommand As SqlCommand
            Dim strSql As String
            Dim intSuccess As Integer
            Dim strConfirmMessage As String = "Confirm edit voucher with ID " + strVoucherID + " ?"
            Dim result As DialogResult

            If dtpCustDate.Value = "1/1/2020" And dtpAppliedDate.Value <> "1/1/2020" Then
                MessageBox.Show("Warning: Impossible to modify voucher applied date without customer get date", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btnCancel_Click(Nothing, Nothing)
            Else

                Result = MessageBox.Show(strConfirmMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If result = DialogResult.Yes Then
                    If OpenConnection() = True Then

                        If dtpAppliedDate.Value <> "1/1/2020" Then
                            lblVoucherStatus.Text = "Used"
                        End If

                        strSql = "Update Voucher set discountAmount=@amount,voucherStartDate=@startDate,voucherExpiredDate=@expiredDate,minimumSpend=@minimumSpend,customerGetDate=@getDate,appliedDate=@appliedDate,voucherStatus=@status  Where voucherID=@voucherID"
                        MySqlCommand = New SqlCommand(strSql, conn)
                        MySqlCommand.Parameters.AddWithValue("@voucherID", strVoucherID)
                        MySqlCommand.Parameters.AddWithValue("@amount", Decimal.Parse(txtAmount.Text.Replace("RM", "")))
                        MySqlCommand.Parameters.AddWithValue("@startDate", dtpStart.Value)
                        MySqlCommand.Parameters.AddWithValue("@expiredDate", dtpEnd.Value)
                        MySqlCommand.Parameters.AddWithValue("@minimumSpend", Decimal.Parse(txtMinimum.Text.Replace("RM", "")))
                        MySqlCommand.Parameters.AddWithValue("@getDate", If(dtpCustDate.Value = "1/1/2020", System.DBNull.Value, dtpCustDate.Value))
                        MySqlCommand.Parameters.AddWithValue("@appliedDate", If(dtpAppliedDate.Value = "1/1/2020", System.DBNull.Value, dtpAppliedDate.Value))
                        MySqlCommand.Parameters.AddWithValue("@status", lblVoucherStatus.Text)
                        intSuccess = MySqlCommand.ExecuteNonQuery()

                        If intSuccess > 0 Then
                            MessageBox.Show("Voucher Information Update Successful.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Voucher Information Update Failed.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        CloseConnection()
                        FrmVoucherDetails_Load(Nothing, Nothing)
                    Else
                        MessageBox.Show("Somethings Wrong With the Database Connection, Please Contact Development Team", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        btnCancel_Click(Nothing, Nothing)
                    End If
                ElseIf result = DialogResult.No Then
                    MessageBox.Show("Actions Cancel!", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    btnCancel_Click(Nothing, Nothing)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error: Cannot retrieve voucher information" & vbCrLf & "Exception : " & ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try

    End Sub

    Private Sub FrmVoucherDetailsNUpdate_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FrmVoucherAll.FrmVoucherAll_Load(Nothing, Nothing)
    End Sub
End Class