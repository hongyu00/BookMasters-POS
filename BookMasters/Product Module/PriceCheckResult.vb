Imports System.Data.SqlClient
Public Class PriceCheckResult
    'Dim strProductPriceCheckID As String
    Private Sub ViewPriceCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadPriceCheckProduct()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

    Private Sub loadPriceCheckProduct()
        Dim sdr As SqlDataReader
        Dim sql As String

        If OpenConnection() = True Then
            sql = "Select productName, productOriginalPrice, productDiscountPrice from Product Where productID = @productPriceCheckID"
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@productPriceCheckID", ProductPriceCheck.strPriceCheckProductID)
            Try
                sdr = cmd.ExecuteReader()
                sdr.Read()

                lblSearchProductID.Text = ProductPriceCheck.strPriceCheckProductID.ToUpper
                lblSearchProductName.Text = sdr("productName").ToString()
                Dim strMemberPrice As String
                strMemberPrice = sdr("productDiscountPrice").ToString()
                lblSearchProductMemberPrice.Text = "RM " + strMemberPrice
                lblSearchProductINonMemberPrice.Text = "RM " + sdr("productOriginalPrice").ToString()

                If strMemberPrice = "" Then
                    lblSearchProductMemberPrice.Text = "N/A"
                End If

                ProductPriceCheck.txtSearchProduct.Text = ""
                ProductPriceCheck.txtSearchProduct.Select()

            Catch ex As Exception
                If String.IsNullOrEmpty(ProductPriceCheck.txtSearchProduct.Text) = True Then
                    MessageBox.Show("Please enter a product ID! ", "Hmmmmm", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Else
                    MessageBox.Show("Opps! Product Not Found!" & vbCrLf & "Please try another product again! ", "Hmmmmm", MessageBoxButtons.OK, MessageBoxIcon.Question)
                End If
                Me.Close()
                ProductPriceCheck.txtSearchProduct.Text = ""
                ProductPriceCheck.txtSearchProduct.Select()
            End Try
            CloseConnection()
        End If
    End Sub

End Class