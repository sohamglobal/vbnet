'Example Demostrate using string in switch statement

Imports System

Public Module SwitchTest

   	Public Sub Main()

		Console.Write("Enter country : ")
		Dim myInput As String = Console.ReadLine()

 		'switch with string type

          Select Case myInput            
                Case "india"
                    Console.WriteLine("Capital : NewDelhi")

                Case "america"
                    Console.WriteLine("Capital : Washington DC")
                   
                case "england"
                    Console.WriteLine("Capital : London")
          End Select 
    
	End Sub

End Module


'content of sohamglobal.com