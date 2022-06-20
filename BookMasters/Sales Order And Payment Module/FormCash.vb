Imports System.Text
Imports System.Text.RegularExpressions

Public Class FormCash
    Dim change As Decimal = 0D
    Dim cashReceived As Decimal = 0D
    Private Sub FormCash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strCash = ""
        lblTotal.Text = FormPayment.lblTotal.Text
        lblID.Text = paymentID
    End Sub

#Region "keypad function"
    Private strCash As String = ""

    Private Sub editLabel(value As Integer)

        If strCash = "" And value = 0 Then
            Exit Sub
        End If

        Dim checkDecimal As Integer = strCash.Length - strCash.IndexOf(".")
        If strCash.Contains(".") And checkDecimal > 2 Then
            Exit Sub
        End If

        strCash += value.ToString()
        lblDisplay.Text = strCash

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        editLabel(Integer.Parse(Button1.Text))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        editLabel(Integer.Parse(Button2.Text))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        editLabel(Integer.Parse(Button3.Text))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        editLabel(Integer.Parse(Button4.Text))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        editLabel(Integer.Parse(Button5.Text))
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        editLabel(Integer.Parse(Button6.Text))
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        editLabel(Integer.Parse(Button7.Text))
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        editLabel(Integer.Parse(Button8.Text))
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        editLabel(Integer.Parse(Button9.Text))
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        editLabel(Integer.Parse(Button0.Text))
    End Sub
    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        If strCash.Contains(".") = False Then
            strCash += "."
        End If
        lblDisplay.Text = strCash
    End Sub
    Private Sub btnBackspace_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
        If strCash.Length <> 0 Then
            strCash = strCash.Substring(0, strCash.Length - 1)
            lblDisplay.Text = strCash
        Else
            Exit Sub
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        strCash = ""
        lblDisplay.Text = strCash
    End Sub
#End Region

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If paymentEnd Then
            If hasHoldTransaction Then
                getHoldPayment()

            Else
                generatePaymentID()
            End If
        End If

        Me.Close()

    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Try
            change = Decimal.Parse(strCash) - Math.Round(total, 2)
            cashReceived = Decimal.Parse(strCash)
            lblAmountReceived.Text = cashReceived.ToString("C")
            lblChange.Text = change.ToString("C")
            If change >= 0 Then
                btnPrint.Enabled = True
                lblInfo.Text = ""
                totalPaymentByCash += Math.Round(total, 2)
                paymentEnd = True
                If paymentEnd = True And hasHoldTransaction = True And previousPaymentID = "" Then
                    hasHoldTransaction = False
                    holdProductsList.Clear()
                End If
                btnAccept.Enabled = False
                updatePayment_ProductOrdered_Product_MemberTable("CASH")
            Else
                lblInfo.Text = "Insufficient Amount!"
                btnPrint.Enabled = False
                paymentEnd = False
            End If
            strCash = ""
        Catch ex As Exception
            MessageBox.Show("Please enter a valid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblDisplay.Text = 0
        End Try


    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        printReceiptPreview.Document = printReceipt
        printReceiptPreview.ShowDialog(Me)
        btnClose_Click(Nothing, Nothing)
    End Sub


    Private Sub printReceipt_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printReceipt.PrintPage
        'fonts
        Dim fontHeader As New Font("Century Gothic", 14)
        Dim fontBody As New Font("Century Gothic", 10)
        Dim FontAddBody As New Font("Century Gothic", 9)
        'header

        Dim strHeader As String = String.Format("{5,58} {0} " & vbNewLine & " {1}" & vbNewLine & "{5,25} {2}" & vbNewLine & "{5,55} {3}" & vbNewLine & "{5,57} {4}",
                                                "BOOK MASTER", "Ground Floor, Tan Sri Khaw Kai Boh Building, Kampus Utama, Jalan Genting Kelang,",
                                                "53300 Kuala Lumpur, Wilayah Persekutuan Kuala Lumpur", "Tel: +(603)-4145 0123", "PAYMENT RECEIPT", " ")



        'body
        Dim topBody As New StringBuilder()
        Dim count As Integer = 0
        Dim prodName As String = ""
        topBody.AppendFormat("{0,10}{1,15}{0,5}{2}" & vbNewLine, " ", "Payment ID : ", paymentID)
        topBody.AppendFormat("{0,16}{1,15}{0,5}{2}" & vbNewLine, " ", "Staff ID : ", staffID)

        topBody.AppendFormat("{0,10} {1}" & vbNewLine, " ", "-------------------------------------------------------------------------------------------------------------------------------------------------------------------")
        topBody.AppendFormat("{4,-10} {0,10} {4,10} {1,-60} {4,10} {2,20} {4,10} {3,20}" & vbNewLine, "No", "Product Name", "Product Quantity", "Product Price(RM)", " ")
        topBody.AppendFormat("{0,10} {1}" & vbNewLine, " ", "-------------------------------------------------------------------------------------------------------------------------------------------------------------------")
        Dim bodyForCount As New StringBuilder()
        Dim bodyForProdName As New StringBuilder()
        Dim bodyForQuantity As New StringBuilder()
        Dim bodyForOriginalPrice As New StringBuilder()

        For Each item As ProductClass In productsList
            count += 1
            prodName = item.ManageProdName()
            bodyForCount.AppendFormat("{0,19} {1}" & vbNewLine, " ", count)
            bodyForProdName.AppendFormat("{0,37} {1}" & vbNewLine, " ", prodName)
            bodyForQuantity.AppendFormat("{0,140} {1}" & vbNewLine, " ", item.ManageProdQuantity)
            If hasMember And item.ManageProdDiscountPrice() <> 0D Then
                bodyForOriginalPrice.AppendFormat("{0,180} {1}" & vbNewLine, " ", item.ManageProdDiscountPrice().ToString("C"))
            Else
                bodyForOriginalPrice.AppendFormat("{0,180} {1}" & vbNewLine, " ", item.ManageProdOriginalPrice().ToString("C"))
            End If
        Next


        'middle part body
        Dim midBody As New StringBuilder()
        midBody.AppendFormat("{0,10} {1}" & vbNewLine, " ", "-------------------------------------------------------------------------------------------------------------------------------------------------------------------")
        midBody.AppendLine()
        midBody.AppendFormat("{0,22} product(s) {1,106} {3,18} {2,-20}" & vbNewLine & vbNewLine, count, "Subtotal : ", subtotal.ToString("C"), " ")
        midBody.AppendFormat("{3,20}Total Quantity : {0,-15}  {1,84} {3,18} {2,-20}" & vbNewLine & vbNewLine & vbNewLine & vbNewLine & vbNewLine, totalProdCount, "Tax(6%) : ", tax.ToString("C"), " ")
        midBody.AppendFormat("{0,148} {2,20} {1,-20}" & vbNewLine & vbNewLine, "Total Discount : ", discount.ToString("C"), " ")

        midBody.AppendFormat("{0,151} {2,19} {1,-20}" & vbNewLine & vbNewLine, "Rounding : ", rounding.ToString("C"), " ")
        midBody.AppendFormat("{0,145} {2,18} {1,-20}" & vbNewLine & vbNewLine & vbNewLine, "Total After Rounding : ", total.ToString("C"), " ")
        midBody.AppendFormat("{0,145} {2,17} {1,-20}" & vbNewLine, "Payment Method : ", "CASH", " ")

        midBody.AppendFormat("{0,120} {1}" & vbNewLine, " ", "-------------------------------------------------------------------------")
        midBody.AppendFormat("{0,147} {2,18} {1,-20}" & vbNewLine, "Cash Received : ", cashReceived.ToString("C"), " ")
        midBody.AppendFormat("{0,152} {2,19} {1,-20}" & vbNewLine, "Change : ", change.ToString("C"), " ")
        midBody.AppendFormat("{0,120} {1}" & vbNewLine & vbNewLine, " ", "-------------------------------------------------------------------------")
        If hasMember Then
            midBody.AppendFormat("{0,10}{1,15}{0,5}{2,-10}{0,20}{3,15}{0,5}{4,-15}" & vbNewLine & vbNewLine, " ", "Member ID : ", memberID, "Points Left : ", (memberPoints + Math.Round(total) - pointRedeem).ToString())
        End If
        midBody.AppendFormat("{0,13}{1,15}{0,5}{2,-10}", " ", "Transaction Time : ", DateTime.Now)


        'additional body
        Dim addBody As New StringBuilder()
        If hasMember Then
            addBody.AppendFormat("{0,130}{1,23}{2}" & vbNewLine, "Discount from Member : ", " ", (discount - voucherDiscountAmount - (pointRedeem / 100)).ToString("C"))
            If hasRedeemPoint Then
                addBody.AppendFormat("{0,135}{1,23}{2}" & vbNewLine, "Discount from Points : ", " ", (pointRedeem / 100).ToString("C"))
            End If
        End If
        If hasVoucher Then
            addBody.AppendFormat("{0,131}{1,23}{2}" & vbNewLine, "Discount from Voucher : ", " ", voucherDiscountAmount.ToString("C"))
        End If

        'footer
        Dim strFooter As String = String.Format("{0,48} {1}", " ", "Thank You. Please Come Again!")



        'print
        With e.Graphics
            .DrawImage(My.Resources.BookMasterLogo, 350, 20, 130, 100)
            .DrawString(strHeader, fontHeader, Brushes.Black, 20, 130)
            .DrawString(topBody.ToString(), fontBody, Brushes.Black, 0, 280)
            .DrawString(bodyForCount.ToString(), fontBody, Brushes.Black, 0, 370)
            .DrawString(bodyForProdName.ToString(), fontBody, Brushes.Black, 0, 370)
            .DrawString(bodyForQuantity.ToString(), fontBody, Brushes.Black, 0, 370)
            .DrawString(bodyForOriginalPrice.ToString(), fontBody, Brushes.Black, 0, 370)
            .DrawString(midBody.ToString(), fontBody, Brushes.Black, 0, 600)
            .DrawString(addBody.ToString(), FontAddBody, Brushes.Black, 90, 700)
            .DrawString(strFooter, fontHeader, Brushes.Black, 0, 1050)
        End With
    End Sub


End Class