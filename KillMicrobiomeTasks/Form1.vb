Public Class Form1
    Private Async Sub Form1_LoadAsync(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Application.CommandLineArgs.Count = 1 Then
            If My.Application.CommandLineArgs(0) = "-wait2min" Then
                Threading.Thread.Sleep(120000)
            End If
        End If
        Dim rpcClient As New BoincRpc.RpcClient,
            key = My.Computer.FileSystem.ReadAllText("RPCkey.txt")
        Try
            Await rpcClient.AuthorizeAsync(key)
        Catch ex As System.InvalidOperationException
            MsgBox("I don't have permission to stop BOINC tasks, please make sure RPCkey.txt has the right token/password to interact with BOINC.")
            End
        End Try
        If Not My.Computer.FileSystem.FileExists("boinccmd.exe") Then
            MsgBox("This program has to be place in the same folder where boinccmd.exe exists to run.", MsgBoxStyle.Critical)
            End
        End If
        Await rpcClient.ConnectAsync("localhost", 31416)
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
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Hide()
    End Sub

    Sub Form1_Load() Handles MyBase.Load
        Me.Opacity = 0
    End Sub
End Class
