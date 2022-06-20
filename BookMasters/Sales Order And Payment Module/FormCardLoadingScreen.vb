Public Class FormCardLoadingScreen
    Dim time As Integer = 5
    Dim randomValue As Random = New Random
    Private Sub FrmCardLoadingScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTimeLeft.Text = "5 sec remaining"
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        time -= 1
        lblTimeLeft.Text = time.ToString() + " sec remaining"
        'during actual time can set 30/60 sec for transaction duration.
        If time = 0 Then
            Timer1.Stop()
            time = 5
            'set random value because we do not have a real credit card reader, therefore use 0 and 1 to determine whether the transaction is a success or failure
            'If randomValue.Next(0, 2) = 0 Then
            '    Dim result As DialogResult = MessageBox.Show("Transaction success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    If result = DialogResult.OK Then
            '        'store values here
            '        FormCard.lblStatus.Text = "Success"
            '        FormCard.lblTransactionTime.Text = DateTime.Now.ToString()
            '        FormCard.btnPrint.Enabled = True
            '        Me.Close()
            '    End If
            'Else
            '    Dim result As DialogResult = MessageBox.Show("Transaction failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    If result = DialogResult.OK Then
            '        FormCard.lblStatus.Text = "Failed"
            '        FormCard.lblTransactionTime.Text = DateTime.Now.ToString()
            '        FormCard.btnPrint.Enabled = False
            '        Me.Close()
            '    End If
            'End If
            Dim result As DialogResult = MessageBox.Show("Transaction success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If result = DialogResult.OK Then
                'store values here
                FormCard.lblStatus.Text = "Success"
                'FormCard.lblTransactionTime.Text = DateTime.Now.ToString()
                FormCard.btnPrint.Enabled = True
                FormCard.Show()
                Me.Close()

            End If
        End If

    End Sub

End Class