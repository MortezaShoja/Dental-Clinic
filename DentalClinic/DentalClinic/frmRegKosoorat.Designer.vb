<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegKosoorat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegKosoorat))
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboDentistName = New System.Windows.Forms.ComboBox
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnReg = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtEllat = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "نام دندانپزشک :"
        '
        'cboDentistName
        '
        Me.cboDentistName.FormattingEnabled = True
        Me.cboDentistName.Location = New System.Drawing.Point(92, 17)
        Me.cboDentistName.Name = "cboDentistName"
        Me.cboDentistName.Size = New System.Drawing.Size(231, 31)
        Me.cboDentistName.TabIndex = 0
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(92, 90)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 30)
        Me.txtPrice.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "کسر مبلغ :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ریال"
        '
        'btnReg
        '
        Me.btnReg.Location = New System.Drawing.Point(248, 90)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(75, 30)
        Me.btnReg.TabIndex = 3
        Me.btnReg.Text = "ثبت"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "علت :"
        '
        'txtEllat
        '
        Me.txtEllat.Location = New System.Drawing.Point(92, 54)
        Me.txtEllat.Name = "txtEllat"
        Me.txtEllat.Size = New System.Drawing.Size(231, 30)
        Me.txtEllat.TabIndex = 1
        '
        'frmRegKosoorat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 128)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEllat)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.cboDentistName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegKosoorat"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "فرم ثبت کسورات :::..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboDentistName As System.Windows.Forms.ComboBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnReg As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEllat As System.Windows.Forms.TextBox
End Class
