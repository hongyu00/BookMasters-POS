Imports System.Data.SqlClient

Public Class FormPayment

    Private Sub FormPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MaximizedBounds = Screen.FromHandle(Me.Handle).WorkingArea
        txtBarcode.Focus()
        Dim tooltip As ToolTip = New ToolTip()
        tooltip.ToolTipIcon = ToolTipIcon.Info
        tooltip.IsBalloon = True
        tooltip.ShowAlways = True
        tooltip.SetToolTip(lblPotentialDiscount, "Amount of discount will be given if the customer is a existing member")

        Dim tooltip2 As ToolTip = New ToolTip()
        tooltip2.ToolTipIcon = ToolTipIcon.Info
        tooltip2.IsBalloon = True
        tooltip2.ShowAlways = True
        tooltip2.SetToolTip(lblDiscountText, "Total Discount of (Potential Discount + Member Points Redemption + Voucher)")

        Dim tooltip3 As ToolTip = New ToolTip()
        tooltip3.ToolTipIcon = ToolTipIcon.Info
        tooltip3.IsBalloon = True
        tooltip3.ShowAlways = True
        tooltip3.SetToolTip(lblTax2, "Multiple of the difference of subtotal and discount from product by 6%")

        If hasHoldTransaction Then
            getHoldPayment()
        Else
            generatePaymentID()
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim sqlQuantity As Integer = 1

            For i As Integer = 0 To (prodCount - 1)
                If productsList(i).ManageProdID() = txtBarcode.Text.ToUpper() Then
                    sqlQuantity = productsList(i).ManageProdQuantity() + 1
                    Exit For
                End If
            Next

            conn.Open()
            Using cmdSearch As SqlCommand = New SqlCommand("SELECT * FROM Product WHERE productID = @id AND productStatus = 'Available' AND productStockIn >= @quantity", conn)
                cmdSearch.Parameters.AddWithValue("@id", txtBarcode.Text)
                cmdSearch.Parameters.AddWithValue("@quantity", sqlQuantity)
                Dim prodRecord As SqlDataReader = cmdSearch.ExecuteReader()
                If prodRecord.HasRows Then
                    While prodRecord.Read()
                        Dim id As String = prodRecord.GetValue(0).ToString()
                        Dim prodName As String = prodRecord.GetValue(1).ToString()
                        Dim quantity As String = 1
                        Dim oriPrice As Decimal = Decimal.Parse(prodRecord.GetValue(11).ToString())
                        Dim discountPrice As Decimal = 0
                        Dim hasDiscount As Integer = 0
                        If prodRecord.GetValue(12).ToString() <> "" Then
                            discountPrice = Decimal.Parse(prodRecord.GetValue(12).ToString())
                            hasDiscount = 1
                        End If
                        'productList(prodCount) = New ProductClass()

                        Dim hasCurrentProduct As Integer = checkExistingProduct(prodCount, id)
                        If hasCurrentProduct <> -1 Then
                            productsList(hasCurrentProduct).ManageProdQuantity() += 1

                        Else
                            productsList.Add(New ProductClass(id, prodName, quantity, oriPrice, discountPrice, hasDiscount))
                            prodCount += 1
                        End If
                        totalProdCount += 1
                    End While
                Else
                    MessageBox.Show("Product ID invalid OR Product is not available OR Product quantity is empty", "Add Product Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                conn.Close()
            End Using
            updateListBoxAndPrice(productsList, prodCount, totalProdCount)
            txtBarcode.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Function checkExistingProduct(prodCount As Integer, id As String) As Integer
        If productsList IsNot Nothing Then
            For i As Integer = 0 To (prodCount - 1)
                If productsList(i).ManageProdID() = id Then
                    Return i
                End If
            Next
        End If

        Return -1
    End Function

    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click
        If prodCount <> 0 Then
            FormCash.Show()
        Else
            MessageBox.Show("No product to make cash payment!", "Cash Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnCard_Click(sender As Object, e As EventArgs) Handles btnCard.Click
        If prodCount <> 0 Then
            FormCardDetails.Show()
        Else
            MessageBox.Show("No product to make card payment!", "Card Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnMember_Click(sender As Object, e As EventArgs) Handles btnMember.Click
        If hasMember Then
            MessageBox.Show("MemberID existed for this payment!", "Member Verify Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            FrmMemberValidation.Show()
        End If
    End Sub

    Private Sub btnVoucher_Click(sender As Object, e As EventArgs) Handles btnVoucher.Click
        If hasVoucher Then
            MessageBox.Show("Member has already used " + voucherID + " and deducted " + voucherDiscountAmount.ToString("C") + "!", "Use Voucher Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            FrmVoucherValidation.Show()

        End If
    End Sub

    Private Sub btnHold_Click(sender As Object, e As EventArgs) Handles btnHold.Click
        Try
            If hasHoldTransaction = False Then

                Dim result As DialogResult = MessageBox.Show("Are you sure you want to hold the current transaction?", "Hold Transaction Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    If prodCount = 0 Then
                        MessageBox.Show("There is no product to HOLD for the current payment!", "Hold Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        hasHoldTransaction = True
                        previousPaymentID = paymentID
                        'holdProductsList = productsList
                        For Each item As ProductClass In productsList
                            holdProductsList.Add(item)
                        Next
                        holdPaymentDetails = New HoldPreviousPaymentClass(paymentID, prodCount, holdProductsList, totalProdCount, memberID, memberPoints, hasMember, isNewMember, renewMember, voucherID, voucherDiscountAmount, hasVoucher)
                        'updatePayment_ProductOrdered_Product_MemberTable("NULL", "HOLD")


                        clearValue()

                        MessageBox.Show("Payment ID [" + previousPaymentID + "] will be HOLD for 1 transaction.", "Hold Transaction Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Dim tempID As String = (10000 + Integer.Parse(previousPaymentID.Substring(2, 4)) + 1).ToString()
                        paymentID = "PY" + tempID.Substring(1, 4)
                        lblPaymentID.Text = paymentID
                        'generatePaymentID()

                    End If
                End If
            Else
                MessageBox.Show("There is a transaction currently in hold. Unable to HOLD 2 transactions in a time.", "Hold Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If


        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click, listProduct.DoubleClick
        Try
            If listProduct.SelectedIndex <> -1 Then
                If productsList(listProduct.SelectedIndex).ManageProdID = "MS0001" Or productsList(listProduct.SelectedIndex).ManageProdID = "MS0002" Then
                    MessageBox.Show("Unable to edit respective product as it is a membership purchase!", "Edit Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                editQuantity = listProduct.SelectedIndex
                FormEditQuantity.Show()
            Else
                MessageBox.Show("Please select a product before proceed to edit!", "Edit Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If listProduct.SelectedIndex <> -1 Then
                Dim result As DialogResult = MessageBox.Show("Delete selected item?", "Delete Product Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then

                    If productsList(listProduct.SelectedIndex).ManageProdID = "MS0001" Or productsList(listProduct.SelectedIndex).ManageProdID = "MS0002" Then
                        If paymentEnd = False And renewMember = True And productsList(listProduct.SelectedIndex).ManageProdID = "MS0002" Then
                            'update back member expired date
                            Dim result2 As DialogResult = MessageBox.Show("The selected value is Renew Member Product. Are you sure you want to erase it? It will not renew the member expiry date.", "Delete Product Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If result2 = DialogResult.Yes Then
                                conn.Open()
                                Dim cmdMember As SqlCommand = New SqlCommand("UPDATE Member SET memberExpiredDate = @expiredDate, memberStatus = @memberStatus WHERE memberID = @memberID", conn)
                                cmdMember.Parameters.AddWithValue("@expiredDate", Convert.ToDateTime(memberExpiredDate))
                                cmdMember.Parameters.AddWithValue("@memberStatus", memberPreviousStatus)
                                cmdMember.Parameters.AddWithValue("@memberID", memberID)
                                cmdMember.ExecuteNonQuery()
                                conn.Close()
                                memberExpiredDate = ""
                                memberPreviousStatus = ""
                                lblMember.Text = ""
                                memberID = ""
                                hasMember = False
                                pointRedeem = 0
                                hasRedeemPoint = False
                                renewMember = False
                            Else
                                Exit Sub
                            End If
                        ElseIf paymentEnd = False And isNewMember = True And productsList(listProduct.SelectedIndex).ManageProdID = "MS0001" Then
                            Dim result3 As DialogResult = MessageBox.Show("The selected value is New Member Product. Are you sure you want to erase it? It will delete the new member ID.", "Delete Product Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If result3 = DialogResult.Yes Then
                                'delete new member
                                conn.Open()
                                Dim cmdMember As SqlCommand = New SqlCommand("DELETE FROM Member WHERE memberID=@memberID", conn)
                                cmdMember.Parameters.AddWithValue("@memberID", memberID)
                                cmdMember.ExecuteNonQuery()
                                conn.Close()
                                lblMember.Text = ""
                                memberID = ""
                                hasMember = False
                                isNewMember = False
                            Else
                                Exit Sub
                            End If

                        End If
                    End If
                End If

                totalProdCount -= productsList(listProduct.SelectedIndex).ManageProdQuantity()
                For i As Integer = listProduct.SelectedIndex To (prodCount - 1)
                    If i = prodCount - 1 Then
                        productsList.RemoveAt(i)
                        'productList(i) = New ProductClass()
                    Else
                        productsList(i) = productsList(i + 1)
                        'productList(i) = productList(i + 1)
                    End If
                Next
                prodCount -= 1
                updateListBoxAndPrice(productsList, prodCount, totalProdCount)
            Else
                MessageBox.Show("Please select a product before proceed to delete!", "Delete Product Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear the current transaction?", "Clear Transaction Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then

                If paymentEnd = False And renewMember = True Then
                    'update back member expired date
                    conn.Open()
                    Dim cmdMember As SqlCommand = New SqlCommand("UPDATE Member SET memberExpiredDate = @expiredDate, memberStatus = @memberStatus WHERE memberID = @memberID", conn)
                    cmdMember.Parameters.AddWithValue("@expiredDate", Convert.ToDateTime(memberExpiredDate))
                    cmdMember.Parameters.AddWithValue("@memberStatus", memberPreviousStatus)
                    cmdMember.Parameters.AddWithValue("@memberID", memberID)
                    cmdMember.ExecuteNonQuery()
                    conn.Close()
                End If
                If paymentEnd = False And isNewMember = True Then
                    'delete new member
                    conn.Open()
                    Dim cmdMemberDel As SqlCommand = New SqlCommand("DELETE FROM Member WHERE memberID=@memberID", conn)
                    cmdMemberDel.Parameters.AddWithValue("@memberID", memberID)
                    cmdMemberDel.ExecuteNonQuery()
                    conn.Close()
                End If
                clearValue()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub

    Private Sub btnPoint_Click(sender As Object, e As EventArgs) Handles btnPoint.Click
        If hasMember Then
            If hasRedeemPoint Then
                MessageBox.Show("Member has already redeemed " + pointRedeem.ToString() + " points!", "Redeem Point Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                FrmMemberRedeemPoint.ShowDialog()
            End If
        Else
            MessageBox.Show("There is no member available for point redemption!", "Redeem Point Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnPrice_Click(sender As Object, e As EventArgs) Handles btnPrice.Click
        ProductPriceCheck.ShowDialog()
    End Sub

    Private Sub btnRenewMember_Click(sender As Object, e As EventArgs) Handles btnRenewMember.Click

        If hasMember Then
            If renewMember Then
                MessageBox.Show("Member has already renew its member!", "Renew Member Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                FrmMemberRenew.ShowDialog()
            End If
        Else
            MessageBox.Show("There is no member available for membership renewal!", "Renew Member Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

End Class