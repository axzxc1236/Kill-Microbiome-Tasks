@echo off
echo @echo off>"%APPDATA%\Microsoft\Windows\Start Menu\Programs\Startup\KillMicrobiomeTasks.bat"
echo %CD:~0,2%>> "%APPDATA%\Microsoft\Windows\Start Menu\Programs\Startup\KillMicrobiomeTasks.bat"
echo cd "%cd%">> "%APPDATA%\Microsoft\Windows\Start Menu\Programs\Startup\KillMicrobiomeTasks.bat"

rem   I added -wait2min to make sure KillMicrobiomeTasks.exe waits until BOINC starts
echo start /MIN KillMicrobiomeTasks.exe -wait2min>> "%APPDATA%\Microsoft\Windows\Start Menu\Programs\Startup\KillMicrobiomeTasks.bat"