<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegUsers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegUsers))
        Me.txtUserN = New System.Windows.Forms.TextBox
        Me.txtPass = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkAdmin = New System.Windows.Forms.CheckBox
        Me.btnRegNewUser = New System.Windows.Forms.Button
        Me.lblAdmin = New System.Windows.Forms.Label
        Me.lblLocked = New System.Windows.Forms.Label
        Me.chkLocked = New System.Windows.Forms.CheckBox
        Me.dgrUsers = New System.Windows.Forms.DataGridView
        Me.btnUpdate = New System.Windows.Forms.Button
        CType(Me.dgrUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUserN
        '
        Me.txtUserN.Location = New System.Drawing.Point(97, 6)
        Me.txtUserN.Name = "txtUserN"
        Me.txtUserN.Size = New System.Drawing.Size(237, 34)
        Me.txtUserN.TabIndex = 0
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(97, 46)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(237, 34)
        Me.txtPass.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 26)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "رمز عبرو :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 26)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "نام کاربری :"
        '
        'chkAdmin
        '
        Me.chkAdmin.AutoSize = True
        Me.chkAdmin.Location = New System.Drawing.Point(99, 95)
        Me.chkAdmin.Name = "chkAdmin"
        Me.chkAdmin.Size = New System.Drawing.Size(15, 14)
        Me.chkAdmin.TabIndex = 3
        Me.chkAdmin.UseVisualStyleBackColor = True
        '
        'btnRegNewUser
        '
        Me.btnRegNewUser.Location = New System.Drawing.Point(226, 323)
        Me.btnRegNewUser.Name = "btnRegNewUser"
        Me.btnRegNewUser.Size = New System.Drawing.Size(110, 33)
        Me.btnRegNewUser.TabIndex = 5
        Me.btnRegNewUser.Text = "ثبت کاربر جدید"
        Me.btnRegNewUser.UseVisualStyleBackColor = True
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Location = New System.Drawing.Point(47, 88)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(46, 26)
        Me.lblAdmin.TabIndex = 16
        Me.lblAdmin.Text = "مدیر :"
        '
        'lblLocked
        '
        Me.lblLocked.AutoSize = True
        Me.lblLocked.Location = New System.Drawing.Point(149, 88)
        Me.lblLocked.Name = "lblLocked"
        Me.lblLocked.Size = New System.Drawing.Size(40, 26)
        Me.lblLocked.TabIndex = 18
        Me.lblLocked.Text = "قفل :"
        '
        'chkLocked
        '
        Me.chkLocked.AutoSize = True
        Me.chkLocked.Location = New System.Drawing.Point(195, 95)
        Me.chkLocked.Name = "chkLocked"
        Me.chkLocked.Size = New System.Drawing.Size(15, 14)
        Me.chkLocked.TabIndex = 4
        Me.chkLocked.UseVisualStyleBackColor = True
        '
        'dgrUsers
        '
        Me.dgrUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrUsers.Location = New System.Drawing.Point(17, 117)
        Me.dgrUsers.Name = "dgrUsers"
        Me.dgrUsers.RowTemplate.ReadOnly = True
        Me.dgrUsers.Size = New System.Drawing.Size(319, 200)
        Me.dgrUsers.TabIndex = 19
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(17, 323)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(112, 33)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "ثبت تغییرات"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'frmRegUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 360)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dgrUsers)
        Me.Controls.Add(Me.lblLocked)
        Me.Controls.Add(Me.chkLocked)
        Me.Controls.Add(Me.lblAdmin)
        Me.Controls.Add(Me.txtUserN)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkAdmin)
        Me.Controls.Add(Me.btnRegNewUser)
        Me.Font = New System.Drawing.Font("B Titr", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegUsers"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ثبت کاربران:::..."
        CType(Me.dgrUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtUserN As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents btnRegNewUser As System.Windows.Forms.Button
    Friend WithEvents lblAdmin As System.Windows.Forms.Label
    Friend WithEvents lblLocked As System.Windows.Forms.Label
    Friend WithEvents chkLocked As System.Windows.Forms.CheckBox
    Friend WithEvents dgrUsers As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
End Class
