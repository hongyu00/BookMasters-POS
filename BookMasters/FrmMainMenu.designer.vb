<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMainMenu))
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.btnMinimize = New FontAwesome.Sharp.IconButton()
        Me.BtnMaximize = New FontAwesome.Sharp.IconButton()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.btnHome = New FontAwesome.Sharp.IconButton()
        Me.imgHome = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnAboutUs = New FontAwesome.Sharp.IconButton()
        Me.btnLogOut = New FontAwesome.Sharp.IconButton()
        Me.PanelReportSubMenu = New System.Windows.Forms.Panel()
        Me.btnUserLoginReport = New System.Windows.Forms.Button()
        Me.btnVoucherReport = New System.Windows.Forms.Button()
        Me.btnDiscountReport = New System.Windows.Forms.Button()
        Me.btnProductsReport = New System.Windows.Forms.Button()
        Me.btnMemberReport = New System.Windows.Forms.Button()
        Me.btnPaymentReport = New System.Windows.Forms.Button()
        Me.btnStaffReport = New System.Windows.Forms.Button()
        Me.btnReport = New FontAwesome.Sharp.IconButton()
        Me.btnVoucher = New FontAwesome.Sharp.IconButton()
        Me.btnDiscount = New FontAwesome.Sharp.IconButton()
        Me.btnProducts = New FontAwesome.Sharp.IconButton()
        Me.btnMember = New FontAwesome.Sharp.IconButton()
        Me.panelPaymentSubMenu = New System.Windows.Forms.Panel()
        Me.btnPaymentHistory = New System.Windows.Forms.Button()
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.btnPayment = New FontAwesome.Sharp.IconButton()
        Me.btnStaff = New FontAwesome.Sharp.IconButton()
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.ctmMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuStaff = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPayment = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaymentTransaction = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaymentHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProducts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDiscount = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVoucher = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportStaff = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportPayment = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportDiscount = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportVoucher = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportUserLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAboutUs = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLogo.SuspendLayout()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.PanelReportSubMenu.SuspendLayout()
        Me.panelPaymentSubMenu.SuspendLayout()
        Me.ctmMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFormTitle
        '
        Me.lblFormTitle.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.Location = New System.Drawing.Point(72, 30)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(101, 29)
        Me.lblFormTitle.TabIndex = 37
        Me.lblFormTitle.Text = "Home"
        Me.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.PanelTitleBar.Controls.Add(Me.btnMinimize)
        Me.PanelTitleBar.Controls.Add(Me.BtnMaximize)
        Me.PanelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitleBar.Controls.Add(Me.btnExit)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(200, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(1238, 90)
        Me.PanelTitleBar.TabIndex = 4
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnMinimize.IconColor = System.Drawing.Color.Black
        Me.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMinimize.Location = New System.Drawing.Point(1146, 3)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(33, 25)
        Me.btnMinimize.TabIndex = 1
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'BtnMaximize
        '
        Me.BtnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMaximize.FlatAppearance.BorderSize = 0
        Me.BtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMaximize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMaximize.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnMaximize.IconColor = System.Drawing.Color.Black
        Me.BtnMaximize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnMaximize.Location = New System.Drawing.Point(1176, 3)
        Me.BtnMaximize.Name = "BtnMaximize"
        Me.BtnMaximize.Size = New System.Drawing.Size(33, 25)
        Me.BtnMaximize.TabIndex = 2
        Me.BtnMaximize.Text = "O"
        Me.BtnMaximize.UseVisualStyleBackColor = True
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.Transparent
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.SkyBlue
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.SkyBlue
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.IconSize = 49
        Me.IconCurrentForm.Location = New System.Drawing.Point(14, 25)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(52, 49)
        Me.IconCurrentForm.TabIndex = 1
        Me.IconCurrentForm.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnExit.IconColor = System.Drawing.Color.Black
        Me.btnExit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExit.Location = New System.Drawing.Point(1205, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(33, 25)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelLogo.Controls.Add(Me.btnHome)
        Me.PanelLogo.Controls.Add(Me.imgHome)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(200, 90)
        Me.PanelLogo.TabIndex = 0
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.Enabled = False
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.btnHome.IconColor = System.Drawing.Color.Black
        Me.btnHome.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHome.Location = New System.Drawing.Point(3, 30)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(26, 39)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        Me.btnHome.Visible = False
        '
        'imgHome
        '
        Me.imgHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgHome.Image = CType(resources.GetObject("imgHome.Image"), System.Drawing.Image)
        Me.imgHome.Location = New System.Drawing.Point(32, 12)
        Me.imgHome.Name = "imgHome"
        Me.imgHome.Size = New System.Drawing.Size(141, 62)
        Me.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgHome.TabIndex = 0
        Me.imgHome.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnAboutUs)
        Me.PanelMenu.Controls.Add(Me.btnLogOut)
        Me.PanelMenu.Controls.Add(Me.PanelReportSubMenu)
        Me.PanelMenu.Controls.Add(Me.btnReport)
        Me.PanelMenu.Controls.Add(Me.btnVoucher)
        Me.PanelMenu.Controls.Add(Me.btnDiscount)
        Me.PanelMenu.Controls.Add(Me.btnProducts)
        Me.PanelMenu.Controls.Add(Me.btnMember)
        Me.PanelMenu.Controls.Add(Me.panelPaymentSubMenu)
        Me.PanelMenu.Controls.Add(Me.btnPayment)
        Me.PanelMenu.Controls.Add(Me.btnStaff)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(200, 1078)
        Me.PanelMenu.TabIndex = 3
        '
        'btnAboutUs
        '
        Me.btnAboutUs.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAboutUs.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAboutUs.FlatAppearance.BorderSize = 0
        Me.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAboutUs.ForeColor = System.Drawing.Color.Black
        Me.btnAboutUs.IconChar = FontAwesome.Sharp.IconChar.Info
        Me.btnAboutUs.IconColor = System.Drawing.Color.Black
        Me.btnAboutUs.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAboutUs.Location = New System.Drawing.Point(0, 1047)
        Me.btnAboutUs.Name = "btnAboutUs"
        Me.btnAboutUs.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnAboutUs.Size = New System.Drawing.Size(200, 70)
        Me.btnAboutUs.TabIndex = 19
        Me.btnAboutUs.Text = "About Us"
        Me.btnAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAboutUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAboutUs.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.ForeColor = System.Drawing.Color.Black
        Me.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btnLogOut.IconColor = System.Drawing.Color.Black
        Me.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogOut.Location = New System.Drawing.Point(0, 977)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnLogOut.Size = New System.Drawing.Size(200, 70)
        Me.btnLogOut.TabIndex = 18
        Me.btnLogOut.Text = "&Logout"
        Me.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'PanelReportSubMenu
        '
        Me.PanelReportSubMenu.Controls.Add(Me.btnUserLoginReport)
        Me.PanelReportSubMenu.Controls.Add(Me.btnVoucherReport)
        Me.PanelReportSubMenu.Controls.Add(Me.btnDiscountReport)
        Me.PanelReportSubMenu.Controls.Add(Me.btnProductsReport)
        Me.PanelReportSubMenu.Controls.Add(Me.btnMemberReport)
        Me.PanelReportSubMenu.Controls.Add(Me.btnPaymentReport)
        Me.PanelReportSubMenu.Controls.Add(Me.btnStaffReport)
        Me.PanelReportSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelReportSubMenu.Location = New System.Drawing.Point(0, 669)
        Me.PanelReportSubMenu.Name = "PanelReportSubMenu"
        Me.PanelReportSubMenu.Size = New System.Drawing.Size(200, 308)
        Me.PanelReportSubMenu.TabIndex = 17
        '
        'btnUserLoginReport
        '
        Me.btnUserLoginReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserLoginReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUserLoginReport.FlatAppearance.BorderSize = 0
        Me.btnUserLoginReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserLoginReport.Location = New System.Drawing.Point(0, 264)
        Me.btnUserLoginReport.Name = "btnUserLoginReport"
        Me.btnUserLoginReport.Size = New System.Drawing.Size(200, 44)
        Me.btnUserLoginReport.TabIndex = 6
        Me.btnUserLoginReport.Text = "&User Login Report"
        Me.btnUserLoginReport.UseVisualStyleBackColor = False
        '
        'btnVoucherReport
        '
        Me.btnVoucherReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVoucherReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVoucherReport.FlatAppearance.BorderSize = 0
        Me.btnVoucherReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoucherReport.Location = New System.Drawing.Point(0, 220)
        Me.btnVoucherReport.Name = "btnVoucherReport"
        Me.btnVoucherReport.Size = New System.Drawing.Size(200, 44)
        Me.btnVoucherReport.TabIndex = 5
        Me.btnVoucherReport.Text = "&Voucher Report"
        Me.btnVoucherReport.UseVisualStyleBackColor = False
        '
        'btnDiscountReport
        '
        Me.btnDiscountReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDiscountReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDiscountReport.FlatAppearance.BorderSize = 0
        Me.btnDiscountReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiscountReport.Location = New System.Drawing.Point(0, 176)
        Me.btnDiscountReport.Name = "btnDiscountReport"
        Me.btnDiscountReport.Size = New System.Drawing.Size(200, 44)
        Me.btnDiscountReport.TabIndex = 4
        Me.btnDiscountReport.Text = "Discou&nt Report"
        Me.btnDiscountReport.UseVisualStyleBackColor = False
        '
        'btnProductsReport
        '
        Me.btnProductsReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnProductsReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProductsReport.FlatAppearance.BorderSize = 0
        Me.btnProductsReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductsReport.Location = New System.Drawing.Point(0, 132)
        Me.btnProductsReport.Name = "btnProductsReport"
        Me.btnProductsReport.Size = New System.Drawing.Size(200, 44)
        Me.btnProductsReport.TabIndex = 3
        Me.btnProductsReport.Text = "Pro&ducts Report"
        Me.btnProductsReport.UseVisualStyleBackColor = False
        '
        'btnMemberReport
        '
        Me.btnMemberReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMemberReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMemberReport.FlatAppearance.BorderSize = 0
        Me.btnMemberReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMemberReport.Location = New System.Drawing.Point(0, 88)
        Me.btnMemberReport.Name = "btnMemberReport"
        Me.btnMemberReport.Size = New System.Drawing.Size(200, 44)
        Me.btnMemberReport.TabIndex = 2
        Me.btnMemberReport.Text = "Member Rep&ort"
        Me.btnMemberReport.UseVisualStyleBackColor = False
        '
        'btnPaymentReport
        '
        Me.btnPaymentReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPaymentReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPaymentReport.FlatAppearance.BorderSize = 0
        Me.btnPaymentReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaymentReport.Location = New System.Drawing.Point(0, 44)
        Me.btnPaymentReport.Name = "btnPaymentReport"
        Me.btnPaymentReport.Size = New System.Drawing.Size(200, 44)
        Me.btnPaymentReport.TabIndex = 1
        Me.btnPaymentReport.Text = "Sales Repor&t"
        Me.btnPaymentReport.UseVisualStyleBackColor = False
        '
        'btnStaffReport
        '
        Me.btnStaffReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStaffReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStaffReport.FlatAppearance.BorderSize = 0
        Me.btnStaffReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaffReport.Location = New System.Drawing.Point(0, 0)
        Me.btnStaffReport.Name = "btnStaffReport"
        Me.btnStaffReport.Size = New System.Drawing.Size(200, 44)
        Me.btnStaffReport.TabIndex = 0
        Me.btnStaffReport.Text = "Staff R&eport"
        Me.btnStaffReport.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.ForeColor = System.Drawing.Color.Black
        Me.btnReport.IconChar = FontAwesome.Sharp.IconChar.Database
        Me.btnReport.IconColor = System.Drawing.Color.Black
        Me.btnReport.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.Location = New System.Drawing.Point(0, 599)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnReport.Size = New System.Drawing.Size(200, 70)
        Me.btnReport.TabIndex = 16
        Me.btnReport.Text = "Report"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnVoucher
        '
        Me.btnVoucher.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnVoucher.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVoucher.FlatAppearance.BorderSize = 0
        Me.btnVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoucher.ForeColor = System.Drawing.Color.Black
        Me.btnVoucher.IconChar = FontAwesome.Sharp.IconChar.Gift
        Me.btnVoucher.IconColor = System.Drawing.Color.Black
        Me.btnVoucher.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnVoucher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVoucher.Location = New System.Drawing.Point(0, 529)
        Me.btnVoucher.Name = "btnVoucher"
        Me.btnVoucher.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnVoucher.Size = New System.Drawing.Size(200, 70)
        Me.btnVoucher.TabIndex = 15
        Me.btnVoucher.Text = "&Voucher"
        Me.btnVoucher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVoucher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVoucher.UseVisualStyleBackColor = True
        '
        'btnDiscount
        '
        Me.btnDiscount.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDiscount.FlatAppearance.BorderSize = 0
        Me.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiscount.ForeColor = System.Drawing.Color.Black
        Me.btnDiscount.IconChar = FontAwesome.Sharp.IconChar.Percentage
        Me.btnDiscount.IconColor = System.Drawing.Color.Black
        Me.btnDiscount.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDiscount.Location = New System.Drawing.Point(0, 459)
        Me.btnDiscount.Name = "btnDiscount"
        Me.btnDiscount.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnDiscount.Size = New System.Drawing.Size(200, 70)
        Me.btnDiscount.TabIndex = 14
        Me.btnDiscount.Text = "&Discount"
        Me.btnDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDiscount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDiscount.UseVisualStyleBackColor = True
        '
        'btnProducts
        '
        Me.btnProducts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProducts.FlatAppearance.BorderSize = 0
        Me.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProducts.ForeColor = System.Drawing.Color.Black
        Me.btnProducts.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.btnProducts.IconColor = System.Drawing.Color.Black
        Me.btnProducts.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducts.Location = New System.Drawing.Point(0, 389)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnProducts.Size = New System.Drawing.Size(200, 70)
        Me.btnProducts.TabIndex = 13
        Me.btnProducts.Text = "P&roducts"
        Me.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'btnMember
        '
        Me.btnMember.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMember.FlatAppearance.BorderSize = 0
        Me.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMember.ForeColor = System.Drawing.Color.Black
        Me.btnMember.IconChar = FontAwesome.Sharp.IconChar.User
        Me.btnMember.IconColor = System.Drawing.Color.Black
        Me.btnMember.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMember.Location = New System.Drawing.Point(0, 319)
        Me.btnMember.Name = "btnMember"
        Me.btnMember.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnMember.Size = New System.Drawing.Size(200, 70)
        Me.btnMember.TabIndex = 12
        Me.btnMember.Text = "&Member"
        Me.btnMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMember.UseVisualStyleBackColor = True
        '
        'panelPaymentSubMenu
        '
        Me.panelPaymentSubMenu.Controls.Add(Me.btnPaymentHistory)
        Me.panelPaymentSubMenu.Controls.Add(Me.btnTransaction)
        Me.panelPaymentSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelPaymentSubMenu.Location = New System.Drawing.Point(0, 230)
        Me.panelPaymentSubMenu.Name = "panelPaymentSubMenu"
        Me.panelPaymentSubMenu.Size = New System.Drawing.Size(200, 89)
        Me.panelPaymentSubMenu.TabIndex = 11
        '
        'btnPaymentHistory
        '
        Me.btnPaymentHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPaymentHistory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPaymentHistory.FlatAppearance.BorderSize = 0
        Me.btnPaymentHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaymentHistory.Location = New System.Drawing.Point(0, 44)
        Me.btnPaymentHistory.Name = "btnPaymentHistory"
        Me.btnPaymentHistory.Size = New System.Drawing.Size(200, 44)
        Me.btnPaymentHistory.TabIndex = 1
        Me.btnPaymentHistory.Text = "Payment &History"
        Me.btnPaymentHistory.UseVisualStyleBackColor = False
        '
        'btnTransaction
        '
        Me.btnTransaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTransaction.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTransaction.FlatAppearance.BorderSize = 0
        Me.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaction.Location = New System.Drawing.Point(0, 0)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(200, 44)
        Me.btnTransaction.TabIndex = 0
        Me.btnTransaction.Text = "&Transaction"
        Me.btnTransaction.UseVisualStyleBackColor = False
        '
        'btnPayment
        '
        Me.btnPayment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPayment.FlatAppearance.BorderSize = 0
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayment.ForeColor = System.Drawing.Color.Black
        Me.btnPayment.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt
        Me.btnPayment.IconColor = System.Drawing.Color.Black
        Me.btnPayment.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayment.Location = New System.Drawing.Point(0, 160)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnPayment.Size = New System.Drawing.Size(200, 70)
        Me.btnPayment.TabIndex = 2
        Me.btnPayment.Text = "P&ayment"
        Me.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'btnStaff
        '
        Me.btnStaff.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStaff.FlatAppearance.BorderSize = 0
        Me.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaff.ForeColor = System.Drawing.Color.Black
        Me.btnStaff.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btnStaff.IconColor = System.Drawing.Color.Black
        Me.btnStaff.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStaff.Location = New System.Drawing.Point(0, 90)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnStaff.Size = New System.Drawing.Size(200, 70)
        Me.btnStaff.TabIndex = 1
        Me.btnStaff.Text = "&Staff"
        Me.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStaff.UseVisualStyleBackColor = True
        '
        'PanelChildForm
        '
        Me.PanelChildForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PanelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelChildForm.Location = New System.Drawing.Point(0, 0)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(1438, 1078)
        Me.PanelChildForm.TabIndex = 5
        '
        'ctmMain
        '
        Me.ctmMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ctmMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHome, Me.ToolStripSeparator2, Me.mnuStaff, Me.mnuPayment, Me.mnuMember, Me.mnuProducts, Me.mnuDiscount, Me.mnuVoucher, Me.mnuReport, Me.ToolStripSeparator1, Me.mnuLogout, Me.mnuAboutUs})
        Me.ctmMain.Name = "ctmMain"
        Me.ctmMain.Size = New System.Drawing.Size(124, 236)
        '
        'mnuHome
        '
        Me.mnuHome.Name = "mnuHome"
        Me.mnuHome.Size = New System.Drawing.Size(123, 22)
        Me.mnuHome.Text = "&Home"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(120, 6)
        '
        'mnuStaff
        '
        Me.mnuStaff.Name = "mnuStaff"
        Me.mnuStaff.Size = New System.Drawing.Size(123, 22)
        Me.mnuStaff.Text = "&Staff"
        '
        'mnuPayment
        '
        Me.mnuPayment.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPaymentTransaction, Me.mnuPaymentHistory})
        Me.mnuPayment.Name = "mnuPayment"
        Me.mnuPayment.Size = New System.Drawing.Size(123, 22)
        Me.mnuPayment.Text = "Payment"
        '
        'mnuPaymentTransaction
        '
        Me.mnuPaymentTransaction.Name = "mnuPaymentTransaction"
        Me.mnuPaymentTransaction.Size = New System.Drawing.Size(162, 22)
        Me.mnuPaymentTransaction.Text = "&Transaction"
        '
        'mnuPaymentHistory
        '
        Me.mnuPaymentHistory.Name = "mnuPaymentHistory"
        Me.mnuPaymentHistory.Size = New System.Drawing.Size(162, 22)
        Me.mnuPaymentHistory.Text = "Payment &History"
        '
        'mnuMember
        '
        Me.mnuMember.Name = "mnuMember"
        Me.mnuMember.Size = New System.Drawing.Size(123, 22)
        Me.mnuMember.Text = "&Member"
        '
        'mnuProducts
        '
        Me.mnuProducts.Name = "mnuProducts"
        Me.mnuProducts.Size = New System.Drawing.Size(123, 22)
        Me.mnuProducts.Text = "P&roducts"
        '
        'mnuDiscount
        '
        Me.mnuDiscount.Name = "mnuDiscount"
        Me.mnuDiscount.Size = New System.Drawing.Size(123, 22)
        Me.mnuDiscount.Text = "&Discount"
        '
        'mnuVoucher
        '
        Me.mnuVoucher.Name = "mnuVoucher"
        Me.mnuVoucher.Size = New System.Drawing.Size(123, 22)
        Me.mnuVoucher.Text = "&Voucher"
        '
        'mnuReport
        '
        Me.mnuReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReportStaff, Me.mnuReportPayment, Me.mnuReportMember, Me.mnuReportProduct, Me.mnuReportDiscount, Me.mnuReportVoucher, Me.mnuReportUserLogin})
        Me.mnuReport.Name = "mnuReport"
        Me.mnuReport.Size = New System.Drawing.Size(123, 22)
        Me.mnuReport.Text = "Report"
        '
        'mnuReportStaff
        '
        Me.mnuReportStaff.Name = "mnuReportStaff"
        Me.mnuReportStaff.Size = New System.Drawing.Size(168, 22)
        Me.mnuReportStaff.Text = "Staff R&eport"
        '
        'mnuReportPayment
        '
        Me.mnuReportPayment.Name = "mnuReportPayment"
        Me.mnuReportPayment.Size = New System.Drawing.Size(168, 22)
        Me.mnuReportPayment.Text = "Payment Repo&rt"
        '
        'mnuReportMember
        '
        Me.mnuReportMember.Name = "mnuReportMember"
        Me.mnuReportMember.Size = New System.Drawing.Size(168, 22)
        Me.mnuReportMember.Text = "Member Rep&ort"
        '
        'mnuReportProduct
        '
        Me.mnuReportProduct.Name = "mnuReportProduct"
        Me.mnuReportProduct.Size = New System.Drawing.Size(168, 22)
        Me.mnuReportProduct.Text = "Pro&ducts Report"
        '
        'mnuReportDiscount
        '
        Me.mnuReportDiscount.Name = "mnuReportDiscount"
        Me.mnuReportDiscount.Size = New System.Drawing.Size(168, 22)
        Me.mnuReportDiscount.Text = "Disco&unt Report"
        '
        'mnuReportVoucher
        '
        Me.mnuReportVoucher.Name = "mnuReportVoucher"
        Me.mnuReportVoucher.Size = New System.Drawing.Size(168, 22)
        Me.mnuReportVoucher.Text = "&Voucher Report"
        '
        'mnuReportUserLogin
        '
        Me.mnuReportUserLogin.Name = "mnuReportUserLogin"
        Me.mnuReportUserLogin.Size = New System.Drawing.Size(168, 22)
        Me.mnuReportUserLogin.Text = "&User Login Report"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(120, 6)
        '
        'mnuLogout
        '
        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.Size = New System.Drawing.Size(123, 22)
        Me.mnuLogout.Text = "&Logout"
        '
        'mnuAboutUs
        '
        Me.mnuAboutUs.Name = "mnuAboutUs"
        Me.mnuAboutUs.Size = New System.Drawing.Size(123, 22)
        Me.mnuAboutUs.Text = "About Us"
        '
        'FrmMainMenu
        '
        Me.AcceptButton = Me.BtnMaximize
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1438, 1078)
        Me.ContextMenuStrip = Me.ctmMain
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelChildForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(1438, 835)
        Me.Name = "FrmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelTitleBar.ResumeLayout(False)
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelReportSubMenu.ResumeLayout(False)
        Me.panelPaymentSubMenu.ResumeLayout(False)
        Me.ctmMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnMaximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPayment As FontAwesome.Sharp.IconButton
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnStaff As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelChildForm As Panel
    Friend WithEvents btnHome As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLogOut As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReport As FontAwesome.Sharp.IconButton
    Friend WithEvents btnVoucher As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDiscount As FontAwesome.Sharp.IconButton
    Friend WithEvents btnProducts As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMember As FontAwesome.Sharp.IconButton
    Friend WithEvents panelPaymentSubMenu As Panel
    Friend WithEvents btnPaymentHistory As Button
    Friend WithEvents btnTransaction As Button
    Friend WithEvents PanelReportSubMenu As Panel
    Friend WithEvents btnPaymentReport As Button
    Friend WithEvents btnUserLoginReport As Button
    Friend WithEvents btnVoucherReport As Button
    Friend WithEvents btnDiscountReport As Button
    Friend WithEvents btnProductsReport As Button
    Friend WithEvents btnMemberReport As Button
    Friend WithEvents btnAboutUs As FontAwesome.Sharp.IconButton
    Friend WithEvents btnStaffReport As Button
    Friend WithEvents ctmMain As ContextMenuStrip
    Friend WithEvents mnuStaff As ToolStripMenuItem
    Friend WithEvents mnuPayment As ToolStripMenuItem
    Friend WithEvents mnuPaymentTransaction As ToolStripMenuItem
    Friend WithEvents mnuPaymentHistory As ToolStripMenuItem
    Friend WithEvents mnuMember As ToolStripMenuItem
    Friend WithEvents mnuProducts As ToolStripMenuItem
    Friend WithEvents mnuDiscount As ToolStripMenuItem
    Friend WithEvents mnuVoucher As ToolStripMenuItem
    Friend WithEvents mnuReport As ToolStripMenuItem
    Friend WithEvents mnuLogout As ToolStripMenuItem
    Friend WithEvents mnuAboutUs As ToolStripMenuItem
    Friend WithEvents mnuReportStaff As ToolStripMenuItem
    Friend WithEvents mnuReportPayment As ToolStripMenuItem
    Friend WithEvents mnuReportMember As ToolStripMenuItem
    Friend WithEvents mnuReportProduct As ToolStripMenuItem
    Friend WithEvents mnuReportDiscount As ToolStripMenuItem
    Friend WithEvents mnuReportVoucher As ToolStripMenuItem
    Friend WithEvents mnuReportUserLogin As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuHome As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class
