Public Class frmInBox
    Public Value As String
    Dim SQl As New SQLConnection


    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        Dim Fno As String = Me.txtValue.Text

        '-------------------- Generate Report ------------------------
        If System.IO.Directory.Exists("c:\clinic_rpt") = False Then
            System.IO.Directory.CreateDirectory("c:\clinic_rpt")
        End If
        Dim DataAdapter As New SqlClient.SqlDataAdapter("select * from Faktor where FaktorNo= N'" & Fno & "' and Deleted=0 ", SQl.sqlcon)
        Dim DataSet As New DataSet
        DataAdapter.Fill(DataSet)
        DataSet.WriteXml("c:\clinic_rpt\Faktor.xml")


        '------------------------- Write XML Faktor Generator ----------------------------
        Dim DataAdapter2 As New SqlClient.SqlDataAdapter("select * from FG where FaktorNo= N'" & Fno & "'", SQl.sqlcon)
        Dim DataSet2 As New DataSet
        DataAdapter2.Fill(DataSet2)
        DataSet2.WriteXml("c:\clinic_rpt\FaktorFG.xml")

        If Value = "Print" Then
            Dim frm As New frmReportViewer
            frm.CrystalReportViewer1.ReportSource = frm.rptFaktor1
            frm.rptFaktor1.PrintToPrinter(1, True, 0, 0)
        ElseIf Value = "View" Then
            Dim frm As New frmReportViewer
            frm.CrystalReportViewer1.ReportSource = frm.rptFaktor1
            frm.MdiParent = DentalClinic.frmParent
            frm.Show()
        End If


        If Value = "EditFaktor" Then

            If Fno.Length > 0 Then

                Dim frm As New frmFaktorEditor

                Dim SQL7 As New SQLConnection

                Dim cmd As New SqlClient.SqlCommand("SELECT FaktorNo, ID, Name, LName, ParvandeNo, SharheKhadamat, Date, Day, HaznieKHadamat, HazineNahaee, SahmeDentist, DentistName, NoeKhadamat, NoeTarefe, Tedad, Moaref,FamilyCode,Nesbat FROM Faktor WHERE FaktorNo= N'" & Fno & "'", SQL7.sqlcon)

                SQL7.sqlcon.Open()
                Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader

                If sdr.Read Then
                    frm.txtFaktorno.Text = sdr(0)
                    frm.FaktorNo = sdr(0)
                    frm.txtID.Text = sdr(1)
                    frm.ID = sdr(1)
                    frm.txtName.Text = sdr(2)
                    frm.txtLname.Text = sdr(3)
                    frm.txtDate.Text = sdr(6)
                    frm.txtDay.Text = sdr(7)
                    frm.cboDentistName.Text = sdr(11)
                    frm.cboKhadamat.Text = sdr(12)
                    frm.cboTarefe.Text = sdr(13)
                    frm.cboMoaref.Text = sdr(15)
                End If

                SQL7.sqlcon.Close()
                frm.MdiParent = DentalClinic.frmParent
                frm.Show()

            End If
        End If

        Me.Close()
    End Sub


    Private Sub frmInBox_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = "صدور صورتحساب المثنی"
        Me.txtTitle.Text = "لطفاً شماره صورتحساب مورد نظر خود را جهت صدورالمثنی وارد کنید"
    End Sub

    Private Sub txtValue_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValue.KeyPress
        If e.KeyChar = Chr(13) Then
            btnOK_Click(sender, e)
        End If
    End Sub


End Class