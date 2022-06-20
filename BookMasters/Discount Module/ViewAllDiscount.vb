Imports System.Data.SqlClient
Public Class ViewAllDiscount
    Friend strSelectedDiscountRecord As String

    Friend Sub ViewAllDiscount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gvViewDiscount.DataSource = loadAllDiscount()
    End Sub

    Friend Function loadAllDiscount() As DataTable
        btnAddNewDiscount.Enabled = True
        Dim adapter As SqlDataAdapter
        Dim dt As New DataTable
        Dim sql As String
        If OpenConnection() = True Then
            sql = "Select * from Discount Where discountID LIKE '%' + @SearchData + '%' OR discountName LIKE '%' + @SearchData + '%' OR discountPercentage LIKE '%' + @SearchData + '%' OR discountStatus LIKE '%' + @SearchData + '%' OR @SearchData= ''"
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@SearchData", txtSearchDiscount.Text.Trim())
            Try
                adapter = New SqlDataAdapter(cmd)
                adapter.Fill(dt)
                dt.Columns(0).ColumnName = "Discount ID"
                dt.Columns(1).ColumnName = "Discount Name"
                dt.Columns(2).ColumnName = "Discount Percentage (%)"
                dt.Columns(3).ColumnName = "Discount Start Date"
                dt.Columns(4).ColumnName = "Discount End Date"
                dt.Columns(5).ColumnName = "Discount Description"
                dt.Columns(6).ColumnName = "Discount Status"

                If UserLogin.strCurrentLoginStaffRole = "MANAGER" Then
                    btnAddNewDiscount.Enabled = True
                Else
                    btnAddNewDiscount.Enabled = False
                End If

            Catch ex As Exception
                MessageBox.Show("Error Occurs!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            CloseConnection()
        End If
        Return dt
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddNewDiscount.Click
        AddNewDiscount.ShowDialog()
    End Sub

    Private Sub txtSearchDiscount_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearchDiscount.KeyUp
        gvViewDiscount.DataSource = loadAllDiscount()
    End Sub

    Private Sub gvDiscount_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gvViewDiscount.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            strSelectedDiscountRecord = gvViewDiscount.Rows(e.RowIndex).Cells(0).Value.ToString
            'MessageBox.Show(strSelectedDiscountRecord, "Hahah")
            ViewSelectedDiscountDetails.ShowDialog()
        End If
    End Sub
End Class