'Finding IP address of a machine

Imports System
Imports System.Net

Module KnowIP
	Public Sub Main()
		Dim host As String
		'Enter any host name like www.bing.com
		Console.Write("Enter host name :")
		host=Console.ReadLine()
		Try
			Dim hostname As IPHostEntry
			hostname = Dns.GetHostEntry(host)
			Dim ip() As IPAddress
			ip = hostname.AddressList
			Console.WriteLine(ip(0).ToString())
		Catch e As Exception
		 	Console.WriteLine(e.ToString())
		End Try
	End Sub
End Module


'content of sohamglobal.com