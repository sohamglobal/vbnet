'Demo program on delegates

Module DelegateTest

	Public Delegate Function MyDelegate(ByVal p As Integer,ByVal q As Integer) As Integer


Sub Main()


	Dim MyMethod As MyDelegate
	Dim  op1 As New GrupOp1


	MyMethod =AddressOf  GrupOp1.Add
	Dim res As Integer=MyMethod(23,56)
	Console.WriteLine("sum is {0}",res)

	MyMethod =AddressOf  GrupOp1.Subtract
	res=MyMethod(84,75)
	Console.WriteLine("subtraction is {0}",res)

MyMethod =AddressOf  GrupOp1.CalcBill
res=MyMethod(4570,245)
Console.WriteLine("Net Bill is {0}",res)

End Sub

Class GrupOp1

Shared Function Add(ByVal a As Integer,ByVal b As Integer) As Integer
Return a+b
End Function



Shared Function Subtract(ByVal a As Integer,ByVal b As Integer) As Integer
Return a-b
End Function


Shared Function CalcBill(ByVal amt As Integer,ByVal disc As Integer) As Integer

Dim net As Integer
net=amt-disc
Return net

End Function

End Class

End Module






'content of sohamglobal.com