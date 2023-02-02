Option Strict On
Option Explicit On
Option Compare Text
Imports System
Imports System.Linq.Expressions
'Baden Brenner
'RCET0265
'Fall 2023
'Fortune Cookie

Module Program
    Sub Main(args As String())
        Dim temp As String
        Dim randomNumber As Integer
        Dim wisdom As Boolean = True

        Do Until wisdom = False

            Dim rnd As New Random
            randomNumber = rnd.Next(1, 5) ' generates a random number between 1 and 5 
            'Console.WriteLine(randomNumber)


            If randomNumber = 1 Then 'selects the wisdom 
                Console.WriteLine("Good things come to those who work hard.")
                'Console.WriteLine(1)
            ElseIf randomNumber = 2 Then
                Console.WriteLine("Success is a journey, not a destination.")
                'Console.WriteLine(2)
            ElseIf randomNumber = 3 Then
                Console.WriteLine("Take a chance, it may lead to something great.")
                'Console.WriteLine(3)
            ElseIf randomNumber = 4 Then
                Console.WriteLine("Your perseverance will pay off in the end.")
                'Console.WriteLine(4)
            End If
            Console.WriteLine(" ")

            Console.WriteLine("would you like more wisdom (Y/N)")
            temp = Console.ReadLine()

            If temp = "N" Then
                wisdom = False
                Console.WriteLine("I Hope You Feel Inlightened")
            End If
        Loop
    End Sub
End Module
