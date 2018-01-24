Public Class dateHelper

    Function getYears As List(Of Integer)
        Dim currentYear As Integer = Date.Now.Year
        Dim yearList As New List(Of Integer)

        For i As Integer = 0 To 10
            yearList.Add(currentYear - i)
        Next

        return yearList 
    End Function

    Function getMonths() As List(Of String)

        Dim monthList As New List(Of String)
        monthList.Add("January")
        monthList.Add("February")
        monthList.Add("March")
        monthList.Add("April")
        monthList.Add("May")
        monthList.Add("June")
        monthList.Add("July")
        monthList.Add("August")
        monthList.Add("September")
        monthList.Add("October")
        monthList.Add("November")
        monthList.Add("December")
        Return monthList

    End Function

End Class
