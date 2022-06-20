Public Class FrmHome
    Friend Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tooltip As ToolTip = New ToolTip()
        tooltip.ToolTipIcon = ToolTipIcon.Info
        tooltip.IsBalloon = True
        tooltip.ShowAlways = True
        tooltip.SetToolTip(lblVarious, "Difference between amount collected and expected amount")

        lblExpectedCash.Text = totalPaymentByCash.ToString("C")
        lblOpenCounter.Text = openCounterAmount.ToString("C")
        lblOpenCounter2.Text = openCounterAmount.ToString("C")
        lblCashCounter.Text = cashCounterAmount.ToString("C")
        lblVariousAmount.Text = variousAmount.ToString("C")
        lblStatus.Text = closeCounterStatus
    End Sub
    Private Sub btnOpenCounter_Click(sender As Object, e As EventArgs) Handles btnOpenCounter.Click
        If hasOpenCounter And hasCloseCounter Then

        ElseIf hasOpenCounter Then
            Dim resultChange As DialogResult = MessageBox.Show("Your previous open counter amount was RM " + openCounterAmount.ToString() + ". Do you want to modify it?", "Open Counter Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If resultChange = DialogResult.Yes Then
                FormOpenCounter.ShowDialog()
            Else
                Exit Sub
            End If
        Else
            FormOpenCounter.ShowDialog()
        End If
    End Sub

    Private Sub btnCloseCounter_Click(sender As Object, e As EventArgs) Handles btnCloseCounter.Click, IconButton1.Click

        If hasOpenCounter And hasCloseCounter Then

            Dim resultChange As DialogResult = MessageBox.Show("Your previous close counter amount was RM " + cashCounterAmount.ToString() + ". Do you want to modify it?", "Close Counter Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If resultChange = DialogResult.Yes Then
                FormCloseCounter.ShowDialog()
            Else
                Exit Sub
            End If


        ElseIf hasOpenCounter Then
            If totalPaymentByCash = 0 Then
                Dim resultChange As DialogResult = MessageBox.Show("There is no cash transaction for you to close counter! Still proceed to close counter?", "Close Counter Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If resultChange = DialogResult.Yes Then
                    FormCloseCounter.ShowDialog()
                Else
                    Exit Sub
                End If
            Else
                FormCloseCounter.ShowDialog()
            End If
        Else
            MessageBox.Show("Open Counter Amount has not been set! Please set Open Counter Amount first before proceed.", "Close Counter Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


End Class