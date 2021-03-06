@echo off
rem delete old schedule batch file used in 0.4 or below
if exist "%APPDATA%\Microsoft\Windows\Start Menu\Programs\Startup\KillMicrobiomeTasks.bat" (
    del "%APPDATA%\Microsoft\Windows\Start Menu\Programs\Startup\KillMicrobiomeTasks.bat"
)

powershell "$s=(New-Object -COM WScript.Shell).CreateShortcut('%APPDATA%\Microsoft\Windows\Start Menu\Programs\Startup\KillMicrobiomeTasks.lnk');$s.TargetPath=(Get-Item -Path ".\KillMicrobiomeTasks.exe").FullName;$s.Arguments='-wait2min';$s.Save()"

if exist "%APPDATA%\Microsoft\Windows\Start Menu\Programs\Startup\KillMicrobiomeTasks.lnk" (
    echo Start up item is successfully created.
) else (
    echo Error! start up item is not created.
)
 
pause