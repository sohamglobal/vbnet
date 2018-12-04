'Demo program on Hashtable class

Imports System
Imports System.Collections

Module HashTest
	Public Sub Main()
		Dim ht As Hashtable = New Hashtable(20)	
		ht.Add("m101","alvaro morata")
		ht.Add("m102","edan hazard")
		ht.Add("m103","soham global")
		ht.Add("m104","maria sharapova")

		Console.WriteLine("total elements are {0}",ht.Count)

		Console.WriteLine("member with code m102 is {0}",ht("m102"))
	End Sub
End Module


'content of sohamglobal.com