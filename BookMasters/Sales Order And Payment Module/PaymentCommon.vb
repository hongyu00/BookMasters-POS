Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Text

Module PaymentCommon
    Const TAX_VALUE As Decimal = 0.06D
    Friend isOnTransaction As Boolean = False
    Friend paymentID As String
    Friend prodCount As Integer = 0
    Friend productsList As New List(Of ProductClass)
    Friend totalProdCount As Integer = 0
    Friend subtotal As Decimal
    Friend discount As Decimal
    Friend tax As Decimal
    Friend rounding As Decimal
    Friend total As Decimal

    Friend isNewMember As Boolean = False
    Friend memberID As String = ""
    Friend memberPoints As Integer
    Friend hasMember As Boolean = False
    Friend pointRedeem As Integer = 0
    Friend hasRedeemPoint As Boolean = False

    Friend renewMember As Boolean = False
    Friend memberExpiredDate As String
    Friend memberPreviousStatus As String

    Friend voucherID As String = ""
    Friend voucherDiscountAmount As Decimal
    Friend hasVoucher As Boolean = False

    Friend staffID As String = UserLogin.strCurrentLoginStaffID

    Friend previousPaymentID As String = ""
    Friend hasHoldTransaction As Boolean = False
    Friend holdMemberVoucherValue As String
    Friend holdPaymentDetails As HoldPreviousPaymentClass
    Friend holdProductsList As New List(Of ProductClass)

    Friend paymentEnd As Boolean = False
    Friend totalPaymentByCash As Decimal = 0
    Friend totalPaymentByCard As Decimal = 0

    Friend editQuantity As Integer

    Friend cashCounterAmount As Decimal
    Friend variousAmount As Decimal
    Friend closeCounterStatus As String
    Friend hasCloseCounter As Boolean = False

    Friend openCounterAmount As Decimal
    Friend hasOpenCounter As Boolean = False

    Friend Sub getHoldPayment()
        Try
            paymentEnd = False
            'hasHoldTransaction = False
            previousPaymentID = ""
            clearValue()

            paymentID = holdPaymentDetails.managePaymentID()
            FormPayment.lblPaymentID.Text = paymentID
            prodCount = holdPaymentDetails.manageProdCount()
            For Each item In holdPaymentDetails.manageProductsList()
                productsList.Add(item)
            Next
            'productsList = holdPaymentDetails.manageProductsList()
            totalProdCount = holdPaymentDetails.manageTotalProdCount()
            memberID = holdPaymentDetails.manageMemberID()
            FormPayment.lblMember.Text = holdPaymentDetails.manageMemberID()
            memberPoints = holdPaymentDetails.manageMemberPoints
            hasMember = holdPaymentDetails.manageHasMember()
            isNewMember = holdPaymentDetails.manageIsNewMember()
            renewMember = holdPaymentDetails.manageIsRenewMember()
            voucherID = holdPaymentDetails.manageVoucherID()
            voucherDiscountAmount = holdPaymentDetails.manageVoucherDiscountAmount()
            hasVoucher = holdPaymentDetails.manageHasVoucher()

            holdPaymentDetails = New HoldPreviousPaymentClass()

            updateListBoxAndPrice(productsList, prodCount, totalProdCount)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Friend Sub generatePaymentID()
        Try
            paymentEnd = False
            clearValue()
            conn.Open()
            Using cmd As SqlCommand = New SqlCommand("SELECT TOP 1 paymentID FROM Payment ORDER BY paymentID DESC", conn)
                Dim readID As SqlDataReader = cmd.ExecuteReader()
                If readID.HasRows Then
                    While readID.Read()
                        paymentID = readID.GetValue(0).ToString()
                        Dim tempID As String = (10000 + Integer.Parse(paymentID.Substring(2, 4)) + 1).ToString()
                        paymentID = "PY" + tempID.Substring(1, 4)
                        FormPayment.lblPaymentID.Text = paymentID
                    End While
                End If
                conn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Friend Sub updateListBoxAndPrice(productsList As List(Of ProductClass), prodCount As Integer, totalprodcount As Integer)
        FormPayment.listProduct.Items.Clear()
        subtotal = 0
        discount = 0
        Dim discountFromProduct As Decimal = 0D
        If productsList IsNot Nothing Then
            For i As Integer = 0 To (productsList.Count - 1)
                If productsList(i).ManageProdID() <> "" Then
                    Dim stringtemp As String = productsList(i).ManageProdName()
                    Dim editPrice As Decimal = productsList(i).ManageProdQuantity() * productsList(i).ManageProdOriginalPrice()

                    Dim potentialDiscountPrice As Decimal = 0.00D
                    If productsList(i).ManageHasDiscount = 1 Then
                        potentialDiscountPrice = productsList(i).ManageProdQuantity() * (productsList(i).ManageProdOriginalPrice() - productsList(i).ManageProdDiscountPrice)
                        discountFromProduct += potentialDiscountPrice
                        discount += potentialDiscountPrice
                    Else
                        discount += 0
                        potentialDiscountPrice = 0.00D
                    End If

                    If stringtemp.Length <= 15 Then
                        FormPayment.listProduct.Items.Add(stringtemp & vbTab & vbTab & vbTab & vbTab & productsList(i).ManageProdQuantity() & vbTab & vbTab & editPrice & vbTab & vbTab & potentialDiscountPrice)
                    ElseIf stringtemp.Length > 15 And stringtemp.Length <= 23 Then
                        FormPayment.listProduct.Items.Add(stringtemp & vbTab & vbTab & vbTab & productsList(i).ManageProdQuantity() & vbTab & vbTab & editPrice & vbTab & vbTab & potentialDiscountPrice)
                    ElseIf stringtemp.Length > 23 And stringtemp.Length <= 30 Then
                        FormPayment.listProduct.Items.Add(stringtemp & vbTab & vbTab & productsList(i).ManageProdQuantity() & vbTab & vbTab & editPrice & vbTab & vbTab & potentialDiscountPrice)
                    Else
                        stringtemp = stringtemp.Substring(0, 30) + "..."
                        FormPayment.listProduct.Items.Add(stringtemp & vbTab & vbTab & productsList(i).ManageProdQuantity() & vbTab & vbTab & editPrice & vbTab & vbTab & potentialDiscountPrice)
                    End If
                    subtotal += editPrice
                End If
            Next
        End If
        If hasMember Then
            FormPayment.lblMember.Text = memberID
        End If


        checkHasMemberAndVoucherForDiscount()
        If hasMember Then
            tax = (subtotal - discountFromProduct) * TAX_VALUE
        Else
            tax = subtotal * TAX_VALUE
        End If
        Dim initialTotal As Decimal = subtotal - discount + tax
        rounding = roundingMechanism(initialTotal)
        total = initialTotal + rounding
        FormPayment.lblTotalQuantity.Text = totalprodcount
        FormPayment.lblSubtotal.Text = subtotal.ToString("C")
        FormPayment.lblDiscount.Text = discount.ToString("C")
        FormPayment.lblTax.Text = tax.ToString("C")
        FormPayment.lblRounding.Text = rounding.ToString("C")
        FormPayment.lblTotal.Text = total.ToString("C")
    End Sub
    Private Sub checkHasMemberAndVoucherForDiscount()

        If hasMember And hasVoucher Then
            discount = discount + voucherDiscountAmount
            If hasRedeemPoint Then
                discount += pointRedeem / 100
            End If
        ElseIf hasMember Or hasVoucher Then
            If hasVoucher Then
                discount = voucherDiscountAmount
            Else
                If hasRedeemPoint Then
                    discount += pointRedeem / 100
                End If
            End If
        Else
            discount = 0
        End If
    End Sub
    Friend Function roundingMechanism(initialTotal As Decimal) As Decimal
        Dim valueInt As Integer = (initialTotal * 100) Mod 10
        If valueInt = 1 Or valueInt = 6 Then
            Return -0.01
        ElseIf valueInt = 2 Or valueInt = 7 Then
            Return -0.02
        ElseIf valueInt = 3 Or valueInt = 8 Then
            Return 0.02
        ElseIf valueInt = 4 Or valueInt = 9 Then
            Return 0.01
        ElseIf valueInt = 5 Or valueInt = 0 Then
            Return 0.00
        End If
        Return 0.00
    End Function


    Friend Sub updatePayment_ProductOrdered_Product_MemberTable(paymentMethod As String)

        'store in PAYMENT table
        If memberID = "" And voucherID = "" Then
            insertSqlPaymentWithoutMemberAndVoucherExist(paymentMethod)
        ElseIf memberID = "" Or voucherID = "" Then
            If memberID = "" Then
                insertSqlPaymentWithVoucherExist(paymentMethod)
                If hasHoldTransaction = True Then
                    holdMemberVoucherValue = "Voucher"
                End If

            Else
                insertSqlPaymentWithMemberExist(paymentMethod)
                If hasHoldTransaction = True Then
                    holdMemberVoucherValue = "Member"
                End If
            End If
        Else
            insertSqlPaymentWithMemberAndVoucherExist(paymentMethod)
            If hasHoldTransaction = True Then
                holdMemberVoucherValue = "MemberAndVoucher"
            End If
        End If

        'store in PRODUCTORDERED table
        insertSqlProductOrdered()


        If hasHoldTransaction <> True Then
            'update PRODUCT table for the quantity
            updateProductQuantity()
            If hasMember Then
                'update MEMBER table for the memberPoints
                updateMemberPoints()
            End If
            If hasVoucher Then
                'update VOUCHER table for voucherStatus and appliedDate
                updateVoucherStatus()
            End If
            'FormPaymentHistory.FormPaymentReport_Load(Nothing, Nothing)
        End If

    End Sub
    Friend Sub insertSqlPaymentWithoutMemberAndVoucherExist(paymentMethod As String)
        conn.Open()

        Dim cmdPayment As SqlCommand = New SqlCommand("INSERT into Payment (paymentID, subtotal, totalDiscount, tax,total,paymentMethod,paymentDate,pointRedeem,staffID) values (@paymentID, @subtotal, @totalDiscount, @tax,@total,@paymentMethod,@paymentDate,@pointRedeem,@staffID)", conn)
        cmdPayment.Parameters.AddWithValue("@paymentID", paymentID)
        cmdPayment.Parameters.AddWithValue("@subtotal", Math.Round(subtotal, 2))
        cmdPayment.Parameters.AddWithValue("@totalDiscount", Math.Round(discount, 2))
        cmdPayment.Parameters.AddWithValue("@tax", Math.Round(tax, 2))
        cmdPayment.Parameters.AddWithValue("@total", Math.Round(total, 2))
        cmdPayment.Parameters.AddWithValue("@paymentMethod", paymentMethod)
        cmdPayment.Parameters.AddWithValue("@paymentDate", DateTime.Now)
        cmdPayment.Parameters.AddWithValue("@pointRedeem", pointRedeem)
        cmdPayment.Parameters.AddWithValue("@staffID", staffID) 'staffID
        Dim row As Integer = cmdPayment.ExecuteNonQuery()
        Debug.WriteLine(row.ToString() + " rows affected")
        conn.Close()

    End Sub
    Friend Sub insertSqlPaymentWithMemberExist(paymentMethod As String)
        conn.Open()

        Dim cmdPayment As SqlCommand = New SqlCommand("INSERT into Payment (paymentID, subtotal, totalDiscount, tax,total,paymentMethod,paymentDate,pointRedeem,memberID,staffID) values (@paymentID, @subtotal, @totalDiscount, @tax,@total,@paymentMethod,@paymentDate,@pointRedeem,@memberID,@staffID)", conn)
        cmdPayment.Parameters.AddWithValue("@paymentID", paymentID)
        cmdPayment.Parameters.AddWithValue("@subtotal", Math.Round(subtotal, 2))
        cmdPayment.Parameters.AddWithValue("@totalDiscount", Math.Round(discount, 2))
        cmdPayment.Parameters.AddWithValue("@tax", Math.Round(tax, 2))
        cmdPayment.Parameters.AddWithValue("@total", Math.Round(total, 2))
        cmdPayment.Parameters.AddWithValue("@paymentMethod", paymentMethod)
        cmdPayment.Parameters.AddWithValue("@paymentDate", DateTime.Now)
        cmdPayment.Parameters.AddWithValue("@pointRedeem", pointRedeem)
        cmdPayment.Parameters.AddWithValue("@memberID", memberID)
        cmdPayment.Parameters.AddWithValue("@staffID", staffID) 'staffID
        Dim row As Integer = cmdPayment.ExecuteNonQuery()
        Debug.WriteLine(row.ToString() + " rows affected")
        conn.Close()
    End Sub
    Friend Sub insertSqlPaymentWithVoucherExist(paymentMethod As String)
        conn.Open()
        Dim cmdPayment As SqlCommand = New SqlCommand("INSERT into Payment (paymentID, subtotal, totalDiscount, tax,total,paymentMethod,paymentDate,voucherID,staffID) values (@paymentID, @subtotal, @totalDiscount, @tax,@total,@paymentMethod,@paymentDate,@voucherID,@staffID)", conn)
        cmdPayment.Parameters.AddWithValue("@paymentID", paymentID)
        cmdPayment.Parameters.AddWithValue("@subtotal", Math.Round(subtotal, 2))
        cmdPayment.Parameters.AddWithValue("@totalDiscount", Math.Round(discount, 2))
        cmdPayment.Parameters.AddWithValue("@tax", Math.Round(tax, 2))
        cmdPayment.Parameters.AddWithValue("@total", Math.Round(total, 2))
        cmdPayment.Parameters.AddWithValue("@paymentMethod", paymentMethod)
        cmdPayment.Parameters.AddWithValue("@paymentDate", DateTime.Now)
        cmdPayment.Parameters.AddWithValue("@voucherID", voucherID)
        cmdPayment.Parameters.AddWithValue("@staffID", staffID) 'staffID
        Dim row As Integer = cmdPayment.ExecuteNonQuery()
        Debug.WriteLine(row.ToString() + " rows affected")
        conn.Close()
    End Sub
    Friend Sub insertSqlPaymentWithMemberAndVoucherExist(paymentMethod As String)
        conn.Open()

        Dim cmdPayment As SqlCommand = New SqlCommand("INSERT into Payment (paymentID, subtotal, totalDiscount, tax,total,paymentMethod,paymentDate,pointRedeem,memberID,voucherID,staffID) values (@paymentID, @subtotal, @totalDiscount, @tax,@total,@paymentMethod,@paymentDate,@pointRedeem,@memberID,@voucherID,@staffID)", conn)
        cmdPayment.Parameters.AddWithValue("@paymentID", paymentID)
        cmdPayment.Parameters.AddWithValue("@subtotal", Math.Round(subtotal, 2))
        cmdPayment.Parameters.AddWithValue("@totalDiscount", Math.Round(discount, 2))
        cmdPayment.Parameters.AddWithValue("@tax", Math.Round(tax, 2))
        cmdPayment.Parameters.AddWithValue("@total", Math.Round(total, 2))
        cmdPayment.Parameters.AddWithValue("@paymentMethod", paymentMethod)
        cmdPayment.Parameters.AddWithValue("@paymentDate", DateTime.Now)
        cmdPayment.Parameters.AddWithValue("@pointRedeem", pointRedeem)
        cmdPayment.Parameters.AddWithValue("@memberID", memberID)
        cmdPayment.Parameters.AddWithValue("@voucherID", voucherID)
        cmdPayment.Parameters.AddWithValue("@staffID", staffID) 'staffID
        Dim row As Integer = cmdPayment.ExecuteNonQuery()
        Debug.WriteLine(row.ToString() + " rows affected")
        conn.Close()
    End Sub

    Friend Sub insertSqlProductOrdered()

        'AFTER PRODUCTORDERED HAS DSICOUNTPRICE
        conn.Open()
        Dim cmdProductOrdered As SqlCommand = New SqlCommand("INSERT into ProductOrdered (paymentID, productID, quantity, discountProductPrice) values (@paymentID, @productID, @quantity, @discountProductPrice)", conn)
        cmdProductOrdered.Parameters.AddWithValue("@paymentID", "")
        cmdProductOrdered.Parameters.AddWithValue("@productID", "")
        cmdProductOrdered.Parameters.AddWithValue("@quantity", 0)
        cmdProductOrdered.Parameters.AddWithValue("@discountProductPrice", 0)

        For i As Integer = 0 To (productsList.Count - 1)
            If (Not String.IsNullOrWhiteSpace(productsList(i).ManageProdID())) Then
                cmdProductOrdered.Parameters("@paymentID").Value = paymentID
                cmdProductOrdered.Parameters("@productID").Value = productsList(i).ManageProdID()
                cmdProductOrdered.Parameters("@quantity").Value = productsList(i).ManageProdQuantity()
                cmdProductOrdered.Parameters("@discountProductPrice").Value = productsList(i).ManageProdDiscountPrice()
                Dim row2 As Integer = cmdProductOrdered.ExecuteNonQuery()
                Debug.WriteLine((i + 1).ToString() + ". " + row2.ToString() + " rows affected")
            End If
        Next
        conn.Close()
    End Sub

    Friend Sub updateProductQuantity()

        For i As Integer = 0 To (prodCount - 1)

            Dim quantity As Integer = productsList(i).ManageProdQuantity()
            Dim prodId As String = productsList(i).ManageProdID()
            If prodId = "MS0001" Or prodId = "MS0002" Then
                Continue For
            End If
            Dim queryStr As String = "UPDATE Product SET productStatus = (CASE WHEN (productStockIn - @quantity) = 0 THEN 'Out Of Stock' ELSE 'Available' END) ," +
                                     "productStockIn = (productStockIn - @quantity), productStockOut = (productStockOut + @quantity) WHERE productID = @productID"

            conn.Open()
            Dim cmdProduct As SqlCommand = New SqlCommand(queryStr, conn)
            cmdProduct.Parameters.AddWithValue("@quantity", quantity)
            cmdProduct.Parameters.AddWithValue("@productID", prodId)

            Dim row3 As Integer = cmdProduct.ExecuteNonQuery()

            Debug.WriteLine((i + 1).ToString() + ". " + row3.ToString() + " rows affected")
            conn.Close()
        Next

    End Sub
    Friend Sub updateMemberPoints()
        memberPoints += pointRedeem
        Dim pointsReceived As Decimal = Math.Round(total)
        conn.Open()
        Dim cmdMember As SqlCommand = New SqlCommand("UPDATE Member SET memberPoint = memberPoint + @pointsCollected - @pointsRedeem WHERE memberID = @memberID", conn)
        cmdMember.Parameters.AddWithValue("@pointsCollected", pointsReceived)
        cmdMember.Parameters.AddWithValue("@pointsRedeem", pointRedeem)
        cmdMember.Parameters.AddWithValue("@memberID", memberID)

        Dim rowMember As Integer = cmdMember.ExecuteNonQuery()
        Debug.WriteLine(rowMember.ToString() + " rows affected")
        conn.Close()
    End Sub
    Friend Sub updateVoucherStatus()
        conn.Open()
        Dim cmdVoucher As SqlCommand = New SqlCommand("UPDATE Voucher SET voucherStatus = 'Used', appliedDate = @date  WHERE voucherID = @voucherID", conn)
        cmdVoucher.Parameters.AddWithValue("@date", DateTime.Now)
        cmdVoucher.Parameters.AddWithValue("@voucherID", voucherID)

        Dim rowVoucher As Integer = cmdVoucher.ExecuteNonQuery()
        Debug.WriteLine(rowVoucher.ToString() + " rows affected")
        conn.Close()
    End Sub

    Friend Sub clearValue()
        If productsList IsNot Nothing Then

            productsList.Clear()
        End If

        prodCount = 0
        totalProdCount = 0
        subtotal = 0
        discount = 0
        tax = 0
        rounding = 0
        total = 0

        FormPayment.lblMember.Text = ""
        isNewMember = False
        memberID = ""
        memberPoints = 0
        hasMember = False
        pointRedeem = 0
        hasRedeemPoint = False


        voucherID = ""
        voucherDiscountAmount = 0
        hasVoucher = False

        paymentEnd = False

        updateListBoxAndPrice(productsList, prodCount, totalProdCount)
        FormPayment.txtBarcode.Text = ""
    End Sub
    Friend Sub refreshOpenCloseCounter()

    End Sub



End Module
