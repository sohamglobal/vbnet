'Demo of using structure 

Imports System

Structure sample
	Public nm As String
	Public mobile As String

	'Public Sub ShowData()
	'	Console.WriteLine("Name: {0}, Mobile: {1}",nm,mobile)
	'End Sub

End Structure 


Public Module StructTest

   	Public Sub Main()
		Dim s As sample
		s.nm="praffull"
		s.mobile="12345123456"
		Console.WriteLine("Name: {0} and  Mobile: {1}",s.nm,s.mobile)
		's.ShowData()
	End Sub

End Module


'content of sohamglobal.com