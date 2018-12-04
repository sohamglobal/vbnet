Imports System
public Module IfTest

public Sub Main()
        Dim myInput As String
        Dim myInt As Integer

        Console.Write("Please enter a number: ")
        myInput = Console.ReadLine()
        myInt = Convert.ToInt32(myInput)

        If myInt > 0 Then
            Console.WriteLine("Your number {0} is greater than zero.", myInt)
        End If
       
        If myInt < 0 Then
            Console.WriteLine("Your number {0} is less than zero.", myInt)
        End If

        If  Not myInt = 0 Then
            Console.WriteLine("Your number {0} is not equal to zero.", myInt)
        Else
            Console.WriteLine("Your number {0} is equal to zero.", myInt)
        End If

	If myInt < 0 Or myInt = 0 Then
	    Console.WriteLine("Your number {0} is less than or equal to zero.", myInt)
	ElseIf myInt > 0 And myInt <= 10
	    Console.WriteLine("Your number {0} is in the range from 1 to 10.", myInt)
	ElseIf myInt > 10 And myInt <= 20
	    Console.WriteLine("Your number {0} is in the range from 11 to 20.", myInt)
	ElseIf myInt > 20 And myInt <= 30
	    Console.WriteLine("Your number {0} is in the range from 21 to 30.", myInt)
	Else
	    Console.WriteLine("Your number {0} is greater than 30.", myInt)
	End If

    End Sub
End Module


'content of sohamglobal.com