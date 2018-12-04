'Demo program for switch statement

Imports System
Module CustomerSwitch

Sub Main

	Dim cnm As String
	Dim ctyp As Integer
	Dim pamt,disc,net As Double


	Console.Write("Enter Name ")
	cnm=Console.ReadLine()

	Console.Write("Enter type (4/5/7) :")
	ctyp=Convert.ToInt32(Console.ReadLine())

	Console.Write("Enter amount ")
	pamt=Convert.ToDouble(Console.ReadLine())

	Select Case ctyp
	Case 4:
	disc=pamt*10/100

	Case 5:
	disc=pamt*8/100

	Case 7:
	disc=pamt*5/100

	Case Else
	disc=0

	End Select

	net=pamt-disc
	Console.Write("{0}, your net bill is Rs.{1}",cnm,net)


End Sub
End Module





'content of sohamglobal.com