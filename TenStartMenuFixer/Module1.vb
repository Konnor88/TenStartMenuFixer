Imports Microsoft.Win32

Module Module1
    Sub Main()
        Console.Title = "10StartMenu Fixer for Windows 11 by Konnor88"
        Console.WriteLine("Welcome to the 10StartMenu Fixer for Windows 11! What would you like to do?")
        Console.WriteLine("[1] Use Windows 10 Start menu")
        Console.WriteLine("[2] Remove Windows 10 Start menu")
Line1:
        Dim knownKeyPressed As Boolean = False
        Dim keyReaded As ConsoleKeyInfo = Console.ReadKey
        Select Case (keyReaded.Key)
            Case ConsoleKey.D1
                'Number 1 Key

                knownKeyPressed = True
                Call Main2()
            Case ConsoleKey.D2
                'Number 2 Key
                knownKeyPressed = True
                Call Main3()
            Case Else
                Console.WriteLine("Wrong key, please try again.")
                GoTo Line1
                knownKeyPressed = False
        End Select
    End Sub
    Sub Main2()
        Console.WriteLine("")
        Console.WriteLine("Applying fix...")
        My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", True).SetValue("Start_ShowClassicMode", 1, RegistryValueKind.DWord)
        Console.WriteLine("Fix successful! Please log out and log back in to see the changes.")
        Console.ReadLine()
        End
    End Sub
    Sub Main3()
        Console.WriteLine("")
        Console.WriteLine("Removing fix...")
        Dim key As Microsoft.Win32.RegistryKey
        key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", True)
        key.DeleteValue("Start_ShowClassicMode")
        Console.WriteLine("Fix removed! Please log out and log back in to see the changes.")
        Console.ReadLine()
        End
    End Sub
End Module
