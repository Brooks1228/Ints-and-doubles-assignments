Module ex5
    'brooks keller
    'ex 5: batting averages
    '10/5/23
    Sub main()
        'defining variables
        Dim input, valid As String
        Dim p1, p2, p3 As String
        Dim bat1, hit1, bat2, hit2, bat3, hit3 As Integer
        Dim av1, av2, av3 As Double

        Console.WriteLine("brooks keller" & vbNewLine)

        Console.WriteLine("please tell me the baseball players with the top 3 averages of all time." & vbNewLine)

        'player 1
        Console.Write("please enter the name of player 1 >> ")
        p1 = Console.ReadLine
        Console.Write("please enter player 1's at bats >> ")
        input = Console.ReadLine
        valid = Double.TryParse(input, bat1)
        Console.Write("please enter player 1's at hits >> ")
        input = Console.ReadLine
        valid = Double.TryParse(input, hit1)
        Console.WriteLine()

        'player 2
        Console.Write("please enter the name of player 2 >> ")
        p2 = Console.ReadLine
        Console.Write("please enter player 2's at bats >> ")
        input = Console.ReadLine
        valid = Double.TryParse(input, bat2)
        Console.Write("please enter player 2's at hits >> ")
        input = Console.ReadLine
        valid = Double.TryParse(input, hit2)
        Console.WriteLine()

        'player 3
        Console.Write("please enter the name of player 3 >> ")
        p3 = Console.ReadLine
        Console.Write("please enter player 3's at bats >> ")
        input = Console.ReadLine
        valid = Double.TryParse(input, bat3)
        Console.Write("please enter player 3's at hits >> ")
        input = Console.ReadLine
        valid = Double.TryParse(input, hit3)
        Console.WriteLine()


        'getting the averages before making the graph
        av1 = hit1 / bat1
        av2 = hit2 / bat2
        av3 = hit3 / bat3

        Console.WriteLine("thank you. i have updated my records. here's what i've got" & vbNewLine)
        Console.WriteLine("   baseball's top 3 batting averages of all time")

        'writing out the table
        Console.WriteLine("".PadRight(52, "-"))
        Console.WriteLine("| " & "Player".PadRight(15) & " | " & "At Bats".PadRight(8) & " | " & "Hits".PadRight(8) & " | " & "Average".PadRight(8) & " |")
        Console.WriteLine("".PadRight(52, "-"))
        Console.WriteLine("| " & p3.PadRight(15) & " | " & bat1.ToString.PadRight(8) & " | " & hit1.ToString.PadRight(8) & " | " & av1.ToString("N3").PadRight(8) & " |")
        Console.WriteLine("| " & p2.PadRight(15) & " | " & bat2.ToString.PadRight(8) & " | " & hit2.ToString.PadRight(8) & " | " & av2.ToString("N3").PadRight(8) & " |")
        Console.WriteLine("| " & p3.PadRight(15) & " | " & bat3.ToString.PadRight(8) & " | " & hit3.ToString.PadRight(8) & " | " & av3.ToString("N3").PadRight(8) & " |")
        Console.WriteLine("".PadRight(52, "-"))
    End Sub
End Module
