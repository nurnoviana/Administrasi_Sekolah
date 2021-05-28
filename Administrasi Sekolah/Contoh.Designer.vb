<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contoh
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Photo = New System.Windows.Forms.PictureBox()
        Me.Save = New System.Windows.Forms.Button()
        Me.Ambil = New System.Windows.Forms.Button()
        Me.Perbarui = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Cari_photo = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nama = New System.Windows.Forms.TextBox()
        Me.Kelas = New System.Windows.Forms.TextBox()
        Me.Tgl = New System.Windows.Forms.DateTimePicker()
        Me.Alamat = New System.Windows.Forms.TextBox()
        Me.Nis = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.Photo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("BigNoodleTitling", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(257, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SISWA"
        '
        'Photo
        '
        Me.Photo.Location = New System.Drawing.Point(401, 60)
        Me.Photo.Name = "Photo"
        Me.Photo.Size = New System.Drawing.Size(118, 163)
        Me.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Photo.TabIndex = 1
        Me.Photo.TabStop = False
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(25, 250)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 23)
        Me.Save.TabIndex = 2
        Me.Save.Text = "SAVE"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Ambil
        '
        Me.Ambil.Location = New System.Drawing.Point(106, 250)
        Me.Ambil.Name = "Ambil"
        Me.Ambil.Size = New System.Drawing.Size(75, 23)
        Me.Ambil.TabIndex = 3
        Me.Ambil.Text = "LOAD"
        Me.Ambil.UseVisualStyleBackColor = True
        '
        'Perbarui
        '
        Me.Perbarui.Location = New System.Drawing.Point(187, 250)
        Me.Perbarui.Name = "Perbarui"
        Me.Perbarui.Size = New System.Drawing.Size(75, 23)
        Me.Perbarui.TabIndex = 4
        Me.Perbarui.Text = "UPDATE"
        Me.Perbarui.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(268, 250)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(75, 23)
        Me.Delete.TabIndex = 5
        Me.Delete.Text = "DELETE"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(383, 250)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(75, 23)
        Me.Search.TabIndex = 6
        Me.Search.Text = "SEARCH"
        Me.Search.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(464, 250)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(75, 23)
        Me.Clear.TabIndex = 7
        Me.Clear.Text = "CLEAR"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Cari_photo
        '
        Me.Cari_photo.FileName = "OpenFileDialog1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-1, 288)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(577, 133)
        Me.DataGridView1.TabIndex = 9
        '
        'Nama
        '
        Me.Nama.Location = New System.Drawing.Point(143, 94)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(201, 20)
        Me.Nama.TabIndex = 11
        '
        'Kelas
        '
        Me.Kelas.Location = New System.Drawing.Point(143, 120)
        Me.Kelas.Name = "Kelas"
        Me.Kelas.Size = New System.Drawing.Size(201, 20)
        Me.Kelas.TabIndex = 12
        '
        'Tgl
        '
        Me.Tgl.CustomFormat = "dd/MM/yyyy"
        Me.Tgl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Tgl.Location = New System.Drawing.Point(144, 146)
        Me.Tgl.Name = "Tgl"
        Me.Tgl.Size = New System.Drawing.Size(200, 20)
        Me.Tgl.TabIndex = 13
        '
        'Alamat
        '
        Me.Alamat.Location = New System.Drawing.Point(143, 172)
        Me.Alamat.Name = "Alamat"
        Me.Alamat.Size = New System.Drawing.Size(201, 20)
        Me.Alamat.TabIndex = 14
        '
        'Nis
        '
        Me.Nis.Location = New System.Drawing.Point(143, 67)
        Me.Nis.Name = "Nis"
        Me.Nis.Size = New System.Drawing.Size(201, 20)
        Me.Nis.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "KELAS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "NAMA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "TGL LAHIR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "ALAMAT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "NIS"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 419)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Nis)
        Me.Controls.Add(Me.Alamat)
        Me.Controls.Add(Me.Tgl)
        Me.Controls.Add(Me.Kelas)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Perbarui)
        Me.Controls.Add(Me.Ambil)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Photo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADMIN"
        CType(Me.Photo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Photo As PictureBox
    Friend WithEvents Save As Button
    Friend WithEvents Ambil As Button
    Friend WithEvents Perbarui As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Search As Button
    Friend WithEvents Clear As Button
    Friend WithEvents Cari_photo As OpenFileDialog
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Nama As TextBox
    Friend WithEvents Kelas As TextBox
    Friend WithEvents Tgl As DateTimePicker
    Friend WithEvents Alamat As TextBox
    Friend WithEvents Nis As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
