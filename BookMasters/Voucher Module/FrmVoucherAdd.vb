Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class FrmVoucherAdd
    Private Sub FrmVoucherAdd_Load(sender As Object, e As EventArgs) Handles Me.Load

        'load voucher type into combo box
        loadCbo()

        'Set default type to promotion
        cboType.SelectedIndex = 1
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        clearInput()
        Me.Close()
    End Sub

    Private Sub clearInput()
        txtAmount.Text = ""
        txtMinimum.Text = ""
        dtpStart.Value = DateTime.Today()
        dtpEnd.Value = DateTime.Today()
        cboType.SelectedIndex = 1

        err.SetError(txtAmount, Nothing)
        err.SetError(txtMinimum, Nothing)
        err.SetError(dtpStart, Nothing)
        err.SetError(dtpEnd, Nothing)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearInput()
    End Sub

    Private Sub loadCbo()
        Try
            Dim strSql As String
            Dim MySqlCommand As SqlCommand
            Dim dtrVoucher As SqlDataReader

            If OpenConnection() = True Then
                strSql = "Select DISTINCT voucherType From Voucher"
                MySqlCommand = New SqlCommand(strSql, conn)
                dtrVoucher = MySqlCommand.ExecuteReader()

                If dtrVoucher.HasRows Then
                    cboType.Items.Clear()

                    Do While dtrVoucher.Read()
                        cboType.Items.Add(dtrVoucher.GetString(0))
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

    Private Sub txtAmount_Validating(sender As Object, e As CancelEventArgs) Handles txtAmount.Validating
        validateAmount()
    End Sub

    Private Sub txtMinimum_Validating(sender As Object, e As CancelEventArgs) Handles txtMinimum.Validating
        validateMinimum()
    End Sub

    Private Sub dtpStart_Validating(sender As Object, e As CancelEventArgs) Handles dtpStart.Validating
        validateStartDate()
    End Sub

    Private Sub dtpEnd_Validating(sender As Object, e As CancelEventArgs) Handles dtpEnd.Validating
        validateEndDate()
    End Sub

    Private Function validateAmount() As Boolean

        Dim boolStatus As Boolean = True

        Try
            Dim decDiscount As Decimal = Decimal.Parse(txtAmount.Text)

            If decDiscount <= 0D Then
                err.SetError(txtAmount, "Cannot be equal or less than 0")
                boolStatus = False
            Else
                err.SetError(txtAmount, Nothing)
                txtAmount.Text = decDiscount.ToString("0.00")
            End If

        Catch ex As Exception

            'If contain special character, empty, and aplhabet will fall into exception

            If containsSpecialChars(txtAmount.Text) Then
                err.SetError(txtAmount, "Cannot contains special characters")
                boolStatus = False
            Else
                err.SetError(txtAmount, "Must not be empty and only accept digits")
                boolStatus = False
            End If

            txtAmount.SelectAll()

        End Try

        Return boolStatus

    End Function

    Private Function validateMinimum() As Boolean

        Dim boolStatus As Boolean = True

        Try
            Dim decMinimum As Decimal = Decimal.Parse(txtMinimum.Text)

            If decMinimum < 0D Then
                err.SetError(txtMinimum, "Cannot be equal or less than 0")
                boolStatus = False
            Else
                err.SetError(txtMinimum, Nothing)
                txtMinimum.Text = decMinimum.ToString("0.00")
            End If

        Catch ex As Exception

            'If contain special character, empty, and aplhabet will fall into exception
            If containsSpecialChars(txtMinimum.Text) Then
                err.SetError(txtMinimum, "Cannot contains special characters")
                boolStatus = False
            Else
                err.SetError(txtMinimum, "Must not be empty and only accept digits")
                boolStatus = False
            End If

            txtMinimum.SelectAll()
        End Try

        Return boolStatus

    End Function

    Private Function validateStartDate() As Boolean

        Dim boolStatus As Boolean = True

        Dim dateStart As Date = dtpStart.Value

        If dateStart > dtpEnd.Value Then
            err.SetError(dtpStart, "Start Date Must Earlier Than End Date")
            boolStatus = False
        Else
            err.SetError(dtpStart, Nothing)
        End If

        Return boolStatus

    End Function

    Private Function validateEndDate() As Boolean

        Dim boolStatus As Boolean = True
        Dim dateEnd As Date = dtpEnd.Value

        If dateEnd < dtpStart.Value Then
            err.SetError(dtpEnd, "End Date Must After Start Date")
            boolStatus = False
        Else
            err.SetError(dtpEnd, Nothing)
        End If

        Return boolStatus

    End Function

    Private Function validateForm() As Boolean

        Dim boolValidateAll As Boolean = False
        Dim boolValidateAmount As Boolean = validateAmount()
        Dim boolValidateMinimum As Boolean = validateMinimum()
        Dim boolValidateStartDate As Boolean = validateStartDate()
        Dim boolValidateEndDate As Boolean = validateEndDate()

        If boolValidateAmount And boolValidateMinimum And boolValidateStartDate And boolValidateEndDate Then
            boolValidateAll = True
        End If

        Return boolValidateAll
    End Function

    Private Function generateVoucherID(strType As String) As String

        Try

            Dim strSql As String
            Dim MySqlCommand As SqlCommand
            Dim intCount As Integer

            If OpenConnection() = True Then
                strSql = "Select Count(*) From Voucher Where voucherID LIKE '" & strType & "%'"
                MySqlCommand = New SqlCommand(strSql, conn)
                intCount = MySqlCommand.ExecuteScalar()

                If intCount > 0 Then
                    CloseConnection()
                    intCount += 1
                    Return intCount.ToString(strType & "0000")
                Else
                    MessageBox.Show("Cannot Get Voucher Count, Please Re-try", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    CloseConnection()
                    Me.Close()
                End If
            Else
                MessageBox.Show("Cannot Generate New Voucher ID", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: Cannot generate new voucher ID", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return ""

    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If validateForm() Then

                Dim MySqlCommand As SqlCommand
                Dim strSql As String
                Dim intSuccess As Integer
                Dim strType As String = If(cboType.SelectedItem = "Promotion", "PM", "BD")
                Dim voucherID As String = generateVoucherID(strType)
                Dim strConfirmMessage As String = "Confirm add new voucher with ID " + voucherID + " ?"

                Dim result As DialogResult = MessageBox.Show(strConfirmMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If result = DialogResult.Yes Then
                    If OpenConnection() = True Then
                        strSql = "Insert into Voucher Values(@voucherID, @discountAmount, @startDate, @endDate, @minimumSpend, @status, @type, @getDate, @appliedDate, @generatedDate, @staffID)"
                        MySqlCommand = New SqlCommand(strSql, conn)
                        MySqlCommand.Parameters.AddWithValue("@voucherID", voucherID)
                        MySqlCommand.Parameters.AddWithValue("@discountAmount", CDec(txtAmount.Text))
                        MySqlCommand.Parameters.AddWithValue("@startDate", dtpStart.Value)
                        MySqlCommand.Parameters.AddWithValue("@endDate", dtpEnd.Value)
                        MySqlCommand.Parameters.AddWithValue("@minimumSpend", CDec(txtMinimum.Text))
                        MySqlCommand.Parameters.AddWithValue("@status", "New")
                        MySqlCommand.Parameters.AddWithValue("@type", cboType.SelectedItem)
                        MySqlCommand.Parameters.AddWithValue("@getDate", System.DBNull.Value)
                        MySqlCommand.Parameters.AddWithValue("@appliedDate", System.DBNull.Value)
                        MySqlCommand.Parameters.AddWithValue("@generatedDate", Now)
                        MySqlCommand.Parameters.AddWithValue("@staffID", UserLogin.strCurrentLoginStaffID)
                        intSuccess = MySqlCommand.ExecuteNonQuery()

                        If intSuccess > 0 Then
                            MessageBox.Show("Voucher Generated." & vbCrLf & "New Voucher's ID is " & voucherID, "Add Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Voucher Generated Failed.", "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Somethings Wrong With the Database Connection, Please Contact Development Team", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                    CloseConnection()
                    btnCancel_Click(Nothing, Nothing)
                ElseIf result = DialogResult.No Then
                    MessageBox.Show("Actions Cancel!", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            Else 'if some field is not valid
                    MessageBox.Show("You must fill in all the neccessary field with correct format only can add record.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

        Catch ex As Exception
            MessageBox.Show("Error: Cannot generate new voucher ID" & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmVoucherAdd_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FrmVoucherAll.FrmVoucherAll_Load(Nothing, Nothing)
    End Sub
End Class