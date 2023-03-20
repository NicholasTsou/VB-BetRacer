

Imports System.Security

Module Module3
    Sub Main()
        Dim phonebook(1, 4) As String
        Dim name As String
        Dim number As String
        Dim input As Integer
        Dim input2 As String
        Dim count As Integer = 5
        Dim bool As Boolean = True

        'adding people into array
        phonebook(0, 0) = "Nick "
        phonebook(1, 0) = "514-746-6425"
        phonebook(0, 1) = "Jean Loup "
        phonebook(1, 1) = "514-234-5678"
        phonebook(0, 2) = "Andy "
        phonebook(1, 2) = "514-123-4567"
        phonebook(0, 3) = "Jon "
        phonebook(1, 3) = "514-987-6543"
        phonebook(0, 4) = "Mom "
        phonebook(1, 4) = "514-345-5432"



        While (bool)
            'displaying menu
            Console.WriteLine("-----Phone Book-----" & vbNewLine &
                              "1. Add" & vbNewLine &
                              "2. Edit" & vbNewLine &
                              "3. Delete" & vbNewLine &
                              "4. Display" & vbNewLine &
                              "5. Exit" & vbNewLine)

            'checking if input is a number
            If (Integer.TryParse(Console.ReadLine(), input)) Then
                'if 1 adding user
                If (input = 1) Then
                    Console.WriteLine("Please enter the name you wish to add: ")
                    name = Console.ReadLine()
                    Console.WriteLine("Please enter the number you wish to add: ")
                    number = Console.ReadLine()
                    'checking if input is correct
                    If (IsNumeric(name) = True Or name = "" Or number.Length > 14) Then
                        Console.WriteLine("Invalid Entry.. Please Try again CORRECTLY")
                    Else
                        'resizing the array and adding person
                        ReDim Preserve phonebook(1, count)
                        phonebook(0, count) = name
                        phonebook(1, count) = number
                        count += 1

                    End If

                End If
                'if 2 editing the person
                If (input = 2) Then
                    'showing array to selet person
                    Console.WriteLine("-----Phone Book-----")
                    For a = 0 To phonebook.GetUpperBound(1)
                        Console.WriteLine()
                        For b = 0 To phonebook.GetUpperBound(0)
                            Console.WriteLine(a & ". " & phonebook(b, a))
                        Next

                    Next
                    'choosing the persons id
                    Console.WriteLine()
                    Console.WriteLine("Please select the person you wish to edit (number): ")
                    input2 = Console.ReadLine()
                    'checking if the id is in the phonebook array
                    If (IsNumeric(input2) = False) Then
                        Console.WriteLine("PLEASE ENTER A NUMBER")
                    ElseIf (input2 < 0 Or input2 > count) Then
                        Console.WriteLine("Funny guy.. I dont see that number in the list..")
                    Else
                        'entering new name/number
                        Console.WriteLine()
                        Console.WriteLine("Please enter a new name: ")
                        name = Console.ReadLine()
                        Console.WriteLine("Please enter a new phone number: ")
                        number = Console.ReadLine()

                        If (name = "" Or IsNumeric(number) = False) Then
                            Console.WriteLine("Invalid Entry try again..")
                        Else
                            'taking the id(input2) and replacing what was written using the
                            'new name and number
                            Console.WriteLine(phonebook(0, input2) & " has been edited succesfully")
                            phonebook(0, input2) = name
                            phonebook(1, input2) = number
                        End If

                    End If
                End If
                'if 3 deleting user
                If (input = 3) Then
                    'showing phonebook
                    Console.WriteLine("-----Phone Book-----")
                    For a = 0 To phonebook.GetUpperBound(1)
                        Console.WriteLine()
                        For b = 0 To phonebook.GetUpperBound(0)
                            Console.WriteLine(a & ". " & phonebook(b, a))
                        Next

                    Next
                    'asking to select id to which user want to delete
                    Console.WriteLine()
                    Console.WriteLine("Please select the person you wish to delete (number): ")
                    input2 = Console.ReadLine()
                    'checking if inout is correct
                    If (IsNumeric(input2) = False) Then
                        Console.WriteLine("PLEASE ENTER A NUMBER")
                    ElseIf (input2 < 0 Or input2 > count) Then
                        Console.WriteLine("Funny guy.. I dont see that number in the list..")
                    Else
                        'choosing the user and deleting there input
                        Console.WriteLine()
                        Console.WriteLine(phonebook(0, input2) & " has vanished from thin air...")
                        phonebook(0, input2) = ""
                        phonebook(1, input2) = ""
                    End If

                End If
                'if 4 displaying phonebook
                If (input = 4) Then
                    'display the phonebook
                    Console.WriteLine("-----Phone Book-----")
                    For a = 0 To phonebook.GetUpperBound(1)
                        Console.WriteLine()
                        For b = 0 To phonebook.GetUpperBound(0)
                            Console.WriteLine(a & ". " & phonebook(b, a))
                        Next

                    Next

                End If
                'if 5 closing phonebook
                If (input = 5) Then

                    Console.WriteLine("Thank you for using my Phonebook.. :)")
                    bool = False
                End If
            Else
                Console.WriteLine("Please enter a NUMBER you see in the list..")

                End If

        End While

    End Sub
End Module
