Module Module1
    'brooks keller
    '10/4/23
    'excer 1: c to f convert
    Sub Main()
        Dim c As Double
        Dim f As Double

        Console.WriteLine("Brooks Keller" & vbNewLine)

        Console.Write("enter a temperature in celsius and i will convert it to fahrenheit >> ")
        c = Console.ReadLine
        f = (c * 1.8) + 32
        Console.Write(c & " degrees celsius converted to fahrenheit is " & f.ToString("N2"))
        Console.WriteLine()

    End Sub

End Module
