@echo off
rem delete old schedule batch file used in 0.4 or below
if exist "%APPDATA%\Microsoft\Windows\Start Menu\Programs\Startup\KillMicrobiomeTasks.bat" (
    del "%APPDATA%\Microsoft\Windows\Start Menu\Programs\Startup\KillMicrobiomeTasks.bat"
)

if exist "%APPDATA%\Microsoft\Windows\Start Menu\Programs\Startup\KillMicrobiomeTasks.lnk" (
    del "%APPDATA%\Microsoft\Windows\Start Menu\Programs\Startup\KillMicrobiomeTasks.lnk"
    echo Start up item is removed
) else (
    echo You didn't create a start up item
)
pause