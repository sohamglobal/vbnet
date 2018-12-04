'  Example Demostrate shared Static Member Function 
 
Imports System
 
Class Account
Private accno As String
Private balance As Integer
Private Shared Irate As Double = 11.00 
 
	Public Sub New(ByVal accno As String, ByVal balance As Integer)
		Me.accno=accno
		Me.balance=balance
	End Sub
 
	Public Sub ShowInterest()
		Dim Newbalance As Integer =  balance+(balance*CType(Irate/100, Integer)) 
		Console.WriteLine("Account Number : "& accno)
		Console.WriteLine("Balance : "& balance)
		Console.WriteLine("Interest rate : {0}%", Irate)
		Console.WriteLine("Balance after interest : "& Newbalance)
		Console.WriteLine("-------------------------------------")
	End Sub
 
	Public Shared  Sub ChangeIrate(ByVal r As Double)

		'applicable to all objects of Account class
		Irate=r
	End Sub
End Class
 
Module AccountDemo
	Public Sub Main()
		Dim soham As Account,sharayu As Account
		soham=New Account("30129932",25300)
		Account.ChangeIrate(11.50)
 
		sharayu=New Account("32194900",13100)
		soham.ShowInterest()
		sharayu.ShowInterest()
	End Sub
End Module
 
 
'content of sohamglobal.com
