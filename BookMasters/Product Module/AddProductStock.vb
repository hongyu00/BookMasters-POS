Imports System.Data.SqlClient
Imports System.Text

Public Class AddProductStock
    Private intStockIn As Integer
    Private intNewStockIn As Integer
    Private intTotalAddedStock As Integer
    Private intNewTotalAddedStock As Integer
    Private intStockAdd As Integer
    Private Sub AddProductStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getStockIn()
    End Sub

    Private Sub getStockIn()
        txtNewStockQtty.Clear()
        txtNewStockQtty.Select()
        Dim sdr As SqlDataReader
        Dim sql As String

        sql = "Select productStockIn, productQuantity from Product Where productID = @productID"
        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@productID", ViewAllProduct.strSelectedProductRecord)

        Try
            If OpenConnection() = True Then

                sdr = cmd.ExecuteReader()
                sdr.Read()

                txtNewStockQtty.Select()
                intStockIn = sdr("productStockIn").ToString()
                intTotalAddedStock = sdr("productQuantity").ToString()
                lblStockIn.Text = intStockIn
                'txtNewStockQtty.Text = ""
                CloseConnection()
            End If
        Catch ex As Exception
            MessageBox.Show(ViewAllProduct.strSelectedProductRecord, "Hmmmmm", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Me.Close()
        End Try
        'lblTesting.Text = intTotalAddedStock
    End Sub

    'Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    '    'txtNewStockQtty.Clear()
    '    'txtNewStockQtty.Select()
    '    Me.Close()
    '    'ViewSelectedProductDetails.Close()
    'End Sub

    Private Sub txtNewStockQtty_TextChanged(sender As Object, e As EventArgs) Handles txtNewStockQtty.TextChanged
        'checkEnterStockQuantity()
    End Sub

    'Private Sub txtNewStockQtty_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNewStockQtty.Validating
    '    validateStockQuantity()
    'End Sub

    'Private Function validateStockQuantity()
    '    Dim blnError As Boolean = True
    '    If IsNumeric(txtNewStockQtty.Text.Trim) = False Or txtNewStockQtty.Text = "0" Then
    '        epNewStock.SetError(txtNewStockQtty, "Invalid stock quantity")
    '        blnError = False
    '    Else
    '        epNewStock.SetError(txtNewStockQtty, "")
    '    End If

    '    Return blnError

    'End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strErrorMessage As New StringBuilder()
        Dim control As Control = Nothing

        If IsNumeric(txtNewStockQtty.Text) = False Then
            strErrorMessage.AppendLine("- Invalid Product Quantity ")
            control = If(control, txtNewStockQtty)
        ElseIf Decimal.Parse(txtNewStockQtty.Text) < 1 Then
            strErrorMessage.AppendLine("- Product quantity can't be 0 ")
            control = If(control, txtNewStockQtty)
        End If

        If strErrorMessage.Length > 0 Then
            MessageBox.Show(strErrorMessage.ToString, "Inpur Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            control.Focus()
            Return
        Else
            intStockAdd = Int32.Parse(txtNewStockQtty.Text)
            Dim strConfirmMessage As String = "Do you sure want to add " + intStockAdd.ToString + " stocks for " + ViewAllProduct.strSelectedProductRecord.ToString + " ?"

            Dim result As DialogResult = MessageBox.Show(strConfirmMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.Yes Then
                addNewStock()
                updateOutOfStockStatus()
                ViewAllProduct.gvViewProduct.DataSource = ViewAllProduct.loadAllProduct()
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Actions Cancel!", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'Me.Close()
                'ViewSelectedProductDetails.Close()
            End If
        End If
    End Sub

    Private Sub addNewStock()
        'lblTesting.Text = intStockAdd
        'MessageBox.Show("Hi u are here!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        intNewStockIn = intStockIn + intStockAdd
        intNewTotalAddedStock = intTotalAddedStock + intStockAdd
        Dim sql As String

        Try
            If OpenConnection() = True Then
                sql = "Update Product Set productStockIn = @productStockIn, productQuantity = @productQuantity Where productID = @productID"
                Dim cmd As SqlCommand = New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@productID", ViewAllProduct.strSelectedProductRecord)
                cmd.Parameters.AddWithValue("@productStockIn", intNewStockIn)
                cmd.Parameters.AddWithValue("@productQuantity", intNewTotalAddedStock)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Product Stock Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                ViewSelectedProductDetails.Close()
                CloseConnection()
            End If
        Catch ex As Exception
            MessageBox.Show("No its fail", "Hmmmmm", MessageBoxButtons.OK, MessageBoxIcon.Question)
            'Me.Close()
        End Try

        txtNewStockQtty.Clear()
        txtNewStockQtty.Select()
    End Sub

    Private Sub updateOutOfStockStatus()
        Dim sql As String
        Dim strUpdateStatus As String = "Available"
        If ViewSelectedProductDetails.strSelectedProductStatus = "Out Of Stock" Then
            Try
                If OpenConnection() = True Then
                    sql = "Update Product Set productStatus = @productStatus Where productID = @productID"
                    Dim cmd As SqlCommand = New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@productID", ViewAllProduct.strSelectedProductRecord)
                    cmd.Parameters.AddWithValue("@productStatus", strUpdateStatus)
                    cmd.ExecuteNonQuery()
                    'MessageBox.Show("Out Of Stock is updated to active Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    ViewSelectedProductDetails.Close()
                    CloseConnection()
                End If

            Catch ex As Exception
                MessageBox.Show("No its fail", "Hmmmmm", MessageBoxButtons.OK, MessageBoxIcon.Question)
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'txtNewStockQtty.Clear()
        'txtNewStockQtty.Select()
        Dim strConfimationMessage As String = "Do you confirm want to exit now? No stock will be added for " & ViewAllProduct.strSelectedProductRecord
        Dim result As DialogResult = MessageBox.Show(strConfimationMessage, "Confimation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If Result = DialogResult.Yes Then
            Me.Close()
        ElseIf Result = DialogResult.No Then
            MessageBox.Show("Actions Cancel!", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class