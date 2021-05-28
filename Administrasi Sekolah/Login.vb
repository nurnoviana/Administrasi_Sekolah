Imports System.Data.OleDb
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Color.Coral
        TransparencyKey = BackColor
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Ceklogin()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Ceklogin()
        Dim user() As String = {"Admin", "Tu", "Supervisor"}
        Dim login As Boolean
        Dim i As Integer
        i = 0
        login = False
        Call Sambungin()
        While (i <= 2 And login = False)
            cmd = New OleDbCommand("select * from " + user(i) + " where UserName= '" & Username.Text & "' and Password='" & Password.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                If rd.Item("UserName") <> Username.Text Or rd.Item("Password") <> Password.Text Then
                    MsgBox("Username atau Password salah")
                    Exit Sub
                Else
                    login = True
                End If
            Else
                i += 1
            End If
        End While

        If (login = True) Then
            MsgBox("Selamat Anda Berhasil Login")
            My.Settings.user = i
            If i = 0 Then
                Admin.Show()
            ElseIf i = 1 Then
                Tu.Show()
            Else
                Supervisor.Show()
            End If
            Me.Close()
        Else
            MsgBox("Username atau Password salah")
        End If
    End Sub
End Class
