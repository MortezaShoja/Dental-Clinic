Public Class frmRegNoeTarefe

    Dim SQL As New SQLConnection

    Private Sub btnRegNoeTarefe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegNoeTarefe.Click


        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "insert into noetarefe (noetarefe) values(N'" & Me.txtNoeTarefe.Text & "')"
        cmd.Connection = Sql.sqlcon

        Sql.sqlcon.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = "SELECT * FROM noetarefe where noetarefe= N'" & Me.txtNoeTarefe.Text & "'"
            Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
            Try
                sdr.Read()
            Catch exx As Exception
                MsgBox("Error")
            End Try

        Finally
            Sql.sqlcon.Close()
        End Try
        Me.Close()

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If MessageBox.Show("اطلاعات مورد نظر حذف شود", "حذف اطلاعات", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) = Windows.Forms.DialogResult.OK Then
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "Delete NoeTarefe where NoeTarefe= N'" & Me.txtNoeTarefe.Text & "'"
            cmd.Connection = Sql.sqlcon

            Sql.sqlcon.Open()
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception

            Finally
                Sql.sqlcon.Close()
            End Try

            Me.txtNoeTarefe.Text = String.Empty

            FillGrid()

            MessageBox.Show("حذف اطلاعات با موفقیت انجام شد", "حذف اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

        End If
    End Sub


    Private Sub dgrView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrView.CellContentClick
        Me.txtNoeTarefe.Text = Me.dgrView.CurrentRow.Cells.Item(0).Value
    End Sub

    Private Sub dgrView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgrView.KeyDown, dgrView.KeyUp
        Me.txtNoeTarefe.Text = Me.dgrView.CurrentRow.Cells.Item(0).Value
    End Sub

    Private Sub dgrView_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgrView.MouseClick
        Try
            Me.txtNoeTarefe.Text = Me.dgrView.CurrentRow.Cells.Item(0).Value
        Catch ex As Exception
            Me.txtNoeTarefe.Text = ""
        End Try

    End Sub


    Private Sub FillGrid()

        Dim tbl As New DataTable
        Dim dvw As DataView
        Dim b As Boolean



        Dim CommandTExt As String = "SELECT NoeTarefe as 'نوع تعرفه' from NoeTarefe"



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


    Private Sub frmRegNoeTarefe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillGrid()
    End Sub
End Class