Public Class FrmConsultarEquipo
    Dim obj As New ConsultasDataView
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        LimpiarYBloquear()
    End Sub
    Private Sub btnAgregarEquipo_Click(sender As Object, e As EventArgs) Handles btnAgregarEquipo.Click
        FrmAgregarEquipo.Show()
    End Sub

    Private Sub dtvDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtvDatos.CellDoubleClick
        TabEquipos.SelectedIndex = 1
        HabilitarControles()

        Dim columna As Integer = e.ColumnIndex
        Dim fila As Integer = e.RowIndex
        Try
            LblId.Text = dtvDatos.Rows(fila).Cells(columna).Value.ToString()
            TxtEquipo.Text = dtvDatos.Rows(fila).Cells(columna + 1).Value.ToString()
            TxtNombreRes.Text = dtvDatos.Rows(fila).Cells(columna + 2).Value.ToString()
            TxtNombreAyud.Text = dtvDatos.Rows(fila).Cells(columna + 3).Value.ToString()
            LblIdUsuario.Text = dtvDatos.Rows(fila).Cells(columna + 4).Value.ToString()
            TxtUsuario.Text = dtvDatos.Rows(fila).Cells(columna + 5).Value.ToString()
            TxtContrasena.Text = dtvDatos.Rows(fila).Cells(columna + 6).Value.ToString()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub HabilitarControles()
        LblId.Visible = False
        LblIdUsuario.Visible = False
        BtnActualizar.Enabled = True
        BtnEliminar.Enabled = True
        TxtEquipo.Enabled = True
        TxtNombreRes.Enabled = True
        TxtNombreAyud.Enabled = True
        TxtUsuario.Enabled = True
        TxtContrasena.Enabled = True

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtEquipo.Text.Trim = "" Or TxtNombreRes.Text.Trim = "" Or TxtNombreAyud.Text.Trim = "" Or TxtUsuario.Text.Trim = "" Or TxtContrasena.Text.Trim = "" Then
            MsgBox("Favor de no eliminar ningún campo", vbExclamation, "Atención")
        Else
            Dim objAc As New Actualizar
            objAc.ActualizarEquipo(LblId.Text, TxtEquipo.Text, TxtNombreRes.Text, TxtNombreAyud.Text)
            objAc.ActualizarUsuario(LblIdUsuario.Text, TxtUsuario.Text, TxtContrasena.Text)
            LimpiarYBloquear()
            RefrescarData()
            TabEquipos.SelectedIndex = 0
        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        Dim res As String
        res = MsgBox("¿Realmente desea eliminar este equipo?", vbYesNo, "¿Eliminar?")
        If res = vbYes Then
            Dim objElim As New Eliminar
            objElim.EliminarEquipo(LblId.Text)
            LimpiarYBloquear()
            TabEquipos.SelectedIndex = 0
            RefrescarData()
        Else
            TabEquipos.SelectedIndex = 0
            LimpiarYBloquear()
        End If
    End Sub

    Private Sub RefrescarData()
        dtvDatos.Refresh()
        obj.ConsultarEquipo("")
    End Sub

    Private Sub LimpiarYBloquear()
        LblId.Text = ""
        LblIdUsuario.Text = ""
        TxtEquipo.Enabled = False
        TxtNombreRes.Enabled = False
        TxtNombreAyud.Enabled = False
        TxtUsuario.Enabled = False
        TxtContrasena.Enabled = False
        BtnActualizar.Enabled = False
        BtnEliminar.Enabled = False
        TxtEquipo.Text = ""
        TxtNombreRes.Text = ""
        TxtNombreAyud.Text = ""
        TxtUsuario.Text = ""
        TxtContrasena.Text = ""
    End Sub

    Private Sub btnAgregarUsuario_Click(sender As Object, e As EventArgs)
        FrmAgregarUsuario.Show()
    End Sub
End Class