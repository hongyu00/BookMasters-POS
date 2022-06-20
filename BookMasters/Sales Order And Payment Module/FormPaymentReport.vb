Imports System.Data.SqlClient
Imports System.Text

Public Class FormPaymentReport
    Dim prSubtotal As Decimal = 0
    Dim prTax As Decimal = 0
    Dim prDiscount As Decimal = 0
    Dim prTotal As Decimal = 0
    Dim prCashAmount As Decimal = 0
    Dim prCardAmount As Decimal = 0

    Dim count As Integer = 0
    Dim cardCount As Integer = 0
    Dim cashCount As Integer = 0

    Dim prodName As New List(Of String)
    Dim prodCount As New List(Of Integer)
    Dim tempProdCount As New List(Of Integer)

    Dim top5(5) As Integer
    Dim top5Prod() As String = {"", "", "", "", ""}

    Dim fromDate As DateTime
    Dim toDate As DateTime
    Dim titleSummary As String = ""
    Dim titleBestSelling As String = ""
    Private Sub FormPaymentReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DateTimePicker2.MaxDate = DateTime.Today
            DateTimePicker2.Value = DateTime.Today
            titleSummary = "For " + DateTime.Now.ToString("d")
            titleBestSelling = "For " + DateTime.Now.ToString("d")
            lblTitle.Text = "Summary Report " + titleSummary
            gboBestSelling.Text = "5 Best Selling Products " + titleBestSelling

            conn.Open()
            Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM Payment WHERE paymentDate = @date", conn)
            cmd.Parameters.AddWithValue("@date", DateTime.Now.Date())
            Dim readDate As SqlDataReader = cmd.ExecuteReader()
            If readDate.HasRows Then
                While readDate.Read()
                    count += 1
                    prSubtotal += Decimal.Parse(readDate.GetValue(1))
                    prTax += Decimal.Parse(readDate.GetValue(3))
                    prDiscount += Decimal.Parse(readDate.GetValue(2))
                    prTotal += Decimal.Parse(readDate.GetValue(4))
                    If readDate.GetValue(5).ToString().Equals("CASH") Then
                        cashCount += 1
                        prCashAmount += Decimal.Parse(readDate.GetValue(4))
                    Else
                        cardCount += 1
                        prCardAmount += Decimal.Parse(readDate.GetValue(4))
                    End If
                End While
            Else
                conn.Close()
                Exit Sub
            End If
            conn.Close()

            conn.Open()
            Dim cmd2 As SqlCommand = New SqlCommand("SELECT b.productName, p.quantity FROM ProductOrdered p, Payment a, Product b WHERE a.paymentDate = @date AND p.paymentID = a.paymentID AND p.productID = b.productID", conn)
            cmd2.Parameters.AddWithValue("@date", DateTime.Now.Date())
            Dim readDate2 As SqlDataReader = cmd2.ExecuteReader()
            If readDate2.HasRows Then
                While readDate2.Read()

                    For i As Integer = 0 To prodName.Count - 1
                        If prodName(i).Equals(readDate2.GetValue(0).ToString()) Then
                            prodCount(i) += Integer.Parse(readDate2.GetValue(1))
                            Continue While
                        End If
                    Next
                    prodName.Add(readDate2.GetValue(0).ToString())
                    prodCount.Add(Integer.Parse(readDate2.GetValue(1)))

                End While
            End If
            conn.Close()
            getTop5RecordAndDisplay()
            display()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            clearValue()
            fromDate = DateTimePicker1.Value
            toDate = DateTimePicker2.Value
            titleSummary = "From " + fromDate.ToString("d") + " to " + toDate.ToString("d")
            titleBestSelling = "From " + fromDate.ToString("d") + " to " + toDate.ToString("d")
            lblTitle.Text = "Summary Report " + titleSummary
            gboBestSelling.Text = "5 Best Selling Products " + titleBestSelling
            conn.Open()
            Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM Payment WHERE paymentDate >= @fromDate AND paymentDate <= @toDate", conn)
            cmd.Parameters.AddWithValue("@fromDate", fromDate)
            cmd.Parameters.AddWithValue("@toDate", toDate)
            Dim readDate As SqlDataReader = cmd.ExecuteReader()
            If readDate.HasRows Then
                While readDate.Read()
                    count += 1
                    prSubtotal += Decimal.Parse(readDate.GetValue(1))
                    prTax += Decimal.Parse(readDate.GetValue(3))
                    prDiscount += Decimal.Parse(readDate.GetValue(2))
                    prTotal += Decimal.Parse(readDate.GetValue(4))
                    If readDate.GetValue(5).ToString().Equals("CASH") Then
                        cashCount += 1
                        prCashAmount += Decimal.Parse(readDate.GetValue(4))
                    Else
                        cardCount += 1
                        prCardAmount += Decimal.Parse(readDate.GetValue(4))
                    End If
                End While
            End If
            conn.Close()

            conn.Open()
            Dim cmd2 As SqlCommand = New SqlCommand("SELECT b.productName, p.quantity FROM ProductOrdered p, Payment a, Product b WHERE p.paymentID = a.paymentID AND p.productID = b.productID AND a.paymentDate >= @fromDate2 AND a.paymentDate <= @toDate2", conn)
            cmd2.Parameters.AddWithValue("@fromDate2", fromDate)
            cmd2.Parameters.AddWithValue("@toDate2", toDate)
            Dim readDate2 As SqlDataReader = cmd2.ExecuteReader()
            If readDate2.HasRows Then
                While readDate2.Read()

                    For i As Integer = 0 To prodName.Count - 1
                        If prodName(i).Equals(readDate2.GetValue(0).ToString()) Then
                            prodCount(i) += Integer.Parse(readDate2.GetValue(1))
                            Continue While
                        End If
                    Next
                    prodName.Add(readDate2.GetValue(0).ToString())
                    prodCount.Add(Integer.Parse(readDate2.GetValue(1)))

                End While
            End If
            conn.Close()
            getTop5RecordAndDisplay()
            display()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub

    Private Sub getTop5RecordAndDisplay()

        If prodCount.Count >= 5 Then
            For z As Integer = 0 To prodCount.Count - 1
                Debug.WriteLine(prodName(z) & vbTab & prodCount(z).ToString())
                tempProdCount.Add(prodCount(z))
            Next

            tempProdCount.Sort()
            tempProdCount.Reverse()

            For k As Integer = 0 To 4
                Dim intNo As Integer = 0
                For i As Integer = 0 To tempProdCount.Count - 1
                    If (tempProdCount(k) = prodCount(intNo)) Then
                        If top5Prod.Contains(prodName(intNo)) Then
                            intNo += 1
                            Continue For
                        Else
                            top5Prod(k) = prodName(intNo)
                            top5(k) = intNo
                            Exit For
                        End If
                    Else
                        intNo += 1
                    End If
                Next
            Next

            lbl1.Text = "1. " + prodName(top5(0))
            lbl1Sold.Text = prodCount(top5(0)).ToString() + " quantity sold"
            lbl2.Text = "2. " + prodName(top5(1))
            lbl2Sold.Text = prodCount(top5(1)).ToString() + " quantity sold"
            lbl3.Text = "3. " + prodName(top5(2))
            lbl3Sold.Text = prodCount(top5(2)).ToString() + " quantity sold"
            lbl4.Text = "4. " + prodName(top5(3))
            lbl4Sold.Text = prodCount(top5(3)).ToString() + " quantity sold"
            lbl5.Text = "5. " + prodName(top5(4))
            lbl5Sold.Text = prodCount(top5(4)).ToString() + " quantity sold"
        Else
            Exit Sub
        End If
    End Sub
    Private Sub display()

        lblTransaction.Text = count.ToString()
        lblTax.Text = prTax.ToString("C")
        lblTotalProfit.Text = prTotal.ToString("C")
        lblProfitEarned.Text = (prTotal - prTax).ToString("C")
        lblCash.Text = prCashAmount.ToString("C")
        lblCard.Text = prCardAmount.ToString("C")
        lblCashTransaction.Text = cashCount.ToString()
        lblCardTransaction.Text = cardCount.ToString()
    End Sub

    Private Sub clearValue()
        prSubtotal = 0
        prTax = 0
        prDiscount = 0
        prTotal = 0
        prCashAmount = 0
        prCardAmount = 0
        count = 0
        cardCount = 0
        cashCount = 0
        titleBestSelling = ""
        titleSummary = ""
        lbl1.Text = "1. "
        lbl1Sold.Text = ""
        lbl2.Text = "2. "
        lbl2Sold.Text = ""
        lbl3.Text = "3. "
        lbl3Sold.Text = ""
        lbl4.Text = "4. "
        lbl4Sold.Text = ""
        lbl5.Text = "5. "
        lbl5Sold.Text = ""
        lblTransaction.Text = ""
        lblTax.Text = ""
        lblTotalProfit.Text = ""
        lblProfitEarned.Text = ""
        lblCash.Text = ""
        lblCard.Text = ""
        lblCashTransaction.Text = ""
        lblCardTransaction.Text = ""
        Array.Clear(top5Prod, 0, top5Prod.Length)
        Array.Clear(top5, 0, top5.Length)
        tempProdCount.Clear()
        prodCount.Clear()
        prodName.Clear()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        clearValue()
        FormPaymentReport_Load(Nothing, Nothing)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        printReceiptPreview.Document = printReceipt
        printReceiptPreview.ShowDialog(Me)
    End Sub
    Private Sub printReceipt_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printReceipt.PrintPage
        Try
            Dim fontHeader As New Font("Century Gothic", 14)
            Dim fontSubHeader As New Font("Century Gothic", 12.5)
            Dim fontBody As New Font("Century Gothic", 12)
            Dim fontTotal As New Font("Century Gothic", 14, FontStyle.Bold)

            Dim strHeader As String = ""
            If titleSummary.StartsWith("From") Then
                strHeader = String.Format("{0,52} {1}" & vbNewLine & vbNewLine & "{0,48} {2}", " ", "Sales Report Summary ", titleSummary)
            Else
                strHeader = String.Format("{0,52} {1}" & vbNewLine & vbNewLine & "{0,62} {2}", " ", "Sales Report Summary ", titleSummary)
            End If
            Dim strSubHeader As String = String.Format("{1,48} Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
        "{1,63} Generated by " + UserLogin.strCurrentLoginStaffName, DateTime.Now, " ")

            Dim topBody As New StringBuilder()
            topBody.AppendFormat("{0,10} {1}" & vbNewLine, " ", "-------------------------------------------------------------------------------------------------------------------------------------")
            topBody.AppendFormat("{0,13} {1,50} {0,15} {2,-10} " & vbNewLine, " ", "Total Transactions by Cash : ", cashCount.ToString() + " transaction(s)")
            topBody.AppendFormat("{0,5} {1,50} {0,15} {2,-10} " & vbNewLine & vbNewLine, " ", "Total Amount Received By Cash : ", prCashAmount.ToString("C"))
            topBody.AppendFormat("{0,13} {1,50} {0,15} {2,-10} " & vbNewLine, " ", "Total Transactions by Card : ", cardCount.ToString() + " transaction(s)")
            topBody.AppendFormat("{0,5} {1,50} {0,15} {2,-10} " & vbNewLine & vbNewLine, " ", "Total Amount Received By Card : ", prCardAmount.ToString("C"))
            topBody.AppendFormat("{0,21} {1,50} {0,15} {2,-10} " & vbNewLine, " ", "Total Transactions : ", count.ToString() + " transaction(s)")
            topBody.AppendFormat("{0,22} {1,50} {0,15} {2,-10} " & vbNewLine & vbNewLine & vbNewLine, " ", "Total Amount : ", prTotal.ToString("C"))
            topBody.AppendFormat("{0,23} {1,50} {0,15} {2,-10} " & vbNewLine & vbNewLine & vbNewLine & vbNewLine & vbNewLine, " ", "Tax to be paid : ", prTax.ToString("C"))
            topBody.AppendFormat("{0,10} {1}" & vbNewLine, " ", "-------------------------------------------------------------------------------------------------------------------------------------")

            Dim totalBody As New StringBuilder()
            totalBody.AppendFormat("{0,12} {1,50} {0,13} {2,-10} " & vbNewLine & vbNewLine & vbNewLine, " ", "Profit Earned : ", (prTotal - prTax).ToString("C"))

            Dim topSalesHeader As New StringBuilder()
            Dim topSalesBody As New StringBuilder()
            Dim topsalesCount As New StringBuilder()
            If prodCount.Count >= 5 Then
                topSalesHeader.AppendFormat("{0,50} {1}", " ", "Top 5 Best Selling Products")

                topSalesBody.AppendFormat("{0,10} {1}" & vbNewLine & vbNewLine, " ", "1. " + prodName(top5(0)))
                topSalesBody.AppendFormat("{0,10} {1}" & vbNewLine & vbNewLine, " ", "2. " + prodName(top5(1)))
                topSalesBody.AppendFormat("{0,10} {1}" & vbNewLine & vbNewLine, " ", "3. " + prodName(top5(2)))
                topSalesBody.AppendFormat("{0,10} {1}" & vbNewLine & vbNewLine, " ", "4. " + prodName(top5(3)))
                topSalesBody.AppendFormat("{0,10} {1}" & vbNewLine & vbNewLine, " ", "5. " + prodName(top5(4)))
                topSalesBody.AppendFormat("{0,10} {1}" & vbNewLine, " ", "-------------------------------------------------------------------------------------------------------------------------------------")

                topsalesCount.AppendFormat("{0,110} {1}" & vbNewLine & vbNewLine, " ", prodCount(top5(0)).ToString() + " quantity sold")
                topsalesCount.AppendFormat("{0,110} {1}" & vbNewLine & vbNewLine, " ", prodCount(top5(1)).ToString() + " quantity sold")
                topsalesCount.AppendFormat("{0,110} {1}" & vbNewLine & vbNewLine, " ", prodCount(top5(2)).ToString() + " quantity sold")
                topsalesCount.AppendFormat("{0,110} {1}" & vbNewLine & vbNewLine, " ", prodCount(top5(3)).ToString() + " quantity sold")
                topsalesCount.AppendFormat("{0,110} {1}" & vbNewLine & vbNewLine, " ", prodCount(top5(4)).ToString() + " quantity sold")
            End If
            Dim strFooter As String = String.Format("{0,53} {1}", " ", "----------Page 1 of 1----------")

            With e.Graphics
                .DrawImage(My.Resources.BookMasterLogo, 350, 20, 130, 100)
                .DrawString(strHeader, fontHeader, Brushes.Black, 20, 130)
                .DrawString(strSubHeader, fontSubHeader, Brushes.Black, 0, 220)
                .DrawString(topBody.ToString(), fontBody, Brushes.Black, 0, 270)
                .DrawString(totalBody.ToString(), fontTotal, Brushes.Black, 0, 560)
                .DrawString(topSalesHeader.ToString(), fontHeader, Brushes.Black, 20, 630)
                .DrawString(topSalesBody.ToString(), fontBody, Brushes.Black, 20, 700)
                .DrawString(topsalesCount.ToString(), fontBody, Brushes.Black, 20, 700)
                .DrawString(strFooter, fontHeader, Brushes.Black, 0, 1050)

            End With
        Catch ex As Exception
            MessageBox.Show("There is no report to print!", "Print Report Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End Try

    End Sub

End Class
