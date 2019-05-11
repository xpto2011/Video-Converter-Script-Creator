Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath = "" Then Return

        TextBox1.Text = FolderBrowserDialog1.SelectedPath
        Dim f As String = My.Computer.FileSystem.GetFiles(FolderBrowserDialog1.SelectedPath, FileIO.SearchOption.SearchTopLevelOnly, "*.mkv", "*.mp4")(0)
        Dim m As New ffmpeg_Script_Creator.MediaFile(f)
        TextBox2.Text = m.WriteAllTracks
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath = "" Then Return

        outDir.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Function compileArgs() As String()
        Dim list As New List(Of String)
        list.Add("PLACEHOLDER")
        list.Add("" & TextBox1.Text & "")

        list.Add("-v")
        list.Add("" & vEncoder.Text & ";" & vPreset.Text & ";" & vPFormat.Text & ";" & vCRF.Text & IIf(vQMax.Text.Length > 0, ";" & vQMax.Text, "") & "")

        list.Add("-a")
        list.Add("" & IIf(ASL.Text.Length > 0 And ASO.Text.Length > 0, ASL.Text & ":" & ASO.Text, "") & ";" & aEncoder.Text & ";" & aBitrate.Text & IIf(aCha.Text.Length > 0, ";" & aCha.Text, "") & "")

        If SSL.Text.Length > 0 And SSO.Text.Length > 0 Then
            list.Add("-s")
            list.Add("" & SSL.Text & ":" & SSO.Text & "")
        End If

        If fParam.Text.Length > 0 Then
            list.Add("-ffparams")
            list.Add("" & fParam.Text & "")
        End If

        If advParam.Text.Length > 0 Then
            list.Add("-adv")
            list.Add("" & advParam.Text & "")
        End If

        If outDir.Text.Length > 0 Then
            list.Add("-out")
            list.Add("" & outDir.Text & "")
        End If

        Return list.ToArray
    End Function


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text = ffmpeg_Script_Creator.Module1.ProcessFiles(compileArgs, True)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox2.Text = ffmpeg_Script_Creator.Module1.ProcessFiles(compileArgs, False)
    End Sub
End Class
