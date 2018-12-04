'Demo program on basic oops, class and object

Imports System

Module OOPS

Class Customer
Private custnm As String
Private amt,disc,net As Double

'empty constructor
Public Sub New()
net=0.0
Console.WriteLine("welcome to Vb.net shop")

End Sub

'parameterized constructor
Public Sub New(ByVal shopnm As String)
net=0.0
Console.WriteLine("welcome to {0}",shopnm)
End Sub

Public Sub GetNewCustData()
Console.Write("Enter name ")
custnm=Console.ReadLine()
Console.Write("Enter amount ")
amt=Convert.ToDouble(Console.ReadLine())
End Sub

Public Sub CalcNet()
disc=amt*10/100
net=amt-disc

End Sub



Public Sub ShowCustData()
Console.WriteLine("Name: {0}",custnm)
Console.WriteLine("NetBill:Rs. {0}",net)

End Sub

Public Shared Sub Display()
Console.WriteLine("Thanks for your visit")

End Sub
End Class


Sub Main()

Dim c As Customer=New Customer("Shivaji Super Bazaar")
c.GetNewCustData()
c.CalcNet()
c.ShowCustData()
Customer.Display()

End Sub



End Module