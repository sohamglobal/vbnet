'Demo program on reading a text file


Imports System
Imports System.IO

Module FileRead
Sub Main()

'Dim str As String
Dim filenm As String
Console.Write("Enter full filename ")
filenm=Console.ReadLine()

Dim fsr As FileStream= New FileStream(filenm,FileMode.Open,FileAccess.Read)
Dim b(fsr.Length) As Byte

Console.WriteLine("File is of {0} bytes",fsr.Length)

fsr.Read(b,0,b.Length)
'Console.Write(b)
Console.Write(System.Text.Encoding.ASCII.GetString(b))

fsr.Close()


End Sub
End Module




'content of sohamglobal.com