<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegTarefe
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
        Dim نوع_خدماتLabel As System.Windows.Forms.Label
        Dim نوع_تعرفهLabel As System.Windows.Forms.Label
        Dim کد_درمانLabel As System.Windows.Forms.Label
        Dim شرحLabel As System.Windows.Forms.Label
        Dim هزینه_خدماتLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegTarefe))
        Me.cboNoeKhadamat = New System.Windows.Forms.ComboBox
        Me.cboNoeTarefe = New System.Windows.Forms.ComboBox
        Me.txtCodeDarman = New System.Windows.Forms.TextBox
        Me.txtSharh = New System.Windows.Forms.TextBox
        Me.txtHazineKHadamat = New System.Windows.Forms.TextBox
        Me.txtSahmeDentist = New System.Windows.Forms.TextBox
        Me.btnRegTarefe = New System.Windows.Forms.Button
        Me.dgrView = New System.Windows.Forms.DataGridView
        نوع_خدماتLabel = New System.Windows.Forms.Label
        نوع_تعرفهLabel = New System.Windows.Forms.Label
        کد_درمانLabel = New System.Windows.Forms.Label
        شرحLabel = New System.Windows.Forms.Label
        هزینه_خدماتLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        CType(Me.dgrView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'نوع_خدماتLabel
        '
        نوع_خدماتLabel.AutoSize = True
        نوع_خدماتLabel.Location = New System.Drawing.Point(8, 16)
        نوع_خدماتLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        نوع_خدماتLabel.Name = "نوع_خدماتLabel"
        نوع_خدماتLabel.Size = New System.Drawing.Size(80, 26)
        نوع_خدماتLabel.TabIndex = 2
        نوع_خدماتLabel.Text = "نوع خدمات:"
        '
        'نوع_تعرفهLabel
        '
        نوع_تعرفهLabel.AutoSize = True
        نوع_تعرفهLabel.Location = New System.Drawing.Point(20, 61)
        نوع_تعرفهLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        نوع_تعرفهLabel.Name = "نوع_تعرفهLabel"
        نوع_تعرفهLabel.Size = New System.Drawing.Size(68, 26)
        نوع_تعرفهLabel.TabIndex = 4
        نوع_تعرفهLabel.Text = "نوع تعرفه:"
        '
        'کد_درمانLabel
        '
        کد_درمانLabel.AutoSize = True
        کد_درمانLabel.Location = New System.Drawing.Point(17, 106)
        کد_درمانLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        کد_درمانLabel.Name = "کد_درمانLabel"
        کد_درمانLabel.Size = New System.Drawing.Size(71, 26)
        کد_درمانLabel.TabIndex = 6
        کد_درمانLabel.Text = "کد درمان:"
        '
        'شرحLabel
        '
        شرحLabel.AutoSize = True
        شرحLabel.Location = New System.Drawing.Point(47, 150)
        شرحLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        شرحLabel.Name = "شرحLabel"
        شرحLabel.Size = New System.Drawing.Size(41, 26)
        شرحLabel.TabIndex = 8
        شرحLabel.Text = "شرح:"
        '
        'هزینه_خدماتLabel
        '
        هزینه_خدماتLabel.AutoSize = True
        هزینه_خدماتLabel.Location = New System.Drawing.Point(381, 17)
        هزینه_خدماتLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        هزینه_خدماتLabel.Name = "هزینه_خدماتLabel"
        هزینه_خدماتLabel.Size = New System.Drawing.Size(89, 26)
        هزینه_خدماتLabel.TabIndex = 10
        هزینه_خدماتLabel.Text = "هزینه خدمات:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(369, 66)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(101, 26)
        Label1.TabIndex = 17
        Label1.Text = "سهم دندانپزشک:"
        '
        'cboNoeKhadamat
        '
        Me.cboNoeKhadamat.FormattingEnabled = True
        Me.cboNoeKhadamat.Location = New System.Drawing.Point(96, 13)
        Me.cboNoeKhadamat.Margin = New System.Windows.Forms.Padding(4)
        Me.cboNoeKhadamat.Name = "cboNoeKhadamat"
        Me.cboNoeKhadamat.Size = New System.Drawing.Size(236, 34)
        Me.cboNoeKhadamat.TabIndex = 0
        '
        'cboNoeTarefe
        '
        Me.cboNoeTarefe.FormattingEnabled = True
        Me.cboNoeTarefe.Location = New System.Drawing.Point(96, 58)
        Me.cboNoeTarefe.Margin = New System.Windows.Forms.Padding(4)
        Me.cboNoeTarefe.Name = "cboNoeTarefe"
        Me.cboNoeTarefe.Size = New System.Drawing.Size(236, 34)
        Me.cboNoeTarefe.TabIndex = 1
        '
        'txtCodeDarman
        '
        Me.txtCodeDarman.Location = New System.Drawing.Point(96, 102)
        Me.txtCodeDarman.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodeDarman.Name = "txtCodeDarman"
        Me.txtCodeDarman.Size = New System.Drawing.Size(121, 34)
        Me.txtCodeDarman.TabIndex = 2
        '
        'txtSharh
        '
        Me.txtSharh.Location = New System.Drawing.Point(96, 146)
        Me.txtSharh.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSharh.Name = "txtSharh"
        Me.txtSharh.Size = New System.Drawing.Size(374, 34)
        Me.txtSharh.TabIndex = 3
        '
        'txtHazineKHadamat
        '
        Me.txtHazineKHadamat.Location = New System.Drawing.Point(478, 14)
        Me.txtHazineKHadamat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHazineKHadamat.Name = "txtHazineKHadamat"
        Me.txtHazineKHadamat.Size = New System.Drawing.Size(121, 34)
        Me.txtHazineKHadamat.TabIndex = 4
        '
        'txtSahmeDentist
        '
        Me.txtSahmeDentist.Location = New System.Drawing.Point(478, 58)
        Me.txtSahmeDentist.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSahmeDentist.Name = "txtSahmeDentist"
        Me.txtSahmeDentist.Size = New System.Drawing.Size(121, 34)
        Me.txtSahmeDentist.TabIndex = 5
        '
        'btnRegTarefe
        '
        Me.btnRegTarefe.Location = New System.Drawing.Point(478, 146)
        Me.btnRegTarefe.Name = "btnRegTarefe"
        Me.btnRegTarefe.Size = New System.Drawing.Size(121, 34)
        Me.btnRegTarefe.TabIndex = 6
        Me.btnRegTarefe.Text = "ثبت تعرفه"
        Me.btnRegTarefe.UseVisualStyleBackColor = True
        '
        'dgrView
        '
        Me.dgrView.AllowUserToAddRows = False
        Me.dgrView.AllowUserToDeleteRows = False
        Me.dgrView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrView.Location = New System.Drawing.Point(13, 197)
        Me.dgrView.Name = "dgrView"
        Me.dgrView.ReadOnly = True
        Me.dgrView.Size = New System.Drawing.Size(586, 174)
        Me.dgrView.TabIndex = 15
        '
        'frmRegTarefe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 383)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.dgrView)
        Me.Controls.Add(Me.btnRegTarefe)
        Me.Controls.Add(Me.txtSahmeDentist)
        Me.Controls.Add(هزینه_خدماتLabel)
        Me.Controls.Add(Me.txtHazineKHadamat)
        Me.Controls.Add(شرحLabel)
        Me.Controls.Add(Me.txtSharh)
        Me.Controls.Add(کد_درمانLabel)
        Me.Controls.Add(Me.txtCodeDarman)
        Me.Controls.Add(نوع_تعرفهLabel)
        Me.Controls.Add(Me.cboNoeTarefe)
        Me.Controls.Add(نوع_خدماتLabel)
        Me.Controls.Add(Me.cboNoeKhadamat)
        Me.Font = New System.Drawing.Font("B Titr", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegTarefe"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ثبت تعرفه :::..."
        CType(Me.dgrView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboNoeKhadamat As System.Windows.Forms.ComboBox
    Friend WithEvents cboNoeTarefe As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodeDarman As System.Windows.Forms.TextBox
    Friend WithEvents txtSharh As System.Windows.Forms.TextBox
    Friend WithEvents txtHazineKHadamat As System.Windows.Forms.TextBox
    Friend WithEvents txtSahmeDentist As System.Windows.Forms.TextBox
    Friend WithEvents btnRegTarefe As System.Windows.Forms.Button
    Friend WithEvents dgrView As System.Windows.Forms.DataGridView
End Class
