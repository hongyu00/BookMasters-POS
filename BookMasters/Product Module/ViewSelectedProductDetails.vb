Imports System.Data.SqlClient
Public Class ViewSelectedProductDetails
    Friend strSelectedProductName As String
    Friend decSelectedProductPrice As Decimal
    Friend strSelectedProductDesc As String
    Friend strSelectedProductDistributor As String
    Friend strSelectedProductAuthor As String
    Friend strSelectedProductCategory As String
    Friend strSelectedProductStatus As String


    'Dim strSelectedProductRecord As String = ViewAllProduct.strSelectedProductRecord
    Friend Sub ViewSelectedProductDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSelectedProduct()
    End Sub

    Private Sub btnAddStock_Click(sender As Object, e As EventArgs) Handles btnAddStock.Click
        AddProductStock.ShowDialog()
    End Sub

    Private Sub btnEditProduct_Click(sender As Object, e As EventArgs) Handles btnEditProduct.Click
        EditProductInfo.ShowDialog()
    End Sub

    Private Sub loadSelectedProduct()

        If OpenConnection() = True Then
            Dim sdr As SqlDataReader
            Dim sql As String
            sql = "Select * from Product Where productID = @selectedProductRecord"
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@selectedProductRecord", ViewAllProduct.strSelectedProductRecord)
            Try
                btnAddStock.Enabled = True
                btnEditProduct.Enabled = True

                sdr = cmd.ExecuteReader()
                sdr.Read()

                strSelectedProductName = sdr("productName").ToString()
                decSelectedProductPrice = sdr("productOriginalPrice").ToString()
                strSelectedProductDesc = sdr("productDesc").ToString()
                strSelectedProductDistributor = sdr("productDistributor").ToString()
                strSelectedProductAuthor = sdr("productAuthor").ToString
                strSelectedProductCategory = sdr("productCategory").ToString
                strSelectedProductStatus = sdr("productStatus").ToString

                lblSelectedProductName.Text = "Product Name: " + strSelectedProductName
                lblSelectedProductDesc.Text = strSelectedProductDesc
                lblTotalAddedStock.Text = "Total Added Stock: " + sdr("productQuantity").ToString()
                lblInStock.Text = "Stock In: " + sdr("productStockIn").ToString()
                lblStockOut.Text = "Stock Out : " + sdr("productStockOut").ToString()

                'lblSelectedProductAddedDate.Text = "Product Added Date: " + sdr("productAddDate").ToString()

                Dim strAddedDate As String = sdr("productAddDate").ToString()
                lblProductAuthor.Text = "Book Author: " + strSelectedProductAuthor
                lblProductAuthor.Visible = True

                lblSelectedProductAddedDate.Text = "Product Added Date: " + DateTime.Parse(strAddedDate).ToString("dd/MM/yyyy")

                'Dim strAuthor As String = sdr("productAuthor").ToString
                If strSelectedProductAuthor = "" Then
                    lblProductAuthor.Visible = False
                End If

                If strSelectedProductStatus = "Not Available" Then
                    btnAddStock.Enabled = False
                    btnEditProduct.Enabled = False
                End If

                If UserLogin.strCurrentLoginStaffRole = "MANAGER" Then
                    btnAddStock.Enabled = True
                    btnEditProduct.Enabled = True
                    If strSelectedProductStatus = "Not Available" Then
                        btnAddStock.Enabled = False
                        btnEditProduct.Enabled = False
                    End If
                    If strSelectedProductCategory = "Membership" Then
                        lblTotalAddedStock.Text = "Total Added Stock: N/A"
                        btnAddStock.Enabled = False
                        btnEditProduct.Enabled = False
                    End If
                Else
                    btnAddStock.Enabled = False
                    btnEditProduct.Enabled = False
                End If

            Catch ex As Exception
                MessageBox.Show("Error Occurs!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            CloseConnection()
        Else
            MessageBox.Show("Error in connecting to database server", "Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

End Class