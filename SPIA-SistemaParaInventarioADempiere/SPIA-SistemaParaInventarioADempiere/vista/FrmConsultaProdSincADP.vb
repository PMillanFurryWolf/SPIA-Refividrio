Public Class FrmConsultaProdSincADP
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCopiar.Click
        Clipboard.SetText(txtBuscador.Text)
    End Sub

    Private Sub txtBuscador_KeyPress(ByVal sender As Object,
                ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscador.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Dim obj As New ConsultasDataView
            obj.BuscarProductos(txtBuscador.Text.ToUpper)
        End If
    End Sub

    Private Sub dtgvBusqusquedaProd_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvBusqusquedaProd.CellDoubleClick
        Try
            Dim columna As Integer = e.ColumnIndex
            Dim Fila As Integer = e.RowIndex
            txtBuscador.Text = dtgvBusqusquedaProd.Rows(Fila).Cells(columna).Value()
        Catch ex As Exception

        End Try
    End Sub
End Class