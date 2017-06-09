Imports Npgsql
Public Class FrmAgregarZona
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        TxtUbicacion.Enabled = False
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim objG As New GuardadoDB()
        If TxtUbicacion.Text.Trim = "" Or TxtNombreZona.Text.Trim = "" Then
            MsgBox("Favor de no dejar campos vacíos", vbExclamation, "Atención")
        Else
            objG.GuardarZona(TxtNombreZona.Text, TxtUbicacion.Text)
            FrmConsultarZonas.dtgvZonas.Refresh()
            Dim objCon As New ConsultasDataView
            objCon.ConsultarZonas()
        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dispose()
    End Sub

    Private Sub TxtBuscadorAlmacen_KeyPress(ByVal sender As Object,
             ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBuscadorAlmacen.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Dim obj As New ConsultasDataView
            obj.BuscarAlmacen(TxtBuscadorAlmacen.Text.ToUpper)
        End If

    End Sub

    Private Sub DtgvAlmacen_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgvAlmacen.CellDoubleClick
        Dim Fila As Integer = e.RowIndex
        Dim Columna As Integer = e.ColumnIndex
        TabZona.SelectedIndex = 0
        Try
            TxtUbicacion.Text = DtgvAlmacen.Rows(Fila).Cells(Columna).Value.ToString()
        Catch ex As Exception
        End Try
    End Sub
End Class