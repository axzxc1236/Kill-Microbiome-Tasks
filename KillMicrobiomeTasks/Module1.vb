Module Module1
    Sub Main()
        Task.WaitAll(worker())
    End Sub

    Private Async Function worker() As Task
        If My.Application.CommandLineArgs.Count = 1 Then
            If My.Application.CommandLineArgs(0) = "-wait2min" Then
                Threading.Thread.Sleep(120000)
            End If
        End If
        Dim rpcClient As New BoincRpc.RpcClient,
            key = My.Computer.FileSystem.ReadAllText("RPCkey.txt")
        If Not My.Computer.FileSystem.FileExists("boinccmd.exe") Then
            MsgBox("This program has to be place in the same folder where boinccmd.exe exists to run.", MsgBoxStyle.Critical)
            End
        End If
        Await rpcClient.ConnectAsync("localhost", 31416)
        If Not Await rpcClient.AuthorizeAsync(key) Then
            MsgBox("I don't have permission to stop BOINC tasks, please make sure RPCkey.txt has the right token/password to interact with BOINC.")
            End
        End If
        While True
            For Each result In Await rpcClient.GetResultsAsync
                If Not result.State = 6 And result.Name.StartsWith("MIP1") Then  'result.State = 6  =>  aborted
                    Dim startInfo As New ProcessStartInfo("boinccmd.exe", "--host localhost --passwd " & key & " --task http://www.worldcommunitygrid.org/ " & result.Name & " abort")
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden
                    Process.Start(startInfo)
                End If
            Next
            Threading.Thread.Sleep(600000)  'Checks every 10 minute
        End While
    End Function
End Module
