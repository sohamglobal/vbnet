'Demo on creating directory and writing a file

Imports System
Imports System.IO


Module FileTest
Sub Main()


If  (Not Directory.Exists("d:\\sohamglobal"))  Then
Directory.CreateDirectory("d:\\sohamglobal")
End If

Dim filename As String="d:\\sohamglobal\\vb.net.txt"

Dim obj As StreamWriter=New StreamWriter(filename)
obj.Write("this is vb.net testing")
obj.Close()


Console.WriteLine("Directory and file created successfully")



End Sub
End Module






'content of sohamglobal.com