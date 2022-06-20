Imports Microsoft.Reporting.WinForms

Public Class FrmVoucherUsedShowReport
    Private Sub FrmVoucherShowUsedReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim parameters(3) As ReportParameter
        parameters(0) = New ReportParameter("month", FrmVoucherReport.cboMonth.Text, True)
        parameters(1) = New ReportParameter("year", FrmVoucherReport.mskYear.Text, True)
        parameters(2) = New ReportParameter("todayDate", Now.ToString(), True)
        parameters(3) = New ReportParameter("staffName", UserLogin.strCurrentLoginStaffName, True)

        With VoucherUsedReportViewer
            .LocalReport.SetParameters(parameters)
            .LocalReport.DataSources.Clear()
            .LocalReport.DataSources.Add(New ReportDataSource("myVoucherUsedReport", FrmVoucherReport.ds.Tables("VoucherUsedReportDataSetTable")))
            .RefreshReport()
            .SetDisplayMode(DisplayMode.PrintLayout)
        End With

    End Sub
End Class