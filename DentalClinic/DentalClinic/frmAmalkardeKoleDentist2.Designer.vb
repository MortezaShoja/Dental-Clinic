<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAmalkardeKoleDentist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAmalkardeKoleDentist))
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.txtPardakhti = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.lblSumKol = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel9 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.txtBaghimande = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCampile = New System.Windows.Forms.ToolStripButton
        Me.btnGenerate = New System.Windows.Forms.ToolStripButton
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblMandeAzGhabl = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblSumIndore = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDate1 = New System.Windows.Forms.TextBox
        Me.txtDate2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboDentistName = New System.Windows.Forms.ComboBox
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(118, 22)
        Me.ToolStripLabel1.Text = "پرداختی به دندانپزشک :"
        '
        'txtPardakhti
        '
        Me.txtPardakhti.Name = "txtPardakhti"
        Me.txtPardakhti.Size = New System.Drawing.Size(70, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripLabel2.Text = "(ریال)"
        '
        'lblSumKol
        '
        Me.lblSumKol.ForeColor = System.Drawing.Color.Blue
        Me.lblSumKol.Name = "lblSumKol"
        Me.lblSumKol.Size = New System.Drawing.Size(13, 17)
        Me.lblSumKol.Text = "0"
        '
        'ToolStripStatusLabel9
        '
        Me.ToolStripStatusLabel9.Name = "ToolStripStatusLabel9"
        Me.ToolStripStatusLabel9.Size = New System.Drawing.Size(32, 17)
        Me.ToolStripStatusLabel9.Text = "(ریال)"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txtPardakhti, Me.ToolStripLabel2, Me.ToolStripLabel3, Me.txtBaghimande, Me.ToolStripLabel4, Me.ToolStripSeparator2, Me.btnCampile, Me.btnGenerate})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 79)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(462, 25)
        Me.ToolStrip1.TabIndex = 23
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripLabel3.Text = "باقیمانده :"
        '
        'txtBaghimande
        '
        Me.txtBaghimande.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtBaghimande.ForeColor = System.Drawing.Color.Red
        Me.txtBaghimande.Name = "txtBaghimande"
        Me.txtBaghimande.ReadOnly = True
        Me.txtBaghimande.Size = New System.Drawing.Size(70, 25)
        Me.txtBaghimande.Text = "0"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripLabel4.Text = "(ریال)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnCampile
        '
        Me.btnCampile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCampile.Image = CType(resources.GetObject("btnCampile.Image"), System.Drawing.Image)
        Me.btnCampile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCampile.Name = "btnCampile"
        Me.btnCampile.Size = New System.Drawing.Size(23, 22)
        Me.btnCampile.Text = "محاسبه"
        '
        'btnGenerate
        '
        Me.btnGenerate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGenerate.Enabled = False
        Me.btnGenerate.Image = CType(resources.GetObject("btnGenerate.Image"), System.Drawing.Image)
        Me.btnGenerate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(23, 22)
        Me.btnGenerate.Text = "صدور صورتحساب"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Enabled = False
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblMandeAzGhabl, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.lblSumIndore, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel7, Me.lblSumKol, Me.ToolStripStatusLabel9})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 104)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(462, 22)
        Me.StatusStrip1.TabIndex = 22
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(67, 17)
        Me.ToolStripStatusLabel1.Text = "مانده از قبل :"
        '
        'lblMandeAzGhabl
        '
        Me.lblMandeAzGhabl.ForeColor = System.Drawing.Color.Blue
        Me.lblMandeAzGhabl.Name = "lblMandeAzGhabl"
        Me.lblMandeAzGhabl.Size = New System.Drawing.Size(13, 17)
        Me.lblMandeAzGhabl.Text = "0"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(32, 17)
        Me.ToolStripStatusLabel3.Text = "(ریال)"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(73, 17)
        Me.ToolStripStatusLabel4.Text = "جمع این دوره :"
        '
        'lblSumIndore
        '
        Me.lblSumIndore.ForeColor = System.Drawing.Color.Blue
        Me.lblSumIndore.Name = "lblSumIndore"
        Me.lblSumIndore.Size = New System.Drawing.Size(13, 17)
        Me.lblSumIndore.Text = "0"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(32, 17)
        Me.ToolStripStatusLabel6.Text = "(ریال)"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(50, 17)
        Me.ToolStripStatusLabel7.Text = "جمع کل :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 21)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "از تاریخ :"
        '
        'txtDate1
        '
        Me.txtDate1.Location = New System.Drawing.Point(109, 42)
        Me.txtDate1.Name = "txtDate1"
        Me.txtDate1.Size = New System.Drawing.Size(135, 29)
        Me.txtDate1.TabIndex = 18
        '
        'txtDate2
        '
        Me.txtDate2.Location = New System.Drawing.Point(298, 42)
        Me.txtDate2.Name = "txtDate2"
        Me.txtDate2.Size = New System.Drawing.Size(135, 29)
        Me.txtDate2.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 21)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "نام دندانپزشک :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(245, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 21)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "تا تاریخ :"
        '
        'cboDentistName
        '
        Me.cboDentistName.FormattingEnabled = True
        Me.cboDentistName.Location = New System.Drawing.Point(109, 5)
        Me.cboDentistName.Name = "cboDentistName"
        Me.cboDentistName.Size = New System.Drawing.Size(325, 29)
        Me.cboDentistName.TabIndex = 16
        '
        'frmAmalkardeKoleDentist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 126)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDate1)
        Me.Controls.Add(Me.txtDate2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboDentistName)
        Me.Font = New System.Drawing.Font("B Titr", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAmalkardeKoleDentist"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گزارش عملکرد کل قابل پرداخت دندانپزشکان:::..."
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtPardakhti As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblSumKol As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel9 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtBaghimande As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCampile As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGenerate As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblMandeAzGhabl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblSumIndore As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDate1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDate2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboDentistName As System.Windows.Forms.ComboBox
End Class
