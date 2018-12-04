'Demo program with run time errors

Module Crash
Sub Main()

	Dim nm As String
	Dim mks As Integer

	Console.Write("Enter Name ")


	nm=Console.ReadLine()
	Console.Write("Enter marks ")
	mks=Convert.ToInt32(Console.ReadLine())

	If mks>=35 Then
	Console.WriteLine("{0} you are PASS",nm)
	Else
	Console.WriteLine("{0} you are FAIL",nm)

	End If

End Sub
End Module


'Try entering string in marks, generates a runtime errors and terminates abnormally
'Check Exception handling code in ErrorRemoval.cs
'content of sohamglobal.com