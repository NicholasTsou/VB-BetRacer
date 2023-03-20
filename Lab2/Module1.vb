Imports System.ComponentModel

Module Module1


    Sub main()
        Dim answer As String
        Dim item As String
        Dim price As String
        Dim rating As String
        Dim count As Integer = 4
        Dim array(2, 4) As String
        Dim bool As Boolean = True

        'adding items to the array
        array(0, 0) = "Kebab"
        array(1, 0) = "9.99"
        array(2, 0) = "9"

        array(0, 1) = "Beef"
        array(1, 1) = "4.99"
        array(2, 1) = "7"

        array(0, 2) = "Chicken"
        array(1, 2) = "6.00"
        array(2, 2) = "9"

        array(0, 3) = "Beer"
        array(1, 3) = "1.99"
        array(2, 3) = "10"

        'shows the menu 
        Console.WriteLine("Menu: " & vbNewLine)
        For a = 0 To array.GetUpperBound(1)
            For b = 0 To array.GetUpperBound(0)
                Console.WriteLine(array(b, a) & " ")
            Next
            Console.WriteLine()
        Next

        While (bool)
            'asking user to add an ite,
            Console.WriteLine("Would you like to add an item? y/n")
            answer = Console.ReadLine().ToLower
            If (answer = "y") Then

                'asking user for name,price,rating
                Console.WriteLine("Enter new item name: ")
                item = Console.ReadLine()

                Console.WriteLine("Enter new item price: ")
                price = Console.ReadLine()

                Console.WriteLine("Enter new item rating: ")
                rating = Console.ReadLine()

                'checking if input is correct or not
                If (item = "" Or IsNumeric(item) = True Or IsNumeric(price) = False Or price = "" Or rating = "" Or IsNumeric(rating) = False) Then
                    Console.WriteLine("Try again smarty pants")
                Else
                    'resizing  the array and adding a new input
                    ReDim Preserve array(2, count)
                    array(0, count) = item
                    array(1, count) = price
                    array(2, count) = rating
                    count += 1
                    'reshowing the array
                    Console.WriteLine("Menu: " & vbNewLine)
                    For a = 0 To array.GetUpperBound(1)
                        For b = 0 To array.GetUpperBound(0)
                            Console.WriteLine(array(b, a) & " ")
                        Next
                        Console.WriteLine()
                    Next
                End If
            ElseIf (answer = "n") Then
                Console.WriteLine("Thank you LEAVE NOW")
                bool = False
            Else
                Console.WriteLine("Try again dumbass")
            End If
        End While
    End Sub



End Module
