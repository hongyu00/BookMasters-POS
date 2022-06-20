Imports Microsoft.Reporting.WinForms

Public Class FrmMemberShowReport

    Private Sub FrmMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Create a report parameter 
        Dim parameters(10) As ReportParameter
        parameters(0) = New ReportParameter("memberName", FrmMemberReport.lblName.Text, True)
        parameters(1) = New ReportParameter("memberID", FrmMemberReport.lblMemberID.Text, True)
        parameters(2) = New ReportParameter("memberStatus", FrmMemberReport.lblStatus.Text, True)
        parameters(3) = New ReportParameter("memberPointsNow", FrmMemberReport.lblPoints.Text, True)
        parameters(4) = New ReportParameter("expiredDate", FrmMemberReport.dtpExpired.Value.ToString("yyyy-MM-dd"), True)
        parameters(5) = New ReportParameter("dateOfJoined", FrmMemberReport.dtpDOJ.Value.ToString("yyyy-MM-dd"), True)
        parameters(6) = New ReportParameter("usedPoints", FrmMemberReport.lblPointUsed.Text, True)
        parameters(7) = New ReportParameter("usedPointsRange", FrmMemberReport.lblPointRange.Text, True)
        parameters(8) = New ReportParameter("dateFrom", FrmMemberReport.dtpFrom.Value.ToString("yyyy-MM-dd"), True)
        parameters(9) = New ReportParameter("dateTo", FrmMemberReport.dtpTo.Value.ToString("yyyy-MM-dd"), True)
        parameters(10) = New ReportParameter("todayDate", Now.ToString(), True)

        'Set the report parameters for the report
        With ReportMember
            .LocalReport.SetParameters(parameters)
            .LocalReport.DataSources.Clear()
            .LocalReport.DataSources.Add(New ReportDataSource("reportDataSet", FrmMemberReport.ds.Tables("ActivityDataSetTable")))
        End With

        'Refresh the report
        With Me.ReportMember
            .RefreshReport()
            .SetDisplayMode(DisplayMode.PrintLayout)
        End With

        'Me.ReportMember.ZoomMode = True
        'Me.ReportMember.ZoomPercent = 100
    End Sub

End Class