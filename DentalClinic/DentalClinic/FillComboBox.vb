Public Class FillComboBox
    Private SQL As SQLConnection
    Private Arr() As String
    Private sdr As SqlClient.SqlDataReader
    Private I As Integer = 0
    Private Temp As String

    Public Function Generate(ByVal DatabaseName, ByVal CommandText)
        SQL = New SQLConnection

        Dim cmd As New SqlClient.SqlCommand("SELECT " & CommandText & " From " & DatabaseName & "", SQL.SqlCon)
        SQL.SqlCon.Open()
        sdr = cmd.ExecuteReader

        While sdr.Read
            Temp += sdr(0) & "~"
            I += 1
        End While
        SQL.SqlCon.Close()
        Try
            Arr = Mid(Temp, 1, Temp.Length - 1).Split("~")
        Catch ex As Exception
            Arr = "".Split(".")
        End Try

        Return Arr
    End Function


End Class
