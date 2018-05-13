Public Class frmAmalkardeKoleDentist
    Private Date1, Date2, DentistName As String
    Private Percent As Integer
    Dim Done As Boolean = True
    Dim DentistID As String
    Dim SQL As New SQLConnection
    Dim Takhfif, Daryafti As Integer


    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click

        Dim Hdate As New DateConvertor
        Hdate.Convertor()
        Dim Tarikh As String = Hdate.Hyear + "/" + Hdate.Hmonth + "/" + Hdate.Hday
        Dim Day As String = Hdate.HweekDay

        GetWeekDay()
        GetDentistID()

        '---------------------- Update sum_amalkardeDentist  -------------------------------------
        Dim cmdUpdate As New SqlClient.SqlCommand
        cmdUpdate.CommandText = "update sum_amalkardeKoleDentist set dentistname='" & Me.cboDentistName.Text & "',date1='" & Date1 & "',date2='" & Date2 & "',SumIndore='" & Me.lblSumIndore.Text & "',sumKol='" & Me.lblSumKol.Text & "',mandeazghabl='" & Me.lblMandeAzGhabl.Text & "',pardakhti='" & Me.txtPardakhti.Text & "',baghimande='" & Me.txtBaghimande.Text & "',Takhfif='" & Takhfif & "',SumDaryafti='" & Daryafti & "',SumSahmeDentist='" & Takhfif + Daryafti & "'"
        cmdUpdate.Connection = SQL.sqlcon

        SQL.sqlcon.Open()
        Try
            cmdUpdate.ExecuteNonQuery()
        Catch ex As Exception
            cmdUpdate.CommandText = "SELECT * FROM sum_amalkardeKoleDentist"
            Dim sdrX As SqlClient.SqlDataReader = cmdUpdate.ExecuteReader
            Try
                sdrX.Read()
            Catch exx As Exception
                MessageBox.Show("خطا!")
            End Try
        Finally
            sql.Sqlcon.Close()
        End Try

        If System.IO.Directory.Exists("c:\clinic_rpt") = False Then
            System.IO.Directory.CreateDirectory("c:\clinic_rpt")
        End If

        '------------------------- Write XML AmalkardeDentist ----------------------------
        Dim DataAdapter As New SqlClient.SqlDataAdapter("select moaref,([name] + ' ' + Lname)+Elat'FullName',Faktorno,Date,Noekhadamat,Noetarefe,daryafti,((daryafti * '" & Percent & "')/100)+kosoorat'SahmeDentist2' from hesabdari where DentistName='" & Me.cboDentistName.Text & "' and Date between '" & Me.txtDate1.Text & "' and '" & Me.txtDate2.Text & "'", sql.Sqlcon)
        Dim DataSet As New DataSet
        DataAdapter.Fill(DataSet)
        DataSet.WriteXml("c:\clinic_rpt\AmalkardeKoleDentist.xml")

        '------------------------- Write XML AmalkardeDentist ----------------------------
        Dim DataAdapter2 As New SqlClient.SqlDataAdapter("select * from sum_AmalkardeKoleDentist", sql.Sqlcon)
        Dim DataSet2 As New DataSet
        DataAdapter2.Fill(DataSet2)
        DataSet2.WriteXml("c:\clinic_rpt\Sum_AmalkardeKoleDentist.xml")


        Dim frm As New frmReportViewer
        frm.CrystalReportViewer1.ReportSource = frm.rptAmalkardeKoleDentist1
        frm.MdiParent = frmParent
        frm.Show()
        Me.btnCampile.Enabled = True

        Me.btnGenerate.Enabled = False
        Me.btnCampile.Enabled = True

        Me.Close()

    End Sub

    Private Sub frmAmalkardeKoleDentist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim FC As New FillComboBox
        Me.cboDentistName.Items.AddRange(FC.Generate("DentistName", "DentistName"))
        
        '------------------------------------------------
        Dim Hdate As New DateConvertor
        Hdate.Convertor()
        Me.txtDate1.Text = Hdate.Hyear + "/" + Hdate.Hmonth + "/" + Hdate.Hday
        Me.txtDate2.Text = Me.txtDate1.Text
    End Sub

    Private Sub SUM_Amalkard()

        Dim cmd As New SqlClient.SqlCommand("SELECT sum(daryafti)+sum(kosoorat)'SahmeNahaee' FROM hesabdari where DentistName='" & Me.cboDentistName.Text & "' and Date between '" & Me.txtDate1.Text & "' and '" & Me.txtDate2.Text & "'", SQL.sqlcon)

        sql.Sqlcon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader

        If sdr.Read Then
            If Not sdr(0).ToString = String.Empty Then

                Daryafti = Integer.Parse(sdr(0).ToString)
                Me.lblSumIndore.Text = ((Integer.Parse(sdr(0).ToString) + Takhfif) * Percent) / 100
                Done = True
            Else
                SQL.sqlcon.Close()
                MessageBox.Show(" هیچگونه عملکردی برای " + Me.cboDentistName.SelectedItem.ToString + " در تاریخ های " + " " + Me.txtDate1.Text + " " + " و " + " " + Me.txtDate2.Text + " " + "یافت نشد", "خطا در صدور صورتحساب عملکرد قابل پرداخت", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Done = False
                Exit Sub
            End If

        End If
        Me.lblSumKol.Text = Integer.Parse(Me.lblSumIndore.Text) + Integer.Parse(Me.lblMandeAzGhabl.Text)

        If Me.txtPardakhti.Text = "" Then
            Me.txtBaghimande.Text = Me.lblSumKol.Text
        Else
            Me.txtBaghimande.Text = Integer.Parse(Me.lblSumKol.Text) - Integer.Parse(Me.txtPardakhti.Text)
        End If
        SQL.sqlcon.Close()

    End Sub

    Private Sub GetWeekDay()
        Dim cmd As New SqlClient.SqlCommand("SELECT day FROM faktor WHERE date= N'" & Me.txtDate1.Text & "'", sql.Sqlcon)


        sql.Sqlcon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader

        If sdr.Read Then
            Date1 = sdr(0).ToString
        End If
        sql.Sqlcon.Close()


        Dim cmd2 As New SqlClient.SqlCommand("SELECT day FROM faktor WHERE date= N'" & Me.txtDate2.Text & "'", sql.Sqlcon)
        sql.Sqlcon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader

        If sdr2.Read Then
            Date2 = sdr2(0).ToString
        End If
        sql.Sqlcon.Close()

        Date1 = Date1 & " " & Me.txtDate1.Text
        Date2 = Date2 & " " & Me.txtDate2.Text


    End Sub

    Private Sub btnCampile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCampile.Click

        '------------------- Get Dentist Talab -------------------

        'GetDentistTalab()


        '------------------- Get Dentist Percent -------------------
        If Me.cboDentistName.Text <> "" Then
            GetDentistPercent()
            GetTakhfif()
            SUM_Amalkard()
            If Done = True Then
                Me.btnGenerate.Enabled = True
                Me.btnCampile.Enabled = False
            End If
        Else

            MessageBox.Show("لطفاً نام دندانپزشک را انتخاب کنید", "خطا در انتخاب دندانپزشک", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Me.cboDentistName.Focus()

        End If

    End Sub

    Private Sub txtPardakhti_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPardakhti.KeyPress
        If Me.txtPardakhti.Text = "" Then Me.txtBaghimande.Text = Me.lblSumKol.Text
    End Sub

    Private Sub txtPardakhti_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPardakhti.TextChanged
        Try
            Me.txtBaghimande.Text = Integer.Parse(Me.lblSumKol.Text) - Integer.Parse(Me.txtPardakhti.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cboDentistName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDentistName.SelectedIndexChanged
        Me.txtBaghimande.Text = "0"
        Me.lblSumIndore.Text = "0"
        Me.lblMandeAzGhabl.Text = "0"
        Me.lblSumKol.Text = "0"
        Me.txtPardakhti.Text = "0"
        Me.btnGenerate.Enabled = False
        Me.btnCampile.Enabled = True

    End Sub

    Public Sub GetDentistPercent()

        Dim cmdPercent As New SqlClient.SqlCommand("SELECT [Percent] FROM DentistName WHERE DentistName= N'" & Me.cboDentistName.Text & "'", SQL.sqlcon)
        SQL.sqlcon.Open()
        Dim sdrPercent As SqlClient.SqlDataReader = cmdPercent.ExecuteReader

        If sdrPercent.Read Then
            Percent = sdrPercent(0).ToString
        End If
        SQL.sqlcon.Close()

    End Sub

    Public Sub GetDentistID()

        Dim cmdPercent As New SqlClient.SqlCommand("SELECT ID FROM DentistName WHERE DentistName= N'" & Me.cboDentistName.Text & "'", SQL.sqlcon)
        SQL.sqlcon.Open()
        Dim sdrPercent As SqlClient.SqlDataReader = cmdPercent.ExecuteReader

        If sdrPercent.Read Then
            DentistID = sdrPercent(0).ToString
        End If
        SQL.sqlcon.Close()

    End Sub

    Public Sub GetDentistTalab()

        GetDentistID()

        Dim cmd As New SqlClient.SqlCommand("SELECT sum(Sum-Pardakhti) from DentistHesabdari where date< N'" & Me.txtDate2.Text & "' and DentistID='" & DentistID & "' group by dentistID", SQL.sqlcon)

        SQL.sqlcon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd.ExecuteReader

        If sdr2.Read Then
            If Not sdr2(0).ToString = String.Empty Then
                Me.lblMandeAzGhabl.Text = sdr2(0).ToString
            End If
        End If
        SQL.sqlcon.Close()

    End Sub

    Private Sub GetTakhfif()

        Dim cmd As New SqlClient.SqlCommand("select -sum(HazineNahaee) as 'تخفیف' from faktor where sharhekhadamat='تخفیف ویژه پارمیس' and dentistname='" & Me.cboDentistName.Text & "'", SQL.sqlcon)

        SQL.sqlcon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader

        If sdr.Read Then
            If Not sdr(0).ToString = String.Empty Then
                Takhfif = Integer.Parse(sdr(0).ToString)
            End If

        End If

        SQL.sqlcon.Close()

    End Sub


End Class