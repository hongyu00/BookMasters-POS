Imports System.Text

Public Class UserLogin

    Friend strCurrentLoginStaffID As String
    Friend strCurrentLoginStaffRole As String
    Friend strCurrentLoginStaffName As String
    Friend strCurrectLogID As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim db As New StaffDataContext()
        Dim s As Staff

        Dim strID As String = txtUserID.Text
        Dim strPassword As String = txtPassword.Text

        If strID = "" Or strPassword = "" Then
            MessageBox.Show("Please enter user ID and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            s = db.Staffs.FirstOrDefault(Function(o) o.staffID = strID)

            If IsNothing(s) Then
                MessageBox.Show("You have entered an invalid user ID or password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If s.staffStatus <> "Active" Then
                    MessageBox.Show("You have entered an invalid user ID or password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf strPassword <> s.staffPassword Then
                    MessageBox.Show("You have entered an invalid user ID or password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    strCurrentLoginStaffID = s.staffID
                    strCurrentLoginStaffRole = s.staffRole
                    strCurrentLoginStaffName = s.staffName

                    generateLoginRecord(s.staffID)

                    MessageBox.Show("Welcome to use this system, " & s.staffName & vbNewLine &
                                        "Your Login ID is : " & strCurrectLogID & vbNewLine &
                                        "Current Login Time is : " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    txtUserID.Text = ""
                    txtPassword.Text = ""

                    Me.Hide()
                    FrmMainMenu.Show()
                End If
            End If
        End If

    End Sub

    Private Function generateLoginRecord(strID As String)

        Dim logdb As New UserLogTimeDataContext()
        Dim loginRecord As New UserLogTime()

        Dim intDefaultCount As Integer = 1
        Dim intDefaultCount2 As Integer = 0
        Dim intDefaultCount3 As Integer = 0
        Dim strTodaysdate As String = DateTime.Now.ToString("yyyyMMdd")
        Dim strLogID = "LG" & strTodaysdate & intDefaultCount3 & intDefaultCount2 & intDefaultCount
        Dim isDuplicated = logdb.UserLogTimes.Any(Function(o) o.logID = strLogID)

        Dim CurrentDatetime As String

        If isDuplicated = False Then
            loginRecord.logID = strLogID
            CurrentDatetime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
            loginRecord.loginTime = CurrentDatetime
            loginRecord.logoutTime = CurrentDatetime
            loginRecord.staffID = strID

            strCurrectLogID = strLogID

            logdb.UserLogTimes.InsertOnSubmit(loginRecord)
            logdb.SubmitChanges()
        Else
            Do While isDuplicated = True
                intDefaultCount += 1
                If intDefaultCount > 9 Then
                    intDefaultCount = 1
                    intDefaultCount2 += 1
                End If
                If intDefaultCount2 > 9 Then
                    intDefaultCount2 = 1
                    intDefaultCount3 += 1
                End If
                strLogID = "LG" & strTodaysdate & intDefaultCount3 & intDefaultCount2 & intDefaultCount
                isDuplicated = logdb.UserLogTimes.Any(Function(o) o.logID = strLogID)
            Loop

            loginRecord.logID = strLogID
            CurrentDatetime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
            loginRecord.loginTime = CurrentDatetime
            loginRecord.logoutTime = CurrentDatetime
            loginRecord.staffID = strID

            strCurrectLogID = strLogID

            logdb.UserLogTimes.InsertOnSubmit(loginRecord)
            logdb.SubmitChanges()
        End If

    End Function

    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        txtUserID.Text = ""
        txtPassword.Text = ""
        Me.Hide()
        ForgotPassword.ShowDialog()
    End Sub

    Private Sub UserLogin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CenterToScreen()
    End Sub

    Private Sub ckbHidePassword_CheckedChanged(sender As Object, e As EventArgs) Handles ckbHidePassword.CheckedChanged

        If ckbHidePassword.Checked = True Then
            txtPassword.PasswordChar = "*"
        Else
            txtPassword.PasswordChar = ""
        End If

    End Sub

End Class


