'Demo program on inheritance

Imports System
Module DemoInh

Class One
Private sum As Integer

Public Sub ShowSum(ByVal a As Integer,ByVal b As Integer)
sum=a+b
Console.WriteLine("sum is {0}",sum)

End Sub
End Class


Class Two
Inherits One

Private sqr As Integer
Public Sub ShowSqr(ByVal n As Integer)
sqr=n*n
Console.WriteLine("square is {0}",sqr)

End Sub
End Class 

Class Three 
Inherits One

Private cub As Integer

Public Sub ShowCube(ByVal n As Integer)
cub=n*n*n
Console.WriteLine("Cube is {0}",cub)

End Sub
End Class

Sub Main()



Dim obj As Two=New Two
obj.ShowSqr(22)
obj.ShowSum(55,90)
'obj.ShowCube(25) not allowed

Dim x As Three=New Three
'x.ShowSqr(22)not allowed
x.ShowSum(47,42)
x.ShowCube(25)

End Sub


End Module