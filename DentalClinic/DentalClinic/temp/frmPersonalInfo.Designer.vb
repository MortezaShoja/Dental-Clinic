<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonalInfo
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
        Dim کد_شناسائیLabel As System.Windows.Forms.Label
        Dim نام__Label As System.Windows.Forms.Label
        Dim نام_خانوادگی__Label As System.Windows.Forms.Label
        Dim شماره_پرونده__Label As System.Windows.Forms.Label
        Dim تلفن_منزل_Label As System.Windows.Forms.Label
        Dim تلفن_محل_کار_Label As System.Windows.Forms.Label
        Dim موبال_Label As System.Windows.Forms.Label
        Dim نام_پدرLabel As System.Windows.Forms.Label
        Dim کد_خانوادگیLabel As System.Windows.Forms.Label
        Dim نسبتLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPersonalInfo))
        Me.PersonalInfoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.PersonalInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicDataSet = New DentalClinic.ClinicDataSet
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnNew = New System.Windows.Forms.ToolStripButton
        Me.btnSave = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnUpdate = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.btnReqFamilyCode = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.lblReg = New System.Windows.Forms.ToolStripLabel
        Me.btnGoFaktor = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.txtBedehi = New System.Windows.Forms.ToolStripLabel
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtLName = New System.Windows.Forms.TextBox
        Me.txtParvandeNo = New System.Windows.Forms.TextBox
        Me.txtHomePhone = New System.Windows.Forms.TextBox
        Me.txtWorkPhone = New System.Windows.Forms.TextBox
        Me.txtMobile = New System.Windows.Forms.TextBox
        Me.PersonalInfoTableAdapter = New DentalClinic.ClinicDataSetTableAdapters.PersonalInfoTableAdapter
        Me.txtFotheName = New System.Windows.Forms.TextBox
        Me.txtFamilyCode = New System.Windows.Forms.TextBox
        Me.cboNesbat = New System.Windows.Forms.ComboBox
        Me.NesbatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NesbatTableAdapter = New DentalClinic.ClinicDataSetTableAdapters.NesbatTableAdapter
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.txtSLname = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel
        Me.txtSParvandeNo = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel
        Me.txtSPhone = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.btnSearch = New System.Windows.Forms.ToolStripButton
        کد_شناسائیLabel = New System.Windows.Forms.Label
        نام__Label = New System.Windows.Forms.Label
        نام_خانوادگی__Label = New System.Windows.Forms.Label
        شماره_پرونده__Label = New System.Windows.Forms.Label
        تلفن_منزل_Label = New System.Windows.Forms.Label
        تلفن_محل_کار_Label = New System.Windows.Forms.Label
        موبال_Label = New System.Windows.Forms.Label
        نام_پدرLabel = New System.Windows.Forms.Label
        کد_خانوادگیLabel = New System.Windows.Forms.Label
        نسبتLabel = New System.Windows.Forms.Label
        CType(Me.PersonalInfoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PersonalInfoBindingNavigator.SuspendLayout()
        CType(Me.PersonalInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NesbatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'کد_شناسائیLabel
        '
        کد_شناسائیLabel.AutoSize = True
        کد_شناسائیLabel.Location = New System.Drawing.Point(23, 48)
        کد_شناسائیLabel.Name = "کد_شناسائیLabel"
        کد_شناسائیLabel.Size = New System.Drawing.Size(70, 23)
        کد_شناسائیLabel.TabIndex = 1
        کد_شناسائیLabel.Text = "کد شناسائی:"
        '
        'نام__Label
        '
        نام__Label.AutoSize = True
        نام__Label.Location = New System.Drawing.Point(62, 84)
        نام__Label.Name = "نام__Label"
        نام__Label.Size = New System.Drawing.Size(31, 23)
        نام__Label.TabIndex = 3
        نام__Label.Text = "نام :"
        '
        'نام_خانوادگی__Label
        '
        نام_خانوادگی__Label.AutoSize = True
        نام_خانوادگی__Label.Location = New System.Drawing.Point(14, 120)
        نام_خانوادگی__Label.Name = "نام_خانوادگی__Label"
        نام_خانوادگی__Label.Size = New System.Drawing.Size(79, 23)
        نام_خانوادگی__Label.TabIndex = 5
        نام_خانوادگی__Label.Text = "نام خانوادگی :"
        '
        'شماره_پرونده__Label
        '
        شماره_پرونده__Label.AutoSize = True
        شماره_پرونده__Label.Location = New System.Drawing.Point(12, 192)
        شماره_پرونده__Label.Name = "شماره_پرونده__Label"
        شماره_پرونده__Label.Size = New System.Drawing.Size(81, 23)
        شماره_پرونده__Label.TabIndex = 7
        شماره_پرونده__Label.Text = "شماره پرونده :"
        '
        'تلفن_منزل_Label
        '
        تلفن_منزل_Label.AutoSize = True
        تلفن_منزل_Label.Location = New System.Drawing.Point(335, 48)
        تلفن_منزل_Label.Name = "تلفن_منزل_Label"
        تلفن_منزل_Label.Size = New System.Drawing.Size(60, 23)
        تلفن_منزل_Label.TabIndex = 11
        تلفن_منزل_Label.Text = "تلفن منزل:"
        '
        'تلفن_محل_کار_Label
        '
        تلفن_محل_کار_Label.AutoSize = True
        تلفن_محل_کار_Label.Location = New System.Drawing.Point(317, 84)
        تلفن_محل_کار_Label.Name = "تلفن_محل_کار_Label"
        تلفن_محل_کار_Label.Size = New System.Drawing.Size(78, 23)
        تلفن_محل_کار_Label.TabIndex = 13
        تلفن_محل_کار_Label.Text = "تلفن محل کار:"
        '
        'موبال_Label
        '
        موبال_Label.AutoSize = True
        موبال_Label.Location = New System.Drawing.Point(351, 120)
        موبال_Label.Name = "موبال_Label"
        موبال_Label.Size = New System.Drawing.Size(44, 23)
        موبال_Label.TabIndex = 15
        موبال_Label.Text = "موبایل:"
        '
        'نام_پدرLabel
        '
        نام_پدرLabel.AutoSize = True
        نام_پدرLabel.Location = New System.Drawing.Point(45, 156)
        نام_پدرLabel.Name = "نام_پدرLabel"
        نام_پدرLabel.Size = New System.Drawing.Size(48, 23)
        نام_پدرLabel.TabIndex = 19
        نام_پدرLabel.Text = "نام پدر:"
        '
        'کد_خانوادگیLabel
        '
        کد_خانوادگیLabel.AutoSize = True
        کد_خانوادگیLabel.Location = New System.Drawing.Point(319, 192)
        کد_خانوادگیLabel.Name = "کد_خانوادگیLabel"
        کد_خانوادگیLabel.Size = New System.Drawing.Size(76, 23)
        کد_خانوادگیLabel.TabIndex = 19
        کد_خانوادگیLabel.Text = "کد خانوادگی:"
        '
        'نسبتLabel
        '
        نسبتLabel.AutoSize = True
        نسبتLabel.Location = New System.Drawing.Point(356, 155)
        نسبتLabel.Name = "نسبتLabel"
        نسبتLabel.Size = New System.Drawing.Size(39, 23)
        نسبتLabel.TabIndex = 20
        نسبتLabel.Text = "نسبت:"
        '
        'PersonalInfoBindingNavigator
        '
        Me.PersonalInfoBindingNavigator.AddNewItem = Nothing
        Me.PersonalInfoBindingNavigator.BindingSource = Me.PersonalInfoBindingSource
        Me.PersonalInfoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PersonalInfoBindingNavigator.CountItemFormat = "از {0}"
        Me.PersonalInfoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PersonalInfoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.btnNew, Me.btnSave, Me.ToolStripSeparator3, Me.BindingNavigatorDeleteItem, Me.btnUpdate, Me.ToolStripSeparator4, Me.btnReqFamilyCode, Me.ToolStripSeparator1, Me.lblReg, Me.btnGoFaktor, Me.ToolStripSeparator2, Me.ToolStripLabel1, Me.txtBedehi})
        Me.PersonalInfoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PersonalInfoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PersonalInfoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PersonalInfoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PersonalInfoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PersonalInfoBindingNavigator.Name = "PersonalInfoBindingNavigator"
        Me.PersonalInfoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PersonalInfoBindingNavigator.Size = New System.Drawing.Size(616, 27)
        Me.PersonalInfoBindingNavigator.TabIndex = 0
        Me.PersonalInfoBindingNavigator.Text = "BindingNavigator1"
        '
        'PersonalInfoBindingSource
        '
        Me.PersonalInfoBindingSource.DataMember = "PersonalInfo"
        Me.PersonalInfoBindingSource.DataSource = Me.ClinicDataSet
        '
        'ClinicDataSet
        '
        Me.ClinicDataSet.DataSetName = "ClinicDataSet"
        Me.ClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(33, 24)
        Me.BindingNavigatorCountItem.Text = "از {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorDeleteItem.Text = "حذف"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("B Titr", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'btnNew
        '
        Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(23, 24)
        Me.btnNew.Text = "جدید"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(23, 24)
        Me.btnSave.Text = "ثبت"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'btnUpdate
        '
        Me.btnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(23, 24)
        Me.btnUpdate.Text = "ثبت تغییرات"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'btnReqFamilyCode
        '
        Me.btnReqFamilyCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnReqFamilyCode.Image = CType(resources.GetObject("btnReqFamilyCode.Image"), System.Drawing.Image)
        Me.btnReqFamilyCode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReqFamilyCode.Name = "btnReqFamilyCode"
        Me.btnReqFamilyCode.Size = New System.Drawing.Size(23, 24)
        Me.btnReqFamilyCode.Text = "کد خانوادگی"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'lblReg
        '
        Me.lblReg.Name = "lblReg"
        Me.lblReg.Size = New System.Drawing.Size(86, 24)
        Me.lblReg.Text = "صدور صورتحساب"
        '
        'btnGoFaktor
        '
        Me.btnGoFaktor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGoFaktor.Image = CType(resources.GetObject("btnGoFaktor.Image"), System.Drawing.Image)
        Me.btnGoFaktor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGoFaktor.Name = "btnGoFaktor"
        Me.btnGoFaktor.Size = New System.Drawing.Size(23, 24)
        Me.btnGoFaktor.Text = "ToolStripButton1"
        Me.btnGoFaktor.ToolTipText = "صدور صورتحساب"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(76, 24)
        Me.ToolStripLabel1.Text = "بدهی پیشین :"
        '
        'txtBedehi
        '
        Me.txtBedehi.Name = "txtBedehi"
        Me.txtBedehi.Size = New System.Drawing.Size(13, 24)
        Me.txtBedehi.Text = "0"
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalInfoBindingSource, "ID", True))
        Me.txtID.Location = New System.Drawing.Point(99, 45)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(202, 30)
        Me.txtID.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalInfoBindingSource, "Name", True))
        Me.txtName.Location = New System.Drawing.Point(99, 81)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(202, 30)
        Me.txtName.TabIndex = 1
        '
        'txtLName
        '
        Me.txtLName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalInfoBindingSource, "LName", True))
        Me.txtLName.Location = New System.Drawing.Point(99, 117)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(202, 30)
        Me.txtLName.TabIndex = 2
        '
        'txtParvandeNo
        '
        Me.txtParvandeNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalInfoBindingSource, "ParvandeNO", True))
        Me.txtParvandeNo.Location = New System.Drawing.Point(99, 189)
        Me.txtParvandeNo.Name = "txtParvandeNo"
        Me.txtParvandeNo.Size = New System.Drawing.Size(202, 30)
        Me.txtParvandeNo.TabIndex = 4
        '
        'txtHomePhone
        '
        Me.txtHomePhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalInfoBindingSource, "HomePhone", True))
        Me.txtHomePhone.Location = New System.Drawing.Point(401, 45)
        Me.txtHomePhone.Name = "txtHomePhone"
        Me.txtHomePhone.Size = New System.Drawing.Size(202, 30)
        Me.txtHomePhone.TabIndex = 6
        '
        'txtWorkPhone
        '
        Me.txtWorkPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalInfoBindingSource, "WorkPhone", True))
        Me.txtWorkPhone.Location = New System.Drawing.Point(401, 81)
        Me.txtWorkPhone.Name = "txtWorkPhone"
        Me.txtWorkPhone.Size = New System.Drawing.Size(202, 30)
        Me.txtWorkPhone.TabIndex = 7
        '
        'txtMobile
        '
        Me.txtMobile.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalInfoBindingSource, "Mobile", True))
        Me.txtMobile.Location = New System.Drawing.Point(401, 117)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(202, 30)
        Me.txtMobile.TabIndex = 8
        '
        'PersonalInfoTableAdapter
        '
        Me.PersonalInfoTableAdapter.ClearBeforeFill = True
        '
        'txtFotheName
        '
        Me.txtFotheName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalInfoBindingSource, "FotherName", True))
        Me.txtFotheName.Location = New System.Drawing.Point(99, 153)
        Me.txtFotheName.Name = "txtFotheName"
        Me.txtFotheName.Size = New System.Drawing.Size(202, 30)
        Me.txtFotheName.TabIndex = 3
        '
        'txtFamilyCode
        '
        Me.txtFamilyCode.BackColor = System.Drawing.Color.White
        Me.txtFamilyCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalInfoBindingSource, "FamilyCode", True))
        Me.txtFamilyCode.Location = New System.Drawing.Point(401, 189)
        Me.txtFamilyCode.Name = "txtFamilyCode"
        Me.txtFamilyCode.ReadOnly = True
        Me.txtFamilyCode.Size = New System.Drawing.Size(202, 30)
        Me.txtFamilyCode.TabIndex = 20
        '
        'cboNesbat
        '
        Me.cboNesbat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalInfoBindingSource, "Nesbat", True))
        Me.cboNesbat.DataSource = Me.NesbatBindingSource
        Me.cboNesbat.DisplayMember = "نسبت"
        Me.cboNesbat.FormattingEnabled = True
        Me.cboNesbat.Location = New System.Drawing.Point(401, 152)
        Me.cboNesbat.Name = "cboNesbat"
        Me.cboNesbat.Size = New System.Drawing.Size(202, 31)
        Me.cboNesbat.TabIndex = 21
        '
        'NesbatBindingSource
        '
        Me.NesbatBindingSource.DataMember = "Nesbat"
        Me.NesbatBindingSource.DataSource = Me.ClinicDataSet
        '
        'NesbatTableAdapter
        '
        Me.NesbatTableAdapter.ClearBeforeFill = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.ToolStripSeparator5, Me.ToolStripLabel3, Me.txtSLname, Me.ToolStripLabel4, Me.txtSParvandeNo, Me.ToolStripLabel5, Me.txtSPhone, Me.ToolStripSeparator6, Me.btnSearch})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 230)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(616, 25)
        Me.ToolStrip1.TabIndex = 22
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripLabel2.Text = "جستجو :"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(72, 22)
        Me.ToolStripLabel3.Text = "نام خانوادگی :"
        '
        'txtSLname
        '
        Me.txtSLname.Name = "txtSLname"
        Me.txtSLname.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(74, 22)
        Me.ToolStripLabel4.Text = "شماره پرونده :"
        '
        'txtSParvandeNo
        '
        Me.txtSParvandeNo.Name = "txtSParvandeNo"
        Me.txtSParvandeNo.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel5.Text = "تلفن :"
        '
        'txtSPhone
        '
        Me.txtSPhone.Name = "txtSPhone"
        Me.txtSPhone.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'btnSearch
        '
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(23, 22)
        Me.btnSearch.Text = "ToolStripButton1"
        '
        'frmPersonalInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 255)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(نسبتLabel)
        Me.Controls.Add(Me.cboNesbat)
        Me.Controls.Add(کد_خانوادگیLabel)
        Me.Controls.Add(Me.txtFamilyCode)
        Me.Controls.Add(نام_پدرLabel)
        Me.Controls.Add(Me.txtFotheName)
        Me.Controls.Add(موبال_Label)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(تلفن_محل_کار_Label)
        Me.Controls.Add(Me.txtWorkPhone)
        Me.Controls.Add(تلفن_منزل_Label)
        Me.Controls.Add(Me.txtHomePhone)
        Me.Controls.Add(شماره_پرونده__Label)
        Me.Controls.Add(Me.txtParvandeNo)
        Me.Controls.Add(نام_خانوادگی__Label)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(نام__Label)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(کد_شناسائیLabel)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.PersonalInfoBindingNavigator)
        Me.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPersonalInfo"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "مشخصات بیماران:::..."
        CType(Me.PersonalInfoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PersonalInfoBindingNavigator.ResumeLayout(False)
        Me.PersonalInfoBindingNavigator.PerformLayout()
        CType(Me.PersonalInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NesbatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClinicDataSet As DentalClinic.ClinicDataSet
    Friend WithEvents PersonalInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonalInfoTableAdapter As DentalClinic.ClinicDataSetTableAdapters.PersonalInfoTableAdapter
    Friend WithEvents PersonalInfoBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtParvandeNo As System.Windows.Forms.TextBox
    Friend WithEvents txtHomePhone As System.Windows.Forms.TextBox
    Friend WithEvents txtWorkPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents txtFotheName As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblReg As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnGoFaktor As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtFamilyCode As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtBedehi As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboNesbat As System.Windows.Forms.ComboBox
    Friend WithEvents NesbatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NesbatTableAdapter As DentalClinic.ClinicDataSetTableAdapters.NesbatTableAdapter
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnReqFamilyCode As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtSLname As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtSParvandeNo As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtSPhone As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
End Class
