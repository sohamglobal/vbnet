'Demo program on Stack class

Imports System
Imports System.Collections

Public Module StackTest

    Public Sub Main()

	Dim st As Stack = New Stack()
	   st.Push("microsoft")
	   st.Push("oracle")
	   st.Push("intel")
	   st.Push("salesforce")
	   st.Push("google")

	While(st.Count >0)
	   Console.WriteLine("The count now is {0}",st.Count)
	   Console.WriteLine(st.Pop())
	End While


    End Sub

End Module


'content of sohamglobal.com