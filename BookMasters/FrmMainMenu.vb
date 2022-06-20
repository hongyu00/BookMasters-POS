Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class FrmMainMenu
    Private currentChildForm As Form

    Private Sub FrmMainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        hideSubMenu()
        imgHome_Click(Nothing, Nothing)
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
        CenterToScreen()

        detectUserLogin()

        'btnMaximize_Click（Nothing, Nothing)

        'set the report btn to deactive when the login role is staff
        setBtnBasedOnRole()

        strNotification = ""

        'Member and Voucher Module
        'To auto update the member status based on today's date
        FrmMemberAll.checkExpired()
        'To auto update the voucher status based on today's date
        FrmVoucherAll.updateStatus()

        'Discount Module
        EditDiscountInfo.deactivateDiscountPrice()
        AddNewDiscount.activateDiscountPrice()

        'Show the summary
        showNoti()

    End Sub

    Private Sub setBtnBasedOnRole()

        If UserLogin.strCurrentLoginStaffRole = "MANAGER" Then
            With btnReport
                .Enabled = True
                .BackColor = Color.FromArgb(204, 230, 255)
            End With
            setBtnEnabled(True)
        Else
            With btnReport
                .Enabled = False
                .BackColor = Color.FromArgb(234, 234, 234)
            End With
            setBtnEnabled(False)
        End If

    End Sub

    Private Sub setBtnEnabled(flag As Boolean)

        mnuReport.Enabled = flag
        mnuReportDiscount.Enabled = flag
        mnuReportProduct.Enabled = flag
        mnuReportMember.Enabled = flag
        mnuReportUserLogin.Enabled = flag
        mnuReportVoucher.Enabled = flag
        mnuReportPayment.Enabled = flag

    End Sub

    Private Sub hideSubMenu()
        panelPaymentSubMenu.Visible = False
        PanelReportSubMenu.Visible = False
    End Sub

    Private Sub showSubMenu(subMenu As Panel)
        If subMenu.Visible = False Then
            hideSubMenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form, formButton As IconButton)

        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm

        IconCurrentForm.IconChar = formButton.IconChar
        lblFormTitle.Text = formButton.Text
        childForm.BringToFront()
        childForm.Show()
        hideSubMenu()
    End Sub

    Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click, mnuHome.Click

        'If currentChildForm IsNot Nothing Then
        '    currentChildForm.Close()
        'End If
        'leftBorderBtn.Visible = False
        'IconCurrentForm.IconChar = IconChar.Home
        'lblFormTitle.Text = "Home"
        FrmHome.FrmHome_Load(Nothing, Nothing)
        OpenChildForm(FrmHome, btnHome)

    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click, mnuStaff.Click

        Dim frmStaff As Form = StaffViewInformation

        If UserLogin.strCurrentLoginStaffRole = "MANAGER" Then
            frmStaff = ManagerMain
        ElseIf UserLogin.strCurrentLoginStaffRole = "STAFF" Then
            frmStaff = StaffViewInformation
        End If

        OpenChildForm(frmStaff, btnStaff)
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click, mnuPayment.Click
        showSubMenu(panelPaymentSubMenu)

    End Sub
    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click, mnuPaymentTransaction.Click
        If openCounterAmount = 0 Then
            Dim result As DialogResult = MessageBox.Show("Please enter open counter amount only proceed to payment!", "Open Counter Amount Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = DialogResult.OK Then
                OpenChildForm(FrmHome, btnHome)
                FormOpenCounter.Show()
            End If
        ElseIf hasOpenCounter Then
            isOnTransaction = True
            OpenChildForm(FormPayment, btnPayment)
        End If

    End Sub

    Private Sub btnPaymentHistory_Click(sender As Object, e As EventArgs) Handles btnPaymentHistory.Click, mnuPaymentHistory.Click
        OpenChildForm(FormPaymentHistory, btnPayment)
    End Sub

    Private Sub btnMember_Click(sender As Object, e As EventArgs) Handles btnMember.Click, mnuMember.Click
        isOnTransaction = False
        OpenChildForm(FrmMemberAll, btnMember)
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click, mnuProducts.Click
        OpenChildForm(ViewAllProduct, btnProducts)
    End Sub

    Private Sub btnDiscount_Click(sender As Object, e As EventArgs) Handles btnDiscount.Click, mnuDiscount.Click
        OpenChildForm(ViewAllDiscount, btnDiscount)
    End Sub

    Private Sub btnVoucher_Click(sender As Object, e As EventArgs) Handles btnVoucher.Click, mnuVoucher.Click
        OpenChildForm(FrmVoucherAll, btnVoucher)
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click, mnuReport.Click
        showSubMenu(PanelReportSubMenu)
        'OpenChildForm(FormReport, btnReport)
    End Sub

    Private Sub btnAboutUs_Click_(sender As Object, e As EventArgs) Handles btnAboutUs.Click, mnuAboutUs.Click
        FrmAboutBox.ShowDialog()
    End Sub

#Region "submenu for report button"
    Private Sub btnStaffReport_Click(sender As Object, e As EventArgs) Handles btnStaffReport.Click, mnuReportStaff.Click
        OpenChildForm(MonthlyStaffJoinedReport, btnReport)
    End Sub

    Private Sub btnPaymentReport_Click(sender As Object, e As EventArgs) Handles btnPaymentReport.Click, mnuReportPayment.Click
        OpenChildForm(FormPaymentReport, btnReport)
    End Sub

    Private Sub btnMemberReport_Click(sender As Object, e As EventArgs) Handles btnMemberReport.Click, mnuReportMember.Click
        OpenChildForm(FrmMemberReportSelection, btnReport)
    End Sub

    Private Sub btnProductsReport_Click(sender As Object, e As EventArgs) Handles btnProductsReport.Click, mnuReportProduct.Click
        OpenChildForm(GenerateProductReport, btnReport)
    End Sub

    Private Sub btnDiscountReport_Click(sender As Object, e As EventArgs) Handles btnDiscountReport.Click, mnuReportDiscount.Click
        OpenChildForm(GenerateDiscountReport, btnReport)
    End Sub

    Private Sub btnVoucherReport_Click(sender As Object, e As EventArgs) Handles btnVoucherReport.Click, mnuReportVoucher.Click
        OpenChildForm(FrmVoucherReport, btnReport)
    End Sub

    Private Sub btnUserLoginReport_Click(sender As Object, e As EventArgs) Handles btnUserLoginReport.Click, mnuReportUserLogin.Click
        OpenChildForm(MonthlyUserLoginReport, btnReport)
    End Sub
#End Region

#Region "for dragging form and min,max,close button"
    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    'Close-Maximize-Minimize'
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Dim result As DialogResult = MessageBox.Show("Confirm to quit?", "Confirmation to Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles BtnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    'Remove transparent border in maximized state'
    Private Sub FrmMainMenu_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

#End Region

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click, mnuLogout.Click

        If UserLogin.strCurrentLoginStaffRole = "MANAGER" Then
            ManagerMain.Close()
        ElseIf UserLogin.strCurrentLoginStaffRole = "STAFF" Then
            StaffViewInformation.Close()
        End If

        Me.Close()
    End Sub

    Sub FrmMainMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        updateLoginRecord()
    End Sub

    Friend Sub detectUserLogin()

        If UserLogin.strCurrentLoginStaffID = "" Or
            UserLogin.strCurrentLoginStaffRole = "" Or
            UserLogin.strCurrectLogID = "" Then
            MessageBox.Show("Please login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            UserLogin.Show()
        End If

    End Sub

    Friend Sub updateLoginRecord()
        Try
            Dim logdb As New UserLogTimeDataContext()
            Dim loginRecord As UserLogTime = logdb.UserLogTimes.FirstOrDefault(Function(o) o.logID = UserLogin.strCurrectLogID)

            If loginRecord Is Nothing Then
                MessageBox.Show("Login ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                loginRecord.logoutTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                MessageBox.Show("Login ID      : " & loginRecord.logID & vbNewLine &
                                "Login time   : " & loginRecord.loginTime & vbNewLine &
                                "Logout time : " & loginRecord.logoutTime, "Logout Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                logdb.SubmitChanges()
            End If

            UserLogin.strCurrentLoginStaffID = ""
            UserLogin.strCurrentLoginStaffRole = ""
            UserLogin.strCurrectLogID = ""
            UserLogin.Show()
        Catch ex As Exception
            MessageBox.Show("Logout Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class