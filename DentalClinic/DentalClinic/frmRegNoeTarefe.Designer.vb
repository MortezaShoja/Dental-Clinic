<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegNoeTarefe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegNoeTarefe))
        Me.txtNoeTarefe = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnRegNoeTarefe = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.dgrView = New System.Windows.Forms.DataGridView
        CType(Me.dgrView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNoeTarefe
        '
        Me.txtNoeTarefe.Location = New System.Drawing.Point(81, 12)
        Me.txtNoeTarefe.Name = "txtNoeTarefe"
        Me.txtNoeTarefe.Size = New System.Drawing.Size(238, 34)
        Me.txtNoeTarefe.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 26)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "نوع تعرفه :"
        '
        'btnRegNoeTarefe
        '
        Me.btnRegNoeTarefe.Location = New System.Drawing.Point(244, 142)
        Me.btnRegNoeTarefe.Name = "btnRegNoeTarefe"
        Me.btnRegNoeTarefe.Size = New System.Drawing.Size(75, 34)
        Me.btnRegNoeTarefe.TabIndex = 6
        Me.btnRegNoeTarefe.Text = "ثبت"
        Me.btnRegNoeTarefe.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(81, 142)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 34)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'dgrView
        '
        Me.dgrView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrView.Location = New System.Drawing.Point(81, 52)
        Me.dgrView.Name = "dgrView"
        Me.dgrView.Size = New System.Drawing.Size(238, 84)
        Me.dgrView.TabIndex = 8
        '
        'frmRegNoeTarefe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 188)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.dgrView)
        Me.Controls.Add(Me.txtNoeTarefe)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegNoeTarefe)
        Me.Font = New System.Drawing.Font("B Titr", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegNoeTarefe"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ثبت نوع تعرفه :::..."
        CType(Me.dgrView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNoeTarefe As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRegNoeTarefe As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents dgrView As System.Windows.Forms.DataGridView
End Class
