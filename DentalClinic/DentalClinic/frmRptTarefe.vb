Public Class frmRptTarefe
    Dim SQL As New SQLConnection


    Private Sub frmRptTarefe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cmd As New SqlClient.SqlCommand("SELECT * from NoeKhadamat", SQL.sqlcon)
        SQL.sqlcon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader

        While sdr.Read
            Me.cboNoekhadamat.Items.Add(sdr(0).ToString)
        End While
        SQL.sqlcon.Close()

        '------------------------------------------
        Dim cmd2 As New SqlClient.SqlCommand("SELECT * from NoeTarefe", SQL.sqlcon)
        SQL.sqlcon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader

        While sdr2.Read
            Me.cboNoeTarefe.Items.Add(sdr2(0).ToString)
        End While
        SQL.sqlcon.Close()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

        Dim DataAdapter As New SqlClient.SqlDataAdapter("select * from tarefe where noekhadamat=N'" & Me.cboNoekhadamat.Text & "' and Noetarefe=N'" & Me.cboNoeTarefe.Text & "'", SQL.sqlcon)
        Dim DataSet As New DataSet
        DataAdapter.Fill(DataSet)
        DataSet.WriteXml("c:\clinic_rpt\Tarefe.xml")

        If Me.Radiokhadamat.Checked = True Then

            Dim frm As New frmReportViewer
            frm.CrystalReportViewer1.ReportSource = frm.rptTarefe1
            frm.MdiParent = frmParent
            frm.Show()

        ElseIf Me.RadioDentist.Checked = True Then

            Dim frm As New frmReportViewer
            frm.CrystalReportViewer1.ReportSource = frm.rptTarefeDentist1
            frm.MdiParent = frmParent
            frm.Show()

        End If

    End Sub
End Class