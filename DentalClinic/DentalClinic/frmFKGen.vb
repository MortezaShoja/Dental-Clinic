Public Class frmFKGen
    Public ID As String
    Dim Sum, Pardakhti, Baghimande As Integer
    Dim CurrentDate, Date1, Date2 As String
    Dim SQL As New SQLConnection


    Private Sub frmFKGen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cmd As New SqlClient.SqlCommand("SELECT Min(Date),Max(Date) FROM Faktor WHERE ID='" & ID & "'", sql.Sqlcon)
        sql.Sqlcon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader

        If sdr.Read Then
            Me.txtDate1.Text = sdr(0)
            Me.txtDate2.Text = sdr(1)
        End If
        sql.Sqlcon.Close()
        '---------------------- Get Date ---------------------------
        Dim Hdate As New DateConvertor
        Hdate.Convertor()
        CurrentDate = Hdate.Hyear + "/" + Hdate.Hmonth + "/" + Hdate.Hday + " " + Hdate.HweekDay
        '------------------------- Get Day Date1 ---------------------
        Dim cmdDate1 As New SqlClient.SqlCommand("SELECT Day FROM Faktor WHERE Date='" & Me.txtDate1.Text & "'", sql.Sqlcon)
        sql.Sqlcon.Open()
        Dim sdrDate1 As SqlClient.SqlDataReader = cmdDate1.ExecuteReader

        If sdrDate1.Read Then
            Date1 = Me.txtDate1.Text + " " + sdrDate1(0)
        End If
        sql.Sqlcon.Close()
        '------------------------- Get Day Date2 ---------------------
        Dim cmdDate2 As New SqlClient.SqlCommand("SELECT Day FROM Faktor WHERE Date='" & Me.txtDate2.Text & "'", SQL.sqlcon)
        SQL.sqlcon.Open()
        Dim sdrDate2 As SqlClient.SqlDataReader = cmdDate2.ExecuteReader

        If sdrDate2.Read Then
            Date2 = Me.txtDate2.Text + " " + sdrDate2(0)
        End If
        SQL.sqlcon.Close()

    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click

        '---------------------- Get Sum ------------------------------
        Dim cmdSum As New SqlClient.SqlCommand("select sum(sum) from Hesabdari where ID= N'" & ID & "'", SQL.sqlcon)
        SQL.sqlcon.Open()
        Dim sdrSum As SqlClient.SqlDataReader = cmdSum.ExecuteReader
        If sdrSum.Read Then
            Sum = sdrSum(0)
        End If
        SQL.sqlcon.Close()
        '---------------------- Get Pardakhti ------------------------------
        Dim cmdPardakhti As New SqlClient.SqlCommand("select sum(Daryafti) from Hesabdari where ID= N'" & ID & "'", SQL.sqlcon)
        SQL.sqlcon.Open()
        Dim sdrPardakhti As SqlClient.SqlDataReader = cmdPardakhti.ExecuteReader
        If sdrPardakhti.Read Then
            Pardakhti = sdrPardakhti(0)
        End If
        SQL.sqlcon.Close()
        '---------------------- Get Baghimande ------------------------------
        Baghimande = Sum - Pardakhti


        '------------------------ Update SUM_FaktoreKoli -------------------
        Dim cmd As New SqlClient.SqlCommand("Update SUM_FaktoreKoli Set Date1='" & Date1 & "',Date2='" & Date2 & "',SUM='" & Sum & "',Pardakhti='" & Pardakhti & "',Baghimande='" & Baghimande & "',currentDate='" & CurrentDate & "'", SQL.sqlcon)

        SQL.sqlcon.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = "SELECT * FROM SUM_FaktoreKoli"
            Dim sdrZ As SqlClient.SqlDataReader = cmd.ExecuteReader
            Try
                sdrZ.Read()
            Catch exx As Exception
                MsgBox("خطا")
            End Try
        Finally
            SQL.sqlcon.Close()
        End Try
        '-------------------- Generate Report ------------------------
        Dim DataAdapter As New SqlClient.SqlDataAdapter("select * from Faktor where ID= N'" & ID & "'  and Deleted=0 order by FaktorNo ", SQL.sqlcon)
        Dim DataSet As New DataSet
        DataAdapter.Fill(DataSet)
        DataSet.WriteXml("c:\clinic_rpt\Faktor.xml")
        '------------------------- Write XML Faktor Generator from => SUM_FaktoreKoli ----------------------------
        Dim DataAdapter2 As New SqlClient.SqlDataAdapter("select * from SUM_FaktoreKoli ", SQL.sqlcon)
        Dim DataSet2 As New DataSet
        DataAdapter2.Fill(DataSet2)
        DataSet2.WriteXml("c:\clinic_rpt\FaktorFG.xml")


        '--------------------- view Report -----------------------
        Dim frm As New frmReportViewer
        frm.CrystalReportViewer1.ReportSource = frm.rptFaktorKoli1

        If Me.rbView.Checked = True Then
            Me.Close()
            frm.MdiParent = frmParent
            frm.Show()
        ElseIf Me.rbPrint.Checked = True Then
            Me.Close()
            frm.rptFaktorKoli1.PrintToPrinter(1, True, 0, 0)
        End If

    End Sub
End Class