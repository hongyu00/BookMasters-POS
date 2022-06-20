Imports System.Data.SqlClient
Imports System.Globalization
Imports System.ComponentModel
Imports System.Text

Public Class FrmVoucherReport

    Friend ds As DataSet = New VoucherReportDataSet

    Private Sub FrmVoucherReportNew_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Load all the months
        cboMonth.DataSource = DateTimeFormatInfo.CurrentInfo.MonthNames

        cboMonth.SelectedIndex = CInt(Now.Month.ToString) - 1
        mskYear.Text = Now.Year.ToString()
    End Sub

    Private Sub btnAvailable_Click(sender As Object, e As EventArgs) Handles btnAvailable.Click, btnUsed.Click

        Dim strSql As String
        Dim da As SqlDataAdapter

        Dim strMonthSelected As String = DateTime.ParseExact(cboMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month.ToString()
        Dim strYearSelected As String = mskYear.Text

        Try
            If OpenConnection() = True Then

                'If Available Btn Cliked
                If CType(sender, Button) Is btnAvailable Then
                    strSql = "Select voucherID, discountAmount, voucherStartDate, voucherExpiredDate, minimumSpend, voucherStatus, staffID From voucher " &
                             "Where (Month(voucherStartDate) = '" & strMonthSelected & "' And YEAR(voucherStartDate) = '" & strYearSelected & "') Or " &
                             "(Month(voucherExpiredDate) = '" & strMonthSelected & "' And Year(voucherExpiredDate) = '" & strYearSelected & "')"

                    da = New SqlDataAdapter(strSql, conn)
                    ds.Clear()
                    da.Fill(ds, "VoucherAvailableReportDataSetTable")

                    If ds.Tables("VoucherAvailableReportDataSetTable").Rows.Count > 0 Then
                        With FrmVoucherAvailableShowReport
                            .VoucherReportViewer.RefreshReport()
                            .Show()
                        End With
                    Else
                        MessageBox.Show("No record found!", "No record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Else

                    strSql = "Select V.voucherID, P.paymentID, V.minimumSpend, V.discountAmount, V.appliedDate,P.paymentDate, P.total From voucher V, payment P Where " &
                    "(Month(V.appliedDate) = '" & strMonthSelected & "' AND Year(V.appliedDate) = '" & strYearSelected & "')" &
                    " AND V.voucherID = P.voucherID"

                    da = New SqlDataAdapter(strSql, conn)
                    ds.Clear()
                    da.Fill(ds, "VoucherUsedReportDataSetTable")

                    If ds.Tables("VoucherUsedReportDataSetTable").Rows.Count > 0 Then
                        With FrmVoucherUsedShowReport
                            .VoucherUsedReportViewer.RefreshReport()
                            .Show()
                        End With
                    Else
                        MessageBox.Show("No record found!", "No record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                End If

                CloseConnection()
            Else
                MessageBox.Show("Somethings Wrong With the Database Connection, Please Contact Development Team", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: Cannot retrieve voucher information" & vbCrLf & ex.Message, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub mskYear_Validating(sender As Object, e As CancelEventArgs) Handles mskYear.Validating

        'No need try catch because mask setting only allow integer
        Dim intYear As Integer = If(mskYear.MaskCompleted, CInt(mskYear.Text), -1)

        If intYear = -1 Then
            err.SetError(mskYear, "Cannot be empty")
            e.Cancel = True
        Else
            err.SetError(mskYear, Nothing)
        End If

    End Sub

End Class