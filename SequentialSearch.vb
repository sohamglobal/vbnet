'Demo program on sequential search

Imports System

Public Module SequentialSearch

    Public Sub Main()

      Dim a(9) As Integer  
      Dim i,cnt As Integer
      cnt=0
	For i = 0 To 9          
	   Console.Write("Enter a number ")
           a(i)=Convert.ToInt32(Console.ReadLine())
	Next

'seq search mechanism to find total even numbers in the array

	For i = 0 To 9 
		If a(i) Mod 2 =0 Then
		cnt= cnt+1
		End If
	Next 

Console.WriteLine("Total even numbers are {0}",cnt)
     End Sub

End Module


'content of sohamglobal.com
