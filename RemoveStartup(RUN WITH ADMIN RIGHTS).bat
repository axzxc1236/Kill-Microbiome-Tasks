@echo off
rem delete old schedule batch file used in 0.4 or below
del "%APPDATA%\Microsoft\Windows\Start Menu\Programs\Startup\KillMicrobiomeTasks.bat"

schtasks /delete /tn Kill-Microbiome-Tasks
pause