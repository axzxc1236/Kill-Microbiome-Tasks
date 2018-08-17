# Kill Microbiome Tasks

A program to stop Microbiome Immunity Project from running.

This program is designed because [A bug that still not fixed yet](https://www.worldcommunitygrid.org/forums/wcg/viewthread_thread,40708). (and maybe won't be fixed at all)

It works by connect to [GuiRpc](https://boinc.berkeley.edu/trac/wiki/GuiRpc), finds Microbiome Immunity Project tasks, abort them all and check again 10 minutes later.

## How to use this program

1. Install [Microsoft .Net Framework 4.6](https://www.microsoft.com/en-us/download/details.aspx?id=48137)

2. Find [BOINC directory](https://boinc.berkeley.edu/wiki/BOINC_Data_directory) where you will put KillMicrobiomeTasks program.

3. Download Release0.3.tar from [Releases](https://github.com/axzxc1236/Kill-Microbiome-Tasks/releases), decompress files to BOINC directory.

4. Find "gui_rpc_auth.cfg" which should be in [BOINC data directory](https://boinc.berkeley.edu/wiki/BOINC_Data_directory), copy its content to "RPCkey.txt".

5. Manually start KillMicrobiomeTasks.exe when BOINC is running.

6. (optional) run createstartup.bat to make KillMicrobiomeTasks.exe run everytime user logins.

License
-------
LGPL 3, see LICENSE

Thanks to [chausner](https://github.com/chausner) for making [BoincRpc](https://github.com/chausner/BoincRpc), saves me a lot of work.