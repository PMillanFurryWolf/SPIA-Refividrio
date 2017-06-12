Public Class FrmConsultarConteo
    Dim objActual As New Actualizar
    Dim objElimina As New Eliminar
    Dim consul As New ConsultasDataView
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        BloquearControles()
        lbl.Visible = False
    End Sub

    Private Sub BloquearControles()
        btnActualizar.Enabled = False
        BtnEliminar.Enabled = False
        BtnElegir.Enabled = False
        TxtColor.Enabled = False
        TxtConteo.Enabled = False
        TxtColor.Text = ""
        TxtConteo.Text = ""
        PicBxColor.BackColor = Color.White
    End Sub

    Private Sub btnAgregarConteo_Click(sender As Object, e As EventArgs) Handles btnAgregarConteo.Click
        FrmAgregarConteo.Show()
    End Sub

    Private Sub dtgvConteo_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvConteo.CellDoubleClick
        Try
            LiberarControles()
            Dim fila = e.RowIndex
            Dim columna = e.ColumnIndex
            Dim obColor As New ColorConverter
            Dim valorColor = dtgvConteo.Rows(fila).Cells(columna + 1).Value.ToString
            Dim charColor As Char = valorColor.First

            If Char.IsUpper(charColor) Then
                PicBxColor.BackColor = obColor.ConvertFromString(valorColor)
            Else
                PicBxColor.BackColor = obColor.ConvertFromString("#" & valorColor)
            End If
            TabConteo.SelectedIndex = 1
            TxtConteo.Text = dtgvConteo.Rows(fila).Cells(columna).Value.ToString
            TxtColor.Text = dtgvConteo.Rows(fila).Cells(columna + 1).Value.ToString
            lbl.Text = dtgvConteo.Rows(fila).Cells(columna).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LiberarControles()
        btnActualizar.Enabled = True
        BtnEliminar.Enabled = True
        BtnElegir.Enabled = True
        TxtColor.Enabled = True
        TxtConteo.Enabled = True
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If TxtConteo.Text = "" Or TxtColor.Text.Trim = "" Then
            MsgBox("Favor de no dejar campos vacíos", vbExclamation, "Atención")
        Else
            objActual.ActualizarConteo(TxtConteo.Text, TxtColor.Text, lbl.Text)
            BloquearControles()
            TabConteo.SelectedIndex = 0
            dtgvConteo.Refresh()
            consul.ConsultarConteo()
        End If
    End Sub
    Private Sub BtnElegir_Click(sender As Object, e As EventArgs) Handles BtnElegir.Click
        ColorDialog1.ShowDialog()
        TxtColor.Text = ColorDialog1.Color.Name
        PicBxColor.BackColor = ColorDialog1.Color
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If TxtConteo.Text = "" Or TxtColor.Text.Trim = "" Then
            MsgBox("Favor de no dejar campos vacíos", vbExclamation, "Atención")
        Else
            Dim res = MsgBox("¿Está seguro que desea eliminar este conteo? :" & lbl.Text, vbYesNo, "¿Eliminar conteo?")
            If res = vbYes Then
                TabConteo.SelectedIndex = 0
                BloquearControles()
                objElimina.EliminarConteo(lbl.Text)
                dtgvConteo.Refresh()
                consul.ConsultarConteo()
            Else
                BloquearControles()
                TabConteo.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmAgregarConteo.Show()
    End Sub
End Class