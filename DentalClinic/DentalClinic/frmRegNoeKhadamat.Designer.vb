<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegNoeKhadamat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegNoeKhadamat))
        Me.txtNoeKhadamat = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnRegNoeKhadamat = New System.Windows.Forms.Button
        Me.dgrView = New System.Windows.Forms.DataGridView
        Me.btnDelete = New System.Windows.Forms.Button
        CType(Me.dgrView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNoeKhadamat
        '
        Me.txtNoeKhadamat.Location = New System.Drawing.Point(93, 12)
        Me.txtNoeKhadamat.Name = "txtNoeKhadamat"
        Me.txtNoeKhadamat.Size = New System.Drawing.Size(238, 34)
        Me.txtNoeKhadamat.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "نوع خدمات :"
        '
        'btnRegNoeKhadamat
        '
        Me.btnRegNoeKhadamat.Location = New System.Drawing.Point(256, 142)
        Me.btnRegNoeKhadamat.Name = "btnRegNoeKhadamat"
        Me.btnRegNoeKhadamat.Size = New System.Drawing.Size(75, 34)
        Me.btnRegNoeKhadamat.TabIndex = 3
        Me.btnRegNoeKhadamat.Text = "ثبت"
        Me.btnRegNoeKhadamat.UseVisualStyleBackColor = True
        '
        'dgrView
        '
        Me.dgrView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrView.Location = New System.Drawing.Point(93, 52)
        Me.dgrView.Name = "dgrView"
        Me.dgrView.Size = New System.Drawing.Size(238, 84)
        Me.dgrView.TabIndex = 5
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(93, 142)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 34)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmRegNoeKhadamat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 188)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.dgrView)
        Me.Controls.Add(Me.txtNoeKhadamat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegNoeKhadamat)
        Me.Font = New System.Drawing.Font("B Titr", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegNoeKhadamat"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ثبت نوع خدمات :::..."
        CType(Me.dgrView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNoeKhadamat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRegNoeKhadamat As System.Windows.Forms.Button
    Friend WithEvents dgrView As System.Windows.Forms.DataGridView
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
