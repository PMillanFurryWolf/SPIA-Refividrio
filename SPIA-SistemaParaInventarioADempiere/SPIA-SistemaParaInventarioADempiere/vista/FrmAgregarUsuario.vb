Public Class FrmAgregarUsuario
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim arrayNivel(1) As String
        arrayNivel(0) = "administrador"
        arrayNivel(1) = "equipo"
        For Each nivel As String In arrayNivel
            cmbNivel.Items.Add(nivel)
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
End Class