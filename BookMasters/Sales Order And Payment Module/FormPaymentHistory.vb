Imports System.Data.SqlClient
Imports System.Text

Public Class FormPaymentHistory
    Dim phPaymentID As String = ""
    Dim phSubtotal As Decimal = 0
    Dim phTotaldiscount As Decimal = 0
    Dim phTax As Decimal = 0
    Dim phTotal As Decimal = 0
    Dim phPaymentmethod As String = ""
    Dim phPaymentdate As String = ""
    Dim phPointredeem As Integer = 0
    Dim phMemberID As String = ""
    Dim phVoucherID As String = ""
    Dim phStaffID As String = ""
    Dim phQuantity As Integer = 0
    Dim phProdList As New List(Of ProductClass)
    Dim phtotalProdCount As Integer = 0
    Dim phProdArr As New List(Of String)

    Friend Sub FormPaymentReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            clear()
            conn.Open()
            Dim cmdRetrieve As SqlCommand = New SqlCommand("SELECT paymentID FROM Payment", conn)
            Dim retrieveRecord As SqlDataReader = cmdRetrieve.ExecuteReader()
            If retrieveRecord.HasRows Then
                While retrieveRecord.Read()
                    cboPaymentID.Items.Add(retrieveRecord.GetValue(0).ToString())
                End While
            End If
            conn.Close()
            Dim tooltip As ToolTip = New ToolTip()
            tooltip.ToolTipIcon = ToolTipIcon.Info
            tooltip.IsBalloon = True
            tooltip.ShowAlways = True
            tooltip.SetToolTip(lblPaymentID, "Enter payment ID into textbox or select paymentID from the combo box.")
            btnType_Click(Nothing, Nothing)
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub btnType_Click(sender As Object, e As EventArgs) Handles btnType.Click
        cboPaymentID.Visible = False
        btnSearch.Visible = True
        txtPayment.Visible = True
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        cboPaymentID.Visible = True
        btnSearch.Visible = False
        txtPayment.Visible = False
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        clear()
        Dim id As String = txtPayment.Text.ToString()
        selectIDAndDisplay(id)
    End Sub
    Private Sub cboPaymentID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPaymentID.SelectedIndexChanged
        clear()
        Dim test As String = cboPaymentID.SelectedItem.ToString()
        selectIDAndDisplay(test)

    End Sub
    Private Sub selectIDAndDisplay(paymentID As String)
        Try
            phPaymentID = paymentID
            Dim count As Integer = 0
            phtotalProdCount = 0
            conn.Open()
            Dim cmdPayment As SqlCommand = New SqlCommand("SELECT p.subtotal, p.totalDiscount, p.tax, p.total, p.paymentMethod, p.paymentDate, p.pointRedeem, p.memberID,
                                                       p.voucherID, p.staffID, a.productID, a.quantity FROM Payment p, ProductOrdered a 
                                                        WHERE p.paymentID = @paymentID AND p.paymentID = a.paymentID", conn)
            cmdPayment.Parameters.AddWithValue("@paymentID", paymentID)
            Dim paymentRecord As SqlDataReader = cmdPayment.ExecuteReader()
            If paymentRecord.HasRows Then
                While paymentRecord.Read()
                    If count = 0 Then
                        phSubtotal = Decimal.Parse(paymentRecord.GetValue(0))
                        lblSubtotal.Text = phSubtotal.ToString("C")
                        phTotaldiscount = Decimal.Parse(paymentRecord.GetValue(1))
                        lblDiscount.Text = phTotaldiscount.ToString("C")
                        phTax = Decimal.Parse(paymentRecord.GetValue(2))
                        lblTax.Text = phTax.ToString("C")
                        phTotal = Decimal.Parse(paymentRecord.GetValue(3))
                        lblTotal.Text = phTotal.ToString("C")
                        phPaymentmethod = paymentRecord.GetValue(4).ToString()
                        lblPaymentMethod.Text = phPaymentmethod
                        phPaymentdate = Convert.ToDateTime(paymentRecord.GetValue(5)).ToString("d")
                        lblPaymentDate.Text = phPaymentdate

                        If paymentRecord.GetValue(7).ToString() <> "" Then
                            phMemberID = paymentRecord.GetValue(7).ToString()
                            lblMemberID.Text = phMemberID
                            If IsDBNull(paymentRecord.GetValue(6)) Then
                                phPointredeem = 0
                            Else
                                phPointredeem = Integer.Parse(paymentRecord.GetValue(6))
                            End If

                            lblPointsRedeem.Text = phPointredeem
                        End If

                        If paymentRecord.GetValue(8).ToString() <> "" Then
                            phVoucherID = paymentRecord.GetValue(8).ToString()
                            lblVoucherID.Text = phVoucherID
                        End If
                        phStaffID = paymentRecord.GetValue(9).ToString()
                        lblStaffID.Text = phStaffID
                    End If
                    count += 1
                    Dim prodID As String = paymentRecord.GetValue(10).ToString()
                    phProdArr.Add(prodID)
                End While
            Else
                MessageBox.Show("Invalid Payment ID", "Payment History Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                conn.Close()
                Exit Sub
            End If
            conn.Close()


            Dim prodSubtotal As Decimal = 0D
            Dim quantity As Integer = 0
            Dim stringtemp As String = ""
            Dim cmdProductOrdered As SqlCommand = New SqlCommand("SELECT p.productName, a.quantity, p.productOriginalPrice, a.discountProductPrice FROM Product p, ProductOrdered a WHERE p.productID = @productID AND p.productID = a.productID AND a.paymentID = @paymentID", conn)
            cmdProductOrdered.Parameters.AddWithValue("@paymentID", "")
            cmdProductOrdered.Parameters.AddWithValue("@productID", "")
            For Each item As String In phProdArr
                conn.Open()
                cmdProductOrdered.Parameters("@paymentID").Value = paymentID
                cmdProductOrdered.Parameters("@productID").Value = item
                Dim prodRecord As SqlDataReader = cmdProductOrdered.ExecuteReader()
                If prodRecord.HasRows Then
                    While prodRecord.Read()
                        quantity = prodRecord.GetValue(1).ToString()
                        phtotalProdCount += quantity
                        If Decimal.Parse(prodRecord.GetValue(3)) <> 0D Then
                            prodSubtotal = quantity * Decimal.Parse(prodRecord.GetValue(3))
                        Else
                            prodSubtotal = quantity * Decimal.Parse(prodRecord.GetValue(2))
                        End If
                        stringtemp = prodRecord.GetValue(0).ToString()
                        If stringtemp.Length <= 15 Then
                            listBoxProduct.Items.Add(stringtemp & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & quantity.ToString() & vbTab & vbTab & prodSubtotal.ToString("C"))
                        ElseIf stringtemp.Length > 15 And stringtemp.Length <= 23 Then
                            listBoxProduct.Items.Add(stringtemp & vbTab & vbTab & vbTab & vbTab & vbTab & quantity.ToString() & vbTab & vbTab & prodSubtotal.ToString("C"))

                        ElseIf stringtemp.Length > 23 And stringtemp.Length <= 40 Then
                            listBoxProduct.Items.Add(stringtemp & vbTab & vbTab & vbTab & vbTab & quantity.ToString() & vbTab & vbTab & prodSubtotal.ToString("C"))
                        Else
                            stringtemp = stringtemp.Substring(0, 40) + "....."
                            listBoxProduct.Items.Add(stringtemp & vbTab & vbTab & vbTab & quantity.ToString() & vbTab & vbTab & prodSubtotal.ToString("C"))
                        End If
                        Dim hasDiscount As Integer = 0
                        If Decimal.Parse(prodRecord.GetValue(3)) <> 0 Then
                            hasDiscount = 1
                        End If
                        phProdList.Add(New ProductClass(item, prodRecord.GetValue(0).ToString(), quantity, Decimal.Parse(prodRecord.GetValue(2)), Decimal.Parse(prodRecord.GetValue(3)), hasDiscount))
                    End While
                End If
                conn.Close()
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtPayment.Text = ""
        clear()
    End Sub
    Private Sub clear()
        lblSubtotal.Text = ""
        lblDiscount.Text = ""
        lblTax.Text = ""
        lblTotal.Text = ""
        lblPaymentMethod.Text = ""
        lblPaymentDate.Text = ""
        lblPointsRedeem.Text = ""
        lblMemberID.Text = ""
        lblVoucherID.Text = ""
        lblStaffID.Text = ""
        phProdList.Clear()
        phProdArr.Clear()
        listBoxProduct.Items.Clear()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        printReceiptPreview.Document = printReceipt
        printReceiptPreview.ShowDialog(Me)
    End Sub




    Private Sub printReceipt_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printReceipt.PrintPage
        Dim phRounding As Integer = 0
        Dim initialTotal As Decimal = phSubtotal - phTotaldiscount + phTax
        phRounding = roundingMechanism(initialTotal)

        'fonts
        Dim fontHeader As New Font("Century Gothic", 14)
        Dim fontBody As New Font("Century Gothic", 10)
        Dim FontAddBody As New Font("Century Gothic", 9)
        'header

        Dim strHeader As String = String.Format("{5,58} {0} " & vbNewLine & " {1}" & vbNewLine & "{5,25} {2}" & vbNewLine & "{5,55} {3}" & vbNewLine & "{5,57} {4}",
                                                "BOOK MASTER", "Ground Floor, Tan Sri Khaw Kai Boh Building, Kampus Utama, Jalan Genting Kelang,",
                                                "53300 Kuala Lumpur, Wilayah Persekutuan Kuala Lumpur", "Tel: +(603)-4145 0123", "PAYMENT HISTORY", " ")



        'body
        Dim topBody As New StringBuilder()
        Dim count As Integer = 0
        Dim prodName As String = ""
        topBody.AppendFormat("{0,10}{1,15}{0,5}{2}" & vbNewLine, " ", "Payment ID : ", phPaymentID)
        topBody.AppendFormat("{0,16}{1,15}{0,5}{2}" & vbNewLine, " ", "Staff ID : ", phStaffID)

        topBody.AppendFormat("{0,10} {1}" & vbNewLine, " ", "-------------------------------------------------------------------------------------------------------------------------------------------------------------------")
        topBody.AppendFormat("{4,-10} {0,10} {4,10} {1,-60} {4,10} {2,20} {4,10} {3,20}" & vbNewLine, "No", "Product Name", "Product Quantity", "Product Price(RM)", " ")
        topBody.AppendFormat("{0,10} {1}" & vbNewLine, " ", "-------------------------------------------------------------------------------------------------------------------------------------------------------------------")
        Dim bodyForCount As New StringBuilder()
        Dim bodyForProdName As New StringBuilder()
        Dim bodyForQuantity As New StringBuilder()
        Dim bodyForOriginalPrice As New StringBuilder()

        For Each item As ProductClass In phProdList
            count += 1
            prodName = item.ManageProdName()
            bodyForCount.AppendFormat("{0,19} {1}" & vbNewLine, " ", count)
            bodyForProdName.AppendFormat("{0,37} {1}" & vbNewLine, " ", prodName)
            bodyForQuantity.AppendFormat("{0,140} {1}" & vbNewLine, " ", item.ManageProdQuantity)
            If phMemberID <> "" And item.ManageProdDiscountPrice() <> 0D Then
                bodyForOriginalPrice.AppendFormat("{0,180} {1}" & vbNewLine, " ", item.ManageProdDiscountPrice().ToString("C"))
            Else
                bodyForOriginalPrice.AppendFormat("{0,180} {1}" & vbNewLine, " ", item.ManageProdOriginalPrice().ToString("C"))
            End If
        Next
        'middle part body
        Dim midBody As New StringBuilder()
        midBody.AppendFormat("{0,10} {1}" & vbNewLine, " ", "-------------------------------------------------------------------------------------------------------------------------------------------------------------------")
        midBody.AppendLine()
        midBody.AppendFormat("{0,22} product(s) {1,106} {3,18} {2,-20}" & vbNewLine & vbNewLine, count, "Subtotal : ", phSubtotal.ToString("C"), " ")
        midBody.AppendFormat("{3,20}Total Quantity : {0,-15}  {1,84} {3,18} {2,-20}" & vbNewLine & vbNewLine, phtotalProdCount, "Tax(6%) : ", phTax.ToString("C"), " ")
        midBody.AppendFormat("{0,148} {2,19} {1,-20}" & vbNewLine & vbNewLine, "Total Discount : ", phTotaldiscount.ToString("C"), " ")

        midBody.AppendFormat("{0,155} {2,20} {1,-20}" & vbNewLine & vbNewLine, "Total : ", phTotal.ToString("C"), " ")

        midBody.AppendFormat("{0,143} {2,18} {1,-20}" & vbNewLine & vbNewLine & vbNewLine & vbNewLine, "Payment Method : ", phPaymentmethod, " ")

        If phMemberID <> "" Then
            midBody.AppendFormat("{0,10}{1,15}{0,5}{2,-10}{0,20}{3,15}{0,5}{4,-15}" & vbNewLine & vbNewLine, " ", "Member ID : ", phMemberID, "Points Redeemed : ", phPointredeem.ToString())
        End If
        midBody.AppendFormat("{0,13}{1,15}{0,5}{2,-10}", " ", "Transaction Time : ", phPaymentdate)

        Dim strFooter As String = String.Format("{0,53} {1}", " ", "----------Page 1 of 1----------")

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
            .DrawString(strFooter, fontHeader, Brushes.Black, 0, 1050)
        End With
    End Sub



End Class