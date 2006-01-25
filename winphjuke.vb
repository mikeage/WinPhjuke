Imports System.Net.Sockets
Imports System.Text
Imports System.IO
Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents address As System.Windows.Forms.TextBox
    Friend WithEvents port As System.Windows.Forms.TextBox
    Friend WithEvents connect As System.Windows.Forms.Button
    Friend WithEvents Refresh As System.Windows.Forms.Button
    Friend WithEvents artist As System.Windows.Forms.TextBox
    Friend WithEvents album As System.Windows.Forms.TextBox
    Friend WithEvents track As System.Windows.Forms.TextBox
    Friend WithEvents position As System.Windows.Forms.ProgressBar
    Friend WithEvents positiontext As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PlayButton As System.Windows.Forms.Button
    Friend WithEvents PauseButton As System.Windows.Forms.Button
    Friend WithEvents StopButton As System.Windows.Forms.Button
    Friend WithEvents NextButton As System.Windows.Forms.Button
    Friend WithEvents PrevButton As System.Windows.Forms.Button
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.position = New System.Windows.Forms.ProgressBar
        Me.address = New System.Windows.Forms.TextBox
        Me.port = New System.Windows.Forms.TextBox
        Me.artist = New System.Windows.Forms.TextBox
        Me.album = New System.Windows.Forms.TextBox
        Me.connect = New System.Windows.Forms.Button
        Me.Refresh = New System.Windows.Forms.Button
        Me.track = New System.Windows.Forms.TextBox
        Me.positiontext = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.PlayButton = New System.Windows.Forms.Button
        Me.PauseButton = New System.Windows.Forms.Button
        Me.StopButton = New System.Windows.Forms.Button
        Me.NextButton = New System.Windows.Forms.Button
        Me.PrevButton = New System.Windows.Forms.Button
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'position
        '
        Me.position.Location = New System.Drawing.Point(16, 120)
        Me.position.Name = "position"
        Me.position.Size = New System.Drawing.Size(264, 8)
        Me.position.Step = 1
        Me.position.TabIndex = 0
        '
        'address
        '
        Me.address.Location = New System.Drawing.Point(8, 8)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(136, 20)
        Me.address.TabIndex = 1
        Me.address.Text = "192.168.1.111"
        '
        'port
        '
        Me.port.Location = New System.Drawing.Point(152, 8)
        Me.port.Name = "port"
        Me.port.Size = New System.Drawing.Size(56, 20)
        Me.port.TabIndex = 2
        Me.port.Text = "4083"
        '
        'artist
        '
        Me.artist.Location = New System.Drawing.Point(56, 48)
        Me.artist.Name = "artist"
        Me.artist.ReadOnly = True
        Me.artist.Size = New System.Drawing.Size(224, 20)
        Me.artist.TabIndex = 3
        Me.artist.Text = "<Unknown>"
        '
        'album
        '
        Me.album.Location = New System.Drawing.Point(56, 72)
        Me.album.Name = "album"
        Me.album.ReadOnly = True
        Me.album.Size = New System.Drawing.Size(224, 20)
        Me.album.TabIndex = 4
        Me.album.Text = "<Unknown>"
        '
        'connect
        '
        Me.connect.Location = New System.Drawing.Point(224, 8)
        Me.connect.Name = "connect"
        Me.connect.Size = New System.Drawing.Size(56, 24)
        Me.connect.TabIndex = 5
        Me.connect.Text = "&Connect"
        '
        'Refresh
        '
        Me.Refresh.Enabled = False
        Me.Refresh.Location = New System.Drawing.Point(224, 136)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(56, 24)
        Me.Refresh.TabIndex = 6
        Me.Refresh.Text = "Refresh"
        '
        'track
        '
        Me.track.Location = New System.Drawing.Point(56, 96)
        Me.track.Name = "track"
        Me.track.ReadOnly = True
        Me.track.Size = New System.Drawing.Size(224, 20)
        Me.track.TabIndex = 7
        Me.track.Text = "<Unknown>"
        '
        'positiontext
        '
        Me.positiontext.Location = New System.Drawing.Point(56, 136)
        Me.positiontext.Name = "positiontext"
        Me.positiontext.ReadOnly = True
        Me.positiontext.Size = New System.Drawing.Size(88, 20)
        Me.positiontext.TabIndex = 8
        Me.positiontext.Text = "<Unknown>"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Artist"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Album"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Track"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Position"
        '
        'PlayButton
        '
        Me.PlayButton.Enabled = False
        Me.PlayButton.Location = New System.Drawing.Point(8, 168)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(48, 24)
        Me.PlayButton.TabIndex = 10
        Me.PlayButton.Text = "Play"
        '
        'PauseButton
        '
        Me.PauseButton.Enabled = False
        Me.PauseButton.Location = New System.Drawing.Point(64, 168)
        Me.PauseButton.Name = "PauseButton"
        Me.PauseButton.Size = New System.Drawing.Size(48, 24)
        Me.PauseButton.TabIndex = 11
        Me.PauseButton.Text = "Pause"
        '
        'StopButton
        '
        Me.StopButton.Enabled = False
        Me.StopButton.Location = New System.Drawing.Point(120, 168)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(48, 24)
        Me.StopButton.TabIndex = 12
        Me.StopButton.Text = "Stop"
        '
        'NextButton
        '
        Me.NextButton.Enabled = False
        Me.NextButton.Location = New System.Drawing.Point(176, 168)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(48, 24)
        Me.NextButton.TabIndex = 13
        Me.NextButton.Text = "Next"
        '
        'PrevButton
        '
        Me.PrevButton.Enabled = False
        Me.PrevButton.Location = New System.Drawing.Point(232, 168)
        Me.PrevButton.Name = "PrevButton"
        Me.PrevButton.Size = New System.Drawing.Size(48, 24)
        Me.PrevButton.TabIndex = 14
        Me.PrevButton.Text = "Prev"
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(168, 136)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(40, 24)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "CheckBox1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(290, 199)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.PrevButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.PauseButton)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.positiontext)
        Me.Controls.Add(Me.track)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.connect)
        Me.Controls.Add(Me.album)
        Me.Controls.Add(Me.artist)
        Me.Controls.Add(Me.port)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.position)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "WinPhJuke 1.0"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim tc As New TcpClient
    Dim ns As NetworkStream
    Dim sr As StreamReader

    Public Declare Sub Sleep Lib "kernel32" Alias "Sleep" (ByVal dwMilliseconds As Long)
    Private Sub connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles connect.Click

        Try
            tc.Connect(address.Text, port.Text)
            ns = tc.GetStream()
            sr = New StreamReader(ns)
            '            StatusBar.Panels(0).Text = "Ready to send"
            '            StatusBar.Panels(1).Text = "Connected"
            Refresh.Enabled = True
            PlayButton.Enabled = True
            PauseButton.Enabled = True
            StopButton.Enabled = True
            NextButton.Enabled = True
            PrevButton.Enabled = True

        Catch ex As Exception
            MsgBox("Error connecting to " & address.Text & ":" & port.Text & Chr(13) & Chr(10) & ". ERROR: " & ex.Message)
            '           StatusBar.Panels(0).Text = "Connection Failed"
            '          StatusBar.Panels(1).Text = "Not Connected"
            Refresh.Enabled = False


            Return
        End Try
    End Sub

    Private Sub Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Refresh.Click
        Dim command As String = "status" & Chr(13)
        Dim result As String
        Dim szCommand() As Byte = System.Text.Encoding.ASCII.GetBytes(command.ToCharArray())
        Dim bytesRead
        Dim gotStatus As Boolean

        sr.DiscardBufferedData()
        ns.Write(szCommand, 0, szCommand.Length)

        Dim resultArray() As String
        Dim curLine
        gotStatus = False
        While (gotStatus = False)
            curLine = sr.ReadLine()
            If RegularExpressions.Regex.Match(curLine, "^[25]00 [a-zA-Z]+$").Success = True Then
                gotStatus = True
            End If
            result = result + curLine + Chr(13)
            resultArray = result.Split(Chr(13))
        End While
        If resultArray(0) = "mode stop" Then
            artist.Text = "Stopped"
            album.Text = "Stopped"
            track.Text = "Stopped"
            position.Maximum = 1
            position.Value = 0
        ElseIf resultArray(0) = "mode play" Then
            For curLine = 1 To (resultArray.Length() - 1)
                If resultArray(curLine).StartsWith("artist") = True Then
                    artist.Text = resultArray(curLine).Substring(7)
                ElseIf resultArray(curLine).StartsWith("track") = True Then
                    track.Text = resultArray(curLine).Substring(6)
                ElseIf resultArray(curLine).StartsWith("album") = True Then
                    album.Text = resultArray(curLine).Substring(6)
                ElseIf resultArray(curLine).StartsWith("length") = True Then
                    position.Maximum = resultArray(curLine).Substring(7)
                ElseIf resultArray(curLine).StartsWith("time") = True Then
                    If resultArray(curLine).Substring(5) > position.Maximum Then
                        ' Usually indicates we haven't yet received a max value
                        position.Maximum = resultArray(curLine).Substring(5)
                    End If
                    position.Value = resultArray(curLine).Substring(5)
                End If
            Next
            positiontext.Text = position.Value & " / " & position.Maximum

        Else
            'artist.Text = "ERROR!"
        End If
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PauseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PauseButton.Click
        Dim command As String = "pause" & Chr(13)
        Dim szCommand() As Byte = System.Text.Encoding.ASCII.GetBytes(command.ToCharArray())
        ns.Write(szCommand, 0, szCommand.Length)
    End Sub

    Private Sub PlayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayButton.Click
        Dim command As String = "play" & Chr(13)
        Dim szCommand() As Byte = System.Text.Encoding.ASCII.GetBytes(command.ToCharArray())
        ns.Write(szCommand, 0, szCommand.Length)
    End Sub

    Private Sub StopButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopButton.Click
        Dim command As String = "stop" & Chr(13)
        Dim szCommand() As Byte = System.Text.Encoding.ASCII.GetBytes(command.ToCharArray())
        ns.Write(szCommand, 0, szCommand.Length)

    End Sub

    Private Sub NextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextButton.Click
        Dim command As String = "next" & Chr(13)
        Dim szCommand() As Byte = System.Text.Encoding.ASCII.GetBytes(command.ToCharArray())
        ns.Write(szCommand, 0, szCommand.Length)

    End Sub

    Private Sub PrevButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrevButton.Click
        Dim command As String = "prev" & Chr(13)
        Dim szCommand() As Byte = System.Text.Encoding.ASCII.GetBytes(command.ToCharArray())
        ns.Write(szCommand, 0, szCommand.Length)

    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        Refresh_Click(sender, e)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Timer.Enabled = True
        Else
            Timer.Enabled = False

        End If
    End Sub
End Class
