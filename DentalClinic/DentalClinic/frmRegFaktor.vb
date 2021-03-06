Public Class frmRegFaktor
    Dim PersonalInfo(8) As String
    Dim Nahaee As Integer
    Dim Flag As Boolean
    Dim Percent As Integer
    Dim SQL As New SQLConnection


    Private Sub frmRegFaktor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cmd As New SqlClient.SqlCommand("SELECT * from NoeKhadamat", SQL.sqlcon)
        SQL.sqlcon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader

        While sdr.Read
            Me.cboNoeKhadamat.Items.Add(sdr(0).ToString)
        End While
        SQL.sqlcon.Close()

        '------------------------------------------
        Dim cmd2 As New SqlClient.SqlCommand("SELECT * from NoeTarefe", SQL.sqlcon)
        SQL.sqlcon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader

        While sdr2.Read
            Me.cboNoeTarefe.Items.Add(sdr2(0).ToString)
        End While
        SQL.sqlcon.Close()
        '------------------------------------------
        Dim cmd3 As New SqlClient.SqlCommand("SELECT DentistName from DentistName", SQL.SqlCon)
        SQL.sqlcon.Open()
        Dim sdr3 As SqlClient.SqlDataReader = cmd3.ExecuteReader

        While sdr3.Read
            Me.cboDentistName.Items.Add(sdr3(0).ToString)
        End While
        SQL.sqlcon.Close()
        '------------------------------------------
        Dim cmd4 As New SqlClient.SqlCommand("SELECT * from Moaref", SQL.sqlcon)
        SQL.sqlcon.Open()
        Dim sdr4 As SqlClient.SqlDataReader = cmd4.ExecuteReader

        While sdr4.Read
            Me.cboMoaref.Items.Add(sdr4(0).ToString)
        End While
        SQL.sqlcon.Close()



    End Sub

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click

        Me.btnReg.Enabled = False

        PersonalInfo(0) = Me.txtFaktorNo.Text
        PersonalInfo(1) = Me.txtID.Text
        PersonalInfo(2) = Me.txtName.Text
        PersonalInfo(3) = Me.txtLName.Text
        PersonalInfo(4) = Me.txtParvandeNO.Text


        Dim tmp() As String = Split(Me.cboSharh.Text, "-")


        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "insert into Faktor (FaktorNo, ID, Name, LName, ParvandeNo, SharheKhadamat, Date, Day, HaznieKHadamat, HazineNahaee, SahmeDentist, DentistName, NoeKhadamat, NoeTarefe, Tedad, Moaref,Nesbat,FamilyCode) values(N'" & _
        Me.txtFaktorNo.Text & "','" & Me.txtID.Text & "',N'" & Me.txtName.Text & "',N'" & Me.txtLName.Text & "',N'" & Me.txtParvandeNO.Text & "','" & tmp(1) & "','" & Me.txtDate.Text & "',N'" & Me.txtDay.Text & "',N'" & Me.txtKhadamat.Text & "',N'" & Me.txtNahaee.Text & "',N'" & Me.txtDentist.Text & "',N'" & Me.cboDentistName.Text & "',N'" & Me.cboNoeKhadamat.Text & "',N'" & Me.cboNoeTarefe.Text & "','" & Me.NumericTedad.Text & "',N'" & Me.cboMoaref.Text & "',N'" & Me.txtNesbat.Text & "','" & Me.txtFamiliCode.Text & "')"
        cmd.Connection = sql.Sqlcon

        sql.Sqlcon.Open()

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = "SELECT * FROM Tarefe"
            Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
            Try
                sdr.Read()
            Catch exx As Exception
                MsgBox("Error")
            End Try
            MsgBox(sdr(0) & vbCrLf & sdr(1) & vbCrLf & sdr(2))
        Finally
            sql.Sqlcon.Close()
        End Try

        RefreshTEXT()

        Me.txtFaktorNo.Text = PersonalInfo(0)
        Me.txtID.Text = PersonalInfo(1)
        Me.txtName.Text = PersonalInfo(2)
        Me.txtLName.Text = PersonalInfo(3)
        Me.txtParvandeNO.Text = PersonalInfo(4)

        Dim DC As New DateConvertor
        DC.Convertor()
        Me.txtDay.Text = DC.HweekDay.ToString
        Me.txtDate.Text = DC.Hyear & "/" & DC.Hmonth & "/" & DC.Hday

        btnGenerate.Enabled = True
    End Sub

    Private Sub RefreshTEXT()
        Dim c As Control
        For Each c In Me.Controls
            If TypeOf c Is TextBox AndAlso c.Text <> "" Then
                c.Text = ""
            End If
        Next
        Me.NumericTedad.Value = 1
        Me.cboSharh.Text = ""
        Me.cboDentistName.Focus()

        Me.txtKhadamat.Text = "0"
        Me.txtDentist.Text = "0"
        Me.txtNahaee.Text = "0"

        Me.cboSharh.Focus()
    End Sub


    Private Sub cboNoeTarefe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNoeTarefe.SelectedIndexChanged
        FillComboBox(Me.cboNoeKhadamat.Text, Me.cboNoeTarefe.Text)
    End Sub

    Sub FillComboBox(ByVal NoeKhadamat As String, ByVal NoeTarefe As String)

        Dim cmd As New SqlClient.SqlCommand("SELECT NoeKhadamat, NoeTarefe, CodeDarman, Sharh, HazineKHadamat, SahmeDentist FROM Tarefe Where NoeKhadamat= N'" & NoeKhadamat & "' and NoeTarefe= N'" & NoeTarefe & "' ", sql.Sqlcon)

        Me.cboSharh.Items.Clear()

        sql.Sqlcon.Open()

        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader

        While (sdr.Read)
            Me.cboSharh.Items.Add(sdr(2) & "-" & sdr(3))

        End While

        sql.Sqlcon.Close()


    End Sub

    Private Sub cboNoeKhadamat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNoeKhadamat.SelectedIndexChanged
        FillComboBox(Me.cboNoeKhadamat.Text, Me.cboNoeTarefe.Text)
    End Sub

    Private Sub cboSharh_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboSharh.KeyPress
        If e.KeyChar = Chr(13) Then
            btnReg_Click(sender, e)
        End If
    End Sub

    Private Sub cboSharh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSharh.SelectedIndexChanged

        Me.btnReg.Enabled = True


        Dim tmp() As String = Split(Me.cboSharh.Text, "-")
        Dim cmd As New SqlClient.SqlCommand("SELECT NoeKhadamat, NoeTarefe, CodeDarman, Sharh, HazineKHadamat,SahmeDentist FROM Tarefe Where NoeKhadamat= N'" & Me.cboNoeKhadamat.Text & "' and NoeTarefe= N'" & Me.cboNoeTarefe.Text & "' and Sharh= N'" & tmp(1) & "' ", sql.Sqlcon)

        sql.Sqlcon.Open()

        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader

        While (sdr.Read)
            Me.txtKhadamat.Text = sdr(4).ToString
            Me.txtDentist.Text = sdr(5).ToString
        End While

        sql.Sqlcon.Close()

        NumericTedad_ValueChanged(sender, e)

    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click

        Dim frm As New frmFaktorEditor
        frm.FaktorNo = Me.txtFaktorNo.Text
        frm.ID = Me.txtID.Text
        frm.MdiParent = frmParent
        frm.Show()

        frm.txtName.Text = Me.txtName.Text
        frm.txtLname.Text = Me.txtLName.Text
        frm.txtFaktorno.Text = Me.txtFaktorNo.Text
        frm.txtID.Text = Me.txtID.Text
        frm.txtDay.Text = Me.txtDay.Text
        frm.txtDate.Text = Me.txtDate.Text
        frm.cboDentistName.Text = Me.cboDentistName.Text
        frm.cboMoaref.Text = Me.cboMoaref.Text
        frm.cboKhadamat.Text = Me.cboNoeKhadamat.Text
        frm.cboTarefe.Text = Me.cboNoeTarefe.Text
        frm.txtNesbat.Text = Me.txtNesbat.Text
        frm.txtFamiliCode.Text = Me.txtFamiliCode.Text

        Me.Close()

    End Sub


    Private Sub NumericTedad_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericTedad.ValueChanged
        If Me.txtKhadamat.Text <> "" Then
            Nahaee = Integer.Parse(Me.txtKhadamat.Text)
            Me.txtNahaee.Text = (Nahaee * Me.NumericTedad.Value).ToString
        End If
    End Sub

    Private Sub txtKhadamat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKhadamat.TextChanged
        If Me.txtKhadamat.Text > "0" Then
            Dim SQL2 As New SQLConnection
            Dim cmdPercent As New SqlClient.SqlCommand("SELECT [Percent] FROM DentistName WHERE DentistName= N'" & Me.cboDentistName.Text & "'", SQL2.sqlcon)

            SQL2.sqlcon.Open()
            Dim sdrPercent As SqlClient.SqlDataReader = cmdPercent.ExecuteReader

            If sdrPercent.Read Then
                Percent = sdrPercent(0).ToString
            End If
            SQL2.sqlcon.Close()


            Me.txtDentist.Text = (Integer.Parse(Me.txtKhadamat.Text) * Percent) / 100

            NumericTedad_ValueChanged(sender, e)
        End If
    End Sub



End Class