<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVoucherUsedShowReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.VoucherUsedReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'VoucherUsedReportViewer
        '
        Me.VoucherUsedReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VoucherUsedReportViewer.LocalReport.ReportEmbeddedResource = "BookMasters.VoucherUsedReport.rdlc"
        Me.VoucherUsedReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.VoucherUsedReportViewer.Name = "VoucherUsedReportViewer"
        Me.VoucherUsedReportViewer.Size = New System.Drawing.Size(800, 450)
        Me.VoucherUsedReportViewer.TabIndex = 0
        '
        'FrmVoucherUsedShowReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.VoucherUsedReportViewer)
        Me.Name = "FrmVoucherUsedShowReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monthly Voucher Used Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VoucherUsedReportViewer As Microsoft.Reporting.WinForms.ReportViewer
End Class
