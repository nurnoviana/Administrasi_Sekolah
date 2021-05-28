<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Video
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Video))
        Me.Video_panel = New AxAXVLC.AxVLCPlugin2()
        Me.Play = New System.Windows.Forms.Button()
        Me.Pause = New System.Windows.Forms.Button()
        Me.Stop_btn = New System.Windows.Forms.Button()
        Me.Path = New System.Windows.Forms.Button()
        Me.Path_tb = New System.Windows.Forms.TextBox()
        Me.Back = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Video_panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Video_panel
        '
        Me.Video_panel.Enabled = True
        Me.Video_panel.Location = New System.Drawing.Point(0, 52)
        Me.Video_panel.Name = "Video_panel"
        Me.Video_panel.OcxState = CType(resources.GetObject("Video_panel.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Video_panel.Size = New System.Drawing.Size(551, 309)
        Me.Video_panel.TabIndex = 0
        '
        'Play
        '
        Me.Play.Location = New System.Drawing.Point(160, 371)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(75, 23)
        Me.Play.TabIndex = 1
        Me.Play.Text = "Play"
        Me.Play.UseVisualStyleBackColor = True
        '
        'Pause
        '
        Me.Pause.Location = New System.Drawing.Point(241, 371)
        Me.Pause.Name = "Pause"
        Me.Pause.Size = New System.Drawing.Size(75, 23)
        Me.Pause.TabIndex = 2
        Me.Pause.Text = "Pause"
        Me.Pause.UseVisualStyleBackColor = True
        '
        'Stop_btn
        '
        Me.Stop_btn.Location = New System.Drawing.Point(322, 371)
        Me.Stop_btn.Name = "Stop_btn"
        Me.Stop_btn.Size = New System.Drawing.Size(75, 23)
        Me.Stop_btn.TabIndex = 3
        Me.Stop_btn.Text = "Stop"
        Me.Stop_btn.UseVisualStyleBackColor = True
        '
        'Path
        '
        Me.Path.Location = New System.Drawing.Point(383, 12)
        Me.Path.Name = "Path"
        Me.Path.Size = New System.Drawing.Size(75, 23)
        Me.Path.TabIndex = 4
        Me.Path.Text = "Path"
        Me.Path.UseVisualStyleBackColor = True
        '
        'Path_tb
        '
        Me.Path_tb.Location = New System.Drawing.Point(12, 13)
        Me.Path_tb.Name = "Path_tb"
        Me.Path_tb.Size = New System.Drawing.Size(365, 20)
        Me.Path_tb.TabIndex = 5
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(464, 12)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 23)
        Me.Back.TabIndex = 6
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(448, 371)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "OPEN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Video
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 400)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Path_tb)
        Me.Controls.Add(Me.Path)
        Me.Controls.Add(Me.Stop_btn)
        Me.Controls.Add(Me.Pause)
        Me.Controls.Add(Me.Play)
        Me.Controls.Add(Me.Video_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Video"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Video"
        CType(Me.Video_panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Video_panel As AxAXVLC.AxVLCPlugin2
    Friend WithEvents Play As Button
    Friend WithEvents Pause As Button
    Friend WithEvents Stop_btn As Button
    Friend WithEvents Path As Button
    Friend WithEvents Path_tb As TextBox
    Friend WithEvents Back As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
End Class
