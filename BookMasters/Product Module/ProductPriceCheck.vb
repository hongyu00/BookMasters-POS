Public Class ProductPriceCheck
    Friend strPriceCheckProductID As String
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        strPriceCheckProductID = txtSearchProduct.Text
        PriceCheckResult.ShowDialog()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearchProduct.Clear()
        txtSearchProduct.Select()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ProductPriceCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearchProduct.Focus()
        txtSearchProduct.Text = ""
    End Sub

    Private Sub pnlHeader_Paint(sender As Object, e As PaintEventArgs) Handles pnlHeader.Paint

    End Sub

    Private Sub txtSearchProduct_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProduct.TextChanged

    End Sub
End Class