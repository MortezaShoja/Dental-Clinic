Public Class frmRegTiming
    Dim SqlCon As New SQLConnection
    Dim Cmd As SqlClient.SqlCommand
    Dim sdr As SqlClient.SqlDataReader

    Public PersonalID As String
    Private Sub frmRegTiming_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dc As New DateConvertor
        dc.Convertor()
        Me.txty.Text = dc.Hyear
        Me.txtM.Text = dc.Hmonth
        Me.txtD.Text = dc.Hday

    End Sub

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click
        Cmd = New SqlClient.SqlCommand
        Cmd.CommandText = "insert into PersonalTiming (PersonalID,[Date],[Time]) Values ('" & PersonalID & "',N'" & Me.txty.Text + "/" + Me.txtM.Text + "/" + Me.txtD.Text & "',N'" & Me.txtMin.Text.ToString + ":" + Me.txtSec.Text & "')"
        Cmd.Connection = SqlCon.SqlCon

        SqlCon.SqlCon.Open()
        Try
            Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        Finally
            SqlCon.SqlCon.Close()
        End Try

        MessageBox.Show("کلیه اطلاعات با موفقیت ثبت گردید", "ثبت اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        FillGrid()
    End Sub

    Private Sub FillGrid()

        Dim tbl As New DataTable
        Dim dvw As DataView
        Dim b As Boolean



        Cmd = New SqlClient.SqlCommand
        Cmd.CommandText = "select [Time] as 'ساعت',PersonalID as 'کد شناسائی' from PersonalTiming where Date= N'" & Me.txty.Text + "/" + Me.txtM.Text + "/" + Me.txtD.Text & "'"
        Cmd.Connection = SqlCon.SqlCon


        SqlCon.SqlCon.Open()

        sdr = Cmd.ExecuteReader
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
        Me.dbgTimes.DataSource = dvw
        SqlCon.SqlCon.Close()

    End Sub

    Private Sub txtM_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtM.LostFocus
        If Me.txtM.Text.ToString.Length = 1 Then
            Me.txtM.Text = "0" + Me.txtM.Text
        End If
    End Sub

    Private Sub txtD_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtD.LostFocus
        If Me.txtD.Text.ToString.Length = 1 Then
            Me.txtD.Text = "0" + Me.txtD.Text
        End If
    End Sub

    Private Sub txtMin_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMin.LostFocus
        If Me.txtMin.Text.ToString.Length = 1 Then
            Me.txtMin.Text = "0" + Me.txtMin.Text
        End If
    End Sub

    Private Sub txtSec_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSec.LostFocus
        If Me.txtSec.Text.ToString.Length = 1 Then
            Me.txtSec.Text = "0" + Me.txtSec.Text
        End If
    End Sub

    Private Sub txtM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtM.TextChanged, txtD.TextChanged
        FillGrid()
    End Sub
End Class