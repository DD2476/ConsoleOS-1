'version 6.2.2021_6
'made by DD2476
'make sure you do not remove me from the credits!

Imports System
Imports System.Console

Module Module1

    Dim crashedApp As String
    Dim cause As String
    Dim errCode As String
    Dim prefix As String = ">>>"
    Const defPrefix As String = ">>>"
    Dim clicks As Integer = 0
    Dim Random As New Random
    Const QUOTE = """"

    Sub Main()

#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance

#Disable Warning BC42024 ' Unused local variable

        If My.Settings.first = False Then

            enterUser()

        Else

            Clear()

            setup()

        End If

    End Sub

    Private Sub enterUser()

        Dim user As String

        Title = "Console OS 1"

        WriteLine("╔═════════════════════╗")
        WriteLine("║  COS1 LOGIN SYSTEM  ║")
        WriteLine("║ Developed by DD2476 ║")
        WriteLine("║  Made with VS2019   ║")
        WriteLine("╚═════════════════════╝")
        WriteLine("")

        'enter username and password
        Write("Please enter your username (case-sensitive): ")

        user = ReadLine()

        If user = My.Settings.username Then

            Clear()

            If My.Settings.usePass = True Then

                enterPass()

            Else

                Startup()

            End If

        Else

            Clear()

            WriteLine("╔═════════════════════╗")
            WriteLine("║  COS1 LOGIN SYSTEM  ║")
            WriteLine("║ Developed by DD2476 ║")
            WriteLine("║  Made with VS2019   ║")
            WriteLine("╚═════════════════════╝")
            WriteLine("")
            WriteLine("Incorrect username.")

            enterUser()

        End If

    End Sub

    Private Sub enterPass()

        Dim pass As String
        Dim b As Integer = 0

        WriteLine("╔═════════════════════╗")
        WriteLine("║  COS1 LOGIN SYSTEM  ║")
        WriteLine("║ Developed by DD2476 ║")
        WriteLine("║  Made with VS2019   ║")
        WriteLine("╚═════════════════════╝")
        WriteLine("")

        WriteLine("Logged with Username: " + My.Settings.username)

        Write("Please enter your password (case-sensitive): ")

        pass = ReadLine()

        If pass = My.Settings.password Then

            Clear()

            WriteLine("╔═════════════════════╗")
            WriteLine("║  COS1 LOGIN SYSTEM  ║")
            WriteLine("║ Developed by DD2476 ║")
            WriteLine("║  Made with VS2019   ║")
            WriteLine("╚═════════════════════╝")
            WriteLine("")

            WriteLine("Logged with Username: " + My.Settings.username)
            Write("Logged with Password: ")

            Do Until b = My.Settings.password.Length

                Write("*")

                b += 1

            Loop

            WriteLine("")
            WriteLine("Thank you.")

            ReadKey()

            Clear()

            Startup()

        Else

            Clear()

            WriteLine("╔═════════════════════╗")
            WriteLine("║  COS1 LOGIN SYSTEM  ║")
            WriteLine("║ Developed by DD2476 ║")
            WriteLine("║  Made with VS2019   ║")
            WriteLine("╚═════════════════════╝")
            WriteLine("")
            WriteLine("Incorrect password.")

            enterPass()

        End If

    End Sub

    Private Sub Startup()

        WriteLine("╔═════════════════════╗")
        WriteLine("║     Console OS 1    ║")
        WriteLine("║ Developed by DD2476 ║")
        WriteLine("║  Made with VS2019   ║")
        WriteLine("╚═════════════════════╝")
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
        WriteLine("/start setup.exe - starts the setup example (BETA).")
        WriteLine("/start cookie.exe - starts Cookiefier!")
        WriteLine("/start nitrogen.exe - starts NitroGen")
        WriteLine("/prefix - shows the current prefix.")
        WriteLine("/prefix-change [New Prefix in quotation marks] - changes the current prefix.")
        WriteLine("/prefix-reset - resets the prefix to its default state.")
        WriteLine("/clear - clears the command interface.")
        WriteLine("/credits - shows the credits.")
        WriteLine("/reset - WARNING: resets all data!")
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

        ElseIf a.ToLower.Contains("/start setup.exe") Then

            Clear()

            SetupExample()

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

            Startup()

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

                Startup()

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

            Clear()

            NitroGen()

        ElseIf a.ToLower.Contains("/reset") Then

            Clear()

            reset()

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
        WriteLine("Type '#//home' to exit")

        Do

            a = ReadLine()

            If a.ToLower = "#//home" Then

                Clear()

                Startup()

            End If

        Loop

    End Sub

    Private Sub SetupExample()

        WriteLine("╔═════════════════════╗")
        WriteLine("║ Setup Example v1.0  ║")
        WriteLine("║ Developed by DD2476 ║")
        WriteLine("╚═════════════════════╝")
        WriteLine("")
        WriteLine("Welcome to the setup!")
        WriteLine("What would you like to do?")
        WriteLine("'next' - continue setup")
        WriteLine("'cancel' - exit setup")

        Dim a As String

        a = ReadLine()

        Clear()

        If a.ToLower = "next" Then

            Dim b As String

            WriteLine("Are you sure you want to install the program? (y/n)")
            WriteLine("Default path: #ConsoleOS#\%VirtualMemory%\.DSK:\SetupFiles\.f\%ProgramName%\.files\.setup\.installed\*.*")

            b = ReadLine()

            If b.ToLower = "y" Then

                Clear()

                WriteLine("Installing...")

                Threading.Thread.Sleep(10000)

                Clear()

                WriteLine("Installation successful. Press any key to exit.")

                ReadKey()

                Clear()

                Startup()

            ElseIf b.ToLower = "n" Then

                Clear()

                WriteLine("Operation cancelled by user.")

                ReadKey()

                Clear()

                Startup()

            Else

                crashedApp = "setup.exe"
                cause = "Invalid option selected"
                errCode = 1

                Crash()

            End If

        ElseIf a.ToLower = "cancel" Then

            Clear()

            WriteLine("Setup has been canceled by user.")

            ReadKey()

            Clear()

            Startup()

        Else

            crashedApp = "setup.exe"
            cause = "Invalid option selected"
            errCode = 1

            Crash()

        End If

    End Sub

    Private Sub Crash()

        Title = "A program has crashed!"

        WriteLine("╔═════════════════════════╗")
        WriteLine("║      Console OS 1       ║")
        WriteLine("║  Crash screen of death  ║")
        WriteLine("║  A program has crashed! ║")
        WriteLine("╚═════════════════════════╝")
        WriteLine("")

        WriteLine("Unfortunately, '" + crashedApp + "' has crashed.")
        WriteLine("Please try restarting the program.")
        WriteLine("")
        WriteLine("Error information: ")
        WriteLine("     Program: " + crashedApp)
        WriteLine("     What happened: " + cause)
        WriteLine("     U.nique P.rogram E.rror C.ode: " + errCode)

        ReadKey()

        Clear()

        Startup()

    End Sub

    Private Sub cookie()

        Dim a As String

        Title = "Cookiefier! by DD2476"

        WriteLine("Your clicks: " + clicks.ToString)
        WriteLine("Press 'ENTER/RETURN' te get clicks!")
        WriteLine("Write '#//home' to exit.")

        a = ReadLine()

        If a = "" Then

            clicks += 1

            Clear()

            cookie()

        ElseIf a.ToLower = "#//home" Then

            Clear()

            Startup()

        Else

            Clear()

            cookie()

        End If

    End Sub

    Private Sub credits()

        WriteLine("╔═════════════════════════════════════════════════╗")
        WriteLine("║Console OS 1                                     ║")
        WriteLine("║                                                 ║")
        WriteLine("║Developer: DD2476                                ║")
        WriteLine("║Testers: DD2476, my Discord Server               ║")
        WriteLine("║Helpers: DD2476, my Discord Server               ║")
        WriteLine("║Developing program: Visual Studio 2019 Enterprise║")
        WriteLine("║.NET Framework 4.8                               ║")
        WriteLine("║Console application                              ║")
        WriteLine("╚═════════════════════════════════════════════════╝")

        ReadKey()

        Clear()

        Startup()

    End Sub

    Private Sub NitroGen()

        Dim b As Integer
        Dim c As Integer = 0

        WriteLine("How many Discord Gift codes do you want to generate?")

        b = Convert.ToInt32(ReadLine())

        Clear()

        Do Until c = b

            WriteLine("https://discord.gift/" + GenerateRandomString(16))

            c += 1

        Loop

        WriteLine("")
        WriteLine("Press any key to exit!")

        ReadKey()

        Clear()

        Startup()

    End Sub

    Public Function GenerateRandomString(ByRef iLength As Integer) As String
        Dim rdm As New Random()
        Dim allowChrs() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray()
        Dim sResult As String = ""

        For i As Integer = 0 To iLength - 1
            sResult += allowChrs(rdm.Next(0, allowChrs.Length))
        Next

        Return sResult
    End Function

    Private Sub setup()

        WriteLine("╔═════════════════════╗")
        WriteLine("║     Console OS 1    ║")
        WriteLine("║ Developed by DD2476 ║")
        WriteLine("║  Made with VS2019   ║")
        WriteLine("╚═════════════════════╝")
        WriteLine("")
        WriteLine("Welcome to the ConsoleOS 1 Setup process! Press any key to start the setup.")

        ReadKey()

        Clear()

        SetupUser()

    End Sub

    Private Sub SetupUser()

        Dim user As String
        Dim conf As String

        WriteLine("╔═════════════════════╗")
        WriteLine("║     Console OS 1    ║")
        WriteLine("║ Developed by DD2476 ║")
        WriteLine("║  Made with VS2019   ║")
        WriteLine("╚═════════════════════╝")
        WriteLine("")

        Write("Please type your username: ")

        user = ReadLine()

        If user <> "" Then

            Clear()

            WriteLine("╔═════════════════════╗")
            WriteLine("║     Console OS 1    ║")
            WriteLine("║ Developed by DD2476 ║")
            WriteLine("║  Made with VS2019   ║")
            WriteLine("╚═════════════════════╝")
            WriteLine("")

            WriteLine("Are you sure you want to set " + QUOTE + user + QUOTE + " as your username? (y/n)")

            conf = ReadLine()

            If conf.ToLower = "y" Then

                Clear()

                My.Settings.username = user
                My.Settings.Save()

                SetupPass()

            ElseIf conf.toLower = "n" Then

                Clear()

                SetupUser()

            Else

                Clear()

                WriteLine("╔═════════════════════╗")
                WriteLine("║     Console OS 1    ║")
                WriteLine("║ Developed by DD2476 ║")
                WriteLine("║  Made with VS2019   ║")
                WriteLine("╚═════════════════════╝")
                WriteLine("")

                WriteLine("Invalid option entered.")

                ReadKey()

                Clear()

                SetupUser()

            End If

        Else

            WriteLine("╔═════════════════════╗")
            WriteLine("║     Console OS 1    ║")
            WriteLine("║ Developed by DD2476 ║")
            WriteLine("║  Made with VS2019   ║")
            WriteLine("╚═════════════════════╝")
            WriteLine("")

            WriteLine("Please type a valid username.")

            ReadKey()

            Clear()

            SetupUser()

        End If

    End Sub

    Private Sub SetupPass()

        Dim pass As String
        Dim yn1 As String
        Dim conf As String

        WriteLine("╔═════════════════════╗")
        WriteLine("║     Console OS 1    ║")
        WriteLine("║ Developed by DD2476 ║")
        WriteLine("║  Made with VS2019   ║")
        WriteLine("╚═════════════════════╝")
        WriteLine("")

        WriteLine("Do you want to set up a password now? (y/n)")

        yn1 = ReadLine()

        If yn1.ToLower = "y" Then

            Clear()

            WriteLine("╔═════════════════════╗")
            WriteLine("║     Console OS 1    ║")
            WriteLine("║ Developed by DD2476 ║")
            WriteLine("║  Made with VS2019   ║")
            WriteLine("╚═════════════════════╝")
            WriteLine("")

            Write("Please type your password (spaces will be removed): ")

            pass = ReadLine().Replace(" ", Nothing)

            If pass <> "" Then

                Clear()

                WriteLine("╔═════════════════════╗")
                WriteLine("║     Console OS 1    ║")
                WriteLine("║ Developed by DD2476 ║")
                WriteLine("║  Made with VS2019   ║")
                WriteLine("╚═════════════════════╝")
                WriteLine("")

                WriteLine("Are you sure you want to set " + QUOTE + pass + QUOTE + " as your password? (y/n)")

                conf = ReadLine()

                If conf.ToLower = "y" Then

                    Clear()

                    My.Settings.password = pass
                    My.Settings.usePass = True
                    My.Settings.first = False
                    My.Settings.Save()

                    WriteLine("Thank you for using this OS. To continue, please restart the application or press any key.")

                    ReadKey()

                    Environment.Exit(0)

                ElseIf conf.ToLower = "n" Then

                    Clear()

                    SetupPass()

                Else

                    Clear()

                    WriteLine("╔═════════════════════╗")
                    WriteLine("║     Console OS 1    ║")
                    WriteLine("║ Developed by DD2476 ║")
                    WriteLine("║  Made with VS2019   ║")
                    WriteLine("╚═════════════════════╝")
                    WriteLine("")

                    WriteLine("Invalid option entered.")

                    ReadKey()

                    Clear()

                    SetupPass()

                End If

            Else

                WriteLine("╔═════════════════════╗")
                WriteLine("║     Console OS 1    ║")
                WriteLine("║ Developed by DD2476 ║")
                WriteLine("║  Made with VS2019   ║")
                WriteLine("╚═════════════════════╝")
                WriteLine("")

                WriteLine("Please type a valid password")

            End If

        ElseIf yn1.ToLower = "n" Then

            My.Settings.usePass = False

        Else

            Clear()

            WriteLine("╔═════════════════════╗")
            WriteLine("║     Console OS 1    ║")
            WriteLine("║ Developed by DD2476 ║")
            WriteLine("║  Made with VS2019   ║")
            WriteLine("╚═════════════════════╝")
            WriteLine("")

            WriteLine("Invalid option entered.")

            ReadKey()

            Clear()

            SetupPass()

        End If

    End Sub

    Private Sub reset()

        Dim b As String


        BackgroundColor = BackgroundColor.White
        ForegroundColor = ForegroundColor.Red

        WriteLine("WARNING: You are about to reset all data stored here!")

        ReadKey()

        Clear()

        WriteLine("Are you sure you want to reset ALL DATA stored? (y/n)")

        b = ReadLine()

        If b.ToLower.Contains("y") Then

            Clear()

            WriteLine("Press any key to confirm.")

            ReadKey()

            Clear()

            WriteLine("Resetting machine...")

            My.Settings.Reset()

            Threading.Thread.Sleep(3000)

            Clear()

            WriteLine("Machine resetted successfully.")

            ReadKey()

            Environment.Exit(0)

        ElseIf b.ToLower.Contains("n") Then

            Clear()

            WriteLine("A system restart will be needed.")

            ReadKey()

            Environment.Exit(0)

        Else

            Environment.Exit(0)

        End If

    End Sub

End Module
