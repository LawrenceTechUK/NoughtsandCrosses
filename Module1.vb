Module Module1
    Dim pXr As Integer
    Dim pXc As Integer
    Dim picked As Boolean = False
    Dim p1Sym As String
    Dim p2Sym As String

    Sub Main()
        Dim grid(2, 2) As String


        Console.WriteLine("Whats your name player 1?")
        Dim name1 As String = Console.ReadLine()
        While Len(name1) = 0
            Console.WriteLine("INVALID INPUT. RENTER NAME:")
            name1 = Console.ReadLine()
        End While
        Console.WriteLine("whats your name player 2?")
        Dim name2 As String = Console.ReadLine()
        While Len(name2) = 0
            Console.WriteLine("INVALID INPUT. RENTER NAME:")
            name2 = Console.ReadLine()
        End While

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
                saveAWin()
        End Select
        Console.ReadLine()

    End Sub

    Sub playGame(grid)
        pickSymbols()
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
        placeSymbol()

        Console.ReadLine()

    End Sub
    Sub placeSymbol(grid)
        Console.WriteLine("What is the X cord collum row number. ")
        pXr = Console.ReadLine()
        Dim d As Integer = 0
        While d < 3
            If pXr = 0 Then
                While pXr = 0
                    Console.WriteLine("INVALID INPUT. INPUT = 0. RENTER: ")
                    pXr = Console.ReadLine()
                End While
            Else
                d = d + 1
            End If
            If Len(pXr) > 1 Then
                While Len(pXr) > 1
                    Console.WriteLine("INVALID INPUT. INPUT > 1. RENTER: ")
                    pXr = Console.ReadLine()
                End While
            Else
                d = d + 1
            End If

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
            If pXc = 0 Then
                While pXc = 0
                    Console.WriteLine("INVALID INPUT. INPUT = 0. RENTER: ")
                    pXc = Console.ReadLine()
                End While
            Else
                s = s + 1
            End If
            If Len(pXc) > 1 Then
                While Len(pXc) > 1
                    Console.WriteLine("INVALID INPUT. INPUT > 1. RENTER: ")
                    pXc = Console.ReadLine()
                End While
            Else
                s = s + 1
            End If

            If Len(pXc) = 0 Then
                While Len(pXc) = 0
                    Console.WriteLine("INVALID INPUT. INPUT > 1. RENTER: ")
                    pXc = Console.ReadLine()
                End While
            Else
                s = s + 1
            End If
        End While

        If d = 3 & s = 3 Then
            ''put the users x  in the cord place row collum 
            grid(pXc, pXr) = "X"
            updateGameGrid(grid)
        End If



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
    End Sub
    Sub pickSymbols()
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
        If picked = True Then
            playGame()
        End If
        Console.ReadLine()
    End Sub
    Sub loadAWin()

    End Sub
    Sub saveAWin()

    End Sub

End Module
