Imports System.Data.SqlClient
Imports System.Text

Public Class EditDiscountInfo
    Private strUpdateDiscountName As String
    Private strUpdateDiscountDescription As String
    Private intUpdateDiscountPercentage As Integer
    Private dateUpdateStartDate As Date
    Private dateUpdateEndDate As Date
    Private strUpdateDiscountStatus As String
    Private listUpdateProduct As New List(Of String)
    Private listSelectedProduct As New List(Of String)
    Friend listOfDiscountProduct As New List(Of String)
    Friend listOfDeactivateDiscountID As New List(Of String)
    Private Sub EditDiscountInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUpdateDiscountPercentage.Enabled = True
        validateStartDate()
        loadSelectedDiscountInfo()
        loadCheckListProduct()
        listSelectedProduct.Clear()
        loadCheckedProduct()
        'checkedSelectedProduct()
        loadAllDicountStatus()
        verifyDiscountStatus()
    End Sub

    Private Sub checkedSelectedProduct()
        'For i As Integer = 0 To listSelectedProduct.Count - 1
        '    If (listSelectedProduct.Contains(clbSelectedDiscountProduct.Items(i).ToString())) Then
        '        clbSelectedDiscountProduct.SetItemChecked(i, True)
        '    End If
        'Next
        Dim strContent As String
        For i As Integer = 0 To clbSelectedDiscountProduct.Items.Count - 1
            Dim view As DataRowView = clbSelectedDiscountProduct.Items(i)
            strContent = view("productName").ToString
            If listSelectedProduct.Contains(strContent) Then
                clbSelectedDiscountProduct.SetItemChecked(i, True)
            End If
        Next
    End Sub

    Private Sub loadCheckedProduct()
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
                        listSelectedProduct.Add(sdr.GetValue(1).ToString())
                    End While
                End If
                checkedSelectedProduct()
            Catch ex As Exception
                MessageBox.Show("Error occurs when load checked products!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            'Dim str As String
            'For Each str In listSelectedProduct
            '    lblTest.Text += str + vbCrLf
            'Next
            CloseConnection()
        End If
    End Sub

    Private Sub loadCheckListProduct()
        Dim adapter As SqlDataAdapter
        Dim dt As New DataTable
        Dim sql As String

        'txtUpdateDiscountName.Select()

        If OpenConnection() = True Then

            sql = "Select productID, productName from Product Where (productCategory = 'Book' OR productCategory = 'Stationery') And productStatus = 'Available'"
            adapter = New SqlDataAdapter(sql, conn)
            adapter.Fill(dt)

            clbSelectedDiscountProduct.DataSource = dt
            clbSelectedDiscountProduct.DisplayMember = "productName"
            clbSelectedDiscountProduct.ValueMember = "productID"

            CloseConnection()
        End If
    End Sub

    Private Sub loadSelectedDiscountInfo()
        lblNewDiscountID.Text = ViewAllDiscount.strSelectedDiscountRecord
        txtUpdateDiscountName.Text = ViewSelectedDiscountDetails.strSelectedDiscountName
        txtUpdateDiscountPercentage.Text = ViewSelectedDiscountDetails.intSelectedDiscountPercentage
        'dtpUpdateDiscountStartDate.MinDate = ViewSelectedDiscountDetails.dateSelectedDiscountStartDate.Date
        'dtpUpdateDiscountEndDate.MinDate = ViewSelectedDiscountDetails.dateSelectedDiscountEndDate.Date
        dtpUpdateDiscountStartDate.Value = ViewSelectedDiscountDetails.dateSelectedDiscountStartDate.Date
        dtpUpdateDiscountEndDate.Value = ViewSelectedDiscountDetails.dateSelectedDiscountEndDate.Date
        txtUpdateDiscountDesc.Text = ViewSelectedDiscountDetails.strSelectedDiscountDesc
        If ViewSelectedDiscountDetails.strSelectedDiscountStatus = "Ongoing" Then
            txtUpdateDiscountPercentage.Enabled = False
        End If

    End Sub

    Friend Sub validateStartDate()
        If ViewSelectedDiscountDetails.strSelectedDiscountStatus = "Active" Then
            dtpUpdateDiscountStartDate.MinDate = Now.Date
        ElseIf ViewSelectedDiscountDetails.strSelectedDiscountStatus = "Ongoing" Then
            dtpUpdateDiscountStartDate.MinDate = ViewSelectedDiscountDetails.dateSelectedDiscountStartDate.Date
            dtpUpdateDiscountEndDate.MinDate = Now.Date
            dtpUpdateDiscountStartDate.Enabled = False
        End If
    End Sub

    Friend Sub validateEndDate()
        Dim dateCalDayAfterStartDate As Date
        dateCalDayAfterStartDate = (dtpUpdateDiscountStartDate.Value).AddDays(1)
        dtpUpdateDiscountEndDate.MinDate = dateCalDayAfterStartDate.Date
        'dtpUpdateDiscountEndDate.Value = dateCalDayAfterStartDate
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        listUpdateProduct.Clear()
        getCheckProductList()

        Dim strErrorMessage As New StringBuilder()
        Dim control As Control = Nothing

        If String.IsNullOrEmpty(txtUpdateDiscountName.Text.Trim) = True Then
            strErrorMessage.AppendLine("- Discount name must be filled")
            control = If(control, txtUpdateDiscountName)
        End If
        If IsNumeric(txtUpdateDiscountPercentage.Text) = False Then
            strErrorMessage.AppendLine("- Invalid Discount Percentage ")
            control = If(control, txtUpdateDiscountPercentage)
        ElseIf Decimal.Parse(txtUpdateDiscountPercentage.Text) < 1 Then
            strErrorMessage.AppendLine("- Discount Percentage can't be 0 ")
            control = If(control, txtUpdateDiscountPercentage)
        ElseIf Decimal.Parse(txtUpdateDiscountPercentage.Text) > 99 Then
            strErrorMessage.AppendLine("- Discount Percentage can't over 100 ")
            control = If(control, txtUpdateDiscountPercentage)
        End If

        If String.IsNullOrEmpty(txtUpdateDiscountDesc.Text.Trim) = True Then
            strErrorMessage.AppendLine("- Discount Description must be filled")
            control = If(control, txtUpdateDiscountDesc)
        End If

        If clbSelectedDiscountProduct.CheckedItems.Count < 1 Then
            strErrorMessage.AppendLine("- At least one product must be selected!")
            control = If(control, clbSelectedDiscountProduct)
        End If

        If strErrorMessage.Length > 0 Then
            MessageBox.Show(strErrorMessage.ToString, "Inpur Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            control.Focus()
            Return
        Else
            Dim strConfirmMessage As String = "Confirm edit discount with ID " + ViewAllDiscount.strSelectedDiscountRecord + " ?"

            Dim result As DialogResult = MessageBox.Show(strConfirmMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.Yes Then
                'getUncheckedItems()
                UpdateDiscountInfo()
                'ClearDiscountPrice()
                ViewAllDiscount.gvViewDiscount.DataSource = ViewAllDiscount.loadAllDiscount()
                ViewSelectedDiscountDetails.Close()
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Actions Cancel!", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        End If
    End Sub

    Private Sub UpdateDiscountInfo()
        strUpdateDiscountName = txtUpdateDiscountName.Text
        strUpdateDiscountDescription = txtUpdateDiscountDesc.Text
        intUpdateDiscountPercentage = Int32.Parse(txtUpdateDiscountPercentage.Text)
        dateUpdateStartDate = dtpUpdateDiscountStartDate.Value
        dateUpdateEndDate = dtpUpdateDiscountEndDate.Value
        strUpdateDiscountStatus = cboDiscountStatus.Text

        If strUpdateDiscountStatus = "Cancelled" Then
            cancelledDiscountPrice()
        End If

        Dim sql As String
        If OpenConnection() = True Then

            Try
                sql = "Update Discount Set discountName = @discountName, discountPercentage = @discountPercentage, discountStartDate = @discountStartDate, discountEndDate = @discountEndDate, discountDescription = @discountDescription, discountStatus = @discountStatus Where discountID = @discountID"
                Dim cmd As SqlCommand = New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@discountID", ViewAllDiscount.strSelectedDiscountRecord)
                cmd.Parameters.AddWithValue("@discountName", strUpdateDiscountName)
                cmd.Parameters.AddWithValue("@discountPercentage", intUpdateDiscountPercentage)
                cmd.Parameters.AddWithValue("@discountStartDate", dateUpdateStartDate)
                cmd.Parameters.AddWithValue("@discountEndDate", dateUpdateEndDate)
                cmd.Parameters.AddWithValue("@discountDescription", strUpdateDiscountDescription)
                cmd.Parameters.AddWithValue("@discountStatus", strUpdateDiscountStatus)

                cmd.ExecuteNonQuery()

                'MessageBox.Show("Discount Information Modified Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CloseConnection()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("No its fail", "Hmmmmm", MessageBoxButtons.OK, MessageBoxIcon.Question)
            End Try
            CloseConnection()
            ClearDiscountProduct()
        End If
    End Sub

    Private Sub ClearDiscountPrice()
        Dim listOfRemovePrice As New List(Of String)
        listOfRemovePrice = listUpdateProduct
        Dim nullPrice As String = Nothing
        Dim sql As String
        If OpenConnection() = True Then
            Try
                sql = "Update Product Set productDiscountPrice = @productDiscountPrice Where productID = @productID"
                Dim cmd As SqlCommand = New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@productDiscountPrice", "")
                cmd.Parameters.AddWithValue("@productID", "")
                For i As Integer = 0 To listOfRemovePrice.Count - 1
                    cmd.Parameters("@productDiscountPrice").Value = If(String.IsNullOrEmpty(nullPrice), DBNull.Value, nullPrice)
                    cmd.Parameters("@productID").Value = listOfRemovePrice(i)
                    cmd.ExecuteNonQuery()
                Next
                'MessageBox.Show("Discount Information Modified Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CloseConnection()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Hmmmmm", MessageBoxButtons.OK, MessageBoxIcon.Question)
            End Try
            CloseConnection()
        End If
        UpdateDiscountPrice()
    End Sub

    Private Sub UpdateDiscountPrice()

    End Sub

    Private Sub ClearDiscountProduct()
        Dim sql As String
        If OpenConnection() = True Then
            Try
                sql = "Delete From DiscountProduct Where discountID = @discountID"
                Dim cmd As SqlCommand = New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@discountID", ViewAllDiscount.strSelectedDiscountRecord)

                cmd.ExecuteNonQuery()
                'MessageBox.Show("Clear Previous Discount Product Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Hmmmmm", MessageBoxButtons.OK, MessageBoxIcon.Question)
            End Try
            CloseConnection()
            'listSelectedProduct.Clear()
            UpdateDiscountProduct()
            Me.Close()
        End If
    End Sub

    Private Sub UpdateDiscountProduct()
        Dim sql As String
        Try
            If OpenConnection() = True Then
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
                For i As Integer = 0 To listUpdateProduct.Count - 1
                    cmd.Parameters("@discountID").Value = ViewAllDiscount.strSelectedDiscountRecord
                    cmd.Parameters("@productID").Value = listUpdateProduct(i)
                    cmd.ExecuteNonQuery()
                Next
                MessageBox.Show("Discount Product Modified Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CloseConnection()
                listSelectedProduct.Clear()
                AddNewDiscount.activateDiscountPrice()
                deactivateDiscountPrice()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Hmmmmm", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try

    End Sub

    Private Sub dtpUpdateDiscountStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpUpdateDiscountStartDate.ValueChanged
        validateEndDate()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim strConfirmMessage As String = "Confirm cancel editing discount promotion with ID " + lblNewDiscountID.Text + " ?" + vbCrLf +
                                            "Your edited information will not be save."

        Dim result As DialogResult = MessageBox.Show(strConfirmMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Me.Close()
            For i = 0 To clbSelectedDiscountProduct.Items.Count - 1
                clbSelectedDiscountProduct.SetItemChecked(i, False)
            Next
            listUpdateProduct.Clear()
            listSelectedProduct.Clear()
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Actions Cancel!", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        'lblTestCOunt.Text = listSelectedProduct.Count
    End Sub

    Private Sub loadAllDicountStatus()

        If OpenConnection() = True Then

            Dim sda As New SqlDataAdapter("Select DISTINCT discountStatus From Discount ", conn)
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)

            cboDiscountStatus.DataSource = dt
            cboDiscountStatus.DisplayMember = "discountStatus"
            cboDiscountStatus.ValueMember = "discountStatus"
            CloseConnection()
        End If
    End Sub

    Private Sub verifyDiscountStatus()
        If ViewSelectedDiscountDetails.strSelectedDiscountStatus = "Cancelled" Then
            cboDiscountStatus.SelectedValue = "Cancelled"
            cboDiscountStatus.Enabled = False
        ElseIf ViewSelectedDiscountDetails.strSelectedDiscountStatus = "Active" Then
            loadActiveStatusMode()
            cboDiscountStatus.SelectedValue = "Active"
            cboDiscountStatus.Enabled = True
        ElseIf ViewSelectedDiscountDetails.strSelectedDiscountStatus = "Ongoing" Then
            loadOngoingStatusMode()
            cboDiscountStatus.SelectedValue = "Ongoing"
            cboDiscountStatus.Enabled = True
        End If
    End Sub

    Private Sub loadOngoingStatusMode()
        If OpenConnection() = True Then

            Dim sda As New SqlDataAdapter("Select DISTINCT discountStatus From Discount Where discountStatus = 'Ongoing' Or discountStatus = 'Cancelled' ", conn)
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)
            cboDiscountStatus.DataSource = dt
            cboDiscountStatus.DisplayMember = "discountStatus"
            cboDiscountStatus.ValueMember = "discountStatus"
            CloseConnection()
        End If
    End Sub

    Private Sub loadActiveStatusMode()
        If OpenConnection() = True Then

            Dim sda As New SqlDataAdapter("Select DISTINCT discountStatus From Discount Where discountStatus = 'Active' Or discountStatus = 'Cancelled' ", conn)
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)
            cboDiscountStatus.DataSource = dt
            cboDiscountStatus.DisplayMember = "discountStatus"
            cboDiscountStatus.ValueMember = "discountStatus"
            CloseConnection()
        End If
    End Sub

    Private Sub getCheckProductList()
        For Each item As Object In clbSelectedDiscountProduct.CheckedItems
            Dim row As DataRowView = TryCast(item, DataRowView)
            listUpdateProduct.Add(row("productID"))
            Debug.WriteLine(item.GetType)
        Next
        'Dim count As Integer = listSelectedProduct.Count
        'Dim str As String
        'For Each str In listSelectedProduct
        '    lblTest.Text += str
        'Next
        'lblTest.Text = count
    End Sub

    'Private Sub getUncheckedItems()
    '    listOfDiscountProduct.Clear()
    '    For Each item As CheckBox In clbSelectedDiscountProduct.Items
    '        If item.Checked = False Then
    '            'Dim row As DataRowView = TryCast(item, DataRowView)
    '            listUpdateProduct.Add(clbSelectedDiscountProduct.ValueMember)
    '        End If
    '    Next
    '    removeDiscountprice()
    'End Sub

    Friend Sub cancelledDiscountPrice()
        listOfDiscountProduct.Clear()

        If OpenConnection() = True Then
            Try
                Dim sdr As SqlDataReader
                Dim sql As String
                sql = "Select DiscountProduct.productID, DiscountProduct.discountID From DiscountProduct, Discount Where Discount.discountID = DiscountProduct.discountID And Discount.discountID = @selectedDiscountID"
                Dim cmd As SqlCommand = New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@selectedDiscountID", ViewAllDiscount.strSelectedDiscountRecord)
                sdr = cmd.ExecuteReader()
                If sdr.HasRows Then
                    While sdr.Read
                        listOfDiscountProduct.Add(sdr.GetValue(0).ToString())
                        listOfDeactivateDiscountID.Add(sdr.GetValue(1).ToString())
                    End While
                End If

            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            CloseConnection()
        End If
        removeDiscountprice()
        UpdateCancelledDiscountStatus()
    End Sub
    Friend Sub deactivateDiscountPrice()
        listOfDiscountProduct.Clear()
        Dim dateToday As Date = Date.Today

        If OpenConnection() = True Then
            Try
                Dim sdr As SqlDataReader
                Dim sql As String
                sql = "Select DiscountProduct.productID, DiscountProduct.discountID From DiscountProduct, Discount Where Discount.discountID = DiscountProduct.discountID And Discount.discountStatus = 'Ongoing' And Discount.discountEndDate <= @dateToday"
                Dim cmd As SqlCommand = New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@dateToday", dateToday)
                sdr = cmd.ExecuteReader()
                If sdr.HasRows Then
                    While sdr.Read
                        listOfDiscountProduct.Add(sdr.GetValue(0).ToString())
                        listOfDeactivateDiscountID.Add(sdr.GetValue(1).ToString())
                    End While
                End If

            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            CloseConnection()
        End If
        removeDiscountprice()
        UpdateEndedDiscountStatus()
    End Sub

    Friend Sub removeDiscountprice()
        Dim nullPrice As String = Nothing
        Dim sql As String

        Try
            If OpenConnection() = True Then

                sql = "Update Product Set productDiscountPrice = @productDiscountPrice Where productID = @productID"
                Dim cmd As SqlCommand = New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@productDiscountPrice", "")
                cmd.Parameters.AddWithValue("@productID", "")
                For i As Integer = 0 To listOfDiscountProduct.Count - 1
                    cmd.Parameters("@productDiscountPrice").Value = If(String.IsNullOrEmpty(nullPrice), DBNull.Value, nullPrice)
                    cmd.Parameters("@productID").Value = listOfDiscountProduct(i)
                    cmd.ExecuteNonQuery()
                Next
                'MessageBox.Show("Discount Information Modified Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CloseConnection()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Hmmmmm", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try
    End Sub

    Friend Sub UpdateCancelledDiscountStatus()
        Dim sql As String

        Try
            If OpenConnection() = True Then

                sql = "Update Discount Set discountStatus = @discountStatus Where (discountStatus = 'Ongoing' OR discountStatus = 'Active') And discountID = @discountID"
                Dim cmd As SqlCommand = New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@discountStatus", "")
                cmd.Parameters.AddWithValue("@discountID", "")
                For i As Integer = 0 To listOfDeactivateDiscountID.Count - 1
                    cmd.Parameters("@discountStatus").Value = "Cancelled"
                    cmd.Parameters("@discountID").Value = listOfDeactivateDiscountID(i)
                    cmd.ExecuteNonQuery()
                Next
                'MessageBox.Show("Discount Information Modified Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CloseConnection()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Hmmmmm", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try
    End Sub

    Friend Sub UpdateEndedDiscountStatus()
        Dim sql As String
        Dim strDeactivatedMessage As String = String.Empty
        Dim intCountDeactivate As Integer = 0

        Try
            If OpenConnection() = True Then

                sql = "Update Discount Set discountStatus = @discountStatus Where (discountStatus = 'Ongoing' OR discountStatus = 'Active') And discountID = @discountID"
                Dim cmd As SqlCommand = New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@discountStatus", "")
                cmd.Parameters.AddWithValue("@discountID", "")
                For i As Integer = 0 To listOfDeactivateDiscountID.Count - 1
                    cmd.Parameters("@discountStatus").Value = "Ended"
                    cmd.Parameters("@discountID").Value = listOfDeactivateDiscountID(i)
                    cmd.ExecuteNonQuery()
                Next
                Dim ListOfUpdates As List(Of String) = listOfDeactivateDiscountID.Distinct.ToList
                For i As Integer = 0 To ListOfUpdates.Count - 1
                    intCountDeactivate = intCountDeactivate + 1
                    strDeactivatedMessage += intCountDeactivate.ToString & ". " & ListOfUpdates(i) & vbNewLine
                Next
                If strDeactivatedMessage = String.Empty = False Then
                    'MessageBox.Show("Discount promotion for " & vbNewLine & strDeactivatedMessage & "has been ended!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    strNotification += vbNewLine & "List of deactivated discount ID: " & vbNewLine & strDeactivatedMessage
                End If

                CloseConnection()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Hmmmmm", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try
    End Sub

End Class