Imports System.Data.SqlClient
Imports System.Text

Public Class EditProductInfo
    Private strUpdateProductName As String
    Private strUpdateProductDescription As String
    Private decUpdateProductPrice As Decimal
    Private strUpdateProductDistributor As String
    Private strUpdateProductAuthor As String
    Private strUpdateProductStatus As String
    Private strProductCategory As String
    Private Sub EditProductInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSelectedInfo()
        loadAllProdStatus()
        verifyProductStatus()
    End Sub

    Private Sub verifyProductStatus()
        If ViewSelectedProductDetails.strSelectedProductStatus = "Available" Then
            cboProductStatus.SelectedValue = "Available"
            cboProductStatus.Enabled = False
        ElseIf ViewSelectedProductDetails.strSelectedProductStatus = "Out Of Stock" Then
            loadSelectedProdStatus()
            cboProductStatus.SelectedValue = "Out Of Stock"
            cboProductStatus.Enabled = True
        End If
    End Sub

    Private Sub loadSelectedInfo()
        lblProductID.Text = ViewAllProduct.strSelectedProductRecord
        txtUpdateProductName.Text = ViewSelectedProductDetails.strSelectedProductName
        txtUpdatePrice.Text = ViewSelectedProductDetails.decSelectedProductPrice.ToString("N2")
        txtUpdateDesc.Text = ViewSelectedProductDetails.strSelectedProductDesc
        txtUpdateAuthor.Text = ViewSelectedProductDetails.strSelectedProductAuthor
        txtUpdateDistributor.Text = ViewSelectedProductDetails.strSelectedProductDistributor
        lblProductCategory.Text = ViewSelectedProductDetails.strSelectedProductCategory

        If String.IsNullOrEmpty(txtUpdateAuthor.Text) = True Then
            txtUpdateAuthor.Enabled = False
        ElseIf String.IsNullOrEmpty(txtUpdateAuthor.Text) = False Then
            txtUpdateAuthor.Enabled = True
        End If

        ' strSelectedProductStatus 

    End Sub
    Private Sub loadAllProdStatus()

        If OpenConnection() = True Then

            Dim sda As New SqlDataAdapter("Select DISTINCT productStatus From Product ", conn)
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)

            cboProductStatus.DataSource = dt
            cboProductStatus.DisplayMember = "productStatus"
            cboProductStatus.ValueMember = "productStatus"
            CloseConnection()
        End If
    End Sub

    Private Sub loadSelectedProdStatus()

        If OpenConnection() = True Then

            Dim sda As New SqlDataAdapter("Select DISTINCT productStatus From Product Where productStatus = 'Out Of Stock' Or productStatus = 'Not Available' ", conn)
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)

            cboProductStatus.DataSource = dt
            cboProductStatus.DisplayMember = "productStatus"
            cboProductStatus.ValueMember = "productStatus"
            CloseConnection()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim strConfirmMessage As String = "Confirm cancel editing product with ID " + lblProductID.Text + " ?" + vbCrLf +
                                            "Your edited information will not be save."

        Dim result As DialogResult = MessageBox.Show(strConfirmMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Me.Close()
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Actions Cancel!", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim strErrorMessage As New StringBuilder()
        Dim control As Control = Nothing

        If String.IsNullOrEmpty(txtUpdateProductName.Text.Trim) = True Then
            strErrorMessage.AppendLine("- Product Name Must Be Filled")
            control = If(control, txtUpdateProductName)
        End If

        If String.IsNullOrEmpty(txtUpdateDesc.Text.Trim) = True Then
            strErrorMessage.AppendLine("- Product Description Must Be Filled")
            control = If(control, txtUpdateDesc)
        End If

        If String.IsNullOrEmpty(txtUpdatePrice.Text.Trim) = True Or IsNumeric(txtUpdatePrice.Text.Trim) = False Then
            strErrorMessage.AppendLine("- Invalid Product Price")
            control = If(control, txtUpdatePrice)
        ElseIf Decimal.Parse(txtUpdatePrice.Text) < 1 Then
            strErrorMessage.AppendLine("- Product Price Can't Be 0 ")
            control = If(control, txtUpdatePrice)
        End If

        If String.IsNullOrEmpty(txtUpdateAuthor.Text.Trim) = True And txtUpdateAuthor.Enabled = True Then
            strErrorMessage.AppendLine("- Product Author Must Be Filled")
            control = If(control, txtUpdateAuthor)
        End If

        If String.IsNullOrEmpty(txtUpdateDistributor.Text.Trim) = True Then
            strErrorMessage.AppendLine("- Product Distributor Must Be Filled")
            control = If(control, txtUpdateDistributor)
        End If

        If strErrorMessage.Length > 0 Then
            MessageBox.Show(strErrorMessage.ToString, "Inpur Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            control.Focus()
            Return
        Else
            Dim strConfirmMessage As String = "Confirm edit product with ID " + ViewAllProduct.strSelectedProductRecord + " ?"

            Dim result As DialogResult = MessageBox.Show(strConfirmMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.Yes Then
                UpdateProductInfo()
                ViewAllProduct.gvViewProduct.DataSource = ViewAllProduct.loadAllProduct()
                Me.Close()
                ViewSelectedProductDetails.Close()
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Actions Cancel!", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        End If
    End Sub
    Private Sub UpdateProductInfo()
        strUpdateProductName = txtUpdateProductName.Text
        strUpdateProductDescription = txtUpdateDesc.Text
        decUpdateProductPrice = txtUpdatePrice.Text
        strUpdateProductDistributor = txtUpdateDistributor.Text
        strUpdateProductAuthor = txtUpdateAuthor.Text
        strUpdateProductStatus = cboProductStatus.Text
        strProductCategory = ViewSelectedProductDetails.strSelectedProductCategory

        Dim sql As String
        Try
            If OpenConnection() = True Then
                If strProductCategory = "Book" Then
                    sql = "Update Product Set productName = @productName, productDesc = @productDesc, productStatus = @productStatus, productAuthor = @productAuthor, productDistributor = @productDistributor, productOriginalPrice = @productOriginalPrice Where productID = @productID"
                    Dim cmd As SqlCommand = New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@productID", ViewAllProduct.strSelectedProductRecord)
                    cmd.Parameters.AddWithValue("@productName", strUpdateProductName)
                    cmd.Parameters.AddWithValue("@productDesc", strUpdateProductDescription)
                    cmd.Parameters.AddWithValue("@productStatus", strUpdateProductStatus)
                    cmd.Parameters.AddWithValue("@productAuthor", strUpdateProductAuthor)
                    cmd.Parameters.AddWithValue("@productDistributor", strUpdateProductDistributor)
                    cmd.Parameters.AddWithValue("@productOriginalPrice", decUpdateProductPrice)

                    cmd.ExecuteNonQuery()
                ElseIf strProductCategory = "Stationery" Then
                    sql = "Update Product Set productName = @productName, productDesc = @productDesc, productStatus = @productStatus, productDistributor = @productDistributor, productOriginalPrice = @productOriginalPrice Where productID = @productID"
                    Dim cmd As SqlCommand = New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@productID", ViewAllProduct.strSelectedProductRecord)
                    cmd.Parameters.AddWithValue("@productName", strUpdateProductName)
                    cmd.Parameters.AddWithValue("@productDesc", strUpdateProductDescription)
                    cmd.Parameters.AddWithValue("@productStatus", strUpdateProductStatus)
                    cmd.Parameters.AddWithValue("@productDistributor", strUpdateProductDistributor)
                    cmd.Parameters.AddWithValue("@productOriginalPrice", decUpdateProductPrice)

                    cmd.ExecuteNonQuery()
                End If
            End If
            CloseConnection()
            MessageBox.Show("Product Information Modified Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("No its fail", "Hmmmmm", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try

    End Sub
End Class