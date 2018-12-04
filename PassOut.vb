'Demo on "ByVal" keyword

Imports System


Module PassOut
Sub Main()
Dim a As Integer=5
Calc(a)
Console.WriteLine(a)
End Sub


Public Sub Calc(ByVal n As Integer)
n=5
n=n+1

End Sub

End Module
'content of sohamglobal.com