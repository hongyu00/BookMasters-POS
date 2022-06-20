Imports System.Data.SqlClient
Imports System.Text

Public Class AddNewDiscount
    Private strNewDiscountID As String
    Private strNewDiscountName As String
    Private intDiscountPercentage As Integer
    Private dateSelectedStartDate As Date
    Private dateSelectedEndDate As Date
    Private strNewDiscountDescription As String
    Private listSelectedProduct As New List(Of String)
    Private strNewDiscountStatus As String

    Friend listOfDiscountPercentage As New List(Of Integer)
    Friend listOfDiscountProduct As New List(Of String)
    Friend listOfProductOriginalPrice As New List(Of Decimal)
    Friend listOfUpdateDiscountPrice As New List(Of Decimal)
    Friend listOfDisabledProduct As New List(Of String)
    Friend listOfActivateDiscountID As New List(Of String)

    Private Sub AddNewDiscount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNewDiscountID.Text = generateDiscountID()
        validateStartDate()
        loadCheckListProduct()

        'dtpNewDiscountStartDate.Format = DateTimePickerFormat.Custom
        'dtpNewDiscountStartDate.CustomFormat = "dd/MM/yyyy"
        'dtpNewDiscountEndDate.Format = DateTimePickerFormat.Custom
        'dtpNewDiscountEndDate.CustomFormat = "dd/MM/yyyy"
        'validateAvailableDiscountProduct()
    End Sub

    'Private Sub validateAvailableDiscountProduct()
    '    Dim tempStartDate As Date = dtpNewDiscountStartDate.Value
    '    Dim tempEndDate As Date = dtpNewDiscountEndDate.Value
    '    If OpenConnection() = True Then
    '        Try
    '            Dim sdr As SqlDataReader
    '            Dim sql As String
    '            sql = "Select DiscountProduct.productID from DiscountProduct, Product, Discount Except Select DiscountProduct.productID from DiscountProduct, Product, Discount Where Product.productID = DiscountProduct.productID And DiscountProduct.discountID = Discount.discountID And (Product.productCategory = 'Book' OR Product.productCategory = 'Stationery') And Product.productStatus = 'Available' And Discount.discountStartDate < @tempEndDate And Discount.discountEndDate > @tempEndDate "
    '            Dim cmd As SqlCommand = New SqlCommand(sql, conn)
    '            cmd.Parameters.AddWithValue("@tempStartDate", tempStartDate)
    '            cmd.Parameters.AddWithValue("@tempEndDate", tempEndDate)
    '            sdr = cmd.ExecuteReader()
    '            If sdr.HasRows Then
    '                While sdr.Read
    '                    listOfDisabledProduct.Add(sdr.GetValue(0).ToString())
    '                End While
    '            Else
    '                lblTestUncheked.Text = "No records"
    '            End If

    '            Dim count As Integer = listOfDisabledProduct.Count
    '            Dim str As String
    '            For Each str In listOfDisabledProduct
    '                lblTestUncheked.Text += str
    '            Next
    '            'lblTestUncheked.Text = dtpNewDiscountEndDate.Value
    '            'disableCheckBox()
    '        Catch ex As Exception
    '            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        End Try
    '    End If

    'End Sub

    'Private Sub disableCheckBox()
    '    Dim strContent As String
    '    For i As Integer = 0 To clbNewDiscountSelectedProduct.Items.Count - 1
    '        Dim view As DataRowView = clbNewDiscountSelectedProduct.Items(i)
    '        strContent = view("productID").ToString
    '        If listOfDisabledProduct.Contains(strContent) Then
    '            clbNewDiscountSelectedProduct.Items.Remove(strContent)
    '        End If
    '    Next
    'End Sub

    Private Sub dtpNewDiscountStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpNewDiscountStartDate.ValueChanged
        validateEndDate()
        'validateAvailableDiscountProduct()
    End Sub

    Private Sub dtpNewDiscountEndDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpNewDiscountEndDate.ValueChanged
        'validateAvailableDiscountProduct()
    End Sub

    'Friend Sub reloadCheckListProduct()
    '    Dim adapter As SqlDataAdapter = New SqlDataAdapter
    '    Dim dt As New DataTable
    '    Dim sql As String

    '    txtNewDiscountName.Select()
    '    If OpenConnection() = True Then

    '        sql = "Select DiscountProduct.productID, Product.productName From DiscountProduct, Product, Discount Except Select DiscountProduct.productID, Product.productName From DiscountProduct, Product, Discount Where Product.productCategory = Membership And (Product.productStatus = 'Not Available' OR Product.productStatus = 'Out of Stock') And Product.productID = DiscountProduct.productID And DiscountProduct.discountID = Discount.discountID And Discount.discountEndDate > @selectedDiscountEndDate And Discount.discountStartDate < @selectedDiscountStartDate "
    '        adapter = New SqlDataAdapter(sql, conn)
    '        'Dim cmd As SqlCommand = New SqlCommand(sql, conn)
    '        'cmd.Parameters.AddWithValue("@selectedDiscountStartDate", dateTempSelectedStartDate)
    '        'cmd.Parameters.AddWithValue("@selectedDiscountEndDate", dateTempSelectedEndDate)

    '        'adapter.InsertCommand = New SqlCommand(cmd, conn)
    '        adapter.SelectCommand.Parameters.AddWithValue("@selectedDiscountStartDate", dateTempSelectedStartDate)
    '        adapter.SelectCommand.Parameters.AddWithValue("@selectedDiscountEndDate", dateTempSelectedEndDate)
    '        'adapter.InsertCommand.ExecuteNonQuery()
    '        'Dim adapter As SqlDataAdapter = SqlDataAdapter(cmd).Fill(dt)
    '        adapter.Fill(dt)

    '        clbNewDiscountSelectedProduct.DataSource = dt
    '        clbNewDiscountSelectedProduct.DisplayMember = "productName"
    '        clbNewDiscountSelectedProduct.ValueMember = "productID"
    '        CloseConnection()
    '    End If
    'End Sub

    Friend Function validateStartDate() As DateTime
        dtpNewDiscountStartDate.MinDate = Now
        Return dtpNewDiscountStartDate.Value.Date
    End Function

    Friend Function validateEndDate() As DateTime
        Dim dateCalDayAfterStartDate As DateTime
        dateCalDayAfterStartDate = (dtpNewDiscountStartDate.Value).AddDays(1).Date
        dtpNewDiscountEndDate.MinDate = dateCalDayAfterStartDate.Date
        'dtpNewDiscountEndDate.Value = dateCalDayAfterStartDate
        Return dtpNewDiscountEndDate.MinDate.Date
    End Function

    Private Function generateDiscountID() As String
        Dim newDiscountID As String = 0
        Dim intRecordCount As Integer

        Dim sql As String
        Dim command As SqlCommand
        If OpenConnection() = True Then

            sql = "Select Count(*) from Discount"
            command = New SqlCommand(sql, conn)
            intRecordCount = command.ExecuteScalar

            newDiscountID = String.Format("DC" + "{0:0000}", intRecordCount + 1)
            CloseConnection()
        End If
        Return newDiscountID
    End Function
    Friend Sub loadCheckListProduct()
        Dim adapter As SqlDataAdapter
        Dim dt As New DataTable
        Dim sql As String

        txtNewDiscountName.Select()
        If OpenConnection() = True Then

            sql = "Select productID, productName from Product Where (productCategory = 'Book' OR productCategory = 'Stationery') And productStatus = 'Available'"
            adapter = New SqlDataAdapter(sql, conn)
            adapter.Fill(dt)

            clbNewDiscountSelectedProduct.DataSource = dt
            clbNewDiscountSelectedProduct.DisplayMember = "productName"
            clbNewDiscountSelectedProduct.ValueMember = "productID"
            CloseConnection()
            'validateAvailableDiscountProduct()
        End If
    End Sub

    'Friend Sub loadCheckListProduct() original
    '    Dim adapter As SqlDataAdapter
    '    Dim dt As New DataTable
    '    Dim sql As String

    '    txtNewDiscountName.Select()
    '    If OpenConnection() = True Then

    '        sql = "Select productID, productName from Product Where (productCategory = 'Book' OR productCategory = 'Stationery') And productStatus = 'Available'"
    '        adapter = New SqlDataAdapter(sql, conn)
    '        adapter.Fill(dt)

    '        clbNewDiscountSelectedProduct.DataSource = dt
    '        clbNewDiscountSelectedProduct.DisplayMember = "productName"
    '        clbNewDiscountSelectedProduct.ValueMember = "productID"
    '        CloseConnection()
    '        'validateAvailableDiscountProduct()
    '    End If
    'End Sub

    Private Sub btnAddNewDiscount_Click(sender As Object, e As EventArgs) Handles btnAddNewDiscount.Click

        listSelectedProduct.Clear()
        getCheckProductList()
        Dim strErrorMessage As New StringBuilder()
        Dim control As Control = Nothing

        If String.IsNullOrEmpty(txtNewDiscountName.Text.Trim) = True Then
            strErrorMessage.AppendLine("- Discount Name Must Be Filled")
            control = If(control, txtNewDiscountName)
        End If

        If IsNumeric(txtNewDiscountPercentage.Text) = False Then
            strErrorMessage.AppendLine("- Invalid Discount Percentage ")
            control = If(control, txtNewDiscountPercentage)
        ElseIf Decimal.Parse(txtNewDiscountPercentage.Text) < 1 Then
            strErrorMessage.AppendLine("- Discount Percentage can't be 0 ")
            control = If(control, txtNewDiscountPercentage)
        ElseIf Decimal.Parse(txtNewDiscountPercentage.Text) > 99 Then
            strErrorMessage.AppendLine("- Discount Percentage can't over 100 ")
            control = If(control, txtNewDiscountPercentage)
        End If

        If String.IsNullOrEmpty(txtNewDiscountDesc.Text.Trim) = True Then
            strErrorMessage.AppendLine("- Discount Description must be filled")
            control = If(control, txtNewDiscountDesc)
        End If

        If clbNewDiscountSelectedProduct.CheckedItems.Count < 1 Then
            strErrorMessage.AppendLine("- At least one product must be selected!")
            control = If(control, clbNewDiscountSelectedProduct)
        End If

        If strErrorMessage.Length > 0 Then
            MessageBox.Show(strErrorMessage.ToString, "Inpur Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            control.Focus()
            Return
        Else
            Dim strConfirmMessage As String = "Confirm add new discount promotions " + txtNewDiscountName.Text + " with ID " + lblNewDiscountID.Text + " ?"

            Dim result As DialogResult = MessageBox.Show(strConfirmMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.Yes Then
                AddDiscount()
                ViewAllDiscount.gvViewDiscount.DataSource = ViewAllDiscount.loadAllDiscount()
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Actions Cancel!", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

    End Sub

    Private Sub AddDiscount()
        strNewDiscountID = lblNewDiscountID.Text
        strNewDiscountName = txtNewDiscountName.Text
        intDiscountPercentage = Int32.Parse(txtNewDiscountPercentage.Text)
        dateSelectedStartDate = dtpNewDiscountStartDate.Value
        dateSelectedEndDate = dtpNewDiscountEndDate.Value
        strNewDiscountDescription = txtNewDiscountDesc.Text
        strNewDiscountStatus = "Active"

        Dim sql As String

        Try
            If OpenConnection() = True Then
                sql = "Insert Into Discount ([discountID],[discountName],[discountPercentage],[discountStartDate],[discountEndDate],[discountDescription],[discountStatus]) Values (@discountID, @discountName ,@discountPercentage, @discountStartDate, @discountEndDate , @discountDescription,@discountStatus)"
                Dim cmd As SqlCommand = New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@discountID", strNewDiscountID)
                cmd.Parameters.AddWithValue("@discountName", strNewDiscountName)
                cmd.Parameters.AddWithValue("@discountPercentage", intDiscountPercentage)
                cmd.Parameters.AddWithValue("@discountStartDate", dateSelectedStartDate)
                cmd.Parameters.AddWithValue("@discountEndDate", dateSelectedEndDate)
                cmd.Parameters.AddWithValue("@discountDescription", strNewDiscountDescription)
                cmd.Parameters.AddWithValue("@discountStatus", strNewDiscountStatus)

                cmd.ExecuteNonQuery()
                CloseConnection()
                AddDiscountProduct()

                'MessageBox.Show("New Discount Promotion Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("No its fail", "Hmmmmm", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try

    End Sub

    Private Sub AddDiscountProduct()

        Dim sql As String
        If OpenConnection() = True Then
            Try
                sql = "Insert Into DiscountProduct ([discountID],[productID]) Values (@discountID, @productID)"
                'Dim cmd As SqlCommand = New SqlCommand(sql, conn)

                'For i As Integer = 0 To intCount
                '    cmd.Parameters.AddWithValue("@discountID", strTemp)
                '    cmd.Parameters.AddWithValue("@productID", listSelectedProduct(i))
                '    cmd.ExecuteNonQuery()
                'Next
                Dim cmd As SqlCommand = New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@discountID", "")
                cmd.Parameters.AddWithValue("@productID", "")
                For i As Integer = 0 To listSelectedProduct.Count - 1
                    cmd.Parameters("@discountID").Value = strNewDiscountID
                    cmd.Parameters("@productID").Value = listSelectedProduct(i)
                    cmd.ExecuteNonQuery()
                Next

                MessageBox.Show("Discount Product Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                CloseConnection()
                btnClear_Click(Nothing, Nothing)
                listSelectedProduct.Clear()
                activateDiscountPrice()
                Me.Close()

            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Hmmmmm", MessageBoxButtons.OK, MessageBoxIcon.Question)
            End Try
            CloseConnection()
        End If
    End Sub

    Private Sub getCheckProductList()
        For Each item As Object In clbNewDiscountSelectedProduct.CheckedItems
            Dim row As DataRowView = TryCast(item, DataRowView)
            listSelectedProduct.Add(row("productID"))
        Next
        'Dim count As Integer = listSelectedProduct.Count
        'Dim str As String
        'For Each str In listSelectedProduct
        '    lblTest.Text += str
        'Next
        'lblTest.Text = count
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim strConfirmMessage As String = "Confirm cancel editing discount with ID " + lblNewDiscountID.Text + " ?" + vbCrLf +
                                            "Your edited information will not be save."

        Dim result As DialogResult = MessageBox.Show(strConfirmMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            btnClear_Click(Nothing, Nothing)
            ViewAllDiscount.gvViewDiscount.DataSource = ViewAllDiscount.loadAllDiscount()
            Me.Close()
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Actions Cancel!", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNewDiscountDesc.Clear()
        txtNewDiscountName.Clear()
        txtNewDiscountPercentage.Clear()
        txtNewDiscountName.Select()
        For i = 0 To clbNewDiscountSelectedProduct.Items.Count - 1
            clbNewDiscountSelectedProduct.SetItemChecked(i, False)
        Next
        dtpNewDiscountStartDate.Value = DateTime.Now
        dtpNewDiscountEndDate.Value = (DateTime.Now).AddDays(1)
        listSelectedProduct.Clear()
    End Sub

    Friend Sub activateDiscountPrice()
        listOfDiscountPercentage.Clear()
        listOfDiscountProduct.Clear()
        listOfProductOriginalPrice.Clear()
        listOfUpdateDiscountPrice.Clear()
        listOfActivateDiscountID.Clear()

        Dim dateToday As Date = Date.Today
        Dim decDiscountPrice As Decimal

        If OpenConnection() = True Then
            Try
                Dim sdr As SqlDataReader
                Dim sql As String
                sql = "Select Discount.discountPercentage, DiscountProduct.productID, Product.productOriginalPrice, DiscountProduct.discountID From DiscountProduct, Product, Discount Where Discount.discountID = DiscountProduct.discountID And DiscountProduct.productID = Product.productID And Discount.discountStatus = 'Active' And Discount.discountStartDate <= @dateToday"
                Dim cmd As SqlCommand = New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@dateToday", dateToday)
                sdr = cmd.ExecuteReader()
                If sdr.HasRows Then
                    While sdr.Read
                        listOfDiscountPercentage.Add(sdr.GetValue(0).ToString())
                        listOfDiscountProduct.Add(sdr.GetValue(1).ToString())
                        listOfProductOriginalPrice.Add(sdr.GetValue(2).ToString())
                        listOfActivateDiscountID.Add(sdr.GetValue(3).ToString())
                    End While
                End If

                For i As Integer = 0 To (listOfDiscountProduct.Count - 1)
                    decDiscountPrice = listOfProductOriginalPrice(i) - (listOfProductOriginalPrice(i) * listOfDiscountPercentage(i) / 100)
                    listOfUpdateDiscountPrice.Add(decDiscountPrice)
                Next

            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            CloseConnection()
        Else
            MessageBox.Show("Error in connecting to database server", "Error", MessageBoxButtons.OK)
        End If
        updateDiscountPrice()
    End Sub

    Friend Sub updateDiscountPrice()
        Dim sql As String
        If OpenConnection() = True Then
            Try
                sql = "Update Product Set productDiscountPrice = @productDiscountPrice Where productID = @productID"
                Dim cmd As SqlCommand = New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@productDiscountPrice", "")
                cmd.Parameters.AddWithValue("@productID", "")
                For i As Integer = 0 To listOfDiscountProduct.Count - 1
                    cmd.Parameters("@productDiscountPrice").Value = listOfUpdateDiscountPrice(i)
                    cmd.Parameters("@productID").Value = listOfDiscountProduct(i)
                    cmd.ExecuteNonQuery()
                Next

                CloseConnection()

                'MessageBox.Show("Discount Information Modified Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Hmmmmm", MessageBoxButtons.OK, MessageBoxIcon.Question)
            End Try
            CloseConnection()
            activateDiscountStatus()
        End If
    End Sub

    Private Sub activateDiscountStatus()
        Dim strNewDiscountStatus As String = "Ongoing"
        Dim strActivatedMessage As String = String.Empty
        Dim intCountActivate As Integer = 0
        Dim sql As String

        If OpenConnection() = True Then
            Try
                sql = "Update Discount Set discountStatus = @strNewDiscountStatus Where discountStatus = 'Active' And discountID = @discountID"
                Dim cmd As SqlCommand = New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@strNewDiscountStatus", "")
                cmd.Parameters.AddWithValue("@discountID", "")
                For i As Integer = 0 To listOfActivateDiscountID.Count - 1
                    cmd.Parameters("@strNewDiscountStatus").Value = strNewDiscountStatus
                    cmd.Parameters("@discountID").Value = listOfActivateDiscountID(i)
                    cmd.ExecuteNonQuery()
                Next
                cmd.ExecuteNonQuery()
                Dim ListOfUpdates As List(Of String) = listOfActivateDiscountID.Distinct.ToList
                For i As Integer = 0 To ListOfUpdates.Count - 1
                    intCountActivate = intCountActivate + 1
                    strActivatedMessage += intCountActivate.ToString & ". " & ListOfUpdates(i) & vbNewLine
                Next
                If strActivatedMessage = String.Empty = False Then
                    'MessageBox.Show("Discount promotion for " & vbNewLine & strActivatedMessage & "has been activated!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    strNotification += vbNewLine & "List of activated discount ID: " & vbNewLine & strActivatedMessage
                End If
                CloseConnection()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Hmmmmm", MessageBoxButtons.OK, MessageBoxIcon.Question)
            End Try
            CloseConnection()
        End If
    End Sub


End Class