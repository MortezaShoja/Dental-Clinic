Public Class frmRegDentistName
    Dim SQL As New SQLConnection
    Dim CmdD As String
    Dim cmdNon As New SqlClient.SqlCommand
    Private ID As String



    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        If Me.btnRegister.Text = "جدید" Then

            Me.txtDentistName.Text = ""
            Me.dgrDentistName.Enabled = False
            Me.btnRegister.Text = "ثبت"
        Else
            Me.btnRegister.Text = "جدید"


            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "insert into DentistName (DentistName,[Percent],ID) Values (N'" & Me.txtDentistName.Text & "','" & Integer.Parse(Me.txtPercent.Text) & "',newid())"
            cmd.Connection = SQL.sqlcon

            SQL.sqlcon.Open()
            Try
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            Finally
                SQL.sqlcon.Close()
            End Try

            MessageBox.Show("کلیه اطلاعات با موفقیت ثبت گردید", "ثبت اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Me.dgrDentistName.Enabled = True
            FillGrid()
        End If
    End Sub



    Private Sub frmRegDentistName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CmdD = " SELECT DentistName as 'نام دندانپزشک',[Percent] as 'درصد',ID as 'کد شناسنائی' from dentistName"
        FillGrid()
  FillTextBox

    End Sub

    Private Sub FillGrid()

        Dim tbl As New DataTable
        Dim dvw As DataView
        Dim b As Boolean


        
        Dim cmd As New SqlClient.SqlCommand(CmdD, SQL.sqlcon)

        SQL.sqlcon.Open()

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
        Me.dgrDentistName.DataSource = dvw
        SQL.sqlcon.Close()

    End Sub


    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click


        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "Update DentistName set DentistName= N'" & Me.txtDentistName.Text & "',[Percent]= '" & Integer.Parse(Me.txtPercent.Text) & "' where ID='" & ID & "'"

        cmd.Connection = SQL.sqlcon

        SQL.sqlcon.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        Finally
            SQL.sqlcon.Close()
        End Try

        FillGrid()

        MessageBox.Show("تغییرات با موفقیت ثبت شد", "ثبت تغییرات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
    End Sub



    Private Sub NonQuary()

        cmdNon.Connection = SQL.sqlcon

        SQL.sqlcon.Open()
        Try
            cmdNon.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)

        Finally
            SQL.sqlcon.Close()
        End Try


        MessageBox.Show("تغییرات با موفقیت ثبت شد", "ثبت تغییرات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        cmdNon.CommandText = "Delete DentistName where DentistName= N'" & Me.txtDentistName.Text & "'"
        NonQuary()
        frmRegDentistName_Load(sender, e)

    End Sub

    Private Sub dgrDentistName_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrDentistName.CellContentClick
FillTextBox
    End Sub

    Private Sub dgrDentistName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgrDentistName.KeyDown, dgrDentistName.KeyUp
        FillTextBox()
    End Sub

    Private Sub dgrDentistName_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgrDentistName.MouseClick
FillTextBox
    End Sub

    Private Sub FillTextBox()
        Try
            Me.txtDentistName.Text = Me.dgrDentistName.CurrentRow.Cells.Item(0).Value
            Me.txtPercent.Text = Me.dgrDentistName.CurrentRow.Cells.Item(1).Value
            ID = Me.dgrDentistName.CurrentRow.Cells.Item(2).Value
        Catch ex As Exception
            Me.txtDentistName.Text = ""
            Me.txtPercent.Text = ""
        End Try


    End Sub
End Class