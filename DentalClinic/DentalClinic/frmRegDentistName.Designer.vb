<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegDentistName
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegDentistName))
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgrDentistName = New System.Windows.Forms.DataGridView
        Me.txtDentistName = New System.Windows.Forms.TextBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnRegister = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPercent = New System.Windows.Forms.TextBox
        CType(Me.dgrDentistName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 26)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "نام دندانپزشک :"
        '
        'dgrDentistName
        '
        Me.dgrDentistName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrDentistName.Location = New System.Drawing.Point(12, 86)
        Me.dgrDentistName.Name = "dgrDentistName"
        Me.dgrDentistName.Size = New System.Drawing.Size(344, 201)
        Me.dgrDentistName.TabIndex = 6
        '
        'txtDentistName
        '
        Me.txtDentistName.Location = New System.Drawing.Point(141, 6)
        Me.txtDentistName.Name = "txtDentistName"
        Me.txtDentistName.Size = New System.Drawing.Size(215, 34)
        Me.txtDentistName.TabIndex = 5
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(246, 293)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(111, 34)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(129, 293)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(111, 34)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "ثبت تغییرات"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(12, 293)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(111, 34)
        Me.btnRegister.TabIndex = 9
        Me.btnRegister.Text = "جدید"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 26)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "درصد قابل پرداخت :"
        '
        'txtPercent
        '
        Me.txtPercent.Location = New System.Drawing.Point(141, 46)
        Me.txtPercent.Name = "txtPercent"
        Me.txtPercent.Size = New System.Drawing.Size(215, 34)
        Me.txtPercent.TabIndex = 12
        '
        'frmRegDentistName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 331)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPercent)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgrDentistName)
        Me.Controls.Add(Me.txtDentistName)
        Me.Controls.Add(Me.btnDelete)
        Me.Font = New System.Drawing.Font("B Titr", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegDentistName"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ثبت دندانپزشک:::..."
        CType(Me.dgrDentistName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgrDentistName As System.Windows.Forms.DataGridView
    Friend WithEvents txtDentistName As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPercent As System.Windows.Forms.TextBox




End Class
