'Demo program on SortedList class

Imports System
Imports System.Collections

Public Module SortedListTest

    Public Sub Main()

	Dim slist As SortedList = New SortedList()

	   slist.Add(43,"java")
  	   slist.Add(59,"C#")
	   slist.Add(17,"C++")
	   slist.Add(38,"python")
           slist.Add(13,"SQL")
	   slist.Add(5,"VB")
        Console.WriteLine("Sorted Items are -")
	Dim nm As String
		For Each nm In slist.GetValueList()
		Console.WriteLine(nm)
		Next

    End Sub

End Module


'content of sohamglobal.com