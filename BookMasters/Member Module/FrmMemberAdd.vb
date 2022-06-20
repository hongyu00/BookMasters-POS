Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class FrmMemberAdd

    Private Sub FrmMemberAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set default gender to female
        cboGender.SelectedIndex = 0

        'Loop all country
        cboCountry.DataSource = GetCountry()
        'set default country to Malaysia
        cboCountry.SelectedIndex = cboCountry.FindString("Malaysia")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        clearInput()
        Me.Close()
    End Sub

    Private Sub clearInput()
        txtName.Text = ""
        dtpDOB.Value = DateTime.Today()
        mskMobile.Text = ""
        mskHome.Text = ""
        cboGender.SelectedIndex = 0
        txtEmail.Text = ""
        mskIC.Text = ""
        cboCountry.SelectedIndex = -1

        err.SetError(txtName, Nothing)
        err.SetError(mskIC, Nothing)
        err.SetError(mskHome, Nothing)
        err.SetError(mskMobile, Nothing)
        err.SetError(txtEmail, Nothing)
        err.SetError(dtpDOB, Nothing)

    End Sub

    Private Sub txtName_Validating(sender As Object, e As CancelEventArgs) Handles txtName.Validating
        validateName()
    End Sub

    Private Sub dtpDOB_Validating(sender As Object, e As CancelEventArgs) Handles dtpDOB.Validating
        validateDOB()
    End Sub

    Private Sub mskMobile_Validating(sender As Object, e As CancelEventArgs) Handles mskMobile.Validating
        validateMobile()
    End Sub

    Private Sub mskHome_Validating(sender As Object, e As CancelEventArgs) Handles mskHome.Validating
        validateHome()
    End Sub

    Private Sub txtEmail_Validating(sender As Object, e As CancelEventArgs) Handles txtEmail.Validating
        validateEmail()
    End Sub

    Private Sub mskIC_Validating(sender As Object, e As CancelEventArgs) Handles mskIC.Validating
        validateIC()
    End Sub

    Private Function validateName() As Boolean

        Dim boolStatus As Boolean = True
        Dim strName As String = txtName.Text.Trim()

        If strName = "" Then
            err.SetError(txtName, "Cannot be empty")
            boolStatus = False
        ElseIf containsSpecialChars(strName) Or Regex.IsMatch(strName, "\d") Then
            err.SetError(txtName, "Invalid Name (No number and special character)")
            boolStatus = False
        Else
            err.SetError(txtName, Nothing)
            txtName.Text = strName.ToUpper()
        End If

        Return boolStatus

    End Function

    Private Function validateDOB() As Boolean

        Dim boolStatus As Boolean = True
        Dim dtpNow As DateTime = DateTime.Today()
        Dim dtpNewDOB As DateTime = dtpDOB.Value
        Dim intCompareResult As Integer = DateTime.Compare(dtpNewDOB, dtpNow)

        If intCompareResult >= 0 Then
            err.SetError(dtpDOB, "Date of birth cannot exceed today's date")
            boolStatus = False
        Else
            err.SetError(dtpDOB, Nothing)
        End If

        Return boolStatus

    End Function

    Private Function validateMobile() As Boolean

        Dim boolStatus As Boolean = True
        Dim strMobile As String = If(mskMobile.MaskCompleted, mskMobile.Text, "")

        If strMobile = "" Then
            err.SetError(mskMobile, "Invalid Mobile Number")
            boolStatus = False
        ElseIf Not strMobile.StartsWith("01") Then
            err.SetError(mskMobile, "First 2 digits must start with 01")
            boolStatus = False
        Else
            err.SetError(mskMobile, Nothing)
        End If

        Return boolStatus

    End Function

    Private Function validateHome() As Boolean

        Dim boolStatus As Boolean = True
        Dim strHome As String = If(mskHome.MaskCompleted, mskHome.Text, "")
        Dim boolEmpty As Boolean = If(mskHome.Text.Replace(" ", "").Length > 1, False, True)

        'If replace with "" = 1 means empty (- consider empty)
        If strHome = "" And Not boolEmpty Then
            err.SetError(mskHome, "Home No can be empty or must follow fill all digits")
            boolStatus = False
        ElseIf Not strHome.StartsWith("0") And Not boolEmpty Then
            err.SetError(mskHome, "First digit must start with 0")
            boolStatus = False
        Else
            err.SetError(mskHome, Nothing)
        End If

        Return boolStatus

    End Function

    Private Function validateEmail() As Boolean

        Dim boolStatus As Boolean = True
        Dim strEmail As String = txtEmail.Text.Trim()

        If strEmail <> "" And strEmail <> "N/A" And Not Regex.IsMatch(strEmail, "^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$") Then
            err.SetError(txtEmail, "Invalid Email")
            boolStatus = False
        Else
            err.SetError(txtEmail, Nothing)
        End If

        Return boolStatus

    End Function

    Private Function validateIC() As Boolean

        Dim boolStatus As Boolean = True
        Dim strIC As String = If(mskIC.MaskCompleted, mskIC.Text, "")

        If strIC = "" Then
            err.SetError(mskIC, "Cannot be empty")
            boolStatus = False
        Else
            err.SetError(mskIC, Nothing)
        End If

        Return boolStatus

    End Function

    Private Function validateForm() As Boolean

        Dim boolValidateAll As Boolean = False
        Dim boolValidateIC As Boolean = validateIC()
        Dim boolValidateEmail As Boolean = validateEmail()
        Dim boolValidateHome As Boolean = validateHome()
        Dim boolValidateMobile As Boolean = validateMobile()
        Dim boolValidateDOB As Boolean = validateDOB()
        Dim boolValidateName As Boolean = validateName()

        If boolValidateIC And boolValidateEmail And boolValidateHome And boolValidateMobile And boolValidateDOB And boolValidateName Then
            boolValidateAll = True
        End If

        Return boolValidateAll
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try
            If validateForm() Then

                Dim MySqlCommand As SqlCommand
                Dim strSql As String
                Dim intSuccess As Integer
                Dim strMemberID As String = generateMemberID()
                Dim strConfirmMessage As String = "Confirm add new member " + txtName.Text + " with ID " + strMemberID + " ?"

                Dim result As DialogResult = MessageBox.Show(strConfirmMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If result = DialogResult.Yes Then

                    If OpenConnection() = True Then
                        strSql = "Insert into Member Values(@memberID, @name, @contact, @point, @expiredDate, @birthday, @dateOfJoined, @status, @nationality, @email, @gender, @homeNo, @memberIC)"
                        MySqlCommand = New SqlCommand(strSql, conn)
                        MySqlCommand.Parameters.AddWithValue("@memberID", strMemberID)
                        MySqlCommand.Parameters.AddWithValue("@name", txtName.Text)
                        MySqlCommand.Parameters.AddWithValue("@contact", mskMobile.Text)
                        MySqlCommand.Parameters.AddWithValue("@point", 0)
                        MySqlCommand.Parameters.AddWithValue("@expiredDate", CDate(Now.AddYears(2).ToString("yyyy-MM-dd")))
                        MySqlCommand.Parameters.AddWithValue("@birthday", CDate(dtpDOB.Text).ToString("yyyy-MM-dd"))
                        MySqlCommand.Parameters.AddWithValue("@dateOfJoined", CDate(Now.ToString("yyyy-MM-dd")))
                        MySqlCommand.Parameters.AddWithValue("@status", "Active")
                        MySqlCommand.Parameters.AddWithValue("@nationality", If(cboCountry.SelectedIndex <> -1, cboCountry.SelectedItem.ToString, System.DBNull.Value))
                        MySqlCommand.Parameters.AddWithValue("@email", If(txtEmail.Text = "", System.DBNull.Value, txtEmail.Text))
                        MySqlCommand.Parameters.AddWithValue("@gender", If(cboGender.SelectedItem.ToString() = "Female", "F", "M"))
                        MySqlCommand.Parameters.AddWithValue("@homeNo", If(mskHome.Text.Trim() = "-", System.DBNull.Value, mskHome.Text))
                        MySqlCommand.Parameters.AddWithValue("@memberIC", mskIC.Text)
                        intSuccess = MySqlCommand.ExecuteNonQuery()

                        If intSuccess > 0 Then

                            If isOnTransaction Then
                                productsList.Add(New ProductClass("MS0001", "NEW MEMBERSHIP", 1, 20.0, 0, 0))
                                prodCount += 1
                                totalProdCount += 1
                                hasMember = True
                                isNewMember = True
                                PaymentCommon.memberID = strMemberID
                            End If

                            updateListBoxAndPrice(productsList, prodCount, totalProdCount)

                            MessageBox.Show("Member Added." & vbCrLf & "New Member's ID is " & strMemberID, "Register Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Member Register Failed.", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Somethings Wrong With the Database Connection, Please Contact Development Team", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                    CloseConnection()
                    btnExit_Click(Nothing, Nothing)
                    FrmMemberAll.FrmMemberAll_Load(Nothing, Nothing)

                ElseIf result = DialogResult.No Then
                    MessageBox.Show("Actions Cancel!", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            Else 'if some field is not valid
                MessageBox.Show("You must fill in all the neccessary field with correct format only can add record.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: Cannot add new record [Contact Number and IC cannot duplicated] or empty", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try

    End Sub

    Private Function generateMemberID() As String

        Try

            Dim strSql As String
            Dim MySqlCommand As SqlCommand
            Dim intCount As Integer

            If OpenConnection() = True Then
                strSql = "Select Count(*) From Member"
                MySqlCommand = New SqlCommand(strSql, conn)
                intCount = MySqlCommand.ExecuteScalar()

                If intCount > 0 Then
                    CloseConnection()
                    intCount += 1
                    Return intCount.ToString("MB0000")
                Else
                    MessageBox.Show("Cannot Get Member Count, Please Re-try", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Me.Close()
                End If
            Else
                MessageBox.Show("Cannot Generate New Member ID", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: Cannot generate new member ID", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return ""

    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearInput()
    End Sub

End Class