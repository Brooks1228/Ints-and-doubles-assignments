Module ex2
    'brooks keller
    '10/4/23
    'excer 2: tip calc
    Sub Main()
        Console.WriteLine("Brooks Keller" & vbNewLine)
        Dim input As String
        Dim valid As String
        Dim ten, fifteen, twenty As Double
        Dim bill As Double

        Console.Write("please enter the total bill and i will calculate your tip >> ")
        input = Console.ReadLine
        valid = Double.TryParse(input, bill)

        Console.Write("for a bill of " & bill.ToString("C2") & " the tip rates are as follows:")

        ten = bill * 0.1
        fifteen = bill * 0.15
        twenty = bill * 0.2

        Console.WriteLine(vbNewLine)
        Console.WriteLine("".PadLeft(22, "-"))
        Console.WriteLine("| " & "percent".PadRight(8) & " | " & "amount".PadRight(7) & " |")
        Console.WriteLine("".PadLeft(22, "-"))
        Console.WriteLine("| " & "10%".PadRight(8) & " | " & ten.ToString("C2").PadRight(7) & " |")
        Console.WriteLine("| " & "20%".PadRight(8) & " | " & fifteen.ToString("C2").PadRight(7) & " |")
        Console.WriteLine("| " & "30%".PadRight(8) & " | " & twenty.ToString("C2").PadRight(7) & " |")
        Console.WriteLine("".PadLeft(22, "-"))
    End Sub
End Module
