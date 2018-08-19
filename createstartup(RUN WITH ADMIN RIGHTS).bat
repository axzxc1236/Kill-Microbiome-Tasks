@echo off
rem delete old schedule batch file used in 0.4 or below
del "%APPDATA%\Microsoft\Windows\Start Menu\Programs\Startup\KillMicrobiomeTasks.bat"

schtasks /create /sc ONLOGON /tn Kill-Microbiome-Tasks /tr "%cd%/KillMicrobiomeTasks.exe -wait2min"
pause