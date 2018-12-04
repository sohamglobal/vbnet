'Demo program on Queue class

Imports System
Imports System.Collections
Public Module QueueTest

    Public Sub Main()
 	Dim myQ As New Queue()
        myQ.Enqueue("cricket")
        myQ.Enqueue("football")
        myQ.Enqueue("tennis")
	myQ.Enqueue("rugby")

	While(myQ.Count >0)
		Console.WriteLine(myQ.Dequeue())
	End While
	
	Console.WriteLine("After accessing all elements the count is {0}",myQ.Count)

    End Sub

End Module

'content of sohamglobal.com
