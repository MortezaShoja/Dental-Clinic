Public Class frmRptMorajein
    Dim SQL As New SQLConnection

    Private Sub frmRptMorajein_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim FC As New FillComboBox

        Me.cboMoaref.Items.AddRange(FC.Generate("PersonalInfo group by moaref", "Moaref"))
        '---------------------------------------------------------------------
        Dim Hdate As New DateConvertor
        Hdate.Convertor()
        Me.txtDate1.Text = Hdate.Hyear + "/" + Hdate.Hmonth + "/" + Hdate.Hday
        Me.txtDate2.Text = Me.txtDate1.Text

    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click


        Dim cmd As New SqlClient.SqlCommand("select name,Lname,moaref,date into tmp_Morajein from hesabdari where not moaref='-' and date between '" & Me.txtDate1.Text & "' and'" & Me.txtDate2.Text & "'", sql.Sqlcon)
        sql.Sqlcon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        sql.Sqlcon.Close()


        '-----------------------------------------
        cmd.CommandText = "update tmp_Date set Date1='" & Me.txtDate1.Text & "',date2='" & Me.txtDate2.Text & "'"
        cmd.Connection = sql.Sqlcon

        sql.Sqlcon.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = "SELECT * FROM tmp_Date"
            Dim sdrX As SqlClient.SqlDataReader = cmd.ExecuteReader
            Try
                sdrX.Read()
            Catch exx As Exception
                MsgBox("Error")
            End Try
        Finally
            sql.Sqlcon.Close()
        End Try
        '-----------------------------------------

        '------------------------- Write XML Amare Morajein ----------------------------
        Dim DataAdapter As New SqlClient.SqlDataAdapter("select Moaref,count(*)'Tedad' from tmp_morajein where moaref='" & Me.cboMoaref.Text & "' group by moaref ", sql.Sqlcon)
        Dim DataSet As New DataSet
        DataAdapter.Fill(DataSet)
        DataSet.WriteXml("c:\clinic_rpt\Morajein.xml")

        Dim DataAdapter2 As New SqlClient.SqlDataAdapter("select count(*)'Sum' from  tmp_morajein  where moaref='" & Me.cboMoaref.Text & "'", sql.Sqlcon)
        Dim DataSet2 As New DataSet
        DataAdapter2.Fill(DataSet2)
        DataSet2.WriteXml("c:\clinic_rpt\Sum_Morajein.xml")

        Dim DataAdapter3 As New SqlClient.SqlDataAdapter("select * from tmp_date ", sql.Sqlcon)
        Dim DataSet3 As New DataSet
        DataAdapter3.Fill(DataSet3)
        DataSet3.WriteXml("c:\clinic_rpt\Date.xml")
        '------------------------------------------------------------------------------

        Dim cmd2 As New SqlClient.SqlCommand("drop table tmp_morajein", sql.Sqlcon)
        SQL.sqlcon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        SQL.sqlcon.Close()

        Dim frm As New frmReportViewer
        frm.CrystalReportViewer1.ReportSource = frm.rptMorajein1
        frm.MdiParent = frmParent
        frm.Show()
        Me.Close()
    End Sub

    Private Sub btnGenKol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenKol.Click


        Dim cmd As New SqlClient.SqlCommand("select name,Lname,moaref,date into tmp_Morajein from hesabdari where not moaref='-' and date between '" & Me.txtDate1.Text & "' and'" & Me.txtDate2.Text & "' and not moaref='کسورات'", SQL.sqlcon)
        SQL.sqlcon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        SQL.sqlcon.Close()


        '-----------------------------------------
        cmd.CommandText = "update tmp_Date set Date1='" & Me.txtDate1.Text & "',date2='" & Me.txtDate2.Text & "'"
        cmd.Connection = SQL.sqlcon

        SQL.sqlcon.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = "SELECT * FROM tmp_Date"
            Dim sdrX As SqlClient.SqlDataReader = cmd.ExecuteReader
            Try
                sdrX.Read()
            Catch exx As Exception
                MsgBox("Error")
            End Try
        Finally
            SQL.sqlcon.Close()
        End Try
        '-----------------------------------------

        '------------------------- Write XML Amare Morajein ----------------------------
        Dim DataAdapter As New SqlClient.SqlDataAdapter("select Moaref,count(*)'Tedad' from tmp_morajein group by moaref ", SQL.sqlcon)
        Dim DataSet As New DataSet
        DataAdapter.Fill(DataSet)
        DataSet.WriteXml("c:\clinic_rpt\Morajein.xml")

        Dim DataAdapter2 As New SqlClient.SqlDataAdapter("select count(*)'Sum' from tmp_morajein ", SQL.sqlcon)
        Dim DataSet2 As New DataSet
        DataAdapter2.Fill(DataSet2)
        DataSet2.WriteXml("c:\clinic_rpt\Sum_Morajein.xml")

        Dim DataAdapter3 As New SqlClient.SqlDataAdapter("select * from tmp_date ", SQL.sqlcon)
        Dim DataSet3 As New DataSet
        DataAdapter3.Fill(DataSet3)
        DataSet3.WriteXml("c:\clinic_rpt\Date.xml")
        '------------------------------------------------------------------------------

        Dim cmd2 As New SqlClient.SqlCommand("drop table tmp_morajein", SQL.sqlcon)
        SQL.sqlcon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        SQL.sqlcon.Close()

        Dim frm As New frmReportViewer
        frm.CrystalReportViewer1.ReportSource = frm.rptMorajein1
        frm.MdiParent = frmParent
        frm.Show()
        Me.Close()
    End Sub
End Class