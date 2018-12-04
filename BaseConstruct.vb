'Demo program on constructor behavior during inheritance and "base" keyword

Imports System

Module BaseConstruct

Public Class One

	Public Sub New()
	Console.WriteLine("Empty constructor of base")
	End Sub

	Public Sub New(ByVal nm As String)
	Console.WriteLine("welcome {0} to parameterized constructor of base...",nm)
	End Sub


	Public Sub DispOne()

	Console.WriteLine("One ran successfully...")

	End Sub
End Class


Class Two
Inherits One

	Public Sub New()
	Console.WriteLine("Empty constructor of derived")
	End Sub


	Public Sub New(ByVal nm As String)
	MyBase.New(nm)
	Console.WriteLine("dear {0},running parameterized constructor of derived...",nm)
	End Sub

	Public Sub DispTwo()

	Console.WriteLine("Two ran successfully ...")

	End Sub

End Class

Sub Main()
	'Dim x As Two=New Two()
	Dim x As Two=New Two("praffull")
	x.DispOne()
	x.DispTwo()

End Sub
End Module




'content of sohamglobal.com