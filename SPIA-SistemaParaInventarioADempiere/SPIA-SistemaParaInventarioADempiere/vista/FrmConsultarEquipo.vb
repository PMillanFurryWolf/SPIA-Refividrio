Public Class FrmConsultarEquipo
    Private Sub btnAgregarEquipo_Click(sender As Object, e As EventArgs) Handles btnAgregarEquipo.Click
        FrmAgregarEquipo.Show()
    End Sub

    Private Sub dtvDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtvDatos.CellDoubleClick
        TabEquipos.SelectedIndex = 1
        Dim columna As Integer = e.ColumnIndex
        Dim fila As Integer = e.RowIndex
        MsgBox("F=" & fila & " C=" & columna & "")
        Try
            Label1.Text = dtvDatos.Rows(fila).Cells(columna).Value()
        Catch ex As Exception
        End Try
    End Sub
End Class