Module Module1

    Sub Main()
        Dim name As String = ""
        Dim memberID As Integer = 0

        Console.WriteLine("Enter Member Name: ")
        name = Console.ReadLine
        Console.WriteLine("Enter Member ID: ")
        memberID = Console.ReadLine

        FileOpen(1, "e:\vbPrac\SportsClubRec.txt", OpenMode.Append)
        WriteLine(1, name)
        WriteLine(1, memberID)

        FileClose(1)


    End Sub

End Module
