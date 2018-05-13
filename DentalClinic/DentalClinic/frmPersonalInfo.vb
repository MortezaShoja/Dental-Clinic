Public Class frmPersonalInfo
    Dim Extention, FaktorNo As String
    Dim btnFlag As Boolean
    Public Commander As String
    Dim MandeAzGhabl, SumKol, Sum, Daryafti, Baghimande As Integer
    Dim SQL As New SQLConnection
    Dim SearchMgr As String = "Load"
    Private Gc As New CodeGenerator
    Public FamiliCode As String
    Private CLS As Boolean
    Public Timing As Boolean

    Private Sub frmSPersonal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Timing = True Then
            Me.btnregTiming.Visible = True
            Me.btnGoFaktor.Visible = False
        Else
            Me.btnregTiming.Visible = False
            Me.btnGoFaktor.Visible = True
        End If

        FillCboMoaref()
        FillDgrPersonalInfo()
        CLS = False
        'FillTextBox()
    End Sub

    Sub ReadExtention()

        Dim SQLL As New SQLConnection
        Dim cmd3 As New SqlClient.SqlCommand
        cmd3.Connection = SQLL.SqlCon

        cmd3.CommandText = ("SELECT Extention FROM Extention")

        SQLL.SqlCon.Open()
        Dim sdr3 As SqlClient.SqlDataReader = cmd3.ExecuteReader
        If sdr3.Read Then
            Extention = sdr3(0).ToString
        End If
        SQLL.SqlCon.Close()

    End Sub

    Private Sub PersonalInfoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUpdate.Click
        If Me.cboNesbat.Text = "سرپرست" Then
            FamiliCode = Gc.GetFamiliCode()
        End If

        Dim SQLQQQ As New SQLConnection

        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "Update personalinfo set name=N'" & Me.txtName.Text & "',lname=N'" & Me.txtLName.Text & "',FotherName=N'" & Me.txtFotherName.Text & "',parvandeno=N'" & Me.txtParvandeNo.Text & "',homephone=N'" & Me.txtHomePhone.Text & "',workphone=N'" & Me.txtWorkPhone.Text & "',mobile=N'" & Me.txtMobile.Text & "',Moaref=N'" & Me.cboMoaref.Text & "',nesbat=N'" & Me.cboNesbat.Text & "',FamiliCode=N'" & FamiliCode & "' where ID='" & Me.txtID.Text & "'"
        cmd.Connection = SQLQQQ.SqlCon

        SQLQQQ.SqlCon.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = "SELECT * FROM personalinfo"
            Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
            Try
                sdr.Read()
            Catch exx As Exception
                MsgBox("Error")
            End Try

        Finally
            SQLQQQ.SqlCon.Close()
        End Try
        SearchMgr = "Load"
        FillDgrFamiliView()
        FillDgrPersonalInfo()
        MessageBox.Show("ثبت تغییرات با موفقیت انجام شد", "ثبت تغییرات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        FillCboMoaref()
    End Sub


    Private Sub btnGoFaktor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoFaktor.Click

        If Commander = "Faktor" Then

            ReadExtention()

            Dim SQLQ1 As New SQLConnection
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "insert into FaktorNo (id,Extention) values ('" & Me.txtID.Text & "',N'" & Extention & "')"
            cmd.Connection = SQLQ1.SqlCon

            SQLQ1.SqlCon.Open()
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                cmd.CommandText = "SELECT * FROM FaktorNo"
                Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
                Try
                    sdr.Read()
                Catch exx As Exception
                    'MsgBox("Error")
                    MessageBox.Show("فاکتور بیمار مورد نظر از قبل باز می باشد", "خطا در تخصیص شماره فاکتور", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                    Exit Sub

                End Try


            Finally
                SQLQ1.SqlCon.Close()
            End Try


            'خواندن شماره فاکتور و ارسال آن به فرم صدور صورتحساب
            cmd.CommandText = ("SELECT faktorno,ID,[open],Extention FROM FaktorNo WHERE ID= N'" & Me.txtID.Text & "' AND [open]='True'")

            SQLQ1.SqlCon.Open()
            Dim sdr2 As SqlClient.SqlDataReader = cmd.ExecuteReader

            If sdr2.Read Then
                FaktorNo = sdr2(0).ToString
                Extention = sdr2(3).ToString
            End If

            SQLQ1.SqlCon.Close()


            If FaktorNo <> "" Then
                Dim frm As New frmRegFaktor
                frm.MdiParent = frmParent
                frm.Show()


                '-------------- Read Dentist Name & Moaref & NoeKhadamat -----------------------
                cmd.CommandText = ("SELECT DentistName,Moaref,NoeKhadamat,NoeTarefe FROM Faktor WHERE ID= N'" & Me.txtID.Text & "'")

                SQLQ1.SqlCon.Open()
                Dim sdrRead As SqlClient.SqlDataReader = cmd.ExecuteReader

                If sdrRead.Read Then
                    frm.cboDentistName.Text = sdrRead(0).ToString
                    frm.cboMoaref.Text = sdrRead(1).ToString
                    frm.cboNoeKhadamat.Text = sdrRead(2).ToString
                    frm.cboNoeTarefe.Text = sdrRead(3).ToString

                    frm.FillComboBox(sdrRead(2).ToString, sdrRead(3).ToString)

                End If
                SQLQ1.SqlCon.Close()

                '-------------- End Read Dentist Name & Moaref & NoeKhadamat -----------------------

                frm.txtID.Text = Me.txtID.Text
                frm.txtName.Text = Me.txtName.Text
                frm.txtLName.Text = Me.txtLName.Text
                frm.txtParvandeNO.Text = Me.txtParvandeNo.Text
                frm.txtFaktorNo.Text = Extention + " " + FaktorNo
                frm.cboMoaref.Text = Me.cboMoaref.Text
                frm.txtFamiliCode.Text = FamiliCode
                frm.txtNesbat.Text = Me.cboNesbat.Text


                Dim DC As New DateConvertor
                DC.Convertor()
                frm.txtDay.Text = DC.HweekDay
                frm.txtDate.Text = DC.Hyear & "/" & DC.Hmonth & "/" & DC.Hday
                frm.MdiParent = frmParent
                frm.Show()
                Me.Close()
            Else
                MessageBox.Show("خطا")
            End If


        ElseIf Commander = "FullFaktor" Then

            Dim frm2 As New frmFKGen
            frm2.ID = Me.txtID.Text
            frm2.Show()
            Me.Close()

        ElseIf Commander = "CarryOnFaktor" Then

            Dim frm As New frmFaktorEditor


            Dim Fno As String = ""
            Dim SQLQ1 As New SQLConnection
            Dim cmd As New SqlClient.SqlCommand("SELECT faktorno,Extention FROM faktorNo WHERE id= N'" & Me.txtID.Text & "' AND [open]= 'True' ")
            cmd.Connection = SQLQ1.SqlCon
            SQLQ1.SqlCon.Open()

            Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
            If sdr.Read Then
                frm.FaktorNo = sdr(1) & " " & sdr(0)
                frm.txtFaktorno.Text = sdr(1) & " " & sdr(0)
                Fno = sdr(1) & " " & sdr(0)
            End If
            If Fno.Length < 1 Then
                MessageBox.Show("هیچ فاکتور بازی برای بیمار مورد نظر یافت نشد", "اماده صدور صورتحساب", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Me.Close()
                Exit Sub
            End If
            SQLQ1.SqlCon.Close()
            '--------------------------------------

            frm.txtName.Text = Me.txtName.Text
            frm.txtLname.Text = Me.txtLName.Text
            frm.txtID.Text = Me.txtID.Text


            Dim cmd2 As New SqlClient.SqlCommand("SELECT day,date,dentistname,moaref,NoeKhadamat,NoeTarefe FROM faktor WHERE id= N'" & Me.txtID.Text & "' AND Faktorno= '" & Fno & "' ")
            cmd2.Connection = SQLQ1.SqlCon
            SQLQ1.SqlCon.Open()
            Dim sdr2229 As SqlClient.SqlDataReader = cmd2.ExecuteReader

            If sdr2229.Read Then
                frm.txtDay.Text = sdr2229(0)
                frm.txtDate.Text = sdr2229(1)
                frm.cboDentistName.Text = sdr2229(2)
                frm.cboMoaref.Text = sdr2229(3)
                frm.cboKhadamat.Text = sdr2229(4)
                frm.cboTarefe.Text = sdr2229(5)
            End If
            SQLQ1.SqlCon.Close()

            frm.ID = Me.txtID.Text
            frm.MdiParent = frmParent
            frm.Show()

            Me.Close()

        End If
    End Sub

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click
        '------------------------ Search --------------------------
        Dim Msg As String = String.Empty
        Try
            Dim SQLL As New SQLConnection
            Dim cmd3 As New SqlClient.SqlCommand

            cmd3.Connection = SQLL.SqlCon

            cmd3.CommandText = ("SELECT Row_number() over (order by lname) ,Name,Lname,ParvandeNo from PersonalInfo where Name=N'" & Me.txtName.Text & "' And Lname=N'" & Me.txtLName.Text & "'")

            SQLL.SqlCon.Open()
            Dim sdr3 As SqlClient.SqlDataReader = cmd3.ExecuteReader
            If sdr3.Read Then
                Msg += sdr3(0).ToString & "_ " & " به شماره پرونده: " & sdr3(3).ToString & " " & sdr3(1).ToString & " " & sdr3(2).ToString & vbCrLf
            End If
            SQLL.SqlCon.Close()
        Catch ex As Exception

        End Try
        If Msg <> String.Empty Then
            If MessageBox.Show("مشخصات همنام با مشخصات در حال ثبت به شرح ذیل یافته شده" & vbCrLf & "؟ آیا مایل به ثبت می باشید یا خیر" & vbCrLf & Msg, "تداخل در نام بیمار", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Me.dgrPersonalInfo.Visible = True
                Me.Height = 614
                RefreshTEXT()
                Me.btnRegNew.Enabled = True
                Me.btnReg.Enabled = False
                Me.btnGoFaktor.Enabled = True
                Me.btnregTiming.Enabled = True
                Me.txtUpdate.Enabled = True
                Me.SearchToolTip.Visible = True
                Me.grpFamily.BackColor = Color.White
                FillDgrFamiliView()
                CLS = False
                Exit Sub
            End If
        End If
        '--------------------------------------------------

        If Me.cboNesbat.Text = "سرپرست" Then
            FamiliCode = Gc.GetFamiliCode()
        ElseIf Me.cboNesbat.Text = "" Then

            MessageBox.Show("لطفاً نسبت خانوادگی را تکمیل کنید", "خطا در ثبت اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If

        If FamiliCode <> "" Then

            Me.dgrPersonalInfo.Visible = True
            Me.Height = 614


            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "insert into personalinfo (id,name,lname,FotherName,parvandeno,homephone,workphone,mobile,Moaref,Nesbat,FamiliCode) values(newid(),N'" & _
            Me.txtName.Text & "',N'" & Me.txtLName.Text & "',N'" & Me.txtFotherName.Text & "',N'" & Me.txtParvandeNo.Text & "',N'" & Me.txtHomePhone.Text & "',N'" & Me.txtWorkPhone.Text & "',N'" & Me.txtMobile.Text & "',N'" & Me.cboMoaref.Text & "',N'" & Me.cboNesbat.Text & "',N'" & FamiliCode & "')"
            cmd.Connection = SQL.SqlCon

            SQL.SqlCon.Open()
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                cmd.CommandText = "SELECT * FROM personalinfo"
                Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
                Try

                    sdr.Read()
                    MessageBox.Show("کلیه اطلاعات با موفقیت ثبت گردید", "ثبت اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

                Catch exx As Exception
                    MsgBox("Error")
                End Try

            Finally
                SQL.SqlCon.Close()
            End Try

            Me.btnRegNew.Enabled = True
            Me.btnReg.Enabled = False
            Me.btnGoFaktor.Enabled = True
            Me.btnregTiming.Enabled = True
            Me.txtUpdate.Enabled = True
            Me.SearchToolTip.Visible = True
            Me.grpFamily.BackColor = Color.White

            FillDgrFamiliView()
            FillDgrPersonalInfo()
            CLS = False
            RefreshTEXT()
        Else

            Me.grpFamily.BackColor = Color.Red
            MessageBox.Show("لطفاً کد خانوادگی را مشخص کنید", "خطا در ثبت اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

            Exit Sub
        End If
        FillCboMoaref()
    End Sub


    Private Sub RefreshTEXT()
        If CLS = False Then
            Me.txtID.Text = ""
            Me.txtName.Text = ""
            Me.txtLName.Text = ""
            Me.txtFotherName.Text = ""
            Me.txtParvandeNo.Text = ""
            Me.txtHomePhone.Text = ""
            Me.txtWorkPhone.Text = ""
            Me.txtMobile.Text = ""
            Me.cboMoaref.Text = ""
            'Me.txtName.Focus()
            'FamiliCode = String.Empty
        End If
    End Sub

    Private Sub btnRegNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegNew.Click
        CLS = True
        FamiliCode = ""
        Me.Height = 428

        RefreshTEXT()

        Me.btnRegNew.Enabled = False
        Me.btnReg.Enabled = True
        Me.btnGoFaktor.Enabled = False
        Me.txtUpdate.Enabled = False
        Me.lblFamiliCode.Text = ""
    End Sub

    Private Sub txtID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtID.TextChanged

        ' Me.btnDelete.Enabled = frmParent.mnuManager.Enabled

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = SQL.SqlCon


        '----------------------------- Mande AZ Ghabl ---------------------------

        cmd.CommandText = "select sum(sum-Daryafti) from Hesabdari where ID= N'" & Me.txtID.Text & "'"
        SQL.SqlCon.Open()
        Try
            Dim sdrMAG As SqlClient.SqlDataReader = cmd.ExecuteReader
            If (sdrMAG.Read) Then
                Me.txtBedehi.Text = Integer.Parse(sdrMAG(0))
            End If
        Catch ex As Exception
            Me.txtBedehi.Text = "0"
        End Try

        SQL.SqlCon.Close()

        If Me.txtBedehi.Text = "" Then
            Me.txtBedehi.Visible = False
            Me.lblBedehi.Visible = False
            sp.Visible = False
        Else
            Me.txtBedehi.Visible = True
            Me.lblBedehi.Visible = True
            sp.Visible = True
        End If


        If Me.txtBedehi.Text = "" Then Me.txtBedehi.Text = 0
        If Integer.Parse(Me.txtBedehi.Text) < 0 Then
            Me.lblBedehi.Text = "طلب  :"
            Me.txtBedehi.Text = -Integer.Parse(Me.txtBedehi.Text)
            Me.txtBedehi.ForeColor = Color.Green
            Me.lblBedehi.ForeColor = Color.Green
        Else
            Me.lblBedehi.Text = "بدهی  :"
            Me.lblBedehi.ForeColor = Color.Red
            Me.txtBedehi.ForeColor = Color.Red
        End If

    End Sub

    Private Sub txtSLname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSLname.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtSLname.Text <> "" Then
                SearchMgr = "Lname"
                FillDgrPersonalInfo()
                Me.dgrPersonalInfo.Focus()

                Clear()
            Else
                SearchMgr = "Load"
                FillDgrPersonalInfo()
            End If
        End If

    End Sub

    Private Sub txtSParvandeNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSParvandeNo.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtSParvandeNo.Text <> "" Then
                SearchMgr = "ParvandeNo"
                FillDgrPersonalInfo()
                Me.dgrPersonalInfo.Focus()

                Clear()
            Else
                SearchMgr = "Load"
                FillDgrPersonalInfo()
            End If
        End If

    End Sub

    Private Sub txtSPhone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSPhone.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtSPhone.Text <> "" Then
                SearchMgr = "Phone"
                FillDgrPersonalInfo()
                Me.dgrPersonalInfo.Focus()

                Clear()
            Else
                SearchMgr = "Load"
                FillDgrPersonalInfo()
            End If
        End If
    End Sub
    Private Sub Clear()
        Me.txtSLname.Text = ""
        Me.txtSParvandeNo.Text = ""
        Me.txtSPhone.Text = ""
        Me.txtSfamiliCode.Text = ""

        Me.txtSFLName.Text = ""
        Me.txtSFParvandeNo.Text = ""
        Me.txtSFPhone.Text = ""
        Me.txtSFFamiliCode.Text = ""
    End Sub

    Sub FillCboMoaref()
        Dim FC As New FillComboBox
        Me.cboMoaref.Items.AddRange(FC.Generate(" PersonalInfo Group By Moaref ", "Moaref"))
    End Sub


    Private Sub FillDgrPersonalInfo()

        Dim SqlGrid As New SQLConnection
        Dim tbl As New DataTable
        Dim dvw As DataView
        Dim b As Boolean

        Dim CmdT1 As String = " where HomePhone like N'" & Me.txtSPhone.Text & "'  or WorkPhone like N'" & Me.txtSPhone.Text & "' or Mobile like N'" & Me.txtSPhone.Text & "' "
        Dim CmdT2 As String = " where LName like N'" & Me.txtSLname.Text & "' Or ParvandeNO like N'" & Me.txtSParvandeNo.Text & "' "
        Dim CmdT3 As String = " SELECT row_number() over (order by Lname) as 'ردیف',ID as 'کد شناسائی',Name as 'نام',Lname as 'نام خانوادگی',FotherName as 'نام پدر',ParvandeNo as 'شماره پرونده',HomePhone as 'تلفن منزل', WorkPhone as 'تلفن محل کار', mobile as 'تلفن همراه',Nesbat as'نسبت',FamiliCode as 'کد خانوادگی',moaref as 'معرف'"
        Dim CmdT4 As String = " where FamiliCode = '" & Me.txtSfamiliCode.Text & "'"
        Dim CmdT5 As String = " where ParvandeNo like N'" & Me.txtSParvandeNo.Text & "'"
        Dim Finalize As String = " From PersonalInfo "

        Dim CommandTExt As String = ""

        If SearchMgr = "Load" Then
            CommandTExt = CmdT3 + Finalize
        ElseIf SearchMgr = "Lname" Then
            CommandTExt = CmdT3 + Finalize + CmdT2
        ElseIf SearchMgr = "Phone" Then
            CommandTExt = CmdT3 + Finalize + CmdT1
        ElseIf SearchMgr = "FamiliCode" Then
            CommandTExt = CmdT3 + Finalize + CmdT4
        ElseIf SearchMgr = "ParvandeNo" Then
            CommandTExt = CmdT3 + Finalize + CmdT5

        End If

        Dim cmd As New SqlClient.SqlCommand(CommandTExt, SqlGrid.SqlCon)

        SqlGrid.SqlCon.Open()

        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        Dim fc As Integer

        While (sdr.Read)
            'populating columns
            If Not b Then
                For fc = 0 To sdr.FieldCount - 1
                    tbl.Columns.Add(sdr.GetName(fc))
                Next
                b = True
            End If
            'populating rows
            Dim row As DataRow = tbl.NewRow
            For fc = 0 To sdr.FieldCount - 1
                row(fc) = sdr(fc)
            Next
            tbl.Rows.Add(row)
        End While
        dvw = New DataView(tbl)
        Me.dgrPersonalInfo.DataSource = dvw
        SqlGrid.SqlCon.Close()

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click

        SearchMgr = "Load"
        FillDgrPersonalInfo()
        Me.dgrPersonalInfo.Focus()
        'FillTextBox()

    End Sub


    Private Sub dgrFamiliView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrFamiliView.CellClick
        FillTextBox()
    End Sub

    Private Sub dgrFamiliView_KeyDown_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgrFamiliView.KeyDown, dgrFamiliView.KeyUp
        FillTextBox()
    End Sub

    Private Sub dgrFamiliView_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgrFamiliView.KeyPress
        FillTextBox()
    End Sub


    Private Sub dgrPersonalInfo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrPersonalInfo.CellClick
        PersonalInfo()
    End Sub

    Private Sub dgrPersonalInfo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgrPersonalInfo.KeyPress
        PersonalInfo()
    End Sub

    Private Sub dgrPersonalInfo_KeyUp_KeyDwon(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgrPersonalInfo.KeyUp, dgrPersonalInfo.KeyDown
        PersonalInfo()
    End Sub
    Private Sub PersonalInfo()
        Me.btnGoFaktor.Enabled = False
        PutFamiliCode()
        SearchMgr = "FamiliCode"
        FillDgrFamiliView()
        FamiliBedehi(FamiliCode)
        RefreshTEXT()
    End Sub
    Private Sub FillTextBox()

        Try
            Me.txtID.Text = Me.dgrFamiliView.CurrentRow.Cells.Item(1).Value.ToString
            Me.txtName.Text = Me.dgrFamiliView.CurrentRow.Cells.Item(2).Value.ToString
            Me.txtLName.Text = Me.dgrFamiliView.CurrentRow.Cells.Item(3).Value.ToString
            Me.txtFotherName.Text = Me.dgrFamiliView.CurrentRow.Cells.Item(4).Value.ToString
            Me.txtParvandeNo.Text = Me.dgrFamiliView.CurrentRow.Cells.Item(5).Value.ToString
            Me.txtHomePhone.Text = Me.dgrFamiliView.CurrentRow.Cells.Item(6).Value.ToString
            Me.txtWorkPhone.Text = Me.dgrFamiliView.CurrentRow.Cells.Item(7).Value.ToString
            Me.txtMobile.Text = Me.dgrFamiliView.CurrentRow.Cells.Item(8).Value.ToString
            Me.cboMoaref.Text = Me.dgrFamiliView.CurrentRow.Cells.Item(9).Value.ToString
            Me.cboNesbat.Text = Me.dgrFamiliView.CurrentRow.Cells.Item(10).Value.ToString

            Me.btnGoFaktor.Enabled = True
            Me.btnregTiming.Enabled = True
            'FamiliCode = Me.dgrFamiliView.CurrentRow.Cells.Item(11).Value.ToString
            Me.txtName.Focus()
        Catch ex As Exception

            MessageBox.Show(ex.Message.ToString, "خطا در خواندن اطلاعات از دیتا بیس گیرید", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Me.txtName.Text = ""
            Me.txtLName.Text = ""
            Me.txtFotherName.Text = ""
            Me.txtParvandeNo.Text = ""
            Me.txtHomePhone.Text = ""
            Me.txtWorkPhone.Text = ""
            Me.txtMobile.Text = ""
            Me.cboMoaref.Text = ""
            Me.dgrFamiliView.ClearSelection()
            Me.cboNesbat.Text = ""
            Me.lblFamiliCode.Text = ""

        End Try


    End Sub


    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim SQLQQQ As New SQLConnection

        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "Delete personalinfo where ID='" & Me.txtID.Text & "'"
        cmd.Connection = SQLQQQ.SqlCon

        SQLQQQ.SqlCon.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = "SELECT * FROM personalinfo"
            Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
            Try
                sdr.Read()
            Catch exx As Exception
                MsgBox("Error")
            End Try

        Finally
            SQLQQQ.SqlCon.Close()
        End Try

        RefreshTEXT()

        FillDgrFamiliView()
        FillDgrPersonalInfo()
        MessageBox.Show("حذف اطلاعات با موفقیت انجام شد", "حذف اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

    End Sub


    Private Sub txtSfamiliCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSfamiliCode.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtSfamiliCode.Text <> "" Then
                SearchMgr = "FamiliCode"
                FillDgrPersonalInfo()
                Me.dgrPersonalInfo.Focus()

                Clear()
            Else
                SearchMgr = "Load"
                FillDgrPersonalInfo()
            End If
        End If
    End Sub




    Private Sub txtSFLName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSFLName.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtSFLName.Text <> "" Then
                SearchMgr = "LName"
                FillDgrFamiliView()
                Clear()
            Else
                SearchMgr = "Load"
                FillDgrPersonalInfo()
            End If
        End If
    End Sub

    Private Sub txtSFParvandeNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSFParvandeNo.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtSFParvandeNo.Text <> "" Then
                SearchMgr = "ParvandeNo"
                FillDgrFamiliView()
                Clear()
            Else
                SearchMgr = "Load"
                FillDgrPersonalInfo()
            End If
        End If
    End Sub

    Private Sub txtSFPhone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSFPhone.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtSFPhone.Text <> "" Then
                SearchMgr = "Phone"
                FillDgrFamiliView()
                Clear()
            Else
                SearchMgr = "Load"
                FillDgrPersonalInfo()
            End If
        End If
    End Sub


    Private Sub txtSFFamiliCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSFFamiliCode.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtSFFamiliCode.Text <> "" Then
                SearchMgr = "FamiliCode"
                FillDgrFamiliView()
                Clear()
            Else
                SearchMgr = "Load"
                FillDgrPersonalInfo()
            End If
        End If
    End Sub


    Private Sub FillDgrFamiliView()

        Dim SqlGrid As New SQLConnection
        Dim tbl As New DataTable
        Dim dvw As DataView
        Dim b As Boolean


        Dim CmdT1 As String = " where HomePhone Like N'" & Me.txtSFPhone.Text & "'  or WorkPhone Like N'" & Me.txtSPhone.Text & "' or Mobile Like N'" & Me.txtSPhone.Text & "'  And FamiliCode= '" & FamiliCode & "'"
        Dim CmdT2 As String = " where LName Like N'" & Me.txtSFLName.Text & "' And FamiliCode= '" & FamiliCode & "'"
        Dim CmdT3 As String = " SELECT row_number() over (order by Lname) as 'ردیف',ID as 'کد شناسائی',Name as 'نام',Lname as 'نام خانوادگی',FotherName as 'نام پدر',ParvandeNo as 'شماره پرونده',HomePhone as 'تلفن منزل', WorkPhone as 'تلفن محل کار', mobile as 'تلفن همراه',moaref as 'معرف' ,Nesbat as 'نسبت',FamiliCode as 'کد خانوادگی'"
        Dim CmdT4 As String = " where Familicode= '" & FamiliCode & "'"
        Dim CmdT5 As String = " where ParvandeNo Like N'" & Me.txtSFParvandeNo.Text & "' And FamiliCode= '" & FamiliCode & "'"
        Dim Finalize As String = " From PersonalInfo "

        Dim CommandText As String = ""
        Select Case SearchMgr

            Case Is = "Load"
                CommandText = CmdT3 + Finalize + " Where FamiliCode= '" & FamiliCode & "'"
            Case Is = "Lname"
                CommandText = CmdT3 + Finalize + CmdT2
            Case Is = "Phone"
                CommandText = CmdT3 + Finalize + CmdT1
            Case Is = "FamiliCode"
                CommandText = CmdT3 + Finalize + CmdT4
            Case Is = "ParvandeNo"
                CommandText = CmdT3 + Finalize + CmdT5
        End Select

        Dim cmd As New SqlClient.SqlCommand(CommandText, SqlGrid.SqlCon)

        SqlGrid.SqlCon.Open()

        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        Dim fc As Integer

        While (sdr.Read)
            'populating columns
            If Not b Then
                For fc = 0 To sdr.FieldCount - 1
                    tbl.Columns.Add(sdr.GetName(fc))
                Next
                b = True
            End If
            'populating rows
            Dim row As DataRow = tbl.NewRow
            For fc = 0 To sdr.FieldCount - 1
                row(fc) = sdr(fc)
            Next
            tbl.Rows.Add(row)
        End While
        dvw = New DataView(tbl)
        Me.dgrFamiliView.DataSource = dvw
        SqlGrid.SqlCon.Close()

    End Sub

    Private Sub PutFamiliCode()
        Try
            FamiliCode = Me.dgrPersonalInfo.CurrentRow.Cells.Item(10).Value.ToString
            Me.Height = 614
            Me.btnRegNew.Enabled = True
        Catch ex As Exception
            FamiliCode = String.Empty
        End Try

        Me.lblFamiliCode.Text = FamiliCode
    End Sub


    Private Sub FamiliBedehi(ByVal F As String)


        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = SQL.SqlCon


        '----------------------------- HazineKhadamat ---------------------------

        ''cmd.CommandText = "select sum(HazineNahaee) from faktor where FamilyCode= N'" & F & "' and Deleted=0"
        ''SQL.sqlcon.Open()
        ''Dim HazineKhadamat As Integer = 0

        ''Dim sdrHazineKhadamat As SqlClient.SqlDataReader = cmd.ExecuteReader
        ''If (sdrHazineKhadamat.Read) Then
        ''    HazineKhadamat = Integer.Parse(sdrHazineKhadamat(0))
        ''End If
        ''SQL.sqlcon.Close()


        '----------------------------- Mande AZ Ghabl ---------------------------

        cmd.CommandText = "select sum(sum-Daryafti) from Hesabdari where FamilyCode= N'" & F & "'"
        SQL.SqlCon.Open()

        Dim sdrMAG As SqlClient.SqlDataReader = cmd.ExecuteReader
        If (sdrMAG.Read) Then
            Try
                Me.lblFBedehiResult.Text = Integer.Parse(sdrMAG(0))
            Catch ex As Exception
                Me.lblFBedehiResult.Text = "0"
            End Try

        End If
        SQL.SqlCon.Close()

        If Me.txtBedehi.Text = "" Then
            Me.lblFBedehiResult.Visible = False
            Me.lblFBedehi.Visible = False
            sp.Visible = False
        Else
            Me.lblFBedehiResult.Visible = True
            Me.lblFBedehi.Visible = True
            sp.Visible = True
        End If


        If Integer.Parse(Me.lblFBedehiResult.Text) < 0 Then
            Me.lblFBedehi.Text = "طلب کل خانواده :"
            Me.lblFBedehiResult.Text = -Integer.Parse(Me.lblFBedehiResult.Text)
            Me.lblFBedehiResult.ForeColor = Color.Green
            Me.lblFBedehi.ForeColor = Color.Green
        Else
            Me.lblFBedehi.Text = "بدهی کل خانواده :"
            Me.lblFBedehi.ForeColor = Color.Red
            Me.lblFBedehiResult.ForeColor = Color.Red
        End If


    End Sub

    Private Sub btnFamiliCodeGenerator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFamiliCodeGenerator.Click
        Me.txtParvandeNo.Text = Gc.GetParvandeNo
        Me.txtHomePhone.Focus()
    End Sub


    Private Sub btnregTiming_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregTiming.Click
        Dim frm As New frmRegTiming
        frm.MdiParent = DentalClinic.frmParent
        frm.PersonalID = Me.dgrFamiliView.CurrentRow.Cells.Item(1).Value.ToString
        frm.Show()
        Me.Close()
    End Sub

  
End Class