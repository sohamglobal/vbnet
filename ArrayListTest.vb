'Demo program on ArrayList class

Imports System
Imports System.Collections


Module ArrayListTest

Sub Main()
	Dim list As New ArrayList()
	list.Add("praffull")
	list.Add("sachin")
	list.Add("rahul")
	list.Add("saurav")


	For i As Integer=0 To list.Count-1
		Console.WriteLine(list(i))
	Next
	Console.Write("\n\n ---------------\n")

	list.Insert(2,"zaheer")
	list.Remove("praffull")


	For Each nm as String In list
		Console.WriteLine(nm)
	Next


End Sub

End Module

'content of sohamglobal.com