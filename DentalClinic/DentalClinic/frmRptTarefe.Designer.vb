<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptTarefe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptTarefe))
        Me.cboNoekhadamat = New System.Windows.Forms.ComboBox
        Me.cboNoeTarefe = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnView = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioDentist = New System.Windows.Forms.RadioButton
        Me.Radiokhadamat = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboNoekhadamat
        '
        Me.cboNoekhadamat.FormattingEnabled = True
        Me.cboNoekhadamat.Location = New System.Drawing.Point(86, 12)
        Me.cboNoekhadamat.Name = "cboNoekhadamat"
        Me.cboNoekhadamat.Size = New System.Drawing.Size(215, 31)
        Me.cboNoekhadamat.TabIndex = 0
        '
        'cboNoeTarefe
        '
        Me.cboNoeTarefe.FormattingEnabled = True
        Me.cboNoeTarefe.Location = New System.Drawing.Point(86, 49)
        Me.cboNoeTarefe.Name = "cboNoeTarefe"
        Me.cboNoeTarefe.Size = New System.Drawing.Size(215, 31)
        Me.cboNoeTarefe.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "نوع خدمات :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "نوع تعرفه :"
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(226, 107)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 68)
        Me.btnView.TabIndex = 4
        Me.btnView.Text = "نمایش"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioDentist)
        Me.GroupBox1.Controls.Add(Me.Radiokhadamat)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "نوع گزارش"
        '
        'RadioDentist
        '
        Me.RadioDentist.AutoSize = True
        Me.RadioDentist.Location = New System.Drawing.Point(45, 59)
        Me.RadioDentist.Name = "RadioDentist"
        Me.RadioDentist.Size = New System.Drawing.Size(138, 27)
        Me.RadioDentist.TabIndex = 1
        Me.RadioDentist.Text = "گزارش سهم دندانپزشک"
        Me.RadioDentist.UseVisualStyleBackColor = True
        '
        'Radiokhadamat
        '
        Me.Radiokhadamat.AutoSize = True
        Me.Radiokhadamat.Checked = True
        Me.Radiokhadamat.Location = New System.Drawing.Point(57, 26)
        Me.Radiokhadamat.Name = "Radiokhadamat"
        Me.Radiokhadamat.Size = New System.Drawing.Size(127, 27)
        Me.Radiokhadamat.TabIndex = 0
        Me.Radiokhadamat.TabStop = True
        Me.Radiokhadamat.Text = "گزارش هزینه خدمات"
        Me.Radiokhadamat.UseVisualStyleBackColor = True
        '
        'frmRptTarefe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 201)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboNoeTarefe)
        Me.Controls.Add(Me.cboNoekhadamat)
        Me.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptTarefe"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "گزارش تعرفه :::..."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboNoekhadamat As System.Windows.Forms.ComboBox
    Friend WithEvents cboNoeTarefe As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioDentist As System.Windows.Forms.RadioButton
    Friend WithEvents Radiokhadamat As System.Windows.Forms.RadioButton
End Class
