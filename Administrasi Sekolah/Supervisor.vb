Imports System.IO
Public Class Supervisor
    Private Sub B_siswa_Click(sender As Object, e As EventArgs) Handles B_siswa.Click
        Muatsiswa()
        TabControl1.SelectTab(0)
    End Sub

    Private Sub B_guru_Click(sender As Object, e As EventArgs) Handles B_guru.Click
        Muatguru()
        TabControl1.SelectTab(1)
    End Sub

    Private Sub B_sarpras_Click(sender As Object, e As EventArgs) Handles B_sarpras.Click
        TabControl1.SelectTab(2)
        Muatsarpras()
    End Sub

    Private Sub B_acara_Click(sender As Object, e As EventArgs) Handles B_acar.Click
        Muatjadwal()
        TabControl1.SelectTab(3)
    End Sub

    Private Sub B_prof_Click(sender As Object, e As EventArgs) Handles B_Prestasi.Click
        Muatprestasi()
        TabControl1.SelectTab(4)
    End Sub

    Private Sub B_Profil_Click(sender As Object, e As EventArgs) Handles B_Profil.Click
        RTB_Profile.LoadFile("Profile.rtf")
        TabControl1.SelectTab(5)
    End Sub

    Private Sub Video_Click(sender As Object, e As EventArgs) Handles Video.Click
        Video_panel.playlist.add("file:///" & My.Settings.Video)
        'Video_panel.playlist.add("file:/// F:\Bon Jovi - Rock in Rio 2017 - FULL CONCERT (1080p) - YouTube.MKV")
        TabControl2.SelectTab(1)
        Video_panel.playlist.play()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl2.SelectTab(0)
    End Sub

    Private Sub Muatsiswa()
        Datasiswa.DataSource = TampilTabel("NIS, Nama, Jk, Kelas, Tgl, Alamat", "Siswa", "").Tables("Siswa")
        Dim Lebar() As Integer = {90, 150, 90, 90, 99, 110}
        LebarKolom(Lebar, Datasiswa)
    End Sub

    Private Sub Muatguru()
        DataGuru.DataSource = TampilTabel("NIP, Nama, Jk, Tgl, Alamat", "Guru", "").Tables("Guru")
        Dim Lebar() As Integer = {90, 150, 90, 99, 110}
        LebarKolom(Lebar, DataGuru)
    End Sub

    Private Sub Muatsarpras()
        DataSarpras.DataSource = TampilTabel("*", "Sarpras", "").Tables("Sarpras")
        Dim Lebar() As Integer = {70, 70, 70, 70, 70, 70, 70, 70, 70}
        LebarKolom(Lebar, DataSarpras)
    End Sub

    Private Sub Muatjadwal()
        Datajadwal.DataSource = TampilTabel("*", "Jadwal", "").Tables("Jadwal")
        Dim Lebar() As Integer = {30, 150, 450}
        LebarKolom(Lebar, Datajadwal)
        Try
            Panel5.BringToFront()
            Dim Data As DataTable = Tampil("Tgl, Ket", "Jadwal", "WHERE Tgl >= #" + Date.Now.ToString("MM-dd-yyyy hh:mm:ss") + "#")
            Dim tgl As DateTime = DateTime.Parse(Data.Rows(0).Item(0))
            Ket.Text = Data.Rows(0).Item(1)
            Tanggal.Text = Format(tgl, "dd")
            Bulan.Text = Format(tgl, "MMMM")
            Tahun.Text = Format(tgl, "yyyy")
            Time.Text = Format(tgl, "HH") + ":" + Format(tgl, "mm")
        Catch e As System.IndexOutOfRangeException
            Pkosong.BringToFront()
        End Try
    End Sub

    Private Sub Muatprestasi()
        Dataprestasi.DataSource = TampilTabel("*", "Prestasi", "").Tables("Prestasi")
        Dim Lebar() As Integer = {70, 70, 70, 70, 70, 70}
        LebarKolom(Lebar, Dataprestasi)
    End Sub

    Private Sub Datasiswa_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datasiswa.CellContentDoubleClick
        Dim i As Integer = Me.Datasiswa.CurrentRow.Index
        Dim Data As DataTable = Tampil("NIS, Nama, Jk, Kelas, Tgl, Alamat, Photo AS [Photo]", "Siswa", "WHERE NIS ='" + Datasiswa.Rows.Item(i).Cells(0).Value + "'")
        Dim buffer() As Byte = CType(Data.Rows(0).Item(6), Byte())
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

    Private Sub DataGuru_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGuru.CellContentDoubleClick
        Dim i As Integer = Me.DataGuru.CurrentRow.Index
        Dim Data As DataTable = Tampil("NIP, Nama, Jk, Tgl, Alamat, Photo AS [Photo]", "Guru", "WHERE NIP ='" + DataGuru.Rows.Item(i).Cells(0).Value + "'")
        Dim buffer() As Byte = CType(Data.Rows(0).Item(5), Byte())
        Dim str As New MemoryStream(buffer)
        TB_nip.Text = Data.Rows(0).Item(0)
        TB_namag.Text = Data.Rows(0).Item(1)
        DT_guru.Text = Data.Rows(0).Item(3)
        TB_alamatg.Text = Data.Rows(0).Item(4)
        PBguru.Image = Image.FromStream(str)
        If Data.Rows(0).Item(2) = "L" Then
            male_g.Select()
        ElseIf Data.Rows(0).Item(2) = "P" Then
            female_g.Select()
        End If
        Tabguru.SelectTab(1)
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Muatsiswa()
        Clear()
        TabSiswa.SelectTab(0)
    End Sub

    Private Sub Clear()
        Tb_nis.Clear()
        Tb_nama.Clear()
        Tb_kelas.Clear()
        DT_siswa.ResetText()
        Tb_alamat.Clear()
        PB_siswa.Image = My.Resources.foto
    End Sub

    Private Sub Back_g_Click(sender As Object, e As EventArgs) Handles Back_g.Click
        Muatguru()
        Tabguru.SelectTab(0)
    End Sub

    Private Sub BT_cariacara_Click(sender As Object, e As EventArgs) Handles BT_cariacara.Click
        Datajadwal.DataSource = TampilTabel("*", "Jadwal", "WHERE Tgl >= #" + Format(Datestart.Value, "MM/dd/yyyy") + "# and Tgl <= #" + Format(Dateend.Value, "MM/dd/yyyy") + "#").Tables("Jadwal")
        Dim Lebar() As Integer = {30, 150, 450}
        LebarKolom(Lebar, Datajadwal)
        'Dim after = Format(Datestart.Value.AddDays(1), "dd/MM/yyyy")
        'da = New OleDbDataAdapter("SELECT * FROM Jadwal WHERE Tgl >= #" + Format(Datestart.Value, "MM/dd/yyyy") + "# and Tgl <= #" + Format(Dateend.Value, "MM/dd/yyyy") + "#", Conn)
        'da = New OleDbDataAdapter("SELECT * FROM Jadwal WHERE Tgl >= #" + Format(Datestart.Value, "MM/dd/yyyy") + "# and Tgl <= #" + after + "#", Conn)
    End Sub

    Private Sub BT_ExportSiswa_Click(sender As Object, e As EventArgs) Handles BT_ExportSiswa.Click
        Exportxl(Datasiswa)
    End Sub
    Private Sub BT_ExportGuru_Click(sender As Object, e As EventArgs) Handles BT_ExportGuru.Click
        Exportxl(DataGuru)
    End Sub
    Private Sub ExportJadwal_Click(sender As Object, e As EventArgs) Handles ExportJadwal.Click
        Exportxl(Datajadwal)
    End Sub
    Private Sub ExportSarpras_Click(sender As Object, e As EventArgs) Handles ExportSarpras.Click
        Exportxl(DataSarpras)
    End Sub
    Private Sub ExportPrestasi_Click(sender As Object, e As EventArgs) Handles ExportPrestasi.Click
        Exportxl(Dataprestasi)
    End Sub

    Private Sub BT_CariGuru_Click(sender As Object, e As EventArgs) Handles BT_CariGuru.Click
        DataGuru.DataSource = TampilTabel("NIP, Nama, Jk, Tgl, Alamat", "Guru", "WHERE Nama Like '%" + TB_SearchGuru.Text + "%'").Tables("Guru")
        Dim Lebar() As Integer = {90, 150, 90, 99, 110}
        LebarKolom(Lebar, DataGuru)
    End Sub

    Private Sub BT_CariSiswa_Click(sender As Object, e As EventArgs) Handles BT_CariSiswa.Click
        Datasiswa.DataSource = TampilTabel("NIS, Nama, Jk, Kelas, Tgl, Alamat", "Siswa", "WHERE Nama Like '%" + TB_CariSiswa.Text + "%'").Tables("Siswa")
        Dim Lebar() As Integer = {90, 150, 90, 90, 99, 110}
        LebarKolom(Lebar, Datasiswa)
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

    Private Sub Time_Click(sender As Object, e As EventArgs) Handles Time.Click

    End Sub

    Private Sub Simpan_Click(sender As Object, e As EventArgs) Handles Simpan.Click

    End Sub
End Class