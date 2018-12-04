'Demo program on Exception handling (try-catch)

Module ErrorRemoval
Sub Main()

Dim nm As String
Dim mks As Integer

Console.Write("Enter Name ")


nm=Console.ReadLine()
Console.Write("Enter marks ")

Try
mks=Convert.ToInt32(Console.ReadLine())
Catch ex As Exception

Console.WriteLine("sorry invalid marks..reset to zero")
mks=0
End Try

If mks>=35 Then
Console.WriteLine("{0} you are PASS",nm)
Else
Console.WriteLine("{0} you are FAIL",nm)

End If


End Sub
End Module


'content of sohamglobal.com
