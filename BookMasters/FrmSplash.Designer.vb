<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSplash
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picBookStore = New System.Windows.Forms.PictureBox()
        CType(Me.picBookStore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(388, 146)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(498, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book Master Point of Sales System"
        '
        'picBookStore
        '
        Me.picBookStore.BackColor = System.Drawing.Color.Transparent
        Me.picBookStore.Image = Global.BookMasters.My.Resources.Resources.SplashBookStoreTransparent
        Me.picBookStore.Location = New System.Drawing.Point(-9, 12)
        Me.picBookStore.Name = "picBookStore"
        Me.picBookStore.Size = New System.Drawing.Size(401, 307)
        Me.picBookStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBookStore.TabIndex = 1
        Me.picBookStore.TabStop = False
        '
        'FrmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 354)
        Me.Controls.Add(Me.picBookStore)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FrmSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSplash"
        CType(Me.picBookStore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents picBookStore As PictureBox
End Class
