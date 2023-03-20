Module Module2 '

    Sub Main()
        Dim input As Integer = 0
        Dim tens As Integer = 0
        Dim ones As Integer = 0
        Dim hundred As Integer = 0
        Dim bool As Boolean = True
        Dim array1() As String = {" ", "One", "Two", "Three", "Four", "Five", "Six", "Seven",
                 "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
                   "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
        Dim array2() As String = {" ", " ", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
        Dim array3() As String = {" ", " One Hundred ", " Two Hundred ", " Three Hundred ", " Four Hundred ", " Five Hundred ",
            " Six Hundred ", " Seven Hundred ", " Eight Hundred ", " Nine Hundred "}
        While (bool)
            'asking user for input
            Console.WriteLine("Please Enter the number you wish to convert to words: 0/1000")

            'checking if input is a number
            If (Integer.TryParse(Console.ReadLine(), input)) Then
                Select Case input
                    'checks to see what number has been inputed by the user
                    'does the math equation to divide and grab the remainder of said input
                    'and the grabs it from the arrays and displays it
                    Case 0
                        Console.WriteLine("Number: " & input & " Word:  Zero")
                    Case 1 To 19
                        Console.WriteLine("Number: " & input & " Word: " & array1(input))
                    Case 20 To 99
                        tens = (input \ 10 Mod 10)
                        ones = input Mod 10
                        Console.WriteLine("Number: " & input & " Word: " & array2(tens) & " " & array1(ones))
                    Case 100 To 199
                        hundred = (input \ 100)
                        tens = (input \ 10 Mod 10)
                        ones = input Mod 10
                        'Console.Write("Test" & hundred)
                        Console.WriteLine("Number: " & input & " Word: " & " One Hundred And " & array2(tens) & array1(ones))
                    Case 200 To 999
                        hundred = (input \ 100)
                        tens = (input \ 10 Mod 10)
                        ones = input Mod 10
                        ' Console.Write("Test" & hundred & tens & ones)
                        Console.WriteLine("Number: " & input & " Word: " & array3(hundred) & " And " & array2(tens) & array1(ones))
                    Case 1000
                        Console.WriteLine("Number: " & input & " Word: " & " One Thousand ")



                End Select

            Else
                Console.WriteLine("Please enter a VALID number")
            End If

        End While
    End Sub

End Module
