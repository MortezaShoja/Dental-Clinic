Public Class CodeGenerator
    Public Function GetFamiliCode()

        Dim DC As New DateConvertor
        DC.Convertor()

        Return (Mid(DC.Hyear, 3, 4) + DC.Hmonth + DC.Hday + Now.TimeOfDay.Hours.ToString + Now.TimeOfDay.Minutes.ToString + Now.TimeOfDay.Seconds.ToString)
    End Function
    Public Function GetParvandeNo()

        Dim DC As New DateConvertor
        DC.Convertor()

        Return (Now.TimeOfDay.Hours.ToString + Now.TimeOfDay.Minutes.ToString + Now.TimeOfDay.Seconds.ToString + " " + Mid(DC.Hyear, 3, 4) + DC.Hmonth + DC.Hday)
    End Function
End Class
