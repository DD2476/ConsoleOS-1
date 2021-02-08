Imports System
Imports System.Console

Module Program

    Dim crashedApp As String
    Dim cause As String
    Dim errCode As String
    Dim prefix As String = "system.console:"
    Const defPrefix As String = "system.console:"
    Dim clicks As Integer = 0
    Dim Random As New Random
    Const QUOTE = """"

    Sub Main()

        Title = "Console OS vFANMADE"

        WriteLine("╔══════════════════════╗")
        WriteLine("║    Console OS v1.1   ║")
        WriteLine("║  Developed by DD2476 ║>>")
        WriteLine("║ FANMADE by AdrianoTech ║")
        WriteLine("║   Made with VS2019   ║<<")
        WriteLine("╚══════════════════════╝")
        WriteLine("")
        WriteLine("Type /help for the list of commands.")
        WriteLine("")

        input()

    End Sub

    Private Sub Help()

        'WriteLine("")
        'WriteLine("")
        WriteLine("╔══════════╗")
        WriteLine("║ Commands ║")
        WriteLine("╚══════════╝")
        WriteLine("")
        WriteLine("/help - shows this menu.")
        WriteLine("/home - sends you to the main interface.")
        WriteLine("/start notepad.exe - starts the 'notepad' program.")
        WriteLine("/start cookie.exe - starts Cookiefier!")
        WriteLine("/start adrik.exe - Try It!")
        WriteLine("/prefix - shows the current prefix.")
        WriteLine("/prefix-change [New Prefix in quotation marks] - changes the current prefix.")
        WriteLine("/prefix-reset - resets the prefix to its default state.")
        WriteLine("/clear - clears the command interface.")
        WriteLine("")

        input()

    End Sub

    Private Sub input()

        'WriteLine("")
        'WriteLine("")

        Write(prefix + " ")

        Dim a As String

        a = ReadLine()

        If a.ToLower.Contains("/help") Then

            Clear()

            Help()

        ElseIf a.ToLower.Contains("/start notepad.exe") Then

            Clear()

            Notepad()
        ElseIf a.ToLower.Contains("/start adrik.exe") Then

            Clear()

            WriteLine("AdrinoTech#7163 :)")
            WriteLine("You can't kill me XD stupid noob")

            Setup()

        ElseIf a.ToLower.Contains("/prefix") AndAlso Not (a.ToLower.Contains("/prefix-change")) AndAlso Not (a.ToLower.Contains("/prefix-reset")) Then

            WriteLine("The current prefix is: " + QUOTE + prefix + QUOTE)
            WriteLine("")

            input()

        ElseIf a.ToLower.Contains("/prefix-change") Then

            Dim b As String

            b = a.Substring(14, a.Replace("/prefix-change ", Nothing).Length + 1)

            'WriteLine("Please type a new prefix.")
            'prefix = ReadLine().Replace(" ", "")

            If b <> "" Then

                If b.Contains(QUOTE) Then

                    b = b.Replace(" ", Nothing)
                    b = b.Replace(QUOTE, Nothing)

                    'prefix = b.Replace(QUOTE, Nothing)

                    prefix = b

                    WriteLine("Prefix set successfully.")

                Else

                    WriteLine("Failed to set prefix: No prefix in quotation marks was found.")

                    prefix = defPrefix

                End If

            Else

                WriteLine("Failed to set prefix: No valid characters were entered.")

                prefix = defPrefix

            End If

            WriteLine("")

            input()

        ElseIf a.ToLower.Contains("/clear") Then

            Clear()

            input()

        ElseIf a.ToLower.Contains("/start cookie.exe") Then

            Clear()

            cookie()

        ElseIf a.ToLower.Contains("/home") Then

            Clear()

            Main()

        ElseIf a.ToLower.Contains("/credits") Then

            Dim b As String
            Dim c As String

            b = Random.Next(100, 1000).ToString + "-" + Random.Next(100, 1000).ToString

            Clear()

            Title = "To access this land, you must prove that you are worthy..."

            WriteLine("To access this land, you must prove that you are worthy...")

            WriteLine("Write this number: " + b + " (without the '-')")

            c = ReadLine()

            If c = b.Replace("-", "") Then

                Clear()

                credits()

            Else

                Clear()

                Title = "You did not make it..."

                WriteLine("You did not make it...")

                ReadKey()

                Clear()

                Title = "Bye Bye! 〜(￣▽￣〜)"

                WriteLine("Bye Bye! 〜(￣▽￣〜)")

                ReadKey()

                Clear()

                Main()

            End If

        ElseIf a.ToLower.Contains("/prefix-reset") Then

            Dim yn1 As String

            WriteLine("Are you sure you want to reset the prefix? (y/n)")

            yn1 = ReadLine()

            If yn1.ToLower = "y" Then

                prefix = defPrefix

                WriteLine("Prefix reset successfully.")
                WriteLine("")

                input()

            ElseIf yn1.ToLower = "n" Then

                WriteLine("Operation cancelled by user.")
                WriteLine("")

                input()

            Else

                crashedApp = "system.console"
                cause = "Invalid yes/no decision"
                errCode = "unknown"

                Clear()

                Crash()

            End If

        ElseIf a.ToLower.Contains("/start nitrogen.exe") Then

            NitroGen()

        ElseIf a.ToLower = "" Then

            input()

        Else

            WriteLine("Error: Bad command entered.")
            WriteLine("")

            input()

        End If

    End Sub

    Private Sub Notepad()

        Dim a As String

        WriteLine("WARNING: Once you wrote a line, you can not edit or delete it!")
        WriteLine("Type '/kill notepad.exe' to exit")

        Do

            a = ReadLine()

            If a.ToLower = "/kill notepad.exe" Then

                Clear()

                Main()

            End If

        Loop

    End Sub

    Private Sub Setup()

        WriteLine("╔═════════════════════╗")
        WriteLine("║    Setup of HELL!   ║")
        WriteLine("║ Developed by DD2476 ║")
        WriteLine("║ ADRINOTECH IS HERE. ║")
        WriteLine("╚═════════════════════╝")
        WriteLine("")
        WriteLine("Welcome to the setup!")
        WriteLine("What would you like to do?")
        WriteLine("'next' - NO ESCAPE!")

        Dim a As String

        a = ReadLine()

        Clear()

        If a.ToLower = "next" Then

            Dim b As String

            WriteLine("DO YOU WANT CLOSE ME? (y)")

            b = ReadLine()

            If b.ToLower = "y" Then

                WriteLine("Noob")
                System.Threading.Thread.Sleep(2000)
                Clear()
                credits()

            ElseIf b.ToLower = "y" Then

                WriteLine("Noob")
                System.Threading.Thread.Sleep(2000)
                Clear()
                credits()

            Else

                WriteLine("Noob")
                System.Threading.Thread.Sleep(2000)
                Clear()
                credits()
                System.Threading.Thread.Sleep(5000)

            End If

        End If

    End Sub

    Private Sub Crash()

        Title = "A program has crashed!"

        WriteLine("╔════════════════════════════╗")
        WriteLine("║       Console OS v1.0      ║")
        WriteLine("║    Crash screen of death   ║")
        WriteLine("║   A program has crashed!   ║")
        WriteLine("╚════════════════════════════╝")
        WriteLine("")

        WriteLine("Unfortunately, '" + crashedApp + "' has crashed.")
        WriteLine("Please try restarting the program.")
        WriteLine("")
        WriteLine("Error information: ")
        WriteLine("     Program: " + crashedApp)
        WriteLine("     What happened: " + cause)
        WriteLine("     U.nique P.rogram E.rror C.ode: " + errCode)



    End Sub

    Private Sub cookie()

        Dim a As String

        Title = "Cookiefier! by DD2476"

        WriteLine("Your clicks: " + clicks.ToString)
        WriteLine("Press 'ENTER/RETURN' te get clicks!")
        WriteLine("Write '/kill cookie.exe' to exit.")

        a = ReadLine()

        If a = "" Then

            clicks += 1

            Clear()

            cookie()

        ElseIf a.ToLower = "/kill cookie.exe" Then

            Clear()

            Main()

        Else

            Clear()

            cookie()

        End If

    End Sub

    Private Sub credits()

        WriteLine("╔═════════════════════════════════════════════════╗")
        WriteLine("║Console OS v1.0                                  ║")
        WriteLine("║                                                 ║")
        WriteLine("║Developer: DD2476                                ║")
        WriteLine("║Testers: DD2476                                  ║")
        WriteLine("║Helpers: DD2476                                  ║")
        WriteLine("║Remaker: AdrianoTech                             ║")
        WriteLine("║Developing program: Visual Studio 2019 Enterprise║")
        WriteLine("╚═════════════════════════════════════════════════╝")

        System.Threading.Thread.Sleep(5000)

        Clear()

        Main()

    End Sub

    Private Sub NitroGen()

        WriteLine("No Way! A Scam")

    End Sub

End Module
