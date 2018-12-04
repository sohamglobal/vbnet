'Demo program on multithreading

Imports System
Imports System.Threading


Module MultiThreading 

Public Class MyThread 

Public Sub Activity1() 

For i As Integer=1 To 10
Console.WriteLine("sohamglobal " + i.ToString)
Thread.Sleep(500)
Next

End Sub 

Public Sub Activity2() 

For i As Integer=11 To 20
Console.WriteLine("Spider " + i.ToString)
Thread.Sleep(500)
Next

End Sub 
End Class


Sub Main()
Console.WriteLine("Multithreading in C#")

Dim thr1 As MyThread=New MyThread()
Dim thr2 As MyThread=New MyThread()

Dim act1 As Thread=New Thread(AddressOf thr1.Activity1)
act1.Start()

Dim act2 As Thread=New Thread(AddressOf thr2.Activity2)
act2.Start()

End Sub


End Module