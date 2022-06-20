<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMemberShowReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ReportMember = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'ReportMember
        '
        Me.ReportMember.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportMember.LocalReport.ReportEmbeddedResource = "BookMasters.ActivityReport.rdlc"
        Me.ReportMember.Location = New System.Drawing.Point(0, 0)
        Me.ReportMember.Name = "ReportMember"
        Me.ReportMember.Size = New System.Drawing.Size(1529, 684)
        Me.ReportMember.TabIndex = 0
        '
        'FrmMemberShowReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1529, 684)
        Me.Controls.Add(Me.ReportMember)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMemberShowReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activity Report"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportMember As Microsoft.Reporting.WinForms.ReportViewer
End Class
