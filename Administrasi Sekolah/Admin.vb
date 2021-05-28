Imports System.Data.OleDb
Imports System.IO
Public Class Admin
    Dim CurrentFont As FontFamily
    Dim CurrentSize As Single
    Dim CurrentForeColor As Color

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CurrentSize = Editor.SelectionFont.Size
    End Sub

    Private Sub B_user_Click(sender As Object, e As EventArgs) Handles B_user.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub B_siswa_Click(sender As Object, e As EventArgs) Handles B_siswa.Click
        TabControl1.SelectTab(1)
        MuatSiswa()
    End Sub

    Private Sub B_guru_Click(sender As Object, e As EventArgs) Handles B_guru.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub B_pel_Click(sender As Object, e As EventArgs) Handles B_pel.Click
        TabControl1.SelectTab(3)
    End Sub

    Private Sub B_kelas_Click(sender As Object, e As EventArgs) Handles B_kelas.Click
        TabControl1.SelectTab(4)
    End Sub

    Private Sub B_prof_Click(sender As Object, e As EventArgs) Handles B_prof.Click
        Editor.LoadFile("Profile.rtf")
        TabControl1.SelectTab(5)
    End Sub

    Private Sub B_log_Click(sender As Object, e As EventArgs) Handles B_log.Click
        TabControl1.SelectTab(6)
    End Sub

    Private Sub B_db_Click(sender As Object, e As EventArgs) Handles B_db.Click
        TabControl1.SelectTab(7)
    End Sub

    Private Sub B_logout_Click(sender As Object, e As EventArgs) Handles B_logout.Click

    End Sub

    '###################################### LOAD DATA #############################################
    Private Sub MuatSiswa()
        '"SELECT NIS, Nama, Jk, Kelas, Tgl, Alamat, Photo AS [Photo] FROM Siswa" =====> CONTOH SYNTAX

        ' <NAMA DATAGRIDVIEW>.Datasource = TampilTabel("<NAMA FIELD YANG INGIN DITAMPILKAN>", "<NAMA TABEL>", "").Tables("<NAMA TABEL>")
        Datasiswa.DataSource = TampilTabel("NIS, Nama, Jk, Kelas, Tgl, Alamat", "Siswa", "").Tables("Siswa")
        Dim Lebar() As Integer = {90, 150, 90, 90, 99, 110} 'SETTING LEBAR KOLOM {kolom1, kolom2, kolom3, dst}
        LebarKolom(Lebar, Datasiswa)

        'Datasiswa.Columns(0).Width = 90
        'Datasiswa.Columns(1).Width = 150
        'Datasiswa.Columns(2).Width = 90
        'Datasiswa.Columns(3).Width = 90
        'Datasiswa.Columns(4).Width = 99
        'Datasiswa.Columns(5).Width = 110

        '#### CONTOH MULTI TABEL ####
        'SELECT Mengajar.Guru, Pelajaran.Nama FROM Pelajaran,Mengajar Where Pelajaran.ID = Mengajar.Pelajaran AND Pelajaran.ID = '1';
        'Datasiswa.DataSource = Tampil("Mengajar.Guru, Pelajaran.Nama", "Pelajaran,Mengajar", "Where Pelajaran.ID = Mengajar.Pelajaran AND Pelajaran.ID = '1'").Tables("Pelajaran,Mengajar")
    End Sub

    Private Sub Foto_Click(sender As Object, e As EventArgs) Handles Foto.Click
        If Cari_foto.ShowDialog = DialogResult.OK Then
            Cari_foto.Filter = "JPG|*.JPG|BMP|*.BMP|GIF|*.GIF|PNG|*.PNG"
            Cari_foto.RestoreDirectory = True
            'Cari_foto.ShowDialog()
            If Cari_foto.FileName = "" Then Exit Sub
            PB_siswa.ImageLocation = Cari_foto.FileName
        End If
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Kembali()
    End Sub

    Private Sub Kembali()
        MuatSiswa()
        Clear()
        TabSiswa.SelectTab(0)
    End Sub

    Private Sub Datasiswa_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datasiswa.CellContentDoubleClick
        Dim i As Integer = Me.Datasiswa.CurrentRow.Index
        Dim Data As DataTable = Tampil("NIS, Nama, Jk, Kelas, Tgl, Alamat, Photo AS [Photo]", "Siswa", "WHERE NIS ='" + Datasiswa.Rows.Item(i).Cells(0).Value + "'")
        Dim buffer() As Byte = CType(Data.Rows(0).Item(6), Byte()) '6 adalah urutan field photo pada syntax query (DATA), dimulai dari 0 dst
        Dim str As New MemoryStream(buffer)
        Tb_nis.Text = Data.Rows(0).Item(0)
        Tb_nama.Text = Data.Rows(0).Item(1)
        Tb_kelas.Text = Data.Rows(0).Item(3)
        DT_siswa.Text = Data.Rows(0).Item(4)
        Tb_alamat.Text = Data.Rows(0).Item(5)
        PB_siswa.Image = Image.FromStream(str)
        If Data.Rows(0).Item(2) = "L" Then
            Male.Select()
        ElseIf Data.Rows(0).Item(2) = "P" Then
            Female.Select()
        End If
        TabSiswa.SelectTab(1)
    End Sub

    Private Sub Clear()
        Tb_nis.Clear()
        Tb_nama.Clear()
        Tb_kelas.Clear()
        DT_siswa.ResetText()
        Tb_alamat.Clear()
        PB_siswa.Image = My.Resources.foto
    End Sub

    Private Sub Simpan_Click(sender As Object, e As EventArgs) Handles Simpan.Click
        Dim jk As String = ""
        If Male.Checked = True Then
            jk = "L"
        ElseIf Female.Checked() = True Then
            jk = "P"
        End If
        '"insert into Siswa (NIS, Nama, Kelas, Tgl, Alamat, Jk, Photo) values ('" & Tb_nis.Text & "', '" & Tb_nama.Text & "','" & Tb_kelas.Text & "', '" & DT_siswa.Text & "','" & Tb_alamat.Text & "', '" & jk & "', '@photo)"
        Dim Field As String = "(NIS, Nama, Kelas, Tgl, Alamat, Jk, Photo)"
        'Values tanpa Foto
        Dim Values As String = "'" & Tb_nis.Text & "', 
                                '" & Tb_nama.Text & "', 
                                '" & Tb_kelas.Text & "', 
                                '" & DT_siswa.Text & "', 
                                '" & Tb_alamat.Text & "', 
                                '" & jk & "'"
        'Tambah_gambar(<NAMA TABEL>, <FIELDNYA>, <VALUENYA TANPA GAMBAR>, <NAMA PICTUREBOX>)
        Tambah_Gambar("Siswa", Field, values, PB_siswa)
        Kembali()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'HAPUS(<TABEL>, <KONDISI>)
        Hapus("Siswa", "NIS='" + Tb_nis.Text + "'")
        Kembali()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim jk As String = ""
        If Male.Checked = True Then
            jk = "L"
        ElseIf Female.Checked() = True Then
            jk = "P"
        End If
        'DATA tanpa Foto
        'data = nilai yang ingin diubah
        Dim Data As String = "[NIS]='" & Tb_nis.Text & "', [Nama]='" & Tb_nama.Text & "', [Kelas]='" & Tb_kelas.Text & "', [Tgl]='" & DT_siswa.Text & "', [Alamat]='" & Tb_alamat.Text & "', [Jk]='" & jk & "'"
        ' kondisi = baris yang ingin diubah
        Dim kondisi As String = "[NIS]='" & Tb_nis.Text & "'"
        'Ubah_Gambar(<TABEL>, <Data TANPA FOTO>, <kondisi>, <NAMA PICTURE BOX>)
        Ubah_Gambar("Siswa", Data, kondisi, PB_siswa)
    End Sub

    '############################################## TEXT EDITOR ##############################################
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Editor.SaveFile("Profile.rtf")
    End Sub

    Private Sub L_Click(sender As Object, e As EventArgs) Handles L.Click
        Editor.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub C_Click(sender As Object, e As EventArgs) Handles C.Click
        Editor.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub R_Click(sender As Object, e As EventArgs) Handles R.Click
        Editor.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub B_Click(sender As Object, e As EventArgs) Handles B.Click
        CurrentFont = Editor.SelectionFont.FontFamily
        CurrentSize = Editor.SelectionFont.Size
        If Editor.SelectionFont.Style = FontStyle.Bold Then
            Editor.SelectionFont = New Font(CurrentFont, CurrentSize, FontStyle.Regular)
        Else
            Editor.SelectionFont = New Font(CurrentFont, CurrentSize, FontStyle.Bold)
        End If
    End Sub

    Private Sub I_Click(sender As Object, e As EventArgs) Handles I.Click
        CurrentFont = Editor.SelectionFont.FontFamily
        CurrentSize = Editor.SelectionFont.Size
        If Editor.SelectionFont.Style = FontStyle.Italic Then
            Editor.SelectionFont = New Font(CurrentFont, CurrentSize, FontStyle.Regular)
        Else
            Editor.SelectionFont = New Font(CurrentFont, CurrentSize, FontStyle.Italic)
        End If
    End Sub

    Private Sub U_Click(sender As Object, e As EventArgs) Handles U.Click
        CurrentFont = Editor.SelectionFont.FontFamily
        CurrentSize = Editor.SelectionFont.Size
        If Editor.SelectionFont.Style = FontStyle.Underline Then
            Editor.SelectionFont = New Font(CurrentFont, CurrentSize, FontStyle.Regular)
        Else
            Editor.SelectionFont = New Font(CurrentFont, CurrentSize, FontStyle.Underline)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FontDialog1.Font = Editor.SelectionFont
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            CurrentFont = FontDialog1.Font.FontFamily
            CurrentSize = FontDialog1.Font.Size
            Editor.SelectionFont = New Font(CurrentFont, CurrentSize)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            CurrentForeColor = ColorDialog1.Color
            Editor.SelectionColor = CurrentForeColor
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CurrentSize = Editor.SelectionFont.Size
        SIzeFont.Text = CurrentSize.ToString
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'OpenFileDialog1.Filter = "(*.mp4)|*.mp4"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Video_panel.playlist.add("file:///" & OpenFileDialog1.FileName)
            My.Settings.Video = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Datasiswa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datasiswa.CellContentClick

    End Sub

    Private Sub TabPage9_Click(sender As Object, e As EventArgs) Handles TabPage9.Click

    End Sub
    '############################################## END OF TEXT EDITOR ##############################################
End Class