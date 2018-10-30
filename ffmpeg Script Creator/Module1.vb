Imports System.IO
Imports gMKVToolNix

Module Module1

    Friend Const MKVTN_PATH = "C:\Program Files\MKVToolNix"

    Private args As String()

    Private subtitlesSettings As String
    Private videoSettings As Dictionary(Of String, String)
    Private audioSettings As Dictionary(Of String, String)
    Private advancedOpts As String = "-sn"
    Private ffmpegParams As String = ""

    Private cmdList As New Queue(Of String)
    'ARG(1): Working Dir

    'Requires:  gMKVToolNix.dll in the same folder as the executable
    '           MKVToolNix Path to be set (above)

    'Example
    '"%WorkingDir%" -v "videoencoder(or_copy);preset;pixel_format(opt);crf(max);vbr_min(opt)" 
    '               -a "language:order(opt);audioencoder(or_copy);160(bitrate);audiochannels(opt)" 
    '               -s "language:order" 
    '               -adv "-sn -profile:v high"
    '               -ffparams "-hwaccel cuvid -y"

    Sub Main()
        args = Environment.GetCommandLineArgs
        Directory.SetCurrentDirectory(args(1))

        Console.WriteLine(args(1))

        'Read Remaning console line args
        If args.Contains("-s") Then
            Dim i = Array.IndexOf(args, "-s")
            subtitlesSettings = args(i + 1)
        End If
        If args.Contains("-v") Then
            Dim i = Array.IndexOf(args, "-v")
            Dim s As String() = args(i + 1).Split(";")
            videoSettings = New Dictionary(Of String, String)
            videoSettings.Add("Encoder", s(0))
            If s(0) <> "copy" Then
                videoSettings.Add("Preset", s(1))
                If s(2) <> "" Then videoSettings.Add("PixelFormat", s(2)) Else videoSettings.Add("PixelFormat", "yuv420p")
                videoSettings.Add("VideoQMax", s(3))
                If s(0).Contains("nvenc") Then videoSettings.Add("VideoQMin", s(4))
            End If
        End If
        If args.Contains("-a") Then
            Dim i = Array.IndexOf(args, "-a")
            Dim s As String() = args(i + 1).Split(";")
            audioSettings = New Dictionary(Of String, String)
            If s(0) <> Nothing Then
                audioSettings.Add("AudioSelection", s(0))
            End If
            audioSettings.Add("Encoder", s(1))
            If s(1) <> "copy" Then
                If s(2) <> "" Then audioSettings.Add("Bitrate", s(2)) Else audioSettings.Add("Bitrate", "192")
                If s.Length = 4 Then audioSettings.Add("Channels", s(3))
            End If
        End If
        If args.Contains("-adv") Then
            Dim i = Array.IndexOf(args, "-adv")
            advancedOpts = args(i + 1)
        End If
        If args.Contains("-ffparams") Then
            ffmpegParams = args(Array.IndexOf(args, "-ffparams") + 1)
        End If

        For Each f In My.Computer.FileSystem.GetFiles(args(1), FileIO.SearchOption.SearchTopLevelOnly, "*.mkv")
            Dim mf As New MediaFile(f)
            Dim subtitleTrack As gMKVTrack
            Dim audioTrack As gMKVTrack
            If subtitlesSettings Is Nothing Then
                subtitleTrack = mf.GetSubToExtract
            Else
                subtitleTrack = mf.GetSubToExtract(False, subtitlesSettings.Split(":")(0), subtitlesSettings.Split(":")(1))
            End If
            If audioSettings Is Nothing OrElse audioSettings.ContainsKey("AudioSelection") = False Then
                audioTrack = mf.GetAudioToKeep
            Else
                audioTrack = mf.GetAudioToKeep(False, audioSettings.Item("AudioSelection").Split(":")(0), audioSettings.Item("AudioSelection").Split(":")(1))
            End If
            Dim subFile As String
            Dim requiresExtract As Boolean = MediaFile.SubRequiresExtract(subtitleTrack)
            If requiresExtract = True Then
                subFile = String.Format("sub.{0}", IIf(subtitleTrack.CodecID.Contains("ASS"), "ass", "srt"))
                cmdList.Enqueue(String.Format("mkvextract tracks ""{0}"" {1}:{2}", f, subtitleTrack.TrackID, subFile))
            End If
            Dim ffmpeg As New FFmpegCmd(mf.fileInfo, mf.videoTracks.First, audioTrack, subtitleTrack, videoSettings, audioSettings, advancedOpts, subFile, ffmpegParams)
            cmdList.Enqueue(ffmpeg.ToString)
            If requiresExtract = True Then
                cmdList.Enqueue(String.Format("del {0}", subFile))
            End If
        Next

        Dim sb As New Text.StringBuilder
        sb.AppendLine("@echo off")
        For Each l As String In cmdList
            sb.AppendLine(l)
        Next
        sb.AppendLine("pause")
        File.WriteAllText("Converter.bat", sb.ToString())
        Console.ReadLine()
    End Sub
End Module
