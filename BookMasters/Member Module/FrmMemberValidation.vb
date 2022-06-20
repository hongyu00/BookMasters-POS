Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class FrmMemberValidation

    Dim strMemberStatus As String
    Dim strMemberExpiredDate As String

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMember.Clear()
        mskMobile.Clear()
    End Sub

    Private Sub btnCreateMember_Click(sender As Object, e As EventArgs) Handles btnCreateMember.Click
        FrmMemberAdd.ShowDialog()
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click

        Try
            Dim strID As String = txtMember.Text.ToUpper().Trim()
            Dim strMobile As String = mskMobile.Text.Trim()

            If strID <> "" And strMobile <> "-" Then
                MessageBox.Show("Cannot validate by both option, please select only one", "Duplicated option", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                btnClear_Click(Nothing, Nothing)
            ElseIf strID = "" And strMobile = "-" Then
                MessageBox.Show("Please enter either 1 option", "No Value Enter", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If strID <> "" Then
                    searchDB(strID, "memberID")
                ElseIf strMobile <> "-" Then
                    searchDB(strMobile, "memberContact")
                End If

                updateListBoxAndPrice(productsList, prodCount, totalProdCount)

            End If 'If either one not empty

        Catch ex As Exception
            MessageBox.Show("Error: Cannot search record", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub searchDB(strContent As String, strSearchItem As String)

        Try
            Dim strSql As String
            Dim dtrMember As SqlDataReader
            Dim MySqlCommand As SqlCommand

            If OpenConnection() = True Then

                strSql = "Select * From Member Where " & strSearchItem & "=@memberInfo"
                MySqlCommand = New SqlCommand(strSql, conn)
                MySqlCommand.Parameters.AddWithValue("@memberInfo", strContent)
                dtrMember = MySqlCommand.ExecuteReader()

                If dtrMember.HasRows Then
                    Do While dtrMember.Read()

                        memberID = dtrMember.GetString(0)
                        memberPoints = Integer.Parse(dtrMember.GetValue(3))
                        strMemberStatus = dtrMember.GetValue(7).ToString()
                        strMemberExpiredDate = dtrMember.GetValue(4).ToString()

                        If strMemberStatus = "Active" Then
                            hasMember = True
                            'disable the member validation button and assign value to lblMember
                            FormPayment.lblMember.Text = memberID
                            MessageBox.Show("Valid Member!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'Me.Close()
                        Else
                            Dim result As DialogResult = MessageBox.Show("Member " + memberID + " has already expired at " + strMemberExpiredDate + "!" + vbNewLine + vbNewLine + "Do the customer wish to renew member?", "Member Validation Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If result = DialogResult.Yes Then
                                CloseConnection()

                                With FrmMemberRenew
                                    .strMemberID = memberID
                                    .boolExpiredRenew = True
                                    .ShowDialog()
                                End With
                            ElseIf result = DialogResult.No Then
                                memberID = ""
                            End If
                        End If

                        Exit Do
                    Loop
                Else
                    MessageBox.Show("Cannot Found Record", "Member Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                CloseConnection()

            Else
                MessageBox.Show("Somethings Wrong With the Database Connection, Please Contact Development Team", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If 'If connection is open

            'updateListBoxAndPrice(productsList, prodCount, totalProdCount)

        Catch ex As Exception
            MessageBox.Show("Error: Cannot search record" & vbCrLf & ex.Message, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnClear_Click(Nothing, Nothing)
            Me.Close()
        End Try

    End Sub

    Private Sub mskMobile_Validating(sender As Object, e As CancelEventArgs) Handles mskMobile.Validating

        Dim strMobile As String = If(mskMobile.MaskCompleted, mskMobile.Text, "N")

        If strMobile = "N" And mskMobile.Text.Trim() <> "-" Then
            err.SetError(mskMobile, "Incomplete Mobile Number")
            e.Cancel = True
        Else
            err.SetError(mskMobile, Nothing)
        End If
    End Sub

End Class