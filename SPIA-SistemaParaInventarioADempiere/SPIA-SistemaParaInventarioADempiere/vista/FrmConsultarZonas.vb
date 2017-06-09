Public Class FrmConsultarZonas
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim obj As New ConsultasDataView
        obj.ConsultarAlmacen()
        FrmAgregarZona.Show()
    End Sub
End Class