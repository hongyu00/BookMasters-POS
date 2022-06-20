Imports System.Data.SqlClient
Public Class ViewAllProduct
    Friend strSelectedProductRecord As String


    Private Sub ViewAllProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gvViewProduct.DataSource = loadAllProduct()
        WindowState = FormWindowState.Maximized
    End Sub

    Friend Function loadAllProduct() As DataTable
        btnAddNewProduct.Enabled = True
        Dim dtProduct As New DataTable
        Dim adapterProduct As SqlDataAdapter
        Dim sql As String

        If OpenConnection() = True Then
            sql = "Select productID, productName, productCategory, productDistributor, productStatus, productOriginalPrice from Product Where productID LIKE '%' + @SearchData + '%' OR productName LIKE '%' + @SearchData + '%' OR productStatus LIKE '%' + @SearchData + '%' OR productDistributor LIKE '%' + @SearchData + '%' OR productCategory LIKE '%' + @SearchData + '%' OR @SearchData= ''"
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@SearchData", txtSearchProduct.Text.Trim())
            Try
                adapterProduct = New SqlDataAdapter(cmd)
                adapterProduct.Fill(dtProduct)
                'gvViewProduct.DataSource = adapterProduct

                dtProduct.Columns(0).ColumnName = "Product ID"
                dtProduct.Columns(1).ColumnName = "Product Name"
                dtProduct.Columns(2).ColumnName = "Product Category"
                dtProduct.Columns(3).ColumnName = "Product Distributor"
                dtProduct.Columns(4).ColumnName = "Product Status"
                dtProduct.Columns(5).ColumnName = "Product Original Price (RM)"

                If UserLogin.strCurrentLoginStaffRole = "MANAGER" Then
                    btnAddNewProduct.Enabled = True
                Else
                    btnAddNewProduct.Enabled = False
                End If

            Catch ex As Exception
                MessageBox.Show("Error Occurs!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try

            CloseConnection()
        End If
        Return dtProduct
    End Function

    Private Sub txtSearchProduct_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearchProduct.KeyUp
        gvViewProduct.DataSource = loadAllProduct()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddNewProduct.Click
        AddNewProduct.ShowDialog()
    End Sub

    Private Sub gvViewProduct_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gvViewProduct.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            strSelectedProductRecord = gvViewProduct.Rows(e.RowIndex).Cells(0).Value.ToString
            'MessageBox.Show(strSelectedProductRecord, "Hahah")
            ViewSelectedProductDetails.ShowDialog()
        End If

    End Sub

End Class