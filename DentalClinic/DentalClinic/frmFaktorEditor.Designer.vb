<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFaktorEditor
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
        Dim شرح_خدماتLabel As System.Windows.Forms.Label
        Dim نوع_خدماتLabel As System.Windows.Forms.Label
        Dim نوع_تعرفهLabel As System.Windows.Forms.Label
        Dim تعدادLabel As System.Windows.Forms.Label
        Dim نام_دندانپزشکLabel As System.Windows.Forms.Label
        Dim معرفLabel As System.Windows.Forms.Label
        Dim هزینه_خدماتLabel As System.Windows.Forms.Label
        Dim سهم_دندانپزشکLabel As System.Windows.Forms.Label
        Dim هزینه_نهائیLabel As System.Windows.Forms.Label
        Dim شماره_صورتحسابLabel As System.Windows.Forms.Label
        Dim کد_شناسائیLabel As System.Windows.Forms.Label
        Dim نامLabel As System.Windows.Forms.Label
        Dim نام_خانوادگیLabel As System.Windows.Forms.Label
        Dim تاریخ1Label As System.Windows.Forms.Label
        Dim روزLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFaktorEditor))
        Me.cboSharh = New System.Windows.Forms.ComboBox()
        Me.cboKhadamat = New System.Windows.Forms.ComboBox()
        Me.cboTarefe = New System.Windows.Forms.ComboBox()
        Me.txtTedad = New System.Windows.Forms.NumericUpDown()
        Me.cboDentistName = New System.Windows.Forms.ComboBox()
        Me.cboMoaref = New System.Windows.Forms.ComboBox()
        Me.txtDentist = New System.Windows.Forms.Label()
        Me.txtNahaee = New System.Windows.Forms.Label()
        Me.btnViewFaktor = New System.Windows.Forms.Button()
        Me.txtFaktorno = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtDaryafti = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.txtBaghimande = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.txtMandeAzGhabl = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtsum = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.txtSumKol = New System.Windows.Forms.ToolStripTextBox()
        Me.chkDel = New System.Windows.Forms.CheckBox()
        Me.listSharh = New System.Windows.Forms.ListBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnRegKhadamat = New System.Windows.Forms.Button()
        Me.txtKhadamat = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbReg = New System.Windows.Forms.RadioButton()
        Me.rbPrint = New System.Windows.Forms.RadioButton()
        Me.rbView = New System.Windows.Forms.RadioButton()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.txtFamiliCode = New System.Windows.Forms.TextBox()
        Me.txtNesbat = New System.Windows.Forms.TextBox()
        شرح_خدماتLabel = New System.Windows.Forms.Label()
        نوع_خدماتLabel = New System.Windows.Forms.Label()
        نوع_تعرفهLabel = New System.Windows.Forms.Label()
        تعدادLabel = New System.Windows.Forms.Label()
        نام_دندانپزشکLabel = New System.Windows.Forms.Label()
        معرفLabel = New System.Windows.Forms.Label()
        هزینه_خدماتLabel = New System.Windows.Forms.Label()
        سهم_دندانپزشکLabel = New System.Windows.Forms.Label()
        هزینه_نهائیLabel = New System.Windows.Forms.Label()
        شماره_صورتحسابLabel = New System.Windows.Forms.Label()
        کد_شناسائیLabel = New System.Windows.Forms.Label()
        نامLabel = New System.Windows.Forms.Label()
        نام_خانوادگیLabel = New System.Windows.Forms.Label()
        تاریخ1Label = New System.Windows.Forms.Label()
        روزLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.txtTedad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'شرح_خدماتLabel
        '
        شرح_خدماتLabel.AutoSize = True
        شرح_خدماتLabel.Location = New System.Drawing.Point(26, 193)
        شرح_خدماتLabel.Name = "شرح_خدماتLabel"
        شرح_خدماتLabel.Size = New System.Drawing.Size(73, 23)
        شرح_خدماتLabel.TabIndex = 2
        شرح_خدماتLabel.Text = "شرح خدمات:"
        '
        'نوع_خدماتLabel
        '
        نوع_خدماتLabel.AutoSize = True
        نوع_خدماتLabel.Location = New System.Drawing.Point(30, 119)
        نوع_خدماتLabel.Name = "نوع_خدماتLabel"
        نوع_خدماتLabel.Size = New System.Drawing.Size(69, 23)
        نوع_خدماتLabel.TabIndex = 4
        نوع_خدماتLabel.Text = "نوع خدمات:"
        '
        'نوع_تعرفهLabel
        '
        نوع_تعرفهLabel.AutoSize = True
        نوع_تعرفهLabel.Location = New System.Drawing.Point(41, 156)
        نوع_تعرفهLabel.Name = "نوع_تعرفهLabel"
        نوع_تعرفهLabel.Size = New System.Drawing.Size(58, 23)
        نوع_تعرفهLabel.TabIndex = 6
        نوع_تعرفهLabel.Text = "نوع تعرفه:"
        '
        'تعدادLabel
        '
        تعدادLabel.AutoSize = True
        تعدادLabel.Location = New System.Drawing.Point(458, 222)
        تعدادLabel.Name = "تعدادLabel"
        تعدادLabel.Size = New System.Drawing.Size(39, 23)
        تعدادLabel.TabIndex = 8
        تعدادLabel.Text = "تعداد:"
        '
        'نام_دندانپزشکLabel
        '
        نام_دندانپزشکLabel.AutoSize = True
        نام_دندانپزشکLabel.Location = New System.Drawing.Point(17, 45)
        نام_دندانپزشکLabel.Name = "نام_دندانپزشکLabel"
        نام_دندانپزشکLabel.Size = New System.Drawing.Size(83, 23)
        نام_دندانپزشکLabel.TabIndex = 10
        نام_دندانپزشکLabel.Text = "نام دندانپزشک:"
        '
        'معرفLabel
        '
        معرفLabel.AutoSize = True
        معرفLabel.Location = New System.Drawing.Point(60, 82)
        معرفLabel.Name = "معرفLabel"
        معرفLabel.Size = New System.Drawing.Size(40, 23)
        معرفLabel.TabIndex = 12
        معرفLabel.Text = "معرف:"
        '
        'هزینه_خدماتLabel
        '
        هزینه_خدماتLabel.AutoSize = True
        هزینه_خدماتLabel.Location = New System.Drawing.Point(631, 190)
        هزینه_خدماتLabel.Name = "هزینه_خدماتLabel"
        هزینه_خدماتLabel.Size = New System.Drawing.Size(77, 23)
        هزینه_خدماتLabel.TabIndex = 14
        هزینه_خدماتLabel.Text = "هزینه خدمات:"
        '
        'سهم_دندانپزشکLabel
        '
        سهم_دندانپزشکLabel.AutoSize = True
        سهم_دندانپزشکLabel.Location = New System.Drawing.Point(409, 190)
        سهم_دندانپزشکLabel.Name = "سهم_دندانپزشکLabel"
        سهم_دندانپزشکLabel.Size = New System.Drawing.Size(88, 23)
        سهم_دندانپزشکLabel.TabIndex = 18
        سهم_دندانپزشکLabel.Text = "سهم دندانپزشک:"
        '
        'هزینه_نهائیLabel
        '
        هزینه_نهائیLabel.AutoSize = True
        هزینه_نهائیLabel.Location = New System.Drawing.Point(641, 224)
        هزینه_نهائیLabel.Name = "هزینه_نهائیLabel"
        هزینه_نهائیLabel.Size = New System.Drawing.Size(67, 23)
        هزینه_نهائیLabel.TabIndex = 20
        هزینه_نهائیLabel.Text = "هزینه نهائی:"
        '
        'شماره_صورتحسابLabel
        '
        شماره_صورتحسابLabel.AutoSize = True
        شماره_صورتحسابLabel.Location = New System.Drawing.Point(399, 45)
        شماره_صورتحسابLabel.Name = "شماره_صورتحسابLabel"
        شماره_صورتحسابLabel.Size = New System.Drawing.Size(98, 23)
        شماره_صورتحسابLabel.TabIndex = 23
        شماره_صورتحسابLabel.Text = "شماره صورتحساب:"
        '
        'کد_شناسائیLabel
        '
        کد_شناسائیLabel.AutoSize = True
        کد_شناسائیLabel.Location = New System.Drawing.Point(638, 42)
        کد_شناسائیLabel.Name = "کد_شناسائیLabel"
        کد_شناسائیLabel.Size = New System.Drawing.Size(70, 23)
        کد_شناسائیLabel.TabIndex = 25
        کد_شناسائیLabel.Text = "کد شناسائی:"
        '
        'نامLabel
        '
        نامLabel.AutoSize = True
        نامLabel.Location = New System.Drawing.Point(469, 81)
        نامLabel.Name = "نامLabel"
        نامLabel.Size = New System.Drawing.Size(28, 23)
        نامLabel.TabIndex = 27
        نامLabel.Text = "نام:"
        '
        'نام_خانوادگیLabel
        '
        نام_خانوادگیLabel.AutoSize = True
        نام_خانوادگیLabel.Location = New System.Drawing.Point(632, 78)
        نام_خانوادگیLabel.Name = "نام_خانوادگیLabel"
        نام_خانوادگیLabel.Size = New System.Drawing.Size(76, 23)
        نام_خانوادگیLabel.TabIndex = 29
        نام_خانوادگیLabel.Text = "نام خانوادگی:"
        '
        'تاریخ1Label
        '
        تاریخ1Label.AutoSize = True
        تاریخ1Label.Location = New System.Drawing.Point(458, 117)
        تاریخ1Label.Name = "تاریخ1Label"
        تاریخ1Label.Size = New System.Drawing.Size(39, 23)
        تاریخ1Label.TabIndex = 31
        تاریخ1Label.Text = "تاریخ:"
        '
        'روزLabel
        '
        روزLabel.AutoSize = True
        روزLabel.Location = New System.Drawing.Point(676, 114)
        روزLabel.Name = "روزLabel"
        روزLabel.Size = New System.Drawing.Size(32, 23)
        روزLabel.TabIndex = 33
        روزLabel.Text = "روز:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(629, 150)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(79, 23)
        Label1.TabIndex = 44
        Label1.Text = "کد خانوادگی :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(455, 153)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(42, 23)
        Label2.TabIndex = 42
        Label2.Text = "نسبت :"
        '
        'cboSharh
        '
        Me.cboSharh.FormattingEnabled = True
        Me.cboSharh.Location = New System.Drawing.Point(105, 190)
        Me.cboSharh.Name = "cboSharh"
        Me.cboSharh.Size = New System.Drawing.Size(270, 31)
        Me.cboSharh.TabIndex = 3
        '
        'cboKhadamat
        '
        Me.cboKhadamat.FormattingEnabled = True
        Me.cboKhadamat.Location = New System.Drawing.Point(105, 116)
        Me.cboKhadamat.Name = "cboKhadamat"
        Me.cboKhadamat.Size = New System.Drawing.Size(270, 31)
        Me.cboKhadamat.TabIndex = 5
        '
        'cboTarefe
        '
        Me.cboTarefe.FormattingEnabled = True
        Me.cboTarefe.Location = New System.Drawing.Point(105, 153)
        Me.cboTarefe.Name = "cboTarefe"
        Me.cboTarefe.Size = New System.Drawing.Size(270, 31)
        Me.cboTarefe.TabIndex = 7
        '
        'txtTedad
        '
        Me.txtTedad.Location = New System.Drawing.Point(503, 220)
        Me.txtTedad.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.txtTedad.Name = "txtTedad"
        Me.txtTedad.Size = New System.Drawing.Size(123, 30)
        Me.txtTedad.TabIndex = 9
        '
        'cboDentistName
        '
        Me.cboDentistName.FormattingEnabled = True
        Me.cboDentistName.Location = New System.Drawing.Point(106, 42)
        Me.cboDentistName.Name = "cboDentistName"
        Me.cboDentistName.Size = New System.Drawing.Size(269, 31)
        Me.cboDentistName.TabIndex = 11
        '
        'cboMoaref
        '
        Me.cboMoaref.FormattingEnabled = True
        Me.cboMoaref.Location = New System.Drawing.Point(106, 79)
        Me.cboMoaref.Name = "cboMoaref"
        Me.cboMoaref.Size = New System.Drawing.Size(269, 31)
        Me.cboMoaref.TabIndex = 13
        '
        'txtDentist
        '
        Me.txtDentist.BackColor = System.Drawing.Color.White
        Me.txtDentist.Location = New System.Drawing.Point(503, 186)
        Me.txtDentist.Name = "txtDentist"
        Me.txtDentist.Size = New System.Drawing.Size(123, 30)
        Me.txtDentist.TabIndex = 19
        '
        'txtNahaee
        '
        Me.txtNahaee.BackColor = System.Drawing.Color.White
        Me.txtNahaee.Location = New System.Drawing.Point(714, 219)
        Me.txtNahaee.Name = "txtNahaee"
        Me.txtNahaee.Size = New System.Drawing.Size(123, 31)
        Me.txtNahaee.TabIndex = 21
        '
        'btnViewFaktor
        '
        Me.btnViewFaktor.Location = New System.Drawing.Point(6, 46)
        Me.btnViewFaktor.Name = "btnViewFaktor"
        Me.btnViewFaktor.Size = New System.Drawing.Size(81, 59)
        Me.btnViewFaktor.TabIndex = 23
        Me.btnViewFaktor.Text = "صدور صورتحساب"
        Me.btnViewFaktor.UseVisualStyleBackColor = True
        '
        'txtFaktorno
        '
        Me.txtFaktorno.Location = New System.Drawing.Point(503, 42)
        Me.txtFaktorno.Name = "txtFaktorno"
        Me.txtFaktorno.Size = New System.Drawing.Size(123, 30)
        Me.txtFaktorno.TabIndex = 24
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(714, 39)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(123, 30)
        Me.txtID.TabIndex = 26
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(503, 78)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(123, 30)
        Me.txtName.TabIndex = 28
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(714, 75)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(123, 30)
        Me.txtLname.TabIndex = 30
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(503, 114)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(123, 30)
        Me.txtDate.TabIndex = 32
        '
        'txtDay
        '
        Me.txtDay.Location = New System.Drawing.Point(714, 111)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(123, 30)
        Me.txtDay.TabIndex = 34
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.txtDaryafti, Me.ToolStripLabel3, Me.txtBaghimande, Me.ToolStripLabel4, Me.txtMandeAzGhabl, Me.ToolStripLabel1, Me.txtsum, Me.ToolStripLabel5, Me.txtSumKol})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(851, 25)
        Me.ToolStrip1.TabIndex = 35
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripLabel2.Text = "دریافتی :"
        '
        'txtDaryafti
        '
        Me.txtDaryafti.Name = "txtDaryafti"
        Me.txtDaryafti.Size = New System.Drawing.Size(100, 25)
        Me.txtDaryafti.Text = "0"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripLabel3.Text = "باقیمانده :"
        '
        'txtBaghimande
        '
        Me.txtBaghimande.Name = "txtBaghimande"
        Me.txtBaghimande.Size = New System.Drawing.Size(100, 25)
        Me.txtBaghimande.Text = "0"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripLabel4.Text = "مانده از قبل :"
        '
        'txtMandeAzGhabl
        '
        Me.txtMandeAzGhabl.Name = "txtMandeAzGhabl"
        Me.txtMandeAzGhabl.Size = New System.Drawing.Size(100, 25)
        Me.txtMandeAzGhabl.Text = "0"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripLabel1.Text = "جمع این دوره :"
        '
        'txtsum
        '
        Me.txtsum.Name = "txtsum"
        Me.txtsum.Size = New System.Drawing.Size(100, 25)
        Me.txtsum.Text = "0"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripLabel5.Text = "جمع کل :"
        '
        'txtSumKol
        '
        Me.txtSumKol.Name = "txtSumKol"
        Me.txtSumKol.Size = New System.Drawing.Size(100, 25)
        Me.txtSumKol.Text = "0"
        '
        'chkDel
        '
        Me.chkDel.AutoSize = True
        Me.chkDel.Location = New System.Drawing.Point(454, 261)
        Me.chkDel.Name = "chkDel"
        Me.chkDel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDel.Size = New System.Drawing.Size(62, 27)
        Me.chkDel.TabIndex = 36
        Me.chkDel.Text = ": حذف"
        Me.chkDel.UseVisualStyleBackColor = True
        '
        'listSharh
        '
        Me.listSharh.FormattingEnabled = True
        Me.listSharh.ItemHeight = 23
        Me.listSharh.Location = New System.Drawing.Point(105, 227)
        Me.listSharh.Name = "listSharh"
        Me.listSharh.Size = New System.Drawing.Size(270, 188)
        Me.listSharh.TabIndex = 37
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(445, 295)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(132, 35)
        Me.btnEdit.TabIndex = 38
        Me.btnEdit.Text = "ثبت تغییرات"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnRegKhadamat
        '
        Me.btnRegKhadamat.Image = CType(resources.GetObject("btnRegKhadamat.Image"), System.Drawing.Image)
        Me.btnRegKhadamat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegKhadamat.Location = New System.Drawing.Point(445, 373)
        Me.btnRegKhadamat.Name = "btnRegKhadamat"
        Me.btnRegKhadamat.Size = New System.Drawing.Size(132, 37)
        Me.btnRegKhadamat.TabIndex = 39
        Me.btnRegKhadamat.Text = "ثبت خدمات جدید"
        Me.btnRegKhadamat.UseVisualStyleBackColor = True
        '
        'txtKhadamat
        '
        Me.txtKhadamat.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKhadamat.Location = New System.Drawing.Point(714, 183)
        Me.txtKhadamat.Name = "txtKhadamat"
        Me.txtKhadamat.Size = New System.Drawing.Size(123, 30)
        Me.txtKhadamat.TabIndex = 40
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbReg)
        Me.GroupBox1.Controls.Add(Me.rbPrint)
        Me.GroupBox1.Controls.Add(Me.rbView)
        Me.GroupBox1.Controls.Add(Me.btnViewFaktor)
        Me.GroupBox1.Location = New System.Drawing.Point(603, 283)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 131)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "صدور صورتحساب :"
        '
        'rbReg
        '
        Me.rbReg.AutoSize = True
        Me.rbReg.Location = New System.Drawing.Point(115, 95)
        Me.rbReg.Name = "rbReg"
        Me.rbReg.Size = New System.Drawing.Size(96, 17)
        Me.rbReg.TabIndex = 26
        Me.rbReg.Text = "ثبت صورتحساب"
        Me.rbReg.UseVisualStyleBackColor = True
        '
        'rbPrint
        '
        Me.rbPrint.AutoSize = True
        Me.rbPrint.Checked = True
        Me.rbPrint.Location = New System.Drawing.Point(111, 62)
        Me.rbPrint.Name = "rbPrint"
        Me.rbPrint.Size = New System.Drawing.Size(99, 17)
        Me.rbPrint.TabIndex = 25
        Me.rbPrint.TabStop = True
        Me.rbPrint.Text = "چاپ صورتحساب"
        Me.rbPrint.UseVisualStyleBackColor = True
        '
        'rbView
        '
        Me.rbView.AutoSize = True
        Me.rbView.Location = New System.Drawing.Point(104, 29)
        Me.rbView.Name = "rbView"
        Me.rbView.Size = New System.Drawing.Size(106, 17)
        Me.rbView.TabIndex = 24
        Me.rbView.Text = "نمایش صورتحساب"
        Me.rbView.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'txtFamiliCode
        '
        Me.txtFamiliCode.Location = New System.Drawing.Point(714, 147)
        Me.txtFamiliCode.Name = "txtFamiliCode"
        Me.txtFamiliCode.Size = New System.Drawing.Size(123, 30)
        Me.txtFamiliCode.TabIndex = 45
        '
        'txtNesbat
        '
        Me.txtNesbat.Location = New System.Drawing.Point(503, 150)
        Me.txtNesbat.Name = "txtNesbat"
        Me.txtNesbat.Size = New System.Drawing.Size(123, 30)
        Me.txtNesbat.TabIndex = 43
        '
        'frmFaktorEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 435)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtFamiliCode)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txtNesbat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtKhadamat)
        Me.Controls.Add(Me.btnRegKhadamat)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.listSharh)
        Me.Controls.Add(Me.chkDel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(روزLabel)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(تاریخ1Label)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(نام_خانوادگیLabel)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(نامLabel)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(کد_شناسائیLabel)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(شماره_صورتحسابLabel)
        Me.Controls.Add(Me.txtFaktorno)
        Me.Controls.Add(هزینه_نهائیLabel)
        Me.Controls.Add(Me.txtNahaee)
        Me.Controls.Add(سهم_دندانپزشکLabel)
        Me.Controls.Add(Me.txtDentist)
        Me.Controls.Add(هزینه_خدماتLabel)
        Me.Controls.Add(معرفLabel)
        Me.Controls.Add(Me.cboMoaref)
        Me.Controls.Add(نام_دندانپزشکLabel)
        Me.Controls.Add(Me.cboDentistName)
        Me.Controls.Add(تعدادLabel)
        Me.Controls.Add(Me.txtTedad)
        Me.Controls.Add(نوع_تعرفهLabel)
        Me.Controls.Add(Me.cboTarefe)
        Me.Controls.Add(نوع_خدماتLabel)
        Me.Controls.Add(Me.cboKhadamat)
        Me.Controls.Add(شرح_خدماتLabel)
        Me.Controls.Add(Me.cboSharh)
        Me.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFaktorEditor"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "پیش نمایش فاکتور:::..."
        CType(Me.txtTedad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboSharh As System.Windows.Forms.ComboBox
    Friend WithEvents cboKhadamat As System.Windows.Forms.ComboBox
    Friend WithEvents cboTarefe As System.Windows.Forms.ComboBox
    Friend WithEvents txtTedad As System.Windows.Forms.NumericUpDown
    Friend WithEvents cboDentistName As System.Windows.Forms.ComboBox
    Friend WithEvents cboMoaref As System.Windows.Forms.ComboBox
    Friend WithEvents txtDentist As System.Windows.Forms.Label
    Friend WithEvents txtNahaee As System.Windows.Forms.Label
    Friend WithEvents CounterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnViewFaktor As System.Windows.Forms.Button
    Friend WithEvents txtFaktorno As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents txtDay As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents txtDaryafti As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents txtsum As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents txtMandeAzGhabl As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents txtBaghimande As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtSumKol As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents chkDel As System.Windows.Forms.CheckBox
    Friend WithEvents listSharh As System.Windows.Forms.ListBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnRegKhadamat As System.Windows.Forms.Button
    Friend WithEvents txtKhadamat As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbPrint As System.Windows.Forms.RadioButton
    Friend WithEvents rbView As System.Windows.Forms.RadioButton
    Friend WithEvents rbReg As System.Windows.Forms.RadioButton
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents txtFamiliCode As System.Windows.Forms.TextBox
    Friend WithEvents txtNesbat As System.Windows.Forms.TextBox
End Class
