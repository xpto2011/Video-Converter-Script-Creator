<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.vQMax = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.vCRF = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.vPFormat = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.vPreset = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.vEncoder = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.aCha = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.aBitrate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.aEncoder = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ASL = New System.Windows.Forms.TextBox()
        Me.ASO = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SSO = New System.Windows.Forms.TextBox()
        Me.SSL = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.advParam = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.outDir = New System.Windows.Forms.TextBox()
        Me.fParam = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(57, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(464, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(527, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 20)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Folder:"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 40)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(584, 79)
        Me.TextBox2.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.vQMax)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.vCRF)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.vPFormat)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.vPreset)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.vEncoder)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 125)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(189, 156)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Video"
        '
        'vQMax
        '
        Me.vQMax.Location = New System.Drawing.Point(125, 124)
        Me.vQMax.Name = "vQMax"
        Me.vQMax.Size = New System.Drawing.Size(56, 20)
        Me.vQMax.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "QMax"
        '
        'vCRF
        '
        Me.vCRF.Location = New System.Drawing.Point(125, 98)
        Me.vCRF.Name = "vCRF"
        Me.vCRF.Size = New System.Drawing.Size(56, 20)
        Me.vCRF.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "CRF/QMin"
        '
        'vPFormat
        '
        Me.vPFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.vPFormat.FormattingEnabled = True
        Me.vPFormat.Items.AddRange(New Object() {"yuv420p", "yuv420p10le", "yuv422p10le", "yuv444p10le", "p016le"})
        Me.vPFormat.Location = New System.Drawing.Point(85, 71)
        Me.vPFormat.Name = "vPFormat"
        Me.vPFormat.Size = New System.Drawing.Size(96, 21)
        Me.vPFormat.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Pixel Format"
        '
        'vPreset
        '
        Me.vPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.vPreset.FormattingEnabled = True
        Me.vPreset.Items.AddRange(New Object() {"ultrafast", "superfast", "veryfast", "faster", "fast", "medium", "slow", "slower", "veryslow"})
        Me.vPreset.Location = New System.Drawing.Point(85, 44)
        Me.vPreset.Name = "vPreset"
        Me.vPreset.Size = New System.Drawing.Size(96, 21)
        Me.vPreset.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Preset"
        '
        'vEncoder
        '
        Me.vEncoder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.vEncoder.FormattingEnabled = True
        Me.vEncoder.Items.AddRange(New Object() {"libx264", "libx265", "h264_nvenc", "hevc_nvenc", "copy"})
        Me.vEncoder.Location = New System.Drawing.Point(85, 17)
        Me.vEncoder.Name = "vEncoder"
        Me.vEncoder.Size = New System.Drawing.Size(96, 21)
        Me.vEncoder.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Encoder"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ASO)
        Me.GroupBox2.Controls.Add(Me.ASL)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.aEncoder)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.aCha)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.aBitrate)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(210, 125)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(189, 156)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Audio"
        '
        'aCha
        '
        Me.aCha.Location = New System.Drawing.Point(126, 73)
        Me.aCha.Name = "aCha"
        Me.aCha.Size = New System.Drawing.Size(54, 20)
        Me.aCha.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Channels"
        '
        'aBitrate
        '
        Me.aBitrate.Location = New System.Drawing.Point(126, 47)
        Me.aBitrate.Name = "aBitrate"
        Me.aBitrate.Size = New System.Drawing.Size(54, 20)
        Me.aBitrate.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Bitrate"
        '
        'aEncoder
        '
        Me.aEncoder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.aEncoder.FormattingEnabled = True
        Me.aEncoder.Items.AddRange(New Object() {"flac", "libfdk_aac", "aac", "libopus", "libvorbis", "copy"})
        Me.aEncoder.Location = New System.Drawing.Point(84, 20)
        Me.aEncoder.Name = "aEncoder"
        Me.aEncoder.Size = New System.Drawing.Size(96, 21)
        Me.aEncoder.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Encoder"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Audio Lang Order"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Audio Lang"
        '
        'ASL
        '
        Me.ASL.Location = New System.Drawing.Point(126, 101)
        Me.ASL.Name = "ASL"
        Me.ASL.Size = New System.Drawing.Size(54, 20)
        Me.ASL.TabIndex = 19
        '
        'ASO
        '
        Me.ASO.Location = New System.Drawing.Point(126, 128)
        Me.ASO.Name = "ASO"
        Me.ASO.Size = New System.Drawing.Size(54, 20)
        Me.ASO.TabIndex = 20
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SSO)
        Me.GroupBox3.Controls.Add(Me.SSL)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(405, 125)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(189, 156)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Subtitles"
        '
        'SSO
        '
        Me.SSO.Location = New System.Drawing.Point(126, 47)
        Me.SSO.Name = "SSO"
        Me.SSO.Size = New System.Drawing.Size(54, 20)
        Me.SSO.TabIndex = 20
        '
        'SSL
        '
        Me.SSL.Location = New System.Drawing.Point(126, 20)
        Me.SSL.Name = "SSL"
        Me.SSL.Size = New System.Drawing.Size(54, 20)
        Me.SSL.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Subtitles Lang Order"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Subtitles Lang"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(22, 316)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Additional Parameters:"
        '
        'advParam
        '
        Me.advParam.Location = New System.Drawing.Point(140, 313)
        Me.advParam.Name = "advParam"
        Me.advParam.Size = New System.Drawing.Size(456, 20)
        Me.advParam.TabIndex = 23
        Me.advParam.Text = "-sn"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(60, 342)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Output Folder:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(527, 339)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 20)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'outDir
        '
        Me.outDir.Location = New System.Drawing.Point(140, 339)
        Me.outDir.Name = "outDir"
        Me.outDir.Size = New System.Drawing.Size(381, 20)
        Me.outDir.TabIndex = 24
        '
        'fParam
        '
        Me.fParam.Location = New System.Drawing.Point(140, 287)
        Me.fParam.Name = "fParam"
        Me.fParam.Size = New System.Drawing.Size(456, 20)
        Me.fParam.TabIndex = 28
        Me.fParam.Text = "-y"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(30, 290)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "FFmpeg Parameters:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(440, 365)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Verify"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(521, 365)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "Create"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 396)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.fParam)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.outDir)
        Me.Controls.Add(Me.advParam)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FFmpeg Script Creator GUI"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents vCRF As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents vPFormat As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents vPreset As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents vEncoder As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents vQMax As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents aCha As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents aBitrate As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ASO As TextBox
    Friend WithEvents ASL As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents aEncoder As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents SSO As TextBox
    Friend WithEvents SSL As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents advParam As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents outDir As TextBox
    Friend WithEvents fParam As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
