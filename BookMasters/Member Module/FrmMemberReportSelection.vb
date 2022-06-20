Imports System.Data.SqlClient

Public Class FrmMemberReportSelection

    Private Sub FrmMemberReportSelection_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try
            Dim MySqlCommand As SqlCommand
            Dim strSql As String
            Dim dtrMember As SqlDataReader

            If OpenConnection() = True Then
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

            cboMemberID.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Error: Cannot retrieve member information", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        FrmMemberReport.strMemberID = cboMemberID.SelectedItem
        FrmMemberReport.ShowDialog()
    End Sub
End Class