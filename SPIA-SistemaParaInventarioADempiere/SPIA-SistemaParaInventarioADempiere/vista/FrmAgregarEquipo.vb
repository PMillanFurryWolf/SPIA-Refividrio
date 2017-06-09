Imports Npgsql
Public Class FrmAgregarEquipo
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        LlenarCombo()
    End Sub

    Friend Sub LlenarCombo()
        Dim objConexion As New ConexionDB
        Dim lector As NpgsqlDataReader
        Dim comando As New NpgsqlCommand("select * from usuario where nivel='equipo'", objConexion.ConectarSPI())

        lector = comando.ExecuteReader()
        While lector.Read()
            cmbUsuario.Items.Add(lector("usuario"))
        End While
        lector.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim objAgregar As New GuardadoDB
        If txtNombreEquipo.Text.Trim = "" Or txtResponsable.Text.Trim = "" Or txtResponsable.Text.Trim = "" Or txtAyudante.Text.Trim = "" Or cmbUsuario.SelectedIndex + 1 = 0 Then
            MsgBox("No dejar campos vacíos", vbExclamation, "Campos vacíos")
        Else
            Dim objg As New GuardadoDB
            objg.GuardarEquipo(txtNombreEquipo.Text, txtNombreEquipo.Text, txtResponsable.Text, txtAyudante.Text, ActualizarCombo())
            Dim obj As New ConsultasDataView
            obj.ConsultarEquipo("")
            FrmConsultarEquipo.dtvDatos.Refresh()
            Dispose()
        End If
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregarUsuario.Click
        FrmAgregarUsuario.Show()
        Dim obj As New ConsultasDataView
        obj.ConsultarUsuario()
    End Sub

    Private Sub cmbUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUsuario.SelectedIndexChanged
        ActualizarCombo()
    End Sub

    Friend Function ActualizarCombo() As Integer
        Dim valor As Integer
        Try
            Dim objConexion As New ConexionDB
            Dim query As String = "select id_usuario from usuario where usuario='" & cmbUsuario.Text & "'and nivel='equipo'"
            Dim comando As New NpgsqlCommand(query, objConexion.ConectarSPI())
            Dim lector As NpgsqlDataReader
            lector = comando.ExecuteReader
            If lector.Read Then
                valor = lector("id_usuario")
            End If
            lector.Close()
            Return valor
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
        Return 0
    End Function
End Class