# Kill Microbiome Tasks

A program to stop Microbiome Immunity Project from running.

This program is designed because [A bug that still not fixed yet](https://www.worldcommunitygrid.org/forums/wcg/viewthread_thread,40708). (and maybe won't be fixed at all)

It works by connect to [GuiRpc](https://boinc.berkeley.edu/trac/wiki/GuiRpc), finds Microbiome Immunity Project tasks, abort them all and check again 10 minutes later.

To use this program, put "KillMicrobiomeTasks.exe", "BoincRpc.dll" and "RPCkey.txt" at BOINC's install directory, open "gui_rpc_auth.cfg" and copy its content to "RPCkey.txt", and set a cron job to auto start "KillMicrobiomeTasks.exe" after 30 seconds after BOINC starts running. (Glary Utilities can do this easilly)

if you can't find "gui_rpc_auth.cfg", it should be in [BOINC's data directory](https://boinc.berkeley.edu/wiki/BOINC_Data_directory).

[Microsoft .Net Framework 4.6](https://www.microsoft.com/en-us/download/details.aspx?id=48137) is used to make this program, and is required to run this program.

License
-------
LGPL 3, see LICENSE

Thanks to [chausner](https://github.com/chausner) for making [BoincRpc](https://github.com/chausner/BoincRpc), saves me a lot of work.