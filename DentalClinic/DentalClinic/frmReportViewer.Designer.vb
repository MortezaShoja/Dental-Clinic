<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportViewer))
        Me.rptAmalkard1 = New DentalClinic.rptAmalkard
        Me.rptAmalkardeDentist1 = New DentalClinic.rptAmalkardeDentist
        Me.rptFaktor1 = New DentalClinic.rptFaktor
        Me.rptAmalkardeKoleDentist1 = New DentalClinic.rptAmalkardeKoleDentist
        Me.rptBedehi1 = New DentalClinic.rptBedehi
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.rptMorajein1 = New DentalClinic.rptMorajein
        Me.rptTarefe1 = New DentalClinic.rptTarefe
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnExit = New System.Windows.Forms.ToolStripButton
        Me.rptFaktorKoli1 = New DentalClinic.rptFaktorKoli
        Me.rptTarefeDentist1 = New DentalClinic.rptTarefeDentist
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(480, 312)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(350, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(63, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(51, 22)
        Me.btnExit.Text = "خروج"
        '
        'frmReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 312)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmReportViewer"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "گزارشات :::..."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptFaktor1 As DentalClinic.rptFaktor
    Friend WithEvents rptAmalkard1 As DentalClinic.rptAmalkard
    Friend WithEvents rptAmalkardeDentist1 As DentalClinic.rptAmalkardeDentist
    Friend WithEvents rptAmalkardeKoleDentist1 As DentalClinic.rptAmalkardeKoleDentist
    Friend WithEvents rptTarefe1 As DentalClinic.rptTarefe
    Friend WithEvents rptBedehi1 As DentalClinic.rptBedehi
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents rptMorajein1 As DentalClinic.rptMorajein
    Friend WithEvents rptFaktorKoli1 As DentalClinic.rptFaktorKoli
    Friend WithEvents rptTarefeDentist1 As DentalClinic.rptTarefeDentist
End Class
