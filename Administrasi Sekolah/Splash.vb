Public Class splash
    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Color.Coral
        TransparencyKey = BackColor
        Timer1.Enabled = True
    End Sub
    Dim progress As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progress = progress + 10
        Progressbar.Width = progress
        If progress = 380 Then
            If My.Settings.user > 0 Then
                Home.Show()
                Me.Close()
            Else
                Login.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Progressbar_Click(sender As Object, e As EventArgs) Handles Progressbar.Click

    End Sub
End Class