Public Class frmParent

    Private Sub frmParent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Dim SQL As New SQLConnection
    Public Co As Boolean
    Public Moaref As String

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        Me.txtTime.Text = Now.Hour & ":" & Now.Minute & ":" & Now.Second
        Dim Hdate As New DateConvertor
        Hdate.Convertor()
        Me.txtDate.Text = Hdate.Hyear & "/" & Hdate.Hmonth & "/" & Hdate.Hday & " " & Hdate.HweekDay

        Me.Text = "نرم افزار مدیریت کلینیک دندانپزشکی " + " " + Moaref + " ::..."
    End Sub

    Private Sub frmParent_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        Application.Exit()
    End Sub

    Private Sub btnBimaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBimaran.Click
        Dim frm As New frmPersonalInfo
        frm.MdiParent = Me
        frm.Show()
        frm.Commander = "Faktor"
    End Sub

    Private Sub cmdRptSecondFaktor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnFaktorAlmosana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFaktorAlmosana.Click
        Dim Msg As String = String.Empty
        If MessageBox.Show("آیا مایلید صورتحساب مورد نظرتان چاپ شود؟", "صدور صورتحساب المثنی", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) = Windows.Forms.DialogResult.Yes Then
            Dim frm As New frmInBox
            frm.MdiParent = Me
            frm.Value = "Print"
            frm.Show()
        ElseIf Windows.Forms.DialogResult.No Then
            Dim frm As New frmInBox
            frm.MdiParent = Me
            frm.Value = "View"
            frm.Show()
        ElseIf Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
    End Sub

    Private Sub btnFaktorEditor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFaktorEditor.Click
        Dim frm As New frmInBox
        frm.Value = "EditFaktor"
        frm.MdiParent = Me
        frm.Show()
        frm.Text = "ویرایش صورتحساب"
        frm.txtTitle.Text = "لطفاً شماره صورتحساب مورد نظر خود را جهت ویرایش وارد کنید"

    End Sub

    Private Sub btnFaktorEdame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFaktorEdame.Click
        Dim frm As New frmPersonalInfo
        frm.MdiParent = Me
        frm.Show()
        frm.Commander = "CarryOnFaktor"
    End Sub


    Private Sub btnRegDentist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegDentist.Click
        Dim frm As New frmRegDentistName
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnKosoorat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKosoorat.Click
        Dim frm As New frmRegKosoorat
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnRegNoeTarafe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegNoeTarafe.Click
        Dim frm As New frmRegNoeTarefe
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnRegNoeKHadamat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegNoeKHadamat.Click
        Dim frm As New frmRegNoeKhadamat
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnRegTarefe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegTarefe.Click
        Dim frm As New frmRegTarefe
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnViewTarefe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewTarefe.Click
        Dim frm As New frmTarefeEditor
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnRptTarefe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRptTarefe.Click
        Dim frm As New frmRptTarefe
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnRptAmalkardKol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRptAmalkardKol.Click
        Dim frm As New frmRptAmalkard
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnRptRizAmalkard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRptRizAmalkard.Click
        Dim frm As New frmRptAmalkardeDentist
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnAmalkardRoozane_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmalkardRoozane.Click
        Dim frm As New frmAmalkardeKoleDentist
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub Bedehkaran()

        Dim sum As String = ""
        Dim date1 As String

        Dim Hdate As New DateConvertor
        Hdate.Convertor()

        date1 = Hdate.Hyear.ToString + "/" + Hdate.Hmonth.ToString + "/" + Hdate.Hday.ToString + " " + Hdate.HweekDay


        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = SQL.SqlCon

        '------------------ Drop Table tmp_Daryafti ----------------------
        Dim cmdDropD As New SqlClient.SqlCommand("drop table tmp_Daryafti", SQL.SqlCon)

        Try
            SQL.SqlCon.Open()
            Dim sdrDrop As SqlClient.SqlDataReader = cmdDropD.ExecuteReader
            If sdrDrop.Read Then

            End If
            SQL.SqlCon.Close()
        Catch ex As Exception
            SQL.SqlCon.Close()
        End Try
        '------------------ Drop Table tmp_HazineKhadamatD ----------------------
        Dim cmdDropHKD As New SqlClient.SqlCommand("drop table tmp_HazineKhadamatD", SQL.SqlCon)

        Try
            SQL.SqlCon.Open()
            Dim sdrDrop As SqlClient.SqlDataReader = cmdDropHKD.ExecuteReader
            If sdrDrop.Read Then

            End If
            SQL.SqlCon.Close()
        Catch ex As Exception
            SQL.SqlCon.Close()
        End Try
        '------------------ Drop Table tmp_HazineKhadamat ----------------------
        Dim cmdDropHK As New SqlClient.SqlCommand("drop table tmp_HazineKhadamat", SQL.SqlCon)

        Try
            SQL.SqlCon.Open()
            Dim sdrDrop As SqlClient.SqlDataReader = cmdDropHK.ExecuteReader
            If sdrDrop.Read Then

            End If
            SQL.SqlCon.Close()
        Catch ex As Exception
            SQL.SqlCon.Close()
        End Try
        '------------------ Drop Table tmp_BedehiID ----------------------
        Dim cmdDropID As New SqlClient.SqlCommand("drop table tmp_BedehiID", SQL.SqlCon)

        Try
            SQL.SqlCon.Open()
            Dim sdrDropID As SqlClient.SqlDataReader = cmdDropID.ExecuteReader
            If sdrDropID.Read Then

            End If
            SQL.SqlCon.Close()
        Catch ex As Exception
            SQL.SqlCon.Close()
        End Try


        '----------------------------------- Sum Daryafti -------------------------------------------
        cmd.CommandText = ("select ID,sum(daryafti)'Daryafti'into tmp_Daryafti from Hesabdari group by ID ")

        SQL.SqlCon.Open()
        Dim sdrD As SqlClient.SqlDataReader = cmd.ExecuteReader

        If sdrD.Read Then

        End If
        SQL.SqlCon.Close()

        '----------------------------------- HazineKhadamatD -------------------------------------------
        cmd.CommandText = ("select ID,HazineNahaee'HazineNahaee'into tmp_HazineKhadamatD from Faktor where Deleted=0")

        SQL.SqlCon.Open()
        Dim sdrKHD As SqlClient.SqlDataReader = cmd.ExecuteReader

        If sdrKHD.Read Then

        End If
        SQL.SqlCon.Close()
        '----------------------------------- HazineKhadamat -------------------------------------------
        cmd.CommandText = ("select ID,sum(HazineNahaee)'HazineNahaee'into tmp_HazineKhadamat from tmp_HazineKhadamatD group by ID ")

        SQL.SqlCon.Open()
        Dim sdrKH As SqlClient.SqlDataReader = cmd.ExecuteReader

        If sdrKH.Read Then

        End If
        SQL.SqlCon.Close()

        '--------------------------- Join & tmp_BedehiID --------------------------------

        cmd.CommandText = ("select tmp_Daryafti.ID,tmp_HazineKhadamat.HazineNahaee-tmp_Daryafti.Daryafti 'Bedehi' into tmp_BedehiID from tmp_Daryafti left join tmp_HazineKhadamat on tmp_Daryafti.ID = tmp_HazineKhadamat.ID where tmp_HazineKhadamat.HazineNahaee-tmp_Daryafti.Daryafti >0 ")

        SQL.SqlCon.Open()
        Dim sdrJoin As SqlClient.SqlDataReader = cmd.ExecuteReader

        If sdrJoin.Read Then

        End If
        SQL.SqlCon.Close()

        Dim cmdSum As New SqlClient.SqlCommand("SELECT sum(Bedehi) from tmp_BedehiID", SQL.SqlCon)
        SQL.SqlCon.Open()
        Dim sdrSum As SqlClient.SqlDataReader = cmdSum.ExecuteReader

        If sdrSum.Read Then
            sum = sdrSum(0).ToString
        End If
        SQL.SqlCon.Close()



        '------------ Update tmp_SumBedehi ------------------
        cmd.CommandText = "update tmp_SumBedehi set Sum='" & sum & "', date='" & date1 & "'"
        cmd.Connection = SQL.SqlCon

        SQL.SqlCon.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = "SELECT * FROM tmp_SumBedehi"
            Dim sdrX As SqlClient.SqlDataReader = cmd.ExecuteReader
            Try
                sdrX.Read()
            Catch exx As Exception
                MsgBox("Error")
            End Try
        Finally
            SQL.SqlCon.Close()
        End Try


        '------------------------------ Write to XML -----------------------
        Dim DataAdapter As New SqlClient.SqlDataAdapter("select PersonalInfo.[Name] , PersonalInfo.LName,PersonalInfo.ParvandeNo,PersonalInfo.HomePhone,PersonalInfo.WorkPhone,PersonalInfo.Mobile,tmp_BedehiID.Bedehi from tmp_BedehiID left join PersonalInfo on tmp_BedehiID.ID = PersonalInfo.ID ", SQL.SqlCon)
        Dim DataSet As New DataSet
        DataAdapter.Fill(DataSet)
        DataSet.WriteXml("c:\clinic_rpt\Bedehkaran.xml")

        Dim DataAdapter2 As New SqlClient.SqlDataAdapter("select * from tmp_SumBedehi", SQL.SqlCon)
        Dim DataSet2 As New DataSet
        DataAdapter2.Fill(DataSet2)
        DataSet2.WriteXml("c:\clinic_rpt\tmp_sumBedehi.xml")

        '------------------ Drop Table Tmp_Bedehi ----------------------
        Dim cmd2 As New SqlClient.SqlCommand("drop table tmp_bedehiID", SQL.SqlCon)
        SQL.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader

        If sdr2.Read Then

        End If
        SQL.SqlCon.Close()


        Dim frm As New frmReportViewer
        frm.CrystalReportViewer1.ReportSource = frm.rptBedehi1
        frm.MdiParent = Me
        frm.Show()


    End Sub

    Private Sub btnRptBedehkaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRptBedehkaran.Click
        Bedehkaran()
    End Sub

    Private Sub btnRptMoaref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRptMoaref.Click
        Dim frm As New frmRptMorajein
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnRptSooratHesabKoli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRptSooratHesabKoli.Click
        Dim frm As New frmPersonalInfo
        frm.MdiParent = Me
        frm.Show()
        frm.Commander = "FullFaktor"
    End Sub

    Private Sub btnRegUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegUser.Click
        Dim frm As New frmRegUsers
        frm.MdiParent = Me
        frm.Show()
    End Sub


    'Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
    '    For Each ChildForm As Form In Me.MdiChildren
    '        ChildForm.Close()
    '    Next
    '    Application.Exit()
    'End Sub


    Private Sub btnViewTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewTime.Click
        Dim frm As New frmPersonalTimes
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnRegVaghteGhabli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegVaghteGhabli.Click
        Dim frm As New frmPersonalInfo
        frm.Timing = True
        frm.MdiParent = Me
        frm.Show()
    End Sub

End Class