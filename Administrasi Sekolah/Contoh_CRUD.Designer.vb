<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Crudform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Pass = New System.Windows.Forms.TextBox()
        Me.User = New System.Windows.Forms.TextBox()
        Me.Back = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Tambah = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Pass)
        Me.Panel1.Controls.Add(Me.User)
        Me.Panel1.Controls.Add(Me.Back)
        Me.Panel1.Controls.Add(Me.Edit)
        Me.Panel1.Controls.Add(Me.Delete)
        Me.Panel1.Controls.Add(Me.Tambah)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(0, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(438, 248)
        Me.Panel1.TabIndex = 2
        '
        'Pass
        '
        Me.Pass.Location = New System.Drawing.Point(232, 23)
        Me.Pass.Name = "Pass"
        Me.Pass.Size = New System.Drawing.Size(191, 20)
        Me.Pass.TabIndex = 6
        Me.Pass.Text = "PASSWORD"
        '
        'User
        '
        Me.User.Location = New System.Drawing.Point(12, 23)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(181, 20)
        Me.User.TabIndex = 5
        Me.User.Text = "USERNAME"
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(348, 49)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 23)
        Me.Back.TabIndex = 4
        Me.Back.Text = "BACK"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Edit
        '
        Me.Edit.Location = New System.Drawing.Point(232, 49)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(75, 23)
        Me.Edit.TabIndex = 3
        Me.Edit.Text = "EDIT"
        Me.Edit.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(118, 49)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(75, 23)
        Me.Delete.TabIndex = 2
        Me.Delete.Text = "DELETE"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Tambah
        '
        Me.Tambah.Location = New System.Drawing.Point(11, 49)
        Me.Tambah.Name = "Tambah"
        Me.Tambah.Size = New System.Drawing.Size(75, 23)
        Me.Tambah.TabIndex = 1
        Me.Tambah.Text = "TAMBAH"
        Me.Tambah.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 78)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(438, 170)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(173, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CONTOH CRUD"
        '
        'Crudform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 282)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Crudform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CRUD"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Back As Button
    Friend WithEvents Edit As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Tambah As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Pass As TextBox
    Friend WithEvents User As TextBox
End Class
