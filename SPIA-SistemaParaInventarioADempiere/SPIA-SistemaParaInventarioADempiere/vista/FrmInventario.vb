Public Class FrmInventario
    Dim objElim As New Eliminar
    Dim objActu As New Actualizar
    Dim objConsul As New ConsultasDataView
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        BloquearControles()
        lbl.Visible = False
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub BloquearControles()
        TxtNomInventarioUP.Text = ""
        TxtNomInventarioUP.Enabled = False
        DtFinUp.Enabled = False
        DtInicioUP.Enabled = False
        BtnActualizar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub

    Dim objConsultas As New ConsultasDataView
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim fechaInicio As DateTime = FechaInicioInventario.Value
        Dim fechaFin As DateTime = FechaFinInventario.Value
        Dim nombreInventario As String = TxtNombreInventario.Text
        Dim objGuardado As New GuardadoDB
        If nombreInventario.Trim = "" Then
            MsgBox("Favor de completar todos los campos", vbExclamation, "Atención")
        Else
            Dim fechainiciof As String = fechaInicio.Year.ToString & "/" & fechaInicio.Month.ToString & "/" & fechaInicio.Day.ToString & " " & fechaInicio.Hour.ToString & ":" & fechaInicio.Minute.ToString & ":" & fechaInicio.Second.ToString
            Dim fechaFinf As String = fechaFin.Year.ToString & "/" & fechaFin.Month.ToString & "/" & fechaFin.Day.ToString & " " & fechaFin.Hour.ToString & ":" & fechaFin.Minute.ToString & ":" & fechaFin.Second.ToString
            objGuardado.GuardarInventario(nombreInventario, fechainiciof, fechaFinf)
            TabInventario.SelectedIndex = 1
            DtvgInventario.Refresh()
            objConsultas.ConsultarInventarios()
            TxtNombreInventario.Text = ""
        End If

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        TabInventario.SelectedIndex = 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabInventario.SelectedIndex = 0
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtNomInventarioUP.Text.Trim = "" Then
            MsgBox("Favor de completar todos los campos", vbExclamation, "Atención")
        Else
            objActu.ActualizarInventario(TxtNomInventarioUP.Text, DtInicioUP.Value, DtFinUp.Value, lbl.Text)
            BloquearControles()
            DtvgInventario.Refresh()
            objConsultas.ConsultarInventarios()
            TabInventario.SelectedIndex = 1
        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If TxtNomInventarioUP.Text.Trim = "" Then
            MsgBox("Favor de completar todos los campos", vbExclamation, "Atención")
        Else
            Dim res = MsgBox("¿Está seguro que desea eliminar este inventario?", vbYesNo, "¿Eliminar?")
            If res = vbYes Then
                objElim.EliminarInventario(lbl.Text)
                BloquearControles()
                DtvgInventario.Refresh()
                objConsultas.ConsultarInventarios()
                TabInventario.SelectedIndex = 1
            Else
                BloquearControles()
                TabInventario.SelectedIndex = 1
            End If
        End If
    End Sub

    Private Sub DtvgInventario_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtvgInventario.CellDoubleClick
        Try
            LiberarControles()
            Dim fila = e.RowIndex
            Dim columna = e.ColumnIndex
            TabInventario.SelectedIndex = 2
            TxtNomInventarioUP.Text = DtvgInventario.Rows(fila).Cells(columna).Value.ToString
            Dim fechaInicio = DtvgInventario.Rows(fila).Cells(columna + 1).Value.ToString
            Dim fechaFin = DtvgInventario.Rows(fila).Cells(columna + 2).Value.ToString
            lbl.Text = DtvgInventario.Rows(fila).Cells(columna).Value.ToString
            DtInicioUP.Value = fechaInicio
            DtFinUp.Value = fechaFin
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LiberarControles()
        TxtNomInventarioUP.Enabled = True
        DtFinUp.Enabled = True
        DtInicioUP.Enabled = True
        BtnActualizar.Enabled = True
        BtnEliminar.Enabled = True
    End Sub
End Class