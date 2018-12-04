'Demo program on generating machine specifications

Imports System

Module MyMachine
	Public Sub Main()
		
		Dim os As OperatingSystem
		os=Environment.OSVersion

		Dim id As PlatformID 
		id=os.Platform

		Dim drives() As String
		drives=Environment.GetLogicalDrives()
		
		Dim drvs As String=""
		For Each dr As String In drives
		drvs+=dr+","
		Next

		Console.WriteLine("Machine Name : {0}",Environment.MachineName)
		Console.WriteLine("Operating System : {0}",Environment.OSVersion)
		Console.WriteLine("Operating System ID: {0}",id)
		Console.WriteLine("Current Folder : {0}",Environment.CurrentDirectory)
		Console.WriteLine("CLR version : {0}",Environment.Version)
		Console.WriteLine("Present Drive : {0}",drvs)
	End Sub
End Module



'content of sohamglobal.com