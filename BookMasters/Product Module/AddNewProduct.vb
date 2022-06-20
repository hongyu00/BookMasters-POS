Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text

Public Class AddNewProduct
    Private strNewProductID As String
    Private strNewProductName As String
    Private intNewProductQuantity As Integer
    Private strNewProductDescription As String
    Private decNewProductPrice As Decimal
    Private strNewProductDistributor As String
    Private strNewProductAuthor As String
    Private strNewProductCategory As String
    Private dateNewProductAddedDate As DateTime

    Private Sub AddNewProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadProductCategory()
        defaultProductAddedDate()
        cboProductCategory.SelectedIndex = 0
        cboProductCategory_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub txtNewProductQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtNewProductQuantity.TextChanged
        'checkProductQuantity()
    End Sub

    Private Sub txtNewProductPrice_TextChanged(sender As Object, e As EventArgs) Handles txtNewProductPrice.TextChanged
        'testing purpose
        Try
            Dim decProductPrice As Decimal
            decProductPrice = txtNewProductPrice.Text
            'txtNewProductAuthor.Text = decProductPrice.ToString("N2")
        Catch
            'checkPriceAmount()
        End Try
    End Sub

    Private Function generateBookProductID() As String
        Dim newBookProductID As String = 0
        Dim intRecordCount As Integer

        Dim sql As String
        Dim command As SqlCommand

        If OpenConnection() = True Then

            sql = "Select Count(*) from Product Where productCategory = 'Book' "
            command = New SqlCommand(sql, conn)
            intRecordCount = command.ExecuteScalar

            newBookProductID = String.Format("BK" + "{0:0000}", intRecordCount + 1)
            CloseConnection()
        End If
        Return newBookProductID
    End Function

    Private Function generateStationeryProductID() As String
        Dim newStationeryProductID As String = 0
        Dim intRecordCount As Integer

        Dim sql As String
        Dim command As SqlCommand

        If OpenConnection() = True Then

            sql = "Select Count(*) from Product Where productCategory = 'Stationery' "
            command = New SqlCommand(sql, conn)
            intRecordCount = command.ExecuteScalar

            newStationeryProductID = String.Format("SN" + "{0:0000}", intRecordCount + 1)
            CloseConnection()
        End If
        Return newStationeryProductID

    End Function

    Private Sub loadProductCategory()

        Try
            Dim sda As New SqlDataAdapter("Select DISTINCT productCategory From Product Where productCategory = 'Book' OR productCategory = 'Stationery'", conn)
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)

            cboProductCategory.DataSource = dt
            cboProductCategory.DisplayMember = "productCategory"
            cboProductCategory.ValueMember = "productCategory"
            CloseConnection()
        Catch ex As Exception
            MessageBox.Show("Cannot Load Product Category", "Failed Loading Product Category", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try

    End Sub

    Private Sub cboProductCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProductCategory.SelectedIndexChanged
        Dim strSelectedProductCategory As String
        strSelectedProductCategory = cboProductCategory.Text
        If strSelectedProductCategory = "Book" Then
            lblNewProductID.Text = generateBookProductID()
            strNewProductCategory = "Book"
            txtNewProductAuthor.Enabled = True
        ElseIf strSelectedProductCategory = "Stationery" Then
            lblNewProductID.Text = generateStationeryProductID()
            strNewProductCategory = "Stationery"
            txtNewProductAuthor.Clear()
            txtNewProductAuthor.Enabled = False
        End If
    End Sub

    Private Sub defaultProductAddedDate()
        dtpProductAddedDate.MinDate = DateTime.Today
        dtpProductAddedDate.MaxDate = DateTime.Today
        'dtpProductAddedDate.Enabled = False
        dateNewProductAddedDate = dtpProductAddedDate.Value
    End Sub

    Private Sub checkProductQuantity()
        If IsNumeric(txtNewProductQuantity.Text) = False Or txtNewProductQuantity.Text = "0" Then
            MessageBox.Show("Please enter a valid product quantity!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNewProductQuantity.SelectAll()
            txtNewProductQuantity.Focus()
        End If
    End Sub

    Private Sub checkPriceAmount()
        'If IsNumeric(txtNewProductPrice.Text) = False Then
        '    MessageBox.Show("Please enter a valid product price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    txtNewProductPrice.SelectAll()
        '    txtNewProductPrice.Focus()
        'End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strErrorMessage As New StringBuilder()
        Dim control As Control = Nothing

        If String.IsNullOrEmpty(txtNewProductName.Text.Trim) = True Then
            strErrorMessage.AppendLine("- Product Name Must Be Filled")
            control = If(control, txtNewProductAuthor)
        End If

        If String.IsNullOrEmpty(txtNewProductDesc.Text.Trim) = True Then
            strErrorMessage.AppendLine("- Product Description Must Be Filled")
            control = If(control, txtNewProductAuthor)
        End If

        If IsNumeric(txtNewProductQuantity.Text) = False Then
            strErrorMessage.AppendLine("- Invalid Product Quantity ")
            control = If(control, txtNewProductQuantity)
        ElseIf Decimal.Parse(txtNewProductQuantity.Text) < 1 Then
            strErrorMessage.AppendLine("- Product quantity can't be 0 ")
            control = If(control, txtNewProductQuantity)
        End If

        If String.IsNullOrEmpty(txtNewProductPrice.Text) = True Or IsNumeric(txtNewProductPrice.Text) = False Then
            strErrorMessage.AppendLine("- Invalid Product Price")
            control = If(control, txtNewProductPrice)
        ElseIf Decimal.Parse(txtNewProductPrice.Text) < 1 Then
            strErrorMessage.AppendLine("- Product Price Can't Be 0 ")
            control = If(control, txtNewProductPrice)
        End If

        If String.IsNullOrEmpty(txtNewProductAuthor.Text.Trim) = True And txtNewProductAuthor.Enabled = True Then
            strErrorMessage.AppendLine("- Product Author Must Be Filled")
            control = If(control, txtNewProductAuthor)
        End If

        If String.IsNullOrEmpty(txtNewProductDistributor.Text.Trim) = True Then
            strErrorMessage.AppendLine("- Product Distributor Must Be Filled")
            control = If(control, txtNewProductAuthor)
        End If

        If strErrorMessage.Length > 0 Then
            MessageBox.Show(strErrorMessage.ToString, "Inpur Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            control.Focus()
            Return
        Else
            Dim strConfirmMessage As String = "Confirm add new product " + txtNewProductName.Text + " with ID " + lblNewProductID.Text + " ?"

            Dim result As DialogResult = MessageBox.Show(strConfirmMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.Yes Then
                addNewProduct()
                ViewAllProduct.gvViewProduct.DataSource = ViewAllProduct.loadAllProduct()
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Actions Cancel!", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim strConfirmMessage As String = "Confirm cancel editing product with ID " + lblNewProductID.Text + " ?" + vbCrLf +
                                            "Your edited information will not be save."

        Dim result As DialogResult = MessageBox.Show(strConfirmMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            ViewAllProduct.gvViewProduct.DataSource = ViewAllProduct.loadAllProduct()
            btnClear_Click(Nothing, Nothing)
            Me.Close()
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Actions Cancel!", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNewProductAuthor.Clear()
        txtNewProductDesc.Clear()
        txtNewProductDistributor.Clear()
        txtNewProductName.Clear()
        txtNewProductPrice.Clear()
        txtNewProductQuantity.Clear()
        txtNewProductName.Select()
    End Sub

    Private Sub addNewProduct()

        'txtNewProductName.Text = "Hihi"
        strNewProductID = lblNewProductID.Text
        strNewProductName = txtNewProductName.Text
        intNewProductQuantity = Int32.Parse(txtNewProductQuantity.Text)
        strNewProductDescription = txtNewProductDesc.Text
        decNewProductPrice = Decimal.Parse(txtNewProductPrice.Text)
        strNewProductDistributor = txtNewProductDistributor.Text
        strNewProductAuthor = txtNewProductAuthor.Text
        strNewProductCategory = cboProductCategory.Text

        Dim sql As String
        Try
            If OpenConnection() = True Then
                If strNewProductCategory = "Book" Then
                    sql = "Insert Into Product ([productID],[productName],[productCategory],[productDesc],[productQuantity],[productStockIn],[productStockOut],[productStatus],[productAuthor],[productDistributor],[productAddDate],[productOriginalPrice]) Values (@productID, @productName , @productCategory, @productDesc, @productQuantity,@productStockIn ,@productStockOut,@productStatus ,@productAuthor, @productDistributor,@productAddDate,@productOriginalPrice)"
                    Dim cmd As SqlCommand = New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@productID", strNewProductID)
                    cmd.Parameters.AddWithValue("@productName", strNewProductName)
                    cmd.Parameters.AddWithValue("@productCategory", strNewProductCategory)
                    cmd.Parameters.AddWithValue("@productDesc", strNewProductDescription)
                    cmd.Parameters.AddWithValue("@productQuantity", intNewProductQuantity)
                    cmd.Parameters.AddWithValue("@productStockIn", intNewProductQuantity)
                    cmd.Parameters.AddWithValue("@productStockOut", 0)
                    cmd.Parameters.AddWithValue("@productStatus", "Available")
                    cmd.Parameters.AddWithValue("@productAuthor", strNewProductAuthor)
                    cmd.Parameters.AddWithValue("@productDistributor", strNewProductDistributor)
                    cmd.Parameters.AddWithValue("@productAddDate", dateNewProductAddedDate)
                    cmd.Parameters.AddWithValue("@productOriginalPrice", decNewProductPrice)

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("New Product Added Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf strNewProductCategory = "Stationery" Then
                    sql = "Insert Into Product ([productID],[productName],[productCategory],[productDesc],[productQuantity],[productStockIn],[productStockOut],[productStatus],[productDistributor],[productAddDate],[productOriginalPrice]) Values (@productID, @productName , @productCategory, @productDesc, @productQuantity,@productStockIn ,@productStockOut,@productStatus, @productDistributor,@productAddDate,@productOriginalPrice)"
                    Dim cmd As SqlCommand = New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@productID", strNewProductID)
                    cmd.Parameters.AddWithValue("@productName", strNewProductName)
                    cmd.Parameters.AddWithValue("@productCategory", strNewProductCategory)
                    cmd.Parameters.AddWithValue("@productDesc", strNewProductDescription)
                    cmd.Parameters.AddWithValue("@productQuantity", intNewProductQuantity)
                    cmd.Parameters.AddWithValue("@productStockIn", intNewProductQuantity)
                    cmd.Parameters.AddWithValue("@productStockOut", 0)
                    cmd.Parameters.AddWithValue("@productStatus", "Available")
                    cmd.Parameters.AddWithValue("@productDistributor", strNewProductDistributor)
                    cmd.Parameters.AddWithValue("@productAddDate", dateNewProductAddedDate)
                    cmd.Parameters.AddWithValue("@productOriginalPrice", decNewProductPrice)

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Product Stock Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                CloseConnection()
                Me.Close()
                btnClear_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show("No its fail", "Hmmmmm", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try
    End Sub

End Class