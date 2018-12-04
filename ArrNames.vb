'Demo program on string array

Imports System
Module ArrNames
Sub Main()

	Dim nm(9) As String
	Dim sval As String
	Dim i As Integer


	For i=0 To 9
		Console.Write("Enter name ")
	nm(i)=Console.ReadLine()
	Next

	Console.Write("Enter name to be searched ")
	sval=Console.ReadLine()


	For i=0 To 9
	If sval=nm(i) Then
		Console.WriteLine("Name found at {0}",i+1)

	End If
	Next


End Sub
End Module
'sequential search on string array