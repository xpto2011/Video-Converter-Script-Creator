Imports gMKVToolNix
Imports System.IO

Public Class FFmpegCmd

    Public ReadOnly Property InputFile As String
    Public ReadOnly Property SubFilter As String
    Public ReadOnly Property MapOptions As String
    Public ReadOnly Property VideoEncoder As VideoEncoder
    Public ReadOnly Property AudioEncoder As AudioEncoder
    Public ReadOnly Property AdvancedOptions As String
    Public ReadOnly Property SubFile As String
    Public ReadOnly Property FFmpegParams As String
    Public ReadOnly Property OutputFile As String

    Public Sub New(ByVal inputfile As gMKVSegmentInfo, ByVal videoTrack As gMKVTrack, ByVal audioTrack As gMKVTrack, ByVal subtitleTrack As gMKVTrack,
                   Optional videoArgs As Dictionary(Of String, String) = Nothing, Optional audioArgs As Dictionary(Of String, String) = Nothing,
                   Optional advancedOpts As String = Nothing, Optional subFile As String = Nothing, Optional ffparams As String = Nothing)
        Me.InputFile = inputfile.Path
        MapOptions = String.Format("-map 0:{0} -map 0:{1}", videoTrack.TrackID, audioTrack.TrackID)
        If subtitleTrack.CodecID.Contains("PGS") Then
            SubFilter = String.Format("-filter_complex ""[0:v][0:{0}]overlay""", subtitleTrack.TrackID)
            AdvancedOptions = "-t " & MediaFile.GetVideoDuration(inputfile)
        Else
            Me.SubFile = String.Format("-vf {0}={1}", IIf(subtitleTrack.CodecID.Contains("ASS"), "ass", "subtitles"), subFile)
        End If
        If videoArgs Is Nothing Then
            VideoEncoder = New VideoEncoder(False, "hevc_nvenc", "slow", , 22, 20)
        ElseIf videoArgs.Item("Encoder") = "copy" Then
            VideoEncoder = New VideoEncoder(True)
        ElseIf videoArgs.Item("Encoder").Contains("nvenc") Then
            VideoEncoder = New VideoEncoder(False, videoArgs.Item("Encoder"), videoArgs.Item("Preset"),
                                            videoArgs.Item("PixelFormat"), videoArgs.Item("VideoQMax"),
                                            videoArgs.Item("VideoQMin"))
        Else
            VideoEncoder = New VideoEncoder(False, videoArgs.Item("Encoder"), videoArgs.Item("Preset"),
                                videoArgs.Item("PixelFormat"), videoArgs.Item("VideoQMax"))
        End If
        If audioArgs Is Nothing Then
            AudioEncoder = New AudioEncoder(True)
        ElseIf audioArgs.Item("Encoder") = "copy" Then
            AudioEncoder = New AudioEncoder(True)
        ElseIf audioArgs.ContainsKey("Channels") Then
            AudioEncoder = New AudioEncoder(False, audioArgs.Item("Encoder"), audioArgs.Item("Bitrate"), audioArgs.Item("Channels"))
        Else
            AudioEncoder = New AudioEncoder(False, audioArgs.Item("Encoder"), audioArgs.Item("Bitrate"))
        End If
        AdvancedOptions = IIf(AdvancedOptions = "", advancedOpts, AdvancedOptions + " " + advancedOpts)
        FFmpegParams = ffparams
        OutputFile = Path.Combine("..\Convert Cache\", Path.GetFileName(Me.InputFile))
    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("ffmpeg {0} -i ""{1}"" {2} {3} {4} {5} {6} {7} ""{8}""",
                             FFmpegParams,
                             InputFile,
                             SubFilter,
                             MapOptions,
                             VideoEncoder,
                             AudioEncoder,
                             AdvancedOptions,
                             SubFile,
                             OutputFile)
    End Function
End Class

Public Class VideoEncoder
    Public ReadOnly Property IsCopy As Boolean
    Public ReadOnly Property videoEncoder As String
    Public ReadOnly Property videoPreset As String
    Public ReadOnly Property pixelFormat As String
    Public ReadOnly Property videoQualityParams As String

    Public Sub New(IsCopy As Boolean, Optional videoEncoder As String = Nothing, Optional videoPreset As String = Nothing,
                   Optional pixelFormat As String = "yuv420p", Optional videoQualityMax As Integer = Nothing, Optional videoQualityMin As Integer = Nothing)
        If IsCopy = True Then
            Me.IsCopy = True
        Else
            Me.videoEncoder = videoEncoder
            Me.videoPreset = videoPreset
            If pixelFormat = Nothing Then
                Me.pixelFormat = "yuv420p"
            Else
                Me.pixelFormat = pixelFormat
            End If
            If videoEncoder.Contains("nvenc") Then
                videoQualityParams = String.Format("-rc vbr_hq -qmin:v {0} -qmax:v {1}", videoQualityMin, videoQualityMax)
            Else
                videoQualityParams = String.Format("-crf {0}", videoQualityMax)
            End If
        End If
    End Sub

    Public Overrides Function ToString() As String
        If IsCopy = False Then
            Return String.Format("-c:v {0} -preset:v {1} -pix_fmt {2} {3}",
                            videoEncoder,
                            videoPreset,
                            pixelFormat,
                            videoQualityParams)
        Else
            Return "-c:v copy"
        End If
    End Function
End Class

Public Class AudioEncoder
    Public ReadOnly Property IsCopy As Boolean
    Public ReadOnly Property audioEncoder As String
    Public ReadOnly Property audioBitrate As String
    Public ReadOnly Property audioChannels As Integer

    Public Sub New(IsCopy As Boolean, Optional audioEncoder As String = Nothing, Optional audioBitrate As String = Nothing, Optional audioChannels As Integer = 0)
        If IsCopy = True Then
            Me.IsCopy = True
        Else
            Me.audioEncoder = audioEncoder
            Me.audioBitrate = audioBitrate
            Me.audioChannels = audioChannels
        End If
    End Sub

    Public Overrides Function ToString() As String
        If IsCopy = False Then
            Return String.Format("-c:a {0} -b:a {1}K {2}",
                            audioEncoder,
                            audioBitrate,
                            IIf(audioChannels = 0, "", "-ac " & audioChannels))
        Else
            Return "-c:a copy"
        End If
    End Function
End Class
