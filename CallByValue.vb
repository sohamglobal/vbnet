'Demo program on Call by value


Module CallByValue

Sub Main()

	Dim n As Integer
	n=15
	Manipulate(n)

	Console.WriteLine("Value of n is {0}",n)
End Sub

Private  Sub Manipulate(ByVal a As Integer)
	a+=10
End Sub
End Module

'content of sohamglobal.com