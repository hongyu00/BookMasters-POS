Imports System.Data.SqlClient

Public Class FrmVoucherValidation
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtVoucher.Text = ""
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click

        Try
            checkVoucherValidation()
            updateListBoxAndPrice(productsList, prodCount, totalProdCount)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Friend Sub checkVoucherValidation()

        Dim strStatus As String = ""
        Dim decMinimumSpend As Decimal = 0D

        conn.Open()
        Dim cmdVoucher As SqlCommand = New SqlCommand("SELECT * FROM Voucher WHERE voucherID = @voucherID", conn)
        cmdVoucher.Parameters.AddWithValue("@voucherID", txtVoucher.Text.ToUpper().Trim())
        Dim dtrVoucher As SqlDataReader = cmdVoucher.ExecuteReader()

        If dtrVoucher.HasRows Then
            While dtrVoucher.Read()

                'Pass to Payment
                voucherID = dtrVoucher.GetValue(0).ToString()
                voucherDiscountAmount = Decimal.Parse(dtrVoucher.GetValue(1))
                strStatus = dtrVoucher.GetValue(5).ToString()
                decMinimumSpend = Decimal.Parse(dtrVoucher.GetValue(4))
                'MessageBox.Show("Valid Voucher!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End While

            If strStatus = "Active" Then
                If decMinimumSpend > subtotal Then
                    MessageBox.Show("Minimum Requirements of " + decMinimumSpend.ToString("C") + " did not achieved!" + vbNewLine + vbNewLine + (decMinimumSpend - subtotal).ToString("C") + " left to use this voucher!", "Voucher Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    hasVoucher = True
                    discount += voucherDiscountAmount
                    MessageBox.Show("Voucher has been successfully added!", "Voucher Validation Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Voucher Is " + strStatus + "! Cannot be used!", "Voucher Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Voucher ID is invalid", "Voucher Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtVoucher.SelectAll()
        End If

        dtrVoucher.Close()
        conn.Close()
    End Sub
End Class