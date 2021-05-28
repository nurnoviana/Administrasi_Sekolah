Imports System.Data.OleDb
Imports System.IO


Public Class Tu
    Private Sub Guru_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'FORMAT = Tambah("NAMA TABEL", "(URUTAN FIELD)", "'VALUENYA'")

        'Jika tidak pakai urutan field
        '"insert into Kelas values ('A','12')"
        CRUD.Tambah("Kelas", "", "'A','12'")

        'atau bisa ditambah urutan fieldnya
        '"insert into Kelas (ID,Nama) values ('A','12')"
        'Tambah("Kelas", "(ID,Nama)", "'A','12'")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        '"Update [Kelas] set [Nama]='13' where [ID]='A'"
        Ubah("Kelas", "[Nama]='13'", "[ID]='A'")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        '"delete From Kelas where ID='B'"
        Hapus("Kelas", "ID='B'")
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectTab(2)
        TabControl4.SelectTab(0)
        MuatPenugasan()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectTab(3)
        TabControl5.SelectTab(0)
        MuatPrestasi()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TabControl1.SelectTab(4)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TabControl1.SelectTab(5)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        VideoPanel.playlist.add("file:///" & My.Settings.Video)
        'Video_panel.playlist.add("file:/// F:\Bon Jovi - Rock in Rio 2017 - FULL CONCERT (1080p) - YouTube.MKV")
        TabControl2.SelectTab(1)
        VideoPanel.playlist.play()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

    End Sub


    Private Sub MuatPrestasi()
        DataPrestasi.DataSource = TampilTabel("Kejuaraan, Peringkat, Tgl, Tempat", "Prestasi", "").Tables("Prestasi")
        Dim Lebar() As Integer = {150, 100, 180, 180}
        LebarKolom(Lebar, DataPrestasi)
    End Sub


    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click

        Dim Field As String = "(Kejuaraan, Peringkat, Tgl, Tempat)"
        Dim Values As String = "'" & TextBox14.Text & "',
                                '" & TextBox13.Text & "',
                                '" & DateTimePicker3.Text & "',
                                '" & TextBox16.Text & "'"
        CRUD.Tambah("Prestasi", Field, Values)
        Kembali()
    End Sub

    Private Sub Clear()
        TextBox14.Clear()
        TextBox13.Clear()
        DateTimePicker3.ResetText()
        TextBox16.Clear()
    End Sub

    Private Sub Kembali()
        MuatPrestasi()
        Clear()
        TabControl5.SelectTab(0)

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Kembali()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Hapus("Prestasi", "ID='" + "'")
        Kembali()
    End Sub

    Private Sub DataPrestasi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataPrestasi.CellContentClick
        Dim i As Integer = Me.DataPrestasi.CurrentRow.Index
        Dim Data As DataTable = Tampil("ID, Kejuaraan, Peringkat, Tgl, Tempat", "Prestasi", "WHERE ID ='" + DataPrestasi.Rows.Item(i).Cells(0).Value + "'")
        TextBox7.Text = Data.Rows(0).Item(0)
        TextBox14.Text = Data.Rows(0).Item(1)
        TextBox13.Text = Data.Rows(0).Item(2)
        DateTimePicker3.Text = Data.Rows(0).Item(3)
        TextBox16.Text = Data.Rows(0).Item(4)
        TabControl5.SelectTab(1)
    End Sub

    Private Sub Tambah_Click(sender As Object, e As EventArgs) Handles Tambah.Click
        Dim Field As String = "(ID, Guru_NIP, Pelajaran_ID, Kelas, Tanggal)"
        Dim Values As String = "'" & TextBox11.Text & "', 
                                '" & TextBox12.Text & "', 
                                '" & TextBox10.Text & "', 
                                '" & TextBox9.Text & "', 
                                '" & DateTimePicker4.Text & "'"
        CRUD.Tambah("Mengajar", Field, Values)
        KembaliPenugasan()
    End Sub

    Private Sub KembaliPenugasan()
        MuatPenugasan()
        ClearPenugasan()
        TabControl4.SelectTab(0)

    End Sub

    Private Sub ClearPenugasan()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox10.Clear()
        TextBox9.Clear()
        DateTimePicker4.ResetText()
    End Sub

    Private Sub MuatPenugasan()
        DataPenugasan.DataSource = TampilTabel("ID, Guru_NIP, Pelajaran_ID, Kelas, Tanggal", "Mengajar", "").Tables("Mengajar")
        Dim Lebar() As Integer = {90, 150, 90, 90, 180}
        LebarKolom(Lebar, DataPenugasan)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        KembaliPenugasan()
    End Sub

    Private Sub DataPenugasan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataPenugasan.CellContentClick
        Dim i As Integer = Me.DataPenugasan.CurrentRow.Index
        Dim Data As DataTable = Tampil("ID, Guru_NIP, Pelajaran_ID, Kelas, Tanggal", "Mengajar", "WHERE ID ='" + DataPenugasan.Rows.Item(i).Cells(0).Value + "'")
        TextBox11.Text = Data.Rows(0).Item(0)
        TextBox12.Text = Data.Rows(0).Item(1)
        TextBox10.Text = Data.Rows(0).Item(2)
        TextBox9.Text = Data.Rows(0).Item(3)
        DateTimePicker4.Text = Data.Rows(0).Item(4)
        TabControl4.SelectTab(1)
    End Sub
    Private Sub KembaliSPP()
        MuatSPP()
        ClearSPP()
        TabControl3.SelectTab(0)
    End Sub

    Private Sub ClearSPP()
        TextBox1.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        DateTimePicker1.ResetText()
        TextBox10.Clear()
    End Sub

    Private Sub MuatSPP()
        DataSPP.DataSource = TampilTabel("ID, Nama_siswa, Kelas, Tanggal, Nominal", "SPP", "").Tables("SPP")
        Dim Lebar() As Integer = {150, 100, 180, 90, 90}
        LebarKolom(Lebar, DataSPP)
    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        KembaliSPP()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Hapus("Mengajar", "ID='" + TextBox11.Text + "'")
        KembaliPenugasan()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TabControl2.SelectTab(0)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        VideoPanel.playlist.play()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        VideoPanel.playlist.togglePause()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        VideoPanel.playlist.stop()
    End Sub
End Class