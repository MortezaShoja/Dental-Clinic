<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFKGen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFKGen))
        Me.txtDate1 = New System.Windows.Forms.TextBox
        Me.txtDate2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnGenerate = New System.Windows.Forms.Button
        Me.rbView = New System.Windows.Forms.RadioButton
        Me.rbPrint = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'txtDate1
        '
        Me.txtDate1.Location = New System.Drawing.Point(70, 10)
        Me.txtDate1.Name = "txtDate1"
        Me.txtDate1.Size = New System.Drawing.Size(150, 30)
        Me.txtDate1.TabIndex = 0
        '
        'txtDate2
        '
        Me.txtDate2.Location = New System.Drawing.Point(70, 46)
        Me.txtDate2.Name = "txtDate2"
        Me.txtDate2.Size = New System.Drawing.Size(150, 30)
        Me.txtDate2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "از تاریخ :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "تا تاریخ :"
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(132, 82)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(88, 60)
        Me.btnGenerate.TabIndex = 4
        Me.btnGenerate.Text = "صدور صورتحساب کلی"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'rbView
        '
        Me.rbView.AutoSize = True
        Me.rbView.Checked = True
        Me.rbView.Location = New System.Drawing.Point(14, 82)
        Me.rbView.Name = "rbView"
        Me.rbView.Size = New System.Drawing.Size(112, 27)
        Me.rbView.TabIndex = 5
        Me.rbView.TabStop = True
        Me.rbView.Text = "نمایش صورتحساب"
        Me.rbView.UseVisualStyleBackColor = True
        '
        'rbPrint
        '
        Me.rbPrint.AutoSize = True
        Me.rbPrint.Location = New System.Drawing.Point(14, 115)
        Me.rbPrint.Name = "rbPrint"
        Me.rbPrint.Size = New System.Drawing.Size(105, 27)
        Me.rbPrint.TabIndex = 6
        Me.rbPrint.Text = "چاپ صورتحساب"
        Me.rbPrint.UseVisualStyleBackColor = True
        '
        'frmFKGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 146)
        Me.Controls.Add(Me.rbPrint)
        Me.Controls.Add(Me.rbView)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDate2)
        Me.Controls.Add(Me.txtDate1)
        Me.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFKGen"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "صدور صورتحساب کلی:::.."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDate1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDate2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents rbView As System.Windows.Forms.RadioButton
    Friend WithEvents rbPrint As System.Windows.Forms.RadioButton
End Class
