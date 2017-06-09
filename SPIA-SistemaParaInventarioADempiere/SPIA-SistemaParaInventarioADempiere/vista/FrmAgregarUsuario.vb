Public Class FrmAgregarUsuario
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        LLenarComboUsuario()
        BloquearControles()
    End Sub

    Private Sub LiberarControles()
        LbId.Visible = False
        LLenarComboUsuario()
        BtnActualizar.Enabled = True
        BtnEliminar.Enabled = True
        TxtUsuarioUp.Enabled = True
        TxtContrasenaUp.Enabled = True
        CmbNivelUp.Enabled = True

    End Sub
    Private Sub BloquearControles()
        BtnActualizar.Enabled = False
        BtnEliminar.Enabled = False
        TxtUsuarioUp.Text = ""
        TxtContrasenaUp.Text = ""
        TxtUsuarioUp.Enabled = False
        TxtContrasenaUp.Enabled = False
        CmbNivelUp.Enabled = False
        CmbNivelUp.Items.Clear()
    End Sub

    Private Sub LLenarComboUsuario()
        Dim arrayNivel(1) As String
        arrayNivel(0) = "administrador"
        arrayNivel(1) = "equipo"
        For Each nivel As String In arrayNivel
            cmbNivel.Items.Add(nivel)
            CmbNivelUp.Items.Add(nivel)
        Next
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim obj As New GuardadoDB
        If txtUsuario.Text.Trim = "" Or txtContrasena.Text.Trim = "" Or cmbNivel.SelectedIndex + 1 = 0 Then
            MsgBox("Favor de no dejar campos vacíos", vbExclamation, "Atención")
        Else
            obj.GuardarUsuario(txtUsuario.Text, txtContrasena.Text, cmbNivel.Text)
            'Actualizar información del combo
            FrmAgregarEquipo.cmbUsuario.Items.Clear()
            FrmAgregarEquipo.LlenarCombo()
        End If
    End Sub
    Private Sub dtgvUsuario_CellDoubleClickk(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvUsuario.CellDoubleClick
        LiberarControles()
        TabUsuario.SelectedIndex = 2
        Dim columna As Integer = e.ColumnIndex
        Dim fila As Integer = e.RowIndex
        Try
            LbId.Text = dtgvUsuario.Rows(fila).Cells(columna).Value.ToString()
            TxtUsuarioUp.Text = dtgvUsuario.Rows(fila).Cells(columna + 1).Value.ToString()
            TxtContrasenaUp.Text = dtgvUsuario.Rows(fila).Cells(columna + 2).Value.ToString()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtUsuarioUp.Text.Trim = "" Or TxtContrasenaUp.Text = "" Or CmbNivelUp.SelectedIndex + 1 = 0 Then
            MsgBox("No dejar campos vacíos", vbExclamation, "Atención")
        Else
            Dim objac As New Actualizar
            objac.ActualizarUsuarioLVL(LbId.Text, TxtUsuarioUp.Text, TxtContrasenaUp.Text, CmbNivelUp.Text)
            BloquearControles()
            RecargarDT()
            TabUsuario.SelectedIndex = 1
        End If
    End Sub

    Private Sub RecargarDT()
        Dim obj As New ConsultasDataView
        dtgvUsuario.Refresh()
        obj.ConsultarUsuario()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim res As String = MsgBox("¿Desea eliminar este usuario? :" & TxtUsuarioUp.Text, vbYesNo, "¿Eliminar?")
        If res = vbYes Then
            Dim obj As New Eliminar
            obj.EliminarUsuario(LbId.Text)
            BloquearControles()
            RecargarDT()
            TabUsuario.SelectedIndex = 1
        Else
            TabUsuario.SelectedIndex = 1
            BloquearControles()
        End If

    End Sub
End Class