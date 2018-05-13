Public Class frmLogin
    Dim User, Password, Moaref As String
    Dim Admin, Locked, Co As Boolean

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        If Me.txtU.Text = "" And Me.txtP.Text = "" Then
            Me.txtU.Focus()
        Else
            Dim frm As New frmParent
            Dim SQL As New SQLConnection

            Dim cmd As New SqlClient.SqlCommand("SELECT username,password,administrator,locked FROM login WHERE username= N'" & txtU.Text & "' AND password= N'" & txtP.Text & "'", SQL.SqlCon)


            SQL.sqlcon.Open()
            Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader

            If sdr.Read Then
                User = sdr(0).ToString
                Password = sdr(1).ToString
                Admin = sdr(2).ToString
                Locked = sdr(3).ToString
            End If

            If Locked = False Then
                If User = txtU.Text AndAlso Password = txtP.Text Then

                    If Admin = True Then

                        frmParent.TabBimaran.Hide()
                        frmParent.TabManaging.Show()
                        frmParent.TabMoaref.Show()
                        frmParent.TabPezeshk.Show()
                        frmParent.TabReport.Show()
                        frmParent.TabSooratHesab.Show()
                        frmParent.TabTarefe.Show()

                    Else

                        frmParent.TabBimaran.Show()
                        frmParent.TabManaging.Hide()
                        frmParent.TabMoaref.Hide()
                        frmParent.TabPezeshk.Hide()
                        frmParent.TabReport.Show()
                        frmParent.TabSooratHesab.Show()
                        frmParent.TabTarefe.Hide()

                    End If

                    frmParent.Show()
                    frmParent.txtUserName.Text = Me.txtU.Text
                    frmParent.Co = Co
                    frmParent.Moaref = Moaref

                    Me.Visible = False
                Else
                    cmdRefresh()
                End If
                SQL.SqlCon.Close()
            Else
                MessageBox.Show("کلمه عبور شما مسدود می باشد" & vbCrLf & " تماس بگیرید" + " IT " + "لطفاً جهت کسب اطلاعات بیشتر با واحد" & vbCrLf & vbCrLf & "Info@ParmisShop.com                          ", "محدودیت ورود", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                cmdRefresh()
            End If


        End If
    End Sub

    Private Sub cmdRefresh()
        Dim c As Control
        For Each c In Me.Controls
            If TypeOf c Is TextBox AndAlso c.Text <> "" Then
                c.Text = ""
            End If
        Next
        txtU.Focus()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Application.Exit()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Hdate As New DateConvertor
        Hdate.Convertor()
        Me.lbldate.Text = Hdate.HweekDay + "  " + Hdate.Hyear + "/" + Hdate.Hmonth + "/" + Hdate.Hday
    End Sub
End Class

