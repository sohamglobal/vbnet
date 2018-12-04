'Demo on foreach statement
Imports System
Module ForEachTest
	Sub Main()
		Dim nm(4) As String
		Dim j As Integer
		For j=0 To 4
		nm(j)=Console.ReadLine()
		Next
		For Each s As String In nm
		Console.WriteLine("{0}",s)
		Next
	End Sub
End Module


'content of sohamglobal.com