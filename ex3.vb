Module ex3
    'brooks keller
    '10/4/23
    'ex 3: byte converter
    Sub main()
        Dim input As String
        Dim valid As String
        Dim kb, mb, gb As Double
        Dim bytes As Double

        Console.WriteLine("Brooks Keller" & vbNewLine)

        Console.WriteLine("please enter a number of bytes, and i will convert it to kilobytes, megabytes, and gigabytes")
        Console.WriteLine("* note for simplicity sake, KB = 1000 bytes, MB = 1000KB and GB = 1000MB" & vbNewLine)

        Console.Write("please enter a large number of bytes >> ")
        input = Console.ReadLine
        valid = Double.TryParse(input, bytes)

        kb = bytes / 1000
        mb = bytes / 1000000
        gb = bytes / 1000000000.0

        Console.WriteLine(bytes & " bytes equals " & kb.ToString("N3") & "KB")
        Console.WriteLine(bytes & " bytes equals " & mb.ToString("N3") & "MB")
        Console.WriteLine(bytes & " bytes equals " & gb.ToString("N3") & "GB")
        Console.WriteLine()
    End Sub
End Module
