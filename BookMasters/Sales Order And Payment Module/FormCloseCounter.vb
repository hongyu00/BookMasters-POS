Imports System.Data.SqlClient

Public Class FormCloseCounter

    Dim rm100Notes As Decimal
    Dim rm50Notes As Decimal
    Dim rm20Notes As Decimal
    Dim rm10Notes As Decimal
    Dim rm5Notes As Decimal
    Dim rm1Notes As Decimal
    Dim _50cent As Decimal
    Dim _20cent As Decimal
    Dim _10cent As Decimal
    Dim _5cent As Decimal


    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            Dim result As DialogResult = MessageBox.Show("Confirm Close Counter Amount?", "Close Counter Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                rm100Notes = Integer.Parse(txt100.Text) * 100D
                rm50Notes = Integer.Parse(txt50.Text) * 50D
                rm20Notes = Integer.Parse(txt20.Text) * 20D
                rm10Notes = Integer.Parse(txt10.Text) * 10D
                rm5Notes = Integer.Parse(txt5.Text) * 5D
                rm1Notes = Integer.Parse(txt1.Text) * 1D
                _50cent = Integer.Parse(txt50cent.Text) * 0.5D
                _20cent = Integer.Parse(txt20cent.Text) * 0.2D
                _10cent = Integer.Parse(txt10cent.Text) * 0.1D
                _5cent = Integer.Parse(txt5cent.Text) * 0.05D
                cashCounterAmount = rm100Notes + rm50Notes + rm20Notes + rm10Notes + rm5Notes +
                                    rm1Notes + _50cent + _20cent + _10cent + _5cent

                If totalPaymentByCash = 0D Then
                    Dim amount As Decimal = 0D
                    conn.Open()
                    Dim cmd As SqlCommand = New SqlCommand("SELECT paymentMethod, total FROM Payment WHERE paymentDate = @date", conn)
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.Date())
                    Dim readDate As SqlDataReader = cmd.ExecuteReader()
                    If readDate.HasRows Then
                        While readDate.Read()
                            If readDate.GetValue(0).ToString().Equals("CASH") Then
                                amount += Decimal.Parse(readDate.GetValue(1))
                            End If

                        End While
                    Else
                        conn.Close()
                        Exit Sub
                    End If
                    conn.Close()
                    totalPaymentByCash = amount
                End If

                variousAmount = cashCounterAmount - openCounterAmount - totalPaymentByCash
                If variousAmount = 0 Then
                    closeCounterStatus = "SAME AS EXPECTED AMOUNT"
                ElseIf variousAmount > 0 Then
                    closeCounterStatus = "OVER EXPECTED AMOUNT"
                Else
                    closeCounterStatus = "BELOW EXPECTED AMOUNT"
                End If
                hasCloseCounter = True
                Me.Close()
                FrmHome.FrmHome_Load(Nothing, Nothing)
                'FormCloseCounterResult.Show()

            End If
        Catch ex As Exception
            MessageBox.Show("Textbox only receive numeric values!", "Close Counter Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txt100.Text = ""
        txt50.Text = ""
        txt20.Text = ""
        txt10.Text = ""
        txt5.Text = ""
        txt1.Text = ""
        txt50cent.Text = ""
        txt20cent.Text = ""
        txt10cent.Text = ""
        txt5cent.Text = ""
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class