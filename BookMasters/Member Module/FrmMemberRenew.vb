Imports System.Data.SqlClient

Public Class FrmMemberRenew

    Friend strMemberID As String
    Friend boolExpiredRenew As Boolean = False
    Private MySqlCommand As SqlCommand
    Private strSql As String
    Private dtrMember As SqlDataReader


    Private Sub FrmMemberRenew_Load(sender As Object, e As EventArgs) Handles Me.Load

        If boolExpiredRenew Or FormPayment.lblMember.Text <> "" Then
            'For payment renew
            cboMemberID.Items.Add(memberID)
            cboMemberID.SelectedItem = memberID
            cboMemberID.Enabled = False
        Else
            Try
                cboMemberID.Enabled = True
                ' CloseConnection()

                If OpenConnection() = True Then
                    cboMemberID.Items.Clear()

                    strSql = "Select memberID From Member"
                    MySqlCommand = New SqlCommand(strSql, conn)
                    dtrMember = MySqlCommand.ExecuteReader()

                    If dtrMember.HasRows Then
                        Do While dtrMember.Read()
                            cboMemberID.Items.Add(dtrMember.GetString(0))
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

                'if strMemberID <> "" mean process form member module, not payment module renew
                cboMemberID.SelectedItem = If(strMemberID <> "", strMemberID, memberID)

            Catch ex As Exception
                MessageBox.Show("Error: Cannot retrieve member information", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    'Return boolean for payment to add new product for renew
    Private Sub btnRenew_Click(sender As Object, e As EventArgs) Handles btnRenew.Click

        Dim intSuccess As Integer
        Dim strExpiredDate As String
        Dim strConfirmMessage As String = "Confirm renew member with ID " + strMemberID + " ?"
        Dim result As DialogResult = MessageBox.Show(strConfirmMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        Try

            If result = DialogResult.Yes Then
                'If the member is not yet expired, add 2 year from the date expired 
                'Else add 2 years from today
                If Date.Compare(getExpiredDate, Now) < 0 Then
                    strExpiredDate = Now.AddYears(2).ToString("yyyy-MM-dd")
                Else
                    strExpiredDate = CDate(getExpiredDate()).AddYears(2).ToString("yyyy-MM-dd")
                End If

                If OpenConnection() = True Then
                    strSql = "Update Member set memberExpiredDate=@expiredDate, memberStatus=@status Where memberID=@memberID"
                    MySqlCommand = New SqlCommand(strSql, conn)
                    MySqlCommand.Parameters.AddWithValue("@memberID", cboMemberID.SelectedItem)
                    MySqlCommand.Parameters.AddWithValue("@expiredDate", CDate(strExpiredDate))
                    MySqlCommand.Parameters.AddWithValue("@status", "Active")

                    intSuccess = MySqlCommand.ExecuteNonQuery()

                    If intSuccess > 0 Then

                        MessageBox.Show("Renew successfully" & Environment.NewLine & "New Expired Date is " & strExpiredDate, "Renew Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        productsList.Add(New ProductClass("MS0002", "RENEW MEMBERSHIP", 1, 10.0, 0, 0))
                        prodCount += 1
                        totalProdCount += 1
                        hasMember = True
                        renewMember = True
                        updateListBoxAndPrice(productsList, prodCount, totalProdCount)
                        CloseConnection()
                        Me.Close()
                        'bolCondition = True
                    Else
                        MessageBox.Show("Renew Failed.", "Renew Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        renewMember = False
                    End If
                Else
                    MessageBox.Show("Somethings Wrong With the Database Connection, Please Contact Development Team", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    renewMember = False
                End If

                CloseConnection()
                'FrmMemberAll.FrmMemberAll_Load(Nothing, Nothing)
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Actions Cancel!", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: Cannot renew member", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox(ex.ToString())
        End Try

    End Sub

    Private Function getExpiredDate() As String

        Dim dtrMember As SqlDataReader

        Try
            If OpenConnection() = True Then

                Dim strDate As String = ""
                strSql = "Select memberExpiredDate, memberStatus From Member where MemberID= @memberID"
                MySqlCommand = New SqlCommand(strSql, conn)
                MySqlCommand.Parameters.AddWithValue("@memberID", cboMemberID.SelectedItem)

                dtrMember = MySqlCommand.ExecuteReader()

                If dtrMember.HasRows Then
                    While dtrMember.Read()
                        strDate = dtrMember.GetValue(0).ToString()
                        memberPreviousStatus = dtrMember.GetValue(1).ToString()
                    End While
                    If strDate <> "" Then
                        memberExpiredDate = strDate
                    Else
                        MessageBox.Show("Cannot Get Member Information, Please Re-try", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        CloseConnection()
                        Me.Close()
                    End If
                End If
                CloseConnection()
                Return strDate
            Else
                MessageBox.Show("Somethings Wrong With the Database Connection, Please Contact Development Team", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: Cannot get expired date", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return ""
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'FrmMemberRedeemPoint.FrmMemberRedeemPoint_Load(Nothing, Nothing)
        Me.Close()
    End Sub

End Class