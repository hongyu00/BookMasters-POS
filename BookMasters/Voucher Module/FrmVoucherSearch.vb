Imports System.Data.SqlClient
Imports System.Globalization

Public Class FrmVoucherSearch
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtID.Text = ""
        lblMessage.Visible = False
        clearGV()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub FrmVoucherSearch_Leave(sender As Object, e As EventArgs) Handles Me.Load
        btnClear_Click(Nothing, Nothing)
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

        Dim strID As String = txtID.Text.ToUpper().Trim()

        lblMessage.Visible = False

        Try
            Dim ds As DataSet = New DataSet()
            Dim da As SqlDataAdapter
            Dim strSql As String

            If OpenConnection() = True Then

                strSql = "Select voucherID, discountAmount, minimumSpend, voucherStatus From Voucher Where voucherID LIKE '%" & strID & "%'"
                da = New SqlDataAdapter(strSql, conn)
                ds.Clear()
                da.Fill(ds, "Voucher")

                If ds.Tables("Voucher").Rows.Count > 0 Then

                    With gvVoucher
                        .DataSource = ds.Tables(0)
                        .Columns(0).HeaderCell.Value = "Voucher ID"
                        .Columns(1).HeaderCell.Value = "Discount Amount"
                        .Columns(1).DefaultCellStyle.Format = "C"
                        .Columns(1).DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-MY")
                        .Columns(2).HeaderCell.Value = "Minimum Spend"
                        .Columns(2).DefaultCellStyle.Format = "C"
                        .Columns(2).DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-MY")
                        .Columns(3).HeaderCell.Value = "Status"
                    End With

                Else
                    'Cannot found record
                    clearGV()
                    lblMessage.Visible = True

                End If

                CloseConnection()

            Else
                MessageBox.Show("Somethings Wrong With the Database Connection, Please Contact Development Team", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If 'If connection is open

        Catch ex As Exception
            MessageBox.Show("Error: Cannot search record", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Sub clearGV()
        With gvVoucher
            .DataSource = Nothing
            .Rows.Clear()
        End With
    End Sub

    Private Sub gvVoucher_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvVoucher.CellDoubleClick
        'Only execute when the content double clicked
        '-1 is header double clicked so we should not response
        If e.RowIndex <> -1 Then
            With FrmVoucherDetailsNUpdate
                .strVoucherID = gvVoucher.Rows(e.RowIndex).Cells(0).Value
                .ShowDialog()
            End With

            txtID_TextChanged(Nothing, Nothing)
        End If
    End Sub
End Class