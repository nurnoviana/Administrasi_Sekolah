Imports System.Data.OleDb
Module CRUD
    Dim CMD As OleDbCommand

    Public Sub Tambah(ByVal tabel As String, ByVal field As String, ByVal value As String)
        'untuk tambah data tanpa foto
        Dim command As String = "INSERT INTO " + tabel + " " + field + " VALUES " + "(" + value + ")"
        Eksekusi(command)
        MsgBox("Simpan Data Sukses!", MsgBoxStyle.Information, "SELAMAT")
    End Sub

    Public Sub Tambah_Gambar(ByVal tabel As String, ByVal field As String, ByVal value As String, ByVal photo As PictureBox)
        'untuk tambah data dengan foto
        Call Sambungin()
        Dim vImage As Byte() = ConvertImage(photo.Image)
        Dim command As String = "INSERT INTO " + tabel + " " + field + " VALUES " + "(" + value + ",@photo)"
        CMD = New OleDbCommand(command, Conn)
        CMD.Parameters.Add(New OleDb.OleDbParameter("@photo", vImage))
        CMD.ExecuteNonQuery()
        MsgBox("Simpan Data Sukses!", MsgBoxStyle.Information, "SELAMAT")
    End Sub

    Public Sub Ubah(ByVal tabel As String, ByVal data As String, ByVal kondisi As String)
        'Ubah(<TABEL>, <data misal--> [Password]='123'> , KONDISI)
        'Dim ubah As String = "Update [Admin] set [Password]='" & Pass.Text & "' where [UserName]='" & User.Text & "'"
        Dim command As String = "Update [" + tabel + "] SET " + data + " WHERE " + "(" + kondisi + ")"
        Eksekusi(command)
        MsgBox("Data Berhasil Di Update!", MsgBoxStyle.Information, "SELAMAT")
    End Sub

    Public Sub Ubah_Gambar(ByVal tabel As String, ByVal data As String, ByVal kondisi As String, ByVal Photo As PictureBox)
        Call Sambungin()
        Dim vImage As Byte() = ConvertImage(Photo.Image)
        Dim command As String = "Update [" + tabel + "] SET " + data + ", [Photo]= @photo  WHERE " + "(" + kondisi + ")"
        CMD = New OleDbCommand(command, Conn)
        CMD.Parameters.Add(New OleDb.OleDbParameter("@photo", vImage))
        CMD.ExecuteNonQuery()
        MsgBox("Data Berhasil Di Update!", MsgBoxStyle.Information, "SELAMAT")
    End Sub

    Public Sub Hapus(ByVal tabel As String, ByVal kondisi As String)
        Dim command As String = "DELETE FROM " + tabel + " WHERE " + kondisi
        Eksekusi(command)
        MsgBox("Hapus Data Sukses!", MsgBoxStyle.Information, "SELAMAT")
    End Sub

    Public Function TampilTabel(ByVal field As String, ByVal tabel As String, ByVal kondisi As String) As DataSet
        'menampilkan data ke datagridview
        Call Sambungin()
        da = New OleDbDataAdapter("SELECT " + field + " FROM " + tabel + " " + kondisi, Conn)
        ds = New DataSet
        da.Fill(ds, tabel)
        Return ds
    End Function

    Public Function Tampil(ByVal field As String, tabel As String, kondisi As String) As DataTable
        'menampilkan data selain ke datagridview; misal textbox dll
        Call Sambungin()
        Dim DSet As New DataSet
        Dim DTabel As New DataTable
        da = New OleDbDataAdapter("SELECT " + field + " FROM " + tabel + " " + kondisi, Conn)
        DSet.Tables.Add(DTabel)
        da.Fill(DTabel)
        Return DTabel
    End Function

    Public Sub LebarKolom(ByVal array As Array, tabel As DataGridView)
        'mengatur lebar kolom
        For i = 0 To array.Length - 1
            tabel.Columns(i).Width = array(i)
        Next
    End Sub

    Private Sub Eksekusi(ByVal Command As String)
        Call Sambungin()
        CMD = New OleDbCommand(Command, Conn)
        CMD.ExecuteNonQuery()
    End Sub

    Public Function ConvertImage(ByVal myImage As Image) As Byte()
        Dim mstream As New IO.MemoryStream
        myImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Png)
        Dim myBytes(mstream.Length - 1) As Byte
        mstream.Position = 0
        mstream.Read(myBytes, 0, mstream.Length)
        Return myBytes
    End Function
End Module
