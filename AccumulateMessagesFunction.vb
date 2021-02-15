'Laura Riley
'RCET 0265
'Spring 2021
'Accumulate Messages Function
'https://github.com/rilelaur/AccumulateMessages.git

Option Explicit On
Option Strict On
Module AccumulateMessagesFunction

    'asks the user to enter a message and concatinates the input by the user
    Sub Main()
        Dim userInput As String
        Console.WriteLine("Please enter a message")
        userInput = Console.ReadLine() & vbCrLf
        Console.WriteLine(UserMessages(userInput, False))

        Console.Read()
    End Sub

    'tells the user what they entered and returns it as a string
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
