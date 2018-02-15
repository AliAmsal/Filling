Module Module1

    Sub Main()
        Dim name As String = ""
        Dim memberID As Integer = 0

        FileOpen(1, "e:\vbPrac\SportsClubRec.txt", OpenMode.Input)

        While Not EOF(1)
            Input(1, name)
            Input(1, memberID)

            Console.WriteLine("Member Name: " & name)
            Console.WriteLine("Member ID: " & memberID)
        End While
        
        FileClose(1)

        Console.ReadKey()

    End Sub

End Module
