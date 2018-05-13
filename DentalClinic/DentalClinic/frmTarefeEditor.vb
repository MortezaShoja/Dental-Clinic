Public Class frmTarefeEditor
    Dim SQL As New SQLConnection
    Dim CodeDarman, NoeKhadamat, NoeTarefe, Sharh, HazineKHadamat, SahmeDentist As String


    Private Sub cboTarafe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTarafe.SelectedIndexChanged
        FillGrid()
    End Sub



    Private Sub FillGrid()

        Dim tbl As New DataTable
        Dim dvw As DataView
        Dim b As Boolean



        Dim CommandTExt As String = "SELECT CodeDarman as 'کد درمان',NoeKhadamat as 'نوع خدمات', NoeTarefe as 'نوع تعرفه', Sharh as 'شرح', HazineKHadamat as 'هزینه خدمات', SahmeDentist as 'سهم دندانپزشک' FROM Tarefe Where NoeKhadamat= N'" & Me.cboKhadamat.Text & "' and NoeTarefe= N'" & Me.cboTarafe.Text & "' "



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

    End Sub

    Private Sub frmTarefeEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As New SqlClient.SqlCommand("SELECT * from NoeKhadamat", Sql.sqlcon)
        Sql.sqlcon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader

        While sdr.Read
            Me.cboKhadamat.Items.Add(sdr(0).ToString)
        End While
        Sql.sqlcon.Close()

        '------------------------------------------
        Dim cmd2 As New SqlClient.SqlCommand("SELECT * from NoeTarefe", Sql.sqlcon)
        Sql.sqlcon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader

        While sdr2.Read
            Me.cboTarafe.Items.Add(sdr2(0).ToString)
        End While
        SQL.sqlcon.Close()

        Me.cboKhadamat.Focus()

    End Sub

    Private Sub cboKhadamat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboKhadamat.SelectedIndexChanged
        FillGrid()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If MessageBox.Show("اطلاعات مورد نظر حذف شود", "حذف اطلاعات", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) = Windows.Forms.DialogResult.OK Then
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "Delete Tarefe where CodeDarman= N'" & Me.txtCodeDarman.Text & "' and NoeKhadamat = N'" & Me.cboKhadamat.Text & "' and NoeTarefe = N'" & Me.cboTarafe.Text & "' and Sharh = N'" & Me.txtSharh.Text & "' and HazineKHadamat = N'" & Me.txtHazinekhadamat.Text & "' and SahmeDentist = N'" & Me.txtSahmeDentist.Text & "'"
            cmd.Connection = SQL.sqlcon

            SQL.sqlcon.Open()
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception

            Finally
                SQL.sqlcon.Close()
            End Try

            RefreshTEXT()

            FillGrid()

            MessageBox.Show("حذف اطلاعات با موفقیت انجام شد", "حذف اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

        End If

    End Sub
    Private Sub RefreshTEXT()
        Dim c As Control
        For Each c In Me.Controls
            If TypeOf c Is TextBox AndAlso c.Text <> "" Then
                c.Text = ""
            End If
        Next
        Me.cboKhadamat.Focus()
    End Sub


    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click
        If MessageBox.Show("اطلاعات مورد نظر تغییر یابد؟", "ثبت تغییرات", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) = Windows.Forms.DialogResult.OK Then
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "Update Tarefe Set CodeDarman= N'" & Me.txtCodeDarman.Text & "',NoeKhadamat = N'" & Me.cboKhadamat.Text & "', NoeTarefe = N'" & Me.cboTarafe.Text & "', Sharh = N'" & Me.txtSharh.Text & "', HazineKHadamat = N'" & Me.txtHazinekhadamat.Text & "', SahmeDentist = N'" & Me.txtSahmeDentist.Text & "' where CodeDarman= N'" & CodeDarman & "' and NoeKhadamat = N'" & NoeKhadamat & "' and NoeTarefe = N'" & NoeTarefe & "' and Sharh = N'" & Sharh & "' and HazineKHadamat = N'" & HazineKHadamat & "' and SahmeDentist = N'" & SahmeDentist & "' "
            cmd.Connection = SQL.sqlcon

            SQL.sqlcon.Open()
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception

            Finally
                SQL.sqlcon.Close()
            End Try

            RefreshTEXT()

            FillGrid()

            MessageBox.Show("ثبت تغییرات با موفقیت انجام شد", "ثبت تغییرات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

        End If
    End Sub

    Private Sub dgrView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrView.CellContentClick
        FillTextBox()
    End Sub

    Private Sub FillTextBox()

        Try
            Me.txtCodeDarman.Text = Me.dgrView.CurrentRow.Cells.Item(0).Value
            Me.txtSharh.Text = Me.dgrView.CurrentRow.Cells.Item(3).Value
            Me.txtHazinekhadamat.Text = Me.dgrView.CurrentRow.Cells.Item(4).Value
            Me.txtSahmeDentist.Text = Me.dgrView.CurrentRow.Cells.Item(5).Value

            CodeDarman = Me.dgrView.CurrentRow.Cells.Item(0).Value
            NoeKhadamat = Me.dgrView.CurrentRow.Cells.Item(1).Value
            NoeTarefe = Me.dgrView.CurrentRow.Cells.Item(2).Value
            Sharh = Me.dgrView.CurrentRow.Cells.Item(3).Value
            HazineKHadamat = Me.dgrView.CurrentRow.Cells.Item(4).Value
            SahmeDentist = Me.dgrView.CurrentRow.Cells.Item(5).Value


        Catch ex As Exception

            Me.txtCodeDarman.Text = ""
            Me.txtSharh.Text = ""
            Me.txtHazinekhadamat.Text = ""
            Me.txtSahmeDentist.Text = ""

        Finally


        End Try
    End Sub

    Private Sub dgrView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgrView.KeyDown, dgrView.KeyUp
        FillTextBox()
    End Sub

    Private Sub dgrView_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgrView.MouseClick
        FillTextBox()
    End Sub
End Class