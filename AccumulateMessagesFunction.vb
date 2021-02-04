'Laura Riley
'RCET 0265
'Spring 2021
'Accumulate Messages Function
'

Option Explicit On
Option Strict On
Module AccumulateMessagesFunction

    Sub Main()
        Dim userInput As String
        Console.WriteLine("Please enter a message")
        userInput = Console.ReadLine() & vbCrLf
        Console.WriteLine(UserMessages(userInput, False))

        Console.Read()
    End Sub

    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String
        Static messages As String

        If clear = False Then
            messages &= vbCrLf & $"You entered: {newMessage}"
        Else
            messages = ""
        End If

        Return messages

    End Function
End Module
