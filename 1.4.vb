Module Module1

    Sub Main()
        Dim name As String = ""
        Dim memberID As Integer = 0

        FileOpen(1, "e:\vbPrac\SportsClubRec.txt", OpenMode.Input)
        FileOpen(2, "e:\vbPrac\temp.txt", OpenMode.Output)

        While Not EOF(1)
            Input(1, name)
            Input(1, memberID)

            WriteLine(2, name)
            WriteLine(2, memberID)
        End While

        Console.WriteLine("Enter member name: ")
        name = Console.ReadLine
        Console.WriteLine("Enter member ID: ")
        memberID = Console.ReadLine

        WriteLine(2, name)
        WriteLine(2, memberID)

        FileClose(1)
        FileClose(2)

        My.Computer.FileSystem.DeleteFile("e:\vbPrac\SportsClubRec.txt")
        My.Computer.FileSystem.RenameFile("e:\vbPrac\temp.txt", "SportsClubRec.txt")

        Console.ReadKey()

    End Sub

End Module
