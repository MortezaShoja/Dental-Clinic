Public Class frmRptAmalkard
    Dim Date1, Date2 As String
    Dim DateX1, DateX2 As String
    Dim SQL As New SQLConnection


    Private Sub frmRptAmalkatd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Hdate As New DateConvertor
        Hdate.Convertor()
        Me.numberYear1.Text = Hdate.Hyear
        Me.numbermonth1.Text = Hdate.Hmonth
        Me.numberDay1.Text = Hdate.Hday

        Me.numberyear2.Text = Hdate.Hyear
        Me.numbermonth2.Text = Hdate.Hmonth
        Me.numberDay2.Text = Hdate.Hday


        Me.numberDay1.Focus()

    End Sub


    Private Sub btnReportViewer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportViewer.Click



        DateX1 = Me.numberYear1.Text & "/" & Me.numbermonth1.Text & "/" & Me.numberDay1.Text
        DateX2 = Me.numberyear2.Text & "/" & Me.numbermonth2.Text & "/" & Me.numberDay2.Text
        GetWeekDay()
        Date1 = Date1 + " " + DateX1
        Date2 = Date2 + " " + DateX2

        '------------------------- Date1 ------------------------------




        Dim cmd As New SqlClient.SqlCommand


        cmd.CommandText = "update AmalkardSums set Date1='" & Date1 & "',date2='" & Date2 & "'"
        cmd.Connection = SQL.sqlcon

        SQL.sqlcon.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = "SELECT * FROM AmalkardSums"
            Dim sdrX As SqlClient.SqlDataReader = cmd.ExecuteReader
            Try
                sdrX.Read()
            Catch exx As Exception
                MsgBox("Error")
            End Try
        Finally
            SQL.sqlcon.Close()
        End Try



        '------------------------- Sum Dodarsad ------------------------------
        cmd.CommandText = "select sum(DoDarsad) from Hesabdari where elat='' and date  between '" & DateX1 & "' and '" & DateX2 & "'"
        SQL.sqlcon.Open()
        Dim SumDodarsad As String = ""
        Dim sdrDo As SqlClient.SqlDataReader = cmd.ExecuteReader

        While (sdrDo.Read)
            SumDodarsad = sdrDo(0).ToString
        End While
        SQL.sqlcon.Close()


        cmd.CommandText = "update AmalkardSums set SumDodarsad='" & SumDodarsad & "'"
        cmd.Connection = SQL.sqlcon

        SQL.sqlcon.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = "SELECT * FROM AmalkardSums"
            Dim sdrX As SqlClient.SqlDataReader = cmd.ExecuteReader
            Try
                sdrX.Read()
            Catch exx As Exception
                MsgBox("Error")
            End Try
        Finally
            SQL.sqlcon.Close()
        End Try


        '------------------------- Sum Baghimande ------------------------------
        cmd.CommandText = "select sum(Daryafti) from Hesabdari where elat='' and date between '" & DateX1 & "' and '" & DateX2 & "'"
        SQL.sqlcon.Open()
        Dim SumBaghimande As Integer = 0
        Dim sdrBAG As SqlClient.SqlDataReader = cmd.ExecuteReader

        While sdrBAG.Read

            Try
                SumBaghimande = Integer.Parse(sdrBAG(0).ToString)
            Catch ex As Exception

            End Try
       

        End While

        SQL.sqlcon.Close()


        cmd.CommandText = "update AmalkardSums set SumDaryafti='" & SumBaghimande & "'"
        cmd.Connection = SQL.sqlcon

        SQL.sqlcon.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = "SELECT * FROM AmalkardSums"
            Dim sdrX As SqlClient.SqlDataReader = cmd.ExecuteReader
            Try
                sdrX.Read()
            Catch exx As Exception
                MsgBox("Error")
            End Try
        Finally
            SQL.sqlcon.Close()
        End Try


        '------------------------- Sum Daryafti ------------------------------
        cmd.CommandText = "select sum([sum]-Daryafti) from Hesabdari where elat='' and date between '" & DateX1 & "' and '" & DateX2 & "'"
        SQL.sqlcon.Open()
        Dim SumDaryafti As Integer = 0
        Dim sdrDAR As SqlClient.SqlDataReader = cmd.ExecuteReader

        While sdrDAR.Read

            Try

                SumDaryafti = Integer.Parse(sdrDAR(0).ToString)

            Catch ex As Exception

            End Try
          

        End While

        SQL.sqlcon.Close()


        cmd.CommandText = "update AmalkardSums set SumBaghimande='" & SumDaryafti & "'"
        cmd.Connection = SQL.sqlcon

        SQL.sqlcon.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = "SELECT * FROM AmalkardSums"
            Dim sdrX As SqlClient.SqlDataReader = cmd.ExecuteReader
            Try
                sdrX.Read()
            Catch exx As Exception
                MsgBox("Error")
            End Try
        Finally
            SQL.sqlcon.Close()
        End Try



        '------------------------- Sum JameKol ------------------------------
        cmd.CommandText = "select sum([sum]) from Hesabdari where elat='' and date between '" & DateX1 & "' and '" & DateX2 & "'"
        SQL.sqlcon.Open()
        Dim SumJameKol As Integer = 0
        Dim sdrSUM As SqlClient.SqlDataReader = cmd.ExecuteReader

        While sdrSUM.Read

            Try

                SumJameKol = Integer.Parse(sdrSUM(0).ToString)

            Catch ex As Exception

            End Try
        
        End While
        SQL.sqlcon.Close()


        cmd.CommandText = "update AmalkardSums set SumJameKol='" & SumJameKol & "'"
        cmd.Connection = SQL.sqlcon

        SQL.sqlcon.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = "SELECT * FROM AmalkardSums"
            Dim sdrX As SqlClient.SqlDataReader = cmd.ExecuteReader
            Try
                sdrX.Read()
            Catch exx As Exception
                MsgBox("Error")
            End Try
        Finally
            SQL.sqlcon.Close()
        End Try



        '------------------------------- Generate XML ----------------------------

        Dim DataAdapter As New SqlClient.SqlDataAdapter("select DentistName,NoeKHadamat,NoeTarefe,Moaref,FaktorNo,[sum],Daryafti,(sum-daryafti)'Baghimande',dodarsad from Hesabdari where elat='' and date between '" & DateX1 & "' and '" & DateX2 & "'", SQL.sqlcon)
        Dim DataSet As New DataSet
        DataAdapter.Fill(DataSet)
        DataSet.WriteXml("c:\clinic_rpt\Amalkard.xml")

        Dim DataAdapter2 As New SqlClient.SqlDataAdapter("select * from AmalkardSums", SQL.sqlcon)
        Dim DataSet2 As New DataSet
        DataAdapter2.Fill(DataSet2)
        DataSet2.WriteXml("c:\clinic_rpt\AmalkardSUM.xml")


        Dim frm As New frmReportViewer
            frm.CrystalReportViewer1.ReportSource = frm.rptAmalkard1
        frm.MdiParent = frmParent
            frm.Show()
        Me.Close()



    End Sub

    Private Sub GetWeekDay()

        Dim cmd As New SqlClient.SqlCommand("SELECT day FROM faktor WHERE date= N'" & DateX1 & "'", SQL.sqlcon)


        SQL.sqlcon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader

        If sdr.Read Then
            Date1 = sdr(0).ToString
        End If
        SQL.sqlcon.Close()


        Dim cmd2 As New SqlClient.SqlCommand("SELECT day FROM faktor WHERE date= N'" & DateX2 & "'", SQL.sqlcon)
        SQL.sqlcon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader

        If sdr2.Read Then
            Date2 = sdr2(0).ToString
        End If
        SQL.sqlcon.Close()


    End Sub
End Class