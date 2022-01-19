Public Class Main
    Dim Path As String

    Private Sub Analizar_Click(sender As Object, e As EventArgs) Handles Analizar.Click
        Dim Grid(13, 0) As String

        'Initialize Head
        Grid(0, 0) = "Location"
        Grid(1, 0) = "Serial"
        Grid(2, 0) = "User"
        Grid(3, 0) = "User ID"

        Grid(4, 0) = "Copy Full Color Single"
        Grid(5, 0) = "Copy Full Color Duplex"
        Grid(6, 0) = "Copy Black Single"
        Grid(7, 0) = "Copy Black Duplex"
        Grid(8, 0) = "Printer Full Color Single"
        Grid(9, 0) = "Printer Full Color Duplex"
        Grid(10, 0) = "Printer Black Single"
        Grid(11, 0) = "Printer Black Duplex"
        Grid(12, 0) = "Scanner"

        Grid(13, 0) = "Partial Price"

        'Get file list
        If Path = "" Then
            MsgBox("Por favor, escoje una ruta.")
            Exit Sub
        End If

        Dim List_Files As String() = IO.Directory.GetFiles(Path, "*.csv")

        'Start progress bar
        Progreso.Width = 1
        Progreso.Visible = True
        Progreso_Etiqueta.Text = "Procesando..."
        Progreso_Etiqueta.Visible = True
        Progreso_Fondo.Visible = True

        Application.DoEvents()

        'Start file analysis
        For i As Integer = 0 To (List_Files.Length - 1)
            'Read current file
            Dim Stream As New IO.StreamReader(List_Files(i))
            Dim CurrentLine As String

            CurrentLine = Stream.ReadLine()
            If Not (CurrentLine Is Nothing) Then
                Dim Array_Line As String() = ParseLine(CurrentLine)

                '----------------------------------------------------------------------------------
                If Array_Line(0) = "Number" And (Array_Line.GetLength(0) = 493 Or
                                                 Array_Line.GetLength(0) = 494 Or
                                                 Array_Line.GetLength(0) = 591 Or
                                                 Array_Line.GetLength(0) = 592) Then
                    Do
                        CurrentLine = Stream.ReadLine()
                        If CurrentLine Is Nothing Then
                            Exit Do
                        End If

                        Array_Line = ParseLine(CurrentLine)

                        'Create user
                        'Array_Line(0) = Array_Line(0).ToUpper()
                        Dim UPos As Integer

                        Dim Column As Integer = Grid.GetLength(0) - 1
                        Dim Row As Integer = Grid.GetLength(1)

                        ReDim Preserve Grid(Column, Row)
                        UPos = Grid.GetLength(1) - 1

                        'Registering Data
                        'Location and Serial
                        Dim Filename As String = FileIO.FileSystem.GetName(List_Files(i))
                        Filename = Filename.Substring(0, Filename.Length - 4)

                        Dim Array_FileInfo As String() = ParseLine(Filename)
                        If Array_FileInfo.GetLength(0) = 2 Then
                            Grid(0, Row) = Array_FileInfo(0)
                            Grid(1, Row) = Array_FileInfo(1)
                        ElseIf Array_FileInfo.GetLength(0) = 1 Then
                            Grid(0, Row) = Array_FileInfo(0)
                            Grid(1, Row) = "NULL"
                        Else
                            Grid(0, Row) = "NULL"
                            Grid(1, Row) = "NULL"
                        End If

                        'User
                        If Array_Line(1) = "" Then Continue Do
                        Grid(2, Row) = Array_Line(1)

                        'UserID
                        Grid(3, Row) = Array_Line(2)

                        'Copy Full Color Single
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(4, UPos))
                            For z As Integer = 12 To 36
                                'n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(409))
                            n += Convert.ToInt32(Array_Line(410))

                            For z As Integer = 413 To 416
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(4, UPos) = n.ToString()
                        End If

                        'Copy Full Color Duplex
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(5, UPos))
                            For z As Integer = 405 To 408
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(411))
                            n += Convert.ToInt32(Array_Line(412))

                            'Save new value
                            Grid(5, UPos) = n.ToString()
                        End If

                        'Copy Black Single
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(6, UPos))
                            For z As Integer = 186 To 210
                                'n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(433))
                            n += Convert.ToInt32(Array_Line(434))

                            For z As Integer = 437 To 440
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(6, UPos) = n.ToString()
                        End If

                        'Copy Black Duplex
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(7, UPos))
                            For z As Integer = 429 To 432
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(435))
                            n += Convert.ToInt32(Array_Line(436))

                            'Save new value
                            Grid(7, UPos) = n.ToString()
                        End If

                        'Printer Full Color Single
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(8, UPos))
                            For z As Integer = 37 To 61
                                'n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(445))
                            n += Convert.ToInt32(Array_Line(446))
                            n += Convert.ToInt32(Array_Line(449))
                            n += Convert.ToInt32(Array_Line(450))

                            For z As Integer = 453 To 456
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(8, UPos) = n.ToString()
                        End If

                        'Printer Full Color Duplex
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(9, UPos))
                            For z As Integer = 441 To 444
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(447))
                            n += Convert.ToInt32(Array_Line(448))
                            n += Convert.ToInt32(Array_Line(451))
                            n += Convert.ToInt32(Array_Line(452))

                            'Save new value
                            Grid(9, UPos) = n.ToString()
                        End If

                        'Printer Black Single
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(10, UPos))
                            For z As Integer = 283 To 307
                                'n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(477))
                            n += Convert.ToInt32(Array_Line(478))
                            n += Convert.ToInt32(Array_Line(481))
                            n += Convert.ToInt32(Array_Line(482))

                            For z As Integer = 485 To 488
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(10, UPos) = n.ToString()
                        End If

                        'Printer Black Duplex
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(11, UPos))
                            For z As Integer = 473 To 477
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(479))
                            n += Convert.ToInt32(Array_Line(480))
                            n += Convert.ToInt32(Array_Line(483))
                            n += Convert.ToInt32(Array_Line(484))

                            'Save new value
                            Grid(11, UPos) = n.ToString()
                        End If

                        'Scanner
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(12, UPos))
                            For z As Integer = 62 To 110
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            For z As Integer = 161 To 185
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            For z As Integer = 332 To 356
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            For z As Integer = 381 To 404
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(12, UPos) = n.ToString()
                        End If
                    Loop

                    '------------------------------------------------------------------------------
                ElseIf Array_Line(0) = "Nombre de Usuario" And (Array_Line.GetLength(0) = 61) Then
                    Do
                        CurrentLine = Stream.ReadLine()
                        If CurrentLine Is Nothing Then
                            Exit Do
                        End If

                        Array_Line = ParseLine(CurrentLine)

                        'Create user
                        'Array_Line(0) = Array_Line(0).ToUpper()
                        Dim UPos As Integer

                        Dim Column As Integer = Grid.GetLength(0) - 1
                        Dim Row As Integer = Grid.GetLength(1)

                        ReDim Preserve Grid(Column, Row)
                        UPos = Grid.GetLength(1) - 1

                        'Registering Data
                        'Location and Serial
                        Dim Filename As String = FileIO.FileSystem.GetName(List_Files(i))
                        Filename = Filename.Substring(0, Filename.Length - 4)

                        Dim Array_FileInfo As String() = ParseLine(Filename)
                        If Array_FileInfo.GetLength(0) = 2 Then
                            Grid(0, Row) = Array_FileInfo(0)
                            Grid(1, Row) = Array_FileInfo(1)
                        ElseIf Array_FileInfo.GetLength(0) = 1 Then
                            Grid(0, Row) = Array_FileInfo(0)
                            Grid(1, Row) = "NULL"
                        Else
                            Grid(0, Row) = "NULL"
                            Grid(1, Row) = "NULL"
                        End If

                        'User
                        Grid(2, Row) = Array_Line(0)

                        'UserID
                        Grid(3, Row) = "NULL"

                        'Copy Full Color Single
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(4, UPos))
                            n += Convert.ToInt32(Array_Line(4))

                            'Save new value
                            Grid(4, UPos) = n.ToString()
                        End If

                        'Copy Full Color Duplex
                        If True Then
                            Grid(5, UPos) = "0"
                        End If

                        'Copy Black Single
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(6, UPos))
                            n += Convert.ToInt32(Array_Line(1))
                            n += Convert.ToInt32(Array_Line(10))

                            'Save new value
                            Grid(6, UPos) = n.ToString()
                        End If

                        'Copy Black Duplex
                        If True Then
                            Grid(7, UPos) = "0"
                        End If

                        'Printer Full Color Single
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(8, UPos))
                            n += Convert.ToInt32(Array_Line(16))

                            'Save new value
                            Grid(8, UPos) = n.ToString()
                        End If

                        'Printer Full Color Duplex
                        If True Then
                            Grid(9, UPos) = "0"
                        End If

                        'Printer Black Single
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(10, UPos))
                            n += Convert.ToInt32(Array_Line(13))

                            'Save new value
                            Grid(10, UPos) = n.ToString()
                        End If

                        'Printer Black Duplex
                        If True Then
                            Grid(11, UPos) = "0"
                        End If

                        'Scanner
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(12, UPos))
                            n += Convert.ToInt32(Array_Line(40))
                            n += Convert.ToInt32(Array_Line(55))
                            n += Convert.ToInt32(Array_Line(37))
                            n += Convert.ToInt32(Array_Line(52))
                            n += Convert.ToInt32(Array_Line(58))

                            'Save new value
                            Grid(12, UPos) = n.ToString()
                        End If
                    Loop

                    '------------------------------------------------------------------------------
                ElseIf Array_Line(0) = "T450SY0U36A" And Array_Line.GetLength(0) = 454 Then
                    Do
                        CurrentLine = Stream.ReadLine()
                        If CurrentLine Is Nothing Then Exit Do
                        CurrentLine = Stream.ReadLine()
                        If CurrentLine Is Nothing Then Exit Do

                        Array_Line = ParseLine(CurrentLine)

                        'Create user
                        'Array_Line(0) = Array_Line(0).ToUpper()
                        Dim UPos As Integer

                        Dim Column As Integer = Grid.GetLength(0) - 1
                        Dim Row As Integer = Grid.GetLength(1)

                        ReDim Preserve Grid(Column, Row)
                        UPos = Grid.GetLength(1) - 1

                        'Registering Data
                        'Location and Serial
                        Dim Filename As String = FileIO.FileSystem.GetName(List_Files(i))
                        Filename = Filename.Substring(0, Filename.Length - 4)

                        Dim Array_FileInfo As String() = ParseLine(Filename)
                        If Array_FileInfo.GetLength(0) = 2 Then
                            Grid(0, Row) = Array_FileInfo(0)
                            Grid(1, Row) = Array_FileInfo(1)
                        ElseIf Array_FileInfo.GetLength(0) = 1 Then
                            Grid(0, Row) = Array_FileInfo(0)
                            Grid(1, Row) = "NULL"
                        Else
                            Grid(0, Row) = "NULL"
                            Grid(1, Row) = "NULL"
                        End If

                        'User
                        Grid(2, Row) = Array_Line(1)

                        'UserID
                        Grid(3, Row) = Array_Line(0)

                        'Copy Full Color Single
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(4, UPos))
                            For z As Integer = 13 To 34
                                'n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(371))
                            n += Convert.ToInt32(Array_Line(372))

                            For z As Integer = 375 To 378
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(4, UPos) = n.ToString()
                        End If

                        'Copy Full Color Duplex
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(5, UPos))
                            For z As Integer = 367 To 370
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(373))
                            n += Convert.ToInt32(Array_Line(374))

                            'Save new value
                            Grid(5, UPos) = n.ToString()
                        End If

                        'Copy Black Single
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(6, UPos))
                            For z As Integer = 169 To 190
                                'n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(395))
                            n += Convert.ToInt32(Array_Line(396))

                            For z As Integer = 399 To 402
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(6, UPos) = n.ToString()
                        End If

                        'Copy Black Duplex
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(7, UPos))
                            For z As Integer = 391 To 394
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(397))
                            n += Convert.ToInt32(Array_Line(398))

                            'Save new value
                            Grid(7, UPos) = n.ToString()
                        End If

                        'Printer Full Color Single
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(8, UPos))
                            For z As Integer = 35 To 56
                                'n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(407))
                            n += Convert.ToInt32(Array_Line(408))
                            n += Convert.ToInt32(Array_Line(411))
                            n += Convert.ToInt32(Array_Line(412))

                            For z As Integer = 415 To 418
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(8, UPos) = n.ToString()
                        End If

                        'Printer Full Color Duplex
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(9, UPos))
                            For z As Integer = 403 To 406
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(409))
                            n += Convert.ToInt32(Array_Line(410))
                            n += Convert.ToInt32(Array_Line(413))
                            n += Convert.ToInt32(Array_Line(414))

                            'Save new value
                            Grid(9, UPos) = n.ToString()
                        End If

                        'Printer Black Single
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(10, UPos))
                            For z As Integer = 257 To 278
                                'n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(395))
                            n += Convert.ToInt32(Array_Line(396))
                            n += Convert.ToInt32(Array_Line(167))
                            n += Convert.ToInt32(Array_Line(168))

                            For z As Integer = 399 To 402
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(10, UPos) = n.ToString()
                        End If

                        'Printer Black Duplex
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(11, UPos))
                            For z As Integer = 391 To 394
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(397))
                            n += Convert.ToInt32(Array_Line(398))

                            'Save new value
                            Grid(11, UPos) = n.ToString()
                        End If

                        'Scanner
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(12, UPos))
                            For z As Integer = 57 To 100
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            For z As Integer = 145 To 166
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            For z As Integer = 301 To 366
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(12, UPos) = n.ToString()
                        End If
                    Loop

                    '------------------------------------------------------------------------------
                ElseIf Array_Line(0) = "Number" And Array_Line.GetLength(0) = 530 Then
                    Do
                        CurrentLine = Stream.ReadLine()
                        If CurrentLine Is Nothing Then
                            Exit Do
                        End If

                        Array_Line = ParseLine(CurrentLine)

                        'Create user
                        'Array_Line(0) = Array_Line(0).ToUpper()
                        Dim UPos As Integer

                        Dim Column As Integer = Grid.GetLength(0) - 1
                        Dim Row As Integer = Grid.GetLength(1)

                        ReDim Preserve Grid(Column, Row)
                        UPos = Grid.GetLength(1) - 1

                        'Registering Data
                        'Location and Serial
                        Dim Filename As String = FileIO.FileSystem.GetName(List_Files(i))
                        Filename = Filename.Substring(0, Filename.Length - 4)

                        Dim Array_FileInfo As String() = ParseLine(Filename)
                        If Array_FileInfo.GetLength(0) = 2 Then
                            Grid(0, Row) = Array_FileInfo(0)
                            Grid(1, Row) = Array_FileInfo(1)
                        ElseIf Array_FileInfo.GetLength(0) = 1 Then
                            Grid(0, Row) = Array_FileInfo(0)
                            Grid(1, Row) = "NULL"
                        Else
                            Grid(0, Row) = "NULL"
                            Grid(1, Row) = "NULL"
                        End If

                        'User
                        Grid(2, Row) = Array_Line(1)

                        'UserID
                        Grid(3, Row) = Array_Line(2)

                        'Copy Full Color Single
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(4, UPos))
                            For z As Integer = 12 To 39
                                'n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(481))
                            n += Convert.ToInt32(Array_Line(482))
                            n += Convert.ToInt32(Array_Line(485))
                            n += Convert.ToInt32(Array_Line(486))

                            For z As Integer = 489 To 492
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(4, UPos) = n.ToString()
                        End If

                        'Copy Full Color Duplex
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(5, UPos))
                            For z As Integer = 477 To 480
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(483))
                            n += Convert.ToInt32(Array_Line(484))
                            n += Convert.ToInt32(Array_Line(487))
                            n += Convert.ToInt32(Array_Line(488))

                            'Save new value
                            Grid(5, UPos) = n.ToString()
                        End If

                        'Copy Black Single
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(6, UPos))
                            For z As Integer = 206 To 233
                                'n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(469))
                            n += Convert.ToInt32(Array_Line(470))

                            For z As Integer = 473 To 476
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(6, UPos) = n.ToString()
                        End If

                        'Copy Black Duplex
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(7, UPos))
                            For z As Integer = 465 To 468
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(471))
                            n += Convert.ToInt32(Array_Line(472))

                            'Save new value
                            Grid(7, UPos) = n.ToString()
                        End If

                        'Printer Full Color Single
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(8, UPos))
                            For z As Integer = 40 To 67
                                'n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(481))
                            n += Convert.ToInt32(Array_Line(482))
                            n += Convert.ToInt32(Array_Line(485))
                            n += Convert.ToInt32(Array_Line(486))

                            For z As Integer = 489 To 492
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(8, UPos) = n.ToString()
                        End If

                        'Printer Full Color Duplex
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(9, UPos))
                            For z As Integer = 477 To 480
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(483))
                            n += Convert.ToInt32(Array_Line(484))
                            n += Convert.ToInt32(Array_Line(487))
                            n += Convert.ToInt32(Array_Line(488))

                            'Save new value
                            Grid(9, UPos) = n.ToString()
                        End If

                        'Printer Black Single
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(10, UPos))
                            For z As Integer = 309 To 336
                                'n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(513))
                            n += Convert.ToInt32(Array_Line(514))
                            n += Convert.ToInt32(Array_Line(517))
                            n += Convert.ToInt32(Array_Line(518))

                            For z As Integer = 521 To 524
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(10, UPos) = n.ToString()
                        End If

                        'Printer Black Duplex
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(11, UPos))
                            For z As Integer = 509 To 512
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(515))
                            n += Convert.ToInt32(Array_Line(516))
                            n += Convert.ToInt32(Array_Line(519))
                            n += Convert.ToInt32(Array_Line(520))

                            'Save new value
                            Grid(11, UPos) = n.ToString()
                        End If

                        'Scanner
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(12, UPos))
                            For z As Integer = 68 To 121
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            For z As Integer = 178 To 205
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            For z As Integer = 362 To 440
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(12, UPos) = n.ToString()
                        End If
                    Loop
                    '------------------------------------------------------------------------------
                ElseIf Array_Line(0) = "Number" And (Array_Line.GetLength(0) = 935) Then
                    Do
                        CurrentLine = Stream.ReadLine()
                        If CurrentLine Is Nothing Then
                            Exit Do
                        End If

                        Array_Line = ParseLine(CurrentLine)

                        'Create user
                        'Array_Line(0) = Array_Line(0).ToUpper()
                        Dim UPos As Integer

                        Dim Column As Integer = Grid.GetLength(0) - 1
                        Dim Row As Integer = Grid.GetLength(1)

                        ReDim Preserve Grid(Column, Row)
                        UPos = Grid.GetLength(1) - 1

                        'Registering Data
                        'Location and Serial
                        Dim Filename As String = FileIO.FileSystem.GetName(List_Files(i))
                        Filename = Filename.Substring(0, Filename.Length - 4)

                        Dim Array_FileInfo As String() = ParseLine(Filename)
                        If Array_FileInfo.GetLength(0) = 2 Then
                            Grid(0, Row) = Array_FileInfo(0)
                            Grid(1, Row) = Array_FileInfo(1)
                        ElseIf Array_FileInfo.GetLength(0) = 1 Then
                            Grid(0, Row) = Array_FileInfo(0)
                            Grid(1, Row) = "NULL"
                        Else
                            Grid(0, Row) = "NULL"
                            Grid(1, Row) = "NULL"
                        End If

                        'User
                        Grid(2, Row) = Array_Line(1)

                        'UserID
                        Grid(3, Row) = Array_Line(2)

                        'Copy Full Color Single
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(4, UPos))
                            For z As Integer = 12 To 37
                                'n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(518))
                            n += Convert.ToInt32(Array_Line(519))

                            For z As Integer = 522 To 525
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(4, UPos) = n.ToString()
                        End If

                        'Copy Full Color Duplex
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(5, UPos))
                            For z As Integer = 514 To 517
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(520))
                            n += Convert.ToInt32(Array_Line(521))

                            'Save new value
                            Grid(5, UPos) = n.ToString()
                        End If

                        'Copy Black Single
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(6, UPos))
                            For z As Integer = 192 To 217
                                'n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(542))
                            n += Convert.ToInt32(Array_Line(543))

                            For z As Integer = 546 To 549
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(6, UPos) = n.ToString()
                        End If

                        'Copy Black Duplex
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(7, UPos))
                            For z As Integer = 538 To 541
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(544))
                            n += Convert.ToInt32(Array_Line(545))

                            'Save new value
                            Grid(7, UPos) = n.ToString()
                        End If

                        'Printer Full Color Single
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(8, UPos))
                            For z As Integer = 38 To 63
                                'n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(566))
                            n += Convert.ToInt32(Array_Line(567))
                            n += Convert.ToInt32(Array_Line(570))
                            n += Convert.ToInt32(Array_Line(571))

                            For z As Integer = 574 To 577
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(8, UPos) = n.ToString()
                        End If

                        'Printer Full Color Duplex
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(9, UPos))
                            For z As Integer = 562 To 565
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(568))
                            n += Convert.ToInt32(Array_Line(569))
                            n += Convert.ToInt32(Array_Line(572))
                            n += Convert.ToInt32(Array_Line(573))

                            'Save new value
                            Grid(9, UPos) = n.ToString()
                        End If

                        'Printer Black Single
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(10, UPos))
                            For z As Integer = 290 To 315
                                'n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(598))
                            n += Convert.ToInt32(Array_Line(599))
                            n += Convert.ToInt32(Array_Line(602))
                            n += Convert.ToInt32(Array_Line(603))

                            For z As Integer = 606 To 609
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(10, UPos) = n.ToString()
                        End If

                        'Printer Black Duplex
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(11, UPos))
                            For z As Integer = 594 To 597
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(600))
                            n += Convert.ToInt32(Array_Line(601))
                            n += Convert.ToInt32(Array_Line(604))
                            n += Convert.ToInt32(Array_Line(605))

                            'Save new value
                            Grid(11, UPos) = n.ToString()
                        End If

                        'Scanner
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(12, UPos))
                            For z As Integer = 64 To 113
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            For z As Integer = 340 To 413
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(12, UPos) = n.ToString()
                        End If
                    Loop

                    '------------------------------------------------------------------------------
                ElseIf Array_Line(0) = "Number" And Array_Line.GetLength(0) = 602 Then
                    Do
                        CurrentLine = Stream.ReadLine()
                        If CurrentLine Is Nothing Then
                            Exit Do
                        End If

                        Array_Line = ParseLine(CurrentLine)

                        'Create user
                        'Array_Line(0) = Array_Line(0).ToUpper()
                        Dim UPos As Integer

                        Dim Column As Integer = Grid.GetLength(0) - 1
                        Dim Row As Integer = Grid.GetLength(1)

                        ReDim Preserve Grid(Column, Row)
                        UPos = Grid.GetLength(1) - 1

                        'Registering Data
                        'Location and Serial
                        Dim Filename As String = FileIO.FileSystem.GetName(List_Files(i))
                        Filename = Filename.Substring(0, Filename.Length - 4)

                        Dim Array_FileInfo As String() = ParseLine(Filename)
                        If Array_FileInfo.GetLength(0) = 2 Then
                            Grid(0, Row) = Array_FileInfo(0)
                            Grid(1, Row) = Array_FileInfo(1)
                        ElseIf Array_FileInfo.GetLength(0) = 1 Then
                            Grid(0, Row) = Array_FileInfo(0)
                            Grid(1, Row) = "NULL"
                        Else
                            Grid(0, Row) = "NULL"
                            Grid(1, Row) = "NULL"
                        End If

                        'User
                        If Array_Line(1) = "" Then Continue Do
                        Grid(2, Row) = Array_Line(1)

                        'UserID
                        Grid(3, Row) = Array_Line(2)

                        'Copy Full Color Single
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(4, UPos))
                            For z As Integer = 12 To 63
                                'n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(418))
                            n += Convert.ToInt32(Array_Line(419))

                            For z As Integer = 422 To 425
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(4, UPos) = n.ToString()
                        End If

                        'Copy Full Color Duplex
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(5, UPos))
                            For z As Integer = 414 To 417
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(420))
                            n += Convert.ToInt32(Array_Line(421))

                            'Save new value
                            Grid(5, UPos) = n.ToString()
                        End If

                        'Copy Black Single
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(6, UPos))
                            For z As Integer = 192 To 217
                                'n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(442))
                            n += Convert.ToInt32(Array_Line(443))

                            For z As Integer = 446 To 449
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(6, UPos) = n.ToString()
                        End If

                        'Copy Black Duplex
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(7, UPos))
                            For z As Integer = 438 To 441
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(444))
                            n += Convert.ToInt32(Array_Line(445))

                            'Save new value
                            Grid(7, UPos) = n.ToString()
                        End If

                        'Printer Full Color Single
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(8, UPos))
                            For z As Integer = 38 To 63
                                'n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(454))
                            n += Convert.ToInt32(Array_Line(455))
                            n += Convert.ToInt32(Array_Line(458))
                            n += Convert.ToInt32(Array_Line(459))

                            For z As Integer = 462 To 465
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(8, UPos) = n.ToString()
                        End If

                        'Printer Full Color Duplex
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(9, UPos))
                            For z As Integer = 450 To 453
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(456))
                            n += Convert.ToInt32(Array_Line(457))
                            n += Convert.ToInt32(Array_Line(460))
                            n += Convert.ToInt32(Array_Line(461))

                            'Save new value
                            Grid(9, UPos) = n.ToString()
                        End If

                        'Printer Black Single
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(10, UPos))
                            For z As Integer = 290 To 315
                                'n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(486))
                            n += Convert.ToInt32(Array_Line(487))

                            For z As Integer = 494 To 497
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(10, UPos) = n.ToString()
                        End If

                        'Printer Black Duplex
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(11, UPos))
                            For z As Integer = 482 To 485
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            n += Convert.ToInt32(Array_Line(488))
                            n += Convert.ToInt32(Array_Line(489))

                            'Save new value
                            Grid(11, UPos) = n.ToString()
                        End If

                        'Scanner
                        If True Then
                            Dim n As Integer

                            n = Convert.ToInt32(Grid(12, UPos))
                            For z As Integer = 64 To 113
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            For z As Integer = 166 To 191
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            For z As Integer = 340 To 413
                                n += Convert.ToInt32(Array_Line(z))
                            Next

                            'Save new value
                            Grid(12, UPos) = n.ToString()
                        End If
                    Loop






                Else
                    MsgBox("El archivo """ + FileIO.FileSystem.GetName(List_Files(i)) + ".csv "" no pudo ser analizado.")
                    'MsgBox(Array_Line.GetLength(0))

                End If
            End If

            Stream.Close()

            'Refresh the progress bar
            Progreso.Width = Progreso_Fondo.Width * (i + 1) / List_Files.Length
            Application.DoEvents()
        Next

        If True Then
            Dim Column As Integer = Grid.GetLength(0) - 1
            Dim Row As Integer = Grid.GetLength(1) + 1

            ReDim Preserve Grid(Column, Row)

            Grid(2, Row) = "Total"

            Dim Total_Values(10) As Integer
            Dim Total As Double = 0
            For r As Integer = 1 To Row - 2
                'Column adding
                For c As Integer = 4 To 13
                    Total_Values(c - 3) += Convert.ToInt32(Grid(c, r))
                Next

                'Partial Total
                Dim Partial_Total As Double =
                    Convert.ToInt32(Grid(4, r)) * Convert.ToDouble(Precio_CopyFullSingle.Text) +
                Convert.ToInt32(Grid(5, r)) * Convert.ToDouble(Precio_CopyFullDuplex.Text) +
                Convert.ToInt32(Grid(6, r)) * Convert.ToDouble(Precio_CopyBlackSingle.Text) +
                Convert.ToInt32(Grid(7, r)) * Convert.ToDouble(Precio_CopyBlackDuplex.Text) +
                Convert.ToInt32(Grid(8, r)) * Convert.ToDouble(Precio_PrintFullSingle.Text) +
                Convert.ToInt32(Grid(9, r)) * Convert.ToDouble(Precio_PrintFullDuplex.Text) +
                Convert.ToInt32(Grid(10, r)) * Convert.ToDouble(Precio_PrintBlackSimple.Text) +
                Convert.ToInt32(Grid(11, r)) * Convert.ToDouble(Precio_PrintBlackDuplex.Text) +
                Convert.ToInt32(Grid(12, r)) * Convert.ToDouble(Precio_Scan.Text)

                Grid(13, r) = """" + Partial_Total.ToString + """"
                Total += Partial_Total
            Next

            For c As Integer = 4 To 12
                Grid(c, Row) = Total_Values(c - 3).ToString
            Next

            Grid(13, Row) = """" + Total.ToString + """"
        End If


        'Save file
        SaveFileDialog.Filter = "Archivos CSV (*.csv)|*.csv"
        SaveFileDialog.ShowDialog()

        If SaveFileDialog.FileName = "" Then
            'End progress bar
            Progreso.Width = 1
            Progreso.Visible = False
            Progreso_Etiqueta.Text = "Completado..."
            Progreso_Fondo.Visible = False

            Exit Sub
        End If

        Try
            Dim Output As New IO.StreamWriter(SaveFileDialog.FileName)
            Dim Line As String

            For Row As Integer = 0 To Grid.GetLength(1) - 1
                Line = ""

                For Column As Integer = 0 To Grid.GetLength(0) - 2
                    Line += Grid(Column, Row) + ";"
                Next
                Line += Grid(Grid.GetLength(0) - 1, Row)

                Output.WriteLine(Line)
            Next

            Output.Close()

            'End progress bar
            Progreso.Width = 1
            Progreso.Visible = False
            Progreso_Etiqueta.Text = "Completado..."
            Progreso_Fondo.Visible = False
        Catch ex As Exception
            MsgBox("Este archivo lo esta utilizando otro programa. Por favor escoja otro nombre.")

            'End progress bar
            Progreso.Width = 1
            Progreso.Visible = False
            Progreso_Etiqueta.Text = ""
            Progreso_Fondo.Visible = False
        End Try
    End Sub

    Private Sub WClose_Click(sender As Object, e As EventArgs) Handles WClose.Click
        End
    End Sub

    Private Sub WMinimize_Click(sender As Object, e As EventArgs) Handles WMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Seleccionar_Click(sender As Object, e As EventArgs) Handles Seleccionar.Click
        FolderDialog.ShowDialog()

        Ruta.Text = FolderDialog.SelectedPath()
        Path = FolderDialog.SelectedPath()
    End Sub

    Private Sub Precio_CopyFullColorSingle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Precio_CopyFullSingle.KeyPress
        Dim C As Integer = Asc(e.KeyChar)

        If C <> 8 Then
            If (C < 48 Or C > 57) And C <> 44 Then e.Handled = True
        End If
    End Sub

    Private Sub Precio_CopyFullColorDuplex_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Precio_CopyFullDuplex.KeyPress
        Dim C As Integer = Asc(e.KeyChar)

        If C <> 8 Then
            If (C < 48 Or C > 57) And C <> 44 Then e.Handled = True
        End If
    End Sub


    Private Sub Precio_CopyBlackSingle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Precio_CopyBlackSingle.KeyPress
        Dim C As Integer = Asc(e.KeyChar)

        If C <> 8 Then
            If (C < 48 Or C > 57) And C <> 44 Then e.Handled = True
        End If
    End Sub

    Private Sub Precio_CopyBlackDuplex_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Precio_CopyBlackDuplex.KeyPress
        Dim C As Integer = Asc(e.KeyChar)

        If C <> 8 Then
            If (C < 48 Or C > 57) And C <> 44 Then e.Handled = True
        End If
    End Sub

    Private Sub Precio_PrintFullColorSingle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Precio_PrintFullSingle.KeyPress
        Dim C As Integer = Asc(e.KeyChar)

        If C <> 8 Then
            If (C < 48 Or C > 57) And C <> 44 Then e.Handled = True
        End If
    End Sub

    Private Sub Precio_PrintFullColorDuplex_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Precio_PrintFullDuplex.KeyPress
        Dim C As Integer = Asc(e.KeyChar)

        If C <> 8 Then
            If (C < 48 Or C > 57) And C <> 44 Then e.Handled = True
        End If
    End Sub

    Private Sub Precio_PrintBlackSimple_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Precio_PrintBlackSimple.KeyPress
        Dim C As Integer = Asc(e.KeyChar)

        If C <> 8 Then
            If (C < 48 Or C > 57) And C <> 44 Then e.Handled = True
        End If
    End Sub

    Private Sub Precio_PrintBlackDuplex_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Precio_PrintBlackDuplex.KeyPress
        Dim C As Integer = Asc(e.KeyChar)

        If C <> 8 Then
            If (C < 48 Or C > 57) And C <> 44 Then e.Handled = True
        End If
    End Sub

    Private Sub Precio_Scan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Precio_Scan.KeyPress
        Dim C As Integer = Asc(e.KeyChar)

        If C <> 8 Then
            If (C < 48 Or C > 57) And C <> 44 Then e.Handled = True
        End If
    End Sub

    Private Sub AnalisisSharpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnalisisSharpToolStripMenuItem.Click
        Dim PathFile As String

        SaveFileDialog.Filter = "Archivos CSV (*.csv)|*.csv"
        OpenFileDialog.ShowDialog()
        PathFile = OpenFileDialog.FileName

        If PathFile = "" Then
            Exit Sub
        End If

        Dim Grid(8, 5) As String

        'Initialize Head
        Grid(0, 0) = "Modo/Tamaño"
        Grid(0, 1) = "Copia Color"
        Grid(0, 2) = "Copia B/N"
        Grid(0, 3) = "Impresion Color"
        Grid(0, 4) = "Impresion B/N"
        Grid(0, 5) = "Escaner"

        Grid(1, 0) = "A3"
        Grid(2, 0) = "A4"
        Grid(3, 0) = "B4"
        Grid(4, 0) = "Carta"
        Grid(5, 0) = "Oficio"
        Grid(6, 0) = "Pliego"

        Grid(7, 0) = "Copias Generadas"
        Grid(7, 2) = "Impresiones Generadas"
        Grid(7, 4) = "Escaneos Generados"
        Grid(8, 0) = "Copias No Generadas"
        Grid(8, 2) = "Impresiones No Generadas"
        Grid(8, 4) = "Escaneos No Generados"

        'Initialize Grid
        For i As Integer = 1 To 6
            For j As Integer = 1 To 4
                Grid(i, j) = "0"
            Next
        Next

        Dim l As Integer = 0

        'Process Sharp File
        Try
            Dim Input As New IO.StreamReader(PathFile)
            Dim CurrentLine As String

            CurrentLine = Input.ReadLine()
            If Not (CurrentLine Is Nothing) Then

                'Transform format
                CurrentLine = CurrentLine.Replace(Chr(34).ToString + Chr(34).ToString, "#")
                CurrentLine = CurrentLine.Replace(Chr(34).ToString, "")
                CurrentLine = CurrentLine.Replace("#", Chr(34).ToString)

                Dim Array_Line As String() = ParseLine(CurrentLine)

                '----------------------------------------------------------------------------------
                If Array_Line(0) = "ID de trabajo" And Array_Line.GetLength(0) = 213 Then
                    Do
                        CurrentLine = Input.ReadLine()
                        If CurrentLine Is Nothing Then
                            Exit Do
                        End If

                        'Transform format
                        CurrentLine = CurrentLine.Replace(Chr(34).ToString + Chr(34).ToString, "#")
                        CurrentLine = CurrentLine.Replace(Chr(34).ToString, "")
                        CurrentLine = CurrentLine.Replace("#", Chr(34).ToString)

                        Array_Line = ParseLine(CurrentLine)

                        'Registering Data
                        Dim Transaction As String = Array_Line(2)
                        If Transaction = "Copiar" Then
                            '------------------------------
                            'Copy Full Color
                            '------------------------------
                            'A3
                            If Array_Line(21) <> "N/A" Then
                                Dim n As Integer

                                n = Convert.ToInt32(Grid(1, 1))
                                n += Convert.ToInt32(Array_Line(21))
                                Grid(1, 1) = n.ToString()
                            End If

                            'A4
                            If Array_Line(25) <> "N/A" Then
                                Dim n As Integer

                                n = Convert.ToInt32(Grid(2, 1))
                                n += Convert.ToInt32(Array_Line(25))
                                Grid(2, 1) = n.ToString()
                            End If

                            'B4
                            If Array_Line(33) <> "N/A" Then
                                Dim n As Integer

                                n = Convert.ToInt32(Grid(3, 1))
                                n += Convert.ToInt32(Array_Line(33))
                                Grid(3, 1) = n.ToString()
                            End If

                            'Carta
                            If Array_Line(53) <> "N/A" Then
                                Dim n As Integer

                                n = Convert.ToInt32(Grid(4, 1))
                                n += Convert.ToInt32(Array_Line(53))
                                Grid(4, 1) = n.ToString()
                            End If

                            'Oficio
                            If Array_Line(49) <> "N/A" Then
                                Dim n As Integer

                                n = Convert.ToInt32(Grid(5, 1))
                                n += Convert.ToInt32(Array_Line(49))
                                Grid(5, 1) = n.ToString()
                            End If

                            'Pliego
                            If Array_Line(45) <> "N/A" Then
                                Dim n As Integer

                                n = Convert.ToInt32(Grid(6, 1))
                                n += Convert.ToInt32(Array_Line(45))
                                Grid(6, 1) = n.ToString()
                            End If

                            '------------------------------
                            'Copy Black
                            '------------------------------
                            'A3
                            If Array_Line(20) <> "N/A" Then
                                Dim n As Integer

                                n = Convert.ToInt32(Grid(1, 2))
                                n += Convert.ToInt32(Array_Line(20))
                                Grid(1, 2) = n.ToString()
                            End If

                            'A4
                            If Array_Line(24) <> "N/A" Then
                                Dim n As Integer

                                n = Convert.ToInt32(Grid(2, 2))
                                n += Convert.ToInt32(Array_Line(24))
                                Grid(2, 2) = n.ToString()
                            End If

                            'B4
                            If Array_Line(32) <> "N/A" Then
                                Dim n As Integer

                                n = Convert.ToInt32(Grid(3, 2))
                                n += Convert.ToInt32(Array_Line(32))
                                Grid(3, 2) = n.ToString()
                            End If

                            'Carta
                            If Array_Line(52) <> "N/A" Then
                                Dim n As Integer

                                n = Convert.ToInt32(Grid(4, 2))
                                n += Convert.ToInt32(Array_Line(52))
                                Grid(4, 2) = n.ToString()
                            End If

                            'Oficio
                            If Array_Line(48) <> "N/A" Then
                                Dim n As Integer

                                n = Convert.ToInt32(Grid(5, 2))
                                n += Convert.ToInt32(Array_Line(48))
                                Grid(5, 2) = n.ToString()
                            End If

                            'Pliego
                            If Array_Line(44) <> "N/A" Then
                                Dim n As Integer

                                n = Convert.ToInt32(Grid(6, 2))
                                n += Convert.ToInt32(Array_Line(44))
                                Grid(6, 2) = n.ToString()
                            End If

                            If Array_Line(168) <> "N/A" And Array_Line(169) <> "N/A" And Array_Line(170) <> "N/A" Then
                                Dim n As Integer

                                'Copias Generadas
                                n = Convert.ToInt32(Grid(7, 1))
                                n += Convert.ToInt32(Array_Line(170)) * Convert.ToInt32(Array_Line(169))
                                Grid(7, 1) = n.ToString()

                                'Copias No Generadas (170-171)
                                n = Convert.ToInt32(Grid(8, 1))
                                n += Convert.ToInt32(Array_Line(12)) -
                                    (Convert.ToInt32(Array_Line(170)) * Convert.ToInt32(Array_Line(169)))
                                'n += Convert.ToInt32(Array_Line(170)) *
                                '    (Convert.ToInt32(Array_Line(168)) - Convert.ToInt32(Array_Line(169)))
                                Grid(8, 1) = n.ToString()
                            End If







                            'Dim x As Integer
                            'x = Convert.ToInt32(Array_Line(20))
                            'x += Convert.ToInt32(Array_Line(24))
                            'x += Convert.ToInt32(Array_Line(32))
                            'x += Convert.ToInt32(Array_Line(52))
                            'x += Convert.ToInt32(Array_Line(48))
                            'x += Convert.ToInt32(Array_Line(44))

                            'Dim z As Integer
                            'z = Convert.ToInt32(Array_Line(170)) * Convert.ToInt32(Array_Line(169))
                            'z += Convert.ToInt32(Array_Line(170)) *
                            '(Convert.ToInt32(Array_Line(168)) - Convert.ToInt32(Array_Line(169)))

                            'If x <> z Then
                            '    MsgBox(Array_Line(0) + ", " + Transaction + "... l=" + (l + 2).ToString + ", x=" + x.ToString + ", z=" + z.ToString)
                            'End If



                        ElseIf Transaction = "Escanear a disco duro" Or
                                   Transaction = "Escaneo a Carpeta de Red" Or
                                   Transaction = "Envío de Fax" Then
                            '------------------------------
                            'Scan
                            '------------------------------
                            If Array_Line(170) <> "N/A" And Array_Line(171) <> "N/A" Then
                                Dim n As Integer

                                'Copias Generadas
                                n = Convert.ToInt32(Grid(7, 5))
                                n += Convert.ToInt32(Array_Line(171))
                                Grid(7, 5) = n.ToString()

                                'Copias No Generadas (170-171)
                                n = Convert.ToInt32(Grid(8, 5))
                                n += Convert.ToInt32(Array_Line(170)) - Convert.ToInt32(Array_Line(171))
                                Grid(8, 5) = n.ToString()
                            End If
                        ElseIf Transaction = "Impresión Directa(Memoria USB)" Or
                                   Transaction = "Imprimir" Or
                                   Transaction = "Imprimir lista" Or
                                   Transaction = "Lista de Impres." Then
                            '------------------------------
                            'Print Full Color
                            '------------------------------
                            'A3
                            If Array_Line(21) <> "N/A" Then
                                Dim n As Integer

                                n = Convert.ToInt32(Grid(1, 3))
                                n += Convert.ToInt32(Array_Line(21))
                                Grid(1, 3) = n.ToString()
                            End If

                            'A4
                            If Array_Line(25) <> "N/A" Then
                                Dim n As Integer

                                n = Convert.ToInt32(Grid(2, 3))
                                n += Convert.ToInt32(Array_Line(25))
                                Grid(2, 3) = n.ToString()
                            End If

                            'B4
                            If Array_Line(33) <> "N/A" Then
                                Dim n As Integer

                                n = Convert.ToInt32(Grid(3, 3))
                                n += Convert.ToInt32(Array_Line(33))
                                Grid(3, 3) = n.ToString()
                            End If

                            'Carta
                            If Array_Line(53) <> "N/A" Then
                                Dim n As Integer

                                n = Convert.ToInt32(Grid(4, 3))
                                n += Convert.ToInt32(Array_Line(53))
                                Grid(4, 3) = n.ToString()
                            End If

                            'Oficio
                            If Array_Line(49) <> "N/A" Then
                                Dim n As Integer

                                n = Convert.ToInt32(Grid(5, 3))
                                n += Convert.ToInt32(Array_Line(49))
                                Grid(5, 3) = n.ToString()
                            End If

                            'Pliego
                            If Array_Line(45) <> "N/A" Then
                                Dim n As Integer

                                n = Convert.ToInt32(Grid(6, 3))
                                n += Convert.ToInt32(Array_Line(45))
                                Grid(6, 3) = n.ToString()
                            End If

                            '------------------------------
                            'Print Black
                            '------------------------------
                            'A3
                            If Array_Line(20) <> "N/A" Then
                                Dim n As Integer

                                n = Convert.ToInt32(Grid(1, 4))
                                n += Convert.ToInt32(Array_Line(20))
                                Grid(1, 4) = n.ToString()
                            End If

                            'A4
                            If Array_Line(24) <> "N/A" Then
                                Dim n As Integer

                                n = Convert.ToInt32(Grid(2, 4))
                                n += Convert.ToInt32(Array_Line(24))
                                Grid(2, 4) = n.ToString()
                            End If

                            'B4
                            If Array_Line(32) <> "N/A" Then
                                Dim n As Integer

                                n = Convert.ToInt32(Grid(3, 4))
                                n += Convert.ToInt32(Array_Line(32))
                                Grid(3, 4) = n.ToString()
                            End If

                            'Carta
                            If Array_Line(52) <> "N/A" Then
                                Dim n As Integer

                                n = Convert.ToInt32(Grid(4, 4))
                                n += Convert.ToInt32(Array_Line(52))
                                Grid(4, 4) = n.ToString()
                            End If

                            'Oficio
                            If Array_Line(48) <> "N/A" Then
                                Dim n As Integer

                                n = Convert.ToInt32(Grid(5, 4))
                                n += Convert.ToInt32(Array_Line(48))
                                Grid(5, 4) = n.ToString()
                            End If

                            'Pliego
                            If Array_Line(44) <> "N/A" Then
                                Dim n As Integer

                                n = Convert.ToInt32(Grid(6, 4))
                                n += Convert.ToInt32(Array_Line(44))
                                Grid(6, 4) = n.ToString()
                            End If

                            If Array_Line(168) <> "N/A" And Array_Line(169) <> "N/A" And Array_Line(170) <> "N/A" Then
                                Dim n As Integer

                                'Impresiones Generadas
                                n = Convert.ToInt32(Grid(7, 3))
                                n += Convert.ToInt32(Array_Line(170)) * Convert.ToInt32(Array_Line(169))
                                Grid(7, 3) = n.ToString()

                                'Impresiones No Generadas
                                n = Convert.ToInt32(Grid(8, 3))
                                n += Convert.ToInt32(Array_Line(12)) -
                                    (Convert.ToInt32(Array_Line(170)) * Convert.ToInt32(Array_Line(169)))
                                'n += Convert.ToInt32(Array_Line(170)) *
                                '    (Convert.ToInt32(Array_Line(168)) - Convert.ToInt32(Array_Line(169)))
                                Grid(8, 3) = n.ToString()
                            End If






                        End If

                        l += 1










                    Loop

                    'Save output file 
                    SaveFileDialog.Filter = "Archivos CSV (*.csv)|*.csv"
                    SaveFileDialog.ShowDialog()

                    If SaveFileDialog.FileName = "" Then
                        Exit Sub
                    End If

                    Try
                        Dim Output As New IO.StreamWriter(SaveFileDialog.FileName)
                        Dim Line As String

                        For Row As Integer = 0 To Grid.GetLength(1) - 1
                            Line = ""

                            For Column As Integer = 0 To Grid.GetLength(0) - 2
                                Line += Grid(Column, Row) + ";"
                            Next
                            Line += Grid(Grid.GetLength(0) - 1, Row)

                            Output.WriteLine(Line)
                        Next

                        Output.Close()
                    Catch ex As Exception
                        MsgBox("#Este archivo lo esta utilizando otro programa. Por favor escoja otro nombre.")
                    End Try





                End If


            End If



            Input.Close()





        Catch ex As Exception
            'MsgBox("Este archivo lo esta utilizando otro programa. Por favor escoja otro nombre.")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Analizar_MouseDown(sender As Object, e As MouseEventArgs) Handles Analizar.MouseDown
        If e.Button = MouseButtons.Right Then
            AnalizarContextMenu.Show(Analizar, e.Location)
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Private Sub Main_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If MoveForm Then
            Me.Location += e.Location - MoveForm_MousePosition
        End If
    End Sub

    Private Sub Main_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Private Sub Main_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = MouseButtons.Left Then MoveForm = False
    End Sub
End Class
