Module ex4
    'brooks keller
    '10/4/23
    'ex 4: currency converter
    Sub main()
        Console.WriteLine("Brooks Keller" & vbNewLine)
        Console.WriteLine("Currency Exchange" & vbNewLine)
        Dim input, valid As String
        Dim us, euro, bp, rupee, cad, btc As Double
        Dim euroEX, bpEX, rupeeEX, cadEX, btcEX As Double
        Console.Write("please enter a US dollar amound and i will convert it to several other currencies >> ")
        input = Console.ReadLine
        valid = Double.TryParse(input, us)
        Console.WriteLine()
        Console.WriteLine(us.ToString("C2") & " US dollars is worth the following:")

        'defining exchange rate values to make it a bit easier for myself
        euroEX = 0.95299
        bpEX = 0.82537
        rupeeEX = 83.2668
        cadEX = 1.3724
        btcEX = 0.00004

        euro = euroEX * us
        bp = bpEX * us
        rupee = rupeeEX * us
        cad = cadEX * us
        btc = btcEX * us
        Console.WriteLine("".PadRight(59, "-"))
        Console.WriteLine("| " & "Currency".PadRight(20) & " | " & "Exchance Rate".PadRight(15) & " | " & "Value".PadRight(15) & "|")
        Console.WriteLine("".PadRight(59, "-"))
        Console.WriteLine("| " & "Euro".PadRight(20) & " | " & euroEX.ToString.PadRight(15) & " | " & euro.ToString.PadRight(15) & "|")
        Console.WriteLine("| " & "British Pounds".PadRight(20) & " | " & bpEX.ToString.PadRight(15) & " | " & bp.ToString.PadRight(15) & "|")
        Console.WriteLine("| " & "Indian Rupee".PadRight(20) & " | " & rupeeEX.ToString.PadRight(15) & " | " & rupee.ToString.PadRight(15) & "|")
        Console.WriteLine("| " & "Canadian Dollar".PadRight(20) & " | " & cadEX.ToString.PadRight(15) & " | " & cad.ToString.PadRight(15) & "|")
        Console.WriteLine("| " & "BitCoin".PadRight(20) & " | " & btcEX.ToString("N5").PadRight(15) & " | " & btc.ToString.PadRight(15) & "|")
        Console.WriteLine("".PadRight(59, "-"))
    End Sub
End Module
