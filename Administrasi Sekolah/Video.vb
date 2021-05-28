Public Class Video
    Private Sub Path_Click(sender As Object, e As EventArgs) Handles Path.Click
        'D:\download\Video\Dream Theater - The spirit carries on (Live Wacken 2015) - YouTube.MP4
        Video_panel.playlist.add("file:///" & Path_tb.Text)
    End Sub

    Private Sub Play_Click(sender As Object, e As EventArgs) Handles Play.Click
        Video_panel.playlist.play()
    End Sub

    Private Sub Pause_Click(sender As Object, e As EventArgs) Handles Pause.Click
        Video_panel.playlist.togglePause()
    End Sub

    Private Sub Stop_btn_Click(sender As Object, e As EventArgs) Handles Stop_btn.Click
        Video_panel.playlist.stop()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Home.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "(*.mp4)|*.mp4"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Video_panel.playlist.add("file:///" & OpenFileDialog1.FileName)
        End If
    End Sub
End Class