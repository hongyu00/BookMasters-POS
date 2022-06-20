Imports System.Data.SqlClient
Imports System.Globalization

Public Class FrmMemberRedeemPoint

    Dim intMemPoints As Integer
    Dim intConvertPointsToRM As Integer

    Private MySqlCommand As SqlCommand
    Private strSql As String
    Private dtrMember As SqlDataReader

    Friend Sub FrmMemberRedeemPoint_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not hasMember Then
            MessageBox.Show("You need to validate first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        Else
            Try
                If OpenConnection() = True Then
                    'If hasMember Then

                    strSql = "Select memberStatus,memberPoint From Member where memberID=@ID"
                    MySqlCommand = New SqlCommand(strSql, conn)
                    MySqlCommand.Parameters.AddWithValue("@ID", memberID)
                    dtrMember = MySqlCommand.ExecuteReader()

                    If dtrMember.HasRows Then
                        Do While dtrMember.Read()
                            lblStatus.Text = dtrMember.GetString(0)
                            intMemPoints = dtrMember.GetInt32(1)
                            lblPoints.Text = intMemPoints.ToString
                        Loop
                    Else
                        MessageBox.Show("Cannot Get Member Information, Please Re-try", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        CloseConnection()
                        Me.Close()
                    End If

                    'For testing only
                    'cboMemberID.Items.Add(memberID)
                    'cboMemberID.SelectedItem = memberID
                    'cboMemberID.Enabled = False
                    'intRedeemPoint = Math.Floor(intPoints / 100) * 100
                    lblMemberID.Text = memberID
                        intConvertPointsToRM = Math.Floor(intMemPoints / 100)
                        lblRedeemAmount.Text = intConvertPointsToRM.ToString("C", New CultureInfo("en-MY"))

                        CloseConnection()
                    'Else
                    'lblMemberID.SendToBack()
                    'lblMemberID.SendToBack()
                    'If OpenConnection() = True Then
                    '    strSql = "Select memberID From Member"
                    '    MySqlCommand = New SqlCommand(strSql, conn)
                    '    dtrMember = MySqlCommand.ExecuteReader()

                    '    If dtrMember.HasRows Then
                    '        Do While dtrMember.Read()
                    '            cboMemberID.Items.Add(dtrMember.GetString(0))
                    '        Loop
                    '    Else
                    '        MessageBox.Show("Cannot Get Member Information, Please Re-try", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    '        Me.Close()
                    '    End If
                    '    CloseConnection()
                    'Else
                    '    MessageBox.Show("Somethings Wrong With the Database Connection, Please Contact Development Team", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    '    Me.Close()
                    'End If
                    'cboMemberID.SelectedIndex = 0
                    'End If
                Else
                    MessageBox.Show("Somethings Wrong With the Database Connection, Please Contact Development Team", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                End If

            Catch ex As Exception
                MessageBox.Show("Error: Cannot retrieve member information", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    'Testing combo box 
    'Private Sub cboMemberID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMemberID.SelectedIndexChanged

    '    If OpenConnection() = True Then
    '        strSql = "Select memberStatus,memberPoint From Member where memberID=@ID"
    '        MySqlCommand = New SqlCommand(strSql, conn)
    '        MySqlCommand.Parameters.AddWithValue("@ID", cboMemberID.SelectedItem)
    '        dtrMember = MySqlCommand.ExecuteReader()

    '        If dtrMember.HasRows Then
    '            Do While dtrMember.Read()
    '                lblStatus.Text = dtrMember.GetString(0)
    '                intPoints = dtrMember.GetInt32(1)
    '                lblPoints.Text = intPoints.ToString
    '                intRedeemPoint = Math.Floor(intPoints / 100) * 100

    '                lblRedeemAmount.Text = Math.Floor(intPoints / 100).ToString("C", New CultureInfo("en-MY"))
    '            Loop
    '        Else
    '            MessageBox.Show("Cannot Get Member Information, Please Re-try", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        CloseConnection()
    '            
    '       Me.Close()
    '        End If

    '        CloseConnection()
    '    Else
    '        MessageBox.Show("Somethings Wrong With the Database Connection, Please Contact Development Team", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Me.Close()
    '    End If
    '
    'End Sub

    'If return 0 means cancel redeem, else return redeemPoints

    Private Sub btnRedeem_Click(sender As Object, e As EventArgs) Handles btnRedeem.Click
        If hasMember Then

            If lblStatus.Text = "Active" And memberPoints >= 100 Then

                Dim result As DialogResult
                result = MessageBox.Show("Redeem " & lblRedeemAmount.Text & "(" & intConvertPointsToRM & "points) to payment" & Environment.NewLine & "Are you confirm?", "Redeem Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If result = DialogResult.Yes Then
                    pointRedeem = intConvertPointsToRM * 100
                    hasRedeemPoint = True
                    memberPoints -= pointRedeem
                    MessageBox.Show("Redeem successfully, member points updated", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'updatePoints()
                    updateListBoxAndPrice(productsList, prodCount, totalProdCount)
                    'FrmMemberRedeemPoint_Load(Nothing, Nothing)
                Else
                    MessageBox.Show("Actions Cancel!", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

                'ElseIf intConvertPointsToRM < 100 Then
                'MessageBox.Show("You have no enough points to redeem", "Redeem Rejected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                'MessageBox.Show("You are not allowed to redeem points since your membership is expired", "Redeem Rejected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                MessageBox.Show("You have no enough points to redeem", "Redeem Rejected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            'Exit Sub
            Me.Close()
        End If

    End Sub

    'Useless after integrate
    'Private Sub updatePoints()
    '    Try
    '        Dim intSuccess As Integer

    '        If OpenConnection() = True Then
    '            strSql = "Update Member set memberPoint=@point Where memberID=@memberID"
    '            MySqlCommand = New SqlCommand(strSql, conn)
    '            MySqlCommand.Parameters.AddWithValue("@memberID", lblMemberID.Text)
    '            MySqlCommand.Parameters.AddWithValue("@point", intPoints - intRedeemPoint)

    '            intSuccess = MySqlCommand.ExecuteNonQuery()

    '            If intSuccess > 0 Then
    '                MessageBox.Show("Redeem successfully, member points updated", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Else
    '                MessageBox.Show("Points Update Failed.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End If
    '        Else
    '            MessageBox.Show("Somethings Wrong With the Database Connection, Please Contact Development Team", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If

    '        CloseConnection()

    '    Catch ex As Exception
    '        MessageBox.Show("Error: Cannot update member points", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
End Class