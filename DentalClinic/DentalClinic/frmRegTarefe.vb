Public Class frmRegTarefe
    Private SQL As New SQLConnection
    Private FC As FillComboBox


    Private Sub frmRegTarefe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FC = New FillComboBox


        Me.cboNoeKhadamat.Items.AddRange(FC.Generate("NoeKhadamat", "NoeKhadamat"))

        '------------------------------------------
        FC = New FillComboBox
        Me.cboNoeTarefe.Items.AddRange(FC.Generate("NoeTarefe", "NoeTarefe"))
    End Sub

    Private Sub btnRegTarefe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegTarefe.Click

        Dim SQL As New SQLConnection

        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "insert into Tarefe (NoeKhadamat,NoeTarefe,CodeDarman,Sharh,HazineKhadamat,SahmeDentist) values(N'" & Me.cboNoeKhadamat.Text & "',N'" & Me.cboNoeTarefe.Text & "',N'" & Me.txtCodeDarman.Text & "',N'" & Me.txtSharh.Text & "',N'" & Me.txtHazineKHadamat.Text & "',N'" & Me.txtSahmeDentist.Text & "')"
        cmd.Connection = SQL.sqlcon

        SQL.sqlcon.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = "SELECT * FROM Tarefe where NoeKhadmat= N'" & Me.cboNoeKhadamat.Text & "' and NoeTarefe= N'" & Me.cboNoeTarefe.Text & "' and Sharh= N'" & Me.txtSharh.Text & "'"
            Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
            Try
                sdr.Read()
            Catch exx As Exception
                MessageBox.Show(sdr(0).ToString)
            End Try

        Finally
            SQL.sqlcon.Close()
        End Try


        Dim c As Control
        For Each c In Me.Controls
            If TypeOf c Is TextBox AndAlso c.Text <> "" Then
                c.Text = ""
            End If
        Next
        FillGrid()
        Me.txtCodeDarman.Focus()

    End Sub

    Private Sub cboNoeKhadamat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNoeKhadamat.SelectedIndexChanged
        FillGrid()
    End Sub

    Private Sub FillGrid()

        Dim tbl As New DataTable
        Dim dvw As DataView
        Dim b As Boolean

        Dim CommandTExt As String = "SELECT CodeDarman as 'کد درمان',NoeKhadamat as 'نوع خدمات', NoeTarefe as 'نوع تعرفه', Sharh as 'شرح', HazineKHadamat as 'هزینه خدمات', SahmeDentist as 'سهم دندانپزشک' FROM Tarefe Where NoeKhadamat= N'" & Me.cboNoeKhadamat.Text & "' and NoeTarefe= N'" & Me.cboNoeTarefe.Text & "' "

        Dim cmd As New SqlClient.SqlCommand(CommandTExt, Sql.sqlcon)

        Sql.sqlcon.Open()

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
        Me.dgrView.DataSource = dvw
        SQL.sqlcon.Close()
        Me.dgrView.Focus()
        GetMax()

    End Sub

    Private Sub cboNoeTarefe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNoeTarefe.SelectedIndexChanged
        FillGrid()
    End Sub

    Private Sub GetMax()
        Dim cmd As New SqlClient.SqlCommand("SELECT Count(*)  from Tarefe where NoeKhadamat= N'" & Me.cboNoeKhadamat.Text & "' and NoeTarefe= N'" & Me.cboNoeTarefe.Text & "'", SQL.sqlcon)
        SQL.sqlcon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader

        While sdr.Read
            Me.txtCodeDarman.Text = (Integer.Parse(sdr(0))) + 1
        End While
        SQL.sqlcon.Close()

    End Sub

End Class