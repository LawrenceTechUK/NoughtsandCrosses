Module Module1
    Dim pXr As Integer
    Dim pXc As Integer
    Dim picked As Boolean = False
    Dim p1Sym As String
    Dim p2Sym As String
    Dim currentPlayer As Integer
    Dim win As Boolean = False
    Dim winner As String

    Sub Main()
        Dim grid(2, 2) As String
        Dim name1 As String
        Dim name2 As String
        If win = False Then
            Console.WriteLine("Whats your name player 1?")
            name1 = Console.ReadLine()
            While Len(name1) = 0
                Console.WriteLine("INVALID INPUT. RENTER NAME:")
                name1 = Console.ReadLine()
            End While
            Console.WriteLine("whats your name player 2?")
            name2 = Console.ReadLine()
            While Len(name2) = 0
                Console.WriteLine("INVALID INPUT. RENTER NAME:")
                name2 = Console.ReadLine()
            End While
        End If
        Console.WriteLine("What would you like to do: ")
        Console.WriteLine("1. play")
        Console.WriteLine("2. load a win")
        Console.WriteLine("3. save a win")
        Dim uchoice As Integer = Console.ReadLine()

        Select Case uchoice
            Case 1
                playGame(grid)
            Case 2
                loadAWin()
            Case 3
                saveAWin(name1, name2, grid)
        End Select
        Console.ReadLine()

    End Sub

    Sub playGame(grid)
        If picked = False Then
            pickSymbols(grid)
        End If
        If picked = True Then
            Console.WriteLine("you are in the play game sub")
            grid(0, 0) = "-"
            grid(0, 1) = "-"
            grid(0, 2) = "-"
            grid(1, 0) = "-"
            grid(1, 1) = "-"
            grid(1, 2) = "-"
            grid(2, 0) = "-"
            grid(2, 1) = "-"
            grid(2, 2) = "-"
            For f As Integer = 0 To 2
                For i As Integer = 0 To 2
                    Console.Write(grid(f, i))
                Next
                Console.WriteLine()
            Next
            updateGameGrid(grid)
            placeSymbol(grid)

            Console.ReadLine()
        End If

    End Sub
    Dim ful As Boolean = False
    Sub placeSymbol(grid)
        Dim s As Integer
        While win = False
            While ful = False
                For o As Integer = 0 To 2
                    For i As Integer = 0 To 2
                        If grid(i, o) = "O" Then
                            s = s + 1
                        End If
                        If grid(i, o) = "X" Then
                            s = s + 1
                        End If
                    Next
                Next
                If ful = 9 Then
                    Console.WriteLine("no moves can be made game is over")
                    win = True
                    ful = True
                End If
                If win = False Then
                    checkForWin(grid)
                End If
                If currentPlayer = 0 Then
                    placeSymbolX(grid)
                End If
                If currentPlayer = 1 Then
                    placeSymbolO(grid)
                End If
            End While
        End While
    End Sub
    Sub checkForWin(grid)
        For o As Integer = 0 To 2
            If (grid(o, 0) = "X" And grid(o, 1) = "X" And grid(o, 2) = "X" Or grid(0, o) = "X" And grid(1, o) = "X" And grid(2, o) = "X") = True Then
                win = True
                winner = "X"
            End If
            If (grid(o, 0) = "O" And grid(o, 1) = "O" And grid(o, 2) = "O" Or grid(0, o) = "O" And grid(1, o) = "O" And grid(2, o) = "O") = True Then
                win = True
                winner = "O"
            End If
        Next
        If win = True Then
            Console.WriteLine(winner & "won!!")
            Main()
        End If
    End Sub
    Sub placeSymbolX(grid)
        While win = False
            Console.WriteLine("What is the X cord collum row number. ")
            pXr = Console.ReadLine()
            Dim d As Integer = 0
            Dim A As Boolean = False
            While A = False
                While d < 3
                    'If pXr = 0 Then
                    '    While pXr = 0
                    '        Console.WriteLine("INVALID INPUT. INPUT = 0. RENTER: ")
                    '        pXr = Console.ReadLine()
                    '    End While
                    'Else
                    d = d + 1
                    'End If
                    Dim p As Boolean = True
                    'If pXr.length() > 1 Then
                    '    While pXr.length() > 2
                    '        Console.WriteLine("INVALID INPUT. INPUT > 1. RENTER: ")
                    '        pXr = Console.ReadLine()
                    '    End While
                    'Else
                    '    d = d + 1
                    'End If
                    d = d + 1

                    If Len(pXr) = 0 Then
                        While Len(pXr) = 0
                            Console.WriteLine("INVALID INPUT. INPUT > 1. RENTER: ")
                            pXr = Console.ReadLine()
                        End While
                    Else
                        d = d + 1
                    End If
                End While
                Console.WriteLine("What is the X cord collum number. ")
                pXc = Console.ReadLine()
                Dim s As Integer = 0
                While s < 3
                    'If pXc = 0 Then
                    '    While pXc = 0
                    '        Console.WriteLine("INVALID INPUT. INPUT = 0. RENTER: ")
                    '        pXc = Console.ReadLine()
                    '    End While
                    'Else
                    s = s + 1
                    'End If
                    'If pXr.length() > 1 Then
                    '    While pXc.length() > 1
                    '        Console.WriteLine("INVALID INPUT. INPUT > 1. RENTER: ")
                    '        pXc = Console.ReadLine()
                    '    End While
                    'Else
                    '    s = s + 1
                    'End If
                    s = s + 1

                    If Len(pXc) = 0 Then
                        While Len(pXc) = 0
                            Console.WriteLine("INVALID INPUT. INPUT > 1. RENTER: ")
                            pXc = Console.ReadLine()
                        End While
                    Else
                        s = s + 1
                    End If
                End While

                If d = 3 Then
                    ''put the users x  in the cord place row collum 
                    Dim checked As Boolean = False
                    While checked = False
                        If grid(pXc, pXr) = "X" Then
                            Console.WriteLine("You cant place that their theis allrady a thing their so you have to rechose. ")
                            checked = True
                            A = False
                        End If
                        If grid(pXc, pXr) = "-" Then
                            checked = True
                            A = True
                            grid(pXc, pXr) = "X"
                            currentPlayer = 1
                            updateGameGrid(grid)

                        End If
                    End While
                End If
            End While
        End While


    End Sub
    Sub placeSymbolO(grid)
        While win = False
            Console.WriteLine("Ok, now its player O's turn")
            Dim A As Boolean = False
            While A = False
                Console.WriteLine("What is the X cord collum row number. ")
                pXr = Console.ReadLine()
                Dim d As Integer = 0
                While d < 3
                    'If pXr = 0 Then
                    '    While pXr = 0
                    '        Console.WriteLine("INVALID INPUT. INPUT = 0. RENTER: ")
                    '        pXr = Console.ReadLine()
                    '    End While
                    'Else
                    d = d + 1
                    'End If
                    Dim p As Boolean = True
                    'If pXr.length() > 1 Then
                    '    While pXr.length() > 2
                    '        Console.WriteLine("INVALID INPUT. INPUT > 1. RENTER: ")
                    '        pXr = Console.ReadLine()
                    '    End While
                    'Else
                    '    d = d + 1
                    'End If
                    d = d + 1

                    If Len(pXr) = 0 Then
                        While Len(pXr) = 0
                            Console.WriteLine("INVALID INPUT. INPUT > 1. RENTER: ")
                            pXr = Console.ReadLine()
                        End While
                    Else
                        d = d + 1
                    End If
                End While
                Console.WriteLine("What is the X cord collum number. ")
                pXc = Console.ReadLine()
                Dim s As Integer = 0
                While s < 3
                    'If pXc = 0 Then
                    '    While pXc = 0
                    '        Console.WriteLine("INVALID INPUT. INPUT = 0. RENTER: ")
                    '        pXc = Console.ReadLine()
                    '    End While
                    'Else
                    s = s + 1
                    'End If
                    'If pXr.length() > 1 Then
                    '    While pXc.length() > 1
                    '        Console.WriteLine("INVALID INPUT. INPUT > 1. RENTER: ")
                    '        pXc = Console.ReadLine()
                    '    End While
                    'Else
                    '    s = s + 1
                    'End If
                    s = s + 1

                    If Len(pXc) = 0 Then
                        While Len(pXc) = 0
                            Console.WriteLine("INVALID INPUT. INPUT > 1. RENTER: ")
                            pXc = Console.ReadLine()
                        End While
                    Else
                        s = s + 1
                    End If
                End While

                If d = 3 Then
                    ''put the users x  in the cord place row collum 
                    Dim checked As Boolean = False
                    While checked = False
                        If grid(pXc, pXr) = "X" Then
                            Console.WriteLine("You cant place that their theis allrady a thing their so you have to rechose. ")
                            checked = True
                            A = False
                        End If
                        If grid(pXc, pXr) = "-" Then
                            checked = True
                            A = True
                            grid(pXc, pXr) = "O"
                            currentPlayer = 0
                            updateGameGrid(grid)

                        End If
                    End While

                End If
            End While
        End While


    End Sub
    Sub updateGameGrid(ByRef grid)
        Console.Clear()
        For f As Integer = 0 To 2
            For i As Integer = 0 To 2
                Console.Write(grid(f, i))
            Next
            Console.WriteLine()
        Next
        Console.WriteLine()
        placeSymbol(grid)
    End Sub
    Sub pickSymbols(grid)
        While picked = False
            Dim avSym(2) As String
        avSym(1) = "X"
        avSym(2) = "Y"
        Console.WriteLine("avaliable symbols are: ")
        For i As Integer = 1 To 2
            Console.WriteLine(avSym(i))
        Next
        Console.WriteLine("player one what symbol do you want? ")
        p1Sym = Console.ReadLine()
        If Len(p1Sym) = 0 Then
            While Len(p1Sym) = 0
                Console.WriteLine("INVALID INPUT. INPUT LEN = 0. RENTER: ")
                p1Sym = Console.ReadLine()
            End While
        End If
        If Len(p1Sym) > 1 Then
            While Len(p1Sym) > 0
                Console.WriteLine("INVALID INPUT. INPUT LEN > 1. RENTER: ")
                p1Sym = Console.ReadLine()
            End While
        End If
        Console.WriteLine("player two what symbol do you want? ")
        p2Sym = Console.ReadLine()
        If Len(p2Sym) = 0 Then
            While Len(p2Sym) = 0
                Console.WriteLine("INVALID INPUT. INPUT LEN = 0. RENTER: ")
                p2Sym = Console.ReadLine()
            End While
        End If
        If Len(p2Sym) > 1 Then
            While Len(p2Sym) > 0
                Console.WriteLine("INVALID INPUT. INPUT LEN > 1. RENTER: ")
                p2Sym = Console.ReadLine()
            End While
        End If
        If p2Sym = p1Sym Then
            While p2Sym = p1Sym
                Console.WriteLine("INVALID INPUT. That symbol has allready been chosen. RENTER: ")
                p2Sym = Console.ReadLine()
            End While
        End If
            picked = True
        End While
        If picked = True Then
            playGame(grid)
        End If
        Console.ReadLine()
    End Sub
    Sub loadAWin()
        Console.WriteLine("You clicked option: 2. This will load the last winning grid.")
        Console.WriteLine()
        If IO.File.Exists("\\cc4sjd8\19015107$\Computer Science\2 - Programing\0andX\last.win") Then
            Dim r As IO.TextReader = New IO.StreamReader("\\cc4sjd8\19015107$\Computer Science\2 - Programing\0andX\last.win")
            Dim loadA As String() = loadA.ReadLine().Split(",")
            Dim loadB As New List(Of List(Of String))
            For I As Int16 = 0 To 2
            Next
        End If
    End Sub
    Sub saveAWin(ByRef name1, name2, grid)
        Console.WriteLine("You clicked option: 3. This will save the winning grid.")
        Dim r As IO.TextWriter = New IO.StreamWriter("\\cc4sjd8\19015107$\Computer Science\2 - Programing\0andX\last.win")
        r.WriteLine("players " & name1 & " | " & name2)
        r.WriteLine("symbols " & p1Sym & " | " & p2Sym)
        Dim xx As String
        For b As Integer = 0 To 2
            For c As Integer = 0 To 2
                If b = 2 And c = 2 Then
                    xx = xx & grid(b, c)
                Else
                    xx = xx & grid(b, c) & ","
                End If
            Next
        Next
        r.WriteLine(xx)
        r.Close()
        Console.WriteLine("dun")
    End Sub

End Module
