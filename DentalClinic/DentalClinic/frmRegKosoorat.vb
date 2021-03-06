Public Class frmRegKosoorat
    Dim Date1, Day1, FaktorNo, DentistID As String

    Dim SQL As New SQLConnection

    Private Sub frmKosoorat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cmdDentist As New SqlClient.SqlCommand
        cmdDentist.CommandText = "select DentistName from DentistName"
        cmdDentist.Connection = SQL.sqlcon

        SQL.sqlcon.Open()
        Dim sdrDentistName As SqlClient.SqlDataReader = cmdDentist.ExecuteReader

        While sdrDentistName.Read
            Me.cboDentistName.Items.Add(sdrDentistName(0).ToString)
        End While

        SQL.sqlcon.Close()

    End Sub

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click


        Dim Hdate As New DateConvertor
        Hdate.Convertor()
        Date1 = Hdate.Hyear & "/" & Hdate.Hmonth & "/" & Hdate.Hday
        Day1 = Hdate.HweekDay
        '-------------------------------- Get Dentist ID ----------------
        GetDentistID()
        '-------------------------------- Get Faktor No ------------------
        GetFaktorNo()
        '------------------------------ Reg into Hesabdari ---------------------
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "insert into hesabdari (FaktorNo, Date, Day,DentistName,DentistID,kosoorat,Elat) values ( '" & FaktorNo & " ',N'" & Date1 & "',N'" & Day1 & "',N'" & Me.cboDentistName.Text & "','" & DentistID & "','" & -Integer.Parse(Me.txtPrice.Text) & "',N'" & "کسر مبلغ به علت " & Me.txtEllat.Text & "')"
        cmd.Connection = sql.Sqlcon

        sql.Sqlcon.Open()

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = "SELECT * FROM hesabdari"
            Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
            Try
                sdr.Read()
            Catch exx As Exception
                MessageBox.Show(sdr(0).ToString)
            End Try
            MessageBox.Show("خطا در ثبت اطلاعات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            sql.Sqlcon.Close()
        End Try

        RefreshText()
        Me.Close()
    End Sub


    Private Sub GetFaktorNo()

        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "insert into Kosoorat_Fno (DentistName,DentistID,Elat) values ( '" & Me.cboDentistName.Text & "','" & DentistID & "','" & Me.txtEllat.Text & "')"
        cmd.Connection = sql.Sqlcon

        sql.Sqlcon.Open()

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = "SELECT * FROM Kosoorat_Fno"
            Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
            Try
                sdr.Read()
            Catch exx As Exception
                MsgBox("Error")
            End Try
            MessageBox.Show("خطا در ثبت اطلاعات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            sql.Sqlcon.Close()
        End Try
        '------------------------------------
        Dim cmdID As New SqlClient.SqlCommand("SELECT FaktorNo FROM Kosoorat_Fno WHERE DentistName='" & Me.cboDentistName.Text & "' and DentistId='" & DentistID & "' and elat='" & Me.txtEllat.Text & "'", sql.Sqlcon)
        sql.Sqlcon.Open()
        Dim sdrID As SqlClient.SqlDataReader = cmdID.ExecuteReader

        If sdrID.Read Then
            FaktorNo = sdrID(0).ToString
        End If
        SQL.sqlcon.Close()


    End Sub


    Private Sub GetDentistID()

        Dim cmdGetID As New SqlClient.SqlCommand("SELECT ID FROM DentistName WHERE DentistName= N'" & Me.cboDentistName.Text & "'", SQL.sqlcon)
        SQL.sqlcon.Open()
        Dim sdrGetID As SqlClient.SqlDataReader = cmdGetID.ExecuteReader

        If sdrGetID.Read Then
            DentistID = sdrGetID(0).ToString
        End If
        SQL.sqlcon.Close()
    End Sub

    Private Sub RefreshText()
        Dim c As Control
        For Each c In Me.Controls
            If TypeOf c Is TextBox AndAlso c.Text <> "" Then
                c.Text = ""
            End If
        Next
        Me.cboDentistName.Focus()
    End Sub

End Class