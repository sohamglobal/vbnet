'Demo program on Linear sort

Imports System

Module  ArrayLinearSort
Sub Main()
	Dim i,j As Integer
	Dim tmp As Integer
	Dim arr(9) As Integer
	
	Console.WriteLine("Enter 10 numbers -")

	For i=0 To 9
	arr(i)=Convert.ToInt32(Console.ReadLine())
	
	Next

	 For i = 0 To 8  
		For j = i+1 To 9
		If arr(j) < arr(i) Then
		tmp=arr(j)
		arr(j)=arr(i)
		arr(i)=tmp
		
		End If
		Next
	
	Next


	Console.WriteLine("The sorted Array -")
	 For Each n1 As Integer In arr
	Console.WriteLine("{0}",n1)

	Next
	
End Sub
End Module

'content of sohamglobal.com
