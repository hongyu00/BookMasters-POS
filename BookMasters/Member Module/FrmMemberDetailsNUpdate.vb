Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class FrmMemberDetailsNUpdate

    Friend strMemberID As String

    Private Sub FrmMemberDetails_Load(sender As Object, e As EventArgs) Handles Me.Load

        'If there are no memberID means something wrong so we need to close the form
        If strMemberID = "" Then
            MessageBox.Show("Please select a member", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        Else
            'set MemberID
            lblMemberID.Text = strMemberID

            'Loop all country
            cboCountry.DataSource = GetCountry()

            'retrieve member information
            retrieveInfo()

            'View only for member information
            setEditability(False)
        End If

    End Sub

    Private Sub retrieveInfo()
        Try
            Dim strSql As String
            Dim MySqlCommand As SqlCommand
            Dim dtrMember As SqlDataReader

            'Load all the information for selected member
            If OpenConnection() = True Then
                strSql = "Select * From Member Where memberID = @memberID"
                MySqlCommand = New SqlCommand(strSql, conn)
                MySqlCommand.Parameters.AddWithValue("@memberID", strMemberID)
                dtrMember = MySqlCommand.ExecuteReader()

                If dtrMember.HasRows Then
                    Do While dtrMember.Read()
                        txtName.Text = dtrMember.GetString(1)
                        mskMobile.Text = dtrMember.GetString(2)
                        lblPoints.Text = dtrMember.GetInt32(3)
                        dtpExpired.Text = dtrMember.GetDateTime(4).ToString("yyyy-MM-dd")
                        dtpDOB.Value = dtrMember.GetDateTime(5).ToString("yyyy-MM-dd")
                        dtpDOJ.Value = dtrMember.GetDateTime(6).ToString("yyyy-MM-dd")
                        lblStatus.Text = dtrMember.GetString(7)
                        If Not IsDBNull(dtrMember(8)) Then
                            cboCountry.SelectedItem = dtrMember.GetString(8)
                        Else
                            cboCountry.SelectedIndex = -1
                        End If
                        If Not IsDBNull(dtrMember(9)) Then
                            txtEmail.Text = dtrMember.GetString(9)
                        Else
                            txtEmail.Text = "N/A"
                        End If
                        cboGender.SelectedIndex = If(dtrMember.GetString(10) = "F", 0, 1)
                        If Not IsDBNull(dtrMember(11)) Then
                            mskHome.Text = dtrMember.GetString(11)
                        Else
                            mskHome.Text = ""
                        End If
                        mskIC.Text = dtrMember.GetString(12)
                    Loop
                Else
                    MessageBox.Show("Cannot Get Member Information, Please Re-try", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    CloseConnection()
                    Me.Close()
                End If
                CloseConnection()
            Else
                MessageBox.Show("Somethings Wrong With the Database Connection, Please Contact Development Team", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: Cannot retrieve member information", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        'Set editable for member information
        setEditability(True)

    End Sub

    'Set editability for the the member information
    'flag; true = editable, false = view only
    Private Sub setEditability(flag As Boolean)

        txtName.Enabled = flag
        dtpDOB.Enabled = flag
        mskMobile.Enabled = flag
        mskHome.Enabled = flag
        txtEmail.Enabled = flag
        cboGender.Enabled = flag
        cboCountry.Enabled = flag
        mskIC.Enabled = flag

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

    Private Sub setBtnStyle(btn As Button, flag As Boolean)

        If flag = False Then
            With btn
                .BackColor = Color.FromArgb(204, 204, 204)
                .Enabled = False
            End With
        Else
            With btn
                .BackColor = Color.FromArgb(22, 99, 255)
                .Enabled = True
            End With
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        setEditability(False)
        'Change back to default value
        retrieveInfo()

    End Sub

    Private Sub txtName_Validating(sender As Object, e As CancelEventArgs) Handles txtName.Validating

        Dim strName As String = txtName.Text.Trim()

        If strName = "" Then
            err.SetError(txtName, "Cannot be empty")
            e.Cancel = True
        ElseIf containsSpecialChars(strName) Or Regex.IsMatch(strName, "\d") Then
            err.SetError(txtName, "Invalid Name (No number and special character)")
            e.Cancel = True
        Else
            err.SetError(txtName, Nothing)
            txtName.Text = strName.ToUpper()
        End If

    End Sub

    Private Sub dtpDOB_Validating(sender As Object, e As CancelEventArgs) Handles dtpDOB.Validating

        Dim dtpNow As DateTime = DateTime.Today()
        Dim dtpNewDOB As DateTime = dtpDOB.Value
        Dim intCompareResult As Integer = DateTime.Compare(dtpNewDOB, dtpNow)

        If intCompareResult >= 0 Then
            err.SetError(dtpDOB, "Date of birth cannot exceed today's date")
            e.Cancel = True
        Else
            err.SetError(dtpDOB, Nothing)
        End If

    End Sub

    Private Sub mskMobile_Validating(sender As Object, e As CancelEventArgs) Handles mskMobile.Validating

        Dim strMobile As String = If(mskMobile.MaskCompleted, mskMobile.Text, "")

        If strMobile = "" Then
            err.SetError(mskMobile, "Invalid Mobile Number")
            e.Cancel = True
        ElseIf Not strMobile.StartsWith("01") Then
            err.SetError(mskMobile, "First 2 digits must start with 01")
            e.Cancel = True
        Else
            err.SetError(mskMobile, Nothing)
        End If

    End Sub

    Private Sub mskHome_Validating(sender As Object, e As CancelEventArgs) Handles mskHome.Validating

        Dim strHome As String = If(mskHome.MaskCompleted, mskHome.Text, "")
        Dim bolEmpty As Boolean = If(mskHome.Text.Replace(" ", "").Length > 1, False, True)

        'If replace with "" = 1 means empty (- consider empty)
        If strHome = "" And Not bolEmpty Then
            err.SetError(mskHome, "Home No can be empty or must follow fill all digits")
            e.Cancel = True
        ElseIf Not strHome.StartsWith("0") And Not bolEmpty Then
            err.SetError(mskHome, "First digit must start with 0")
            e.Cancel = True
        Else
            err.SetError(mskHome, Nothing)
        End If

    End Sub

    Private Sub txtEmail_Validating(sender As Object, e As CancelEventArgs) Handles txtEmail.Validating

        Dim strEmail As String = txtEmail.Text.Trim()

        If strEmail <> "" And strEmail <> "N/A" And Not Regex.IsMatch(strEmail, "^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$") Then
            err.SetError(txtEmail, "Invalid Email")
            e.Cancel = True
        Else
            err.SetError(txtEmail, Nothing)
        End If

    End Sub

    Private Sub mskIC_Validating(sender As Object, e As CancelEventArgs) Handles mskIC.Validating

        Dim strIC As String = If(mskIC.MaskCompleted, mskIC.Text, "")

        If strIC = "" Then
            err.SetError(mskIC, "Cannot be empty")
            e.Cancel = True
        Else
            err.SetError(mskIC, Nothing)
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            Dim MySqlCommand As SqlCommand
            Dim strSql As String
            Dim intSuccess As Integer
            Dim strConfirmMessage As String = "Confirm edit member with ID " + strMemberID + " ?"

            Dim result As DialogResult = MessageBox.Show(strConfirmMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.Yes Then

                If OpenConnection() = True Then
                    strSql = "Update Member set memberName=@name,memberContact=@contact,memberBirthDay=@birthday,memberNationality=@nationality,memberEmail=@email,memberGender=@gender,memberHomeNo=@homeNo, memberIC=@memberIC Where memberID=@memberID"
                    MySqlCommand = New SqlCommand(strSql, conn)
                    MySqlCommand.Parameters.AddWithValue("@memberID", strMemberID)
                    MySqlCommand.Parameters.AddWithValue("@name", txtName.Text)
                    MySqlCommand.Parameters.AddWithValue("@contact", mskMobile.Text)
                    MySqlCommand.Parameters.AddWithValue("@birthday", CDate(dtpDOB.Text).ToString("yyyy-MM-dd"))
                    MySqlCommand.Parameters.AddWithValue("@nationality", If(cboCountry.SelectedIndex <> -1, cboCountry.SelectedItem.ToString, System.DBNull.Value))
                    MySqlCommand.Parameters.AddWithValue("@email", If(txtEmail.Text = "N/A" Or txtEmail.Text = "", System.DBNull.Value, txtEmail.Text))
                    MySqlCommand.Parameters.AddWithValue("@gender", If(cboGender.SelectedItem.ToString() = "Female", "F", "M"))
                    MySqlCommand.Parameters.AddWithValue("@homeNo", If(mskHome.Text.Trim() = "-", System.DBNull.Value, mskHome.Text))
                    MySqlCommand.Parameters.AddWithValue("@memberIC", mskIC.Text)
                    intSuccess = MySqlCommand.ExecuteNonQuery()

                    If intSuccess > 0 Then
                        MessageBox.Show("Member Information Update Successful.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Member Information Update Failed.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Somethings Wrong With the Database Connection, Please Contact Development Team", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    btnCancel_Click(Nothing, Nothing)
                End If

                CloseConnection()
                FrmMemberDetails_Load(Nothing, Nothing)

            ElseIf result = DialogResult.No Then
                MessageBox.Show("Actions Cancel!", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                btnCancel_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: Cannot update member information [Contact Number and IC cannot duplicated]", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmMemberDetailsNUpdate_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FrmMemberAll.FrmMemberAll_Load(Nothing, Nothing)
    End Sub

End Class