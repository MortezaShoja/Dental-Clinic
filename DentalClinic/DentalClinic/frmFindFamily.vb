Public Class frmFindFamily
    Dim Extention, FaktorNo As String
    Dim btnFlag As Boolean
    Public Commander As String
    Dim MandeAzGhabl, SumKol, Sum, Daryafti, Baghimande As Integer
    Dim SQL As New SQLConnection
    Dim SearchMgr As String = "Load"
    Dim FamiliCode As String


    Private Sub frmSPersonal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FillGrid()
        FillTextBox()

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        frmPersonalInfo.FamiliCode = FamiliCode
        frmPersonalInfo.lblFamiliCode.Text = FamiliCode
        Me.Close()

    End Sub


    Private Sub txtID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtID.TextChanged

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = SQL.sqlcon
        '----------------------------- HazineKhadamat ---------------------------

        cmd.CommandText = "select sum(HazineNahaee) from faktor where FamiliCode= '" & FamiliCode & "' and Deleted=0"
        SQL.sqlcon.Open()
        Dim HazineKhadamat As Integer = 0

        Dim sdrHazineKhadamat As SqlClient.SqlDataReader = cmd.ExecuteReader
        If (sdrHazineKhadamat.Read) Then
            HazineKhadamat = Integer.Parse(sdrHazineKhadamat(0))
        End If
        SQL.sqlcon.Close()


        '----------------------------- Mande AZ Ghabl ---------------------------

        cmd.CommandText = "select sum(Daryafti) from Hesabdari where ID= N'" & Me.txtID.Text & "'"
        SQL.sqlcon.Open()

        Dim sdrMAG As SqlClient.SqlDataReader = cmd.ExecuteReader
        If (sdrMAG.Read) Then
            Me.txtFamiliBedehi.Text = HazineKhadamat - Integer.Parse(sdrMAG(0))
        End If
        SQL.sqlcon.Close()

        If Me.txtFamiliBedehi.Text = "" Then
            Me.txtFamiliBedehi.Visible = False
            Me.lblBedehi.Visible = False
            sp.Visible = False
        Else
            Me.txtFamiliBedehi.Visible = True
            Me.lblBedehi.Visible = True
            sp.Visible = True
        End If


        If Me.txtFamiliBedehi.Text = "" Then Me.txtFamiliBedehi.Text = 0
        If Integer.Parse(Me.txtFamiliBedehi.Text) < 0 Then
            Me.lblBedehi.Text = "طلب پیشین :"
            Me.txtFamiliBedehi.Text = -Integer.Parse(Me.txtFamiliBedehi.Text)
            Me.txtFamiliBedehi.ForeColor = Color.Green
            Me.lblBedehi.ForeColor = Color.Green
        Else
            Me.lblBedehi.Text = "بدهی پیشین کل خانواده :"
            Me.lblBedehi.ForeColor = Color.Red
            Me.txtFamiliBedehi.ForeColor = Color.Red
        End If

    End Sub

    Private Sub txtSLname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSLname.KeyPress
        If e.KeyChar = Chr(13) Then
            SearchMgr = "Lname"
            FillGrid()
            Me.txtMoaref.Focus()
            Me.dgrPersonalInfo.Focus()
            Clear()
        End If

    End Sub

    Private Sub txtSParvandeNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSParvandeNo.KeyPress
        If e.KeyChar = Chr(13) Then
            SearchMgr = "Lname"
            FillGrid()
            Me.txtMoaref.Focus()
            Me.dgrPersonalInfo.Focus()
            Clear()
        End If

    End Sub

    Private Sub txtSPhone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSPhone.KeyPress
        If e.KeyChar = Chr(13) Then
            SearchMgr = "Phone"
            FillGrid()
            Me.txtMoaref.Focus()
            Me.dgrPersonalInfo.Focus()
            Clear()
        End If
    End Sub

    Private Sub Clear()
        Me.txtSLname.Text = ""
        Me.txtSParvandeNo.Text = ""
        Me.txtSPhone.Text = ""
    End Sub


    Private Sub FillGrid()

        Dim SqlGrid As New SQLConnection
        Dim tbl As New DataTable
        Dim dvw As DataView
        Dim b As Boolean


        Dim CmdT1 As String = " where HomePhone= '" & Me.txtSPhone.Text & "'  or WorkPhone= '" & Me.txtSPhone.Text & "' or Mobile= '" & Me.txtSPhone.Text & "' "
        Dim CmdT2 As String = " where LName= '" & Me.txtSLname.Text & "' Or ParvandeNO= '" & Me.txtSParvandeNo.Text & "' "
        Dim CmdT3 As String = " SELECT row_number() over (order by Lname) as 'ردیف',ID as 'کد شناسائی',Name as 'نام',Lname as 'نام خانوادگی',FotherName as 'نام پدر',ParvandeNo as 'شماره پرونده',HomePhone as 'تلفن منزل', WorkPhone as 'تلفن محل کار', mobile as 'تلفن همراه',moaref as 'معرف' ,Nesbat as 'نسبت',FamiliCode as 'کد خانوادگی'"
        Dim CmdT4 As String = " where FamiliCode= '" & Integer.Parse(Me.txtSfamiliCode.Text) & "'"
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
        End If


        Dim cmd As New SqlClient.SqlCommand(CommandTExt, SqlGrid.sqlcon)

        SqlGrid.sqlcon.Open()

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
        SqlGrid.sqlcon.Close()

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click

        SearchMgr = "Load"
        Me.txtMoaref.Focus()
        Me.dgrPersonalInfo.Focus()
        FillGrid()
        FillTextBox()

    End Sub

    Private Sub dgrPersonalInfo_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrPersonalInfo.CellContentClick

        FillTextBox()

    End Sub

    Private Sub dgrPersonalInfo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgrPersonalInfo.KeyDown, dgrPersonalInfo.KeyUp

        FillTextBox()

    End Sub

    Private Sub dgrPersonalInfo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrPersonalInfo.GotFocus
        FillTextBox()
    End Sub

    Private Sub FillTextBox()

        Try
            Me.txtID.Text = Me.dgrPersonalInfo.CurrentRow.Cells.Item(1).Value
            Me.txtName.Text = Me.dgrPersonalInfo.CurrentRow.Cells.Item(2).Value
            Me.txtLName.Text = Me.dgrPersonalInfo.CurrentRow.Cells.Item(3).Value
            Me.txtFotherName.Text = Me.dgrPersonalInfo.CurrentRow.Cells.Item(4).Value
            Me.txtParvandeNo.Text = Me.dgrPersonalInfo.CurrentRow.Cells.Item(5).Value
            Me.txtHomePhone.Text = Me.dgrPersonalInfo.CurrentRow.Cells.Item(6).Value
            Me.txtWorkPhone.Text = Me.dgrPersonalInfo.CurrentRow.Cells.Item(7).Value
            Me.txtMobile.Text = Me.dgrPersonalInfo.CurrentRow.Cells.Item(8).Value
            Me.txtMoaref.Text = Me.dgrPersonalInfo.CurrentRow.Cells.Item(9).Value
            Me.txtNesbat.Text = Me.dgrPersonalInfo.CurrentRow.Cells.Item(10).Value
            Me.lblFamiliCode.Text = Me.dgrPersonalInfo.CurrentRow.Cells.Item(11).Value
            FamiliCode = Me.dgrPersonalInfo.CurrentRow.Cells.Item(11).Value
        Catch ex As Exception


            Me.txtName.Text = ""
            Me.txtLName.Text = ""
            Me.txtFotherName.Text = ""
            Me.txtParvandeNo.Text = ""
            Me.txtHomePhone.Text = ""
            Me.txtWorkPhone.Text = ""
            Me.txtMobile.Text = ""
            Me.txtMoaref.Text = ""
            Me.txtNesbat.Text = ""

        Finally


        End Try
    End Sub

    Private Sub dgrPersonalInfo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgrPersonalInfo.MouseClick
        FillTextBox()
    End Sub

    Private Sub txtSfamiliCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSfamiliCode.KeyPress
        If e.KeyChar = Chr(13) Then
            SearchMgr = "FamiliCode"
            FillGrid()
            Me.txtMoaref.Focus()
            Me.dgrPersonalInfo.Focus()
            Clear()
        End If
    End Sub


    Private Sub GetFamiliCode()

        Dim DC As New DateConvertor
        DC.Convertor()

        FamiliCode = Mid(DC.Hyear, 3, 4) + DC.Hmonth + DC.Hday + Now.TimeOfDay.Hours.ToString + Now.TimeOfDay.Minutes.ToString + Now.TimeOfDay.Seconds.ToString

    End Sub

End Class