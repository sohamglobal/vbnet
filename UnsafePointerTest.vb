'Demo on creating a pointer 

Imports System

Public Module UnsafePointerTest

	 Public Sub Main()
		Dim num As Integer=10
		Dim ptr As IntPtr

		'"unsafe pointer" is not allowed in vb
		ptr=num
		Console.WriteLine("Number {0}", cstr(ptr))

	 End Sub

End Module


'content of sohamglobal.com