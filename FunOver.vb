'Demo program on function overloading

Imports System

Class Calculate
	Private sum As Integer
	Public Sub CalcSum(a As Integer,b As Integer)
	sum=a+b
	End Sub

	Public Sub CalcSum(a As Integer,b As Integer,c As Integer)
	sum=a+b+c
	End Sub

	Public Sub CalcSum(a As Integer,b As Integer,c As Integer,d As Integer)
	sum=a+b+c+d
	End Sub

	Public Sub ShowSum()
	Console.WriteLine("sum is {0}",sum)
	End Sub
End Class

Module FunOver
	Sub Main()
	Dim cal As New Calculate
	cal.CalcSum(23,45,12)
	cal.ShowSum()
	cal.CalcSum(44,78)
	cal.ShowSum()
	End Sub
End Module


'content of sohamglobal.com














	