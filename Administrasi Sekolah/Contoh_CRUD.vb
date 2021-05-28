Imports System.Data.OleDb
Public Class Crudform
    Private Sub CRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tampil()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Home.Show()
        Me.Close()
    End Sub

    Private Sub Tambah_Click(sender As Object, e As EventArgs) Handles Tambah.Click
        Dim CMD As OleDbCommand
        Call Sambungin()
        Dim simpan As String = "insert into Admin values ('" & User.Text & "','" & Pass.Text & "')"
        CMD = New OleDbCommand(simpan, Conn)
        CMD.ExecuteNonQuery()
        MsgBox("Input data berhasil")
        Tampil()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Call Sambungin()
        Dim CMD As OleDbCommand
        Dim hapus As String = "delete From Admin where UserName='" & User.Text & "'"
        CMD = New OleDbCommand(hapus, Conn)
        CMD.ExecuteNonQuery()
        MsgBox("Delete data berhasil")
        Tampil()
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        Call Sambungin()
        Dim CMD As OleDbCommand
        Dim ubah As String = "Update [Admin] set [Password]='" & Pass.Text & "' where [UserName]='" & User.Text & "'"
        CMD = New OleDbCommand(ubah, Conn)
        CMD.ExecuteNonQuery()
        MsgBox("Data Berhasil diUpdate")
        Tampil()
    End Sub

    Private Sub Tampil()
        Sambungin()
        da = New OleDbDataAdapter("Select * from Admin", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Admin")
        DataGridView1.DataSource = (ds.Tables("Admin"))
    End Sub
End Class