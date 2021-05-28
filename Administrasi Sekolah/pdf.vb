Public Class pdf
    Private Sub Openpdf_Click(sender As Object, e As EventArgs) Handles Openpdf.Click
        OpenFileDialog1.Filter = "PDF FILE |*.pdf"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            pdf_form.src = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Home.Show()
        Me.Close()
    End Sub

    Private Sub Path_Click(sender As Object, e As EventArgs) Handles Path.Click
        'pdf_form.src = "D:\download\Documents\IDSIRTII-Artikel-cara_hacker.pdf"
        pdf_form.src = Path_tb.Text
    End Sub
End Class