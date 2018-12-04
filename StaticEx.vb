'Example Demostrate shared Static Function

Imports System

Class TestStat
	Public Sub Show()
		Console.WriteLine("Simple function tested ok")
	End Sub
	Public Shared Sub Display()
		Console.WriteLine("Static function tested ok")
	End Sub
End Class

Public Module StaticEx

    Public Sub Main()
	Dim ts As TestStat=New TestStat()
	ts.Show()

	' ts.Display() not allowed
	TestStat.Display()
    End Sub

End Module


'content of sohamglobal.com