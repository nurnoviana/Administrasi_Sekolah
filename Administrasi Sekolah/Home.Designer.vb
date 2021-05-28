<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.userlb = New System.Windows.Forms.Label()
        Me.crud = New System.Windows.Forms.Button()
        Me.Contoh_pdf = New System.Windows.Forms.Button()
        Me.Contoh_video = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'userlb
        '
        Me.userlb.AutoSize = True
        Me.userlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userlb.Location = New System.Drawing.Point(154, 9)
        Me.userlb.Name = "userlb"
        Me.userlb.Size = New System.Drawing.Size(120, 39)
        Me.userlb.TabIndex = 0
        Me.userlb.Text = "Label1"
        '
        'crud
        '
        Me.crud.Location = New System.Drawing.Point(142, 80)
        Me.crud.Name = "crud"
        Me.crud.Size = New System.Drawing.Size(137, 23)
        Me.crud.TabIndex = 1
        Me.crud.Text = "CONTOH CRUD"
        Me.crud.UseVisualStyleBackColor = True
        '
        'Contoh_pdf
        '
        Me.Contoh_pdf.Location = New System.Drawing.Point(142, 109)
        Me.Contoh_pdf.Name = "Contoh_pdf"
        Me.Contoh_pdf.Size = New System.Drawing.Size(137, 23)
        Me.Contoh_pdf.TabIndex = 2
        Me.Contoh_pdf.Text = "CONTOH PDF"
        Me.Contoh_pdf.UseVisualStyleBackColor = True
        '
        'Contoh_video
        '
        Me.Contoh_video.Location = New System.Drawing.Point(142, 139)
        Me.Contoh_video.Name = "Contoh_video"
        Me.Contoh_video.Size = New System.Drawing.Size(137, 23)
        Me.Contoh_video.TabIndex = 3
        Me.Contoh_video.Text = "CONTOH VIDEO"
        Me.Contoh_video.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 181)
        Me.Controls.Add(Me.Contoh_video)
        Me.Controls.Add(Me.Contoh_pdf)
        Me.Controls.Add(Me.crud)
        Me.Controls.Add(Me.userlb)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HOME"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents userlb As Label
    Friend WithEvents crud As Button
    Friend WithEvents Contoh_pdf As Button
    Friend WithEvents Contoh_video As Button
End Class
