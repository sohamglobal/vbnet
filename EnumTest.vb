'Demo program on enumerations

Imports System

Module EnumTest

Enum Temperature
boilingpoint=100
comfort=26
conditioned=18
freezingpoint=0
End Enum

Enum Rating

sachin
rahul
saurav
zaheer

End Enum



Sub Main()
Dim i As Integer=Temperature.conditioned
Dim rt As Byte
Console.WriteLine("AC must not be kept to {0} centigrade",i)

rt=Rating.rahul
Console.WriteLine("{0} is rated {1}",Rating.rahul,++rt)
End Sub

End Module



'content of sohamglobal.com