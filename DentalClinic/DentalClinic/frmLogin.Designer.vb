<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtU As System.Windows.Forms.TextBox
    Friend WithEvents txtP As System.Windows.Forms.TextBox
    Friend WithEvents cmdLogin As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.txtU = New System.Windows.Forms.TextBox
        Me.txtP = New System.Windows.Forms.TextBox
        Me.cmdLogin = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.lbldate = New System.Windows.Forms.Label
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(2, 95)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UsernameLabel.Size = New System.Drawing.Size(69, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "نام کاربری :"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(7, 124)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PasswordLabel.Size = New System.Drawing.Size(64, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "کلمه عبور :"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtU
        '
        Me.txtU.Location = New System.Drawing.Point(77, 98)
        Me.txtU.Name = "txtU"
        Me.txtU.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtU.Size = New System.Drawing.Size(154, 20)
        Me.txtU.TabIndex = 1
        '
        'txtP
        '
        Me.txtP.Location = New System.Drawing.Point(77, 124)
        Me.txtP.Name = "txtP"
        Me.txtP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtP.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtP.Size = New System.Drawing.Size(154, 20)
        Me.txtP.TabIndex = 3
        '
        'cmdLogin
        '
        Me.cmdLogin.Location = New System.Drawing.Point(10, 160)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(103, 23)
        Me.cmdLogin.TabIndex = 4
        Me.cmdLogin.Text = "ورود"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(124, 160)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(103, 23)
        Me.cmdExit.TabIndex = 5
        Me.cmdExit.Text = "خروج"
        '
        'lbldate
        '
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.Blue
        Me.lbldate.Location = New System.Drawing.Point(5, 9)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(254, 39)
        Me.lbldate.TabIndex = 6
        Me.lbldate.Text = "Label1"
        Me.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(237, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(165, 193)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 192)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdLogin)
        Me.Controls.Add(Me.txtP)
        Me.Controls.Add(Me.txtU)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ورود به سیستم :::..."
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbldate As System.Windows.Forms.Label

End Class
