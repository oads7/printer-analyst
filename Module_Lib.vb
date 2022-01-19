Module Module_Lib

    Public Function ParseLine(Line As String) As String()
        Dim Array(-1) As String
        Dim Size As Integer = Line.Length()

        Dim Ignore_all As Integer = False
        Dim Quotes As Integer = False

        Dim Start As Integer = 0

        For i As Integer = 0 To Size - 1
            Select Case Line(i)
                Case Chr(34)
                    Ignore_all = Not Ignore_all
                    Quotes = True
                Case ","c, ";"c
                    If Not Ignore_all Then
                        'Take item
                        Dim d As Integer = Array.GetLength(0)
                        ReDim Preserve Array(d)

                        If Quotes Then
                            Array(d) = Line.Substring(Start + 1, i - Start - 2)
                            Quotes = False
                        Else
                            Array(d) = Line.Substring(Start, i - Start)
                        End If

                        Start = i + 1
                    End If
            End Select
        Next

        'Take last item
        Dim e As Integer = Array.GetLength(0)
        ReDim Preserve Array(e)

        If Quotes Then
            Array(e) = Line.Substring(Start + 1, Size - Start - 2)
        Else
            Array(e) = Line.Substring(Start, Size - Start)
        End If

        Return Array
    End Function

    Public Function ParseFilename(Filename As String) As String()
        Dim Array(-1) As String
        Dim Size As Integer = Filename.Length()

        Dim Ignore_all As Integer = False
        Dim Quotes As Integer = False

        Dim Start As Integer = 0

        For i As Integer = 0 To Size - 1
            Select Case Filename(i)
                Case Chr(34)
                    Ignore_all = Not Ignore_all
                    Quotes = True
                Case "-"c
                    If Not Ignore_all Then
                        'Take item
                        Dim d As Integer = Array.GetLength(0)
                        ReDim Preserve Array(d)

                        If Quotes Then
                            Array(d) = Filename.Substring(Start + 1, i - Start - 2)
                            Quotes = False
                        Else
                            Array(d) = Filename.Substring(Start, i - Start)
                        End If

                        Start = i + 1
                    End If
            End Select
        Next

        'Take last item
        Dim e As Integer = Array.GetLength(0)
        ReDim Preserve Array(e)

        If Quotes Then
            Array(e) = Filename.Substring(Start + 1, Size - Start - 2)
        Else
            Array(e) = Filename.Substring(Start, Size - Start)
        End If

        Return Array
    End Function

    Public Function FindUser(ByRef Grid As String(,), User As String) As Integer
        Dim r As Integer = -1

        For i As Integer = 1 To Grid.GetLength(1) - 1
            'Find the match name
            If Grid(0, i) = User Then
                r = i
                Exit For
            End If
        Next

        Return r
    End Function

End Module
