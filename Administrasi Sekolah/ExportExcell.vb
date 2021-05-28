Imports Excel = Microsoft.Office.Interop.Excel
Module ExportExcell
    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet
    Dim misValue As Object = System.Reflection.Missing.Value
    Dim sd As New SaveFileDialog
    Dim i As Integer
    Dim j As Integer

    Public Sub Exportxl(ByVal tabel As DataGridView)
        xlApp = New Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        Dim columnsCount As Integer = tabel.Columns.Count
        For Each column In tabel.Columns
            xlWorkSheet.Cells(1, column.Index + 1).Value = column.Name
        Next

        For i = 0 To tabel.Rows.Count - 1
            For j = 0 To tabel.ColumnCount - 1
                xlWorkSheet.Cells(i + 2, j + 1) =
                tabel(j, i).Value.ToString()
            Next
        Next
        sd.Filter = "Excell (*.xlsx)|*.xlsx"
        If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
            xlWorkSheet.SaveAs(sd.FileName)
            xlWorkBook.Close()
            xlApp.Quit()
            MsgBox("Data berhasil di eksport")
        End If

        ReleaseObject(xlApp)
        ReleaseObject(xlWorkBook)
        ReleaseObject(xlWorkSheet)
    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Module
