<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pdf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pdf))
        Me.pdf_form = New AxAcroPDFLib.AxAcroPDF()
        Me.Openpdf = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Back = New System.Windows.Forms.Button()
        Me.Path = New System.Windows.Forms.Button()
        Me.Path_tb = New System.Windows.Forms.TextBox()
        CType(Me.pdf_form, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pdf_form
        '
        Me.pdf_form.Enabled = True
        Me.pdf_form.Location = New System.Drawing.Point(12, 40)
        Me.pdf_form.Name = "pdf_form"
        Me.pdf_form.OcxState = CType(resources.GetObject("pdf_form.OcxState"), System.Windows.Forms.AxHost.State)
        Me.pdf_form.Size = New System.Drawing.Size(679, 414)
        Me.pdf_form.TabIndex = 0
        '
        'Openpdf
        '
        Me.Openpdf.Location = New System.Drawing.Point(535, 11)
        Me.Openpdf.Name = "Openpdf"
        Me.Openpdf.Size = New System.Drawing.Size(75, 23)
        Me.Openpdf.TabIndex = 1
        Me.Openpdf.Text = "OPEN PDF"
        Me.Openpdf.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(616, 11)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 23)
        Me.Back.TabIndex = 2
        Me.Back.Text = "BACK"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Path
        '
        Me.Path.Location = New System.Drawing.Point(454, 11)
        Me.Path.Name = "Path"
        Me.Path.Size = New System.Drawing.Size(75, 23)
        Me.Path.TabIndex = 3
        Me.Path.Text = "PATH"
        Me.Path.UseVisualStyleBackColor = True
        '
        'Path_tb
        '
        Me.Path_tb.Location = New System.Drawing.Point(12, 11)
        Me.Path_tb.Name = "Path_tb"
        Me.Path_tb.Size = New System.Drawing.Size(436, 20)
        Me.Path_tb.TabIndex = 4
        '
        'pdf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 466)
        Me.Controls.Add(Me.Path_tb)
        Me.Controls.Add(Me.Path)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Openpdf)
        Me.Controls.Add(Me.pdf_form)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pdf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pdf"
        CType(Me.pdf_form, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pdf_form As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents Openpdf As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Back As Button
    Friend WithEvents Path As Button
    Friend WithEvents Path_tb As TextBox
End Class
