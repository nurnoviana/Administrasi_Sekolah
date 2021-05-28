Imports System.Data.OleDb
Imports System.IO
Public Class Contoh
    Public Function ConvertImage(ByVal myImage As Image) As Byte()
        Dim mstream As New IO.MemoryStream
        myImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Png)

        Dim myBytes(mstream.Length - 1) As Byte
        mstream.Position = 0
        mstream.Read(myBytes, 0, mstream.Length)

        Return myBytes
    End Function
    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        Nis.Clear()
        Nama.Clear()
        Kelas.Clear()
        Alamat.Clear()
        Photo.Image = Nothing
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Cari_photo.Filter = "JPG|*.JPG|BMP|*.BMP|GIF|*.GIF|PNG|*.PNG"
        Cari_photo.RestoreDirectory = True
        Cari_photo.ShowDialog()
        If Cari_photo.FileName = "" Then Exit Sub
        Photo.ImageLocation = Cari_photo.FileName
    End Sub

    Private Sub Ambil_Click(sender As Object, e As EventArgs) Handles Ambil.Click
        Muat()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Dim CMD As OleDbCommand
        Dim vImage As Byte() = ConvertImage(Photo.Image)
        Call Sambungin()
        Dim Simpan As String = "insert into Siswa (NIS, Nama, Kelas, Ttl, Alamat, Photo) values ('" & Nis.Text & "', '" & Nama.Text & "', '" & Kelas.Text & "', '" & Tgl.Text & "','" & Alamat.Text & "', @photo)"
        CMD = New OleDbCommand(Simpan, Conn)
        CMD.Parameters.Add(New OleDb.OleDbParameter("@photo", vImage))
        CMD.ExecuteNonQuery()
        MsgBox("Simpan data sukses...!", MsgBoxStyle.Information, "SELAMAT")
        Muat()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        On Error Resume Next
        Dim i As Integer
        i = Me.DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)
            Dim buffer() As Byte = CType(.Cells(5).Value, Byte())
            Dim str As New MemoryStream(buffer)
            Me.Nis.Text = .Cells(0).Value
            Me.Nama.Text = .Cells(1).Value
            Me.Kelas.Text = .Cells(2).Value
            Me.Tgl.Text = .Cells(3).Value
            Me.Alamat.Text = .Cells(4).Value
            Me.Photo.Image = Image.FromStream(str)
        End With
    End Sub

    Private Sub Perbarui_Click(sender As Object, e As EventArgs) Handles Perbarui.Click
        Call Sambungin()
        Dim vImage As Byte() = ConvertImage(Photo.Image)
        Dim CMD As OleDbCommand
        Dim ubah As String = "Update [Siswa] set [Photo]= @photo where [NIS]='" & Nis.Text & "'"
        CMD = New OleDbCommand(ubah, Conn)
        CMD.Parameters.Add(New OleDb.OleDbParameter("@photo", vImage))
        CMD.ExecuteNonQuery()
        MsgBox("Data Berhasil diUpdate")
        Muat()
    End Sub

    Private Sub Siswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Muat()
    End Sub

    Private Sub Muat()
        Call Sambungin()
        da = New OleDbDataAdapter("SELECT NIS, Nama, Kelas, Tgl, Alamat, Photo AS [Photo] FROM Siswa", Conn)
        ds = New DataSet
        da.Fill(ds, "Siswa")
        DataGridView1.DataSource = ds.Tables("Siswa")
        DataGridView1.Columns(0).Width = 90
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 90
        DataGridView1.Columns(3).Width = 90
        DataGridView1.Columns(4).Width = 99
        DataGridView1.Columns(5).Width = 90
    End Sub

End Class