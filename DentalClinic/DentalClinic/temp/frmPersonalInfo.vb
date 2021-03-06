Public Class frmPersonalInfo
    Dim Flag As Boolean = False
    Dim FaktorNo As String
    Dim Exeqution As String
    Private Sub frmPersonalInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClinicDataSet.Nesbat' table. You can move, or remove it, as needed.
        Me.NesbatTableAdapter.Fill(Me.ClinicDataSet.Nesbat)
        'TODO: This line of code loads data into the 'ClinicDataSet.PersonalInfo' table. You can move, or remove it, as needed.
        Me.PersonalInfoTableAdapter.Fill(Me.ClinicDataSet.PersonalInfo)
    End Sub

    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.TextChanged
        Dim sqlcon As New SqlClient.SqlConnection("server=server;data source=""."";integrated security=sspi;database=Clinic")
        Dim cmd As New SqlClient.SqlCommand("SELECT ID,Pardakhti,Sum FROM Hesabdari WHERE ID= N'" & Me.txtID.Text & "'", sqlcon)

        Dim Sum As Integer
        Dim Pardakhti As Integer

        sqlcon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        While (sdr.Read)
            Pardakhti += sdr(1)
            Sum += sdr(2)
        End While

        sqlcon.Close()
        Me.txtBedehi.Text = Sum - Pardakhti

    End Sub


    Private Sub RefreshTEXT()

        Me.txtName.Text = ""
        Me.txtLName.Text = ""
        Me.txtFotheName.Text = ""
        Me.txtParvandeNo.Text = ""
        Me.txtHomePhone.Text = ""
        Me.txtWorkPhone.Text = ""
        Me.txtMobile.Text = ""
        Me.cboNesbat.Text = ""
        Me.txtFamilyCode.Text = ""
        Me.txtName.Focus()
    End Sub




    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If Flag = False Then
            RefreshTEXT()
            Me.txtID.ReadOnly = True
            Flag = True
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Flag = True Then

            Dim sqlcon As New SqlClient.SqlConnection("server=server;data source=""."";integrated security=sspi;database=Clinic")
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "insert into personalinfo (id,name,lname,FotherName,parvandeno,homephone,workphone,mobile,FamilyCode,Nesbat) values(newid(),'" & _
            Me.txtName.Text & "','" & Me.txtLName.Text & "','" & Me.txtFotheName.Text & "','" & Me.txtParvandeNo.Text & "','" & Me.txtHomePhone.Text & "','" & Me.txtWorkPhone.Text & "','" & Me.txtMobile.Text & "','" & Me.txtFamilyCode.Text & "','" & Me.cboNesbat.Text & "')"
            cmd.Connection = sqlcon

            sqlcon.Open()
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
                'MsgBox(sdr(0) & vbCrLf & sdr(1) & vbCrLf & sdr(2))
            Finally
                sqlcon.Close()
            End Try



            Flag = False
            RefreshTEXT()
            Me.PersonalInfoTableAdapter.Fill(Me.ClinicDataSet.PersonalInfo)
            Me.PersonalInfoBindingNavigator.Refresh()

            MessageBox.Show("کلیه اطلاعات با موفقیت ثبت گردید", "ثبت اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

        Else
            MessageBox.Show(" خطا در ثبت اطلاعات", "ثبت اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        End If

    End Sub

    Private Sub btnGoFaktor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoFaktor.Click, lblReg.Click


        Dim sqlcon As New SqlClient.SqlConnection("server=server;data source=""."";integrated security=sspi;database=Clinic")
        Dim cmd As New SqlClient.SqlCommand

        ReadExeqution()

        cmd.CommandText = "insert into FaktorNo (id,Exeqution) values ('" & Me.txtID.Text & "','" & Exeqution & "')"
        cmd.Connection = sqlcon

        sqlcon.Open()
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
            sqlcon.Close()
        End Try


        'خواندن شماره فاکتور و ارسال آن به فرم صدور صورتحساب
        cmd.CommandText = ("SELECT faktorno,ID,[open],Exeqution FROM FaktorNo WHERE ID= N'" & Me.txtID.Text & "' AND [open]='True'")

        sqlcon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd.ExecuteReader

        If sdr2.Read Then
            FaktorNo = sdr2(0).ToString
            Exeqution = sdr2(3).ToString
        End If

        sqlcon.Close()


        If FaktorNo <> "" Then
            Dim frm As New frmRegFaktor
            frm.Show()
            '-------------- Read Dentist Name & Moaref & NoeKhadamat -----------------------
            cmd.CommandText = ("SELECT DentistName,Moaref,NoeKhadamat,NoeTarefe FROM Faktor WHERE ID= N'" & Me.txtID.Text & "'")

            sqlcon.Open()
            Dim sdrRead As SqlClient.SqlDataReader = cmd.ExecuteReader

            If sdrRead.Read Then
                frm.cboDentistName.Text = sdrRead(0).ToString
                frm.cboMoaref.Text = sdrRead(1).ToString
                frm.cboNoeKhadamat.Text = sdrRead(2).ToString
                frm.cboNoeTarefe.Text = sdrRead(3).ToString

                frm.FillComboBox(sdrRead(2).ToString, sdrRead(3).ToString)

            End If
            sqlcon.Close()



            '-------------- End Read Dentist Name & Moaref & NoeKhadamat -----------------------


            frm.txtID.Text = Me.txtID.Text
            frm.txtName.Text = Me.txtName.Text
            frm.txtLName.Text = Me.txtLName.Text
            frm.txtParvandeNO.Text = Me.txtParvandeNo.Text
            frm.txtFaktorNo.Text = Exeqution + " " + FaktorNo
            frm.txtFamilyCode.Text = Me.txtFamilyCode.Text
            frm.txtNesbat.Text = Me.cboNesbat.Text


            Dim DC As New DateConvertor
            DC.Convertor()
            frm.txtDay.Text = DC.HweekDay
            frm.txtDate.Text = DC.Hyear & "/" & DC.Hmonth & "/" & DC.Hday

        Else
            MessageBox.Show("خطا")
        End If

    End Sub

    Sub ReadExeqution()

        Dim sqlcon3 As New SqlClient.SqlConnection("server=server;data source=""."";integrated security=sspi;database=Clinic")
        Dim cmd3 As New SqlClient.SqlCommand
        cmd3.Connection = sqlcon3

        cmd3.CommandText = ("SELECT Exeqution FROM Exeqution")

        sqlcon3.Open()
        Dim sdr3 As SqlClient.SqlDataReader = cmd3.ExecuteReader
        If sdr3.Read Then
            Exeqution = sdr3(0).ToString
        End If
        sqlcon3.Close()
    End Sub


    Private Sub btnReqFamilyCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReqFamilyCode.Click
        If Me.cboNesbat.Text = "سرپرست" Then

            Dim sqlcon As New SqlClient.SqlConnection("server=server;data source=""."";integrated security=sspi;database=Clinic")
            Dim cmd As New SqlClient.SqlCommand

            ReadExeqution()

            cmd.CommandText = "insert into FamilyCode (ID) values ('" & Me.txtID.Text & "')"
            cmd.Connection = sqlcon

            sqlcon.Open()
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                cmd.CommandText = "SELECT * FROM FamilyCode"
                Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
                Try
                    sdr.Read()
                Catch exx As Exception
                    MsgBox("Error")
                End Try
                'MsgBox(sdr(0) & vbCrLf & sdr(1) & vbCrLf & sdr(2))
            Finally
                sqlcon.Close()
            End Try
            '------------------ Read from FamilyCode bank -----------------------
            Dim sqlcon3 As New SqlClient.SqlConnection("server=server;data source=""."";integrated security=sspi;database=Clinic")
            Dim cmd3 As New SqlClient.SqlCommand
            cmd3.Connection = sqlcon3

            cmd3.CommandText = ("SELECT FamilyCode FROM FamilyCode where id='" & Me.txtID.Text & "' ")

            sqlcon3.Open()
            Dim sdr3 As SqlClient.SqlDataReader = cmd3.ExecuteReader
            If sdr3.Read Then
                Me.txtFamilyCode.Text = sdr3(0).ToString
            End If
            sqlcon3.Close()
            '------------------------ Update PersonalInfo Bank------------------------


            Me.Validate()
            Me.PersonalInfoBindingSource.EndEdit()
            Me.PersonalInfoTableAdapter.Update(Me.ClinicDataSet.PersonalInfo)

        Else
            MessageBox.Show("کد خانوادگی مخصوص سرپرست خانواده می باشد", "خطا در درخواست کد خانوادگی", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Me.Validate()
        Me.PersonalInfoBindingSource.EndEdit()
        Me.PersonalInfoTableAdapter.Update(Me.ClinicDataSet.PersonalInfo)
        MessageBox.Show("ثبت تغییرات با موفقیت انجام شد", "ثبت تغییرات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Me.PersonalInfoBindingSource.Filter = "Lname= '" & Me.txtSLname.Text & "' or ParvandeNo= '" & Me.txtSParvandeNo.Text & "' or homephone='" & Me.txtSPhone.Text & "' or Workphone='" & Me.txtSPhone.Text & "' or Mobile='" & Me.txtSPhone.Text & "'"

    End Sub

End Class