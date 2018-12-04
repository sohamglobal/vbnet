'Demo on method overriding,virtual keywork and runtime polymorphism



Imports System
Module Test
Class One
Public Overridable Sub Show()

Console.WriteLine("class One executed...")

End Sub
End Class

Class Two
Inherits One

Public Overrides Sub Show()
Console.WriteLine("class Two executed...")
End Sub
End Class


Sub Main()

Dim refobj As One

Dim x As One=New One()
Dim y As Two=New Two()

    refobj = x
    refobj.Show()

    refobj = y
    refobj.Show()
   


End Sub





End Module


'content of sohamglobal.com
