Imports System.Text

Public Class FormCardDetails

    Friend cardType As String = ""
    Dim errorMsg As New StringBuilder()

    Private Sub FormCardDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotal.Text = total.ToString("C")
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Try
            lblError.Text = ""
            Dim result As Boolean = checkCardFormat()

            If result Then
                Me.Close()
                paymentEnd = True
                If paymentEnd = True And hasHoldTransaction = True And previousPaymentID = "" Then
                    hasHoldTransaction = False
                End If
                totalPaymentByCard += Math.Round(total, 2)
                'cardNo = txtName.Text.ToString()
                updatePayment_ProductOrdered_Product_MemberTable("CREDIT/DEBIT CARD")
                FormCardLoadingScreen.Show()

            Else
                lblError.Text = errorMsg.ToString()
                paymentEnd = False
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function checkCardFormat() As Boolean
        Dim hasError As Boolean = True
        Try
            errorMsg.Clear()
            Dim cardLength As String = If(txtCard.MaskCompleted, txtCard.Text, "")
            Dim name As String = txtName.Text.Trim()
            Dim check As String = txtCard.Text.Substring(0, 1)
            Dim month As String = ""
            Dim year As String = ""
            Dim cvv As String = If(txtCVV.MaskCompleted, txtCVV.Text, "")

            If name = "" Then
                errorMsg.AppendLine("- Name field cannot be empty")
                hasError = False
            End If

            If cardLength = "" Then
                errorMsg.AppendLine("- Invalid Card Length")
                hasError = False
            Else
                If cardType.Equals("Visa Card") Then
                    If check <> "4" Then
                        errorMsg.AppendLine("- Wrong Visa Card Format")
                        hasError = False
                    End If
                Else
                    If check <> "5" Then
                        errorMsg.AppendLine("- Wrong Master Card Format")
                        hasError = False
                    End If
                End If
            End If

            If cbMonth.SelectedIndex = -1 Or cbYear.SelectedIndex = -1 Then
                If cbMonth.SelectedIndex = -1 And cbYear.SelectedIndex = -1 Then
                    errorMsg.AppendLine("- Month and Year field cannot be empty")
                    hasError = False
                ElseIf cbMonth.SelectedIndex = -1 Then
                    errorMsg.AppendLine("- Month field cannot be empty")
                    hasError = False
                Else
                    errorMsg.AppendLine("- Years field cannot be empty")
                    hasError = False
                End If
            Else
                month = cbMonth.SelectedItem.ToString()
                year = cbYear.SelectedItem.ToString()
                If year = DateTime.Now.Year.ToString() And month < DateTime.Now.Month.ToString() Then
                    errorMsg.AppendLine("- Card has expired or wrong date selected")
                    hasError = False
                End If
            End If


            If cvv = "" Then
                errorMsg.AppendLine("- Invalid CVV Length")
                hasError = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            hasError = False
        End Try

        Return hasError
    End Function


    Private Sub rbVisa_CheckedChanged(sender As Object, e As EventArgs) Handles rbVisa.CheckedChanged, rbMaster.CheckedChanged

        If rbVisa.Checked Then
            cardType = "Visa Card"
        Else
            cardType = "Master Card"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        rbVisa.Checked = False
        rbMaster.Checked = False
        txtName.Text = ""
        txtCard.Text = ""
        txtCVV.Text = ""
        cbMonth.SelectedIndex = -1
        cbYear.SelectedIndex = -1
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class