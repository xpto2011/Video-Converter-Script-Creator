Imports gMKVToolNix
Imports System.Text.RegularExpressions

Public Class MediaFile

    Public ReadOnly Property fileInfo As gMKVSegmentInfo
    Public ReadOnly Property videoTracks As New List(Of gMKVTrack)
    Public ReadOnly Property audioTracks As New List(Of gMKVTrack)
    Public ReadOnly Property subtitleTracks As New List(Of gMKVTrack)
    Public ReadOnly Property attachments As New List(Of gMKVAttachment)
    Public ReadOnly Property chapters As gMKVChapter

    Public Sub New(file As String)
        Dim segs As List(Of gMKVSegment) = gMKVHelper.GetMergedMkvSegmentList(MKVTN_PATH, file)

        For Each seg In segs
            If TryCast(seg, gMKVSegmentInfo) IsNot Nothing Then
                Console.WriteLine(CType(seg, gMKVSegmentInfo).Path)
            Else
                Console.WriteLine(seg.ToString)
            End If
            If TryCast(seg, gMKVSegmentInfo) IsNot Nothing Then
                fileInfo = seg
            ElseIf TryCast(seg, gMKVTrack) IsNot Nothing Then
                Dim track As gMKVTrack = CType(seg, gMKVTrack)
                If track.TrackType = MkvTrackType.video Then
                    videoTracks.Add(track)
                ElseIf track.TrackType = MkvTrackType.audio Then
                    audioTracks.Add(track)
                Else
                    subtitleTracks.Add(track)
                End If
            ElseIf TryCast(seg, gMKVAttachment) IsNot Nothing Then
                attachments.Add(CType(seg, gMKVAttachment))
            ElseIf TryCast(seg, gMKVChapter) IsNot Nothing Then
                chapters = CType(seg, gMKVChapter)
            End If
        Next
    End Sub

    Public Function GetSubToExtract(Optional first As Boolean = True, Optional lang As String = "eng", Optional number As Integer = 1) As gMKVTrack
        If first = True Then
            Return subtitleTracks.First
        Else
            Dim counter As Integer = 1
            For Each st In subtitleTracks
                If st.Language = lang And number = counter Then
                    Return st
                ElseIf st.Language = lang And number <> counter Then
                    counter += 1
                End If
            Next
        End If
        Return Nothing
    End Function

    Public Function GetAudioToKeep(Optional first As Boolean = True, Optional lang As String = "jpn", Optional number As Integer = 1) As gMKVTrack
        If first = True Then
            Return audioTracks.First
        Else
            Dim counter As Integer = 1
            For Each at In audioTracks
                If at.Language = lang And number = counter Then
                    Return at
                ElseIf at.Language = lang And number <> counter Then
                    counter += 1
                End If
            Next
        End If
        Return Nothing
    End Function

    Public Shared Function SubRequiresExtract(Subtitle As gMKVTrack) As String
        If Subtitle.CodecID.Contains("ASS") Or Subtitle.CodecID.Contains("UTF8") Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function GetVideoDuration(InfoSegment As gMKVSegmentInfo) As String
        Dim duration As String = InfoSegment.Duration
        Dim RegexString As String = "(\d+.\d+)s"
        Dim match As Match = Regex.Match(duration, RegexString)
        If match.Success = True Then
            Return match.Groups(1).ToString
        Else
            Return Nothing
        End If
    End Function
End Class
