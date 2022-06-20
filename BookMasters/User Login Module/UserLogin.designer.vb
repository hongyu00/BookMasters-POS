<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserLogin
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnForgotPassword = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpLogin = New System.Windows.Forms.GroupBox()
        Me.ckbHidePassword = New System.Windows.Forms.CheckBox()
        Me.picPasswordLogo = New System.Windows.Forms.PictureBox()
        Me.picUserLogo = New System.Windows.Forms.PictureBox()
        Me.picBookMasterLogo = New System.Windows.Forms.PictureBox()
        Me.grpLogin.SuspendLayout()
        CType(Me.picPasswordLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUserLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBookMasterLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&User ID : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 178)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Password : "
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(117, 122)
        Me.txtUserID.Margin = New System.Windows.Forms.Padding(5)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(407, 45)
        Me.txtUserID.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(117, 226)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(407, 45)
        Me.txtPassword.TabIndex = 4
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.SpringGreen
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(50, 302)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(230, 58)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "&Sign In"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnForgotPassword
        '
        Me.btnForgotPassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnForgotPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForgotPassword.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnForgotPassword.Location = New System.Drawing.Point(313, 307)
        Me.btnForgotPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.btnForgotPassword.Name = "btnForgotPassword"
        Me.btnForgotPassword.Size = New System.Drawing.Size(211, 53)
        Me.btnForgotPassword.TabIndex = 6
        Me.btnForgotPassword.Text = "&Forgot Password"
        Me.btnForgotPassword.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(164, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(530, 46)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Book Store POS System"
        '
        'grpLogin
        '
        Me.grpLogin.BackColor = System.Drawing.Color.LightSkyBlue
        Me.grpLogin.Controls.Add(Me.ckbHidePassword)
        Me.grpLogin.Controls.Add(Me.btnForgotPassword)
        Me.grpLogin.Controls.Add(Me.Label2)
        Me.grpLogin.Controls.Add(Me.Label3)
        Me.grpLogin.Controls.Add(Me.txtUserID)
        Me.grpLogin.Controls.Add(Me.picPasswordLogo)
        Me.grpLogin.Controls.Add(Me.txtPassword)
        Me.grpLogin.Controls.Add(Me.picUserLogo)
        Me.grpLogin.Controls.Add(Me.btnLogin)
        Me.grpLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLogin.Location = New System.Drawing.Point(55, 253)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Size = New System.Drawing.Size(625, 398)
        Me.grpLogin.TabIndex = 12
        Me.grpLogin.TabStop = False
        Me.grpLogin.Text = "User Login"
        '
        'ckbHidePassword
        '
        Me.ckbHidePassword.AutoSize = True
        Me.ckbHidePassword.Checked = True
        Me.ckbHidePassword.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbHidePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbHidePassword.Location = New System.Drawing.Point(539, 236)
        Me.ckbHidePassword.Margin = New System.Windows.Forms.Padding(5)
        Me.ckbHidePassword.Name = "ckbHidePassword"
        Me.ckbHidePassword.Size = New System.Drawing.Size(78, 29)
        Me.ckbHidePassword.TabIndex = 9
        Me.ckbHidePassword.Text = "Hide"
        Me.ckbHidePassword.UseVisualStyleBackColor = True
        '
        'picPasswordLogo
        '
        Me.picPasswordLogo.Image = Global.BookMasters.My.Resources.Resources.PasswordIcon
        Me.picPasswordLogo.Location = New System.Drawing.Point(50, 226)
        Me.picPasswordLogo.Margin = New System.Windows.Forms.Padding(5)
        Me.picPasswordLogo.Name = "picPasswordLogo"
        Me.picPasswordLogo.Size = New System.Drawing.Size(58, 45)
        Me.picPasswordLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPasswordLogo.TabIndex = 8
        Me.picPasswordLogo.TabStop = False
        '
        'picUserLogo
        '
        Me.picUserLogo.Image = Global.BookMasters.My.Resources.Resources.Login
        Me.picUserLogo.Location = New System.Drawing.Point(50, 122)
        Me.picUserLogo.Margin = New System.Windows.Forms.Padding(5)
        Me.picUserLogo.Name = "picUserLogo"
        Me.picUserLogo.Size = New System.Drawing.Size(58, 45)
        Me.picUserLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUserLogo.TabIndex = 7
        Me.picUserLogo.TabStop = False
        '
        'picBookMasterLogo
        '
        Me.picBookMasterLogo.Image = Global.BookMasters.My.Resources.Resources.BookMasterLogo
        Me.picBookMasterLogo.Location = New System.Drawing.Point(185, 22)
        Me.picBookMasterLogo.Name = "picBookMasterLogo"
        Me.picBookMasterLogo.Size = New System.Drawing.Size(345, 146)
        Me.picBookMasterLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picBookMasterLogo.TabIndex = 10
        Me.picBookMasterLogo.TabStop = False
        '
        'UserLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(719, 679)
        Me.Controls.Add(Me.grpLogin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.picBookMasterLogo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "UserLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Login"
        Me.grpLogin.ResumeLayout(False)
        Me.grpLogin.PerformLayout()
        CType(Me.picPasswordLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUserLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBookMasterLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnForgotPassword As Button
    Friend WithEvents picUserLogo As PictureBox
    Friend WithEvents picPasswordLogo As PictureBox
    Friend WithEvents picBookMasterLogo As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents grpLogin As GroupBox
    Friend WithEvents ckbHidePassword As CheckBox
End Class
