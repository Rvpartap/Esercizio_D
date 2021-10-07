Imports System

Module Program
    Sub Main()
        Dim anni As Integer
        Console.WriteLine("Buongiorno, Quanti anni hai? ")
        anni = Console.ReadLine
        If anni >= 18 Then
            Console.WriteLine("Hai " & anni & " anni, allora sei Maggiorenne!")
        Else
            Console.WriteLine("Hai " & anni & " anni, allora sei Minorenne!")
        End If
        Console.ReadLine()
    End Sub
End Module
