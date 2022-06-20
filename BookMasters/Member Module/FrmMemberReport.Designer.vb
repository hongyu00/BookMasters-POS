<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMemberReport
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.grpView = New System.Windows.Forms.GroupBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.dtpExpired = New System.Windows.Forms.DateTimePicker()
        Me.lblExpired = New System.Windows.Forms.Label()
        Me.lblLStatus = New System.Windows.Forms.Label()
        Me.lblLPoints = New System.Windows.Forms.Label()
        Me.dtpDOJ = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.lblMemberIDTitle = New System.Windows.Forms.Label()
        Me.lblMemberID = New System.Windows.Forms.Label()
        Me.grpTotalPoint = New System.Windows.Forms.GroupBox()
        Me.picArrow = New System.Windows.Forms.PictureBox()
        Me.lblPointUsed = New System.Windows.Forms.Label()
        Me.gvRecord = New System.Windows.Forms.DataGridView()
        Me.lblRecord = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblNoRecord = New System.Windows.Forms.Label()
        Me.grpRangePoint = New System.Windows.Forms.GroupBox()
        Me.picRangeArrow = New System.Windows.Forms.PictureBox()
        Me.lblPointRange = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.grpView.SuspendLayout()
        Me.grpTotalPoint.SuspendLayout()
        CType(Me.picArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRangePoint.SuspendLayout()
        CType(Me.picRangeArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(378, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(223, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Activity Report  -  "
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblName)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1068, 73)
        Me.pnlHeader.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Orange
        Me.lblName.Location = New System.Drawing.Point(584, 18)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(87, 30)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(820, 416)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(90, 32)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'grpView
        '
        Me.grpView.Controls.Add(Me.lblStatus)
        Me.grpView.Controls.Add(Me.dtpExpired)
        Me.grpView.Controls.Add(Me.lblExpired)
        Me.grpView.Controls.Add(Me.lblLStatus)
        Me.grpView.Controls.Add(Me.lblLPoints)
        Me.grpView.Controls.Add(Me.dtpDOJ)
        Me.grpView.Controls.Add(Me.Label2)
        Me.grpView.Controls.Add(Me.lblPoints)
        Me.grpView.Controls.Add(Me.lblMemberIDTitle)
        Me.grpView.Controls.Add(Me.lblMemberID)
        Me.grpView.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpView.Location = New System.Drawing.Point(30, 93)
        Me.grpView.Name = "grpView"
        Me.grpView.Size = New System.Drawing.Size(593, 297)
        Me.grpView.TabIndex = 1
        Me.grpView.TabStop = False
        Me.grpView.Text = "Membership"
        '
        'lblStatus
        '
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatus.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(172, 89)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(124, 27)
        Me.lblStatus.TabIndex = 3
        '
        'dtpExpired
        '
        Me.dtpExpired.Enabled = False
        Me.dtpExpired.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExpired.Location = New System.Drawing.Point(172, 178)
        Me.dtpExpired.Name = "dtpExpired"
        Me.dtpExpired.Size = New System.Drawing.Size(300, 28)
        Me.dtpExpired.TabIndex = 7
        Me.dtpExpired.Value = New Date(2020, 11, 23, 15, 44, 50, 0)
        '
        'lblExpired
        '
        Me.lblExpired.AutoSize = True
        Me.lblExpired.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpired.Location = New System.Drawing.Point(24, 178)
        Me.lblExpired.Name = "lblExpired"
        Me.lblExpired.Size = New System.Drawing.Size(131, 21)
        Me.lblExpired.TabIndex = 6
        Me.lblExpired.Text = "Exipi&red Date :"
        '
        'lblLStatus
        '
        Me.lblLStatus.AutoSize = True
        Me.lblLStatus.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLStatus.Location = New System.Drawing.Point(87, 91)
        Me.lblLStatus.Name = "lblLStatus"
        Me.lblLStatus.Size = New System.Drawing.Size(71, 21)
        Me.lblLStatus.TabIndex = 2
        Me.lblLStatus.Text = "S&tatus :"
        '
        'lblLPoints
        '
        Me.lblLPoints.AutoSize = True
        Me.lblLPoints.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLPoints.Location = New System.Drawing.Point(44, 139)
        Me.lblLPoints.Name = "lblLPoints"
        Me.lblLPoints.Size = New System.Drawing.Size(111, 21)
        Me.lblLPoints.TabIndex = 4
        Me.lblLPoints.Text = "&Points Now :"
        '
        'dtpDOJ
        '
        Me.dtpDOJ.Enabled = False
        Me.dtpDOJ.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOJ.Location = New System.Drawing.Point(172, 226)
        Me.dtpDOJ.Name = "dtpDOJ"
        Me.dtpDOJ.Size = New System.Drawing.Size(300, 28)
        Me.dtpDOJ.TabIndex = 9
        Me.dtpDOJ.Value = New Date(2020, 11, 23, 15, 44, 50, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Date of &Joined :"
        '
        'lblPoints
        '
        Me.lblPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPoints.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.Location = New System.Drawing.Point(172, 133)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(124, 27)
        Me.lblPoints.TabIndex = 5
        '
        'lblMemberIDTitle
        '
        Me.lblMemberIDTitle.AutoSize = True
        Me.lblMemberIDTitle.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberIDTitle.Location = New System.Drawing.Point(44, 40)
        Me.lblMemberIDTitle.Name = "lblMemberIDTitle"
        Me.lblMemberIDTitle.Size = New System.Drawing.Size(114, 21)
        Me.lblMemberIDTitle.TabIndex = 0
        Me.lblMemberIDTitle.Text = "Member I&D :"
        '
        'lblMemberID
        '
        Me.lblMemberID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMemberID.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberID.Location = New System.Drawing.Point(171, 38)
        Me.lblMemberID.Name = "lblMemberID"
        Me.lblMemberID.Size = New System.Drawing.Size(200, 27)
        Me.lblMemberID.TabIndex = 1
        '
        'grpTotalPoint
        '
        Me.grpTotalPoint.Controls.Add(Me.picArrow)
        Me.grpTotalPoint.Controls.Add(Me.lblPointUsed)
        Me.grpTotalPoint.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTotalPoint.Location = New System.Drawing.Point(694, 93)
        Me.grpTotalPoint.Name = "grpTotalPoint"
        Me.grpTotalPoint.Size = New System.Drawing.Size(328, 131)
        Me.grpTotalPoint.TabIndex = 2
        Me.grpTotalPoint.TabStop = False
        Me.grpTotalPoint.Text = "Total Used Points"
        '
        'picArrow
        '
        Me.picArrow.Image = Global.BookMasters.My.Resources.Resources.greenUpArrow
        Me.picArrow.Location = New System.Drawing.Point(228, 29)
        Me.picArrow.Name = "picArrow"
        Me.picArrow.Size = New System.Drawing.Size(74, 83)
        Me.picArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picArrow.TabIndex = 11
        Me.picArrow.TabStop = False
        '
        'lblPointUsed
        '
        Me.lblPointUsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPointUsed.Font = New System.Drawing.Font("Century Gothic", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointUsed.Location = New System.Drawing.Point(54, 42)
        Me.lblPointUsed.Name = "lblPointUsed"
        Me.lblPointUsed.Size = New System.Drawing.Size(159, 73)
        Me.lblPointUsed.TabIndex = 0
        Me.lblPointUsed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gvRecord
        '
        Me.gvRecord.AllowUserToAddRows = False
        Me.gvRecord.AllowUserToDeleteRows = False
        Me.gvRecord.AllowUserToResizeColumns = False
        Me.gvRecord.AllowUserToResizeRows = False
        Me.gvRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvRecord.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gvRecord.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.gvRecord.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvRecord.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gvRecord.ColumnHeadersHeight = 30
        Me.gvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvRecord.DefaultCellStyle = DataGridViewCellStyle2
        Me.gvRecord.EnableHeadersVisualStyles = False
        Me.gvRecord.Location = New System.Drawing.Point(30, 515)
        Me.gvRecord.Name = "gvRecord"
        Me.gvRecord.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvRecord.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.gvRecord.RowHeadersVisible = False
        Me.gvRecord.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gvRecord.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.gvRecord.RowTemplate.Height = 30
        Me.gvRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvRecord.Size = New System.Drawing.Size(1001, 216)
        Me.gvRecord.TabIndex = 11
        '
        'lblRecord
        '
        Me.lblRecord.AutoSize = True
        Me.lblRecord.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecord.Location = New System.Drawing.Point(468, 471)
        Me.lblRecord.Name = "lblRecord"
        Me.lblRecord.Size = New System.Drawing.Size(126, 30)
        Me.lblRecord.TabIndex = 10
        Me.lblRecord.Text = "Record(s)"
        '
        'dtpFrom
        '
        Me.dtpFrom.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.Location = New System.Drawing.Point(113, 420)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(306, 28)
        Me.dtpFrom.TabIndex = 5
        Me.dtpFrom.Value = New Date(2019, 1, 1, 0, 0, 0, 0)
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.Location = New System.Drawing.Point(36, 421)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(59, 21)
        Me.lblFrom.TabIndex = 4
        Me.lblFrom.Text = "&From :"
        '
        'dtpTo
        '
        Me.dtpTo.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Location = New System.Drawing.Point(485, 420)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(304, 28)
        Me.dtpTo.TabIndex = 7
        Me.dtpTo.Value = New Date(2020, 11, 30, 18, 41, 40, 0)
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.Location = New System.Drawing.Point(430, 420)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(39, 21)
        Me.lblTo.TabIndex = 6
        Me.lblTo.Text = "T&o :"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRefresh.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(932, 416)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(90, 31)
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.Text = "Refres&h"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'lblNoRecord
        '
        Me.lblNoRecord.AutoSize = True
        Me.lblNoRecord.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoRecord.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.lblNoRecord.Location = New System.Drawing.Point(361, 540)
        Me.lblNoRecord.Name = "lblNoRecord"
        Me.lblNoRecord.Size = New System.Drawing.Size(381, 30)
        Me.lblNoRecord.TabIndex = 12
        Me.lblNoRecord.Text = "No Redeem Transaction Found"
        '
        'grpRangePoint
        '
        Me.grpRangePoint.Controls.Add(Me.picRangeArrow)
        Me.grpRangePoint.Controls.Add(Me.lblPointRange)
        Me.grpRangePoint.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRangePoint.Location = New System.Drawing.Point(694, 259)
        Me.grpRangePoint.Name = "grpRangePoint"
        Me.grpRangePoint.Size = New System.Drawing.Size(328, 131)
        Me.grpRangePoint.TabIndex = 3
        Me.grpRangePoint.TabStop = False
        Me.grpRangePoint.Text = "Used Points In Range"
        '
        'picRangeArrow
        '
        Me.picRangeArrow.Image = Global.BookMasters.My.Resources.Resources.rangeArrow
        Me.picRangeArrow.Location = New System.Drawing.Point(219, 36)
        Me.picRangeArrow.Name = "picRangeArrow"
        Me.picRangeArrow.Size = New System.Drawing.Size(83, 79)
        Me.picRangeArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRangeArrow.TabIndex = 11
        Me.picRangeArrow.TabStop = False
        '
        'lblPointRange
        '
        Me.lblPointRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPointRange.Font = New System.Drawing.Font("Century Gothic", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointRange.Location = New System.Drawing.Point(54, 42)
        Me.lblPointRange.Name = "lblPointRange"
        Me.lblPointRange.Size = New System.Drawing.Size(159, 73)
        Me.lblPointRange.TabIndex = 0
        Me.lblPointRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmMemberReport
        '
        Me.AcceptButton = Me.btnRefresh
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1068, 743)
        Me.Controls.Add(Me.grpRangePoint)
        Me.Controls.Add(Me.lblNoRecord)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.lblRecord)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.gvRecord)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.grpTotalPoint)
        Me.Controls.Add(Me.grpView)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmMemberReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Report - Name"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.grpView.ResumeLayout(False)
        Me.grpView.PerformLayout()
        Me.grpTotalPoint.ResumeLayout(False)
        CType(Me.picArrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRangePoint.ResumeLayout(False)
        CType(Me.picRangeArrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnPrint As Button
    Friend WithEvents lblName As Label
    Friend WithEvents grpView As GroupBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents dtpExpired As DateTimePicker
    Friend WithEvents lblExpired As Label
    Friend WithEvents lblLStatus As Label
    Friend WithEvents lblLPoints As Label
    Friend WithEvents dtpDOJ As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPoints As Label
    Friend WithEvents lblMemberIDTitle As Label
    Friend WithEvents lblMemberID As Label
    Friend WithEvents grpTotalPoint As GroupBox
    Friend WithEvents picArrow As PictureBox
    Friend WithEvents lblPointUsed As Label
    Friend WithEvents gvRecord As DataGridView
    Friend WithEvents lblRecord As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents lblFrom As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents lblTo As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lblNoRecord As Label
    Friend WithEvents grpRangePoint As GroupBox
    Friend WithEvents picRangeArrow As PictureBox
    Friend WithEvents lblPointRange As Label
End Class
