<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInBox))
        Me.btnOk = New System.Windows.Forms.Button
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.txtValue = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOk.Location = New System.Drawing.Point(10, 70)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(60, 31)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "صدور"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitle.Location = New System.Drawing.Point(12, 12)
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(334, 52)
        Me.txtTitle.TabIndex = 2
        '
        'txtValue
        '
        Me.txtValue.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtValue.Location = New System.Drawing.Point(76, 70)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(270, 31)
        Me.txtValue.TabIndex = 0
        Me.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmInBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 113)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.btnOk)
        Me.Font = New System.Drawing.Font("B Nazanin", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInBox"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
End Class
