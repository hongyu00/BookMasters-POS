Imports System.Data.SqlClient

Public Class ViewSelectedDiscountDetails
    Friend strSelectedDiscountName As String
    Friend intSelectedDiscountPercentage As Integer
    Friend strSelectedDiscountDesc As String
    Friend strSelectedDiscountStatus As String
    Friend dateSelectedDiscountStartDate As Date
    Friend dateSelectedDiscountEndDate As Date
    Friend strDiscountProducts As String

    Private Sub ViewSelectedDiscountDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEditDiscount.Enabled = True
        loadSelectedDiscount()
        loadDiscountProducts()
    End Sub

    Private Sub loadDiscountProducts()
        strDiscountProducts = vbNullString
        If OpenConnection() = True Then
            Try
                Dim sdr As SqlDataReader
                Dim sql As String
                sql = "Select DiscountProduct.productID, Product.productName From DiscountProduct, Product, Discount Where Discount.discountID = DiscountProduct.discountID And DiscountProduct.productID = Product.productID And DiscountProduct.discountID = @selectedDiscountRecord"
                Dim cmd As SqlCommand = New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@selectedDiscountRecord", ViewAllDiscount.strSelectedDiscountRecord)
                sdr = cmd.ExecuteReader()
                If sdr.HasRows Then
                    While sdr.Read
                        strDiscountProducts += sdr.GetValue(0).ToString() + " - " + sdr.GetValue(1).ToString() + vbCrLf
                    End While
                End If

            Catch ex As Exception
                MessageBox.Show("Error Occurs!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            lblDiscountProducts.Text = strDiscountProducts

            CloseConnection()
        End If
    End Sub

    Private Sub loadSelectedDiscount()
        Dim dateToday As Date = Date.Today
        EditDiscountInfo.dtpUpdateDiscountStartDate.Enabled = True

        If OpenConnection() = True Then
            Dim sdr As SqlDataReader
            Dim sql As String
            sql = "Select * from Discount Where discountID = @selectedDiscountRecord"
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@selectedDiscountRecord", ViewAllDiscount.strSelectedDiscountRecord)
            Try
                'btnAddStock.Enabled = True
                'btnEditProduct.Enabled = True

                sdr = cmd.ExecuteReader()
                sdr.Read()

                strSelectedDiscountName = sdr("discountName").ToString()
                intSelectedDiscountPercentage = sdr("discountPercentage").ToString()
                strSelectedDiscountDesc = sdr("discountDescription").ToString()
                strSelectedDiscountStatus = sdr("discountStatus").ToString()
                dateSelectedDiscountStartDate = sdr("discountStartDate").ToString()
                dateSelectedDiscountEndDate = sdr("discountEndDate").ToString()

                lblDiscountName.Text = "Discount Name: " + strSelectedDiscountName
                lblDiscountPercentage.Text = "Discount Percentage: " & intSelectedDiscountPercentage & " %"
                lblDiscountDesc.Text = strSelectedDiscountDesc
                lblDiscountStatus.Text = "Discount Status: " + strSelectedDiscountStatus
                lblDiscountStartDate.Text = "Discount Start Date: " + dateSelectedDiscountStartDate.Date
                lblDiscountEndDate.Text = "Discount End Date: " + dateSelectedDiscountEndDate.Date



                If strSelectedDiscountStatus = "Ongoing" Then
                    EditDiscountInfo.clbSelectedDiscountProduct.SelectionMode = SelectionMode.None
                    EditDiscountInfo.dtpUpdateDiscountStartDate.Value = dateSelectedDiscountStartDate.Date
                    EditDiscountInfo.dtpUpdateDiscountEndDate.Value = dateSelectedDiscountEndDate.Date
                    EditDiscountInfo.dtpUpdateDiscountStartDate.Enabled = False
                ElseIf strSelectedDiscountStatus = "Active" Then
                    EditDiscountInfo.clbSelectedDiscountProduct.SelectionMode = SelectionMode.One
                    EditDiscountInfo.dtpUpdateDiscountStartDate.Value = dateSelectedDiscountStartDate.Date
                    'EditDiscountInfo.dtpUpdateDiscountEndDate.Value = dateSelectedDiscountEndDate.Date
                    ' EditDiscountInfo.validateStartDate()
                End If

                If UserLogin.strCurrentLoginStaffRole = "MANAGER" Then
                    btnEditDiscount.Enabled = True
                    If strSelectedDiscountStatus = "Ended" Then
                        btnEditDiscount.Enabled = False
                    ElseIf strSelectedDiscountStatus = "Cancelled" Then
                        btnEditDiscount.Enabled = False
                    End If
                Else
                    btnEditDiscount.Enabled = False
                End If

            Catch ex As Exception
                'MessageBox.Show("Error Occurs When Load Discount Product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try

            CloseConnection()
        End If
    End Sub

    Private Sub btnEditDiscount_Click(sender As Object, e As EventArgs) Handles btnEditDiscount.Click
        EditDiscountInfo.ShowDialog()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'ViewAllDiscount.gvViewDiscount.DataSource = ViewAllDiscount.loadAllDiscount()
        Me.Close()
    End Sub

End Class