Public Class frmFaktorEditor

    Public FaktorNo, ID, SharhK, DentistID As String
    Dim Dodarsad As String = ""
    Dim Percent As Integer
    Dim DentistN As String
    Dim SQL As New SQLConnection


    Sub FillComboBox()
        Dim Temp As String = Me.cboSharh.Text

        Dim Khadamat As String = Me.cboKhadamat.Text
        Dim Tarefe As String = Me.cboTarefe.Text

        Dim FC As New FillComboBox
        Me.cboSharh.Items.AddRange(FC.Generate("Tarefe Where NoeKhadamat= N'" & Khadamat & "' and NoeTarefe= N'" & Tarefe & "'", "Sharh"))
        Me.cboSharh.Text = Temp

    End Sub

    Private Sub cboKhadamat_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboKhadamat.SelectedValueChanged
        FillComboBox()
    End Sub

    Private Sub نوع_خدماتComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboKhadamat.TextChanged
        FillComboBox()
    End Sub

    Private Sub cboTarefe_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTarefe.SelectedValueChanged
        FillComboBox()
    End Sub

    Private Sub نوع_تعرفهComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTarefe.TextChanged
        FillComboBox()
    End Sub

    Private Sub NumericTedad_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTedad.ValueChanged
        If Me.txtKhadamat.Text <> "" Then
            Dim Sum As Integer
            Sum = Integer.Parse(Me.txtKhadamat.Text)
            Me.txtNahaee.Text = (Sum * Me.txtTedad.Value).ToString
        End If
    End Sub



    Private Sub cboSharh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSharh.TextChanged

        Dim SQLS As New SQLConnection
        Dim cmd As New SqlClient.SqlCommand("SELECT NoeKhadamat, NoeTarefe, CodeDarman, Sharh, HazineKHadamat, SahmeDentist FROM Tarefe Where NoeKhadamat= N'" & Me.cboKhadamat.Text & "' and NoeTarefe= N'" & Me.cboTarefe.Text & "' and Sharh= N'" & Me.cboSharh.Text & "' ", SQLS.sqlcon)

        SQLS.sqlcon.Open()

        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader

        While (sdr.Read)
            Me.txtKhadamat.Text = sdr(4).ToString
            Me.txtDentist.Text = sdr(5).ToString
        End While

        SQLS.sqlcon.Close()


        NumericTedad_ValueChanged(sender, e)


    End Sub


    Private Sub btnViewFaktor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewFaktor.Click

        CloseFaktorNo()


        SUM()
        GetDentistID()

        Dodarsad = Val(Me.txtDaryafti.Text) * 2 / 100


        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "insert into Hesabdari (FaktorNo, ID, Name, LName,date,day,DentistName,DentistId,NoeKhadamat,NoeTarefe,Daryafti,Sum,moaref,DoDarsad,SumKol,Elat,FamilyCode,Nesbat) values('" & Me.txtFaktorno.Text & "', '" & Me.txtID.Text & "', '" & Me.txtName.Text & "', '" & Me.txtLname.Text & "', '" & Me.txtDate.Text & "',  '" & Me.txtDay.Text & "', '" & Me.cboDentistName.Text & "', '" & DentistID & "','" & Me.cboKhadamat.Text & "', '" & Me.cboTarefe.Text & "', '" & Me.txtDaryafti.Text & "', '" & Me.txtsum.Text & "', '" & Me.cboMoaref.Text & "','" & Dodarsad & "','" & Me.txtSumKol.Text & "','','" & Me.txtFamiliCode.Text & "','" & Me.txtNesbat.Text & "')"
        cmd.Connection = sql.Sqlcon


        '---------- Update hesabdari ------------------ 12:33AM
        sql.Sqlcon.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = "Select * from Hesabdari"

            UpdateHesabdari()


            sql.Sqlcon.Close()
        End Try


        XML()





        If Me.rbView.Checked = True Then
            Dim frm As New frmReportViewer
            frm.CrystalReportViewer1.ReportSource = frm.rptFaktor1
            Me.Close()
            frm.MdiParent = frmParent
            frm.Show()
        ElseIf Me.rbPrint.Checked = True Then
            Dim frm As New frmReportViewer
            frm.CrystalReportViewer1.ReportSource = frm.rptFaktor1
            Me.Close()
            frm.rptFaktor1.PrintToPrinter(1, True, 0, 0)
        ElseIf Me.rbReg.Checked = True Then
            Me.Close()
        End If

    End Sub

    Private Sub SUM()

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = SQL.sqlcon


        '----------------------------- HazineKhadamat ---------------------------

        cmd.CommandText = "select sum(HazineNahaee) from faktor where ID= N'" & Me.txtID.Text & "' and FaktorNo < N'" & FaktorNo & "' and Deleted=0"
        SQL.sqlcon.Open()
        Dim HazineKhadamat As Integer = 0

        Dim sdrHazineKhadamat As SqlClient.SqlDataReader = cmd.ExecuteReader

        If sdrHazineKhadamat.Read Then
            If Not sdrHazineKhadamat(0).ToString = "" Then
                HazineKhadamat = Integer.Parse(sdrHazineKhadamat(0).ToString)
            End If
        End If

        SQL.sqlcon.Close()


        '----------------------------- Mande AZ Ghabl ---------------------------

        cmd.CommandText = "select sum(Daryafti) from Hesabdari where ID= N'" & Me.txtID.Text & "' and FaktorNo < N'" & FaktorNo & "'"
        SQL.sqlcon.Open()

        Dim sdrMAG As SqlClient.SqlDataReader = cmd.ExecuteReader
        If (sdrMAG.Read) Then
            If Not sdrMAG(0).ToString = "" Then
                Me.txtMandeAzGhabl.Text = HazineKhadamat - Integer.Parse(sdrMAG(0).ToString)
            End If
        End If
        SQL.sqlcon.Close()
        If Me.txtMandeAzGhabl.Text = "" Then Me.txtMandeAzGhabl.Text = "0"


        '----------------------------- SUM ---------------------------
        Me.txtsum.Text = ""
        cmd.CommandText = "select sum(HazineNahaee)'Sum' from faktor where ID= N'" & ID & "' and FaktorNo= N'" & FaktorNo & "' and Deleted=0"
        Me.cboSharh.Items.Clear()

        SQL.sqlcon.Open()

        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader

        While (sdr.Read)
            Me.txtSumKol.Text = sdr(0).ToString
        End While

        SQL.sqlcon.Close()
        Me.txtsum.Text = Me.txtSumKol.Text

        Me.txtSumKol.Text = Val(Me.txtSumKol.Text) + Val(Me.txtMandeAzGhabl.Text)

    End Sub


    Private Sub Baghimande()
        If Me.txtDaryafti.Text >= "0" And Me.txtsum.Text >= "0" Then
            Me.txtBaghimande.Text = (Val(Me.txtSumKol.Text) - Val(Me.txtDaryafti.Text)).ToString
        End If
    End Sub

    Private Sub txtDaryafti_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDaryafti.TextChanged
        Baghimande()
    End Sub
    Private Sub XML()


        Dim cmd As New SqlClient.SqlCommand


        '------------------------- Update FG SUMs----------------------------

        Dim SQLsum As New SQLConnection
        cmd.CommandText = "insert into FG (FaktorNo,Sum,MandeAzGhabl,Baghimande,Daryafti,CurrentSum) values('" & Me.txtFaktorno.Text & "','" & Me.txtSumKol.Text & "','" & Me.txtMandeAzGhabl.Text & "','" & Me.txtBaghimande.Text & "','" & Me.txtDaryafti.Text & "','" & Me.txtsum.Text & "')"
        cmd.Connection = SQLsum.sqlcon

        SQLsum.sqlcon.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = "Select * from Fg"

            UpdateFaktor()


            SQLsum.sqlcon.Close()
        End Try

        '-----------------------------------------------------------------------------

        If System.IO.Directory.Exists("c:\clinic_rpt") = False Then
            System.IO.Directory.CreateDirectory("c:\clinic_rpt")
        End If

        '-------------------- Generate Report ------------------------

        Dim DataAdapter As New SqlClient.SqlDataAdapter("select * from Faktor where ID= N'" & ID & "' and FaktorNo= N'" & FaktorNo & "' and Deleted=0 ", sql.Sqlcon)
        Dim DataSet As New DataSet
        DataAdapter.Fill(DataSet)
        DataSet.WriteXml("c:\clinic_rpt\Faktor.xml")


        '------------------------- Write XML Faktor Generator ----------------------------
        Dim DataAdapter2 As New SqlClient.SqlDataAdapter("select * from FG where faktorno='" & Me.txtFaktorno.Text & "'", sql.Sqlcon)
        Dim DataSet2 As New DataSet
        DataAdapter2.Fill(DataSet2)
        DataSet2.WriteXml("c:\clinic_rpt\FaktorFG.xml")

    End Sub



    Private Sub frmFaktorEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim FC As FillComboBox

        FC = New FillComboBox
        Me.cboKhadamat.Items.AddRange(FC.Generate("NoeKhadamat", " * "))
        
        '------------------------------------------

        FC = New FillComboBox
        Me.cboTarefe.Items.AddRange(FC.Generate("NoeTarefe", " * "))
        '------------------------------------------

        FC = New FillComboBox
        Me.cboDentistName.Items.AddRange(FC.Generate("DentistName", " * "))
        '------------------------------------------
        FC = New FillComboBox
        Me.cboMoaref.Items.AddRange(FC.Generate("Moaref", " * "))

        SUM()
        Baghimande()

        FilList(sender, e)
        Me.listSharh.SelectedIndex = 0
    End Sub


    Sub FilList(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.listSharh.Items.Clear()


        Dim cmd As New SqlClient.SqlCommand("SELECT counter,SharheKhadamat FROM faktor where faktorno='" & FaktorNo & "'", sql.Sqlcon)

        sql.Sqlcon.Open()

        Dim sdrList As SqlClient.SqlDataReader = cmd.ExecuteReader

        While sdrList.Read
            Me.listSharh.Items.Add(sdrList(0).ToString + "_" + sdrList(1).ToString)
        End While

        sql.Sqlcon.Close()


        AddHandler listSharh.SelectedIndexChanged, AddressOf listSharh_SelectedIndexChanged

    End Sub

    Private Sub listSharh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim SharhSpliter() As String = Me.listSharh.Text.Split("_")


        Dim cmdR As New SqlClient.SqlCommand

        cmdR.Connection = sql.Sqlcon
        cmdR.CommandText = "SELECT DentistName,Moaref,SharheKhadamat,NoeKhadamat,NoeTarefe,FaktorNo,ID,Name,Lname,Date,Day,HazineMavadvaLab,HaznieKHadamat,Hazinenahaee,SahmeDentist,Tedad,Deleted FROM Faktor where ID= N'" & ID & "' and FaktorNo= N'" & FaktorNo & "' and SharheKhadamat= N'" & SharhSpliter(1) & "'and counter= N'" & SharhSpliter(0) & "'"

        sql.Sqlcon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmdR.ExecuteReader

        If sdr.Read() Then

            Me.cboDentistName.Text = sdr(0)
            DentistN = sdr(0)
            Me.cboMoaref.Text = sdr(1)

            Me.cboSharh.Text = sdr(2)
            SharhK = sdr(2)

            Me.cboKhadamat.Text = sdr(3)
            Me.cboTarefe.Text = sdr(4)
            Me.txtFaktorno.Text = sdr(5)
            Me.txtID.Text = sdr(6)
            Me.txtName.Text = sdr(7)
            Me.txtLname.Text = sdr(8)
            Me.txtDate.Text = sdr(9)
            Me.txtDay.Text = sdr(10)
            Me.txtKhadamat.Text = sdr(12)
            Me.txtNahaee.Text = sdr(13)
            Me.txtDentist.Text = sdr(14)
            Me.txtTedad.Value = Val(sdr(15))
            Me.chkDel.Checked = sdr(16)

        End If
        sql.Sqlcon.Close()

        SUM()
        Baghimande()

        FillComboBox()

        Me.cboSharh.Text = SharhK


    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim SharhSpliter() As String = Me.listSharh.Text.Split("_")


        Dim cmdEdit As New SqlClient.SqlCommand

        cmdEdit.CommandText = "update Faktor set DentistName='" & Me.cboDentistName.Text & "',Moaref='" & Me.cboMoaref.Text & "',NoeKhadamat='" & Me.cboKhadamat.Text & "',NoeTarefe='" & Me.cboTarefe.Text & "',SharheKhadamat='" & Me.cboSharh.Text & "',FaktorNo='" & Me.txtFaktorno.Text & "',ID='" & Me.txtID.Text & "',Name='" & Me.txtName.Text & "',Lname='" & Me.txtLname.Text & "',Date='" & Me.txtDate.Text & "',Day='" & Me.txtDay.Text & "',HaznieKHadamat='" & Me.txtKhadamat.Text & "',Hazinenahaee='" & Me.txtNahaee.Text & "',SahmeDentist='" & Me.txtDentist.Text & "',Tedad='" & Me.txtTedad.Value & "',Deleted='" & Me.chkDel.Checked & "',FamilyCode='" & Me.txtFamiliCode.Text & "',nesbat='" & Me.txtNesbat.Text & "'  where ID= N'" & ID & "' and FaktorNo= N'" & FaktorNo & "' and SharheKhadamat= N'" & SharhSpliter(1) & "'and counter= N'" & SharhSpliter(0) & "'"
        cmdEdit.Connection = sql.Sqlcon

        sql.Sqlcon.Open()
        Try
            cmdEdit.ExecuteNonQuery()
        Catch ex As Exception
            cmdEdit.CommandText = "SELECT * FROM FG"
            Dim sdrZ As SqlClient.SqlDataReader = cmdEdit.ExecuteReader
            Try
                sdrZ.Read()
            Catch exx As Exception
                MsgBox("Error")
            End Try
        Finally
            sql.Sqlcon.Close()
        End Try


        FilList(sender, e)

        FillComboBox()


        SUM()
        Baghimande()
        Me.listSharh.SelectedIndex = 0
    End Sub

    Private Sub GetDentistID()

        Dim cmd As New SqlClient.SqlCommand("SELECT ID FROM DentistName Where DentistName= N'" & Me.cboDentistName.Text & "'", sql.Sqlcon)

        sql.Sqlcon.Open()

        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader

        While (sdr.Read)
            DentistID = sdr(0).ToString
        End While

        sql.Sqlcon.Close()
    End Sub

    Private Sub CloseFaktorNo()

        Dim cmd As New SqlClient.SqlCommand

        Dim Tmp() As String = Split(Me.txtID.Text, " ")
        cmd.CommandText = "update FaktorNo set [open]='False' where ID= N'" & Me.txtID.Text & "'"
        cmd.Connection = sql.Sqlcon

        MessageBox.Show("فاکتور جاری بسته شد", "پایان فاکتور", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

        sql.Sqlcon.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = "SELECT * FROM FaktorNo"
            Dim sdrX As SqlClient.SqlDataReader = cmd.ExecuteReader
            Try
                sdrX.Read()
            Catch exx As Exception
                MessageBox.Show("فاکتور بیمار مورد نظر از قبل باز می باشد", "خطا در تخصیص شماره فاکتور", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            End Try
        Finally
            sql.Sqlcon.Close()
        End Try
    End Sub

    Private Sub btnRegKhadamat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegKhadamat.Click

        Dim frm As New frmRegFaktor
        frm.MdiParent = frmParent
        frm.Show()

        'Dim cmd As New SqlClient.SqlCommand
        'cmd.Connection = sql.Sqlcon
        ''-------------- Read Dentist Name & Moaref & NoeKhadamat -----------------------
        'cmd.CommandText = ("SELECT DentistName,Moaref,NoeKhadamat,NoeTarefe,ParvandeNo FROM Faktor WHERE ID= N'" & Me.txtID.Text & "'")

        'sql.Sqlcon.Open()
        'Dim sdrRead As SqlClient.SqlDataReader = cmd.ExecuteReader

        'If sdrRead.Read Then
        'frm.cboDentistName.Text = sdrRead(0).ToString
        'frm.cboMoaref.Text = sdrRead(1).ToString
        'frm.cboNoeKhadamat.Text = sdrRead(2).ToString
        'frm.cboNoeTarefe.Text = sdrRead(3).ToString
        'frm.txtParvandeNO.Text = sdrRead(4).ToString

        'frm.FillComboBox(sdrRead(2).ToString, sdrRead(3).ToString)

        'End If
        'sql.Sqlcon.Close()


        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = sql.Sqlcon
        '-------------- Read Dentist Name & Moaref & NoeKhadamat -----------------------
        cmd.CommandText = ("SELECT ParvandeNo FROM Faktor WHERE ID= N'" & Me.txtID.Text & "'")

        sql.Sqlcon.Open()
        Dim sdrRead As SqlClient.SqlDataReader = cmd.ExecuteReader

        If sdrRead.Read Then

            frm.txtParvandeNO.Text = sdrRead(0).ToString
        End If

        sql.Sqlcon.Close()

        frm.cboDentistName.Text = Me.cboDentistName.Text
        frm.cboMoaref.Text = Me.cboMoaref.Text
        frm.cboNoeKhadamat.Text = Me.cboKhadamat.Text
        frm.cboNoeTarefe.Text = Me.cboTarefe.Text


        frm.FillComboBox(Me.cboKhadamat.Text, Me.cboTarefe.Text)

        '-------------- End Read Dentist Name & Moaref & NoeKhadamat -----------------------


        frm.txtID.Text = Me.txtID.Text
        frm.txtName.Text = Me.txtName.Text
        frm.txtLName.Text = Me.txtLname.Text
        frm.txtFaktorNo.Text = Me.txtFaktorno.Text
        frm.txtDate.Text = Me.txtDate.Text
        frm.txtDay.Text = Me.txtDay.Text
        frm.txtNesbat.Text = Me.txtNesbat.Text
        frm.txtFamiliCode.Text = Me.txtFamiliCode.Text

        Me.Close()

    End Sub

    Private Sub UpdateFaktor()


        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "update FG set FaktorNo='" & Me.txtFaktorno.Text & "',Sum='" & Me.txtSumKol.Text & "',MandeAzGhabl='" & Me.txtMandeAzGhabl.Text & "',Baghimande='" & Me.txtBaghimande.Text & "',Daryafti='" & Me.txtDaryafti.Text & "',CurrentSum='" & Me.txtsum.Text & "' where faktorno='" & Me.txtFaktorno.Text & "'"
        cmd.Connection = sql.Sqlcon

        SQL.sqlcon.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = "SELECT * FROM FG"
            Dim sdrX As SqlClient.SqlDataReader = cmd.ExecuteReader
            Try
                sdrX.Read()
            Catch exx As Exception
                MsgBox("خطا")
            End Try
        Finally
            SQL.sqlcon.Close()
        End Try
    End Sub


    Private Sub UpdateHesabdari()
        Dim cmd As New SqlClient.SqlCommand
        Dim SQL1 As New SQLConnection
        cmd.CommandText = "update Hesabdari set FaktorNo='" & Me.txtFaktorno.Text & "',ID='" & Me.txtID.Text & "', Name='" & Me.txtName.Text & "', LName='" & Me.txtLname.Text & "',date='" & Me.txtDate.Text & "',day='" & Me.txtDay.Text & "',DentistName='" & Me.cboDentistName.Text & "',DentistId='" & DentistID & "',NoeKhadamat='" & Me.cboKhadamat.Text & "',NoeTarefe='" & Me.cboTarefe.Text & "',Daryafti='" & Me.txtDaryafti.Text & "',Sum='" & Me.txtSumKol.Text & "',moaref='" & Me.cboMoaref.Text & "',DoDarsad='" & Dodarsad & "' where faktorno='" & Me.txtFaktorno.Text & "'"
        cmd.Connection = SQL1.sqlcon

        SQL1.sqlcon.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = "SELECT * FROM Hesabdari"
            Dim sdrX As SqlClient.SqlDataReader = cmd.ExecuteReader
            Try
                sdrX.Read()
            Catch exx As Exception
                MsgBox("خطا")
            End Try
        Finally
            SQL1.sqlcon.Close()
        End Try

    End Sub

    Private Sub txtKhadamat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKhadamat.TextChanged


        Dim DentistN As String = Me.cboDentistName.Text

        If Me.txtKhadamat.Text > "0" Then
            Dim SQLX As New SQLConnection

            Dim cmdPercent As New SqlClient.SqlCommand("SELECT [Percent] FROM DentistName WHERE DentistName= N'" & DentistN & "'", SQLX.sqlcon)
            SQLX.sqlcon.Open()
            Dim sdrPercent As SqlClient.SqlDataReader = cmdPercent.ExecuteReader

            If sdrPercent.Read Then
                Percent = sdrPercent(0).ToString
            End If
            SQLX.sqlcon.Close()


            Me.txtDentist.Text = (Integer.Parse(Me.txtKhadamat.Text) * Percent) / 100

            NumericTedad_ValueChanged(sender, e)
        End If
    End Sub


    Private Sub btnPrnFaktor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        CloseFaktorNo()
        SUM()
        GetDentistID()

        Dodarsad = Val(Me.txtDaryafti.Text) * 2 / 100


        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "insert into Hesabdari (FaktorNo, ID, Name, LName,date,day,DentistName,DentistId,NoeKhadamat,NoeTarefe,Daryafti,Sum,moaref,DoDarsad,SumKol,Elat) values('" & Me.txtFaktorno.Text & "', '" & Me.txtID.Text & "', '" & Me.txtName.Text & "', '" & Me.txtLname.Text & "', '" & Me.txtDate.Text & "',  '" & Me.txtDay.Text & "', '" & Me.cboDentistName.Text & "', '" & DentistID & "','" & Me.cboKhadamat.Text & "', '" & Me.cboTarefe.Text & "', '" & Me.txtDaryafti.Text & "', '" & Me.txtsum.Text & "', '" & Me.cboMoaref.Text & "','" & Dodarsad & "','" & Me.txtSumKol.Text & "','')"
        cmd.Connection = SQL.Sqlcon


        '---------- Update hesabdari ------------------ 12:33AM
        SQL.Sqlcon.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = "Select * from Hesabdari"

            UpdateHesabdari()


            SQL.Sqlcon.Close()
        End Try


        XML()





    End Sub

End Class