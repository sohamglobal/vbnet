'Demo program on abstract class,protected member and this keyword


Imports System
Module AbstractTest
MustInherit Class MyName
	Protected  nm as String
	Public MustOverride Sub ShowName()


	Public Sub TestFun()
	Console.WriteLine("normal function in abstract class tested ok...")
	End Sub
End Class




Class MyCity 
Inherits MyName
	Private Dim cit as String	
	Public Sub GetName(ByVal nm as String)
	Me.nm=nm
	End Sub
	Public Sub ShowCity(ByVal ct as String)
	Me.cit=ct
	Console.WriteLine("My city is {0}",cit)
	End Sub	
	Public Overrides Sub ShowName()
	Console.WriteLine("My name is "+nm)
	End Sub
End Class
Sub Main()
	
	Dim obj As MyCity=New MyCity()
	
	obj.GetName("Soham Global")
	obj.ShowCity("Amravati")
	obj.ShowName()
	obj.TestFun()

End Sub
End Module





'content of sohamglobal.com
