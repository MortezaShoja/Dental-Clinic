Public Class frmRegUsers
    Dim SQL As New SQLConnection

    Private Sub btnRegNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegNewUser.Click

        Dim SQL As New SQLConnection
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "insert into Login (UserName,Password,Administrator,Locked) values('" & Me.txtUserN.Text & "','" & Me.txtPass.Text & "','" & Me.chkAdmin.Checked & "','" & Me.chkLocked.Checked & "')"
        cmd.Connection = SQL.sqlcon

        SQL.sqlcon.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = "SELECT * FROM Login where UserName= '" & Me.txtUserN.Text & "'"
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
        Me.txtUserN.Focus()


    End Sub

    Private Sub lblAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAdmin.Click
        If Me.chkAdmin.Checked = True Then
            Me.chkAdmin.Checked = False
        Else
            Me.chkAdmin.Checked = True
        End If
    End Sub

    Private Sub lblLocked_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLocked.Click
        If Me.chkLocked.Checked = True Then
            Me.chkLocked.Checked = False
        Else
            Me.chkLocked.Checked = True
        End If
    End Sub

    Private Sub FillGrid()

        Dim tbl As New DataTable
        Dim dvw As DataView
        Dim b As Boolean

        Dim CommandText As String = "select UserName,Password,Administrator,Locked from login"


        Dim cmd As New SqlClient.SqlCommand(CommandTExt, SQL.sqlcon)

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
        Me.dgrUsers.DataSource = dvw
        SQL.sqlcon.Close()

    End Sub

    Private Sub frmRegUsers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        FillGrid()

    End Sub

    Private Sub dgrUsers_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrUsers.CellClick
        FillTextBox()
    End Sub

    Private Sub dgrUsers_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrUsers.CellContentClick

        FillTextBox()

    End Sub

    Private Sub dgrUsers_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgrUsers.KeyDown, dgrUsers.KeyUp

        FillTextBox()

    End Sub

    Private Sub dgrUsers_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrUsers.GotFocus
        FillTextBox()
    End Sub
    Private Sub FillTextBox()

        Try
            Me.txtUserN.Text = Me.dgrUsers.CurrentRow.Cells.Item(0).Value
            Me.txtPass.Text = Me.dgrUsers.CurrentRow.Cells.Item(1).Value
            Me.chkAdmin.Checked = Me.dgrUsers.CurrentRow.Cells.Item(2).Value
            Me.chkLocked.Checked = Me.dgrUsers.CurrentRow.Cells.Item(3).Value
        Catch ex As Exception

            Me.txtUserN.Text = ""
            Me.txtPass.Text = ""
            Me.chkAdmin.Checked = False
            Me.chkLocked.Checked = False


        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim cmd As New SqlClient.SqlCommand
        Dim Adm, Lock As Integer
        If Me.chkAdmin.Checked = True Then
            Adm = 1
        Else
            Adm = 0
        End If

        If Me.chkLocked.Checked = True Then
            Lock = 1
        Else
            Lock = 0
        End If




        cmd.CommandText = "Update Login  set Password='" & Me.txtPass.Text & "',Administrator='" & Adm & "',Locked='" & Lock & "' where UserName= '" & Me.txtUserN.Text & "'"
        cmd.Connection = SQL.sqlcon
        MessageBox.Show("ثبت کاربر با موفقیت انجام شد", "ثبت کاربر", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        SQL.sqlcon.Open()
        Try
            cmd.ExecuteNonQuery()

        Catch ex As Exception

            MessageBox.Show(ex.Message.ToString & vbCrLf, "خطا در ثبت کاربر", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SQL.sqlcon.Close()
            FillGrid()
        End Try

    End Sub


End Class