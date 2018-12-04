'Demo program on interfaces
Imports System

Interface Bank
	Sub ShowAmount(bal As Double)
End Interface

Interface Finance
	Sub ShowLoan(sal As Double)
End Interface


Class Money 
	Implements Bank,Finance
	Dim amount As Double
	Dim loan As Double
	Public Sub ShowAmount(bal As Double) Implements Bank.ShowAmount
		amount=bal+(bal*7/100)
		Console.WriteLine("total amount will be {0}",amount)
	End Sub

	Public Sub ShowLoan(sal As Double) Implements Finance.ShowLoan
		loan=sal*25
		Console.WriteLine("total loan you can get is {0}",loan)
	End Sub

	Public Sub ShowMess()
		Console.WriteLine("Try cross platform .NET core 2.0 on Linux")
	End Sub
End Class


Module InterfaceTest
	Sub Main()
	Dim m As New Money
	m.ShowLoan(7500)
	m.ShowAmount(12900)
        m.ShowMess()
	End Sub
End Module

'content of sohamglobal.com