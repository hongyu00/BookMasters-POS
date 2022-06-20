Imports System.Data.SqlClient
Imports System.Globalization

Public Class FrmMemberReport

    Friend strMemberID As String
    Friend ds As DataSet = New ActivityDataSet
    Private strSql As String

    Private Sub FrmMemberReport_Load(sender As Object, e As EventArgs) Handles Me.Load

        lblMemberID.Text = strMemberID

        lblNoRecord.Visible = False
        dtpTo.Value = Now

        retrieveMemberInfo()
        retrieveRecord()
        calPointUsed(lblPointUsed)
        calPointUsed(lblPointRange)
    End Sub

    Private Sub retrieveMemberInfo()

        Dim dtrMember As SqlDataReader
        Dim MySqlCommand As SqlCommand

        Try
            If OpenConnection() = True Then

                'To get memberInformation
                strSql = "Select memberStatus, memberPoint, memberExpiredDate,memberDateOfJoined, memberName From Member Where memberID = @memberID"
                MySqlCommand = New SqlCommand(strSql, conn)
                MySqlCommand.Parameters.AddWithValue("@memberID", strMemberID)
                dtrMember = MySqlCommand.ExecuteReader()

                If dtrMember.HasRows Then
                    Do While dtrMember.Read()
                        lblStatus.Text = dtrMember.GetString(0)
                        lblPoints.Text = dtrMember.GetInt32(1).ToString
                        dtpExpired.Value = dtrMember.GetDateTime(2).ToString
                        dtpDOJ.Value = dtrMember.GetDateTime(3).ToString
                        lblName.Text = dtrMember.GetString(4)
                    Loop
                    dtrMember.Close()
                Else
                    MessageBox.Show("No member record found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    CloseConnection()
                    Me.Close()
                End If
                '----------------------------------------------------------------------------------------------------------------------------------------
                CloseConnection()
            Else
                MessageBox.Show("Somethings Wrong With the Database Connection, Please Contact Development Team", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: Cannot retrieve member information" & vbCrLf & ex.Message, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub retrieveRecord()

        Dim da As SqlDataAdapter

        Try
            If OpenConnection() = True Then

                'To get total transactions of redeem for member
                '----------------------------------------------------------------------------------------------------------------------------------------
                strSql = "Select paymentID,paymentDate,total, pointRedeem,pointRedeem/100 As amountRedeem From Payment Where memberID = '" & strMemberID & "'"

                da = New SqlDataAdapter(strSql, conn)
                ds.Tables("ActivityDataSetTable").Clear()
                ds.Clear()
                da.Fill(ds, "ActivityDataSetTable")

                If ds.Tables("ActivityDataSetTable").Rows.Count > 0 Then

                    With gvRecord
                        .DataSource = ds.Tables("ActivityDataSetTable")
                        .Columns(0).HeaderCell.Value = "Payment ID"
                        .Columns(1).HeaderCell.Value = "Payment Date"
                        .Columns(1).DefaultCellStyle.Format = "yyyy-MM-dd"
                        .Columns(2).HeaderCell.Value = "Total (RM)"
                        .Columns(2).DefaultCellStyle.Format = "C"
                        .Columns(2).DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-MY")
                        .Columns(3).HeaderCell.Value = "Point Redeem"
                        .Columns(4).HeaderCell.Value = "Amount Redeem (RM)"
                        .Columns(4).DefaultCellStyle.Format = "C"
                        .Columns(4).DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-MY")
                    End With
                    detectRange()

                Else
                    noRecord()
                End If
                '----------------------------------------------------------------------------------------------------------------------------------------
                CloseConnection()
            Else
                MessageBox.Show("Somethings Wrong With the Database Connection, Please Contact Development Team", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: Cannot retrieve member transaction record" & vbCrLf & ex.Message, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub noRecord()

        With gvRecord
            .DataSource = Nothing
            .Rows.Clear()
        End With

        With lblNoRecord
            .Visible = True
            .BringToFront()
        End With

        lblPointRange.Text = "0"

    End Sub

    Private Sub detectRange()

        Dim dateFrom As DateTime = dtpFrom.Value
        Dim dateTo As DateTime = dtpTo.Value
        Dim datePaymentDate As DateTime
        Dim boolContinue As Boolean = False

        Do
            For intIndex As Integer = 0 To gvRecord.RowCount - 1

                datePaymentDate = CDate(gvRecord.Rows(intIndex).Cells(1).Value)

                'Remove the row that not in the range
                If Not ((datePaymentDate >= dateFrom) And (datePaymentDate <= dateTo)) Then

                    gvRecord.Rows.Remove(gvRecord.Rows(intIndex))

                    If gvRecord.RowCount = 0 Then
                        noRecord()
                        Return
                    End If

                    boolContinue = True
                    Exit For
                Else
                    boolContinue = False
                End If

            Next
        Loop While boolContinue

        If gvRecord.RowCount > 0 Then
            lblNoRecord.Visible = False
        End If

        calPointUsed(lblPointRange)

    End Sub

    Private Sub calPointUsed(lblPoint As Label)

        Dim intPointUsed As Integer = 0

        For intIndex As Integer = 0 To gvRecord.RowCount - 1
            If Not IsDBNull(gvRecord.Rows(intIndex).Cells(3).Value) Then
                intPointUsed += CInt(gvRecord.Rows(intIndex).Cells(3).Value)
            End If
        Next

        lblPoint.Text = intPointUsed.ToString()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click, Me.Closed
        retrieveRecord()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        FrmMemberShowReport.ShowDialog()
        Me.Close()
    End Sub

End Class