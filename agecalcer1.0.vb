    Public Function agecalcer(day As String, month As String, year As String) As String
        Dim yas As Single = 0
        For dogumyili As Short = Short.Parse(year) To Short.Parse(DateTime.Today.Year.ToString) - 1
            yas = yas + 1
        Next
        For dogumgunu As Byte = Byte.Parse(day) To Byte.Parse(DateTime.Today.Day.ToString) - 1
            yas = yas + 0.01
        Next
        For dogumayi As Byte = Byte.Parse(month) To Byte.Parse(DateTime.Today.Month.ToString) - 1
            yas = yas + 0.1
        Next
        Dim hesaplanmisyas As String = ""
        Dim indeks As Byte = 0
        For Each int As Char In yas.ToString
            hesaplanmisyas += int
            If int = "," Then
                hesaplanmisyas += yas.ToString()(indeks + 1)
                Exit For
            End If
            indeks = indeks + 1
        Next
        Return "Your Age = " + hesaplanmisyas.Replace(",", ".")
    End Function
