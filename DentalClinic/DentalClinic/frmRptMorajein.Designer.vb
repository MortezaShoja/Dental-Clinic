<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptMorajein
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptMorajein))
        Me.btnGenerate = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDate1 = New System.Windows.Forms.TextBox
        Me.txtDate2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboMoaref = New System.Windows.Forms.ComboBox
        Me.btnGenKol = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(104, 79)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(130, 36)
        Me.btnGenerate.TabIndex = 10
        Me.btnGenerate.Text = "گزارش بر حسب معرف"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(240, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "تا تاریخ :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "از تاریخ :"
        '
        'txtDate1
        '
        Me.txtDate1.Location = New System.Drawing.Point(104, 43)
        Me.txtDate1.Name = "txtDate1"
        Me.txtDate1.Size = New System.Drawing.Size(130, 30)
        Me.txtDate1.TabIndex = 7
        '
        'txtDate2
        '
        Me.txtDate2.Location = New System.Drawing.Point(293, 43)
        Me.txtDate2.Name = "txtDate2"
        Me.txtDate2.Size = New System.Drawing.Size(130, 30)
        Me.txtDate2.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "معرف :"
        '
        'cboMoaref
        '
        Me.cboMoaref.FormattingEnabled = True
        Me.cboMoaref.Location = New System.Drawing.Point(104, 6)
        Me.cboMoaref.Name = "cboMoaref"
        Me.cboMoaref.Size = New System.Drawing.Size(320, 31)
        Me.cboMoaref.TabIndex = 6
        '
        'btnGenKol
        '
        Me.btnGenKol.Location = New System.Drawing.Point(293, 79)
        Me.btnGenKol.Name = "btnGenKol"
        Me.btnGenKol.Size = New System.Drawing.Size(130, 36)
        Me.btnGenKol.TabIndex = 13
        Me.btnGenKol.Text = "گزارش کل معرف ها"
        Me.btnGenKol.UseVisualStyleBackColor = True
        '
        'frmRptMorajein
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 125)
        Me.Controls.Add(Me.btnGenKol)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDate1)
        Me.Controls.Add(Me.txtDate2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboMoaref)
        Me.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptMorajein"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "گزارش مراجعین معرفها:::..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDate1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDate2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboMoaref As System.Windows.Forms.ComboBox
    Friend WithEvents btnGenKol As System.Windows.Forms.Button
End Class
