'Demo on "ByVal" keyword

Imports System


Module PassRef
Sub Main()
Dim a As Integer=3
Calc(a)
Console.WriteLine("value of a is {0}",a)
End Sub


Public Sub Calc(ByRef n As Integer)
n=n+1

End Sub

End Module
'content of sohamglobal.com