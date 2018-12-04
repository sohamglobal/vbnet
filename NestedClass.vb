'Demo program on nested classes
Imports System

Class Outer
	Public Sub ShowOuter()
		Console.WriteLine("outer tested ok..")
	End Sub
	Public Class Inner
		Public Sub ShowInner()	
			Console.WriteLine("inner tested ok..")
		End Sub
	End Class
End Class



Module NestedClass
	Sub Main()
	Dim inobj As New Outer.Inner
	inobj.ShowInner()
	Dim outobj As Outer=New Outer()
	outobj.ShowOuter()
	End Sub
End Module

'content of sohamglobal.com