Public Class FrmBuscarEquipo
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dispose()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        FrmConsultarEquipo.Show()
        Hide()
        Dim obj As New ConsultasDataView
        obj.ConsultarEquipo(txtNombre.Text)
    End Sub

End Class