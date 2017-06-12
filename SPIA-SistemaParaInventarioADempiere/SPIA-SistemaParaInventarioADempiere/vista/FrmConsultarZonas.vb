Public Class FrmConsultarZonas
    Dim ojbElim As New Eliminar
    Dim objActu As New Actualizar
    Dim consul As New ConsultasDataView

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        BloquearControles()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub BloquearControles()
        TxtUbicacion.Enabled = False
        TxtNombreZona.Enabled = False
        Lbl.Visible = False
        BtnActualizar.Enabled = False
        BtnEliminar.Enabled = False
        BtnCodigoAlmacen.Enabled = False
        TxtNombreZona.Text = ""
        TxtUbicacion.Text = ""
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim obj As New ConsultasDataView
        obj.ConsultarAlmacen()
        FrmAgregarZona.Show()
    End Sub

    Private Sub dtgvZonas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvZonas.CellDoubleClick
        Dim fila = e.RowIndex
        Dim columna = e.ColumnIndex
        LiberarControles()
        TabZona.SelectedIndex = 1
        Try
            TxtNombreZona.Text = dtgvZonas.Rows(fila).Cells(columna).Value.ToString
            TxtUbicacion.Text = dtgvZonas.Rows(fila).Cells(columna + 1).Value.ToString
            Lbl.Text = dtgvZonas.Rows(fila).Cells(columna).Value.ToString
        Catch ex As Exception
        End Try
    End Sub
    Private Sub LiberarControles()
        TxtNombreZona.Enabled = True
        BtnActualizar.Enabled = True
        BtnCodigoAlmacen.Enabled = True
        BtnEliminar.Enabled = True
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If TxtNombreZona.Text.Trim = "" Or TxtUbicacion.Text.Trim = "" Then
            MsgBox("Favor de no dejar campos vacíos", vbExclamation, "Atención")
        Else
            Dim res = MsgBox("¿Realmente desea eliminar esta zona? :" & Lbl.Text, vbYesNo, "Confirmación de eliminado")
            If res = vbYes Then
                ojbElim.EliminarZona(Lbl.Text)
                BloquearControles()
                TabZona.SelectedIndex = 0
                dtgvZonas.Refresh()
                consul.ConsultarZonas()
            Else
                BloquearControles()
                TabZona.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtNombreZona.Text.Trim = "" Or TxtUbicacion.Text.Trim = "" Then
            MsgBox("Favor de no deja campos vacíos", vbExclamation, "Atención")
        Else
            Dim actualizar As New Actualizar
            TabZona.SelectedIndex = 0
            actualizar.ActualizaZona(TxtNombreZona.Text, TxtUbicacion.Text, Lbl.Text)
            BloquearControles()
            dtgvZonas.Refresh()
            consul.ConsultarZonas()
        End If
    End Sub

    Private Sub BtnCodigoAlmacen_Click(sender As Object, e As EventArgs) Handles BtnCodigoAlmacen.Click
        TabZona.SelectedIndex = 2
    End Sub

    Private Sub DtgvAlmacen_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgvAlmacen.CellDoubleClick
        Dim fila = e.RowIndex
        Dim columna = e.ColumnIndex
        TxtUbicacion.Text = DtgvAlmacen.Rows(fila).Cells(columna).Value.ToString
        TabZona.SelectedIndex = 1
    End Sub

    Private Sub TxtUbicacion_TextChanged(sender As Object, e As EventArgs) Handles TxtUbicacion.TextChanged

    End Sub

    Private Sub txtBuscador_KeyPress(ByVal sender As Object,
                ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBuscarZona.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Dim objConsul As New ConsultasDataView
            objConsul.BuscarAlmacen(TxtBuscarZona.Text.ToUpper)
        End If

    End Sub
End Class