Imports System.Data.SqlClient

Public Class FormEditQuantity

    Dim stockInAmount As Integer

#Region "keypad function"
    Private quantityStr As String = ""
    Private Sub editLabel(value As Integer)

        If quantityStr = "" And value = 0 Then
            Exit Sub
        End If

        Dim checkDecimal As Integer = quantityStr.Length - quantityStr.IndexOf(".")
        If quantityStr.Contains(".") And checkDecimal > 2 Then
            Exit Sub
        End If

        quantityStr += value.ToString()
        lblDisplay.Text = quantityStr

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
    Private Sub btnBackspace_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
        If quantityStr.Length <> 0 Then
            quantityStr = quantityStr.Substring(0, quantityStr.Length - 1)
            lblDisplay.Text = quantityStr
        Else
            Exit Sub
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        quantityStr = ""
        lblDisplay.Text = quantityStr
    End Sub
#End Region

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Try
            Dim quantityInt As Integer = Integer.Parse(quantityStr)
            conn.Open()
            Dim cmdProduct As SqlCommand = New SqlCommand("SELECT productStockIn FROM Product WHERE productID = @productID", conn)
            cmdProduct.Parameters.AddWithValue("@productID", productsList(editQuantity).ManageProdID())
            'cmdProduct.Parameters.AddWithValue("@productStockOut", quantityInt)
            Dim readID As SqlDataReader = cmdProduct.ExecuteReader()
            If readID.HasRows Then
                While readID.Read()
                    stockInAmount = Integer.Parse(readID.GetValue(0))
                End While
            End If
            conn.Close()

            If stockInAmount >= quantityInt Then
                Dim result As DialogResult = MessageBox.Show("Quantity entered : " + quantityInt.ToString() + vbNewLine + "Confirm edit quantity?", "Edit quantity Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    Dim quantity As Integer = quantityInt - productsList(editQuantity).ManageProdQuantity()
                    productsList(editQuantity).ManageProdQuantity = quantityInt
                    totalProdCount += quantity
                    updateListBoxAndPrice(productsList, prodCount, totalProdCount)
                    Me.Close()
                End If
            Else
                Dim message As String = "Stock Left : " + stockInAmount.ToString() + vbNewLine +
                                        "Quantity entered : " + quantityInt.ToString() + vbNewLine + vbNewLine +
                                        "Insufficient stock for the customer to purchase!"
                MessageBox.Show(message, "Edit quantity error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If


        Catch ex As Exception
            MessageBox.Show("Please enter a valid quantity!", "Edit quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            conn.Close()
        End Try

    End Sub

    Private Sub FormEditQuantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        quantityStr = ""
    End Sub
End Class