Imports Microsoft.Reporting.WinForms

Public Class FrmVoucherAvailableShowReport
    Private Sub FrmVoucherShowReport_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim parameters(3) As ReportParameter
        parameters(0) = New ReportParameter("month", FrmVoucherReport.cboMonth.Text, True)
        parameters(1) = New ReportParameter("year", FrmVoucherReport.mskYear.Text, True)
        parameters(2) = New ReportParameter("todayDate", Now.ToString(), True)
        parameters(3) = New ReportParameter("staffName", UserLogin.strCurrentLoginStaffName, True)

        With VoucherReportViewer
            .LocalReport.SetParameters(parameters)
            .LocalReport.DataSources.Clear()
            .LocalReport.DataSources.Add(New ReportDataSource("myVoucherDataSet", FrmVoucherReport.ds.Tables("VoucherAvailableReportDataSetTable")))
        End With

        With VoucherReportViewer
            .RefreshReport()
            .SetDisplayMode(DisplayMode.PrintLayout)
        End With

    End Sub
End Class