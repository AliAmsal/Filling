Module Module1

    Sub Main()
        Dim mname As String = ""
        Dim mID As Integer = 0
        Dim searchName As String
        Dim isfound As Boolean

        FileOpen(1, "e:\vbPrac\SportsClubRec.txt", OpenMode.Input)

        Console.Write("Enter member name to search: ")
        searchName = Console.ReadLine

        While Not EOF(1) And isfound = False

            If searchName = name Then
                Console.WriteLine("Member Name: " & mname)
                Console.WriteLine("Member ID: " & mID)
                isfound = True
            End If
        End While
        If isfound = False Then
            Console.WriteLine("Record not found")
        End If
        FileClose(1)

        Console.ReadKey()

    End Sub

End Module
