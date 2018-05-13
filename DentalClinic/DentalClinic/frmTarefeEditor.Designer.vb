<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarefeEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTarefeEditor))
        Me.cboKhadamat = New System.Windows.Forms.ComboBox
        Me.cboTarafe = New System.Windows.Forms.ComboBox
        Me.txtSharh = New System.Windows.Forms.TextBox
        Me.txtSahmeDentist = New System.Windows.Forms.TextBox
        Me.txtHazinekhadamat = New System.Windows.Forms.TextBox
        Me.txtCodeDarman = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dgrView = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnReg = New System.Windows.Forms.Button
        CType(Me.dgrView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboKhadamat
        '
        Me.cboKhadamat.FormattingEnabled = True
        Me.cboKhadamat.Location = New System.Drawing.Point(8, 22)
        Me.cboKhadamat.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cboKhadamat.Name = "cboKhadamat"
        Me.cboKhadamat.Size = New System.Drawing.Size(193, 31)
        Me.cboKhadamat.TabIndex = 1
        '
        'cboTarafe
        '
        Me.cboTarafe.FormattingEnabled = True
        Me.cboTarafe.Location = New System.Drawing.Point(8, 63)
        Me.cboTarafe.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cboTarafe.Name = "cboTarafe"
        Me.cboTarafe.Size = New System.Drawing.Size(193, 31)
        Me.cboTarafe.TabIndex = 2
        '
        'txtSharh
        '
        Me.txtSharh.Location = New System.Drawing.Point(131, 63)
        Me.txtSharh.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtSharh.Name = "txtSharh"
        Me.txtSharh.Size = New System.Drawing.Size(363, 30)
        Me.txtSharh.TabIndex = 6
        '
        'txtSahmeDentist
        '
        Me.txtSahmeDentist.Location = New System.Drawing.Point(19, 20)
        Me.txtSahmeDentist.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtSahmeDentist.Name = "txtSahmeDentist"
        Me.txtSahmeDentist.Size = New System.Drawing.Size(103, 30)
        Me.txtSahmeDentist.TabIndex = 5
        '
        'txtHazinekhadamat
        '
        Me.txtHazinekhadamat.Location = New System.Drawing.Point(234, 22)
        Me.txtHazinekhadamat.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtHazinekhadamat.Name = "txtHazinekhadamat"
        Me.txtHazinekhadamat.Size = New System.Drawing.Size(103, 30)
        Me.txtHazinekhadamat.TabIndex = 4
        '
        'txtCodeDarman
        '
        Me.txtCodeDarman.Location = New System.Drawing.Point(437, 22)
        Me.txtCodeDarman.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtCodeDarman.Name = "txtCodeDarman"
        Me.txtCodeDarman.Size = New System.Drawing.Size(57, 30)
        Me.txtCodeDarman.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(494, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "شرح خدمات"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "سهم دندانپزشک"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(347, 29)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "هزینه خدمات "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(508, 29)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "کد درمان "
        '
        'dgrView
        '
        Me.dgrView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrView.Location = New System.Drawing.Point(14, 141)
        Me.dgrView.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.dgrView.Name = "dgrView"
        Me.dgrView.Size = New System.Drawing.Size(866, 359)
        Me.dgrView.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboTarafe)
        Me.GroupBox1.Controls.Add(Me.cboKhadamat)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 115)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "گزارش"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(210, 72)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "نوع تعرفه"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(210, 29)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "نوع خدمات"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnReg)
        Me.GroupBox2.Controls.Add(Me.txtCodeDarman)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtHazinekhadamat)
        Me.GroupBox2.Controls.Add(Me.txtSharh)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtSahmeDentist)
        Me.GroupBox2.Location = New System.Drawing.Point(304, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(576, 115)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "نمایش تعرفه مورد نظر"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(19, 62)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(48, 32)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnReg
        '
        Me.btnReg.Location = New System.Drawing.Point(73, 63)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(49, 32)
        Me.btnReg.TabIndex = 7
        Me.btnReg.Text = "ثبت"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'frmTarefeEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 516)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgrView)
        Me.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTarefeEditor"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "نمایش تعرفه :::..."
        CType(Me.dgrView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboKhadamat As System.Windows.Forms.ComboBox
    Friend WithEvents cboTarafe As System.Windows.Forms.ComboBox
    Friend WithEvents txtSharh As System.Windows.Forms.TextBox
    Friend WithEvents txtSahmeDentist As System.Windows.Forms.TextBox
    Friend WithEvents txtHazinekhadamat As System.Windows.Forms.TextBox
    Friend WithEvents txtCodeDarman As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgrView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnReg As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
