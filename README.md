# Major Update
Microsoft has removed the functionality of restoring the Windows 10 start menu on Windows 11 entirely. The last build this program works on is Build 22000.51, and that build even requires a workaround of replacing the explorer.exe inside of it with the one from the original leak. I will keep this repository up for archive purposes and for people interested in using it on the initial leaked build (build 21996.1) or build 22000.51.

# TenStartMenuFixer
Simple application that restores the Windows 10 start menu on Windows 11. Can be toggled on or off.

# How does it work?
It uses a command-line interface to configure a registry key that allows for the Windows 10 start menu to be displayed rather than the Windows 11 start menu.

# How can I build it?
Just open it up and press "Build" in Visual Studio and you're good to go.

# Why VB.NET? 
Everytime I coded it in C# Windows Defender decided to keep reporting it as unwanted. Making it in VB.NET solved the issue.

# What build does it support?
It is guaranteed on Windows 11 build 21996.

# Will it harm my Windows 11 install?
No, it will not. All it does is apply a registry key for the install part and remove it for the uninstall part. I won't be responsible if this somehow messes up. 
