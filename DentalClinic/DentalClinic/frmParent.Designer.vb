<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParent
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUserName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtUserName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabBimaran = New System.Windows.Forms.TabPage()
        Me.btnViewTime = New System.Windows.Forms.Button()
        Me.btnRegVaghteGhabli = New System.Windows.Forms.Button()
        Me.btnBimaran = New System.Windows.Forms.Button()
        Me.TabSooratHesab = New System.Windows.Forms.TabPage()
        Me.btnRptSooratHesabKoli = New System.Windows.Forms.Button()
        Me.btnFaktorAlmosana = New System.Windows.Forms.Button()
        Me.btnFaktorEditor = New System.Windows.Forms.Button()
        Me.btnFaktorEdame = New System.Windows.Forms.Button()
        Me.TabMoaref = New System.Windows.Forms.TabPage()
        Me.btnRptMoaref = New System.Windows.Forms.Button()
        Me.BtnRegMoaref = New System.Windows.Forms.Button()
        Me.TabPezeshk = New System.Windows.Forms.TabPage()
        Me.btnKosoorat = New System.Windows.Forms.Button()
        Me.btnRegDentist = New System.Windows.Forms.Button()
        Me.TabTarefe = New System.Windows.Forms.TabPage()
        Me.btnRptTarefe = New System.Windows.Forms.Button()
        Me.btnViewTarefe = New System.Windows.Forms.Button()
        Me.btnRegTarefe = New System.Windows.Forms.Button()
        Me.btnRegNoeKHadamat = New System.Windows.Forms.Button()
        Me.btnRegNoeTarafe = New System.Windows.Forms.Button()
        Me.TabReport = New System.Windows.Forms.TabPage()
        Me.btnRptBedehkaran = New System.Windows.Forms.Button()
        Me.btnAmalkardRoozane = New System.Windows.Forms.Button()
        Me.btnRptRizAmalkard = New System.Windows.Forms.Button()
        Me.btnRptAmalkardKol = New System.Windows.Forms.Button()
        Me.TabManaging = New System.Windows.Forms.TabPage()
        Me.btnRegUser = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabBimaran.SuspendLayout()
        Me.TabSooratHesab.SuspendLayout()
        Me.TabMoaref.SuspendLayout()
        Me.TabPezeshk.SuspendLayout()
        Me.TabTarefe.SuspendLayout()
        Me.TabReport.SuspendLayout()
        Me.TabManaging.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 5
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblDate, Me.txtDate, Me.lblTime, Me.txtTime, Me.lblUserName, Me.txtUserName})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 720)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(42, 0, 4, 0)
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(715, 22)
        Me.StatusStrip1.TabIndex = 23
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblDate
        '
        Me.lblDate.ForeColor = System.Drawing.Color.Black
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(39, 17)
        Me.lblDate.Text = "تاریخ :"
        '
        'txtDate
        '
        Me.txtDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(65, 17)
        Me.txtDate.Text = "1385/11/10"
        '
        'lblTime
        '
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(41, 17)
        Me.lblTime.Text = "ساعت :"
        '
        'txtTime
        '
        Me.txtTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(60, 17)
        Me.txtTime.Text = "05:07 عصر"
        '
        'lblUserName
        '
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(55, 17)
        Me.lblUserName.Text = "نام کاربر :"
        '
        'txtUserName
        '
        Me.txtUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(72, 17)
        Me.txtUserName.Text = "مرتضی شجاع"
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.TabBimaran)
        Me.TabControl1.Controls.Add(Me.TabSooratHesab)
        Me.TabControl1.Controls.Add(Me.TabMoaref)
        Me.TabControl1.Controls.Add(Me.TabPezeshk)
        Me.TabControl1.Controls.Add(Me.TabTarefe)
        Me.TabControl1.Controls.Add(Me.TabReport)
        Me.TabControl1.Controls.Add(Me.TabManaging)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TabControl1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(198, 720)
        Me.TabControl1.TabIndex = 24
        '
        'TabBimaran
        '
        Me.TabBimaran.BackgroundImage = Global.DentalClinic.My.Resources.Resources.WindowsXP040
        Me.TabBimaran.Controls.Add(Me.btnViewTime)
        Me.TabBimaran.Controls.Add(Me.btnRegVaghteGhabli)
        Me.TabBimaran.Controls.Add(Me.btnBimaran)
        Me.TabBimaran.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.TabBimaran.Location = New System.Drawing.Point(35, 4)
        Me.TabBimaran.Name = "TabBimaran"
        Me.TabBimaran.Padding = New System.Windows.Forms.Padding(3)
        Me.TabBimaran.Size = New System.Drawing.Size(159, 712)
        Me.TabBimaran.TabIndex = 0
        Me.TabBimaran.Text = "بیماران"
        Me.TabBimaran.UseVisualStyleBackColor = True
        '
        'btnViewTime
        '
        Me.btnViewTime.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnViewTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnViewTime.ImageList = Me.ImageList1
        Me.btnViewTime.Location = New System.Drawing.Point(11, 183)
        Me.btnViewTime.Name = "btnViewTime"
        Me.btnViewTime.Size = New System.Drawing.Size(140, 80)
        Me.btnViewTime.TabIndex = 2
        Me.btnViewTime.Text = "نمایش وقت ها"
        Me.btnViewTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnViewTime.UseVisualStyleBackColor = True
        '
        'btnRegVaghteGhabli
        '
        Me.btnRegVaghteGhabli.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRegVaghteGhabli.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRegVaghteGhabli.ImageList = Me.ImageList1
        Me.btnRegVaghteGhabli.Location = New System.Drawing.Point(11, 97)
        Me.btnRegVaghteGhabli.Name = "btnRegVaghteGhabli"
        Me.btnRegVaghteGhabli.Size = New System.Drawing.Size(140, 80)
        Me.btnRegVaghteGhabli.TabIndex = 1
        Me.btnRegVaghteGhabli.Text = "تعیین وقت قبلی"
        Me.btnRegVaghteGhabli.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRegVaghteGhabli.UseVisualStyleBackColor = True
        '
        'btnBimaran
        '
        Me.btnBimaran.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBimaran.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBimaran.ImageList = Me.ImageList1
        Me.btnBimaran.Location = New System.Drawing.Point(11, 11)
        Me.btnBimaran.Name = "btnBimaran"
        Me.btnBimaran.Size = New System.Drawing.Size(140, 80)
        Me.btnBimaran.TabIndex = 0
        Me.btnBimaran.Text = "بیماران"
        Me.btnBimaran.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBimaran.UseVisualStyleBackColor = True
        '
        'TabSooratHesab
        '
        Me.TabSooratHesab.AutoScroll = True
        Me.TabSooratHesab.BackgroundImage = Global.DentalClinic.My.Resources.Resources.WindowsXP040
        Me.TabSooratHesab.Controls.Add(Me.btnRptSooratHesabKoli)
        Me.TabSooratHesab.Controls.Add(Me.btnFaktorAlmosana)
        Me.TabSooratHesab.Controls.Add(Me.btnFaktorEditor)
        Me.TabSooratHesab.Controls.Add(Me.btnFaktorEdame)
        Me.TabSooratHesab.Location = New System.Drawing.Point(35, 4)
        Me.TabSooratHesab.Name = "TabSooratHesab"
        Me.TabSooratHesab.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSooratHesab.Size = New System.Drawing.Size(159, 720)
        Me.TabSooratHesab.TabIndex = 1
        Me.TabSooratHesab.Text = "صورتحساب ها"
        Me.TabSooratHesab.UseVisualStyleBackColor = True
        '
        'btnRptSooratHesabKoli
        '
        Me.btnRptSooratHesabKoli.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRptSooratHesabKoli.ImageList = Me.ImageList1
        Me.btnRptSooratHesabKoli.Location = New System.Drawing.Point(11, 269)
        Me.btnRptSooratHesabKoli.Name = "btnRptSooratHesabKoli"
        Me.btnRptSooratHesabKoli.Size = New System.Drawing.Size(140, 80)
        Me.btnRptSooratHesabKoli.TabIndex = 17
        Me.btnRptSooratHesabKoli.Text = "صدور صورتحساب کلی"
        Me.btnRptSooratHesabKoli.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRptSooratHesabKoli.UseVisualStyleBackColor = True
        '
        'btnFaktorAlmosana
        '
        Me.btnFaktorAlmosana.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFaktorAlmosana.ImageList = Me.ImageList1
        Me.btnFaktorAlmosana.Location = New System.Drawing.Point(11, 183)
        Me.btnFaktorAlmosana.Name = "btnFaktorAlmosana"
        Me.btnFaktorAlmosana.Size = New System.Drawing.Size(140, 80)
        Me.btnFaktorAlmosana.TabIndex = 3
        Me.btnFaktorAlmosana.Text = "صورتحساب المثنی"
        Me.btnFaktorAlmosana.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFaktorAlmosana.UseVisualStyleBackColor = True
        '
        'btnFaktorEditor
        '
        Me.btnFaktorEditor.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFaktorEditor.ImageList = Me.ImageList1
        Me.btnFaktorEditor.Location = New System.Drawing.Point(11, 97)
        Me.btnFaktorEditor.Name = "btnFaktorEditor"
        Me.btnFaktorEditor.Size = New System.Drawing.Size(140, 80)
        Me.btnFaktorEditor.TabIndex = 2
        Me.btnFaktorEditor.Text = "ویرایش صورتحساب"
        Me.btnFaktorEditor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFaktorEditor.UseVisualStyleBackColor = True
        '
        'btnFaktorEdame
        '
        Me.btnFaktorEdame.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFaktorEdame.ImageList = Me.ImageList1
        Me.btnFaktorEdame.Location = New System.Drawing.Point(11, 11)
        Me.btnFaktorEdame.Name = "btnFaktorEdame"
        Me.btnFaktorEdame.Size = New System.Drawing.Size(140, 80)
        Me.btnFaktorEdame.TabIndex = 1
        Me.btnFaktorEdame.Text = "ادامه صدور صورتحساب"
        Me.btnFaktorEdame.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFaktorEdame.UseVisualStyleBackColor = True
        '
        'TabMoaref
        '
        Me.TabMoaref.AutoScroll = True
        Me.TabMoaref.BackgroundImage = Global.DentalClinic.My.Resources.Resources.WindowsXP040
        Me.TabMoaref.Controls.Add(Me.btnRptMoaref)
        Me.TabMoaref.Controls.Add(Me.BtnRegMoaref)
        Me.TabMoaref.Location = New System.Drawing.Point(35, 4)
        Me.TabMoaref.Name = "TabMoaref"
        Me.TabMoaref.Size = New System.Drawing.Size(159, 720)
        Me.TabMoaref.TabIndex = 2
        Me.TabMoaref.Text = "معرف"
        Me.TabMoaref.UseVisualStyleBackColor = True
        '
        'btnRptMoaref
        '
        Me.btnRptMoaref.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRptMoaref.ImageList = Me.ImageList1
        Me.btnRptMoaref.Location = New System.Drawing.Point(11, 97)
        Me.btnRptMoaref.Name = "btnRptMoaref"
        Me.btnRptMoaref.Size = New System.Drawing.Size(140, 80)
        Me.btnRptMoaref.TabIndex = 6
        Me.btnRptMoaref.Text = "گزارش مراجعه معرف ها"
        Me.btnRptMoaref.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRptMoaref.UseVisualStyleBackColor = True
        '
        'BtnRegMoaref
        '
        Me.BtnRegMoaref.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnRegMoaref.ImageList = Me.ImageList1
        Me.BtnRegMoaref.Location = New System.Drawing.Point(11, 11)
        Me.BtnRegMoaref.Name = "BtnRegMoaref"
        Me.BtnRegMoaref.Size = New System.Drawing.Size(140, 80)
        Me.BtnRegMoaref.TabIndex = 5
        Me.BtnRegMoaref.Text = "ثبت معرف"
        Me.BtnRegMoaref.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnRegMoaref.UseVisualStyleBackColor = True
        '
        'TabPezeshk
        '
        Me.TabPezeshk.BackgroundImage = Global.DentalClinic.My.Resources.Resources.WindowsXP040
        Me.TabPezeshk.Controls.Add(Me.btnKosoorat)
        Me.TabPezeshk.Controls.Add(Me.btnRegDentist)
        Me.TabPezeshk.Location = New System.Drawing.Point(35, 4)
        Me.TabPezeshk.Name = "TabPezeshk"
        Me.TabPezeshk.Size = New System.Drawing.Size(159, 720)
        Me.TabPezeshk.TabIndex = 3
        Me.TabPezeshk.Text = "دندانپزشک"
        Me.TabPezeshk.UseVisualStyleBackColor = True
        '
        'btnKosoorat
        '
        Me.btnKosoorat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKosoorat.ImageList = Me.ImageList1
        Me.btnKosoorat.Location = New System.Drawing.Point(11, 97)
        Me.btnKosoorat.Name = "btnKosoorat"
        Me.btnKosoorat.Size = New System.Drawing.Size(140, 80)
        Me.btnKosoorat.TabIndex = 8
        Me.btnKosoorat.Text = "ثبت کسورات پزشکان"
        Me.btnKosoorat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKosoorat.UseVisualStyleBackColor = True
        '
        'btnRegDentist
        '
        Me.btnRegDentist.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRegDentist.ImageList = Me.ImageList1
        Me.btnRegDentist.Location = New System.Drawing.Point(11, 11)
        Me.btnRegDentist.Name = "btnRegDentist"
        Me.btnRegDentist.Size = New System.Drawing.Size(140, 80)
        Me.btnRegDentist.TabIndex = 7
        Me.btnRegDentist.Text = "ثبت دندانپزشک"
        Me.btnRegDentist.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRegDentist.UseVisualStyleBackColor = True
        '
        'TabTarefe
        '
        Me.TabTarefe.BackgroundImage = Global.DentalClinic.My.Resources.Resources.WindowsXP040
        Me.TabTarefe.Controls.Add(Me.btnRptTarefe)
        Me.TabTarefe.Controls.Add(Me.btnViewTarefe)
        Me.TabTarefe.Controls.Add(Me.btnRegTarefe)
        Me.TabTarefe.Controls.Add(Me.btnRegNoeKHadamat)
        Me.TabTarefe.Controls.Add(Me.btnRegNoeTarafe)
        Me.TabTarefe.Location = New System.Drawing.Point(35, 4)
        Me.TabTarefe.Name = "TabTarefe"
        Me.TabTarefe.Size = New System.Drawing.Size(159, 720)
        Me.TabTarefe.TabIndex = 4
        Me.TabTarefe.Text = "تعرفه"
        Me.TabTarefe.UseVisualStyleBackColor = True
        '
        'btnRptTarefe
        '
        Me.btnRptTarefe.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRptTarefe.ImageList = Me.ImageList1
        Me.btnRptTarefe.Location = New System.Drawing.Point(11, 355)
        Me.btnRptTarefe.Name = "btnRptTarefe"
        Me.btnRptTarefe.Size = New System.Drawing.Size(140, 80)
        Me.btnRptTarefe.TabIndex = 14
        Me.btnRptTarefe.Text = "گزارش تعرفه ها"
        Me.btnRptTarefe.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRptTarefe.UseVisualStyleBackColor = True
        '
        'btnViewTarefe
        '
        Me.btnViewTarefe.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnViewTarefe.ImageList = Me.ImageList1
        Me.btnViewTarefe.Location = New System.Drawing.Point(11, 269)
        Me.btnViewTarefe.Name = "btnViewTarefe"
        Me.btnViewTarefe.Size = New System.Drawing.Size(140, 80)
        Me.btnViewTarefe.TabIndex = 11
        Me.btnViewTarefe.Text = "ویرایش تعرفه"
        Me.btnViewTarefe.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnViewTarefe.UseVisualStyleBackColor = True
        '
        'btnRegTarefe
        '
        Me.btnRegTarefe.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRegTarefe.ImageList = Me.ImageList1
        Me.btnRegTarefe.Location = New System.Drawing.Point(11, 183)
        Me.btnRegTarefe.Name = "btnRegTarefe"
        Me.btnRegTarefe.Size = New System.Drawing.Size(140, 80)
        Me.btnRegTarefe.TabIndex = 10
        Me.btnRegTarefe.Text = "ثبت تعرفه"
        Me.btnRegTarefe.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRegTarefe.UseVisualStyleBackColor = True
        '
        'btnRegNoeKHadamat
        '
        Me.btnRegNoeKHadamat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRegNoeKHadamat.ImageList = Me.ImageList1
        Me.btnRegNoeKHadamat.Location = New System.Drawing.Point(11, 97)
        Me.btnRegNoeKHadamat.Name = "btnRegNoeKHadamat"
        Me.btnRegNoeKHadamat.Size = New System.Drawing.Size(140, 80)
        Me.btnRegNoeKHadamat.TabIndex = 9
        Me.btnRegNoeKHadamat.Text = "ثبت نوع خدمات"
        Me.btnRegNoeKHadamat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRegNoeKHadamat.UseVisualStyleBackColor = True
        '
        'btnRegNoeTarafe
        '
        Me.btnRegNoeTarafe.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRegNoeTarafe.ImageList = Me.ImageList1
        Me.btnRegNoeTarafe.Location = New System.Drawing.Point(11, 11)
        Me.btnRegNoeTarafe.Name = "btnRegNoeTarafe"
        Me.btnRegNoeTarafe.Size = New System.Drawing.Size(140, 80)
        Me.btnRegNoeTarafe.TabIndex = 8
        Me.btnRegNoeTarafe.Text = "ثبت نوع تعرفه"
        Me.btnRegNoeTarafe.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRegNoeTarafe.UseVisualStyleBackColor = True
        '
        'TabReport
        '
        Me.TabReport.BackgroundImage = Global.DentalClinic.My.Resources.Resources.WindowsXP040
        Me.TabReport.Controls.Add(Me.btnRptBedehkaran)
        Me.TabReport.Controls.Add(Me.btnAmalkardRoozane)
        Me.TabReport.Controls.Add(Me.btnRptRizAmalkard)
        Me.TabReport.Controls.Add(Me.btnRptAmalkardKol)
        Me.TabReport.Location = New System.Drawing.Point(35, 4)
        Me.TabReport.Name = "TabReport"
        Me.TabReport.Size = New System.Drawing.Size(159, 720)
        Me.TabReport.TabIndex = 5
        Me.TabReport.Text = "گزارشات"
        Me.TabReport.UseVisualStyleBackColor = True
        '
        'btnRptBedehkaran
        '
        Me.btnRptBedehkaran.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRptBedehkaran.ImageList = Me.ImageList1
        Me.btnRptBedehkaran.Location = New System.Drawing.Point(11, 269)
        Me.btnRptBedehkaran.Name = "btnRptBedehkaran"
        Me.btnRptBedehkaran.Size = New System.Drawing.Size(140, 80)
        Me.btnRptBedehkaran.TabIndex = 16
        Me.btnRptBedehkaran.Text = "گزارش بدهکاران"
        Me.btnRptBedehkaran.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRptBedehkaran.UseVisualStyleBackColor = True
        '
        'btnAmalkardRoozane
        '
        Me.btnAmalkardRoozane.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAmalkardRoozane.ImageList = Me.ImageList1
        Me.btnAmalkardRoozane.Location = New System.Drawing.Point(11, 183)
        Me.btnAmalkardRoozane.Name = "btnAmalkardRoozane"
        Me.btnAmalkardRoozane.Size = New System.Drawing.Size(140, 80)
        Me.btnAmalkardRoozane.TabIndex = 15
        Me.btnAmalkardRoozane.Text = "گزارش عملکرد روزانه"
        Me.btnAmalkardRoozane.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAmalkardRoozane.UseVisualStyleBackColor = True
        '
        'btnRptRizAmalkard
        '
        Me.btnRptRizAmalkard.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRptRizAmalkard.ImageList = Me.ImageList1
        Me.btnRptRizAmalkard.Location = New System.Drawing.Point(11, 97)
        Me.btnRptRizAmalkard.Name = "btnRptRizAmalkard"
        Me.btnRptRizAmalkard.Size = New System.Drawing.Size(140, 80)
        Me.btnRptRizAmalkard.TabIndex = 14
        Me.btnRptRizAmalkard.Text = "گزارش ریز عملکرد روزانه"
        Me.btnRptRizAmalkard.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRptRizAmalkard.UseVisualStyleBackColor = True
        '
        'btnRptAmalkardKol
        '
        Me.btnRptAmalkardKol.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRptAmalkardKol.ImageList = Me.ImageList1
        Me.btnRptAmalkardKol.Location = New System.Drawing.Point(11, 11)
        Me.btnRptAmalkardKol.Name = "btnRptAmalkardKol"
        Me.btnRptAmalkardKol.Size = New System.Drawing.Size(140, 80)
        Me.btnRptAmalkardKol.TabIndex = 13
        Me.btnRptAmalkardKol.Text = "گزارش عملکرد کل"
        Me.btnRptAmalkardKol.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRptAmalkardKol.UseVisualStyleBackColor = True
        '
        'TabManaging
        '
        Me.TabManaging.BackgroundImage = Global.DentalClinic.My.Resources.Resources.WindowsXP040
        Me.TabManaging.Controls.Add(Me.btnRegUser)
        Me.TabManaging.Location = New System.Drawing.Point(35, 4)
        Me.TabManaging.Name = "TabManaging"
        Me.TabManaging.Size = New System.Drawing.Size(159, 720)
        Me.TabManaging.TabIndex = 6
        Me.TabManaging.Text = "مدیریت"
        Me.TabManaging.UseVisualStyleBackColor = True
        '
        'btnRegUser
        '
        Me.btnRegUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRegUser.ImageList = Me.ImageList1
        Me.btnRegUser.Location = New System.Drawing.Point(11, 11)
        Me.btnRegUser.Name = "btnRegUser"
        Me.btnRegUser.Size = New System.Drawing.Size(140, 80)
        Me.btnRegUser.TabIndex = 2
        Me.btnRegUser.Text = "ثبت کاربران"
        Me.btnRegUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRegUser.UseVisualStyleBackColor = True
        '
        'frmParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DentalClinic.My.Resources.Resources.christmas_windows_logo
        Me.ClientSize = New System.Drawing.Size(715, 742)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmParent"
        Me.RightToLeftLayout = True
        Me.Text = "frmParent"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabBimaran.ResumeLayout(False)
        Me.TabSooratHesab.ResumeLayout(False)
        Me.TabMoaref.ResumeLayout(False)
        Me.TabPezeshk.ResumeLayout(False)
        Me.TabTarefe.ResumeLayout(False)
        Me.TabReport.ResumeLayout(False)
        Me.TabManaging.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblUserName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtUserName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabBimaran As System.Windows.Forms.TabPage
    Friend WithEvents btnBimaran As System.Windows.Forms.Button
    Friend WithEvents TabSooratHesab As System.Windows.Forms.TabPage
    Friend WithEvents btnRptSooratHesabKoli As System.Windows.Forms.Button
    Friend WithEvents btnFaktorAlmosana As System.Windows.Forms.Button
    Friend WithEvents btnFaktorEditor As System.Windows.Forms.Button
    Friend WithEvents btnFaktorEdame As System.Windows.Forms.Button
    Friend WithEvents TabMoaref As System.Windows.Forms.TabPage
    Friend WithEvents btnRptMoaref As System.Windows.Forms.Button
    Friend WithEvents BtnRegMoaref As System.Windows.Forms.Button
    Friend WithEvents TabPezeshk As System.Windows.Forms.TabPage
    Friend WithEvents btnKosoorat As System.Windows.Forms.Button
    Friend WithEvents btnRegDentist As System.Windows.Forms.Button
    Friend WithEvents TabTarefe As System.Windows.Forms.TabPage
    Friend WithEvents btnRptTarefe As System.Windows.Forms.Button
    Friend WithEvents btnViewTarefe As System.Windows.Forms.Button
    Friend WithEvents btnRegTarefe As System.Windows.Forms.Button
    Friend WithEvents btnRegNoeKHadamat As System.Windows.Forms.Button
    Friend WithEvents btnRegNoeTarafe As System.Windows.Forms.Button
    Friend WithEvents TabReport As System.Windows.Forms.TabPage
    Friend WithEvents btnRptBedehkaran As System.Windows.Forms.Button
    Friend WithEvents btnAmalkardRoozane As System.Windows.Forms.Button
    Friend WithEvents btnRptRizAmalkard As System.Windows.Forms.Button
    Friend WithEvents btnRptAmalkardKol As System.Windows.Forms.Button
    Friend WithEvents TabManaging As System.Windows.Forms.TabPage
    Friend WithEvents btnRegUser As System.Windows.Forms.Button
    Friend WithEvents btnViewTime As System.Windows.Forms.Button
    Friend WithEvents btnRegVaghteGhabli As System.Windows.Forms.Button
End Class
