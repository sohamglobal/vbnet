'Demo example of properties, set and get

Imports System

Module PersonProperties

	Class Demo
	
	 Private myName As String="NA"
	 Private myAge As Integer=0
	 
	Public Property Name() As String
        	Get
            	Return myName 
        	End Get
        	Set(ByVal Value As String)
            	myName = Value
        	End Set
    	End Property

	Public Property Age() As Integer
      	  	Get
            	Return myAge 
        	End Get
        	Set(ByVal Value As Integer)
            	myAge = Value
        	End Set
    	End Property

	Public Overrides Function ToString() As String
	Return "Name = " + Name.ToString() + ", Age = " + Age.ToString()
	End Function
	End Class

	Public Sub Main()
		Console.WriteLine("Simple Properties")
		'Create a new Person object:
		Dim person As Demo=New Demo()

		'Print out the name and the age associated with the person:
		 Console.WriteLine("Person details - {0}", person)

		'Set some values on the person object:
		 person.Name = "Praffull"
       		 person.Age = 99
       		 Console.WriteLine("Person details - {0}", person)

		'Increment the Age property:
		person.Age += 1
       	        Console.WriteLine("Person details - {0}", person)
			
	End Sub
End Module
