Public Class FormOpenCounter

#Region "keypad function"
    Private amountStr As String = ""
    Private Sub editLabel(value As Integer)

        If amountStr = "" And value = 0 Then
            Exit Sub
        End If

        Dim checkDecimal As Integer = amountStr.Length - amountStr.IndexOf(".")
        If amountStr.Contains(".") And checkDecimal > 2 Then
            Exit Sub
        End If

        amountStr += value.ToString()
        lblDisplay.Text = amountStr

    End Sub
    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        If amountStr.Contains(".") = False Then
            amountStr += "."
        End If
        lblDisplay.Text = amountStr
    End Sub
    Private Sub btnBackspace_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
        If amountStr.Length <> 0 Then
            amountStr = amountStr.Substring(0, amountStr.Length - 1)
            lblDisplay.Text = amountStr
        Else
            Exit Sub
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        editLabel(Integer.Parse(Button1.Text))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        editLabel(Integer.Parse(Button2.Text))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        editLabel(Integer.Parse(Button3.Text))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        editLabel(Integer.Parse(Button4.Text))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        editLabel(Integer.Parse(Button5.Text))
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        editLabel(Integer.Parse(Button6.Text))
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        editLabel(Integer.Parse(Button7.Text))
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        editLabel(Integer.Parse(Button8.Text))
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        editLabel(Integer.Parse(Button9.Text))
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        editLabel(Integer.Parse(Button0.Text))
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        amountStr = ""
        lblDisplay.Text = amountStr
    End Sub
#End Region

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Try

            Dim result As DialogResult = MessageBox.Show("Confirm Open Counter Amount?", "Open Counter Amount Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Dim amount As Decimal = Decimal.Parse(amountStr)
                openCounterAmount = amount
                hasOpenCounter = True
                Me.Close()
                FrmHome.FrmHome_Load(Nothing, Nothing)
            End If

        Catch ex As Exception
            MessageBox.Show("Please enter a valid quantity!", "Open Counter Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub FormOpenCounter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        amountStr = ""
        lblDisplay.Focus()
    End Sub
End Class