<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptAmalkardeDentist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptAmalkardeDentist))
        Me.cboDentistName = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDate2 = New System.Windows.Forms.TextBox
        Me.txtDate1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnGenerate = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cboDentistName
        '
        Me.cboDentistName.FormattingEnabled = True
        Me.cboDentistName.Location = New System.Drawing.Point(103, 8)
        Me.cboDentistName.Name = "cboDentistName"
        Me.cboDentistName.Size = New System.Drawing.Size(320, 31)
        Me.cboDentistName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "نام دندانپزشک :"
        '
        'txtDate2
        '
        Me.txtDate2.Location = New System.Drawing.Point(292, 45)
        Me.txtDate2.Name = "txtDate2"
        Me.txtDate2.Size = New System.Drawing.Size(130, 30)
        Me.txtDate2.TabIndex = 2
        '
        'txtDate1
        '
        Me.txtDate1.Location = New System.Drawing.Point(103, 45)
        Me.txtDate1.Name = "txtDate1"
        Me.txtDate1.Size = New System.Drawing.Size(130, 30)
        Me.txtDate1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "از تاریخ :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(239, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "تا تاریخ :"
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(103, 81)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(130, 36)
        Me.btnGenerate.TabIndex = 3
        Me.btnGenerate.Text = "صدور صورتحساب"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'frmRptAmalkardeDentist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 125)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDate1)
        Me.Controls.Add(Me.txtDate2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboDentistName)
        Me.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptAmalkardeDentist"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "صورت ریز عملکرد  روزانه دندانپزشک:::..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboDentistName As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDate2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDate1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
End Class
