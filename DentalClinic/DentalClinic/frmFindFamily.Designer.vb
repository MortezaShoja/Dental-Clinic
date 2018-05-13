<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindFamily
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
        Me.components = New System.ComponentModel.Container
        Dim Label1 As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim LNameLabel As System.Windows.Forms.Label
        Dim FotherNameLabel As System.Windows.Forms.Label
        Dim ParvandeNOLabel As System.Windows.Forms.Label
        Dim HomePhoneLabel As System.Windows.Forms.Label
        Dim WorkPhoneLabel As System.Windows.Forms.Label
        Dim MobileLabel As System.Windows.Forms.Label
        Dim MoarefLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFindFamily))
        Me.btnSearch = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.txtSLname = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.lblFamiliCode = New System.Windows.Forms.ToolStripLabel
        Me.txtFamiliBedehi = New System.Windows.Forms.ToolStripLabel
        Me.lblBedehi = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.sp = New System.Windows.Forms.ToolStripSeparator
        Me.txtSfamiliCode = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.dgrPersonalInfo = New System.Windows.Forms.DataGridView
        Me.PersonalInfoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnOK = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel
        Me.txtSParvandeNo = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel
        Me.txtSPhone = New System.Windows.Forms.ToolStripTextBox
        Me.SearchToolTip = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtLName = New System.Windows.Forms.TextBox
        Me.txtFotherName = New System.Windows.Forms.TextBox
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtParvandeNo = New System.Windows.Forms.TextBox
        Me.txtHomePhone = New System.Windows.Forms.TextBox
        Me.txtWorkPhone = New System.Windows.Forms.TextBox
        Me.txtMobile = New System.Windows.Forms.TextBox
        Me.txtNesbat = New System.Windows.Forms.TextBox
        Me.txtMoaref = New System.Windows.Forms.TextBox
        Label1 = New System.Windows.Forms.Label
        IDLabel = New System.Windows.Forms.Label
        NameLabel = New System.Windows.Forms.Label
        LNameLabel = New System.Windows.Forms.Label
        FotherNameLabel = New System.Windows.Forms.Label
        ParvandeNOLabel = New System.Windows.Forms.Label
        HomePhoneLabel = New System.Windows.Forms.Label
        WorkPhoneLabel = New System.Windows.Forms.Label
        MobileLabel = New System.Windows.Forms.Label
        MoarefLabel = New System.Windows.Forms.Label
        CType(Me.dgrPersonalInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonalInfoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PersonalInfoBindingNavigator.SuspendLayout()
        Me.SearchToolTip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label1.Location = New System.Drawing.Point(393, 145)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(90, 23)
        Label1.TabIndex = 71
        Label1.Text = "نسبت خانوادگی :"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        IDLabel.Location = New System.Drawing.Point(17, 37)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(73, 23)
        IDLabel.TabIndex = 67
        IDLabel.Text = "کد شناسائی :"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        NameLabel.Location = New System.Drawing.Point(59, 68)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(31, 23)
        NameLabel.TabIndex = 50
        NameLabel.Text = "نام :"
        '
        'LNameLabel
        '
        LNameLabel.AutoSize = True
        LNameLabel.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        LNameLabel.Location = New System.Drawing.Point(11, 104)
        LNameLabel.Name = "LNameLabel"
        LNameLabel.Size = New System.Drawing.Size(79, 23)
        LNameLabel.TabIndex = 52
        LNameLabel.Text = "نام خانوادگی :"
        '
        'FotherNameLabel
        '
        FotherNameLabel.AutoSize = True
        FotherNameLabel.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        FotherNameLabel.Location = New System.Drawing.Point(39, 140)
        FotherNameLabel.Name = "FotherNameLabel"
        FotherNameLabel.Size = New System.Drawing.Size(51, 23)
        FotherNameLabel.TabIndex = 54
        FotherNameLabel.Text = "نام پدر :"
        '
        'ParvandeNOLabel
        '
        ParvandeNOLabel.AutoSize = True
        ParvandeNOLabel.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        ParvandeNOLabel.Location = New System.Drawing.Point(9, 176)
        ParvandeNOLabel.Name = "ParvandeNOLabel"
        ParvandeNOLabel.Size = New System.Drawing.Size(81, 23)
        ParvandeNOLabel.TabIndex = 56
        ParvandeNOLabel.Text = "شماره پرونده :"
        '
        'HomePhoneLabel
        '
        HomePhoneLabel.AutoSize = True
        HomePhoneLabel.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        HomePhoneLabel.Location = New System.Drawing.Point(420, 37)
        HomePhoneLabel.Name = "HomePhoneLabel"
        HomePhoneLabel.Size = New System.Drawing.Size(63, 23)
        HomePhoneLabel.TabIndex = 58
        HomePhoneLabel.Text = "تلفن منزل :"
        '
        'WorkPhoneLabel
        '
        WorkPhoneLabel.AutoSize = True
        WorkPhoneLabel.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        WorkPhoneLabel.Location = New System.Drawing.Point(402, 73)
        WorkPhoneLabel.Name = "WorkPhoneLabel"
        WorkPhoneLabel.Size = New System.Drawing.Size(81, 23)
        WorkPhoneLabel.TabIndex = 60
        WorkPhoneLabel.Text = "تلفن محل کار :"
        '
        'MobileLabel
        '
        MobileLabel.AutoSize = True
        MobileLabel.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        MobileLabel.Location = New System.Drawing.Point(416, 109)
        MobileLabel.Name = "MobileLabel"
        MobileLabel.Size = New System.Drawing.Size(67, 23)
        MobileLabel.TabIndex = 62
        MobileLabel.Text = "تلفن همراه :"
        '
        'MoarefLabel
        '
        MoarefLabel.AutoSize = True
        MoarefLabel.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        MoarefLabel.Location = New System.Drawing.Point(440, 183)
        MoarefLabel.Name = "MoarefLabel"
        MoarefLabel.Size = New System.Drawing.Size(43, 23)
        MoarefLabel.TabIndex = 64
        MoarefLabel.Text = "معرف :"
        '
        'btnSearch
        '
        Me.btnSearch.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(23, 22)
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'txtSLname
        '
        Me.txtSLname.Name = "txtSLname"
        Me.txtSLname.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(72, 22)
        Me.ToolStripLabel3.Text = "نام خانوادگی :"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'lblFamiliCode
        '
        Me.lblFamiliCode.ForeColor = System.Drawing.Color.Red
        Me.lblFamiliCode.Name = "lblFamiliCode"
        Me.lblFamiliCode.Size = New System.Drawing.Size(13, 22)
        Me.lblFamiliCode.Text = "0"
        '
        'txtFamiliBedehi
        '
        Me.txtFamiliBedehi.ForeColor = System.Drawing.Color.Red
        Me.txtFamiliBedehi.Name = "txtFamiliBedehi"
        Me.txtFamiliBedehi.Size = New System.Drawing.Size(13, 22)
        Me.txtFamiliBedehi.Text = "0"
        '
        'lblBedehi
        '
        Me.lblBedehi.Name = "lblBedehi"
        Me.lblBedehi.Size = New System.Drawing.Size(87, 22)
        Me.lblBedehi.Text = "بدهی کل فامیل :"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripLabel2.Text = "کد خانوادگی"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'sp
        '
        Me.sp.Name = "sp"
        Me.sp.Size = New System.Drawing.Size(6, 25)
        '
        'txtSfamiliCode
        '
        Me.txtSfamiliCode.Name = "txtSfamiliCode"
        Me.txtSfamiliCode.Size = New System.Drawing.Size(100, 25)
        Me.txtSfamiliCode.Text = "0"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripLabel1.Text = "کد خانوادگی"
        '
        'dgrPersonalInfo
        '
        Me.dgrPersonalInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrPersonalInfo.Location = New System.Drawing.Point(11, 216)
        Me.dgrPersonalInfo.Name = "dgrPersonalInfo"
        Me.dgrPersonalInfo.Size = New System.Drawing.Size(747, 118)
        Me.dgrPersonalInfo.TabIndex = 69
        '
        'PersonalInfoBindingNavigator
        '
        Me.PersonalInfoBindingNavigator.AddNewItem = Nothing
        Me.PersonalInfoBindingNavigator.CountItem = Nothing
        Me.PersonalInfoBindingNavigator.CountItemFormat = "از {0}"
        Me.PersonalInfoBindingNavigator.DeleteItem = Nothing
        Me.PersonalInfoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.lblFamiliCode, Me.ToolStripSeparator7, Me.ToolStripSeparator8, Me.lblBedehi, Me.txtFamiliBedehi, Me.ToolStripSeparator2, Me.sp, Me.btnOK})
        Me.PersonalInfoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PersonalInfoBindingNavigator.MoveFirstItem = Nothing
        Me.PersonalInfoBindingNavigator.MoveLastItem = Nothing
        Me.PersonalInfoBindingNavigator.MoveNextItem = Nothing
        Me.PersonalInfoBindingNavigator.MovePreviousItem = Nothing
        Me.PersonalInfoBindingNavigator.Name = "PersonalInfoBindingNavigator"
        Me.PersonalInfoBindingNavigator.PositionItem = Nothing
        Me.PersonalInfoBindingNavigator.Size = New System.Drawing.Size(771, 25)
        Me.PersonalInfoBindingNavigator.TabIndex = 49
        Me.PersonalInfoBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnOK
        '
        Me.btnOK.ForeColor = System.Drawing.Color.Blue
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(58, 22)
        Me.btnOK.Text = "تائید..."
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel5.Text = "تلفن :"
        '
        'txtSParvandeNo
        '
        Me.txtSParvandeNo.Name = "txtSParvandeNo"
        Me.txtSParvandeNo.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(74, 22)
        Me.ToolStripLabel4.Text = "شماره پرونده :"
        '
        'txtSPhone
        '
        Me.txtSPhone.Name = "txtSPhone"
        Me.txtSPhone.Size = New System.Drawing.Size(100, 25)
        '
        'SearchToolTip
        '
        Me.SearchToolTip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SearchToolTip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSearch, Me.ToolStripSeparator5, Me.ToolStripLabel3, Me.txtSLname, Me.ToolStripLabel4, Me.txtSParvandeNo, Me.ToolStripLabel5, Me.txtSPhone, Me.ToolStripSeparator6, Me.ToolStripLabel1, Me.txtSfamiliCode, Me.btnRefresh})
        Me.SearchToolTip.Location = New System.Drawing.Point(0, 343)
        Me.SearchToolTip.Name = "SearchToolTip"
        Me.SearchToolTip.Size = New System.Drawing.Size(771, 25)
        Me.SearchToolTip.TabIndex = 48
        Me.SearchToolTip.Text = "ToolStrip1"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(66, 22)
        Me.btnRefresh.Text = "کل موارد"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtName.Location = New System.Drawing.Point(96, 70)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(269, 30)
        Me.txtName.TabIndex = 51
        '
        'txtLName
        '
        Me.txtLName.BackColor = System.Drawing.Color.White
        Me.txtLName.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtLName.Location = New System.Drawing.Point(96, 106)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.ReadOnly = True
        Me.txtLName.Size = New System.Drawing.Size(269, 30)
        Me.txtLName.TabIndex = 53
        '
        'txtFotherName
        '
        Me.txtFotherName.BackColor = System.Drawing.Color.White
        Me.txtFotherName.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtFotherName.Location = New System.Drawing.Point(96, 142)
        Me.txtFotherName.Name = "txtFotherName"
        Me.txtFotherName.ReadOnly = True
        Me.txtFotherName.Size = New System.Drawing.Size(269, 30)
        Me.txtFotherName.TabIndex = 55
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.Gainsboro
        Me.txtID.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.Black
        Me.txtID.Location = New System.Drawing.Point(96, 34)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(269, 30)
        Me.txtID.TabIndex = 68
        '
        'txtParvandeNo
        '
        Me.txtParvandeNo.BackColor = System.Drawing.Color.White
        Me.txtParvandeNo.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtParvandeNo.Location = New System.Drawing.Point(96, 178)
        Me.txtParvandeNo.Name = "txtParvandeNo"
        Me.txtParvandeNo.ReadOnly = True
        Me.txtParvandeNo.Size = New System.Drawing.Size(269, 30)
        Me.txtParvandeNo.TabIndex = 57
        '
        'txtHomePhone
        '
        Me.txtHomePhone.BackColor = System.Drawing.Color.White
        Me.txtHomePhone.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtHomePhone.Location = New System.Drawing.Point(489, 34)
        Me.txtHomePhone.Name = "txtHomePhone"
        Me.txtHomePhone.ReadOnly = True
        Me.txtHomePhone.Size = New System.Drawing.Size(269, 30)
        Me.txtHomePhone.TabIndex = 59
        '
        'txtWorkPhone
        '
        Me.txtWorkPhone.BackColor = System.Drawing.Color.White
        Me.txtWorkPhone.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtWorkPhone.Location = New System.Drawing.Point(489, 70)
        Me.txtWorkPhone.Name = "txtWorkPhone"
        Me.txtWorkPhone.ReadOnly = True
        Me.txtWorkPhone.Size = New System.Drawing.Size(269, 30)
        Me.txtWorkPhone.TabIndex = 61
        '
        'txtMobile
        '
        Me.txtMobile.BackColor = System.Drawing.Color.White
        Me.txtMobile.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtMobile.Location = New System.Drawing.Point(489, 106)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.ReadOnly = True
        Me.txtMobile.Size = New System.Drawing.Size(269, 30)
        Me.txtMobile.TabIndex = 63
        '
        'txtNesbat
        '
        Me.txtNesbat.BackColor = System.Drawing.Color.White
        Me.txtNesbat.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtNesbat.Location = New System.Drawing.Point(489, 142)
        Me.txtNesbat.Name = "txtNesbat"
        Me.txtNesbat.ReadOnly = True
        Me.txtNesbat.Size = New System.Drawing.Size(269, 30)
        Me.txtNesbat.TabIndex = 72
        '
        'txtMoaref
        '
        Me.txtMoaref.BackColor = System.Drawing.Color.White
        Me.txtMoaref.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtMoaref.Location = New System.Drawing.Point(489, 180)
        Me.txtMoaref.Name = "txtMoaref"
        Me.txtMoaref.ReadOnly = True
        Me.txtMoaref.Size = New System.Drawing.Size(269, 30)
        Me.txtMoaref.TabIndex = 73
        '
        'frmFindFamily
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 368)
        Me.Controls.Add(Me.txtMoaref)
        Me.Controls.Add(Me.txtNesbat)
        Me.Controls.Add(Me.dgrPersonalInfo)
        Me.Controls.Add(Me.PersonalInfoBindingNavigator)
        Me.Controls.Add(Me.SearchToolTip)
        Me.Controls.Add(Label1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(LNameLabel)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(FotherNameLabel)
        Me.Controls.Add(ParvandeNOLabel)
        Me.Controls.Add(HomePhoneLabel)
        Me.Controls.Add(WorkPhoneLabel)
        Me.Controls.Add(MobileLabel)
        Me.Controls.Add(MoarefLabel)
        Me.Controls.Add(Me.txtFotherName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtParvandeNo)
        Me.Controls.Add(Me.txtHomePhone)
        Me.Controls.Add(Me.txtWorkPhone)
        Me.Controls.Add(Me.txtMobile)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFindFamily"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "جستجوی خانواده :::..."
        CType(Me.dgrPersonalInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonalInfoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PersonalInfoBindingNavigator.ResumeLayout(False)
        Me.PersonalInfoBindingNavigator.PerformLayout()
        Me.SearchToolTip.ResumeLayout(False)
        Me.SearchToolTip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtSLname As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblFamiliCode As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtFamiliBedehi As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblBedehi As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents sp As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtSfamiliCode As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents dgrPersonalInfo As System.Windows.Forms.DataGridView
    Friend WithEvents PersonalInfoBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtSParvandeNo As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtSPhone As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SearchToolTip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtFotherName As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtParvandeNo As System.Windows.Forms.TextBox
    Friend WithEvents txtHomePhone As System.Windows.Forms.TextBox
    Friend WithEvents txtWorkPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents txtNesbat As System.Windows.Forms.TextBox
    Friend WithEvents txtMoaref As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnOK As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
