'Demo program on creating array in C#


Module Arrays
Sub Main()

	Dim i As Integer
	Dim arr(9) As Integer



	Console.WriteLine("Enter 10 numbers -")
	For i=0 To 9
		arr(i)=Convert.ToInt32(Console.ReadLine())
	Next

	Console.WriteLine("Arrays -")
	For Each n As Integer In arr
	Console.WriteLine("{0}",n)
	Next




End Sub
End Module



'content of sohamglobal.com