<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegTiming
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegTiming))
        Me.dbgTimes = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.txty = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblPersonName = New System.Windows.Forms.Label
        Me.btnReg = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtM = New System.Windows.Forms.TextBox
        Me.txtD = New System.Windows.Forms.TextBox
        Me.txtMin = New System.Windows.Forms.TextBox
        Me.txtSec = New System.Windows.Forms.TextBox
        CType(Me.dbgTimes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dbgTimes
        '
        Me.dbgTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dbgTimes.Location = New System.Drawing.Point(12, 155)
        Me.dbgTimes.Name = "dbgTimes"
        Me.dbgTimes.Size = New System.Drawing.Size(226, 179)
        Me.dbgTimes.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "تاریخ :"
        '
        'txty
        '
        Me.txty.Location = New System.Drawing.Point(174, 38)
        Me.txty.Name = "txty"
        Me.txty.Size = New System.Drawing.Size(61, 33)
        Me.txty.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 26)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "/"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(161, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 26)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "/"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 26)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "نام بیمار :"
        '
        'lblPersonName
        '
        Me.lblPersonName.AutoSize = True
        Me.lblPersonName.ForeColor = System.Drawing.Color.Maroon
        Me.lblPersonName.Location = New System.Drawing.Point(77, 9)
        Me.lblPersonName.Name = "lblPersonName"
        Me.lblPersonName.Size = New System.Drawing.Size(125, 26)
        Me.lblPersonName.TabIndex = 10
        Me.lblPersonName.Text = "محل نمایش نام بیمار"
        '
        'btnReg
        '
        Me.btnReg.Location = New System.Drawing.Point(11, 116)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(71, 33)
        Me.btnReg.TabIndex = 12
        Me.btnReg.Text = "ثبت"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(89, 116)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(71, 33)
        Me.btnEdit.TabIndex = 17
        Me.btnEdit.Text = "تغییرات"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(166, 116)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(71, 33)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(113, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 26)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 26)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "زمان :"
        '
        'txtM
        '
        Me.txtM.Location = New System.Drawing.Point(124, 38)
        Me.txtM.Name = "txtM"
        Me.txtM.Size = New System.Drawing.Size(44, 33)
        Me.txtM.TabIndex = 25
        '
        'txtD
        '
        Me.txtD.Location = New System.Drawing.Point(74, 38)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(44, 33)
        Me.txtD.TabIndex = 26
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(124, 77)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(44, 33)
        Me.txtMin.TabIndex = 27
        '
        'txtSec
        '
        Me.txtSec.Location = New System.Drawing.Point(74, 77)
        Me.txtSec.Name = "txtSec"
        Me.txtSec.Size = New System.Drawing.Size(44, 33)
        Me.txtSec.TabIndex = 28
        '
        'frmRegTiming
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 346)
        Me.Controls.Add(Me.txtSec)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.txtD)
        Me.Controls.Add(Me.txtM)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.lblPersonName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txty)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dbgTimes)
        Me.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegTiming"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "ثبت وقت قبلی :::..."
        CType(Me.dbgTimes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dbgTimes As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txty As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblPersonName As System.Windows.Forms.Label
    Friend WithEvents btnReg As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtM As System.Windows.Forms.TextBox
    Friend WithEvents txtD As System.Windows.Forms.TextBox
    Friend WithEvents txtMin As System.Windows.Forms.TextBox
    Friend WithEvents txtSec As System.Windows.Forms.TextBox
End Class
