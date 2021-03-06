Public Class frmRptAmalkardeDentist
    Dim ID As String = ""
    Dim Sum As Integer = 0
    Dim Date1, Date2 As String
    Dim SQL As New SQLConnection

    Private Sub frmRptAmalkardeDentist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cmd As New SqlClient.SqlCommand("SELECT DentistName from DentistName", SQL.sqlcon)
        SQL.sqlcon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader

        While sdr.Read
            Me.cboDentistName.Items.Add(sdr(0).ToString)
        End While
        SQL.sqlcon.Close()
        '----------------------------------------------------------------------------

        Dim Hdate As New DateConvertor
        Hdate.Convertor()
        Me.txtDate1.Text = Hdate.Hyear + "/" + Hdate.Hmonth + "/" + Hdate.Hday
        Me.txtDate2.Text = Me.txtDate1.Text
    End Sub


    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click

        Dim Hdate As New DateConvertor
        Hdate.Convertor()
        Dim Tarikh As String = Hdate.Hyear + "/" + Hdate.Hmonth + "/" + Hdate.Hday
        Dim Day As String = Hdate.HweekDay

        SUM_Amalkard()
        GetWeekDay()
        Date1 = Date1 + " " + Me.txtDate1.Text
        Date2 = Date2 + " " + Me.txtDate2.Text


        If Me.cboDentistName.Text <> "" Then

            '---------------------- Update sum_amalkardeDentist  -------------------------------------
            Dim cmdUpdate As New SqlClient.SqlCommand
            cmdUpdate.CommandText = "update sum_amalkardeDentist set sum='" & Sum & "',dentistname='" & Me.cboDentistName.Text & "',date1='" & Date1 & "',date2='" & Date2 & "'"
            cmdUpdate.Connection = SQL.sqlcon

            SQL.sqlcon.Open()
            Try
                cmdUpdate.ExecuteNonQuery()
            Catch ex As Exception
                cmdUpdate.CommandText = "SELECT * FROM sum_amalkardeDentist"
                Dim sdrX As SqlClient.SqlDataReader = cmdUpdate.ExecuteReader
                Try
                    sdrX.Read()
                Catch exx As Exception
                    MessageBox.Show("خطا!")
                End Try
            Finally
                SQL.sqlcon.Close()
            End Try


            If Sum > 0 Then
                '------------------------- Write XML AmalkardeDentist ----------------------------
                Dim DataAdapter As New SqlClient.SqlDataAdapter("select row_number() over (order by Faktorno),[Name],Lname,SharheKhadamat,NoeKhadamat,NoeTarefe,Tedad,SahmeDentist,(sahmeDentist*Tedad)'SahmeNahaee',DentistName,Faktorno from Faktor where DentistName='" & Me.cboDentistName.Text & "' and Date between '" & Me.txtDate1.Text & "' and '" & Me.txtDate2.Text & "' and SahmeDentist>=1  and Deleted=0", SQL.sqlcon)
                Dim DataSet As New DataSet
                DataAdapter.Fill(DataSet)
                DataSet.WriteXml("c:\clinic_rpt\AmalkardeDentist.xml")

                '------------------------- Write XML AmalkardeDentist ----------------------------
                Dim DataAdapter2 As New SqlClient.SqlDataAdapter("select * from sum_AmalkardeDentist", SQL.sqlcon)
                Dim DataSet2 As New DataSet
                DataAdapter2.Fill(DataSet2)
                DataSet2.WriteXml("c:\clinic_rpt\Sum_AmalkardeDentist.xml")


                Dim frm As New frmReportViewer
                frm.CrystalReportViewer1.ReportSource = frm.rptAmalkardeDentist1
                frm.MdiParent = frmParent
                frm.Show()
            Else
                MessageBox.Show(" هیچگونه عملکردی برای " + Me.cboDentistName.SelectedItem.ToString + " در تاریخ های " + " " + Date1 + " " + " و " + " " + Date1 + " " + "یافت نشد", "خطا در صدور صورتحساب عملکرد ریز روزانه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            End If

        Else


            MessageBox.Show("لطفاً نام دندانپزشک را انتخاب کنید", "خطا در انتخاب دندانپزشک", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Me.cboDentistName.Focus()
        End If
    End Sub
    Private Sub SUM_Amalkard()


        Dim cmd As New SqlClient.SqlCommand("SELECT sum ((sahmeDentist*Tedad))'SahmeNahaee' FROM Faktor where DentistName='" & Me.cboDentistName.Text & "' and Date between '" & Me.txtDate1.Text & "' and '" & Me.txtDate2.Text & "' and SahmeDentist>=1 ", SQL.sqlcon)


        SQL.sqlcon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader

        If sdr.Read Then
            If Not sdr(0).ToString = String.Empty Then
                Sum = sdr(0)
            End If
        End If
        SQL.sqlcon.Close()

    End Sub

    Private Sub GetWeekDay()


        Dim cmd As New SqlClient.SqlCommand("SELECT day FROM faktor WHERE date= N'" & Me.txtDate1.Text & "'", SQL.sqlcon)

        SQL.sqlcon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader

        If sdr.Read Then
            Date1 = sdr(0).ToString
        End If
        SQL.sqlcon.Close()


        Dim cmd2 As New SqlClient.SqlCommand("SELECT day FROM faktor WHERE date= N'" & Me.txtDate2.Text & "'", SQL.sqlcon)
        SQL.sqlcon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader

        If sdr2.Read Then
            Date2 = sdr2(0).ToString
        End If
        SQL.sqlcon.Close()


    End Sub
End Class