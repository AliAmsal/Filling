Module Module1

    Sub Main()
        Dim name As String = ""
        Dim memberID As Integer = 0
        Dim telephoneNo As String = ""
        Dim memDate As Date

        FileOpen(1, "e:\vbPrac\SportsClubRec.txt", OpenMode.Input)
        FileOpen(2, "e:\vbPrac\temp.txt", OpenMode.Output)

        While Not EOF(1)
            Input(1, name)
            Input(1, memberID)

            Console.WriteLine("MemberName:" & name)
            Console.WriteLine("MemberID:" & memberID)


            Console.WriteLine("Enter Telephone Number: ")
            telephoneNo = Console.ReadLine
            Console.WriteLine("Enter Membership Date: ")
            memDate = Console.ReadLine

            WriteLine(2, name)
            WriteLine(2, memberID)
            WriteLine(2, telephoneNo)
            WriteLine(2, memDate)

        End While

        FileClose(1)
        FileClose(2)

        My.Computer.FileSystem.DeleteFile("e:\vbPrac\SportsClubRec.txt")
        My.Computer.FileSystem.RenameFile("e:\vbPrac\temp.txt", "SportsClubRec.txt")


    End Sub

End Module
